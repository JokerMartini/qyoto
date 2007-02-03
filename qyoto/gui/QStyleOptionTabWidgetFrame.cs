//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QStyleOptionTabWidgetFrame")]
	public class QStyleOptionTabWidgetFrame : QStyleOption, IDisposable {
 		protected QStyleOptionTabWidgetFrame(Type dummy) : base((Type) null) {}
		[SmokeClass("QStyleOptionTabWidgetFrame")]
		interface IQStyleOptionTabWidgetFrameProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStyleOptionTabWidgetFrame), this);
			_interceptor = (QStyleOptionTabWidgetFrame) realProxy.GetTransparentProxy();
		}
		private QStyleOptionTabWidgetFrame ProxyQStyleOptionTabWidgetFrame() {
			return (QStyleOptionTabWidgetFrame) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStyleOptionTabWidgetFrame() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStyleOptionTabWidgetFrameProxy), null);
			_staticInterceptor = (IQStyleOptionTabWidgetFrameProxy) realProxy.GetTransparentProxy();
		}
		private static IQStyleOptionTabWidgetFrameProxy StaticQStyleOptionTabWidgetFrame() {
			return (IQStyleOptionTabWidgetFrameProxy) _staticInterceptor;
		}

		public enum StyleOptionType {
			Type = QStyleOption.OptionType.SO_TabWidgetFrame,
		}
		public enum StyleOptionVersion {
			Version = 1,
		}
		public QStyleOptionTabWidgetFrame() : this((Type) null) {
			CreateProxy();
			NewQStyleOptionTabWidgetFrame();
		}
		[SmokeMethod("QStyleOptionTabWidgetFrame", "()", "")]
		private void NewQStyleOptionTabWidgetFrame() {
			ProxyQStyleOptionTabWidgetFrame().NewQStyleOptionTabWidgetFrame();
		}
		public QStyleOptionTabWidgetFrame(QStyleOptionTabWidgetFrame other) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionTabWidgetFrame(other);
		}
		[SmokeMethod("QStyleOptionTabWidgetFrame", "(const QStyleOptionTabWidgetFrame&)", "#")]
		private void NewQStyleOptionTabWidgetFrame(QStyleOptionTabWidgetFrame other) {
			ProxyQStyleOptionTabWidgetFrame().NewQStyleOptionTabWidgetFrame(other);
		}
		public QStyleOptionTabWidgetFrame(int version) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionTabWidgetFrame(version);
		}
		[SmokeMethod("QStyleOptionTabWidgetFrame", "(int)", "$")]
		private void NewQStyleOptionTabWidgetFrame(int version) {
			ProxyQStyleOptionTabWidgetFrame().NewQStyleOptionTabWidgetFrame(version);
		}
		~QStyleOptionTabWidgetFrame() {
			DisposeQStyleOptionTabWidgetFrame();
		}
		public void Dispose() {
			DisposeQStyleOptionTabWidgetFrame();
		}
		[SmokeMethod("~QStyleOptionTabWidgetFrame", "()", "")]
		private void DisposeQStyleOptionTabWidgetFrame() {
			ProxyQStyleOptionTabWidgetFrame().DisposeQStyleOptionTabWidgetFrame();
		}
	}
}
