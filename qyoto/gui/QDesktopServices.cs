//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QDesktopServices")]
	public class QDesktopServices : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QDesktopServices(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QDesktopServices), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QDesktopServices() {
			staticInterceptor = new SmokeInvocation(typeof(QDesktopServices), null);
		}
		public QDesktopServices() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDesktopServices", "QDesktopServices()", typeof(void));
		}
		~QDesktopServices() {
			interceptor.Invoke("~QDesktopServices", "~QDesktopServices()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QDesktopServices", "~QDesktopServices()", typeof(void));
		}
		public static bool OpenUrl(QUrl url) {
			return (bool) staticInterceptor.Invoke("openUrl#", "openUrl(const QUrl&)", typeof(bool), typeof(QUrl), url);
		}
		public static void SetUrlHandler(string scheme, QObject receiver, string method) {
			staticInterceptor.Invoke("setUrlHandler$#$", "setUrlHandler(const QString&, QObject*, const char*)", typeof(void), typeof(string), scheme, typeof(QObject), receiver, typeof(string), method);
		}
		public static void UnsetUrlHandler(string scheme) {
			staticInterceptor.Invoke("unsetUrlHandler$", "unsetUrlHandler(const QString&)", typeof(void), typeof(string), scheme);
		}
	}
}
