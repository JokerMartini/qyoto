//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QBig5Codec : QTextCodec, IDisposable {
 		protected QBig5Codec(Type dummy) : base((Type) null) {}
		interface IQBig5CodecProxy {
		}

		protected void CreateQBig5CodecProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QBig5Codec), this);
			_interceptor = (QBig5Codec) realProxy.GetTransparentProxy();
		}
		private QBig5Codec ProxyQBig5Codec() {
			return (QBig5Codec) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QBig5Codec() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQBig5CodecProxy), null);
			_staticInterceptor = (IQBig5CodecProxy) realProxy.GetTransparentProxy();
		}
		private static IQBig5CodecProxy StaticQBig5Codec() {
			return (IQBig5CodecProxy) _staticInterceptor;
		}

		[SmokeMethod("mibEnum() const")]
		public new virtual int MibEnum() {
			return ProxyQBig5Codec().MibEnum();
		}
		[SmokeMethod("name() const")]
		public new string Name() {
			return ProxyQBig5Codec().Name();
		}
		[SmokeMethod("makeDecoder() const")]
		public new QTextDecoder MakeDecoder() {
			return ProxyQBig5Codec().MakeDecoder();
		}
		[SmokeMethod("fromUnicode(const QString&, int&) const")]
		public new string FromUnicode(string uc, out int lenInOut) {
			return ProxyQBig5Codec().FromUnicode(uc,out lenInOut);
		}
		[SmokeMethod("toUnicode(const char*, int) const")]
		public new string ToUnicode(string chars, int len) {
			return ProxyQBig5Codec().ToUnicode(chars,len);
		}
		[SmokeMethod("heuristicContentMatch(const char*, int) const")]
		public new int HeuristicContentMatch(string chars, int len) {
			return ProxyQBig5Codec().HeuristicContentMatch(chars,len);
		}
		[SmokeMethod("heuristicNameMatch(const char*) const")]
		public new int HeuristicNameMatch(string hint) {
			return ProxyQBig5Codec().HeuristicNameMatch(hint);
		}
		public QBig5Codec() : this((Type) null) {
			CreateQBig5CodecProxy();
			NewQBig5Codec();
		}
		[SmokeMethod("QBig5Codec()")]
		private void NewQBig5Codec() {
			ProxyQBig5Codec().NewQBig5Codec();
		}
		~QBig5Codec() {
			DisposeQBig5Codec();
		}
		public new void Dispose() {
			DisposeQBig5Codec();
		}
		private void DisposeQBig5Codec() {
			ProxyQBig5Codec().DisposeQBig5Codec();
		}
	}
}
