//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QSql")]
	public class QSql : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QSql(Type dummy) {}
		interface IQSqlProxy {
		}

		protected void CreateQSqlProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSql), this);
			_interceptor = (QSql) realProxy.GetTransparentProxy();
		}
		private QSql ProxyQSql() {
			return (QSql) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSql() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSqlProxy), null);
			_staticInterceptor = (IQSqlProxy) realProxy.GetTransparentProxy();
		}
		private static IQSqlProxy StaticQSql() {
			return (IQSqlProxy) _staticInterceptor;
		}

		public enum Op {
			None = -1,
			Insert = 0,
			Update = 1,
			Delete = 2,
		}
		public enum Location {
			BeforeFirst = -1,
			AfterLast = -2,
		}
		public enum Confirm {
			Cancel = -1,
			No = 0,
			Yes = 1,
		}
		public enum ParameterType {
			In = 1,
			Out = 2,
			InOut = 3,
		}
		public enum TableType {
			Tables = 0x01,
			SystemTables = 0x02,
			Views = 0x04,
			AllTables = 0xff,
		}
		public QSql() : this((Type) null) {
			CreateQSqlProxy();
			NewQSql();
		}
		[SmokeMethod("QSql()")]
		private void NewQSql() {
			ProxyQSql().NewQSql();
		}
		~QSql() {
			DisposeQSql();
		}
		public void Dispose() {
			DisposeQSql();
		}
		private void DisposeQSql() {
			ProxyQSql().DisposeQSql();
		}
	}
}
