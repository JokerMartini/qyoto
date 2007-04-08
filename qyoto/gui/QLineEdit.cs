//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	///<remarks> See <see cref="IQLineEditSignals"></see> for signals emitted by QLineEdit
	///</remarks>

	[SmokeClass("QLineEdit")]
	public class QLineEdit : QWidget, IDisposable {
 		protected QLineEdit(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QLineEdit), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QLineEdit() {
			staticInterceptor = new SmokeInvocation(typeof(QLineEdit), null);
		}
		public enum EchoMode {
			Normal = 0,
			NoEcho = 1,
			Password = 2,
			PasswordEchoOnEdit = 3,
		}
		[Q_PROPERTY("QString", "inputMask")]
		public string InputMask {
			get { return (string) interceptor.Invoke("inputMask", "inputMask()", typeof(string)); }
			set { interceptor.Invoke("setInputMask$", "setInputMask(QString)", typeof(void), typeof(string), value); }
		}
		[Q_PROPERTY("QString", "text")]
		public string Text {
			get { return (string) interceptor.Invoke("text", "text()", typeof(string)); }
			set { interceptor.Invoke("setText$", "setText(QString)", typeof(void), typeof(string), value); }
		}
		[Q_PROPERTY("int", "maxLength")]
		public int MaxLength {
			get { return (int) interceptor.Invoke("maxLength", "maxLength()", typeof(int)); }
			set { interceptor.Invoke("setMaxLength$", "setMaxLength(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("bool", "frame")]
		public bool Frame {
			get { return (bool) interceptor.Invoke("hasFrame", "hasFrame()", typeof(bool)); }
			set { interceptor.Invoke("setFrame$", "setFrame(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("QLineEdit::EchoMode", "echoMode")]
		public QLineEdit.EchoMode echoMode {
			get { return (QLineEdit.EchoMode) interceptor.Invoke("echoMode", "echoMode()", typeof(QLineEdit.EchoMode)); }
			set { interceptor.Invoke("setEchoMode$", "setEchoMode(QLineEdit::EchoMode)", typeof(void), typeof(QLineEdit.EchoMode), value); }
		}
		[Q_PROPERTY("QString", "displayText")]
		public string DisplayText {
			get { return (string) interceptor.Invoke("displayText", "displayText()", typeof(string)); }
		}
		[Q_PROPERTY("int", "cursorPosition")]
		public int CursorPosition {
			get { return (int) interceptor.Invoke("cursorPosition", "cursorPosition()", typeof(int)); }
			set { interceptor.Invoke("setCursorPosition$", "setCursorPosition(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("Qt::Alignment", "alignment")]
		public int Alignment {
			get { return (int) interceptor.Invoke("alignment", "alignment()", typeof(int)); }
			set { interceptor.Invoke("setAlignment$", "setAlignment(Qt::Alignment)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("bool", "modified")]
		public bool Modified {
			get { return (bool) interceptor.Invoke("isModified", "isModified()", typeof(bool)); }
			set { interceptor.Invoke("setModified$", "setModified(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("bool", "hasSelectedText")]
		public bool HasSelectedText {
			get { return (bool) interceptor.Invoke("hasSelectedText", "hasSelectedText()", typeof(bool)); }
		}
		[Q_PROPERTY("QString", "selectedText")]
		public string SelectedText {
			get { return (string) interceptor.Invoke("selectedText", "selectedText()", typeof(string)); }
		}
		[Q_PROPERTY("bool", "dragEnabled")]
		public bool DragEnabled {
			get { return (bool) interceptor.Invoke("dragEnabled", "dragEnabled()", typeof(bool)); }
			set { interceptor.Invoke("setDragEnabled$", "setDragEnabled(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("bool", "readOnly")]
		public bool ReadOnly {
			get { return (bool) interceptor.Invoke("isReadOnly", "isReadOnly()", typeof(bool)); }
			set { interceptor.Invoke("setReadOnly$", "setReadOnly(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("bool", "undoAvailable")]
		public bool UndoAvailable {
			get { return (bool) interceptor.Invoke("isUndoAvailable", "isUndoAvailable()", typeof(bool)); }
		}
		[Q_PROPERTY("bool", "redoAvailable")]
		public bool RedoAvailable {
			get { return (bool) interceptor.Invoke("isRedoAvailable", "isRedoAvailable()", typeof(bool)); }
		}
		[Q_PROPERTY("bool", "acceptableInput")]
		public bool AcceptableInput {
			get { return (bool) interceptor.Invoke("hasAcceptableInput", "hasAcceptableInput()", typeof(bool)); }
		}
		public QLineEdit(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QLineEdit#", "QLineEdit(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public QLineEdit() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QLineEdit", "QLineEdit()", typeof(void));
		}
		public QLineEdit(string arg1, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QLineEdit$#", "QLineEdit(const QString&, QWidget*)", typeof(void), typeof(string), arg1, typeof(QWidget), parent);
		}
		public QLineEdit(string arg1) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QLineEdit$", "QLineEdit(const QString&)", typeof(void), typeof(string), arg1);
		}
		public void SetValidator(QValidator arg1) {
			interceptor.Invoke("setValidator#", "setValidator(const QValidator*)", typeof(void), typeof(QValidator), arg1);
		}
		public QValidator Validator() {
			return (QValidator) interceptor.Invoke("validator", "validator() const", typeof(QValidator));
		}
		public void SetCompleter(QCompleter completer) {
			interceptor.Invoke("setCompleter#", "setCompleter(QCompleter*)", typeof(void), typeof(QCompleter), completer);
		}
		public QCompleter Completer() {
			return (QCompleter) interceptor.Invoke("completer", "completer() const", typeof(QCompleter));
		}
		[SmokeMethod("sizeHint() const")]
		public override QSize SizeHint() {
			return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
		}
		[SmokeMethod("minimumSizeHint() const")]
		public override QSize MinimumSizeHint() {
			return (QSize) interceptor.Invoke("minimumSizeHint", "minimumSizeHint() const", typeof(QSize));
		}
		public int CursorPositionAt(QPoint pos) {
			return (int) interceptor.Invoke("cursorPositionAt#", "cursorPositionAt(const QPoint&)", typeof(int), typeof(QPoint), pos);
		}
		public void CursorForward(bool mark, int steps) {
			interceptor.Invoke("cursorForward$$", "cursorForward(bool, int)", typeof(void), typeof(bool), mark, typeof(int), steps);
		}
		public void CursorForward(bool mark) {
			interceptor.Invoke("cursorForward$", "cursorForward(bool)", typeof(void), typeof(bool), mark);
		}
		public void CursorBackward(bool mark, int steps) {
			interceptor.Invoke("cursorBackward$$", "cursorBackward(bool, int)", typeof(void), typeof(bool), mark, typeof(int), steps);
		}
		public void CursorBackward(bool mark) {
			interceptor.Invoke("cursorBackward$", "cursorBackward(bool)", typeof(void), typeof(bool), mark);
		}
		public void CursorWordForward(bool mark) {
			interceptor.Invoke("cursorWordForward$", "cursorWordForward(bool)", typeof(void), typeof(bool), mark);
		}
		public void CursorWordBackward(bool mark) {
			interceptor.Invoke("cursorWordBackward$", "cursorWordBackward(bool)", typeof(void), typeof(bool), mark);
		}
		public void Backspace() {
			interceptor.Invoke("backspace", "backspace()", typeof(void));
		}
		public void Del() {
			interceptor.Invoke("del", "del()", typeof(void));
		}
		public void Home(bool mark) {
			interceptor.Invoke("home$", "home(bool)", typeof(void), typeof(bool), mark);
		}
		public void End(bool mark) {
			interceptor.Invoke("end$", "end(bool)", typeof(void), typeof(bool), mark);
		}
		public void SetSelection(int arg1, int arg2) {
			interceptor.Invoke("setSelection$$", "setSelection(int, int)", typeof(void), typeof(int), arg1, typeof(int), arg2);
		}
		public int SelectionStart() {
			return (int) interceptor.Invoke("selectionStart", "selectionStart() const", typeof(int));
		}
		public void Deselect() {
			interceptor.Invoke("deselect", "deselect()", typeof(void));
		}
		public void Insert(string arg1) {
			interceptor.Invoke("insert$", "insert(const QString&)", typeof(void), typeof(string), arg1);
		}
		public QMenu CreateStandardContextMenu() {
			return (QMenu) interceptor.Invoke("createStandardContextMenu", "createStandardContextMenu()", typeof(QMenu));
		}
		[SmokeMethod("inputMethodQuery(Qt::InputMethodQuery) const")]
		public override QVariant InputMethodQuery(Qt.InputMethodQuery arg1) {
			return (QVariant) interceptor.Invoke("inputMethodQuery$", "inputMethodQuery(Qt::InputMethodQuery) const", typeof(QVariant), typeof(Qt.InputMethodQuery), arg1);
		}
		[SmokeMethod("event(QEvent*)")]
		public new virtual bool Event(QEvent arg1) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
		}
		[Q_SLOT("void setText(const QString&)")]
		public void SetText(string arg1) {
			interceptor.Invoke("setText$", "setText(const QString&)", typeof(void), typeof(string), arg1);
		}
		[Q_SLOT("void clear()")]
		public void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		[Q_SLOT("void selectAll()")]
		public void SelectAll() {
			interceptor.Invoke("selectAll", "selectAll()", typeof(void));
		}
		[Q_SLOT("void undo()")]
		public void Undo() {
			interceptor.Invoke("undo", "undo()", typeof(void));
		}
		[Q_SLOT("void redo()")]
		public void Redo() {
			interceptor.Invoke("redo", "redo()", typeof(void));
		}
		[Q_SLOT("void cut()")]
		public void Cut() {
			interceptor.Invoke("cut", "cut()", typeof(void));
		}
		[Q_SLOT("void copy() const")]
		public void Copy() {
			interceptor.Invoke("copy", "copy() const", typeof(void));
		}
		[Q_SLOT("void paste()")]
		public void Paste() {
			interceptor.Invoke("paste", "paste()", typeof(void));
		}
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected override void MousePressEvent(QMouseEvent arg1) {
			interceptor.Invoke("mousePressEvent#", "mousePressEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
		}
		[SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
		protected override void MouseMoveEvent(QMouseEvent arg1) {
			interceptor.Invoke("mouseMoveEvent#", "mouseMoveEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
		}
		[SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
		protected override void MouseReleaseEvent(QMouseEvent arg1) {
			interceptor.Invoke("mouseReleaseEvent#", "mouseReleaseEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
		}
		[SmokeMethod("mouseDoubleClickEvent(QMouseEvent*)")]
		protected override void MouseDoubleClickEvent(QMouseEvent arg1) {
			interceptor.Invoke("mouseDoubleClickEvent#", "mouseDoubleClickEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected override void KeyPressEvent(QKeyEvent arg1) {
			interceptor.Invoke("keyPressEvent#", "keyPressEvent(QKeyEvent*)", typeof(void), typeof(QKeyEvent), arg1);
		}
		[SmokeMethod("focusInEvent(QFocusEvent*)")]
		protected override void FocusInEvent(QFocusEvent arg1) {
			interceptor.Invoke("focusInEvent#", "focusInEvent(QFocusEvent*)", typeof(void), typeof(QFocusEvent), arg1);
		}
		[SmokeMethod("focusOutEvent(QFocusEvent*)")]
		protected override void FocusOutEvent(QFocusEvent arg1) {
			interceptor.Invoke("focusOutEvent#", "focusOutEvent(QFocusEvent*)", typeof(void), typeof(QFocusEvent), arg1);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected override void PaintEvent(QPaintEvent arg1) {
			interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), arg1);
		}
		[SmokeMethod("dragEnterEvent(QDragEnterEvent*)")]
		protected override void DragEnterEvent(QDragEnterEvent arg1) {
			interceptor.Invoke("dragEnterEvent#", "dragEnterEvent(QDragEnterEvent*)", typeof(void), typeof(QDragEnterEvent), arg1);
		}
		[SmokeMethod("dragMoveEvent(QDragMoveEvent*)")]
		protected override void DragMoveEvent(QDragMoveEvent e) {
			interceptor.Invoke("dragMoveEvent#", "dragMoveEvent(QDragMoveEvent*)", typeof(void), typeof(QDragMoveEvent), e);
		}
		[SmokeMethod("dragLeaveEvent(QDragLeaveEvent*)")]
		protected override void DragLeaveEvent(QDragLeaveEvent e) {
			interceptor.Invoke("dragLeaveEvent#", "dragLeaveEvent(QDragLeaveEvent*)", typeof(void), typeof(QDragLeaveEvent), e);
		}
		[SmokeMethod("dropEvent(QDropEvent*)")]
		protected override void DropEvent(QDropEvent arg1) {
			interceptor.Invoke("dropEvent#", "dropEvent(QDropEvent*)", typeof(void), typeof(QDropEvent), arg1);
		}
		[SmokeMethod("changeEvent(QEvent*)")]
		protected override void ChangeEvent(QEvent arg1) {
			interceptor.Invoke("changeEvent#", "changeEvent(QEvent*)", typeof(void), typeof(QEvent), arg1);
		}
		[SmokeMethod("contextMenuEvent(QContextMenuEvent*)")]
		protected override void ContextMenuEvent(QContextMenuEvent arg1) {
			interceptor.Invoke("contextMenuEvent#", "contextMenuEvent(QContextMenuEvent*)", typeof(void), typeof(QContextMenuEvent), arg1);
		}
		[SmokeMethod("inputMethodEvent(QInputMethodEvent*)")]
		protected override void InputMethodEvent(QInputMethodEvent arg1) {
			interceptor.Invoke("inputMethodEvent#", "inputMethodEvent(QInputMethodEvent*)", typeof(void), typeof(QInputMethodEvent), arg1);
		}
		protected void InitStyleOption(QStyleOptionFrame option) {
			interceptor.Invoke("initStyleOption#", "initStyleOption(QStyleOptionFrame*) const", typeof(void), typeof(QStyleOptionFrame), option);
		}
		~QLineEdit() {
			interceptor.Invoke("~QLineEdit", "~QLineEdit()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QLineEdit", "~QLineEdit()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQLineEditSignals Emit {
			get { return (IQLineEditSignals) Q_EMIT; }
		}
	}

	public interface IQLineEditSignals : IQWidgetSignals {
		[Q_SIGNAL("void textChanged(const QString&)")]
		void TextChanged(string arg1);
		[Q_SIGNAL("void textEdited(const QString&)")]
		void TextEdited(string arg1);
		[Q_SIGNAL("void cursorPositionChanged(int, int)")]
		void CursorPositionChanged(int arg1, int arg2);
		[Q_SIGNAL("void returnPressed()")]
		void ReturnPressed();
		[Q_SIGNAL("void editingFinished()")]
		void EditingFinished();
		[Q_SIGNAL("void selectionChanged()")]
		void SelectionChanged();
	}
}
