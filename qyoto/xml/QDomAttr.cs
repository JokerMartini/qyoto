//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	[SmokeClass("QDomAttr")]
	public class QDomAttr : QDomNode, IDisposable {
 		protected QDomAttr(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QDomAttr), this);
		}
		public QDomAttr() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDomAttr", "QDomAttr()", typeof(void));
		}
		public QDomAttr(QDomAttr x) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDomAttr#", "QDomAttr(const QDomAttr&)", typeof(void), typeof(QDomAttr), x);
		}
		public string Name() {
			return (string) interceptor.Invoke("name", "name() const", typeof(string));
		}
		public bool Specified() {
			return (bool) interceptor.Invoke("specified", "specified() const", typeof(bool));
		}
		public QDomElement OwnerElement() {
			return (QDomElement) interceptor.Invoke("ownerElement", "ownerElement() const", typeof(QDomElement));
		}
		public string Value() {
			return (string) interceptor.Invoke("value", "value() const", typeof(string));
		}
		public void SetValue(string arg1) {
			interceptor.Invoke("setValue$", "setValue(const QString&)", typeof(void), typeof(string), arg1);
		}
		public new QDomNode.NodeType NodeType() {
			return (QDomNode.NodeType) interceptor.Invoke("nodeType", "nodeType() const", typeof(QDomNode.NodeType));
		}
		~QDomAttr() {
			interceptor.Invoke("~QDomAttr", "~QDomAttr()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QDomAttr", "~QDomAttr()", typeof(void));
		}
	}
}
