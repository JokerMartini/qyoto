//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QHoverEvent")]
	public class QHoverEvent : QEvent, IDisposable {
 		protected QHoverEvent(Type dummy) : base((Type) null) {}
		interface IQHoverEventProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QHoverEvent), this);
			_interceptor = (QHoverEvent) realProxy.GetTransparentProxy();
		}
		private QHoverEvent ProxyQHoverEvent() {
			return (QHoverEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QHoverEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQHoverEventProxy), null);
			_staticInterceptor = (IQHoverEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQHoverEventProxy StaticQHoverEvent() {
			return (IQHoverEventProxy) _staticInterceptor;
		}

		public QHoverEvent(QEvent.E_Type type, QPoint pos, QPoint oldPos) : this((Type) null) {
			CreateProxy();
			NewQHoverEvent(type,pos,oldPos);
		}
		[SmokeMethod("QHoverEvent(QEvent::Type, const QPoint&, const QPoint&)")]
		private void NewQHoverEvent(QEvent.E_Type type, QPoint pos, QPoint oldPos) {
			ProxyQHoverEvent().NewQHoverEvent(type,pos,oldPos);
		}
		[SmokeMethod("pos() const")]
		public QPoint Pos() {
			return ProxyQHoverEvent().Pos();
		}
		[SmokeMethod("oldPos() const")]
		public QPoint OldPos() {
			return ProxyQHoverEvent().OldPos();
		}
		~QHoverEvent() {
			DisposeQHoverEvent();
		}
		public new void Dispose() {
			DisposeQHoverEvent();
		}
		private void DisposeQHoverEvent() {
			ProxyQHoverEvent().DisposeQHoverEvent();
		}
	}
}
