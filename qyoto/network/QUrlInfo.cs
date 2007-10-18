//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QUrlInfo")]
	public class QUrlInfo : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QUrlInfo(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QUrlInfo), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QUrlInfo() {
			staticInterceptor = new SmokeInvocation(typeof(QUrlInfo), null);
		}
		public enum PermissionSpec {
			ReadOwner = 00400,
			WriteOwner = 00200,
			ExeOwner = 00100,
			ReadGroup = 00040,
			WriteGroup = 00020,
			ExeGroup = 00010,
			ReadOther = 00004,
			WriteOther = 00002,
			ExeOther = 00001,
		}
		public QUrlInfo() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QUrlInfo", "QUrlInfo()", typeof(void));
		}
		public QUrlInfo(QUrlInfo ui) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QUrlInfo#", "QUrlInfo(const QUrlInfo&)", typeof(void), typeof(QUrlInfo), ui);
		}
		public QUrlInfo(string name, int permissions, string owner, string group, long size, QDateTime lastModified, QDateTime lastRead, bool isDir, bool isFile, bool isSymLink, bool isWritable, bool isReadable, bool isExecutable) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QUrlInfo$$$$$##$$$$$$", "QUrlInfo(const QString&, int, const QString&, const QString&, qint64, const QDateTime&, const QDateTime&, bool, bool, bool, bool, bool, bool)", typeof(void), typeof(string), name, typeof(int), permissions, typeof(string), owner, typeof(string), group, typeof(long), size, typeof(QDateTime), lastModified, typeof(QDateTime), lastRead, typeof(bool), isDir, typeof(bool), isFile, typeof(bool), isSymLink, typeof(bool), isWritable, typeof(bool), isReadable, typeof(bool), isExecutable);
		}
		public QUrlInfo(QUrl url, int permissions, string owner, string group, long size, QDateTime lastModified, QDateTime lastRead, bool isDir, bool isFile, bool isSymLink, bool isWritable, bool isReadable, bool isExecutable) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QUrlInfo#$$$$##$$$$$$", "QUrlInfo(const QUrl&, int, const QString&, const QString&, qint64, const QDateTime&, const QDateTime&, bool, bool, bool, bool, bool, bool)", typeof(void), typeof(QUrl), url, typeof(int), permissions, typeof(string), owner, typeof(string), group, typeof(long), size, typeof(QDateTime), lastModified, typeof(QDateTime), lastRead, typeof(bool), isDir, typeof(bool), isFile, typeof(bool), isSymLink, typeof(bool), isWritable, typeof(bool), isReadable, typeof(bool), isExecutable);
		}
		[SmokeMethod("setName(const QString&)")]
		public virtual void SetName(string name) {
			interceptor.Invoke("setName$", "setName(const QString&)", typeof(void), typeof(string), name);
		}
		[SmokeMethod("setDir(bool)")]
		public virtual void SetDir(bool b) {
			interceptor.Invoke("setDir$", "setDir(bool)", typeof(void), typeof(bool), b);
		}
		[SmokeMethod("setFile(bool)")]
		public virtual void SetFile(bool b) {
			interceptor.Invoke("setFile$", "setFile(bool)", typeof(void), typeof(bool), b);
		}
		[SmokeMethod("setSymLink(bool)")]
		public virtual void SetSymLink(bool b) {
			interceptor.Invoke("setSymLink$", "setSymLink(bool)", typeof(void), typeof(bool), b);
		}
		[SmokeMethod("setOwner(const QString&)")]
		public virtual void SetOwner(string s) {
			interceptor.Invoke("setOwner$", "setOwner(const QString&)", typeof(void), typeof(string), s);
		}
		[SmokeMethod("setGroup(const QString&)")]
		public virtual void SetGroup(string s) {
			interceptor.Invoke("setGroup$", "setGroup(const QString&)", typeof(void), typeof(string), s);
		}
		[SmokeMethod("setSize(qint64)")]
		public virtual void SetSize(long size) {
			interceptor.Invoke("setSize$", "setSize(qint64)", typeof(void), typeof(long), size);
		}
		[SmokeMethod("setWritable(bool)")]
		public virtual void SetWritable(bool b) {
			interceptor.Invoke("setWritable$", "setWritable(bool)", typeof(void), typeof(bool), b);
		}
		[SmokeMethod("setReadable(bool)")]
		public virtual void SetReadable(bool b) {
			interceptor.Invoke("setReadable$", "setReadable(bool)", typeof(void), typeof(bool), b);
		}
		[SmokeMethod("setPermissions(int)")]
		public virtual void SetPermissions(int p) {
			interceptor.Invoke("setPermissions$", "setPermissions(int)", typeof(void), typeof(int), p);
		}
		[SmokeMethod("setLastModified(const QDateTime&)")]
		public virtual void SetLastModified(QDateTime dt) {
			interceptor.Invoke("setLastModified#", "setLastModified(const QDateTime&)", typeof(void), typeof(QDateTime), dt);
		}
		public bool IsValid() {
			return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
		}
		public string Name() {
			return (string) interceptor.Invoke("name", "name() const", typeof(string));
		}
		public int Permissions() {
			return (int) interceptor.Invoke("permissions", "permissions() const", typeof(int));
		}
		public string Owner() {
			return (string) interceptor.Invoke("owner", "owner() const", typeof(string));
		}
		public string Group() {
			return (string) interceptor.Invoke("group", "group() const", typeof(string));
		}
		public long Size() {
			return (long) interceptor.Invoke("size", "size() const", typeof(long));
		}
		public QDateTime LastModified() {
			return (QDateTime) interceptor.Invoke("lastModified", "lastModified() const", typeof(QDateTime));
		}
		public QDateTime LastRead() {
			return (QDateTime) interceptor.Invoke("lastRead", "lastRead() const", typeof(QDateTime));
		}
		public bool IsDir() {
			return (bool) interceptor.Invoke("isDir", "isDir() const", typeof(bool));
		}
		public bool IsFile() {
			return (bool) interceptor.Invoke("isFile", "isFile() const", typeof(bool));
		}
		public bool IsSymLink() {
			return (bool) interceptor.Invoke("isSymLink", "isSymLink() const", typeof(bool));
		}
		public bool IsWritable() {
			return (bool) interceptor.Invoke("isWritable", "isWritable() const", typeof(bool));
		}
		public bool IsReadable() {
			return (bool) interceptor.Invoke("isReadable", "isReadable() const", typeof(bool));
		}
		public bool IsExecutable() {
			return (bool) interceptor.Invoke("isExecutable", "isExecutable() const", typeof(bool));
		}
		public override bool Equals(object o) {
			if (!(o is QUrlInfo)) { return false; }
			return this == (QUrlInfo) o;
		}
		public override int GetHashCode() {
			return interceptor.GetHashCode();
		}
		~QUrlInfo() {
			interceptor.Invoke("~QUrlInfo", "~QUrlInfo()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QUrlInfo", "~QUrlInfo()", typeof(void));
		}
		public static bool operator==(QUrlInfo lhs, QUrlInfo i) {
			return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QUrlInfo&) const", typeof(bool), typeof(QUrlInfo), lhs, typeof(QUrlInfo), i);
		}
		public static bool operator!=(QUrlInfo lhs, QUrlInfo i) {
			return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QUrlInfo&) const", typeof(bool), typeof(QUrlInfo), lhs, typeof(QUrlInfo), i);
		}
		public static bool GreaterThan(QUrlInfo i1, QUrlInfo i2, int sortBy) {
			return (bool) staticInterceptor.Invoke("greaterThan##$", "greaterThan(const QUrlInfo&, const QUrlInfo&, int)", typeof(bool), typeof(QUrlInfo), i1, typeof(QUrlInfo), i2, typeof(int), sortBy);
		}
		public static bool LessThan(QUrlInfo i1, QUrlInfo i2, int sortBy) {
			return (bool) staticInterceptor.Invoke("lessThan##$", "lessThan(const QUrlInfo&, const QUrlInfo&, int)", typeof(bool), typeof(QUrlInfo), i1, typeof(QUrlInfo), i2, typeof(int), sortBy);
		}
		public static bool Equal(QUrlInfo i1, QUrlInfo i2, int sortBy) {
			return (bool) staticInterceptor.Invoke("equal##$", "equal(const QUrlInfo&, const QUrlInfo&, int)", typeof(bool), typeof(QUrlInfo), i1, typeof(QUrlInfo), i2, typeof(int), sortBy);
		}
	}
}
