//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	[SmokeClass("QPainter")]
	public class QPainter : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QPainter(Type dummy) {}
		[SmokeClass("QPainter")]
		interface IQPainterProxy {
			[SmokeMethod("setRedirected", "(const QPaintDevice*, QPaintDevice*, const QPoint&)", "###")]
			void SetRedirected(IQPaintDevice device, IQPaintDevice replacement, QPoint offset);
			[SmokeMethod("setRedirected", "(const QPaintDevice*, QPaintDevice*)", "##")]
			void SetRedirected(IQPaintDevice device, IQPaintDevice replacement);
			[SmokeMethod("redirected", "(const QPaintDevice*, QPoint*)", "##")]
			IQPaintDevice Redirected(IQPaintDevice device, QPoint offset);
			[SmokeMethod("redirected", "(const QPaintDevice*)", "#")]
			IQPaintDevice Redirected(IQPaintDevice device);
			[SmokeMethod("restoreRedirected", "(const QPaintDevice*)", "#")]
			void RestoreRedirected(IQPaintDevice device);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QPainter), this);
			_interceptor = (QPainter) realProxy.GetTransparentProxy();
		}
		private QPainter ProxyQPainter() {
			return (QPainter) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QPainter() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQPainterProxy), null);
			_staticInterceptor = (IQPainterProxy) realProxy.GetTransparentProxy();
		}
		private static IQPainterProxy StaticQPainter() {
			return (IQPainterProxy) _staticInterceptor;
		}

		public enum RenderHint {
			Antialiasing = 0x01,
			TextAntialiasing = 0x02,
			SmoothPixmapTransform = 0x04,
		}
		public enum CompositionMode {
			CompositionMode_SourceOver = 0,
			CompositionMode_DestinationOver = 1,
			CompositionMode_Clear = 2,
			CompositionMode_Source = 3,
			CompositionMode_Destination = 4,
			CompositionMode_SourceIn = 5,
			CompositionMode_DestinationIn = 6,
			CompositionMode_SourceOut = 7,
			CompositionMode_DestinationOut = 8,
			CompositionMode_SourceAtop = 9,
			CompositionMode_DestinationAtop = 10,
			CompositionMode_Xor = 11,
		}
		public QPainter() : this((Type) null) {
			CreateProxy();
			NewQPainter();
		}
		[SmokeMethod("QPainter", "()", "")]
		private void NewQPainter() {
			ProxyQPainter().NewQPainter();
		}
		public QPainter(IQPaintDevice arg1) : this((Type) null) {
			CreateProxy();
			NewQPainter(arg1);
		}
		[SmokeMethod("QPainter", "(QPaintDevice*)", "#")]
		private void NewQPainter(IQPaintDevice arg1) {
			ProxyQPainter().NewQPainter(arg1);
		}
		[SmokeMethod("device", "() const", "")]
		public IQPaintDevice Device() {
			return ProxyQPainter().Device();
		}
		[SmokeMethod("begin", "(QPaintDevice*)", "#")]
		public bool Begin(IQPaintDevice arg1) {
			return ProxyQPainter().Begin(arg1);
		}
		[SmokeMethod("end", "()", "")]
		public bool End() {
			return ProxyQPainter().End();
		}
		[SmokeMethod("isActive", "() const", "")]
		public bool IsActive() {
			return ProxyQPainter().IsActive();
		}
		[SmokeMethod("initFrom", "(const QWidget*)", "#")]
		public void InitFrom(QWidget widget) {
			ProxyQPainter().InitFrom(widget);
		}
		[SmokeMethod("setCompositionMode", "(QPainter::CompositionMode)", "$")]
		public void SetCompositionMode(QPainter.CompositionMode mode) {
			ProxyQPainter().SetCompositionMode(mode);
		}
		[SmokeMethod("compositionMode", "() const", "")]
		public QPainter.CompositionMode compositionMode() {
			return ProxyQPainter().compositionMode();
		}
		[SmokeMethod("font", "() const", "")]
		public QFont Font() {
			return ProxyQPainter().Font();
		}
		[SmokeMethod("setFont", "(const QFont&)", "#")]
		public void SetFont(QFont f) {
			ProxyQPainter().SetFont(f);
		}
		[SmokeMethod("fontMetrics", "() const", "")]
		public QFontMetrics FontMetrics() {
			return ProxyQPainter().FontMetrics();
		}
		[SmokeMethod("fontInfo", "() const", "")]
		public QFontInfo FontInfo() {
			return ProxyQPainter().FontInfo();
		}
		[SmokeMethod("setPen", "(const QColor&)", "#")]
		public void SetPen(QColor color) {
			ProxyQPainter().SetPen(color);
		}
		[SmokeMethod("setPen", "(const QPen&)", "#")]
		public void SetPen(QPen pen) {
			ProxyQPainter().SetPen(pen);
		}
		[SmokeMethod("setPen", "(Qt::PenStyle)", "$")]
		public void SetPen(Qt.PenStyle style) {
			ProxyQPainter().SetPen(style);
		}
		[SmokeMethod("pen", "() const", "")]
		public QPen Pen() {
			return ProxyQPainter().Pen();
		}
		[SmokeMethod("setBrush", "(const QBrush&)", "#")]
		public void SetBrush(QBrush brush) {
			ProxyQPainter().SetBrush(brush);
		}
		[SmokeMethod("setBrush", "(Qt::BrushStyle)", "$")]
		public void SetBrush(Qt.BrushStyle style) {
			ProxyQPainter().SetBrush(style);
		}
		[SmokeMethod("brush", "() const", "")]
		public QBrush Brush() {
			return ProxyQPainter().Brush();
		}
		[SmokeMethod("setBackgroundMode", "(Qt::BGMode)", "$")]
		public void SetBackgroundMode(Qt.BGMode mode) {
			ProxyQPainter().SetBackgroundMode(mode);
		}
		[SmokeMethod("backgroundMode", "() const", "")]
		public Qt.BGMode BackgroundMode() {
			return ProxyQPainter().BackgroundMode();
		}
		[SmokeMethod("brushOrigin", "() const", "")]
		public QPoint BrushOrigin() {
			return ProxyQPainter().BrushOrigin();
		}
		[SmokeMethod("setBrushOrigin", "(int, int)", "$$")]
		public void SetBrushOrigin(int x, int y) {
			ProxyQPainter().SetBrushOrigin(x,y);
		}
		[SmokeMethod("setBrushOrigin", "(const QPoint&)", "#")]
		public void SetBrushOrigin(QPoint arg1) {
			ProxyQPainter().SetBrushOrigin(arg1);
		}
		[SmokeMethod("setBrushOrigin", "(const QPointF&)", "#")]
		public void SetBrushOrigin(QPointF arg1) {
			ProxyQPainter().SetBrushOrigin(arg1);
		}
		[SmokeMethod("setBackground", "(const QBrush&)", "#")]
		public void SetBackground(QBrush bg) {
			ProxyQPainter().SetBackground(bg);
		}
		[SmokeMethod("background", "() const", "")]
		public QBrush Background() {
			return ProxyQPainter().Background();
		}
		[SmokeMethod("opacity", "() const", "")]
		public double Opacity() {
			return ProxyQPainter().Opacity();
		}
		[SmokeMethod("setOpacity", "(qreal)", "$")]
		public void SetOpacity(double opacity) {
			ProxyQPainter().SetOpacity(opacity);
		}
		[SmokeMethod("clipRegion", "() const", "")]
		public QRegion ClipRegion() {
			return ProxyQPainter().ClipRegion();
		}
		[SmokeMethod("clipPath", "() const", "")]
		public QPainterPath ClipPath() {
			return ProxyQPainter().ClipPath();
		}
		[SmokeMethod("setClipRect", "(const QRectF&, Qt::ClipOperation)", "#$")]
		public void SetClipRect(QRectF arg1, Qt.ClipOperation op) {
			ProxyQPainter().SetClipRect(arg1,op);
		}
		[SmokeMethod("setClipRect", "(const QRectF&)", "#")]
		public void SetClipRect(QRectF arg1) {
			ProxyQPainter().SetClipRect(arg1);
		}
		[SmokeMethod("setClipRect", "(const QRect&, Qt::ClipOperation)", "#$")]
		public void SetClipRect(QRect arg1, Qt.ClipOperation op) {
			ProxyQPainter().SetClipRect(arg1,op);
		}
		[SmokeMethod("setClipRect", "(const QRect&)", "#")]
		public void SetClipRect(QRect arg1) {
			ProxyQPainter().SetClipRect(arg1);
		}
		[SmokeMethod("setClipRect", "(int, int, int, int, Qt::ClipOperation)", "$$$$$")]
		public void SetClipRect(int x, int y, int w, int h, Qt.ClipOperation op) {
			ProxyQPainter().SetClipRect(x,y,w,h,op);
		}
		[SmokeMethod("setClipRect", "(int, int, int, int)", "$$$$")]
		public void SetClipRect(int x, int y, int w, int h) {
			ProxyQPainter().SetClipRect(x,y,w,h);
		}
		[SmokeMethod("setClipRegion", "(const QRegion&, Qt::ClipOperation)", "#$")]
		public void SetClipRegion(QRegion arg1, Qt.ClipOperation op) {
			ProxyQPainter().SetClipRegion(arg1,op);
		}
		[SmokeMethod("setClipRegion", "(const QRegion&)", "#")]
		public void SetClipRegion(QRegion arg1) {
			ProxyQPainter().SetClipRegion(arg1);
		}
		[SmokeMethod("setClipPath", "(const QPainterPath&, Qt::ClipOperation)", "#$")]
		public void SetClipPath(QPainterPath path, Qt.ClipOperation op) {
			ProxyQPainter().SetClipPath(path,op);
		}
		[SmokeMethod("setClipPath", "(const QPainterPath&)", "#")]
		public void SetClipPath(QPainterPath path) {
			ProxyQPainter().SetClipPath(path);
		}
		[SmokeMethod("setClipping", "(bool)", "$")]
		public void SetClipping(bool enable) {
			ProxyQPainter().SetClipping(enable);
		}
		[SmokeMethod("hasClipping", "() const", "")]
		public bool HasClipping() {
			return ProxyQPainter().HasClipping();
		}
		[SmokeMethod("save", "()", "")]
		public void Save() {
			ProxyQPainter().Save();
		}
		[SmokeMethod("restore", "()", "")]
		public void Restore() {
			ProxyQPainter().Restore();
		}
		[SmokeMethod("setMatrix", "(const QMatrix&, bool)", "#$")]
		public void SetMatrix(QMatrix matrix, bool combine) {
			ProxyQPainter().SetMatrix(matrix,combine);
		}
		[SmokeMethod("setMatrix", "(const QMatrix&)", "#")]
		public void SetMatrix(QMatrix matrix) {
			ProxyQPainter().SetMatrix(matrix);
		}
		[SmokeMethod("matrix", "() const", "")]
		public QMatrix Matrix() {
			return ProxyQPainter().Matrix();
		}
		[SmokeMethod("deviceMatrix", "() const", "")]
		public QMatrix DeviceMatrix() {
			return ProxyQPainter().DeviceMatrix();
		}
		[SmokeMethod("resetMatrix", "()", "")]
		public void ResetMatrix() {
			ProxyQPainter().ResetMatrix();
		}
		[SmokeMethod("setWorldMatrix", "(const QMatrix&, bool)", "#$")]
		public void SetWorldMatrix(QMatrix matrix, bool combine) {
			ProxyQPainter().SetWorldMatrix(matrix,combine);
		}
		[SmokeMethod("setWorldMatrix", "(const QMatrix&)", "#")]
		public void SetWorldMatrix(QMatrix matrix) {
			ProxyQPainter().SetWorldMatrix(matrix);
		}
		[SmokeMethod("worldMatrix", "() const", "")]
		public QMatrix WorldMatrix() {
			return ProxyQPainter().WorldMatrix();
		}
		[SmokeMethod("combinedMatrix", "() const", "")]
		public QMatrix CombinedMatrix() {
			return ProxyQPainter().CombinedMatrix();
		}
		[SmokeMethod("setMatrixEnabled", "(bool)", "$")]
		public void SetMatrixEnabled(bool enabled) {
			ProxyQPainter().SetMatrixEnabled(enabled);
		}
		[SmokeMethod("matrixEnabled", "() const", "")]
		public bool MatrixEnabled() {
			return ProxyQPainter().MatrixEnabled();
		}
		[SmokeMethod("setWorldMatrixEnabled", "(bool)", "$")]
		public void SetWorldMatrixEnabled(bool enabled) {
			ProxyQPainter().SetWorldMatrixEnabled(enabled);
		}
		[SmokeMethod("worldMatrixEnabled", "() const", "")]
		public bool WorldMatrixEnabled() {
			return ProxyQPainter().WorldMatrixEnabled();
		}
		[SmokeMethod("scale", "(qreal, qreal)", "$$")]
		public void Scale(double sx, double sy) {
			ProxyQPainter().Scale(sx,sy);
		}
		[SmokeMethod("shear", "(qreal, qreal)", "$$")]
		public void Shear(double sh, double sv) {
			ProxyQPainter().Shear(sh,sv);
		}
		[SmokeMethod("rotate", "(qreal)", "$")]
		public void Rotate(double a) {
			ProxyQPainter().Rotate(a);
		}
		[SmokeMethod("translate", "(const QPointF&)", "#")]
		public void Translate(QPointF offset) {
			ProxyQPainter().Translate(offset);
		}
		[SmokeMethod("translate", "(const QPoint&)", "#")]
		public void Translate(QPoint offset) {
			ProxyQPainter().Translate(offset);
		}
		[SmokeMethod("translate", "(qreal, qreal)", "$$")]
		public void Translate(double dx, double dy) {
			ProxyQPainter().Translate(dx,dy);
		}
		[SmokeMethod("window", "() const", "")]
		public QRect Window() {
			return ProxyQPainter().Window();
		}
		[SmokeMethod("setWindow", "(const QRect&)", "#")]
		public void SetWindow(QRect window) {
			ProxyQPainter().SetWindow(window);
		}
		[SmokeMethod("setWindow", "(int, int, int, int)", "$$$$")]
		public void SetWindow(int x, int y, int w, int h) {
			ProxyQPainter().SetWindow(x,y,w,h);
		}
		[SmokeMethod("viewport", "() const", "")]
		public QRect Viewport() {
			return ProxyQPainter().Viewport();
		}
		[SmokeMethod("setViewport", "(const QRect&)", "#")]
		public void SetViewport(QRect viewport) {
			ProxyQPainter().SetViewport(viewport);
		}
		[SmokeMethod("setViewport", "(int, int, int, int)", "$$$$")]
		public void SetViewport(int x, int y, int w, int h) {
			ProxyQPainter().SetViewport(x,y,w,h);
		}
		[SmokeMethod("setViewTransformEnabled", "(bool)", "$")]
		public void SetViewTransformEnabled(bool enable) {
			ProxyQPainter().SetViewTransformEnabled(enable);
		}
		[SmokeMethod("viewTransformEnabled", "() const", "")]
		public bool ViewTransformEnabled() {
			return ProxyQPainter().ViewTransformEnabled();
		}
		[SmokeMethod("strokePath", "(const QPainterPath&, const QPen&)", "##")]
		public void StrokePath(QPainterPath path, QPen pen) {
			ProxyQPainter().StrokePath(path,pen);
		}
		[SmokeMethod("fillPath", "(const QPainterPath&, const QBrush&)", "##")]
		public void FillPath(QPainterPath path, QBrush brush) {
			ProxyQPainter().FillPath(path,brush);
		}
		[SmokeMethod("drawPath", "(const QPainterPath&)", "#")]
		public void DrawPath(QPainterPath path) {
			ProxyQPainter().DrawPath(path);
		}
		[SmokeMethod("drawPoint", "(const QPointF&)", "#")]
		public void DrawPoint(QPointF pt) {
			ProxyQPainter().DrawPoint(pt);
		}
		[SmokeMethod("drawPoint", "(const QPoint&)", "#")]
		public void DrawPoint(QPoint p) {
			ProxyQPainter().DrawPoint(p);
		}
		[SmokeMethod("drawPoint", "(int, int)", "$$")]
		public void DrawPoint(int x, int y) {
			ProxyQPainter().DrawPoint(x,y);
		}
		[SmokeMethod("drawPoints", "(const QPointF*, int)", "#$")]
		public void DrawPoints(QPointF points, int pointCount) {
			ProxyQPainter().DrawPoints(points,pointCount);
		}
		[SmokeMethod("drawPoints", "(const QPolygonF&)", "#")]
		public void DrawPoints(QPolygonF points) {
			ProxyQPainter().DrawPoints(points);
		}
		[SmokeMethod("drawPoints", "(const QPoint*, int)", "#$")]
		public void DrawPoints(QPoint points, int pointCount) {
			ProxyQPainter().DrawPoints(points,pointCount);
		}
		[SmokeMethod("drawPoints", "(const QPolygon&)", "#")]
		public void DrawPoints(QPolygon points) {
			ProxyQPainter().DrawPoints(points);
		}
		[SmokeMethod("drawLine", "(const QLineF&)", "#")]
		public void DrawLine(QLineF line) {
			ProxyQPainter().DrawLine(line);
		}
		[SmokeMethod("drawLine", "(const QLine&)", "#")]
		public void DrawLine(QLine line) {
			ProxyQPainter().DrawLine(line);
		}
		[SmokeMethod("drawLine", "(int, int, int, int)", "$$$$")]
		public void DrawLine(int x1, int y1, int x2, int y2) {
			ProxyQPainter().DrawLine(x1,y1,x2,y2);
		}
		[SmokeMethod("drawLine", "(const QPoint&, const QPoint&)", "##")]
		public void DrawLine(QPoint p1, QPoint p2) {
			ProxyQPainter().DrawLine(p1,p2);
		}
		[SmokeMethod("drawLine", "(const QPointF&, const QPointF&)", "##")]
		public void DrawLine(QPointF p1, QPointF p2) {
			ProxyQPainter().DrawLine(p1,p2);
		}
		[SmokeMethod("drawLines", "(const QLineF*, int)", "#$")]
		public void DrawLines(QLineF lines, int lineCount) {
			ProxyQPainter().DrawLines(lines,lineCount);
		}
		[SmokeMethod("drawLines", "(const QVector<QLineF>&)", "?")]
		public void DrawLines(List<QLineF> lines) {
			ProxyQPainter().DrawLines(lines);
		}
		[SmokeMethod("drawLines", "(const QPointF*, int)", "#$")]
		public void DrawLines(QPointF pointPairs, int lineCount) {
			ProxyQPainter().DrawLines(pointPairs,lineCount);
		}
		[SmokeMethod("drawLines", "(const QVector<QPointF>&)", "?")]
		public void DrawLines(List<QPointF> pointPairs) {
			ProxyQPainter().DrawLines(pointPairs);
		}
		[SmokeMethod("drawLines", "(const QLine*, int)", "#$")]
		public void DrawLines(QLine lines, int lineCount) {
			ProxyQPainter().DrawLines(lines,lineCount);
		}
		[SmokeMethod("drawLines", "(const QVector<QLine>&)", "?")]
		public void DrawLines(List<QLine> lines) {
			ProxyQPainter().DrawLines(lines);
		}
		[SmokeMethod("drawLines", "(const QPoint*, int)", "#$")]
		public void DrawLines(QPoint pointPairs, int lineCount) {
			ProxyQPainter().DrawLines(pointPairs,lineCount);
		}
		[SmokeMethod("drawLines", "(const QVector<QPoint>&)", "?")]
		public void DrawLines(List<QPoint> pointPairs) {
			ProxyQPainter().DrawLines(pointPairs);
		}
		[SmokeMethod("drawRect", "(const QRectF&)", "#")]
		public void DrawRect(QRectF rect) {
			ProxyQPainter().DrawRect(rect);
		}
		[SmokeMethod("drawRect", "(int, int, int, int)", "$$$$")]
		public void DrawRect(int x1, int y1, int w, int h) {
			ProxyQPainter().DrawRect(x1,y1,w,h);
		}
		[SmokeMethod("drawRect", "(const QRect&)", "#")]
		public void DrawRect(QRect rect) {
			ProxyQPainter().DrawRect(rect);
		}
		[SmokeMethod("drawRects", "(const QRectF*, int)", "#$")]
		public void DrawRects(QRectF rects, int rectCount) {
			ProxyQPainter().DrawRects(rects,rectCount);
		}
		[SmokeMethod("drawRects", "(const QVector<QRectF>&)", "?")]
		public void DrawRects(List<QRectF> rectangles) {
			ProxyQPainter().DrawRects(rectangles);
		}
		[SmokeMethod("drawRects", "(const QRect*, int)", "#$")]
		public void DrawRects(QRect rects, int rectCount) {
			ProxyQPainter().DrawRects(rects,rectCount);
		}
		[SmokeMethod("drawRects", "(const QVector<QRect>&)", "?")]
		public void DrawRects(List<QRect> rectangles) {
			ProxyQPainter().DrawRects(rectangles);
		}
		[SmokeMethod("drawEllipse", "(const QRectF&)", "#")]
		public void DrawEllipse(QRectF r) {
			ProxyQPainter().DrawEllipse(r);
		}
		[SmokeMethod("drawEllipse", "(const QRect&)", "#")]
		public void DrawEllipse(QRect r) {
			ProxyQPainter().DrawEllipse(r);
		}
		[SmokeMethod("drawEllipse", "(int, int, int, int)", "$$$$")]
		public void DrawEllipse(int x, int y, int w, int h) {
			ProxyQPainter().DrawEllipse(x,y,w,h);
		}
		[SmokeMethod("drawPolyline", "(const QPointF*, int)", "#$")]
		public void DrawPolyline(QPointF points, int pointCount) {
			ProxyQPainter().DrawPolyline(points,pointCount);
		}
		[SmokeMethod("drawPolyline", "(const QPolygonF&)", "#")]
		public void DrawPolyline(QPolygonF polyline) {
			ProxyQPainter().DrawPolyline(polyline);
		}
		[SmokeMethod("drawPolyline", "(const QPoint*, int)", "#$")]
		public void DrawPolyline(QPoint points, int pointCount) {
			ProxyQPainter().DrawPolyline(points,pointCount);
		}
		[SmokeMethod("drawPolyline", "(const QPolygon&)", "#")]
		public void DrawPolyline(QPolygon polygon) {
			ProxyQPainter().DrawPolyline(polygon);
		}
		[SmokeMethod("drawPolygon", "(const QPointF*, int, Qt::FillRule)", "#$$")]
		public void DrawPolygon(QPointF points, int pointCount, Qt.FillRule fillRule) {
			ProxyQPainter().DrawPolygon(points,pointCount,fillRule);
		}
		[SmokeMethod("drawPolygon", "(const QPointF*, int)", "#$")]
		public void DrawPolygon(QPointF points, int pointCount) {
			ProxyQPainter().DrawPolygon(points,pointCount);
		}
		[SmokeMethod("drawPolygon", "(const QPolygonF&, Qt::FillRule)", "#$")]
		public void DrawPolygon(QPolygonF polygon, Qt.FillRule fillRule) {
			ProxyQPainter().DrawPolygon(polygon,fillRule);
		}
		[SmokeMethod("drawPolygon", "(const QPolygonF&)", "#")]
		public void DrawPolygon(QPolygonF polygon) {
			ProxyQPainter().DrawPolygon(polygon);
		}
		[SmokeMethod("drawPolygon", "(const QPoint*, int, Qt::FillRule)", "#$$")]
		public void DrawPolygon(QPoint points, int pointCount, Qt.FillRule fillRule) {
			ProxyQPainter().DrawPolygon(points,pointCount,fillRule);
		}
		[SmokeMethod("drawPolygon", "(const QPoint*, int)", "#$")]
		public void DrawPolygon(QPoint points, int pointCount) {
			ProxyQPainter().DrawPolygon(points,pointCount);
		}
		[SmokeMethod("drawPolygon", "(const QPolygon&, Qt::FillRule)", "#$")]
		public void DrawPolygon(QPolygon polygon, Qt.FillRule fillRule) {
			ProxyQPainter().DrawPolygon(polygon,fillRule);
		}
		[SmokeMethod("drawPolygon", "(const QPolygon&)", "#")]
		public void DrawPolygon(QPolygon polygon) {
			ProxyQPainter().DrawPolygon(polygon);
		}
		[SmokeMethod("drawConvexPolygon", "(const QPointF*, int)", "#$")]
		public void DrawConvexPolygon(QPointF points, int pointCount) {
			ProxyQPainter().DrawConvexPolygon(points,pointCount);
		}
		[SmokeMethod("drawConvexPolygon", "(const QPolygonF&)", "#")]
		public void DrawConvexPolygon(QPolygonF polygon) {
			ProxyQPainter().DrawConvexPolygon(polygon);
		}
		[SmokeMethod("drawConvexPolygon", "(const QPoint*, int)", "#$")]
		public void DrawConvexPolygon(QPoint points, int pointCount) {
			ProxyQPainter().DrawConvexPolygon(points,pointCount);
		}
		[SmokeMethod("drawConvexPolygon", "(const QPolygon&)", "#")]
		public void DrawConvexPolygon(QPolygon polygon) {
			ProxyQPainter().DrawConvexPolygon(polygon);
		}
		[SmokeMethod("drawArc", "(const QRectF&, int, int)", "#$$")]
		public void DrawArc(QRectF rect, int a, int alen) {
			ProxyQPainter().DrawArc(rect,a,alen);
		}
		[SmokeMethod("drawArc", "(const QRect&, int, int)", "#$$")]
		public void DrawArc(QRect arg1, int a, int alen) {
			ProxyQPainter().DrawArc(arg1,a,alen);
		}
		[SmokeMethod("drawArc", "(int, int, int, int, int, int)", "$$$$$$")]
		public void DrawArc(int x, int y, int w, int h, int a, int alen) {
			ProxyQPainter().DrawArc(x,y,w,h,a,alen);
		}
		[SmokeMethod("drawPie", "(const QRectF&, int, int)", "#$$")]
		public void DrawPie(QRectF rect, int a, int alen) {
			ProxyQPainter().DrawPie(rect,a,alen);
		}
		[SmokeMethod("drawPie", "(int, int, int, int, int, int)", "$$$$$$")]
		public void DrawPie(int x, int y, int w, int h, int a, int alen) {
			ProxyQPainter().DrawPie(x,y,w,h,a,alen);
		}
		[SmokeMethod("drawPie", "(const QRect&, int, int)", "#$$")]
		public void DrawPie(QRect arg1, int a, int alen) {
			ProxyQPainter().DrawPie(arg1,a,alen);
		}
		[SmokeMethod("drawChord", "(const QRectF&, int, int)", "#$$")]
		public void DrawChord(QRectF rect, int a, int alen) {
			ProxyQPainter().DrawChord(rect,a,alen);
		}
		[SmokeMethod("drawChord", "(int, int, int, int, int, int)", "$$$$$$")]
		public void DrawChord(int x, int y, int w, int h, int a, int alen) {
			ProxyQPainter().DrawChord(x,y,w,h,a,alen);
		}
		[SmokeMethod("drawChord", "(const QRect&, int, int)", "#$$")]
		public void DrawChord(QRect arg1, int a, int alen) {
			ProxyQPainter().DrawChord(arg1,a,alen);
		}
		[SmokeMethod("drawRoundRect", "(const QRectF&, int, int)", "#$$")]
		public void DrawRoundRect(QRectF r, int xround, int yround) {
			ProxyQPainter().DrawRoundRect(r,xround,yround);
		}
		[SmokeMethod("drawRoundRect", "(const QRectF&, int)", "#$")]
		public void DrawRoundRect(QRectF r, int xround) {
			ProxyQPainter().DrawRoundRect(r,xround);
		}
		[SmokeMethod("drawRoundRect", "(const QRectF&)", "#")]
		public void DrawRoundRect(QRectF r) {
			ProxyQPainter().DrawRoundRect(r);
		}
		[SmokeMethod("drawRoundRect", "(int, int, int, int, int, int)", "$$$$$$")]
		public void DrawRoundRect(int x, int y, int w, int h, int arg5, int arg6) {
			ProxyQPainter().DrawRoundRect(x,y,w,h,arg5,arg6);
		}
		[SmokeMethod("drawRoundRect", "(int, int, int, int, int)", "$$$$$")]
		public void DrawRoundRect(int x, int y, int w, int h, int arg5) {
			ProxyQPainter().DrawRoundRect(x,y,w,h,arg5);
		}
		[SmokeMethod("drawRoundRect", "(int, int, int, int)", "$$$$")]
		public void DrawRoundRect(int x, int y, int w, int h) {
			ProxyQPainter().DrawRoundRect(x,y,w,h);
		}
		[SmokeMethod("drawRoundRect", "(const QRect&, int, int)", "#$$")]
		public void DrawRoundRect(QRect r, int xround, int yround) {
			ProxyQPainter().DrawRoundRect(r,xround,yround);
		}
		[SmokeMethod("drawRoundRect", "(const QRect&, int)", "#$")]
		public void DrawRoundRect(QRect r, int xround) {
			ProxyQPainter().DrawRoundRect(r,xround);
		}
		[SmokeMethod("drawRoundRect", "(const QRect&)", "#")]
		public void DrawRoundRect(QRect r) {
			ProxyQPainter().DrawRoundRect(r);
		}
		[SmokeMethod("drawTiledPixmap", "(const QRectF&, const QPixmap&, const QPointF&)", "###")]
		public void DrawTiledPixmap(QRectF rect, QPixmap pm, QPointF offset) {
			ProxyQPainter().DrawTiledPixmap(rect,pm,offset);
		}
		[SmokeMethod("drawTiledPixmap", "(const QRectF&, const QPixmap&)", "##")]
		public void DrawTiledPixmap(QRectF rect, QPixmap pm) {
			ProxyQPainter().DrawTiledPixmap(rect,pm);
		}
		[SmokeMethod("drawTiledPixmap", "(int, int, int, int, const QPixmap&, int, int)", "$$$$#$$")]
		public void DrawTiledPixmap(int x, int y, int w, int h, QPixmap arg5, int sx, int sy) {
			ProxyQPainter().DrawTiledPixmap(x,y,w,h,arg5,sx,sy);
		}
		[SmokeMethod("drawTiledPixmap", "(int, int, int, int, const QPixmap&, int)", "$$$$#$")]
		public void DrawTiledPixmap(int x, int y, int w, int h, QPixmap arg5, int sx) {
			ProxyQPainter().DrawTiledPixmap(x,y,w,h,arg5,sx);
		}
		[SmokeMethod("drawTiledPixmap", "(int, int, int, int, const QPixmap&)", "$$$$#")]
		public void DrawTiledPixmap(int x, int y, int w, int h, QPixmap arg5) {
			ProxyQPainter().DrawTiledPixmap(x,y,w,h,arg5);
		}
		[SmokeMethod("drawTiledPixmap", "(const QRect&, const QPixmap&, const QPoint&)", "###")]
		public void DrawTiledPixmap(QRect arg1, QPixmap arg2, QPoint arg3) {
			ProxyQPainter().DrawTiledPixmap(arg1,arg2,arg3);
		}
		[SmokeMethod("drawTiledPixmap", "(const QRect&, const QPixmap&)", "##")]
		public void DrawTiledPixmap(QRect arg1, QPixmap arg2) {
			ProxyQPainter().DrawTiledPixmap(arg1,arg2);
		}
		[SmokeMethod("drawPicture", "(const QPointF&, const QPicture&)", "##")]
		public void DrawPicture(QPointF p, QPicture picture) {
			ProxyQPainter().DrawPicture(p,picture);
		}
		[SmokeMethod("drawPicture", "(int, int, const QPicture&)", "$$#")]
		public void DrawPicture(int x, int y, QPicture picture) {
			ProxyQPainter().DrawPicture(x,y,picture);
		}
		[SmokeMethod("drawPicture", "(const QPoint&, const QPicture&)", "##")]
		public void DrawPicture(QPoint p, QPicture picture) {
			ProxyQPainter().DrawPicture(p,picture);
		}
		[SmokeMethod("drawPixmap", "(const QRectF&, const QPixmap&, const QRectF&)", "###")]
		public void DrawPixmap(QRectF targetRect, QPixmap pixmap, QRectF sourceRect) {
			ProxyQPainter().DrawPixmap(targetRect,pixmap,sourceRect);
		}
		[SmokeMethod("drawPixmap", "(const QRect&, const QPixmap&, const QRect&)", "###")]
		public void DrawPixmap(QRect targetRect, QPixmap pixmap, QRect sourceRect) {
			ProxyQPainter().DrawPixmap(targetRect,pixmap,sourceRect);
		}
		[SmokeMethod("drawPixmap", "(int, int, int, int, const QPixmap&, int, int, int, int)", "$$$$#$$$$")]
		public void DrawPixmap(int x, int y, int w, int h, QPixmap pm, int sx, int sy, int sw, int sh) {
			ProxyQPainter().DrawPixmap(x,y,w,h,pm,sx,sy,sw,sh);
		}
		[SmokeMethod("drawPixmap", "(int, int, const QPixmap&, int, int, int, int)", "$$#$$$$")]
		public void DrawPixmap(int x, int y, QPixmap pm, int sx, int sy, int sw, int sh) {
			ProxyQPainter().DrawPixmap(x,y,pm,sx,sy,sw,sh);
		}
		[SmokeMethod("drawPixmap", "(const QPointF&, const QPixmap&, const QRectF&)", "###")]
		public void DrawPixmap(QPointF p, QPixmap pm, QRectF sr) {
			ProxyQPainter().DrawPixmap(p,pm,sr);
		}
		[SmokeMethod("drawPixmap", "(const QPoint&, const QPixmap&, const QRect&)", "###")]
		public void DrawPixmap(QPoint p, QPixmap pm, QRect sr) {
			ProxyQPainter().DrawPixmap(p,pm,sr);
		}
		[SmokeMethod("drawPixmap", "(const QPointF&, const QPixmap&)", "##")]
		public void DrawPixmap(QPointF p, QPixmap pm) {
			ProxyQPainter().DrawPixmap(p,pm);
		}
		[SmokeMethod("drawPixmap", "(const QPoint&, const QPixmap&)", "##")]
		public void DrawPixmap(QPoint p, QPixmap pm) {
			ProxyQPainter().DrawPixmap(p,pm);
		}
		[SmokeMethod("drawPixmap", "(int, int, const QPixmap&)", "$$#")]
		public void DrawPixmap(int x, int y, QPixmap pm) {
			ProxyQPainter().DrawPixmap(x,y,pm);
		}
		[SmokeMethod("drawPixmap", "(const QRect&, const QPixmap&)", "##")]
		public void DrawPixmap(QRect r, QPixmap pm) {
			ProxyQPainter().DrawPixmap(r,pm);
		}
		[SmokeMethod("drawPixmap", "(int, int, int, int, const QPixmap&)", "$$$$#")]
		public void DrawPixmap(int x, int y, int w, int h, QPixmap pm) {
			ProxyQPainter().DrawPixmap(x,y,w,h,pm);
		}
		[SmokeMethod("drawImage", "(const QRectF&, const QImage&, const QRectF&, Qt::ImageConversionFlags)", "###$")]
		public void DrawImage(QRectF targetRect, QImage image, QRectF sourceRect, int flags) {
			ProxyQPainter().DrawImage(targetRect,image,sourceRect,flags);
		}
		[SmokeMethod("drawImage", "(const QRectF&, const QImage&, const QRectF&)", "###")]
		public void DrawImage(QRectF targetRect, QImage image, QRectF sourceRect) {
			ProxyQPainter().DrawImage(targetRect,image,sourceRect);
		}
		[SmokeMethod("drawImage", "(const QRect&, const QImage&, const QRect&, Qt::ImageConversionFlags)", "###$")]
		public void DrawImage(QRect targetRect, QImage image, QRect sourceRect, int flags) {
			ProxyQPainter().DrawImage(targetRect,image,sourceRect,flags);
		}
		[SmokeMethod("drawImage", "(const QRect&, const QImage&, const QRect&)", "###")]
		public void DrawImage(QRect targetRect, QImage image, QRect sourceRect) {
			ProxyQPainter().DrawImage(targetRect,image,sourceRect);
		}
		[SmokeMethod("drawImage", "(const QPointF&, const QImage&, const QRectF&, Qt::ImageConversionFlags)", "###$")]
		public void DrawImage(QPointF p, QImage image, QRectF sr, int flags) {
			ProxyQPainter().DrawImage(p,image,sr,flags);
		}
		[SmokeMethod("drawImage", "(const QPointF&, const QImage&, const QRectF&)", "###")]
		public void DrawImage(QPointF p, QImage image, QRectF sr) {
			ProxyQPainter().DrawImage(p,image,sr);
		}
		[SmokeMethod("drawImage", "(const QPoint&, const QImage&, const QRect&, Qt::ImageConversionFlags)", "###$")]
		public void DrawImage(QPoint p, QImage image, QRect sr, int flags) {
			ProxyQPainter().DrawImage(p,image,sr,flags);
		}
		[SmokeMethod("drawImage", "(const QPoint&, const QImage&, const QRect&)", "###")]
		public void DrawImage(QPoint p, QImage image, QRect sr) {
			ProxyQPainter().DrawImage(p,image,sr);
		}
		[SmokeMethod("drawImage", "(const QRectF&, const QImage&)", "##")]
		public void DrawImage(QRectF r, QImage image) {
			ProxyQPainter().DrawImage(r,image);
		}
		[SmokeMethod("drawImage", "(const QRect&, const QImage&)", "##")]
		public void DrawImage(QRect r, QImage image) {
			ProxyQPainter().DrawImage(r,image);
		}
		[SmokeMethod("drawImage", "(const QPointF&, const QImage&)", "##")]
		public void DrawImage(QPointF p, QImage image) {
			ProxyQPainter().DrawImage(p,image);
		}
		[SmokeMethod("drawImage", "(const QPoint&, const QImage&)", "##")]
		public void DrawImage(QPoint p, QImage image) {
			ProxyQPainter().DrawImage(p,image);
		}
		[SmokeMethod("drawImage", "(int, int, const QImage&, int, int, int, int, Qt::ImageConversionFlags)", "$$#$$$$$")]
		public void DrawImage(int x, int y, QImage image, int sx, int sy, int sw, int sh, int flags) {
			ProxyQPainter().DrawImage(x,y,image,sx,sy,sw,sh,flags);
		}
		[SmokeMethod("drawImage", "(int, int, const QImage&, int, int, int, int)", "$$#$$$$")]
		public void DrawImage(int x, int y, QImage image, int sx, int sy, int sw, int sh) {
			ProxyQPainter().DrawImage(x,y,image,sx,sy,sw,sh);
		}
		[SmokeMethod("drawImage", "(int, int, const QImage&, int, int, int)", "$$#$$$")]
		public void DrawImage(int x, int y, QImage image, int sx, int sy, int sw) {
			ProxyQPainter().DrawImage(x,y,image,sx,sy,sw);
		}
		[SmokeMethod("drawImage", "(int, int, const QImage&, int, int)", "$$#$$")]
		public void DrawImage(int x, int y, QImage image, int sx, int sy) {
			ProxyQPainter().DrawImage(x,y,image,sx,sy);
		}
		[SmokeMethod("drawImage", "(int, int, const QImage&, int)", "$$#$")]
		public void DrawImage(int x, int y, QImage image, int sx) {
			ProxyQPainter().DrawImage(x,y,image,sx);
		}
		[SmokeMethod("drawImage", "(int, int, const QImage&)", "$$#")]
		public void DrawImage(int x, int y, QImage image) {
			ProxyQPainter().DrawImage(x,y,image);
		}
		[SmokeMethod("setLayoutDirection", "(Qt::LayoutDirection)", "$")]
		public void SetLayoutDirection(Qt.LayoutDirection direction) {
			ProxyQPainter().SetLayoutDirection(direction);
		}
		[SmokeMethod("layoutDirection", "() const", "")]
		public Qt.LayoutDirection LayoutDirection() {
			return ProxyQPainter().LayoutDirection();
		}
		[SmokeMethod("drawText", "(const QPointF&, const QString&)", "#$")]
		public void DrawText(QPointF p, string s) {
			ProxyQPainter().DrawText(p,s);
		}
		[SmokeMethod("drawText", "(const QPoint&, const QString&)", "#$")]
		public void DrawText(QPoint p, string s) {
			ProxyQPainter().DrawText(p,s);
		}
		[SmokeMethod("drawText", "(int, int, const QString&)", "$$$")]
		public void DrawText(int x, int y, string s) {
			ProxyQPainter().DrawText(x,y,s);
		}
		[SmokeMethod("drawText", "(const QRectF&, int, const QString&, QRectF*)", "#$$#")]
		public void DrawText(QRectF r, int flags, string text, QRectF br) {
			ProxyQPainter().DrawText(r,flags,text,br);
		}
		[SmokeMethod("drawText", "(const QRectF&, int, const QString&)", "#$$")]
		public void DrawText(QRectF r, int flags, string text) {
			ProxyQPainter().DrawText(r,flags,text);
		}
		[SmokeMethod("drawText", "(const QRect&, int, const QString&, QRect*)", "#$$#")]
		public void DrawText(QRect r, int flags, string text, QRect br) {
			ProxyQPainter().DrawText(r,flags,text,br);
		}
		[SmokeMethod("drawText", "(const QRect&, int, const QString&)", "#$$")]
		public void DrawText(QRect r, int flags, string text) {
			ProxyQPainter().DrawText(r,flags,text);
		}
		[SmokeMethod("drawText", "(int, int, int, int, int, const QString&, QRect*)", "$$$$$$#")]
		public void DrawText(int x, int y, int w, int h, int flags, string text, QRect br) {
			ProxyQPainter().DrawText(x,y,w,h,flags,text,br);
		}
		[SmokeMethod("drawText", "(int, int, int, int, int, const QString&)", "$$$$$$")]
		public void DrawText(int x, int y, int w, int h, int flags, string text) {
			ProxyQPainter().DrawText(x,y,w,h,flags,text);
		}
		[SmokeMethod("drawText", "(const QRectF&, const QString&, const QTextOption&)", "#$#")]
		public void DrawText(QRectF r, string text, QTextOption o) {
			ProxyQPainter().DrawText(r,text,o);
		}
		[SmokeMethod("drawText", "(const QRectF&, const QString&)", "#$")]
		public void DrawText(QRectF r, string text) {
			ProxyQPainter().DrawText(r,text);
		}
		[SmokeMethod("boundingRect", "(const QRectF&, int, const QString&)", "#$$")]
		public QRectF BoundingRect(QRectF rect, int flags, string text) {
			return ProxyQPainter().BoundingRect(rect,flags,text);
		}
		[SmokeMethod("boundingRect", "(const QRect&, int, const QString&)", "#$$")]
		public QRect BoundingRect(QRect rect, int flags, string text) {
			return ProxyQPainter().BoundingRect(rect,flags,text);
		}
		[SmokeMethod("boundingRect", "(int, int, int, int, int, const QString&)", "$$$$$$")]
		public QRect BoundingRect(int x, int y, int w, int h, int flags, string text) {
			return ProxyQPainter().BoundingRect(x,y,w,h,flags,text);
		}
		[SmokeMethod("boundingRect", "(const QRectF&, const QString&, const QTextOption&)", "#$#")]
		public QRectF BoundingRect(QRectF rect, string text, QTextOption o) {
			return ProxyQPainter().BoundingRect(rect,text,o);
		}
		[SmokeMethod("boundingRect", "(const QRectF&, const QString&)", "#$")]
		public QRectF BoundingRect(QRectF rect, string text) {
			return ProxyQPainter().BoundingRect(rect,text);
		}
		[SmokeMethod("fillRect", "(const QRectF&, const QBrush&)", "##")]
		public void FillRect(QRectF arg1, QBrush arg2) {
			ProxyQPainter().FillRect(arg1,arg2);
		}
		[SmokeMethod("fillRect", "(int, int, int, int, const QBrush&)", "$$$$#")]
		public void FillRect(int x, int y, int w, int h, QBrush arg5) {
			ProxyQPainter().FillRect(x,y,w,h,arg5);
		}
		[SmokeMethod("fillRect", "(const QRect&, const QBrush&)", "##")]
		public void FillRect(QRect arg1, QBrush arg2) {
			ProxyQPainter().FillRect(arg1,arg2);
		}
		[SmokeMethod("eraseRect", "(const QRectF&)", "#")]
		public void EraseRect(QRectF arg1) {
			ProxyQPainter().EraseRect(arg1);
		}
		[SmokeMethod("eraseRect", "(int, int, int, int)", "$$$$")]
		public void EraseRect(int x, int y, int w, int h) {
			ProxyQPainter().EraseRect(x,y,w,h);
		}
		[SmokeMethod("eraseRect", "(const QRect&)", "#")]
		public void EraseRect(QRect arg1) {
			ProxyQPainter().EraseRect(arg1);
		}
		[SmokeMethod("setRenderHint", "(QPainter::RenderHint, bool)", "$$")]
		public void SetRenderHint(QPainter.RenderHint hint, bool on) {
			ProxyQPainter().SetRenderHint(hint,on);
		}
		[SmokeMethod("setRenderHint", "(QPainter::RenderHint)", "$")]
		public void SetRenderHint(QPainter.RenderHint hint) {
			ProxyQPainter().SetRenderHint(hint);
		}
		[SmokeMethod("setRenderHints", "(RenderHints, bool)", "$$")]
		public void SetRenderHints(int hints, bool on) {
			ProxyQPainter().SetRenderHints(hints,on);
		}
		[SmokeMethod("setRenderHints", "(RenderHints)", "$")]
		public void SetRenderHints(int hints) {
			ProxyQPainter().SetRenderHints(hints);
		}
		[SmokeMethod("renderHints", "() const", "")]
		public int RenderHints() {
			return ProxyQPainter().RenderHints();
		}
		[SmokeMethod("paintEngine", "() const", "")]
		public QPaintEngine PaintEngine() {
			return ProxyQPainter().PaintEngine();
		}
		public static void SetRedirected(IQPaintDevice device, IQPaintDevice replacement, QPoint offset) {
			StaticQPainter().SetRedirected(device,replacement,offset);
		}
		public static void SetRedirected(IQPaintDevice device, IQPaintDevice replacement) {
			StaticQPainter().SetRedirected(device,replacement);
		}
		public static IQPaintDevice Redirected(IQPaintDevice device, QPoint offset) {
			return StaticQPainter().Redirected(device,offset);
		}
		public static IQPaintDevice Redirected(IQPaintDevice device) {
			return StaticQPainter().Redirected(device);
		}
		public static void RestoreRedirected(IQPaintDevice device) {
			StaticQPainter().RestoreRedirected(device);
		}
		~QPainter() {
			DisposeQPainter();
		}
		public void Dispose() {
			DisposeQPainter();
		}
		[SmokeMethod("~QPainter", "()", "")]
		private void DisposeQPainter() {
			ProxyQPainter().DisposeQPainter();
		}
	}
}
