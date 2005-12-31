//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QResizeEvent : QEvent, IDisposable {
 		protected QResizeEvent(Type dummy) : base((Type) null) {}
		interface IQResizeEventProxy {
		}

		protected void CreateQResizeEventProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QResizeEvent), this);
			_interceptor = (QResizeEvent) realProxy.GetTransparentProxy();
		}
		private QResizeEvent ProxyQResizeEvent() {
			return (QResizeEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QResizeEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQResizeEventProxy), null);
			_staticInterceptor = (IQResizeEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQResizeEventProxy StaticQResizeEvent() {
			return (IQResizeEventProxy) _staticInterceptor;
		}

		public QResizeEvent(QSize size, QSize oldSize) : this((Type) null) {
			CreateQResizeEventProxy();
			NewQResizeEvent(size,oldSize);
		}
		[SmokeMethod("QResizeEvent(const QSize&, const QSize&)")]
		private void NewQResizeEvent(QSize size, QSize oldSize) {
			ProxyQResizeEvent().NewQResizeEvent(size,oldSize);
		}
		[SmokeMethod("size() const")]
		public QSize Size() {
			return ProxyQResizeEvent().Size();
		}
		[SmokeMethod("oldSize() const")]
		public QSize OldSize() {
			return ProxyQResizeEvent().OldSize();
		}
		~QResizeEvent() {
			DisposeQResizeEvent();
		}
		public new void Dispose() {
			DisposeQResizeEvent();
		}
		private void DisposeQResizeEvent() {
			ProxyQResizeEvent().DisposeQResizeEvent();
		}
	}
}
