//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QGrid : QFrame, IDisposable {
 		protected QGrid(Type dummy) : base((Type) null) {}
		interface IQGridProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQGridProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGrid), this);
			_interceptor = (QGrid) realProxy.GetTransparentProxy();
		}
		private QGrid ProxyQGrid() {
			return (QGrid) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGrid() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGridProxy), null);
			_staticInterceptor = (IQGridProxy) realProxy.GetTransparentProxy();
		}
		private static IQGridProxy StaticQGrid() {
			return (IQGridProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQGrid().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQGrid().ClassName();
		}
		public QGrid(int n, QWidget parent, string name, int f) : this((Type) null) {
			CreateQGridProxy();
			CreateQGridSignalProxy();
			NewQGrid(n,parent,name,f);
		}
		[SmokeMethod("QGrid(int, QWidget*, const char*, Qt::WFlags)")]
		private void NewQGrid(int n, QWidget parent, string name, int f) {
			ProxyQGrid().NewQGrid(n,parent,name,f);
		}
		public QGrid(int n, QWidget parent, string name) : this((Type) null) {
			CreateQGridProxy();
			CreateQGridSignalProxy();
			NewQGrid(n,parent,name);
		}
		[SmokeMethod("QGrid(int, QWidget*, const char*)")]
		private void NewQGrid(int n, QWidget parent, string name) {
			ProxyQGrid().NewQGrid(n,parent,name);
		}
		public QGrid(int n, QWidget parent) : this((Type) null) {
			CreateQGridProxy();
			CreateQGridSignalProxy();
			NewQGrid(n,parent);
		}
		[SmokeMethod("QGrid(int, QWidget*)")]
		private void NewQGrid(int n, QWidget parent) {
			ProxyQGrid().NewQGrid(n,parent);
		}
		public QGrid(int n) : this((Type) null) {
			CreateQGridProxy();
			CreateQGridSignalProxy();
			NewQGrid(n);
		}
		[SmokeMethod("QGrid(int)")]
		private void NewQGrid(int n) {
			ProxyQGrid().NewQGrid(n);
		}
		public QGrid(int n, int orient, QWidget parent, string name, int f) : this((Type) null) {
			CreateQGridProxy();
			CreateQGridSignalProxy();
			NewQGrid(n,orient,parent,name,f);
		}
		[SmokeMethod("QGrid(int, Qt::Orientation, QWidget*, const char*, Qt::WFlags)")]
		private void NewQGrid(int n, int orient, QWidget parent, string name, int f) {
			ProxyQGrid().NewQGrid(n,orient,parent,name,f);
		}
		public QGrid(int n, int orient, QWidget parent, string name) : this((Type) null) {
			CreateQGridProxy();
			CreateQGridSignalProxy();
			NewQGrid(n,orient,parent,name);
		}
		[SmokeMethod("QGrid(int, Qt::Orientation, QWidget*, const char*)")]
		private void NewQGrid(int n, int orient, QWidget parent, string name) {
			ProxyQGrid().NewQGrid(n,orient,parent,name);
		}
		public QGrid(int n, int orient, QWidget parent) : this((Type) null) {
			CreateQGridProxy();
			CreateQGridSignalProxy();
			NewQGrid(n,orient,parent);
		}
		[SmokeMethod("QGrid(int, Qt::Orientation, QWidget*)")]
		private void NewQGrid(int n, int orient, QWidget parent) {
			ProxyQGrid().NewQGrid(n,orient,parent);
		}
		public QGrid(int n, int orient) : this((Type) null) {
			CreateQGridProxy();
			CreateQGridSignalProxy();
			NewQGrid(n,orient);
		}
		[SmokeMethod("QGrid(int, Qt::Orientation)")]
		private void NewQGrid(int n, int orient) {
			ProxyQGrid().NewQGrid(n,orient);
		}
		[SmokeMethod("setSpacing(int)")]
		public void SetSpacing(int arg1) {
			ProxyQGrid().SetSpacing(arg1);
		}
		[SmokeMethod("sizeHint() const")]
		public new QSize SizeHint() {
			return ProxyQGrid().SizeHint();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQGrid().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQGrid().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQGrid().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQGrid().TrUtf8(arg1);
		}
		[SmokeMethod("frameChanged()")]
		protected new void FrameChanged() {
			ProxyQGrid().FrameChanged();
		}
		~QGrid() {
			DisposeQGrid();
		}
		public new void Dispose() {
			DisposeQGrid();
		}
		private void DisposeQGrid() {
			ProxyQGrid().DisposeQGrid();
		}
		protected void CreateQGridSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQGridSignals), this);
			_signalInterceptor = (IQGridSignals) realProxy.GetTransparentProxy();
		}
		protected new IQGridSignals Emit() {
			return (IQGridSignals) _signalInterceptor;
		}
	}

	public interface IQGridSignals : IQFrameSignals {
	}
}
