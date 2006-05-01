//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QSplitterHandle")]
	public class QSplitterHandle : QWidget, IDisposable {
 		protected QSplitterHandle(Type dummy) : base((Type) null) {}
		interface IQSplitterHandleProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSplitterHandle), this);
			_interceptor = (QSplitterHandle) realProxy.GetTransparentProxy();
		}
		private QSplitterHandle ProxyQSplitterHandle() {
			return (QSplitterHandle) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSplitterHandle() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSplitterHandleProxy), null);
			_staticInterceptor = (IQSplitterHandleProxy) realProxy.GetTransparentProxy();
		}
		private static IQSplitterHandleProxy StaticQSplitterHandle() {
			return (IQSplitterHandleProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQSplitterHandle().MetaObject();
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QSplitterHandle(Qt.Orientation o, QSplitter parent) : this((Type) null) {
			CreateProxy();
			NewQSplitterHandle(o,parent);
		}
		[SmokeMethod("QSplitterHandle(Qt::Orientation, QSplitter*)")]
		private void NewQSplitterHandle(Qt.Orientation o, QSplitter parent) {
			ProxyQSplitterHandle().NewQSplitterHandle(o,parent);
		}
		[SmokeMethod("setOrientation(Qt::Orientation)")]
		public void SetOrientation(Qt.Orientation o) {
			ProxyQSplitterHandle().SetOrientation(o);
		}
		[SmokeMethod("orientation() const")]
		public Qt.Orientation Orientation() {
			return ProxyQSplitterHandle().Orientation();
		}
		[SmokeMethod("opaqueResize() const")]
		public bool OpaqueResize() {
			return ProxyQSplitterHandle().OpaqueResize();
		}
		[SmokeMethod("splitter() const")]
		public QSplitter Splitter() {
			return ProxyQSplitterHandle().Splitter();
		}
		[SmokeMethod("sizeHint() const")]
		public new QSize SizeHint() {
			return ProxyQSplitterHandle().SizeHint();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQSplitterHandle().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQSplitterHandle().Tr(s);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected new void PaintEvent(QPaintEvent arg1) {
			ProxyQSplitterHandle().PaintEvent(arg1);
		}
		[SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
		protected new void MouseMoveEvent(QMouseEvent arg1) {
			ProxyQSplitterHandle().MouseMoveEvent(arg1);
		}
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected new void MousePressEvent(QMouseEvent arg1) {
			ProxyQSplitterHandle().MousePressEvent(arg1);
		}
		[SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
		protected new void MouseReleaseEvent(QMouseEvent arg1) {
			ProxyQSplitterHandle().MouseReleaseEvent(arg1);
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent arg1) {
			return ProxyQSplitterHandle().Event(arg1);
		}
		[SmokeMethod("moveSplitter(int)")]
		protected void MoveSplitter(int p) {
			ProxyQSplitterHandle().MoveSplitter(p);
		}
		[SmokeMethod("closestLegalPosition(int)")]
		protected int ClosestLegalPosition(int p) {
			return ProxyQSplitterHandle().ClosestLegalPosition(p);
		}
		~QSplitterHandle() {
			DisposeQSplitterHandle();
		}
		public new void Dispose() {
			DisposeQSplitterHandle();
		}
		private void DisposeQSplitterHandle() {
			ProxyQSplitterHandle().DisposeQSplitterHandle();
		}
		protected new IQSplitterHandleSignals Emit() {
			return (IQSplitterHandleSignals) Q_EMIT;
		}
	}

	public interface IQSplitterHandleSignals : IQWidgetSignals {
	}
}
