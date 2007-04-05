//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QTemporaryFile")]
	public class QTemporaryFile : QFile, IDisposable {
 		protected QTemporaryFile(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QTemporaryFile), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QTemporaryFile() {
			staticInterceptor = new SmokeInvocation(typeof(QTemporaryFile), null);
		}
		public QTemporaryFile() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTemporaryFile", "QTemporaryFile()", typeof(void));
		}
		public QTemporaryFile(string templateName) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTemporaryFile$", "QTemporaryFile(const QString&)", typeof(void), typeof(string), templateName);
		}
		public QTemporaryFile(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTemporaryFile#", "QTemporaryFile(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public QTemporaryFile(string templateName, QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTemporaryFile$#", "QTemporaryFile(const QString&, QObject*)", typeof(void), typeof(string), templateName, typeof(QObject), parent);
		}
		public bool AutoRemove() {
			return (bool) interceptor.Invoke("autoRemove", "autoRemove() const", typeof(bool));
		}
		public void SetAutoRemove(bool b) {
			interceptor.Invoke("setAutoRemove$", "setAutoRemove(bool)", typeof(void), typeof(bool), b);
		}
		public bool Open() {
			return (bool) interceptor.Invoke("open", "open()", typeof(bool));
		}
		public string FileName() {
			return (string) interceptor.Invoke("fileName", "fileName() const", typeof(string));
		}
		public string FileTemplate() {
			return (string) interceptor.Invoke("fileTemplate", "fileTemplate() const", typeof(string));
		}
		public void SetFileTemplate(string name) {
			interceptor.Invoke("setFileTemplate$", "setFileTemplate(const QString&)", typeof(void), typeof(string), name);
		}
		[SmokeMethod("fileEngine() const")]
		public override QAbstractFileEngine FileEngine() {
			return (QAbstractFileEngine) interceptor.Invoke("fileEngine", "fileEngine() const", typeof(QAbstractFileEngine));
		}
		[SmokeMethod("open(OpenMode)")]
		protected new virtual bool Open(int flags) {
			return (bool) interceptor.Invoke("open$", "open(OpenMode)", typeof(bool), typeof(int), flags);
		}
		~QTemporaryFile() {
			interceptor.Invoke("~QTemporaryFile", "~QTemporaryFile()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QTemporaryFile", "~QTemporaryFile()", typeof(void));
		}
		public static string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		public static QTemporaryFile CreateLocalFile(string fileName) {
			return (QTemporaryFile) staticInterceptor.Invoke("createLocalFile$", "createLocalFile(const QString&)", typeof(QTemporaryFile), typeof(string), fileName);
		}
		public static QTemporaryFile CreateLocalFile(QFile file) {
			return (QTemporaryFile) staticInterceptor.Invoke("createLocalFile#", "createLocalFile(QFile&)", typeof(QTemporaryFile), typeof(QFile), file);
		}
		protected new IQTemporaryFileSignals Emit {
			get { return (IQTemporaryFileSignals) Q_EMIT; }
		}
	}

	public interface IQTemporaryFileSignals : IQFileSignals {
	}
}
