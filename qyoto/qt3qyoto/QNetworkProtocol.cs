//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQNetworkProtocolSignals"></see> for signals emitted by QNetworkProtocol
	public class QNetworkProtocol : QObject, IDisposable {
 		protected QNetworkProtocol(Type dummy) : base((Type) null) {}
		interface IQNetworkProtocolProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
			QNetworkProtocol GetNetworkProtocol(string protocol);
			bool HasOnlyLocalFileSystem();
		}

		protected void CreateQNetworkProtocolProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QNetworkProtocol), this);
			_interceptor = (QNetworkProtocol) realProxy.GetTransparentProxy();
		}
		private QNetworkProtocol ProxyQNetworkProtocol() {
			return (QNetworkProtocol) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QNetworkProtocol() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQNetworkProtocolProxy), null);
			_staticInterceptor = (IQNetworkProtocolProxy) realProxy.GetTransparentProxy();
		}
		private static IQNetworkProtocolProxy StaticQNetworkProtocol() {
			return (IQNetworkProtocolProxy) _staticInterceptor;
		}

		enum State {
			StWaiting = 0,
			StInProgress = 1,
			StDone = 2,
			StFailed = 3,
			StStopped = 4,
		}
		enum Operation {
			OpListChildren = 1,
			OpMkDir = 2,
			OpMkdir = OpMkDir,
			OpRemove = 4,
			OpRename = 8,
			OpGet = 32,
			OpPut = 64,
		}
		enum ConnectionState {
			ConHostFound = 0,
			ConConnected = 1,
			ConClosed = 2,
		}
		enum Error {
			NoError = 0,
			ErrValid = 1,
			ErrUnknownProtocol = 2,
			ErrUnsupported = 3,
			ErrParse = 4,
			ErrLoginIncorrect = 5,
			ErrHostNotFound = 6,
			ErrListChildren = 7,
			ErrListChlidren = ErrListChildren,
			ErrMkDir = 8,
			ErrMkdir = ErrMkDir,
			ErrRemove = 9,
			ErrRename = 10,
			ErrGet = 11,
			ErrPut = 12,
			ErrFileNotExisting = 13,
			ErrPermissionDenied = 14,
		}
		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQNetworkProtocol().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQNetworkProtocol().ClassName();
		}
		public QNetworkProtocol() : this((Type) null) {
			CreateQNetworkProtocolProxy();
			CreateQNetworkProtocolSignalProxy();
			NewQNetworkProtocol();
		}
		[SmokeMethod("QNetworkProtocol()")]
		private void NewQNetworkProtocol() {
			ProxyQNetworkProtocol().NewQNetworkProtocol();
		}
		[SmokeMethod("setUrl(QUrlOperator*)")]
		public virtual void SetUrl(QUrlOperator u) {
			ProxyQNetworkProtocol().SetUrl(u);
		}
		[SmokeMethod("setAutoDelete(bool, int)")]
		public virtual void SetAutoDelete(bool b, int i) {
			ProxyQNetworkProtocol().SetAutoDelete(b,i);
		}
		[SmokeMethod("setAutoDelete(bool)")]
		public virtual void SetAutoDelete(bool b) {
			ProxyQNetworkProtocol().SetAutoDelete(b);
		}
		[SmokeMethod("autoDelete() const")]
		public bool AutoDelete() {
			return ProxyQNetworkProtocol().AutoDelete();
		}
		[SmokeMethod("supportedOperations() const")]
		public virtual int SupportedOperations() {
			return ProxyQNetworkProtocol().SupportedOperations();
		}
		[SmokeMethod("addOperation(QNetworkOperation*)")]
		public virtual void AddOperation(QNetworkOperation op) {
			ProxyQNetworkProtocol().AddOperation(op);
		}
		[SmokeMethod("url() const")]
		public QUrlOperator Url() {
			return ProxyQNetworkProtocol().Url();
		}
		[SmokeMethod("operationInProgress() const")]
		public QNetworkOperation OperationInProgress() {
			return ProxyQNetworkProtocol().OperationInProgress();
		}
		[SmokeMethod("clearOperationQueue()")]
		public virtual void ClearOperationQueue() {
			ProxyQNetworkProtocol().ClearOperationQueue();
		}
		[SmokeMethod("stop()")]
		public virtual void Stop() {
			ProxyQNetworkProtocol().Stop();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQNetworkProtocol().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQNetworkProtocol().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQNetworkProtocol().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQNetworkProtocol().TrUtf8(arg1);
		}
		// void registerNetworkProtocol(const QString& arg1,QNetworkProtocolFactoryBase* arg2); >>>> NOT CONVERTED
		[SmokeMethod("getNetworkProtocol(const QString&)")]
		public static QNetworkProtocol GetNetworkProtocol(string protocol) {
			return StaticQNetworkProtocol().GetNetworkProtocol(protocol);
		}
		[SmokeMethod("hasOnlyLocalFileSystem()")]
		public static bool HasOnlyLocalFileSystem() {
			return StaticQNetworkProtocol().HasOnlyLocalFileSystem();
		}
		[SmokeMethod("processOperation(QNetworkOperation*)")]
		protected virtual void ProcessOperation(QNetworkOperation op) {
			ProxyQNetworkProtocol().ProcessOperation(op);
		}
		[SmokeMethod("operationListChildren(QNetworkOperation*)")]
		protected virtual void OperationListChildren(QNetworkOperation op) {
			ProxyQNetworkProtocol().OperationListChildren(op);
		}
		[SmokeMethod("operationMkDir(QNetworkOperation*)")]
		protected virtual void OperationMkDir(QNetworkOperation op) {
			ProxyQNetworkProtocol().OperationMkDir(op);
		}
		[SmokeMethod("operationRemove(QNetworkOperation*)")]
		protected virtual void OperationRemove(QNetworkOperation op) {
			ProxyQNetworkProtocol().OperationRemove(op);
		}
		[SmokeMethod("operationRename(QNetworkOperation*)")]
		protected virtual void OperationRename(QNetworkOperation op) {
			ProxyQNetworkProtocol().OperationRename(op);
		}
		[SmokeMethod("operationGet(QNetworkOperation*)")]
		protected virtual void OperationGet(QNetworkOperation op) {
			ProxyQNetworkProtocol().OperationGet(op);
		}
		[SmokeMethod("operationPut(QNetworkOperation*)")]
		protected virtual void OperationPut(QNetworkOperation op) {
			ProxyQNetworkProtocol().OperationPut(op);
		}
		[SmokeMethod("operationPutChunk(QNetworkOperation*)")]
		protected virtual void OperationPutChunk(QNetworkOperation op) {
			ProxyQNetworkProtocol().OperationPutChunk(op);
		}
		[SmokeMethod("checkConnection(QNetworkOperation*)")]
		protected virtual bool CheckConnection(QNetworkOperation op) {
			return ProxyQNetworkProtocol().CheckConnection(op);
		}
		~QNetworkProtocol() {
			DisposeQNetworkProtocol();
		}
		public new void Dispose() {
			DisposeQNetworkProtocol();
		}
		private void DisposeQNetworkProtocol() {
			ProxyQNetworkProtocol().DisposeQNetworkProtocol();
		}
		protected void CreateQNetworkProtocolSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQNetworkProtocolSignals), this);
			_signalInterceptor = (IQNetworkProtocolSignals) realProxy.GetTransparentProxy();
		}
		protected new IQNetworkProtocolSignals Emit() {
			return (IQNetworkProtocolSignals) _signalInterceptor;
		}
	}

	public interface IQNetworkProtocolSignals : IQObjectSignals {
		[Q_SIGNAL("data(const QByteArray&, QNetworkOperation*)")]
		void Data(QByteArray arg1, QNetworkOperation res);
		[Q_SIGNAL("connectionStateChanged(int, const QString&)")]
		void ConnectionStateChanged(int state, string data);
		[Q_SIGNAL("finished(QNetworkOperation*)")]
		void Finished(QNetworkOperation res);
		[Q_SIGNAL("start(QNetworkOperation*)")]
		void Start(QNetworkOperation res);
		// void newChildren(const QValueList<QUrlInfo>& arg1,QNetworkOperation* arg2); >>>> NOT CONVERTED
		[Q_SIGNAL("newChild(const QUrlInfo&, QNetworkOperation*)")]
		void NewChild(QUrlInfo arg1, QNetworkOperation res);
		[Q_SIGNAL("createdDirectory(const QUrlInfo&, QNetworkOperation*)")]
		void CreatedDirectory(QUrlInfo arg1, QNetworkOperation res);
		[Q_SIGNAL("removed(QNetworkOperation*)")]
		void Removed(QNetworkOperation res);
		[Q_SIGNAL("itemChanged(QNetworkOperation*)")]
		void ItemChanged(QNetworkOperation res);
		[Q_SIGNAL("dataTransferProgress(int, int, QNetworkOperation*)")]
		void DataTransferProgress(int bytesDone, int bytesTotal, QNetworkOperation res);
	}
}
