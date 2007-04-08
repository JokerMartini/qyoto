//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	///<remarks> See <see cref="IQMainWindowSignals"></see> for signals emitted by QMainWindow
	///</remarks>

	[SmokeClass("QMainWindow")]
	public class QMainWindow : QWidget, IDisposable {
 		protected QMainWindow(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QMainWindow), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QMainWindow() {
			staticInterceptor = new SmokeInvocation(typeof(QMainWindow), null);
		}
		public enum DockOption {
			AnimatedDocks = 0x01,
			AllowNestedDocks = 0x02,
			AllowTabbedDocks = 0x04,
			ForceTabbedDocks = 0x08,
			VerticalTabs = 0x10,
		}
		[Q_PROPERTY("QSize", "iconSize")]
		public QSize IconSize {
			get { return (QSize) interceptor.Invoke("iconSize", "iconSize()", typeof(QSize)); }
			set { interceptor.Invoke("setIconSize#", "setIconSize(QSize)", typeof(void), typeof(QSize), value); }
		}
		[Q_PROPERTY("Qt::ToolButtonStyle", "toolButtonStyle")]
		public new Qt.ToolButtonStyle ToolButtonStyle {
			get { return (Qt.ToolButtonStyle) interceptor.Invoke("toolButtonStyle", "toolButtonStyle()", typeof(Qt.ToolButtonStyle)); }
			set { interceptor.Invoke("setToolButtonStyle$", "setToolButtonStyle(Qt::ToolButtonStyle)", typeof(void), typeof(Qt.ToolButtonStyle), value); }
		}
		[Q_PROPERTY("bool", "animated")]
		public bool Animated {
			get { return (bool) interceptor.Invoke("isAnimated", "isAnimated()", typeof(bool)); }
			set { interceptor.Invoke("setAnimated$", "setAnimated(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("bool", "dockNestingEnabled")]
		public bool DockNestingEnabled {
			get { return (bool) interceptor.Invoke("isDockNestingEnabled", "isDockNestingEnabled()", typeof(bool)); }
			set { interceptor.Invoke("setDockNestingEnabled$", "setDockNestingEnabled(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("bool", "unifiedTitleAndToolBarOnMac")]
		public bool UnifiedTitleAndToolBarOnMac {
			get { return (bool) interceptor.Invoke("unifiedTitleAndToolBarOnMac", "unifiedTitleAndToolBarOnMac()", typeof(bool)); }
			set { interceptor.Invoke("setUnifiedTitleAndToolBarOnMac$", "setUnifiedTitleAndToolBarOnMac(bool)", typeof(void), typeof(bool), value); }
		}
		public QMainWindow(QWidget parent, int flags) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QMainWindow#$", "QMainWindow(QWidget*, Qt::WindowFlags)", typeof(void), typeof(QWidget), parent, typeof(int), flags);
		}
		public QMainWindow(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QMainWindow#", "QMainWindow(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public QMainWindow() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QMainWindow", "QMainWindow()", typeof(void));
		}
		public bool IsSeparator(QPoint pos) {
			return (bool) interceptor.Invoke("isSeparator#", "isSeparator(const QPoint&) const", typeof(bool), typeof(QPoint), pos);
		}
		public QMenuBar MenuBar() {
			return (QMenuBar) interceptor.Invoke("menuBar", "menuBar() const", typeof(QMenuBar));
		}
		public void SetMenuBar(QMenuBar menubar) {
			interceptor.Invoke("setMenuBar#", "setMenuBar(QMenuBar*)", typeof(void), typeof(QMenuBar), menubar);
		}
		public QWidget MenuWidget() {
			return (QWidget) interceptor.Invoke("menuWidget", "menuWidget() const", typeof(QWidget));
		}
		public void SetMenuWidget(QWidget menubar) {
			interceptor.Invoke("setMenuWidget#", "setMenuWidget(QWidget*)", typeof(void), typeof(QWidget), menubar);
		}
		public QStatusBar StatusBar() {
			return (QStatusBar) interceptor.Invoke("statusBar", "statusBar() const", typeof(QStatusBar));
		}
		public void SetStatusBar(QStatusBar statusbar) {
			interceptor.Invoke("setStatusBar#", "setStatusBar(QStatusBar*)", typeof(void), typeof(QStatusBar), statusbar);
		}
		public QWidget CentralWidget() {
			return (QWidget) interceptor.Invoke("centralWidget", "centralWidget() const", typeof(QWidget));
		}
		public void SetCentralWidget(QWidget widget) {
			interceptor.Invoke("setCentralWidget#", "setCentralWidget(QWidget*)", typeof(void), typeof(QWidget), widget);
		}
		public void SetCorner(Qt.Corner corner, Qt.DockWidgetArea area) {
			interceptor.Invoke("setCorner$$", "setCorner(Qt::Corner, Qt::DockWidgetArea)", typeof(void), typeof(Qt.Corner), corner, typeof(Qt.DockWidgetArea), area);
		}
		public new Qt.DockWidgetArea Corner(Qt.Corner corner) {
			return (Qt.DockWidgetArea) interceptor.Invoke("corner$", "corner(Qt::Corner) const", typeof(Qt.DockWidgetArea), typeof(Qt.Corner), corner);
		}
		public void AddToolBarBreak(Qt.ToolBarArea area) {
			interceptor.Invoke("addToolBarBreak$", "addToolBarBreak(Qt::ToolBarArea)", typeof(void), typeof(Qt.ToolBarArea), area);
		}
		public void AddToolBarBreak() {
			interceptor.Invoke("addToolBarBreak", "addToolBarBreak()", typeof(void));
		}
		public void InsertToolBarBreak(QToolBar before) {
			interceptor.Invoke("insertToolBarBreak#", "insertToolBarBreak(QToolBar*)", typeof(void), typeof(QToolBar), before);
		}
		public void AddToolBar(Qt.ToolBarArea area, QToolBar toolbar) {
			interceptor.Invoke("addToolBar$#", "addToolBar(Qt::ToolBarArea, QToolBar*)", typeof(void), typeof(Qt.ToolBarArea), area, typeof(QToolBar), toolbar);
		}
		public void AddToolBar(QToolBar toolbar) {
			interceptor.Invoke("addToolBar#", "addToolBar(QToolBar*)", typeof(void), typeof(QToolBar), toolbar);
		}
		public QToolBar AddToolBar(string title) {
			return (QToolBar) interceptor.Invoke("addToolBar$", "addToolBar(const QString&)", typeof(QToolBar), typeof(string), title);
		}
		public void InsertToolBar(QToolBar before, QToolBar toolbar) {
			interceptor.Invoke("insertToolBar##", "insertToolBar(QToolBar*, QToolBar*)", typeof(void), typeof(QToolBar), before, typeof(QToolBar), toolbar);
		}
		public void RemoveToolBar(QToolBar toolbar) {
			interceptor.Invoke("removeToolBar#", "removeToolBar(QToolBar*)", typeof(void), typeof(QToolBar), toolbar);
		}
		public void RemoveToolBarBreak(QToolBar before) {
			interceptor.Invoke("removeToolBarBreak#", "removeToolBarBreak(QToolBar*)", typeof(void), typeof(QToolBar), before);
		}
		public new Qt.ToolBarArea ToolBarArea(QToolBar toolbar) {
			return (Qt.ToolBarArea) interceptor.Invoke("toolBarArea#", "toolBarArea(QToolBar*) const", typeof(Qt.ToolBarArea), typeof(QToolBar), toolbar);
		}
		public bool ToolBarBreak(QToolBar toolbar) {
			return (bool) interceptor.Invoke("toolBarBreak#", "toolBarBreak(QToolBar*) const", typeof(bool), typeof(QToolBar), toolbar);
		}
		public void AddDockWidget(Qt.DockWidgetArea area, QDockWidget dockwidget) {
			interceptor.Invoke("addDockWidget$#", "addDockWidget(Qt::DockWidgetArea, QDockWidget*)", typeof(void), typeof(Qt.DockWidgetArea), area, typeof(QDockWidget), dockwidget);
		}
		public void AddDockWidget(Qt.DockWidgetArea area, QDockWidget dockwidget, Qt.Orientation orientation) {
			interceptor.Invoke("addDockWidget$#$", "addDockWidget(Qt::DockWidgetArea, QDockWidget*, Qt::Orientation)", typeof(void), typeof(Qt.DockWidgetArea), area, typeof(QDockWidget), dockwidget, typeof(Qt.Orientation), orientation);
		}
		public void SplitDockWidget(QDockWidget after, QDockWidget dockwidget, Qt.Orientation orientation) {
			interceptor.Invoke("splitDockWidget##$", "splitDockWidget(QDockWidget*, QDockWidget*, Qt::Orientation)", typeof(void), typeof(QDockWidget), after, typeof(QDockWidget), dockwidget, typeof(Qt.Orientation), orientation);
		}
		public void TabifyDockWidget(QDockWidget first, QDockWidget second) {
			interceptor.Invoke("tabifyDockWidget##", "tabifyDockWidget(QDockWidget*, QDockWidget*)", typeof(void), typeof(QDockWidget), first, typeof(QDockWidget), second);
		}
		public void RemoveDockWidget(QDockWidget dockwidget) {
			interceptor.Invoke("removeDockWidget#", "removeDockWidget(QDockWidget*)", typeof(void), typeof(QDockWidget), dockwidget);
		}
		public new Qt.DockWidgetArea DockWidgetArea(QDockWidget dockwidget) {
			return (Qt.DockWidgetArea) interceptor.Invoke("dockWidgetArea#", "dockWidgetArea(QDockWidget*) const", typeof(Qt.DockWidgetArea), typeof(QDockWidget), dockwidget);
		}
		public QByteArray SaveState(int version) {
			return (QByteArray) interceptor.Invoke("saveState$", "saveState(int) const", typeof(QByteArray), typeof(int), version);
		}
		public QByteArray SaveState() {
			return (QByteArray) interceptor.Invoke("saveState", "saveState() const", typeof(QByteArray));
		}
		public bool RestoreState(QByteArray state, int version) {
			return (bool) interceptor.Invoke("restoreState#$", "restoreState(const QByteArray&, int)", typeof(bool), typeof(QByteArray), state, typeof(int), version);
		}
		public bool RestoreState(QByteArray state) {
			return (bool) interceptor.Invoke("restoreState#", "restoreState(const QByteArray&)", typeof(bool), typeof(QByteArray), state);
		}
		[SmokeMethod("createPopupMenu()")]
		public virtual QMenu CreatePopupMenu() {
			return (QMenu) interceptor.Invoke("createPopupMenu", "createPopupMenu()", typeof(QMenu));
		}
		[Q_SLOT("void setAnimated(bool)")]
		public void SetAnimated(bool enabled) {
			interceptor.Invoke("setAnimated$", "setAnimated(bool)", typeof(void), typeof(bool), enabled);
		}
		[Q_SLOT("void setDockNestingEnabled(bool)")]
		public void SetDockNestingEnabled(bool enabled) {
			interceptor.Invoke("setDockNestingEnabled$", "setDockNestingEnabled(bool)", typeof(void), typeof(bool), enabled);
		}
		[SmokeMethod("contextMenuEvent(QContextMenuEvent*)")]
		protected override void ContextMenuEvent(QContextMenuEvent arg1) {
			interceptor.Invoke("contextMenuEvent#", "contextMenuEvent(QContextMenuEvent*)", typeof(void), typeof(QContextMenuEvent), arg1);
		}
		[SmokeMethod("event(QEvent*)")]
		protected override bool Event(QEvent arg1) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
		}
		~QMainWindow() {
			interceptor.Invoke("~QMainWindow", "~QMainWindow()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QMainWindow", "~QMainWindow()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQMainWindowSignals Emit {
			get { return (IQMainWindowSignals) Q_EMIT; }
		}
	}

	public interface IQMainWindowSignals : IQWidgetSignals {
		[Q_SIGNAL("void iconSizeChanged(const QSize&)")]
		void IconSizeChanged(QSize iconSize);
		[Q_SIGNAL("void toolButtonStyleChanged(Qt::ToolButtonStyle)")]
		void ToolButtonStyleChanged(Qt.ToolButtonStyle toolButtonStyle);
	}
}
