//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QXmlLocator")]
	public class QXmlLocator : MarshalByRefObject {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QXmlLocator(Type dummy) {}
		[SmokeClass("QXmlLocator")]
		interface IQXmlLocatorProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QXmlLocator), this);
			_interceptor = (QXmlLocator) realProxy.GetTransparentProxy();
		}
		private QXmlLocator ProxyQXmlLocator() {
			return (QXmlLocator) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QXmlLocator() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQXmlLocatorProxy), null);
			_staticInterceptor = (IQXmlLocatorProxy) realProxy.GetTransparentProxy();
		}
		private static IQXmlLocatorProxy StaticQXmlLocator() {
			return (IQXmlLocatorProxy) _staticInterceptor;
		}

		public QXmlLocator() : this((Type) null) {
			CreateProxy();
			NewQXmlLocator();
		}
		[SmokeMethod("QXmlLocator", "()", "")]
		private void NewQXmlLocator() {
			ProxyQXmlLocator().NewQXmlLocator();
		}
		[SmokeMethod("columnNumber", "() const", "")]
		public virtual int ColumnNumber() {
			return ProxyQXmlLocator().ColumnNumber();
		}
		[SmokeMethod("lineNumber", "() const", "")]
		public virtual int LineNumber() {
			return ProxyQXmlLocator().LineNumber();
		}
		~QXmlLocator() {
			DisposeQXmlLocator();
		}
		public void Dispose() {
			DisposeQXmlLocator();
		}
		[SmokeMethod("~QXmlLocator", "()", "")]
		private void DisposeQXmlLocator() {
			ProxyQXmlLocator().DisposeQXmlLocator();
		}
	}
}
