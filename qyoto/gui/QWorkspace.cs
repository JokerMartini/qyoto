//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	/// See <see cref="IQWorkspaceSignals"></see> for signals emitted by QWorkspace
	[SmokeClass("QWorkspace")]
	public class QWorkspace : QWidget, IDisposable {
 		protected QWorkspace(Type dummy) : base((Type) null) {}
		[SmokeClass("QWorkspace")]
		interface IQWorkspaceProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QWorkspace), this);
			_interceptor = (QWorkspace) realProxy.GetTransparentProxy();
		}
		private QWorkspace ProxyQWorkspace() {
			return (QWorkspace) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QWorkspace() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQWorkspaceProxy), null);
			_staticInterceptor = (IQWorkspaceProxy) realProxy.GetTransparentProxy();
		}
		private static IQWorkspaceProxy StaticQWorkspace() {
			return (IQWorkspaceProxy) _staticInterceptor;
		}

		public enum WindowOrder {
			CreationOrder = 0,
			StackingOrder = 1,
		}
		[Q_PROPERTY("bool", "scrollBarsEnabled")]
		public bool ScrollBarsEnabled {
			get {
				return Property("scrollBarsEnabled").Value<bool>();
			}
			set {
				SetProperty("scrollBarsEnabled", QVariant.FromValue<bool>(value));
			}
		}
		[Q_PROPERTY("QBrush", "background")]
		public QBrush Background {
			get {
				return Property("background").Value<QBrush>();
			}
			set {
				SetProperty("background", QVariant.FromValue<QBrush>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QWorkspace(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQWorkspace(parent);
		}
		[SmokeMethod("QWorkspace", "(QWidget*)", "#")]
		private void NewQWorkspace(QWidget parent) {
			ProxyQWorkspace().NewQWorkspace(parent);
		}
		public QWorkspace() : this((Type) null) {
			CreateProxy();
			NewQWorkspace();
		}
		[SmokeMethod("QWorkspace", "()", "")]
		private void NewQWorkspace() {
			ProxyQWorkspace().NewQWorkspace();
		}
		[SmokeMethod("activeWindow", "() const", "")]
		public QWidget ActiveWindow() {
			return ProxyQWorkspace().ActiveWindow();
		}
		[SmokeMethod("windowList", "(QWorkspace::WindowOrder) const", "$")]
		public List<QWidget> WindowList(QWorkspace.WindowOrder order) {
			return ProxyQWorkspace().WindowList(order);
		}
		[SmokeMethod("windowList", "() const", "")]
		public List<QWidget> WindowList() {
			return ProxyQWorkspace().WindowList();
		}
		[SmokeMethod("addWindow", "(QWidget*, Qt::WindowFlags)", "#$")]
		public QWidget AddWindow(QWidget w, int flags) {
			return ProxyQWorkspace().AddWindow(w,flags);
		}
		[SmokeMethod("addWindow", "(QWidget*)", "#")]
		public QWidget AddWindow(QWidget w) {
			return ProxyQWorkspace().AddWindow(w);
		}
		[SmokeMethod("sizeHint", "() const", "")]
		public new QSize SizeHint() {
			return ProxyQWorkspace().SizeHint();
		}
		[Q_SLOT("void setActiveWindow(QWidget*)")]
		[SmokeMethod("setActiveWindow", "(QWidget*)", "#")]
		public void SetActiveWindow(QWidget w) {
			ProxyQWorkspace().SetActiveWindow(w);
		}
		[Q_SLOT("void cascade()")]
		[SmokeMethod("cascade", "()", "")]
		public void Cascade() {
			ProxyQWorkspace().Cascade();
		}
		[Q_SLOT("void tile()")]
		[SmokeMethod("tile", "()", "")]
		public void Tile() {
			ProxyQWorkspace().Tile();
		}
		[Q_SLOT("void arrangeIcons()")]
		[SmokeMethod("arrangeIcons", "()", "")]
		public void ArrangeIcons() {
			ProxyQWorkspace().ArrangeIcons();
		}
		[Q_SLOT("void closeActiveWindow()")]
		[SmokeMethod("closeActiveWindow", "()", "")]
		public void CloseActiveWindow() {
			ProxyQWorkspace().CloseActiveWindow();
		}
		[Q_SLOT("void closeAllWindows()")]
		[SmokeMethod("closeAllWindows", "()", "")]
		public void CloseAllWindows() {
			ProxyQWorkspace().CloseAllWindows();
		}
		[Q_SLOT("void activateNextWindow()")]
		[SmokeMethod("activateNextWindow", "()", "")]
		public void ActivateNextWindow() {
			ProxyQWorkspace().ActivateNextWindow();
		}
		[Q_SLOT("void activatePreviousWindow()")]
		[SmokeMethod("activatePreviousWindow", "()", "")]
		public void ActivatePreviousWindow() {
			ProxyQWorkspace().ActivatePreviousWindow();
		}
		public static new string Tr(string s, string c) {
			return StaticQWorkspace().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQWorkspace().Tr(s);
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		public new bool Event(QEvent e) {
			return ProxyQWorkspace().Event(e);
		}
		[SmokeMethod("paintEvent", "(QPaintEvent*)", "#")]
		protected new void PaintEvent(QPaintEvent e) {
			ProxyQWorkspace().PaintEvent(e);
		}
		[SmokeMethod("changeEvent", "(QEvent*)", "#")]
		protected new void ChangeEvent(QEvent arg1) {
			ProxyQWorkspace().ChangeEvent(arg1);
		}
		[SmokeMethod("childEvent", "(QChildEvent*)", "#")]
		protected new void ChildEvent(QChildEvent arg1) {
			ProxyQWorkspace().ChildEvent(arg1);
		}
		[SmokeMethod("resizeEvent", "(QResizeEvent*)", "#")]
		protected new void ResizeEvent(QResizeEvent arg1) {
			ProxyQWorkspace().ResizeEvent(arg1);
		}
		[SmokeMethod("eventFilter", "(QObject*, QEvent*)", "##")]
		public new bool EventFilter(QObject arg1, QEvent arg2) {
			return ProxyQWorkspace().EventFilter(arg1,arg2);
		}
		[SmokeMethod("showEvent", "(QShowEvent*)", "#")]
		public new void ShowEvent(QShowEvent e) {
			ProxyQWorkspace().ShowEvent(e);
		}
		[SmokeMethod("hideEvent", "(QHideEvent*)", "#")]
		protected new void HideEvent(QHideEvent e) {
			ProxyQWorkspace().HideEvent(e);
		}
		[SmokeMethod("wheelEvent", "(QWheelEvent*)", "#")]
		protected new void WheelEvent(QWheelEvent e) {
			ProxyQWorkspace().WheelEvent(e);
		}
		~QWorkspace() {
			DisposeQWorkspace();
		}
		public new void Dispose() {
			DisposeQWorkspace();
		}
		[SmokeMethod("~QWorkspace", "()", "")]
		private void DisposeQWorkspace() {
			ProxyQWorkspace().DisposeQWorkspace();
		}
		protected new IQWorkspaceSignals Emit {
			get {
				return (IQWorkspaceSignals) Q_EMIT;
			}
		}
	}

	public interface IQWorkspaceSignals : IQWidgetSignals {
		[Q_SIGNAL("void windowActivated(QWidget*)")]
		void WindowActivated(QWidget w);
	}
}
