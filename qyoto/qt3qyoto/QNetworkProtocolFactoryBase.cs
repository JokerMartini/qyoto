//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QNetworkProtocolFactoryBase : MarshalByRefObject {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QNetworkProtocolFactoryBase(Type dummy) {}
		interface IQNetworkProtocolFactoryBaseProxy {
		}

		protected void CreateQNetworkProtocolFactoryBaseProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QNetworkProtocolFactoryBase), this);
			_interceptor = (QNetworkProtocolFactoryBase) realProxy.GetTransparentProxy();
		}
		private QNetworkProtocolFactoryBase ProxyQNetworkProtocolFactoryBase() {
			return (QNetworkProtocolFactoryBase) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QNetworkProtocolFactoryBase() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQNetworkProtocolFactoryBaseProxy), null);
			_staticInterceptor = (IQNetworkProtocolFactoryBaseProxy) realProxy.GetTransparentProxy();
		}
		private static IQNetworkProtocolFactoryBaseProxy StaticQNetworkProtocolFactoryBase() {
			return (IQNetworkProtocolFactoryBaseProxy) _staticInterceptor;
		}

		[SmokeMethod("createObject()")]
		public virtual QNetworkProtocol CreateObject() {
			return ProxyQNetworkProtocolFactoryBase().CreateObject();
		}
		// QNetworkProtocolFactoryBase* QNetworkProtocolFactoryBase(); >>>> NOT CONVERTED
	}
}
