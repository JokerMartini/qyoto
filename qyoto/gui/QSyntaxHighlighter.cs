//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QSyntaxHighlighter")]
	public abstract class QSyntaxHighlighter : QObject {
 		protected QSyntaxHighlighter(Type dummy) : base((Type) null) {}
		[SmokeClass("QSyntaxHighlighter")]
		interface IQSyntaxHighlighterProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSyntaxHighlighter), this);
			_interceptor = (QSyntaxHighlighter) realProxy.GetTransparentProxy();
		}
		private QSyntaxHighlighter ProxyQSyntaxHighlighter() {
			return (QSyntaxHighlighter) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSyntaxHighlighter() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSyntaxHighlighterProxy), null);
			_staticInterceptor = (IQSyntaxHighlighterProxy) realProxy.GetTransparentProxy();
		}
		private static IQSyntaxHighlighterProxy StaticQSyntaxHighlighter() {
			return (IQSyntaxHighlighterProxy) _staticInterceptor;
		}
		public QSyntaxHighlighter(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQSyntaxHighlighter(parent);
		}
		[SmokeMethod("QSyntaxHighlighter", "(QObject*)", "#")]
		private void NewQSyntaxHighlighter(QObject parent) {
			ProxyQSyntaxHighlighter().NewQSyntaxHighlighter(parent);
		}
		public QSyntaxHighlighter(QTextDocument parent) : this((Type) null) {
			CreateProxy();
			NewQSyntaxHighlighter(parent);
		}
		[SmokeMethod("QSyntaxHighlighter", "(QTextDocument*)", "#")]
		private void NewQSyntaxHighlighter(QTextDocument parent) {
			ProxyQSyntaxHighlighter().NewQSyntaxHighlighter(parent);
		}
		public QSyntaxHighlighter(QTextEdit parent) : this((Type) null) {
			CreateProxy();
			NewQSyntaxHighlighter(parent);
		}
		[SmokeMethod("QSyntaxHighlighter", "(QTextEdit*)", "#")]
		private void NewQSyntaxHighlighter(QTextEdit parent) {
			ProxyQSyntaxHighlighter().NewQSyntaxHighlighter(parent);
		}
		[SmokeMethod("setDocument", "(QTextDocument*)", "#")]
		public void SetDocument(QTextDocument doc) {
			ProxyQSyntaxHighlighter().SetDocument(doc);
		}
		[SmokeMethod("document", "() const", "")]
		public QTextDocument Document() {
			return ProxyQSyntaxHighlighter().Document();
		}
		[Q_SLOT("void rehighlight()")]
		[SmokeMethod("rehighlight", "()", "")]
		public void Rehighlight() {
			ProxyQSyntaxHighlighter().Rehighlight();
		}
		public static string Tr(string s, string c) {
			return StaticQSyntaxHighlighter().Tr(s,c);
		}
		public static string Tr(string s) {
			return StaticQSyntaxHighlighter().Tr(s);
		}
		protected abstract void HighlightBlock(string text);
		[SmokeMethod("setFormat", "(int, int, const QTextCharFormat&)", "$$#")]
		protected void SetFormat(int start, int count, QTextCharFormat format) {
			ProxyQSyntaxHighlighter().SetFormat(start,count,format);
		}
		[SmokeMethod("setFormat", "(int, int, const QColor&)", "$$#")]
		protected void SetFormat(int start, int count, QColor color) {
			ProxyQSyntaxHighlighter().SetFormat(start,count,color);
		}
		[SmokeMethod("setFormat", "(int, int, const QFont&)", "$$#")]
		protected void SetFormat(int start, int count, QFont font) {
			ProxyQSyntaxHighlighter().SetFormat(start,count,font);
		}
		[SmokeMethod("format", "(int) const", "$")]
		public QTextCharFormat Format(int pos) {
			return ProxyQSyntaxHighlighter().Format(pos);
		}
		[SmokeMethod("previousBlockState", "() const", "")]
		protected int PreviousBlockState() {
			return ProxyQSyntaxHighlighter().PreviousBlockState();
		}
		[SmokeMethod("currentBlockState", "() const", "")]
		protected int CurrentBlockState() {
			return ProxyQSyntaxHighlighter().CurrentBlockState();
		}
		[SmokeMethod("setCurrentBlockState", "(int)", "$")]
		protected void SetCurrentBlockState(int newState) {
			ProxyQSyntaxHighlighter().SetCurrentBlockState(newState);
		}
		[SmokeMethod("setCurrentBlockUserData", "(QTextBlockUserData*)", "#")]
		protected void SetCurrentBlockUserData(QTextBlockUserData data) {
			ProxyQSyntaxHighlighter().SetCurrentBlockUserData(data);
		}
		[SmokeMethod("currentBlockUserData", "() const", "")]
		protected QTextBlockUserData CurrentBlockUserData() {
			return ProxyQSyntaxHighlighter().CurrentBlockUserData();
		}
		~QSyntaxHighlighter() {
			DisposeQSyntaxHighlighter();
		}
		public new void Dispose() {
			DisposeQSyntaxHighlighter();
		}
		[SmokeMethod("~QSyntaxHighlighter", "()", "")]
		private void DisposeQSyntaxHighlighter() {
			ProxyQSyntaxHighlighter().DisposeQSyntaxHighlighter();
		}
		protected new IQSyntaxHighlighterSignals Emit {
			get { return (IQSyntaxHighlighterSignals) Q_EMIT; }
		}
	}

	public interface IQSyntaxHighlighterSignals : IQObjectSignals {
	}
}
