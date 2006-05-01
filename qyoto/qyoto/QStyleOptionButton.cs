//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QStyleOptionButton")]
	public class QStyleOptionButton : QStyleOption, IDisposable {
 		protected QStyleOptionButton(Type dummy) : base((Type) null) {}
		interface IQStyleOptionButtonProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStyleOptionButton), this);
			_interceptor = (QStyleOptionButton) realProxy.GetTransparentProxy();
		}
		private QStyleOptionButton ProxyQStyleOptionButton() {
			return (QStyleOptionButton) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStyleOptionButton() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStyleOptionButtonProxy), null);
			_staticInterceptor = (IQStyleOptionButtonProxy) realProxy.GetTransparentProxy();
		}
		private static IQStyleOptionButtonProxy StaticQStyleOptionButton() {
			return (IQStyleOptionButtonProxy) _staticInterceptor;
		}

		public enum ButtonFeature {
			None = 0x00,
			Flat = 0x01,
			HasMenu = 0x02,
			DefaultButton = 0x04,
			AutoDefaultButton = 0x08,
		}
		public const int Type = (int) QStyleOption.OptionType.SO_Button;

		public const int Version = 1;

		public QStyleOptionButton() : this((Type) null) {
			CreateProxy();
			NewQStyleOptionButton();
		}
		[SmokeMethod("QStyleOptionButton()")]
		private void NewQStyleOptionButton() {
			ProxyQStyleOptionButton().NewQStyleOptionButton();
		}
		public QStyleOptionButton(QStyleOptionButton other) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionButton(other);
		}
		[SmokeMethod("QStyleOptionButton(const QStyleOptionButton&)")]
		private void NewQStyleOptionButton(QStyleOptionButton other) {
			ProxyQStyleOptionButton().NewQStyleOptionButton(other);
		}
		public QStyleOptionButton(int version) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionButton(version);
		}
		[SmokeMethod("QStyleOptionButton(int)")]
		private void NewQStyleOptionButton(int version) {
			ProxyQStyleOptionButton().NewQStyleOptionButton(version);
		}
		~QStyleOptionButton() {
			DisposeQStyleOptionButton();
		}
		public void Dispose() {
			DisposeQStyleOptionButton();
		}
		private void DisposeQStyleOptionButton() {
			ProxyQStyleOptionButton().DisposeQStyleOptionButton();
		}
	}
}
