//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	[SmokeClass("QStyleOptionFrame")]
	public class QStyleOptionFrame : QStyleOption, IDisposable {
 		protected QStyleOptionFrame(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QStyleOptionFrame), this);
		}
		public enum StyleOptionType {
			Type = QStyleOption.OptionType.SO_Frame,
		}
		public enum StyleOptionVersion {
			Version = 1,
		}
		public QStyleOptionFrame() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QStyleOptionFrame", "QStyleOptionFrame()", typeof(void));
		}
		public QStyleOptionFrame(QStyleOptionFrame other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QStyleOptionFrame#", "QStyleOptionFrame(const QStyleOptionFrame&)", typeof(void), typeof(QStyleOptionFrame), other);
		}
		public QStyleOptionFrame(int version) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QStyleOptionFrame$", "QStyleOptionFrame(int)", typeof(void), typeof(int), version);
		}
		~QStyleOptionFrame() {
			interceptor.Invoke("~QStyleOptionFrame", "~QStyleOptionFrame()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QStyleOptionFrame", "~QStyleOptionFrame()", typeof(void));
		}
	}
}
