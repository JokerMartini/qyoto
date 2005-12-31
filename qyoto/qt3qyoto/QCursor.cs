//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QCursor : Qt, IDisposable {
 		protected QCursor(Type dummy) : base((Type) null) {}
		interface IQCursorProxy {
			QPoint Pos();
			void SetPos(int x, int y);
			void SetPos(QPoint arg1);
			void Initialize();
			void Cleanup();
		}

		protected void CreateQCursorProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QCursor), this);
			_interceptor = (QCursor) realProxy.GetTransparentProxy();
		}
		private QCursor ProxyQCursor() {
			return (QCursor) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QCursor() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQCursorProxy), null);
			_staticInterceptor = (IQCursorProxy) realProxy.GetTransparentProxy();
		}
		private static IQCursorProxy StaticQCursor() {
			return (IQCursorProxy) _staticInterceptor;
		}

		public QCursor() : this((Type) null) {
			CreateQCursorProxy();
			NewQCursor();
		}
		[SmokeMethod("QCursor()")]
		private void NewQCursor() {
			ProxyQCursor().NewQCursor();
		}
		public QCursor(int shape) : this((Type) null) {
			CreateQCursorProxy();
			NewQCursor(shape);
		}
		[SmokeMethod("QCursor(int)")]
		private void NewQCursor(int shape) {
			ProxyQCursor().NewQCursor(shape);
		}
		public QCursor(QBitmap bitmap, QBitmap mask, int hotX, int hotY) : this((Type) null) {
			CreateQCursorProxy();
			NewQCursor(bitmap,mask,hotX,hotY);
		}
		[SmokeMethod("QCursor(const QBitmap&, const QBitmap&, int, int)")]
		private void NewQCursor(QBitmap bitmap, QBitmap mask, int hotX, int hotY) {
			ProxyQCursor().NewQCursor(bitmap,mask,hotX,hotY);
		}
		public QCursor(QBitmap bitmap, QBitmap mask, int hotX) : this((Type) null) {
			CreateQCursorProxy();
			NewQCursor(bitmap,mask,hotX);
		}
		[SmokeMethod("QCursor(const QBitmap&, const QBitmap&, int)")]
		private void NewQCursor(QBitmap bitmap, QBitmap mask, int hotX) {
			ProxyQCursor().NewQCursor(bitmap,mask,hotX);
		}
		public QCursor(QBitmap bitmap, QBitmap mask) : this((Type) null) {
			CreateQCursorProxy();
			NewQCursor(bitmap,mask);
		}
		[SmokeMethod("QCursor(const QBitmap&, const QBitmap&)")]
		private void NewQCursor(QBitmap bitmap, QBitmap mask) {
			ProxyQCursor().NewQCursor(bitmap,mask);
		}
		public QCursor(QPixmap pixmap, int hotX, int hotY) : this((Type) null) {
			CreateQCursorProxy();
			NewQCursor(pixmap,hotX,hotY);
		}
		[SmokeMethod("QCursor(const QPixmap&, int, int)")]
		private void NewQCursor(QPixmap pixmap, int hotX, int hotY) {
			ProxyQCursor().NewQCursor(pixmap,hotX,hotY);
		}
		public QCursor(QPixmap pixmap, int hotX) : this((Type) null) {
			CreateQCursorProxy();
			NewQCursor(pixmap,hotX);
		}
		[SmokeMethod("QCursor(const QPixmap&, int)")]
		private void NewQCursor(QPixmap pixmap, int hotX) {
			ProxyQCursor().NewQCursor(pixmap,hotX);
		}
		public QCursor(QPixmap pixmap) : this((Type) null) {
			CreateQCursorProxy();
			NewQCursor(pixmap);
		}
		[SmokeMethod("QCursor(const QPixmap&)")]
		private void NewQCursor(QPixmap pixmap) {
			ProxyQCursor().NewQCursor(pixmap);
		}
		public QCursor(QCursor arg1) : this((Type) null) {
			CreateQCursorProxy();
			NewQCursor(arg1);
		}
		[SmokeMethod("QCursor(const QCursor&)")]
		private void NewQCursor(QCursor arg1) {
			ProxyQCursor().NewQCursor(arg1);
		}
		[SmokeMethod("shape() const")]
		public int Shape() {
			return ProxyQCursor().Shape();
		}
		[SmokeMethod("setShape(int)")]
		public void SetShape(int arg1) {
			ProxyQCursor().SetShape(arg1);
		}
		[SmokeMethod("bitmap() const")]
		public QBitmap Bitmap() {
			return ProxyQCursor().Bitmap();
		}
		[SmokeMethod("mask() const")]
		public QBitmap Mask() {
			return ProxyQCursor().Mask();
		}
		[SmokeMethod("hotSpot() const")]
		public QPoint HotSpot() {
			return ProxyQCursor().HotSpot();
		}
		[SmokeMethod("pos()")]
		public static QPoint Pos() {
			return StaticQCursor().Pos();
		}
		[SmokeMethod("setPos(int, int)")]
		public static void SetPos(int x, int y) {
			StaticQCursor().SetPos(x,y);
		}
		[SmokeMethod("setPos(const QPoint&)")]
		public static void SetPos(QPoint arg1) {
			StaticQCursor().SetPos(arg1);
		}
		[SmokeMethod("initialize()")]
		public static void Initialize() {
			StaticQCursor().Initialize();
		}
		[SmokeMethod("cleanup()")]
		public static void Cleanup() {
			StaticQCursor().Cleanup();
		}
		~QCursor() {
			DisposeQCursor();
		}
		public void Dispose() {
			DisposeQCursor();
		}
		private void DisposeQCursor() {
			ProxyQCursor().DisposeQCursor();
		}
	}
}
