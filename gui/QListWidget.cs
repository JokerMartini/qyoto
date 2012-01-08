//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Collections.Generic;
    /// <remarks> See <see cref="IQListWidgetSignals"></see> for signals emitted by QListWidget
    /// </remarks>
    [SmokeClass("QListWidget")]
    public class QListWidget : QListView, IDisposable {
        protected QListWidget(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QListWidget), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QListWidget() {
            staticInterceptor = new SmokeInvocation(typeof(QListWidget), null);
        }
        [Q_PROPERTY("int", "count")]
        public int Count {
            get { return (int) interceptor.Invoke("count", "count()", typeof(int)); }
        }
        [Q_PROPERTY("int", "currentRow")]
        public int CurrentRow {
            get { return (int) interceptor.Invoke("currentRow", "currentRow()", typeof(int)); }
            set { interceptor.Invoke("setCurrentRow$", "setCurrentRow(int)", typeof(void), typeof(int), value); }
        }
        [Q_PROPERTY("bool", "sortingEnabled")]
        public bool SortingEnabled {
            get { return (bool) interceptor.Invoke("isSortingEnabled", "isSortingEnabled()", typeof(bool)); }
            set { interceptor.Invoke("setSortingEnabled$", "setSortingEnabled(bool)", typeof(void), typeof(bool), value); }
        }
        public QListWidget(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QListWidget#", "QListWidget(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public QListWidget() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QListWidget", "QListWidget()", typeof(void));
        }
        public QListWidgetItem Item(int row) {
            return (QListWidgetItem) interceptor.Invoke("item$", "item(int) const", typeof(QListWidgetItem), typeof(int), row);
        }
        public int Row(QListWidgetItem item) {
            return (int) interceptor.Invoke("row#", "row(const QListWidgetItem*) const", typeof(int), typeof(QListWidgetItem), item);
        }
        public void InsertItem(int row, QListWidgetItem item) {
            interceptor.Invoke("insertItem$#", "insertItem(int, QListWidgetItem*)", typeof(void), typeof(int), row, typeof(QListWidgetItem), item);
        }
        public void InsertItem(int row, string label) {
            interceptor.Invoke("insertItem$$", "insertItem(int, const QString&)", typeof(void), typeof(int), row, typeof(string), label);
        }
        public void InsertItems(int row, List<string> labels) {
            interceptor.Invoke("insertItems$?", "insertItems(int, const QStringList&)", typeof(void), typeof(int), row, typeof(List<string>), labels);
        }
        public void AddItem(string label) {
            interceptor.Invoke("addItem$", "addItem(const QString&)", typeof(void), typeof(string), label);
        }
        public void AddItem(QListWidgetItem item) {
            interceptor.Invoke("addItem#", "addItem(QListWidgetItem*)", typeof(void), typeof(QListWidgetItem), item);
        }
        public void AddItems(List<string> labels) {
            interceptor.Invoke("addItems?", "addItems(const QStringList&)", typeof(void), typeof(List<string>), labels);
        }
        public QListWidgetItem TakeItem(int row) {
            return (QListWidgetItem) interceptor.Invoke("takeItem$", "takeItem(int)", typeof(QListWidgetItem), typeof(int), row);
        }
        public QListWidgetItem CurrentItem() {
            return (QListWidgetItem) interceptor.Invoke("currentItem", "currentItem() const", typeof(QListWidgetItem));
        }
        public void SetCurrentItem(QListWidgetItem item) {
            interceptor.Invoke("setCurrentItem#", "setCurrentItem(QListWidgetItem*)", typeof(void), typeof(QListWidgetItem), item);
        }
        public void SetCurrentItem(QListWidgetItem item, uint command) {
            interceptor.Invoke("setCurrentItem#$", "setCurrentItem(QListWidgetItem*, QItemSelectionModel::SelectionFlags)", typeof(void), typeof(QListWidgetItem), item, typeof(uint), command);
        }
        public void SetCurrentRow(int row, uint command) {
            interceptor.Invoke("setCurrentRow$$", "setCurrentRow(int, QItemSelectionModel::SelectionFlags)", typeof(void), typeof(int), row, typeof(uint), command);
        }
        public QListWidgetItem ItemAt(QPoint p) {
            return (QListWidgetItem) interceptor.Invoke("itemAt#", "itemAt(const QPoint&) const", typeof(QListWidgetItem), typeof(QPoint), p);
        }
        public QListWidgetItem ItemAt(int x, int y) {
            return (QListWidgetItem) interceptor.Invoke("itemAt$$", "itemAt(int, int) const", typeof(QListWidgetItem), typeof(int), x, typeof(int), y);
        }
        public QRect VisualItemRect(QListWidgetItem item) {
            return (QRect) interceptor.Invoke("visualItemRect#", "visualItemRect(const QListWidgetItem*) const", typeof(QRect), typeof(QListWidgetItem), item);
        }
        public void SortItems(Qt.SortOrder order) {
            interceptor.Invoke("sortItems$", "sortItems(Qt::SortOrder)", typeof(void), typeof(Qt.SortOrder), order);
        }
        public void SortItems() {
            interceptor.Invoke("sortItems", "sortItems()", typeof(void));
        }
        public void EditItem(QListWidgetItem item) {
            interceptor.Invoke("editItem#", "editItem(QListWidgetItem*)", typeof(void), typeof(QListWidgetItem), item);
        }
        public void OpenPersistentEditor(QListWidgetItem item) {
            interceptor.Invoke("openPersistentEditor#", "openPersistentEditor(QListWidgetItem*)", typeof(void), typeof(QListWidgetItem), item);
        }
        public void ClosePersistentEditor(QListWidgetItem item) {
            interceptor.Invoke("closePersistentEditor#", "closePersistentEditor(QListWidgetItem*)", typeof(void), typeof(QListWidgetItem), item);
        }
        public QWidget ItemWidget(QListWidgetItem item) {
            return (QWidget) interceptor.Invoke("itemWidget#", "itemWidget(QListWidgetItem*) const", typeof(QWidget), typeof(QListWidgetItem), item);
        }
        public void SetItemWidget(QListWidgetItem item, QWidget widget) {
            interceptor.Invoke("setItemWidget##", "setItemWidget(QListWidgetItem*, QWidget*)", typeof(void), typeof(QListWidgetItem), item, typeof(QWidget), widget);
        }
        public void RemoveItemWidget(QListWidgetItem item) {
            interceptor.Invoke("removeItemWidget#", "removeItemWidget(QListWidgetItem*)", typeof(void), typeof(QListWidgetItem), item);
        }
        public bool IsItemSelected(QListWidgetItem item) {
            return (bool) interceptor.Invoke("isItemSelected#", "isItemSelected(const QListWidgetItem*) const", typeof(bool), typeof(QListWidgetItem), item);
        }
        public void SetItemSelected(QListWidgetItem item, bool select) {
            interceptor.Invoke("setItemSelected#$", "setItemSelected(const QListWidgetItem*, bool)", typeof(void), typeof(QListWidgetItem), item, typeof(bool), select);
        }
        public List<QListWidgetItem> SelectedItems() {
            return (List<QListWidgetItem>) interceptor.Invoke("selectedItems", "selectedItems() const", typeof(List<QListWidgetItem>));
        }
        public List<QListWidgetItem> FindItems(string text, uint flags) {
            return (List<QListWidgetItem>) interceptor.Invoke("findItems$$", "findItems(const QString&, Qt::MatchFlags) const", typeof(List<QListWidgetItem>), typeof(string), text, typeof(uint), flags);
        }
        public bool IsItemHidden(QListWidgetItem item) {
            return (bool) interceptor.Invoke("isItemHidden#", "isItemHidden(const QListWidgetItem*) const", typeof(bool), typeof(QListWidgetItem), item);
        }
        public void SetItemHidden(QListWidgetItem item, bool hide) {
            interceptor.Invoke("setItemHidden#$", "setItemHidden(const QListWidgetItem*, bool)", typeof(void), typeof(QListWidgetItem), item, typeof(bool), hide);
        }
        [SmokeMethod("dropEvent(QDropEvent*)")]
        public new virtual void DropEvent(QDropEvent arg1) {
            interceptor.Invoke("dropEvent#", "dropEvent(QDropEvent*)", typeof(void), typeof(QDropEvent), arg1);
        }
        [Q_SLOT("void scrollToItem(QListWidgetItem*, QAbstractItemView::ScrollHint)")]
        public void ScrollToItem(QListWidgetItem item, QAbstractItemView.ScrollHint hint) {
            interceptor.Invoke("scrollToItem#$", "scrollToItem(const QListWidgetItem*, QAbstractItemView::ScrollHint)", typeof(void), typeof(QListWidgetItem), item, typeof(QAbstractItemView.ScrollHint), hint);
        }
        [Q_SLOT("void scrollToItem(QListWidgetItem*)")]
        public void ScrollToItem(QListWidgetItem item) {
            interceptor.Invoke("scrollToItem#", "scrollToItem(const QListWidgetItem*)", typeof(void), typeof(QListWidgetItem), item);
        }
        [Q_SLOT("void clear()")]
        public void Clear() {
            interceptor.Invoke("clear", "clear()", typeof(void));
        }
        [SmokeMethod("event(QEvent*)")]
        protected override bool Event(QEvent e) {
            return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), e);
        }
        [SmokeMethod("mimeTypes() const")]
        protected virtual List<string> MimeTypes() {
            return (List<string>) interceptor.Invoke("mimeTypes", "mimeTypes() const", typeof(List<string>));
        }
        [SmokeMethod("mimeData(const QList<QListWidgetItem*>) const")]
        protected virtual QMimeData MimeData(List<QListWidgetItem> items) {
            return (QMimeData) interceptor.Invoke("mimeData?", "mimeData(const QList<QListWidgetItem*>) const", typeof(QMimeData), typeof(List<QListWidgetItem>), items);
        }
        [SmokeMethod("dropMimeData(int, const QMimeData*, Qt::DropAction)")]
        protected virtual bool DropMimeData(int index, QMimeData data, Qt.DropAction action) {
            return (bool) interceptor.Invoke("dropMimeData$#$", "dropMimeData(int, const QMimeData*, Qt::DropAction)", typeof(bool), typeof(int), index, typeof(QMimeData), data, typeof(Qt.DropAction), action);
        }
        [SmokeMethod("supportedDropActions() const")]
        protected virtual uint SupportedDropActions() {
            return (uint) interceptor.Invoke("supportedDropActions", "supportedDropActions() const", typeof(uint));
        }
        protected List<QListWidgetItem> Items(QMimeData data) {
            return (List<QListWidgetItem>) interceptor.Invoke("items#", "items(const QMimeData*) const", typeof(List<QListWidgetItem>), typeof(QMimeData), data);
        }
        protected QModelIndex IndexFromItem(QListWidgetItem item) {
            return (QModelIndex) interceptor.Invoke("indexFromItem#", "indexFromItem(QListWidgetItem*) const", typeof(QModelIndex), typeof(QListWidgetItem), item);
        }
        protected QListWidgetItem ItemFromIndex(QModelIndex index) {
            return (QListWidgetItem) interceptor.Invoke("itemFromIndex#", "itemFromIndex(const QModelIndex&) const", typeof(QListWidgetItem), typeof(QModelIndex), index);
        }
        ~QListWidget() {
            interceptor.Invoke("~QListWidget", "~QListWidget()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QListWidget", "~QListWidget()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQListWidgetSignals Emit {
            get { return (IQListWidgetSignals) Q_EMIT; }
        }
    }

    public interface IQListWidgetSignals : IQListViewSignals {
        [Q_SIGNAL("void itemPressed(QListWidgetItem*)")]
        void ItemPressed(QListWidgetItem item);
        [Q_SIGNAL("void itemClicked(QListWidgetItem*)")]
        void ItemClicked(QListWidgetItem item);
        [Q_SIGNAL("void itemDoubleClicked(QListWidgetItem*)")]
        void ItemDoubleClicked(QListWidgetItem item);
        [Q_SIGNAL("void itemActivated(QListWidgetItem*)")]
        void ItemActivated(QListWidgetItem item);
        [Q_SIGNAL("void itemEntered(QListWidgetItem*)")]
        void ItemEntered(QListWidgetItem item);
        [Q_SIGNAL("void itemChanged(QListWidgetItem*)")]
        void ItemChanged(QListWidgetItem item);
        [Q_SIGNAL("void currentItemChanged(QListWidgetItem*, QListWidgetItem*)")]
        void CurrentItemChanged(QListWidgetItem current, QListWidgetItem previous);
        [Q_SIGNAL("void currentTextChanged(QString)")]
        void CurrentTextChanged(string currentText);
        [Q_SIGNAL("void currentRowChanged(int)")]
        void CurrentRowChanged(int currentRow);
        [Q_SIGNAL("void itemSelectionChanged()")]
        void ItemSelectionChanged();
    }
}