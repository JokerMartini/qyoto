//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	[SmokeClass("QSortFilterProxyModel")]
	public class QSortFilterProxyModel : QAbstractProxyModel, IDisposable {
 		protected QSortFilterProxyModel(Type dummy) : base((Type) null) {}
		interface IQSortFilterProxyModelProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSortFilterProxyModel), this);
			_interceptor = (QSortFilterProxyModel) realProxy.GetTransparentProxy();
		}
		private QSortFilterProxyModel ProxyQSortFilterProxyModel() {
			return (QSortFilterProxyModel) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSortFilterProxyModel() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSortFilterProxyModelProxy), null);
			_staticInterceptor = (IQSortFilterProxyModelProxy) realProxy.GetTransparentProxy();
		}
		private static IQSortFilterProxyModelProxy StaticQSortFilterProxyModel() {
			return (IQSortFilterProxyModelProxy) _staticInterceptor;
		}

		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QSortFilterProxyModel(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQSortFilterProxyModel(parent);
		}
		[SmokeMethod("QSortFilterProxyModel(QObject*)")]
		private void NewQSortFilterProxyModel(QObject parent) {
			ProxyQSortFilterProxyModel().NewQSortFilterProxyModel(parent);
		}
		public QSortFilterProxyModel() : this((Type) null) {
			CreateProxy();
			NewQSortFilterProxyModel();
		}
		[SmokeMethod("QSortFilterProxyModel()")]
		private void NewQSortFilterProxyModel() {
			ProxyQSortFilterProxyModel().NewQSortFilterProxyModel();
		}
		[SmokeMethod("setSourceModel(QAbstractItemModel*)")]
		public new void SetSourceModel(QAbstractItemModel sourceModel) {
			ProxyQSortFilterProxyModel().SetSourceModel(sourceModel);
		}
		[SmokeMethod("mapToSource(const QModelIndex&) const")]
		public new QModelIndex MapToSource(QModelIndex proxyIndex) {
			return ProxyQSortFilterProxyModel().MapToSource(proxyIndex);
		}
		[SmokeMethod("mapFromSource(const QModelIndex&) const")]
		public new QModelIndex MapFromSource(QModelIndex sourceIndex) {
			return ProxyQSortFilterProxyModel().MapFromSource(sourceIndex);
		}
		[SmokeMethod("mapSelectionToSource(const QItemSelection&) const")]
		public new QItemSelection MapSelectionToSource(QItemSelection proxySelection) {
			return ProxyQSortFilterProxyModel().MapSelectionToSource(proxySelection);
		}
		[SmokeMethod("mapSelectionFromSource(const QItemSelection&) const")]
		public new QItemSelection MapSelectionFromSource(QItemSelection sourceSelection) {
			return ProxyQSortFilterProxyModel().MapSelectionFromSource(sourceSelection);
		}
		[SmokeMethod("filterRegExp() const")]
		public QRegExp FilterRegExp() {
			return ProxyQSortFilterProxyModel().FilterRegExp();
		}
		[SmokeMethod("setFilterRegExp(const QRegExp&)")]
		public void SetFilterRegExp(QRegExp regExp) {
			ProxyQSortFilterProxyModel().SetFilterRegExp(regExp);
		}
		[SmokeMethod("filterKeyColumn() const")]
		public int FilterKeyColumn() {
			return ProxyQSortFilterProxyModel().FilterKeyColumn();
		}
		[SmokeMethod("setFilterKeyColumn(int)")]
		public void SetFilterKeyColumn(int column) {
			ProxyQSortFilterProxyModel().SetFilterKeyColumn(column);
		}
		[SmokeMethod("filterCaseSensitivity() const")]
		public Qt.CaseSensitivity FilterCaseSensitivity() {
			return ProxyQSortFilterProxyModel().FilterCaseSensitivity();
		}
		[SmokeMethod("setFilterCaseSensitivity(Qt::CaseSensitivity)")]
		public void SetFilterCaseSensitivity(Qt.CaseSensitivity cs) {
			ProxyQSortFilterProxyModel().SetFilterCaseSensitivity(cs);
		}
		[SmokeMethod("sortCaseSensitivity() const")]
		public Qt.CaseSensitivity SortCaseSensitivity() {
			return ProxyQSortFilterProxyModel().SortCaseSensitivity();
		}
		[SmokeMethod("setSortCaseSensitivity(Qt::CaseSensitivity)")]
		public void SetSortCaseSensitivity(Qt.CaseSensitivity cs) {
			ProxyQSortFilterProxyModel().SetSortCaseSensitivity(cs);
		}
		[SmokeMethod("dynamicSortFilter() const")]
		public bool DynamicSortFilter() {
			return ProxyQSortFilterProxyModel().DynamicSortFilter();
		}
		[SmokeMethod("setDynamicSortFilter(bool)")]
		public void SetDynamicSortFilter(bool enable) {
			ProxyQSortFilterProxyModel().SetDynamicSortFilter(enable);
		}
		[SmokeMethod("sortRole() const")]
		public int SortRole() {
			return ProxyQSortFilterProxyModel().SortRole();
		}
		[SmokeMethod("setSortRole(int)")]
		public void SetSortRole(int role) {
			ProxyQSortFilterProxyModel().SetSortRole(role);
		}
		[SmokeMethod("filterRole() const")]
		public int FilterRole() {
			return ProxyQSortFilterProxyModel().FilterRole();
		}
		[SmokeMethod("setFilterRole(int)")]
		public void SetFilterRole(int role) {
			ProxyQSortFilterProxyModel().SetFilterRole(role);
		}
		[SmokeMethod("setFilterRegExp(const QString&)")]
		public void SetFilterRegExp(string pattern) {
			ProxyQSortFilterProxyModel().SetFilterRegExp(pattern);
		}
		[SmokeMethod("setFilterWildcard(const QString&)")]
		public void SetFilterWildcard(string pattern) {
			ProxyQSortFilterProxyModel().SetFilterWildcard(pattern);
		}
		[SmokeMethod("setFilterFixedString(const QString&)")]
		public void SetFilterFixedString(string pattern) {
			ProxyQSortFilterProxyModel().SetFilterFixedString(pattern);
		}
		[SmokeMethod("clear()")]
		public void Clear() {
			ProxyQSortFilterProxyModel().Clear();
		}
		[SmokeMethod("parent() const")]
		public new QObject Parent() {
			return ProxyQSortFilterProxyModel().Parent();
		}
		[SmokeMethod("index(int, int, const QModelIndex&) const")]
		public new QModelIndex Index(int row, int column, QModelIndex parent) {
			return ProxyQSortFilterProxyModel().Index(row,column,parent);
		}
		[SmokeMethod("index(int, int) const")]
		public new QModelIndex Index(int row, int column) {
			return ProxyQSortFilterProxyModel().Index(row,column);
		}
		[SmokeMethod("parent(const QModelIndex&) const")]
		public new QModelIndex Parent(QModelIndex child) {
			return ProxyQSortFilterProxyModel().Parent(child);
		}
		[SmokeMethod("rowCount(const QModelIndex&) const")]
		public new int RowCount(QModelIndex parent) {
			return ProxyQSortFilterProxyModel().RowCount(parent);
		}
		[SmokeMethod("rowCount() const")]
		public new int RowCount() {
			return ProxyQSortFilterProxyModel().RowCount();
		}
		[SmokeMethod("columnCount(const QModelIndex&) const")]
		public new int ColumnCount(QModelIndex parent) {
			return ProxyQSortFilterProxyModel().ColumnCount(parent);
		}
		[SmokeMethod("columnCount() const")]
		public new int ColumnCount() {
			return ProxyQSortFilterProxyModel().ColumnCount();
		}
		[SmokeMethod("hasChildren(const QModelIndex&) const")]
		public new bool HasChildren(QModelIndex parent) {
			return ProxyQSortFilterProxyModel().HasChildren(parent);
		}
		[SmokeMethod("hasChildren() const")]
		public new bool HasChildren() {
			return ProxyQSortFilterProxyModel().HasChildren();
		}
		[SmokeMethod("data(const QModelIndex&, int) const")]
		public new QVariant Data(QModelIndex index, int role) {
			return ProxyQSortFilterProxyModel().Data(index,role);
		}
		[SmokeMethod("data(const QModelIndex&) const")]
		public new QVariant Data(QModelIndex index) {
			return ProxyQSortFilterProxyModel().Data(index);
		}
		[SmokeMethod("setData(const QModelIndex&, const QVariant&, int)")]
		public new bool SetData(QModelIndex index, QVariant value, int role) {
			return ProxyQSortFilterProxyModel().SetData(index,value,role);
		}
		[SmokeMethod("headerData(int, Qt::Orientation, int) const")]
		public new QVariant HeaderData(int section, Qt.Orientation orientation, int role) {
			return ProxyQSortFilterProxyModel().HeaderData(section,orientation,role);
		}
		[SmokeMethod("setHeaderData(int, Qt::Orientation, const QVariant&, int)")]
		public new bool SetHeaderData(int section, Qt.Orientation orientation, QVariant value, int role) {
			return ProxyQSortFilterProxyModel().SetHeaderData(section,orientation,value,role);
		}
		[SmokeMethod("mimeData(const QModelIndexList&) const")]
		public new QMimeData MimeData(List<QModelIndex> indexes) {
			return ProxyQSortFilterProxyModel().MimeData(indexes);
		}
		[SmokeMethod("dropMimeData(const QMimeData*, Qt::DropAction, int, int, const QModelIndex&)")]
		public new bool DropMimeData(QMimeData data, Qt.DropAction action, int row, int column, QModelIndex parent) {
			return ProxyQSortFilterProxyModel().DropMimeData(data,action,row,column,parent);
		}
		[SmokeMethod("insertRows(int, int, const QModelIndex&)")]
		public new bool InsertRows(int row, int count, QModelIndex parent) {
			return ProxyQSortFilterProxyModel().InsertRows(row,count,parent);
		}
		[SmokeMethod("insertRows(int, int)")]
		public new bool InsertRows(int row, int count) {
			return ProxyQSortFilterProxyModel().InsertRows(row,count);
		}
		[SmokeMethod("insertColumns(int, int, const QModelIndex&)")]
		public new bool InsertColumns(int column, int count, QModelIndex parent) {
			return ProxyQSortFilterProxyModel().InsertColumns(column,count,parent);
		}
		[SmokeMethod("insertColumns(int, int)")]
		public new bool InsertColumns(int column, int count) {
			return ProxyQSortFilterProxyModel().InsertColumns(column,count);
		}
		[SmokeMethod("removeRows(int, int, const QModelIndex&)")]
		public new bool RemoveRows(int row, int count, QModelIndex parent) {
			return ProxyQSortFilterProxyModel().RemoveRows(row,count,parent);
		}
		[SmokeMethod("removeRows(int, int)")]
		public new bool RemoveRows(int row, int count) {
			return ProxyQSortFilterProxyModel().RemoveRows(row,count);
		}
		[SmokeMethod("removeColumns(int, int, const QModelIndex&)")]
		public new bool RemoveColumns(int column, int count, QModelIndex parent) {
			return ProxyQSortFilterProxyModel().RemoveColumns(column,count,parent);
		}
		[SmokeMethod("removeColumns(int, int)")]
		public new bool RemoveColumns(int column, int count) {
			return ProxyQSortFilterProxyModel().RemoveColumns(column,count);
		}
		[SmokeMethod("fetchMore(const QModelIndex&)")]
		public new void FetchMore(QModelIndex parent) {
			ProxyQSortFilterProxyModel().FetchMore(parent);
		}
		[SmokeMethod("canFetchMore(const QModelIndex&) const")]
		public new bool CanFetchMore(QModelIndex parent) {
			return ProxyQSortFilterProxyModel().CanFetchMore(parent);
		}
		[SmokeMethod("flags(const QModelIndex&) const")]
		public new int Flags(QModelIndex index) {
			return ProxyQSortFilterProxyModel().Flags(index);
		}
		[SmokeMethod("buddy(const QModelIndex&) const")]
		public new QModelIndex Buddy(QModelIndex index) {
			return ProxyQSortFilterProxyModel().Buddy(index);
		}
		[SmokeMethod("match(const QModelIndex&, int, const QVariant&, int, Qt::MatchFlags) const")]
		public new List<QModelIndex> Match(QModelIndex start, int role, QVariant value, int hits, int flags) {
			return ProxyQSortFilterProxyModel().Match(start,role,value,hits,flags);
		}
		[SmokeMethod("span(const QModelIndex&) const")]
		public new QSize Span(QModelIndex index) {
			return ProxyQSortFilterProxyModel().Span(index);
		}
		[SmokeMethod("sort(int, Qt::SortOrder)")]
		public new void Sort(int column, Qt.SortOrder order) {
			ProxyQSortFilterProxyModel().Sort(column,order);
		}
		[SmokeMethod("sort(int)")]
		public new void Sort(int column) {
			ProxyQSortFilterProxyModel().Sort(column);
		}
		[SmokeMethod("mimeTypes() const")]
		public new List<string> MimeTypes() {
			return ProxyQSortFilterProxyModel().MimeTypes();
		}
		[SmokeMethod("supportedDropActions() const")]
		public new int SupportedDropActions() {
			return ProxyQSortFilterProxyModel().SupportedDropActions();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQSortFilterProxyModel().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQSortFilterProxyModel().Tr(s);
		}
		[SmokeMethod("filterAcceptsRow(int, const QModelIndex&) const")]
		protected virtual bool FilterAcceptsRow(int source_row, QModelIndex source_parent) {
			return ProxyQSortFilterProxyModel().FilterAcceptsRow(source_row,source_parent);
		}
		[SmokeMethod("filterAcceptsColumn(int, const QModelIndex&) const")]
		protected virtual bool FilterAcceptsColumn(int source_column, QModelIndex source_parent) {
			return ProxyQSortFilterProxyModel().FilterAcceptsColumn(source_column,source_parent);
		}
		[SmokeMethod("lessThan(const QModelIndex&, const QModelIndex&) const")]
		protected virtual bool LessThan(QModelIndex left, QModelIndex right) {
			return ProxyQSortFilterProxyModel().LessThan(left,right);
		}
		[SmokeMethod("filterChanged()")]
		protected void FilterChanged() {
			ProxyQSortFilterProxyModel().FilterChanged();
		}
		~QSortFilterProxyModel() {
			DisposeQSortFilterProxyModel();
		}
		public new void Dispose() {
			DisposeQSortFilterProxyModel();
		}
		[SmokeMethod("~QSortFilterProxyModel()")]
		private void DisposeQSortFilterProxyModel() {
			ProxyQSortFilterProxyModel().DisposeQSortFilterProxyModel();
		}
		protected new IQSortFilterProxyModelSignals Emit() {
			return (IQSortFilterProxyModelSignals) Q_EMIT;
		}
	}

	public interface IQSortFilterProxyModelSignals : IQAbstractProxyModelSignals {
	}
}
