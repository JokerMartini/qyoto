//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	[SmokeClass("QGLPixelBuffer")]
	public class QGLPixelBuffer : QPaintDevice, IDisposable {
 		protected QGLPixelBuffer(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QGLPixelBuffer), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QGLPixelBuffer() {
			staticInterceptor = new SmokeInvocation(typeof(QGLPixelBuffer), null);
		}
		public QGLPixelBuffer(QSize size, QGLFormat format, QGLWidget shareWidget) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGLPixelBuffer###", "QGLPixelBuffer(const QSize&, const QGLFormat&, QGLWidget*)", typeof(void), typeof(QSize), size, typeof(QGLFormat), format, typeof(QGLWidget), shareWidget);
		}
		public QGLPixelBuffer(QSize size, QGLFormat format) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGLPixelBuffer##", "QGLPixelBuffer(const QSize&, const QGLFormat&)", typeof(void), typeof(QSize), size, typeof(QGLFormat), format);
		}
		public QGLPixelBuffer(QSize size) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGLPixelBuffer#", "QGLPixelBuffer(const QSize&)", typeof(void), typeof(QSize), size);
		}
		public QGLPixelBuffer(int width, int height, QGLFormat format, QGLWidget shareWidget) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGLPixelBuffer$$##", "QGLPixelBuffer(int, int, const QGLFormat&, QGLWidget*)", typeof(void), typeof(int), width, typeof(int), height, typeof(QGLFormat), format, typeof(QGLWidget), shareWidget);
		}
		public QGLPixelBuffer(int width, int height, QGLFormat format) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGLPixelBuffer$$#", "QGLPixelBuffer(int, int, const QGLFormat&)", typeof(void), typeof(int), width, typeof(int), height, typeof(QGLFormat), format);
		}
		public QGLPixelBuffer(int width, int height) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGLPixelBuffer$$", "QGLPixelBuffer(int, int)", typeof(void), typeof(int), width, typeof(int), height);
		}
		public bool IsValid() {
			return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
		}
		public bool MakeCurrent() {
			return (bool) interceptor.Invoke("makeCurrent", "makeCurrent()", typeof(bool));
		}
		public bool DoneCurrent() {
			return (bool) interceptor.Invoke("doneCurrent", "doneCurrent()", typeof(bool));
		}
		public uint GenerateDynamicTexture() {
			return (uint) interceptor.Invoke("generateDynamicTexture", "generateDynamicTexture() const", typeof(uint));
		}
		public bool BindToDynamicTexture(uint texture) {
			return (bool) interceptor.Invoke("bindToDynamicTexture$", "bindToDynamicTexture(GLuint)", typeof(bool), typeof(uint), texture);
		}
		public void ReleaseFromDynamicTexture() {
			interceptor.Invoke("releaseFromDynamicTexture", "releaseFromDynamicTexture()", typeof(void));
		}
		public void UpdateDynamicTexture(uint texture_id) {
			interceptor.Invoke("updateDynamicTexture$", "updateDynamicTexture(GLuint) const", typeof(void), typeof(uint), texture_id);
		}
		public uint BindTexture(QImage image, int target) {
			return (uint) interceptor.Invoke("bindTexture#$", "bindTexture(const QImage&, GLenum)", typeof(uint), typeof(QImage), image, typeof(int), target);
		}
		public uint BindTexture(QImage image) {
			return (uint) interceptor.Invoke("bindTexture#", "bindTexture(const QImage&)", typeof(uint), typeof(QImage), image);
		}
		public uint BindTexture(QPixmap pixmap, int target) {
			return (uint) interceptor.Invoke("bindTexture#$", "bindTexture(const QPixmap&, GLenum)", typeof(uint), typeof(QPixmap), pixmap, typeof(int), target);
		}
		public uint BindTexture(QPixmap pixmap) {
			return (uint) interceptor.Invoke("bindTexture#", "bindTexture(const QPixmap&)", typeof(uint), typeof(QPixmap), pixmap);
		}
		public uint BindTexture(string fileName) {
			return (uint) interceptor.Invoke("bindTexture$", "bindTexture(const QString&)", typeof(uint), typeof(string), fileName);
		}
		public void DeleteTexture(uint texture_id) {
			interceptor.Invoke("deleteTexture$", "deleteTexture(GLuint)", typeof(void), typeof(uint), texture_id);
		}
		public void DrawTexture(QRectF target, uint textureId, int textureTarget) {
			interceptor.Invoke("drawTexture#$$", "drawTexture(const QRectF&, GLuint, GLenum)", typeof(void), typeof(QRectF), target, typeof(uint), textureId, typeof(int), textureTarget);
		}
		public void DrawTexture(QRectF target, uint textureId) {
			interceptor.Invoke("drawTexture#$", "drawTexture(const QRectF&, GLuint)", typeof(void), typeof(QRectF), target, typeof(uint), textureId);
		}
		public void DrawTexture(QPointF point, uint textureId, int textureTarget) {
			interceptor.Invoke("drawTexture#$$", "drawTexture(const QPointF&, GLuint, GLenum)", typeof(void), typeof(QPointF), point, typeof(uint), textureId, typeof(int), textureTarget);
		}
		public void DrawTexture(QPointF point, uint textureId) {
			interceptor.Invoke("drawTexture#$", "drawTexture(const QPointF&, GLuint)", typeof(void), typeof(QPointF), point, typeof(uint), textureId);
		}
		public QSize Size() {
			return (QSize) interceptor.Invoke("size", "size() const", typeof(QSize));
		}
		public QImage ToImage() {
			return (QImage) interceptor.Invoke("toImage", "toImage() const", typeof(QImage));
		}
		[SmokeMethod("paintEngine() const")]
		public override QPaintEngine PaintEngine() {
			return (QPaintEngine) interceptor.Invoke("paintEngine", "paintEngine() const", typeof(QPaintEngine));
		}
		public QGLFormat Format() {
			return (QGLFormat) interceptor.Invoke("format", "format() const", typeof(QGLFormat));
		}
		[SmokeMethod("metric(QPaintDevice::PaintDeviceMetric) const")]
		protected override int Metric(IQPaintDevice metric) {
			return (int) interceptor.Invoke("metric$", "metric(QPaintDevice::PaintDeviceMetric) const", typeof(int), typeof(IQPaintDevice), metric);
		}
		[SmokeMethod("devType() const")]
		protected new virtual int DevType() {
			return (int) interceptor.Invoke("devType", "devType() const", typeof(int));
		}
		~QGLPixelBuffer() {
			interceptor.Invoke("~QGLPixelBuffer", "~QGLPixelBuffer()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QGLPixelBuffer", "~QGLPixelBuffer()", typeof(void));
		}
		public static bool HasOpenGLPbuffers() {
			return (bool) staticInterceptor.Invoke("hasOpenGLPbuffers", "hasOpenGLPbuffers()", typeof(bool));
		}
	}
}
