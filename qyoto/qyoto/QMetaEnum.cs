//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QMetaEnum")]
	public class QMetaEnum : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QMetaEnum(Type dummy) {}
		interface IQMetaEnumProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QMetaEnum), this);
			_interceptor = (QMetaEnum) realProxy.GetTransparentProxy();
		}
		private QMetaEnum ProxyQMetaEnum() {
			return (QMetaEnum) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QMetaEnum() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQMetaEnumProxy), null);
			_staticInterceptor = (IQMetaEnumProxy) realProxy.GetTransparentProxy();
		}
		private static IQMetaEnumProxy StaticQMetaEnum() {
			return (IQMetaEnumProxy) _staticInterceptor;
		}

		public QMetaEnum() : this((Type) null) {
			CreateProxy();
			NewQMetaEnum();
		}
		[SmokeMethod("QMetaEnum()")]
		private void NewQMetaEnum() {
			ProxyQMetaEnum().NewQMetaEnum();
		}
		[SmokeMethod("name() const")]
		public string Name() {
			return ProxyQMetaEnum().Name();
		}
		[SmokeMethod("isFlag() const")]
		public bool IsFlag() {
			return ProxyQMetaEnum().IsFlag();
		}
		[SmokeMethod("keyCount() const")]
		public int KeyCount() {
			return ProxyQMetaEnum().KeyCount();
		}
		[SmokeMethod("key(int) const")]
		public string Key(int index) {
			return ProxyQMetaEnum().Key(index);
		}
		[SmokeMethod("value(int) const")]
		public int Value(int index) {
			return ProxyQMetaEnum().Value(index);
		}
		[SmokeMethod("scope() const")]
		public string Scope() {
			return ProxyQMetaEnum().Scope();
		}
		[SmokeMethod("keyToValue(const char*) const")]
		public int KeyToValue(string key) {
			return ProxyQMetaEnum().KeyToValue(key);
		}
		[SmokeMethod("valueToKey(int) const")]
		public string ValueToKey(int value) {
			return ProxyQMetaEnum().ValueToKey(value);
		}
		[SmokeMethod("keysToValue(const char*) const")]
		public int KeysToValue(string keys) {
			return ProxyQMetaEnum().KeysToValue(keys);
		}
		[SmokeMethod("valueToKeys(int) const")]
		public QByteArray ValueToKeys(int value) {
			return ProxyQMetaEnum().ValueToKeys(value);
		}
		[SmokeMethod("isValid() const")]
		public bool IsValid() {
			return ProxyQMetaEnum().IsValid();
		}
		~QMetaEnum() {
			DisposeQMetaEnum();
		}
		public void Dispose() {
			DisposeQMetaEnum();
		}
		private void DisposeQMetaEnum() {
			ProxyQMetaEnum().DisposeQMetaEnum();
		}
	}
}
