//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QClipboard")]
	public class QClipboard : QObject {
 		protected QClipboard(Type dummy) : base((Type) null) {}
		[SmokeClass("QClipboard")]
		interface IQClipboardProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QClipboard), this);
			_interceptor = (QClipboard) realProxy.GetTransparentProxy();
		}
		private QClipboard ProxyQClipboard() {
			return (QClipboard) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QClipboard() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQClipboardProxy), null);
			_staticInterceptor = (IQClipboardProxy) realProxy.GetTransparentProxy();
		}
		private static IQClipboardProxy StaticQClipboard() {
			return (IQClipboardProxy) _staticInterceptor;
		}

		public enum Mode {
			Clipboard = 0,
			Selection = 1,
			FindBuffer = 2,
			LastMode = FindBuffer,
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		[SmokeMethod("clear", "(QClipboard::Mode)", "$")]
		public void Clear(QClipboard.Mode mode) {
			ProxyQClipboard().Clear(mode);
		}
		[SmokeMethod("clear", "()", "")]
		public void Clear() {
			ProxyQClipboard().Clear();
		}
		[SmokeMethod("supportsSelection", "() const", "")]
		public bool SupportsSelection() {
			return ProxyQClipboard().SupportsSelection();
		}
		[SmokeMethod("supportsFindBuffer", "() const", "")]
		public bool SupportsFindBuffer() {
			return ProxyQClipboard().SupportsFindBuffer();
		}
		[SmokeMethod("ownsSelection", "() const", "")]
		public bool OwnsSelection() {
			return ProxyQClipboard().OwnsSelection();
		}
		[SmokeMethod("ownsClipboard", "() const", "")]
		public bool OwnsClipboard() {
			return ProxyQClipboard().OwnsClipboard();
		}
		[SmokeMethod("ownsFindBuffer", "() const", "")]
		public bool OwnsFindBuffer() {
			return ProxyQClipboard().OwnsFindBuffer();
		}
		[SmokeMethod("text", "(QClipboard::Mode) const", "$")]
		public string Text(QClipboard.Mode mode) {
			return ProxyQClipboard().Text(mode);
		}
		[SmokeMethod("text", "() const", "")]
		public string Text() {
			return ProxyQClipboard().Text();
		}
		[SmokeMethod("text", "(QString&, QClipboard::Mode) const", "$$")]
		public string Text(StringBuilder subtype, QClipboard.Mode mode) {
			return ProxyQClipboard().Text(subtype,mode);
		}
		[SmokeMethod("text", "(QString&) const", "$")]
		public string Text(StringBuilder subtype) {
			return ProxyQClipboard().Text(subtype);
		}
		[SmokeMethod("setText", "(const QString&, QClipboard::Mode)", "$$")]
		public void SetText(string arg1, QClipboard.Mode mode) {
			ProxyQClipboard().SetText(arg1,mode);
		}
		[SmokeMethod("setText", "(const QString&)", "$")]
		public void SetText(string arg1) {
			ProxyQClipboard().SetText(arg1);
		}
		[SmokeMethod("mimeData", "(QClipboard::Mode) const", "$")]
		public QMimeData MimeData(QClipboard.Mode mode) {
			return ProxyQClipboard().MimeData(mode);
		}
		[SmokeMethod("mimeData", "() const", "")]
		public QMimeData MimeData() {
			return ProxyQClipboard().MimeData();
		}
		[SmokeMethod("setMimeData", "(QMimeData*, QClipboard::Mode)", "#$")]
		public void SetMimeData(QMimeData data, QClipboard.Mode mode) {
			ProxyQClipboard().SetMimeData(data,mode);
		}
		[SmokeMethod("setMimeData", "(QMimeData*)", "#")]
		public void SetMimeData(QMimeData data) {
			ProxyQClipboard().SetMimeData(data);
		}
		[SmokeMethod("image", "(QClipboard::Mode) const", "$")]
		public QImage Image(QClipboard.Mode mode) {
			return ProxyQClipboard().Image(mode);
		}
		[SmokeMethod("image", "() const", "")]
		public QImage Image() {
			return ProxyQClipboard().Image();
		}
		[SmokeMethod("pixmap", "(QClipboard::Mode) const", "$")]
		public QPixmap Pixmap(QClipboard.Mode mode) {
			return ProxyQClipboard().Pixmap(mode);
		}
		[SmokeMethod("pixmap", "() const", "")]
		public QPixmap Pixmap() {
			return ProxyQClipboard().Pixmap();
		}
		[SmokeMethod("setImage", "(const QImage&, QClipboard::Mode)", "#$")]
		public void SetImage(QImage arg1, QClipboard.Mode mode) {
			ProxyQClipboard().SetImage(arg1,mode);
		}
		[SmokeMethod("setImage", "(const QImage&)", "#")]
		public void SetImage(QImage arg1) {
			ProxyQClipboard().SetImage(arg1);
		}
		[SmokeMethod("setPixmap", "(const QPixmap&, QClipboard::Mode)", "#$")]
		public void SetPixmap(QPixmap arg1, QClipboard.Mode mode) {
			ProxyQClipboard().SetPixmap(arg1,mode);
		}
		[SmokeMethod("setPixmap", "(const QPixmap&)", "#")]
		public void SetPixmap(QPixmap arg1) {
			ProxyQClipboard().SetPixmap(arg1);
		}
		public static new string Tr(string s, string c) {
			return StaticQClipboard().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQClipboard().Tr(s);
		}
		protected new IQClipboardSignals Emit {
			get {
				return (IQClipboardSignals) Q_EMIT;
			}
		}
	}

	public interface IQClipboardSignals : IQObjectSignals {
	}
}
