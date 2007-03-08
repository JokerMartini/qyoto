//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QTextObject")]
	public class QTextObject : QObject {
 		protected QTextObject(Type dummy) : base((Type) null) {}
		[SmokeClass("QTextObject")]
		interface IQTextObjectProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextObject), this);
			_interceptor = (QTextObject) realProxy.GetTransparentProxy();
		}
		private QTextObject ProxyQTextObject() {
			return (QTextObject) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextObject() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextObjectProxy), null);
			_staticInterceptor = (IQTextObjectProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextObjectProxy StaticQTextObject() {
			return (IQTextObjectProxy) _staticInterceptor;
		}
		[SmokeMethod("format", "() const", "")]
		public QTextFormat Format() {
			return ProxyQTextObject().Format();
		}
		[SmokeMethod("formatIndex", "() const", "")]
		public int FormatIndex() {
			return ProxyQTextObject().FormatIndex();
		}
		[SmokeMethod("document", "() const", "")]
		public QTextDocument Document() {
			return ProxyQTextObject().Document();
		}
		[SmokeMethod("objectIndex", "() const", "")]
		public int ObjectIndex() {
			return ProxyQTextObject().ObjectIndex();
		}
		// QTextDocumentPrivate* docHandle(); >>>> NOT CONVERTED
		public static string Tr(string s, string c) {
			return StaticQTextObject().Tr(s,c);
		}
		public static string Tr(string s) {
			return StaticQTextObject().Tr(s);
		}
		public QTextObject(QTextDocument doc) : this((Type) null) {
			CreateProxy();
			NewQTextObject(doc);
		}
		[SmokeMethod("QTextObject", "(QTextDocument*)", "#")]
		private void NewQTextObject(QTextDocument doc) {
			ProxyQTextObject().NewQTextObject(doc);
		}
		[SmokeMethod("setFormat", "(const QTextFormat&)", "#")]
		protected void SetFormat(QTextFormat format) {
			ProxyQTextObject().SetFormat(format);
		}
		protected new IQTextObjectSignals Emit {
			get { return (IQTextObjectSignals) Q_EMIT; }
		}
	}

	public interface IQTextObjectSignals : IQObjectSignals {
	}
}
