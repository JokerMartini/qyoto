//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	/// See <see cref="IQTabWidgetSignals"></see> for signals emitted by QTabWidget
	[SmokeClass("QTabWidget")]
	public class QTabWidget : QWidget, IDisposable {
 		protected QTabWidget(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QTabWidget), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QTabWidget() {
			staticInterceptor = new SmokeInvocation(typeof(QTabWidget), null);
		}
		public enum TabPosition {
			North = 0,
			South = 1,
			West = 2,
			East = 3,
		}
		public enum TabShape {
			Rounded = 0,
			Triangular = 1,
		}
		[Q_PROPERTY("QTabWidget::TabPosition", "tabPosition")]
		public QTabWidget.TabPosition tabPosition {
			get { return (QTabWidget.TabPosition) interceptor.Invoke("tabPosition", "tabPosition()", typeof(QTabWidget.TabPosition)); }
			set { interceptor.Invoke("setTabPosition$", "setTabPosition(QTabWidget::TabPosition)", typeof(void), typeof(QTabWidget.TabPosition), value); }
		}
		[Q_PROPERTY("QTabWidget::TabShape", "tabShape")]
		public QTabWidget.TabShape tabShape {
			get { return (QTabWidget.TabShape) interceptor.Invoke("tabShape", "tabShape()", typeof(QTabWidget.TabShape)); }
			set { interceptor.Invoke("setTabShape$", "setTabShape(QTabWidget::TabShape)", typeof(void), typeof(QTabWidget.TabShape), value); }
		}
		[Q_PROPERTY("int", "currentIndex")]
		public int CurrentIndex {
			get { return (int) interceptor.Invoke("currentIndex", "currentIndex()", typeof(int)); }
			set { interceptor.Invoke("setCurrentIndex$", "setCurrentIndex(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("int", "count")]
		public int Count {
			get { return (int) interceptor.Invoke("count", "count()", typeof(int)); }
		}
		[Q_PROPERTY("QSize", "iconSize")]
		public QSize IconSize {
			get { return (QSize) interceptor.Invoke("iconSize", "iconSize()", typeof(QSize)); }
			set { interceptor.Invoke("setIconSize#", "setIconSize(QSize)", typeof(void), typeof(QSize), value); }
		}
		[Q_PROPERTY("Qt::TextElideMode", "elideMode")]
		public Qt.TextElideMode ElideMode {
			get { return (Qt.TextElideMode) interceptor.Invoke("elideMode", "elideMode()", typeof(Qt.TextElideMode)); }
			set { interceptor.Invoke("setElideMode$", "setElideMode(Qt::TextElideMode)", typeof(void), typeof(Qt.TextElideMode), value); }
		}
		[Q_PROPERTY("bool", "usesScrollButtons")]
		public bool UsesScrollButtons {
			get { return (bool) interceptor.Invoke("usesScrollButtons", "usesScrollButtons()", typeof(bool)); }
			set { interceptor.Invoke("setUsesScrollButtons$", "setUsesScrollButtons(bool)", typeof(void), typeof(bool), value); }
		}
		public QTabWidget(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTabWidget#", "QTabWidget(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public QTabWidget() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTabWidget", "QTabWidget()", typeof(void));
		}
		public int AddTab(QWidget widget, string arg2) {
			return (int) interceptor.Invoke("addTab#$", "addTab(QWidget*, const QString&)", typeof(int), typeof(QWidget), widget, typeof(string), arg2);
		}
		public int AddTab(QWidget widget, QIcon icon, string label) {
			return (int) interceptor.Invoke("addTab##$", "addTab(QWidget*, const QIcon&, const QString&)", typeof(int), typeof(QWidget), widget, typeof(QIcon), icon, typeof(string), label);
		}
		public int InsertTab(int index, QWidget widget, string arg3) {
			return (int) interceptor.Invoke("insertTab$#$", "insertTab(int, QWidget*, const QString&)", typeof(int), typeof(int), index, typeof(QWidget), widget, typeof(string), arg3);
		}
		public int InsertTab(int index, QWidget widget, QIcon icon, string label) {
			return (int) interceptor.Invoke("insertTab$##$", "insertTab(int, QWidget*, const QIcon&, const QString&)", typeof(int), typeof(int), index, typeof(QWidget), widget, typeof(QIcon), icon, typeof(string), label);
		}
		public void RemoveTab(int index) {
			interceptor.Invoke("removeTab$", "removeTab(int)", typeof(void), typeof(int), index);
		}
		public bool IsTabEnabled(int index) {
			return (bool) interceptor.Invoke("isTabEnabled$", "isTabEnabled(int) const", typeof(bool), typeof(int), index);
		}
		public void SetTabEnabled(int index, bool arg2) {
			interceptor.Invoke("setTabEnabled$$", "setTabEnabled(int, bool)", typeof(void), typeof(int), index, typeof(bool), arg2);
		}
		public string TabText(int index) {
			return (string) interceptor.Invoke("tabText$", "tabText(int) const", typeof(string), typeof(int), index);
		}
		public void SetTabText(int index, string arg2) {
			interceptor.Invoke("setTabText$$", "setTabText(int, const QString&)", typeof(void), typeof(int), index, typeof(string), arg2);
		}
		public QIcon TabIcon(int index) {
			return (QIcon) interceptor.Invoke("tabIcon$", "tabIcon(int) const", typeof(QIcon), typeof(int), index);
		}
		public void SetTabIcon(int index, QIcon icon) {
			interceptor.Invoke("setTabIcon$#", "setTabIcon(int, const QIcon&)", typeof(void), typeof(int), index, typeof(QIcon), icon);
		}
		public void SetTabToolTip(int index, string tip) {
			interceptor.Invoke("setTabToolTip$$", "setTabToolTip(int, const QString&)", typeof(void), typeof(int), index, typeof(string), tip);
		}
		public string TabToolTip(int index) {
			return (string) interceptor.Invoke("tabToolTip$", "tabToolTip(int) const", typeof(string), typeof(int), index);
		}
		public void SetTabWhatsThis(int index, string text) {
			interceptor.Invoke("setTabWhatsThis$$", "setTabWhatsThis(int, const QString&)", typeof(void), typeof(int), index, typeof(string), text);
		}
		public string TabWhatsThis(int index) {
			return (string) interceptor.Invoke("tabWhatsThis$", "tabWhatsThis(int) const", typeof(string), typeof(int), index);
		}
		public QWidget CurrentWidget() {
			return (QWidget) interceptor.Invoke("currentWidget", "currentWidget() const", typeof(QWidget));
		}
		public QWidget Widget(int index) {
			return (QWidget) interceptor.Invoke("widget$", "widget(int) const", typeof(QWidget), typeof(int), index);
		}
		public int IndexOf(QWidget widget) {
			return (int) interceptor.Invoke("indexOf#", "indexOf(QWidget*) const", typeof(int), typeof(QWidget), widget);
		}
		[SmokeMethod("sizeHint() const")]
		public override QSize SizeHint() {
			return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
		}
		[SmokeMethod("minimumSizeHint() const")]
		public override QSize MinimumSizeHint() {
			return (QSize) interceptor.Invoke("minimumSizeHint", "minimumSizeHint() const", typeof(QSize));
		}
		public void SetCornerWidget(QWidget w, Qt.Corner corner) {
			interceptor.Invoke("setCornerWidget#$", "setCornerWidget(QWidget*, Qt::Corner)", typeof(void), typeof(QWidget), w, typeof(Qt.Corner), corner);
		}
		public void SetCornerWidget(QWidget w) {
			interceptor.Invoke("setCornerWidget#", "setCornerWidget(QWidget*)", typeof(void), typeof(QWidget), w);
		}
		public QWidget CornerWidget(Qt.Corner corner) {
			return (QWidget) interceptor.Invoke("cornerWidget$", "cornerWidget(Qt::Corner) const", typeof(QWidget), typeof(Qt.Corner), corner);
		}
		public QWidget CornerWidget() {
			return (QWidget) interceptor.Invoke("cornerWidget", "cornerWidget() const", typeof(QWidget));
		}
		public void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		[Q_SLOT("void setCurrentWidget(QWidget*)")]
		public void SetCurrentWidget(QWidget widget) {
			interceptor.Invoke("setCurrentWidget#", "setCurrentWidget(QWidget*)", typeof(void), typeof(QWidget), widget);
		}
		[SmokeMethod("tabInserted(int)")]
		protected virtual void TabInserted(int index) {
			interceptor.Invoke("tabInserted$", "tabInserted(int)", typeof(void), typeof(int), index);
		}
		[SmokeMethod("tabRemoved(int)")]
		protected virtual void TabRemoved(int index) {
			interceptor.Invoke("tabRemoved$", "tabRemoved(int)", typeof(void), typeof(int), index);
		}
		[SmokeMethod("showEvent(QShowEvent*)")]
		protected override void ShowEvent(QShowEvent arg1) {
			interceptor.Invoke("showEvent#", "showEvent(QShowEvent*)", typeof(void), typeof(QShowEvent), arg1);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected override void ResizeEvent(QResizeEvent arg1) {
			interceptor.Invoke("resizeEvent#", "resizeEvent(QResizeEvent*)", typeof(void), typeof(QResizeEvent), arg1);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected override void KeyPressEvent(QKeyEvent arg1) {
			interceptor.Invoke("keyPressEvent#", "keyPressEvent(QKeyEvent*)", typeof(void), typeof(QKeyEvent), arg1);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected override void PaintEvent(QPaintEvent arg1) {
			interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), arg1);
		}
		protected void SetTabBar(QTabBar arg1) {
			interceptor.Invoke("setTabBar#", "setTabBar(QTabBar*)", typeof(void), typeof(QTabBar), arg1);
		}
		protected QTabBar TabBar() {
			return (QTabBar) interceptor.Invoke("tabBar", "tabBar() const", typeof(QTabBar));
		}
		[SmokeMethod("changeEvent(QEvent*)")]
		protected override void ChangeEvent(QEvent arg1) {
			interceptor.Invoke("changeEvent#", "changeEvent(QEvent*)", typeof(void), typeof(QEvent), arg1);
		}
		[SmokeMethod("event(QEvent*)")]
		protected override bool Event(QEvent arg1) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
		}
		protected void InitStyleOption(QStyleOptionTabWidgetFrame option) {
			interceptor.Invoke("initStyleOption#", "initStyleOption(QStyleOptionTabWidgetFrame*) const", typeof(void), typeof(QStyleOptionTabWidgetFrame), option);
		}
		~QTabWidget() {
			interceptor.Invoke("~QTabWidget", "~QTabWidget()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QTabWidget", "~QTabWidget()", typeof(void));
		}
		public static string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQTabWidgetSignals Emit {
			get { return (IQTabWidgetSignals) Q_EMIT; }
		}
	}

	public interface IQTabWidgetSignals : IQWidgetSignals {
		[Q_SIGNAL("void currentChanged(int)")]
		void CurrentChanged(int index);
	}
}
