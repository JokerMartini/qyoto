//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QGLFramebufferObject")]
	public class QGLFramebufferObject : QPaintDevice, IDisposable {
 		protected QGLFramebufferObject(Type dummy) : base((Type) null) {}
		interface IQGLFramebufferObjectProxy {
			bool HasOpenGLFramebufferObjects();
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGLFramebufferObject), this);
			_interceptor = (QGLFramebufferObject) realProxy.GetTransparentProxy();
		}
		private QGLFramebufferObject ProxyQGLFramebufferObject() {
			return (QGLFramebufferObject) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGLFramebufferObject() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGLFramebufferObjectProxy), null);
			_staticInterceptor = (IQGLFramebufferObjectProxy) realProxy.GetTransparentProxy();
		}
		private static IQGLFramebufferObjectProxy StaticQGLFramebufferObject() {
			return (IQGLFramebufferObjectProxy) _staticInterceptor;
		}

		public QGLFramebufferObject(QSize size, int target) : this((Type) null) {
			CreateProxy();
			NewQGLFramebufferObject(size,target);
		}
		[SmokeMethod("QGLFramebufferObject(const QSize&, GLenum)")]
		private void NewQGLFramebufferObject(QSize size, int target) {
			ProxyQGLFramebufferObject().NewQGLFramebufferObject(size,target);
		}
		public QGLFramebufferObject(QSize size) : this((Type) null) {
			CreateProxy();
			NewQGLFramebufferObject(size);
		}
		[SmokeMethod("QGLFramebufferObject(const QSize&)")]
		private void NewQGLFramebufferObject(QSize size) {
			ProxyQGLFramebufferObject().NewQGLFramebufferObject(size);
		}
		public QGLFramebufferObject(int width, int height, int target) : this((Type) null) {
			CreateProxy();
			NewQGLFramebufferObject(width,height,target);
		}
		[SmokeMethod("QGLFramebufferObject(int, int, GLenum)")]
		private void NewQGLFramebufferObject(int width, int height, int target) {
			ProxyQGLFramebufferObject().NewQGLFramebufferObject(width,height,target);
		}
		public QGLFramebufferObject(int width, int height) : this((Type) null) {
			CreateProxy();
			NewQGLFramebufferObject(width,height);
		}
		[SmokeMethod("QGLFramebufferObject(int, int)")]
		private void NewQGLFramebufferObject(int width, int height) {
			ProxyQGLFramebufferObject().NewQGLFramebufferObject(width,height);
		}
		[SmokeMethod("isValid() const")]
		public bool IsValid() {
			return ProxyQGLFramebufferObject().IsValid();
		}
		[SmokeMethod("bind()")]
		public bool Bind() {
			return ProxyQGLFramebufferObject().Bind();
		}
		[SmokeMethod("release()")]
		public bool Release() {
			return ProxyQGLFramebufferObject().Release();
		}
		[SmokeMethod("texture() const")]
		public uint Texture() {
			return ProxyQGLFramebufferObject().Texture();
		}
		[SmokeMethod("size() const")]
		public QSize Size() {
			return ProxyQGLFramebufferObject().Size();
		}
		[SmokeMethod("toImage() const")]
		public QImage ToImage() {
			return ProxyQGLFramebufferObject().ToImage();
		}
		[SmokeMethod("paintEngine() const")]
		public new QPaintEngine PaintEngine() {
			return ProxyQGLFramebufferObject().PaintEngine();
		}
		[SmokeMethod("hasOpenGLFramebufferObjects()")]
		public static bool HasOpenGLFramebufferObjects() {
			return StaticQGLFramebufferObject().HasOpenGLFramebufferObjects();
		}
		[SmokeMethod("metric(QPaintDevice::PaintDeviceMetric) const")]
		protected new int Metric(IQPaintDevice metric) {
			return ProxyQGLFramebufferObject().Metric(metric);
		}
		[SmokeMethod("devType() const")]
		protected new int DevType() {
			return ProxyQGLFramebufferObject().DevType();
		}
		~QGLFramebufferObject() {
			DisposeQGLFramebufferObject();
		}
		public void Dispose() {
			DisposeQGLFramebufferObject();
		}
		[SmokeMethod("~QGLFramebufferObject()")]
		private void DisposeQGLFramebufferObject() {
			ProxyQGLFramebufferObject().DisposeQGLFramebufferObject();
		}
	}
}
