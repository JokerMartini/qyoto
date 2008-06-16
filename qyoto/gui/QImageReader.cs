//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	using System.Collections.Generic;
	[SmokeClass("QImageReader")]
	public class QImageReader : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QImageReader(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QImageReader), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QImageReader() {
			staticInterceptor = new SmokeInvocation(typeof(QImageReader), null);
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
			interceptor.Invoke("QImageReader", "QImageReader()", typeof(void));
		}
		public QImageReader(QIODevice device, QByteArray format) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QImageReader##", "QImageReader(QIODevice*, const QByteArray&)", typeof(void), typeof(QIODevice), device, typeof(QByteArray), format);
		}
		public QImageReader(QIODevice device) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QImageReader#", "QImageReader(QIODevice*)", typeof(void), typeof(QIODevice), device);
		}
		public QImageReader(string fileName, QByteArray format) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QImageReader$#", "QImageReader(const QString&, const QByteArray&)", typeof(void), typeof(string), fileName, typeof(QByteArray), format);
		}
		public QImageReader(string fileName) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QImageReader$", "QImageReader(const QString&)", typeof(void), typeof(string), fileName);
		}
		public void SetFormat(QByteArray format) {
			interceptor.Invoke("setFormat#", "setFormat(const QByteArray&)", typeof(void), typeof(QByteArray), format);
		}
		public QByteArray Format() {
			return (QByteArray) interceptor.Invoke("format", "format() const", typeof(QByteArray));
		}
		public void SetDevice(QIODevice device) {
			interceptor.Invoke("setDevice#", "setDevice(QIODevice*)", typeof(void), typeof(QIODevice), device);
		}
		public QIODevice Device() {
			return (QIODevice) interceptor.Invoke("device", "device() const", typeof(QIODevice));
		}
		public void SetFileName(string fileName) {
			interceptor.Invoke("setFileName$", "setFileName(const QString&)", typeof(void), typeof(string), fileName);
		}
		public string FileName() {
			return (string) interceptor.Invoke("fileName", "fileName() const", typeof(string));
		}
		public QSize Size() {
			return (QSize) interceptor.Invoke("size", "size() const", typeof(QSize));
		}
		public List<string> TextKeys() {
			return (List<string>) interceptor.Invoke("textKeys", "textKeys() const", typeof(List<string>));
		}
		public string Text(string key) {
			return (string) interceptor.Invoke("text$", "text(const QString&) const", typeof(string), typeof(string), key);
		}
		public void SetClipRect(QRect rect) {
			interceptor.Invoke("setClipRect#", "setClipRect(const QRect&)", typeof(void), typeof(QRect), rect);
		}
		public QRect ClipRect() {
			return (QRect) interceptor.Invoke("clipRect", "clipRect() const", typeof(QRect));
		}
		public void SetScaledSize(QSize size) {
			interceptor.Invoke("setScaledSize#", "setScaledSize(const QSize&)", typeof(void), typeof(QSize), size);
		}
		public QSize ScaledSize() {
			return (QSize) interceptor.Invoke("scaledSize", "scaledSize() const", typeof(QSize));
		}
		public void SetQuality(int quality) {
			interceptor.Invoke("setQuality$", "setQuality(int)", typeof(void), typeof(int), quality);
		}
		public int Quality() {
			return (int) interceptor.Invoke("quality", "quality() const", typeof(int));
		}
		public void SetScaledClipRect(QRect rect) {
			interceptor.Invoke("setScaledClipRect#", "setScaledClipRect(const QRect&)", typeof(void), typeof(QRect), rect);
		}
		public QRect ScaledClipRect() {
			return (QRect) interceptor.Invoke("scaledClipRect", "scaledClipRect() const", typeof(QRect));
		}
		public void SetBackgroundColor(QColor color) {
			interceptor.Invoke("setBackgroundColor#", "setBackgroundColor(const QColor&)", typeof(void), typeof(QColor), color);
		}
		public QColor BackgroundColor() {
			return (QColor) interceptor.Invoke("backgroundColor", "backgroundColor() const", typeof(QColor));
		}
		public bool SupportsAnimation() {
			return (bool) interceptor.Invoke("supportsAnimation", "supportsAnimation() const", typeof(bool));
		}
		public bool CanRead() {
			return (bool) interceptor.Invoke("canRead", "canRead() const", typeof(bool));
		}
		public QImage Read() {
			return (QImage) interceptor.Invoke("read", "read()", typeof(QImage));
		}
		public bool Read(QImage image) {
			return (bool) interceptor.Invoke("read#", "read(QImage*)", typeof(bool), typeof(QImage), image);
		}
		public bool JumpToNextImage() {
			return (bool) interceptor.Invoke("jumpToNextImage", "jumpToNextImage()", typeof(bool));
		}
		public bool JumpToImage(int imageNumber) {
			return (bool) interceptor.Invoke("jumpToImage$", "jumpToImage(int)", typeof(bool), typeof(int), imageNumber);
		}
		public int LoopCount() {
			return (int) interceptor.Invoke("loopCount", "loopCount() const", typeof(int));
		}
		public int ImageCount() {
			return (int) interceptor.Invoke("imageCount", "imageCount() const", typeof(int));
		}
		public int NextImageDelay() {
			return (int) interceptor.Invoke("nextImageDelay", "nextImageDelay() const", typeof(int));
		}
		public int CurrentImageNumber() {
			return (int) interceptor.Invoke("currentImageNumber", "currentImageNumber() const", typeof(int));
		}
		public QRect CurrentImageRect() {
			return (QRect) interceptor.Invoke("currentImageRect", "currentImageRect() const", typeof(QRect));
		}
		public int Error() {
			return (int) interceptor.Invoke("error", "error() const", typeof(int));
		}
		public string ErrorString() {
			return (string) interceptor.Invoke("errorString", "errorString() const", typeof(string));
		}
		public bool SupportsOption(QImageIOHandler.ImageOption option) {
			return (bool) interceptor.Invoke("supportsOption$", "supportsOption(QImageIOHandler::ImageOption) const", typeof(bool), typeof(QImageIOHandler.ImageOption), option);
		}
		~QImageReader() {
			interceptor.Invoke("~QImageReader", "~QImageReader()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QImageReader", "~QImageReader()", typeof(void));
		}
		public static QByteArray ImageFormat(string fileName) {
			return (QByteArray) staticInterceptor.Invoke("imageFormat$", "imageFormat(const QString&)", typeof(QByteArray), typeof(string), fileName);
		}
		public static QByteArray ImageFormat(QIODevice device) {
			return (QByteArray) staticInterceptor.Invoke("imageFormat#", "imageFormat(QIODevice*)", typeof(QByteArray), typeof(QIODevice), device);
		}
		public static List<QByteArray> SupportedImageFormats() {
			return (List<QByteArray>) staticInterceptor.Invoke("supportedImageFormats", "supportedImageFormats()", typeof(List<QByteArray>));
		}
	}
}
