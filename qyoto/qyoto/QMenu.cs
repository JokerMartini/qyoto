//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQMenuSignals"></see> for signals emitted by QMenu
	[SmokeClass("QMenu")]
	public class QMenu : QWidget, IDisposable {
 		protected QMenu(Type dummy) : base((Type) null) {}
		interface IQMenuProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QMenu), this);
			_interceptor = (QMenu) realProxy.GetTransparentProxy();
		}
		private QMenu ProxyQMenu() {
			return (QMenu) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QMenu() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQMenuProxy), null);
			_staticInterceptor = (IQMenuProxy) realProxy.GetTransparentProxy();
		}
		private static IQMenuProxy StaticQMenu() {
			return (IQMenuProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQMenu().MetaObject();
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QMenu(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQMenu(parent);
		}
		[SmokeMethod("QMenu(QWidget*)")]
		private void NewQMenu(QWidget parent) {
			ProxyQMenu().NewQMenu(parent);
		}
		public QMenu() : this((Type) null) {
			CreateProxy();
			NewQMenu();
		}
		[SmokeMethod("QMenu()")]
		private void NewQMenu() {
			ProxyQMenu().NewQMenu();
		}
		public QMenu(string title, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQMenu(title,parent);
		}
		[SmokeMethod("QMenu(const QString&, QWidget*)")]
		private void NewQMenu(string title, QWidget parent) {
			ProxyQMenu().NewQMenu(title,parent);
		}
		public QMenu(string title) : this((Type) null) {
			CreateProxy();
			NewQMenu(title);
		}
		[SmokeMethod("QMenu(const QString&)")]
		private void NewQMenu(string title) {
			ProxyQMenu().NewQMenu(title);
		}
		[SmokeMethod("addAction(QAction*)")]
		public new void AddAction(QAction action) {
			ProxyQMenu().AddAction(action);
		}
		[SmokeMethod("addAction(const QString&)")]
		public new QAction AddAction(string text) {
			return ProxyQMenu().AddAction(text);
		}
		[SmokeMethod("addAction(const QIcon&, const QString&)")]
		public new QAction AddAction(QIcon icon, string text) {
			return ProxyQMenu().AddAction(icon,text);
		}
		[SmokeMethod("addAction(const QString&, const QObject*, const char*, const QKeySequence&)")]
		public new QAction AddAction(string text, QObject receiver, string member, QKeySequence shortcut) {
			return ProxyQMenu().AddAction(text,receiver,member,shortcut);
		}
		[SmokeMethod("addAction(const QString&, const QObject*, const char*)")]
		public new QAction AddAction(string text, QObject receiver, string member) {
			return ProxyQMenu().AddAction(text,receiver,member);
		}
		[SmokeMethod("addAction(const QIcon&, const QString&, const QObject*, const char*, const QKeySequence&)")]
		public new QAction AddAction(QIcon icon, string text, QObject receiver, string member, QKeySequence shortcut) {
			return ProxyQMenu().AddAction(icon,text,receiver,member,shortcut);
		}
		[SmokeMethod("addAction(const QIcon&, const QString&, const QObject*, const char*)")]
		public new QAction AddAction(QIcon icon, string text, QObject receiver, string member) {
			return ProxyQMenu().AddAction(icon,text,receiver,member);
		}
		[SmokeMethod("addMenu(QMenu*)")]
		public QAction AddMenu(QMenu menu) {
			return ProxyQMenu().AddMenu(menu);
		}
		[SmokeMethod("addMenu(const QString&)")]
		public QMenu AddMenu(string title) {
			return ProxyQMenu().AddMenu(title);
		}
		[SmokeMethod("addMenu(const QIcon&, const QString&)")]
		public QMenu AddMenu(QIcon icon, string title) {
			return ProxyQMenu().AddMenu(icon,title);
		}
		[SmokeMethod("addSeparator()")]
		public QAction AddSeparator() {
			return ProxyQMenu().AddSeparator();
		}
		[SmokeMethod("insertMenu(QAction*, QMenu*)")]
		public QAction InsertMenu(QAction before, QMenu menu) {
			return ProxyQMenu().InsertMenu(before,menu);
		}
		[SmokeMethod("insertSeparator(QAction*)")]
		public QAction InsertSeparator(QAction before) {
			return ProxyQMenu().InsertSeparator(before);
		}
		[SmokeMethod("clear()")]
		public void Clear() {
			ProxyQMenu().Clear();
		}
		[SmokeMethod("setTearOffEnabled(bool)")]
		public void SetTearOffEnabled(bool arg1) {
			ProxyQMenu().SetTearOffEnabled(arg1);
		}
		[SmokeMethod("isTearOffEnabled() const")]
		public bool IsTearOffEnabled() {
			return ProxyQMenu().IsTearOffEnabled();
		}
		[SmokeMethod("isTearOffMenuVisible() const")]
		public bool IsTearOffMenuVisible() {
			return ProxyQMenu().IsTearOffMenuVisible();
		}
		[SmokeMethod("hideTearOffMenu()")]
		public void HideTearOffMenu() {
			ProxyQMenu().HideTearOffMenu();
		}
		[SmokeMethod("setDefaultAction(QAction*)")]
		public void SetDefaultAction(QAction arg1) {
			ProxyQMenu().SetDefaultAction(arg1);
		}
		[SmokeMethod("defaultAction() const")]
		public QAction DefaultAction() {
			return ProxyQMenu().DefaultAction();
		}
		[SmokeMethod("setActiveAction(QAction*)")]
		public void SetActiveAction(QAction act) {
			ProxyQMenu().SetActiveAction(act);
		}
		[SmokeMethod("activeAction() const")]
		public QAction ActiveAction() {
			return ProxyQMenu().ActiveAction();
		}
		[SmokeMethod("popup(const QPoint&, QAction*)")]
		public void Popup(QPoint pos, QAction at) {
			ProxyQMenu().Popup(pos,at);
		}
		[SmokeMethod("popup(const QPoint&)")]
		public void Popup(QPoint pos) {
			ProxyQMenu().Popup(pos);
		}
		[SmokeMethod("exec()")]
		public QAction Exec() {
			return ProxyQMenu().Exec();
		}
		[SmokeMethod("exec(const QPoint&, QAction*)")]
		public QAction Exec(QPoint pos, QAction at) {
			return ProxyQMenu().Exec(pos,at);
		}
		[SmokeMethod("exec(const QPoint&)")]
		public QAction Exec(QPoint pos) {
			return ProxyQMenu().Exec(pos);
		}
		[SmokeMethod("sizeHint() const")]
		public new QSize SizeHint() {
			return ProxyQMenu().SizeHint();
		}
		[SmokeMethod("actionGeometry(QAction*) const")]
		public QRect ActionGeometry(QAction arg1) {
			return ProxyQMenu().ActionGeometry(arg1);
		}
		[SmokeMethod("actionAt(const QPoint&) const")]
		public QAction ActionAt(QPoint arg1) {
			return ProxyQMenu().ActionAt(arg1);
		}
		[SmokeMethod("menuAction() const")]
		public QAction MenuAction() {
			return ProxyQMenu().MenuAction();
		}
		[SmokeMethod("title() const")]
		public string Title() {
			return ProxyQMenu().Title();
		}
		[SmokeMethod("setTitle(const QString&)")]
		public void SetTitle(string title) {
			ProxyQMenu().SetTitle(title);
		}
		[SmokeMethod("icon() const")]
		public QIcon Icon() {
			return ProxyQMenu().Icon();
		}
		[SmokeMethod("setIcon(const QIcon&)")]
		public void SetIcon(QIcon icon) {
			ProxyQMenu().SetIcon(icon);
		}
		[SmokeMethod("setNoReplayFor(QWidget*)")]
		public void SetNoReplayFor(QWidget widget) {
			ProxyQMenu().SetNoReplayFor(widget);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQMenu().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQMenu().Tr(s);
		}
		// QAction* exec(QList<QAction*> arg1,const QPoint& arg2,QAction* arg3); >>>> NOT CONVERTED
		// QAction* exec(QList<QAction*> arg1,const QPoint& arg2); >>>> NOT CONVERTED
		[SmokeMethod("columnCount() const")]
		protected int ColumnCount() {
			return ProxyQMenu().ColumnCount();
		}
		[SmokeMethod("changeEvent(QEvent*)")]
		protected new void ChangeEvent(QEvent arg1) {
			ProxyQMenu().ChangeEvent(arg1);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected new void KeyPressEvent(QKeyEvent arg1) {
			ProxyQMenu().KeyPressEvent(arg1);
		}
		[SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
		protected new void MouseReleaseEvent(QMouseEvent arg1) {
			ProxyQMenu().MouseReleaseEvent(arg1);
		}
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected new void MousePressEvent(QMouseEvent arg1) {
			ProxyQMenu().MousePressEvent(arg1);
		}
		[SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
		protected new void MouseMoveEvent(QMouseEvent arg1) {
			ProxyQMenu().MouseMoveEvent(arg1);
		}
		[SmokeMethod("wheelEvent(QWheelEvent*)")]
		protected new void WheelEvent(QWheelEvent arg1) {
			ProxyQMenu().WheelEvent(arg1);
		}
		[SmokeMethod("enterEvent(QEvent*)")]
		protected new void EnterEvent(QEvent arg1) {
			ProxyQMenu().EnterEvent(arg1);
		}
		[SmokeMethod("leaveEvent(QEvent*)")]
		protected new void LeaveEvent(QEvent arg1) {
			ProxyQMenu().LeaveEvent(arg1);
		}
		[SmokeMethod("hideEvent(QHideEvent*)")]
		protected new void HideEvent(QHideEvent arg1) {
			ProxyQMenu().HideEvent(arg1);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected new void PaintEvent(QPaintEvent arg1) {
			ProxyQMenu().PaintEvent(arg1);
		}
		[SmokeMethod("actionEvent(QActionEvent*)")]
		protected new void ActionEvent(QActionEvent arg1) {
			ProxyQMenu().ActionEvent(arg1);
		}
		[SmokeMethod("timerEvent(QTimerEvent*)")]
		protected new void TimerEvent(QTimerEvent arg1) {
			ProxyQMenu().TimerEvent(arg1);
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent arg1) {
			return ProxyQMenu().Event(arg1);
		}
		~QMenu() {
			DisposeQMenu();
		}
		public new void Dispose() {
			DisposeQMenu();
		}
		private void DisposeQMenu() {
			ProxyQMenu().DisposeQMenu();
		}
		protected new IQMenuSignals Emit() {
			return (IQMenuSignals) Q_EMIT;
		}
	}

	public interface IQMenuSignals : IQWidgetSignals {
		[Q_SIGNAL("void aboutToShow()")]
		void AboutToShow();
		[Q_SIGNAL("void triggered(QAction*)")]
		void Triggered(QAction action);
		[Q_SIGNAL("void hovered(QAction*)")]
		void Hovered(QAction action);
	}
}
