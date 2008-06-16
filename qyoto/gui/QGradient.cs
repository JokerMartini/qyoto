//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	[SmokeClass("QGradient")]
	public class QGradient : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QGradient(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QGradient), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QGradient() {
			staticInterceptor = new SmokeInvocation(typeof(QGradient), null);
		}
		public enum TypeOf {
			LinearGradient = 0,
			RadialGradient = 1,
			ConicalGradient = 2,
			NoGradient = 3,
		}
		public enum Spread {
			PadSpread = 0,
			ReflectSpread = 1,
			RepeatSpread = 2,
		}
		public enum CoordinateMode {
			LogicalMode = 0,
			StretchToDeviceMode = 1,
			ObjectBoundingMode = 2,
		}
		// void setStops(const QGradientStops& arg1); >>>> NOT CONVERTED
		// QGradientStops stops(); >>>> NOT CONVERTED
		public QGradient() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGradient", "QGradient()", typeof(void));
		}
		public QGradient.TypeOf type() {
			return (QGradient.TypeOf) interceptor.Invoke("type", "type() const", typeof(QGradient.TypeOf));
		}
		public void SetSpread(QGradient.Spread spread) {
			interceptor.Invoke("setSpread$", "setSpread(QGradient::Spread)", typeof(void), typeof(QGradient.Spread), spread);
		}
		public QGradient.Spread spread() {
			return (QGradient.Spread) interceptor.Invoke("spread", "spread() const", typeof(QGradient.Spread));
		}
		public void SetColorAt(double pos, QColor color) {
			interceptor.Invoke("setColorAt$#", "setColorAt(qreal, const QColor&)", typeof(void), typeof(double), pos, typeof(QColor), color);
		}
		public QGradient.CoordinateMode coordinateMode() {
			return (QGradient.CoordinateMode) interceptor.Invoke("coordinateMode", "coordinateMode() const", typeof(QGradient.CoordinateMode));
		}
		public void SetCoordinateMode(QGradient.CoordinateMode mode) {
			interceptor.Invoke("setCoordinateMode$", "setCoordinateMode(QGradient::CoordinateMode)", typeof(void), typeof(QGradient.CoordinateMode), mode);
		}
		public override bool Equals(object o) {
			if (!(o is QGradient)) { return false; }
			return this == (QGradient) o;
		}
		public override int GetHashCode() {
			return interceptor.GetHashCode();
		}
		~QGradient() {
			interceptor.Invoke("~QGradient", "~QGradient()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QGradient", "~QGradient()", typeof(void));
		}
		public static bool operator==(QGradient lhs, QGradient gradient) {
			return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QGradient&) const", typeof(bool), typeof(QGradient), lhs, typeof(QGradient), gradient);
		}
		public static bool operator!=(QGradient lhs, QGradient gradient) {
			return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QGradient&) const", typeof(bool), typeof(QGradient), lhs, typeof(QGradient), gradient);
		}
	}
}
