//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QClassInfo : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QClassInfo(Type dummy) {}
		interface IQClassInfoProxy {
		}

		protected void CreateQClassInfoProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QClassInfo), this);
			_interceptor = (QClassInfo) realProxy.GetTransparentProxy();
		}
		private QClassInfo ProxyQClassInfo() {
			return (QClassInfo) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QClassInfo() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQClassInfoProxy), null);
			_staticInterceptor = (IQClassInfoProxy) realProxy.GetTransparentProxy();
		}
		private static IQClassInfoProxy StaticQClassInfo() {
			return (IQClassInfoProxy) _staticInterceptor;
		}

		public QClassInfo() : this((Type) null) {
			CreateQClassInfoProxy();
			NewQClassInfo();
		}
		[SmokeMethod("QClassInfo()")]
		private void NewQClassInfo() {
			ProxyQClassInfo().NewQClassInfo();
		}
		~QClassInfo() {
			DisposeQClassInfo();
		}
		public void Dispose() {
			DisposeQClassInfo();
		}
		private void DisposeQClassInfo() {
			ProxyQClassInfo().DisposeQClassInfo();
		}
	}
}
