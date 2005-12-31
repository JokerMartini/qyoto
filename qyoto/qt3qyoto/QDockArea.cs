//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QDockArea : QWidget, IDisposable {
 		protected QDockArea(Type dummy) : base((Type) null) {}
		interface IQDockAreaProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQDockAreaProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDockArea), this);
			_interceptor = (QDockArea) realProxy.GetTransparentProxy();
		}
		private QDockArea ProxyQDockArea() {
			return (QDockArea) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDockArea() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDockAreaProxy), null);
			_staticInterceptor = (IQDockAreaProxy) realProxy.GetTransparentProxy();
		}
		private static IQDockAreaProxy StaticQDockArea() {
			return (IQDockAreaProxy) _staticInterceptor;
		}

		enum E_HandlePosition {
			Normal = 0,
			Reverse = 1,
		}
		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQDockArea().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQDockArea().ClassName();
		}
		public QDockArea(int o, int h, QWidget parent, string name) : this((Type) null) {
			CreateQDockAreaProxy();
			CreateQDockAreaSignalProxy();
			NewQDockArea(o,h,parent,name);
		}
		[SmokeMethod("QDockArea(Qt::Orientation, QDockArea::HandlePosition, QWidget*, const char*)")]
		private void NewQDockArea(int o, int h, QWidget parent, string name) {
			ProxyQDockArea().NewQDockArea(o,h,parent,name);
		}
		public QDockArea(int o, int h, QWidget parent) : this((Type) null) {
			CreateQDockAreaProxy();
			CreateQDockAreaSignalProxy();
			NewQDockArea(o,h,parent);
		}
		[SmokeMethod("QDockArea(Qt::Orientation, QDockArea::HandlePosition, QWidget*)")]
		private void NewQDockArea(int o, int h, QWidget parent) {
			ProxyQDockArea().NewQDockArea(o,h,parent);
		}
		public QDockArea(int o, int h) : this((Type) null) {
			CreateQDockAreaProxy();
			CreateQDockAreaSignalProxy();
			NewQDockArea(o,h);
		}
		[SmokeMethod("QDockArea(Qt::Orientation, QDockArea::HandlePosition)")]
		private void NewQDockArea(int o, int h) {
			ProxyQDockArea().NewQDockArea(o,h);
		}
		public QDockArea(int o) : this((Type) null) {
			CreateQDockAreaProxy();
			CreateQDockAreaSignalProxy();
			NewQDockArea(o);
		}
		[SmokeMethod("QDockArea(Qt::Orientation)")]
		private void NewQDockArea(int o) {
			ProxyQDockArea().NewQDockArea(o);
		}
		[SmokeMethod("moveDockWindow(QDockWindow*, const QPoint&, const QRect&, bool)")]
		public void MoveDockWindow(QDockWindow w, QPoint globalPos, QRect rect, bool swap) {
			ProxyQDockArea().MoveDockWindow(w,globalPos,rect,swap);
		}
		[SmokeMethod("removeDockWindow(QDockWindow*, bool, bool, bool)")]
		public void RemoveDockWindow(QDockWindow w, bool makeFloating, bool swap, bool fixNewLines) {
			ProxyQDockArea().RemoveDockWindow(w,makeFloating,swap,fixNewLines);
		}
		[SmokeMethod("removeDockWindow(QDockWindow*, bool, bool)")]
		public void RemoveDockWindow(QDockWindow w, bool makeFloating, bool swap) {
			ProxyQDockArea().RemoveDockWindow(w,makeFloating,swap);
		}
		[SmokeMethod("moveDockWindow(QDockWindow*, int)")]
		public void MoveDockWindow(QDockWindow w, int index) {
			ProxyQDockArea().MoveDockWindow(w,index);
		}
		[SmokeMethod("moveDockWindow(QDockWindow*)")]
		public void MoveDockWindow(QDockWindow w) {
			ProxyQDockArea().MoveDockWindow(w);
		}
		[SmokeMethod("hasDockWindow(QDockWindow*, int*)")]
		public bool HasDockWindow(QDockWindow w, out int index) {
			return ProxyQDockArea().HasDockWindow(w,out index);
		}
		[SmokeMethod("hasDockWindow(QDockWindow*)")]
		public bool HasDockWindow(QDockWindow w) {
			return ProxyQDockArea().HasDockWindow(w);
		}
		[SmokeMethod("invalidNextOffset(QDockWindow*)")]
		public void InvalidNextOffset(QDockWindow dw) {
			ProxyQDockArea().InvalidNextOffset(dw);
		}
		[SmokeMethod("orientation() const")]
		public int Orientation() {
			return ProxyQDockArea().Orientation();
		}
		[SmokeMethod("handlePosition() const")]
		public int HandlePosition() {
			return ProxyQDockArea().HandlePosition();
		}
		[SmokeMethod("eventFilter(QObject*, QEvent*)")]
		public new bool EventFilter(QObject arg1, QEvent arg2) {
			return ProxyQDockArea().EventFilter(arg1,arg2);
		}
		[SmokeMethod("isEmpty() const")]
		public bool IsEmpty() {
			return ProxyQDockArea().IsEmpty();
		}
		[SmokeMethod("count() const")]
		public int Count() {
			return ProxyQDockArea().Count();
		}
		// QPtrList<QDockWindow> dockWindowList(); >>>> NOT CONVERTED
		[SmokeMethod("isDockWindowAccepted(QDockWindow*)")]
		public bool IsDockWindowAccepted(QDockWindow dw) {
			return ProxyQDockArea().IsDockWindowAccepted(dw);
		}
		[SmokeMethod("setAcceptDockWindow(QDockWindow*, bool)")]
		public void SetAcceptDockWindow(QDockWindow dw, bool accept) {
			ProxyQDockArea().SetAcceptDockWindow(dw,accept);
		}
		[Q_SLOT("lineUp(bool)")]
		[SmokeMethod("lineUp(bool)")]
		public void LineUp(bool keepNewLines) {
			ProxyQDockArea().LineUp(keepNewLines);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQDockArea().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQDockArea().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQDockArea().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQDockArea().TrUtf8(arg1);
		}
		~QDockArea() {
			DisposeQDockArea();
		}
		public new void Dispose() {
			DisposeQDockArea();
		}
		private void DisposeQDockArea() {
			ProxyQDockArea().DisposeQDockArea();
		}
		protected void CreateQDockAreaSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQDockAreaSignals), this);
			_signalInterceptor = (IQDockAreaSignals) realProxy.GetTransparentProxy();
		}
		protected new IQDockAreaSignals Emit() {
			return (IQDockAreaSignals) _signalInterceptor;
		}
	}

	public interface IQDockAreaSignals : IQWidgetSignals {
	}
}
