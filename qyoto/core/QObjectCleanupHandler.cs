//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	[SmokeClass("QObjectCleanupHandler")]
	public class QObjectCleanupHandler : QObject, IDisposable {
 		protected QObjectCleanupHandler(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QObjectCleanupHandler), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QObjectCleanupHandler() {
			staticInterceptor = new SmokeInvocation(typeof(QObjectCleanupHandler), null);
		}
		public QObjectCleanupHandler() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QObjectCleanupHandler", "QObjectCleanupHandler()", typeof(void));
		}
		public QObject Add(QObject arg1) {
			return (QObject) interceptor.Invoke("add#", "add(QObject*)", typeof(QObject), typeof(QObject), arg1);
		}
		public void Remove(QObject arg1) {
			interceptor.Invoke("remove#", "remove(QObject*)", typeof(void), typeof(QObject), arg1);
		}
		public bool IsEmpty() {
			return (bool) interceptor.Invoke("isEmpty", "isEmpty() const", typeof(bool));
		}
		public void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		~QObjectCleanupHandler() {
			interceptor.Invoke("~QObjectCleanupHandler", "~QObjectCleanupHandler()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QObjectCleanupHandler", "~QObjectCleanupHandler()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQObjectCleanupHandlerSignals Emit {
			get { return (IQObjectCleanupHandlerSignals) Q_EMIT; }
		}
	}

	public interface IQObjectCleanupHandlerSignals : IQObjectSignals {
	}
}
