//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	[SmokeClass("QFileOpenEvent")]
	public class QFileOpenEvent : QEvent, IDisposable {
 		protected QFileOpenEvent(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QFileOpenEvent), this);
		}
		public QFileOpenEvent(string file) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFileOpenEvent$", "QFileOpenEvent(const QString&)", typeof(void), typeof(string), file);
		}
		public string File() {
			return (string) interceptor.Invoke("file", "file() const", typeof(string));
		}
		~QFileOpenEvent() {
			interceptor.Invoke("~QFileOpenEvent", "~QFileOpenEvent()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QFileOpenEvent", "~QFileOpenEvent()", typeof(void));
		}
	}
}
