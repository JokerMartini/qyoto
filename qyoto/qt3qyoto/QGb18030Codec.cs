//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QGb18030Codec : QTextCodec, IDisposable {
 		protected QGb18030Codec(Type dummy) : base((Type) null) {}
		interface IQGb18030CodecProxy {
		}

		protected void CreateQGb18030CodecProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGb18030Codec), this);
			_interceptor = (QGb18030Codec) realProxy.GetTransparentProxy();
		}
		private QGb18030Codec ProxyQGb18030Codec() {
			return (QGb18030Codec) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGb18030Codec() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGb18030CodecProxy), null);
			_staticInterceptor = (IQGb18030CodecProxy) realProxy.GetTransparentProxy();
		}
		private static IQGb18030CodecProxy StaticQGb18030Codec() {
			return (IQGb18030CodecProxy) _staticInterceptor;
		}

		public QGb18030Codec() : this((Type) null) {
			CreateQGb18030CodecProxy();
			NewQGb18030Codec();
		}
		[SmokeMethod("QGb18030Codec()")]
		private void NewQGb18030Codec() {
			ProxyQGb18030Codec().NewQGb18030Codec();
		}
		[SmokeMethod("mibEnum() const")]
		public new int MibEnum() {
			return ProxyQGb18030Codec().MibEnum();
		}
		[SmokeMethod("name() const")]
		public new string Name() {
			return ProxyQGb18030Codec().Name();
		}
		[SmokeMethod("makeDecoder() const")]
		public new QTextDecoder MakeDecoder() {
			return ProxyQGb18030Codec().MakeDecoder();
		}
		[SmokeMethod("fromUnicode(const QString&, int&) const")]
		public new string FromUnicode(string uc, out int lenInOut) {
			return ProxyQGb18030Codec().FromUnicode(uc,out lenInOut);
		}
		[SmokeMethod("toUnicode(const char*, int) const")]
		public new string ToUnicode(string chars, int len) {
			return ProxyQGb18030Codec().ToUnicode(chars,len);
		}
		[SmokeMethod("heuristicContentMatch(const char*, int) const")]
		public new int HeuristicContentMatch(string chars, int len) {
			return ProxyQGb18030Codec().HeuristicContentMatch(chars,len);
		}
		[SmokeMethod("heuristicNameMatch(const char*) const")]
		public new int HeuristicNameMatch(string hint) {
			return ProxyQGb18030Codec().HeuristicNameMatch(hint);
		}
		~QGb18030Codec() {
			DisposeQGb18030Codec();
		}
		public new void Dispose() {
			DisposeQGb18030Codec();
		}
		private void DisposeQGb18030Codec() {
			ProxyQGb18030Codec().DisposeQGb18030Codec();
		}
	}
}
