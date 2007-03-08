//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QTextEncoder")]
	public class QTextEncoder : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QTextEncoder(Type dummy) {}
		[SmokeClass("QTextEncoder")]
		interface IQTextEncoderProxy {
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextEncoder), this);
			_interceptor = (QTextEncoder) realProxy.GetTransparentProxy();
		}
		private QTextEncoder ProxyQTextEncoder() {
			return (QTextEncoder) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextEncoder() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextEncoderProxy), null);
			_staticInterceptor = (IQTextEncoderProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextEncoderProxy StaticQTextEncoder() {
			return (IQTextEncoderProxy) _staticInterceptor;
		}
		public QTextEncoder(QTextCodec codec) : this((Type) null) {
			CreateProxy();
			NewQTextEncoder(codec);
		}
		[SmokeMethod("QTextEncoder", "(const QTextCodec*)", "#")]
		private void NewQTextEncoder(QTextCodec codec) {
			ProxyQTextEncoder().NewQTextEncoder(codec);
		}
		[SmokeMethod("fromUnicode", "(const QString&)", "$")]
		public QByteArray FromUnicode(string str) {
			return ProxyQTextEncoder().FromUnicode(str);
		}
		[SmokeMethod("fromUnicode", "(const QChar*, int)", "#$")]
		public QByteArray FromUnicode(char uc, int len) {
			return ProxyQTextEncoder().FromUnicode(uc,len);
		}
		~QTextEncoder() {
			DisposeQTextEncoder();
		}
		public void Dispose() {
			DisposeQTextEncoder();
		}
		[SmokeMethod("~QTextEncoder", "()", "")]
		private void DisposeQTextEncoder() {
			ProxyQTextEncoder().DisposeQTextEncoder();
		}
	}
}
