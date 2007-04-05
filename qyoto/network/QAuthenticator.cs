//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QAuthenticator")]
	public class QAuthenticator : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QAuthenticator(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QAuthenticator), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QAuthenticator() {
			staticInterceptor = new SmokeInvocation(typeof(QAuthenticator), null);
		}
		public QAuthenticator() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QAuthenticator", "QAuthenticator()", typeof(void));
		}
		public QAuthenticator(QAuthenticator other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QAuthenticator#", "QAuthenticator(const QAuthenticator&)", typeof(void), typeof(QAuthenticator), other);
		}
		public override bool Equals(object o) {
			if (!(o is QAuthenticator)) { return false; }
			return this == (QAuthenticator) o;
		}
		public override int GetHashCode() {
			return interceptor.GetHashCode();
		}
		public string User() {
			return (string) interceptor.Invoke("user", "user() const", typeof(string));
		}
		public void SetUser(string user) {
			interceptor.Invoke("setUser$", "setUser(const QString&)", typeof(void), typeof(string), user);
		}
		public string Password() {
			return (string) interceptor.Invoke("password", "password() const", typeof(string));
		}
		public void SetPassword(string password) {
			interceptor.Invoke("setPassword$", "setPassword(const QString&)", typeof(void), typeof(string), password);
		}
		public string Realm() {
			return (string) interceptor.Invoke("realm", "realm() const", typeof(string));
		}
		public bool IsNull() {
			return (bool) interceptor.Invoke("isNull", "isNull() const", typeof(bool));
		}
		public void Detach() {
			interceptor.Invoke("detach", "detach()", typeof(void));
		}
		~QAuthenticator() {
			interceptor.Invoke("~QAuthenticator", "~QAuthenticator()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QAuthenticator", "~QAuthenticator()", typeof(void));
		}
		public static bool operator==(QAuthenticator lhs, QAuthenticator other) {
			return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QAuthenticator&) const", typeof(bool), typeof(QAuthenticator), lhs, typeof(QAuthenticator), other);
		}
		public static bool operator!=(QAuthenticator lhs, QAuthenticator other) {
			return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QAuthenticator&) const", typeof(bool), typeof(QAuthenticator), lhs, typeof(QAuthenticator), other);
		}
	}
}
