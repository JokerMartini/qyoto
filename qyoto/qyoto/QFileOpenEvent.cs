//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QFileOpenEvent")]
	public class QFileOpenEvent : QEvent, IDisposable {
 		protected QFileOpenEvent(Type dummy) : base((Type) null) {}
		interface IQFileOpenEventProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QFileOpenEvent), this);
			_interceptor = (QFileOpenEvent) realProxy.GetTransparentProxy();
		}
		private QFileOpenEvent ProxyQFileOpenEvent() {
			return (QFileOpenEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QFileOpenEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQFileOpenEventProxy), null);
			_staticInterceptor = (IQFileOpenEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQFileOpenEventProxy StaticQFileOpenEvent() {
			return (IQFileOpenEventProxy) _staticInterceptor;
		}

		public QFileOpenEvent(string file) : this((Type) null) {
			CreateProxy();
			NewQFileOpenEvent(file);
		}
		[SmokeMethod("QFileOpenEvent(const QString&)")]
		private void NewQFileOpenEvent(string file) {
			ProxyQFileOpenEvent().NewQFileOpenEvent(file);
		}
		[SmokeMethod("file() const")]
		public string File() {
			return ProxyQFileOpenEvent().File();
		}
		~QFileOpenEvent() {
			DisposeQFileOpenEvent();
		}
		public new void Dispose() {
			DisposeQFileOpenEvent();
		}
		private void DisposeQFileOpenEvent() {
			ProxyQFileOpenEvent().DisposeQFileOpenEvent();
		}
	}
}
