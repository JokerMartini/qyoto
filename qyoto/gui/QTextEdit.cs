//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	///<remarks> See <see cref="IQTextEditSignals"></see> for signals emitted by QTextEdit
	///</remarks>

	[SmokeClass("QTextEdit")]
	public class QTextEdit : QAbstractScrollArea, IDisposable {
 		protected QTextEdit(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QTextEdit), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QTextEdit() {
			staticInterceptor = new SmokeInvocation(typeof(QTextEdit), null);
		}
		public enum LineWrapMode {
			NoWrap = 0,
			WidgetWidth = 1,
			FixedPixelWidth = 2,
			FixedColumnWidth = 3,
		}
		public enum AutoFormattingFlag : uint {
			AutoNone = 0,
			AutoBulletList = 0x00000001,
			AutoAll = 0xffffffff,
		}
		[Q_PROPERTY("AutoFormatting", "autoFormatting")]
		public int AutoFormatting {
			get { return (int) interceptor.Invoke("autoFormatting", "autoFormatting()", typeof(int)); }
			set { interceptor.Invoke("setAutoFormatting$", "setAutoFormatting(AutoFormatting)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("bool", "tabChangesFocus")]
		public bool TabChangesFocus {
			get { return (bool) interceptor.Invoke("tabChangesFocus", "tabChangesFocus()", typeof(bool)); }
			set { interceptor.Invoke("setTabChangesFocus$", "setTabChangesFocus(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("QString", "documentTitle")]
		public string DocumentTitle {
			get { return (string) interceptor.Invoke("documentTitle", "documentTitle()", typeof(string)); }
			set { interceptor.Invoke("setDocumentTitle$", "setDocumentTitle(QString)", typeof(void), typeof(string), value); }
		}
		[Q_PROPERTY("bool", "undoRedoEnabled")]
		public bool UndoRedoEnabled {
			get { return (bool) interceptor.Invoke("isUndoRedoEnabled", "isUndoRedoEnabled()", typeof(bool)); }
			set { interceptor.Invoke("setUndoRedoEnabled$", "setUndoRedoEnabled(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("QTextEdit::LineWrapMode", "lineWrapMode")]
		public QTextEdit.LineWrapMode lineWrapMode {
			get { return (QTextEdit.LineWrapMode) interceptor.Invoke("lineWrapMode", "lineWrapMode()", typeof(QTextEdit.LineWrapMode)); }
			set { interceptor.Invoke("setLineWrapMode$", "setLineWrapMode(QTextEdit::LineWrapMode)", typeof(void), typeof(QTextEdit.LineWrapMode), value); }
		}
		[Q_PROPERTY("int", "lineWrapColumnOrWidth")]
		public int LineWrapColumnOrWidth {
			get { return (int) interceptor.Invoke("lineWrapColumnOrWidth", "lineWrapColumnOrWidth()", typeof(int)); }
			set { interceptor.Invoke("setLineWrapColumnOrWidth$", "setLineWrapColumnOrWidth(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("bool", "readOnly")]
		public bool ReadOnly {
			get { return (bool) interceptor.Invoke("isReadOnly", "isReadOnly()", typeof(bool)); }
			set { interceptor.Invoke("setReadOnly$", "setReadOnly(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("QString", "html")]
		public string Html {
			get { return (string) interceptor.Invoke("toHtml", "toHtml()", typeof(string)); }
			set { interceptor.Invoke("setHtml$", "setHtml(QString)", typeof(void), typeof(string), value); }
		}
		[Q_PROPERTY("QString", "plainText")]
		public string PlainText {
			get { return (string) interceptor.Invoke("toPlainText", "toPlainText()", typeof(string)); }
			set { interceptor.Invoke("setPlainText$", "setPlainText(QString)", typeof(void), typeof(string), value); }
		}
		[Q_PROPERTY("bool", "overwriteMode")]
		public bool OverwriteMode {
			get { return (bool) interceptor.Invoke("overwriteMode", "overwriteMode()", typeof(bool)); }
			set { interceptor.Invoke("setOverwriteMode$", "setOverwriteMode(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("int", "tabStopWidth")]
		public int TabStopWidth {
			get { return (int) interceptor.Invoke("tabStopWidth", "tabStopWidth()", typeof(int)); }
			set { interceptor.Invoke("setTabStopWidth$", "setTabStopWidth(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("bool", "acceptRichText")]
		public bool AcceptRichText {
			get { return (bool) interceptor.Invoke("acceptRichText", "acceptRichText()", typeof(bool)); }
			set { interceptor.Invoke("setAcceptRichText$", "setAcceptRichText(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("int", "cursorWidth")]
		public int CursorWidth {
			get { return (int) interceptor.Invoke("cursorWidth", "cursorWidth()", typeof(int)); }
			set { interceptor.Invoke("setCursorWidth$", "setCursorWidth(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("Qt::TextInteractionFlags", "textInteractionFlags")]
		public int TextInteractionFlags {
			get { return (int) interceptor.Invoke("textInteractionFlags", "textInteractionFlags()", typeof(int)); }
			set { interceptor.Invoke("setTextInteractionFlags$", "setTextInteractionFlags(Qt::TextInteractionFlags)", typeof(void), typeof(int), value); }
		}
		// void setExtraSelections(const QList<QTextEdit::ExtraSelection>& arg1); >>>> NOT CONVERTED
		// QList<QTextEdit::ExtraSelection> extraSelections(); >>>> NOT CONVERTED
		public QTextEdit(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTextEdit#", "QTextEdit(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public QTextEdit() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTextEdit", "QTextEdit()", typeof(void));
		}
		public QTextEdit(string text, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTextEdit$#", "QTextEdit(const QString&, QWidget*)", typeof(void), typeof(string), text, typeof(QWidget), parent);
		}
		public QTextEdit(string text) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTextEdit$", "QTextEdit(const QString&)", typeof(void), typeof(string), text);
		}
		public void SetDocument(QTextDocument document) {
			interceptor.Invoke("setDocument#", "setDocument(QTextDocument*)", typeof(void), typeof(QTextDocument), document);
		}
		public QTextDocument Document() {
			return (QTextDocument) interceptor.Invoke("document", "document() const", typeof(QTextDocument));
		}
		public void SetTextCursor(QTextCursor cursor) {
			interceptor.Invoke("setTextCursor#", "setTextCursor(const QTextCursor&)", typeof(void), typeof(QTextCursor), cursor);
		}
		public QTextCursor TextCursor() {
			return (QTextCursor) interceptor.Invoke("textCursor", "textCursor() const", typeof(QTextCursor));
		}
		public double FontPointSize() {
			return (double) interceptor.Invoke("fontPointSize", "fontPointSize() const", typeof(double));
		}
		public string FontFamily() {
			return (string) interceptor.Invoke("fontFamily", "fontFamily() const", typeof(string));
		}
		public int FontWeight() {
			return (int) interceptor.Invoke("fontWeight", "fontWeight() const", typeof(int));
		}
		public bool FontUnderline() {
			return (bool) interceptor.Invoke("fontUnderline", "fontUnderline() const", typeof(bool));
		}
		public bool FontItalic() {
			return (bool) interceptor.Invoke("fontItalic", "fontItalic() const", typeof(bool));
		}
		public QColor TextColor() {
			return (QColor) interceptor.Invoke("textColor", "textColor() const", typeof(QColor));
		}
		public QFont CurrentFont() {
			return (QFont) interceptor.Invoke("currentFont", "currentFont() const", typeof(QFont));
		}
		public int Alignment() {
			return (int) interceptor.Invoke("alignment", "alignment() const", typeof(int));
		}
		public void MergeCurrentCharFormat(QTextCharFormat modifier) {
			interceptor.Invoke("mergeCurrentCharFormat#", "mergeCurrentCharFormat(const QTextCharFormat&)", typeof(void), typeof(QTextCharFormat), modifier);
		}
		public void SetCurrentCharFormat(QTextCharFormat format) {
			interceptor.Invoke("setCurrentCharFormat#", "setCurrentCharFormat(const QTextCharFormat&)", typeof(void), typeof(QTextCharFormat), format);
		}
		public QTextCharFormat CurrentCharFormat() {
			return (QTextCharFormat) interceptor.Invoke("currentCharFormat", "currentCharFormat() const", typeof(QTextCharFormat));
		}
		public QTextOption.WrapMode WordWrapMode() {
			return (QTextOption.WrapMode) interceptor.Invoke("wordWrapMode", "wordWrapMode() const", typeof(QTextOption.WrapMode));
		}
		public void SetWordWrapMode(QTextOption.WrapMode policy) {
			interceptor.Invoke("setWordWrapMode$", "setWordWrapMode(QTextOption::WrapMode)", typeof(void), typeof(QTextOption.WrapMode), policy);
		}
		public bool Find(string exp, int options) {
			return (bool) interceptor.Invoke("find$$", "find(const QString&, QTextDocument::FindFlags)", typeof(bool), typeof(string), exp, typeof(int), options);
		}
		public bool Find(string exp) {
			return (bool) interceptor.Invoke("find$", "find(const QString&)", typeof(bool), typeof(string), exp);
		}
		public void EnsureCursorVisible() {
			interceptor.Invoke("ensureCursorVisible", "ensureCursorVisible()", typeof(void));
		}
		[SmokeMethod("loadResource(int, const QUrl&)")]
		public virtual QVariant LoadResource(int type, QUrl name) {
			return (QVariant) interceptor.Invoke("loadResource$#", "loadResource(int, const QUrl&)", typeof(QVariant), typeof(int), type, typeof(QUrl), name);
		}
		public QMenu CreateStandardContextMenu() {
			return (QMenu) interceptor.Invoke("createStandardContextMenu", "createStandardContextMenu()", typeof(QMenu));
		}
		public QTextCursor CursorForPosition(QPoint pos) {
			return (QTextCursor) interceptor.Invoke("cursorForPosition#", "cursorForPosition(const QPoint&) const", typeof(QTextCursor), typeof(QPoint), pos);
		}
		public QRect CursorRect(QTextCursor cursor) {
			return (QRect) interceptor.Invoke("cursorRect#", "cursorRect(const QTextCursor&) const", typeof(QRect), typeof(QTextCursor), cursor);
		}
		public QRect CursorRect() {
			return (QRect) interceptor.Invoke("cursorRect", "cursorRect() const", typeof(QRect));
		}
		public string AnchorAt(QPoint pos) {
			return (string) interceptor.Invoke("anchorAt#", "anchorAt(const QPoint&) const", typeof(string), typeof(QPoint), pos);
		}
		public void MoveCursor(QTextCursor.MoveOperation operation, QTextCursor.MoveMode mode) {
			interceptor.Invoke("moveCursor$$", "moveCursor(QTextCursor::MoveOperation, QTextCursor::MoveMode)", typeof(void), typeof(QTextCursor.MoveOperation), operation, typeof(QTextCursor.MoveMode), mode);
		}
		public void MoveCursor(QTextCursor.MoveOperation operation) {
			interceptor.Invoke("moveCursor$", "moveCursor(QTextCursor::MoveOperation)", typeof(void), typeof(QTextCursor.MoveOperation), operation);
		}
		public bool CanPaste() {
			return (bool) interceptor.Invoke("canPaste", "canPaste() const", typeof(bool));
		}
		public void Print(QPrinter printer) {
			interceptor.Invoke("print#", "print(QPrinter*) const", typeof(void), typeof(QPrinter), printer);
		}
		[Q_SLOT("void setFontPointSize(qreal)")]
		public void SetFontPointSize(double s) {
			interceptor.Invoke("setFontPointSize$", "setFontPointSize(qreal)", typeof(void), typeof(double), s);
		}
		[Q_SLOT("void setFontFamily(const QString&)")]
		public void SetFontFamily(string fontFamily) {
			interceptor.Invoke("setFontFamily$", "setFontFamily(const QString&)", typeof(void), typeof(string), fontFamily);
		}
		[Q_SLOT("void setFontWeight(int)")]
		public void SetFontWeight(int w) {
			interceptor.Invoke("setFontWeight$", "setFontWeight(int)", typeof(void), typeof(int), w);
		}
		[Q_SLOT("void setFontUnderline(bool)")]
		public void SetFontUnderline(bool b) {
			interceptor.Invoke("setFontUnderline$", "setFontUnderline(bool)", typeof(void), typeof(bool), b);
		}
		[Q_SLOT("void setFontItalic(bool)")]
		public void SetFontItalic(bool b) {
			interceptor.Invoke("setFontItalic$", "setFontItalic(bool)", typeof(void), typeof(bool), b);
		}
		[Q_SLOT("void setTextColor(const QColor&)")]
		public void SetTextColor(QColor c) {
			interceptor.Invoke("setTextColor#", "setTextColor(const QColor&)", typeof(void), typeof(QColor), c);
		}
		[Q_SLOT("void setCurrentFont(const QFont&)")]
		public void SetCurrentFont(QFont f) {
			interceptor.Invoke("setCurrentFont#", "setCurrentFont(const QFont&)", typeof(void), typeof(QFont), f);
		}
		[Q_SLOT("void setAlignment(Qt::Alignment)")]
		public void SetAlignment(int a) {
			interceptor.Invoke("setAlignment$", "setAlignment(Qt::Alignment)", typeof(void), typeof(int), a);
		}
		[Q_SLOT("void setPlainText(const QString&)")]
		public void SetPlainText(string text) {
			interceptor.Invoke("setPlainText$", "setPlainText(const QString&)", typeof(void), typeof(string), text);
		}
		[Q_SLOT("void setHtml(const QString&)")]
		public void SetHtml(string text) {
			interceptor.Invoke("setHtml$", "setHtml(const QString&)", typeof(void), typeof(string), text);
		}
		[Q_SLOT("void setText(const QString&)")]
		public void SetText(string text) {
			interceptor.Invoke("setText$", "setText(const QString&)", typeof(void), typeof(string), text);
		}
		[Q_SLOT("void cut()")]
		public void Cut() {
			interceptor.Invoke("cut", "cut()", typeof(void));
		}
		[Q_SLOT("void copy()")]
		public void Copy() {
			interceptor.Invoke("copy", "copy()", typeof(void));
		}
		[Q_SLOT("void paste()")]
		public void Paste() {
			interceptor.Invoke("paste", "paste()", typeof(void));
		}
		[Q_SLOT("void undo()")]
		public void Undo() {
			interceptor.Invoke("undo", "undo()", typeof(void));
		}
		[Q_SLOT("void redo()")]
		public void Redo() {
			interceptor.Invoke("redo", "redo()", typeof(void));
		}
		[Q_SLOT("void clear()")]
		public void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		[Q_SLOT("void selectAll()")]
		public void SelectAll() {
			interceptor.Invoke("selectAll", "selectAll()", typeof(void));
		}
		[Q_SLOT("void insertPlainText(const QString&)")]
		public void InsertPlainText(string text) {
			interceptor.Invoke("insertPlainText$", "insertPlainText(const QString&)", typeof(void), typeof(string), text);
		}
		[Q_SLOT("void insertHtml(const QString&)")]
		public void InsertHtml(string text) {
			interceptor.Invoke("insertHtml$", "insertHtml(const QString&)", typeof(void), typeof(string), text);
		}
		[Q_SLOT("void append(const QString&)")]
		public void Append(string text) {
			interceptor.Invoke("append$", "append(const QString&)", typeof(void), typeof(string), text);
		}
		[Q_SLOT("void scrollToAnchor(const QString&)")]
		public void ScrollToAnchor(string name) {
			interceptor.Invoke("scrollToAnchor$", "scrollToAnchor(const QString&)", typeof(void), typeof(string), name);
		}
		[Q_SLOT("void zoomIn(int)")]
		public void ZoomIn(int range) {
			interceptor.Invoke("zoomIn$", "zoomIn(int)", typeof(void), typeof(int), range);
		}
		[Q_SLOT("void zoomIn()")]
		public void ZoomIn() {
			interceptor.Invoke("zoomIn", "zoomIn()", typeof(void));
		}
		[Q_SLOT("void zoomOut(int)")]
		public void ZoomOut(int range) {
			interceptor.Invoke("zoomOut$", "zoomOut(int)", typeof(void), typeof(int), range);
		}
		[Q_SLOT("void zoomOut()")]
		public void ZoomOut() {
			interceptor.Invoke("zoomOut", "zoomOut()", typeof(void));
		}
		[SmokeMethod("event(QEvent*)")]
		protected override bool Event(QEvent e) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), e);
		}
		[SmokeMethod("timerEvent(QTimerEvent*)")]
		protected override void TimerEvent(QTimerEvent e) {
			interceptor.Invoke("timerEvent#", "timerEvent(QTimerEvent*)", typeof(void), typeof(QTimerEvent), e);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected override void KeyPressEvent(QKeyEvent e) {
			interceptor.Invoke("keyPressEvent#", "keyPressEvent(QKeyEvent*)", typeof(void), typeof(QKeyEvent), e);
		}
		[SmokeMethod("keyReleaseEvent(QKeyEvent*)")]
		protected override void KeyReleaseEvent(QKeyEvent e) {
			interceptor.Invoke("keyReleaseEvent#", "keyReleaseEvent(QKeyEvent*)", typeof(void), typeof(QKeyEvent), e);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected override void ResizeEvent(QResizeEvent e) {
			interceptor.Invoke("resizeEvent#", "resizeEvent(QResizeEvent*)", typeof(void), typeof(QResizeEvent), e);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected override void PaintEvent(QPaintEvent e) {
			interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), e);
		}
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected override void MousePressEvent(QMouseEvent e) {
			interceptor.Invoke("mousePressEvent#", "mousePressEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), e);
		}
		[SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
		protected override void MouseMoveEvent(QMouseEvent e) {
			interceptor.Invoke("mouseMoveEvent#", "mouseMoveEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), e);
		}
		[SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
		protected override void MouseReleaseEvent(QMouseEvent e) {
			interceptor.Invoke("mouseReleaseEvent#", "mouseReleaseEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), e);
		}
		[SmokeMethod("mouseDoubleClickEvent(QMouseEvent*)")]
		protected override void MouseDoubleClickEvent(QMouseEvent e) {
			interceptor.Invoke("mouseDoubleClickEvent#", "mouseDoubleClickEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), e);
		}
		[SmokeMethod("focusNextPrevChild(bool)")]
		protected override bool FocusNextPrevChild(bool next) {
			return (bool) interceptor.Invoke("focusNextPrevChild$", "focusNextPrevChild(bool)", typeof(bool), typeof(bool), next);
		}
		[SmokeMethod("contextMenuEvent(QContextMenuEvent*)")]
		protected override void ContextMenuEvent(QContextMenuEvent e) {
			interceptor.Invoke("contextMenuEvent#", "contextMenuEvent(QContextMenuEvent*)", typeof(void), typeof(QContextMenuEvent), e);
		}
		[SmokeMethod("dragEnterEvent(QDragEnterEvent*)")]
		protected override void DragEnterEvent(QDragEnterEvent e) {
			interceptor.Invoke("dragEnterEvent#", "dragEnterEvent(QDragEnterEvent*)", typeof(void), typeof(QDragEnterEvent), e);
		}
		[SmokeMethod("dragLeaveEvent(QDragLeaveEvent*)")]
		protected override void DragLeaveEvent(QDragLeaveEvent e) {
			interceptor.Invoke("dragLeaveEvent#", "dragLeaveEvent(QDragLeaveEvent*)", typeof(void), typeof(QDragLeaveEvent), e);
		}
		[SmokeMethod("dragMoveEvent(QDragMoveEvent*)")]
		protected override void DragMoveEvent(QDragMoveEvent e) {
			interceptor.Invoke("dragMoveEvent#", "dragMoveEvent(QDragMoveEvent*)", typeof(void), typeof(QDragMoveEvent), e);
		}
		[SmokeMethod("dropEvent(QDropEvent*)")]
		protected override void DropEvent(QDropEvent e) {
			interceptor.Invoke("dropEvent#", "dropEvent(QDropEvent*)", typeof(void), typeof(QDropEvent), e);
		}
		[SmokeMethod("focusInEvent(QFocusEvent*)")]
		protected override void FocusInEvent(QFocusEvent e) {
			interceptor.Invoke("focusInEvent#", "focusInEvent(QFocusEvent*)", typeof(void), typeof(QFocusEvent), e);
		}
		[SmokeMethod("focusOutEvent(QFocusEvent*)")]
		protected override void FocusOutEvent(QFocusEvent e) {
			interceptor.Invoke("focusOutEvent#", "focusOutEvent(QFocusEvent*)", typeof(void), typeof(QFocusEvent), e);
		}
		[SmokeMethod("showEvent(QShowEvent*)")]
		protected override void ShowEvent(QShowEvent arg1) {
			interceptor.Invoke("showEvent#", "showEvent(QShowEvent*)", typeof(void), typeof(QShowEvent), arg1);
		}
		[SmokeMethod("changeEvent(QEvent*)")]
		protected override void ChangeEvent(QEvent e) {
			interceptor.Invoke("changeEvent#", "changeEvent(QEvent*)", typeof(void), typeof(QEvent), e);
		}
		[SmokeMethod("wheelEvent(QWheelEvent*)")]
		protected override void WheelEvent(QWheelEvent e) {
			interceptor.Invoke("wheelEvent#", "wheelEvent(QWheelEvent*)", typeof(void), typeof(QWheelEvent), e);
		}
		[SmokeMethod("createMimeDataFromSelection() const")]
		protected virtual QMimeData CreateMimeDataFromSelection() {
			return (QMimeData) interceptor.Invoke("createMimeDataFromSelection", "createMimeDataFromSelection() const", typeof(QMimeData));
		}
		[SmokeMethod("canInsertFromMimeData(const QMimeData*) const")]
		protected virtual bool CanInsertFromMimeData(QMimeData source) {
			return (bool) interceptor.Invoke("canInsertFromMimeData#", "canInsertFromMimeData(const QMimeData*) const", typeof(bool), typeof(QMimeData), source);
		}
		[SmokeMethod("insertFromMimeData(const QMimeData*)")]
		protected virtual void InsertFromMimeData(QMimeData source) {
			interceptor.Invoke("insertFromMimeData#", "insertFromMimeData(const QMimeData*)", typeof(void), typeof(QMimeData), source);
		}
		[SmokeMethod("inputMethodEvent(QInputMethodEvent*)")]
		protected override void InputMethodEvent(QInputMethodEvent arg1) {
			interceptor.Invoke("inputMethodEvent#", "inputMethodEvent(QInputMethodEvent*)", typeof(void), typeof(QInputMethodEvent), arg1);
		}
		[SmokeMethod("inputMethodQuery(Qt::InputMethodQuery) const")]
		protected new virtual QVariant InputMethodQuery(Qt.InputMethodQuery property) {
			return (QVariant) interceptor.Invoke("inputMethodQuery$", "inputMethodQuery(Qt::InputMethodQuery) const", typeof(QVariant), typeof(Qt.InputMethodQuery), property);
		}
		[SmokeMethod("scrollContentsBy(int, int)")]
		protected override void ScrollContentsBy(int dx, int dy) {
			interceptor.Invoke("scrollContentsBy$$", "scrollContentsBy(int, int)", typeof(void), typeof(int), dx, typeof(int), dy);
		}
		~QTextEdit() {
			interceptor.Invoke("~QTextEdit", "~QTextEdit()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QTextEdit", "~QTextEdit()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQTextEditSignals Emit {
			get { return (IQTextEditSignals) Q_EMIT; }
		}
	}

	public interface IQTextEditSignals : IQAbstractScrollAreaSignals {
		[Q_SIGNAL("void textChanged()")]
		void TextChanged();
		[Q_SIGNAL("void undoAvailable(bool)")]
		void UndoAvailable(bool b);
		[Q_SIGNAL("void redoAvailable(bool)")]
		void RedoAvailable(bool b);
		[Q_SIGNAL("void currentCharFormatChanged(const QTextCharFormat&)")]
		void CurrentCharFormatChanged(QTextCharFormat format);
		[Q_SIGNAL("void copyAvailable(bool)")]
		void CopyAvailable(bool b);
		[Q_SIGNAL("void selectionChanged()")]
		void SelectionChanged();
		[Q_SIGNAL("void cursorPositionChanged()")]
		void CursorPositionChanged();
	}
}
