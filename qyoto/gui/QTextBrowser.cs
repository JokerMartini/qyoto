//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	/// See <see cref="IQTextBrowserSignals"></see> for signals emitted by QTextBrowser
	[SmokeClass("QTextBrowser")]
	public class QTextBrowser : QTextEdit, IDisposable {
 		protected QTextBrowser(Type dummy) : base((Type) null) {}
		interface IQTextBrowserProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextBrowser), this);
			_interceptor = (QTextBrowser) realProxy.GetTransparentProxy();
		}
		private QTextBrowser ProxyQTextBrowser() {
			return (QTextBrowser) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextBrowser() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextBrowserProxy), null);
			_staticInterceptor = (IQTextBrowserProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextBrowserProxy StaticQTextBrowser() {
			return (IQTextBrowserProxy) _staticInterceptor;
		}

		public IQUrl Source {
			get {
				return Property("Source").Value<IQUrl>();
			}
			set {
				SetProperty("Source", QVariant.FromValue<IQUrl>(value));
			}
		}
		public List<string> SearchPaths {
			get {
				return Property("SearchPaths").Value<List<string>>();
			}
			set {
				SetProperty("SearchPaths", QVariant.FromValue<List<string>>(value));
			}
		}
		public bool OpenExternalLinks {
			get {
				return Property("OpenExternalLinks").Value<bool>();
			}
			set {
				SetProperty("OpenExternalLinks", QVariant.FromValue<bool>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QTextBrowser(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQTextBrowser(parent);
		}
		[SmokeMethod("QTextBrowser(QWidget*)")]
		private void NewQTextBrowser(QWidget parent) {
			ProxyQTextBrowser().NewQTextBrowser(parent);
		}
		public QTextBrowser() : this((Type) null) {
			CreateProxy();
			NewQTextBrowser();
		}
		[SmokeMethod("QTextBrowser()")]
		private void NewQTextBrowser() {
			ProxyQTextBrowser().NewQTextBrowser();
		}
		[SmokeMethod("loadResource(int, const QUrl&)")]
		public new virtual QVariant LoadResource(int type, IQUrl name) {
			return ProxyQTextBrowser().LoadResource(type,name);
		}
		[SmokeMethod("isBackwardAvailable() const")]
		public bool IsBackwardAvailable() {
			return ProxyQTextBrowser().IsBackwardAvailable();
		}
		[SmokeMethod("isForwardAvailable() const")]
		public bool IsForwardAvailable() {
			return ProxyQTextBrowser().IsForwardAvailable();
		}
		[SmokeMethod("clearHistory()")]
		public void ClearHistory() {
			ProxyQTextBrowser().ClearHistory();
		}
		[SmokeMethod("backward()")]
		public virtual void Backward() {
			ProxyQTextBrowser().Backward();
		}
		[SmokeMethod("forward()")]
		public virtual void Forward() {
			ProxyQTextBrowser().Forward();
		}
		[SmokeMethod("home()")]
		public virtual void Home() {
			ProxyQTextBrowser().Home();
		}
		[SmokeMethod("reload()")]
		public virtual void Reload() {
			ProxyQTextBrowser().Reload();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQTextBrowser().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQTextBrowser().Tr(s);
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent e) {
			return ProxyQTextBrowser().Event(e);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected new virtual void KeyPressEvent(QKeyEvent ev) {
			ProxyQTextBrowser().KeyPressEvent(ev);
		}
		[SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
		protected new virtual void MouseMoveEvent(QMouseEvent ev) {
			ProxyQTextBrowser().MouseMoveEvent(ev);
		}
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected new virtual void MousePressEvent(QMouseEvent ev) {
			ProxyQTextBrowser().MousePressEvent(ev);
		}
		[SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
		protected new virtual void MouseReleaseEvent(QMouseEvent ev) {
			ProxyQTextBrowser().MouseReleaseEvent(ev);
		}
		[SmokeMethod("focusOutEvent(QFocusEvent*)")]
		protected new virtual void FocusOutEvent(QFocusEvent ev) {
			ProxyQTextBrowser().FocusOutEvent(ev);
		}
		[SmokeMethod("focusNextPrevChild(bool)")]
		protected new virtual bool FocusNextPrevChild(bool next) {
			return ProxyQTextBrowser().FocusNextPrevChild(next);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected new virtual void PaintEvent(QPaintEvent e) {
			ProxyQTextBrowser().PaintEvent(e);
		}
		~QTextBrowser() {
			DisposeQTextBrowser();
		}
		public new void Dispose() {
			DisposeQTextBrowser();
		}
		[SmokeMethod("~QTextBrowser()")]
		private void DisposeQTextBrowser() {
			ProxyQTextBrowser().DisposeQTextBrowser();
		}
		protected new IQTextBrowserSignals Emit() {
			return (IQTextBrowserSignals) Q_EMIT;
		}
	}

	public interface IQTextBrowserSignals : IQTextEditSignals {
		[Q_SIGNAL("void backwardAvailable(bool)")]
		void BackwardAvailable(bool arg1);
		[Q_SIGNAL("void forwardAvailable(bool)")]
		void ForwardAvailable(bool arg1);
		[Q_SIGNAL("void sourceChanged(const QUrl&)")]
		void SourceChanged(IQUrl arg1);
		[Q_SIGNAL("void highlighted(const QUrl&)")]
		void Highlighted(IQUrl arg1);
		[Q_SIGNAL("void highlighted(const QString&)")]
		void Highlighted(string arg1);
		[Q_SIGNAL("void anchorClicked(const QUrl&)")]
		void AnchorClicked(IQUrl arg1);
	}
}
