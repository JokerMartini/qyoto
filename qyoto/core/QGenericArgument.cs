//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QGenericArgument")]
	public class QGenericArgument : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QGenericArgument(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QGenericArgument), this);
		}
		// QGenericArgument* QGenericArgument(const char* arg1,const void* arg2); >>>> NOT CONVERTED
		// void* data(); >>>> NOT CONVERTED
		public QGenericArgument(string aName) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGenericArgument$", "QGenericArgument(const char*)", typeof(void), typeof(string), aName);
		}
		public QGenericArgument() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QGenericArgument", "QGenericArgument()", typeof(void));
		}
		public string Name() {
			return (string) interceptor.Invoke("name", "name() const", typeof(string));
		}
		~QGenericArgument() {
			interceptor.Invoke("~QGenericArgument", "~QGenericArgument()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QGenericArgument", "~QGenericArgument()", typeof(void));
		}
	}
}
