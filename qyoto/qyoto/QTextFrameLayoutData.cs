//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QTextFrameLayoutData")]
	public class QTextFrameLayoutData : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QTextFrameLayoutData(Type dummy) {}
		interface IQTextFrameLayoutDataProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextFrameLayoutData), this);
			_interceptor = (QTextFrameLayoutData) realProxy.GetTransparentProxy();
		}
		private QTextFrameLayoutData ProxyQTextFrameLayoutData() {
			return (QTextFrameLayoutData) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextFrameLayoutData() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextFrameLayoutDataProxy), null);
			_staticInterceptor = (IQTextFrameLayoutDataProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextFrameLayoutDataProxy StaticQTextFrameLayoutData() {
			return (IQTextFrameLayoutDataProxy) _staticInterceptor;
		}

		public QTextFrameLayoutData() : this((Type) null) {
			CreateProxy();
			NewQTextFrameLayoutData();
		}
		[SmokeMethod("QTextFrameLayoutData()")]
		private void NewQTextFrameLayoutData() {
			ProxyQTextFrameLayoutData().NewQTextFrameLayoutData();
		}
		~QTextFrameLayoutData() {
			DisposeQTextFrameLayoutData();
		}
		public void Dispose() {
			DisposeQTextFrameLayoutData();
		}
		private void DisposeQTextFrameLayoutData() {
			ProxyQTextFrameLayoutData().DisposeQTextFrameLayoutData();
		}
	}
}
