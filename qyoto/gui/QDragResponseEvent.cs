//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QDragResponseEvent")]
	public class QDragResponseEvent : QEvent, IDisposable {
 		protected QDragResponseEvent(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QDragResponseEvent), this);
		}
		public QDragResponseEvent(bool accepted) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDragResponseEvent$", "QDragResponseEvent(bool)", typeof(void), typeof(bool), accepted);
		}
		public bool DragAccepted() {
			return (bool) interceptor.Invoke("dragAccepted", "dragAccepted() const", typeof(bool));
		}
		~QDragResponseEvent() {
			interceptor.Invoke("~QDragResponseEvent", "~QDragResponseEvent()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QDragResponseEvent", "~QDragResponseEvent()", typeof(void));
		}
	}
}
