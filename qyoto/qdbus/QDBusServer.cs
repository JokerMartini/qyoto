//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QDBusServer")]
	public class QDBusServer : QObject, IDisposable {
 		protected QDBusServer(Type dummy) : base((Type) null) {}
		[SmokeClass("QDBusServer")]
		interface IQDBusServerProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDBusServer), this);
			_interceptor = (QDBusServer) realProxy.GetTransparentProxy();
		}
		private QDBusServer ProxyQDBusServer() {
			return (QDBusServer) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDBusServer() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDBusServerProxy), null);
			_staticInterceptor = (IQDBusServerProxy) realProxy.GetTransparentProxy();
		}
		private static IQDBusServerProxy StaticQDBusServer() {
			return (IQDBusServerProxy) _staticInterceptor;
		}
		public QDBusServer(string address, QObject parent) : this((Type) null) {
			CreateProxy();
			NewQDBusServer(address,parent);
		}
		[SmokeMethod("QDBusServer", "(const QString&, QObject*)", "$#")]
		private void NewQDBusServer(string address, QObject parent) {
			ProxyQDBusServer().NewQDBusServer(address,parent);
		}
		public QDBusServer(string address) : this((Type) null) {
			CreateProxy();
			NewQDBusServer(address);
		}
		[SmokeMethod("QDBusServer", "(const QString&)", "$")]
		private void NewQDBusServer(string address) {
			ProxyQDBusServer().NewQDBusServer(address);
		}
		[SmokeMethod("isConnected", "() const", "")]
		public bool IsConnected() {
			return ProxyQDBusServer().IsConnected();
		}
		[SmokeMethod("lastError", "() const", "")]
		public QDBusError LastError() {
			return ProxyQDBusServer().LastError();
		}
		[SmokeMethod("address", "() const", "")]
		public string Address() {
			return ProxyQDBusServer().Address();
		}
		public static string Tr(string s, string c) {
			return StaticQDBusServer().Tr(s,c);
		}
		public static string Tr(string s) {
			return StaticQDBusServer().Tr(s);
		}
		~QDBusServer() {
			DisposeQDBusServer();
		}
		public new void Dispose() {
			DisposeQDBusServer();
		}
		[SmokeMethod("~QDBusServer", "()", "")]
		private void DisposeQDBusServer() {
			ProxyQDBusServer().DisposeQDBusServer();
		}
		protected new IQDBusServerSignals Emit {
			get { return (IQDBusServerSignals) Q_EMIT; }
		}
	}

	public interface IQDBusServerSignals : IQObjectSignals {
	}
}
