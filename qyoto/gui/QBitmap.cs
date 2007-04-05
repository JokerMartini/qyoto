//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QBitmap")]
	public class QBitmap : QPixmap, IDisposable {
 		protected QBitmap(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QBitmap), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QBitmap() {
			staticInterceptor = new SmokeInvocation(typeof(QBitmap), null);
		}
		//  operator QVariant(); >>>> NOT CONVERTED
		public QBitmap() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QBitmap", "QBitmap()", typeof(void));
		}
		public QBitmap(QPixmap arg1) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QBitmap#", "QBitmap(const QPixmap&)", typeof(void), typeof(QPixmap), arg1);
		}
		public QBitmap(int w, int h) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QBitmap$$", "QBitmap(int, int)", typeof(void), typeof(int), w, typeof(int), h);
		}
		public QBitmap(QSize arg1) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QBitmap#", "QBitmap(const QSize&)", typeof(void), typeof(QSize), arg1);
		}
		public QBitmap(string fileName, string format) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QBitmap$$", "QBitmap(const QString&, const char*)", typeof(void), typeof(string), fileName, typeof(string), format);
		}
		public QBitmap(string fileName) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QBitmap$", "QBitmap(const QString&)", typeof(void), typeof(string), fileName);
		}
		public void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		public QBitmap Transformed(QMatrix arg1) {
			return (QBitmap) interceptor.Invoke("transformed#", "transformed(const QMatrix&) const", typeof(QBitmap), typeof(QMatrix), arg1);
		}
		public QBitmap Transformed(QTransform matrix) {
			return (QBitmap) interceptor.Invoke("transformed#", "transformed(const QTransform&) const", typeof(QBitmap), typeof(QTransform), matrix);
		}
		~QBitmap() {
			interceptor.Invoke("~QBitmap", "~QBitmap()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QBitmap", "~QBitmap()", typeof(void));
		}
		public static QBitmap FromImage(QImage image, int flags) {
			return (QBitmap) staticInterceptor.Invoke("fromImage#$", "fromImage(const QImage&, Qt::ImageConversionFlags)", typeof(QBitmap), typeof(QImage), image, typeof(int), flags);
		}
		public static QBitmap FromImage(QImage image) {
			return (QBitmap) staticInterceptor.Invoke("fromImage#", "fromImage(const QImage&)", typeof(QBitmap), typeof(QImage), image);
		}
		public static QBitmap FromData(QSize size, char[] bits, QImage.Format monoFormat) {
			return (QBitmap) staticInterceptor.Invoke("fromData#$$", "fromData(const QSize&, const uchar*, QImage::Format)", typeof(QBitmap), typeof(QSize), size, typeof(char[]), bits, typeof(QImage.Format), monoFormat);
		}
		public static QBitmap FromData(QSize size, char[] bits) {
			return (QBitmap) staticInterceptor.Invoke("fromData#$", "fromData(const QSize&, const uchar*)", typeof(QBitmap), typeof(QSize), size, typeof(char[]), bits);
		}
	}
}
