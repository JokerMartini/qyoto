//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QStyleOptionMenuItem")]
	public class QStyleOptionMenuItem : QStyleOption, IDisposable {
 		protected QStyleOptionMenuItem(Type dummy) : base((Type) null) {}
		[SmokeClass("QStyleOptionMenuItem")]
		interface IQStyleOptionMenuItemProxy {
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStyleOptionMenuItem), this);
			_interceptor = (QStyleOptionMenuItem) realProxy.GetTransparentProxy();
		}
		private QStyleOptionMenuItem ProxyQStyleOptionMenuItem() {
			return (QStyleOptionMenuItem) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStyleOptionMenuItem() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStyleOptionMenuItemProxy), null);
			_staticInterceptor = (IQStyleOptionMenuItemProxy) realProxy.GetTransparentProxy();
		}
		private static IQStyleOptionMenuItemProxy StaticQStyleOptionMenuItem() {
			return (IQStyleOptionMenuItemProxy) _staticInterceptor;
		}
		public enum StyleOptionType {
			Type = QStyleOption.OptionType.SO_MenuItem,
		}
		public enum StyleOptionVersion {
			Version = 1,
		}
		public enum MenuItemType {
			Normal = 0,
			DefaultItem = 1,
			Separator = 2,
			SubMenu = 3,
			Scroller = 4,
			TearOff = 5,
			Margin = 6,
			EmptyArea = 7,
		}
		public enum CheckType {
			NotCheckable = 0,
			Exclusive = 1,
			NonExclusive = 2,
		}
		public QStyleOptionMenuItem() : this((Type) null) {
			CreateProxy();
			NewQStyleOptionMenuItem();
		}
		[SmokeMethod("QStyleOptionMenuItem", "()", "")]
		private void NewQStyleOptionMenuItem() {
			ProxyQStyleOptionMenuItem().NewQStyleOptionMenuItem();
		}
		public QStyleOptionMenuItem(QStyleOptionMenuItem other) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionMenuItem(other);
		}
		[SmokeMethod("QStyleOptionMenuItem", "(const QStyleOptionMenuItem&)", "#")]
		private void NewQStyleOptionMenuItem(QStyleOptionMenuItem other) {
			ProxyQStyleOptionMenuItem().NewQStyleOptionMenuItem(other);
		}
		public QStyleOptionMenuItem(int version) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionMenuItem(version);
		}
		[SmokeMethod("QStyleOptionMenuItem", "(int)", "$")]
		private void NewQStyleOptionMenuItem(int version) {
			ProxyQStyleOptionMenuItem().NewQStyleOptionMenuItem(version);
		}
		~QStyleOptionMenuItem() {
			DisposeQStyleOptionMenuItem();
		}
		public void Dispose() {
			DisposeQStyleOptionMenuItem();
		}
		[SmokeMethod("~QStyleOptionMenuItem", "()", "")]
		private void DisposeQStyleOptionMenuItem() {
			ProxyQStyleOptionMenuItem().DisposeQStyleOptionMenuItem();
		}
	}
}
