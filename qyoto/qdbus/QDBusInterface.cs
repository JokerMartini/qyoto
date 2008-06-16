//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	[SmokeClass("QDBusInterface")]
	public class QDBusInterface : QDBusAbstractInterface, IDisposable {
 		protected QDBusInterface(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QDBusInterface), this);
		}
		public QDBusInterface(string service, string path, string arg3, QDBusConnection connection, QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDBusInterface$$$##", "QDBusInterface(const QString&, const QString&, const QString&, const QDBusConnection&, QObject*)", typeof(void), typeof(string), service, typeof(string), path, typeof(string), arg3, typeof(QDBusConnection), connection, typeof(QObject), parent);
		}
		public QDBusInterface(string service, string path, string arg3, QDBusConnection connection) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDBusInterface$$$#", "QDBusInterface(const QString&, const QString&, const QString&, const QDBusConnection&)", typeof(void), typeof(string), service, typeof(string), path, typeof(string), arg3, typeof(QDBusConnection), connection);
		}
		public QDBusInterface(string service, string path, string arg3) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDBusInterface$$$", "QDBusInterface(const QString&, const QString&, const QString&)", typeof(void), typeof(string), service, typeof(string), path, typeof(string), arg3);
		}
		public QDBusInterface(string service, string path) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDBusInterface$$", "QDBusInterface(const QString&, const QString&)", typeof(void), typeof(string), service, typeof(string), path);
		}
		~QDBusInterface() {
			interceptor.Invoke("~QDBusInterface", "~QDBusInterface()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QDBusInterface", "~QDBusInterface()", typeof(void));
		}
		protected new IQDBusInterfaceSignals Emit {
			get { return (IQDBusInterfaceSignals) Q_EMIT; }
		}
	}

	public interface IQDBusInterfaceSignals : IQDBusAbstractInterfaceSignals {
	}
}
