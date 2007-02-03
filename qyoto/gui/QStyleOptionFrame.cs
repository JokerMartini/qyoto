//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QStyleOptionFrame")]
	public class QStyleOptionFrame : QStyleOption, IDisposable {
 		protected QStyleOptionFrame(Type dummy) : base((Type) null) {}
		[SmokeClass("QStyleOptionFrame")]
		interface IQStyleOptionFrameProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStyleOptionFrame), this);
			_interceptor = (QStyleOptionFrame) realProxy.GetTransparentProxy();
		}
		private QStyleOptionFrame ProxyQStyleOptionFrame() {
			return (QStyleOptionFrame) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStyleOptionFrame() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStyleOptionFrameProxy), null);
			_staticInterceptor = (IQStyleOptionFrameProxy) realProxy.GetTransparentProxy();
		}
		private static IQStyleOptionFrameProxy StaticQStyleOptionFrame() {
			return (IQStyleOptionFrameProxy) _staticInterceptor;
		}

		public enum StyleOptionType {
			Type = QStyleOption.OptionType.SO_Frame,
		}
		public enum StyleOptionVersion {
			Version = 1,
		}
		public QStyleOptionFrame() : this((Type) null) {
			CreateProxy();
			NewQStyleOptionFrame();
		}
		[SmokeMethod("QStyleOptionFrame", "()", "")]
		private void NewQStyleOptionFrame() {
			ProxyQStyleOptionFrame().NewQStyleOptionFrame();
		}
		public QStyleOptionFrame(QStyleOptionFrame other) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionFrame(other);
		}
		[SmokeMethod("QStyleOptionFrame", "(const QStyleOptionFrame&)", "#")]
		private void NewQStyleOptionFrame(QStyleOptionFrame other) {
			ProxyQStyleOptionFrame().NewQStyleOptionFrame(other);
		}
		public QStyleOptionFrame(int version) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionFrame(version);
		}
		[SmokeMethod("QStyleOptionFrame", "(int)", "$")]
		private void NewQStyleOptionFrame(int version) {
			ProxyQStyleOptionFrame().NewQStyleOptionFrame(version);
		}
		~QStyleOptionFrame() {
			DisposeQStyleOptionFrame();
		}
		public void Dispose() {
			DisposeQStyleOptionFrame();
		}
		[SmokeMethod("~QStyleOptionFrame", "()", "")]
		private void DisposeQStyleOptionFrame() {
			ProxyQStyleOptionFrame().DisposeQStyleOptionFrame();
		}
	}
}
