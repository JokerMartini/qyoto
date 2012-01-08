//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    /// <remarks> See <see cref="IQAbstractItemDelegateSignals"></see> for signals emitted by QAbstractItemDelegate
    /// </remarks>
    [SmokeClass("QAbstractItemDelegate")]
    public abstract class QAbstractItemDelegate : QObject {
        protected QAbstractItemDelegate(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QAbstractItemDelegate), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QAbstractItemDelegate() {
            staticInterceptor = new SmokeInvocation(typeof(QAbstractItemDelegate), null);
        }
        public enum EndEditHint {
            NoHint = 0,
            EditNextItem = 1,
            EditPreviousItem = 2,
            SubmitModelCache = 3,
            RevertModelCache = 4,
        }
        // QAbstractItemDelegate* QAbstractItemDelegate(QObjectPrivate& arg1,QObject* arg2); >>>> NOT CONVERTED
        // QAbstractItemDelegate* QAbstractItemDelegate(QObjectPrivate& arg1); >>>> NOT CONVERTED
        public QAbstractItemDelegate(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QAbstractItemDelegate#", "QAbstractItemDelegate(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public QAbstractItemDelegate() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QAbstractItemDelegate", "QAbstractItemDelegate()", typeof(void));
        }
        [SmokeMethod("paint(QPainter*, const QStyleOptionViewItem&, const QModelIndex&) const")]
        public abstract void Paint(QPainter painter, QStyleOptionViewItem option, QModelIndex index);
        [SmokeMethod("sizeHint(const QStyleOptionViewItem&, const QModelIndex&) const")]
        public new abstract QSize SizeHint(QStyleOptionViewItem option, QModelIndex index);
        [SmokeMethod("createEditor(QWidget*, const QStyleOptionViewItem&, const QModelIndex&) const")]
        public virtual QWidget CreateEditor(QWidget parent, QStyleOptionViewItem option, QModelIndex index) {
            return (QWidget) interceptor.Invoke("createEditor###", "createEditor(QWidget*, const QStyleOptionViewItem&, const QModelIndex&) const", typeof(QWidget), typeof(QWidget), parent, typeof(QStyleOptionViewItem), option, typeof(QModelIndex), index);
        }
        [SmokeMethod("setEditorData(QWidget*, const QModelIndex&) const")]
        public virtual void SetEditorData(QWidget editor, QModelIndex index) {
            interceptor.Invoke("setEditorData##", "setEditorData(QWidget*, const QModelIndex&) const", typeof(void), typeof(QWidget), editor, typeof(QModelIndex), index);
        }
        [SmokeMethod("setModelData(QWidget*, QAbstractItemModel*, const QModelIndex&) const")]
        public virtual void SetModelData(QWidget editor, QAbstractItemModel model, QModelIndex index) {
            interceptor.Invoke("setModelData###", "setModelData(QWidget*, QAbstractItemModel*, const QModelIndex&) const", typeof(void), typeof(QWidget), editor, typeof(QAbstractItemModel), model, typeof(QModelIndex), index);
        }
        [SmokeMethod("updateEditorGeometry(QWidget*, const QStyleOptionViewItem&, const QModelIndex&) const")]
        public virtual void UpdateEditorGeometry(QWidget editor, QStyleOptionViewItem option, QModelIndex index) {
            interceptor.Invoke("updateEditorGeometry###", "updateEditorGeometry(QWidget*, const QStyleOptionViewItem&, const QModelIndex&) const", typeof(void), typeof(QWidget), editor, typeof(QStyleOptionViewItem), option, typeof(QModelIndex), index);
        }
        [SmokeMethod("editorEvent(QEvent*, QAbstractItemModel*, const QStyleOptionViewItem&, const QModelIndex&)")]
        public virtual bool EditorEvent(QEvent arg1, QAbstractItemModel model, QStyleOptionViewItem option, QModelIndex index) {
            return (bool) interceptor.Invoke("editorEvent####", "editorEvent(QEvent*, QAbstractItemModel*, const QStyleOptionViewItem&, const QModelIndex&)", typeof(bool), typeof(QEvent), arg1, typeof(QAbstractItemModel), model, typeof(QStyleOptionViewItem), option, typeof(QModelIndex), index);
        }
        [Q_SLOT("bool helpEvent(QHelpEvent*, QAbstractItemView*, QStyleOptionViewItem, QModelIndex)")]
        public bool HelpEvent(QHelpEvent arg1, QAbstractItemView view, QStyleOptionViewItem option, QModelIndex index) {
            return (bool) interceptor.Invoke("helpEvent####", "helpEvent(QHelpEvent*, QAbstractItemView*, const QStyleOptionViewItem&, const QModelIndex&)", typeof(bool), typeof(QHelpEvent), arg1, typeof(QAbstractItemView), view, typeof(QStyleOptionViewItem), option, typeof(QModelIndex), index);
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        public static string ElidedText(QFontMetrics fontMetrics, int width, Qt.TextElideMode mode, string text) {
            return (string) staticInterceptor.Invoke("elidedText#$$$", "elidedText(const QFontMetrics&, int, Qt::TextElideMode, const QString&)", typeof(string), typeof(QFontMetrics), fontMetrics, typeof(int), width, typeof(Qt.TextElideMode), mode, typeof(string), text);
        }
        protected new IQAbstractItemDelegateSignals Emit {
            get { return (IQAbstractItemDelegateSignals) Q_EMIT; }
        }
    }

    public interface IQAbstractItemDelegateSignals : IQObjectSignals {
        [Q_SIGNAL("void commitData(QWidget*)")]
        void CommitData(QWidget editor);
        [Q_SIGNAL("void closeEditor(QWidget*, QAbstractItemDelegate::EndEditHint)")]
        void CloseEditor(QWidget editor, QAbstractItemDelegate.EndEditHint hint);
        [Q_SIGNAL("void closeEditor(QWidget*)")]
        void CloseEditor(QWidget editor);
        [Q_SIGNAL("void sizeHintChanged(QModelIndex)")]
        void SizeHintChanged(QModelIndex arg1);
    }
}