//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QTextCodecPlugin")]
	public class QTextCodecPlugin : QObject {
 		protected QTextCodecPlugin(Type dummy) : base((Type) null) {}
		interface IQTextCodecPluginProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextCodecPlugin), this);
			_interceptor = (QTextCodecPlugin) realProxy.GetTransparentProxy();
		}
		private QTextCodecPlugin ProxyQTextCodecPlugin() {
			return (QTextCodecPlugin) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextCodecPlugin() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextCodecPluginProxy), null);
			_staticInterceptor = (IQTextCodecPluginProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextCodecPluginProxy StaticQTextCodecPlugin() {
			return (IQTextCodecPluginProxy) _staticInterceptor;
		}

		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQTextCodecPlugin().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQTextCodecPlugin().Tr(s);
		}
		protected new IQTextCodecPluginSignals Emit() {
			return (IQTextCodecPluginSignals) Q_EMIT;
		}
	}

	public interface IQTextCodecPluginSignals : IQObjectSignals {
	}
}
