//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QStyleOptionGraphicsItem")]
	public class QStyleOptionGraphicsItem : QStyleOption, IDisposable {
 		protected QStyleOptionGraphicsItem(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QStyleOptionGraphicsItem), this);
		}
		public enum StyleOptionType {
			Type = QStyleOption.OptionType.SO_GraphicsItem,
		}
		public enum StyleOptionVersion {
			Version = 1,
		}
		public QStyleOptionGraphicsItem() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QStyleOptionGraphicsItem", "QStyleOptionGraphicsItem()", typeof(void));
		}
		public QStyleOptionGraphicsItem(QStyleOptionGraphicsItem other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QStyleOptionGraphicsItem#", "QStyleOptionGraphicsItem(const QStyleOptionGraphicsItem&)", typeof(void), typeof(QStyleOptionGraphicsItem), other);
		}
		public QStyleOptionGraphicsItem(int version) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QStyleOptionGraphicsItem$", "QStyleOptionGraphicsItem(int)", typeof(void), typeof(int), version);
		}
		~QStyleOptionGraphicsItem() {
			interceptor.Invoke("~QStyleOptionGraphicsItem", "~QStyleOptionGraphicsItem()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QStyleOptionGraphicsItem", "~QStyleOptionGraphicsItem()", typeof(void));
		}
	}
}
