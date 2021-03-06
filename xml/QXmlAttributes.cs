//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QXmlAttributes")]
    public class QXmlAttributes : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QXmlAttributes(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QXmlAttributes), this);
        }
        // int index(const QLatin1String& arg1); >>>> NOT CONVERTED
        // QString value(const QLatin1String& arg1); >>>> NOT CONVERTED
        public QXmlAttributes() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QXmlAttributes", "QXmlAttributes()", typeof(void));
        }
        public int Index(string qName) {
            return (int) interceptor.Invoke("index$", "index(const QString&) const", typeof(int), typeof(string), qName);
        }
        public int Index(string uri, string localPart) {
            return (int) interceptor.Invoke("index$$", "index(const QString&, const QString&) const", typeof(int), typeof(string), uri, typeof(string), localPart);
        }
        public int Length() {
            return (int) interceptor.Invoke("length", "length() const", typeof(int));
        }
        public int Count() {
            return (int) interceptor.Invoke("count", "count() const", typeof(int));
        }
        public string LocalName(int index) {
            return (string) interceptor.Invoke("localName$", "localName(int) const", typeof(string), typeof(int), index);
        }
        public string QName(int index) {
            return (string) interceptor.Invoke("qName$", "qName(int) const", typeof(string), typeof(int), index);
        }
        public string Uri(int index) {
            return (string) interceptor.Invoke("uri$", "uri(int) const", typeof(string), typeof(int), index);
        }
        public string type(int index) {
            return (string) interceptor.Invoke("type$", "type(int) const", typeof(string), typeof(int), index);
        }
        public string type(string qName) {
            return (string) interceptor.Invoke("type$", "type(const QString&) const", typeof(string), typeof(string), qName);
        }
        public string type(string uri, string localName) {
            return (string) interceptor.Invoke("type$$", "type(const QString&, const QString&) const", typeof(string), typeof(string), uri, typeof(string), localName);
        }
        public string Value(int index) {
            return (string) interceptor.Invoke("value$", "value(int) const", typeof(string), typeof(int), index);
        }
        public string Value(string qName) {
            return (string) interceptor.Invoke("value$", "value(const QString&) const", typeof(string), typeof(string), qName);
        }
        public string Value(string uri, string localName) {
            return (string) interceptor.Invoke("value$$", "value(const QString&, const QString&) const", typeof(string), typeof(string), uri, typeof(string), localName);
        }
        public void Clear() {
            interceptor.Invoke("clear", "clear()", typeof(void));
        }
        public void Append(string qName, string uri, string localPart, string value) {
            interceptor.Invoke("append$$$$", "append(const QString&, const QString&, const QString&, const QString&)", typeof(void), typeof(string), qName, typeof(string), uri, typeof(string), localPart, typeof(string), value);
        }
        ~QXmlAttributes() {
            interceptor.Invoke("~QXmlAttributes", "~QXmlAttributes()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QXmlAttributes", "~QXmlAttributes()", typeof(void));
        }
    }
}
