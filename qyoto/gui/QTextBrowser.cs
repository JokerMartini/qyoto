//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	///<remarks> See <see cref="IQTextBrowserSignals"></see> for signals emitted by QTextBrowser
	///</remarks>

	[SmokeClass("QTextBrowser")]
	public class QTextBrowser : QTextEdit, IDisposable {
 		protected QTextBrowser(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QTextBrowser), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QTextBrowser() {
			staticInterceptor = new SmokeInvocation(typeof(QTextBrowser), null);
		}
		[Q_PROPERTY("QUrl", "source")]
		public QUrl Source {
			get { return (QUrl) interceptor.Invoke("source", "source()", typeof(QUrl)); }
			set { interceptor.Invoke("setSource#", "setSource(QUrl)", typeof(void), typeof(QUrl), value); }
		}
		[Q_PROPERTY("QStringList", "searchPaths")]
		public List<string> SearchPaths {
			get { return (List<string>) interceptor.Invoke("searchPaths", "searchPaths()", typeof(List<string>)); }
			set { interceptor.Invoke("setSearchPaths?", "setSearchPaths(QStringList)", typeof(void), typeof(List<string>), value); }
		}
		[Q_PROPERTY("bool", "openExternalLinks")]
		public bool OpenExternalLinks {
			get { return (bool) interceptor.Invoke("openExternalLinks", "openExternalLinks()", typeof(bool)); }
			set { interceptor.Invoke("setOpenExternalLinks$", "setOpenExternalLinks(bool)", typeof(void), typeof(bool), value); }
		}
		public QTextBrowser(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTextBrowser#", "QTextBrowser(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public QTextBrowser() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTextBrowser", "QTextBrowser()", typeof(void));
		}
		[SmokeMethod("loadResource(int, const QUrl&)")]
		public override QVariant LoadResource(int type, QUrl name) {
			return (QVariant) interceptor.Invoke("loadResource$#", "loadResource(int, const QUrl&)", typeof(QVariant), typeof(int), type, typeof(QUrl), name);
		}
		public bool IsBackwardAvailable() {
			return (bool) interceptor.Invoke("isBackwardAvailable", "isBackwardAvailable() const", typeof(bool));
		}
		public bool IsForwardAvailable() {
			return (bool) interceptor.Invoke("isForwardAvailable", "isForwardAvailable() const", typeof(bool));
		}
		public void ClearHistory() {
			interceptor.Invoke("clearHistory", "clearHistory()", typeof(void));
		}
		[Q_SLOT("void setSource(const QUrl&)")]
		[SmokeMethod("setSource(const QUrl&)")]
		public virtual void SetSource(QUrl name) {
			interceptor.Invoke("setSource#", "setSource(const QUrl&)", typeof(void), typeof(QUrl), name);
		}
		[Q_SLOT("void backward()")]
		[SmokeMethod("backward()")]
		public virtual void Backward() {
			interceptor.Invoke("backward", "backward()", typeof(void));
		}
		[Q_SLOT("void forward()")]
		[SmokeMethod("forward()")]
		public virtual void Forward() {
			interceptor.Invoke("forward", "forward()", typeof(void));
		}
		[Q_SLOT("void home()")]
		[SmokeMethod("home()")]
		public virtual void Home() {
			interceptor.Invoke("home", "home()", typeof(void));
		}
		[Q_SLOT("void reload()")]
		[SmokeMethod("reload()")]
		public virtual void Reload() {
			interceptor.Invoke("reload", "reload()", typeof(void));
		}
		[SmokeMethod("event(QEvent*)")]
		protected override bool Event(QEvent e) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), e);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected override void KeyPressEvent(QKeyEvent ev) {
			interceptor.Invoke("keyPressEvent#", "keyPressEvent(QKeyEvent*)", typeof(void), typeof(QKeyEvent), ev);
		}
		[SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
		protected override void MouseMoveEvent(QMouseEvent ev) {
			interceptor.Invoke("mouseMoveEvent#", "mouseMoveEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), ev);
		}
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected override void MousePressEvent(QMouseEvent ev) {
			interceptor.Invoke("mousePressEvent#", "mousePressEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), ev);
		}
		[SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
		protected override void MouseReleaseEvent(QMouseEvent ev) {
			interceptor.Invoke("mouseReleaseEvent#", "mouseReleaseEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), ev);
		}
		[SmokeMethod("focusOutEvent(QFocusEvent*)")]
		protected override void FocusOutEvent(QFocusEvent ev) {
			interceptor.Invoke("focusOutEvent#", "focusOutEvent(QFocusEvent*)", typeof(void), typeof(QFocusEvent), ev);
		}
		[SmokeMethod("focusNextPrevChild(bool)")]
		protected override bool FocusNextPrevChild(bool next) {
			return (bool) interceptor.Invoke("focusNextPrevChild$", "focusNextPrevChild(bool)", typeof(bool), typeof(bool), next);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected override void PaintEvent(QPaintEvent e) {
			interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), e);
		}
		~QTextBrowser() {
			interceptor.Invoke("~QTextBrowser", "~QTextBrowser()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QTextBrowser", "~QTextBrowser()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQTextBrowserSignals Emit {
			get { return (IQTextBrowserSignals) Q_EMIT; }
		}
	}

	public interface IQTextBrowserSignals : IQTextEditSignals {
		[Q_SIGNAL("void backwardAvailable(bool)")]
		void BackwardAvailable(bool arg1);
		[Q_SIGNAL("void forwardAvailable(bool)")]
		void ForwardAvailable(bool arg1);
		[Q_SIGNAL("void sourceChanged(const QUrl&)")]
		void SourceChanged(QUrl arg1);
		[Q_SIGNAL("void highlighted(const QUrl&)")]
		void Highlighted(QUrl arg1);
		[Q_SIGNAL("void highlighted(const QString&)")]
		void Highlighted(string arg1);
		[Q_SIGNAL("void anchorClicked(const QUrl&)")]
		void AnchorClicked(QUrl arg1);
	}
}
