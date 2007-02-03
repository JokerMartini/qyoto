//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QStyleOptionRubberBand")]
	public class QStyleOptionRubberBand : QStyleOption, IDisposable {
 		protected QStyleOptionRubberBand(Type dummy) : base((Type) null) {}
		[SmokeClass("QStyleOptionRubberBand")]
		interface IQStyleOptionRubberBandProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStyleOptionRubberBand), this);
			_interceptor = (QStyleOptionRubberBand) realProxy.GetTransparentProxy();
		}
		private QStyleOptionRubberBand ProxyQStyleOptionRubberBand() {
			return (QStyleOptionRubberBand) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStyleOptionRubberBand() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStyleOptionRubberBandProxy), null);
			_staticInterceptor = (IQStyleOptionRubberBandProxy) realProxy.GetTransparentProxy();
		}
		private static IQStyleOptionRubberBandProxy StaticQStyleOptionRubberBand() {
			return (IQStyleOptionRubberBandProxy) _staticInterceptor;
		}

		public enum StyleOptionType {
			Type = QStyleOption.OptionType.SO_RubberBand,
		}
		public enum StyleOptionVersion {
			Version = 1,
		}
		public QStyleOptionRubberBand() : this((Type) null) {
			CreateProxy();
			NewQStyleOptionRubberBand();
		}
		[SmokeMethod("QStyleOptionRubberBand", "()", "")]
		private void NewQStyleOptionRubberBand() {
			ProxyQStyleOptionRubberBand().NewQStyleOptionRubberBand();
		}
		public QStyleOptionRubberBand(QStyleOptionRubberBand other) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionRubberBand(other);
		}
		[SmokeMethod("QStyleOptionRubberBand", "(const QStyleOptionRubberBand&)", "#")]
		private void NewQStyleOptionRubberBand(QStyleOptionRubberBand other) {
			ProxyQStyleOptionRubberBand().NewQStyleOptionRubberBand(other);
		}
		public QStyleOptionRubberBand(int version) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionRubberBand(version);
		}
		[SmokeMethod("QStyleOptionRubberBand", "(int)", "$")]
		private void NewQStyleOptionRubberBand(int version) {
			ProxyQStyleOptionRubberBand().NewQStyleOptionRubberBand(version);
		}
		~QStyleOptionRubberBand() {
			DisposeQStyleOptionRubberBand();
		}
		public void Dispose() {
			DisposeQStyleOptionRubberBand();
		}
		[SmokeMethod("~QStyleOptionRubberBand", "()", "")]
		private void DisposeQStyleOptionRubberBand() {
			ProxyQStyleOptionRubberBand().DisposeQStyleOptionRubberBand();
		}
	}
}
