//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    /// <remarks> See <see cref="IQDBusServerSignals"></see> for signals emitted by QDBusServer
    /// </remarks>
    [SmokeClass("QDBusServer")]
    public class QDBusServer : QObject, IDisposable {
        protected QDBusServer(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QDBusServer), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QDBusServer() {
            staticInterceptor = new SmokeInvocation(typeof(QDBusServer), null);
        }
        public QDBusServer(string address, QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QDBusServer$#", "QDBusServer(const QString&, QObject*)", typeof(void), typeof(string), address, typeof(QObject), parent);
        }
        public QDBusServer(string address) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QDBusServer$", "QDBusServer(const QString&)", typeof(void), typeof(string), address);
        }
        public bool IsConnected() {
            return (bool) interceptor.Invoke("isConnected", "isConnected() const", typeof(bool));
        }
        public QDBusError LastError() {
            return (QDBusError) interceptor.Invoke("lastError", "lastError() const", typeof(QDBusError));
        }
        public string Address() {
            return (string) interceptor.Invoke("address", "address() const", typeof(string));
        }
        ~QDBusServer() {
            interceptor.Invoke("~QDBusServer", "~QDBusServer()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QDBusServer", "~QDBusServer()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQDBusServerSignals Emit {
            get { return (IQDBusServerSignals) Q_EMIT; }
        }
    }

    public interface IQDBusServerSignals : IQObjectSignals {
        [Q_SIGNAL("void newConnection(QDBusConnection)")]
        void NewConnection(QDBusConnection connection);
    }
}
