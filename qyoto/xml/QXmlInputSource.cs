//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QXmlInputSource")]
	public class QXmlInputSource : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QXmlInputSource(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QXmlInputSource), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QXmlInputSource() {
			staticInterceptor = new SmokeInvocation(typeof(QXmlInputSource), null);
		}
		public static ushort EndOfData() {
			return (ushort) staticInterceptor.Invoke("EndOfData", "EndOfData()", typeof(ushort));
		}
		public static ushort EndOfDocument() {
			return (ushort) staticInterceptor.Invoke("EndOfDocument", "EndOfDocument()", typeof(ushort));
		}
		public QXmlInputSource() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QXmlInputSource", "QXmlInputSource()", typeof(void));
		}
		public QXmlInputSource(QIODevice dev) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QXmlInputSource#", "QXmlInputSource(QIODevice*)", typeof(void), typeof(QIODevice), dev);
		}
		[SmokeMethod("setData(const QString&)")]
		public virtual void SetData(string dat) {
			interceptor.Invoke("setData$", "setData(const QString&)", typeof(void), typeof(string), dat);
		}
		[SmokeMethod("setData(const QByteArray&)")]
		public virtual void SetData(QByteArray dat) {
			interceptor.Invoke("setData#", "setData(const QByteArray&)", typeof(void), typeof(QByteArray), dat);
		}
		[SmokeMethod("fetchData()")]
		public virtual void FetchData() {
			interceptor.Invoke("fetchData", "fetchData()", typeof(void));
		}
		[SmokeMethod("data() const")]
		public virtual string Data() {
			return (string) interceptor.Invoke("data", "data() const", typeof(string));
		}
		[SmokeMethod("next()")]
		public virtual char Next() {
			return (char) interceptor.Invoke("next", "next()", typeof(char));
		}
		[SmokeMethod("reset()")]
		public virtual void Reset() {
			interceptor.Invoke("reset", "reset()", typeof(void));
		}
		[SmokeMethod("fromRawData(const QByteArray&, bool)")]
		protected virtual string FromRawData(QByteArray data, bool beginning) {
			return (string) interceptor.Invoke("fromRawData#$", "fromRawData(const QByteArray&, bool)", typeof(string), typeof(QByteArray), data, typeof(bool), beginning);
		}
		[SmokeMethod("fromRawData(const QByteArray&)")]
		protected virtual string FromRawData(QByteArray data) {
			return (string) interceptor.Invoke("fromRawData#", "fromRawData(const QByteArray&)", typeof(string), typeof(QByteArray), data);
		}
		~QXmlInputSource() {
			interceptor.Invoke("~QXmlInputSource", "~QXmlInputSource()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QXmlInputSource", "~QXmlInputSource()", typeof(void));
		}
	}
}
