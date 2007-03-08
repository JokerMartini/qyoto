//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QAbstractPrintDialog")]
	public abstract class QAbstractPrintDialog : QDialog {
 		protected QAbstractPrintDialog(Type dummy) : base((Type) null) {}
		[SmokeClass("QAbstractPrintDialog")]
		interface IQAbstractPrintDialogProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QAbstractPrintDialog), this);
			_interceptor = (QAbstractPrintDialog) realProxy.GetTransparentProxy();
		}
		private QAbstractPrintDialog ProxyQAbstractPrintDialog() {
			return (QAbstractPrintDialog) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QAbstractPrintDialog() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQAbstractPrintDialogProxy), null);
			_staticInterceptor = (IQAbstractPrintDialogProxy) realProxy.GetTransparentProxy();
		}
		private static IQAbstractPrintDialogProxy StaticQAbstractPrintDialog() {
			return (IQAbstractPrintDialogProxy) _staticInterceptor;
		}
		public enum PrintRange {
			AllPages = 0,
			Selection = 1,
			PageRange = 2,
		}
		public enum PrintDialogOption {
			None = 0x0000,
			PrintToFile = 0x0001,
			PrintSelection = 0x0002,
			PrintPageRange = 0x0004,
			PrintCollateCopies = 0x0010,
		}
		public QAbstractPrintDialog(QPrinter printer, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQAbstractPrintDialog(printer,parent);
		}
		[SmokeMethod("QAbstractPrintDialog", "(QPrinter*, QWidget*)", "##")]
		private void NewQAbstractPrintDialog(QPrinter printer, QWidget parent) {
			ProxyQAbstractPrintDialog().NewQAbstractPrintDialog(printer,parent);
		}
		public QAbstractPrintDialog(QPrinter printer) : this((Type) null) {
			CreateProxy();
			NewQAbstractPrintDialog(printer);
		}
		[SmokeMethod("QAbstractPrintDialog", "(QPrinter*)", "#")]
		private void NewQAbstractPrintDialog(QPrinter printer) {
			ProxyQAbstractPrintDialog().NewQAbstractPrintDialog(printer);
		}
		public abstract int Exec();
		[SmokeMethod("addEnabledOption", "(QAbstractPrintDialog::PrintDialogOption)", "$")]
		public void AddEnabledOption(QAbstractPrintDialog.PrintDialogOption option) {
			ProxyQAbstractPrintDialog().AddEnabledOption(option);
		}
		[SmokeMethod("setEnabledOptions", "(PrintDialogOptions)", "$")]
		public void SetEnabledOptions(int options) {
			ProxyQAbstractPrintDialog().SetEnabledOptions(options);
		}
		[SmokeMethod("enabledOptions", "() const", "")]
		public int EnabledOptions() {
			return ProxyQAbstractPrintDialog().EnabledOptions();
		}
		[SmokeMethod("isOptionEnabled", "(QAbstractPrintDialog::PrintDialogOption) const", "$")]
		public bool IsOptionEnabled(QAbstractPrintDialog.PrintDialogOption option) {
			return ProxyQAbstractPrintDialog().IsOptionEnabled(option);
		}
		[SmokeMethod("setPrintRange", "(QAbstractPrintDialog::PrintRange)", "$")]
		public void SetPrintRange(QAbstractPrintDialog.PrintRange range) {
			ProxyQAbstractPrintDialog().SetPrintRange(range);
		}
		[SmokeMethod("printRange", "() const", "")]
		public QAbstractPrintDialog.PrintRange printRange() {
			return ProxyQAbstractPrintDialog().printRange();
		}
		[SmokeMethod("setMinMax", "(int, int)", "$$")]
		public void SetMinMax(int min, int max) {
			ProxyQAbstractPrintDialog().SetMinMax(min,max);
		}
		[SmokeMethod("minPage", "() const", "")]
		public int MinPage() {
			return ProxyQAbstractPrintDialog().MinPage();
		}
		[SmokeMethod("maxPage", "() const", "")]
		public int MaxPage() {
			return ProxyQAbstractPrintDialog().MaxPage();
		}
		[SmokeMethod("setFromTo", "(int, int)", "$$")]
		public void SetFromTo(int fromPage, int toPage) {
			ProxyQAbstractPrintDialog().SetFromTo(fromPage,toPage);
		}
		[SmokeMethod("fromPage", "() const", "")]
		public int FromPage() {
			return ProxyQAbstractPrintDialog().FromPage();
		}
		[SmokeMethod("toPage", "() const", "")]
		public int ToPage() {
			return ProxyQAbstractPrintDialog().ToPage();
		}
		[SmokeMethod("printer", "() const", "")]
		public QPrinter Printer() {
			return ProxyQAbstractPrintDialog().Printer();
		}
		public static string Tr(string s, string c) {
			return StaticQAbstractPrintDialog().Tr(s,c);
		}
		public static string Tr(string s) {
			return StaticQAbstractPrintDialog().Tr(s);
		}
		~QAbstractPrintDialog() {
			DisposeQAbstractPrintDialog();
		}
		public new void Dispose() {
			DisposeQAbstractPrintDialog();
		}
		[SmokeMethod("~QAbstractPrintDialog", "()", "")]
		private void DisposeQAbstractPrintDialog() {
			ProxyQAbstractPrintDialog().DisposeQAbstractPrintDialog();
		}
		protected new IQAbstractPrintDialogSignals Emit {
			get { return (IQAbstractPrintDialogSignals) Q_EMIT; }
		}
	}

	public interface IQAbstractPrintDialogSignals : IQDialogSignals {
	}
}
