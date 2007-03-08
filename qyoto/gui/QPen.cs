//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QPen")]
	public class QPen : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QPen(Type dummy) {}
		[SmokeClass("QPen")]
		interface IQPenProxy {
			[SmokeMethod("operator==", "(const QPen&) const", "#")]
			bool op_equals(QPen lhs, QPen p);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QPen), this);
			_interceptor = (QPen) realProxy.GetTransparentProxy();
		}
		private QPen ProxyQPen() {
			return (QPen) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QPen() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQPenProxy), null);
			_staticInterceptor = (IQPenProxy) realProxy.GetTransparentProxy();
		}
		private static IQPenProxy StaticQPen() {
			return (IQPenProxy) _staticInterceptor;
		}
		public QPen() : this((Type) null) {
			CreateProxy();
			NewQPen();
		}
		[SmokeMethod("QPen", "()", "")]
		private void NewQPen() {
			ProxyQPen().NewQPen();
		}
		public QPen(Qt.PenStyle arg1) : this((Type) null) {
			CreateProxy();
			NewQPen(arg1);
		}
		[SmokeMethod("QPen", "(Qt::PenStyle)", "$")]
		private void NewQPen(Qt.PenStyle arg1) {
			ProxyQPen().NewQPen(arg1);
		}
		public QPen(QColor color) : this((Type) null) {
			CreateProxy();
			NewQPen(color);
		}
		[SmokeMethod("QPen", "(const QColor&)", "#")]
		private void NewQPen(QColor color) {
			ProxyQPen().NewQPen(color);
		}
		public QPen(QBrush brush, double width, Qt.PenStyle s, Qt.PenCapStyle c, Qt.PenJoinStyle j) : this((Type) null) {
			CreateProxy();
			NewQPen(brush,width,s,c,j);
		}
		[SmokeMethod("QPen", "(const QBrush&, qreal, Qt::PenStyle, Qt::PenCapStyle, Qt::PenJoinStyle)", "#$$$$")]
		private void NewQPen(QBrush brush, double width, Qt.PenStyle s, Qt.PenCapStyle c, Qt.PenJoinStyle j) {
			ProxyQPen().NewQPen(brush,width,s,c,j);
		}
		public QPen(QBrush brush, double width, Qt.PenStyle s, Qt.PenCapStyle c) : this((Type) null) {
			CreateProxy();
			NewQPen(brush,width,s,c);
		}
		[SmokeMethod("QPen", "(const QBrush&, qreal, Qt::PenStyle, Qt::PenCapStyle)", "#$$$")]
		private void NewQPen(QBrush brush, double width, Qt.PenStyle s, Qt.PenCapStyle c) {
			ProxyQPen().NewQPen(brush,width,s,c);
		}
		public QPen(QBrush brush, double width, Qt.PenStyle s) : this((Type) null) {
			CreateProxy();
			NewQPen(brush,width,s);
		}
		[SmokeMethod("QPen", "(const QBrush&, qreal, Qt::PenStyle)", "#$$")]
		private void NewQPen(QBrush brush, double width, Qt.PenStyle s) {
			ProxyQPen().NewQPen(brush,width,s);
		}
		public QPen(QBrush brush, double width) : this((Type) null) {
			CreateProxy();
			NewQPen(brush,width);
		}
		[SmokeMethod("QPen", "(const QBrush&, qreal)", "#$")]
		private void NewQPen(QBrush brush, double width) {
			ProxyQPen().NewQPen(brush,width);
		}
		public QPen(QPen pen) : this((Type) null) {
			CreateProxy();
			NewQPen(pen);
		}
		[SmokeMethod("QPen", "(const QPen&)", "#")]
		private void NewQPen(QPen pen) {
			ProxyQPen().NewQPen(pen);
		}
		[SmokeMethod("style", "() const", "")]
		public Qt.PenStyle Style() {
			return ProxyQPen().Style();
		}
		[SmokeMethod("setStyle", "(Qt::PenStyle)", "$")]
		public void SetStyle(Qt.PenStyle arg1) {
			ProxyQPen().SetStyle(arg1);
		}
		[SmokeMethod("dashPattern", "() const", "")]
		public List<double> DashPattern() {
			return ProxyQPen().DashPattern();
		}
		[SmokeMethod("setDashPattern", "(const QVector<qreal>&)", "?")]
		public void SetDashPattern(List<double> pattern) {
			ProxyQPen().SetDashPattern(pattern);
		}
		[SmokeMethod("miterLimit", "() const", "")]
		public double MiterLimit() {
			return ProxyQPen().MiterLimit();
		}
		[SmokeMethod("setMiterLimit", "(qreal)", "$")]
		public void SetMiterLimit(double limit) {
			ProxyQPen().SetMiterLimit(limit);
		}
		[SmokeMethod("widthF", "() const", "")]
		public double WidthF() {
			return ProxyQPen().WidthF();
		}
		[SmokeMethod("setWidthF", "(qreal)", "$")]
		public void SetWidthF(double width) {
			ProxyQPen().SetWidthF(width);
		}
		[SmokeMethod("width", "() const", "")]
		public int Width() {
			return ProxyQPen().Width();
		}
		[SmokeMethod("setWidth", "(int)", "$")]
		public void SetWidth(int width) {
			ProxyQPen().SetWidth(width);
		}
		[SmokeMethod("color", "() const", "")]
		public QColor Color() {
			return ProxyQPen().Color();
		}
		[SmokeMethod("setColor", "(const QColor&)", "#")]
		public void SetColor(QColor color) {
			ProxyQPen().SetColor(color);
		}
		[SmokeMethod("brush", "() const", "")]
		public QBrush Brush() {
			return ProxyQPen().Brush();
		}
		[SmokeMethod("setBrush", "(const QBrush&)", "#")]
		public void SetBrush(QBrush brush) {
			ProxyQPen().SetBrush(brush);
		}
		[SmokeMethod("isSolid", "() const", "")]
		public bool IsSolid() {
			return ProxyQPen().IsSolid();
		}
		[SmokeMethod("capStyle", "() const", "")]
		public Qt.PenCapStyle CapStyle() {
			return ProxyQPen().CapStyle();
		}
		[SmokeMethod("setCapStyle", "(Qt::PenCapStyle)", "$")]
		public void SetCapStyle(Qt.PenCapStyle pcs) {
			ProxyQPen().SetCapStyle(pcs);
		}
		[SmokeMethod("joinStyle", "() const", "")]
		public Qt.PenJoinStyle JoinStyle() {
			return ProxyQPen().JoinStyle();
		}
		[SmokeMethod("setJoinStyle", "(Qt::PenJoinStyle)", "$")]
		public void SetJoinStyle(Qt.PenJoinStyle pcs) {
			ProxyQPen().SetJoinStyle(pcs);
		}
		public static bool operator==(QPen lhs, QPen p) {
			return StaticQPen().op_equals(lhs,p);
		}
		public static bool operator!=(QPen lhs, QPen p) {
			return !StaticQPen().op_equals(lhs,p);
		}
		public override bool Equals(object o) {
			if (!(o is QPen)) { return false; }
			return this == (QPen) o;
		}
		public override int GetHashCode() {
			return ProxyQPen().GetHashCode();
		}
		//  operator QVariant(); >>>> NOT CONVERTED
		[SmokeMethod("isDetached", "()", "")]
		public bool IsDetached() {
			return ProxyQPen().IsDetached();
		}
		~QPen() {
			DisposeQPen();
		}
		public void Dispose() {
			DisposeQPen();
		}
		[SmokeMethod("~QPen", "()", "")]
		private void DisposeQPen() {
			ProxyQPen().DisposeQPen();
		}
	}
}
