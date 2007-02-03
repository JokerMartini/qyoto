//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	/// See <see cref="IQMenuBarSignals"></see> for signals emitted by QMenuBar
	[SmokeClass("QMenuBar")]
	public class QMenuBar : QWidget, IDisposable {
 		protected QMenuBar(Type dummy) : base((Type) null) {}
		[SmokeClass("QMenuBar")]
		interface IQMenuBarProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QMenuBar), this);
			_interceptor = (QMenuBar) realProxy.GetTransparentProxy();
		}
		private QMenuBar ProxyQMenuBar() {
			return (QMenuBar) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QMenuBar() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQMenuBarProxy), null);
			_staticInterceptor = (IQMenuBarProxy) realProxy.GetTransparentProxy();
		}
		private static IQMenuBarProxy StaticQMenuBar() {
			return (IQMenuBarProxy) _staticInterceptor;
		}

		[Q_PROPERTY("bool", "defaultUp")]
		public bool DefaultUp {
			get {
				return Property("defaultUp").Value<bool>();
			}
			set {
				SetProperty("defaultUp", QVariant.FromValue<bool>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QMenuBar(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQMenuBar(parent);
		}
		[SmokeMethod("QMenuBar", "(QWidget*)", "#")]
		private void NewQMenuBar(QWidget parent) {
			ProxyQMenuBar().NewQMenuBar(parent);
		}
		public QMenuBar() : this((Type) null) {
			CreateProxy();
			NewQMenuBar();
		}
		[SmokeMethod("QMenuBar", "()", "")]
		private void NewQMenuBar() {
			ProxyQMenuBar().NewQMenuBar();
		}
		[SmokeMethod("addAction", "(QAction*)", "#")]
		public new void AddAction(QAction action) {
			ProxyQMenuBar().AddAction(action);
		}
		[SmokeMethod("addAction", "(const QString&)", "$")]
		public new QAction AddAction(string text) {
			return ProxyQMenuBar().AddAction(text);
		}
		[SmokeMethod("addAction", "(const QString&, const QObject*, const char*)", "$#$")]
		public new QAction AddAction(string text, QObject receiver, string member) {
			return ProxyQMenuBar().AddAction(text,receiver,member);
		}
		[SmokeMethod("addMenu", "(QMenu*)", "#")]
		public QAction AddMenu(QMenu menu) {
			return ProxyQMenuBar().AddMenu(menu);
		}
		[SmokeMethod("addMenu", "(const QString&)", "$")]
		public QMenu AddMenu(string title) {
			return ProxyQMenuBar().AddMenu(title);
		}
		[SmokeMethod("addMenu", "(const QIcon&, const QString&)", "#$")]
		public QMenu AddMenu(QIcon icon, string title) {
			return ProxyQMenuBar().AddMenu(icon,title);
		}
		[SmokeMethod("addSeparator", "()", "")]
		public QAction AddSeparator() {
			return ProxyQMenuBar().AddSeparator();
		}
		[SmokeMethod("insertSeparator", "(QAction*)", "#")]
		public QAction InsertSeparator(QAction before) {
			return ProxyQMenuBar().InsertSeparator(before);
		}
		[SmokeMethod("insertMenu", "(QAction*, QMenu*)", "##")]
		public QAction InsertMenu(QAction before, QMenu menu) {
			return ProxyQMenuBar().InsertMenu(before,menu);
		}
		[SmokeMethod("clear", "()", "")]
		public void Clear() {
			ProxyQMenuBar().Clear();
		}
		[SmokeMethod("activeAction", "() const", "")]
		public QAction ActiveAction() {
			return ProxyQMenuBar().ActiveAction();
		}
		[SmokeMethod("setActiveAction", "(QAction*)", "#")]
		public void SetActiveAction(QAction action) {
			ProxyQMenuBar().SetActiveAction(action);
		}
		[SmokeMethod("isDefaultUp", "() const", "")]
		public bool IsDefaultUp() {
			return ProxyQMenuBar().IsDefaultUp();
		}
		[SmokeMethod("sizeHint", "() const", "")]
		public new QSize SizeHint() {
			return ProxyQMenuBar().SizeHint();
		}
		[SmokeMethod("minimumSizeHint", "() const", "")]
		public new QSize MinimumSizeHint() {
			return ProxyQMenuBar().MinimumSizeHint();
		}
		[SmokeMethod("heightForWidth", "(int) const", "$")]
		public new int HeightForWidth(int arg1) {
			return ProxyQMenuBar().HeightForWidth(arg1);
		}
		[SmokeMethod("actionGeometry", "(QAction*) const", "#")]
		public QRect ActionGeometry(QAction arg1) {
			return ProxyQMenuBar().ActionGeometry(arg1);
		}
		[SmokeMethod("actionAt", "(const QPoint&) const", "#")]
		public QAction ActionAt(QPoint arg1) {
			return ProxyQMenuBar().ActionAt(arg1);
		}
		[SmokeMethod("setCornerWidget", "(QWidget*, Qt::Corner)", "#$")]
		public void SetCornerWidget(QWidget w, Qt.Corner corner) {
			ProxyQMenuBar().SetCornerWidget(w,corner);
		}
		[SmokeMethod("setCornerWidget", "(QWidget*)", "#")]
		public void SetCornerWidget(QWidget w) {
			ProxyQMenuBar().SetCornerWidget(w);
		}
		[SmokeMethod("cornerWidget", "(Qt::Corner) const", "$")]
		public QWidget CornerWidget(Qt.Corner corner) {
			return ProxyQMenuBar().CornerWidget(corner);
		}
		[SmokeMethod("cornerWidget", "() const", "")]
		public QWidget CornerWidget() {
			return ProxyQMenuBar().CornerWidget();
		}
		public static new string Tr(string s, string c) {
			return StaticQMenuBar().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQMenuBar().Tr(s);
		}
		[SmokeMethod("changeEvent", "(QEvent*)", "#")]
		protected new void ChangeEvent(QEvent arg1) {
			ProxyQMenuBar().ChangeEvent(arg1);
		}
		[SmokeMethod("keyPressEvent", "(QKeyEvent*)", "#")]
		protected new void KeyPressEvent(QKeyEvent arg1) {
			ProxyQMenuBar().KeyPressEvent(arg1);
		}
		[SmokeMethod("mouseReleaseEvent", "(QMouseEvent*)", "#")]
		protected new void MouseReleaseEvent(QMouseEvent arg1) {
			ProxyQMenuBar().MouseReleaseEvent(arg1);
		}
		[SmokeMethod("mousePressEvent", "(QMouseEvent*)", "#")]
		protected new void MousePressEvent(QMouseEvent arg1) {
			ProxyQMenuBar().MousePressEvent(arg1);
		}
		[SmokeMethod("mouseMoveEvent", "(QMouseEvent*)", "#")]
		protected new void MouseMoveEvent(QMouseEvent arg1) {
			ProxyQMenuBar().MouseMoveEvent(arg1);
		}
		[SmokeMethod("leaveEvent", "(QEvent*)", "#")]
		protected new void LeaveEvent(QEvent arg1) {
			ProxyQMenuBar().LeaveEvent(arg1);
		}
		[SmokeMethod("paintEvent", "(QPaintEvent*)", "#")]
		protected new void PaintEvent(QPaintEvent arg1) {
			ProxyQMenuBar().PaintEvent(arg1);
		}
		[SmokeMethod("resizeEvent", "(QResizeEvent*)", "#")]
		protected new void ResizeEvent(QResizeEvent arg1) {
			ProxyQMenuBar().ResizeEvent(arg1);
		}
		[SmokeMethod("actionEvent", "(QActionEvent*)", "#")]
		protected new void ActionEvent(QActionEvent arg1) {
			ProxyQMenuBar().ActionEvent(arg1);
		}
		[SmokeMethod("focusOutEvent", "(QFocusEvent*)", "#")]
		protected new void FocusOutEvent(QFocusEvent arg1) {
			ProxyQMenuBar().FocusOutEvent(arg1);
		}
		[SmokeMethod("focusInEvent", "(QFocusEvent*)", "#")]
		protected new void FocusInEvent(QFocusEvent arg1) {
			ProxyQMenuBar().FocusInEvent(arg1);
		}
		[SmokeMethod("eventFilter", "(QObject*, QEvent*)", "##")]
		public new bool EventFilter(QObject arg1, QEvent arg2) {
			return ProxyQMenuBar().EventFilter(arg1,arg2);
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		public new bool Event(QEvent arg1) {
			return ProxyQMenuBar().Event(arg1);
		}
		~QMenuBar() {
			DisposeQMenuBar();
		}
		public new void Dispose() {
			DisposeQMenuBar();
		}
		[SmokeMethod("~QMenuBar", "()", "")]
		private void DisposeQMenuBar() {
			ProxyQMenuBar().DisposeQMenuBar();
		}
		protected new IQMenuBarSignals Emit {
			get {
				return (IQMenuBarSignals) Q_EMIT;
			}
		}
	}

	public interface IQMenuBarSignals : IQWidgetSignals {
		[Q_SIGNAL("void triggered(QAction*)")]
		void Triggered(QAction action);
		[Q_SIGNAL("void hovered(QAction*)")]
		void Hovered(QAction action);
	}
}
