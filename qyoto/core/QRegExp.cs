//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	[SmokeClass("QRegExp")]
	public class QRegExp : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QRegExp(Type dummy) {}
		interface IQRegExpProxy {
			bool op_equals(QRegExp lhs, QRegExp rx);
			string Escape(string str);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QRegExp), this);
			_interceptor = (QRegExp) realProxy.GetTransparentProxy();
		}
		private QRegExp ProxyQRegExp() {
			return (QRegExp) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QRegExp() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQRegExpProxy), null);
			_staticInterceptor = (IQRegExpProxy) realProxy.GetTransparentProxy();
		}
		private static IQRegExpProxy StaticQRegExp() {
			return (IQRegExpProxy) _staticInterceptor;
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
			NewQRegExp();
		}
		[SmokeMethod("QRegExp()")]
		private void NewQRegExp() {
			ProxyQRegExp().NewQRegExp();
		}
		public QRegExp(string pattern, Qt.CaseSensitivity cs, QRegExp.PatternSyntax syntax) : this((Type) null) {
			CreateProxy();
			NewQRegExp(pattern,cs,syntax);
		}
		[SmokeMethod("QRegExp(const QString&, Qt::CaseSensitivity, QRegExp::PatternSyntax)")]
		private void NewQRegExp(string pattern, Qt.CaseSensitivity cs, QRegExp.PatternSyntax syntax) {
			ProxyQRegExp().NewQRegExp(pattern,cs,syntax);
		}
		public QRegExp(string pattern, Qt.CaseSensitivity cs) : this((Type) null) {
			CreateProxy();
			NewQRegExp(pattern,cs);
		}
		[SmokeMethod("QRegExp(const QString&, Qt::CaseSensitivity)")]
		private void NewQRegExp(string pattern, Qt.CaseSensitivity cs) {
			ProxyQRegExp().NewQRegExp(pattern,cs);
		}
		public QRegExp(string pattern) : this((Type) null) {
			CreateProxy();
			NewQRegExp(pattern);
		}
		[SmokeMethod("QRegExp(const QString&)")]
		private void NewQRegExp(string pattern) {
			ProxyQRegExp().NewQRegExp(pattern);
		}
		public QRegExp(QRegExp rx) : this((Type) null) {
			CreateProxy();
			NewQRegExp(rx);
		}
		[SmokeMethod("QRegExp(const QRegExp&)")]
		private void NewQRegExp(QRegExp rx) {
			ProxyQRegExp().NewQRegExp(rx);
		}
		[SmokeMethod("operator==(const QRegExp&) const")]
		public static bool operator==(QRegExp lhs, QRegExp rx) {
			return StaticQRegExp().op_equals(lhs,rx);
		}
		public static bool operator!=(QRegExp lhs, QRegExp rx) {
			return !StaticQRegExp().op_equals(lhs,rx);
		}
		public override bool Equals(object o) {
			if (!(o is QRegExp)) { return false; }
			return this == (QRegExp) o;
		}
		public override int GetHashCode() {
			return ProxyQRegExp().GetHashCode();
		}
		[SmokeMethod("isEmpty() const")]
		public bool IsEmpty() {
			return ProxyQRegExp().IsEmpty();
		}
		[SmokeMethod("isValid() const")]
		public bool IsValid() {
			return ProxyQRegExp().IsValid();
		}
		[SmokeMethod("pattern() const")]
		public string Pattern() {
			return ProxyQRegExp().Pattern();
		}
		[SmokeMethod("setPattern(const QString&)")]
		public void SetPattern(string pattern) {
			ProxyQRegExp().SetPattern(pattern);
		}
		[SmokeMethod("caseSensitivity() const")]
		public Qt.CaseSensitivity CaseSensitivity() {
			return ProxyQRegExp().CaseSensitivity();
		}
		[SmokeMethod("setCaseSensitivity(Qt::CaseSensitivity)")]
		public void SetCaseSensitivity(Qt.CaseSensitivity cs) {
			ProxyQRegExp().SetCaseSensitivity(cs);
		}
		[SmokeMethod("patternSyntax() const")]
		public QRegExp.PatternSyntax patternSyntax() {
			return ProxyQRegExp().patternSyntax();
		}
		[SmokeMethod("setPatternSyntax(QRegExp::PatternSyntax)")]
		public void SetPatternSyntax(QRegExp.PatternSyntax syntax) {
			ProxyQRegExp().SetPatternSyntax(syntax);
		}
		[SmokeMethod("isMinimal() const")]
		public bool IsMinimal() {
			return ProxyQRegExp().IsMinimal();
		}
		[SmokeMethod("setMinimal(bool)")]
		public void SetMinimal(bool minimal) {
			ProxyQRegExp().SetMinimal(minimal);
		}
		[SmokeMethod("exactMatch(const QString&) const")]
		public bool ExactMatch(string str) {
			return ProxyQRegExp().ExactMatch(str);
		}
		[SmokeMethod("indexIn(const QString&, int, QRegExp::CaretMode) const")]
		public int IndexIn(string str, int offset, QRegExp.CaretMode caretMode) {
			return ProxyQRegExp().IndexIn(str,offset,caretMode);
		}
		[SmokeMethod("indexIn(const QString&, int) const")]
		public int IndexIn(string str, int offset) {
			return ProxyQRegExp().IndexIn(str,offset);
		}
		[SmokeMethod("indexIn(const QString&) const")]
		public int IndexIn(string str) {
			return ProxyQRegExp().IndexIn(str);
		}
		[SmokeMethod("lastIndexIn(const QString&, int, QRegExp::CaretMode) const")]
		public int LastIndexIn(string str, int offset, QRegExp.CaretMode caretMode) {
			return ProxyQRegExp().LastIndexIn(str,offset,caretMode);
		}
		[SmokeMethod("lastIndexIn(const QString&, int) const")]
		public int LastIndexIn(string str, int offset) {
			return ProxyQRegExp().LastIndexIn(str,offset);
		}
		[SmokeMethod("lastIndexIn(const QString&) const")]
		public int LastIndexIn(string str) {
			return ProxyQRegExp().LastIndexIn(str);
		}
		[SmokeMethod("matchedLength() const")]
		public int MatchedLength() {
			return ProxyQRegExp().MatchedLength();
		}
		[SmokeMethod("numCaptures() const")]
		public int NumCaptures() {
			return ProxyQRegExp().NumCaptures();
		}
		[SmokeMethod("capturedTexts()")]
		public List<string> CapturedTexts() {
			return ProxyQRegExp().CapturedTexts();
		}
		[SmokeMethod("cap(int)")]
		public string Cap(int nth) {
			return ProxyQRegExp().Cap(nth);
		}
		[SmokeMethod("cap()")]
		public string Cap() {
			return ProxyQRegExp().Cap();
		}
		[SmokeMethod("pos(int)")]
		public int Pos(int nth) {
			return ProxyQRegExp().Pos(nth);
		}
		[SmokeMethod("pos()")]
		public int Pos() {
			return ProxyQRegExp().Pos();
		}
		[SmokeMethod("errorString()")]
		public string ErrorString() {
			return ProxyQRegExp().ErrorString();
		}
		[SmokeMethod("escape(const QString&)")]
		public static string Escape(string str) {
			return StaticQRegExp().Escape(str);
		}
		~QRegExp() {
			DisposeQRegExp();
		}
		public void Dispose() {
			DisposeQRegExp();
		}
		[SmokeMethod("~QRegExp()")]
		private void DisposeQRegExp() {
			ProxyQRegExp().DisposeQRegExp();
		}
	}
}
