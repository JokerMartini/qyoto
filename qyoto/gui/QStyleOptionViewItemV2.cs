//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	[SmokeClass("QStyleOptionViewItemV2")]
	public class QStyleOptionViewItemV2 : QStyleOptionViewItem, IDisposable {
 		protected QStyleOptionViewItemV2(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QStyleOptionViewItemV2), this);
		}
		public enum StyleOptionVersion {
			Version = 2,
		}
		public enum ViewItemFeature {
			None = 0x00,
			WrapText = 0x01,
			Alternate = 0x02,
			HasCheckIndicator = 0x04,
			HasDisplay = 0x08,
			HasDecoration = 0x10,
		}
		public QStyleOptionViewItemV2() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QStyleOptionViewItemV2", "QStyleOptionViewItemV2()", typeof(void));
		}
		public QStyleOptionViewItemV2(QStyleOptionViewItemV2 other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QStyleOptionViewItemV2#", "QStyleOptionViewItemV2(const QStyleOptionViewItemV2&)", typeof(void), typeof(QStyleOptionViewItemV2), other);
		}
		public QStyleOptionViewItemV2(QStyleOptionViewItem other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QStyleOptionViewItemV2#", "QStyleOptionViewItemV2(const QStyleOptionViewItem&)", typeof(void), typeof(QStyleOptionViewItem), other);
		}
		public QStyleOptionViewItemV2(int version) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QStyleOptionViewItemV2$", "QStyleOptionViewItemV2(int)", typeof(void), typeof(int), version);
		}
		~QStyleOptionViewItemV2() {
			interceptor.Invoke("~QStyleOptionViewItemV2", "~QStyleOptionViewItemV2()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QStyleOptionViewItemV2", "~QStyleOptionViewItemV2()", typeof(void));
		}
	}
}
