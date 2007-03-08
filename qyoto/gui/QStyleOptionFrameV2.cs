//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QStyleOptionFrameV2")]
	public class QStyleOptionFrameV2 : QStyleOptionFrame, IDisposable {
 		protected QStyleOptionFrameV2(Type dummy) : base((Type) null) {}
		[SmokeClass("QStyleOptionFrameV2")]
		interface IQStyleOptionFrameV2Proxy {
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStyleOptionFrameV2), this);
			_interceptor = (QStyleOptionFrameV2) realProxy.GetTransparentProxy();
		}
		private QStyleOptionFrameV2 ProxyQStyleOptionFrameV2() {
			return (QStyleOptionFrameV2) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStyleOptionFrameV2() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStyleOptionFrameV2Proxy), null);
			_staticInterceptor = (IQStyleOptionFrameV2Proxy) realProxy.GetTransparentProxy();
		}
		private static IQStyleOptionFrameV2Proxy StaticQStyleOptionFrameV2() {
			return (IQStyleOptionFrameV2Proxy) _staticInterceptor;
		}
		public enum StyleOptionVersion {
			Version = 2,
		}
		public enum FrameFeature {
			None = 0x00,
			Flat = 0x01,
		}
		public QStyleOptionFrameV2() : this((Type) null) {
			CreateProxy();
			NewQStyleOptionFrameV2();
		}
		[SmokeMethod("QStyleOptionFrameV2", "()", "")]
		private void NewQStyleOptionFrameV2() {
			ProxyQStyleOptionFrameV2().NewQStyleOptionFrameV2();
		}
		public QStyleOptionFrameV2(QStyleOptionFrameV2 other) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionFrameV2(other);
		}
		[SmokeMethod("QStyleOptionFrameV2", "(const QStyleOptionFrameV2&)", "#")]
		private void NewQStyleOptionFrameV2(QStyleOptionFrameV2 other) {
			ProxyQStyleOptionFrameV2().NewQStyleOptionFrameV2(other);
		}
		public QStyleOptionFrameV2(QStyleOptionFrame other) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionFrameV2(other);
		}
		[SmokeMethod("QStyleOptionFrameV2", "(const QStyleOptionFrame&)", "#")]
		private void NewQStyleOptionFrameV2(QStyleOptionFrame other) {
			ProxyQStyleOptionFrameV2().NewQStyleOptionFrameV2(other);
		}
		public QStyleOptionFrameV2(int version) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionFrameV2(version);
		}
		[SmokeMethod("QStyleOptionFrameV2", "(int)", "$")]
		private void NewQStyleOptionFrameV2(int version) {
			ProxyQStyleOptionFrameV2().NewQStyleOptionFrameV2(version);
		}
		~QStyleOptionFrameV2() {
			DisposeQStyleOptionFrameV2();
		}
		public void Dispose() {
			DisposeQStyleOptionFrameV2();
		}
		[SmokeMethod("~QStyleOptionFrameV2", "()", "")]
		private void DisposeQStyleOptionFrameV2() {
			ProxyQStyleOptionFrameV2().DisposeQStyleOptionFrameV2();
		}
	}
}
