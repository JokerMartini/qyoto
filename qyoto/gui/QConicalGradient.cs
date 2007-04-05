//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QConicalGradient")]
	public class QConicalGradient : QGradient, IDisposable {
 		protected QConicalGradient(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QConicalGradient), this);
		}
		public QConicalGradient() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QConicalGradient", "QConicalGradient()", typeof(void));
		}
		public QConicalGradient(QPointF center, double startAngle) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QConicalGradient#$", "QConicalGradient(const QPointF&, qreal)", typeof(void), typeof(QPointF), center, typeof(double), startAngle);
		}
		public QConicalGradient(double cx, double cy, double startAngle) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QConicalGradient$$$", "QConicalGradient(qreal, qreal, qreal)", typeof(void), typeof(double), cx, typeof(double), cy, typeof(double), startAngle);
		}
		public QPointF Center() {
			return (QPointF) interceptor.Invoke("center", "center() const", typeof(QPointF));
		}
		public void SetCenter(QPointF center) {
			interceptor.Invoke("setCenter#", "setCenter(const QPointF&)", typeof(void), typeof(QPointF), center);
		}
		public void SetCenter(double x, double y) {
			interceptor.Invoke("setCenter$$", "setCenter(qreal, qreal)", typeof(void), typeof(double), x, typeof(double), y);
		}
		public double Angle() {
			return (double) interceptor.Invoke("angle", "angle() const", typeof(double));
		}
		public void SetAngle(double angle) {
			interceptor.Invoke("setAngle$", "setAngle(qreal)", typeof(void), typeof(double), angle);
		}
		~QConicalGradient() {
			interceptor.Invoke("~QConicalGradient", "~QConicalGradient()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QConicalGradient", "~QConicalGradient()", typeof(void));
		}
	}
}
