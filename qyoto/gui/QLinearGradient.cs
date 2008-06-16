//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	[SmokeClass("QLinearGradient")]
	public class QLinearGradient : QGradient, IDisposable {
 		protected QLinearGradient(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QLinearGradient), this);
		}
		public QLinearGradient() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QLinearGradient", "QLinearGradient()", typeof(void));
		}
		public QLinearGradient(QPointF start, QPointF finalStop) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QLinearGradient##", "QLinearGradient(const QPointF&, const QPointF&)", typeof(void), typeof(QPointF), start, typeof(QPointF), finalStop);
		}
		public QLinearGradient(double xStart, double yStart, double xFinalStop, double yFinalStop) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QLinearGradient$$$$", "QLinearGradient(qreal, qreal, qreal, qreal)", typeof(void), typeof(double), xStart, typeof(double), yStart, typeof(double), xFinalStop, typeof(double), yFinalStop);
		}
		public QPointF Start() {
			return (QPointF) interceptor.Invoke("start", "start() const", typeof(QPointF));
		}
		public void SetStart(QPointF start) {
			interceptor.Invoke("setStart#", "setStart(const QPointF&)", typeof(void), typeof(QPointF), start);
		}
		public void SetStart(double x, double y) {
			interceptor.Invoke("setStart$$", "setStart(qreal, qreal)", typeof(void), typeof(double), x, typeof(double), y);
		}
		public QPointF FinalStop() {
			return (QPointF) interceptor.Invoke("finalStop", "finalStop() const", typeof(QPointF));
		}
		public void SetFinalStop(QPointF stop) {
			interceptor.Invoke("setFinalStop#", "setFinalStop(const QPointF&)", typeof(void), typeof(QPointF), stop);
		}
		public void SetFinalStop(double x, double y) {
			interceptor.Invoke("setFinalStop$$", "setFinalStop(qreal, qreal)", typeof(void), typeof(double), x, typeof(double), y);
		}
		~QLinearGradient() {
			interceptor.Invoke("~QLinearGradient", "~QLinearGradient()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QLinearGradient", "~QLinearGradient()", typeof(void));
		}
	}
}
