﻿using Antlr4.Runtime;
using Ionic.Zip;
using Newtonsoft.Json;
using ScratchScript.Core.Frontend.Implementation;
using ScratchScript.Core.Models;
using ScratchScript.Core.Optimizer.Backend;
using ScratchScript.Helpers;
using Serilog;

namespace ScratchScript.Core;

public class ProjectManager
{
    private readonly string _input;
    private readonly string _irOutput;
    private readonly string _name;
    private readonly string _output;

    private ZipFile _outputArchive;
    private Target _compiledTarget;
    private Project _project = new();

    public ProjectManager(string input, string irOutput, string output)
    {
        _input = input;
        _name = Path.GetFileNameWithoutExtension(_input);
        _irOutput = irOutput;
        _output = output;
        Log.Information("Output will be saved to {OutputPath}", _output);

        _outputArchive = new ZipFile(_output);
    }

    public bool Build()
    {
        var projectName = Path.GetFileNameWithoutExtension(_output);
        Log.Information("--- Building project {Name} ---", projectName);
        try
        {
            var ir = GetIr();
            if (!string.IsNullOrEmpty(_irOutput)) File.WriteAllText(_irOutput, ir);
            #if DEBUG
            Console.WriteLine(ir);
            Console.ReadLine();
            #endif

            //INSERT MIDDLE LAYER

            _compiledTarget = GetTarget(ir);
            ConnectionChecker.Check(_compiledTarget.Blocks.Select(x => x.Value).ToList());
            _project.LayerOrder++;
            if (!_compiledTarget.IsStage) AddStageTarget();
            _compiledTarget.LayerOrder = _project.LayerOrder;
            _project.Targets.Add(_compiledTarget);
            AddEmptyCostumes();

            Bundle();
            return true;
        }
        catch (Exception e)
        {
            //TODO: format exception
            Console.WriteLine(e);
            return false;
        }
    }

    private void AddEmptyCostumes()
    {
        var emptyCostume = CostumeHelper.GetEmptyCostume();
        foreach (var target in _project.Targets.Where(t => !t.Costumes.Any()))
        {
            Log.Verbose("Adding an empty costume to {Target}", target.Name);
            target.Costumes.Add(emptyCostume);
        }
    }

    private void AddStageTarget()
    {
        Log.Verbose("Adding a stage target");
        _project.Targets.Insert(0, new Stage
        {
            Name = "Stage",
            IsStage = true,
            LayerOrder = 0
        });
        _project.LayerOrder++;
    }

    private void Bundle()
    {
        Log.Information("--- Bundling ---");

        Log.Verbose("Writing {File}", "project.json");
        var json = JsonConvert.SerializeObject(_project, Formatting.Indented);
        _outputArchive.AddEntry("project.json", json);

        foreach (var costume in _project.Targets.SelectMany(t => t.Costumes).DistinctBy(c => c.Md5Extension))
        {
            Log.Verbose("Writing {File}", costume.Md5Extension);
            _outputArchive.AddEntry(costume.Md5Extension, costume.Data);
        }

        _outputArchive.Save(_output);
        _outputArchive.Dispose();
    }

    private string GetIr()
    {
        Log.Verbose("--- Frontend ---");
        var inputStream = new AntlrFileStream(_input);
        var lexer = new ScratchScriptLexer(inputStream);
        var tokenStream = new CommonTokenStream(lexer);
        var parser = new ScratchScriptParser(tokenStream);
        var visitor = new ScratchScriptVisitor(parser);
        visitor.Visit(parser.program());
        return visitor.Output;
    }

    private Target GetTarget(string ir)
    {
        Log.Verbose("--- Backend ---");
        var inputStream = new AntlrInputStream(ir);
        var lexer = new ScratchIRLexer(inputStream);
        var tokenStream = new CommonTokenStream(lexer);
        var parser = new ScratchIRParser(tokenStream);
        var visitor = new ScratchIRBackendVisitor(_name);
        visitor.Visit(parser.program());
        return visitor.Target;
    }
}