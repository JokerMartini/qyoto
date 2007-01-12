//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QDial")]
	public class QDial : QAbstractSlider, IDisposable {
 		protected QDial(Type dummy) : base((Type) null) {}
		interface IQDialProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDial), this);
			_interceptor = (QDial) realProxy.GetTransparentProxy();
		}
		private QDial ProxyQDial() {
			return (QDial) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDial() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDialProxy), null);
			_staticInterceptor = (IQDialProxy) realProxy.GetTransparentProxy();
		}
		private static IQDialProxy StaticQDial() {
			return (IQDialProxy) _staticInterceptor;
		}

		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QDial(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQDial(parent);
		}
		[SmokeMethod("QDial(QWidget*)")]
		private void NewQDial(QWidget parent) {
			ProxyQDial().NewQDial(parent);
		}
		public QDial() : this((Type) null) {
			CreateProxy();
			NewQDial();
		}
		[SmokeMethod("QDial()")]
		private void NewQDial() {
			ProxyQDial().NewQDial();
		}
		[SmokeMethod("wrapping() const")]
		public bool Wrapping() {
			return ProxyQDial().Wrapping();
		}
		[SmokeMethod("notchSize() const")]
		public int NotchSize() {
			return ProxyQDial().NotchSize();
		}
		[SmokeMethod("setNotchTarget(double)")]
		public void SetNotchTarget(double target) {
			ProxyQDial().SetNotchTarget(target);
		}
		[SmokeMethod("notchTarget() const")]
		public double NotchTarget() {
			return ProxyQDial().NotchTarget();
		}
		[SmokeMethod("notchesVisible() const")]
		public bool NotchesVisible() {
			return ProxyQDial().NotchesVisible();
		}
		[SmokeMethod("sizeHint() const")]
		public new QSize SizeHint() {
			return ProxyQDial().SizeHint();
		}
		[SmokeMethod("minimumSizeHint() const")]
		public new QSize MinimumSizeHint() {
			return ProxyQDial().MinimumSizeHint();
		}
		[SmokeMethod("setNotchesVisible(bool)")]
		public void SetNotchesVisible(bool visible) {
			ProxyQDial().SetNotchesVisible(visible);
		}
		[SmokeMethod("setWrapping(bool)")]
		public void SetWrapping(bool on) {
			ProxyQDial().SetWrapping(on);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQDial().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQDial().Tr(s);
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent e) {
			return ProxyQDial().Event(e);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected new void ResizeEvent(QResizeEvent re) {
			ProxyQDial().ResizeEvent(re);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected new void PaintEvent(QPaintEvent pe) {
			ProxyQDial().PaintEvent(pe);
		}
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected new void MousePressEvent(QMouseEvent me) {
			ProxyQDial().MousePressEvent(me);
		}
		[SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
		protected new void MouseReleaseEvent(QMouseEvent me) {
			ProxyQDial().MouseReleaseEvent(me);
		}
		[SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
		protected new void MouseMoveEvent(QMouseEvent me) {
			ProxyQDial().MouseMoveEvent(me);
		}
		[SmokeMethod("sliderChange(QAbstractSlider::SliderChange)")]
		protected new void SliderChange(QAbstractSlider.SliderChange change) {
			ProxyQDial().SliderChange(change);
		}
		~QDial() {
			DisposeQDial();
		}
		public new void Dispose() {
			DisposeQDial();
		}
		[SmokeMethod("~QDial()")]
		private void DisposeQDial() {
			ProxyQDial().DisposeQDial();
		}
		protected new IQDialSignals Emit() {
			return (IQDialSignals) Q_EMIT;
		}
	}

	public interface IQDialSignals : IQAbstractSliderSignals {
	}
}