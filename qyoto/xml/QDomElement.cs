//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QDomElement")]
	public class QDomElement : QDomNode, IDisposable {
 		protected QDomElement(Type dummy) : base((Type) null) {}
		[SmokeClass("QDomElement")]
		interface IQDomElementProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDomElement), this);
			_interceptor = (QDomElement) realProxy.GetTransparentProxy();
		}
		private QDomElement ProxyQDomElement() {
			return (QDomElement) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDomElement() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDomElementProxy), null);
			_staticInterceptor = (IQDomElementProxy) realProxy.GetTransparentProxy();
		}
		private static IQDomElementProxy StaticQDomElement() {
			return (IQDomElementProxy) _staticInterceptor;
		}

		public QDomElement() : this((Type) null) {
			CreateProxy();
			NewQDomElement();
		}
		[SmokeMethod("QDomElement", "()", "")]
		private void NewQDomElement() {
			ProxyQDomElement().NewQDomElement();
		}
		public QDomElement(QDomElement x) : this((Type) null) {
			CreateProxy();
			NewQDomElement(x);
		}
		[SmokeMethod("QDomElement", "(const QDomElement&)", "#")]
		private void NewQDomElement(QDomElement x) {
			ProxyQDomElement().NewQDomElement(x);
		}
		[SmokeMethod("attribute", "(const QString&, const QString&) const", "$$")]
		public string Attribute(string name, string defValue) {
			return ProxyQDomElement().Attribute(name,defValue);
		}
		[SmokeMethod("attribute", "(const QString&) const", "$")]
		public string Attribute(string name) {
			return ProxyQDomElement().Attribute(name);
		}
		[SmokeMethod("setAttribute", "(const QString&, const QString&)", "$$")]
		public void SetAttribute(string name, string value) {
			ProxyQDomElement().SetAttribute(name,value);
		}
		[SmokeMethod("setAttribute", "(const QString&, qlonglong)", "$?")]
		public void SetAttribute(string name, long value) {
			ProxyQDomElement().SetAttribute(name,value);
		}
		[SmokeMethod("setAttribute", "(const QString&, qulonglong)", "$$")]
		public void SetAttribute(string name, ulong value) {
			ProxyQDomElement().SetAttribute(name,value);
		}
		[SmokeMethod("setAttribute", "(const QString&, int)", "$$")]
		public void SetAttribute(string name, int value) {
			ProxyQDomElement().SetAttribute(name,value);
		}
		[SmokeMethod("setAttribute", "(const QString&, uint)", "$$")]
		public void SetAttribute(string name, uint value) {
			ProxyQDomElement().SetAttribute(name,value);
		}
		[SmokeMethod("setAttribute", "(const QString&, float)", "$$")]
		public void SetAttribute(string name, float value) {
			ProxyQDomElement().SetAttribute(name,value);
		}
		[SmokeMethod("setAttribute", "(const QString&, double)", "$$")]
		public void SetAttribute(string name, double value) {
			ProxyQDomElement().SetAttribute(name,value);
		}
		[SmokeMethod("removeAttribute", "(const QString&)", "$")]
		public void RemoveAttribute(string name) {
			ProxyQDomElement().RemoveAttribute(name);
		}
		[SmokeMethod("attributeNode", "(const QString&)", "$")]
		public QDomAttr AttributeNode(string name) {
			return ProxyQDomElement().AttributeNode(name);
		}
		[SmokeMethod("setAttributeNode", "(const QDomAttr&)", "#")]
		public QDomAttr SetAttributeNode(QDomAttr newAttr) {
			return ProxyQDomElement().SetAttributeNode(newAttr);
		}
		[SmokeMethod("removeAttributeNode", "(const QDomAttr&)", "#")]
		public QDomAttr RemoveAttributeNode(QDomAttr oldAttr) {
			return ProxyQDomElement().RemoveAttributeNode(oldAttr);
		}
		[SmokeMethod("elementsByTagName", "(const QString&) const", "$")]
		public QDomNodeList ElementsByTagName(string tagname) {
			return ProxyQDomElement().ElementsByTagName(tagname);
		}
		[SmokeMethod("hasAttribute", "(const QString&) const", "$")]
		public bool HasAttribute(string name) {
			return ProxyQDomElement().HasAttribute(name);
		}
		[SmokeMethod("attributeNS", "(const QString, const QString&, const QString&) const", "$$$")]
		public string AttributeNS(string nsURI, string localName, string defValue) {
			return ProxyQDomElement().AttributeNS(nsURI,localName,defValue);
		}
		[SmokeMethod("attributeNS", "(const QString, const QString&) const", "$$")]
		public string AttributeNS(string nsURI, string localName) {
			return ProxyQDomElement().AttributeNS(nsURI,localName);
		}
		[SmokeMethod("setAttributeNS", "(const QString, const QString&, const QString&)", "$$$")]
		public void SetAttributeNS(string nsURI, string qName, string value) {
			ProxyQDomElement().SetAttributeNS(nsURI,qName,value);
		}
		[SmokeMethod("setAttributeNS", "(const QString, const QString&, int)", "$$$")]
		public void SetAttributeNS(string nsURI, string qName, int value) {
			ProxyQDomElement().SetAttributeNS(nsURI,qName,value);
		}
		[SmokeMethod("setAttributeNS", "(const QString, const QString&, uint)", "$$$")]
		public void SetAttributeNS(string nsURI, string qName, uint value) {
			ProxyQDomElement().SetAttributeNS(nsURI,qName,value);
		}
		[SmokeMethod("setAttributeNS", "(const QString, const QString&, qlonglong)", "$$?")]
		public void SetAttributeNS(string nsURI, string qName, long value) {
			ProxyQDomElement().SetAttributeNS(nsURI,qName,value);
		}
		[SmokeMethod("setAttributeNS", "(const QString, const QString&, qulonglong)", "$$$")]
		public void SetAttributeNS(string nsURI, string qName, ulong value) {
			ProxyQDomElement().SetAttributeNS(nsURI,qName,value);
		}
		[SmokeMethod("setAttributeNS", "(const QString, const QString&, double)", "$$$")]
		public void SetAttributeNS(string nsURI, string qName, double value) {
			ProxyQDomElement().SetAttributeNS(nsURI,qName,value);
		}
		[SmokeMethod("removeAttributeNS", "(const QString&, const QString&)", "$$")]
		public void RemoveAttributeNS(string nsURI, string localName) {
			ProxyQDomElement().RemoveAttributeNS(nsURI,localName);
		}
		[SmokeMethod("attributeNodeNS", "(const QString&, const QString&)", "$$")]
		public QDomAttr AttributeNodeNS(string nsURI, string localName) {
			return ProxyQDomElement().AttributeNodeNS(nsURI,localName);
		}
		[SmokeMethod("setAttributeNodeNS", "(const QDomAttr&)", "#")]
		public QDomAttr SetAttributeNodeNS(QDomAttr newAttr) {
			return ProxyQDomElement().SetAttributeNodeNS(newAttr);
		}
		[SmokeMethod("elementsByTagNameNS", "(const QString&, const QString&) const", "$$")]
		public QDomNodeList ElementsByTagNameNS(string nsURI, string localName) {
			return ProxyQDomElement().ElementsByTagNameNS(nsURI,localName);
		}
		[SmokeMethod("hasAttributeNS", "(const QString&, const QString&) const", "$$")]
		public bool HasAttributeNS(string nsURI, string localName) {
			return ProxyQDomElement().HasAttributeNS(nsURI,localName);
		}
		[SmokeMethod("tagName", "() const", "")]
		public string TagName() {
			return ProxyQDomElement().TagName();
		}
		[SmokeMethod("setTagName", "(const QString&)", "$")]
		public void SetTagName(string name) {
			ProxyQDomElement().SetTagName(name);
		}
		[SmokeMethod("attributes", "() const", "")]
		public new QDomNamedNodeMap Attributes() {
			return ProxyQDomElement().Attributes();
		}
		[SmokeMethod("nodeType", "() const", "")]
		public new QDomNode.NodeType NodeType() {
			return ProxyQDomElement().NodeType();
		}
		[SmokeMethod("text", "() const", "")]
		public string Text() {
			return ProxyQDomElement().Text();
		}
		~QDomElement() {
			DisposeQDomElement();
		}
		public void Dispose() {
			DisposeQDomElement();
		}
		[SmokeMethod("~QDomElement", "()", "")]
		private void DisposeQDomElement() {
			ProxyQDomElement().DisposeQDomElement();
		}
	}
}
