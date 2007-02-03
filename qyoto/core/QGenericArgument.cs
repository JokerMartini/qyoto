//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QGenericArgument")]
	public class QGenericArgument : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QGenericArgument(Type dummy) {}
		[SmokeClass("QGenericArgument")]
		interface IQGenericArgumentProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGenericArgument), this);
			_interceptor = (QGenericArgument) realProxy.GetTransparentProxy();
		}
		private QGenericArgument ProxyQGenericArgument() {
			return (QGenericArgument) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGenericArgument() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGenericArgumentProxy), null);
			_staticInterceptor = (IQGenericArgumentProxy) realProxy.GetTransparentProxy();
		}
		private static IQGenericArgumentProxy StaticQGenericArgument() {
			return (IQGenericArgumentProxy) _staticInterceptor;
		}

		// QGenericArgument* QGenericArgument(const char* arg1,const void* arg2); >>>> NOT CONVERTED
		public QGenericArgument(string aName) : this((Type) null) {
			CreateProxy();
			NewQGenericArgument(aName);
		}
		[SmokeMethod("QGenericArgument", "(const char*)", "$")]
		private void NewQGenericArgument(string aName) {
			ProxyQGenericArgument().NewQGenericArgument(aName);
		}
		public QGenericArgument() : this((Type) null) {
			CreateProxy();
			NewQGenericArgument();
		}
		[SmokeMethod("QGenericArgument", "()", "")]
		private void NewQGenericArgument() {
			ProxyQGenericArgument().NewQGenericArgument();
		}
		// void* data(); >>>> NOT CONVERTED
		[SmokeMethod("name", "() const", "")]
		public string Name() {
			return ProxyQGenericArgument().Name();
		}
		~QGenericArgument() {
			DisposeQGenericArgument();
		}
		public void Dispose() {
			DisposeQGenericArgument();
		}
		[SmokeMethod("~QGenericArgument", "()", "")]
		private void DisposeQGenericArgument() {
			ProxyQGenericArgument().DisposeQGenericArgument();
		}
	}
}
