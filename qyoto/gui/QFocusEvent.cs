//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QFocusEvent")]
	public class QFocusEvent : QEvent, IDisposable {
 		protected QFocusEvent(Type dummy) : base((Type) null) {}
		interface IQFocusEventProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QFocusEvent), this);
			_interceptor = (QFocusEvent) realProxy.GetTransparentProxy();
		}
		private QFocusEvent ProxyQFocusEvent() {
			return (QFocusEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QFocusEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQFocusEventProxy), null);
			_staticInterceptor = (IQFocusEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQFocusEventProxy StaticQFocusEvent() {
			return (IQFocusEventProxy) _staticInterceptor;
		}

		public QFocusEvent(QEvent.E_Type type, Qt.FocusReason reason) : this((Type) null) {
			CreateProxy();
			NewQFocusEvent(type,reason);
		}
		[SmokeMethod("QFocusEvent(QEvent::Type, Qt::FocusReason)")]
		private void NewQFocusEvent(QEvent.E_Type type, Qt.FocusReason reason) {
			ProxyQFocusEvent().NewQFocusEvent(type,reason);
		}
		public QFocusEvent(QEvent.E_Type type) : this((Type) null) {
			CreateProxy();
			NewQFocusEvent(type);
		}
		[SmokeMethod("QFocusEvent(QEvent::Type)")]
		private void NewQFocusEvent(QEvent.E_Type type) {
			ProxyQFocusEvent().NewQFocusEvent(type);
		}
		[SmokeMethod("gotFocus() const")]
		public bool GotFocus() {
			return ProxyQFocusEvent().GotFocus();
		}
		[SmokeMethod("lostFocus() const")]
		public bool LostFocus() {
			return ProxyQFocusEvent().LostFocus();
		}
		[SmokeMethod("reason()")]
		public Qt.FocusReason Reason() {
			return ProxyQFocusEvent().Reason();
		}
		~QFocusEvent() {
			DisposeQFocusEvent();
		}
		public new void Dispose() {
			DisposeQFocusEvent();
		}
		[SmokeMethod("~QFocusEvent()")]
		private void DisposeQFocusEvent() {
			ProxyQFocusEvent().DisposeQFocusEvent();
		}
	}
}