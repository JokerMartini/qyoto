//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QPageSetupDialog")]
	public class QPageSetupDialog : QAbstractPageSetupDialog, IDisposable {
 		protected QPageSetupDialog(Type dummy) : base((Type) null) {}
		[SmokeClass("QPageSetupDialog")]
		interface IQPageSetupDialogProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QPageSetupDialog), this);
			_interceptor = (QPageSetupDialog) realProxy.GetTransparentProxy();
		}
		private QPageSetupDialog ProxyQPageSetupDialog() {
			return (QPageSetupDialog) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QPageSetupDialog() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQPageSetupDialogProxy), null);
			_staticInterceptor = (IQPageSetupDialogProxy) realProxy.GetTransparentProxy();
		}
		private static IQPageSetupDialogProxy StaticQPageSetupDialog() {
			return (IQPageSetupDialogProxy) _staticInterceptor;
		}
		public QPageSetupDialog(QPrinter printer, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQPageSetupDialog(printer,parent);
		}
		[SmokeMethod("QPageSetupDialog", "(QPrinter*, QWidget*)", "##")]
		private void NewQPageSetupDialog(QPrinter printer, QWidget parent) {
			ProxyQPageSetupDialog().NewQPageSetupDialog(printer,parent);
		}
		public QPageSetupDialog(QPrinter printer) : this((Type) null) {
			CreateProxy();
			NewQPageSetupDialog(printer);
		}
		[SmokeMethod("QPageSetupDialog", "(QPrinter*)", "#")]
		private void NewQPageSetupDialog(QPrinter printer) {
			ProxyQPageSetupDialog().NewQPageSetupDialog(printer);
		}
		[SmokeMethod("exec", "()", "")]
		public override int Exec() {
			return ProxyQPageSetupDialog().Exec();
		}
		public static string Tr(string s, string c) {
			return StaticQPageSetupDialog().Tr(s,c);
		}
		public static string Tr(string s) {
			return StaticQPageSetupDialog().Tr(s);
		}
		~QPageSetupDialog() {
			DisposeQPageSetupDialog();
		}
		public new void Dispose() {
			DisposeQPageSetupDialog();
		}
		[SmokeMethod("~QPageSetupDialog", "()", "")]
		private void DisposeQPageSetupDialog() {
			ProxyQPageSetupDialog().DisposeQPageSetupDialog();
		}
		protected new IQPageSetupDialogSignals Emit {
			get { return (IQPageSetupDialogSignals) Q_EMIT; }
		}
	}

	public interface IQPageSetupDialogSignals : IQAbstractPageSetupDialogSignals {
	}
}
