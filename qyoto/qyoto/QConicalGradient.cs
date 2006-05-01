//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QConicalGradient")]
	public class QConicalGradient : QGradient, IDisposable {
 		protected QConicalGradient(Type dummy) : base((Type) null) {}
		interface IQConicalGradientProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QConicalGradient), this);
			_interceptor = (QConicalGradient) realProxy.GetTransparentProxy();
		}
		private QConicalGradient ProxyQConicalGradient() {
			return (QConicalGradient) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QConicalGradient() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQConicalGradientProxy), null);
			_staticInterceptor = (IQConicalGradientProxy) realProxy.GetTransparentProxy();
		}
		private static IQConicalGradientProxy StaticQConicalGradient() {
			return (IQConicalGradientProxy) _staticInterceptor;
		}

		public QConicalGradient(QPointF center, double startAngle) : this((Type) null) {
			CreateProxy();
			NewQConicalGradient(center,startAngle);
		}
		[SmokeMethod("QConicalGradient(const QPointF&, qreal)")]
		private void NewQConicalGradient(QPointF center, double startAngle) {
			ProxyQConicalGradient().NewQConicalGradient(center,startAngle);
		}
		public QConicalGradient(double cx, double cy, double startAngle) : this((Type) null) {
			CreateProxy();
			NewQConicalGradient(cx,cy,startAngle);
		}
		[SmokeMethod("QConicalGradient(qreal, qreal, qreal)")]
		private void NewQConicalGradient(double cx, double cy, double startAngle) {
			ProxyQConicalGradient().NewQConicalGradient(cx,cy,startAngle);
		}
		[SmokeMethod("center() const")]
		public QPointF Center() {
			return ProxyQConicalGradient().Center();
		}
		[SmokeMethod("angle() const")]
		public double Angle() {
			return ProxyQConicalGradient().Angle();
		}
		~QConicalGradient() {
			DisposeQConicalGradient();
		}
		public void Dispose() {
			DisposeQConicalGradient();
		}
		private void DisposeQConicalGradient() {
			ProxyQConicalGradient().DisposeQConicalGradient();
		}
	}
}
