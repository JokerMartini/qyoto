//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QGraphicsSimpleTextItem")]
	public class QGraphicsSimpleTextItem : QAbstractGraphicsShapeItem, IDisposable {
 		protected QGraphicsSimpleTextItem(Type dummy) : base((Type) null) {}
		interface IQGraphicsSimpleTextItemProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGraphicsSimpleTextItem), this);
			_interceptor = (QGraphicsSimpleTextItem) realProxy.GetTransparentProxy();
		}
		private QGraphicsSimpleTextItem ProxyQGraphicsSimpleTextItem() {
			return (QGraphicsSimpleTextItem) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGraphicsSimpleTextItem() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGraphicsSimpleTextItemProxy), null);
			_staticInterceptor = (IQGraphicsSimpleTextItemProxy) realProxy.GetTransparentProxy();
		}
		private static IQGraphicsSimpleTextItemProxy StaticQGraphicsSimpleTextItem() {
			return (IQGraphicsSimpleTextItemProxy) _staticInterceptor;
		}

		public const int Type = 9;

		public QGraphicsSimpleTextItem(QGraphicsItem parent, QGraphicsScene scene) : this((Type) null) {
			CreateProxy();
			NewQGraphicsSimpleTextItem(parent,scene);
		}
		[SmokeMethod("QGraphicsSimpleTextItem(QGraphicsItem*, QGraphicsScene*)")]
		private void NewQGraphicsSimpleTextItem(QGraphicsItem parent, QGraphicsScene scene) {
			ProxyQGraphicsSimpleTextItem().NewQGraphicsSimpleTextItem(parent,scene);
		}
		public QGraphicsSimpleTextItem(QGraphicsItem parent) : this((Type) null) {
			CreateProxy();
			NewQGraphicsSimpleTextItem(parent);
		}
		[SmokeMethod("QGraphicsSimpleTextItem(QGraphicsItem*)")]
		private void NewQGraphicsSimpleTextItem(QGraphicsItem parent) {
			ProxyQGraphicsSimpleTextItem().NewQGraphicsSimpleTextItem(parent);
		}
		public QGraphicsSimpleTextItem() : this((Type) null) {
			CreateProxy();
			NewQGraphicsSimpleTextItem();
		}
		[SmokeMethod("QGraphicsSimpleTextItem()")]
		private void NewQGraphicsSimpleTextItem() {
			ProxyQGraphicsSimpleTextItem().NewQGraphicsSimpleTextItem();
		}
		public QGraphicsSimpleTextItem(string text, QGraphicsItem parent, QGraphicsScene scene) : this((Type) null) {
			CreateProxy();
			NewQGraphicsSimpleTextItem(text,parent,scene);
		}
		[SmokeMethod("QGraphicsSimpleTextItem(const QString&, QGraphicsItem*, QGraphicsScene*)")]
		private void NewQGraphicsSimpleTextItem(string text, QGraphicsItem parent, QGraphicsScene scene) {
			ProxyQGraphicsSimpleTextItem().NewQGraphicsSimpleTextItem(text,parent,scene);
		}
		public QGraphicsSimpleTextItem(string text, QGraphicsItem parent) : this((Type) null) {
			CreateProxy();
			NewQGraphicsSimpleTextItem(text,parent);
		}
		[SmokeMethod("QGraphicsSimpleTextItem(const QString&, QGraphicsItem*)")]
		private void NewQGraphicsSimpleTextItem(string text, QGraphicsItem parent) {
			ProxyQGraphicsSimpleTextItem().NewQGraphicsSimpleTextItem(text,parent);
		}
		public QGraphicsSimpleTextItem(string text) : this((Type) null) {
			CreateProxy();
			NewQGraphicsSimpleTextItem(text);
		}
		[SmokeMethod("QGraphicsSimpleTextItem(const QString&)")]
		private void NewQGraphicsSimpleTextItem(string text) {
			ProxyQGraphicsSimpleTextItem().NewQGraphicsSimpleTextItem(text);
		}
		[SmokeMethod("setText(const QString&)")]
		public void SetText(string text) {
			ProxyQGraphicsSimpleTextItem().SetText(text);
		}
		[SmokeMethod("text() const")]
		public string Text() {
			return ProxyQGraphicsSimpleTextItem().Text();
		}
		[SmokeMethod("setFont(const QFont&)")]
		public void SetFont(QFont font) {
			ProxyQGraphicsSimpleTextItem().SetFont(font);
		}
		[SmokeMethod("font() const")]
		public QFont Font() {
			return ProxyQGraphicsSimpleTextItem().Font();
		}
		[SmokeMethod("boundingRect() const")]
		public new QRectF BoundingRect() {
			return ProxyQGraphicsSimpleTextItem().BoundingRect();
		}
		[SmokeMethod("shape() const")]
		public new QPainterPath Shape() {
			return ProxyQGraphicsSimpleTextItem().Shape();
		}
		[SmokeMethod("contains(const QPointF&) const")]
		public new bool Contains(QPointF point) {
			return ProxyQGraphicsSimpleTextItem().Contains(point);
		}
		[SmokeMethod("paint(QPainter*, const QStyleOptionGraphicsItem*, QWidget*)")]
		public new void Paint(QPainter painter, QStyleOptionGraphicsItem option, QWidget widget) {
			ProxyQGraphicsSimpleTextItem().Paint(painter,option,widget);
		}
		[SmokeMethod("isObscuredBy(const QGraphicsItem*) const")]
		public new bool IsObscuredBy(QGraphicsItem item) {
			return ProxyQGraphicsSimpleTextItem().IsObscuredBy(item);
		}
		[SmokeMethod("opaqueArea() const")]
		public new QPainterPath OpaqueArea() {
			return ProxyQGraphicsSimpleTextItem().OpaqueArea();
		}
		[SmokeMethod("type() const")]
		public new int type() {
			return ProxyQGraphicsSimpleTextItem().type();
		}
		[SmokeMethod("supportsExtension(QGraphicsItem::Extension) const")]
		protected new bool SupportsExtension(QGraphicsItem.Extension extension) {
			return ProxyQGraphicsSimpleTextItem().SupportsExtension(extension);
		}
		[SmokeMethod("setExtension(QGraphicsItem::Extension, const QVariant&)")]
		protected new void SetExtension(QGraphicsItem.Extension extension, QVariant variant) {
			ProxyQGraphicsSimpleTextItem().SetExtension(extension,variant);
		}
		[SmokeMethod("extension(const QVariant&) const")]
		protected new QVariant Extension(QVariant variant) {
			return ProxyQGraphicsSimpleTextItem().Extension(variant);
		}
		~QGraphicsSimpleTextItem() {
			DisposeQGraphicsSimpleTextItem();
		}
		public void Dispose() {
			DisposeQGraphicsSimpleTextItem();
		}
		[SmokeMethod("~QGraphicsSimpleTextItem()")]
		private void DisposeQGraphicsSimpleTextItem() {
			ProxyQGraphicsSimpleTextItem().DisposeQGraphicsSimpleTextItem();
		}
	}
}
