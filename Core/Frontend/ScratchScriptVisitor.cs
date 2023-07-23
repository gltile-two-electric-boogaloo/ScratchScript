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

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="ScratchScriptParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.CLSCompliant(false)]
public interface IScratchScriptVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] ScratchScriptParser.ProgramContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.topLevelStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTopLevelStatement([NotNull] ScratchScriptParser.TopLevelStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLine([NotNull] ScratchScriptParser.LineContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] ScratchScriptParser.StatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.eventStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEventStatement([NotNull] ScratchScriptParser.EventStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.assignmentStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignmentStatement([NotNull] ScratchScriptParser.AssignmentStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.variableDeclarationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableDeclarationStatement([NotNull] ScratchScriptParser.VariableDeclarationStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.memberProcedureCallStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMemberProcedureCallStatement([NotNull] ScratchScriptParser.MemberProcedureCallStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.procedureCallStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProcedureCallStatement([NotNull] ScratchScriptParser.ProcedureCallStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.procedureDeclarationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProcedureDeclarationStatement([NotNull] ScratchScriptParser.ProcedureDeclarationStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfStatement([NotNull] ScratchScriptParser.IfStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.whileStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileStatement([NotNull] ScratchScriptParser.WhileStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.elseIfStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElseIfStatement([NotNull] ScratchScriptParser.ElseIfStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.importStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitImportStatement([NotNull] ScratchScriptParser.ImportStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.attributeStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAttributeStatement([NotNull] ScratchScriptParser.AttributeStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReturnStatement([NotNull] ScratchScriptParser.ReturnStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.repeatStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRepeatStatement([NotNull] ScratchScriptParser.RepeatStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.breakStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBreakStatement([NotNull] ScratchScriptParser.BreakStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.continueStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitContinueStatement([NotNull] ScratchScriptParser.ContinueStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.namespaceStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNamespaceStatement([NotNull] ScratchScriptParser.NamespaceStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.switchStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSwitchStatement([NotNull] ScratchScriptParser.SwitchStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.procedureArgument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProcedureArgument([NotNull] ScratchScriptParser.ProcedureArgumentContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="ScratchScriptParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstantExpression([NotNull] ScratchScriptParser.ConstantExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="ScratchScriptParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifierExpression([NotNull] ScratchScriptParser.IdentifierExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="ScratchScriptParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNotExpression([NotNull] ScratchScriptParser.NotExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>binaryMultiplyExpression</c>
	/// labeled alternative in <see cref="ScratchScriptParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBinaryMultiplyExpression([NotNull] ScratchScriptParser.BinaryMultiplyExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>unaryAddExpression</c>
	/// labeled alternative in <see cref="ScratchScriptParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnaryAddExpression([NotNull] ScratchScriptParser.UnaryAddExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>arrayAccessExpression</c>
	/// labeled alternative in <see cref="ScratchScriptParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayAccessExpression([NotNull] ScratchScriptParser.ArrayAccessExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>parenthesizedExpression</c>
	/// labeled alternative in <see cref="ScratchScriptParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParenthesizedExpression([NotNull] ScratchScriptParser.ParenthesizedExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>procedureCallExpression</c>
	/// labeled alternative in <see cref="ScratchScriptParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProcedureCallExpression([NotNull] ScratchScriptParser.ProcedureCallExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>binaryBooleanExpression</c>
	/// labeled alternative in <see cref="ScratchScriptParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBinaryBooleanExpression([NotNull] ScratchScriptParser.BinaryBooleanExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>binaryCompareExpression</c>
	/// labeled alternative in <see cref="ScratchScriptParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBinaryCompareExpression([NotNull] ScratchScriptParser.BinaryCompareExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ternaryExpression</c>
	/// labeled alternative in <see cref="ScratchScriptParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTernaryExpression([NotNull] ScratchScriptParser.TernaryExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>binaryAddExpression</c>
	/// labeled alternative in <see cref="ScratchScriptParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBinaryAddExpression([NotNull] ScratchScriptParser.BinaryAddExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>memberProcedureCallExpression</c>
	/// labeled alternative in <see cref="ScratchScriptParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMemberProcedureCallExpression([NotNull] ScratchScriptParser.MemberProcedureCallExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.multiplyOperators"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiplyOperators([NotNull] ScratchScriptParser.MultiplyOperatorsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.addOperators"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddOperators([NotNull] ScratchScriptParser.AddOperatorsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.compareOperators"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompareOperators([NotNull] ScratchScriptParser.CompareOperatorsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.booleanOperators"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBooleanOperators([NotNull] ScratchScriptParser.BooleanOperatorsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.assignmentOperators"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignmentOperators([NotNull] ScratchScriptParser.AssignmentOperatorsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.case"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCase([NotNull] ScratchScriptParser.CaseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlock([NotNull] ScratchScriptParser.BlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.switchBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSwitchBlock([NotNull] ScratchScriptParser.SwitchBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.defaultCase"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefaultCase([NotNull] ScratchScriptParser.DefaultCaseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstant([NotNull] ScratchScriptParser.ConstantContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.comment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComment([NotNull] ScratchScriptParser.CommentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ScratchScriptParser.boolean"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolean([NotNull] ScratchScriptParser.BooleanContext context);
}
