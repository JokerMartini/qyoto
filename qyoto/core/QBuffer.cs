//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QBuffer")]
	public class QBuffer : QIODevice, IDisposable {
 		protected QBuffer(Type dummy) : base((Type) null) {}
		[SmokeClass("QBuffer")]
		interface IQBufferProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QBuffer), this);
			_interceptor = (QBuffer) realProxy.GetTransparentProxy();
		}
		private QBuffer ProxyQBuffer() {
			return (QBuffer) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QBuffer() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQBufferProxy), null);
			_staticInterceptor = (IQBufferProxy) realProxy.GetTransparentProxy();
		}
		private static IQBufferProxy StaticQBuffer() {
			return (IQBufferProxy) _staticInterceptor;
		}
		public QBuffer(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQBuffer(parent);
		}
		[SmokeMethod("QBuffer", "(QObject*)", "#")]
		private void NewQBuffer(QObject parent) {
			ProxyQBuffer().NewQBuffer(parent);
		}
		public QBuffer() : this((Type) null) {
			CreateProxy();
			NewQBuffer();
		}
		[SmokeMethod("QBuffer", "()", "")]
		private void NewQBuffer() {
			ProxyQBuffer().NewQBuffer();
		}
		public QBuffer(QByteArray buf, QObject parent) : this((Type) null) {
			CreateProxy();
			NewQBuffer(buf,parent);
		}
		[SmokeMethod("QBuffer", "(QByteArray*, QObject*)", "##")]
		private void NewQBuffer(QByteArray buf, QObject parent) {
			ProxyQBuffer().NewQBuffer(buf,parent);
		}
		public QBuffer(QByteArray buf) : this((Type) null) {
			CreateProxy();
			NewQBuffer(buf);
		}
		[SmokeMethod("QBuffer", "(QByteArray*)", "#")]
		private void NewQBuffer(QByteArray buf) {
			ProxyQBuffer().NewQBuffer(buf);
		}
		[SmokeMethod("buffer", "()", "")]
		public QByteArray Buffer() {
			return ProxyQBuffer().Buffer();
		}
		[SmokeMethod("setBuffer", "(QByteArray*)", "#")]
		public void SetBuffer(QByteArray a) {
			ProxyQBuffer().SetBuffer(a);
		}
		[SmokeMethod("setData", "(const QByteArray&)", "#")]
		public void SetData(QByteArray data) {
			ProxyQBuffer().SetData(data);
		}
		[SmokeMethod("setData", "(const char*, int)", "$$")]
		public void SetData(string data, int len) {
			ProxyQBuffer().SetData(data,len);
		}
		[SmokeMethod("data", "() const", "")]
		public QByteArray Data() {
			return ProxyQBuffer().Data();
		}
		[SmokeMethod("open", "(OpenMode)", "$")]
		public override bool Open(int openMode) {
			return ProxyQBuffer().Open(openMode);
		}
		[SmokeMethod("close", "()", "")]
		public override void Close() {
			ProxyQBuffer().Close();
		}
		[SmokeMethod("size", "() const", "")]
		public override long Size() {
			return ProxyQBuffer().Size();
		}
		[SmokeMethod("pos", "() const", "")]
		public override long Pos() {
			return ProxyQBuffer().Pos();
		}
		[SmokeMethod("seek", "(qint64)", "$")]
		public override bool Seek(long off) {
			return ProxyQBuffer().Seek(off);
		}
		[SmokeMethod("atEnd", "() const", "")]
		public override bool AtEnd() {
			return ProxyQBuffer().AtEnd();
		}
		[SmokeMethod("canReadLine", "() const", "")]
		public override bool CanReadLine() {
			return ProxyQBuffer().CanReadLine();
		}
		public static string Tr(string s, string c) {
			return StaticQBuffer().Tr(s,c);
		}
		public static string Tr(string s) {
			return StaticQBuffer().Tr(s);
		}
		[SmokeMethod("readData", "(char*, qint64)", "$$")]
		protected override long ReadData(string data, long maxlen) {
			return ProxyQBuffer().ReadData(data,maxlen);
		}
		[SmokeMethod("writeData", "(const char*, qint64)", "$$")]
		protected override long WriteData(string data, long len) {
			return ProxyQBuffer().WriteData(data,len);
		}
		~QBuffer() {
			DisposeQBuffer();
		}
		public new void Dispose() {
			DisposeQBuffer();
		}
		[SmokeMethod("~QBuffer", "()", "")]
		private void DisposeQBuffer() {
			ProxyQBuffer().DisposeQBuffer();
		}
		protected new IQBufferSignals Emit {
			get { return (IQBufferSignals) Q_EMIT; }
		}
	}

	public interface IQBufferSignals : IQIODeviceSignals {
	}
}
