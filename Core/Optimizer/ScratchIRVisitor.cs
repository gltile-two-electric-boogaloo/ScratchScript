//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.12.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ../ScratchIR.g4 by ANTLR 4.12.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="ScratchIRParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.CLSCompliant(false)]
public interface IScratchIRVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchIRParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] ScratchIRParser.ProgramContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>setCommand</c>
	/// labeled alternative in <see cref="ScratchIRParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSetCommand([NotNull] ScratchIRParser.SetCommandContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>whileCommand</c>
	/// labeled alternative in <see cref="ScratchIRParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileCommand([NotNull] ScratchIRParser.WhileCommandContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>repeatCommand</c>
	/// labeled alternative in <see cref="ScratchIRParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRepeatCommand([NotNull] ScratchIRParser.RepeatCommandContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ifCommand</c>
	/// labeled alternative in <see cref="ScratchIRParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfCommand([NotNull] ScratchIRParser.IfCommandContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>callCommand</c>
	/// labeled alternative in <see cref="ScratchIRParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCallCommand([NotNull] ScratchIRParser.CallCommandContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>rawCommand</c>
	/// labeled alternative in <see cref="ScratchIRParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRawCommand([NotNull] ScratchIRParser.RawCommandContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pushCommand</c>
	/// labeled alternative in <see cref="ScratchIRParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPushCommand([NotNull] ScratchIRParser.PushCommandContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>pushAtCommand</c>
	/// labeled alternative in <see cref="ScratchIRParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPushAtCommand([NotNull] ScratchIRParser.PushAtCommandContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>popCommand</c>
	/// labeled alternative in <see cref="ScratchIRParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPopCommand([NotNull] ScratchIRParser.PopCommandContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>popAtCommand</c>
	/// labeled alternative in <see cref="ScratchIRParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPopAtCommand([NotNull] ScratchIRParser.PopAtCommandContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>popAllCommand</c>
	/// labeled alternative in <see cref="ScratchIRParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPopAllCommand([NotNull] ScratchIRParser.PopAllCommandContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>loadCommand</c>
	/// labeled alternative in <see cref="ScratchIRParser.topLevelCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLoadCommand([NotNull] ScratchIRParser.LoadCommandContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>procedureBlock</c>
	/// labeled alternative in <see cref="ScratchIRParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProcedureBlock([NotNull] ScratchIRParser.ProcedureBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>eventBlock</c>
	/// labeled alternative in <see cref="ScratchIRParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEventBlock([NotNull] ScratchIRParser.EventBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>topLevelBlock</c>
	/// labeled alternative in <see cref="ScratchIRParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTopLevelBlock([NotNull] ScratchIRParser.TopLevelBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="ScratchIRParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstantExpression([NotNull] ScratchIRParser.ConstantExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>variableExpression</c>
	/// labeled alternative in <see cref="ScratchIRParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableExpression([NotNull] ScratchIRParser.VariableExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>stackIndexExpression</c>
	/// labeled alternative in <see cref="ScratchIRParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStackIndexExpression([NotNull] ScratchIRParser.StackIndexExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>arrayExpression</c>
	/// labeled alternative in <see cref="ScratchIRParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayExpression([NotNull] ScratchIRParser.ArrayExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>parenthesizedExpression</c>
	/// labeled alternative in <see cref="ScratchIRParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParenthesizedExpression([NotNull] ScratchIRParser.ParenthesizedExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>binaryAddExpression</c>
	/// labeled alternative in <see cref="ScratchIRParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBinaryAddExpression([NotNull] ScratchIRParser.BinaryAddExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>binaryMultiplyExpression</c>
	/// labeled alternative in <see cref="ScratchIRParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBinaryMultiplyExpression([NotNull] ScratchIRParser.BinaryMultiplyExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>binaryBooleanExpression</c>
	/// labeled alternative in <see cref="ScratchIRParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBinaryBooleanExpression([NotNull] ScratchIRParser.BinaryBooleanExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>binaryCompareExpression</c>
	/// labeled alternative in <see cref="ScratchIRParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBinaryCompareExpression([NotNull] ScratchIRParser.BinaryCompareExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>rawShadowExpression</c>
	/// labeled alternative in <see cref="ScratchIRParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRawShadowExpression([NotNull] ScratchIRParser.RawShadowExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="ScratchIRParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNotExpression([NotNull] ScratchIRParser.NotExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>listAccessExpression</c>
	/// labeled alternative in <see cref="ScratchIRParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitListAccessExpression([NotNull] ScratchIRParser.ListAccessExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchIRParser.elseIfStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElseIfStatement([NotNull] ScratchIRParser.ElseIfStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchIRParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfStatement([NotNull] ScratchIRParser.IfStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchIRParser.procedureArgument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProcedureArgument([NotNull] ScratchIRParser.ProcedureArgumentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchIRParser.callProcedureArgument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCallProcedureArgument([NotNull] ScratchIRParser.CallProcedureArgumentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchIRParser.procedureArgumentType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProcedureArgumentType([NotNull] ScratchIRParser.ProcedureArgumentTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchIRParser.variableIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableIdentifier([NotNull] ScratchIRParser.VariableIdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchIRParser.arrayIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayIdentifier([NotNull] ScratchIRParser.ArrayIdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchIRParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstant([NotNull] ScratchIRParser.ConstantContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchIRParser.procedureArgumentTypeDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProcedureArgumentTypeDeclaration([NotNull] ScratchIRParser.ProcedureArgumentTypeDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchIRParser.addOperators"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddOperators([NotNull] ScratchIRParser.AddOperatorsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchIRParser.multiplyOperators"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiplyOperators([NotNull] ScratchIRParser.MultiplyOperatorsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchIRParser.booleanOperators"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBooleanOperators([NotNull] ScratchIRParser.BooleanOperatorsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchIRParser.compareOperators"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompareOperators([NotNull] ScratchIRParser.CompareOperatorsContext context);
}
