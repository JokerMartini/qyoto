//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QXmlStreamAttributes")]
	public class QXmlStreamAttributes : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QXmlStreamAttributes(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QXmlStreamAttributes), this);
		}
		// QStringRef value(const QString& arg1,const QLatin1String& arg2); >>>> NOT CONVERTED
		// QStringRef value(const QLatin1String& arg1,const QLatin1String& arg2); >>>> NOT CONVERTED
		// QStringRef value(const QLatin1String& arg1); >>>> NOT CONVERTED
		public string Value(string namespaceUri, string name) {
			return (string) interceptor.Invoke("value$$", "value(const QString&, const QString&) const", typeof(string), typeof(string), namespaceUri, typeof(string), name);
		}
		public string Value(string qualifiedName) {
			return (string) interceptor.Invoke("value$", "value(const QString&) const", typeof(string), typeof(string), qualifiedName);
		}
		public void Append(string namespaceUri, string name, string value) {
			interceptor.Invoke("append$$$", "append(const QString&, const QString&, const QString&)", typeof(void), typeof(string), namespaceUri, typeof(string), name, typeof(string), value);
		}
		public void Append(string qualifiedName, string value) {
			interceptor.Invoke("append$$", "append(const QString&, const QString&)", typeof(void), typeof(string), qualifiedName, typeof(string), value);
		}
		public void Append(QXmlStreamAttribute attribute) {
			interceptor.Invoke("append#", "append(const QXmlStreamAttribute&)", typeof(void), typeof(QXmlStreamAttribute), attribute);
		}
		public QXmlStreamAttributes() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QXmlStreamAttributes", "QXmlStreamAttributes()", typeof(void));
		}
		~QXmlStreamAttributes() {
			interceptor.Invoke("~QXmlStreamAttributes", "~QXmlStreamAttributes()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QXmlStreamAttributes", "~QXmlStreamAttributes()", typeof(void));
		}
	}
}
