//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	public interface IQSqlQuery {
			bool IsValid();
			bool IsActive();
			bool IsNull(int field);
			int At();
			string LastQuery();
			int NumRowsAffected();
			QSqlError LastError();
			bool IsSelect();
			int Size();
			QSqlDriver Driver();
			QSqlResult Result();
			bool IsForwardOnly();
			QSqlRecord Record();
			void SetForwardOnly(bool forward);
			bool Exec(string query);
			QVariant Value(int i);
			bool Seek(int i, bool relative);
			bool Seek(int i);
			bool Next();
			bool Previous();
			bool First();
			bool Last();
			void Clear();
			bool Exec();
			bool ExecBatch(QSqlQuery.BatchExecutionMode mode);
			bool ExecBatch();
			bool Prepare(string query);
			void BindValue(string placeholder, QVariant val, int type);
			void BindValue(string placeholder, QVariant val);
			void BindValue(int pos, QVariant val, int type);
			void BindValue(int pos, QVariant val);
			void AddBindValue(QVariant val, int type);
			void AddBindValue(QVariant val);
			QVariant BoundValue(string placeholder);
			QVariant BoundValue(int pos);
			Dictionary<string, QVariant> BoundValues();
			string ExecutedQuery();
			QVariant LastInsertId();
	}

	[SmokeClass("QSqlQuery")]
	public class QSqlQuery : MarshalByRefObject, IQSqlQuery, IDisposable {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QSqlQuery(Type dummy) {}
		[SmokeClass("QSqlQuery")]
		interface IQSqlQueryProxy {
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSqlQuery), this);
			_interceptor = (QSqlQuery) realProxy.GetTransparentProxy();
		}
		private QSqlQuery ProxyQSqlQuery() {
			return (QSqlQuery) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSqlQuery() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSqlQueryProxy), null);
			_staticInterceptor = (IQSqlQueryProxy) realProxy.GetTransparentProxy();
		}
		private static IQSqlQueryProxy StaticQSqlQuery() {
			return (IQSqlQueryProxy) _staticInterceptor;
		}
		public enum BatchExecutionMode {
			ValuesAsRows = 0,
			ValuesAsColumns = 1,
		}
		public QSqlQuery(QSqlResult r) : this((Type) null) {
			CreateProxy();
			NewQSqlQuery(r);
		}
		[SmokeMethod("QSqlQuery", "(QSqlResult*)", "#")]
		private void NewQSqlQuery(QSqlResult r) {
			ProxyQSqlQuery().NewQSqlQuery(r);
		}
		public QSqlQuery(string query, QSqlDatabase db) : this((Type) null) {
			CreateProxy();
			NewQSqlQuery(query,db);
		}
		[SmokeMethod("QSqlQuery", "(const QString&, QSqlDatabase)", "$#")]
		private void NewQSqlQuery(string query, QSqlDatabase db) {
			ProxyQSqlQuery().NewQSqlQuery(query,db);
		}
		public QSqlQuery(string query) : this((Type) null) {
			CreateProxy();
			NewQSqlQuery(query);
		}
		[SmokeMethod("QSqlQuery", "(const QString&)", "$")]
		private void NewQSqlQuery(string query) {
			ProxyQSqlQuery().NewQSqlQuery(query);
		}
		public QSqlQuery() : this((Type) null) {
			CreateProxy();
			NewQSqlQuery();
		}
		[SmokeMethod("QSqlQuery", "()", "")]
		private void NewQSqlQuery() {
			ProxyQSqlQuery().NewQSqlQuery();
		}
		public QSqlQuery(QSqlDatabase db) : this((Type) null) {
			CreateProxy();
			NewQSqlQuery(db);
		}
		[SmokeMethod("QSqlQuery", "(QSqlDatabase)", "#")]
		private void NewQSqlQuery(QSqlDatabase db) {
			ProxyQSqlQuery().NewQSqlQuery(db);
		}
		public QSqlQuery(IQSqlQuery other) : this((Type) null) {
			CreateProxy();
			NewQSqlQuery(other);
		}
		[SmokeMethod("QSqlQuery", "(const QSqlQuery&)", "#")]
		private void NewQSqlQuery(IQSqlQuery other) {
			ProxyQSqlQuery().NewQSqlQuery(other);
		}
		[SmokeMethod("isValid", "() const", "")]
		public bool IsValid() {
			return ProxyQSqlQuery().IsValid();
		}
		[SmokeMethod("isActive", "() const", "")]
		public bool IsActive() {
			return ProxyQSqlQuery().IsActive();
		}
		[SmokeMethod("isNull", "(int) const", "$")]
		public bool IsNull(int field) {
			return ProxyQSqlQuery().IsNull(field);
		}
		[SmokeMethod("at", "() const", "")]
		public int At() {
			return ProxyQSqlQuery().At();
		}
		[SmokeMethod("lastQuery", "() const", "")]
		public string LastQuery() {
			return ProxyQSqlQuery().LastQuery();
		}
		[SmokeMethod("numRowsAffected", "() const", "")]
		public int NumRowsAffected() {
			return ProxyQSqlQuery().NumRowsAffected();
		}
		[SmokeMethod("lastError", "() const", "")]
		public QSqlError LastError() {
			return ProxyQSqlQuery().LastError();
		}
		[SmokeMethod("isSelect", "() const", "")]
		public bool IsSelect() {
			return ProxyQSqlQuery().IsSelect();
		}
		[SmokeMethod("size", "() const", "")]
		public int Size() {
			return ProxyQSqlQuery().Size();
		}
		[SmokeMethod("driver", "() const", "")]
		public QSqlDriver Driver() {
			return ProxyQSqlQuery().Driver();
		}
		[SmokeMethod("result", "() const", "")]
		public QSqlResult Result() {
			return ProxyQSqlQuery().Result();
		}
		[SmokeMethod("isForwardOnly", "() const", "")]
		public bool IsForwardOnly() {
			return ProxyQSqlQuery().IsForwardOnly();
		}
		[SmokeMethod("record", "() const", "")]
		public QSqlRecord Record() {
			return ProxyQSqlQuery().Record();
		}
		[SmokeMethod("setForwardOnly", "(bool)", "$")]
		public void SetForwardOnly(bool forward) {
			ProxyQSqlQuery().SetForwardOnly(forward);
		}
		[SmokeMethod("exec", "(const QString&)", "$")]
		public bool Exec(string query) {
			return ProxyQSqlQuery().Exec(query);
		}
		[SmokeMethod("value", "(int) const", "$")]
		public QVariant Value(int i) {
			return ProxyQSqlQuery().Value(i);
		}
		[SmokeMethod("seek", "(int, bool)", "$$")]
		public bool Seek(int i, bool relative) {
			return ProxyQSqlQuery().Seek(i,relative);
		}
		[SmokeMethod("seek", "(int)", "$")]
		public bool Seek(int i) {
			return ProxyQSqlQuery().Seek(i);
		}
		[SmokeMethod("next", "()", "")]
		public bool Next() {
			return ProxyQSqlQuery().Next();
		}
		[SmokeMethod("previous", "()", "")]
		public bool Previous() {
			return ProxyQSqlQuery().Previous();
		}
		[SmokeMethod("first", "()", "")]
		public bool First() {
			return ProxyQSqlQuery().First();
		}
		[SmokeMethod("last", "()", "")]
		public bool Last() {
			return ProxyQSqlQuery().Last();
		}
		[SmokeMethod("clear", "()", "")]
		public void Clear() {
			ProxyQSqlQuery().Clear();
		}
		[SmokeMethod("exec", "()", "")]
		public bool Exec() {
			return ProxyQSqlQuery().Exec();
		}
		[SmokeMethod("execBatch", "(QSqlQuery::BatchExecutionMode)", "$")]
		public bool ExecBatch(QSqlQuery.BatchExecutionMode mode) {
			return ProxyQSqlQuery().ExecBatch(mode);
		}
		[SmokeMethod("execBatch", "()", "")]
		public bool ExecBatch() {
			return ProxyQSqlQuery().ExecBatch();
		}
		[SmokeMethod("prepare", "(const QString&)", "$")]
		public bool Prepare(string query) {
			return ProxyQSqlQuery().Prepare(query);
		}
		[SmokeMethod("bindValue", "(const QString&, const QVariant&, QSql::ParamType)", "$#$")]
		public void BindValue(string placeholder, QVariant val, int type) {
			ProxyQSqlQuery().BindValue(placeholder,val,type);
		}
		[SmokeMethod("bindValue", "(const QString&, const QVariant&)", "$#")]
		public void BindValue(string placeholder, QVariant val) {
			ProxyQSqlQuery().BindValue(placeholder,val);
		}
		[SmokeMethod("bindValue", "(int, const QVariant&, QSql::ParamType)", "$#$")]
		public void BindValue(int pos, QVariant val, int type) {
			ProxyQSqlQuery().BindValue(pos,val,type);
		}
		[SmokeMethod("bindValue", "(int, const QVariant&)", "$#")]
		public void BindValue(int pos, QVariant val) {
			ProxyQSqlQuery().BindValue(pos,val);
		}
		[SmokeMethod("addBindValue", "(const QVariant&, QSql::ParamType)", "#$")]
		public void AddBindValue(QVariant val, int type) {
			ProxyQSqlQuery().AddBindValue(val,type);
		}
		[SmokeMethod("addBindValue", "(const QVariant&)", "#")]
		public void AddBindValue(QVariant val) {
			ProxyQSqlQuery().AddBindValue(val);
		}
		[SmokeMethod("boundValue", "(const QString&) const", "$")]
		public QVariant BoundValue(string placeholder) {
			return ProxyQSqlQuery().BoundValue(placeholder);
		}
		[SmokeMethod("boundValue", "(int) const", "$")]
		public QVariant BoundValue(int pos) {
			return ProxyQSqlQuery().BoundValue(pos);
		}
		[SmokeMethod("boundValues", "() const", "")]
		public Dictionary<string, QVariant> BoundValues() {
			return ProxyQSqlQuery().BoundValues();
		}
		[SmokeMethod("executedQuery", "() const", "")]
		public string ExecutedQuery() {
			return ProxyQSqlQuery().ExecutedQuery();
		}
		[SmokeMethod("lastInsertId", "() const", "")]
		public QVariant LastInsertId() {
			return ProxyQSqlQuery().LastInsertId();
		}
		~QSqlQuery() {
			DisposeQSqlQuery();
		}
		public void Dispose() {
			DisposeQSqlQuery();
		}
		[SmokeMethod("~QSqlQuery", "()", "")]
		private void DisposeQSqlQuery() {
			ProxyQSqlQuery().DisposeQSqlQuery();
		}
	}
}
