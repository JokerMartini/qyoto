//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QGbkCodec : QGb18030Codec, IDisposable {
 		protected QGbkCodec(Type dummy) : base((Type) null) {}
		interface IQGbkCodecProxy {
		}

		protected void CreateQGbkCodecProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGbkCodec), this);
			_interceptor = (QGbkCodec) realProxy.GetTransparentProxy();
		}
		private QGbkCodec ProxyQGbkCodec() {
			return (QGbkCodec) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGbkCodec() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGbkCodecProxy), null);
			_staticInterceptor = (IQGbkCodecProxy) realProxy.GetTransparentProxy();
		}
		private static IQGbkCodecProxy StaticQGbkCodec() {
			return (IQGbkCodecProxy) _staticInterceptor;
		}

		public QGbkCodec() : this((Type) null) {
			CreateQGbkCodecProxy();
			NewQGbkCodec();
		}
		[SmokeMethod("QGbkCodec()")]
		private void NewQGbkCodec() {
			ProxyQGbkCodec().NewQGbkCodec();
		}
		[SmokeMethod("mibEnum() const")]
		public new int MibEnum() {
			return ProxyQGbkCodec().MibEnum();
		}
		[SmokeMethod("name() const")]
		public new string Name() {
			return ProxyQGbkCodec().Name();
		}
		[SmokeMethod("makeDecoder() const")]
		public new QTextDecoder MakeDecoder() {
			return ProxyQGbkCodec().MakeDecoder();
		}
		[SmokeMethod("fromUnicode(const QString&, int&) const")]
		public new string FromUnicode(string uc, out int lenInOut) {
			return ProxyQGbkCodec().FromUnicode(uc,out lenInOut);
		}
		[SmokeMethod("toUnicode(const char*, int) const")]
		public new string ToUnicode(string chars, int len) {
			return ProxyQGbkCodec().ToUnicode(chars,len);
		}
		[SmokeMethod("heuristicContentMatch(const char*, int) const")]
		public new int HeuristicContentMatch(string chars, int len) {
			return ProxyQGbkCodec().HeuristicContentMatch(chars,len);
		}
		[SmokeMethod("heuristicNameMatch(const char*) const")]
		public new int HeuristicNameMatch(string hint) {
			return ProxyQGbkCodec().HeuristicNameMatch(hint);
		}
		~QGbkCodec() {
			DisposeQGbkCodec();
		}
		public new void Dispose() {
			DisposeQGbkCodec();
		}
		private void DisposeQGbkCodec() {
			ProxyQGbkCodec().DisposeQGbkCodec();
		}
	}
}
