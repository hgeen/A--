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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class AmmLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, WHILE=24, 
		INTEGER=25, FLOAT=26, STRING=27, BOOL=28, NULL=29, WS=30, IDENTIFIER=31;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "WHILE", "INTEGER", 
		"FLOAT", "STRING", "BOOL", "NULL", "WS", "IDENTIFIER"
	};


	public AmmLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "';'", "'if'", "'else'", "'='", "'('", "','", "')'", "'!'", "'*'", 
		"'/'", "'+'", "'-'", "'=='", "'!='", "'>'", "'<'", "'>='", "'<='", "'and'", 
		"'or'", "'xor'", "'{'", "'}'", null, null, null, null, null, "'null'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		"WHILE", "INTEGER", "FLOAT", "STRING", "BOOL", "NULL", "WS", "IDENTIFIER"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Amm.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2!\xC8\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x3\x2"+
		"\x3\x2\x3\x3\x3\x3\x3\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3\x5\x3"+
		"\x6\x3\x6\x3\a\x3\a\x3\b\x3\b\x3\t\x3\t\x3\n\x3\n\x3\v\x3\v\x3\f\x3\f"+
		"\x3\r\x3\r\x3\xE\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3\x11\x3"+
		"\x11\x3\x12\x3\x12\x3\x12\x3\x13\x3\x13\x3\x13\x3\x14\x3\x14\x3\x14\x3"+
		"\x14\x3\x15\x3\x15\x3\x15\x3\x16\x3\x16\x3\x16\x3\x16\x3\x17\x3\x17\x3"+
		"\x18\x3\x18\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3"+
		"\x19\x3\x19\x5\x19\x87\n\x19\x3\x1A\x6\x1A\x8A\n\x1A\r\x1A\xE\x1A\x8B"+
		"\x3\x1B\x6\x1B\x8F\n\x1B\r\x1B\xE\x1B\x90\x3\x1B\x3\x1B\x6\x1B\x95\n\x1B"+
		"\r\x1B\xE\x1B\x96\x3\x1C\x3\x1C\a\x1C\x9B\n\x1C\f\x1C\xE\x1C\x9E\v\x1C"+
		"\x3\x1C\x3\x1C\x3\x1C\a\x1C\xA3\n\x1C\f\x1C\xE\x1C\xA6\v\x1C\x3\x1C\x5"+
		"\x1C\xA9\n\x1C\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D"+
		"\x3\x1D\x5\x1D\xB4\n\x1D\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1F\x6"+
		"\x1F\xBC\n\x1F\r\x1F\xE\x1F\xBD\x3\x1F\x3\x1F\x3 \x3 \a \xC4\n \f \xE"+
		" \xC7\v \x2\x2\x2!\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF"+
		"\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10"+
		"\x1F\x2\x11!\x2\x12#\x2\x13%\x2\x14\'\x2\x15)\x2\x16+\x2\x17-\x2\x18/"+
		"\x2\x19\x31\x2\x1A\x33\x2\x1B\x35\x2\x1C\x37\x2\x1D\x39\x2\x1E;\x2\x1F"+
		"=\x2 ?\x2!\x3\x2\b\x3\x2\x32;\x3\x2$$\x3\x2))\x5\x2\v\f\xF\xF\"\"\x5\x2"+
		"\x43\\\x61\x61\x63|\x6\x2\x32;\x43\\\x61\x61\x63|\xD1\x2\x3\x3\x2\x2\x2"+
		"\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2"+
		"\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2"+
		"\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3"+
		"\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3"+
		"\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2+\x3\x2\x2"+
		"\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33\x3\x2\x2"+
		"\x2\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2\x2\x2;\x3\x2"+
		"\x2\x2\x2=\x3\x2\x2\x2\x2?\x3\x2\x2\x2\x3\x41\x3\x2\x2\x2\x5\x43\x3\x2"+
		"\x2\x2\a\x46\x3\x2\x2\x2\tK\x3\x2\x2\x2\vM\x3\x2\x2\x2\rO\x3\x2\x2\x2"+
		"\xFQ\x3\x2\x2\x2\x11S\x3\x2\x2\x2\x13U\x3\x2\x2\x2\x15W\x3\x2\x2\x2\x17"+
		"Y\x3\x2\x2\x2\x19[\x3\x2\x2\x2\x1B]\x3\x2\x2\x2\x1D`\x3\x2\x2\x2\x1F\x63"+
		"\x3\x2\x2\x2!\x65\x3\x2\x2\x2#g\x3\x2\x2\x2%j\x3\x2\x2\x2\'m\x3\x2\x2"+
		"\x2)q\x3\x2\x2\x2+t\x3\x2\x2\x2-x\x3\x2\x2\x2/z\x3\x2\x2\x2\x31\x86\x3"+
		"\x2\x2\x2\x33\x89\x3\x2\x2\x2\x35\x8E\x3\x2\x2\x2\x37\xA8\x3\x2\x2\x2"+
		"\x39\xB3\x3\x2\x2\x2;\xB5\x3\x2\x2\x2=\xBB\x3\x2\x2\x2?\xC1\x3\x2\x2\x2"+
		"\x41\x42\a=\x2\x2\x42\x4\x3\x2\x2\x2\x43\x44\ak\x2\x2\x44\x45\ah\x2\x2"+
		"\x45\x6\x3\x2\x2\x2\x46G\ag\x2\x2GH\an\x2\x2HI\au\x2\x2IJ\ag\x2\x2J\b"+
		"\x3\x2\x2\x2KL\a?\x2\x2L\n\x3\x2\x2\x2MN\a*\x2\x2N\f\x3\x2\x2\x2OP\a."+
		"\x2\x2P\xE\x3\x2\x2\x2QR\a+\x2\x2R\x10\x3\x2\x2\x2ST\a#\x2\x2T\x12\x3"+
		"\x2\x2\x2UV\a,\x2\x2V\x14\x3\x2\x2\x2WX\a\x31\x2\x2X\x16\x3\x2\x2\x2Y"+
		"Z\a-\x2\x2Z\x18\x3\x2\x2\x2[\\\a/\x2\x2\\\x1A\x3\x2\x2\x2]^\a?\x2\x2^"+
		"_\a?\x2\x2_\x1C\x3\x2\x2\x2`\x61\a#\x2\x2\x61\x62\a?\x2\x2\x62\x1E\x3"+
		"\x2\x2\x2\x63\x64\a@\x2\x2\x64 \x3\x2\x2\x2\x65\x66\a>\x2\x2\x66\"\x3"+
		"\x2\x2\x2gh\a@\x2\x2hi\a?\x2\x2i$\x3\x2\x2\x2jk\a>\x2\x2kl\a?\x2\x2l&"+
		"\x3\x2\x2\x2mn\a\x63\x2\x2no\ap\x2\x2op\a\x66\x2\x2p(\x3\x2\x2\x2qr\a"+
		"q\x2\x2rs\at\x2\x2s*\x3\x2\x2\x2tu\az\x2\x2uv\aq\x2\x2vw\at\x2\x2w,\x3"+
		"\x2\x2\x2xy\a}\x2\x2y.\x3\x2\x2\x2z{\a\x7F\x2\x2{\x30\x3\x2\x2\x2|}\a"+
		"y\x2\x2}~\aj\x2\x2~\x7F\ak\x2\x2\x7F\x80\an\x2\x2\x80\x87\ag\x2\x2\x81"+
		"\x82\aw\x2\x2\x82\x83\ap\x2\x2\x83\x84\av\x2\x2\x84\x85\ak\x2\x2\x85\x87"+
		"\an\x2\x2\x86|\x3\x2\x2\x2\x86\x81\x3\x2\x2\x2\x87\x32\x3\x2\x2\x2\x88"+
		"\x8A\t\x2\x2\x2\x89\x88\x3\x2\x2\x2\x8A\x8B\x3\x2\x2\x2\x8B\x89\x3\x2"+
		"\x2\x2\x8B\x8C\x3\x2\x2\x2\x8C\x34\x3\x2\x2\x2\x8D\x8F\t\x2\x2\x2\x8E"+
		"\x8D\x3\x2\x2\x2\x8F\x90\x3\x2\x2\x2\x90\x8E\x3\x2\x2\x2\x90\x91\x3\x2"+
		"\x2\x2\x91\x92\x3\x2\x2\x2\x92\x94\a\x30\x2\x2\x93\x95\t\x2\x2\x2\x94"+
		"\x93\x3\x2\x2\x2\x95\x96\x3\x2\x2\x2\x96\x94\x3\x2\x2\x2\x96\x97\x3\x2"+
		"\x2\x2\x97\x36\x3\x2\x2\x2\x98\x9C\a$\x2\x2\x99\x9B\n\x3\x2\x2\x9A\x99"+
		"\x3\x2\x2\x2\x9B\x9E\x3\x2\x2\x2\x9C\x9A\x3\x2\x2\x2\x9C\x9D\x3\x2\x2"+
		"\x2\x9D\x9F\x3\x2\x2\x2\x9E\x9C\x3\x2\x2\x2\x9F\xA9\a$\x2\x2\xA0\xA4\a"+
		")\x2\x2\xA1\xA3\n\x4\x2\x2\xA2\xA1\x3\x2\x2\x2\xA3\xA6\x3\x2\x2\x2\xA4"+
		"\xA2\x3\x2\x2\x2\xA4\xA5\x3\x2\x2\x2\xA5\xA7\x3\x2\x2\x2\xA6\xA4\x3\x2"+
		"\x2\x2\xA7\xA9\a)\x2\x2\xA8\x98\x3\x2\x2\x2\xA8\xA0\x3\x2\x2\x2\xA9\x38"+
		"\x3\x2\x2\x2\xAA\xAB\av\x2\x2\xAB\xAC\at\x2\x2\xAC\xAD\aw\x2\x2\xAD\xB4"+
		"\ag\x2\x2\xAE\xAF\ah\x2\x2\xAF\xB0\a\x63\x2\x2\xB0\xB1\an\x2\x2\xB1\xB2"+
		"\au\x2\x2\xB2\xB4\ag\x2\x2\xB3\xAA\x3\x2\x2\x2\xB3\xAE\x3\x2\x2\x2\xB4"+
		":\x3\x2\x2\x2\xB5\xB6\ap\x2\x2\xB6\xB7\aw\x2\x2\xB7\xB8\an\x2\x2\xB8\xB9"+
		"\an\x2\x2\xB9<\x3\x2\x2\x2\xBA\xBC\t\x5\x2\x2\xBB\xBA\x3\x2\x2\x2\xBC"+
		"\xBD\x3\x2\x2\x2\xBD\xBB\x3\x2\x2\x2\xBD\xBE\x3\x2\x2\x2\xBE\xBF\x3\x2"+
		"\x2\x2\xBF\xC0\b\x1F\x2\x2\xC0>\x3\x2\x2\x2\xC1\xC5\t\x6\x2\x2\xC2\xC4"+
		"\t\a\x2\x2\xC3\xC2\x3\x2\x2\x2\xC4\xC7\x3\x2\x2\x2\xC5\xC3\x3\x2\x2\x2"+
		"\xC5\xC6\x3\x2\x2\x2\xC6@\x3\x2\x2\x2\xC7\xC5\x3\x2\x2\x2\r\x2\x86\x8B"+
		"\x90\x96\x9C\xA4\xA8\xB3\xBD\xC5\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Aminusminus.Content
