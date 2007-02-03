//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	/// See <see cref="IQHttpSignals"></see> for signals emitted by QHttp
	[SmokeClass("QHttp")]
	public class QHttp : QObject, IDisposable {
 		protected QHttp(Type dummy) : base((Type) null) {}
		[SmokeClass("QHttp")]
		interface IQHttpProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QHttp), this);
			_interceptor = (QHttp) realProxy.GetTransparentProxy();
		}
		private QHttp ProxyQHttp() {
			return (QHttp) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QHttp() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQHttpProxy), null);
			_staticInterceptor = (IQHttpProxy) realProxy.GetTransparentProxy();
		}
		private static IQHttpProxy StaticQHttp() {
			return (IQHttpProxy) _staticInterceptor;
		}

		public enum State {
			Unconnected = 0,
			HostLookup = 1,
			Connecting = 2,
			Sending = 3,
			Reading = 4,
			Connected = 5,
			Closing = 6,
		}
		public enum Error {
			NoError = 0,
			UnknownError = 1,
			HostNotFound = 2,
			ConnectionRefused = 3,
			UnexpectedClose = 4,
			InvalidResponseHeader = 5,
			WrongContentLength = 6,
			Aborted = 7,
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QHttp(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQHttp(parent);
		}
		[SmokeMethod("QHttp", "(QObject*)", "#")]
		private void NewQHttp(QObject parent) {
			ProxyQHttp().NewQHttp(parent);
		}
		public QHttp() : this((Type) null) {
			CreateProxy();
			NewQHttp();
		}
		[SmokeMethod("QHttp", "()", "")]
		private void NewQHttp() {
			ProxyQHttp().NewQHttp();
		}
		public QHttp(string hostname, ushort port, QObject parent) : this((Type) null) {
			CreateProxy();
			NewQHttp(hostname,port,parent);
		}
		[SmokeMethod("QHttp", "(const QString&, quint16, QObject*)", "$$#")]
		private void NewQHttp(string hostname, ushort port, QObject parent) {
			ProxyQHttp().NewQHttp(hostname,port,parent);
		}
		public QHttp(string hostname, ushort port) : this((Type) null) {
			CreateProxy();
			NewQHttp(hostname,port);
		}
		[SmokeMethod("QHttp", "(const QString&, quint16)", "$$")]
		private void NewQHttp(string hostname, ushort port) {
			ProxyQHttp().NewQHttp(hostname,port);
		}
		public QHttp(string hostname) : this((Type) null) {
			CreateProxy();
			NewQHttp(hostname);
		}
		[SmokeMethod("QHttp", "(const QString&)", "$")]
		private void NewQHttp(string hostname) {
			ProxyQHttp().NewQHttp(hostname);
		}
		[SmokeMethod("setHost", "(const QString&, quint16)", "$$")]
		public int SetHost(string hostname, ushort port) {
			return ProxyQHttp().SetHost(hostname,port);
		}
		[SmokeMethod("setHost", "(const QString&)", "$")]
		public int SetHost(string hostname) {
			return ProxyQHttp().SetHost(hostname);
		}
		[SmokeMethod("setSocket", "(QTcpSocket*)", "#")]
		public int SetSocket(QTcpSocket socket) {
			return ProxyQHttp().SetSocket(socket);
		}
		[SmokeMethod("setUser", "(const QString&, const QString&)", "$$")]
		public int SetUser(string username, string password) {
			return ProxyQHttp().SetUser(username,password);
		}
		[SmokeMethod("setUser", "(const QString&)", "$")]
		public int SetUser(string username) {
			return ProxyQHttp().SetUser(username);
		}
		[SmokeMethod("setProxy", "(const QString&, int, const QString&, const QString&)", "$$$$")]
		public int SetProxy(string host, int port, string username, string password) {
			return ProxyQHttp().SetProxy(host,port,username,password);
		}
		[SmokeMethod("setProxy", "(const QString&, int, const QString&)", "$$$")]
		public int SetProxy(string host, int port, string username) {
			return ProxyQHttp().SetProxy(host,port,username);
		}
		[SmokeMethod("setProxy", "(const QString&, int)", "$$")]
		public int SetProxy(string host, int port) {
			return ProxyQHttp().SetProxy(host,port);
		}
		[SmokeMethod("get", "(const QString&, QIODevice*)", "$#")]
		public int Get(string path, IQIODevice to) {
			return ProxyQHttp().Get(path,to);
		}
		[SmokeMethod("get", "(const QString&)", "$")]
		public int Get(string path) {
			return ProxyQHttp().Get(path);
		}
		[SmokeMethod("post", "(const QString&, QIODevice*, QIODevice*)", "$##")]
		public int Post(string path, IQIODevice data, IQIODevice to) {
			return ProxyQHttp().Post(path,data,to);
		}
		[SmokeMethod("post", "(const QString&, QIODevice*)", "$#")]
		public int Post(string path, IQIODevice data) {
			return ProxyQHttp().Post(path,data);
		}
		[SmokeMethod("post", "(const QString&, const QByteArray&, QIODevice*)", "$##")]
		public int Post(string path, QByteArray data, IQIODevice to) {
			return ProxyQHttp().Post(path,data,to);
		}
		[SmokeMethod("post", "(const QString&, const QByteArray&)", "$#")]
		public int Post(string path, QByteArray data) {
			return ProxyQHttp().Post(path,data);
		}
		[SmokeMethod("head", "(const QString&)", "$")]
		public int Head(string path) {
			return ProxyQHttp().Head(path);
		}
		[SmokeMethod("request", "(const QHttpRequestHeader&, QIODevice*, QIODevice*)", "###")]
		public int Request(QHttpRequestHeader header, IQIODevice device, IQIODevice to) {
			return ProxyQHttp().Request(header,device,to);
		}
		[SmokeMethod("request", "(const QHttpRequestHeader&, QIODevice*)", "##")]
		public int Request(QHttpRequestHeader header, IQIODevice device) {
			return ProxyQHttp().Request(header,device);
		}
		[SmokeMethod("request", "(const QHttpRequestHeader&)", "#")]
		public int Request(QHttpRequestHeader header) {
			return ProxyQHttp().Request(header);
		}
		[SmokeMethod("request", "(const QHttpRequestHeader&, const QByteArray&, QIODevice*)", "###")]
		public int Request(QHttpRequestHeader header, QByteArray data, IQIODevice to) {
			return ProxyQHttp().Request(header,data,to);
		}
		[SmokeMethod("request", "(const QHttpRequestHeader&, const QByteArray&)", "##")]
		public int Request(QHttpRequestHeader header, QByteArray data) {
			return ProxyQHttp().Request(header,data);
		}
		[SmokeMethod("closeConnection", "()", "")]
		public int CloseConnection() {
			return ProxyQHttp().CloseConnection();
		}
		[SmokeMethod("close", "()", "")]
		public int Close() {
			return ProxyQHttp().Close();
		}
		[SmokeMethod("bytesAvailable", "() const", "")]
		public long BytesAvailable() {
			return ProxyQHttp().BytesAvailable();
		}
		[SmokeMethod("read", "(char*, qint64)", "$$")]
		public long Read(string data, long maxlen) {
			return ProxyQHttp().Read(data,maxlen);
		}
		[SmokeMethod("readAll", "()", "")]
		public QByteArray ReadAll() {
			return ProxyQHttp().ReadAll();
		}
		[SmokeMethod("currentId", "() const", "")]
		public int CurrentId() {
			return ProxyQHttp().CurrentId();
		}
		[SmokeMethod("currentSourceDevice", "() const", "")]
		public IQIODevice CurrentSourceDevice() {
			return ProxyQHttp().CurrentSourceDevice();
		}
		[SmokeMethod("currentDestinationDevice", "() const", "")]
		public IQIODevice CurrentDestinationDevice() {
			return ProxyQHttp().CurrentDestinationDevice();
		}
		[SmokeMethod("currentRequest", "() const", "")]
		public QHttpRequestHeader CurrentRequest() {
			return ProxyQHttp().CurrentRequest();
		}
		[SmokeMethod("lastResponse", "() const", "")]
		public QHttpResponseHeader LastResponse() {
			return ProxyQHttp().LastResponse();
		}
		[SmokeMethod("hasPendingRequests", "() const", "")]
		public bool HasPendingRequests() {
			return ProxyQHttp().HasPendingRequests();
		}
		[SmokeMethod("clearPendingRequests", "()", "")]
		public void ClearPendingRequests() {
			ProxyQHttp().ClearPendingRequests();
		}
		[SmokeMethod("state", "() const", "")]
		public QHttp.State state() {
			return ProxyQHttp().state();
		}
		[SmokeMethod("error", "() const", "")]
		public QHttp.Error error() {
			return ProxyQHttp().error();
		}
		[SmokeMethod("errorString", "() const", "")]
		public string ErrorString() {
			return ProxyQHttp().ErrorString();
		}
		[Q_SLOT("void abort()")]
		[SmokeMethod("abort", "()", "")]
		public void Abort() {
			ProxyQHttp().Abort();
		}
		public static new string Tr(string s, string c) {
			return StaticQHttp().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQHttp().Tr(s);
		}
		~QHttp() {
			DisposeQHttp();
		}
		public new void Dispose() {
			DisposeQHttp();
		}
		[SmokeMethod("~QHttp", "()", "")]
		private void DisposeQHttp() {
			ProxyQHttp().DisposeQHttp();
		}
		protected new IQHttpSignals Emit {
			get {
				return (IQHttpSignals) Q_EMIT;
			}
		}
	}

	public interface IQHttpSignals : IQObjectSignals {
		[Q_SIGNAL("void stateChanged(int)")]
		void StateChanged(int arg1);
		[Q_SIGNAL("void responseHeaderReceived(const QHttpResponseHeader&)")]
		void ResponseHeaderReceived(QHttpResponseHeader resp);
		[Q_SIGNAL("void readyRead(const QHttpResponseHeader&)")]
		void ReadyRead(QHttpResponseHeader resp);
		[Q_SIGNAL("void dataSendProgress(int, int)")]
		void DataSendProgress(int arg1, int arg2);
		[Q_SIGNAL("void dataReadProgress(int, int)")]
		void DataReadProgress(int arg1, int arg2);
		[Q_SIGNAL("void requestStarted(int)")]
		void RequestStarted(int arg1);
		[Q_SIGNAL("void requestFinished(int, bool)")]
		void RequestFinished(int arg1, bool arg2);
		[Q_SIGNAL("void done(bool)")]
		void Done(bool arg1);
	}
}
