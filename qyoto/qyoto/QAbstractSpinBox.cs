//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQAbstractSpinBoxSignals"></see> for signals emitted by QAbstractSpinBox
	[SmokeClass("QAbstractSpinBox")]
	public class QAbstractSpinBox : QWidget, IDisposable {
 		protected QAbstractSpinBox(Type dummy) : base((Type) null) {}
		interface IQAbstractSpinBoxProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QAbstractSpinBox), this);
			_interceptor = (QAbstractSpinBox) realProxy.GetTransparentProxy();
		}
		private QAbstractSpinBox ProxyQAbstractSpinBox() {
			return (QAbstractSpinBox) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QAbstractSpinBox() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQAbstractSpinBoxProxy), null);
			_staticInterceptor = (IQAbstractSpinBoxProxy) realProxy.GetTransparentProxy();
		}
		private static IQAbstractSpinBoxProxy StaticQAbstractSpinBox() {
			return (IQAbstractSpinBoxProxy) _staticInterceptor;
		}

		public enum StepEnabledFlag {
			StepNone = 0x00,
			StepUpEnabled = 0x01,
			StepDownEnabled = 0x02,
		}
		public enum ButtonSymbols {
			UpDownArrows = 0,
			PlusMinus = 1,
		}
		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQAbstractSpinBox().MetaObject();
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QAbstractSpinBox(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQAbstractSpinBox(parent);
		}
		[SmokeMethod("QAbstractSpinBox(QWidget*)")]
		private void NewQAbstractSpinBox(QWidget parent) {
			ProxyQAbstractSpinBox().NewQAbstractSpinBox(parent);
		}
		public QAbstractSpinBox() : this((Type) null) {
			CreateProxy();
			NewQAbstractSpinBox();
		}
		[SmokeMethod("QAbstractSpinBox()")]
		private void NewQAbstractSpinBox() {
			ProxyQAbstractSpinBox().NewQAbstractSpinBox();
		}
		[SmokeMethod("buttonSymbols() const")]
		public QAbstractSpinBox.ButtonSymbols buttonSymbols() {
			return ProxyQAbstractSpinBox().buttonSymbols();
		}
		[SmokeMethod("setButtonSymbols(QAbstractSpinBox::ButtonSymbols)")]
		public void SetButtonSymbols(QAbstractSpinBox.ButtonSymbols bs) {
			ProxyQAbstractSpinBox().SetButtonSymbols(bs);
		}
		[SmokeMethod("text() const")]
		public string Text() {
			return ProxyQAbstractSpinBox().Text();
		}
		[SmokeMethod("specialValueText() const")]
		public string SpecialValueText() {
			return ProxyQAbstractSpinBox().SpecialValueText();
		}
		[SmokeMethod("setSpecialValueText(const QString&)")]
		public void SetSpecialValueText(string s) {
			ProxyQAbstractSpinBox().SetSpecialValueText(s);
		}
		[SmokeMethod("wrapping() const")]
		public bool Wrapping() {
			return ProxyQAbstractSpinBox().Wrapping();
		}
		[SmokeMethod("setWrapping(bool)")]
		public void SetWrapping(bool w) {
			ProxyQAbstractSpinBox().SetWrapping(w);
		}
		[SmokeMethod("setReadOnly(bool)")]
		public void SetReadOnly(bool r) {
			ProxyQAbstractSpinBox().SetReadOnly(r);
		}
		[SmokeMethod("isReadOnly() const")]
		public bool IsReadOnly() {
			return ProxyQAbstractSpinBox().IsReadOnly();
		}
		[SmokeMethod("setAlignment(Qt::Alignment)")]
		public void SetAlignment(int flag) {
			ProxyQAbstractSpinBox().SetAlignment(flag);
		}
		[SmokeMethod("alignment() const")]
		public int Alignment() {
			return ProxyQAbstractSpinBox().Alignment();
		}
		[SmokeMethod("setFrame(bool)")]
		public void SetFrame(bool arg1) {
			ProxyQAbstractSpinBox().SetFrame(arg1);
		}
		[SmokeMethod("hasFrame() const")]
		public bool HasFrame() {
			return ProxyQAbstractSpinBox().HasFrame();
		}
		[SmokeMethod("sizeHint() const")]
		public new QSize SizeHint() {
			return ProxyQAbstractSpinBox().SizeHint();
		}
		[SmokeMethod("minimumSizeHint() const")]
		public new QSize MinimumSizeHint() {
			return ProxyQAbstractSpinBox().MinimumSizeHint();
		}
		[SmokeMethod("interpretText()")]
		public void InterpretText() {
			ProxyQAbstractSpinBox().InterpretText();
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent arg1) {
			return ProxyQAbstractSpinBox().Event(arg1);
		}
		[SmokeMethod("validate(QString&, int&) const")]
		public virtual int Validate(StringBuilder input, out int pos) {
			return ProxyQAbstractSpinBox().Validate(input,out pos);
		}
		[SmokeMethod("fixup(QString&) const")]
		public virtual void Fixup(StringBuilder input) {
			ProxyQAbstractSpinBox().Fixup(input);
		}
		[SmokeMethod("stepBy(int)")]
		public virtual void StepBy(int steps) {
			ProxyQAbstractSpinBox().StepBy(steps);
		}
		[SmokeMethod("stepUp()")]
		public void StepUp() {
			ProxyQAbstractSpinBox().StepUp();
		}
		[SmokeMethod("stepDown()")]
		public void StepDown() {
			ProxyQAbstractSpinBox().StepDown();
		}
		[SmokeMethod("selectAll()")]
		public void SelectAll() {
			ProxyQAbstractSpinBox().SelectAll();
		}
		[SmokeMethod("clear()")]
		public virtual void Clear() {
			ProxyQAbstractSpinBox().Clear();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQAbstractSpinBox().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQAbstractSpinBox().Tr(s);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected new void ResizeEvent(QResizeEvent e) {
			ProxyQAbstractSpinBox().ResizeEvent(e);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected new void KeyPressEvent(QKeyEvent e) {
			ProxyQAbstractSpinBox().KeyPressEvent(e);
		}
		[SmokeMethod("keyReleaseEvent(QKeyEvent*)")]
		protected new void KeyReleaseEvent(QKeyEvent e) {
			ProxyQAbstractSpinBox().KeyReleaseEvent(e);
		}
		[SmokeMethod("wheelEvent(QWheelEvent*)")]
		protected new void WheelEvent(QWheelEvent e) {
			ProxyQAbstractSpinBox().WheelEvent(e);
		}
		[SmokeMethod("focusInEvent(QFocusEvent*)")]
		protected new void FocusInEvent(QFocusEvent e) {
			ProxyQAbstractSpinBox().FocusInEvent(e);
		}
		[SmokeMethod("focusOutEvent(QFocusEvent*)")]
		protected new void FocusOutEvent(QFocusEvent e) {
			ProxyQAbstractSpinBox().FocusOutEvent(e);
		}
		[SmokeMethod("contextMenuEvent(QContextMenuEvent*)")]
		protected new void ContextMenuEvent(QContextMenuEvent e) {
			ProxyQAbstractSpinBox().ContextMenuEvent(e);
		}
		[SmokeMethod("changeEvent(QEvent*)")]
		protected new void ChangeEvent(QEvent e) {
			ProxyQAbstractSpinBox().ChangeEvent(e);
		}
		[SmokeMethod("closeEvent(QCloseEvent*)")]
		protected new void CloseEvent(QCloseEvent e) {
			ProxyQAbstractSpinBox().CloseEvent(e);
		}
		[SmokeMethod("hideEvent(QHideEvent*)")]
		protected new void HideEvent(QHideEvent e) {
			ProxyQAbstractSpinBox().HideEvent(e);
		}
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected new void MousePressEvent(QMouseEvent e) {
			ProxyQAbstractSpinBox().MousePressEvent(e);
		}
		[SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
		protected new void MouseReleaseEvent(QMouseEvent e) {
			ProxyQAbstractSpinBox().MouseReleaseEvent(e);
		}
		[SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
		protected new void MouseMoveEvent(QMouseEvent e) {
			ProxyQAbstractSpinBox().MouseMoveEvent(e);
		}
		[SmokeMethod("timerEvent(QTimerEvent*)")]
		protected new void TimerEvent(QTimerEvent e) {
			ProxyQAbstractSpinBox().TimerEvent(e);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected new void PaintEvent(QPaintEvent e) {
			ProxyQAbstractSpinBox().PaintEvent(e);
		}
		[SmokeMethod("showEvent(QShowEvent*)")]
		public new void ShowEvent(QShowEvent e) {
			ProxyQAbstractSpinBox().ShowEvent(e);
		}
		[SmokeMethod("lineEdit() const")]
		protected QLineEdit LineEdit() {
			return ProxyQAbstractSpinBox().LineEdit();
		}
		[SmokeMethod("setLineEdit(QLineEdit*)")]
		protected void SetLineEdit(QLineEdit e) {
			ProxyQAbstractSpinBox().SetLineEdit(e);
		}
		[SmokeMethod("stepEnabled() const")]
		protected virtual int StepEnabled() {
			return ProxyQAbstractSpinBox().StepEnabled();
		}
		~QAbstractSpinBox() {
			DisposeQAbstractSpinBox();
		}
		public new void Dispose() {
			DisposeQAbstractSpinBox();
		}
		private void DisposeQAbstractSpinBox() {
			ProxyQAbstractSpinBox().DisposeQAbstractSpinBox();
		}
		protected new IQAbstractSpinBoxSignals Emit() {
			return (IQAbstractSpinBoxSignals) Q_EMIT;
		}
	}

	public interface IQAbstractSpinBoxSignals : IQWidgetSignals {
		[Q_SIGNAL("void editingFinished()")]
		void EditingFinished();
	}
}
