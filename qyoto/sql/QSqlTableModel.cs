//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	/// See <see cref="IQSqlTableModelSignals"></see> for signals emitted by QSqlTableModel
	[SmokeClass("QSqlTableModel")]
	public class QSqlTableModel : QSqlQueryModel, IDisposable {
 		protected QSqlTableModel(Type dummy) : base((Type) null) {}
		[SmokeClass("QSqlTableModel")]
		interface IQSqlTableModelProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSqlTableModel), this);
			_interceptor = (QSqlTableModel) realProxy.GetTransparentProxy();
		}
		private QSqlTableModel ProxyQSqlTableModel() {
			return (QSqlTableModel) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSqlTableModel() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSqlTableModelProxy), null);
			_staticInterceptor = (IQSqlTableModelProxy) realProxy.GetTransparentProxy();
		}
		private static IQSqlTableModelProxy StaticQSqlTableModel() {
			return (IQSqlTableModelProxy) _staticInterceptor;
		}

		public enum EditStrategy {
			OnFieldChange = 0,
			OnRowChange = 1,
			OnManualSubmit = 2,
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QSqlTableModel(QObject parent, QSqlDatabase db) : this((Type) null) {
			CreateProxy();
			NewQSqlTableModel(parent,db);
		}
		[SmokeMethod("QSqlTableModel", "(QObject*, QSqlDatabase)", "##")]
		private void NewQSqlTableModel(QObject parent, QSqlDatabase db) {
			ProxyQSqlTableModel().NewQSqlTableModel(parent,db);
		}
		public QSqlTableModel(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQSqlTableModel(parent);
		}
		[SmokeMethod("QSqlTableModel", "(QObject*)", "#")]
		private void NewQSqlTableModel(QObject parent) {
			ProxyQSqlTableModel().NewQSqlTableModel(parent);
		}
		public QSqlTableModel() : this((Type) null) {
			CreateProxy();
			NewQSqlTableModel();
		}
		[SmokeMethod("QSqlTableModel", "()", "")]
		private void NewQSqlTableModel() {
			ProxyQSqlTableModel().NewQSqlTableModel();
		}
		[SmokeMethod("select", "()", "")]
		public virtual bool Select() {
			return ProxyQSqlTableModel().Select();
		}
		[SmokeMethod("setTable", "(const QString&)", "$")]
		public virtual void SetTable(string tableName) {
			ProxyQSqlTableModel().SetTable(tableName);
		}
		[SmokeMethod("tableName", "() const", "")]
		public string TableName() {
			return ProxyQSqlTableModel().TableName();
		}
		[SmokeMethod("flags", "(const QModelIndex&) const", "#")]
		public new int Flags(QModelIndex index) {
			return ProxyQSqlTableModel().Flags(index);
		}
		[SmokeMethod("data", "(const QModelIndex&, int) const", "#$")]
		public new QVariant Data(QModelIndex idx, int role) {
			return ProxyQSqlTableModel().Data(idx,role);
		}
		[SmokeMethod("data", "(const QModelIndex&) const", "#")]
		public new QVariant Data(QModelIndex idx) {
			return ProxyQSqlTableModel().Data(idx);
		}
		[SmokeMethod("setData", "(const QModelIndex&, const QVariant&, int)", "##$")]
		public new bool SetData(QModelIndex index, QVariant value, int role) {
			return ProxyQSqlTableModel().SetData(index,value,role);
		}
		[SmokeMethod("setData", "(const QModelIndex&, const QVariant&)", "##")]
		public new bool SetData(QModelIndex index, QVariant value) {
			return ProxyQSqlTableModel().SetData(index,value);
		}
		[SmokeMethod("headerData", "(int, Qt::Orientation, int) const", "$$$")]
		public new QVariant HeaderData(int section, Qt.Orientation orientation, int role) {
			return ProxyQSqlTableModel().HeaderData(section,orientation,role);
		}
		[SmokeMethod("headerData", "(int, Qt::Orientation) const", "$$")]
		public new QVariant HeaderData(int section, Qt.Orientation orientation) {
			return ProxyQSqlTableModel().HeaderData(section,orientation);
		}
		[SmokeMethod("isDirty", "(const QModelIndex&) const", "#")]
		public bool IsDirty(QModelIndex index) {
			return ProxyQSqlTableModel().IsDirty(index);
		}
		[SmokeMethod("clear", "()", "")]
		public new void Clear() {
			ProxyQSqlTableModel().Clear();
		}
		[SmokeMethod("setEditStrategy", "(QSqlTableModel::EditStrategy)", "$")]
		public virtual void SetEditStrategy(QSqlTableModel.EditStrategy strategy) {
			ProxyQSqlTableModel().SetEditStrategy(strategy);
		}
		[SmokeMethod("editStrategy", "() const", "")]
		public QSqlTableModel.EditStrategy editStrategy() {
			return ProxyQSqlTableModel().editStrategy();
		}
		[SmokeMethod("primaryKey", "() const", "")]
		public QSqlIndex PrimaryKey() {
			return ProxyQSqlTableModel().PrimaryKey();
		}
		[SmokeMethod("database", "() const", "")]
		public QSqlDatabase Database() {
			return ProxyQSqlTableModel().Database();
		}
		[SmokeMethod("fieldIndex", "(const QString&) const", "$")]
		public int FieldIndex(string fieldName) {
			return ProxyQSqlTableModel().FieldIndex(fieldName);
		}
		[SmokeMethod("sort", "(int, Qt::SortOrder)", "$$")]
		public new void Sort(int column, Qt.SortOrder order) {
			ProxyQSqlTableModel().Sort(column,order);
		}
		[SmokeMethod("setSort", "(int, Qt::SortOrder)", "$$")]
		public virtual void SetSort(int column, Qt.SortOrder order) {
			ProxyQSqlTableModel().SetSort(column,order);
		}
		[SmokeMethod("filter", "() const", "")]
		public string Filter() {
			return ProxyQSqlTableModel().Filter();
		}
		[SmokeMethod("setFilter", "(const QString&)", "$")]
		public virtual void SetFilter(string filter) {
			ProxyQSqlTableModel().SetFilter(filter);
		}
		[SmokeMethod("rowCount", "(const QModelIndex&) const", "#")]
		public new int RowCount(QModelIndex parent) {
			return ProxyQSqlTableModel().RowCount(parent);
		}
		[SmokeMethod("rowCount", "() const", "")]
		public new int RowCount() {
			return ProxyQSqlTableModel().RowCount();
		}
		[SmokeMethod("removeColumns", "(int, int, const QModelIndex&)", "$$#")]
		public new bool RemoveColumns(int column, int count, QModelIndex parent) {
			return ProxyQSqlTableModel().RemoveColumns(column,count,parent);
		}
		[SmokeMethod("removeColumns", "(int, int)", "$$")]
		public new bool RemoveColumns(int column, int count) {
			return ProxyQSqlTableModel().RemoveColumns(column,count);
		}
		[SmokeMethod("removeRows", "(int, int, const QModelIndex&)", "$$#")]
		public new bool RemoveRows(int row, int count, QModelIndex parent) {
			return ProxyQSqlTableModel().RemoveRows(row,count,parent);
		}
		[SmokeMethod("removeRows", "(int, int)", "$$")]
		public new bool RemoveRows(int row, int count) {
			return ProxyQSqlTableModel().RemoveRows(row,count);
		}
		[SmokeMethod("insertRows", "(int, int, const QModelIndex&)", "$$#")]
		public new bool InsertRows(int row, int count, QModelIndex parent) {
			return ProxyQSqlTableModel().InsertRows(row,count,parent);
		}
		[SmokeMethod("insertRows", "(int, int)", "$$")]
		public new bool InsertRows(int row, int count) {
			return ProxyQSqlTableModel().InsertRows(row,count);
		}
		[SmokeMethod("insertRecord", "(int, const QSqlRecord&)", "$#")]
		public bool InsertRecord(int row, QSqlRecord record) {
			return ProxyQSqlTableModel().InsertRecord(row,record);
		}
		[SmokeMethod("setRecord", "(int, const QSqlRecord&)", "$#")]
		public bool SetRecord(int row, QSqlRecord record) {
			return ProxyQSqlTableModel().SetRecord(row,record);
		}
		[SmokeMethod("revertRow", "(int)", "$")]
		public virtual void RevertRow(int row) {
			ProxyQSqlTableModel().RevertRow(row);
		}
		[Q_SLOT("bool submit()")]
		[SmokeMethod("submit", "()", "")]
		public new bool Submit() {
			return ProxyQSqlTableModel().Submit();
		}
		[Q_SLOT("void revert()")]
		[SmokeMethod("revert", "()", "")]
		public new void Revert() {
			ProxyQSqlTableModel().Revert();
		}
		[Q_SLOT("bool submitAll()")]
		[SmokeMethod("submitAll", "()", "")]
		public bool SubmitAll() {
			return ProxyQSqlTableModel().SubmitAll();
		}
		[Q_SLOT("void revertAll()")]
		[SmokeMethod("revertAll", "()", "")]
		public void RevertAll() {
			ProxyQSqlTableModel().RevertAll();
		}
		public static new string Tr(string s, string c) {
			return StaticQSqlTableModel().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQSqlTableModel().Tr(s);
		}
		[SmokeMethod("updateRowInTable", "(int, const QSqlRecord&)", "$#")]
		protected virtual bool UpdateRowInTable(int row, QSqlRecord values) {
			return ProxyQSqlTableModel().UpdateRowInTable(row,values);
		}
		[SmokeMethod("insertRowIntoTable", "(const QSqlRecord&)", "#")]
		protected virtual bool InsertRowIntoTable(QSqlRecord values) {
			return ProxyQSqlTableModel().InsertRowIntoTable(values);
		}
		[SmokeMethod("deleteRowFromTable", "(int)", "$")]
		protected virtual bool DeleteRowFromTable(int row) {
			return ProxyQSqlTableModel().DeleteRowFromTable(row);
		}
		[SmokeMethod("orderByClause", "() const", "")]
		protected virtual string OrderByClause() {
			return ProxyQSqlTableModel().OrderByClause();
		}
		[SmokeMethod("selectStatement", "() const", "")]
		protected virtual string SelectStatement() {
			return ProxyQSqlTableModel().SelectStatement();
		}
		[SmokeMethod("setPrimaryKey", "(const QSqlIndex&)", "#")]
		protected void SetPrimaryKey(QSqlIndex key) {
			ProxyQSqlTableModel().SetPrimaryKey(key);
		}
		[SmokeMethod("setQuery", "(const QSqlQuery&)", "#")]
		protected new void SetQuery(IQSqlQuery query) {
			ProxyQSqlTableModel().SetQuery(query);
		}
		[SmokeMethod("indexInQuery", "(const QModelIndex&) const", "#")]
		protected new QModelIndex IndexInQuery(QModelIndex item) {
			return ProxyQSqlTableModel().IndexInQuery(item);
		}
		~QSqlTableModel() {
			DisposeQSqlTableModel();
		}
		public new void Dispose() {
			DisposeQSqlTableModel();
		}
		[SmokeMethod("~QSqlTableModel", "()", "")]
		private void DisposeQSqlTableModel() {
			ProxyQSqlTableModel().DisposeQSqlTableModel();
		}
		protected new IQSqlTableModelSignals Emit {
			get {
				return (IQSqlTableModelSignals) Q_EMIT;
			}
		}
	}

	public interface IQSqlTableModelSignals : IQSqlQueryModelSignals {
		[Q_SIGNAL("void primeInsert(int, QSqlRecord&)")]
		void PrimeInsert(int row, QSqlRecord record);
		[Q_SIGNAL("void beforeInsert(QSqlRecord&)")]
		void BeforeInsert(QSqlRecord record);
		[Q_SIGNAL("void beforeUpdate(int, QSqlRecord&)")]
		void BeforeUpdate(int row, QSqlRecord record);
		[Q_SIGNAL("void beforeDelete(int)")]
		void BeforeDelete(int row);
	}
}
