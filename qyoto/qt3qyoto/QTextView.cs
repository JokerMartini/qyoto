//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QTextView : QTextEdit, IDisposable {
 		protected QTextView(Type dummy) : base((Type) null) {}
		interface IQTextViewProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQTextViewProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextView), this);
			_interceptor = (QTextView) realProxy.GetTransparentProxy();
		}
		private QTextView ProxyQTextView() {
			return (QTextView) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextView() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextViewProxy), null);
			_staticInterceptor = (IQTextViewProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextViewProxy StaticQTextView() {
			return (IQTextViewProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQTextView().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQTextView().ClassName();
		}
		public QTextView(string text, string context, QWidget parent, string name) : this((Type) null) {
			CreateQTextViewProxy();
			CreateQTextViewSignalProxy();
			NewQTextView(text,context,parent,name);
		}
		[SmokeMethod("QTextView(const QString&, const QString&, QWidget*, const char*)")]
		private void NewQTextView(string text, string context, QWidget parent, string name) {
			ProxyQTextView().NewQTextView(text,context,parent,name);
		}
		public QTextView(string text, string context, QWidget parent) : this((Type) null) {
			CreateQTextViewProxy();
			CreateQTextViewSignalProxy();
			NewQTextView(text,context,parent);
		}
		[SmokeMethod("QTextView(const QString&, const QString&, QWidget*)")]
		private void NewQTextView(string text, string context, QWidget parent) {
			ProxyQTextView().NewQTextView(text,context,parent);
		}
		public QTextView(string text, string context) : this((Type) null) {
			CreateQTextViewProxy();
			CreateQTextViewSignalProxy();
			NewQTextView(text,context);
		}
		[SmokeMethod("QTextView(const QString&, const QString&)")]
		private void NewQTextView(string text, string context) {
			ProxyQTextView().NewQTextView(text,context);
		}
		public QTextView(string text) : this((Type) null) {
			CreateQTextViewProxy();
			CreateQTextViewSignalProxy();
			NewQTextView(text);
		}
		[SmokeMethod("QTextView(const QString&)")]
		private void NewQTextView(string text) {
			ProxyQTextView().NewQTextView(text);
		}
		public QTextView(QWidget parent, string name) : this((Type) null) {
			CreateQTextViewProxy();
			CreateQTextViewSignalProxy();
			NewQTextView(parent,name);
		}
		[SmokeMethod("QTextView(QWidget*, const char*)")]
		private void NewQTextView(QWidget parent, string name) {
			ProxyQTextView().NewQTextView(parent,name);
		}
		public QTextView(QWidget parent) : this((Type) null) {
			CreateQTextViewProxy();
			CreateQTextViewSignalProxy();
			NewQTextView(parent);
		}
		[SmokeMethod("QTextView(QWidget*)")]
		private void NewQTextView(QWidget parent) {
			ProxyQTextView().NewQTextView(parent);
		}
		public QTextView() : this((Type) null) {
			CreateQTextViewProxy();
			CreateQTextViewSignalProxy();
			NewQTextView();
		}
		[SmokeMethod("QTextView()")]
		private void NewQTextView() {
			ProxyQTextView().NewQTextView();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQTextView().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQTextView().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQTextView().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQTextView().TrUtf8(arg1);
		}
		~QTextView() {
			DisposeQTextView();
		}
		public new void Dispose() {
			DisposeQTextView();
		}
		private void DisposeQTextView() {
			ProxyQTextView().DisposeQTextView();
		}
		protected void CreateQTextViewSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQTextViewSignals), this);
			_signalInterceptor = (IQTextViewSignals) realProxy.GetTransparentProxy();
		}
		protected new IQTextViewSignals Emit() {
			return (IQTextViewSignals) _signalInterceptor;
		}
	}

	public interface IQTextViewSignals : IQTextEditSignals {
	}
}
