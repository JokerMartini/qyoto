//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQSpinWidgetSignals"></see> for signals emitted by QSpinWidget
	public class QSpinWidget : QWidget, IDisposable {
 		protected QSpinWidget(Type dummy) : base((Type) null) {}
		interface IQSpinWidgetProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQSpinWidgetProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSpinWidget), this);
			_interceptor = (QSpinWidget) realProxy.GetTransparentProxy();
		}
		private QSpinWidget ProxyQSpinWidget() {
			return (QSpinWidget) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSpinWidget() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSpinWidgetProxy), null);
			_staticInterceptor = (IQSpinWidgetProxy) realProxy.GetTransparentProxy();
		}
		private static IQSpinWidgetProxy StaticQSpinWidget() {
			return (IQSpinWidgetProxy) _staticInterceptor;
		}

		enum E_ButtonSymbols {
			UpDownArrows = 0,
			PlusMinus = 1,
		}
		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQSpinWidget().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQSpinWidget().ClassName();
		}
		public QSpinWidget(QWidget parent, string name) : this((Type) null) {
			CreateQSpinWidgetProxy();
			CreateQSpinWidgetSignalProxy();
			NewQSpinWidget(parent,name);
		}
		[SmokeMethod("QSpinWidget(QWidget*, const char*)")]
		private void NewQSpinWidget(QWidget parent, string name) {
			ProxyQSpinWidget().NewQSpinWidget(parent,name);
		}
		public QSpinWidget(QWidget parent) : this((Type) null) {
			CreateQSpinWidgetProxy();
			CreateQSpinWidgetSignalProxy();
			NewQSpinWidget(parent);
		}
		[SmokeMethod("QSpinWidget(QWidget*)")]
		private void NewQSpinWidget(QWidget parent) {
			ProxyQSpinWidget().NewQSpinWidget(parent);
		}
		public QSpinWidget() : this((Type) null) {
			CreateQSpinWidgetProxy();
			CreateQSpinWidgetSignalProxy();
			NewQSpinWidget();
		}
		[SmokeMethod("QSpinWidget()")]
		private void NewQSpinWidget() {
			ProxyQSpinWidget().NewQSpinWidget();
		}
		[SmokeMethod("setEditWidget(QWidget*)")]
		public void SetEditWidget(QWidget widget) {
			ProxyQSpinWidget().SetEditWidget(widget);
		}
		[SmokeMethod("editWidget()")]
		public QWidget EditWidget() {
			return ProxyQSpinWidget().EditWidget();
		}
		[SmokeMethod("upRect() const")]
		public QRect UpRect() {
			return ProxyQSpinWidget().UpRect();
		}
		[SmokeMethod("downRect() const")]
		public QRect DownRect() {
			return ProxyQSpinWidget().DownRect();
		}
		[SmokeMethod("setUpEnabled(bool)")]
		public void SetUpEnabled(bool on) {
			ProxyQSpinWidget().SetUpEnabled(on);
		}
		[SmokeMethod("setDownEnabled(bool)")]
		public void SetDownEnabled(bool on) {
			ProxyQSpinWidget().SetDownEnabled(on);
		}
		[SmokeMethod("isUpEnabled() const")]
		public bool IsUpEnabled() {
			return ProxyQSpinWidget().IsUpEnabled();
		}
		[SmokeMethod("isDownEnabled() const")]
		public bool IsDownEnabled() {
			return ProxyQSpinWidget().IsDownEnabled();
		}
		[SmokeMethod("setButtonSymbols(QSpinWidget::ButtonSymbols)")]
		public virtual void SetButtonSymbols(int bs) {
			ProxyQSpinWidget().SetButtonSymbols(bs);
		}
		[SmokeMethod("buttonSymbols() const")]
		public int ButtonSymbols() {
			return ProxyQSpinWidget().ButtonSymbols();
		}
		[SmokeMethod("arrange()")]
		public void Arrange() {
			ProxyQSpinWidget().Arrange();
		}
		[Q_SLOT("stepUp()")]
		[SmokeMethod("stepUp()")]
		public void StepUp() {
			ProxyQSpinWidget().StepUp();
		}
		[Q_SLOT("stepDown()")]
		[SmokeMethod("stepDown()")]
		public void StepDown() {
			ProxyQSpinWidget().StepDown();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQSpinWidget().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQSpinWidget().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQSpinWidget().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQSpinWidget().TrUtf8(arg1);
		}
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected new void MousePressEvent(QMouseEvent e) {
			ProxyQSpinWidget().MousePressEvent(e);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected new void ResizeEvent(QResizeEvent ev) {
			ProxyQSpinWidget().ResizeEvent(ev);
		}
		[SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
		protected new void MouseReleaseEvent(QMouseEvent e) {
			ProxyQSpinWidget().MouseReleaseEvent(e);
		}
		[SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
		protected new void MouseMoveEvent(QMouseEvent e) {
			ProxyQSpinWidget().MouseMoveEvent(e);
		}
		[SmokeMethod("wheelEvent(QWheelEvent*)")]
		protected new void WheelEvent(QWheelEvent arg1) {
			ProxyQSpinWidget().WheelEvent(arg1);
		}
		[SmokeMethod("styleChange(QStyle&)")]
		public new void StyleChange(QStyle arg1) {
			ProxyQSpinWidget().StyleChange(arg1);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected new void PaintEvent(QPaintEvent arg1) {
			ProxyQSpinWidget().PaintEvent(arg1);
		}
		[SmokeMethod("enableChanged(bool)")]
		protected void EnableChanged(bool old) {
			ProxyQSpinWidget().EnableChanged(old);
		}
		[SmokeMethod("windowActivationChange(bool)")]
		protected new void WindowActivationChange(bool arg1) {
			ProxyQSpinWidget().WindowActivationChange(arg1);
		}
		~QSpinWidget() {
			DisposeQSpinWidget();
		}
		public new void Dispose() {
			DisposeQSpinWidget();
		}
		private void DisposeQSpinWidget() {
			ProxyQSpinWidget().DisposeQSpinWidget();
		}
		protected void CreateQSpinWidgetSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQSpinWidgetSignals), this);
			_signalInterceptor = (IQSpinWidgetSignals) realProxy.GetTransparentProxy();
		}
		protected new IQSpinWidgetSignals Emit() {
			return (IQSpinWidgetSignals) _signalInterceptor;
		}
	}

	public interface IQSpinWidgetSignals : IQWidgetSignals {
		[Q_SIGNAL("stepUpPressed()")]
		void StepUpPressed();
		[Q_SIGNAL("stepDownPressed()")]
		void StepDownPressed();
	}
}
