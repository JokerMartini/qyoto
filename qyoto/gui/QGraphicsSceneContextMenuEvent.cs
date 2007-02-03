//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QGraphicsSceneContextMenuEvent")]
	public class QGraphicsSceneContextMenuEvent : QGraphicsSceneEvent, IDisposable {
 		protected QGraphicsSceneContextMenuEvent(Type dummy) : base((Type) null) {}
		[SmokeClass("QGraphicsSceneContextMenuEvent")]
		interface IQGraphicsSceneContextMenuEventProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGraphicsSceneContextMenuEvent), this);
			_interceptor = (QGraphicsSceneContextMenuEvent) realProxy.GetTransparentProxy();
		}
		private QGraphicsSceneContextMenuEvent ProxyQGraphicsSceneContextMenuEvent() {
			return (QGraphicsSceneContextMenuEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGraphicsSceneContextMenuEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGraphicsSceneContextMenuEventProxy), null);
			_staticInterceptor = (IQGraphicsSceneContextMenuEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQGraphicsSceneContextMenuEventProxy StaticQGraphicsSceneContextMenuEvent() {
			return (IQGraphicsSceneContextMenuEventProxy) _staticInterceptor;
		}

		public enum Reason {
			Mouse = 0,
			Keyboard = 1,
			Other = 2,
		}
		public QGraphicsSceneContextMenuEvent(QEvent.TypeOf type) : this((Type) null) {
			CreateProxy();
			NewQGraphicsSceneContextMenuEvent(type);
		}
		[SmokeMethod("QGraphicsSceneContextMenuEvent", "(QEvent::Type)", "$")]
		private void NewQGraphicsSceneContextMenuEvent(QEvent.TypeOf type) {
			ProxyQGraphicsSceneContextMenuEvent().NewQGraphicsSceneContextMenuEvent(type);
		}
		public QGraphicsSceneContextMenuEvent() : this((Type) null) {
			CreateProxy();
			NewQGraphicsSceneContextMenuEvent();
		}
		[SmokeMethod("QGraphicsSceneContextMenuEvent", "()", "")]
		private void NewQGraphicsSceneContextMenuEvent() {
			ProxyQGraphicsSceneContextMenuEvent().NewQGraphicsSceneContextMenuEvent();
		}
		[SmokeMethod("pos", "() const", "")]
		public QPointF Pos() {
			return ProxyQGraphicsSceneContextMenuEvent().Pos();
		}
		[SmokeMethod("setPos", "(const QPointF&)", "#")]
		public void SetPos(QPointF pos) {
			ProxyQGraphicsSceneContextMenuEvent().SetPos(pos);
		}
		[SmokeMethod("scenePos", "() const", "")]
		public QPointF ScenePos() {
			return ProxyQGraphicsSceneContextMenuEvent().ScenePos();
		}
		[SmokeMethod("setScenePos", "(const QPointF&)", "#")]
		public void SetScenePos(QPointF pos) {
			ProxyQGraphicsSceneContextMenuEvent().SetScenePos(pos);
		}
		[SmokeMethod("screenPos", "() const", "")]
		public QPoint ScreenPos() {
			return ProxyQGraphicsSceneContextMenuEvent().ScreenPos();
		}
		[SmokeMethod("setScreenPos", "(const QPoint&)", "#")]
		public void SetScreenPos(QPoint pos) {
			ProxyQGraphicsSceneContextMenuEvent().SetScreenPos(pos);
		}
		[SmokeMethod("modifiers", "() const", "")]
		public int Modifiers() {
			return ProxyQGraphicsSceneContextMenuEvent().Modifiers();
		}
		[SmokeMethod("setModifiers", "(Qt::KeyboardModifiers)", "$")]
		public void SetModifiers(int modifiers) {
			ProxyQGraphicsSceneContextMenuEvent().SetModifiers(modifiers);
		}
		[SmokeMethod("reason", "() const", "")]
		public QGraphicsSceneContextMenuEvent.Reason reason() {
			return ProxyQGraphicsSceneContextMenuEvent().reason();
		}
		[SmokeMethod("setReason", "(QGraphicsSceneContextMenuEvent::Reason)", "$")]
		public void SetReason(QGraphicsSceneContextMenuEvent.Reason reason) {
			ProxyQGraphicsSceneContextMenuEvent().SetReason(reason);
		}
		~QGraphicsSceneContextMenuEvent() {
			DisposeQGraphicsSceneContextMenuEvent();
		}
		public new void Dispose() {
			DisposeQGraphicsSceneContextMenuEvent();
		}
		[SmokeMethod("~QGraphicsSceneContextMenuEvent", "()", "")]
		private void DisposeQGraphicsSceneContextMenuEvent() {
			ProxyQGraphicsSceneContextMenuEvent().DisposeQGraphicsSceneContextMenuEvent();
		}
	}
}
