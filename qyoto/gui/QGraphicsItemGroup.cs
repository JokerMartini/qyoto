//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QGraphicsItemGroup")]
	public class QGraphicsItemGroup : QGraphicsItem, IDisposable {
 		protected QGraphicsItemGroup(Type dummy) : base((Type) null) {}
		interface IQGraphicsItemGroupProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGraphicsItemGroup), this);
			_interceptor = (QGraphicsItemGroup) realProxy.GetTransparentProxy();
		}
		private QGraphicsItemGroup ProxyQGraphicsItemGroup() {
			return (QGraphicsItemGroup) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGraphicsItemGroup() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGraphicsItemGroupProxy), null);
			_staticInterceptor = (IQGraphicsItemGroupProxy) realProxy.GetTransparentProxy();
		}
		private static IQGraphicsItemGroupProxy StaticQGraphicsItemGroup() {
			return (IQGraphicsItemGroupProxy) _staticInterceptor;
		}

		public const int Type = 10;

		public QGraphicsItemGroup(QGraphicsItem parent, QGraphicsScene scene) : this((Type) null) {
			CreateProxy();
			NewQGraphicsItemGroup(parent,scene);
		}
		[SmokeMethod("QGraphicsItemGroup(QGraphicsItem*, QGraphicsScene*)")]
		private void NewQGraphicsItemGroup(QGraphicsItem parent, QGraphicsScene scene) {
			ProxyQGraphicsItemGroup().NewQGraphicsItemGroup(parent,scene);
		}
		public QGraphicsItemGroup(QGraphicsItem parent) : this((Type) null) {
			CreateProxy();
			NewQGraphicsItemGroup(parent);
		}
		[SmokeMethod("QGraphicsItemGroup(QGraphicsItem*)")]
		private void NewQGraphicsItemGroup(QGraphicsItem parent) {
			ProxyQGraphicsItemGroup().NewQGraphicsItemGroup(parent);
		}
		public QGraphicsItemGroup() : this((Type) null) {
			CreateProxy();
			NewQGraphicsItemGroup();
		}
		[SmokeMethod("QGraphicsItemGroup()")]
		private void NewQGraphicsItemGroup() {
			ProxyQGraphicsItemGroup().NewQGraphicsItemGroup();
		}
		[SmokeMethod("addToGroup(QGraphicsItem*)")]
		public void AddToGroup(QGraphicsItem item) {
			ProxyQGraphicsItemGroup().AddToGroup(item);
		}
		[SmokeMethod("removeFromGroup(QGraphicsItem*)")]
		public void RemoveFromGroup(QGraphicsItem item) {
			ProxyQGraphicsItemGroup().RemoveFromGroup(item);
		}
		[SmokeMethod("boundingRect() const")]
		public new QRectF BoundingRect() {
			return ProxyQGraphicsItemGroup().BoundingRect();
		}
		[SmokeMethod("paint(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)")]
		public new void Paint(QPainter painter, QStyleOptionGraphicsItem option, QWidget widget) {
			ProxyQGraphicsItemGroup().Paint(painter,option,widget);
		}
		[SmokeMethod("paint(QPainter*, const QStyleOptionGraphicsItem*)")]
		public new void Paint(QPainter painter, QStyleOptionGraphicsItem option) {
			ProxyQGraphicsItemGroup().Paint(painter,option);
		}
		[SmokeMethod("isObscuredBy(const QGraphicsItem*) const")]
		public new bool IsObscuredBy(QGraphicsItem item) {
			return ProxyQGraphicsItemGroup().IsObscuredBy(item);
		}
		[SmokeMethod("opaqueArea() const")]
		public new QPainterPath OpaqueArea() {
			return ProxyQGraphicsItemGroup().OpaqueArea();
		}
		[SmokeMethod("type() const")]
		public new int type() {
			return ProxyQGraphicsItemGroup().type();
		}
		~QGraphicsItemGroup() {
			DisposeQGraphicsItemGroup();
		}
		public void Dispose() {
			DisposeQGraphicsItemGroup();
		}
		[SmokeMethod("~QGraphicsItemGroup()")]
		private void DisposeQGraphicsItemGroup() {
			ProxyQGraphicsItemGroup().DisposeQGraphicsItemGroup();
		}
	}
}
