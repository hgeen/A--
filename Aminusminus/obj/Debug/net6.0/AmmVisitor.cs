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
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="AmmParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IAmmVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>parenthesizedExpression</c>
	/// labeled alternative in <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParenthesizedExpression([NotNull] AmmParser.ParenthesizedExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstantExpression([NotNull] AmmParser.ConstantExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifierExpression([NotNull] AmmParser.IdentifierExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionCallExpression([NotNull] AmmParser.FunctionCallExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>addititveExpression</c>
	/// labeled alternative in <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddititveExpression([NotNull] AmmParser.AddititveExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNotExpression([NotNull] AmmParser.NotExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>comparisonExpression</c>
	/// labeled alternative in <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComparisonExpression([NotNull] AmmParser.ComparisonExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>multiplicativeExpression</c>
	/// labeled alternative in <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiplicativeExpression([NotNull] AmmParser.MultiplicativeExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>booleanExpression</c>
	/// labeled alternative in <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBooleanExpression([NotNull] AmmParser.BooleanExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AmmParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] AmmParser.ProgramContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AmmParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLine([NotNull] AmmParser.LineContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AmmParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] AmmParser.StatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AmmParser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfBlock([NotNull] AmmParser.IfBlockContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AmmParser.elseIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElseIfBlock([NotNull] AmmParser.ElseIfBlockContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AmmParser.whileBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileBlock([NotNull] AmmParser.WhileBlockContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AmmParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignment([NotNull] AmmParser.AssignmentContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AmmParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionCall([NotNull] AmmParser.FunctionCallContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AmmParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] AmmParser.ExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AmmParser.multOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultOp([NotNull] AmmParser.MultOpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AmmParser.addOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddOp([NotNull] AmmParser.AddOpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AmmParser.compareOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompareOp([NotNull] AmmParser.CompareOpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AmmParser.boolOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolOp([NotNull] AmmParser.BoolOpContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AmmParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstant([NotNull] AmmParser.ConstantContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="AmmParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlock([NotNull] AmmParser.BlockContext context);
}
} // namespace Aminusminus.Content
