//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QDomEntityReference : QDomNode, IDisposable {
 		protected QDomEntityReference(Type dummy) : base((Type) null) {}
		interface IQDomEntityReferenceProxy {
		}

		protected void CreateQDomEntityReferenceProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDomEntityReference), this);
			_interceptor = (QDomEntityReference) realProxy.GetTransparentProxy();
		}
		private QDomEntityReference ProxyQDomEntityReference() {
			return (QDomEntityReference) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDomEntityReference() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDomEntityReferenceProxy), null);
			_staticInterceptor = (IQDomEntityReferenceProxy) realProxy.GetTransparentProxy();
		}
		private static IQDomEntityReferenceProxy StaticQDomEntityReference() {
			return (IQDomEntityReferenceProxy) _staticInterceptor;
		}

		public QDomEntityReference() : this((Type) null) {
			CreateQDomEntityReferenceProxy();
			NewQDomEntityReference();
		}
		[SmokeMethod("QDomEntityReference()")]
		private void NewQDomEntityReference() {
			ProxyQDomEntityReference().NewQDomEntityReference();
		}
		public QDomEntityReference(QDomEntityReference x) : this((Type) null) {
			CreateQDomEntityReferenceProxy();
			NewQDomEntityReference(x);
		}
		[SmokeMethod("QDomEntityReference(const QDomEntityReference&)")]
		private void NewQDomEntityReference(QDomEntityReference x) {
			ProxyQDomEntityReference().NewQDomEntityReference(x);
		}
		[SmokeMethod("nodeType() const")]
		public new int NodeType() {
			return ProxyQDomEntityReference().NodeType();
		}
		[SmokeMethod("isEntityReference() const")]
		public new bool IsEntityReference() {
			return ProxyQDomEntityReference().IsEntityReference();
		}
		~QDomEntityReference() {
			DisposeQDomEntityReference();
		}
		public new void Dispose() {
			DisposeQDomEntityReference();
		}
		private void DisposeQDomEntityReference() {
			ProxyQDomEntityReference().DisposeQDomEntityReference();
		}
	}
}
