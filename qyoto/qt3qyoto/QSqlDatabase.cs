//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Collections;
	using System.Text;

	public class QSqlDatabase : QObject, IDisposable {
 		protected QSqlDatabase(Type dummy) : base((Type) null) {}
		interface IQSqlDatabaseProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
			QSqlDatabase AddDatabase(string type, string connectionName);
			QSqlDatabase AddDatabase(string type);
			QSqlDatabase AddDatabase(QSqlDriver driver, string connectionName);
			QSqlDatabase AddDatabase(QSqlDriver driver);
			QSqlDatabase Database(string connectionName, bool open);
			QSqlDatabase Database(string connectionName);
			QSqlDatabase Database();
			void RemoveDatabase(string connectionName);
			void RemoveDatabase(QSqlDatabase db);
			bool Contains(string connectionName);
			bool Contains();
			ArrayList Drivers();
			bool IsDriverAvailable(string name);
		}

		protected void CreateQSqlDatabaseProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSqlDatabase), this);
			_interceptor = (QSqlDatabase) realProxy.GetTransparentProxy();
		}
		private QSqlDatabase ProxyQSqlDatabase() {
			return (QSqlDatabase) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSqlDatabase() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSqlDatabaseProxy), null);
			_staticInterceptor = (IQSqlDatabaseProxy) realProxy.GetTransparentProxy();
		}
		private static IQSqlDatabaseProxy StaticQSqlDatabase() {
			return (IQSqlDatabaseProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQSqlDatabase().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQSqlDatabase().ClassName();
		}
		[SmokeMethod("open()")]
		public bool Open() {
			return ProxyQSqlDatabase().Open();
		}
		[SmokeMethod("open(const QString&, const QString&)")]
		public bool Open(string user, string password) {
			return ProxyQSqlDatabase().Open(user,password);
		}
		[SmokeMethod("close()")]
		public void Close() {
			ProxyQSqlDatabase().Close();
		}
		[SmokeMethod("isOpen() const")]
		public bool IsOpen() {
			return ProxyQSqlDatabase().IsOpen();
		}
		[SmokeMethod("isOpenError() const")]
		public bool IsOpenError() {
			return ProxyQSqlDatabase().IsOpenError();
		}
		[SmokeMethod("tables() const")]
		public ArrayList Tables() {
			return ProxyQSqlDatabase().Tables();
		}
		[SmokeMethod("tables(QSql::TableType) const")]
		public ArrayList Tables(int type) {
			return ProxyQSqlDatabase().Tables(type);
		}
		[SmokeMethod("primaryIndex(const QString&) const")]
		public QSqlIndex PrimaryIndex(string tablename) {
			return ProxyQSqlDatabase().PrimaryIndex(tablename);
		}
		[SmokeMethod("record(const QString&) const")]
		public QSqlRecord Record(string tablename) {
			return ProxyQSqlDatabase().Record(tablename);
		}
		[SmokeMethod("record(const QSqlQuery&) const")]
		public QSqlRecord Record(IQSqlQuery query) {
			return ProxyQSqlDatabase().Record(query);
		}
		[SmokeMethod("recordInfo(const QString&) const")]
		public QSqlRecordInfo RecordInfo(string tablename) {
			return ProxyQSqlDatabase().RecordInfo(tablename);
		}
		[SmokeMethod("recordInfo(const QSqlQuery&) const")]
		public QSqlRecordInfo RecordInfo(IQSqlQuery query) {
			return ProxyQSqlDatabase().RecordInfo(query);
		}
		[SmokeMethod("exec(const QString&) const")]
		public IQSqlQuery Exec(string query) {
			return ProxyQSqlDatabase().Exec(query);
		}
		[SmokeMethod("exec() const")]
		public IQSqlQuery Exec() {
			return ProxyQSqlDatabase().Exec();
		}
		[SmokeMethod("lastError() const")]
		public QSqlError LastError() {
			return ProxyQSqlDatabase().LastError();
		}
		[SmokeMethod("transaction()")]
		public bool Transaction() {
			return ProxyQSqlDatabase().Transaction();
		}
		[SmokeMethod("commit()")]
		public bool Commit() {
			return ProxyQSqlDatabase().Commit();
		}
		[SmokeMethod("rollback()")]
		public bool Rollback() {
			return ProxyQSqlDatabase().Rollback();
		}
		[SmokeMethod("setDatabaseName(const QString&)")]
		public virtual void SetDatabaseName(string name) {
			ProxyQSqlDatabase().SetDatabaseName(name);
		}
		[SmokeMethod("setUserName(const QString&)")]
		public virtual void SetUserName(string name) {
			ProxyQSqlDatabase().SetUserName(name);
		}
		[SmokeMethod("setPassword(const QString&)")]
		public virtual void SetPassword(string password) {
			ProxyQSqlDatabase().SetPassword(password);
		}
		[SmokeMethod("setHostName(const QString&)")]
		public virtual void SetHostName(string host) {
			ProxyQSqlDatabase().SetHostName(host);
		}
		[SmokeMethod("setPort(int)")]
		public virtual void SetPort(int p) {
			ProxyQSqlDatabase().SetPort(p);
		}
		[SmokeMethod("setConnectOptions(const QString&)")]
		public void SetConnectOptions(string options) {
			ProxyQSqlDatabase().SetConnectOptions(options);
		}
		[SmokeMethod("setConnectOptions()")]
		public void SetConnectOptions() {
			ProxyQSqlDatabase().SetConnectOptions();
		}
		[SmokeMethod("databaseName() const")]
		public string DatabaseName() {
			return ProxyQSqlDatabase().DatabaseName();
		}
		[SmokeMethod("userName() const")]
		public string UserName() {
			return ProxyQSqlDatabase().UserName();
		}
		[SmokeMethod("password() const")]
		public string Password() {
			return ProxyQSqlDatabase().Password();
		}
		[SmokeMethod("hostName() const")]
		public string HostName() {
			return ProxyQSqlDatabase().HostName();
		}
		[SmokeMethod("driverName() const")]
		public string DriverName() {
			return ProxyQSqlDatabase().DriverName();
		}
		[SmokeMethod("port() const")]
		public int Port() {
			return ProxyQSqlDatabase().Port();
		}
		[SmokeMethod("connectOptions() const")]
		public string ConnectOptions() {
			return ProxyQSqlDatabase().ConnectOptions();
		}
		[SmokeMethod("driver() const")]
		public QSqlDriver Driver() {
			return ProxyQSqlDatabase().Driver();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQSqlDatabase().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQSqlDatabase().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQSqlDatabase().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQSqlDatabase().TrUtf8(arg1);
		}
		[SmokeMethod("addDatabase(const QString&, const QString&)")]
		public static QSqlDatabase AddDatabase(string type, string connectionName) {
			return StaticQSqlDatabase().AddDatabase(type,connectionName);
		}
		[SmokeMethod("addDatabase(const QString&)")]
		public static QSqlDatabase AddDatabase(string type) {
			return StaticQSqlDatabase().AddDatabase(type);
		}
		[SmokeMethod("addDatabase(QSqlDriver*, const QString&)")]
		public static QSqlDatabase AddDatabase(QSqlDriver driver, string connectionName) {
			return StaticQSqlDatabase().AddDatabase(driver,connectionName);
		}
		[SmokeMethod("addDatabase(QSqlDriver*)")]
		public static QSqlDatabase AddDatabase(QSqlDriver driver) {
			return StaticQSqlDatabase().AddDatabase(driver);
		}
		[SmokeMethod("database(const QString&, bool)")]
		public static QSqlDatabase Database(string connectionName, bool open) {
			return StaticQSqlDatabase().Database(connectionName,open);
		}
		[SmokeMethod("database(const QString&)")]
		public static QSqlDatabase Database(string connectionName) {
			return StaticQSqlDatabase().Database(connectionName);
		}
		[SmokeMethod("database()")]
		public static QSqlDatabase Database() {
			return StaticQSqlDatabase().Database();
		}
		[SmokeMethod("removeDatabase(const QString&)")]
		public static void RemoveDatabase(string connectionName) {
			StaticQSqlDatabase().RemoveDatabase(connectionName);
		}
		[SmokeMethod("removeDatabase(QSqlDatabase*)")]
		public static void RemoveDatabase(QSqlDatabase db) {
			StaticQSqlDatabase().RemoveDatabase(db);
		}
		[SmokeMethod("contains(const QString&)")]
		public static bool Contains(string connectionName) {
			return StaticQSqlDatabase().Contains(connectionName);
		}
		[SmokeMethod("contains()")]
		public static bool Contains() {
			return StaticQSqlDatabase().Contains();
		}
		[SmokeMethod("drivers()")]
		public static ArrayList Drivers() {
			return StaticQSqlDatabase().Drivers();
		}
		// void registerSqlDriver(const QString& arg1,const QSqlDriverCreatorBase* arg2); >>>> NOT CONVERTED
		[SmokeMethod("isDriverAvailable(const QString&)")]
		public static bool IsDriverAvailable(string name) {
			return StaticQSqlDatabase().IsDriverAvailable(name);
		}
		public QSqlDatabase(string type, string name, QObject parent, string objname) : this((Type) null) {
			CreateQSqlDatabaseProxy();
			CreateQSqlDatabaseSignalProxy();
			NewQSqlDatabase(type,name,parent,objname);
		}
		[SmokeMethod("QSqlDatabase(const QString&, const QString&, QObject*, const char*)")]
		private void NewQSqlDatabase(string type, string name, QObject parent, string objname) {
			ProxyQSqlDatabase().NewQSqlDatabase(type,name,parent,objname);
		}
		public QSqlDatabase(string type, string name, QObject parent) : this((Type) null) {
			CreateQSqlDatabaseProxy();
			CreateQSqlDatabaseSignalProxy();
			NewQSqlDatabase(type,name,parent);
		}
		[SmokeMethod("QSqlDatabase(const QString&, const QString&, QObject*)")]
		private void NewQSqlDatabase(string type, string name, QObject parent) {
			ProxyQSqlDatabase().NewQSqlDatabase(type,name,parent);
		}
		public QSqlDatabase(string type, string name) : this((Type) null) {
			CreateQSqlDatabaseProxy();
			CreateQSqlDatabaseSignalProxy();
			NewQSqlDatabase(type,name);
		}
		[SmokeMethod("QSqlDatabase(const QString&, const QString&)")]
		private void NewQSqlDatabase(string type, string name) {
			ProxyQSqlDatabase().NewQSqlDatabase(type,name);
		}
		public QSqlDatabase(QSqlDriver driver, QObject parent, string objname) : this((Type) null) {
			CreateQSqlDatabaseProxy();
			CreateQSqlDatabaseSignalProxy();
			NewQSqlDatabase(driver,parent,objname);
		}
		[SmokeMethod("QSqlDatabase(QSqlDriver*, QObject*, const char*)")]
		private void NewQSqlDatabase(QSqlDriver driver, QObject parent, string objname) {
			ProxyQSqlDatabase().NewQSqlDatabase(driver,parent,objname);
		}
		public QSqlDatabase(QSqlDriver driver, QObject parent) : this((Type) null) {
			CreateQSqlDatabaseProxy();
			CreateQSqlDatabaseSignalProxy();
			NewQSqlDatabase(driver,parent);
		}
		[SmokeMethod("QSqlDatabase(QSqlDriver*, QObject*)")]
		private void NewQSqlDatabase(QSqlDriver driver, QObject parent) {
			ProxyQSqlDatabase().NewQSqlDatabase(driver,parent);
		}
		public QSqlDatabase(QSqlDriver driver) : this((Type) null) {
			CreateQSqlDatabaseProxy();
			CreateQSqlDatabaseSignalProxy();
			NewQSqlDatabase(driver);
		}
		[SmokeMethod("QSqlDatabase(QSqlDriver*)")]
		private void NewQSqlDatabase(QSqlDriver driver) {
			ProxyQSqlDatabase().NewQSqlDatabase(driver);
		}
		~QSqlDatabase() {
			DisposeQSqlDatabase();
		}
		public new void Dispose() {
			DisposeQSqlDatabase();
		}
		private void DisposeQSqlDatabase() {
			ProxyQSqlDatabase().DisposeQSqlDatabase();
		}
		protected void CreateQSqlDatabaseSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQSqlDatabaseSignals), this);
			_signalInterceptor = (IQSqlDatabaseSignals) realProxy.GetTransparentProxy();
		}
		protected new IQSqlDatabaseSignals Emit() {
			return (IQSqlDatabaseSignals) _signalInterceptor;
		}
	}

	public interface IQSqlDatabaseSignals : IQObjectSignals {
	}
}
