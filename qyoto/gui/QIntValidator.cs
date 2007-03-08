//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QIntValidator")]
	public class QIntValidator : QValidator, IDisposable {
 		protected QIntValidator(Type dummy) : base((Type) null) {}
		[SmokeClass("QIntValidator")]
		interface IQIntValidatorProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QIntValidator), this);
			_interceptor = (QIntValidator) realProxy.GetTransparentProxy();
		}
		private QIntValidator ProxyQIntValidator() {
			return (QIntValidator) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QIntValidator() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQIntValidatorProxy), null);
			_staticInterceptor = (IQIntValidatorProxy) realProxy.GetTransparentProxy();
		}
		private static IQIntValidatorProxy StaticQIntValidator() {
			return (IQIntValidatorProxy) _staticInterceptor;
		}
		[Q_PROPERTY("int", "bottom")]
		public int Bottom {
			get { return Property("bottom").Value<int>(); }
			set { SetProperty("bottom", QVariant.FromValue<int>(value)); }
		}
		[Q_PROPERTY("int", "top")]
		public int Top {
			get { return Property("top").Value<int>(); }
			set { SetProperty("top", QVariant.FromValue<int>(value)); }
		}
		public QIntValidator(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQIntValidator(parent);
		}
		[SmokeMethod("QIntValidator", "(QObject*)", "#")]
		private void NewQIntValidator(QObject parent) {
			ProxyQIntValidator().NewQIntValidator(parent);
		}
		public QIntValidator(int bottom, int top, QObject parent) : this((Type) null) {
			CreateProxy();
			NewQIntValidator(bottom,top,parent);
		}
		[SmokeMethod("QIntValidator", "(int, int, QObject*)", "$$#")]
		private void NewQIntValidator(int bottom, int top, QObject parent) {
			ProxyQIntValidator().NewQIntValidator(bottom,top,parent);
		}
		[SmokeMethod("validate", "(QString&, int&) const", "$$")]
		public override int Validate(StringBuilder arg1, out int arg2) {
			return ProxyQIntValidator().Validate(arg1,out arg2);
		}
		[SmokeMethod("setRange", "(int, int)", "$$")]
		public virtual void SetRange(int bottom, int top) {
			ProxyQIntValidator().SetRange(bottom,top);
		}
		public static string Tr(string s, string c) {
			return StaticQIntValidator().Tr(s,c);
		}
		public static string Tr(string s) {
			return StaticQIntValidator().Tr(s);
		}
		~QIntValidator() {
			DisposeQIntValidator();
		}
		public new void Dispose() {
			DisposeQIntValidator();
		}
		[SmokeMethod("~QIntValidator", "()", "")]
		private void DisposeQIntValidator() {
			ProxyQIntValidator().DisposeQIntValidator();
		}
		protected new IQIntValidatorSignals Emit {
			get { return (IQIntValidatorSignals) Q_EMIT; }
		}
	}

	public interface IQIntValidatorSignals : IQValidatorSignals {
	}
}
