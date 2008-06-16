//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	[SmokeClass("QItemDelegate")]
	public class QItemDelegate : QAbstractItemDelegate, IDisposable {
 		protected QItemDelegate(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QItemDelegate), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QItemDelegate() {
			staticInterceptor = new SmokeInvocation(typeof(QItemDelegate), null);
		}
		[Q_PROPERTY("bool", "clipping")]
		public bool Clipping {
			get { return (bool) interceptor.Invoke("hasClipping", "hasClipping()", typeof(bool)); }
			set { interceptor.Invoke("setClipping$", "setClipping(bool)", typeof(void), typeof(bool), value); }
		}
		public QItemDelegate(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QItemDelegate#", "QItemDelegate(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public QItemDelegate() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QItemDelegate", "QItemDelegate()", typeof(void));
		}
		[SmokeMethod("paint(QPainter*, const QStyleOptionViewItem&, const QModelIndex&) const")]
		public override void Paint(QPainter painter, QStyleOptionViewItem option, QModelIndex index) {
			interceptor.Invoke("paint###", "paint(QPainter*, const QStyleOptionViewItem&, const QModelIndex&) const", typeof(void), typeof(QPainter), painter, typeof(QStyleOptionViewItem), option, typeof(QModelIndex), index);
		}
		[SmokeMethod("sizeHint(const QStyleOptionViewItem&, const QModelIndex&) const")]
		public override QSize SizeHint(QStyleOptionViewItem option, QModelIndex index) {
			return (QSize) interceptor.Invoke("sizeHint##", "sizeHint(const QStyleOptionViewItem&, const QModelIndex&) const", typeof(QSize), typeof(QStyleOptionViewItem), option, typeof(QModelIndex), index);
		}
		[SmokeMethod("createEditor(QWidget*, const QStyleOptionViewItem&, const QModelIndex&) const")]
		public override QWidget CreateEditor(QWidget parent, QStyleOptionViewItem option, QModelIndex index) {
			return (QWidget) interceptor.Invoke("createEditor###", "createEditor(QWidget*, const QStyleOptionViewItem&, const QModelIndex&) const", typeof(QWidget), typeof(QWidget), parent, typeof(QStyleOptionViewItem), option, typeof(QModelIndex), index);
		}
		[SmokeMethod("setEditorData(QWidget*, const QModelIndex&) const")]
		public override void SetEditorData(QWidget editor, QModelIndex index) {
			interceptor.Invoke("setEditorData##", "setEditorData(QWidget*, const QModelIndex&) const", typeof(void), typeof(QWidget), editor, typeof(QModelIndex), index);
		}
		[SmokeMethod("setModelData(QWidget*, QAbstractItemModel*, const QModelIndex&) const")]
		public override void SetModelData(QWidget editor, QAbstractItemModel model, QModelIndex index) {
			interceptor.Invoke("setModelData###", "setModelData(QWidget*, QAbstractItemModel*, const QModelIndex&) const", typeof(void), typeof(QWidget), editor, typeof(QAbstractItemModel), model, typeof(QModelIndex), index);
		}
		[SmokeMethod("updateEditorGeometry(QWidget*, const QStyleOptionViewItem&, const QModelIndex&) const")]
		public override void UpdateEditorGeometry(QWidget editor, QStyleOptionViewItem option, QModelIndex index) {
			interceptor.Invoke("updateEditorGeometry###", "updateEditorGeometry(QWidget*, const QStyleOptionViewItem&, const QModelIndex&) const", typeof(void), typeof(QWidget), editor, typeof(QStyleOptionViewItem), option, typeof(QModelIndex), index);
		}
		public QItemEditorFactory ItemEditorFactory() {
			return (QItemEditorFactory) interceptor.Invoke("itemEditorFactory", "itemEditorFactory() const", typeof(QItemEditorFactory));
		}
		public void SetItemEditorFactory(QItemEditorFactory factory) {
			interceptor.Invoke("setItemEditorFactory#", "setItemEditorFactory(QItemEditorFactory*)", typeof(void), typeof(QItemEditorFactory), factory);
		}
		[SmokeMethod("drawDisplay(QPainter*, const QStyleOptionViewItem&, const QRect&, const QString&) const")]
		protected virtual void DrawDisplay(QPainter painter, QStyleOptionViewItem option, QRect rect, string text) {
			interceptor.Invoke("drawDisplay###$", "drawDisplay(QPainter*, const QStyleOptionViewItem&, const QRect&, const QString&) const", typeof(void), typeof(QPainter), painter, typeof(QStyleOptionViewItem), option, typeof(QRect), rect, typeof(string), text);
		}
		[SmokeMethod("drawDecoration(QPainter*, const QStyleOptionViewItem&, const QRect&, const QPixmap&) const")]
		protected virtual void DrawDecoration(QPainter painter, QStyleOptionViewItem option, QRect rect, QPixmap pixmap) {
			interceptor.Invoke("drawDecoration####", "drawDecoration(QPainter*, const QStyleOptionViewItem&, const QRect&, const QPixmap&) const", typeof(void), typeof(QPainter), painter, typeof(QStyleOptionViewItem), option, typeof(QRect), rect, typeof(QPixmap), pixmap);
		}
		[SmokeMethod("drawFocus(QPainter*, const QStyleOptionViewItem&, const QRect&) const")]
		protected virtual void DrawFocus(QPainter painter, QStyleOptionViewItem option, QRect rect) {
			interceptor.Invoke("drawFocus###", "drawFocus(QPainter*, const QStyleOptionViewItem&, const QRect&) const", typeof(void), typeof(QPainter), painter, typeof(QStyleOptionViewItem), option, typeof(QRect), rect);
		}
		[SmokeMethod("drawCheck(QPainter*, const QStyleOptionViewItem&, const QRect&, Qt::CheckState) const")]
		protected virtual void DrawCheck(QPainter painter, QStyleOptionViewItem option, QRect rect, Qt.CheckState state) {
			interceptor.Invoke("drawCheck###$", "drawCheck(QPainter*, const QStyleOptionViewItem&, const QRect&, Qt::CheckState) const", typeof(void), typeof(QPainter), painter, typeof(QStyleOptionViewItem), option, typeof(QRect), rect, typeof(Qt.CheckState), state);
		}
		protected void DrawBackground(QPainter painter, QStyleOptionViewItem option, QModelIndex index) {
			interceptor.Invoke("drawBackground###", "drawBackground(QPainter*, const QStyleOptionViewItem&, const QModelIndex&) const", typeof(void), typeof(QPainter), painter, typeof(QStyleOptionViewItem), option, typeof(QModelIndex), index);
		}
		protected void DoLayout(QStyleOptionViewItem option, QRect checkRect, QRect iconRect, QRect textRect, bool hint) {
			interceptor.Invoke("doLayout####$", "doLayout(const QStyleOptionViewItem&, QRect*, QRect*, QRect*, bool) const", typeof(void), typeof(QStyleOptionViewItem), option, typeof(QRect), checkRect, typeof(QRect), iconRect, typeof(QRect), textRect, typeof(bool), hint);
		}
		protected QRect Rect(QStyleOptionViewItem option, QModelIndex index, int role) {
			return (QRect) interceptor.Invoke("rect##$", "rect(const QStyleOptionViewItem&, const QModelIndex&, int) const", typeof(QRect), typeof(QStyleOptionViewItem), option, typeof(QModelIndex), index, typeof(int), role);
		}
		[SmokeMethod("eventFilter(QObject*, QEvent*)")]
		protected new virtual bool EventFilter(QObject arg1, QEvent arg2) {
			return (bool) interceptor.Invoke("eventFilter##", "eventFilter(QObject*, QEvent*)", typeof(bool), typeof(QObject), arg1, typeof(QEvent), arg2);
		}
		[SmokeMethod("editorEvent(QEvent*, QAbstractItemModel*, const QStyleOptionViewItem&, const QModelIndex&)")]
		protected new virtual bool EditorEvent(QEvent arg1, QAbstractItemModel model, QStyleOptionViewItem option, QModelIndex index) {
			return (bool) interceptor.Invoke("editorEvent####", "editorEvent(QEvent*, QAbstractItemModel*, const QStyleOptionViewItem&, const QModelIndex&)", typeof(bool), typeof(QEvent), arg1, typeof(QAbstractItemModel), model, typeof(QStyleOptionViewItem), option, typeof(QModelIndex), index);
		}
		protected QStyleOptionViewItem SetOptions(QModelIndex index, QStyleOptionViewItem option) {
			return (QStyleOptionViewItem) interceptor.Invoke("setOptions##", "setOptions(const QModelIndex&, const QStyleOptionViewItem&) const", typeof(QStyleOptionViewItem), typeof(QModelIndex), index, typeof(QStyleOptionViewItem), option);
		}
		protected QPixmap Decoration(QStyleOptionViewItem option, QVariant variant) {
			return (QPixmap) interceptor.Invoke("decoration##", "decoration(const QStyleOptionViewItem&, const QVariant&) const", typeof(QPixmap), typeof(QStyleOptionViewItem), option, typeof(QVariant), variant);
		}
		protected QPixmap Selected(QPixmap pixmap, QPalette palette, bool enabled) {
			return (QPixmap) interceptor.Invoke("selected##$", "selected(const QPixmap&, const QPalette&, bool) const", typeof(QPixmap), typeof(QPixmap), pixmap, typeof(QPalette), palette, typeof(bool), enabled);
		}
		protected QRect Check(QStyleOptionViewItem option, QRect bounding, QVariant variant) {
			return (QRect) interceptor.Invoke("check###", "check(const QStyleOptionViewItem&, const QRect&, const QVariant&) const", typeof(QRect), typeof(QStyleOptionViewItem), option, typeof(QRect), bounding, typeof(QVariant), variant);
		}
		protected QRect TextRectangle(QPainter painter, QRect rect, QFont font, string text) {
			return (QRect) interceptor.Invoke("textRectangle###$", "textRectangle(QPainter*, const QRect&, const QFont&, const QString&) const", typeof(QRect), typeof(QPainter), painter, typeof(QRect), rect, typeof(QFont), font, typeof(string), text);
		}
		~QItemDelegate() {
			interceptor.Invoke("~QItemDelegate", "~QItemDelegate()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QItemDelegate", "~QItemDelegate()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQItemDelegateSignals Emit {
			get { return (IQItemDelegateSignals) Q_EMIT; }
		}
	}

	public interface IQItemDelegateSignals : IQAbstractItemDelegateSignals {
	}
}
