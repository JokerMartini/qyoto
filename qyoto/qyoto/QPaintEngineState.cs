//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QPaintEngineState")]
	public class QPaintEngineState : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QPaintEngineState(Type dummy) {}
		interface IQPaintEngineStateProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QPaintEngineState), this);
			_interceptor = (QPaintEngineState) realProxy.GetTransparentProxy();
		}
		private QPaintEngineState ProxyQPaintEngineState() {
			return (QPaintEngineState) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QPaintEngineState() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQPaintEngineStateProxy), null);
			_staticInterceptor = (IQPaintEngineStateProxy) realProxy.GetTransparentProxy();
		}
		private static IQPaintEngineStateProxy StaticQPaintEngineState() {
			return (IQPaintEngineStateProxy) _staticInterceptor;
		}

		[SmokeMethod("state() const")]
		public int State() {
			return ProxyQPaintEngineState().State();
		}
		[SmokeMethod("pen() const")]
		public QPen Pen() {
			return ProxyQPaintEngineState().Pen();
		}
		[SmokeMethod("brush() const")]
		public QBrush Brush() {
			return ProxyQPaintEngineState().Brush();
		}
		[SmokeMethod("brushOrigin() const")]
		public QPointF BrushOrigin() {
			return ProxyQPaintEngineState().BrushOrigin();
		}
		[SmokeMethod("backgroundBrush() const")]
		public QBrush BackgroundBrush() {
			return ProxyQPaintEngineState().BackgroundBrush();
		}
		[SmokeMethod("backgroundMode() const")]
		public Qt.BGMode BackgroundMode() {
			return ProxyQPaintEngineState().BackgroundMode();
		}
		[SmokeMethod("font() const")]
		public QFont Font() {
			return ProxyQPaintEngineState().Font();
		}
		[SmokeMethod("matrix() const")]
		public QMatrix Matrix() {
			return ProxyQPaintEngineState().Matrix();
		}
		[SmokeMethod("clipOperation() const")]
		public Qt.ClipOperation ClipOperation() {
			return ProxyQPaintEngineState().ClipOperation();
		}
		[SmokeMethod("clipRegion() const")]
		public QRegion ClipRegion() {
			return ProxyQPaintEngineState().ClipRegion();
		}
		[SmokeMethod("clipPath() const")]
		public QPainterPath ClipPath() {
			return ProxyQPaintEngineState().ClipPath();
		}
		[SmokeMethod("isClipEnabled() const")]
		public bool IsClipEnabled() {
			return ProxyQPaintEngineState().IsClipEnabled();
		}
		[SmokeMethod("renderHints() const")]
		public int RenderHints() {
			return ProxyQPaintEngineState().RenderHints();
		}
		[SmokeMethod("compositionMode() const")]
		public QPainter.CompositionMode CompositionMode() {
			return ProxyQPaintEngineState().CompositionMode();
		}
		[SmokeMethod("painter() const")]
		public QPainter Painter() {
			return ProxyQPaintEngineState().Painter();
		}
		public QPaintEngineState() : this((Type) null) {
			CreateProxy();
			NewQPaintEngineState();
		}
		[SmokeMethod("QPaintEngineState()")]
		private void NewQPaintEngineState() {
			ProxyQPaintEngineState().NewQPaintEngineState();
		}
		~QPaintEngineState() {
			DisposeQPaintEngineState();
		}
		public void Dispose() {
			DisposeQPaintEngineState();
		}
		private void DisposeQPaintEngineState() {
			ProxyQPaintEngineState().DisposeQPaintEngineState();
		}
	}
}
