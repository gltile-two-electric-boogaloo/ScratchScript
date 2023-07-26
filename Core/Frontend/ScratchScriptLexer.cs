//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.12.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ../ScratchScript.g4 by ANTLR 4.12.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.CLSCompliant(false)]
public partial class ScratchScriptLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		Whitespace=1, NewLine=2, Semicolon=3, LeftParen=4, RightParen=5, LeftBracket=6, 
		RightBracket=7, LeftBrace=8, RightBrace=9, Assignment=10, Comma=11, Not=12, 
		Arrow=13, Colon=14, Dot=15, Ternary=16, SingleLineCommentStart=17, MultiLineCommentStart=18, 
		MultiLineCommentEnd=19, Comment=20, At=21, Hashtag=22, Multiply=23, Plus=24, 
		Minus=25, Divide=26, Power=27, Modulus=28, And=29, Or=30, BitwiseAnd=31, 
		BitwiseOr=32, BitwiseXor=33, LeftShift=34, RightShift=35, Greater=36, 
		Lesser=37, GreaterOrEqual=38, LesserOrEqual=39, Equal=40, NotEqual=41, 
		AdditionAsignment=42, SubtractionAssignment=43, MultiplicationAssignment=44, 
		DivisionAssignment=45, ModulusAssignment=46, If=47, Else=48, True=49, 
		False=50, Break=51, Continue=52, Default=53, Case=54, Switch=55, While=56, 
		VariableDeclare=57, Import=58, ProcedureDeclare=59, Return=60, Repeat=61, 
		Event=62, From=63, Namespace=64, Number=65, Identifier=66, String=67, 
		Color=68;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"Digit", "HexDigit", "Whitespace", "NewLine", "Semicolon", "LeftParen", 
		"RightParen", "LeftBracket", "RightBracket", "LeftBrace", "RightBrace", 
		"Assignment", "Comma", "Not", "Arrow", "Colon", "Dot", "Ternary", "SingleLineCommentStart", 
		"MultiLineCommentStart", "MultiLineCommentEnd", "Comment", "At", "Hashtag", 
		"Multiply", "Plus", "Minus", "Divide", "Power", "Modulus", "And", "Or", 
		"BitwiseAnd", "BitwiseOr", "BitwiseXor", "LeftShift", "RightShift", "Greater", 
		"Lesser", "GreaterOrEqual", "LesserOrEqual", "Equal", "NotEqual", "AdditionAsignment", 
		"SubtractionAssignment", "MultiplicationAssignment", "DivisionAssignment", 
		"ModulusAssignment", "If", "Else", "True", "False", "Break", "Continue", 
		"Default", "Case", "Switch", "While", "VariableDeclare", "Import", "ProcedureDeclare", 
		"Return", "Repeat", "Event", "From", "Namespace", "Number", "Identifier", 
		"String", "Color"
	};


	public ScratchScriptLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public ScratchScriptLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, "';'", "'('", "')'", "'['", "']'", "'{'", "'}'", "'='", 
		"','", "'!'", "'->'", "':'", "'.'", "'?'", "'//'", "'/*'", "'*/'", null, 
		"'@'", "'#'", "'*'", "'+'", "'-'", "'/'", "'**'", "'%'", "'&&'", "'||'", 
		"'&'", "'|'", "'^'", "'<<'", "'>>'", "'>'", "'<'", "'>='", "'<='", "'=='", 
		"'!='", "'+='", "'-='", "'*='", "'/='", "'%='", null, "'else'", "'true'", 
		"'false'", "'break'", "'continue'", "'default'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "Whitespace", "NewLine", "Semicolon", "LeftParen", "RightParen", 
		"LeftBracket", "RightBracket", "LeftBrace", "RightBrace", "Assignment", 
		"Comma", "Not", "Arrow", "Colon", "Dot", "Ternary", "SingleLineCommentStart", 
		"MultiLineCommentStart", "MultiLineCommentEnd", "Comment", "At", "Hashtag", 
		"Multiply", "Plus", "Minus", "Divide", "Power", "Modulus", "And", "Or", 
		"BitwiseAnd", "BitwiseOr", "BitwiseXor", "LeftShift", "RightShift", "Greater", 
		"Lesser", "GreaterOrEqual", "LesserOrEqual", "Equal", "NotEqual", "AdditionAsignment", 
		"SubtractionAssignment", "MultiplicationAssignment", "DivisionAssignment", 
		"ModulusAssignment", "If", "Else", "True", "False", "Break", "Continue", 
		"Default", "Case", "Switch", "While", "VariableDeclare", "Import", "ProcedureDeclare", 
		"Return", "Repeat", "Event", "From", "Namespace", "Number", "Identifier", 
		"String", "Color"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "ScratchScript.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static ScratchScriptLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,68,499,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,7,34,2,35,
		7,35,2,36,7,36,2,37,7,37,2,38,7,38,2,39,7,39,2,40,7,40,2,41,7,41,2,42,
		7,42,2,43,7,43,2,44,7,44,2,45,7,45,2,46,7,46,2,47,7,47,2,48,7,48,2,49,
		7,49,2,50,7,50,2,51,7,51,2,52,7,52,2,53,7,53,2,54,7,54,2,55,7,55,2,56,
		7,56,2,57,7,57,2,58,7,58,2,59,7,59,2,60,7,60,2,61,7,61,2,62,7,62,2,63,
		7,63,2,64,7,64,2,65,7,65,2,66,7,66,2,67,7,67,2,68,7,68,2,69,7,69,1,0,1,
		0,1,1,1,1,1,2,1,2,1,2,1,2,1,3,3,3,151,8,3,1,3,1,3,3,3,155,8,3,1,3,1,3,
		1,4,1,4,1,5,1,5,1,6,1,6,1,7,1,7,1,8,1,8,1,9,1,9,1,10,1,10,1,11,1,11,1,
		12,1,12,1,13,1,13,1,14,1,14,1,14,1,15,1,15,1,16,1,16,1,17,1,17,1,18,1,
		18,1,18,1,19,1,19,1,19,1,20,1,20,1,20,1,21,1,21,1,21,5,21,200,8,21,10,
		21,12,21,203,9,21,1,21,1,21,5,21,207,8,21,10,21,12,21,210,9,21,1,21,1,
		21,3,21,214,8,21,1,22,1,22,1,23,1,23,1,24,1,24,1,25,1,25,1,26,1,26,1,27,
		1,27,1,28,1,28,1,28,1,29,1,29,1,30,1,30,1,30,1,31,1,31,1,31,1,32,1,32,
		1,33,1,33,1,34,1,34,1,35,1,35,1,35,1,36,1,36,1,36,1,37,1,37,1,38,1,38,
		1,39,1,39,1,39,1,40,1,40,1,40,1,41,1,41,1,41,1,42,1,42,1,42,1,43,1,43,
		1,43,1,44,1,44,1,44,1,45,1,45,1,45,1,46,1,46,1,46,1,47,1,47,1,47,1,48,
		1,48,1,48,1,48,4,48,286,8,48,11,48,12,48,287,1,49,1,49,1,49,1,49,1,49,
		1,50,1,50,1,50,1,50,1,50,1,51,1,51,1,51,1,51,1,51,1,51,1,52,1,52,1,52,
		1,52,1,52,1,52,1,53,1,53,1,53,1,53,1,53,1,53,1,53,1,53,1,53,1,54,1,54,
		1,54,1,54,1,54,1,54,1,54,1,54,1,55,1,55,1,55,1,55,1,55,1,55,4,55,335,8,
		55,11,55,12,55,336,1,56,1,56,1,56,1,56,1,56,1,56,1,56,1,56,4,56,347,8,
		56,11,56,12,56,348,1,57,1,57,1,57,1,57,1,57,1,57,1,57,4,57,358,8,57,11,
		57,12,57,359,1,58,1,58,1,58,1,58,1,58,4,58,367,8,58,11,58,12,58,368,1,
		59,1,59,1,59,1,59,1,59,1,59,1,59,1,59,4,59,379,8,59,11,59,12,59,380,1,
		60,1,60,1,60,1,60,1,60,1,60,1,60,1,60,1,60,1,60,4,60,393,8,60,11,60,12,
		60,394,1,61,1,61,1,61,1,61,1,61,1,61,1,61,1,61,4,61,405,8,61,11,61,12,
		61,406,1,62,1,62,1,62,1,62,1,62,1,62,1,62,1,62,4,62,417,8,62,11,62,12,
		62,418,1,63,1,63,1,63,1,63,4,63,425,8,63,11,63,12,63,426,1,64,1,64,1,64,
		1,64,1,64,1,64,4,64,435,8,64,11,64,12,64,436,1,65,1,65,1,65,1,65,1,65,
		1,65,1,65,1,65,1,65,1,65,1,65,4,65,450,8,65,11,65,12,65,451,1,66,4,66,
		455,8,66,11,66,12,66,456,1,66,1,66,4,66,461,8,66,11,66,12,66,462,3,66,
		465,8,66,1,67,1,67,5,67,469,8,67,10,67,12,67,472,9,67,1,68,1,68,5,68,476,
		8,68,10,68,12,68,479,9,68,1,68,1,68,1,68,5,68,484,8,68,10,68,12,68,487,
		9,68,1,68,3,68,490,8,68,1,69,1,69,1,69,1,69,1,69,1,69,1,69,1,69,1,208,
		0,70,1,0,3,0,5,1,7,2,9,3,11,4,13,5,15,6,17,7,19,8,21,9,23,10,25,11,27,
		12,29,13,31,14,33,15,35,16,37,17,39,18,41,19,43,20,45,21,47,22,49,23,51,
		24,53,25,55,26,57,27,59,28,61,29,63,30,65,31,67,32,69,33,71,34,73,35,75,
		36,77,37,79,38,81,39,83,40,85,41,87,42,89,43,91,44,93,45,95,46,97,47,99,
		48,101,49,103,50,105,51,107,52,109,53,111,54,113,55,115,56,117,57,119,
		58,121,59,123,60,125,61,127,62,129,63,131,64,133,65,135,66,137,67,139,
		68,1,0,9,1,0,48,57,3,0,48,57,65,70,97,102,2,0,9,9,32,32,2,0,10,10,13,13,
		1,0,46,46,3,0,65,90,95,95,97,122,4,0,48,57,65,90,95,95,97,122,1,0,34,34,
		1,0,39,39,521,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,0,0,13,1,
		0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,0,0,0,21,1,0,0,0,0,23,1,0,0,0,
		0,25,1,0,0,0,0,27,1,0,0,0,0,29,1,0,0,0,0,31,1,0,0,0,0,33,1,0,0,0,0,35,
		1,0,0,0,0,37,1,0,0,0,0,39,1,0,0,0,0,41,1,0,0,0,0,43,1,0,0,0,0,45,1,0,0,
		0,0,47,1,0,0,0,0,49,1,0,0,0,0,51,1,0,0,0,0,53,1,0,0,0,0,55,1,0,0,0,0,57,
		1,0,0,0,0,59,1,0,0,0,0,61,1,0,0,0,0,63,1,0,0,0,0,65,1,0,0,0,0,67,1,0,0,
		0,0,69,1,0,0,0,0,71,1,0,0,0,0,73,1,0,0,0,0,75,1,0,0,0,0,77,1,0,0,0,0,79,
		1,0,0,0,0,81,1,0,0,0,0,83,1,0,0,0,0,85,1,0,0,0,0,87,1,0,0,0,0,89,1,0,0,
		0,0,91,1,0,0,0,0,93,1,0,0,0,0,95,1,0,0,0,0,97,1,0,0,0,0,99,1,0,0,0,0,101,
		1,0,0,0,0,103,1,0,0,0,0,105,1,0,0,0,0,107,1,0,0,0,0,109,1,0,0,0,0,111,
		1,0,0,0,0,113,1,0,0,0,0,115,1,0,0,0,0,117,1,0,0,0,0,119,1,0,0,0,0,121,
		1,0,0,0,0,123,1,0,0,0,0,125,1,0,0,0,0,127,1,0,0,0,0,129,1,0,0,0,0,131,
		1,0,0,0,0,133,1,0,0,0,0,135,1,0,0,0,0,137,1,0,0,0,0,139,1,0,0,0,1,141,
		1,0,0,0,3,143,1,0,0,0,5,145,1,0,0,0,7,154,1,0,0,0,9,158,1,0,0,0,11,160,
		1,0,0,0,13,162,1,0,0,0,15,164,1,0,0,0,17,166,1,0,0,0,19,168,1,0,0,0,21,
		170,1,0,0,0,23,172,1,0,0,0,25,174,1,0,0,0,27,176,1,0,0,0,29,178,1,0,0,
		0,31,181,1,0,0,0,33,183,1,0,0,0,35,185,1,0,0,0,37,187,1,0,0,0,39,190,1,
		0,0,0,41,193,1,0,0,0,43,213,1,0,0,0,45,215,1,0,0,0,47,217,1,0,0,0,49,219,
		1,0,0,0,51,221,1,0,0,0,53,223,1,0,0,0,55,225,1,0,0,0,57,227,1,0,0,0,59,
		230,1,0,0,0,61,232,1,0,0,0,63,235,1,0,0,0,65,238,1,0,0,0,67,240,1,0,0,
		0,69,242,1,0,0,0,71,244,1,0,0,0,73,247,1,0,0,0,75,250,1,0,0,0,77,252,1,
		0,0,0,79,254,1,0,0,0,81,257,1,0,0,0,83,260,1,0,0,0,85,263,1,0,0,0,87,266,
		1,0,0,0,89,269,1,0,0,0,91,272,1,0,0,0,93,275,1,0,0,0,95,278,1,0,0,0,97,
		281,1,0,0,0,99,289,1,0,0,0,101,294,1,0,0,0,103,299,1,0,0,0,105,305,1,0,
		0,0,107,311,1,0,0,0,109,320,1,0,0,0,111,328,1,0,0,0,113,338,1,0,0,0,115,
		350,1,0,0,0,117,361,1,0,0,0,119,370,1,0,0,0,121,382,1,0,0,0,123,396,1,
		0,0,0,125,408,1,0,0,0,127,420,1,0,0,0,129,428,1,0,0,0,131,438,1,0,0,0,
		133,454,1,0,0,0,135,466,1,0,0,0,137,489,1,0,0,0,139,491,1,0,0,0,141,142,
		7,0,0,0,142,2,1,0,0,0,143,144,7,1,0,0,144,4,1,0,0,0,145,146,7,2,0,0,146,
		147,1,0,0,0,147,148,6,2,0,0,148,6,1,0,0,0,149,151,5,13,0,0,150,149,1,0,
		0,0,150,151,1,0,0,0,151,152,1,0,0,0,152,155,5,10,0,0,153,155,7,3,0,0,154,
		150,1,0,0,0,154,153,1,0,0,0,155,156,1,0,0,0,156,157,6,3,1,0,157,8,1,0,
		0,0,158,159,5,59,0,0,159,10,1,0,0,0,160,161,5,40,0,0,161,12,1,0,0,0,162,
		163,5,41,0,0,163,14,1,0,0,0,164,165,5,91,0,0,165,16,1,0,0,0,166,167,5,
		93,0,0,167,18,1,0,0,0,168,169,5,123,0,0,169,20,1,0,0,0,170,171,5,125,0,
		0,171,22,1,0,0,0,172,173,5,61,0,0,173,24,1,0,0,0,174,175,5,44,0,0,175,
		26,1,0,0,0,176,177,5,33,0,0,177,28,1,0,0,0,178,179,5,45,0,0,179,180,5,
		62,0,0,180,30,1,0,0,0,181,182,5,58,0,0,182,32,1,0,0,0,183,184,5,46,0,0,
		184,34,1,0,0,0,185,186,5,63,0,0,186,36,1,0,0,0,187,188,5,47,0,0,188,189,
		5,47,0,0,189,38,1,0,0,0,190,191,5,47,0,0,191,192,5,42,0,0,192,40,1,0,0,
		0,193,194,5,42,0,0,194,195,5,47,0,0,195,42,1,0,0,0,196,201,3,37,18,0,197,
		200,8,3,0,0,198,200,3,5,2,0,199,197,1,0,0,0,199,198,1,0,0,0,200,203,1,
		0,0,0,201,199,1,0,0,0,201,202,1,0,0,0,202,214,1,0,0,0,203,201,1,0,0,0,
		204,208,3,39,19,0,205,207,9,0,0,0,206,205,1,0,0,0,207,210,1,0,0,0,208,
		209,1,0,0,0,208,206,1,0,0,0,209,211,1,0,0,0,210,208,1,0,0,0,211,212,3,
		41,20,0,212,214,1,0,0,0,213,196,1,0,0,0,213,204,1,0,0,0,214,44,1,0,0,0,
		215,216,5,64,0,0,216,46,1,0,0,0,217,218,5,35,0,0,218,48,1,0,0,0,219,220,
		5,42,0,0,220,50,1,0,0,0,221,222,5,43,0,0,222,52,1,0,0,0,223,224,5,45,0,
		0,224,54,1,0,0,0,225,226,5,47,0,0,226,56,1,0,0,0,227,228,5,42,0,0,228,
		229,5,42,0,0,229,58,1,0,0,0,230,231,5,37,0,0,231,60,1,0,0,0,232,233,5,
		38,0,0,233,234,5,38,0,0,234,62,1,0,0,0,235,236,5,124,0,0,236,237,5,124,
		0,0,237,64,1,0,0,0,238,239,5,38,0,0,239,66,1,0,0,0,240,241,5,124,0,0,241,
		68,1,0,0,0,242,243,5,94,0,0,243,70,1,0,0,0,244,245,5,60,0,0,245,246,5,
		60,0,0,246,72,1,0,0,0,247,248,5,62,0,0,248,249,5,62,0,0,249,74,1,0,0,0,
		250,251,5,62,0,0,251,76,1,0,0,0,252,253,5,60,0,0,253,78,1,0,0,0,254,255,
		5,62,0,0,255,256,5,61,0,0,256,80,1,0,0,0,257,258,5,60,0,0,258,259,5,61,
		0,0,259,82,1,0,0,0,260,261,5,61,0,0,261,262,5,61,0,0,262,84,1,0,0,0,263,
		264,5,33,0,0,264,265,5,61,0,0,265,86,1,0,0,0,266,267,5,43,0,0,267,268,
		5,61,0,0,268,88,1,0,0,0,269,270,5,45,0,0,270,271,5,61,0,0,271,90,1,0,0,
		0,272,273,5,42,0,0,273,274,5,61,0,0,274,92,1,0,0,0,275,276,5,47,0,0,276,
		277,5,61,0,0,277,94,1,0,0,0,278,279,5,37,0,0,279,280,5,61,0,0,280,96,1,
		0,0,0,281,282,5,105,0,0,282,283,5,102,0,0,283,285,1,0,0,0,284,286,3,5,
		2,0,285,284,1,0,0,0,286,287,1,0,0,0,287,285,1,0,0,0,287,288,1,0,0,0,288,
		98,1,0,0,0,289,290,5,101,0,0,290,291,5,108,0,0,291,292,5,115,0,0,292,293,
		5,101,0,0,293,100,1,0,0,0,294,295,5,116,0,0,295,296,5,114,0,0,296,297,
		5,117,0,0,297,298,5,101,0,0,298,102,1,0,0,0,299,300,5,102,0,0,300,301,
		5,97,0,0,301,302,5,108,0,0,302,303,5,115,0,0,303,304,5,101,0,0,304,104,
		1,0,0,0,305,306,5,98,0,0,306,307,5,114,0,0,307,308,5,101,0,0,308,309,5,
		97,0,0,309,310,5,107,0,0,310,106,1,0,0,0,311,312,5,99,0,0,312,313,5,111,
		0,0,313,314,5,110,0,0,314,315,5,116,0,0,315,316,5,105,0,0,316,317,5,110,
		0,0,317,318,5,117,0,0,318,319,5,101,0,0,319,108,1,0,0,0,320,321,5,100,
		0,0,321,322,5,101,0,0,322,323,5,102,0,0,323,324,5,97,0,0,324,325,5,117,
		0,0,325,326,5,108,0,0,326,327,5,116,0,0,327,110,1,0,0,0,328,329,5,99,0,
		0,329,330,5,97,0,0,330,331,5,115,0,0,331,332,5,101,0,0,332,334,1,0,0,0,
		333,335,3,5,2,0,334,333,1,0,0,0,335,336,1,0,0,0,336,334,1,0,0,0,336,337,
		1,0,0,0,337,112,1,0,0,0,338,339,5,115,0,0,339,340,5,119,0,0,340,341,5,
		105,0,0,341,342,5,116,0,0,342,343,5,99,0,0,343,344,5,104,0,0,344,346,1,
		0,0,0,345,347,3,5,2,0,346,345,1,0,0,0,347,348,1,0,0,0,348,346,1,0,0,0,
		348,349,1,0,0,0,349,114,1,0,0,0,350,351,5,119,0,0,351,352,5,104,0,0,352,
		353,5,105,0,0,353,354,5,108,0,0,354,355,5,101,0,0,355,357,1,0,0,0,356,
		358,3,5,2,0,357,356,1,0,0,0,358,359,1,0,0,0,359,357,1,0,0,0,359,360,1,
		0,0,0,360,116,1,0,0,0,361,362,5,118,0,0,362,363,5,97,0,0,363,364,5,114,
		0,0,364,366,1,0,0,0,365,367,3,5,2,0,366,365,1,0,0,0,367,368,1,0,0,0,368,
		366,1,0,0,0,368,369,1,0,0,0,369,118,1,0,0,0,370,371,5,105,0,0,371,372,
		5,109,0,0,372,373,5,112,0,0,373,374,5,111,0,0,374,375,5,114,0,0,375,376,
		5,116,0,0,376,378,1,0,0,0,377,379,3,5,2,0,378,377,1,0,0,0,379,380,1,0,
		0,0,380,378,1,0,0,0,380,381,1,0,0,0,381,120,1,0,0,0,382,383,5,102,0,0,
		383,384,5,117,0,0,384,385,5,110,0,0,385,386,5,99,0,0,386,387,5,116,0,0,
		387,388,5,105,0,0,388,389,5,111,0,0,389,390,5,110,0,0,390,392,1,0,0,0,
		391,393,3,5,2,0,392,391,1,0,0,0,393,394,1,0,0,0,394,392,1,0,0,0,394,395,
		1,0,0,0,395,122,1,0,0,0,396,397,5,114,0,0,397,398,5,101,0,0,398,399,5,
		116,0,0,399,400,5,117,0,0,400,401,5,114,0,0,401,402,5,110,0,0,402,404,
		1,0,0,0,403,405,3,5,2,0,404,403,1,0,0,0,405,406,1,0,0,0,406,404,1,0,0,
		0,406,407,1,0,0,0,407,124,1,0,0,0,408,409,5,114,0,0,409,410,5,101,0,0,
		410,411,5,112,0,0,411,412,5,101,0,0,412,413,5,97,0,0,413,414,5,116,0,0,
		414,416,1,0,0,0,415,417,3,5,2,0,416,415,1,0,0,0,417,418,1,0,0,0,418,416,
		1,0,0,0,418,419,1,0,0,0,419,126,1,0,0,0,420,421,5,111,0,0,421,422,5,110,
		0,0,422,424,1,0,0,0,423,425,3,5,2,0,424,423,1,0,0,0,425,426,1,0,0,0,426,
		424,1,0,0,0,426,427,1,0,0,0,427,128,1,0,0,0,428,429,5,102,0,0,429,430,
		5,114,0,0,430,431,5,111,0,0,431,432,5,109,0,0,432,434,1,0,0,0,433,435,
		3,5,2,0,434,433,1,0,0,0,435,436,1,0,0,0,436,434,1,0,0,0,436,437,1,0,0,
		0,437,130,1,0,0,0,438,439,5,110,0,0,439,440,5,97,0,0,440,441,5,109,0,0,
		441,442,5,101,0,0,442,443,5,115,0,0,443,444,5,112,0,0,444,445,5,97,0,0,
		445,446,5,99,0,0,446,447,5,101,0,0,447,449,1,0,0,0,448,450,3,5,2,0,449,
		448,1,0,0,0,450,451,1,0,0,0,451,449,1,0,0,0,451,452,1,0,0,0,452,132,1,
		0,0,0,453,455,3,1,0,0,454,453,1,0,0,0,455,456,1,0,0,0,456,454,1,0,0,0,
		456,457,1,0,0,0,457,464,1,0,0,0,458,460,7,4,0,0,459,461,3,1,0,0,460,459,
		1,0,0,0,461,462,1,0,0,0,462,460,1,0,0,0,462,463,1,0,0,0,463,465,1,0,0,
		0,464,458,1,0,0,0,464,465,1,0,0,0,465,134,1,0,0,0,466,470,7,5,0,0,467,
		469,7,6,0,0,468,467,1,0,0,0,469,472,1,0,0,0,470,468,1,0,0,0,470,471,1,
		0,0,0,471,136,1,0,0,0,472,470,1,0,0,0,473,477,5,34,0,0,474,476,8,7,0,0,
		475,474,1,0,0,0,476,479,1,0,0,0,477,475,1,0,0,0,477,478,1,0,0,0,478,480,
		1,0,0,0,479,477,1,0,0,0,480,490,5,34,0,0,481,485,5,39,0,0,482,484,8,8,
		0,0,483,482,1,0,0,0,484,487,1,0,0,0,485,483,1,0,0,0,485,486,1,0,0,0,486,
		488,1,0,0,0,487,485,1,0,0,0,488,490,5,39,0,0,489,473,1,0,0,0,489,481,1,
		0,0,0,490,138,1,0,0,0,491,492,3,47,23,0,492,493,3,3,1,0,493,494,3,3,1,
		0,494,495,3,3,1,0,495,496,3,3,1,0,496,497,3,3,1,0,497,498,3,3,1,0,498,
		140,1,0,0,0,26,0,150,154,199,201,208,213,287,336,348,359,368,380,394,406,
		418,426,436,451,456,462,464,470,477,485,489,2,0,1,0,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
