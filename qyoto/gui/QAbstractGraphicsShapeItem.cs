//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QAbstractGraphicsShapeItem")]
	public class QAbstractGraphicsShapeItem : QGraphicsItem, IDisposable {
 		protected QAbstractGraphicsShapeItem(Type dummy) : base((Type) null) {}
		interface IQAbstractGraphicsShapeItemProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QAbstractGraphicsShapeItem), this);
			_interceptor = (QAbstractGraphicsShapeItem) realProxy.GetTransparentProxy();
		}
		private QAbstractGraphicsShapeItem ProxyQAbstractGraphicsShapeItem() {
			return (QAbstractGraphicsShapeItem) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QAbstractGraphicsShapeItem() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQAbstractGraphicsShapeItemProxy), null);
			_staticInterceptor = (IQAbstractGraphicsShapeItemProxy) realProxy.GetTransparentProxy();
		}
		private static IQAbstractGraphicsShapeItemProxy StaticQAbstractGraphicsShapeItem() {
			return (IQAbstractGraphicsShapeItemProxy) _staticInterceptor;
		}

		public QAbstractGraphicsShapeItem(QGraphicsItem parent, QGraphicsScene scene) : this((Type) null) {
			CreateProxy();
			NewQAbstractGraphicsShapeItem(parent,scene);
		}
		[SmokeMethod("QAbstractGraphicsShapeItem(QGraphicsItem*, QGraphicsScene*)")]
		private void NewQAbstractGraphicsShapeItem(QGraphicsItem parent, QGraphicsScene scene) {
			ProxyQAbstractGraphicsShapeItem().NewQAbstractGraphicsShapeItem(parent,scene);
		}
		public QAbstractGraphicsShapeItem(QGraphicsItem parent) : this((Type) null) {
			CreateProxy();
			NewQAbstractGraphicsShapeItem(parent);
		}
		[SmokeMethod("QAbstractGraphicsShapeItem(QGraphicsItem*)")]
		private void NewQAbstractGraphicsShapeItem(QGraphicsItem parent) {
			ProxyQAbstractGraphicsShapeItem().NewQAbstractGraphicsShapeItem(parent);
		}
		public QAbstractGraphicsShapeItem() : this((Type) null) {
			CreateProxy();
			NewQAbstractGraphicsShapeItem();
		}
		[SmokeMethod("QAbstractGraphicsShapeItem()")]
		private void NewQAbstractGraphicsShapeItem() {
			ProxyQAbstractGraphicsShapeItem().NewQAbstractGraphicsShapeItem();
		}
		[SmokeMethod("pen() const")]
		public QPen Pen() {
			return ProxyQAbstractGraphicsShapeItem().Pen();
		}
		[SmokeMethod("setPen(const QPen&)")]
		public void SetPen(QPen pen) {
			ProxyQAbstractGraphicsShapeItem().SetPen(pen);
		}
		[SmokeMethod("brush() const")]
		public QBrush Brush() {
			return ProxyQAbstractGraphicsShapeItem().Brush();
		}
		[SmokeMethod("setBrush(const QBrush&)")]
		public void SetBrush(QBrush brush) {
			ProxyQAbstractGraphicsShapeItem().SetBrush(brush);
		}
		[SmokeMethod("isObscuredBy(const QGraphicsItem*) const")]
		public new bool IsObscuredBy(QGraphicsItem item) {
			return ProxyQAbstractGraphicsShapeItem().IsObscuredBy(item);
		}
		[SmokeMethod("opaqueArea() const")]
		public new QPainterPath OpaqueArea() {
			return ProxyQAbstractGraphicsShapeItem().OpaqueArea();
		}
		~QAbstractGraphicsShapeItem() {
			DisposeQAbstractGraphicsShapeItem();
		}
		public new void Dispose() {
			DisposeQAbstractGraphicsShapeItem();
		}
		[SmokeMethod("~QAbstractGraphicsShapeItem()")]
		private void DisposeQAbstractGraphicsShapeItem() {
			ProxyQAbstractGraphicsShapeItem().DisposeQAbstractGraphicsShapeItem();
		}
	}
}
