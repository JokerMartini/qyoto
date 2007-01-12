//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	/// See <see cref="IQTimeLineSignals"></see> for signals emitted by QTimeLine
	[SmokeClass("QTimeLine")]
	public class QTimeLine : QObject, IDisposable {
 		protected QTimeLine(Type dummy) : base((Type) null) {}
		interface IQTimeLineProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTimeLine), this);
			_interceptor = (QTimeLine) realProxy.GetTransparentProxy();
		}
		private QTimeLine ProxyQTimeLine() {
			return (QTimeLine) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTimeLine() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTimeLineProxy), null);
			_staticInterceptor = (IQTimeLineProxy) realProxy.GetTransparentProxy();
		}
		private static IQTimeLineProxy StaticQTimeLine() {
			return (IQTimeLineProxy) _staticInterceptor;
		}

		public enum State {
			NotRunning = 0,
			Paused = 1,
			Running = 2,
		}
		public enum Direction {
			Forward = 0,
			Backward = 1,
		}
		public enum CurveShape {
			EaseInCurve = 0,
			EaseOutCurve = 1,
			EaseInOutCurve = 2,
			LinearCurve = 3,
			SineCurve = 4,
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QTimeLine(int duration, QObject parent) : this((Type) null) {
			CreateProxy();
			NewQTimeLine(duration,parent);
		}
		[SmokeMethod("QTimeLine(int, QObject*)")]
		private void NewQTimeLine(int duration, QObject parent) {
			ProxyQTimeLine().NewQTimeLine(duration,parent);
		}
		public QTimeLine(int duration) : this((Type) null) {
			CreateProxy();
			NewQTimeLine(duration);
		}
		[SmokeMethod("QTimeLine(int)")]
		private void NewQTimeLine(int duration) {
			ProxyQTimeLine().NewQTimeLine(duration);
		}
		public QTimeLine() : this((Type) null) {
			CreateProxy();
			NewQTimeLine();
		}
		[SmokeMethod("QTimeLine()")]
		private void NewQTimeLine() {
			ProxyQTimeLine().NewQTimeLine();
		}
		[SmokeMethod("state() const")]
		public QTimeLine.State state() {
			return ProxyQTimeLine().state();
		}
		[SmokeMethod("loopCount() const")]
		public int LoopCount() {
			return ProxyQTimeLine().LoopCount();
		}
		[SmokeMethod("setLoopCount(int)")]
		public void SetLoopCount(int count) {
			ProxyQTimeLine().SetLoopCount(count);
		}
		[SmokeMethod("direction() const")]
		public QTimeLine.Direction direction() {
			return ProxyQTimeLine().direction();
		}
		[SmokeMethod("setDirection(QTimeLine::Direction)")]
		public void SetDirection(QTimeLine.Direction direction) {
			ProxyQTimeLine().SetDirection(direction);
		}
		[SmokeMethod("duration() const")]
		public int Duration() {
			return ProxyQTimeLine().Duration();
		}
		[SmokeMethod("setDuration(int)")]
		public void SetDuration(int duration) {
			ProxyQTimeLine().SetDuration(duration);
		}
		[SmokeMethod("startFrame() const")]
		public int StartFrame() {
			return ProxyQTimeLine().StartFrame();
		}
		[SmokeMethod("setStartFrame(int)")]
		public void SetStartFrame(int frame) {
			ProxyQTimeLine().SetStartFrame(frame);
		}
		[SmokeMethod("endFrame() const")]
		public int EndFrame() {
			return ProxyQTimeLine().EndFrame();
		}
		[SmokeMethod("setEndFrame(int)")]
		public void SetEndFrame(int frame) {
			ProxyQTimeLine().SetEndFrame(frame);
		}
		[SmokeMethod("setFrameRange(int, int)")]
		public void SetFrameRange(int startFrame, int endFrame) {
			ProxyQTimeLine().SetFrameRange(startFrame,endFrame);
		}
		[SmokeMethod("updateInterval() const")]
		public int UpdateInterval() {
			return ProxyQTimeLine().UpdateInterval();
		}
		[SmokeMethod("setUpdateInterval(int)")]
		public void SetUpdateInterval(int interval) {
			ProxyQTimeLine().SetUpdateInterval(interval);
		}
		[SmokeMethod("curveShape() const")]
		public QTimeLine.CurveShape curveShape() {
			return ProxyQTimeLine().curveShape();
		}
		[SmokeMethod("setCurveShape(QTimeLine::CurveShape)")]
		public void SetCurveShape(QTimeLine.CurveShape shape) {
			ProxyQTimeLine().SetCurveShape(shape);
		}
		[SmokeMethod("currentTime() const")]
		public int CurrentTime() {
			return ProxyQTimeLine().CurrentTime();
		}
		[SmokeMethod("currentFrame() const")]
		public int CurrentFrame() {
			return ProxyQTimeLine().CurrentFrame();
		}
		[SmokeMethod("currentValue() const")]
		public double CurrentValue() {
			return ProxyQTimeLine().CurrentValue();
		}
		[SmokeMethod("frameForTime(int) const")]
		public int FrameForTime(int msec) {
			return ProxyQTimeLine().FrameForTime(msec);
		}
		[SmokeMethod("valueForTime(int) const")]
		public virtual double ValueForTime(int msec) {
			return ProxyQTimeLine().ValueForTime(msec);
		}
		[SmokeMethod("start()")]
		public void Start() {
			ProxyQTimeLine().Start();
		}
		[SmokeMethod("stop()")]
		public void Stop() {
			ProxyQTimeLine().Stop();
		}
		[SmokeMethod("setPaused(bool)")]
		public void SetPaused(bool paused) {
			ProxyQTimeLine().SetPaused(paused);
		}
		[SmokeMethod("setCurrentTime(int)")]
		public void SetCurrentTime(int msec) {
			ProxyQTimeLine().SetCurrentTime(msec);
		}
		[SmokeMethod("toggleDirection()")]
		public void ToggleDirection() {
			ProxyQTimeLine().ToggleDirection();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQTimeLine().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQTimeLine().Tr(s);
		}
		[SmokeMethod("timerEvent(QTimerEvent*)")]
		protected new void TimerEvent(QTimerEvent arg1) {
			ProxyQTimeLine().TimerEvent(arg1);
		}
		~QTimeLine() {
			DisposeQTimeLine();
		}
		public new void Dispose() {
			DisposeQTimeLine();
		}
		[SmokeMethod("~QTimeLine()")]
		private void DisposeQTimeLine() {
			ProxyQTimeLine().DisposeQTimeLine();
		}
		protected new IQTimeLineSignals Emit() {
			return (IQTimeLineSignals) Q_EMIT;
		}
	}

	public interface IQTimeLineSignals : IQObjectSignals {
		[Q_SIGNAL("void valueChanged(qreal)")]
		void ValueChanged(double x);
		[Q_SIGNAL("void frameChanged(int)")]
		void FrameChanged(int arg1);
		[Q_SIGNAL("void stateChanged(QTimeLine::State)")]
		void StateChanged(QTimeLine.State newState);
		[Q_SIGNAL("void finished()")]
		void Finished();
	}
}