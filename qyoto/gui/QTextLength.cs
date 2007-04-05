//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QTextLength")]
	public class QTextLength : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QTextLength(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QTextLength), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QTextLength() {
			staticInterceptor = new SmokeInvocation(typeof(QTextLength), null);
		}
		public enum TypeOf {
			VariableLength = 0,
			FixedLength = 1,
			PercentageLength = 2,
		}
		//  operator QVariant(); >>>> NOT CONVERTED
		public QTextLength() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTextLength", "QTextLength()", typeof(void));
		}
		public QTextLength(QTextLength.TypeOf type, double value) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTextLength$$", "QTextLength(QTextLength::Type, qreal)", typeof(void), typeof(QTextLength.TypeOf), type, typeof(double), value);
		}
		public QTextLength.TypeOf type() {
			return (QTextLength.TypeOf) interceptor.Invoke("type", "type() const", typeof(QTextLength.TypeOf));
		}
		public double Value(double maximumLength) {
			return (double) interceptor.Invoke("value$", "value(qreal) const", typeof(double), typeof(double), maximumLength);
		}
		public double RawValue() {
			return (double) interceptor.Invoke("rawValue", "rawValue() const", typeof(double));
		}
		public override bool Equals(object o) {
			if (!(o is QTextLength)) { return false; }
			return this == (QTextLength) o;
		}
		public override int GetHashCode() {
			return interceptor.GetHashCode();
		}
		~QTextLength() {
			interceptor.Invoke("~QTextLength", "~QTextLength()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QTextLength", "~QTextLength()", typeof(void));
		}
		public static bool operator==(QTextLength lhs, QTextLength other) {
			return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QTextLength&) const", typeof(bool), typeof(QTextLength), lhs, typeof(QTextLength), other);
		}
		public static bool operator!=(QTextLength lhs, QTextLength other) {
			return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QTextLength&) const", typeof(bool), typeof(QTextLength), lhs, typeof(QTextLength), other);
		}
	}
}
