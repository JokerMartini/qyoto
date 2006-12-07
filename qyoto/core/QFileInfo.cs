//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QFileInfo")]
	public class QFileInfo : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QFileInfo(Type dummy) {}
		interface IQFileInfoProxy {
			bool op_equals(QFileInfo lhs, QFileInfo fileinfo);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QFileInfo), this);
			_interceptor = (QFileInfo) realProxy.GetTransparentProxy();
		}
		private QFileInfo ProxyQFileInfo() {
			return (QFileInfo) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QFileInfo() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQFileInfoProxy), null);
			_staticInterceptor = (IQFileInfoProxy) realProxy.GetTransparentProxy();
		}
		private static IQFileInfoProxy StaticQFileInfo() {
			return (IQFileInfoProxy) _staticInterceptor;
		}

		public QFileInfo() : this((Type) null) {
			CreateProxy();
			NewQFileInfo();
		}
		[SmokeMethod("QFileInfo()")]
		private void NewQFileInfo() {
			ProxyQFileInfo().NewQFileInfo();
		}
		public QFileInfo(string file) : this((Type) null) {
			CreateProxy();
			NewQFileInfo(file);
		}
		[SmokeMethod("QFileInfo(const QString&)")]
		private void NewQFileInfo(string file) {
			ProxyQFileInfo().NewQFileInfo(file);
		}
		public QFileInfo(QFile file) : this((Type) null) {
			CreateProxy();
			NewQFileInfo(file);
		}
		[SmokeMethod("QFileInfo(const QFile&)")]
		private void NewQFileInfo(QFile file) {
			ProxyQFileInfo().NewQFileInfo(file);
		}
		public QFileInfo(QDir dir, string file) : this((Type) null) {
			CreateProxy();
			NewQFileInfo(dir,file);
		}
		[SmokeMethod("QFileInfo(const QDir&, const QString&)")]
		private void NewQFileInfo(QDir dir, string file) {
			ProxyQFileInfo().NewQFileInfo(dir,file);
		}
		public QFileInfo(QFileInfo fileinfo) : this((Type) null) {
			CreateProxy();
			NewQFileInfo(fileinfo);
		}
		[SmokeMethod("QFileInfo(const QFileInfo&)")]
		private void NewQFileInfo(QFileInfo fileinfo) {
			ProxyQFileInfo().NewQFileInfo(fileinfo);
		}
		[SmokeMethod("operator==(const QFileInfo&)")]
		public static bool operator==(QFileInfo lhs, QFileInfo fileinfo) {
			return StaticQFileInfo().op_equals(lhs,fileinfo);
		}
		public static bool operator!=(QFileInfo lhs, QFileInfo fileinfo) {
			return !StaticQFileInfo().op_equals(lhs,fileinfo);
		}
		public override bool Equals(object o) {
			if (!(o is QFileInfo)) { return false; }
			return this == (QFileInfo) o;
		}
		public override int GetHashCode() {
			return ProxyQFileInfo().GetHashCode();
		}
		[SmokeMethod("setFile(const QString&)")]
		public void SetFile(string file) {
			ProxyQFileInfo().SetFile(file);
		}
		[SmokeMethod("setFile(const QFile&)")]
		public void SetFile(QFile file) {
			ProxyQFileInfo().SetFile(file);
		}
		[SmokeMethod("setFile(const QDir&, const QString&)")]
		public void SetFile(QDir dir, string file) {
			ProxyQFileInfo().SetFile(dir,file);
		}
		[SmokeMethod("exists() const")]
		public bool Exists() {
			return ProxyQFileInfo().Exists();
		}
		[SmokeMethod("refresh()")]
		public void Refresh() {
			ProxyQFileInfo().Refresh();
		}
		[SmokeMethod("filePath() const")]
		public string FilePath() {
			return ProxyQFileInfo().FilePath();
		}
		[SmokeMethod("absoluteFilePath() const")]
		public string AbsoluteFilePath() {
			return ProxyQFileInfo().AbsoluteFilePath();
		}
		[SmokeMethod("canonicalFilePath() const")]
		public string CanonicalFilePath() {
			return ProxyQFileInfo().CanonicalFilePath();
		}
		[SmokeMethod("fileName() const")]
		public string FileName() {
			return ProxyQFileInfo().FileName();
		}
		[SmokeMethod("baseName() const")]
		public string BaseName() {
			return ProxyQFileInfo().BaseName();
		}
		[SmokeMethod("completeBaseName() const")]
		public string CompleteBaseName() {
			return ProxyQFileInfo().CompleteBaseName();
		}
		[SmokeMethod("suffix() const")]
		public string Suffix() {
			return ProxyQFileInfo().Suffix();
		}
		[SmokeMethod("completeSuffix() const")]
		public string CompleteSuffix() {
			return ProxyQFileInfo().CompleteSuffix();
		}
		[SmokeMethod("path() const")]
		public string Path() {
			return ProxyQFileInfo().Path();
		}
		[SmokeMethod("absolutePath() const")]
		public string AbsolutePath() {
			return ProxyQFileInfo().AbsolutePath();
		}
		[SmokeMethod("canonicalPath() const")]
		public string CanonicalPath() {
			return ProxyQFileInfo().CanonicalPath();
		}
		[SmokeMethod("dir() const")]
		public QDir Dir() {
			return ProxyQFileInfo().Dir();
		}
		[SmokeMethod("absoluteDir() const")]
		public QDir AbsoluteDir() {
			return ProxyQFileInfo().AbsoluteDir();
		}
		[SmokeMethod("isReadable() const")]
		public bool IsReadable() {
			return ProxyQFileInfo().IsReadable();
		}
		[SmokeMethod("isWritable() const")]
		public bool IsWritable() {
			return ProxyQFileInfo().IsWritable();
		}
		[SmokeMethod("isExecutable() const")]
		public bool IsExecutable() {
			return ProxyQFileInfo().IsExecutable();
		}
		[SmokeMethod("isHidden() const")]
		public bool IsHidden() {
			return ProxyQFileInfo().IsHidden();
		}
		[SmokeMethod("isRelative() const")]
		public bool IsRelative() {
			return ProxyQFileInfo().IsRelative();
		}
		[SmokeMethod("isAbsolute() const")]
		public bool IsAbsolute() {
			return ProxyQFileInfo().IsAbsolute();
		}
		[SmokeMethod("makeAbsolute()")]
		public bool MakeAbsolute() {
			return ProxyQFileInfo().MakeAbsolute();
		}
		[SmokeMethod("isFile() const")]
		public bool IsFile() {
			return ProxyQFileInfo().IsFile();
		}
		[SmokeMethod("isDir() const")]
		public bool IsDir() {
			return ProxyQFileInfo().IsDir();
		}
		[SmokeMethod("isSymLink() const")]
		public bool IsSymLink() {
			return ProxyQFileInfo().IsSymLink();
		}
		[SmokeMethod("isRoot() const")]
		public bool IsRoot() {
			return ProxyQFileInfo().IsRoot();
		}
		[SmokeMethod("readLink() const")]
		public string ReadLink() {
			return ProxyQFileInfo().ReadLink();
		}
		[SmokeMethod("symLinkTarget() const")]
		public string SymLinkTarget() {
			return ProxyQFileInfo().SymLinkTarget();
		}
		[SmokeMethod("owner() const")]
		public string Owner() {
			return ProxyQFileInfo().Owner();
		}
		[SmokeMethod("ownerId() const")]
		public uint OwnerId() {
			return ProxyQFileInfo().OwnerId();
		}
		[SmokeMethod("group() const")]
		public string Group() {
			return ProxyQFileInfo().Group();
		}
		[SmokeMethod("groupId() const")]
		public uint GroupId() {
			return ProxyQFileInfo().GroupId();
		}
		[SmokeMethod("permission(QFile::Permissions) const")]
		public bool Permission(int permissions) {
			return ProxyQFileInfo().Permission(permissions);
		}
		[SmokeMethod("permissions() const")]
		public int Permissions() {
			return ProxyQFileInfo().Permissions();
		}
		// qint64 size(); >>>> NOT CONVERTED
		[SmokeMethod("created() const")]
		public QDateTime Created() {
			return ProxyQFileInfo().Created();
		}
		[SmokeMethod("lastModified() const")]
		public QDateTime LastModified() {
			return ProxyQFileInfo().LastModified();
		}
		[SmokeMethod("lastRead() const")]
		public QDateTime LastRead() {
			return ProxyQFileInfo().LastRead();
		}
		[SmokeMethod("detach()")]
		public void Detach() {
			ProxyQFileInfo().Detach();
		}
		[SmokeMethod("caching() const")]
		public bool Caching() {
			return ProxyQFileInfo().Caching();
		}
		[SmokeMethod("setCaching(bool)")]
		public void SetCaching(bool on) {
			ProxyQFileInfo().SetCaching(on);
		}
		~QFileInfo() {
			DisposeQFileInfo();
		}
		public void Dispose() {
			DisposeQFileInfo();
		}
		[SmokeMethod("~QFileInfo()")]
		private void DisposeQFileInfo() {
			ProxyQFileInfo().DisposeQFileInfo();
		}
	}
}
