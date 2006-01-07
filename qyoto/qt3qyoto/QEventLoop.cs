//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQEventLoopSignals"></see> for signals emitted by QEventLoop
	[SmokeClass("QEventLoop")]
	public class QEventLoop : QObject, IDisposable {
 		protected QEventLoop(Type dummy) : base((Type) null) {}
		interface IQEventLoopProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQEventLoopProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QEventLoop), this);
			_interceptor = (QEventLoop) realProxy.GetTransparentProxy();
		}
		private QEventLoop ProxyQEventLoop() {
			return (QEventLoop) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QEventLoop() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQEventLoopProxy), null);
			_staticInterceptor = (IQEventLoopProxy) realProxy.GetTransparentProxy();
		}
		private static IQEventLoopProxy StaticQEventLoop() {
			return (IQEventLoopProxy) _staticInterceptor;
		}

		public enum ProcessEvents {
			AllEvents = 0x00,
			ExcludeUserInput = 0x01,
			ExcludeSocketNotifiers = 0x02,
			WaitForMore = 0x04,
		}
		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQEventLoop().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQEventLoop().ClassName();
		}
		public QEventLoop(QObject parent, string name) : this((Type) null) {
			CreateQEventLoopProxy();
			CreateQEventLoopSignalProxy();
			NewQEventLoop(parent,name);
		}
		[SmokeMethod("QEventLoop(QObject*, const char*)")]
		private void NewQEventLoop(QObject parent, string name) {
			ProxyQEventLoop().NewQEventLoop(parent,name);
		}
		public QEventLoop(QObject parent) : this((Type) null) {
			CreateQEventLoopProxy();
			CreateQEventLoopSignalProxy();
			NewQEventLoop(parent);
		}
		[SmokeMethod("QEventLoop(QObject*)")]
		private void NewQEventLoop(QObject parent) {
			ProxyQEventLoop().NewQEventLoop(parent);
		}
		public QEventLoop() : this((Type) null) {
			CreateQEventLoopProxy();
			CreateQEventLoopSignalProxy();
			NewQEventLoop();
		}
		[SmokeMethod("QEventLoop()")]
		private void NewQEventLoop() {
			ProxyQEventLoop().NewQEventLoop();
		}
		[SmokeMethod("processEvents(QEventLoop::ProcessEventsFlags, int)")]
		public void processEvents(uint flags, int maxtime) {
			ProxyQEventLoop().processEvents(flags,maxtime);
		}
		[SmokeMethod("processEvents(QEventLoop::ProcessEventsFlags)")]
		public virtual bool processEvents(uint flags) {
			return ProxyQEventLoop().processEvents(flags);
		}
		[SmokeMethod("hasPendingEvents() const")]
		public virtual bool HasPendingEvents() {
			return ProxyQEventLoop().HasPendingEvents();
		}
		[SmokeMethod("registerSocketNotifier(QSocketNotifier*)")]
		public virtual void RegisterSocketNotifier(QSocketNotifier arg1) {
			ProxyQEventLoop().RegisterSocketNotifier(arg1);
		}
		[SmokeMethod("unregisterSocketNotifier(QSocketNotifier*)")]
		public virtual void UnregisterSocketNotifier(QSocketNotifier arg1) {
			ProxyQEventLoop().UnregisterSocketNotifier(arg1);
		}
		[SmokeMethod("setSocketNotifierPending(QSocketNotifier*)")]
		public void SetSocketNotifierPending(QSocketNotifier arg1) {
			ProxyQEventLoop().SetSocketNotifierPending(arg1);
		}
		[SmokeMethod("activateSocketNotifiers()")]
		public int ActivateSocketNotifiers() {
			return ProxyQEventLoop().ActivateSocketNotifiers();
		}
		[SmokeMethod("activateTimers()")]
		public int ActivateTimers() {
			return ProxyQEventLoop().ActivateTimers();
		}
		[SmokeMethod("timeToWait() const")]
		public int TimeToWait() {
			return ProxyQEventLoop().TimeToWait();
		}
		[SmokeMethod("exec()")]
		public virtual int Exec() {
			return ProxyQEventLoop().Exec();
		}
		[SmokeMethod("exit(int)")]
		public virtual void Exit(int retcode) {
			ProxyQEventLoop().Exit(retcode);
		}
		[SmokeMethod("exit()")]
		public virtual void Exit() {
			ProxyQEventLoop().Exit();
		}
		[SmokeMethod("enterLoop()")]
		public virtual int EnterLoop() {
			return ProxyQEventLoop().EnterLoop();
		}
		[SmokeMethod("exitLoop()")]
		public virtual void ExitLoop() {
			ProxyQEventLoop().ExitLoop();
		}
		[SmokeMethod("loopLevel() const")]
		public virtual int LoopLevel() {
			return ProxyQEventLoop().LoopLevel();
		}
		[SmokeMethod("wakeUp()")]
		public virtual void WakeUp() {
			ProxyQEventLoop().WakeUp();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQEventLoop().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQEventLoop().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQEventLoop().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQEventLoop().TrUtf8(arg1);
		}
		~QEventLoop() {
			DisposeQEventLoop();
		}
		public new void Dispose() {
			DisposeQEventLoop();
		}
		private void DisposeQEventLoop() {
			ProxyQEventLoop().DisposeQEventLoop();
		}
		protected void CreateQEventLoopSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQEventLoopSignals), this);
			Q_EMIT = (IQEventLoopSignals) realProxy.GetTransparentProxy();
		}
		protected new IQEventLoopSignals Emit() {
			return (IQEventLoopSignals) Q_EMIT;
		}
	}

	public interface IQEventLoopSignals : IQObjectSignals {
		[Q_SIGNAL("void awake()")]
		void Awake();
		[Q_SIGNAL("void aboutToBlock()")]
		void AboutToBlock();
	}
}
