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
		public enum StandardLocation {
			DesktopLocation = 0,
			DocumentsLocation = 1,
			FontsLocation = 2,
			ApplicationsLocation = 3,
			MusicLocation = 4,
			MoviesLocation = 5,
			PicturesLocation = 6,
			TempLocation = 7,
			HomeLocation = 8,
			DataLocation = 9,
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
		public static string StorageLocation(QDesktopServices.StandardLocation type) {
			return (string) staticInterceptor.Invoke("storageLocation$", "storageLocation(QDesktopServices::StandardLocation)", typeof(string), typeof(QDesktopServices.StandardLocation), type);
		}
		public static string DisplayName(QDesktopServices.StandardLocation type) {
			return (string) staticInterceptor.Invoke("displayName$", "displayName(QDesktopServices::StandardLocation)", typeof(string), typeof(QDesktopServices.StandardLocation), type);
		}
	}
}
