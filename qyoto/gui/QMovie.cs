//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	/// See <see cref="IQMovieSignals"></see> for signals emitted by QMovie
	[SmokeClass("QMovie")]
	public class QMovie : QObject, IDisposable {
 		protected QMovie(Type dummy) : base((Type) null) {}
		interface IQMovieProxy {
			string Tr(string s, string c);
			string Tr(string s);
			List<QByteArray> SupportedFormats();
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QMovie), this);
			_interceptor = (QMovie) realProxy.GetTransparentProxy();
		}
		private QMovie ProxyQMovie() {
			return (QMovie) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QMovie() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQMovieProxy), null);
			_staticInterceptor = (IQMovieProxy) realProxy.GetTransparentProxy();
		}
		private static IQMovieProxy StaticQMovie() {
			return (IQMovieProxy) _staticInterceptor;
		}

		public enum MovieState {
			NotRunning = 0,
			Paused = 1,
			Running = 2,
		}
		public enum CacheMode {
			CacheNone = 0,
			CacheAll = 1,
		}
		public int Speed {
			get {
				return Property("Speed").Value<int>();
			}
			set {
				SetProperty("Speed", QVariant.FromValue<int>(value));
			}
		}
		public int cacheMode {
			get {
				return Property("cacheMode").Value<int>();
			}
			set {
				SetProperty("cacheMode", QVariant.FromValue<int>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QMovie(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQMovie(parent);
		}
		[SmokeMethod("QMovie(QObject*)")]
		private void NewQMovie(QObject parent) {
			ProxyQMovie().NewQMovie(parent);
		}
		public QMovie() : this((Type) null) {
			CreateProxy();
			NewQMovie();
		}
		[SmokeMethod("QMovie()")]
		private void NewQMovie() {
			ProxyQMovie().NewQMovie();
		}
		public QMovie(IQIODevice device, QByteArray format, QObject parent) : this((Type) null) {
			CreateProxy();
			NewQMovie(device,format,parent);
		}
		[SmokeMethod("QMovie(QIODevice*, const QByteArray&, QObject*)")]
		private void NewQMovie(IQIODevice device, QByteArray format, QObject parent) {
			ProxyQMovie().NewQMovie(device,format,parent);
		}
		public QMovie(IQIODevice device, QByteArray format) : this((Type) null) {
			CreateProxy();
			NewQMovie(device,format);
		}
		[SmokeMethod("QMovie(QIODevice*, const QByteArray&)")]
		private void NewQMovie(IQIODevice device, QByteArray format) {
			ProxyQMovie().NewQMovie(device,format);
		}
		public QMovie(IQIODevice device) : this((Type) null) {
			CreateProxy();
			NewQMovie(device);
		}
		[SmokeMethod("QMovie(QIODevice*)")]
		private void NewQMovie(IQIODevice device) {
			ProxyQMovie().NewQMovie(device);
		}
		public QMovie(string fileName, QByteArray format, QObject parent) : this((Type) null) {
			CreateProxy();
			NewQMovie(fileName,format,parent);
		}
		[SmokeMethod("QMovie(const QString&, const QByteArray&, QObject*)")]
		private void NewQMovie(string fileName, QByteArray format, QObject parent) {
			ProxyQMovie().NewQMovie(fileName,format,parent);
		}
		public QMovie(string fileName, QByteArray format) : this((Type) null) {
			CreateProxy();
			NewQMovie(fileName,format);
		}
		[SmokeMethod("QMovie(const QString&, const QByteArray&)")]
		private void NewQMovie(string fileName, QByteArray format) {
			ProxyQMovie().NewQMovie(fileName,format);
		}
		public QMovie(string fileName) : this((Type) null) {
			CreateProxy();
			NewQMovie(fileName);
		}
		[SmokeMethod("QMovie(const QString&)")]
		private void NewQMovie(string fileName) {
			ProxyQMovie().NewQMovie(fileName);
		}
		[SmokeMethod("setDevice(QIODevice*)")]
		public void SetDevice(IQIODevice device) {
			ProxyQMovie().SetDevice(device);
		}
		[SmokeMethod("device() const")]
		public IQIODevice Device() {
			return ProxyQMovie().Device();
		}
		[SmokeMethod("setFileName(const QString&)")]
		public void SetFileName(string fileName) {
			ProxyQMovie().SetFileName(fileName);
		}
		[SmokeMethod("fileName() const")]
		public string FileName() {
			return ProxyQMovie().FileName();
		}
		[SmokeMethod("setFormat(const QByteArray&)")]
		public void SetFormat(QByteArray format) {
			ProxyQMovie().SetFormat(format);
		}
		[SmokeMethod("format() const")]
		public QByteArray Format() {
			return ProxyQMovie().Format();
		}
		[SmokeMethod("setBackgroundColor(const QColor&)")]
		public void SetBackgroundColor(QColor color) {
			ProxyQMovie().SetBackgroundColor(color);
		}
		[SmokeMethod("backgroundColor() const")]
		public QColor BackgroundColor() {
			return ProxyQMovie().BackgroundColor();
		}
		[SmokeMethod("state() const")]
		public QMovie.MovieState State() {
			return ProxyQMovie().State();
		}
		[SmokeMethod("frameRect() const")]
		public QRect FrameRect() {
			return ProxyQMovie().FrameRect();
		}
		[SmokeMethod("currentImage() const")]
		public QImage CurrentImage() {
			return ProxyQMovie().CurrentImage();
		}
		[SmokeMethod("currentPixmap() const")]
		public QPixmap CurrentPixmap() {
			return ProxyQMovie().CurrentPixmap();
		}
		[SmokeMethod("isValid() const")]
		public bool IsValid() {
			return ProxyQMovie().IsValid();
		}
		[SmokeMethod("jumpToFrame(int)")]
		public bool JumpToFrame(int frameNumber) {
			return ProxyQMovie().JumpToFrame(frameNumber);
		}
		[SmokeMethod("loopCount() const")]
		public int LoopCount() {
			return ProxyQMovie().LoopCount();
		}
		[SmokeMethod("frameCount() const")]
		public int FrameCount() {
			return ProxyQMovie().FrameCount();
		}
		[SmokeMethod("nextFrameDelay() const")]
		public int NextFrameDelay() {
			return ProxyQMovie().NextFrameDelay();
		}
		[SmokeMethod("currentFrameNumber() const")]
		public int CurrentFrameNumber() {
			return ProxyQMovie().CurrentFrameNumber();
		}
		[SmokeMethod("scaledSize()")]
		public QSize ScaledSize() {
			return ProxyQMovie().ScaledSize();
		}
		[SmokeMethod("setScaledSize(const QSize&)")]
		public void SetScaledSize(QSize size) {
			ProxyQMovie().SetScaledSize(size);
		}
		[SmokeMethod("start()")]
		public void Start() {
			ProxyQMovie().Start();
		}
		[SmokeMethod("jumpToNextFrame()")]
		public bool JumpToNextFrame() {
			return ProxyQMovie().JumpToNextFrame();
		}
		[SmokeMethod("setPaused(bool)")]
		public void SetPaused(bool paused) {
			ProxyQMovie().SetPaused(paused);
		}
		[SmokeMethod("stop()")]
		public void Stop() {
			ProxyQMovie().Stop();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQMovie().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQMovie().Tr(s);
		}
		[SmokeMethod("supportedFormats()")]
		public static List<QByteArray> SupportedFormats() {
			return StaticQMovie().SupportedFormats();
		}
		~QMovie() {
			DisposeQMovie();
		}
		public new void Dispose() {
			DisposeQMovie();
		}
		[SmokeMethod("~QMovie()")]
		private void DisposeQMovie() {
			ProxyQMovie().DisposeQMovie();
		}
		protected new IQMovieSignals Emit() {
			return (IQMovieSignals) Q_EMIT;
		}
	}

	public interface IQMovieSignals : IQObjectSignals {
		[Q_SIGNAL("void started()")]
		void Started();
		[Q_SIGNAL("void resized(const QSize&)")]
		void Resized(QSize size);
		[Q_SIGNAL("void updated(const QRect&)")]
		void Updated(QRect rect);
		[Q_SIGNAL("void stateChanged(QMovie::MovieState)")]
		void StateChanged(QMovie.MovieState state);
		[Q_SIGNAL("void error(QImageReader::ImageReaderError)")]
		void Error(int error);
		[Q_SIGNAL("void finished()")]
		void Finished();
		[Q_SIGNAL("void frameChanged(int)")]
		void FrameChanged(int frameNumber);
	}
}
