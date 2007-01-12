//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QStyleOptionProgressBar")]
	public class QStyleOptionProgressBar : QStyleOption, IDisposable {
 		protected QStyleOptionProgressBar(Type dummy) : base((Type) null) {}
		interface IQStyleOptionProgressBarProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStyleOptionProgressBar), this);
			_interceptor = (QStyleOptionProgressBar) realProxy.GetTransparentProxy();
		}
		private QStyleOptionProgressBar ProxyQStyleOptionProgressBar() {
			return (QStyleOptionProgressBar) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStyleOptionProgressBar() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStyleOptionProgressBarProxy), null);
			_staticInterceptor = (IQStyleOptionProgressBarProxy) realProxy.GetTransparentProxy();
		}
		private static IQStyleOptionProgressBarProxy StaticQStyleOptionProgressBar() {
			return (IQStyleOptionProgressBarProxy) _staticInterceptor;
		}

		public enum StyleOptionType {
			Type = QStyleOption.OptionType.SO_ProgressBar,
		}
		public enum StyleOptionVersion {
			Version = 1,
		}
		public QStyleOptionProgressBar() : this((Type) null) {
			CreateProxy();
			NewQStyleOptionProgressBar();
		}
		[SmokeMethod("QStyleOptionProgressBar()")]
		private void NewQStyleOptionProgressBar() {
			ProxyQStyleOptionProgressBar().NewQStyleOptionProgressBar();
		}
		public QStyleOptionProgressBar(QStyleOptionProgressBar other) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionProgressBar(other);
		}
		[SmokeMethod("QStyleOptionProgressBar(const QStyleOptionProgressBar&)")]
		private void NewQStyleOptionProgressBar(QStyleOptionProgressBar other) {
			ProxyQStyleOptionProgressBar().NewQStyleOptionProgressBar(other);
		}
		public QStyleOptionProgressBar(int version) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionProgressBar(version);
		}
		[SmokeMethod("QStyleOptionProgressBar(int)")]
		private void NewQStyleOptionProgressBar(int version) {
			ProxyQStyleOptionProgressBar().NewQStyleOptionProgressBar(version);
		}
		~QStyleOptionProgressBar() {
			DisposeQStyleOptionProgressBar();
		}
		public void Dispose() {
			DisposeQStyleOptionProgressBar();
		}
		[SmokeMethod("~QStyleOptionProgressBar()")]
		private void DisposeQStyleOptionProgressBar() {
			ProxyQStyleOptionProgressBar().DisposeQStyleOptionProgressBar();
		}
	}
}