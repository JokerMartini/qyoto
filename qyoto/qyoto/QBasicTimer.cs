//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QBasicTimer")]
	public class QBasicTimer : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QBasicTimer(Type dummy) {}
		interface IQBasicTimerProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QBasicTimer), this);
			_interceptor = (QBasicTimer) realProxy.GetTransparentProxy();
		}
		private QBasicTimer ProxyQBasicTimer() {
			return (QBasicTimer) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QBasicTimer() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQBasicTimerProxy), null);
			_staticInterceptor = (IQBasicTimerProxy) realProxy.GetTransparentProxy();
		}
		private static IQBasicTimerProxy StaticQBasicTimer() {
			return (IQBasicTimerProxy) _staticInterceptor;
		}

		public QBasicTimer() : this((Type) null) {
			CreateProxy();
			NewQBasicTimer();
		}
		[SmokeMethod("QBasicTimer()")]
		private void NewQBasicTimer() {
			ProxyQBasicTimer().NewQBasicTimer();
		}
		[SmokeMethod("isActive() const")]
		public bool IsActive() {
			return ProxyQBasicTimer().IsActive();
		}
		[SmokeMethod("timerId() const")]
		public int TimerId() {
			return ProxyQBasicTimer().TimerId();
		}
		[SmokeMethod("start(int, QObject*)")]
		public void Start(int msec, QObject arg2) {
			ProxyQBasicTimer().Start(msec,arg2);
		}
		[SmokeMethod("stop()")]
		public void Stop() {
			ProxyQBasicTimer().Stop();
		}
		~QBasicTimer() {
			DisposeQBasicTimer();
		}
		public void Dispose() {
			DisposeQBasicTimer();
		}
		private void DisposeQBasicTimer() {
			ProxyQBasicTimer().DisposeQBasicTimer();
		}
	}
}
