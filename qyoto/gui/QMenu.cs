//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	///<remarks> See <see cref="IQMenuSignals"></see> for signals emitted by QMenu
	///</remarks>

	[SmokeClass("QMenu")]
	public class QMenu : QWidget, IDisposable {
 		protected QMenu(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QMenu), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QMenu() {
			staticInterceptor = new SmokeInvocation(typeof(QMenu), null);
		}
		[Q_PROPERTY("bool", "tearOffEnabled")]
		public bool TearOffEnabled {
			get { return (bool) interceptor.Invoke("isTearOffEnabled", "isTearOffEnabled()", typeof(bool)); }
			set { interceptor.Invoke("setTearOffEnabled$", "setTearOffEnabled(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("QString", "title")]
		public string Title {
			get { return (string) interceptor.Invoke("title", "title()", typeof(string)); }
			set { interceptor.Invoke("setTitle$", "setTitle(QString)", typeof(void), typeof(string), value); }
		}
		[Q_PROPERTY("QIcon", "icon")]
		public QIcon icon {
			get { return (QIcon) interceptor.Invoke("icon", "icon()", typeof(QIcon)); }
			set { interceptor.Invoke("setIcon#", "setIcon(QIcon)", typeof(void), typeof(QIcon), value); }
		}
		[Q_PROPERTY("bool", "separatorsCollapsible")]
		public bool SeparatorsCollapsible {
			get { return (bool) interceptor.Invoke("separatorsCollapsible", "separatorsCollapsible()", typeof(bool)); }
			set { interceptor.Invoke("setSeparatorsCollapsible$", "setSeparatorsCollapsible(bool)", typeof(void), typeof(bool), value); }
		}
		public QMenu(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QMenu#", "QMenu(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public QMenu() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QMenu", "QMenu()", typeof(void));
		}
		public QMenu(string title, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QMenu$#", "QMenu(const QString&, QWidget*)", typeof(void), typeof(string), title, typeof(QWidget), parent);
		}
		public QMenu(string title) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QMenu$", "QMenu(const QString&)", typeof(void), typeof(string), title);
		}
		public new void AddAction(QAction action) {
			interceptor.Invoke("addAction#", "addAction(QAction*)", typeof(void), typeof(QAction), action);
		}
		public QAction AddAction(string text) {
			return (QAction) interceptor.Invoke("addAction$", "addAction(const QString&)", typeof(QAction), typeof(string), text);
		}
		public QAction AddAction(QIcon icon, string text) {
			return (QAction) interceptor.Invoke("addAction#$", "addAction(const QIcon&, const QString&)", typeof(QAction), typeof(QIcon), icon, typeof(string), text);
		}
		public QAction AddAction(string text, QObject receiver, string member, QKeySequence shortcut) {
			return (QAction) interceptor.Invoke("addAction$#$#", "addAction(const QString&, const QObject*, const char*, const QKeySequence&)", typeof(QAction), typeof(string), text, typeof(QObject), receiver, typeof(string), member, typeof(QKeySequence), shortcut);
		}
		public QAction AddAction(string text, QObject receiver, string member) {
			return (QAction) interceptor.Invoke("addAction$#$", "addAction(const QString&, const QObject*, const char*)", typeof(QAction), typeof(string), text, typeof(QObject), receiver, typeof(string), member);
		}
		public QAction AddAction(QIcon icon, string text, QObject receiver, string member, QKeySequence shortcut) {
			return (QAction) interceptor.Invoke("addAction#$#$#", "addAction(const QIcon&, const QString&, const QObject*, const char*, const QKeySequence&)", typeof(QAction), typeof(QIcon), icon, typeof(string), text, typeof(QObject), receiver, typeof(string), member, typeof(QKeySequence), shortcut);
		}
		public QAction AddAction(QIcon icon, string text, QObject receiver, string member) {
			return (QAction) interceptor.Invoke("addAction#$#$", "addAction(const QIcon&, const QString&, const QObject*, const char*)", typeof(QAction), typeof(QIcon), icon, typeof(string), text, typeof(QObject), receiver, typeof(string), member);
		}
		public QAction AddMenu(QMenu menu) {
			return (QAction) interceptor.Invoke("addMenu#", "addMenu(QMenu*)", typeof(QAction), typeof(QMenu), menu);
		}
		public QMenu AddMenu(string title) {
			return (QMenu) interceptor.Invoke("addMenu$", "addMenu(const QString&)", typeof(QMenu), typeof(string), title);
		}
		public QMenu AddMenu(QIcon icon, string title) {
			return (QMenu) interceptor.Invoke("addMenu#$", "addMenu(const QIcon&, const QString&)", typeof(QMenu), typeof(QIcon), icon, typeof(string), title);
		}
		public QAction AddSeparator() {
			return (QAction) interceptor.Invoke("addSeparator", "addSeparator()", typeof(QAction));
		}
		public QAction InsertMenu(QAction before, QMenu menu) {
			return (QAction) interceptor.Invoke("insertMenu##", "insertMenu(QAction*, QMenu*)", typeof(QAction), typeof(QAction), before, typeof(QMenu), menu);
		}
		public QAction InsertSeparator(QAction before) {
			return (QAction) interceptor.Invoke("insertSeparator#", "insertSeparator(QAction*)", typeof(QAction), typeof(QAction), before);
		}
		public bool IsEmpty() {
			return (bool) interceptor.Invoke("isEmpty", "isEmpty() const", typeof(bool));
		}
		public void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		public bool IsTearOffMenuVisible() {
			return (bool) interceptor.Invoke("isTearOffMenuVisible", "isTearOffMenuVisible() const", typeof(bool));
		}
		public void HideTearOffMenu() {
			interceptor.Invoke("hideTearOffMenu", "hideTearOffMenu()", typeof(void));
		}
		public void SetDefaultAction(QAction arg1) {
			interceptor.Invoke("setDefaultAction#", "setDefaultAction(QAction*)", typeof(void), typeof(QAction), arg1);
		}
		public QAction DefaultAction() {
			return (QAction) interceptor.Invoke("defaultAction", "defaultAction() const", typeof(QAction));
		}
		public void SetActiveAction(QAction act) {
			interceptor.Invoke("setActiveAction#", "setActiveAction(QAction*)", typeof(void), typeof(QAction), act);
		}
		public QAction ActiveAction() {
			return (QAction) interceptor.Invoke("activeAction", "activeAction() const", typeof(QAction));
		}
		public void Popup(QPoint pos, QAction at) {
			interceptor.Invoke("popup##", "popup(const QPoint&, QAction*)", typeof(void), typeof(QPoint), pos, typeof(QAction), at);
		}
		public void Popup(QPoint pos) {
			interceptor.Invoke("popup#", "popup(const QPoint&)", typeof(void), typeof(QPoint), pos);
		}
		public QAction Exec() {
			return (QAction) interceptor.Invoke("exec", "exec()", typeof(QAction));
		}
		public QAction Exec(QPoint pos, QAction at) {
			return (QAction) interceptor.Invoke("exec##", "exec(const QPoint&, QAction*)", typeof(QAction), typeof(QPoint), pos, typeof(QAction), at);
		}
		public QAction Exec(QPoint pos) {
			return (QAction) interceptor.Invoke("exec#", "exec(const QPoint&)", typeof(QAction), typeof(QPoint), pos);
		}
		[SmokeMethod("sizeHint() const")]
		public override QSize SizeHint() {
			return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
		}
		public QRect ActionGeometry(QAction arg1) {
			return (QRect) interceptor.Invoke("actionGeometry#", "actionGeometry(QAction*) const", typeof(QRect), typeof(QAction), arg1);
		}
		public QAction ActionAt(QPoint arg1) {
			return (QAction) interceptor.Invoke("actionAt#", "actionAt(const QPoint&) const", typeof(QAction), typeof(QPoint), arg1);
		}
		public QAction MenuAction() {
			return (QAction) interceptor.Invoke("menuAction", "menuAction() const", typeof(QAction));
		}
		public void SetNoReplayFor(QWidget widget) {
			interceptor.Invoke("setNoReplayFor#", "setNoReplayFor(QWidget*)", typeof(void), typeof(QWidget), widget);
		}
		protected int ColumnCount() {
			return (int) interceptor.Invoke("columnCount", "columnCount() const", typeof(int));
		}
		[SmokeMethod("changeEvent(QEvent*)")]
		protected override void ChangeEvent(QEvent arg1) {
			interceptor.Invoke("changeEvent#", "changeEvent(QEvent*)", typeof(void), typeof(QEvent), arg1);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected override void KeyPressEvent(QKeyEvent arg1) {
			interceptor.Invoke("keyPressEvent#", "keyPressEvent(QKeyEvent*)", typeof(void), typeof(QKeyEvent), arg1);
		}
		[SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
		protected override void MouseReleaseEvent(QMouseEvent arg1) {
			interceptor.Invoke("mouseReleaseEvent#", "mouseReleaseEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
		}
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected override void MousePressEvent(QMouseEvent arg1) {
			interceptor.Invoke("mousePressEvent#", "mousePressEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
		}
		[SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
		protected override void MouseMoveEvent(QMouseEvent arg1) {
			interceptor.Invoke("mouseMoveEvent#", "mouseMoveEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
		}
		[SmokeMethod("wheelEvent(QWheelEvent*)")]
		protected override void WheelEvent(QWheelEvent arg1) {
			interceptor.Invoke("wheelEvent#", "wheelEvent(QWheelEvent*)", typeof(void), typeof(QWheelEvent), arg1);
		}
		[SmokeMethod("enterEvent(QEvent*)")]
		protected override void EnterEvent(QEvent arg1) {
			interceptor.Invoke("enterEvent#", "enterEvent(QEvent*)", typeof(void), typeof(QEvent), arg1);
		}
		[SmokeMethod("leaveEvent(QEvent*)")]
		protected override void LeaveEvent(QEvent arg1) {
			interceptor.Invoke("leaveEvent#", "leaveEvent(QEvent*)", typeof(void), typeof(QEvent), arg1);
		}
		[SmokeMethod("hideEvent(QHideEvent*)")]
		protected override void HideEvent(QHideEvent arg1) {
			interceptor.Invoke("hideEvent#", "hideEvent(QHideEvent*)", typeof(void), typeof(QHideEvent), arg1);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected override void PaintEvent(QPaintEvent arg1) {
			interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), arg1);
		}
		[SmokeMethod("actionEvent(QActionEvent*)")]
		protected override void ActionEvent(QActionEvent arg1) {
			interceptor.Invoke("actionEvent#", "actionEvent(QActionEvent*)", typeof(void), typeof(QActionEvent), arg1);
		}
		[SmokeMethod("timerEvent(QTimerEvent*)")]
		protected override void TimerEvent(QTimerEvent arg1) {
			interceptor.Invoke("timerEvent#", "timerEvent(QTimerEvent*)", typeof(void), typeof(QTimerEvent), arg1);
		}
		[SmokeMethod("event(QEvent*)")]
		protected override bool Event(QEvent arg1) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
		}
		[SmokeMethod("focusNextPrevChild(bool)")]
		protected override bool FocusNextPrevChild(bool next) {
			return (bool) interceptor.Invoke("focusNextPrevChild$", "focusNextPrevChild(bool)", typeof(bool), typeof(bool), next);
		}
		protected void InitStyleOption(QStyleOptionMenuItem option, QAction action) {
			interceptor.Invoke("initStyleOption##", "initStyleOption(QStyleOptionMenuItem*, const QAction*) const", typeof(void), typeof(QStyleOptionMenuItem), option, typeof(QAction), action);
		}
		~QMenu() {
			interceptor.Invoke("~QMenu", "~QMenu()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QMenu", "~QMenu()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		public static QAction Exec(List<QAction> actions, QPoint pos, QAction at) {
			return (QAction) staticInterceptor.Invoke("exec?##", "exec(QList<QAction*>, const QPoint&, QAction*)", typeof(QAction), typeof(List<QAction>), actions, typeof(QPoint), pos, typeof(QAction), at);
		}
		public static QAction Exec(List<QAction> actions, QPoint pos) {
			return (QAction) staticInterceptor.Invoke("exec?#", "exec(QList<QAction*>, const QPoint&)", typeof(QAction), typeof(List<QAction>), actions, typeof(QPoint), pos);
		}
		protected new IQMenuSignals Emit {
			get { return (IQMenuSignals) Q_EMIT; }
		}
	}

	public interface IQMenuSignals : IQWidgetSignals {
		[Q_SIGNAL("void aboutToShow()")]
		void AboutToShow();
		[Q_SIGNAL("void aboutToHide()")]
		void AboutToHide();
		[Q_SIGNAL("void triggered(QAction*)")]
		void Triggered(QAction action);
		[Q_SIGNAL("void hovered(QAction*)")]
		void Hovered(QAction action);
	}
}
