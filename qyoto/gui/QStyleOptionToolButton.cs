//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QStyleOptionToolButton")]
	public class QStyleOptionToolButton : QStyleOptionComplex, IDisposable {
 		protected QStyleOptionToolButton(Type dummy) : base((Type) null) {}
		[SmokeClass("QStyleOptionToolButton")]
		interface IQStyleOptionToolButtonProxy {
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStyleOptionToolButton), this);
			_interceptor = (QStyleOptionToolButton) realProxy.GetTransparentProxy();
		}
		private QStyleOptionToolButton ProxyQStyleOptionToolButton() {
			return (QStyleOptionToolButton) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStyleOptionToolButton() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStyleOptionToolButtonProxy), null);
			_staticInterceptor = (IQStyleOptionToolButtonProxy) realProxy.GetTransparentProxy();
		}
		private static IQStyleOptionToolButtonProxy StaticQStyleOptionToolButton() {
			return (IQStyleOptionToolButtonProxy) _staticInterceptor;
		}
		public enum StyleOptionType {
			Type = QStyleOption.OptionType.SO_ToolButton,
		}
		public enum StyleOptionVersion {
			Version = 1,
		}
		public enum ToolButtonFeature {
			None = 0x00,
			Arrow = 0x01,
			Menu = 0x04,
			PopupDelay = 0x08,
		}
		public QStyleOptionToolButton() : this((Type) null) {
			CreateProxy();
			NewQStyleOptionToolButton();
		}
		[SmokeMethod("QStyleOptionToolButton", "()", "")]
		private void NewQStyleOptionToolButton() {
			ProxyQStyleOptionToolButton().NewQStyleOptionToolButton();
		}
		public QStyleOptionToolButton(QStyleOptionToolButton other) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionToolButton(other);
		}
		[SmokeMethod("QStyleOptionToolButton", "(const QStyleOptionToolButton&)", "#")]
		private void NewQStyleOptionToolButton(QStyleOptionToolButton other) {
			ProxyQStyleOptionToolButton().NewQStyleOptionToolButton(other);
		}
		public QStyleOptionToolButton(int version) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionToolButton(version);
		}
		[SmokeMethod("QStyleOptionToolButton", "(int)", "$")]
		private void NewQStyleOptionToolButton(int version) {
			ProxyQStyleOptionToolButton().NewQStyleOptionToolButton(version);
		}
		~QStyleOptionToolButton() {
			DisposeQStyleOptionToolButton();
		}
		public void Dispose() {
			DisposeQStyleOptionToolButton();
		}
		[SmokeMethod("~QStyleOptionToolButton", "()", "")]
		private void DisposeQStyleOptionToolButton() {
			ProxyQStyleOptionToolButton().DisposeQStyleOptionToolButton();
		}
	}
}
