//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QContextMenuEvent")]
	public class QContextMenuEvent : QEvent, IDisposable {
 		protected QContextMenuEvent(Type dummy) : base((Type) null) {}
		interface IQContextMenuEventProxy {
		}

		protected void CreateQContextMenuEventProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QContextMenuEvent), this);
			_interceptor = (QContextMenuEvent) realProxy.GetTransparentProxy();
		}
		private QContextMenuEvent ProxyQContextMenuEvent() {
			return (QContextMenuEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QContextMenuEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQContextMenuEventProxy), null);
			_staticInterceptor = (IQContextMenuEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQContextMenuEventProxy StaticQContextMenuEvent() {
			return (IQContextMenuEventProxy) _staticInterceptor;
		}

		public enum Reason {
			Mouse = 0,
			Keyboard = 1,
			Other = 2,
		}
		public QContextMenuEvent(QContextMenuEvent.Reason reason, QPoint pos, QPoint globalPos, int state) : this((Type) null) {
			CreateQContextMenuEventProxy();
			NewQContextMenuEvent(reason,pos,globalPos,state);
		}
		[SmokeMethod("QContextMenuEvent(QContextMenuEvent::Reason, const QPoint&, const QPoint&, int)")]
		private void NewQContextMenuEvent(QContextMenuEvent.Reason reason, QPoint pos, QPoint globalPos, int state) {
			ProxyQContextMenuEvent().NewQContextMenuEvent(reason,pos,globalPos,state);
		}
		public QContextMenuEvent(QContextMenuEvent.Reason reason, QPoint pos, int state) : this((Type) null) {
			CreateQContextMenuEventProxy();
			NewQContextMenuEvent(reason,pos,state);
		}
		[SmokeMethod("QContextMenuEvent(QContextMenuEvent::Reason, const QPoint&, int)")]
		private void NewQContextMenuEvent(QContextMenuEvent.Reason reason, QPoint pos, int state) {
			ProxyQContextMenuEvent().NewQContextMenuEvent(reason,pos,state);
		}
		[SmokeMethod("x() const")]
		public int X() {
			return ProxyQContextMenuEvent().X();
		}
		[SmokeMethod("y() const")]
		public int Y() {
			return ProxyQContextMenuEvent().Y();
		}
		[SmokeMethod("globalX() const")]
		public int GlobalX() {
			return ProxyQContextMenuEvent().GlobalX();
		}
		[SmokeMethod("globalY() const")]
		public int GlobalY() {
			return ProxyQContextMenuEvent().GlobalY();
		}
		[SmokeMethod("pos() const")]
		public QPoint Pos() {
			return ProxyQContextMenuEvent().Pos();
		}
		[SmokeMethod("globalPos() const")]
		public QPoint GlobalPos() {
			return ProxyQContextMenuEvent().GlobalPos();
		}
		[SmokeMethod("state() const")]
		public Qt.ButtonState State() {
			return ProxyQContextMenuEvent().State();
		}
		[SmokeMethod("isAccepted() const")]
		public bool IsAccepted() {
			return ProxyQContextMenuEvent().IsAccepted();
		}
		[SmokeMethod("isConsumed() const")]
		public bool IsConsumed() {
			return ProxyQContextMenuEvent().IsConsumed();
		}
		[SmokeMethod("consume()")]
		public void Consume() {
			ProxyQContextMenuEvent().Consume();
		}
		[SmokeMethod("accept()")]
		public void Accept() {
			ProxyQContextMenuEvent().Accept();
		}
		[SmokeMethod("ignore()")]
		public void Ignore() {
			ProxyQContextMenuEvent().Ignore();
		}
		[SmokeMethod("reason() const")]
		public QContextMenuEvent.Reason reason() {
			return ProxyQContextMenuEvent().reason();
		}
		~QContextMenuEvent() {
			DisposeQContextMenuEvent();
		}
		public new void Dispose() {
			DisposeQContextMenuEvent();
		}
		private void DisposeQContextMenuEvent() {
			ProxyQContextMenuEvent().DisposeQContextMenuEvent();
		}
	}
}
