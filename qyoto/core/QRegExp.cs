//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QRegExp")]
	public class QRegExp : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QRegExp(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QRegExp), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QRegExp() {
			staticInterceptor = new SmokeInvocation(typeof(QRegExp), null);
		}
		public enum PatternSyntax {
			RegExp = 0,
			Wildcard = 1,
			FixedString = 2,
			RegExp2 = 3,
		}
		public enum CaretMode {
			CaretAtZero = 0,
			CaretAtOffset = 1,
			CaretWontMatch = 2,
		}
		public QRegExp() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QRegExp", "QRegExp()", typeof(void));
		}
		public QRegExp(string pattern, Qt.CaseSensitivity cs, QRegExp.PatternSyntax syntax) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QRegExp$$$", "QRegExp(const QString&, Qt::CaseSensitivity, QRegExp::PatternSyntax)", typeof(void), typeof(string), pattern, typeof(Qt.CaseSensitivity), cs, typeof(QRegExp.PatternSyntax), syntax);
		}
		public QRegExp(string pattern, Qt.CaseSensitivity cs) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QRegExp$$", "QRegExp(const QString&, Qt::CaseSensitivity)", typeof(void), typeof(string), pattern, typeof(Qt.CaseSensitivity), cs);
		}
		public QRegExp(string pattern) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QRegExp$", "QRegExp(const QString&)", typeof(void), typeof(string), pattern);
		}
		public QRegExp(QRegExp rx) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QRegExp#", "QRegExp(const QRegExp&)", typeof(void), typeof(QRegExp), rx);
		}
		public override bool Equals(object o) {
			if (!(o is QRegExp)) { return false; }
			return this == (QRegExp) o;
		}
		public override int GetHashCode() {
			return interceptor.GetHashCode();
		}
		public bool IsEmpty() {
			return (bool) interceptor.Invoke("isEmpty", "isEmpty() const", typeof(bool));
		}
		public bool IsValid() {
			return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
		}
		public string Pattern() {
			return (string) interceptor.Invoke("pattern", "pattern() const", typeof(string));
		}
		public void SetPattern(string pattern) {
			interceptor.Invoke("setPattern$", "setPattern(const QString&)", typeof(void), typeof(string), pattern);
		}
		public Qt.CaseSensitivity CaseSensitivity() {
			return (Qt.CaseSensitivity) interceptor.Invoke("caseSensitivity", "caseSensitivity() const", typeof(Qt.CaseSensitivity));
		}
		public void SetCaseSensitivity(Qt.CaseSensitivity cs) {
			interceptor.Invoke("setCaseSensitivity$", "setCaseSensitivity(Qt::CaseSensitivity)", typeof(void), typeof(Qt.CaseSensitivity), cs);
		}
		public QRegExp.PatternSyntax patternSyntax() {
			return (QRegExp.PatternSyntax) interceptor.Invoke("patternSyntax", "patternSyntax() const", typeof(QRegExp.PatternSyntax));
		}
		public void SetPatternSyntax(QRegExp.PatternSyntax syntax) {
			interceptor.Invoke("setPatternSyntax$", "setPatternSyntax(QRegExp::PatternSyntax)", typeof(void), typeof(QRegExp.PatternSyntax), syntax);
		}
		public bool IsMinimal() {
			return (bool) interceptor.Invoke("isMinimal", "isMinimal() const", typeof(bool));
		}
		public void SetMinimal(bool minimal) {
			interceptor.Invoke("setMinimal$", "setMinimal(bool)", typeof(void), typeof(bool), minimal);
		}
		public bool ExactMatch(string str) {
			return (bool) interceptor.Invoke("exactMatch$", "exactMatch(const QString&) const", typeof(bool), typeof(string), str);
		}
		public int IndexIn(string str, int offset, QRegExp.CaretMode caretMode) {
			return (int) interceptor.Invoke("indexIn$$$", "indexIn(const QString&, int, QRegExp::CaretMode) const", typeof(int), typeof(string), str, typeof(int), offset, typeof(QRegExp.CaretMode), caretMode);
		}
		public int IndexIn(string str, int offset) {
			return (int) interceptor.Invoke("indexIn$$", "indexIn(const QString&, int) const", typeof(int), typeof(string), str, typeof(int), offset);
		}
		public int IndexIn(string str) {
			return (int) interceptor.Invoke("indexIn$", "indexIn(const QString&) const", typeof(int), typeof(string), str);
		}
		public int LastIndexIn(string str, int offset, QRegExp.CaretMode caretMode) {
			return (int) interceptor.Invoke("lastIndexIn$$$", "lastIndexIn(const QString&, int, QRegExp::CaretMode) const", typeof(int), typeof(string), str, typeof(int), offset, typeof(QRegExp.CaretMode), caretMode);
		}
		public int LastIndexIn(string str, int offset) {
			return (int) interceptor.Invoke("lastIndexIn$$", "lastIndexIn(const QString&, int) const", typeof(int), typeof(string), str, typeof(int), offset);
		}
		public int LastIndexIn(string str) {
			return (int) interceptor.Invoke("lastIndexIn$", "lastIndexIn(const QString&) const", typeof(int), typeof(string), str);
		}
		public int MatchedLength() {
			return (int) interceptor.Invoke("matchedLength", "matchedLength() const", typeof(int));
		}
		public int NumCaptures() {
			return (int) interceptor.Invoke("numCaptures", "numCaptures() const", typeof(int));
		}
		public List<string> CapturedTexts() {
			return (List<string>) interceptor.Invoke("capturedTexts", "capturedTexts()", typeof(List<string>));
		}
		public string Cap(int nth) {
			return (string) interceptor.Invoke("cap$", "cap(int)", typeof(string), typeof(int), nth);
		}
		public string Cap() {
			return (string) interceptor.Invoke("cap", "cap()", typeof(string));
		}
		public int Pos(int nth) {
			return (int) interceptor.Invoke("pos$", "pos(int)", typeof(int), typeof(int), nth);
		}
		public int Pos() {
			return (int) interceptor.Invoke("pos", "pos()", typeof(int));
		}
		public string ErrorString() {
			return (string) interceptor.Invoke("errorString", "errorString()", typeof(string));
		}
		~QRegExp() {
			interceptor.Invoke("~QRegExp", "~QRegExp()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QRegExp", "~QRegExp()", typeof(void));
		}
		public static bool operator==(QRegExp lhs, QRegExp rx) {
			return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QRegExp&) const", typeof(bool), typeof(QRegExp), lhs, typeof(QRegExp), rx);
		}
		public static bool operator!=(QRegExp lhs, QRegExp rx) {
			return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QRegExp&) const", typeof(bool), typeof(QRegExp), lhs, typeof(QRegExp), rx);
		}
		public static string Escape(string str) {
			return (string) staticInterceptor.Invoke("escape$", "escape(const QString&)", typeof(string), typeof(string), str);
		}
	}
}
