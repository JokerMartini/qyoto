//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	/// See <see cref="IQAbstractSliderSignals"></see> for signals emitted by QAbstractSlider
	[SmokeClass("QAbstractSlider")]
	public class QAbstractSlider : QWidget, IDisposable {
 		protected QAbstractSlider(Type dummy) : base((Type) null) {}
		interface IQAbstractSliderProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QAbstractSlider), this);
			_interceptor = (QAbstractSlider) realProxy.GetTransparentProxy();
		}
		private QAbstractSlider ProxyQAbstractSlider() {
			return (QAbstractSlider) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QAbstractSlider() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQAbstractSliderProxy), null);
			_staticInterceptor = (IQAbstractSliderProxy) realProxy.GetTransparentProxy();
		}
		private static IQAbstractSliderProxy StaticQAbstractSlider() {
			return (IQAbstractSliderProxy) _staticInterceptor;
		}

		public enum SliderAction {
			SliderNoAction = 0,
			SliderSingleStepAdd = 1,
			SliderSingleStepSub = 2,
			SliderPageStepAdd = 3,
			SliderPageStepSub = 4,
			SliderToMinimum = 5,
			SliderToMaximum = 6,
			SliderMove = 7,
		}
		public enum SliderChange {
			SliderRangeChange = 0,
			SliderOrientationChange = 1,
			SliderStepsChange = 2,
			SliderValueChange = 3,
		}
		public int Minimum {
			get {
				return Property("Minimum").Value<int>();
			}
			set {
				SetProperty("Minimum", QVariant.FromValue<int>(value));
			}
		}
		public int Maximum {
			get {
				return Property("Maximum").Value<int>();
			}
			set {
				SetProperty("Maximum", QVariant.FromValue<int>(value));
			}
		}
		public int SingleStep {
			get {
				return Property("SingleStep").Value<int>();
			}
			set {
				SetProperty("SingleStep", QVariant.FromValue<int>(value));
			}
		}
		public int PageStep {
			get {
				return Property("PageStep").Value<int>();
			}
			set {
				SetProperty("PageStep", QVariant.FromValue<int>(value));
			}
		}
		public int Value {
			get {
				return Property("Value").Value<int>();
			}
			set {
				SetProperty("Value", QVariant.FromValue<int>(value));
			}
		}
		public int SliderPosition {
			get {
				return Property("SliderPosition").Value<int>();
			}
			set {
				SetProperty("SliderPosition", QVariant.FromValue<int>(value));
			}
		}
		public bool Tracking {
			get {
				return Property("Tracking").Value<bool>();
			}
			set {
				SetProperty("Tracking", QVariant.FromValue<bool>(value));
			}
		}
		public Qt.Orientation Orientation {
			get {
				return Property("Orientation").Value<Qt.Orientation>();
			}
			set {
				SetProperty("Orientation", QVariant.FromValue<Qt.Orientation>(value));
			}
		}
		public bool InvertedAppearance {
			get {
				return Property("InvertedAppearance").Value<bool>();
			}
			set {
				SetProperty("InvertedAppearance", QVariant.FromValue<bool>(value));
			}
		}
		public bool InvertedControls {
			get {
				return Property("InvertedControls").Value<bool>();
			}
			set {
				SetProperty("InvertedControls", QVariant.FromValue<bool>(value));
			}
		}
		public bool SliderDown {
			get {
				return Property("SliderDown").Value<bool>();
			}
			set {
				SetProperty("SliderDown", QVariant.FromValue<bool>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QAbstractSlider(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQAbstractSlider(parent);
		}
		[SmokeMethod("QAbstractSlider(QWidget*)")]
		private void NewQAbstractSlider(QWidget parent) {
			ProxyQAbstractSlider().NewQAbstractSlider(parent);
		}
		public QAbstractSlider() : this((Type) null) {
			CreateProxy();
			NewQAbstractSlider();
		}
		[SmokeMethod("QAbstractSlider()")]
		private void NewQAbstractSlider() {
			ProxyQAbstractSlider().NewQAbstractSlider();
		}
		[SmokeMethod("setRange(int, int)")]
		public void SetRange(int min, int max) {
			ProxyQAbstractSlider().SetRange(min,max);
		}
		[SmokeMethod("hasTracking() const")]
		public bool HasTracking() {
			return ProxyQAbstractSlider().HasTracking();
		}
		[SmokeMethod("isSliderDown() const")]
		public bool IsSliderDown() {
			return ProxyQAbstractSlider().IsSliderDown();
		}
		[SmokeMethod("triggerAction(QAbstractSlider::SliderAction)")]
		public void TriggerAction(QAbstractSlider.SliderAction action) {
			ProxyQAbstractSlider().TriggerAction(action);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQAbstractSlider().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQAbstractSlider().Tr(s);
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent e) {
			return ProxyQAbstractSlider().Event(e);
		}
		[SmokeMethod("setRepeatAction(QAbstractSlider::SliderAction, int, int)")]
		protected void SetRepeatAction(QAbstractSlider.SliderAction action, int thresholdTime, int repeatTime) {
			ProxyQAbstractSlider().SetRepeatAction(action,thresholdTime,repeatTime);
		}
		[SmokeMethod("setRepeatAction(QAbstractSlider::SliderAction, int)")]
		protected void SetRepeatAction(QAbstractSlider.SliderAction action, int thresholdTime) {
			ProxyQAbstractSlider().SetRepeatAction(action,thresholdTime);
		}
		[SmokeMethod("setRepeatAction(QAbstractSlider::SliderAction)")]
		protected void SetRepeatAction(QAbstractSlider.SliderAction action) {
			ProxyQAbstractSlider().SetRepeatAction(action);
		}
		[SmokeMethod("repeatAction() const")]
		protected QAbstractSlider.SliderAction RepeatAction() {
			return ProxyQAbstractSlider().RepeatAction();
		}
		[SmokeMethod("sliderChange(QAbstractSlider::SliderChange)")]
		protected virtual void sliderChange(QAbstractSlider.SliderChange change) {
			ProxyQAbstractSlider().sliderChange(change);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected new void KeyPressEvent(QKeyEvent ev) {
			ProxyQAbstractSlider().KeyPressEvent(ev);
		}
		[SmokeMethod("timerEvent(QTimerEvent*)")]
		protected new void TimerEvent(QTimerEvent arg1) {
			ProxyQAbstractSlider().TimerEvent(arg1);
		}
		[SmokeMethod("wheelEvent(QWheelEvent*)")]
		protected new void WheelEvent(QWheelEvent e) {
			ProxyQAbstractSlider().WheelEvent(e);
		}
		[SmokeMethod("changeEvent(QEvent*)")]
		protected new void ChangeEvent(QEvent e) {
			ProxyQAbstractSlider().ChangeEvent(e);
		}
		~QAbstractSlider() {
			DisposeQAbstractSlider();
		}
		public new void Dispose() {
			DisposeQAbstractSlider();
		}
		[SmokeMethod("~QAbstractSlider()")]
		private void DisposeQAbstractSlider() {
			ProxyQAbstractSlider().DisposeQAbstractSlider();
		}
		protected new IQAbstractSliderSignals Emit() {
			return (IQAbstractSliderSignals) Q_EMIT;
		}
	}

	public interface IQAbstractSliderSignals : IQWidgetSignals {
		[Q_SIGNAL("void valueChanged(int)")]
		void ValueChanged(int value);
		[Q_SIGNAL("void sliderPressed()")]
		void SliderPressed();
		[Q_SIGNAL("void sliderMoved(int)")]
		void SliderMoved(int position);
		[Q_SIGNAL("void sliderReleased()")]
		void SliderReleased();
		[Q_SIGNAL("void rangeChanged(int, int)")]
		void RangeChanged(int min, int max);
		[Q_SIGNAL("void actionTriggered(int)")]
		void ActionTriggered(int action);
	}
}
