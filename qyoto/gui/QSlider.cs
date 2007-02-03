//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QSlider")]
	public class QSlider : QAbstractSlider, IDisposable {
 		protected QSlider(Type dummy) : base((Type) null) {}
		[SmokeClass("QSlider")]
		interface IQSliderProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSlider), this);
			_interceptor = (QSlider) realProxy.GetTransparentProxy();
		}
		private QSlider ProxyQSlider() {
			return (QSlider) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSlider() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSliderProxy), null);
			_staticInterceptor = (IQSliderProxy) realProxy.GetTransparentProxy();
		}
		private static IQSliderProxy StaticQSlider() {
			return (IQSliderProxy) _staticInterceptor;
		}

		public enum TickPosition {
			NoTicks = 0,
			TicksAbove = 1,
			TicksLeft = TicksAbove,
			TicksBelow = 2,
			TicksRight = TicksBelow,
			TicksBothSides = 3,
		}
		[Q_PROPERTY("QSlider::TickPosition", "tickPosition")]
		public QSlider.TickPosition tickPosition {
			get {
				return Property("tickPosition").Value<QSlider.TickPosition>();
			}
			set {
				SetProperty("tickPosition", QVariant.FromValue<QSlider.TickPosition>(value));
			}
		}
		[Q_PROPERTY("int", "tickInterval")]
		public int TickInterval {
			get {
				return Property("tickInterval").Value<int>();
			}
			set {
				SetProperty("tickInterval", QVariant.FromValue<int>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QSlider(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQSlider(parent);
		}
		[SmokeMethod("QSlider", "(QWidget*)", "#")]
		private void NewQSlider(QWidget parent) {
			ProxyQSlider().NewQSlider(parent);
		}
		public QSlider() : this((Type) null) {
			CreateProxy();
			NewQSlider();
		}
		[SmokeMethod("QSlider", "()", "")]
		private void NewQSlider() {
			ProxyQSlider().NewQSlider();
		}
		public QSlider(Qt.Orientation orientation, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQSlider(orientation,parent);
		}
		[SmokeMethod("QSlider", "(Qt::Orientation, QWidget*)", "$#")]
		private void NewQSlider(Qt.Orientation orientation, QWidget parent) {
			ProxyQSlider().NewQSlider(orientation,parent);
		}
		public QSlider(Qt.Orientation orientation) : this((Type) null) {
			CreateProxy();
			NewQSlider(orientation);
		}
		[SmokeMethod("QSlider", "(Qt::Orientation)", "$")]
		private void NewQSlider(Qt.Orientation orientation) {
			ProxyQSlider().NewQSlider(orientation);
		}
		[SmokeMethod("sizeHint", "() const", "")]
		public new QSize SizeHint() {
			return ProxyQSlider().SizeHint();
		}
		[SmokeMethod("minimumSizeHint", "() const", "")]
		public new QSize MinimumSizeHint() {
			return ProxyQSlider().MinimumSizeHint();
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		public new bool Event(QEvent arg1) {
			return ProxyQSlider().Event(arg1);
		}
		public static new string Tr(string s, string c) {
			return StaticQSlider().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQSlider().Tr(s);
		}
		[SmokeMethod("paintEvent", "(QPaintEvent*)", "#")]
		protected new void PaintEvent(QPaintEvent ev) {
			ProxyQSlider().PaintEvent(ev);
		}
		[SmokeMethod("mousePressEvent", "(QMouseEvent*)", "#")]
		protected new void MousePressEvent(QMouseEvent ev) {
			ProxyQSlider().MousePressEvent(ev);
		}
		[SmokeMethod("mouseReleaseEvent", "(QMouseEvent*)", "#")]
		protected new void MouseReleaseEvent(QMouseEvent ev) {
			ProxyQSlider().MouseReleaseEvent(ev);
		}
		[SmokeMethod("mouseMoveEvent", "(QMouseEvent*)", "#")]
		protected new void MouseMoveEvent(QMouseEvent ev) {
			ProxyQSlider().MouseMoveEvent(ev);
		}
		~QSlider() {
			DisposeQSlider();
		}
		public new void Dispose() {
			DisposeQSlider();
		}
		[SmokeMethod("~QSlider", "()", "")]
		private void DisposeQSlider() {
			ProxyQSlider().DisposeQSlider();
		}
		protected new IQSliderSignals Emit {
			get {
				return (IQSliderSignals) Q_EMIT;
			}
		}
	}

	public interface IQSliderSignals : IQAbstractSliderSignals {
	}
}
