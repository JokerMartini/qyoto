//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QStyleHintReturnMask")]
	public class QStyleHintReturnMask : QStyleHintReturn, IDisposable {
 		protected QStyleHintReturnMask(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QStyleHintReturnMask), this);
		}
		public enum StyleOptionType {
			Type = QStyleHintReturn.HintReturnType.SH_Mask,
		}
		public enum StyleOptionVersion {
			Version = 1,
		}
		public QStyleHintReturnMask() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QStyleHintReturnMask", "QStyleHintReturnMask()", typeof(void));
		}
		~QStyleHintReturnMask() {
			interceptor.Invoke("~QStyleHintReturnMask", "~QStyleHintReturnMask()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QStyleHintReturnMask", "~QStyleHintReturnMask()", typeof(void));
		}
	}
}
