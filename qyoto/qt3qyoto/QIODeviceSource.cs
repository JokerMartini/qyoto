//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QIODeviceSource : QDataSource, IDisposable {
 		protected QIODeviceSource(Type dummy) : base((Type) null) {}
		interface IQIODeviceSourceProxy {
		}

		protected void CreateQIODeviceSourceProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QIODeviceSource), this);
			_interceptor = (QIODeviceSource) realProxy.GetTransparentProxy();
		}
		private QIODeviceSource ProxyQIODeviceSource() {
			return (QIODeviceSource) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QIODeviceSource() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQIODeviceSourceProxy), null);
			_staticInterceptor = (IQIODeviceSourceProxy) realProxy.GetTransparentProxy();
		}
		private static IQIODeviceSourceProxy StaticQIODeviceSource() {
			return (IQIODeviceSourceProxy) _staticInterceptor;
		}

		public QIODeviceSource(IQIODevice arg1, int bufsize) : this((Type) null) {
			CreateQIODeviceSourceProxy();
			NewQIODeviceSource(arg1,bufsize);
		}
		[SmokeMethod("QIODeviceSource(QIODevice*, int)")]
		private void NewQIODeviceSource(IQIODevice arg1, int bufsize) {
			ProxyQIODeviceSource().NewQIODeviceSource(arg1,bufsize);
		}
		public QIODeviceSource(IQIODevice arg1) : this((Type) null) {
			CreateQIODeviceSourceProxy();
			NewQIODeviceSource(arg1);
		}
		[SmokeMethod("QIODeviceSource(QIODevice*)")]
		private void NewQIODeviceSource(IQIODevice arg1) {
			ProxyQIODeviceSource().NewQIODeviceSource(arg1);
		}
		[SmokeMethod("readyToSend()")]
		public new int ReadyToSend() {
			return ProxyQIODeviceSource().ReadyToSend();
		}
		[SmokeMethod("sendTo(QDataSink*, int)")]
		public new void SendTo(QDataSink sink, int n) {
			ProxyQIODeviceSource().SendTo(sink,n);
		}
		[SmokeMethod("rewindable() const")]
		public new bool Rewindable() {
			return ProxyQIODeviceSource().Rewindable();
		}
		[SmokeMethod("enableRewind(bool)")]
		public new void EnableRewind(bool on) {
			ProxyQIODeviceSource().EnableRewind(on);
		}
		[SmokeMethod("rewind()")]
		public new void Rewind() {
			ProxyQIODeviceSource().Rewind();
		}
		~QIODeviceSource() {
			DisposeQIODeviceSource();
		}
		public new void Dispose() {
			DisposeQIODeviceSource();
		}
		private void DisposeQIODeviceSource() {
			ProxyQIODeviceSource().DisposeQIODeviceSource();
		}
	}
}
