//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QIMComposeEvent")]
	public class QIMComposeEvent : QIMEvent, IDisposable {
 		protected QIMComposeEvent(Type dummy) : base((Type) null) {}
		interface IQIMComposeEventProxy {
		}

		protected void CreateQIMComposeEventProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QIMComposeEvent), this);
			_interceptor = (QIMComposeEvent) realProxy.GetTransparentProxy();
		}
		private QIMComposeEvent ProxyQIMComposeEvent() {
			return (QIMComposeEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QIMComposeEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQIMComposeEventProxy), null);
			_staticInterceptor = (IQIMComposeEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQIMComposeEventProxy StaticQIMComposeEvent() {
			return (IQIMComposeEventProxy) _staticInterceptor;
		}

		public QIMComposeEvent(QEvent.E_Type type, string text, int cursorPosition, int selLength) : this((Type) null) {
			CreateQIMComposeEventProxy();
			NewQIMComposeEvent(type,text,cursorPosition,selLength);
		}
		[SmokeMethod("QIMComposeEvent(QEvent::Type, const QString&, int, int)")]
		private void NewQIMComposeEvent(QEvent.E_Type type, string text, int cursorPosition, int selLength) {
			ProxyQIMComposeEvent().NewQIMComposeEvent(type,text,cursorPosition,selLength);
		}
		~QIMComposeEvent() {
			DisposeQIMComposeEvent();
		}
		public new void Dispose() {
			DisposeQIMComposeEvent();
		}
		private void DisposeQIMComposeEvent() {
			ProxyQIMComposeEvent().DisposeQIMComposeEvent();
		}
	}
}
