//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QDomComment")]
	public class QDomComment : QDomCharacterData, IDisposable {
 		protected QDomComment(Type dummy) : base((Type) null) {}
		interface IQDomCommentProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDomComment), this);
			_interceptor = (QDomComment) realProxy.GetTransparentProxy();
		}
		private QDomComment ProxyQDomComment() {
			return (QDomComment) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDomComment() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDomCommentProxy), null);
			_staticInterceptor = (IQDomCommentProxy) realProxy.GetTransparentProxy();
		}
		private static IQDomCommentProxy StaticQDomComment() {
			return (IQDomCommentProxy) _staticInterceptor;
		}

		public QDomComment() : this((Type) null) {
			CreateProxy();
			NewQDomComment();
		}
		[SmokeMethod("QDomComment()")]
		private void NewQDomComment() {
			ProxyQDomComment().NewQDomComment();
		}
		public QDomComment(QDomComment x) : this((Type) null) {
			CreateProxy();
			NewQDomComment(x);
		}
		[SmokeMethod("QDomComment(const QDomComment&)")]
		private void NewQDomComment(QDomComment x) {
			ProxyQDomComment().NewQDomComment(x);
		}
		[SmokeMethod("nodeType() const")]
		public new QDomNode.NodeType NodeType() {
			return ProxyQDomComment().NodeType();
		}
		~QDomComment() {
			DisposeQDomComment();
		}
		public void Dispose() {
			DisposeQDomComment();
		}
		private void DisposeQDomComment() {
			ProxyQDomComment().DisposeQDomComment();
		}
	}
}
