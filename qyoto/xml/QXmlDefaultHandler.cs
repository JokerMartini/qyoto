//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QXmlDefaultHandler")]
	public class QXmlDefaultHandler : QXmlLexicalHandler, IQXmlContentHandler, IQXmlDTDHandler, IQXmlDeclHandler, IQXmlEntityResolver, IQXmlErrorHandler, IDisposable {
 		protected QXmlDefaultHandler(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QXmlDefaultHandler), this);
		}
		// bool resolveEntity(const QString& arg1,const QString& arg2,QXmlInputSource*& arg3); >>>> NOT CONVERTED
		// bool resolveEntity(const QString& arg1,const QString& arg2,QXmlInputSource*& arg3); >>>> NOT CONVERTED
		public QXmlDefaultHandler() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QXmlDefaultHandler", "QXmlDefaultHandler()", typeof(void));
		}
		[SmokeMethod("setDocumentLocator(QXmlLocator*)")]
		public virtual void SetDocumentLocator(QXmlLocator locator) {
			interceptor.Invoke("setDocumentLocator#", "setDocumentLocator(QXmlLocator*)", typeof(void), typeof(QXmlLocator), locator);
		}
		[SmokeMethod("startDocument()")]
		public virtual bool StartDocument() {
			return (bool) interceptor.Invoke("startDocument", "startDocument()", typeof(bool));
		}
		[SmokeMethod("endDocument()")]
		public virtual bool EndDocument() {
			return (bool) interceptor.Invoke("endDocument", "endDocument()", typeof(bool));
		}
		[SmokeMethod("startPrefixMapping(const QString&, const QString&)")]
		public virtual bool StartPrefixMapping(string prefix, string uri) {
			return (bool) interceptor.Invoke("startPrefixMapping$$", "startPrefixMapping(const QString&, const QString&)", typeof(bool), typeof(string), prefix, typeof(string), uri);
		}
		[SmokeMethod("endPrefixMapping(const QString&)")]
		public virtual bool EndPrefixMapping(string prefix) {
			return (bool) interceptor.Invoke("endPrefixMapping$", "endPrefixMapping(const QString&)", typeof(bool), typeof(string), prefix);
		}
		[SmokeMethod("startElement(const QString&, const QString&, const QString&, const QXmlAttributes&)")]
		public virtual bool StartElement(string namespaceURI, string localName, string qName, QXmlAttributes atts) {
			return (bool) interceptor.Invoke("startElement$$$#", "startElement(const QString&, const QString&, const QString&, const QXmlAttributes&)", typeof(bool), typeof(string), namespaceURI, typeof(string), localName, typeof(string), qName, typeof(QXmlAttributes), atts);
		}
		[SmokeMethod("endElement(const QString&, const QString&, const QString&)")]
		public virtual bool EndElement(string namespaceURI, string localName, string qName) {
			return (bool) interceptor.Invoke("endElement$$$", "endElement(const QString&, const QString&, const QString&)", typeof(bool), typeof(string), namespaceURI, typeof(string), localName, typeof(string), qName);
		}
		[SmokeMethod("characters(const QString&)")]
		public virtual bool Characters(string ch) {
			return (bool) interceptor.Invoke("characters$", "characters(const QString&)", typeof(bool), typeof(string), ch);
		}
		[SmokeMethod("ignorableWhitespace(const QString&)")]
		public virtual bool IgnorableWhitespace(string ch) {
			return (bool) interceptor.Invoke("ignorableWhitespace$", "ignorableWhitespace(const QString&)", typeof(bool), typeof(string), ch);
		}
		[SmokeMethod("processingInstruction(const QString&, const QString&)")]
		public virtual bool ProcessingInstruction(string target, string data) {
			return (bool) interceptor.Invoke("processingInstruction$$", "processingInstruction(const QString&, const QString&)", typeof(bool), typeof(string), target, typeof(string), data);
		}
		[SmokeMethod("skippedEntity(const QString&)")]
		public virtual bool SkippedEntity(string name) {
			return (bool) interceptor.Invoke("skippedEntity$", "skippedEntity(const QString&)", typeof(bool), typeof(string), name);
		}
		[SmokeMethod("warning(const QXmlParseException&)")]
		public virtual bool Warning(QXmlParseException exception) {
			return (bool) interceptor.Invoke("warning#", "warning(const QXmlParseException&)", typeof(bool), typeof(QXmlParseException), exception);
		}
		[SmokeMethod("error(const QXmlParseException&)")]
		public virtual bool Error(QXmlParseException exception) {
			return (bool) interceptor.Invoke("error#", "error(const QXmlParseException&)", typeof(bool), typeof(QXmlParseException), exception);
		}
		[SmokeMethod("fatalError(const QXmlParseException&)")]
		public virtual bool FatalError(QXmlParseException exception) {
			return (bool) interceptor.Invoke("fatalError#", "fatalError(const QXmlParseException&)", typeof(bool), typeof(QXmlParseException), exception);
		}
		[SmokeMethod("notationDecl(const QString&, const QString&, const QString&)")]
		public virtual bool NotationDecl(string name, string publicId, string systemId) {
			return (bool) interceptor.Invoke("notationDecl$$$", "notationDecl(const QString&, const QString&, const QString&)", typeof(bool), typeof(string), name, typeof(string), publicId, typeof(string), systemId);
		}
		[SmokeMethod("unparsedEntityDecl(const QString&, const QString&, const QString&, const QString&)")]
		public virtual bool UnparsedEntityDecl(string name, string publicId, string systemId, string notationName) {
			return (bool) interceptor.Invoke("unparsedEntityDecl$$$$", "unparsedEntityDecl(const QString&, const QString&, const QString&, const QString&)", typeof(bool), typeof(string), name, typeof(string), publicId, typeof(string), systemId, typeof(string), notationName);
		}
		[SmokeMethod("startDTD(const QString&, const QString&, const QString&)")]
		public override bool StartDTD(string name, string publicId, string systemId) {
			return (bool) interceptor.Invoke("startDTD$$$", "startDTD(const QString&, const QString&, const QString&)", typeof(bool), typeof(string), name, typeof(string), publicId, typeof(string), systemId);
		}
		[SmokeMethod("endDTD()")]
		public override bool EndDTD() {
			return (bool) interceptor.Invoke("endDTD", "endDTD()", typeof(bool));
		}
		[SmokeMethod("startEntity(const QString&)")]
		public override bool StartEntity(string name) {
			return (bool) interceptor.Invoke("startEntity$", "startEntity(const QString&)", typeof(bool), typeof(string), name);
		}
		[SmokeMethod("endEntity(const QString&)")]
		public override bool EndEntity(string name) {
			return (bool) interceptor.Invoke("endEntity$", "endEntity(const QString&)", typeof(bool), typeof(string), name);
		}
		[SmokeMethod("startCDATA()")]
		public override bool StartCDATA() {
			return (bool) interceptor.Invoke("startCDATA", "startCDATA()", typeof(bool));
		}
		[SmokeMethod("endCDATA()")]
		public override bool EndCDATA() {
			return (bool) interceptor.Invoke("endCDATA", "endCDATA()", typeof(bool));
		}
		[SmokeMethod("comment(const QString&)")]
		public override bool Comment(string ch) {
			return (bool) interceptor.Invoke("comment$", "comment(const QString&)", typeof(bool), typeof(string), ch);
		}
		[SmokeMethod("attributeDecl(const QString&, const QString&, const QString&, const QString&, const QString&)")]
		public virtual bool AttributeDecl(string eName, string aName, string type, string valueDefault, string value) {
			return (bool) interceptor.Invoke("attributeDecl$$$$$", "attributeDecl(const QString&, const QString&, const QString&, const QString&, const QString&)", typeof(bool), typeof(string), eName, typeof(string), aName, typeof(string), type, typeof(string), valueDefault, typeof(string), value);
		}
		[SmokeMethod("internalEntityDecl(const QString&, const QString&)")]
		public virtual bool InternalEntityDecl(string name, string value) {
			return (bool) interceptor.Invoke("internalEntityDecl$$", "internalEntityDecl(const QString&, const QString&)", typeof(bool), typeof(string), name, typeof(string), value);
		}
		[SmokeMethod("externalEntityDecl(const QString&, const QString&, const QString&)")]
		public virtual bool ExternalEntityDecl(string name, string publicId, string systemId) {
			return (bool) interceptor.Invoke("externalEntityDecl$$$", "externalEntityDecl(const QString&, const QString&, const QString&)", typeof(bool), typeof(string), name, typeof(string), publicId, typeof(string), systemId);
		}
		[SmokeMethod("errorString() const")]
		public override string ErrorString() {
			return (string) interceptor.Invoke("errorString", "errorString() const", typeof(string));
		}
		~QXmlDefaultHandler() {
			interceptor.Invoke("~QXmlDefaultHandler", "~QXmlDefaultHandler()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QXmlDefaultHandler", "~QXmlDefaultHandler()", typeof(void));
		}
	}
}
