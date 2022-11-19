//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\stuar\Documents\VISUAL STUDIO\VSCODE\Languages\A--\Aminusminus\Content\Amm.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Aminusminus.Content {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="AmmParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IAmmListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>parenthesizedExpression</c>
	/// labeled alternative in <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenthesizedExpression([NotNull] AmmParser.ParenthesizedExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parenthesizedExpression</c>
	/// labeled alternative in <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenthesizedExpression([NotNull] AmmParser.ParenthesizedExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstantExpression([NotNull] AmmParser.ConstantExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstantExpression([NotNull] AmmParser.ConstantExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierExpression([NotNull] AmmParser.IdentifierExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierExpression([NotNull] AmmParser.IdentifierExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCallExpression([NotNull] AmmParser.FunctionCallExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCallExpression([NotNull] AmmParser.FunctionCallExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>addititveExpression</c>
	/// labeled alternative in <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddititveExpression([NotNull] AmmParser.AddititveExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>addititveExpression</c>
	/// labeled alternative in <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddititveExpression([NotNull] AmmParser.AddititveExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNotExpression([NotNull] AmmParser.NotExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNotExpression([NotNull] AmmParser.NotExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>comparisonExpression</c>
	/// labeled alternative in <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComparisonExpression([NotNull] AmmParser.ComparisonExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>comparisonExpression</c>
	/// labeled alternative in <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComparisonExpression([NotNull] AmmParser.ComparisonExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>multiplicativeExpression</c>
	/// labeled alternative in <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicativeExpression([NotNull] AmmParser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>multiplicativeExpression</c>
	/// labeled alternative in <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicativeExpression([NotNull] AmmParser.MultiplicativeExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>booleanExpression</c>
	/// labeled alternative in <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBooleanExpression([NotNull] AmmParser.BooleanExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>booleanExpression</c>
	/// labeled alternative in <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBooleanExpression([NotNull] AmmParser.BooleanExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AmmParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] AmmParser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AmmParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] AmmParser.ProgramContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AmmParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLine([NotNull] AmmParser.LineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AmmParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLine([NotNull] AmmParser.LineContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AmmParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] AmmParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AmmParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] AmmParser.StatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AmmParser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfBlock([NotNull] AmmParser.IfBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AmmParser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfBlock([NotNull] AmmParser.IfBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AmmParser.elseIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElseIfBlock([NotNull] AmmParser.ElseIfBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AmmParser.elseIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElseIfBlock([NotNull] AmmParser.ElseIfBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AmmParser.whileBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileBlock([NotNull] AmmParser.WhileBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AmmParser.whileBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileBlock([NotNull] AmmParser.WhileBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AmmParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignment([NotNull] AmmParser.AssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AmmParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignment([NotNull] AmmParser.AssignmentContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AmmParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCall([NotNull] AmmParser.FunctionCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AmmParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCall([NotNull] AmmParser.FunctionCallContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] AmmParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] AmmParser.ExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AmmParser.multOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultOp([NotNull] AmmParser.MultOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AmmParser.multOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultOp([NotNull] AmmParser.MultOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AmmParser.addOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddOp([NotNull] AmmParser.AddOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AmmParser.addOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddOp([NotNull] AmmParser.AddOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AmmParser.compareOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompareOp([NotNull] AmmParser.CompareOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AmmParser.compareOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompareOp([NotNull] AmmParser.CompareOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AmmParser.boolOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoolOp([NotNull] AmmParser.BoolOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AmmParser.boolOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoolOp([NotNull] AmmParser.BoolOpContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AmmParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstant([NotNull] AmmParser.ConstantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AmmParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstant([NotNull] AmmParser.ConstantContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AmmParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] AmmParser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AmmParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] AmmParser.BlockContext context);
}
} // namespace Aminusminus.Content
