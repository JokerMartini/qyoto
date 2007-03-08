//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QImageReader")]
	public class QImageReader : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QImageReader(Type dummy) {}
		[SmokeClass("QImageReader")]
		interface IQImageReaderProxy {
			[SmokeMethod("imageFormat", "(const QString&)", "$")]
			QByteArray ImageFormat(string fileName);
			[SmokeMethod("imageFormat", "(QIODevice*)", "#")]
			QByteArray ImageFormat(QIODevice device);
			[SmokeMethod("supportedImageFormats", "()", "")]
			List<QByteArray> SupportedImageFormats();
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QImageReader), this);
			_interceptor = (QImageReader) realProxy.GetTransparentProxy();
		}
		private QImageReader ProxyQImageReader() {
			return (QImageReader) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QImageReader() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQImageReaderProxy), null);
			_staticInterceptor = (IQImageReaderProxy) realProxy.GetTransparentProxy();
		}
		private static IQImageReaderProxy StaticQImageReader() {
			return (IQImageReaderProxy) _staticInterceptor;
		}
		public enum ImageReaderError {
			UnknownError = 0,
			FileNotFoundError = 1,
			DeviceError = 2,
			UnsupportedFormatError = 3,
			InvalidDataError = 4,
		}
		public QImageReader() : this((Type) null) {
			CreateProxy();
			NewQImageReader();
		}
		[SmokeMethod("QImageReader", "()", "")]
		private void NewQImageReader() {
			ProxyQImageReader().NewQImageReader();
		}
		public QImageReader(QIODevice device, QByteArray format) : this((Type) null) {
			CreateProxy();
			NewQImageReader(device,format);
		}
		[SmokeMethod("QImageReader", "(QIODevice*, const QByteArray&)", "##")]
		private void NewQImageReader(QIODevice device, QByteArray format) {
			ProxyQImageReader().NewQImageReader(device,format);
		}
		public QImageReader(QIODevice device) : this((Type) null) {
			CreateProxy();
			NewQImageReader(device);
		}
		[SmokeMethod("QImageReader", "(QIODevice*)", "#")]
		private void NewQImageReader(QIODevice device) {
			ProxyQImageReader().NewQImageReader(device);
		}
		public QImageReader(string fileName, QByteArray format) : this((Type) null) {
			CreateProxy();
			NewQImageReader(fileName,format);
		}
		[SmokeMethod("QImageReader", "(const QString&, const QByteArray&)", "$#")]
		private void NewQImageReader(string fileName, QByteArray format) {
			ProxyQImageReader().NewQImageReader(fileName,format);
		}
		public QImageReader(string fileName) : this((Type) null) {
			CreateProxy();
			NewQImageReader(fileName);
		}
		[SmokeMethod("QImageReader", "(const QString&)", "$")]
		private void NewQImageReader(string fileName) {
			ProxyQImageReader().NewQImageReader(fileName);
		}
		[SmokeMethod("setFormat", "(const QByteArray&)", "#")]
		public void SetFormat(QByteArray format) {
			ProxyQImageReader().SetFormat(format);
		}
		[SmokeMethod("format", "() const", "")]
		public QByteArray Format() {
			return ProxyQImageReader().Format();
		}
		[SmokeMethod("setDevice", "(QIODevice*)", "#")]
		public void SetDevice(QIODevice device) {
			ProxyQImageReader().SetDevice(device);
		}
		[SmokeMethod("device", "() const", "")]
		public QIODevice Device() {
			return ProxyQImageReader().Device();
		}
		[SmokeMethod("setFileName", "(const QString&)", "$")]
		public void SetFileName(string fileName) {
			ProxyQImageReader().SetFileName(fileName);
		}
		[SmokeMethod("fileName", "() const", "")]
		public string FileName() {
			return ProxyQImageReader().FileName();
		}
		[SmokeMethod("size", "() const", "")]
		public QSize Size() {
			return ProxyQImageReader().Size();
		}
		[SmokeMethod("textKeys", "() const", "")]
		public List<string> TextKeys() {
			return ProxyQImageReader().TextKeys();
		}
		[SmokeMethod("text", "(const QString&) const", "$")]
		public string Text(string key) {
			return ProxyQImageReader().Text(key);
		}
		[SmokeMethod("setClipRect", "(const QRect&)", "#")]
		public void SetClipRect(QRect rect) {
			ProxyQImageReader().SetClipRect(rect);
		}
		[SmokeMethod("clipRect", "() const", "")]
		public QRect ClipRect() {
			return ProxyQImageReader().ClipRect();
		}
		[SmokeMethod("setScaledSize", "(const QSize&)", "#")]
		public void SetScaledSize(QSize size) {
			ProxyQImageReader().SetScaledSize(size);
		}
		[SmokeMethod("scaledSize", "() const", "")]
		public QSize ScaledSize() {
			return ProxyQImageReader().ScaledSize();
		}
		[SmokeMethod("setQuality", "(int)", "$")]
		public void SetQuality(int quality) {
			ProxyQImageReader().SetQuality(quality);
		}
		[SmokeMethod("quality", "() const", "")]
		public int Quality() {
			return ProxyQImageReader().Quality();
		}
		[SmokeMethod("setScaledClipRect", "(const QRect&)", "#")]
		public void SetScaledClipRect(QRect rect) {
			ProxyQImageReader().SetScaledClipRect(rect);
		}
		[SmokeMethod("scaledClipRect", "() const", "")]
		public QRect ScaledClipRect() {
			return ProxyQImageReader().ScaledClipRect();
		}
		[SmokeMethod("setBackgroundColor", "(const QColor&)", "#")]
		public void SetBackgroundColor(QColor color) {
			ProxyQImageReader().SetBackgroundColor(color);
		}
		[SmokeMethod("backgroundColor", "() const", "")]
		public QColor BackgroundColor() {
			return ProxyQImageReader().BackgroundColor();
		}
		[SmokeMethod("supportsAnimation", "() const", "")]
		public bool SupportsAnimation() {
			return ProxyQImageReader().SupportsAnimation();
		}
		[SmokeMethod("canRead", "() const", "")]
		public bool CanRead() {
			return ProxyQImageReader().CanRead();
		}
		[SmokeMethod("read", "()", "")]
		public QImage Read() {
			return ProxyQImageReader().Read();
		}
		[SmokeMethod("read", "(QImage*)", "#")]
		public bool Read(QImage image) {
			return ProxyQImageReader().Read(image);
		}
		[SmokeMethod("jumpToNextImage", "()", "")]
		public bool JumpToNextImage() {
			return ProxyQImageReader().JumpToNextImage();
		}
		[SmokeMethod("jumpToImage", "(int)", "$")]
		public bool JumpToImage(int imageNumber) {
			return ProxyQImageReader().JumpToImage(imageNumber);
		}
		[SmokeMethod("loopCount", "() const", "")]
		public int LoopCount() {
			return ProxyQImageReader().LoopCount();
		}
		[SmokeMethod("imageCount", "() const", "")]
		public int ImageCount() {
			return ProxyQImageReader().ImageCount();
		}
		[SmokeMethod("nextImageDelay", "() const", "")]
		public int NextImageDelay() {
			return ProxyQImageReader().NextImageDelay();
		}
		[SmokeMethod("currentImageNumber", "() const", "")]
		public int CurrentImageNumber() {
			return ProxyQImageReader().CurrentImageNumber();
		}
		[SmokeMethod("currentImageRect", "() const", "")]
		public QRect CurrentImageRect() {
			return ProxyQImageReader().CurrentImageRect();
		}
		[SmokeMethod("error", "() const", "")]
		public int Error() {
			return ProxyQImageReader().Error();
		}
		[SmokeMethod("errorString", "() const", "")]
		public string ErrorString() {
			return ProxyQImageReader().ErrorString();
		}
		[SmokeMethod("supportsOption", "(QImageIOHandler::ImageOption) const", "$")]
		public bool SupportsOption(QImageIOHandler.ImageOption option) {
			return ProxyQImageReader().SupportsOption(option);
		}
		public static QByteArray ImageFormat(string fileName) {
			return StaticQImageReader().ImageFormat(fileName);
		}
		public static QByteArray ImageFormat(QIODevice device) {
			return StaticQImageReader().ImageFormat(device);
		}
		public static List<QByteArray> SupportedImageFormats() {
			return StaticQImageReader().SupportedImageFormats();
		}
		~QImageReader() {
			DisposeQImageReader();
		}
		public void Dispose() {
			DisposeQImageReader();
		}
		[SmokeMethod("~QImageReader", "()", "")]
		private void DisposeQImageReader() {
			ProxyQImageReader().DisposeQImageReader();
		}
	}
}
