﻿using ScratchScript.Core.Blocks;
using ScratchScript.Core.Frontend.Implementation;
using ScratchScript.Core.Models;
using ScratchScript.Extensions;
using ScratchScript.Helpers;
using Serilog;

namespace ScratchScript.Core.Optimizer.Backend;

public partial class ScratchIRBackendVisitor
{
    private List<ScratchVariable> _variables = new();

    private ScratchVariable GetVariable(string name)
    {
        if(_variables.All(x => x.Name != name))
            _variables.Add(new ScratchVariable {Id = NameHelper.New(name), Name = name});
        return _variables.FirstOrDefault(x => x.Name == name);
    }
    
    public override object VisitSetCommand(ScratchIRParser.SetCommandContext context)
    {
        var name = context.variableIdentifier().Identifier().GetText();
        var variable = GetVariable(name);
        var variableBlock = Data.Variable(variable);
        var value = Visit(context.expression());
        
        Log.Verbose("[Set] {Name} = {Value}", name, value);
        
        var block = Data.SetVariableTo();
        block.SetField("VARIABLE", ScratchField.FromVariableBlock(variableBlock));
        block.SetInput("VALUE", ScratchInput.New(value, block));
        UpdateBlocks(variableBlock, block, value);
        return block;
    }

    public override object VisitLoadCommand(ScratchIRParser.LoadCommandContext context)
    {
        var name = context.Identifier().GetText();
        Log.Verbose("[Load] Creating a variable named {Name}", name);
        var type = TypeHelper.ScratchTypeFromString(context.Type().GetText()[1..]);

        RegisterVariable(name, type);
        return null;
    }

    private void RegisterVariable(string name, ScratchType type)
    {
        var id = NameHelper.New(name);
        _variables.Add(new ScratchVariable
        {
            Id = id,
            Name = name,
            Type = type,
            IsList = type == ScratchType.List
        });
        if (type == ScratchType.List) Target.Lists[id] = new List<object> { name, Array.Empty<object>() };
        else Target.Variables[id] = new List<object> {name, ""};
    }

    public override object VisitVariableExpression(ScratchIRParser.VariableExpressionContext context)
    {
        var name = context.variableIdentifier().Identifier().GetText();
        var variable = GetVariable(name);
        return variable.IsList ? Data.List(variable) : Data.Variable(variable);
    }

    public override object VisitStackIndexExpression(ScratchIRParser.StackIndexExpressionContext context)
    {
        var reporter = _procedures.Last().StackIndexReporter.Clone();
        UpdateBlocks(reporter);
        return reporter;
    }
}