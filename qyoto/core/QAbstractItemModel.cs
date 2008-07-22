//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Collections.Generic;
    /// <remarks> See <see cref="IQAbstractItemModelSignals"></see> for signals emitted by QAbstractItemModel
    /// </remarks>
    [SmokeClass("QAbstractItemModel")]
    public abstract partial class QAbstractItemModel : QObject {
        protected QAbstractItemModel(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QAbstractItemModel), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QAbstractItemModel() {
            staticInterceptor = new SmokeInvocation(typeof(QAbstractItemModel), null);
        }
        // QAbstractItemModel* QAbstractItemModel(QAbstractItemModelPrivate& arg1,QObject* arg2); >>>> NOT CONVERTED
        // QAbstractItemModel* QAbstractItemModel(QAbstractItemModelPrivate& arg1); >>>> NOT CONVERTED
        // QModelIndex createIndex(int arg1,int arg2,void* arg3); >>>> NOT CONVERTED
        public QAbstractItemModel(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QAbstractItemModel#", "QAbstractItemModel(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public QAbstractItemModel() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QAbstractItemModel", "QAbstractItemModel()", typeof(void));
        }
        public bool HasIndex(int row, int column, QModelIndex parent) {
            return (bool) interceptor.Invoke("hasIndex$$#", "hasIndex(int, int, const QModelIndex&) const", typeof(bool), typeof(int), row, typeof(int), column, typeof(QModelIndex), parent);
        }
        public bool HasIndex(int row, int column) {
            return (bool) interceptor.Invoke("hasIndex$$", "hasIndex(int, int) const", typeof(bool), typeof(int), row, typeof(int), column);
        }
        [SmokeMethod("index(int, int, const QModelIndex&) const")]
        public abstract QModelIndex Index(int row, int column, QModelIndex parent);
        [SmokeMethod("parent(const QModelIndex&) const")]
        public abstract QModelIndex Parent(QModelIndex child);
        public QModelIndex Sibling(int row, int column, QModelIndex idx) {
            return (QModelIndex) interceptor.Invoke("sibling$$#", "sibling(int, int, const QModelIndex&) const", typeof(QModelIndex), typeof(int), row, typeof(int), column, typeof(QModelIndex), idx);
        }
        [SmokeMethod("rowCount(const QModelIndex&) const")]
        public abstract int RowCount(QModelIndex parent);
        [SmokeMethod("columnCount(const QModelIndex&) const")]
        public abstract int ColumnCount(QModelIndex parent);
        [SmokeMethod("hasChildren(const QModelIndex&) const")]
        public virtual bool HasChildren(QModelIndex parent) {
            return (bool) interceptor.Invoke("hasChildren#", "hasChildren(const QModelIndex&) const", typeof(bool), typeof(QModelIndex), parent);
        }
        [SmokeMethod("hasChildren() const")]
        public virtual bool HasChildren() {
            return (bool) interceptor.Invoke("hasChildren", "hasChildren() const", typeof(bool));
        }
        [SmokeMethod("data(const QModelIndex&, int) const")]
        public abstract QVariant Data(QModelIndex index, int role);
        [SmokeMethod("setData(const QModelIndex&, const QVariant&, int)")]
        public virtual bool SetData(QModelIndex index, QVariant value, int role) {
            return (bool) interceptor.Invoke("setData##$", "setData(const QModelIndex&, const QVariant&, int)", typeof(bool), typeof(QModelIndex), index, typeof(QVariant), value, typeof(int), role);
        }
        [SmokeMethod("setData(const QModelIndex&, const QVariant&)")]
        public virtual bool SetData(QModelIndex index, QVariant value) {
            return (bool) interceptor.Invoke("setData##", "setData(const QModelIndex&, const QVariant&)", typeof(bool), typeof(QModelIndex), index, typeof(QVariant), value);
        }
        [SmokeMethod("headerData(int, Qt::Orientation, int) const")]
        public virtual QVariant HeaderData(int section, Qt.Orientation orientation, int role) {
            return (QVariant) interceptor.Invoke("headerData$$$", "headerData(int, Qt::Orientation, int) const", typeof(QVariant), typeof(int), section, typeof(Qt.Orientation), orientation, typeof(int), role);
        }
        [SmokeMethod("headerData(int, Qt::Orientation) const")]
        public virtual QVariant HeaderData(int section, Qt.Orientation orientation) {
            return (QVariant) interceptor.Invoke("headerData$$", "headerData(int, Qt::Orientation) const", typeof(QVariant), typeof(int), section, typeof(Qt.Orientation), orientation);
        }
        [SmokeMethod("setHeaderData(int, Qt::Orientation, const QVariant&, int)")]
        public virtual bool SetHeaderData(int section, Qt.Orientation orientation, QVariant value, int role) {
            return (bool) interceptor.Invoke("setHeaderData$$#$", "setHeaderData(int, Qt::Orientation, const QVariant&, int)", typeof(bool), typeof(int), section, typeof(Qt.Orientation), orientation, typeof(QVariant), value, typeof(int), role);
        }
        [SmokeMethod("setHeaderData(int, Qt::Orientation, const QVariant&)")]
        public virtual bool SetHeaderData(int section, Qt.Orientation orientation, QVariant value) {
            return (bool) interceptor.Invoke("setHeaderData$$#", "setHeaderData(int, Qt::Orientation, const QVariant&)", typeof(bool), typeof(int), section, typeof(Qt.Orientation), orientation, typeof(QVariant), value);
        }
        [SmokeMethod("itemData(const QModelIndex&) const")]
        public virtual Dictionary<int, QVariant> ItemData(QModelIndex index) {
            return (Dictionary<int, QVariant>) interceptor.Invoke("itemData#", "itemData(const QModelIndex&) const", typeof(Dictionary<int, QVariant>), typeof(QModelIndex), index);
        }
        [SmokeMethod("setItemData(const QModelIndex&, const QMap<int, QVariant>&)")]
        public virtual bool SetItemData(QModelIndex index, Dictionary<int, QVariant> roles) {
            return (bool) interceptor.Invoke("setItemData#?", "setItemData(const QModelIndex&, const QMap<int,QVariant>&)", typeof(bool), typeof(QModelIndex), index, typeof(Dictionary<int, QVariant>), roles);
        }
        [SmokeMethod("mimeTypes() const")]
        public virtual List<string> MimeTypes() {
            return (List<string>) interceptor.Invoke("mimeTypes", "mimeTypes() const", typeof(List<string>));
        }
        [SmokeMethod("mimeData(const QList<QModelIndex>&) const")]
        public virtual QMimeData MimeData(List<QModelIndex> indexes) {
            return (QMimeData) interceptor.Invoke("mimeData?", "mimeData(const QList<QModelIndex>&) const", typeof(QMimeData), typeof(List<QModelIndex>), indexes);
        }
        [SmokeMethod("dropMimeData(const QMimeData*, Qt::DropAction, int, int, const QModelIndex&)")]
        public virtual bool DropMimeData(QMimeData data, Qt.DropAction action, int row, int column, QModelIndex parent) {
            return (bool) interceptor.Invoke("dropMimeData#$$$#", "dropMimeData(const QMimeData*, Qt::DropAction, int, int, const QModelIndex&)", typeof(bool), typeof(QMimeData), data, typeof(Qt.DropAction), action, typeof(int), row, typeof(int), column, typeof(QModelIndex), parent);
        }
        [SmokeMethod("supportedDropActions() const")]
        public virtual uint SupportedDropActions() {
            return (uint) interceptor.Invoke("supportedDropActions", "supportedDropActions() const", typeof(uint));
        }
        public uint SupportedDragActions() {
            return (uint) interceptor.Invoke("supportedDragActions", "supportedDragActions() const", typeof(uint));
        }
        public void SetSupportedDragActions(uint arg1) {
            interceptor.Invoke("setSupportedDragActions$", "setSupportedDragActions(Qt::DropActions)", typeof(void), typeof(uint), arg1);
        }
        [SmokeMethod("insertRows(int, int, const QModelIndex&)")]
        public virtual bool InsertRows(int row, int count, QModelIndex parent) {
            return (bool) interceptor.Invoke("insertRows$$#", "insertRows(int, int, const QModelIndex&)", typeof(bool), typeof(int), row, typeof(int), count, typeof(QModelIndex), parent);
        }
        [SmokeMethod("insertRows(int, int)")]
        public virtual bool InsertRows(int row, int count) {
            return (bool) interceptor.Invoke("insertRows$$", "insertRows(int, int)", typeof(bool), typeof(int), row, typeof(int), count);
        }
        [SmokeMethod("insertColumns(int, int, const QModelIndex&)")]
        public virtual bool InsertColumns(int column, int count, QModelIndex parent) {
            return (bool) interceptor.Invoke("insertColumns$$#", "insertColumns(int, int, const QModelIndex&)", typeof(bool), typeof(int), column, typeof(int), count, typeof(QModelIndex), parent);
        }
        [SmokeMethod("insertColumns(int, int)")]
        public virtual bool InsertColumns(int column, int count) {
            return (bool) interceptor.Invoke("insertColumns$$", "insertColumns(int, int)", typeof(bool), typeof(int), column, typeof(int), count);
        }
        [SmokeMethod("removeRows(int, int, const QModelIndex&)")]
        public virtual bool RemoveRows(int row, int count, QModelIndex parent) {
            return (bool) interceptor.Invoke("removeRows$$#", "removeRows(int, int, const QModelIndex&)", typeof(bool), typeof(int), row, typeof(int), count, typeof(QModelIndex), parent);
        }
        [SmokeMethod("removeRows(int, int)")]
        public virtual bool RemoveRows(int row, int count) {
            return (bool) interceptor.Invoke("removeRows$$", "removeRows(int, int)", typeof(bool), typeof(int), row, typeof(int), count);
        }
        [SmokeMethod("removeColumns(int, int, const QModelIndex&)")]
        public virtual bool RemoveColumns(int column, int count, QModelIndex parent) {
            return (bool) interceptor.Invoke("removeColumns$$#", "removeColumns(int, int, const QModelIndex&)", typeof(bool), typeof(int), column, typeof(int), count, typeof(QModelIndex), parent);
        }
        [SmokeMethod("removeColumns(int, int)")]
        public virtual bool RemoveColumns(int column, int count) {
            return (bool) interceptor.Invoke("removeColumns$$", "removeColumns(int, int)", typeof(bool), typeof(int), column, typeof(int), count);
        }
        public bool InsertRow(int row, QModelIndex parent) {
            return (bool) interceptor.Invoke("insertRow$#", "insertRow(int, const QModelIndex&)", typeof(bool), typeof(int), row, typeof(QModelIndex), parent);
        }
        public bool InsertRow(int row) {
            return (bool) interceptor.Invoke("insertRow$", "insertRow(int)", typeof(bool), typeof(int), row);
        }
        public bool InsertColumn(int column, QModelIndex parent) {
            return (bool) interceptor.Invoke("insertColumn$#", "insertColumn(int, const QModelIndex&)", typeof(bool), typeof(int), column, typeof(QModelIndex), parent);
        }
        public bool InsertColumn(int column) {
            return (bool) interceptor.Invoke("insertColumn$", "insertColumn(int)", typeof(bool), typeof(int), column);
        }
        public bool RemoveRow(int row, QModelIndex parent) {
            return (bool) interceptor.Invoke("removeRow$#", "removeRow(int, const QModelIndex&)", typeof(bool), typeof(int), row, typeof(QModelIndex), parent);
        }
        public bool RemoveRow(int row) {
            return (bool) interceptor.Invoke("removeRow$", "removeRow(int)", typeof(bool), typeof(int), row);
        }
        public bool RemoveColumn(int column, QModelIndex parent) {
            return (bool) interceptor.Invoke("removeColumn$#", "removeColumn(int, const QModelIndex&)", typeof(bool), typeof(int), column, typeof(QModelIndex), parent);
        }
        public bool RemoveColumn(int column) {
            return (bool) interceptor.Invoke("removeColumn$", "removeColumn(int)", typeof(bool), typeof(int), column);
        }
        [SmokeMethod("fetchMore(const QModelIndex&)")]
        public virtual void FetchMore(QModelIndex parent) {
            interceptor.Invoke("fetchMore#", "fetchMore(const QModelIndex&)", typeof(void), typeof(QModelIndex), parent);
        }
        [SmokeMethod("canFetchMore(const QModelIndex&) const")]
        public virtual bool CanFetchMore(QModelIndex parent) {
            return (bool) interceptor.Invoke("canFetchMore#", "canFetchMore(const QModelIndex&) const", typeof(bool), typeof(QModelIndex), parent);
        }
        [SmokeMethod("flags(const QModelIndex&) const")]
        public virtual uint Flags(QModelIndex index) {
            return (uint) interceptor.Invoke("flags#", "flags(const QModelIndex&) const", typeof(uint), typeof(QModelIndex), index);
        }
        [SmokeMethod("sort(int, Qt::SortOrder)")]
        public virtual void Sort(int column, Qt.SortOrder order) {
            interceptor.Invoke("sort$$", "sort(int, Qt::SortOrder)", typeof(void), typeof(int), column, typeof(Qt.SortOrder), order);
        }
        [SmokeMethod("sort(int)")]
        public virtual void Sort(int column) {
            interceptor.Invoke("sort$", "sort(int)", typeof(void), typeof(int), column);
        }
        [SmokeMethod("buddy(const QModelIndex&) const")]
        public virtual QModelIndex Buddy(QModelIndex index) {
            return (QModelIndex) interceptor.Invoke("buddy#", "buddy(const QModelIndex&) const", typeof(QModelIndex), typeof(QModelIndex), index);
        }
        [SmokeMethod("match(const QModelIndex&, int, const QVariant&, int, Qt::MatchFlags) const")]
        public virtual List<QModelIndex> Match(QModelIndex start, int role, QVariant value, int hits, uint flags) {
            return (List<QModelIndex>) interceptor.Invoke("match#$#$$", "match(const QModelIndex&, int, const QVariant&, int, Qt::MatchFlags) const", typeof(List<QModelIndex>), typeof(QModelIndex), start, typeof(int), role, typeof(QVariant), value, typeof(int), hits, typeof(uint), flags);
        }
        [SmokeMethod("match(const QModelIndex&, int, const QVariant&, int) const")]
        public virtual List<QModelIndex> Match(QModelIndex start, int role, QVariant value, int hits) {
            return (List<QModelIndex>) interceptor.Invoke("match#$#$", "match(const QModelIndex&, int, const QVariant&, int) const", typeof(List<QModelIndex>), typeof(QModelIndex), start, typeof(int), role, typeof(QVariant), value, typeof(int), hits);
        }
        [SmokeMethod("match(const QModelIndex&, int, const QVariant&) const")]
        public virtual List<QModelIndex> Match(QModelIndex start, int role, QVariant value) {
            return (List<QModelIndex>) interceptor.Invoke("match#$#", "match(const QModelIndex&, int, const QVariant&) const", typeof(List<QModelIndex>), typeof(QModelIndex), start, typeof(int), role, typeof(QVariant), value);
        }
        [SmokeMethod("span(const QModelIndex&) const")]
        public virtual QSize Span(QModelIndex index) {
            return (QSize) interceptor.Invoke("span#", "span(const QModelIndex&) const", typeof(QSize), typeof(QModelIndex), index);
        }
        public new QObject Parent() {
            return (QObject) interceptor.Invoke("parent", "parent() const", typeof(QObject));
        }
        [Q_SLOT("bool submit()")]
        [SmokeMethod("submit()")]
        public virtual bool Submit() {
            return (bool) interceptor.Invoke("submit", "submit()", typeof(bool));
        }
        [Q_SLOT("void revert()")]
        [SmokeMethod("revert()")]
        public virtual void Revert() {
            interceptor.Invoke("revert", "revert()", typeof(void));
        }
        protected QModelIndex CreateIndex(int row, int column) {
            return (QModelIndex) interceptor.Invoke("createIndex$$", "createIndex(int, int) const", typeof(QModelIndex), typeof(int), row, typeof(int), column);
        }
        protected QModelIndex CreateIndex(int row, int column, int id) {
            return (QModelIndex) interceptor.Invoke("createIndex$$$", "createIndex(int, int, int) const", typeof(QModelIndex), typeof(int), row, typeof(int), column, typeof(int), id);
        }
        protected QModelIndex CreateIndex(int row, int column, uint id) {
            return (QModelIndex) interceptor.Invoke("createIndex$$$", "createIndex(int, int, unsigned int) const", typeof(QModelIndex), typeof(int), row, typeof(int), column, typeof(uint), id);
        }
        protected void EncodeData(List<QModelIndex> indexes, QDataStream stream) {
            interceptor.Invoke("encodeData?#", "encodeData(const QList<QModelIndex>&, QDataStream&) const", typeof(void), typeof(List<QModelIndex>), indexes, typeof(QDataStream), stream);
        }
        protected bool DecodeData(int row, int column, QModelIndex parent, QDataStream stream) {
            return (bool) interceptor.Invoke("decodeData$$##", "decodeData(int, int, const QModelIndex&, QDataStream&)", typeof(bool), typeof(int), row, typeof(int), column, typeof(QModelIndex), parent, typeof(QDataStream), stream);
        }
        protected void BeginInsertRows(QModelIndex parent, int first, int last) {
            interceptor.Invoke("beginInsertRows#$$", "beginInsertRows(const QModelIndex&, int, int)", typeof(void), typeof(QModelIndex), parent, typeof(int), first, typeof(int), last);
        }
        protected void EndInsertRows() {
            interceptor.Invoke("endInsertRows", "endInsertRows()", typeof(void));
        }
        protected void BeginRemoveRows(QModelIndex parent, int first, int last) {
            interceptor.Invoke("beginRemoveRows#$$", "beginRemoveRows(const QModelIndex&, int, int)", typeof(void), typeof(QModelIndex), parent, typeof(int), first, typeof(int), last);
        }
        protected void EndRemoveRows() {
            interceptor.Invoke("endRemoveRows", "endRemoveRows()", typeof(void));
        }
        protected void BeginInsertColumns(QModelIndex parent, int first, int last) {
            interceptor.Invoke("beginInsertColumns#$$", "beginInsertColumns(const QModelIndex&, int, int)", typeof(void), typeof(QModelIndex), parent, typeof(int), first, typeof(int), last);
        }
        protected void EndInsertColumns() {
            interceptor.Invoke("endInsertColumns", "endInsertColumns()", typeof(void));
        }
        protected void BeginRemoveColumns(QModelIndex parent, int first, int last) {
            interceptor.Invoke("beginRemoveColumns#$$", "beginRemoveColumns(const QModelIndex&, int, int)", typeof(void), typeof(QModelIndex), parent, typeof(int), first, typeof(int), last);
        }
        protected void EndRemoveColumns() {
            interceptor.Invoke("endRemoveColumns", "endRemoveColumns()", typeof(void));
        }
        protected void Reset() {
            interceptor.Invoke("reset", "reset()", typeof(void));
        }
        protected void ChangePersistentIndex(QModelIndex from, QModelIndex to) {
            interceptor.Invoke("changePersistentIndex##", "changePersistentIndex(const QModelIndex&, const QModelIndex&)", typeof(void), typeof(QModelIndex), from, typeof(QModelIndex), to);
        }
        protected void ChangePersistentIndexList(List<QModelIndex> from, List<QModelIndex> to) {
            interceptor.Invoke("changePersistentIndexList??", "changePersistentIndexList(const QList<QModelIndex>&, const QList<QModelIndex>&)", typeof(void), typeof(List<QModelIndex>), from, typeof(List<QModelIndex>), to);
        }
        protected List<QModelIndex> PersistentIndexList() {
            return (List<QModelIndex>) interceptor.Invoke("persistentIndexList", "persistentIndexList() const", typeof(List<QModelIndex>));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQAbstractItemModelSignals Emit {
            get { return (IQAbstractItemModelSignals) Q_EMIT; }
        }
    }

    public interface IQAbstractItemModelSignals : IQObjectSignals {
        [Q_SIGNAL("void dataChanged(QModelIndex, QModelIndex)")]
        void DataChanged(QModelIndex topLeft, QModelIndex bottomRight);
        [Q_SIGNAL("void headerDataChanged(Qt::Orientation, int, int)")]
        void HeaderDataChanged(Qt.Orientation orientation, int first, int last);
        [Q_SIGNAL("void layoutChanged()")]
        void LayoutChanged();
        [Q_SIGNAL("void layoutAboutToBeChanged()")]
        void LayoutAboutToBeChanged();
    }
}
