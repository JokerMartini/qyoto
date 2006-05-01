//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QWheelEvent")]
	public class QWheelEvent : QInputEvent, IDisposable {
 		protected QWheelEvent(Type dummy) : base((Type) null) {}
		interface IQWheelEventProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QWheelEvent), this);
			_interceptor = (QWheelEvent) realProxy.GetTransparentProxy();
		}
		private QWheelEvent ProxyQWheelEvent() {
			return (QWheelEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QWheelEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQWheelEventProxy), null);
			_staticInterceptor = (IQWheelEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQWheelEventProxy StaticQWheelEvent() {
			return (IQWheelEventProxy) _staticInterceptor;
		}

		public QWheelEvent(QPoint pos, int delta, int buttons, int modifiers, Qt.Orientation orient) : this((Type) null) {
			CreateProxy();
			NewQWheelEvent(pos,delta,buttons,modifiers,orient);
		}
		[SmokeMethod("QWheelEvent(const QPoint&, int, Qt::MouseButtons, Qt::KeyboardModifiers, Qt::Orientation)")]
		private void NewQWheelEvent(QPoint pos, int delta, int buttons, int modifiers, Qt.Orientation orient) {
			ProxyQWheelEvent().NewQWheelEvent(pos,delta,buttons,modifiers,orient);
		}
		public QWheelEvent(QPoint pos, int delta, int buttons, int modifiers) : this((Type) null) {
			CreateProxy();
			NewQWheelEvent(pos,delta,buttons,modifiers);
		}
		[SmokeMethod("QWheelEvent(const QPoint&, int, Qt::MouseButtons, Qt::KeyboardModifiers)")]
		private void NewQWheelEvent(QPoint pos, int delta, int buttons, int modifiers) {
			ProxyQWheelEvent().NewQWheelEvent(pos,delta,buttons,modifiers);
		}
		public QWheelEvent(QPoint pos, QPoint globalPos, int delta, int buttons, int modifiers, Qt.Orientation orient) : this((Type) null) {
			CreateProxy();
			NewQWheelEvent(pos,globalPos,delta,buttons,modifiers,orient);
		}
		[SmokeMethod("QWheelEvent(const QPoint&, const QPoint&, int, Qt::MouseButtons, Qt::KeyboardModifiers, Qt::Orientation)")]
		private void NewQWheelEvent(QPoint pos, QPoint globalPos, int delta, int buttons, int modifiers, Qt.Orientation orient) {
			ProxyQWheelEvent().NewQWheelEvent(pos,globalPos,delta,buttons,modifiers,orient);
		}
		public QWheelEvent(QPoint pos, QPoint globalPos, int delta, int buttons, int modifiers) : this((Type) null) {
			CreateProxy();
			NewQWheelEvent(pos,globalPos,delta,buttons,modifiers);
		}
		[SmokeMethod("QWheelEvent(const QPoint&, const QPoint&, int, Qt::MouseButtons, Qt::KeyboardModifiers)")]
		private void NewQWheelEvent(QPoint pos, QPoint globalPos, int delta, int buttons, int modifiers) {
			ProxyQWheelEvent().NewQWheelEvent(pos,globalPos,delta,buttons,modifiers);
		}
		[SmokeMethod("delta() const")]
		public int Delta() {
			return ProxyQWheelEvent().Delta();
		}
		[SmokeMethod("pos() const")]
		public QPoint Pos() {
			return ProxyQWheelEvent().Pos();
		}
		[SmokeMethod("globalPos() const")]
		public QPoint GlobalPos() {
			return ProxyQWheelEvent().GlobalPos();
		}
		[SmokeMethod("x() const")]
		public int X() {
			return ProxyQWheelEvent().X();
		}
		[SmokeMethod("y() const")]
		public int Y() {
			return ProxyQWheelEvent().Y();
		}
		[SmokeMethod("globalX() const")]
		public int GlobalX() {
			return ProxyQWheelEvent().GlobalX();
		}
		[SmokeMethod("globalY() const")]
		public int GlobalY() {
			return ProxyQWheelEvent().GlobalY();
		}
		[SmokeMethod("buttons() const")]
		public int Buttons() {
			return ProxyQWheelEvent().Buttons();
		}
		[SmokeMethod("orientation() const")]
		public Qt.Orientation Orientation() {
			return ProxyQWheelEvent().Orientation();
		}
		~QWheelEvent() {
			DisposeQWheelEvent();
		}
		public new void Dispose() {
			DisposeQWheelEvent();
		}
		private void DisposeQWheelEvent() {
			ProxyQWheelEvent().DisposeQWheelEvent();
		}
	}
}
