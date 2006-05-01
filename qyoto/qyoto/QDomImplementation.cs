//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QDomImplementation")]
	public class QDomImplementation : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QDomImplementation(Type dummy) {}
		interface IQDomImplementationProxy {
			bool op_equals(QDomImplementation lhs, QDomImplementation arg1);
			QDomImplementation.InvalidDataPolicy invalidDataPolicy();
			void SetInvalidDataPolicy(QDomImplementation.InvalidDataPolicy policy);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDomImplementation), this);
			_interceptor = (QDomImplementation) realProxy.GetTransparentProxy();
		}
		private QDomImplementation ProxyQDomImplementation() {
			return (QDomImplementation) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDomImplementation() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDomImplementationProxy), null);
			_staticInterceptor = (IQDomImplementationProxy) realProxy.GetTransparentProxy();
		}
		private static IQDomImplementationProxy StaticQDomImplementation() {
			return (IQDomImplementationProxy) _staticInterceptor;
		}

		public enum InvalidDataPolicy {
			AcceptInvalidChars = 0,
			DropInvalidChars = 1,
			ReturnNullNode = 2,
		}
		public QDomImplementation() : this((Type) null) {
			CreateProxy();
			NewQDomImplementation();
		}
		[SmokeMethod("QDomImplementation()")]
		private void NewQDomImplementation() {
			ProxyQDomImplementation().NewQDomImplementation();
		}
		public QDomImplementation(QDomImplementation arg1) : this((Type) null) {
			CreateProxy();
			NewQDomImplementation(arg1);
		}
		[SmokeMethod("QDomImplementation(const QDomImplementation&)")]
		private void NewQDomImplementation(QDomImplementation arg1) {
			ProxyQDomImplementation().NewQDomImplementation(arg1);
		}
		[SmokeMethod("operator==(const QDomImplementation&) const")]
		public static bool operator==(QDomImplementation lhs, QDomImplementation arg1) {
			return StaticQDomImplementation().op_equals(lhs,arg1);
		}
		public static bool operator!=(QDomImplementation lhs, QDomImplementation arg1) {
			return !StaticQDomImplementation().op_equals(lhs,arg1);
		}
		public override bool Equals(object o) {
			if (!(o is QDomImplementation)) { return false; }
			return this == (QDomImplementation) o;
		}
		public override int GetHashCode() {
			return ProxyQDomImplementation().GetHashCode();
		}
		[SmokeMethod("hasFeature(const QString&, const QString&) const")]
		public bool HasFeature(string feature, string version) {
			return ProxyQDomImplementation().HasFeature(feature,version);
		}
		[SmokeMethod("createDocumentType(const QString&, const QString&, const QString&)")]
		public QDomDocumentType CreateDocumentType(string qName, string publicId, string systemId) {
			return ProxyQDomImplementation().CreateDocumentType(qName,publicId,systemId);
		}
		[SmokeMethod("createDocument(const QString&, const QString&, const QDomDocumentType&)")]
		public QDomDocument CreateDocument(string nsURI, string qName, QDomDocumentType doctype) {
			return ProxyQDomImplementation().CreateDocument(nsURI,qName,doctype);
		}
		[SmokeMethod("isNull()")]
		public bool IsNull() {
			return ProxyQDomImplementation().IsNull();
		}
		[SmokeMethod("invalidDataPolicy()")]
		public static QDomImplementation.InvalidDataPolicy invalidDataPolicy() {
			return StaticQDomImplementation().invalidDataPolicy();
		}
		[SmokeMethod("setInvalidDataPolicy(QDomImplementation::InvalidDataPolicy)")]
		public static void SetInvalidDataPolicy(QDomImplementation.InvalidDataPolicy policy) {
			StaticQDomImplementation().SetInvalidDataPolicy(policy);
		}
		~QDomImplementation() {
			DisposeQDomImplementation();
		}
		public void Dispose() {
			DisposeQDomImplementation();
		}
		private void DisposeQDomImplementation() {
			ProxyQDomImplementation().DisposeQDomImplementation();
		}
	}
}
