//Auto-generated by kalyptus. DO NOT EDIT.
namespace QScintilla {

	using System;
	using Qyoto;

	[SmokeClass("QsciLexerPerl")]
	public class QsciLexerPerl : QsciLexer, IDisposable {
 		protected QsciLexerPerl(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QsciLexerPerl), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QsciLexerPerl() {
			staticInterceptor = new SmokeInvocation(typeof(QsciLexerPerl), null);
		}
		public const int Default = 0;
		public const int Error = 1;
		public const int Comment = 2;
		public const int POD = 3;
		public const int Number = 4;
		public const int Keyword = 5;
		public const int DoubleQuotedString = 6;
		public const int SingleQuotedString = 7;
		public const int Operator = 10;
		public const int Identifier = 11;
		public const int Scalar = 12;
		public const int Array = 13;
		public const int Hash = 14;
		public const int SymbolTable = 15;
		public const int Regex = 17;
		public const int Substitution = 18;
		public const int Backticks = 20;
		public const int DataSection = 21;
		public const int HereDocumentDelimiter = 22;
		public const int SingleQuotedHereDocument = 23;
		public const int DoubleQuotedHereDocument = 24;
		public const int BacktickHereDocument = 25;
		public const int QuotedStringQ = 26;
		public const int QuotedStringQQ = 27;
		public const int QuotedStringQX = 28;
		public const int QuotedStringQR = 29;
		public const int QuotedStringQW = 30;
		public const int PODVerbatim = 31;
		public const int SubroutinePrototype = 40;
		public const int FormatIdentifier = 41;
		public const int FormatBody = 42;

		public QsciLexerPerl(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QsciLexerPerl#", "QsciLexerPerl(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public QsciLexerPerl() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QsciLexerPerl", "QsciLexerPerl()", typeof(void));
		}
		[SmokeMethod("language() const")]
		public override string Language() {
			return (string) interceptor.Invoke("language", "language() const", typeof(string));
		}
		[SmokeMethod("lexer() const")]
		public override string Lexer() {
			return (string) interceptor.Invoke("lexer", "lexer() const", typeof(string));
		}
		[SmokeMethod("braceStyle() const")]
		public override int BraceStyle() {
			return (int) interceptor.Invoke("braceStyle", "braceStyle() const", typeof(int));
		}
		[SmokeMethod("wordCharacters() const")]
		public override string WordCharacters() {
			return (string) interceptor.Invoke("wordCharacters", "wordCharacters() const", typeof(string));
		}
		[SmokeMethod("defaultColor(int) const")]
		public override QColor DefaultColor(int style) {
			return (QColor) interceptor.Invoke("defaultColor$", "defaultColor(int) const", typeof(QColor), typeof(int), style);
		}
		[SmokeMethod("defaultEolFill(int) const")]
		public override bool DefaultEolFill(int style) {
			return (bool) interceptor.Invoke("defaultEolFill$", "defaultEolFill(int) const", typeof(bool), typeof(int), style);
		}
		[SmokeMethod("defaultFont(int) const")]
		public override QFont DefaultFont(int style) {
			return (QFont) interceptor.Invoke("defaultFont$", "defaultFont(int) const", typeof(QFont), typeof(int), style);
		}
		[SmokeMethod("defaultPaper(int) const")]
		public override QColor DefaultPaper(int style) {
			return (QColor) interceptor.Invoke("defaultPaper$", "defaultPaper(int) const", typeof(QColor), typeof(int), style);
		}
		[SmokeMethod("keywords(int) const")]
		public override string Keywords(int set) {
			return (string) interceptor.Invoke("keywords$", "keywords(int) const", typeof(string), typeof(int), set);
		}
		[SmokeMethod("description(int) const")]
		public override string Description(int style) {
			return (string) interceptor.Invoke("description$", "description(int) const", typeof(string), typeof(int), style);
		}
		[SmokeMethod("refreshProperties()")]
		public override void RefreshProperties() {
			interceptor.Invoke("refreshProperties", "refreshProperties()", typeof(void));
		}
		public bool FoldComments() {
			return (bool) interceptor.Invoke("foldComments", "foldComments() const", typeof(bool));
		}
		public bool FoldCompact() {
			return (bool) interceptor.Invoke("foldCompact", "foldCompact() const", typeof(bool));
		}
		[Q_SLOT("void setFoldComments(bool)")]
		[SmokeMethod("setFoldComments(bool)")]
		public virtual void SetFoldComments(bool fold) {
			interceptor.Invoke("setFoldComments$", "setFoldComments(bool)", typeof(void), typeof(bool), fold);
		}
		[Q_SLOT("void setFoldCompact(bool)")]
		[SmokeMethod("setFoldCompact(bool)")]
		public virtual void SetFoldCompact(bool fold) {
			interceptor.Invoke("setFoldCompact$", "setFoldCompact(bool)", typeof(void), typeof(bool), fold);
		}
		[SmokeMethod("readProperties(QSettings&, const QString&)")]
		protected override bool ReadProperties(QSettings qs, string prefix) {
			return (bool) interceptor.Invoke("readProperties#$", "readProperties(QSettings&, const QString&)", typeof(bool), typeof(QSettings), qs, typeof(string), prefix);
		}
		[SmokeMethod("writeProperties(QSettings&, const QString&) const")]
		protected override bool WriteProperties(QSettings qs, string prefix) {
			return (bool) interceptor.Invoke("writeProperties#$", "writeProperties(QSettings&, const QString&) const", typeof(bool), typeof(QSettings), qs, typeof(string), prefix);
		}
		~QsciLexerPerl() {
			interceptor.Invoke("~QsciLexerPerl", "~QsciLexerPerl()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QsciLexerPerl", "~QsciLexerPerl()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQsciLexerPerlSignals Emit {
			get { return (IQsciLexerPerlSignals) Q_EMIT; }
		}
	}

	public interface IQsciLexerPerlSignals : IQsciLexerSignals {
	}
}
