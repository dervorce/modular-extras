//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /media/glitch/ExtraWorld/repos/ModularSkillScripts repos/ModularSkillScripts/Grammars/ModsaLanguage.g4 by ANTLR 4.13.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace ModsaLang {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="ModsaLanguageParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.2")]
[System.CLSCompliant(false)]
public interface IModsaLanguageListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="ModsaLanguageParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] ModsaLanguageParser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ModsaLanguageParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] ModsaLanguageParser.ProgramContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>AddSubExpression</c>
	/// labeled alternative in <see cref="ModsaLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddSubExpression([NotNull] ModsaLanguageParser.AddSubExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AddSubExpression</c>
	/// labeled alternative in <see cref="ModsaLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddSubExpression([NotNull] ModsaLanguageParser.AddSubExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>FunctionExpression</c>
	/// labeled alternative in <see cref="ModsaLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionExpression([NotNull] ModsaLanguageParser.FunctionExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>FunctionExpression</c>
	/// labeled alternative in <see cref="ModsaLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionExpression([NotNull] ModsaLanguageParser.FunctionExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ParenExpression</c>
	/// labeled alternative in <see cref="ModsaLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenExpression([NotNull] ModsaLanguageParser.ParenExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ParenExpression</c>
	/// labeled alternative in <see cref="ModsaLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenExpression([NotNull] ModsaLanguageParser.ParenExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NumberExpression</c>
	/// labeled alternative in <see cref="ModsaLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumberExpression([NotNull] ModsaLanguageParser.NumberExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NumberExpression</c>
	/// labeled alternative in <see cref="ModsaLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumberExpression([NotNull] ModsaLanguageParser.NumberExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>VariableExpression</c>
	/// labeled alternative in <see cref="ModsaLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableExpression([NotNull] ModsaLanguageParser.VariableExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>VariableExpression</c>
	/// labeled alternative in <see cref="ModsaLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableExpression([NotNull] ModsaLanguageParser.VariableExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>MulDivExpression</c>
	/// labeled alternative in <see cref="ModsaLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMulDivExpression([NotNull] ModsaLanguageParser.MulDivExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MulDivExpression</c>
	/// labeled alternative in <see cref="ModsaLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMulDivExpression([NotNull] ModsaLanguageParser.MulDivExpressionContext context);
}
} // namespace ModsaLang
