//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	/// See <see cref="IQLineEditSignals"></see> for signals emitted by QLineEdit
	[SmokeClass("QLineEdit")]
	public class QLineEdit : QWidget, IDisposable {
 		protected QLineEdit(Type dummy) : base((Type) null) {}
		interface IQLineEditProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QLineEdit), this);
			_interceptor = (QLineEdit) realProxy.GetTransparentProxy();
		}
		private QLineEdit ProxyQLineEdit() {
			return (QLineEdit) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QLineEdit() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQLineEditProxy), null);
			_staticInterceptor = (IQLineEditProxy) realProxy.GetTransparentProxy();
		}
		private static IQLineEditProxy StaticQLineEdit() {
			return (IQLineEditProxy) _staticInterceptor;
		}

		public enum EchoMode {
			Normal = 0,
			NoEcho = 1,
			Password = 2,
			PasswordEchoOnEdit = 3,
		}
		public string InputMask {
			get {
				return Property("inputMask").Value<string>();
			}
			set {
				SetProperty("inputMask", QVariant.FromValue<string>(value));
			}
		}
		public string Text {
			get {
				return Property("text").Value<string>();
			}
			set {
				SetProperty("text", QVariant.FromValue<string>(value));
			}
		}
		public int MaxLength {
			get {
				return Property("maxLength").Value<int>();
			}
			set {
				SetProperty("maxLength", QVariant.FromValue<int>(value));
			}
		}
		public bool Frame {
			get {
				return Property("frame").Value<bool>();
			}
			set {
				SetProperty("frame", QVariant.FromValue<bool>(value));
			}
		}
		public QLineEdit.EchoMode echoMode {
			get {
				return Property("echoMode").Value<QLineEdit.EchoMode>();
			}
			set {
				SetProperty("echoMode", QVariant.FromValue<QLineEdit.EchoMode>(value));
			}
		}
		public string DisplayText {
			get {
				return Property("displayText").Value<string>();
			}
		}
		public int CursorPosition {
			get {
				return Property("cursorPosition").Value<int>();
			}
			set {
				SetProperty("cursorPosition", QVariant.FromValue<int>(value));
			}
		}
		public int Alignment {
			get {
				return Property("alignment").Value<int>();
			}
			set {
				SetProperty("alignment", QVariant.FromValue<int>(value));
			}
		}
		public bool Modified {
			get {
				return Property("modified").Value<bool>();
			}
			set {
				SetProperty("modified", QVariant.FromValue<bool>(value));
			}
		}
		public bool HasSelectedText {
			get {
				return Property("hasSelectedText").Value<bool>();
			}
		}
		public string SelectedText {
			get {
				return Property("selectedText").Value<string>();
			}
		}
		public bool DragEnabled {
			get {
				return Property("dragEnabled").Value<bool>();
			}
			set {
				SetProperty("dragEnabled", QVariant.FromValue<bool>(value));
			}
		}
		public bool ReadOnly {
			get {
				return Property("readOnly").Value<bool>();
			}
			set {
				SetProperty("readOnly", QVariant.FromValue<bool>(value));
			}
		}
		public bool UndoAvailable {
			get {
				return Property("undoAvailable").Value<bool>();
			}
		}
		public bool RedoAvailable {
			get {
				return Property("redoAvailable").Value<bool>();
			}
		}
		public bool AcceptableInput {
			get {
				return Property("acceptableInput").Value<bool>();
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QLineEdit(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQLineEdit(parent);
		}
		[SmokeMethod("QLineEdit(QWidget*)")]
		private void NewQLineEdit(QWidget parent) {
			ProxyQLineEdit().NewQLineEdit(parent);
		}
		public QLineEdit() : this((Type) null) {
			CreateProxy();
			NewQLineEdit();
		}
		[SmokeMethod("QLineEdit()")]
		private void NewQLineEdit() {
			ProxyQLineEdit().NewQLineEdit();
		}
		public QLineEdit(string arg1, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQLineEdit(arg1,parent);
		}
		[SmokeMethod("QLineEdit(const QString&, QWidget*)")]
		private void NewQLineEdit(string arg1, QWidget parent) {
			ProxyQLineEdit().NewQLineEdit(arg1,parent);
		}
		public QLineEdit(string arg1) : this((Type) null) {
			CreateProxy();
			NewQLineEdit(arg1);
		}
		[SmokeMethod("QLineEdit(const QString&)")]
		private void NewQLineEdit(string arg1) {
			ProxyQLineEdit().NewQLineEdit(arg1);
		}
		[SmokeMethod("hasFrame() const")]
		public bool HasFrame() {
			return ProxyQLineEdit().HasFrame();
		}
		[SmokeMethod("isReadOnly() const")]
		public bool IsReadOnly() {
			return ProxyQLineEdit().IsReadOnly();
		}
		[SmokeMethod("setValidator(const QValidator*)")]
		public void SetValidator(QValidator arg1) {
			ProxyQLineEdit().SetValidator(arg1);
		}
		[SmokeMethod("validator() const")]
		public QValidator Validator() {
			return ProxyQLineEdit().Validator();
		}
		[SmokeMethod("setCompleter(QCompleter*)")]
		public void SetCompleter(QCompleter completer) {
			ProxyQLineEdit().SetCompleter(completer);
		}
		[SmokeMethod("completer() const")]
		public QCompleter Completer() {
			return ProxyQLineEdit().Completer();
		}
		[SmokeMethod("sizeHint() const")]
		public new QSize SizeHint() {
			return ProxyQLineEdit().SizeHint();
		}
		[SmokeMethod("minimumSizeHint() const")]
		public new QSize MinimumSizeHint() {
			return ProxyQLineEdit().MinimumSizeHint();
		}
		[SmokeMethod("cursorPositionAt(const QPoint&)")]
		public int CursorPositionAt(QPoint pos) {
			return ProxyQLineEdit().CursorPositionAt(pos);
		}
		[SmokeMethod("cursorForward(bool, int)")]
		public void CursorForward(bool mark, int steps) {
			ProxyQLineEdit().CursorForward(mark,steps);
		}
		[SmokeMethod("cursorForward(bool)")]
		public void CursorForward(bool mark) {
			ProxyQLineEdit().CursorForward(mark);
		}
		[SmokeMethod("cursorBackward(bool, int)")]
		public void CursorBackward(bool mark, int steps) {
			ProxyQLineEdit().CursorBackward(mark,steps);
		}
		[SmokeMethod("cursorBackward(bool)")]
		public void CursorBackward(bool mark) {
			ProxyQLineEdit().CursorBackward(mark);
		}
		[SmokeMethod("cursorWordForward(bool)")]
		public void CursorWordForward(bool mark) {
			ProxyQLineEdit().CursorWordForward(mark);
		}
		[SmokeMethod("cursorWordBackward(bool)")]
		public void CursorWordBackward(bool mark) {
			ProxyQLineEdit().CursorWordBackward(mark);
		}
		[SmokeMethod("backspace()")]
		public void Backspace() {
			ProxyQLineEdit().Backspace();
		}
		[SmokeMethod("del()")]
		public void Del() {
			ProxyQLineEdit().Del();
		}
		[SmokeMethod("home(bool)")]
		public void Home(bool mark) {
			ProxyQLineEdit().Home(mark);
		}
		[SmokeMethod("end(bool)")]
		public void End(bool mark) {
			ProxyQLineEdit().End(mark);
		}
		[SmokeMethod("isModified() const")]
		public bool IsModified() {
			return ProxyQLineEdit().IsModified();
		}
		[SmokeMethod("setSelection(int, int)")]
		public void SetSelection(int arg1, int arg2) {
			ProxyQLineEdit().SetSelection(arg1,arg2);
		}
		[SmokeMethod("selectionStart() const")]
		public int SelectionStart() {
			return ProxyQLineEdit().SelectionStart();
		}
		[SmokeMethod("isUndoAvailable() const")]
		public bool IsUndoAvailable() {
			return ProxyQLineEdit().IsUndoAvailable();
		}
		[SmokeMethod("isRedoAvailable() const")]
		public bool IsRedoAvailable() {
			return ProxyQLineEdit().IsRedoAvailable();
		}
		[SmokeMethod("hasAcceptableInput() const")]
		public bool HasAcceptableInput() {
			return ProxyQLineEdit().HasAcceptableInput();
		}
		[SmokeMethod("clear()")]
		public void Clear() {
			ProxyQLineEdit().Clear();
		}
		[SmokeMethod("selectAll()")]
		public void SelectAll() {
			ProxyQLineEdit().SelectAll();
		}
		[SmokeMethod("undo()")]
		public void Undo() {
			ProxyQLineEdit().Undo();
		}
		[SmokeMethod("redo()")]
		public void Redo() {
			ProxyQLineEdit().Redo();
		}
		[SmokeMethod("cut()")]
		public void Cut() {
			ProxyQLineEdit().Cut();
		}
		[SmokeMethod("copy() const")]
		public void Copy() {
			ProxyQLineEdit().Copy();
		}
		[SmokeMethod("paste()")]
		public void Paste() {
			ProxyQLineEdit().Paste();
		}
		[SmokeMethod("deselect()")]
		public void Deselect() {
			ProxyQLineEdit().Deselect();
		}
		[SmokeMethod("insert(const QString&)")]
		public void Insert(string arg1) {
			ProxyQLineEdit().Insert(arg1);
		}
		[SmokeMethod("createStandardContextMenu()")]
		public QMenu CreateStandardContextMenu() {
			return ProxyQLineEdit().CreateStandardContextMenu();
		}
		[SmokeMethod("inputMethodQuery(Qt::InputMethodQuery) const")]
		public new QVariant InputMethodQuery(Qt.InputMethodQuery arg1) {
			return ProxyQLineEdit().InputMethodQuery(arg1);
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent arg1) {
			return ProxyQLineEdit().Event(arg1);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQLineEdit().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQLineEdit().Tr(s);
		}
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected new void MousePressEvent(QMouseEvent arg1) {
			ProxyQLineEdit().MousePressEvent(arg1);
		}
		[SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
		protected new void MouseMoveEvent(QMouseEvent arg1) {
			ProxyQLineEdit().MouseMoveEvent(arg1);
		}
		[SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
		protected new void MouseReleaseEvent(QMouseEvent arg1) {
			ProxyQLineEdit().MouseReleaseEvent(arg1);
		}
		[SmokeMethod("mouseDoubleClickEvent(QMouseEvent*)")]
		protected new void MouseDoubleClickEvent(QMouseEvent arg1) {
			ProxyQLineEdit().MouseDoubleClickEvent(arg1);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected new void KeyPressEvent(QKeyEvent arg1) {
			ProxyQLineEdit().KeyPressEvent(arg1);
		}
		[SmokeMethod("focusInEvent(QFocusEvent*)")]
		protected new void FocusInEvent(QFocusEvent arg1) {
			ProxyQLineEdit().FocusInEvent(arg1);
		}
		[SmokeMethod("focusOutEvent(QFocusEvent*)")]
		protected new void FocusOutEvent(QFocusEvent arg1) {
			ProxyQLineEdit().FocusOutEvent(arg1);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected new void PaintEvent(QPaintEvent arg1) {
			ProxyQLineEdit().PaintEvent(arg1);
		}
		[SmokeMethod("dragEnterEvent(QDragEnterEvent*)")]
		protected new void DragEnterEvent(QDragEnterEvent arg1) {
			ProxyQLineEdit().DragEnterEvent(arg1);
		}
		[SmokeMethod("dragMoveEvent(QDragMoveEvent*)")]
		protected new void DragMoveEvent(QDragMoveEvent e) {
			ProxyQLineEdit().DragMoveEvent(e);
		}
		[SmokeMethod("dragLeaveEvent(QDragLeaveEvent*)")]
		protected new void DragLeaveEvent(QDragLeaveEvent e) {
			ProxyQLineEdit().DragLeaveEvent(e);
		}
		[SmokeMethod("dropEvent(QDropEvent*)")]
		protected new void DropEvent(QDropEvent arg1) {
			ProxyQLineEdit().DropEvent(arg1);
		}
		[SmokeMethod("changeEvent(QEvent*)")]
		protected new void ChangeEvent(QEvent arg1) {
			ProxyQLineEdit().ChangeEvent(arg1);
		}
		[SmokeMethod("contextMenuEvent(QContextMenuEvent*)")]
		protected new void ContextMenuEvent(QContextMenuEvent arg1) {
			ProxyQLineEdit().ContextMenuEvent(arg1);
		}
		[SmokeMethod("inputMethodEvent(QInputMethodEvent*)")]
		protected new void InputMethodEvent(QInputMethodEvent arg1) {
			ProxyQLineEdit().InputMethodEvent(arg1);
		}
		~QLineEdit() {
			DisposeQLineEdit();
		}
		public new void Dispose() {
			DisposeQLineEdit();
		}
		[SmokeMethod("~QLineEdit()")]
		private void DisposeQLineEdit() {
			ProxyQLineEdit().DisposeQLineEdit();
		}
		protected new IQLineEditSignals Emit {
			get {
				return (IQLineEditSignals) Q_EMIT;
			}
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
