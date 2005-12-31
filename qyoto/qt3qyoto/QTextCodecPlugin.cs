//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Collections;
	using System.Text;

	public class QTextCodecPlugin : QGPlugin {
 		protected QTextCodecPlugin(Type dummy) : base((Type) null) {}
		interface IQTextCodecPluginProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQTextCodecPluginProxy() {
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

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQTextCodecPlugin().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQTextCodecPlugin().ClassName();
		}
		[SmokeMethod("names() const")]
		public virtual ArrayList Names() {
			return ProxyQTextCodecPlugin().Names();
		}
		[SmokeMethod("createForName(const QString&)")]
		public virtual QTextCodec CreateForName(string name) {
			return ProxyQTextCodecPlugin().CreateForName(name);
		}
		[SmokeMethod("mibEnums() const")]
		public virtual int[] MibEnums() {
			return ProxyQTextCodecPlugin().MibEnums();
		}
		[SmokeMethod("createForMib(int)")]
		public virtual QTextCodec CreateForMib(int mib) {
			return ProxyQTextCodecPlugin().CreateForMib(mib);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQTextCodecPlugin().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQTextCodecPlugin().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQTextCodecPlugin().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQTextCodecPlugin().TrUtf8(arg1);
		}
		protected void CreateQTextCodecPluginSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQTextCodecPluginSignals), this);
			_signalInterceptor = (IQTextCodecPluginSignals) realProxy.GetTransparentProxy();
		}
		protected new IQTextCodecPluginSignals Emit() {
			return (IQTextCodecPluginSignals) _signalInterceptor;
		}
	}

	public interface IQTextCodecPluginSignals : IQGPluginSignals {
	}
}
