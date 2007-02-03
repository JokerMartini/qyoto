//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QStyleOptionProgressBarV2")]
	public class QStyleOptionProgressBarV2 : QStyleOptionProgressBar, IDisposable {
 		protected QStyleOptionProgressBarV2(Type dummy) : base((Type) null) {}
		[SmokeClass("QStyleOptionProgressBarV2")]
		interface IQStyleOptionProgressBarV2Proxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStyleOptionProgressBarV2), this);
			_interceptor = (QStyleOptionProgressBarV2) realProxy.GetTransparentProxy();
		}
		private QStyleOptionProgressBarV2 ProxyQStyleOptionProgressBarV2() {
			return (QStyleOptionProgressBarV2) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStyleOptionProgressBarV2() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStyleOptionProgressBarV2Proxy), null);
			_staticInterceptor = (IQStyleOptionProgressBarV2Proxy) realProxy.GetTransparentProxy();
		}
		private static IQStyleOptionProgressBarV2Proxy StaticQStyleOptionProgressBarV2() {
			return (IQStyleOptionProgressBarV2Proxy) _staticInterceptor;
		}

		public enum StyleOptionType {
			Type = QStyleOption.OptionType.SO_ProgressBar,
		}
		public enum StyleOptionVersion {
			Version = 2,
		}
		public QStyleOptionProgressBarV2() : this((Type) null) {
			CreateProxy();
			NewQStyleOptionProgressBarV2();
		}
		[SmokeMethod("QStyleOptionProgressBarV2", "()", "")]
		private void NewQStyleOptionProgressBarV2() {
			ProxyQStyleOptionProgressBarV2().NewQStyleOptionProgressBarV2();
		}
		public QStyleOptionProgressBarV2(QStyleOptionProgressBar other) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionProgressBarV2(other);
		}
		[SmokeMethod("QStyleOptionProgressBarV2", "(const QStyleOptionProgressBar&)", "#")]
		private void NewQStyleOptionProgressBarV2(QStyleOptionProgressBar other) {
			ProxyQStyleOptionProgressBarV2().NewQStyleOptionProgressBarV2(other);
		}
		public QStyleOptionProgressBarV2(QStyleOptionProgressBarV2 other) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionProgressBarV2(other);
		}
		[SmokeMethod("QStyleOptionProgressBarV2", "(const QStyleOptionProgressBarV2&)", "#")]
		private void NewQStyleOptionProgressBarV2(QStyleOptionProgressBarV2 other) {
			ProxyQStyleOptionProgressBarV2().NewQStyleOptionProgressBarV2(other);
		}
		public QStyleOptionProgressBarV2(int version) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionProgressBarV2(version);
		}
		[SmokeMethod("QStyleOptionProgressBarV2", "(int)", "$")]
		private void NewQStyleOptionProgressBarV2(int version) {
			ProxyQStyleOptionProgressBarV2().NewQStyleOptionProgressBarV2(version);
		}
		~QStyleOptionProgressBarV2() {
			DisposeQStyleOptionProgressBarV2();
		}
		public void Dispose() {
			DisposeQStyleOptionProgressBarV2();
		}
		[SmokeMethod("~QStyleOptionProgressBarV2", "()", "")]
		private void DisposeQStyleOptionProgressBarV2() {
			ProxyQStyleOptionProgressBarV2().DisposeQStyleOptionProgressBarV2();
		}
	}
}
