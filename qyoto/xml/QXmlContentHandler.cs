//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	public interface IQXmlContentHandler {
			void SetDocumentLocator(QXmlLocator locator);
			bool StartDocument();
			bool EndDocument();
			bool StartPrefixMapping(string prefix, string uri);
			bool EndPrefixMapping(string prefix);
			bool StartElement(string namespaceURI, string localName, string qName, QXmlAttributes atts);
			bool EndElement(string namespaceURI, string localName, string qName);
			bool Characters(string ch);
			bool IgnorableWhitespace(string ch);
			bool ProcessingInstruction(string target, string data);
			bool SkippedEntity(string name);
			string ErrorString();
	}

	[SmokeClass("QXmlContentHandler")]
	public class QXmlContentHandler : MarshalByRefObject, IQXmlContentHandler {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QXmlContentHandler(Type dummy) {}
		[SmokeClass("QXmlContentHandler")]
		interface IQXmlContentHandlerProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QXmlContentHandler), this);
			_interceptor = (QXmlContentHandler) realProxy.GetTransparentProxy();
		}
		private QXmlContentHandler ProxyQXmlContentHandler() {
			return (QXmlContentHandler) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QXmlContentHandler() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQXmlContentHandlerProxy), null);
			_staticInterceptor = (IQXmlContentHandlerProxy) realProxy.GetTransparentProxy();
		}
		private static IQXmlContentHandlerProxy StaticQXmlContentHandler() {
			return (IQXmlContentHandlerProxy) _staticInterceptor;
		}

		[SmokeMethod("setDocumentLocator", "(QXmlLocator*)", "#")]
		public virtual void SetDocumentLocator(QXmlLocator locator) {
			ProxyQXmlContentHandler().SetDocumentLocator(locator);
		}
		[SmokeMethod("startDocument", "()", "")]
		public virtual bool StartDocument() {
			return ProxyQXmlContentHandler().StartDocument();
		}
		[SmokeMethod("endDocument", "()", "")]
		public virtual bool EndDocument() {
			return ProxyQXmlContentHandler().EndDocument();
		}
		[SmokeMethod("startPrefixMapping", "(const QString&, const QString&)", "$$")]
		public virtual bool StartPrefixMapping(string prefix, string uri) {
			return ProxyQXmlContentHandler().StartPrefixMapping(prefix,uri);
		}
		[SmokeMethod("endPrefixMapping", "(const QString&)", "$")]
		public virtual bool EndPrefixMapping(string prefix) {
			return ProxyQXmlContentHandler().EndPrefixMapping(prefix);
		}
		[SmokeMethod("startElement", "(const QString&, const QString&, const QString&, const QXmlAttributes&)", "$$$#")]
		public virtual bool StartElement(string namespaceURI, string localName, string qName, QXmlAttributes atts) {
			return ProxyQXmlContentHandler().StartElement(namespaceURI,localName,qName,atts);
		}
		[SmokeMethod("endElement", "(const QString&, const QString&, const QString&)", "$$$")]
		public virtual bool EndElement(string namespaceURI, string localName, string qName) {
			return ProxyQXmlContentHandler().EndElement(namespaceURI,localName,qName);
		}
		[SmokeMethod("characters", "(const QString&)", "$")]
		public virtual bool Characters(string ch) {
			return ProxyQXmlContentHandler().Characters(ch);
		}
		[SmokeMethod("ignorableWhitespace", "(const QString&)", "$")]
		public virtual bool IgnorableWhitespace(string ch) {
			return ProxyQXmlContentHandler().IgnorableWhitespace(ch);
		}
		[SmokeMethod("processingInstruction", "(const QString&, const QString&)", "$$")]
		public virtual bool ProcessingInstruction(string target, string data) {
			return ProxyQXmlContentHandler().ProcessingInstruction(target,data);
		}
		[SmokeMethod("skippedEntity", "(const QString&)", "$")]
		public virtual bool SkippedEntity(string name) {
			return ProxyQXmlContentHandler().SkippedEntity(name);
		}
		[SmokeMethod("errorString", "() const", "")]
		public virtual string ErrorString() {
			return ProxyQXmlContentHandler().ErrorString();
		}
		public QXmlContentHandler() : this((Type) null) {
			CreateProxy();
			NewQXmlContentHandler();
		}
		[SmokeMethod("QXmlContentHandler", "()", "")]
		private void NewQXmlContentHandler() {
			ProxyQXmlContentHandler().NewQXmlContentHandler();
		}
		~QXmlContentHandler() {
			DisposeQXmlContentHandler();
		}
		public void Dispose() {
			DisposeQXmlContentHandler();
		}
		[SmokeMethod("~QXmlContentHandler", "()", "")]
		private void DisposeQXmlContentHandler() {
			ProxyQXmlContentHandler().DisposeQXmlContentHandler();
		}
	}
}
