//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QDoubleValidator")]
	public class QDoubleValidator : QValidator, IDisposable {
 		protected QDoubleValidator(Type dummy) : base((Type) null) {}
		interface IQDoubleValidatorProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDoubleValidator), this);
			_interceptor = (QDoubleValidator) realProxy.GetTransparentProxy();
		}
		private QDoubleValidator ProxyQDoubleValidator() {
			return (QDoubleValidator) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDoubleValidator() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDoubleValidatorProxy), null);
			_staticInterceptor = (IQDoubleValidatorProxy) realProxy.GetTransparentProxy();
		}
		private static IQDoubleValidatorProxy StaticQDoubleValidator() {
			return (IQDoubleValidatorProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQDoubleValidator().MetaObject();
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QDoubleValidator(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQDoubleValidator(parent);
		}
		[SmokeMethod("QDoubleValidator(QObject*)")]
		private void NewQDoubleValidator(QObject parent) {
			ProxyQDoubleValidator().NewQDoubleValidator(parent);
		}
		public QDoubleValidator(double bottom, double top, int decimals, QObject parent) : this((Type) null) {
			CreateProxy();
			NewQDoubleValidator(bottom,top,decimals,parent);
		}
		[SmokeMethod("QDoubleValidator(double, double, int, QObject*)")]
		private void NewQDoubleValidator(double bottom, double top, int decimals, QObject parent) {
			ProxyQDoubleValidator().NewQDoubleValidator(bottom,top,decimals,parent);
		}
		[SmokeMethod("validate(QString&, int&) const")]
		public new int Validate(StringBuilder arg1, out int arg2) {
			return ProxyQDoubleValidator().Validate(arg1,out arg2);
		}
		[SmokeMethod("setRange(double, double, int)")]
		public virtual void SetRange(double bottom, double top, int decimals) {
			ProxyQDoubleValidator().SetRange(bottom,top,decimals);
		}
		[SmokeMethod("setRange(double, double)")]
		public virtual void SetRange(double bottom, double top) {
			ProxyQDoubleValidator().SetRange(bottom,top);
		}
		[SmokeMethod("setBottom(double)")]
		public void SetBottom(double arg1) {
			ProxyQDoubleValidator().SetBottom(arg1);
		}
		[SmokeMethod("setTop(double)")]
		public void SetTop(double arg1) {
			ProxyQDoubleValidator().SetTop(arg1);
		}
		[SmokeMethod("setDecimals(int)")]
		public void SetDecimals(int arg1) {
			ProxyQDoubleValidator().SetDecimals(arg1);
		}
		[SmokeMethod("bottom() const")]
		public double Bottom() {
			return ProxyQDoubleValidator().Bottom();
		}
		[SmokeMethod("top() const")]
		public double Top() {
			return ProxyQDoubleValidator().Top();
		}
		[SmokeMethod("decimals() const")]
		public int Decimals() {
			return ProxyQDoubleValidator().Decimals();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQDoubleValidator().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQDoubleValidator().Tr(s);
		}
		~QDoubleValidator() {
			DisposeQDoubleValidator();
		}
		public new void Dispose() {
			DisposeQDoubleValidator();
		}
		private void DisposeQDoubleValidator() {
			ProxyQDoubleValidator().DisposeQDoubleValidator();
		}
		protected new IQDoubleValidatorSignals Emit() {
			return (IQDoubleValidatorSignals) Q_EMIT;
		}
	}

	public interface IQDoubleValidatorSignals : IQValidatorSignals {
	}
}
