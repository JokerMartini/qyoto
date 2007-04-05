//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QScrollArea")]
	public class QScrollArea : QAbstractScrollArea, IDisposable {
 		protected QScrollArea(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QScrollArea), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QScrollArea() {
			staticInterceptor = new SmokeInvocation(typeof(QScrollArea), null);
		}
		[Q_PROPERTY("bool", "widgetResizable")]
		public bool WidgetResizable {
			get { return (bool) interceptor.Invoke("widgetResizable", "widgetResizable()", typeof(bool)); }
			set { interceptor.Invoke("setWidgetResizable$", "setWidgetResizable(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("Qt::Alignment", "alignment")]
		public int Alignment {
			get { return (int) interceptor.Invoke("alignment", "alignment()", typeof(int)); }
			set { interceptor.Invoke("setAlignment$", "setAlignment(Qt::Alignment)", typeof(void), typeof(int), value); }
		}
		public QScrollArea(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QScrollArea#", "QScrollArea(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public QScrollArea() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QScrollArea", "QScrollArea()", typeof(void));
		}
		public QWidget Widget() {
			return (QWidget) interceptor.Invoke("widget", "widget() const", typeof(QWidget));
		}
		public void SetWidget(QWidget widget) {
			interceptor.Invoke("setWidget#", "setWidget(QWidget*)", typeof(void), typeof(QWidget), widget);
		}
		public QWidget TakeWidget() {
			return (QWidget) interceptor.Invoke("takeWidget", "takeWidget()", typeof(QWidget));
		}
		[SmokeMethod("sizeHint() const")]
		public override QSize SizeHint() {
			return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
		}
		[SmokeMethod("focusNextPrevChild(bool)")]
		public new virtual bool FocusNextPrevChild(bool next) {
			return (bool) interceptor.Invoke("focusNextPrevChild$", "focusNextPrevChild(bool)", typeof(bool), typeof(bool), next);
		}
		public void EnsureVisible(int x, int y, int xmargin, int ymargin) {
			interceptor.Invoke("ensureVisible$$$$", "ensureVisible(int, int, int, int)", typeof(void), typeof(int), x, typeof(int), y, typeof(int), xmargin, typeof(int), ymargin);
		}
		public void EnsureVisible(int x, int y, int xmargin) {
			interceptor.Invoke("ensureVisible$$$", "ensureVisible(int, int, int)", typeof(void), typeof(int), x, typeof(int), y, typeof(int), xmargin);
		}
		public void EnsureVisible(int x, int y) {
			interceptor.Invoke("ensureVisible$$", "ensureVisible(int, int)", typeof(void), typeof(int), x, typeof(int), y);
		}
		public void EnsureWidgetVisible(QWidget childWidget, int xmargin, int ymargin) {
			interceptor.Invoke("ensureWidgetVisible#$$", "ensureWidgetVisible(QWidget*, int, int)", typeof(void), typeof(QWidget), childWidget, typeof(int), xmargin, typeof(int), ymargin);
		}
		public void EnsureWidgetVisible(QWidget childWidget, int xmargin) {
			interceptor.Invoke("ensureWidgetVisible#$", "ensureWidgetVisible(QWidget*, int)", typeof(void), typeof(QWidget), childWidget, typeof(int), xmargin);
		}
		public void EnsureWidgetVisible(QWidget childWidget) {
			interceptor.Invoke("ensureWidgetVisible#", "ensureWidgetVisible(QWidget*)", typeof(void), typeof(QWidget), childWidget);
		}
		[SmokeMethod("event(QEvent*)")]
		protected override bool Event(QEvent arg1) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
		}
		[SmokeMethod("eventFilter(QObject*, QEvent*)")]
		protected new virtual bool EventFilter(QObject arg1, QEvent arg2) {
			return (bool) interceptor.Invoke("eventFilter##", "eventFilter(QObject*, QEvent*)", typeof(bool), typeof(QObject), arg1, typeof(QEvent), arg2);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected override void ResizeEvent(QResizeEvent arg1) {
			interceptor.Invoke("resizeEvent#", "resizeEvent(QResizeEvent*)", typeof(void), typeof(QResizeEvent), arg1);
		}
		[SmokeMethod("scrollContentsBy(int, int)")]
		protected override void ScrollContentsBy(int dx, int dy) {
			interceptor.Invoke("scrollContentsBy$$", "scrollContentsBy(int, int)", typeof(void), typeof(int), dx, typeof(int), dy);
		}
		~QScrollArea() {
			interceptor.Invoke("~QScrollArea", "~QScrollArea()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QScrollArea", "~QScrollArea()", typeof(void));
		}
		public static string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQScrollAreaSignals Emit {
			get { return (IQScrollAreaSignals) Q_EMIT; }
		}
	}

	public interface IQScrollAreaSignals : IQAbstractScrollAreaSignals {
	}
}
