//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public class QCanvasPolygonalItem : QCanvasItem {
 		protected QCanvasPolygonalItem(Type dummy) : base((Type) null) {}
		interface IQCanvasPolygonalItemProxy {
		}

		protected void CreateQCanvasPolygonalItemProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QCanvasPolygonalItem), this);
			_interceptor = (QCanvasPolygonalItem) realProxy.GetTransparentProxy();
		}
		private QCanvasPolygonalItem ProxyQCanvasPolygonalItem() {
			return (QCanvasPolygonalItem) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QCanvasPolygonalItem() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQCanvasPolygonalItemProxy), null);
			_staticInterceptor = (IQCanvasPolygonalItemProxy) realProxy.GetTransparentProxy();
		}
		private static IQCanvasPolygonalItemProxy StaticQCanvasPolygonalItem() {
			return (IQCanvasPolygonalItemProxy) _staticInterceptor;
		}

		[SmokeMethod("collidesWith(const QCanvasItem*) const")]
		public new bool CollidesWith(QCanvasItem arg1) {
			return ProxyQCanvasPolygonalItem().CollidesWith(arg1);
		}
		[SmokeMethod("setPen(QPen)")]
		public virtual void SetPen(QPen p) {
			ProxyQCanvasPolygonalItem().SetPen(p);
		}
		[SmokeMethod("setBrush(QBrush)")]
		public virtual void SetBrush(QBrush b) {
			ProxyQCanvasPolygonalItem().SetBrush(b);
		}
		[SmokeMethod("pen() const")]
		public QPen Pen() {
			return ProxyQCanvasPolygonalItem().Pen();
		}
		[SmokeMethod("brush() const")]
		public QBrush Brush() {
			return ProxyQCanvasPolygonalItem().Brush();
		}
		[SmokeMethod("areaPoints() const")]
		public virtual QPointArray AreaPoints() {
			return ProxyQCanvasPolygonalItem().AreaPoints();
		}
		[SmokeMethod("areaPointsAdvanced() const")]
		public virtual QPointArray AreaPointsAdvanced() {
			return ProxyQCanvasPolygonalItem().AreaPointsAdvanced();
		}
		[SmokeMethod("boundingRect() const")]
		public new QRect BoundingRect() {
			return ProxyQCanvasPolygonalItem().BoundingRect();
		}
		[SmokeMethod("rtti() const")]
		public new int Rtti() {
			return ProxyQCanvasPolygonalItem().Rtti();
		}
	}
}
