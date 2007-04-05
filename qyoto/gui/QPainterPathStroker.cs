//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QPainterPathStroker")]
	public class QPainterPathStroker : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QPainterPathStroker(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QPainterPathStroker), this);
		}
		public QPainterPathStroker() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QPainterPathStroker", "QPainterPathStroker()", typeof(void));
		}
		public void SetWidth(double width) {
			interceptor.Invoke("setWidth$", "setWidth(qreal)", typeof(void), typeof(double), width);
		}
		public double Width() {
			return (double) interceptor.Invoke("width", "width() const", typeof(double));
		}
		public void SetCapStyle(Qt.PenCapStyle style) {
			interceptor.Invoke("setCapStyle$", "setCapStyle(Qt::PenCapStyle)", typeof(void), typeof(Qt.PenCapStyle), style);
		}
		public Qt.PenCapStyle CapStyle() {
			return (Qt.PenCapStyle) interceptor.Invoke("capStyle", "capStyle() const", typeof(Qt.PenCapStyle));
		}
		public void SetJoinStyle(Qt.PenJoinStyle style) {
			interceptor.Invoke("setJoinStyle$", "setJoinStyle(Qt::PenJoinStyle)", typeof(void), typeof(Qt.PenJoinStyle), style);
		}
		public Qt.PenJoinStyle JoinStyle() {
			return (Qt.PenJoinStyle) interceptor.Invoke("joinStyle", "joinStyle() const", typeof(Qt.PenJoinStyle));
		}
		public void SetMiterLimit(double length) {
			interceptor.Invoke("setMiterLimit$", "setMiterLimit(qreal)", typeof(void), typeof(double), length);
		}
		public double MiterLimit() {
			return (double) interceptor.Invoke("miterLimit", "miterLimit() const", typeof(double));
		}
		public void SetCurveThreshold(double threshold) {
			interceptor.Invoke("setCurveThreshold$", "setCurveThreshold(qreal)", typeof(void), typeof(double), threshold);
		}
		public double CurveThreshold() {
			return (double) interceptor.Invoke("curveThreshold", "curveThreshold() const", typeof(double));
		}
		public void SetDashPattern(Qt.PenStyle arg1) {
			interceptor.Invoke("setDashPattern$", "setDashPattern(Qt::PenStyle)", typeof(void), typeof(Qt.PenStyle), arg1);
		}
		public void SetDashPattern(List<double> dashPattern) {
			interceptor.Invoke("setDashPattern?", "setDashPattern(const QVector<qreal>&)", typeof(void), typeof(List<double>), dashPattern);
		}
		public List<double> DashPattern() {
			return (List<double>) interceptor.Invoke("dashPattern", "dashPattern() const", typeof(List<double>));
		}
		public void SetDashOffset(double offset) {
			interceptor.Invoke("setDashOffset$", "setDashOffset(qreal)", typeof(void), typeof(double), offset);
		}
		public double DashOffset() {
			return (double) interceptor.Invoke("dashOffset", "dashOffset() const", typeof(double));
		}
		public QPainterPath CreateStroke(QPainterPath path) {
			return (QPainterPath) interceptor.Invoke("createStroke#", "createStroke(const QPainterPath&) const", typeof(QPainterPath), typeof(QPainterPath), path);
		}
		~QPainterPathStroker() {
			interceptor.Invoke("~QPainterPathStroker", "~QPainterPathStroker()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QPainterPathStroker", "~QPainterPathStroker()", typeof(void));
		}
	}
}
