//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	using System.Collections.Generic;
	[SmokeClass("QRegion")]
	public partial class QRegion : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QRegion(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QRegion), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QRegion() {
			staticInterceptor = new SmokeInvocation(typeof(QRegion), null);
		}
		public enum RegionType {
			Rectangle = 0,
			Ellipse = 1,
		}
		//  operator QVariant(); >>>> NOT CONVERTED
		public QRegion() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QRegion", "QRegion()", typeof(void));
		}
		public QRegion(int x, int y, int w, int h, QRegion.RegionType t) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QRegion$$$$$", "QRegion(int, int, int, int, QRegion::RegionType)", typeof(void), typeof(int), x, typeof(int), y, typeof(int), w, typeof(int), h, typeof(QRegion.RegionType), t);
		}
		public QRegion(int x, int y, int w, int h) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QRegion$$$$", "QRegion(int, int, int, int)", typeof(void), typeof(int), x, typeof(int), y, typeof(int), w, typeof(int), h);
		}
		public QRegion(QRect r, QRegion.RegionType t) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QRegion#$", "QRegion(const QRect&, QRegion::RegionType)", typeof(void), typeof(QRect), r, typeof(QRegion.RegionType), t);
		}
		public QRegion(QRect r) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QRegion#", "QRegion(const QRect&)", typeof(void), typeof(QRect), r);
		}
		public QRegion(QPolygon pa, Qt.FillRule fillRule) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QRegion#$", "QRegion(const QPolygon&, Qt::FillRule)", typeof(void), typeof(QPolygon), pa, typeof(Qt.FillRule), fillRule);
		}
		public QRegion(QPolygon pa) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QRegion#", "QRegion(const QPolygon&)", typeof(void), typeof(QPolygon), pa);
		}
		public QRegion(QRegion region) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QRegion#", "QRegion(const QRegion&)", typeof(void), typeof(QRegion), region);
		}
		public QRegion(QBitmap bitmap) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QRegion#", "QRegion(const QBitmap&)", typeof(void), typeof(QBitmap), bitmap);
		}
		public bool IsEmpty() {
			return (bool) interceptor.Invoke("isEmpty", "isEmpty() const", typeof(bool));
		}
		public bool Contains(QPoint p) {
			return (bool) interceptor.Invoke("contains#", "contains(const QPoint&) const", typeof(bool), typeof(QPoint), p);
		}
		public bool Contains(QRect r) {
			return (bool) interceptor.Invoke("contains#", "contains(const QRect&) const", typeof(bool), typeof(QRect), r);
		}
		public void Translate(int dx, int dy) {
			interceptor.Invoke("translate$$", "translate(int, int)", typeof(void), typeof(int), dx, typeof(int), dy);
		}
		public void Translate(QPoint p) {
			interceptor.Invoke("translate#", "translate(const QPoint&)", typeof(void), typeof(QPoint), p);
		}
		public QRegion Translated(int dx, int dy) {
			return (QRegion) interceptor.Invoke("translated$$", "translated(int, int) const", typeof(QRegion), typeof(int), dx, typeof(int), dy);
		}
		public QRegion Translated(QPoint p) {
			return (QRegion) interceptor.Invoke("translated#", "translated(const QPoint&) const", typeof(QRegion), typeof(QPoint), p);
		}
		public QRegion Unite(QRegion r) {
			return (QRegion) interceptor.Invoke("unite#", "unite(const QRegion&) const", typeof(QRegion), typeof(QRegion), r);
		}
		public QRegion Unite(QRect r) {
			return (QRegion) interceptor.Invoke("unite#", "unite(const QRect&) const", typeof(QRegion), typeof(QRect), r);
		}
		public QRegion Intersect(QRegion r) {
			return (QRegion) interceptor.Invoke("intersect#", "intersect(const QRegion&) const", typeof(QRegion), typeof(QRegion), r);
		}
		public QRegion Intersect(QRect r) {
			return (QRegion) interceptor.Invoke("intersect#", "intersect(const QRect&) const", typeof(QRegion), typeof(QRect), r);
		}
		public QRegion Subtract(QRegion r) {
			return (QRegion) interceptor.Invoke("subtract#", "subtract(const QRegion&) const", typeof(QRegion), typeof(QRegion), r);
		}
		public QRegion Eor(QRegion r) {
			return (QRegion) interceptor.Invoke("eor#", "eor(const QRegion&) const", typeof(QRegion), typeof(QRegion), r);
		}
		public QRegion United(QRegion r) {
			return (QRegion) interceptor.Invoke("united#", "united(const QRegion&) const", typeof(QRegion), typeof(QRegion), r);
		}
		public QRegion United(QRect r) {
			return (QRegion) interceptor.Invoke("united#", "united(const QRect&) const", typeof(QRegion), typeof(QRect), r);
		}
		public QRegion Intersected(QRegion r) {
			return (QRegion) interceptor.Invoke("intersected#", "intersected(const QRegion&) const", typeof(QRegion), typeof(QRegion), r);
		}
		public QRegion Intersected(QRect r) {
			return (QRegion) interceptor.Invoke("intersected#", "intersected(const QRect&) const", typeof(QRegion), typeof(QRect), r);
		}
		public QRegion Subtracted(QRegion r) {
			return (QRegion) interceptor.Invoke("subtracted#", "subtracted(const QRegion&) const", typeof(QRegion), typeof(QRegion), r);
		}
		public QRegion Xored(QRegion r) {
			return (QRegion) interceptor.Invoke("xored#", "xored(const QRegion&) const", typeof(QRegion), typeof(QRegion), r);
		}
		public bool Intersects(QRegion r) {
			return (bool) interceptor.Invoke("intersects#", "intersects(const QRegion&) const", typeof(bool), typeof(QRegion), r);
		}
		public bool Intersects(QRect r) {
			return (bool) interceptor.Invoke("intersects#", "intersects(const QRect&) const", typeof(bool), typeof(QRect), r);
		}
		public QRect BoundingRect() {
			return (QRect) interceptor.Invoke("boundingRect", "boundingRect() const", typeof(QRect));
		}
		public List<QRect> Rects() {
			return (List<QRect>) interceptor.Invoke("rects", "rects() const", typeof(List<QRect>));
		}
		public void SetRects(QRect rect, int num) {
			interceptor.Invoke("setRects#$", "setRects(const QRect*, int)", typeof(void), typeof(QRect), rect, typeof(int), num);
		}
		public int NumRects() {
			return (int) interceptor.Invoke("numRects", "numRects() const", typeof(int));
		}
		public override bool Equals(object o) {
			if (!(o is QRegion)) { return false; }
			return this == (QRegion) o;
		}
		public override int GetHashCode() {
			return interceptor.GetHashCode();
		}
		~QRegion() {
			interceptor.Invoke("~QRegion", "~QRegion()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QRegion", "~QRegion()", typeof(void));
		}
		public static QRegion operator|(QRegion lhs, QRegion r) {
			return (QRegion) staticInterceptor.Invoke("operator|#", "operator|(const QRegion&) const", typeof(QRegion), typeof(QRegion), lhs, typeof(QRegion), r);
		}
		public static QRegion operator+(QRegion lhs, QRegion r) {
			return (QRegion) staticInterceptor.Invoke("operator+#", "operator+(const QRegion&) const", typeof(QRegion), typeof(QRegion), lhs, typeof(QRegion), r);
		}
		public static QRegion operator+(QRegion lhs, QRect r) {
			return (QRegion) staticInterceptor.Invoke("operator+#", "operator+(const QRect&) const", typeof(QRegion), typeof(QRegion), lhs, typeof(QRect), r);
		}
		public static QRegion operator&(QRegion lhs, QRegion r) {
			return (QRegion) staticInterceptor.Invoke("operator&#", "operator&(const QRegion&) const", typeof(QRegion), typeof(QRegion), lhs, typeof(QRegion), r);
		}
		public static QRegion operator&(QRegion lhs, QRect r) {
			return (QRegion) staticInterceptor.Invoke("operator&#", "operator&(const QRect&) const", typeof(QRegion), typeof(QRegion), lhs, typeof(QRect), r);
		}
		public static QRegion operator-(QRegion lhs, QRegion r) {
			return (QRegion) staticInterceptor.Invoke("operator-#", "operator-(const QRegion&) const", typeof(QRegion), typeof(QRegion), lhs, typeof(QRegion), r);
		}
		public static QRegion operator^(QRegion lhs, QRegion r) {
			return (QRegion) staticInterceptor.Invoke("operator^#", "operator^(const QRegion&) const", typeof(QRegion), typeof(QRegion), lhs, typeof(QRegion), r);
		}
		public static bool operator==(QRegion lhs, QRegion r) {
			return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QRegion&) const", typeof(bool), typeof(QRegion), lhs, typeof(QRegion), r);
		}
		public static bool operator!=(QRegion lhs, QRegion r) {
			return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QRegion&) const", typeof(bool), typeof(QRegion), lhs, typeof(QRegion), r);
		}
		public static QRegion operator*(QRegion r, QMatrix m) {
			return (QRegion) staticInterceptor.Invoke("operator*##", "operator*(const QRegion&, const QMatrix&)", typeof(QRegion), typeof(QRegion), r, typeof(QMatrix), m);
		}
		public static QRegion operator*(QRegion r, QTransform m) {
			return (QRegion) staticInterceptor.Invoke("operator*##", "operator*(const QRegion&, const QTransform&)", typeof(QRegion), typeof(QRegion), r, typeof(QTransform), m);
		}
	}
}
