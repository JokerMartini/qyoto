//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QIcon")]
	public class QIcon : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QIcon(Type dummy) {}
		[SmokeClass("QIcon")]
		interface IQIconProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QIcon), this);
			_interceptor = (QIcon) realProxy.GetTransparentProxy();
		}
		private QIcon ProxyQIcon() {
			return (QIcon) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QIcon() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQIconProxy), null);
			_staticInterceptor = (IQIconProxy) realProxy.GetTransparentProxy();
		}
		private static IQIconProxy StaticQIcon() {
			return (IQIconProxy) _staticInterceptor;
		}

		public enum Mode {
			Normal = 0,
			Disabled = 1,
			Active = 2,
			Selected = 3,
		}
		public enum State {
			On = 0,
			Off = 1,
		}
		public QIcon() : this((Type) null) {
			CreateProxy();
			NewQIcon();
		}
		[SmokeMethod("QIcon", "()", "")]
		private void NewQIcon() {
			ProxyQIcon().NewQIcon();
		}
		public QIcon(QPixmap pixmap) : this((Type) null) {
			CreateProxy();
			NewQIcon(pixmap);
		}
		[SmokeMethod("QIcon", "(const QPixmap&)", "#")]
		private void NewQIcon(QPixmap pixmap) {
			ProxyQIcon().NewQIcon(pixmap);
		}
		public QIcon(QIcon other) : this((Type) null) {
			CreateProxy();
			NewQIcon(other);
		}
		[SmokeMethod("QIcon", "(const QIcon&)", "#")]
		private void NewQIcon(QIcon other) {
			ProxyQIcon().NewQIcon(other);
		}
		public QIcon(string fileName) : this((Type) null) {
			CreateProxy();
			NewQIcon(fileName);
		}
		[SmokeMethod("QIcon", "(const QString&)", "$")]
		private void NewQIcon(string fileName) {
			ProxyQIcon().NewQIcon(fileName);
		}
		public QIcon(QIconEngine engine) : this((Type) null) {
			CreateProxy();
			NewQIcon(engine);
		}
		[SmokeMethod("QIcon", "(QIconEngine*)", "#")]
		private void NewQIcon(QIconEngine engine) {
			ProxyQIcon().NewQIcon(engine);
		}
		//  operator QVariant(); >>>> NOT CONVERTED
		[SmokeMethod("pixmap", "(const QSize&, QIcon::Mode, QIcon::State) const", "#$$")]
		public QPixmap Pixmap(QSize size, QIcon.Mode mode, QIcon.State state) {
			return ProxyQIcon().Pixmap(size,mode,state);
		}
		[SmokeMethod("pixmap", "(const QSize&, QIcon::Mode) const", "#$")]
		public QPixmap Pixmap(QSize size, QIcon.Mode mode) {
			return ProxyQIcon().Pixmap(size,mode);
		}
		[SmokeMethod("pixmap", "(const QSize&) const", "#")]
		public QPixmap Pixmap(QSize size) {
			return ProxyQIcon().Pixmap(size);
		}
		[SmokeMethod("pixmap", "(int, int, QIcon::Mode, QIcon::State) const", "$$$$")]
		public QPixmap Pixmap(int w, int h, QIcon.Mode mode, QIcon.State state) {
			return ProxyQIcon().Pixmap(w,h,mode,state);
		}
		[SmokeMethod("pixmap", "(int, int, QIcon::Mode) const", "$$$")]
		public QPixmap Pixmap(int w, int h, QIcon.Mode mode) {
			return ProxyQIcon().Pixmap(w,h,mode);
		}
		[SmokeMethod("pixmap", "(int, int) const", "$$")]
		public QPixmap Pixmap(int w, int h) {
			return ProxyQIcon().Pixmap(w,h);
		}
		[SmokeMethod("pixmap", "(int, QIcon::Mode, QIcon::State) const", "$$$")]
		public QPixmap Pixmap(int extent, QIcon.Mode mode, QIcon.State state) {
			return ProxyQIcon().Pixmap(extent,mode,state);
		}
		[SmokeMethod("pixmap", "(int, QIcon::Mode) const", "$$")]
		public QPixmap Pixmap(int extent, QIcon.Mode mode) {
			return ProxyQIcon().Pixmap(extent,mode);
		}
		[SmokeMethod("pixmap", "(int) const", "$")]
		public QPixmap Pixmap(int extent) {
			return ProxyQIcon().Pixmap(extent);
		}
		[SmokeMethod("actualSize", "(const QSize&, QIcon::Mode, QIcon::State) const", "#$$")]
		public QSize ActualSize(QSize size, QIcon.Mode mode, QIcon.State state) {
			return ProxyQIcon().ActualSize(size,mode,state);
		}
		[SmokeMethod("actualSize", "(const QSize&, QIcon::Mode) const", "#$")]
		public QSize ActualSize(QSize size, QIcon.Mode mode) {
			return ProxyQIcon().ActualSize(size,mode);
		}
		[SmokeMethod("actualSize", "(const QSize&) const", "#")]
		public QSize ActualSize(QSize size) {
			return ProxyQIcon().ActualSize(size);
		}
		[SmokeMethod("paint", "(QPainter*, const QRect&, Qt::Alignment, QIcon::Mode, QIcon::State) const", "##$$$")]
		public void Paint(QPainter painter, QRect rect, int alignment, QIcon.Mode mode, QIcon.State state) {
			ProxyQIcon().Paint(painter,rect,alignment,mode,state);
		}
		[SmokeMethod("paint", "(QPainter*, const QRect&, Qt::Alignment, QIcon::Mode) const", "##$$")]
		public void Paint(QPainter painter, QRect rect, int alignment, QIcon.Mode mode) {
			ProxyQIcon().Paint(painter,rect,alignment,mode);
		}
		[SmokeMethod("paint", "(QPainter*, const QRect&, Qt::Alignment) const", "##$")]
		public void Paint(QPainter painter, QRect rect, int alignment) {
			ProxyQIcon().Paint(painter,rect,alignment);
		}
		[SmokeMethod("paint", "(QPainter*, const QRect&) const", "##")]
		public void Paint(QPainter painter, QRect rect) {
			ProxyQIcon().Paint(painter,rect);
		}
		[SmokeMethod("paint", "(QPainter*, int, int, int, int, Qt::Alignment, QIcon::Mode, QIcon::State) const", "#$$$$$$$")]
		public void Paint(QPainter painter, int x, int y, int w, int h, int alignment, QIcon.Mode mode, QIcon.State state) {
			ProxyQIcon().Paint(painter,x,y,w,h,alignment,mode,state);
		}
		[SmokeMethod("paint", "(QPainter*, int, int, int, int, Qt::Alignment, QIcon::Mode) const", "#$$$$$$")]
		public void Paint(QPainter painter, int x, int y, int w, int h, int alignment, QIcon.Mode mode) {
			ProxyQIcon().Paint(painter,x,y,w,h,alignment,mode);
		}
		[SmokeMethod("paint", "(QPainter*, int, int, int, int, Qt::Alignment) const", "#$$$$$")]
		public void Paint(QPainter painter, int x, int y, int w, int h, int alignment) {
			ProxyQIcon().Paint(painter,x,y,w,h,alignment);
		}
		[SmokeMethod("paint", "(QPainter*, int, int, int, int) const", "#$$$$")]
		public void Paint(QPainter painter, int x, int y, int w, int h) {
			ProxyQIcon().Paint(painter,x,y,w,h);
		}
		[SmokeMethod("isNull", "() const", "")]
		public bool IsNull() {
			return ProxyQIcon().IsNull();
		}
		[SmokeMethod("isDetached", "() const", "")]
		public bool IsDetached() {
			return ProxyQIcon().IsDetached();
		}
		[SmokeMethod("serialNumber", "() const", "")]
		public int SerialNumber() {
			return ProxyQIcon().SerialNumber();
		}
		[SmokeMethod("addPixmap", "(const QPixmap&, QIcon::Mode, QIcon::State)", "#$$")]
		public void AddPixmap(QPixmap pixmap, QIcon.Mode mode, QIcon.State state) {
			ProxyQIcon().AddPixmap(pixmap,mode,state);
		}
		[SmokeMethod("addPixmap", "(const QPixmap&, QIcon::Mode)", "#$")]
		public void AddPixmap(QPixmap pixmap, QIcon.Mode mode) {
			ProxyQIcon().AddPixmap(pixmap,mode);
		}
		[SmokeMethod("addPixmap", "(const QPixmap&)", "#")]
		public void AddPixmap(QPixmap pixmap) {
			ProxyQIcon().AddPixmap(pixmap);
		}
		[SmokeMethod("addFile", "(const QString&, const QSize&, QIcon::Mode, QIcon::State)", "$#$$")]
		public void AddFile(string fileName, QSize size, QIcon.Mode mode, QIcon.State state) {
			ProxyQIcon().AddFile(fileName,size,mode,state);
		}
		[SmokeMethod("addFile", "(const QString&, const QSize&, QIcon::Mode)", "$#$")]
		public void AddFile(string fileName, QSize size, QIcon.Mode mode) {
			ProxyQIcon().AddFile(fileName,size,mode);
		}
		[SmokeMethod("addFile", "(const QString&, const QSize&)", "$#")]
		public void AddFile(string fileName, QSize size) {
			ProxyQIcon().AddFile(fileName,size);
		}
		[SmokeMethod("addFile", "(const QString&)", "$")]
		public void AddFile(string fileName) {
			ProxyQIcon().AddFile(fileName);
		}
		~QIcon() {
			DisposeQIcon();
		}
		public void Dispose() {
			DisposeQIcon();
		}
		[SmokeMethod("~QIcon", "()", "")]
		private void DisposeQIcon() {
			ProxyQIcon().DisposeQIcon();
		}
	}
}
