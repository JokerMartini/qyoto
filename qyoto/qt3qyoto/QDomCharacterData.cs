//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QDomCharacterData : QDomNode, IDisposable {
 		protected QDomCharacterData(Type dummy) : base((Type) null) {}
		interface IQDomCharacterDataProxy {
		}

		protected void CreateQDomCharacterDataProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDomCharacterData), this);
			_interceptor = (QDomCharacterData) realProxy.GetTransparentProxy();
		}
		private QDomCharacterData ProxyQDomCharacterData() {
			return (QDomCharacterData) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDomCharacterData() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDomCharacterDataProxy), null);
			_staticInterceptor = (IQDomCharacterDataProxy) realProxy.GetTransparentProxy();
		}
		private static IQDomCharacterDataProxy StaticQDomCharacterData() {
			return (IQDomCharacterDataProxy) _staticInterceptor;
		}

		public QDomCharacterData() : this((Type) null) {
			CreateQDomCharacterDataProxy();
			NewQDomCharacterData();
		}
		[SmokeMethod("QDomCharacterData()")]
		private void NewQDomCharacterData() {
			ProxyQDomCharacterData().NewQDomCharacterData();
		}
		public QDomCharacterData(QDomCharacterData x) : this((Type) null) {
			CreateQDomCharacterDataProxy();
			NewQDomCharacterData(x);
		}
		[SmokeMethod("QDomCharacterData(const QDomCharacterData&)")]
		private void NewQDomCharacterData(QDomCharacterData x) {
			ProxyQDomCharacterData().NewQDomCharacterData(x);
		}
		[SmokeMethod("substringData(unsigned long, unsigned long)")]
		public virtual string SubstringData(ulong offset, ulong count) {
			return ProxyQDomCharacterData().SubstringData(offset,count);
		}
		[SmokeMethod("appendData(const QString&)")]
		public virtual void AppendData(string arg) {
			ProxyQDomCharacterData().AppendData(arg);
		}
		[SmokeMethod("insertData(unsigned long, const QString&)")]
		public virtual void InsertData(ulong offset, string arg) {
			ProxyQDomCharacterData().InsertData(offset,arg);
		}
		[SmokeMethod("deleteData(unsigned long, unsigned long)")]
		public virtual void DeleteData(ulong offset, ulong count) {
			ProxyQDomCharacterData().DeleteData(offset,count);
		}
		[SmokeMethod("replaceData(unsigned long, unsigned long, const QString&)")]
		public virtual void ReplaceData(ulong offset, ulong count, string arg) {
			ProxyQDomCharacterData().ReplaceData(offset,count,arg);
		}
		[SmokeMethod("length() const")]
		public virtual uint Length() {
			return ProxyQDomCharacterData().Length();
		}
		[SmokeMethod("data() const")]
		public virtual string Data() {
			return ProxyQDomCharacterData().Data();
		}
		[SmokeMethod("setData(const QString&)")]
		public virtual void SetData(string arg1) {
			ProxyQDomCharacterData().SetData(arg1);
		}
		[SmokeMethod("nodeType() const")]
		public new int NodeType() {
			return ProxyQDomCharacterData().NodeType();
		}
		[SmokeMethod("isCharacterData() const")]
		public new bool IsCharacterData() {
			return ProxyQDomCharacterData().IsCharacterData();
		}
		~QDomCharacterData() {
			DisposeQDomCharacterData();
		}
		public new void Dispose() {
			DisposeQDomCharacterData();
		}
		private void DisposeQDomCharacterData() {
			ProxyQDomCharacterData().DisposeQDomCharacterData();
		}
	}
}
