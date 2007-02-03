//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QChar")]
	public class QChar : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QChar(Type dummy) {}
		[SmokeClass("QChar")]
		interface IQCharProxy {
			[SmokeMethod("fromAscii", "(char)", "$")]
			char FromAscii(char c);
			[SmokeMethod("fromLatin1", "(char)", "$")]
			char FromLatin1(char c);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QChar), this);
			_interceptor = (QChar) realProxy.GetTransparentProxy();
		}
		private QChar ProxyQChar() {
			return (QChar) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QChar() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQCharProxy), null);
			_staticInterceptor = (IQCharProxy) realProxy.GetTransparentProxy();
		}
		private static IQCharProxy StaticQChar() {
			return (IQCharProxy) _staticInterceptor;
		}

		public enum SpecialCharacter {
			Null = 0x0000,
			Nbsp = 0x00a0,
			ReplacementCharacter = 0xfffd,
			ObjectReplacementCharacter = 0xfffc,
			ByteOrderMark = 0xfeff,
			ByteOrderSwapped = 0xfffe,
			ParagraphSeparator = 0x2029,
			LineSeparator = 0x2028,
		}
		public enum Category {
			NoCategory = 0,
			Mark_NonSpacing = 1,
			Mark_SpacingCombining = 2,
			Mark_Enclosing = 3,
			Number_DecimalDigit = 4,
			Number_Letter = 5,
			Number_Other = 6,
			Separator_Space = 7,
			Separator_Line = 8,
			Separator_Paragraph = 9,
			Other_Control = 10,
			Other_Format = 11,
			Other_Surrogate = 12,
			Other_PrivateUse = 13,
			Other_NotAssigned = 14,
			Letter_Uppercase = 15,
			Letter_Lowercase = 16,
			Letter_Titlecase = 17,
			Letter_Modifier = 18,
			Letter_Other = 19,
			Punctuation_Connector = 20,
			Punctuation_Dash = 21,
			Punctuation_Open = 22,
			Punctuation_Close = 23,
			Punctuation_InitialQuote = 24,
			Punctuation_FinalQuote = 25,
			Punctuation_Other = 26,
			Symbol_Math = 27,
			Symbol_Currency = 28,
			Symbol_Modifier = 29,
			Symbol_Other = 30,
			Punctuation_Dask = Punctuation_Dash,
		}
		public enum Direction {
			DirL = 0,
			DirR = 1,
			DirEN = 2,
			DirES = 3,
			DirET = 4,
			DirAN = 5,
			DirCS = 6,
			DirB = 7,
			DirS = 8,
			DirWS = 9,
			DirON = 10,
			DirLRE = 11,
			DirLRO = 12,
			DirAL = 13,
			DirRLE = 14,
			DirRLO = 15,
			DirPDF = 16,
			DirNSM = 17,
			DirBN = 18,
		}
		public enum Decomposition {
			NoDecomposition = 0,
			Canonical = 1,
			Font = 2,
			NoBreak = 3,
			Initial = 4,
			Medial = 5,
			Final = 6,
			Isolated = 7,
			Circle = 8,
			Super = 9,
			Sub = 10,
			Vertical = 11,
			Wide = 12,
			Narrow = 13,
			Small = 14,
			Square = 15,
			Compat = 16,
			Fraction = 17,
		}
		public enum Joining {
			OtherJoining = 0,
			Dual = 1,
			Right = 2,
			Center = 3,
		}
		public enum CombiningClass {
			Combining_BelowLeftAttached = 200,
			Combining_BelowAttached = 202,
			Combining_BelowRightAttached = 204,
			Combining_LeftAttached = 208,
			Combining_RightAttached = 210,
			Combining_AboveLeftAttached = 212,
			Combining_AboveAttached = 214,
			Combining_AboveRightAttached = 216,
			Combining_BelowLeft = 218,
			Combining_Below = 220,
			Combining_BelowRight = 222,
			Combining_Left = 224,
			Combining_Right = 226,
			Combining_AboveLeft = 228,
			Combining_Above = 230,
			Combining_AboveRight = 232,
			Combining_DoubleBelow = 233,
			Combining_DoubleAbove = 234,
			Combining_IotaSubscript = 240,
		}
		public enum UnicodeVersion {
			Unicode_Unassigned = 0,
			Unicode_1_1 = 1,
			Unicode_2_0 = 2,
			Unicode_2_1_2 = 3,
			Unicode_3_0 = 4,
			Unicode_3_1 = 5,
			Unicode_3_2 = 6,
			Unicode_4_0 = 7,
		}
		public QChar() : this((Type) null) {
			CreateProxy();
			NewQChar();
		}
		[SmokeMethod("QChar", "()", "")]
		private void NewQChar() {
			ProxyQChar().NewQChar();
		}
		public QChar(char c) : this((Type) null) {
			CreateProxy();
			NewQChar(c);
		}
		[SmokeMethod("QChar", "(char)", "$")]
		private void NewQChar(char c) {
			ProxyQChar().NewQChar(c);
		}
		public QChar(ushort c) : this((Type) null) {
			CreateProxy();
			NewQChar(c);
		}
		[SmokeMethod("QChar", "(uchar)", "$")]
		private void NewQChar(ushort c) {
			ProxyQChar().NewQChar(c);
		}
		public QChar(QLatin1Char ch) : this((Type) null) {
			CreateProxy();
			NewQChar(ch);
		}
		[SmokeMethod("QChar", "(QLatin1Char)", "#")]
		private void NewQChar(QLatin1Char ch) {
			ProxyQChar().NewQChar(ch);
		}
		public QChar(ushort c, ushort r) : this((Type) null) {
			CreateProxy();
			NewQChar(c,r);
		}
		[SmokeMethod("QChar", "(uchar, uchar)", "$$")]
		private void NewQChar(ushort c, ushort r) {
			ProxyQChar().NewQChar(c,r);
		}
		public QChar(short rc) : this((Type) null) {
			CreateProxy();
			NewQChar(rc);
		}
		[SmokeMethod("QChar", "(short)", "$")]
		private void NewQChar(short rc) {
			ProxyQChar().NewQChar(rc);
		}
		public QChar(uint rc) : this((Type) null) {
			CreateProxy();
			NewQChar(rc);
		}
		[SmokeMethod("QChar", "(uint)", "$")]
		private void NewQChar(uint rc) {
			ProxyQChar().NewQChar(rc);
		}
		public QChar(int rc) : this((Type) null) {
			CreateProxy();
			NewQChar(rc);
		}
		[SmokeMethod("QChar", "(int)", "$")]
		private void NewQChar(int rc) {
			ProxyQChar().NewQChar(rc);
		}
		[SmokeMethod("digitValue", "() const", "")]
		public int DigitValue() {
			return ProxyQChar().DigitValue();
		}
		[SmokeMethod("toLower", "() const", "")]
		public char ToLower() {
			return ProxyQChar().ToLower();
		}
		[SmokeMethod("toUpper", "() const", "")]
		public char ToUpper() {
			return ProxyQChar().ToUpper();
		}
		[SmokeMethod("category", "() const", "")]
		public char category() {
			return ProxyQChar().category();
		}
		[SmokeMethod("direction", "() const", "")]
		public char direction() {
			return ProxyQChar().direction();
		}
		[SmokeMethod("joining", "() const", "")]
		public char joining() {
			return ProxyQChar().joining();
		}
		[SmokeMethod("hasMirrored", "() const", "")]
		public bool HasMirrored() {
			return ProxyQChar().HasMirrored();
		}
		[SmokeMethod("isLower", "() const", "")]
		public bool IsLower() {
			return ProxyQChar().IsLower();
		}
		[SmokeMethod("isUpper", "() const", "")]
		public bool IsUpper() {
			return ProxyQChar().IsUpper();
		}
		[SmokeMethod("mirroredChar", "() const", "")]
		public char MirroredChar() {
			return ProxyQChar().MirroredChar();
		}
		[SmokeMethod("decomposition", "() const", "")]
		public string decomposition() {
			return ProxyQChar().decomposition();
		}
		[SmokeMethod("decompositionTag", "() const", "")]
		public char DecompositionTag() {
			return ProxyQChar().DecompositionTag();
		}
		[SmokeMethod("combiningClass", "() const", "")]
		public ushort combiningClass() {
			return ProxyQChar().combiningClass();
		}
		[SmokeMethod("unicodeVersion", "() const", "")]
		public char unicodeVersion() {
			return ProxyQChar().unicodeVersion();
		}
		[SmokeMethod("toAscii", "() const", "")]
		public char ToAscii() {
			return ProxyQChar().ToAscii();
		}
		[SmokeMethod("toLatin1", "() const", "")]
		public char ToLatin1() {
			return ProxyQChar().ToLatin1();
		}
		[SmokeMethod("unicode", "() const", "")]
		public ushort Unicode() {
			return ProxyQChar().Unicode();
		}
		// ushort& unicode(); >>>> NOT CONVERTED
		[SmokeMethod("isNull", "() const", "")]
		public bool IsNull() {
			return ProxyQChar().IsNull();
		}
		[SmokeMethod("isPrint", "() const", "")]
		public bool IsPrint() {
			return ProxyQChar().IsPrint();
		}
		[SmokeMethod("isPunct", "() const", "")]
		public bool IsPunct() {
			return ProxyQChar().IsPunct();
		}
		[SmokeMethod("isSpace", "() const", "")]
		public bool IsSpace() {
			return ProxyQChar().IsSpace();
		}
		[SmokeMethod("isMark", "() const", "")]
		public bool IsMark() {
			return ProxyQChar().IsMark();
		}
		[SmokeMethod("isLetter", "() const", "")]
		public bool IsLetter() {
			return ProxyQChar().IsLetter();
		}
		[SmokeMethod("isNumber", "() const", "")]
		public bool IsNumber() {
			return ProxyQChar().IsNumber();
		}
		[SmokeMethod("isLetterOrNumber", "() const", "")]
		public bool IsLetterOrNumber() {
			return ProxyQChar().IsLetterOrNumber();
		}
		[SmokeMethod("isDigit", "() const", "")]
		public bool IsDigit() {
			return ProxyQChar().IsDigit();
		}
		[SmokeMethod("isSymbol", "() const", "")]
		public bool IsSymbol() {
			return ProxyQChar().IsSymbol();
		}
		[SmokeMethod("cell", "() const", "")]
		public ushort Cell() {
			return ProxyQChar().Cell();
		}
		[SmokeMethod("row", "() const", "")]
		public ushort Row() {
			return ProxyQChar().Row();
		}
		[SmokeMethod("setCell", "(uchar)", "$")]
		public void SetCell(ushort cell) {
			ProxyQChar().SetCell(cell);
		}
		[SmokeMethod("setRow", "(uchar)", "$")]
		public void SetRow(ushort row) {
			ProxyQChar().SetRow(row);
		}
		public static char FromAscii(char c) {
			return StaticQChar().FromAscii(c);
		}
		public static char FromLatin1(char c) {
			return StaticQChar().FromLatin1(c);
		}
		~QChar() {
			DisposeQChar();
		}
		public void Dispose() {
			DisposeQChar();
		}
		[SmokeMethod("~QChar", "()", "")]
		private void DisposeQChar() {
			ProxyQChar().DisposeQChar();
		}
	}
}
