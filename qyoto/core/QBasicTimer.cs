//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	[SmokeClass("QBasicTimer")]
	public class QBasicTimer : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QBasicTimer(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QBasicTimer), this);
		}
		public QBasicTimer() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QBasicTimer", "QBasicTimer()", typeof(void));
		}
		public bool IsActive() {
			return (bool) interceptor.Invoke("isActive", "isActive() const", typeof(bool));
		}
		public int TimerId() {
			return (int) interceptor.Invoke("timerId", "timerId() const", typeof(int));
		}
		public void Start(int msec, QObject arg2) {
			interceptor.Invoke("start$#", "start(int, QObject*)", typeof(void), typeof(int), msec, typeof(QObject), arg2);
		}
		public void Stop() {
			interceptor.Invoke("stop", "stop()", typeof(void));
		}
		~QBasicTimer() {
			interceptor.Invoke("~QBasicTimer", "~QBasicTimer()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QBasicTimer", "~QBasicTimer()", typeof(void));
		}
	}
}
