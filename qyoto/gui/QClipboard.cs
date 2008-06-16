//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	using System.Text;
	[SmokeClass("QClipboard")]
	public class QClipboard : QObject {
 		protected QClipboard(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QClipboard), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QClipboard() {
			staticInterceptor = new SmokeInvocation(typeof(QClipboard), null);
		}
		public enum Mode {
			Clipboard = 0,
			Selection = 1,
			FindBuffer = 2,
			LastMode = FindBuffer,
		}
		public void Clear(QClipboard.Mode mode) {
			interceptor.Invoke("clear$", "clear(QClipboard::Mode)", typeof(void), typeof(QClipboard.Mode), mode);
		}
		public void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		public bool SupportsSelection() {
			return (bool) interceptor.Invoke("supportsSelection", "supportsSelection() const", typeof(bool));
		}
		public bool SupportsFindBuffer() {
			return (bool) interceptor.Invoke("supportsFindBuffer", "supportsFindBuffer() const", typeof(bool));
		}
		public bool OwnsSelection() {
			return (bool) interceptor.Invoke("ownsSelection", "ownsSelection() const", typeof(bool));
		}
		public bool OwnsClipboard() {
			return (bool) interceptor.Invoke("ownsClipboard", "ownsClipboard() const", typeof(bool));
		}
		public bool OwnsFindBuffer() {
			return (bool) interceptor.Invoke("ownsFindBuffer", "ownsFindBuffer() const", typeof(bool));
		}
		public string Text(QClipboard.Mode mode) {
			return (string) interceptor.Invoke("text$", "text(QClipboard::Mode) const", typeof(string), typeof(QClipboard.Mode), mode);
		}
		public string Text() {
			return (string) interceptor.Invoke("text", "text() const", typeof(string));
		}
		public string Text(StringBuilder subtype, QClipboard.Mode mode) {
			return (string) interceptor.Invoke("text$$", "text(QString&, QClipboard::Mode) const", typeof(string), typeof(StringBuilder), subtype, typeof(QClipboard.Mode), mode);
		}
		public string Text(StringBuilder subtype) {
			return (string) interceptor.Invoke("text$", "text(QString&) const", typeof(string), typeof(StringBuilder), subtype);
		}
		public void SetText(string arg1, QClipboard.Mode mode) {
			interceptor.Invoke("setText$$", "setText(const QString&, QClipboard::Mode)", typeof(void), typeof(string), arg1, typeof(QClipboard.Mode), mode);
		}
		public void SetText(string arg1) {
			interceptor.Invoke("setText$", "setText(const QString&)", typeof(void), typeof(string), arg1);
		}
		public QMimeData MimeData(QClipboard.Mode mode) {
			return (QMimeData) interceptor.Invoke("mimeData$", "mimeData(QClipboard::Mode) const", typeof(QMimeData), typeof(QClipboard.Mode), mode);
		}
		public QMimeData MimeData() {
			return (QMimeData) interceptor.Invoke("mimeData", "mimeData() const", typeof(QMimeData));
		}
		public void SetMimeData(QMimeData data, QClipboard.Mode mode) {
			interceptor.Invoke("setMimeData#$", "setMimeData(QMimeData*, QClipboard::Mode)", typeof(void), typeof(QMimeData), data, typeof(QClipboard.Mode), mode);
		}
		public void SetMimeData(QMimeData data) {
			interceptor.Invoke("setMimeData#", "setMimeData(QMimeData*)", typeof(void), typeof(QMimeData), data);
		}
		public QImage Image(QClipboard.Mode mode) {
			return (QImage) interceptor.Invoke("image$", "image(QClipboard::Mode) const", typeof(QImage), typeof(QClipboard.Mode), mode);
		}
		public QImage Image() {
			return (QImage) interceptor.Invoke("image", "image() const", typeof(QImage));
		}
		public QPixmap Pixmap(QClipboard.Mode mode) {
			return (QPixmap) interceptor.Invoke("pixmap$", "pixmap(QClipboard::Mode) const", typeof(QPixmap), typeof(QClipboard.Mode), mode);
		}
		public QPixmap Pixmap() {
			return (QPixmap) interceptor.Invoke("pixmap", "pixmap() const", typeof(QPixmap));
		}
		public void SetImage(QImage arg1, QClipboard.Mode mode) {
			interceptor.Invoke("setImage#$", "setImage(const QImage&, QClipboard::Mode)", typeof(void), typeof(QImage), arg1, typeof(QClipboard.Mode), mode);
		}
		public void SetImage(QImage arg1) {
			interceptor.Invoke("setImage#", "setImage(const QImage&)", typeof(void), typeof(QImage), arg1);
		}
		public void SetPixmap(QPixmap arg1, QClipboard.Mode mode) {
			interceptor.Invoke("setPixmap#$", "setPixmap(const QPixmap&, QClipboard::Mode)", typeof(void), typeof(QPixmap), arg1, typeof(QClipboard.Mode), mode);
		}
		public void SetPixmap(QPixmap arg1) {
			interceptor.Invoke("setPixmap#", "setPixmap(const QPixmap&)", typeof(void), typeof(QPixmap), arg1);
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQClipboardSignals Emit {
			get { return (IQClipboardSignals) Q_EMIT; }
		}
	}

	public interface IQClipboardSignals : IQObjectSignals {
	}
}
