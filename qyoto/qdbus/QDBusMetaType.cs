//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QDBusMetaType")]
	public class QDBusMetaType : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QDBusMetaType(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QDBusMetaType), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QDBusMetaType() {
			staticInterceptor = new SmokeInvocation(typeof(QDBusMetaType), null);
		}
		// void registerMarshallOperators(int arg1,MarshallFunction arg2,DemarshallFunction arg3); >>>> NOT CONVERTED
		// bool marshall(QDBusArgument& arg1,int arg2,const void* arg3); >>>> NOT CONVERTED
		// bool demarshall(const QDBusArgument& arg1,int arg2,void* arg3); >>>> NOT CONVERTED
		public QDBusMetaType() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDBusMetaType", "QDBusMetaType()", typeof(void));
		}
		~QDBusMetaType() {
			interceptor.Invoke("~QDBusMetaType", "~QDBusMetaType()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QDBusMetaType", "~QDBusMetaType()", typeof(void));
		}
		public static int SignatureToType(string signature) {
			return (int) staticInterceptor.Invoke("signatureToType$", "signatureToType(const char*)", typeof(int), typeof(string), signature);
		}
		public static string TypeToSignature(int type) {
			return (string) staticInterceptor.Invoke("typeToSignature$", "typeToSignature(int)", typeof(string), typeof(int), type);
		}
	}
}
