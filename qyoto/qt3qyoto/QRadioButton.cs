//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QRadioButton : QButton, IDisposable {
 		protected QRadioButton(Type dummy) : base((Type) null) {}
		interface IQRadioButtonProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQRadioButtonProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QRadioButton), this);
			_interceptor = (QRadioButton) realProxy.GetTransparentProxy();
		}
		private QRadioButton ProxyQRadioButton() {
			return (QRadioButton) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QRadioButton() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQRadioButtonProxy), null);
			_staticInterceptor = (IQRadioButtonProxy) realProxy.GetTransparentProxy();
		}
		private static IQRadioButtonProxy StaticQRadioButton() {
			return (IQRadioButtonProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQRadioButton().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQRadioButton().ClassName();
		}
		public QRadioButton(QWidget parent, string name) : this((Type) null) {
			CreateQRadioButtonProxy();
			CreateQRadioButtonSignalProxy();
			NewQRadioButton(parent,name);
		}
		[SmokeMethod("QRadioButton(QWidget*, const char*)")]
		private void NewQRadioButton(QWidget parent, string name) {
			ProxyQRadioButton().NewQRadioButton(parent,name);
		}
		public QRadioButton(QWidget parent) : this((Type) null) {
			CreateQRadioButtonProxy();
			CreateQRadioButtonSignalProxy();
			NewQRadioButton(parent);
		}
		[SmokeMethod("QRadioButton(QWidget*)")]
		private void NewQRadioButton(QWidget parent) {
			ProxyQRadioButton().NewQRadioButton(parent);
		}
		public QRadioButton(string text, QWidget parent, string name) : this((Type) null) {
			CreateQRadioButtonProxy();
			CreateQRadioButtonSignalProxy();
			NewQRadioButton(text,parent,name);
		}
		[SmokeMethod("QRadioButton(const QString&, QWidget*, const char*)")]
		private void NewQRadioButton(string text, QWidget parent, string name) {
			ProxyQRadioButton().NewQRadioButton(text,parent,name);
		}
		public QRadioButton(string text, QWidget parent) : this((Type) null) {
			CreateQRadioButtonProxy();
			CreateQRadioButtonSignalProxy();
			NewQRadioButton(text,parent);
		}
		[SmokeMethod("QRadioButton(const QString&, QWidget*)")]
		private void NewQRadioButton(string text, QWidget parent) {
			ProxyQRadioButton().NewQRadioButton(text,parent);
		}
		[SmokeMethod("isChecked() const")]
		public bool IsChecked() {
			return ProxyQRadioButton().IsChecked();
		}
		[SmokeMethod("sizeHint() const")]
		public new QSize SizeHint() {
			return ProxyQRadioButton().SizeHint();
		}
		[Q_SLOT("setChecked(bool)")]
		[SmokeMethod("setChecked(bool)")]
		public virtual void SetChecked(bool check) {
			ProxyQRadioButton().SetChecked(check);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQRadioButton().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQRadioButton().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQRadioButton().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQRadioButton().TrUtf8(arg1);
		}
		[SmokeMethod("hitButton(const QPoint&) const")]
		protected new bool HitButton(QPoint arg1) {
			return ProxyQRadioButton().HitButton(arg1);
		}
		[SmokeMethod("drawButton(QPainter*)")]
		protected new void DrawButton(QPainter arg1) {
			ProxyQRadioButton().DrawButton(arg1);
		}
		[SmokeMethod("drawButtonLabel(QPainter*)")]
		protected new void DrawButtonLabel(QPainter arg1) {
			ProxyQRadioButton().DrawButtonLabel(arg1);
		}
		[SmokeMethod("updateMask()")]
		protected new void UpdateMask() {
			ProxyQRadioButton().UpdateMask();
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected new void ResizeEvent(QResizeEvent arg1) {
			ProxyQRadioButton().ResizeEvent(arg1);
		}
		~QRadioButton() {
			DisposeQRadioButton();
		}
		public new void Dispose() {
			DisposeQRadioButton();
		}
		private void DisposeQRadioButton() {
			ProxyQRadioButton().DisposeQRadioButton();
		}
		protected void CreateQRadioButtonSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQRadioButtonSignals), this);
			_signalInterceptor = (IQRadioButtonSignals) realProxy.GetTransparentProxy();
		}
		protected new IQRadioButtonSignals Emit() {
			return (IQRadioButtonSignals) _signalInterceptor;
		}
	}

	public interface IQRadioButtonSignals : IQButtonSignals {
	}
}
