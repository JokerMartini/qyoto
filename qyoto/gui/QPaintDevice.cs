//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	public interface IQPaintDevice {
			int DevType();
			bool PaintingActive();
			QPaintEngine PaintEngine();
			int Width();
			int Height();
			int WidthMM();
			int HeightMM();
			int LogicalDpiX();
			int LogicalDpiY();
			int PhysicalDpiX();
			int PhysicalDpiY();
			int NumColors();
			int Depth();
	}

	[SmokeClass("QPaintDevice")]
	public class QPaintDevice : MarshalByRefObject, IQPaintDevice {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QPaintDevice(Type dummy) {}
		[SmokeClass("QPaintDevice")]
		interface IQPaintDeviceProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QPaintDevice), this);
			_interceptor = (QPaintDevice) realProxy.GetTransparentProxy();
		}
		private QPaintDevice ProxyQPaintDevice() {
			return (QPaintDevice) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QPaintDevice() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQPaintDeviceProxy), null);
			_staticInterceptor = (IQPaintDeviceProxy) realProxy.GetTransparentProxy();
		}
		private static IQPaintDeviceProxy StaticQPaintDevice() {
			return (IQPaintDeviceProxy) _staticInterceptor;
		}

		public enum PaintDeviceMetric {
			PdmWidth = 1,
			PdmHeight = 2,
			PdmWidthMM = 3,
			PdmHeightMM = 4,
			PdmNumColors = 5,
			PdmDepth = 6,
			PdmDpiX = 7,
			PdmDpiY = 8,
			PdmPhysicalDpiX = 9,
			PdmPhysicalDpiY = 10,
		}
		[SmokeMethod("devType", "() const", "")]
		public virtual int DevType() {
			return ProxyQPaintDevice().DevType();
		}
		[SmokeMethod("paintingActive", "() const", "")]
		public bool PaintingActive() {
			return ProxyQPaintDevice().PaintingActive();
		}
		[SmokeMethod("paintEngine", "() const", "")]
		public virtual QPaintEngine PaintEngine() {
			return ProxyQPaintDevice().PaintEngine();
		}
		[SmokeMethod("width", "() const", "")]
		public int Width() {
			return ProxyQPaintDevice().Width();
		}
		[SmokeMethod("height", "() const", "")]
		public int Height() {
			return ProxyQPaintDevice().Height();
		}
		[SmokeMethod("widthMM", "() const", "")]
		public int WidthMM() {
			return ProxyQPaintDevice().WidthMM();
		}
		[SmokeMethod("heightMM", "() const", "")]
		public int HeightMM() {
			return ProxyQPaintDevice().HeightMM();
		}
		[SmokeMethod("logicalDpiX", "() const", "")]
		public int LogicalDpiX() {
			return ProxyQPaintDevice().LogicalDpiX();
		}
		[SmokeMethod("logicalDpiY", "() const", "")]
		public int LogicalDpiY() {
			return ProxyQPaintDevice().LogicalDpiY();
		}
		[SmokeMethod("physicalDpiX", "() const", "")]
		public int PhysicalDpiX() {
			return ProxyQPaintDevice().PhysicalDpiX();
		}
		[SmokeMethod("physicalDpiY", "() const", "")]
		public int PhysicalDpiY() {
			return ProxyQPaintDevice().PhysicalDpiY();
		}
		[SmokeMethod("numColors", "() const", "")]
		public int NumColors() {
			return ProxyQPaintDevice().NumColors();
		}
		[SmokeMethod("depth", "() const", "")]
		public int Depth() {
			return ProxyQPaintDevice().Depth();
		}
		~QPaintDevice() {
			DisposeQPaintDevice();
		}
		public void Dispose() {
			DisposeQPaintDevice();
		}
		[SmokeMethod("~QPaintDevice", "()", "")]
		private void DisposeQPaintDevice() {
			ProxyQPaintDevice().DisposeQPaintDevice();
		}
	}
}
