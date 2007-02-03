//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QBool")]
	public class QBool : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QBool(Type dummy) {}
		[SmokeClass("QBool")]
		interface IQBoolProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QBool), this);
			_interceptor = (QBool) realProxy.GetTransparentProxy();
		}
		private QBool ProxyQBool() {
			return (QBool) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QBool() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQBoolProxy), null);
			_staticInterceptor = (IQBoolProxy) realProxy.GetTransparentProxy();
		}
		private static IQBoolProxy StaticQBool() {
			return (IQBoolProxy) _staticInterceptor;
		}

		public QBool(bool B) : this((Type) null) {
			CreateProxy();
			NewQBool(B);
		}
		[SmokeMethod("QBool", "(bool)", "$")]
		private void NewQBool(bool B) {
			ProxyQBool().NewQBool(B);
		}
		//  operator const void *(); >>>> NOT CONVERTED
		~QBool() {
			DisposeQBool();
		}
		public void Dispose() {
			DisposeQBool();
		}
		[SmokeMethod("~QBool", "()", "")]
		private void DisposeQBool() {
			ProxyQBool().DisposeQBool();
		}
	}
}
