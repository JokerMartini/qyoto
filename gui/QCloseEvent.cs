//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QCloseEvent")]
    public class QCloseEvent : QEvent, IDisposable {
        protected QCloseEvent(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QCloseEvent), this);
        }
        public QCloseEvent() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QCloseEvent", "QCloseEvent()", typeof(void));
        }
        ~QCloseEvent() {
            interceptor.Invoke("~QCloseEvent", "~QCloseEvent()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QCloseEvent", "~QCloseEvent()", typeof(void));
        }
    }
}
