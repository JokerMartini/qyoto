//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QBig5hkscsCodec : QTextCodec, IDisposable {
 		protected QBig5hkscsCodec(Type dummy) : base((Type) null) {}
		interface IQBig5hkscsCodecProxy {
		}

		protected void CreateQBig5hkscsCodecProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QBig5hkscsCodec), this);
			_interceptor = (QBig5hkscsCodec) realProxy.GetTransparentProxy();
		}
		private QBig5hkscsCodec ProxyQBig5hkscsCodec() {
			return (QBig5hkscsCodec) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QBig5hkscsCodec() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQBig5hkscsCodecProxy), null);
			_staticInterceptor = (IQBig5hkscsCodecProxy) realProxy.GetTransparentProxy();
		}
		private static IQBig5hkscsCodecProxy StaticQBig5hkscsCodec() {
			return (IQBig5hkscsCodecProxy) _staticInterceptor;
		}

		[SmokeMethod("mibEnum() const")]
		public new virtual int MibEnum() {
			return ProxyQBig5hkscsCodec().MibEnum();
		}
		[SmokeMethod("name() const")]
		public new string Name() {
			return ProxyQBig5hkscsCodec().Name();
		}
		[SmokeMethod("makeDecoder() const")]
		public new QTextDecoder MakeDecoder() {
			return ProxyQBig5hkscsCodec().MakeDecoder();
		}
		[SmokeMethod("fromUnicode(const QString&, int&) const")]
		public new string FromUnicode(string uc, out int lenInOut) {
			return ProxyQBig5hkscsCodec().FromUnicode(uc,out lenInOut);
		}
		[SmokeMethod("toUnicode(const char*, int) const")]
		public new string ToUnicode(string chars, int len) {
			return ProxyQBig5hkscsCodec().ToUnicode(chars,len);
		}
		[SmokeMethod("heuristicContentMatch(const char*, int) const")]
		public new int HeuristicContentMatch(string chars, int len) {
			return ProxyQBig5hkscsCodec().HeuristicContentMatch(chars,len);
		}
		[SmokeMethod("heuristicNameMatch(const char*) const")]
		public new int HeuristicNameMatch(string hint) {
			return ProxyQBig5hkscsCodec().HeuristicNameMatch(hint);
		}
		public QBig5hkscsCodec() : this((Type) null) {
			CreateQBig5hkscsCodecProxy();
			NewQBig5hkscsCodec();
		}
		[SmokeMethod("QBig5hkscsCodec()")]
		private void NewQBig5hkscsCodec() {
			ProxyQBig5hkscsCodec().NewQBig5hkscsCodec();
		}
		~QBig5hkscsCodec() {
			DisposeQBig5hkscsCodec();
		}
		public new void Dispose() {
			DisposeQBig5hkscsCodec();
		}
		private void DisposeQBig5hkscsCodec() {
			ProxyQBig5hkscsCodec().DisposeQBig5hkscsCodec();
		}
	}
}
