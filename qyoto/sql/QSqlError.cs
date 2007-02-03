//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QSqlError")]
	public class QSqlError : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QSqlError(Type dummy) {}
		[SmokeClass("QSqlError")]
		interface IQSqlErrorProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSqlError), this);
			_interceptor = (QSqlError) realProxy.GetTransparentProxy();
		}
		private QSqlError ProxyQSqlError() {
			return (QSqlError) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSqlError() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSqlErrorProxy), null);
			_staticInterceptor = (IQSqlErrorProxy) realProxy.GetTransparentProxy();
		}
		private static IQSqlErrorProxy StaticQSqlError() {
			return (IQSqlErrorProxy) _staticInterceptor;
		}

		public enum ErrorType {
			NoError = 0,
			ConnectionError = 1,
			StatementError = 2,
			TransactionError = 3,
			UnknownError = 4,
		}
		public QSqlError(string driverText, string databaseText, QSqlError.ErrorType type, int number) : this((Type) null) {
			CreateProxy();
			NewQSqlError(driverText,databaseText,type,number);
		}
		[SmokeMethod("QSqlError", "(const QString&, const QString&, QSqlError::ErrorType, int)", "$$$$")]
		private void NewQSqlError(string driverText, string databaseText, QSqlError.ErrorType type, int number) {
			ProxyQSqlError().NewQSqlError(driverText,databaseText,type,number);
		}
		public QSqlError(string driverText, string databaseText, QSqlError.ErrorType type) : this((Type) null) {
			CreateProxy();
			NewQSqlError(driverText,databaseText,type);
		}
		[SmokeMethod("QSqlError", "(const QString&, const QString&, QSqlError::ErrorType)", "$$$")]
		private void NewQSqlError(string driverText, string databaseText, QSqlError.ErrorType type) {
			ProxyQSqlError().NewQSqlError(driverText,databaseText,type);
		}
		public QSqlError(string driverText, string databaseText) : this((Type) null) {
			CreateProxy();
			NewQSqlError(driverText,databaseText);
		}
		[SmokeMethod("QSqlError", "(const QString&, const QString&)", "$$")]
		private void NewQSqlError(string driverText, string databaseText) {
			ProxyQSqlError().NewQSqlError(driverText,databaseText);
		}
		public QSqlError(string driverText) : this((Type) null) {
			CreateProxy();
			NewQSqlError(driverText);
		}
		[SmokeMethod("QSqlError", "(const QString&)", "$")]
		private void NewQSqlError(string driverText) {
			ProxyQSqlError().NewQSqlError(driverText);
		}
		public QSqlError() : this((Type) null) {
			CreateProxy();
			NewQSqlError();
		}
		[SmokeMethod("QSqlError", "()", "")]
		private void NewQSqlError() {
			ProxyQSqlError().NewQSqlError();
		}
		public QSqlError(QSqlError other) : this((Type) null) {
			CreateProxy();
			NewQSqlError(other);
		}
		[SmokeMethod("QSqlError", "(const QSqlError&)", "#")]
		private void NewQSqlError(QSqlError other) {
			ProxyQSqlError().NewQSqlError(other);
		}
		[SmokeMethod("driverText", "() const", "")]
		public string DriverText() {
			return ProxyQSqlError().DriverText();
		}
		[SmokeMethod("setDriverText", "(const QString&)", "$")]
		public void SetDriverText(string driverText) {
			ProxyQSqlError().SetDriverText(driverText);
		}
		[SmokeMethod("databaseText", "() const", "")]
		public string DatabaseText() {
			return ProxyQSqlError().DatabaseText();
		}
		[SmokeMethod("setDatabaseText", "(const QString&)", "$")]
		public void SetDatabaseText(string databaseText) {
			ProxyQSqlError().SetDatabaseText(databaseText);
		}
		[SmokeMethod("type", "() const", "")]
		public QSqlError.ErrorType type() {
			return ProxyQSqlError().type();
		}
		[SmokeMethod("setType", "(QSqlError::ErrorType)", "$")]
		public void SetType(QSqlError.ErrorType type) {
			ProxyQSqlError().SetType(type);
		}
		[SmokeMethod("number", "() const", "")]
		public int Number() {
			return ProxyQSqlError().Number();
		}
		[SmokeMethod("setNumber", "(int)", "$")]
		public void SetNumber(int number) {
			ProxyQSqlError().SetNumber(number);
		}
		[SmokeMethod("text", "() const", "")]
		public string Text() {
			return ProxyQSqlError().Text();
		}
		[SmokeMethod("isValid", "() const", "")]
		public bool IsValid() {
			return ProxyQSqlError().IsValid();
		}
		~QSqlError() {
			DisposeQSqlError();
		}
		public void Dispose() {
			DisposeQSqlError();
		}
		[SmokeMethod("~QSqlError", "()", "")]
		private void DisposeQSqlError() {
			ProxyQSqlError().DisposeQSqlError();
		}
	}
}
