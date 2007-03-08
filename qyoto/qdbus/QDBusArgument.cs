//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	[SmokeClass("QDBusArgument")]
	public class QDBusArgument : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QDBusArgument(Type dummy) {}
		[SmokeClass("QDBusArgument")]
		interface IQDBusArgumentProxy {
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDBusArgument), this);
			_interceptor = (QDBusArgument) realProxy.GetTransparentProxy();
		}
		private QDBusArgument ProxyQDBusArgument() {
			return (QDBusArgument) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDBusArgument() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDBusArgumentProxy), null);
			_staticInterceptor = (IQDBusArgumentProxy) realProxy.GetTransparentProxy();
		}
		private static IQDBusArgumentProxy StaticQDBusArgument() {
			return (IQDBusArgumentProxy) _staticInterceptor;
		}
		public QDBusArgument() : this((Type) null) {
			CreateProxy();
			NewQDBusArgument();
		}
		[SmokeMethod("QDBusArgument", "()", "")]
		private void NewQDBusArgument() {
			ProxyQDBusArgument().NewQDBusArgument();
		}
		public QDBusArgument(QDBusArgument other) : this((Type) null) {
			CreateProxy();
			NewQDBusArgument(other);
		}
		[SmokeMethod("QDBusArgument", "(const QDBusArgument&)", "#")]
		private void NewQDBusArgument(QDBusArgument other) {
			ProxyQDBusArgument().NewQDBusArgument(other);
		}
		[SmokeMethod("operator<<", "(uchar)", "$")]
		public QDBusArgument Write(ushort arg) {
			return ProxyQDBusArgument().Write(arg);
		}
		[SmokeMethod("operator<<", "(bool)", "$")]
		public QDBusArgument Write(bool arg) {
			return ProxyQDBusArgument().Write(arg);
		}
		[SmokeMethod("operator<<", "(short)", "$")]
		public QDBusArgument Write(short arg) {
			return ProxyQDBusArgument().Write(arg);
		}
		[SmokeMethod("operator<<", "(int)", "$")]
		public QDBusArgument Write(int arg) {
			return ProxyQDBusArgument().Write(arg);
		}
		[SmokeMethod("operator<<", "(uint)", "$")]
		public QDBusArgument Write(uint arg) {
			return ProxyQDBusArgument().Write(arg);
		}
		[SmokeMethod("operator<<", "(qlonglong)", "?")]
		public QDBusArgument Write(long arg) {
			return ProxyQDBusArgument().Write(arg);
		}
		[SmokeMethod("operator<<", "(qulonglong)", "$")]
		public QDBusArgument Write(ulong arg) {
			return ProxyQDBusArgument().Write(arg);
		}
		[SmokeMethod("operator<<", "(double)", "$")]
		public QDBusArgument Write(double arg) {
			return ProxyQDBusArgument().Write(arg);
		}
		[SmokeMethod("operator<<", "(const QString&)", "$")]
		public QDBusArgument Write(string arg) {
			return ProxyQDBusArgument().Write(arg);
		}
		[SmokeMethod("operator<<", "(const QDBusVariant&)", "?")]
		public QDBusArgument Write(QDBusVariant arg) {
			return ProxyQDBusArgument().Write(arg);
		}
		[SmokeMethod("operator<<", "(const QDBusObjectPath&)", "$")]
		public QDBusArgument Write(QDBusObjectPath arg) {
			return ProxyQDBusArgument().Write(arg);
		}
		[SmokeMethod("operator<<", "(const QDBusSignature&)", "$")]
		public QDBusArgument Write(QDBusSignature arg) {
			return ProxyQDBusArgument().Write(arg);
		}
		[SmokeMethod("operator<<", "(const QStringList&)", "?")]
		public QDBusArgument Write(List<string> arg) {
			return ProxyQDBusArgument().Write(arg);
		}
		[SmokeMethod("operator<<", "(const QByteArray&)", "#")]
		public QDBusArgument Write(QByteArray arg) {
			return ProxyQDBusArgument().Write(arg);
		}
		[SmokeMethod("beginStructure", "()", "")]
		public void BeginStructure() {
			ProxyQDBusArgument().BeginStructure();
		}
		[SmokeMethod("endStructure", "()", "")]
		public void EndStructure() {
			ProxyQDBusArgument().EndStructure();
		}
		[SmokeMethod("beginArray", "(int)", "$")]
		public void BeginArray(int elementMetaTypeId) {
			ProxyQDBusArgument().BeginArray(elementMetaTypeId);
		}
		[SmokeMethod("endArray", "()", "")]
		public void EndArray() {
			ProxyQDBusArgument().EndArray();
		}
		[SmokeMethod("beginMap", "(int, int)", "$$")]
		public void BeginMap(int keyMetaTypeId, int valueMetaTypeId) {
			ProxyQDBusArgument().BeginMap(keyMetaTypeId,valueMetaTypeId);
		}
		[SmokeMethod("endMap", "()", "")]
		public void EndMap() {
			ProxyQDBusArgument().EndMap();
		}
		[SmokeMethod("beginMapEntry", "()", "")]
		public void BeginMapEntry() {
			ProxyQDBusArgument().BeginMapEntry();
		}
		[SmokeMethod("endMapEntry", "()", "")]
		public void EndMapEntry() {
			ProxyQDBusArgument().EndMapEntry();
		}
		[SmokeMethod("currentSignature", "() const", "")]
		public string CurrentSignature() {
			return ProxyQDBusArgument().CurrentSignature();
		}
		[SmokeMethod("operator>>", "(uchar&) const", "$")]
		public QDBusArgument Read(ushort arg) {
			return ProxyQDBusArgument().Read(arg);
		}
		[SmokeMethod("operator>>", "(bool&) const", "$")]
		public QDBusArgument Read(bool arg) {
			return ProxyQDBusArgument().Read(arg);
		}
		// const QDBusArgument& operator>>(short& arg1); >>>> NOT CONVERTED
		// const QDBusArgument& operator>>(ushort& arg1); >>>> NOT CONVERTED
		[SmokeMethod("operator>>", "(int&) const", "$")]
		public QDBusArgument Read(out int arg) {
			return ProxyQDBusArgument().Read(out arg);
		}
		[SmokeMethod("operator>>", "(uint&) const", "$")]
		public QDBusArgument Read(uint arg) {
			return ProxyQDBusArgument().Read(arg);
		}
		// const QDBusArgument& operator>>(qlonglong& arg1); >>>> NOT CONVERTED
		// const QDBusArgument& operator>>(qulonglong& arg1); >>>> NOT CONVERTED
		[SmokeMethod("operator>>", "(double&) const", "$")]
		public QDBusArgument Read(double arg) {
			return ProxyQDBusArgument().Read(arg);
		}
		[SmokeMethod("operator>>", "(QString&) const", "$")]
		public QDBusArgument Read(StringBuilder arg) {
			return ProxyQDBusArgument().Read(arg);
		}
		[SmokeMethod("operator>>", "(QDBusVariant&) const", "?")]
		public QDBusArgument Read(QDBusVariant arg) {
			return ProxyQDBusArgument().Read(arg);
		}
		[SmokeMethod("operator>>", "(QDBusObjectPath&) const", "$")]
		public QDBusArgument Read(QDBusObjectPath arg) {
			return ProxyQDBusArgument().Read(arg);
		}
		[SmokeMethod("operator>>", "(QDBusSignature&) const", "$")]
		public QDBusArgument Read(QDBusSignature arg) {
			return ProxyQDBusArgument().Read(arg);
		}
		[SmokeMethod("operator>>", "(QStringList&) const", "?")]
		public QDBusArgument Read(List<string> arg) {
			return ProxyQDBusArgument().Read(arg);
		}
		[SmokeMethod("operator>>", "(QByteArray&) const", "#")]
		public QDBusArgument Read(QByteArray arg) {
			return ProxyQDBusArgument().Read(arg);
		}
		[SmokeMethod("beginArray", "() const", "")]
		public void BeginArray() {
			ProxyQDBusArgument().BeginArray();
		}
		[SmokeMethod("beginMap", "() const", "")]
		public void BeginMap() {
			ProxyQDBusArgument().BeginMap();
		}
		[SmokeMethod("atEnd", "() const", "")]
		public bool AtEnd() {
			return ProxyQDBusArgument().AtEnd();
		}
		// QDBusArgument* QDBusArgument(QDBusArgumentPrivate* arg1); >>>> NOT CONVERTED
		~QDBusArgument() {
			DisposeQDBusArgument();
		}
		public void Dispose() {
			DisposeQDBusArgument();
		}
		[SmokeMethod("~QDBusArgument", "()", "")]
		private void DisposeQDBusArgument() {
			ProxyQDBusArgument().DisposeQDBusArgument();
		}
	}
}
