//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QSqlField")]
	public class QSqlField : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QSqlField(Type dummy) {}
		interface IQSqlFieldProxy {
			bool op_equals(QSqlField lhs, QSqlField other);
		}

		protected void CreateQSqlFieldProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSqlField), this);
			_interceptor = (QSqlField) realProxy.GetTransparentProxy();
		}
		private QSqlField ProxyQSqlField() {
			return (QSqlField) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSqlField() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSqlFieldProxy), null);
			_staticInterceptor = (IQSqlFieldProxy) realProxy.GetTransparentProxy();
		}
		private static IQSqlFieldProxy StaticQSqlField() {
			return (IQSqlFieldProxy) _staticInterceptor;
		}

		public QSqlField(string fieldName, QVariant.E_Type type) : this((Type) null) {
			CreateQSqlFieldProxy();
			NewQSqlField(fieldName,type);
		}
		[SmokeMethod("QSqlField(const QString&, QVariant::Type)")]
		private void NewQSqlField(string fieldName, QVariant.E_Type type) {
			ProxyQSqlField().NewQSqlField(fieldName,type);
		}
		public QSqlField(string fieldName) : this((Type) null) {
			CreateQSqlFieldProxy();
			NewQSqlField(fieldName);
		}
		[SmokeMethod("QSqlField(const QString&)")]
		private void NewQSqlField(string fieldName) {
			ProxyQSqlField().NewQSqlField(fieldName);
		}
		public QSqlField() : this((Type) null) {
			CreateQSqlFieldProxy();
			NewQSqlField();
		}
		[SmokeMethod("QSqlField()")]
		private void NewQSqlField() {
			ProxyQSqlField().NewQSqlField();
		}
		public QSqlField(QSqlField other) : this((Type) null) {
			CreateQSqlFieldProxy();
			NewQSqlField(other);
		}
		[SmokeMethod("QSqlField(const QSqlField&)")]
		private void NewQSqlField(QSqlField other) {
			ProxyQSqlField().NewQSqlField(other);
		}
		[SmokeMethod("operator==(const QSqlField&) const")]
		public static bool operator==(QSqlField lhs, QSqlField other) {
			return StaticQSqlField().op_equals(lhs,other);
		}
		public static bool operator!=(QSqlField lhs, QSqlField other) {
			return !StaticQSqlField().op_equals(lhs,other);
		}
		public override bool Equals(object o) {
			if (!(o is QSqlField)) { return false; }
			return this == (QSqlField) o;
		}
		public override int GetHashCode() {
			return ProxyQSqlField().GetHashCode();
		}
		[SmokeMethod("setValue(const QVariant&)")]
		public virtual void SetValue(QVariant value) {
			ProxyQSqlField().SetValue(value);
		}
		[SmokeMethod("value() const")]
		public virtual QVariant Value() {
			return ProxyQSqlField().Value();
		}
		[SmokeMethod("setName(const QString&)")]
		public virtual void SetName(string name) {
			ProxyQSqlField().SetName(name);
		}
		[SmokeMethod("name() const")]
		public string Name() {
			return ProxyQSqlField().Name();
		}
		[SmokeMethod("setNull()")]
		public virtual void SetNull() {
			ProxyQSqlField().SetNull();
		}
		[SmokeMethod("isNull() const")]
		public bool IsNull() {
			return ProxyQSqlField().IsNull();
		}
		[SmokeMethod("setReadOnly(bool)")]
		public virtual void SetReadOnly(bool readOnly) {
			ProxyQSqlField().SetReadOnly(readOnly);
		}
		[SmokeMethod("isReadOnly() const")]
		public bool IsReadOnly() {
			return ProxyQSqlField().IsReadOnly();
		}
		[SmokeMethod("clear(bool)")]
		public void Clear(bool nullify) {
			ProxyQSqlField().Clear(nullify);
		}
		[SmokeMethod("clear()")]
		public void Clear() {
			ProxyQSqlField().Clear();
		}
		~QSqlField() {
			DisposeQSqlField();
		}
		public void Dispose() {
			DisposeQSqlField();
		}
		private void DisposeQSqlField() {
			ProxyQSqlField().DisposeQSqlField();
		}
	}
}
