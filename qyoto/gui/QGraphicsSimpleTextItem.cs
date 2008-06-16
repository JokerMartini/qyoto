//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	[SmokeClass("QGraphicsSimpleTextItem")]
	public class QGraphicsSimpleTextItem : QAbstractGraphicsShapeItem, IDisposable {
 		protected QGraphicsSimpleTextItem(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QGraphicsSimpleTextItem), this);
		}
		public new const int Type = 9;
		public QGraphicsSimpleTextItem(QGraphicsItem parent, QGraphicsScene scene) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGraphicsSimpleTextItem##", "QGraphicsSimpleTextItem(QGraphicsItem*, QGraphicsScene*)", typeof(void), typeof(QGraphicsItem), parent, typeof(QGraphicsScene), scene);
		}
		public QGraphicsSimpleTextItem(QGraphicsItem parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGraphicsSimpleTextItem#", "QGraphicsSimpleTextItem(QGraphicsItem*)", typeof(void), typeof(QGraphicsItem), parent);
		}
		public QGraphicsSimpleTextItem() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGraphicsSimpleTextItem", "QGraphicsSimpleTextItem()", typeof(void));
		}
		public QGraphicsSimpleTextItem(string text, QGraphicsItem parent, QGraphicsScene scene) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGraphicsSimpleTextItem$##", "QGraphicsSimpleTextItem(const QString&, QGraphicsItem*, QGraphicsScene*)", typeof(void), typeof(string), text, typeof(QGraphicsItem), parent, typeof(QGraphicsScene), scene);
		}
		public QGraphicsSimpleTextItem(string text, QGraphicsItem parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGraphicsSimpleTextItem$#", "QGraphicsSimpleTextItem(const QString&, QGraphicsItem*)", typeof(void), typeof(string), text, typeof(QGraphicsItem), parent);
		}
		public QGraphicsSimpleTextItem(string text) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGraphicsSimpleTextItem$", "QGraphicsSimpleTextItem(const QString&)", typeof(void), typeof(string), text);
		}
		public void SetText(string text) {
			interceptor.Invoke("setText$", "setText(const QString&)", typeof(void), typeof(string), text);
		}
		public string Text() {
			return (string) interceptor.Invoke("text", "text() const", typeof(string));
		}
		public void SetFont(QFont font) {
			interceptor.Invoke("setFont#", "setFont(const QFont&)", typeof(void), typeof(QFont), font);
		}
		public QFont Font() {
			return (QFont) interceptor.Invoke("font", "font() const", typeof(QFont));
		}
		[SmokeMethod("boundingRect() const")]
		public override QRectF BoundingRect() {
			return (QRectF) interceptor.Invoke("boundingRect", "boundingRect() const", typeof(QRectF));
		}
		[SmokeMethod("shape() const")]
		public override QPainterPath Shape() {
			return (QPainterPath) interceptor.Invoke("shape", "shape() const", typeof(QPainterPath));
		}
		[SmokeMethod("contains(const QPointF&) const")]
		public override bool Contains(QPointF point) {
			return (bool) interceptor.Invoke("contains#", "contains(const QPointF&) const", typeof(bool), typeof(QPointF), point);
		}
		[SmokeMethod("paint(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)")]
		public override void Paint(QPainter painter, QStyleOptionGraphicsItem option, QWidget widget) {
			interceptor.Invoke("paint###", "paint(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)", typeof(void), typeof(QPainter), painter, typeof(QStyleOptionGraphicsItem), option, typeof(QWidget), widget);
		}
		[SmokeMethod("isObscuredBy(const QGraphicsItem*) const")]
		public override bool IsObscuredBy(QGraphicsItem item) {
			return (bool) interceptor.Invoke("isObscuredBy#", "isObscuredBy(const QGraphicsItem*) const", typeof(bool), typeof(QGraphicsItem), item);
		}
		[SmokeMethod("opaqueArea() const")]
		public override QPainterPath OpaqueArea() {
			return (QPainterPath) interceptor.Invoke("opaqueArea", "opaqueArea() const", typeof(QPainterPath));
		}
		[SmokeMethod("type() const")]
		public override int type() {
			return (int) interceptor.Invoke("type", "type() const", typeof(int));
		}
		[SmokeMethod("supportsExtension(QGraphicsItem::Extension) const")]
		protected override bool SupportsExtension(QGraphicsItem.Extension extension) {
			return (bool) interceptor.Invoke("supportsExtension$", "supportsExtension(QGraphicsItem::Extension) const", typeof(bool), typeof(QGraphicsItem.Extension), extension);
		}
		[SmokeMethod("setExtension(QGraphicsItem::Extension, const QVariant&)")]
		protected override void SetExtension(QGraphicsItem.Extension extension, QVariant variant) {
			interceptor.Invoke("setExtension$#", "setExtension(QGraphicsItem::Extension, const QVariant&)", typeof(void), typeof(QGraphicsItem.Extension), extension, typeof(QVariant), variant);
		}
		[SmokeMethod("extension(const QVariant&) const")]
		protected override QVariant extension(QVariant variant) {
			return (QVariant) interceptor.Invoke("extension#", "extension(const QVariant&) const", typeof(QVariant), typeof(QVariant), variant);
		}
		~QGraphicsSimpleTextItem() {
			interceptor.Invoke("~QGraphicsSimpleTextItem", "~QGraphicsSimpleTextItem()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QGraphicsSimpleTextItem", "~QGraphicsSimpleTextItem()", typeof(void));
		}
	}
}
