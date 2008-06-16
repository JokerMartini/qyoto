//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	[SmokeClass("QPixmapCache")]
	public class QPixmapCache : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QPixmapCache(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QPixmapCache), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QPixmapCache() {
			staticInterceptor = new SmokeInvocation(typeof(QPixmapCache), null);
		}
		public QPixmapCache() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QPixmapCache", "QPixmapCache()", typeof(void));
		}
		~QPixmapCache() {
			interceptor.Invoke("~QPixmapCache", "~QPixmapCache()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QPixmapCache", "~QPixmapCache()", typeof(void));
		}
		public static int CacheLimit() {
			return (int) staticInterceptor.Invoke("cacheLimit", "cacheLimit()", typeof(int));
		}
		public static void SetCacheLimit(int arg1) {
			staticInterceptor.Invoke("setCacheLimit$", "setCacheLimit(int)", typeof(void), typeof(int), arg1);
		}
		public static QPixmap Find(string key) {
			return (QPixmap) staticInterceptor.Invoke("find$", "find(const QString&)", typeof(QPixmap), typeof(string), key);
		}
		public static bool Find(string key, QPixmap arg2) {
			return (bool) staticInterceptor.Invoke("find$#", "find(const QString&, QPixmap&)", typeof(bool), typeof(string), key, typeof(QPixmap), arg2);
		}
		public static bool Insert(string key, QPixmap arg2) {
			return (bool) staticInterceptor.Invoke("insert$#", "insert(const QString&, const QPixmap&)", typeof(bool), typeof(string), key, typeof(QPixmap), arg2);
		}
		public static void Remove(string key) {
			staticInterceptor.Invoke("remove$", "remove(const QString&)", typeof(void), typeof(string), key);
		}
		public static void Clear() {
			staticInterceptor.Invoke("clear", "clear()", typeof(void));
		}
	}
}
