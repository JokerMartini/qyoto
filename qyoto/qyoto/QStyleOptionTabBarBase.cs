//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QStyleOptionTabBarBase")]
	public class QStyleOptionTabBarBase : QStyleOption, IDisposable {
 		protected QStyleOptionTabBarBase(Type dummy) : base((Type) null) {}
		interface IQStyleOptionTabBarBaseProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStyleOptionTabBarBase), this);
			_interceptor = (QStyleOptionTabBarBase) realProxy.GetTransparentProxy();
		}
		private QStyleOptionTabBarBase ProxyQStyleOptionTabBarBase() {
			return (QStyleOptionTabBarBase) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStyleOptionTabBarBase() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStyleOptionTabBarBaseProxy), null);
			_staticInterceptor = (IQStyleOptionTabBarBaseProxy) realProxy.GetTransparentProxy();
		}
		private static IQStyleOptionTabBarBaseProxy StaticQStyleOptionTabBarBase() {
			return (IQStyleOptionTabBarBaseProxy) _staticInterceptor;
		}

		public const int Type = (int) QStyleOption.OptionType.SO_TabBarBase;

		public const int Version = 1;

		public QStyleOptionTabBarBase() : this((Type) null) {
			CreateProxy();
			NewQStyleOptionTabBarBase();
		}
		[SmokeMethod("QStyleOptionTabBarBase()")]
		private void NewQStyleOptionTabBarBase() {
			ProxyQStyleOptionTabBarBase().NewQStyleOptionTabBarBase();
		}
		public QStyleOptionTabBarBase(QStyleOptionTabBarBase other) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionTabBarBase(other);
		}
		[SmokeMethod("QStyleOptionTabBarBase(const QStyleOptionTabBarBase&)")]
		private void NewQStyleOptionTabBarBase(QStyleOptionTabBarBase other) {
			ProxyQStyleOptionTabBarBase().NewQStyleOptionTabBarBase(other);
		}
		public QStyleOptionTabBarBase(int version) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionTabBarBase(version);
		}
		[SmokeMethod("QStyleOptionTabBarBase(int)")]
		private void NewQStyleOptionTabBarBase(int version) {
			ProxyQStyleOptionTabBarBase().NewQStyleOptionTabBarBase(version);
		}
		~QStyleOptionTabBarBase() {
			DisposeQStyleOptionTabBarBase();
		}
		public void Dispose() {
			DisposeQStyleOptionTabBarBase();
		}
		private void DisposeQStyleOptionTabBarBase() {
			ProxyQStyleOptionTabBarBase().DisposeQStyleOptionTabBarBase();
		}
	}
}
