//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	/// See <see cref="IQSvgRendererSignals"></see> for signals emitted by QSvgRenderer
	[SmokeClass("QSvgRenderer")]
	public class QSvgRenderer : QObject, IDisposable {
 		protected QSvgRenderer(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QSvgRenderer), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QSvgRenderer() {
			staticInterceptor = new SmokeInvocation(typeof(QSvgRenderer), null);
		}
		[Q_PROPERTY("QRectF", "viewBox")]
		public QRectF ViewBox {
			get { return (QRectF) interceptor.Invoke("viewBoxF", "viewBoxF()", typeof(QRectF)); }
			set { interceptor.Invoke("setViewBox#", "setViewBox(QRectF)", typeof(void), typeof(QRectF), value); }
		}
		[Q_PROPERTY("int", "framesPerSecond")]
		public int FramesPerSecond {
			get { return (int) interceptor.Invoke("framesPerSecond", "framesPerSecond()", typeof(int)); }
			set { interceptor.Invoke("setFramesPerSecond$", "setFramesPerSecond(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("int", "currentFrame")]
		public int CurrentFrame {
			get { return (int) interceptor.Invoke("currentFrame", "currentFrame()", typeof(int)); }
			set { interceptor.Invoke("setCurrentFrame$", "setCurrentFrame(int)", typeof(void), typeof(int), value); }
		}
		public QSvgRenderer(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSvgRenderer#", "QSvgRenderer(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public QSvgRenderer() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSvgRenderer", "QSvgRenderer()", typeof(void));
		}
		public QSvgRenderer(string filename, QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSvgRenderer$#", "QSvgRenderer(const QString&, QObject*)", typeof(void), typeof(string), filename, typeof(QObject), parent);
		}
		public QSvgRenderer(string filename) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSvgRenderer$", "QSvgRenderer(const QString&)", typeof(void), typeof(string), filename);
		}
		public QSvgRenderer(QByteArray contents, QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSvgRenderer##", "QSvgRenderer(const QByteArray&, QObject*)", typeof(void), typeof(QByteArray), contents, typeof(QObject), parent);
		}
		public QSvgRenderer(QByteArray contents) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSvgRenderer#", "QSvgRenderer(const QByteArray&)", typeof(void), typeof(QByteArray), contents);
		}
		public bool IsValid() {
			return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
		}
		public QSize DefaultSize() {
			return (QSize) interceptor.Invoke("defaultSize", "defaultSize() const", typeof(QSize));
		}
		public QRectF ViewBoxF() {
			return (QRectF) interceptor.Invoke("viewBoxF", "viewBoxF() const", typeof(QRectF));
		}
		public bool Animated() {
			return (bool) interceptor.Invoke("animated", "animated() const", typeof(bool));
		}
		public int AnimationDuration() {
			return (int) interceptor.Invoke("animationDuration", "animationDuration() const", typeof(int));
		}
		public QRectF BoundsOnElement(string id) {
			return (QRectF) interceptor.Invoke("boundsOnElement$", "boundsOnElement(const QString&) const", typeof(QRectF), typeof(string), id);
		}
		public bool ElementExists(string id) {
			return (bool) interceptor.Invoke("elementExists$", "elementExists(const QString&) const", typeof(bool), typeof(string), id);
		}
		public QMatrix MatrixForElement(string id) {
			return (QMatrix) interceptor.Invoke("matrixForElement$", "matrixForElement(const QString&) const", typeof(QMatrix), typeof(string), id);
		}
		[Q_SLOT("bool load(const QString&)")]
		public bool Load(string filename) {
			return (bool) interceptor.Invoke("load$", "load(const QString&)", typeof(bool), typeof(string), filename);
		}
		[Q_SLOT("bool load(const QByteArray&)")]
		public bool Load(QByteArray contents) {
			return (bool) interceptor.Invoke("load#", "load(const QByteArray&)", typeof(bool), typeof(QByteArray), contents);
		}
		[Q_SLOT("void render(QPainter*)")]
		public void Render(QPainter p) {
			interceptor.Invoke("render#", "render(QPainter*)", typeof(void), typeof(QPainter), p);
		}
		[Q_SLOT("void render(QPainter*, const QRectF&)")]
		public void Render(QPainter p, QRectF bounds) {
			interceptor.Invoke("render##", "render(QPainter*, const QRectF&)", typeof(void), typeof(QPainter), p, typeof(QRectF), bounds);
		}
		[Q_SLOT("void render(QPainter*, const QString&, const QRectF&)")]
		public void Render(QPainter p, string elementId, QRectF bounds) {
			interceptor.Invoke("render#$#", "render(QPainter*, const QString&, const QRectF&)", typeof(void), typeof(QPainter), p, typeof(string), elementId, typeof(QRectF), bounds);
		}
		[Q_SLOT("void render(QPainter*, const QString&)")]
		public void Render(QPainter p, string elementId) {
			interceptor.Invoke("render#$", "render(QPainter*, const QString&)", typeof(void), typeof(QPainter), p, typeof(string), elementId);
		}
		~QSvgRenderer() {
			interceptor.Invoke("~QSvgRenderer", "~QSvgRenderer()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QSvgRenderer", "~QSvgRenderer()", typeof(void));
		}
		public static string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQSvgRendererSignals Emit {
			get { return (IQSvgRendererSignals) Q_EMIT; }
		}
	}

	public interface IQSvgRendererSignals : IQObjectSignals {
		[Q_SIGNAL("void repaintNeeded()")]
		void RepaintNeeded();
	}
}
