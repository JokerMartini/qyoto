//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QToolBarChangeEvent")]
	public class QToolBarChangeEvent : QEvent, IDisposable {
 		protected QToolBarChangeEvent(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QToolBarChangeEvent), this);
		}
		public QToolBarChangeEvent(bool t) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QToolBarChangeEvent$", "QToolBarChangeEvent(bool)", typeof(void), typeof(bool), t);
		}
		public bool Toggle() {
			return (bool) interceptor.Invoke("toggle", "toggle() const", typeof(bool));
		}
		~QToolBarChangeEvent() {
			interceptor.Invoke("~QToolBarChangeEvent", "~QToolBarChangeEvent()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QToolBarChangeEvent", "~QToolBarChangeEvent()", typeof(void));
		}
	}
}
