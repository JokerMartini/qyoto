//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QAbstractFileEngineHandler")]
	public abstract class QAbstractFileEngineHandler : MarshalByRefObject {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QAbstractFileEngineHandler(Type dummy) {}
		[SmokeClass("QAbstractFileEngineHandler")]
		interface IQAbstractFileEngineHandlerProxy {
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QAbstractFileEngineHandler), this);
			_interceptor = (QAbstractFileEngineHandler) realProxy.GetTransparentProxy();
		}
		private QAbstractFileEngineHandler ProxyQAbstractFileEngineHandler() {
			return (QAbstractFileEngineHandler) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QAbstractFileEngineHandler() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQAbstractFileEngineHandlerProxy), null);
			_staticInterceptor = (IQAbstractFileEngineHandlerProxy) realProxy.GetTransparentProxy();
		}
		private static IQAbstractFileEngineHandlerProxy StaticQAbstractFileEngineHandler() {
			return (IQAbstractFileEngineHandlerProxy) _staticInterceptor;
		}
		public QAbstractFileEngineHandler() : this((Type) null) {
			CreateProxy();
			NewQAbstractFileEngineHandler();
		}
		[SmokeMethod("QAbstractFileEngineHandler", "()", "")]
		private void NewQAbstractFileEngineHandler() {
			ProxyQAbstractFileEngineHandler().NewQAbstractFileEngineHandler();
		}
		public abstract QAbstractFileEngine Create(string fileName);
		~QAbstractFileEngineHandler() {
			DisposeQAbstractFileEngineHandler();
		}
		public void Dispose() {
			DisposeQAbstractFileEngineHandler();
		}
		[SmokeMethod("~QAbstractFileEngineHandler", "()", "")]
		private void DisposeQAbstractFileEngineHandler() {
			ProxyQAbstractFileEngineHandler().DisposeQAbstractFileEngineHandler();
		}
	}
}
