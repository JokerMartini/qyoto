//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QPainterPath")]
	public class QPainterPath : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QPainterPath(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QPainterPath), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QPainterPath() {
			staticInterceptor = new SmokeInvocation(typeof(QPainterPath), null);
		}
		public enum ElementType {
			MoveToElement = 0,
			LineToElement = 1,
			CurveToElement = 2,
			CurveToDataElement = 3,
		}
		// const QPainterPath::Element& elementAt(int arg1); >>>> NOT CONVERTED
		public QPainterPath() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QPainterPath", "QPainterPath()", typeof(void));
		}
		public QPainterPath(QPointF startPoint) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QPainterPath#", "QPainterPath(const QPointF&)", typeof(void), typeof(QPointF), startPoint);
		}
		public QPainterPath(QPainterPath other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QPainterPath#", "QPainterPath(const QPainterPath&)", typeof(void), typeof(QPainterPath), other);
		}
		public void CloseSubpath() {
			interceptor.Invoke("closeSubpath", "closeSubpath()", typeof(void));
		}
		public void MoveTo(QPointF p) {
			interceptor.Invoke("moveTo#", "moveTo(const QPointF&)", typeof(void), typeof(QPointF), p);
		}
		public void MoveTo(double x, double y) {
			interceptor.Invoke("moveTo$$", "moveTo(qreal, qreal)", typeof(void), typeof(double), x, typeof(double), y);
		}
		public void LineTo(QPointF p) {
			interceptor.Invoke("lineTo#", "lineTo(const QPointF&)", typeof(void), typeof(QPointF), p);
		}
		public void LineTo(double x, double y) {
			interceptor.Invoke("lineTo$$", "lineTo(qreal, qreal)", typeof(void), typeof(double), x, typeof(double), y);
		}
		public void ArcMoveTo(QRectF rect, double angle) {
			interceptor.Invoke("arcMoveTo#$", "arcMoveTo(const QRectF&, qreal)", typeof(void), typeof(QRectF), rect, typeof(double), angle);
		}
		public void ArcMoveTo(double x, double y, double w, double h, double angle) {
			interceptor.Invoke("arcMoveTo$$$$$", "arcMoveTo(qreal, qreal, qreal, qreal, qreal)", typeof(void), typeof(double), x, typeof(double), y, typeof(double), w, typeof(double), h, typeof(double), angle);
		}
		public void ArcTo(QRectF rect, double startAngle, double arcLength) {
			interceptor.Invoke("arcTo#$$", "arcTo(const QRectF&, qreal, qreal)", typeof(void), typeof(QRectF), rect, typeof(double), startAngle, typeof(double), arcLength);
		}
		public void ArcTo(double x, double y, double w, double h, double startAngle, double arcLength) {
			interceptor.Invoke("arcTo$$$$$$", "arcTo(qreal, qreal, qreal, qreal, qreal, qreal)", typeof(void), typeof(double), x, typeof(double), y, typeof(double), w, typeof(double), h, typeof(double), startAngle, typeof(double), arcLength);
		}
		public void CubicTo(QPointF ctrlPt1, QPointF ctrlPt2, QPointF endPt) {
			interceptor.Invoke("cubicTo###", "cubicTo(const QPointF&, const QPointF&, const QPointF&)", typeof(void), typeof(QPointF), ctrlPt1, typeof(QPointF), ctrlPt2, typeof(QPointF), endPt);
		}
		public void CubicTo(double ctrlPt1x, double ctrlPt1y, double ctrlPt2x, double ctrlPt2y, double endPtx, double endPty) {
			interceptor.Invoke("cubicTo$$$$$$", "cubicTo(qreal, qreal, qreal, qreal, qreal, qreal)", typeof(void), typeof(double), ctrlPt1x, typeof(double), ctrlPt1y, typeof(double), ctrlPt2x, typeof(double), ctrlPt2y, typeof(double), endPtx, typeof(double), endPty);
		}
		public void QuadTo(QPointF ctrlPt, QPointF endPt) {
			interceptor.Invoke("quadTo##", "quadTo(const QPointF&, const QPointF&)", typeof(void), typeof(QPointF), ctrlPt, typeof(QPointF), endPt);
		}
		public void QuadTo(double ctrlPtx, double ctrlPty, double endPtx, double endPty) {
			interceptor.Invoke("quadTo$$$$", "quadTo(qreal, qreal, qreal, qreal)", typeof(void), typeof(double), ctrlPtx, typeof(double), ctrlPty, typeof(double), endPtx, typeof(double), endPty);
		}
		public QPointF CurrentPosition() {
			return (QPointF) interceptor.Invoke("currentPosition", "currentPosition() const", typeof(QPointF));
		}
		public void AddRect(QRectF rect) {
			interceptor.Invoke("addRect#", "addRect(const QRectF&)", typeof(void), typeof(QRectF), rect);
		}
		public void AddRect(double x, double y, double w, double h) {
			interceptor.Invoke("addRect$$$$", "addRect(qreal, qreal, qreal, qreal)", typeof(void), typeof(double), x, typeof(double), y, typeof(double), w, typeof(double), h);
		}
		public void AddEllipse(QRectF rect) {
			interceptor.Invoke("addEllipse#", "addEllipse(const QRectF&)", typeof(void), typeof(QRectF), rect);
		}
		public void AddEllipse(double x, double y, double w, double h) {
			interceptor.Invoke("addEllipse$$$$", "addEllipse(qreal, qreal, qreal, qreal)", typeof(void), typeof(double), x, typeof(double), y, typeof(double), w, typeof(double), h);
		}
		public void AddPolygon(QPolygonF polygon) {
			interceptor.Invoke("addPolygon#", "addPolygon(const QPolygonF&)", typeof(void), typeof(QPolygonF), polygon);
		}
		public void AddText(QPointF point, QFont f, string text) {
			interceptor.Invoke("addText##$", "addText(const QPointF&, const QFont&, const QString&)", typeof(void), typeof(QPointF), point, typeof(QFont), f, typeof(string), text);
		}
		public void AddText(double x, double y, QFont f, string text) {
			interceptor.Invoke("addText$$#$", "addText(qreal, qreal, const QFont&, const QString&)", typeof(void), typeof(double), x, typeof(double), y, typeof(QFont), f, typeof(string), text);
		}
		public void AddPath(QPainterPath path) {
			interceptor.Invoke("addPath#", "addPath(const QPainterPath&)", typeof(void), typeof(QPainterPath), path);
		}
		public void AddRegion(QRegion region) {
			interceptor.Invoke("addRegion#", "addRegion(const QRegion&)", typeof(void), typeof(QRegion), region);
		}
		public void AddRoundRect(QRectF rect, int xRnd, int yRnd) {
			interceptor.Invoke("addRoundRect#$$", "addRoundRect(const QRectF&, int, int)", typeof(void), typeof(QRectF), rect, typeof(int), xRnd, typeof(int), yRnd);
		}
		public void AddRoundRect(double x, double y, double w, double h, int xRnd, int yRnd) {
			interceptor.Invoke("addRoundRect$$$$$$", "addRoundRect(qreal, qreal, qreal, qreal, int, int)", typeof(void), typeof(double), x, typeof(double), y, typeof(double), w, typeof(double), h, typeof(int), xRnd, typeof(int), yRnd);
		}
		public void AddRoundRect(QRectF rect, int roundness) {
			interceptor.Invoke("addRoundRect#$", "addRoundRect(const QRectF&, int)", typeof(void), typeof(QRectF), rect, typeof(int), roundness);
		}
		public void AddRoundRect(double x, double y, double w, double h, int roundness) {
			interceptor.Invoke("addRoundRect$$$$$", "addRoundRect(qreal, qreal, qreal, qreal, int)", typeof(void), typeof(double), x, typeof(double), y, typeof(double), w, typeof(double), h, typeof(int), roundness);
		}
		public void ConnectPath(QPainterPath path) {
			interceptor.Invoke("connectPath#", "connectPath(const QPainterPath&)", typeof(void), typeof(QPainterPath), path);
		}
		public bool Contains(QPointF pt) {
			return (bool) interceptor.Invoke("contains#", "contains(const QPointF&) const", typeof(bool), typeof(QPointF), pt);
		}
		public bool Contains(QRectF rect) {
			return (bool) interceptor.Invoke("contains#", "contains(const QRectF&) const", typeof(bool), typeof(QRectF), rect);
		}
		public bool Intersects(QRectF rect) {
			return (bool) interceptor.Invoke("intersects#", "intersects(const QRectF&) const", typeof(bool), typeof(QRectF), rect);
		}
		public QRectF BoundingRect() {
			return (QRectF) interceptor.Invoke("boundingRect", "boundingRect() const", typeof(QRectF));
		}
		public QRectF ControlPointRect() {
			return (QRectF) interceptor.Invoke("controlPointRect", "controlPointRect() const", typeof(QRectF));
		}
		public Qt.FillRule FillRule() {
			return (Qt.FillRule) interceptor.Invoke("fillRule", "fillRule() const", typeof(Qt.FillRule));
		}
		public void SetFillRule(Qt.FillRule fillRule) {
			interceptor.Invoke("setFillRule$", "setFillRule(Qt::FillRule)", typeof(void), typeof(Qt.FillRule), fillRule);
		}
		public bool IsEmpty() {
			return (bool) interceptor.Invoke("isEmpty", "isEmpty() const", typeof(bool));
		}
		public QPainterPath ToReversed() {
			return (QPainterPath) interceptor.Invoke("toReversed", "toReversed() const", typeof(QPainterPath));
		}
		public List<QPolygonF> ToSubpathPolygons(QMatrix matrix) {
			return (List<QPolygonF>) interceptor.Invoke("toSubpathPolygons#", "toSubpathPolygons(const QMatrix&) const", typeof(List<QPolygonF>), typeof(QMatrix), matrix);
		}
		public List<QPolygonF> ToSubpathPolygons() {
			return (List<QPolygonF>) interceptor.Invoke("toSubpathPolygons", "toSubpathPolygons() const", typeof(List<QPolygonF>));
		}
		public List<QPolygonF> ToFillPolygons(QMatrix matrix) {
			return (List<QPolygonF>) interceptor.Invoke("toFillPolygons#", "toFillPolygons(const QMatrix&) const", typeof(List<QPolygonF>), typeof(QMatrix), matrix);
		}
		public List<QPolygonF> ToFillPolygons() {
			return (List<QPolygonF>) interceptor.Invoke("toFillPolygons", "toFillPolygons() const", typeof(List<QPolygonF>));
		}
		public QPolygonF ToFillPolygon(QMatrix matrix) {
			return (QPolygonF) interceptor.Invoke("toFillPolygon#", "toFillPolygon(const QMatrix&) const", typeof(QPolygonF), typeof(QMatrix), matrix);
		}
		public QPolygonF ToFillPolygon() {
			return (QPolygonF) interceptor.Invoke("toFillPolygon", "toFillPolygon() const", typeof(QPolygonF));
		}
		public List<QPolygonF> ToSubpathPolygons(QTransform matrix) {
			return (List<QPolygonF>) interceptor.Invoke("toSubpathPolygons#", "toSubpathPolygons(const QTransform&) const", typeof(List<QPolygonF>), typeof(QTransform), matrix);
		}
		public List<QPolygonF> ToFillPolygons(QTransform matrix) {
			return (List<QPolygonF>) interceptor.Invoke("toFillPolygons#", "toFillPolygons(const QTransform&) const", typeof(List<QPolygonF>), typeof(QTransform), matrix);
		}
		public QPolygonF ToFillPolygon(QTransform matrix) {
			return (QPolygonF) interceptor.Invoke("toFillPolygon#", "toFillPolygon(const QTransform&) const", typeof(QPolygonF), typeof(QTransform), matrix);
		}
		public int ElementCount() {
			return (int) interceptor.Invoke("elementCount", "elementCount() const", typeof(int));
		}
		public void SetElementPositionAt(int i, double x, double y) {
			interceptor.Invoke("setElementPositionAt$$$", "setElementPositionAt(int, qreal, qreal)", typeof(void), typeof(int), i, typeof(double), x, typeof(double), y);
		}
		public double Length() {
			return (double) interceptor.Invoke("length", "length() const", typeof(double));
		}
		public double PercentAtLength(double t) {
			return (double) interceptor.Invoke("percentAtLength$", "percentAtLength(qreal) const", typeof(double), typeof(double), t);
		}
		public QPointF PointAtPercent(double t) {
			return (QPointF) interceptor.Invoke("pointAtPercent$", "pointAtPercent(qreal) const", typeof(QPointF), typeof(double), t);
		}
		public double AngleAtPercent(double t) {
			return (double) interceptor.Invoke("angleAtPercent$", "angleAtPercent(qreal) const", typeof(double), typeof(double), t);
		}
		public double SlopeAtPercent(double t) {
			return (double) interceptor.Invoke("slopeAtPercent$", "slopeAtPercent(qreal) const", typeof(double), typeof(double), t);
		}
		public bool Intersects(QPainterPath p) {
			return (bool) interceptor.Invoke("intersects#", "intersects(const QPainterPath&) const", typeof(bool), typeof(QPainterPath), p);
		}
		public bool Contains(QPainterPath p) {
			return (bool) interceptor.Invoke("contains#", "contains(const QPainterPath&) const", typeof(bool), typeof(QPainterPath), p);
		}
		public QPainterPath United(QPainterPath r) {
			return (QPainterPath) interceptor.Invoke("united#", "united(const QPainterPath&) const", typeof(QPainterPath), typeof(QPainterPath), r);
		}
		public QPainterPath Intersected(QPainterPath r) {
			return (QPainterPath) interceptor.Invoke("intersected#", "intersected(const QPainterPath&) const", typeof(QPainterPath), typeof(QPainterPath), r);
		}
		public QPainterPath Subtracted(QPainterPath r) {
			return (QPainterPath) interceptor.Invoke("subtracted#", "subtracted(const QPainterPath&) const", typeof(QPainterPath), typeof(QPainterPath), r);
		}
		public QPainterPath SubtractedInverted(QPainterPath r) {
			return (QPainterPath) interceptor.Invoke("subtractedInverted#", "subtractedInverted(const QPainterPath&) const", typeof(QPainterPath), typeof(QPainterPath), r);
		}
		public override bool Equals(object o) {
			if (!(o is QPainterPath)) { return false; }
			return this == (QPainterPath) o;
		}
		public override int GetHashCode() {
			return interceptor.GetHashCode();
		}
		~QPainterPath() {
			interceptor.Invoke("~QPainterPath", "~QPainterPath()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QPainterPath", "~QPainterPath()", typeof(void));
		}
		public static bool operator==(QPainterPath lhs, QPainterPath other) {
			return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QPainterPath&) const", typeof(bool), typeof(QPainterPath), lhs, typeof(QPainterPath), other);
		}
		public static bool operator!=(QPainterPath lhs, QPainterPath other) {
			return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QPainterPath&) const", typeof(bool), typeof(QPainterPath), lhs, typeof(QPainterPath), other);
		}
		public static QPainterPath operator*(QPainterPath p, QMatrix m) {
			return (QPainterPath) staticInterceptor.Invoke("operator*##", "operator*(const QPainterPath&, const QMatrix&)", typeof(QPainterPath), typeof(QPainterPath), p, typeof(QMatrix), m);
		}
		public static QPainterPath operator*(QPainterPath p, QTransform m) {
			return (QPainterPath) staticInterceptor.Invoke("operator*##", "operator*(const QPainterPath&, const QTransform&)", typeof(QPainterPath), typeof(QPainterPath), p, typeof(QTransform), m);
		}
	}
}
