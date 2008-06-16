//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	[SmokeClass("QSslError")]
	public class QSslError : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QSslError(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QSslError), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QSslError() {
			staticInterceptor = new SmokeInvocation(typeof(QSslError), null);
		}
		public enum SslError {
			NoError = 0,
			UnableToGetIssuerCertificate = 1,
			UnableToDecryptCertificateSignature = 2,
			UnableToDecodeIssuerPublicKey = 3,
			CertificateSignatureFailed = 4,
			CertificateNotYetValid = 5,
			CertificateExpired = 6,
			InvalidNotBeforeField = 7,
			InvalidNotAfterField = 8,
			SelfSignedCertificate = 9,
			SelfSignedCertificateInChain = 10,
			UnableToGetLocalIssuerCertificate = 11,
			UnableToVerifyFirstCertificate = 12,
			CertificateRevoked = 13,
			InvalidCaCertificate = 14,
			PathLengthExceeded = 15,
			InvalidPurpose = 16,
			CertificateUntrusted = 17,
			CertificateRejected = 18,
			SubjectIssuerMismatch = 19,
			AuthorityIssuerSerialNumberMismatch = 20,
			NoPeerCertificate = 21,
			HostNameMismatch = 22,
			NoSslSupport = 23,
			UnspecifiedError = -1,
		}
		public QSslError(QSslError.SslError error, QSslCertificate certificate) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSslError$#", "QSslError(QSslError::SslError, const QSslCertificate&)", typeof(void), typeof(QSslError.SslError), error, typeof(QSslCertificate), certificate);
		}
		public QSslError(QSslError.SslError error) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSslError$", "QSslError(QSslError::SslError)", typeof(void), typeof(QSslError.SslError), error);
		}
		public QSslError() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSslError", "QSslError()", typeof(void));
		}
		public QSslError(QSslError other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSslError#", "QSslError(const QSslError&)", typeof(void), typeof(QSslError), other);
		}
		public override bool Equals(object o) {
			if (!(o is QSslError)) { return false; }
			return this == (QSslError) o;
		}
		public override int GetHashCode() {
			return interceptor.GetHashCode();
		}
		public QSslError.SslError Error() {
			return (QSslError.SslError) interceptor.Invoke("error", "error() const", typeof(QSslError.SslError));
		}
		public string ErrorString() {
			return (string) interceptor.Invoke("errorString", "errorString() const", typeof(string));
		}
		public QSslCertificate Certificate() {
			return (QSslCertificate) interceptor.Invoke("certificate", "certificate() const", typeof(QSslCertificate));
		}
		~QSslError() {
			interceptor.Invoke("~QSslError", "~QSslError()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QSslError", "~QSslError()", typeof(void));
		}
		public static bool operator==(QSslError lhs, QSslError other) {
			return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QSslError&) const", typeof(bool), typeof(QSslError), lhs, typeof(QSslError), other);
		}
		public static bool operator!=(QSslError lhs, QSslError other) {
			return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QSslError&) const", typeof(bool), typeof(QSslError), lhs, typeof(QSslError), other);
		}
	}
}
