//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QGraphicsPolygonItem")]
	public class QGraphicsPolygonItem : QAbstractGraphicsShapeItem, IDisposable {
 		protected QGraphicsPolygonItem(Type dummy) : base((Type) null) {}
		[SmokeClass("QGraphicsPolygonItem")]
		interface IQGraphicsPolygonItemProxy {
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGraphicsPolygonItem), this);
			_interceptor = (QGraphicsPolygonItem) realProxy.GetTransparentProxy();
		}
		private QGraphicsPolygonItem ProxyQGraphicsPolygonItem() {
			return (QGraphicsPolygonItem) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGraphicsPolygonItem() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGraphicsPolygonItemProxy), null);
			_staticInterceptor = (IQGraphicsPolygonItemProxy) realProxy.GetTransparentProxy();
		}
		private static IQGraphicsPolygonItemProxy StaticQGraphicsPolygonItem() {
			return (IQGraphicsPolygonItemProxy) _staticInterceptor;
		}
		public const int Type = 5;

		public QGraphicsPolygonItem(QGraphicsItem parent, QGraphicsScene scene) : this((Type) null) {
			CreateProxy();
			NewQGraphicsPolygonItem(parent,scene);
		}
		[SmokeMethod("QGraphicsPolygonItem", "(QGraphicsItem*, QGraphicsScene*)", "##")]
		private void NewQGraphicsPolygonItem(QGraphicsItem parent, QGraphicsScene scene) {
			ProxyQGraphicsPolygonItem().NewQGraphicsPolygonItem(parent,scene);
		}
		public QGraphicsPolygonItem(QGraphicsItem parent) : this((Type) null) {
			CreateProxy();
			NewQGraphicsPolygonItem(parent);
		}
		[SmokeMethod("QGraphicsPolygonItem", "(QGraphicsItem*)", "#")]
		private void NewQGraphicsPolygonItem(QGraphicsItem parent) {
			ProxyQGraphicsPolygonItem().NewQGraphicsPolygonItem(parent);
		}
		public QGraphicsPolygonItem() : this((Type) null) {
			CreateProxy();
			NewQGraphicsPolygonItem();
		}
		[SmokeMethod("QGraphicsPolygonItem", "()", "")]
		private void NewQGraphicsPolygonItem() {
			ProxyQGraphicsPolygonItem().NewQGraphicsPolygonItem();
		}
		public QGraphicsPolygonItem(QPolygonF polygon, QGraphicsItem parent, QGraphicsScene scene) : this((Type) null) {
			CreateProxy();
			NewQGraphicsPolygonItem(polygon,parent,scene);
		}
		[SmokeMethod("QGraphicsPolygonItem", "(const QPolygonF&, QGraphicsItem*, QGraphicsScene*)", "###")]
		private void NewQGraphicsPolygonItem(QPolygonF polygon, QGraphicsItem parent, QGraphicsScene scene) {
			ProxyQGraphicsPolygonItem().NewQGraphicsPolygonItem(polygon,parent,scene);
		}
		public QGraphicsPolygonItem(QPolygonF polygon, QGraphicsItem parent) : this((Type) null) {
			CreateProxy();
			NewQGraphicsPolygonItem(polygon,parent);
		}
		[SmokeMethod("QGraphicsPolygonItem", "(const QPolygonF&, QGraphicsItem*)", "##")]
		private void NewQGraphicsPolygonItem(QPolygonF polygon, QGraphicsItem parent) {
			ProxyQGraphicsPolygonItem().NewQGraphicsPolygonItem(polygon,parent);
		}
		public QGraphicsPolygonItem(QPolygonF polygon) : this((Type) null) {
			CreateProxy();
			NewQGraphicsPolygonItem(polygon);
		}
		[SmokeMethod("QGraphicsPolygonItem", "(const QPolygonF&)", "#")]
		private void NewQGraphicsPolygonItem(QPolygonF polygon) {
			ProxyQGraphicsPolygonItem().NewQGraphicsPolygonItem(polygon);
		}
		[SmokeMethod("polygon", "() const", "")]
		public QPolygonF Polygon() {
			return ProxyQGraphicsPolygonItem().Polygon();
		}
		[SmokeMethod("setPolygon", "(const QPolygonF&)", "#")]
		public void SetPolygon(QPolygonF polygon) {
			ProxyQGraphicsPolygonItem().SetPolygon(polygon);
		}
		[SmokeMethod("fillRule", "() const", "")]
		public Qt.FillRule FillRule() {
			return ProxyQGraphicsPolygonItem().FillRule();
		}
		[SmokeMethod("setFillRule", "(Qt::FillRule)", "$")]
		public void SetFillRule(Qt.FillRule rule) {
			ProxyQGraphicsPolygonItem().SetFillRule(rule);
		}
		[SmokeMethod("boundingRect", "() const", "")]
		public override QRectF BoundingRect() {
			return ProxyQGraphicsPolygonItem().BoundingRect();
		}
		[SmokeMethod("shape", "() const", "")]
		public override QPainterPath Shape() {
			return ProxyQGraphicsPolygonItem().Shape();
		}
		[SmokeMethod("contains", "(const QPointF&) const", "#")]
		public override bool Contains(QPointF point) {
			return ProxyQGraphicsPolygonItem().Contains(point);
		}
		[SmokeMethod("paint", "(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)", "###")]
		public override void Paint(QPainter painter, QStyleOptionGraphicsItem option, QWidget widget) {
			ProxyQGraphicsPolygonItem().Paint(painter,option,widget);
		}
		[SmokeMethod("paint", "(QPainter*, const QStyleOptionGraphicsItem*)", "##")]
		public override void Paint(QPainter painter, QStyleOptionGraphicsItem option) {
			ProxyQGraphicsPolygonItem().Paint(painter,option);
		}
		[SmokeMethod("isObscuredBy", "(const QGraphicsItem*) const", "#")]
		public override bool IsObscuredBy(QGraphicsItem item) {
			return ProxyQGraphicsPolygonItem().IsObscuredBy(item);
		}
		[SmokeMethod("opaqueArea", "() const", "")]
		public override QPainterPath OpaqueArea() {
			return ProxyQGraphicsPolygonItem().OpaqueArea();
		}
		[SmokeMethod("type", "() const", "")]
		public override int type() {
			return ProxyQGraphicsPolygonItem().type();
		}
		[SmokeMethod("supportsExtension", "(QGraphicsItem::Extension) const", "$")]
		protected override bool SupportsExtension(QGraphicsItem.Extension extension) {
			return ProxyQGraphicsPolygonItem().SupportsExtension(extension);
		}
		[SmokeMethod("setExtension", "(QGraphicsItem::Extension, const QVariant&)", "$#")]
		protected override void SetExtension(QGraphicsItem.Extension extension, QVariant variant) {
			ProxyQGraphicsPolygonItem().SetExtension(extension,variant);
		}
		[SmokeMethod("extension", "(const QVariant&) const", "#")]
		protected override QVariant extension(QVariant variant) {
			return ProxyQGraphicsPolygonItem().extension(variant);
		}
		~QGraphicsPolygonItem() {
			DisposeQGraphicsPolygonItem();
		}
		public void Dispose() {
			DisposeQGraphicsPolygonItem();
		}
		[SmokeMethod("~QGraphicsPolygonItem", "()", "")]
		private void DisposeQGraphicsPolygonItem() {
			ProxyQGraphicsPolygonItem().DisposeQGraphicsPolygonItem();
		}
	}
}
