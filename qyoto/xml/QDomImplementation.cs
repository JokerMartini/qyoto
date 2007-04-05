//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QDomImplementation")]
	public class QDomImplementation : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QDomImplementation(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QDomImplementation), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QDomImplementation() {
			staticInterceptor = new SmokeInvocation(typeof(QDomImplementation), null);
		}
		public enum InvalidDataPolicy {
			AcceptInvalidChars = 0,
			DropInvalidChars = 1,
			ReturnNullNode = 2,
		}
		public QDomImplementation() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDomImplementation", "QDomImplementation()", typeof(void));
		}
		public QDomImplementation(QDomImplementation arg1) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDomImplementation#", "QDomImplementation(const QDomImplementation&)", typeof(void), typeof(QDomImplementation), arg1);
		}
		public override bool Equals(object o) {
			if (!(o is QDomImplementation)) { return false; }
			return this == (QDomImplementation) o;
		}
		public override int GetHashCode() {
			return interceptor.GetHashCode();
		}
		public bool HasFeature(string feature, string version) {
			return (bool) interceptor.Invoke("hasFeature$$", "hasFeature(const QString&, const QString&) const", typeof(bool), typeof(string), feature, typeof(string), version);
		}
		public QDomDocumentType CreateDocumentType(string qName, string publicId, string systemId) {
			return (QDomDocumentType) interceptor.Invoke("createDocumentType$$$", "createDocumentType(const QString&, const QString&, const QString&)", typeof(QDomDocumentType), typeof(string), qName, typeof(string), publicId, typeof(string), systemId);
		}
		public QDomDocument CreateDocument(string nsURI, string qName, QDomDocumentType doctype) {
			return (QDomDocument) interceptor.Invoke("createDocument$$#", "createDocument(const QString&, const QString&, const QDomDocumentType&)", typeof(QDomDocument), typeof(string), nsURI, typeof(string), qName, typeof(QDomDocumentType), doctype);
		}
		public bool IsNull() {
			return (bool) interceptor.Invoke("isNull", "isNull()", typeof(bool));
		}
		~QDomImplementation() {
			interceptor.Invoke("~QDomImplementation", "~QDomImplementation()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QDomImplementation", "~QDomImplementation()", typeof(void));
		}
		public static bool operator==(QDomImplementation lhs, QDomImplementation arg1) {
			return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QDomImplementation&) const", typeof(bool), typeof(QDomImplementation), lhs, typeof(QDomImplementation), arg1);
		}
		public static bool operator!=(QDomImplementation lhs, QDomImplementation arg1) {
			return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QDomImplementation&) const", typeof(bool), typeof(QDomImplementation), lhs, typeof(QDomImplementation), arg1);
		}
		public static QDomImplementation.InvalidDataPolicy invalidDataPolicy() {
			return (QDomImplementation.InvalidDataPolicy) staticInterceptor.Invoke("invalidDataPolicy", "invalidDataPolicy()", typeof(QDomImplementation.InvalidDataPolicy));
		}
		public static void SetInvalidDataPolicy(QDomImplementation.InvalidDataPolicy policy) {
			staticInterceptor.Invoke("setInvalidDataPolicy$", "setInvalidDataPolicy(QDomImplementation::InvalidDataPolicy)", typeof(void), typeof(QDomImplementation.InvalidDataPolicy), policy);
		}
	}
}
