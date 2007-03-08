//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QTextLength")]
	public class QTextLength : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QTextLength(Type dummy) {}
		[SmokeClass("QTextLength")]
		interface IQTextLengthProxy {
			[SmokeMethod("operator==", "(const QTextLength&) const", "#")]
			bool op_equals(QTextLength lhs, QTextLength other);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextLength), this);
			_interceptor = (QTextLength) realProxy.GetTransparentProxy();
		}
		private QTextLength ProxyQTextLength() {
			return (QTextLength) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextLength() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextLengthProxy), null);
			_staticInterceptor = (IQTextLengthProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextLengthProxy StaticQTextLength() {
			return (IQTextLengthProxy) _staticInterceptor;
		}
		public enum TypeOf {
			VariableLength = 0,
			FixedLength = 1,
			PercentageLength = 2,
		}
		public QTextLength() : this((Type) null) {
			CreateProxy();
			NewQTextLength();
		}
		[SmokeMethod("QTextLength", "()", "")]
		private void NewQTextLength() {
			ProxyQTextLength().NewQTextLength();
		}
		public QTextLength(QTextLength.TypeOf type, double value) : this((Type) null) {
			CreateProxy();
			NewQTextLength(type,value);
		}
		[SmokeMethod("QTextLength", "(QTextLength::Type, qreal)", "$$")]
		private void NewQTextLength(QTextLength.TypeOf type, double value) {
			ProxyQTextLength().NewQTextLength(type,value);
		}
		[SmokeMethod("type", "() const", "")]
		public QTextLength.TypeOf type() {
			return ProxyQTextLength().type();
		}
		[SmokeMethod("value", "(qreal) const", "$")]
		public double Value(double maximumLength) {
			return ProxyQTextLength().Value(maximumLength);
		}
		[SmokeMethod("rawValue", "() const", "")]
		public double RawValue() {
			return ProxyQTextLength().RawValue();
		}
		public static bool operator==(QTextLength lhs, QTextLength other) {
			return StaticQTextLength().op_equals(lhs,other);
		}
		public static bool operator!=(QTextLength lhs, QTextLength other) {
			return !StaticQTextLength().op_equals(lhs,other);
		}
		public override bool Equals(object o) {
			if (!(o is QTextLength)) { return false; }
			return this == (QTextLength) o;
		}
		public override int GetHashCode() {
			return ProxyQTextLength().GetHashCode();
		}
		//  operator QVariant(); >>>> NOT CONVERTED
		~QTextLength() {
			DisposeQTextLength();
		}
		public void Dispose() {
			DisposeQTextLength();
		}
		[SmokeMethod("~QTextLength", "()", "")]
		private void DisposeQTextLength() {
			ProxyQTextLength().DisposeQTextLength();
		}
	}
}
