//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	[SmokeClass("QSqlQueryModel")]
	public partial class QSqlQueryModel : QAbstractTableModel, IDisposable {
 		protected QSqlQueryModel(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QSqlQueryModel), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QSqlQueryModel() {
			staticInterceptor = new SmokeInvocation(typeof(QSqlQueryModel), null);
		}
		// QSqlQueryModel* QSqlQueryModel(QSqlQueryModelPrivate& arg1,QObject* arg2); >>>> NOT CONVERTED
		// QSqlQueryModel* QSqlQueryModel(QSqlQueryModelPrivate& arg1); >>>> NOT CONVERTED
		public QSqlQueryModel(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSqlQueryModel#", "QSqlQueryModel(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public QSqlQueryModel() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QSqlQueryModel", "QSqlQueryModel()", typeof(void));
		}
		[SmokeMethod("rowCount(const QModelIndex&) const")]
		public override int RowCount(QModelIndex parent) {
			return (int) interceptor.Invoke("rowCount#", "rowCount(const QModelIndex&) const", typeof(int), typeof(QModelIndex), parent);
		}
		[SmokeMethod("rowCount() const")]
		public virtual int RowCount() {
			return (int) interceptor.Invoke("rowCount", "rowCount() const", typeof(int));
		}
		[SmokeMethod("columnCount(const QModelIndex&) const")]
		public override int ColumnCount(QModelIndex parent) {
			return (int) interceptor.Invoke("columnCount#", "columnCount(const QModelIndex&) const", typeof(int), typeof(QModelIndex), parent);
		}
		[SmokeMethod("columnCount() const")]
		public virtual int ColumnCount() {
			return (int) interceptor.Invoke("columnCount", "columnCount() const", typeof(int));
		}
		public QSqlRecord Record(int row) {
			return (QSqlRecord) interceptor.Invoke("record$", "record(int) const", typeof(QSqlRecord), typeof(int), row);
		}
		public QSqlRecord Record() {
			return (QSqlRecord) interceptor.Invoke("record", "record() const", typeof(QSqlRecord));
		}
		[SmokeMethod("data(const QModelIndex&, int) const")]
		public override QVariant Data(QModelIndex item, int role) {
			return (QVariant) interceptor.Invoke("data#$", "data(const QModelIndex&, int) const", typeof(QVariant), typeof(QModelIndex), item, typeof(int), role);
		}
		[SmokeMethod("data(const QModelIndex&) const")]
		public virtual QVariant Data(QModelIndex item) {
			return (QVariant) interceptor.Invoke("data#", "data(const QModelIndex&) const", typeof(QVariant), typeof(QModelIndex), item);
		}
		[SmokeMethod("headerData(int, Qt::Orientation, int) const")]
		public override QVariant HeaderData(int section, Qt.Orientation orientation, int role) {
			return (QVariant) interceptor.Invoke("headerData$$$", "headerData(int, Qt::Orientation, int) const", typeof(QVariant), typeof(int), section, typeof(Qt.Orientation), orientation, typeof(int), role);
		}
		[SmokeMethod("headerData(int, Qt::Orientation) const")]
		public override QVariant HeaderData(int section, Qt.Orientation orientation) {
			return (QVariant) interceptor.Invoke("headerData$$", "headerData(int, Qt::Orientation) const", typeof(QVariant), typeof(int), section, typeof(Qt.Orientation), orientation);
		}
		[SmokeMethod("setHeaderData(int, Qt::Orientation, const QVariant&, int)")]
		public override bool SetHeaderData(int section, Qt.Orientation orientation, QVariant value, int role) {
			return (bool) interceptor.Invoke("setHeaderData$$#$", "setHeaderData(int, Qt::Orientation, const QVariant&, int)", typeof(bool), typeof(int), section, typeof(Qt.Orientation), orientation, typeof(QVariant), value, typeof(int), role);
		}
		[SmokeMethod("setHeaderData(int, Qt::Orientation, const QVariant&)")]
		public override bool SetHeaderData(int section, Qt.Orientation orientation, QVariant value) {
			return (bool) interceptor.Invoke("setHeaderData$$#", "setHeaderData(int, Qt::Orientation, const QVariant&)", typeof(bool), typeof(int), section, typeof(Qt.Orientation), orientation, typeof(QVariant), value);
		}
		[SmokeMethod("insertColumns(int, int, const QModelIndex&)")]
		public override bool InsertColumns(int column, int count, QModelIndex parent) {
			return (bool) interceptor.Invoke("insertColumns$$#", "insertColumns(int, int, const QModelIndex&)", typeof(bool), typeof(int), column, typeof(int), count, typeof(QModelIndex), parent);
		}
		[SmokeMethod("insertColumns(int, int)")]
		public override bool InsertColumns(int column, int count) {
			return (bool) interceptor.Invoke("insertColumns$$", "insertColumns(int, int)", typeof(bool), typeof(int), column, typeof(int), count);
		}
		[SmokeMethod("removeColumns(int, int, const QModelIndex&)")]
		public override bool RemoveColumns(int column, int count, QModelIndex parent) {
			return (bool) interceptor.Invoke("removeColumns$$#", "removeColumns(int, int, const QModelIndex&)", typeof(bool), typeof(int), column, typeof(int), count, typeof(QModelIndex), parent);
		}
		[SmokeMethod("removeColumns(int, int)")]
		public override bool RemoveColumns(int column, int count) {
			return (bool) interceptor.Invoke("removeColumns$$", "removeColumns(int, int)", typeof(bool), typeof(int), column, typeof(int), count);
		}
		public void SetQuery(QSqlQuery query) {
			interceptor.Invoke("setQuery#", "setQuery(const QSqlQuery&)", typeof(void), typeof(QSqlQuery), query);
		}
		public void SetQuery(string query, QSqlDatabase db) {
			interceptor.Invoke("setQuery$#", "setQuery(const QString&, const QSqlDatabase&)", typeof(void), typeof(string), query, typeof(QSqlDatabase), db);
		}
		public void SetQuery(string query) {
			interceptor.Invoke("setQuery$", "setQuery(const QString&)", typeof(void), typeof(string), query);
		}
		public QSqlQuery Query() {
			return (QSqlQuery) interceptor.Invoke("query", "query() const", typeof(QSqlQuery));
		}
		[SmokeMethod("clear()")]
		public virtual void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		public QSqlError LastError() {
			return (QSqlError) interceptor.Invoke("lastError", "lastError() const", typeof(QSqlError));
		}
		[SmokeMethod("fetchMore(const QModelIndex&)")]
		public override void FetchMore(QModelIndex parent) {
			interceptor.Invoke("fetchMore#", "fetchMore(const QModelIndex&)", typeof(void), typeof(QModelIndex), parent);
		}
		public void FetchMore() {
			interceptor.Invoke("fetchMore", "fetchMore()", typeof(void));
		}
		[SmokeMethod("canFetchMore(const QModelIndex&) const")]
		public override bool CanFetchMore(QModelIndex parent) {
			return (bool) interceptor.Invoke("canFetchMore#", "canFetchMore(const QModelIndex&) const", typeof(bool), typeof(QModelIndex), parent);
		}
		public bool CanFetchMore() {
			return (bool) interceptor.Invoke("canFetchMore", "canFetchMore() const", typeof(bool));
		}
		[SmokeMethod("queryChange()")]
		protected virtual void QueryChange() {
			interceptor.Invoke("queryChange", "queryChange()", typeof(void));
		}
		protected QModelIndex IndexInQuery(QModelIndex item) {
			return (QModelIndex) interceptor.Invoke("indexInQuery#", "indexInQuery(const QModelIndex&) const", typeof(QModelIndex), typeof(QModelIndex), item);
		}
		protected void SetLastError(QSqlError error) {
			interceptor.Invoke("setLastError#", "setLastError(const QSqlError&)", typeof(void), typeof(QSqlError), error);
		}
		~QSqlQueryModel() {
			interceptor.Invoke("~QSqlQueryModel", "~QSqlQueryModel()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QSqlQueryModel", "~QSqlQueryModel()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQSqlQueryModelSignals Emit {
			get { return (IQSqlQueryModelSignals) Q_EMIT; }
		}
	}

	public interface IQSqlQueryModelSignals : IQAbstractTableModelSignals {
	}
}
