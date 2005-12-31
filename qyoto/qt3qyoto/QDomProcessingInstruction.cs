//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QDomProcessingInstruction : QDomNode, IDisposable {
 		protected QDomProcessingInstruction(Type dummy) : base((Type) null) {}
		interface IQDomProcessingInstructionProxy {
		}

		protected void CreateQDomProcessingInstructionProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDomProcessingInstruction), this);
			_interceptor = (QDomProcessingInstruction) realProxy.GetTransparentProxy();
		}
		private QDomProcessingInstruction ProxyQDomProcessingInstruction() {
			return (QDomProcessingInstruction) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDomProcessingInstruction() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDomProcessingInstructionProxy), null);
			_staticInterceptor = (IQDomProcessingInstructionProxy) realProxy.GetTransparentProxy();
		}
		private static IQDomProcessingInstructionProxy StaticQDomProcessingInstruction() {
			return (IQDomProcessingInstructionProxy) _staticInterceptor;
		}

		public QDomProcessingInstruction() : this((Type) null) {
			CreateQDomProcessingInstructionProxy();
			NewQDomProcessingInstruction();
		}
		[SmokeMethod("QDomProcessingInstruction()")]
		private void NewQDomProcessingInstruction() {
			ProxyQDomProcessingInstruction().NewQDomProcessingInstruction();
		}
		public QDomProcessingInstruction(QDomProcessingInstruction x) : this((Type) null) {
			CreateQDomProcessingInstructionProxy();
			NewQDomProcessingInstruction(x);
		}
		[SmokeMethod("QDomProcessingInstruction(const QDomProcessingInstruction&)")]
		private void NewQDomProcessingInstruction(QDomProcessingInstruction x) {
			ProxyQDomProcessingInstruction().NewQDomProcessingInstruction(x);
		}
		[SmokeMethod("target() const")]
		public virtual string Target() {
			return ProxyQDomProcessingInstruction().Target();
		}
		[SmokeMethod("data() const")]
		public virtual string Data() {
			return ProxyQDomProcessingInstruction().Data();
		}
		[SmokeMethod("setData(const QString&)")]
		public virtual void SetData(string d) {
			ProxyQDomProcessingInstruction().SetData(d);
		}
		[SmokeMethod("nodeType() const")]
		public new int NodeType() {
			return ProxyQDomProcessingInstruction().NodeType();
		}
		[SmokeMethod("isProcessingInstruction() const")]
		public new bool IsProcessingInstruction() {
			return ProxyQDomProcessingInstruction().IsProcessingInstruction();
		}
		~QDomProcessingInstruction() {
			DisposeQDomProcessingInstruction();
		}
		public new void Dispose() {
			DisposeQDomProcessingInstruction();
		}
		private void DisposeQDomProcessingInstruction() {
			ProxyQDomProcessingInstruction().DisposeQDomProcessingInstruction();
		}
	}
}
