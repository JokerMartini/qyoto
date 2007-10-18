//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	/// <remarks> See <see cref="IQDialogSignals"></see> for signals emitted by QDialog
	/// </remarks>

	[SmokeClass("QDialog")]
	public class QDialog : QWidget, IDisposable {
 		protected QDialog(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QDialog), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QDialog() {
			staticInterceptor = new SmokeInvocation(typeof(QDialog), null);
		}
		public enum DialogCode {
			Rejected = 0,
			Accepted = 1,
		}
		[Q_PROPERTY("bool", "sizeGripEnabled")]
		public bool SizeGripEnabled {
			get { return (bool) interceptor.Invoke("isSizeGripEnabled", "isSizeGripEnabled()", typeof(bool)); }
			set { interceptor.Invoke("setSizeGripEnabled$", "setSizeGripEnabled(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("bool", "modal")]
		public new bool Modal {
			get { return (bool) interceptor.Invoke("isModal", "isModal()", typeof(bool)); }
			set { interceptor.Invoke("setModal$", "setModal(bool)", typeof(void), typeof(bool), value); }
		}
		// QDialog* QDialog(QDialogPrivate& arg1,QWidget* arg2,Qt::WindowFlags arg3); >>>> NOT CONVERTED
		// QDialog* QDialog(QDialogPrivate& arg1,QWidget* arg2); >>>> NOT CONVERTED
		public QDialog(QWidget parent, uint f) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDialog#$", "QDialog(QWidget*, Qt::WindowFlags)", typeof(void), typeof(QWidget), parent, typeof(uint), f);
		}
		public QDialog(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDialog#", "QDialog(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public QDialog() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDialog", "QDialog()", typeof(void));
		}
		public int Result() {
			return (int) interceptor.Invoke("result", "result() const", typeof(int));
		}
		[SmokeMethod("setVisible(bool)")]
		public override void SetVisible(bool visible) {
			interceptor.Invoke("setVisible$", "setVisible(bool)", typeof(void), typeof(bool), visible);
		}
		public void SetOrientation(Qt.Orientation orientation) {
			interceptor.Invoke("setOrientation$", "setOrientation(Qt::Orientation)", typeof(void), typeof(Qt.Orientation), orientation);
		}
		public new Qt.Orientation Orientation() {
			return (Qt.Orientation) interceptor.Invoke("orientation", "orientation() const", typeof(Qt.Orientation));
		}
		public void SetExtension(QWidget extension) {
			interceptor.Invoke("setExtension#", "setExtension(QWidget*)", typeof(void), typeof(QWidget), extension);
		}
		public QWidget Extension() {
			return (QWidget) interceptor.Invoke("extension", "extension() const", typeof(QWidget));
		}
		[SmokeMethod("sizeHint() const")]
		public override QSize SizeHint() {
			return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
		}
		[SmokeMethod("minimumSizeHint() const")]
		public override QSize MinimumSizeHint() {
			return (QSize) interceptor.Invoke("minimumSizeHint", "minimumSizeHint() const", typeof(QSize));
		}
		[SmokeMethod("event(QEvent*)")]
		public new virtual bool Event(QEvent arg1) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
		}
		public void SetResult(int r) {
			interceptor.Invoke("setResult$", "setResult(int)", typeof(void), typeof(int), r);
		}
		[Q_SLOT("int exec()")]
		public int Exec() {
			return (int) interceptor.Invoke("exec", "exec()", typeof(int));
		}
		[Q_SLOT("void done(int)")]
		[SmokeMethod("done(int)")]
		public virtual void Done(int arg1) {
			interceptor.Invoke("done$", "done(int)", typeof(void), typeof(int), arg1);
		}
		[Q_SLOT("void accept()")]
		[SmokeMethod("accept()")]
		public virtual void Accept() {
			interceptor.Invoke("accept", "accept()", typeof(void));
		}
		[Q_SLOT("void reject()")]
		[SmokeMethod("reject()")]
		public virtual void Reject() {
			interceptor.Invoke("reject", "reject()", typeof(void));
		}
		[Q_SLOT("void showExtension(bool)")]
		public void ShowExtension(bool arg1) {
			interceptor.Invoke("showExtension$", "showExtension(bool)", typeof(void), typeof(bool), arg1);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected override void KeyPressEvent(QKeyEvent arg1) {
			interceptor.Invoke("keyPressEvent#", "keyPressEvent(QKeyEvent*)", typeof(void), typeof(QKeyEvent), arg1);
		}
		[SmokeMethod("closeEvent(QCloseEvent*)")]
		protected override void CloseEvent(QCloseEvent arg1) {
			interceptor.Invoke("closeEvent#", "closeEvent(QCloseEvent*)", typeof(void), typeof(QCloseEvent), arg1);
		}
		[SmokeMethod("showEvent(QShowEvent*)")]
		protected override void ShowEvent(QShowEvent arg1) {
			interceptor.Invoke("showEvent#", "showEvent(QShowEvent*)", typeof(void), typeof(QShowEvent), arg1);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected override void ResizeEvent(QResizeEvent arg1) {
			interceptor.Invoke("resizeEvent#", "resizeEvent(QResizeEvent*)", typeof(void), typeof(QResizeEvent), arg1);
		}
		[SmokeMethod("contextMenuEvent(QContextMenuEvent*)")]
		protected override void ContextMenuEvent(QContextMenuEvent arg1) {
			interceptor.Invoke("contextMenuEvent#", "contextMenuEvent(QContextMenuEvent*)", typeof(void), typeof(QContextMenuEvent), arg1);
		}
		[SmokeMethod("eventFilter(QObject*, QEvent*)")]
		protected new virtual bool EventFilter(QObject arg1, QEvent arg2) {
			return (bool) interceptor.Invoke("eventFilter##", "eventFilter(QObject*, QEvent*)", typeof(bool), typeof(QObject), arg1, typeof(QEvent), arg2);
		}
		protected void AdjustPosition(QWidget arg1) {
			interceptor.Invoke("adjustPosition#", "adjustPosition(QWidget*)", typeof(void), typeof(QWidget), arg1);
		}
		~QDialog() {
			interceptor.Invoke("~QDialog", "~QDialog()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QDialog", "~QDialog()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQDialogSignals Emit {
			get { return (IQDialogSignals) Q_EMIT; }
		}
	}

	public interface IQDialogSignals : IQWidgetSignals {
		[Q_SIGNAL("void finished(int)")]
		void Finished(int result);
		[Q_SIGNAL("void accepted()")]
		void Accepted();
		[Q_SIGNAL("void rejected()")]
		void Rejected();
	}
}
