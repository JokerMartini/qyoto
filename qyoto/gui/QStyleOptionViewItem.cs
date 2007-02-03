//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QStyleOptionViewItem")]
	public class QStyleOptionViewItem : QStyleOption, IDisposable {
 		protected QStyleOptionViewItem(Type dummy) : base((Type) null) {}
		[SmokeClass("QStyleOptionViewItem")]
		interface IQStyleOptionViewItemProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStyleOptionViewItem), this);
			_interceptor = (QStyleOptionViewItem) realProxy.GetTransparentProxy();
		}
		private QStyleOptionViewItem ProxyQStyleOptionViewItem() {
			return (QStyleOptionViewItem) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStyleOptionViewItem() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStyleOptionViewItemProxy), null);
			_staticInterceptor = (IQStyleOptionViewItemProxy) realProxy.GetTransparentProxy();
		}
		private static IQStyleOptionViewItemProxy StaticQStyleOptionViewItem() {
			return (IQStyleOptionViewItemProxy) _staticInterceptor;
		}

		public enum StyleOptionType {
			Type = QStyleOption.OptionType.SO_ViewItem,
		}
		public enum StyleOptionVersion {
			Version = 1,
		}
		public enum Position {
			Left = 0,
			Right = 1,
			Top = 2,
			Bottom = 3,
		}
		public QStyleOptionViewItem() : this((Type) null) {
			CreateProxy();
			NewQStyleOptionViewItem();
		}
		[SmokeMethod("QStyleOptionViewItem", "()", "")]
		private void NewQStyleOptionViewItem() {
			ProxyQStyleOptionViewItem().NewQStyleOptionViewItem();
		}
		public QStyleOptionViewItem(QStyleOptionViewItem other) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionViewItem(other);
		}
		[SmokeMethod("QStyleOptionViewItem", "(const QStyleOptionViewItem&)", "#")]
		private void NewQStyleOptionViewItem(QStyleOptionViewItem other) {
			ProxyQStyleOptionViewItem().NewQStyleOptionViewItem(other);
		}
		public QStyleOptionViewItem(int version) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionViewItem(version);
		}
		[SmokeMethod("QStyleOptionViewItem", "(int)", "$")]
		private void NewQStyleOptionViewItem(int version) {
			ProxyQStyleOptionViewItem().NewQStyleOptionViewItem(version);
		}
		~QStyleOptionViewItem() {
			DisposeQStyleOptionViewItem();
		}
		public void Dispose() {
			DisposeQStyleOptionViewItem();
		}
		[SmokeMethod("~QStyleOptionViewItem", "()", "")]
		private void DisposeQStyleOptionViewItem() {
			ProxyQStyleOptionViewItem().DisposeQStyleOptionViewItem();
		}
	}
}
