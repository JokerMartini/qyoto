//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QSocketDevice")]
	public class QSocketDevice : QIODevice, IDisposable {
 		protected QSocketDevice(Type dummy) : base((Type) null) {}
		interface IQSocketDeviceProxy {
		}

		protected void CreateQSocketDeviceProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSocketDevice), this);
			_interceptor = (QSocketDevice) realProxy.GetTransparentProxy();
		}
		private QSocketDevice ProxyQSocketDevice() {
			return (QSocketDevice) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSocketDevice() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSocketDeviceProxy), null);
			_staticInterceptor = (IQSocketDeviceProxy) realProxy.GetTransparentProxy();
		}
		private static IQSocketDeviceProxy StaticQSocketDevice() {
			return (IQSocketDeviceProxy) _staticInterceptor;
		}

		public enum E_Type {
			Stream = 0,
			Datagram = 1,
		}
		public enum Protocol {
			IPv4 = 0,
			IPv6 = 1,
			Unknown = 2,
		}
		public enum Error {
			NoError = 0,
			AlreadyBound = 1,
			Inaccessible = 2,
			NoResources = 3,
			InternalError = 4,
			Bug = InternalError,
			Impossible = 5,
			NoFiles = 6,
			ConnectionRefused = 7,
			NetworkFailure = 8,
			UnknownError = 9,
		}
		public QSocketDevice(QSocketDevice.E_Type type) : this((Type) null) {
			CreateQSocketDeviceProxy();
			NewQSocketDevice(type);
		}
		[SmokeMethod("QSocketDevice(QSocketDevice::Type)")]
		private void NewQSocketDevice(QSocketDevice.E_Type type) {
			ProxyQSocketDevice().NewQSocketDevice(type);
		}
		public QSocketDevice() : this((Type) null) {
			CreateQSocketDeviceProxy();
			NewQSocketDevice();
		}
		[SmokeMethod("QSocketDevice()")]
		private void NewQSocketDevice() {
			ProxyQSocketDevice().NewQSocketDevice();
		}
		public QSocketDevice(QSocketDevice.E_Type type, QSocketDevice.Protocol protocol, int dummy) : this((Type) null) {
			CreateQSocketDeviceProxy();
			NewQSocketDevice(type,protocol,dummy);
		}
		[SmokeMethod("QSocketDevice(QSocketDevice::Type, QSocketDevice::Protocol, int)")]
		private void NewQSocketDevice(QSocketDevice.E_Type type, QSocketDevice.Protocol protocol, int dummy) {
			ProxyQSocketDevice().NewQSocketDevice(type,protocol,dummy);
		}
		public QSocketDevice(int socket, QSocketDevice.E_Type type) : this((Type) null) {
			CreateQSocketDeviceProxy();
			NewQSocketDevice(socket,type);
		}
		[SmokeMethod("QSocketDevice(int, QSocketDevice::Type)")]
		private void NewQSocketDevice(int socket, QSocketDevice.E_Type type) {
			ProxyQSocketDevice().NewQSocketDevice(socket,type);
		}
		[SmokeMethod("isValid() const")]
		public bool IsValid() {
			return ProxyQSocketDevice().IsValid();
		}
		[SmokeMethod("protocol() const")]
		public QSocketDevice.Protocol protocol() {
			return ProxyQSocketDevice().protocol();
		}
		[SmokeMethod("socket() const")]
		public int Socket() {
			return ProxyQSocketDevice().Socket();
		}
		[SmokeMethod("setSocket(int, QSocketDevice::Type)")]
		public virtual void SetSocket(int socket, QSocketDevice.E_Type type) {
			ProxyQSocketDevice().SetSocket(socket,type);
		}
		[SmokeMethod("open(int)")]
		public new bool Open(int mode) {
			return ProxyQSocketDevice().Open(mode);
		}
		[SmokeMethod("close()")]
		public new void Close() {
			ProxyQSocketDevice().Close();
		}
		[SmokeMethod("flush()")]
		public new void Flush() {
			ProxyQSocketDevice().Flush();
		}
		[SmokeMethod("size() const")]
		public new ulong Size() {
			return ProxyQSocketDevice().Size();
		}
		[SmokeMethod("at() const")]
		public new ulong At() {
			return ProxyQSocketDevice().At();
		}
		[SmokeMethod("at(QIODevice::Offset)")]
		public new bool At(ulong arg1) {
			return ProxyQSocketDevice().At(arg1);
		}
		[SmokeMethod("atEnd() const")]
		public new bool AtEnd() {
			return ProxyQSocketDevice().AtEnd();
		}
		[SmokeMethod("blocking() const")]
		public bool Blocking() {
			return ProxyQSocketDevice().Blocking();
		}
		[SmokeMethod("setBlocking(bool)")]
		public virtual void SetBlocking(bool arg1) {
			ProxyQSocketDevice().SetBlocking(arg1);
		}
		[SmokeMethod("addressReusable() const")]
		public bool AddressReusable() {
			return ProxyQSocketDevice().AddressReusable();
		}
		[SmokeMethod("setAddressReusable(bool)")]
		public virtual void SetAddressReusable(bool arg1) {
			ProxyQSocketDevice().SetAddressReusable(arg1);
		}
		[SmokeMethod("receiveBufferSize() const")]
		public int ReceiveBufferSize() {
			return ProxyQSocketDevice().ReceiveBufferSize();
		}
		[SmokeMethod("setReceiveBufferSize(uint)")]
		public virtual void SetReceiveBufferSize(uint arg1) {
			ProxyQSocketDevice().SetReceiveBufferSize(arg1);
		}
		[SmokeMethod("sendBufferSize() const")]
		public int SendBufferSize() {
			return ProxyQSocketDevice().SendBufferSize();
		}
		[SmokeMethod("setSendBufferSize(uint)")]
		public virtual void SetSendBufferSize(uint arg1) {
			ProxyQSocketDevice().SetSendBufferSize(arg1);
		}
		[SmokeMethod("connect(const QHostAddress&, Q_UINT16)")]
		public virtual bool Connect(QHostAddress arg1, ushort arg2) {
			return ProxyQSocketDevice().Connect(arg1,arg2);
		}
		[SmokeMethod("bind(const QHostAddress&, Q_UINT16)")]
		public virtual bool Bind(QHostAddress arg1, ushort arg2) {
			return ProxyQSocketDevice().Bind(arg1,arg2);
		}
		[SmokeMethod("listen(int)")]
		public virtual bool Listen(int backlog) {
			return ProxyQSocketDevice().Listen(backlog);
		}
		[SmokeMethod("accept()")]
		public virtual int Accept() {
			return ProxyQSocketDevice().Accept();
		}
		[SmokeMethod("bytesAvailable() const")]
		public long BytesAvailable() {
			return ProxyQSocketDevice().BytesAvailable();
		}
		[SmokeMethod("waitForMore(int, bool*) const")]
		public long WaitForMore(int msecs, out bool timeout) {
			return ProxyQSocketDevice().WaitForMore(msecs,out timeout);
		}
		[SmokeMethod("waitForMore(int) const")]
		public long WaitForMore(int msecs) {
			return ProxyQSocketDevice().WaitForMore(msecs);
		}
		[SmokeMethod("readBlock(char*, Q_ULONG)")]
		public new long ReadBlock(string data, long maxlen) {
			return ProxyQSocketDevice().ReadBlock(data,maxlen);
		}
		[SmokeMethod("writeBlock(const char*, Q_ULONG)")]
		public new long WriteBlock(string data, long len) {
			return ProxyQSocketDevice().WriteBlock(data,len);
		}
		[SmokeMethod("writeBlock(const char*, Q_ULONG, const QHostAddress&, Q_UINT16)")]
		public new virtual long WriteBlock(string data, long len, QHostAddress host, ushort port) {
			return ProxyQSocketDevice().WriteBlock(data,len,host,port);
		}
		[SmokeMethod("getch()")]
		public new int Getch() {
			return ProxyQSocketDevice().Getch();
		}
		[SmokeMethod("putch(int)")]
		public new int Putch(int arg1) {
			return ProxyQSocketDevice().Putch(arg1);
		}
		[SmokeMethod("ungetch(int)")]
		public new int Ungetch(int arg1) {
			return ProxyQSocketDevice().Ungetch(arg1);
		}
		[SmokeMethod("port() const")]
		public ushort Port() {
			return ProxyQSocketDevice().Port();
		}
		[SmokeMethod("peerPort() const")]
		public ushort PeerPort() {
			return ProxyQSocketDevice().PeerPort();
		}
		[SmokeMethod("address() const")]
		public QHostAddress Address() {
			return ProxyQSocketDevice().Address();
		}
		[SmokeMethod("peerAddress() const")]
		public QHostAddress PeerAddress() {
			return ProxyQSocketDevice().PeerAddress();
		}
		[SmokeMethod("error() const")]
		public QSocketDevice.Error error() {
			return ProxyQSocketDevice().error();
		}
		[SmokeMethod("setError(QSocketDevice::Error)")]
		protected void SetError(QSocketDevice.Error err) {
			ProxyQSocketDevice().SetError(err);
		}
		~QSocketDevice() {
			DisposeQSocketDevice();
		}
		public void Dispose() {
			DisposeQSocketDevice();
		}
		private void DisposeQSocketDevice() {
			ProxyQSocketDevice().DisposeQSocketDevice();
		}
	}
}
