//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QSortFilterProxyModel")]
	public class QSortFilterProxyModel : QAbstractProxyModel, IDisposable {
 		protected QSortFilterProxyModel(Type dummy) : base((Type) null) {}
		[SmokeClass("QSortFilterProxyModel")]
		interface IQSortFilterProxyModelProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
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
		[Q_PROPERTY("QRegExp", "filterRegExp")]
		public QRegExp FilterRegExp {
			get { return Property("filterRegExp").Value<QRegExp>(); }
			set { SetProperty("filterRegExp", QVariant.FromValue<QRegExp>(value)); }
		}
		[Q_PROPERTY("int", "filterKeyColumn")]
		public int FilterKeyColumn {
			get { return Property("filterKeyColumn").Value<int>(); }
			set { SetProperty("filterKeyColumn", QVariant.FromValue<int>(value)); }
		}
		[Q_PROPERTY("bool", "dynamicSortFilter")]
		public bool DynamicSortFilter {
			get { return Property("dynamicSortFilter").Value<bool>(); }
			set { SetProperty("dynamicSortFilter", QVariant.FromValue<bool>(value)); }
		}
		[Q_PROPERTY("Qt::CaseSensitivity", "filterCaseSensitivity")]
		public Qt.CaseSensitivity FilterCaseSensitivity {
			get { return Property("filterCaseSensitivity").Value<Qt.CaseSensitivity>(); }
			set { SetProperty("filterCaseSensitivity", QVariant.FromValue<Qt.CaseSensitivity>(value)); }
		}
		[Q_PROPERTY("Qt::CaseSensitivity", "sortCaseSensitivity")]
		public Qt.CaseSensitivity SortCaseSensitivity {
			get { return Property("sortCaseSensitivity").Value<Qt.CaseSensitivity>(); }
			set { SetProperty("sortCaseSensitivity", QVariant.FromValue<Qt.CaseSensitivity>(value)); }
		}
		[Q_PROPERTY("int", "sortRole")]
		public int SortRole {
			get { return Property("sortRole").Value<int>(); }
			set { SetProperty("sortRole", QVariant.FromValue<int>(value)); }
		}
		[Q_PROPERTY("int", "filterRole")]
		public int FilterRole {
			get { return Property("filterRole").Value<int>(); }
			set { SetProperty("filterRole", QVariant.FromValue<int>(value)); }
		}
		public QSortFilterProxyModel(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQSortFilterProxyModel(parent);
		}
		[SmokeMethod("QSortFilterProxyModel", "(QObject*)", "#")]
		private void NewQSortFilterProxyModel(QObject parent) {
			ProxyQSortFilterProxyModel().NewQSortFilterProxyModel(parent);
		}
		public QSortFilterProxyModel() : this((Type) null) {
			CreateProxy();
			NewQSortFilterProxyModel();
		}
		[SmokeMethod("QSortFilterProxyModel", "()", "")]
		private void NewQSortFilterProxyModel() {
			ProxyQSortFilterProxyModel().NewQSortFilterProxyModel();
		}
		[SmokeMethod("setSourceModel", "(QAbstractItemModel*)", "#")]
		public override void SetSourceModel(QAbstractItemModel sourceModel) {
			ProxyQSortFilterProxyModel().SetSourceModel(sourceModel);
		}
		[SmokeMethod("mapToSource", "(const QModelIndex&) const", "#")]
		public override QModelIndex MapToSource(QModelIndex proxyIndex) {
			return ProxyQSortFilterProxyModel().MapToSource(proxyIndex);
		}
		[SmokeMethod("mapFromSource", "(const QModelIndex&) const", "#")]
		public override QModelIndex MapFromSource(QModelIndex sourceIndex) {
			return ProxyQSortFilterProxyModel().MapFromSource(sourceIndex);
		}
		[SmokeMethod("mapSelectionToSource", "(const QItemSelection&) const", "#")]
		public override QItemSelection MapSelectionToSource(QItemSelection proxySelection) {
			return ProxyQSortFilterProxyModel().MapSelectionToSource(proxySelection);
		}
		[SmokeMethod("mapSelectionFromSource", "(const QItemSelection&) const", "#")]
		public override QItemSelection MapSelectionFromSource(QItemSelection sourceSelection) {
			return ProxyQSortFilterProxyModel().MapSelectionFromSource(sourceSelection);
		}
		[SmokeMethod("parent", "() const", "")]
		public QObject Parent() {
			return ProxyQSortFilterProxyModel().Parent();
		}
		[SmokeMethod("index", "(int, int, const QModelIndex&) const", "$$#")]
		public override QModelIndex Index(int row, int column, QModelIndex parent) {
			return ProxyQSortFilterProxyModel().Index(row,column,parent);
		}
		[SmokeMethod("index", "(int, int) const", "$$")]
		public override QModelIndex Index(int row, int column) {
			return ProxyQSortFilterProxyModel().Index(row,column);
		}
		[SmokeMethod("parent", "(const QModelIndex&) const", "#")]
		public override QModelIndex Parent(QModelIndex child) {
			return ProxyQSortFilterProxyModel().Parent(child);
		}
		[SmokeMethod("rowCount", "(const QModelIndex&) const", "#")]
		public override int RowCount(QModelIndex parent) {
			return ProxyQSortFilterProxyModel().RowCount(parent);
		}
		[SmokeMethod("rowCount", "() const", "")]
		public override int RowCount() {
			return ProxyQSortFilterProxyModel().RowCount();
		}
		[SmokeMethod("columnCount", "(const QModelIndex&) const", "#")]
		public override int ColumnCount(QModelIndex parent) {
			return ProxyQSortFilterProxyModel().ColumnCount(parent);
		}
		[SmokeMethod("columnCount", "() const", "")]
		public override int ColumnCount() {
			return ProxyQSortFilterProxyModel().ColumnCount();
		}
		[SmokeMethod("hasChildren", "(const QModelIndex&) const", "#")]
		public override bool HasChildren(QModelIndex parent) {
			return ProxyQSortFilterProxyModel().HasChildren(parent);
		}
		[SmokeMethod("hasChildren", "() const", "")]
		public override bool HasChildren() {
			return ProxyQSortFilterProxyModel().HasChildren();
		}
		[SmokeMethod("data", "(const QModelIndex&, int) const", "#$")]
		public override QVariant Data(QModelIndex index, int role) {
			return ProxyQSortFilterProxyModel().Data(index,role);
		}
		[SmokeMethod("data", "(const QModelIndex&) const", "#")]
		public override QVariant Data(QModelIndex index) {
			return ProxyQSortFilterProxyModel().Data(index);
		}
		[SmokeMethod("setData", "(const QModelIndex&, const QVariant&, int)", "##$")]
		public override bool SetData(QModelIndex index, QVariant value, int role) {
			return ProxyQSortFilterProxyModel().SetData(index,value,role);
		}
		[SmokeMethod("headerData", "(int, Qt::Orientation, int) const", "$$$")]
		public override QVariant HeaderData(int section, Qt.Orientation orientation, int role) {
			return ProxyQSortFilterProxyModel().HeaderData(section,orientation,role);
		}
		[SmokeMethod("setHeaderData", "(int, Qt::Orientation, const QVariant&, int)", "$$#$")]
		public override bool SetHeaderData(int section, Qt.Orientation orientation, QVariant value, int role) {
			return ProxyQSortFilterProxyModel().SetHeaderData(section,orientation,value,role);
		}
		[SmokeMethod("mimeData", "(const QModelIndexList&) const", "?")]
		public override QMimeData MimeData(List<QModelIndex> indexes) {
			return ProxyQSortFilterProxyModel().MimeData(indexes);
		}
		[SmokeMethod("dropMimeData", "(const QMimeData*, Qt::DropAction, int, int, const QModelIndex&)", "#$$$#")]
		public override bool DropMimeData(QMimeData data, Qt.DropAction action, int row, int column, QModelIndex parent) {
			return ProxyQSortFilterProxyModel().DropMimeData(data,action,row,column,parent);
		}
		[SmokeMethod("insertRows", "(int, int, const QModelIndex&)", "$$#")]
		public override bool InsertRows(int row, int count, QModelIndex parent) {
			return ProxyQSortFilterProxyModel().InsertRows(row,count,parent);
		}
		[SmokeMethod("insertRows", "(int, int)", "$$")]
		public override bool InsertRows(int row, int count) {
			return ProxyQSortFilterProxyModel().InsertRows(row,count);
		}
		[SmokeMethod("insertColumns", "(int, int, const QModelIndex&)", "$$#")]
		public override bool InsertColumns(int column, int count, QModelIndex parent) {
			return ProxyQSortFilterProxyModel().InsertColumns(column,count,parent);
		}
		[SmokeMethod("insertColumns", "(int, int)", "$$")]
		public override bool InsertColumns(int column, int count) {
			return ProxyQSortFilterProxyModel().InsertColumns(column,count);
		}
		[SmokeMethod("removeRows", "(int, int, const QModelIndex&)", "$$#")]
		public override bool RemoveRows(int row, int count, QModelIndex parent) {
			return ProxyQSortFilterProxyModel().RemoveRows(row,count,parent);
		}
		[SmokeMethod("removeRows", "(int, int)", "$$")]
		public override bool RemoveRows(int row, int count) {
			return ProxyQSortFilterProxyModel().RemoveRows(row,count);
		}
		[SmokeMethod("removeColumns", "(int, int, const QModelIndex&)", "$$#")]
		public override bool RemoveColumns(int column, int count, QModelIndex parent) {
			return ProxyQSortFilterProxyModel().RemoveColumns(column,count,parent);
		}
		[SmokeMethod("removeColumns", "(int, int)", "$$")]
		public override bool RemoveColumns(int column, int count) {
			return ProxyQSortFilterProxyModel().RemoveColumns(column,count);
		}
		[SmokeMethod("fetchMore", "(const QModelIndex&)", "#")]
		public override void FetchMore(QModelIndex parent) {
			ProxyQSortFilterProxyModel().FetchMore(parent);
		}
		[SmokeMethod("canFetchMore", "(const QModelIndex&) const", "#")]
		public override bool CanFetchMore(QModelIndex parent) {
			return ProxyQSortFilterProxyModel().CanFetchMore(parent);
		}
		[SmokeMethod("flags", "(const QModelIndex&) const", "#")]
		public override int Flags(QModelIndex index) {
			return ProxyQSortFilterProxyModel().Flags(index);
		}
		[SmokeMethod("buddy", "(const QModelIndex&) const", "#")]
		public override QModelIndex Buddy(QModelIndex index) {
			return ProxyQSortFilterProxyModel().Buddy(index);
		}
		[SmokeMethod("match", "(const QModelIndex&, int, const QVariant&, int, Qt::MatchFlags) const", "#$#$$")]
		public override List<QModelIndex> Match(QModelIndex start, int role, QVariant value, int hits, int flags) {
			return ProxyQSortFilterProxyModel().Match(start,role,value,hits,flags);
		}
		[SmokeMethod("span", "(const QModelIndex&) const", "#")]
		public override QSize Span(QModelIndex index) {
			return ProxyQSortFilterProxyModel().Span(index);
		}
		[SmokeMethod("sort", "(int, Qt::SortOrder)", "$$")]
		public override void Sort(int column, Qt.SortOrder order) {
			ProxyQSortFilterProxyModel().Sort(column,order);
		}
		[SmokeMethod("sort", "(int)", "$")]
		public override void Sort(int column) {
			ProxyQSortFilterProxyModel().Sort(column);
		}
		[SmokeMethod("mimeTypes", "() const", "")]
		public override List<string> MimeTypes() {
			return ProxyQSortFilterProxyModel().MimeTypes();
		}
		[SmokeMethod("supportedDropActions", "() const", "")]
		public override int SupportedDropActions() {
			return ProxyQSortFilterProxyModel().SupportedDropActions();
		}
		[Q_SLOT("void setFilterWildcard(const QString&)")]
		[SmokeMethod("setFilterWildcard", "(const QString&)", "$")]
		public void SetFilterWildcard(string pattern) {
			ProxyQSortFilterProxyModel().SetFilterWildcard(pattern);
		}
		[Q_SLOT("void setFilterFixedString(const QString&)")]
		[SmokeMethod("setFilterFixedString", "(const QString&)", "$")]
		public void SetFilterFixedString(string pattern) {
			ProxyQSortFilterProxyModel().SetFilterFixedString(pattern);
		}
		[Q_SLOT("void clear()")]
		[SmokeMethod("clear", "()", "")]
		public void Clear() {
			ProxyQSortFilterProxyModel().Clear();
		}
		public static string Tr(string s, string c) {
			return StaticQSortFilterProxyModel().Tr(s,c);
		}
		public static string Tr(string s) {
			return StaticQSortFilterProxyModel().Tr(s);
		}
		[SmokeMethod("filterAcceptsRow", "(int, const QModelIndex&) const", "$#")]
		protected virtual bool FilterAcceptsRow(int source_row, QModelIndex source_parent) {
			return ProxyQSortFilterProxyModel().FilterAcceptsRow(source_row,source_parent);
		}
		[SmokeMethod("filterAcceptsColumn", "(int, const QModelIndex&) const", "$#")]
		protected virtual bool FilterAcceptsColumn(int source_column, QModelIndex source_parent) {
			return ProxyQSortFilterProxyModel().FilterAcceptsColumn(source_column,source_parent);
		}
		[SmokeMethod("lessThan", "(const QModelIndex&, const QModelIndex&) const", "##")]
		protected virtual bool LessThan(QModelIndex left, QModelIndex right) {
			return ProxyQSortFilterProxyModel().LessThan(left,right);
		}
		[SmokeMethod("filterChanged", "()", "")]
		protected void FilterChanged() {
			ProxyQSortFilterProxyModel().FilterChanged();
		}
		~QSortFilterProxyModel() {
			DisposeQSortFilterProxyModel();
		}
		public new void Dispose() {
			DisposeQSortFilterProxyModel();
		}
		[SmokeMethod("~QSortFilterProxyModel", "()", "")]
		private void DisposeQSortFilterProxyModel() {
			ProxyQSortFilterProxyModel().DisposeQSortFilterProxyModel();
		}
		protected new IQSortFilterProxyModelSignals Emit {
			get { return (IQSortFilterProxyModelSignals) Q_EMIT; }
		}
	}

	public interface IQSortFilterProxyModelSignals : IQAbstractProxyModelSignals {
	}
}
