//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	using System.Collections.Generic;
	[SmokeClass("QPolygon")]
	public partial class QPolygon : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QPolygon(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QPolygon), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QPolygon() {
			staticInterceptor = new SmokeInvocation(typeof(QPolygon), null);
		}
		//  operator QVariant(); >>>> NOT CONVERTED
		public QPolygon() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QPolygon", "QPolygon()", typeof(void));
		}
		public QPolygon(int size) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QPolygon$", "QPolygon(int)", typeof(void), typeof(int), size);
		}
		public QPolygon(QPolygon a) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QPolygon#", "QPolygon(const QPolygon&)", typeof(void), typeof(QPolygon), a);
		}
		public QPolygon(List<QPoint> v) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QPolygon?", "QPolygon(const QVector<QPoint>&)", typeof(void), typeof(List<QPoint>), v);
		}
		public QPolygon(QRect r, bool closed) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QPolygon#$", "QPolygon(const QRect&, bool)", typeof(void), typeof(QRect), r, typeof(bool), closed);
		}
		public QPolygon(QRect r) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QPolygon#", "QPolygon(const QRect&)", typeof(void), typeof(QRect), r);
		}
		public QPolygon(int nPoints, ref int points) : this((Type) null) {
			CreateProxy();
			StackItem[] stack = new StackItem[3];
			stack[1].s_int = nPoints;
			stack[2].s_int = points;
			interceptor.Invoke("QPolygon$$", "QPolygon(int, const int*)", stack);
			points = stack[2].s_int;
			return;
		}
		public void Translate(int dx, int dy) {
			interceptor.Invoke("translate$$", "translate(int, int)", typeof(void), typeof(int), dx, typeof(int), dy);
		}
		public void Translate(QPoint offset) {
			interceptor.Invoke("translate#", "translate(const QPoint&)", typeof(void), typeof(QPoint), offset);
		}
		public QRect BoundingRect() {
			return (QRect) interceptor.Invoke("boundingRect", "boundingRect() const", typeof(QRect));
		}
		public void Point(int i, ref int x, ref int y) {
			StackItem[] stack = new StackItem[4];
			stack[1].s_int = i;
			stack[2].s_int = x;
			stack[3].s_int = y;
			interceptor.Invoke("point$$$", "point(int, int*, int*) const", stack);
			x = stack[2].s_int;
			y = stack[3].s_int;
			return;
		}
		public QPoint Point(int i) {
			return (QPoint) interceptor.Invoke("point$", "point(int) const", typeof(QPoint), typeof(int), i);
		}
		public void SetPoint(int index, int x, int y) {
			interceptor.Invoke("setPoint$$$", "setPoint(int, int, int)", typeof(void), typeof(int), index, typeof(int), x, typeof(int), y);
		}
		public void SetPoint(int index, QPoint p) {
			interceptor.Invoke("setPoint$#", "setPoint(int, const QPoint&)", typeof(void), typeof(int), index, typeof(QPoint), p);
		}
		public void SetPoints(int nPoints, ref int points) {
			StackItem[] stack = new StackItem[3];
			stack[1].s_int = nPoints;
			stack[2].s_int = points;
			interceptor.Invoke("setPoints$$", "setPoints(int, const int*)", stack);
			points = stack[2].s_int;
			return;
		}
		public void PutPoints(int index, int nPoints, ref int points) {
			StackItem[] stack = new StackItem[4];
			stack[1].s_int = index;
			stack[2].s_int = nPoints;
			stack[3].s_int = points;
			interceptor.Invoke("putPoints$$$", "putPoints(int, int, const int*)", stack);
			points = stack[3].s_int;
			return;
		}
		public void PutPoints(int index, int nPoints, QPolygon from, int fromIndex) {
			interceptor.Invoke("putPoints$$#$", "putPoints(int, int, const QPolygon&, int)", typeof(void), typeof(int), index, typeof(int), nPoints, typeof(QPolygon), from, typeof(int), fromIndex);
		}
		public void PutPoints(int index, int nPoints, QPolygon from) {
			interceptor.Invoke("putPoints$$#", "putPoints(int, int, const QPolygon&)", typeof(void), typeof(int), index, typeof(int), nPoints, typeof(QPolygon), from);
		}
		public bool ContainsPoint(QPoint pt, Qt.FillRule fillRule) {
			return (bool) interceptor.Invoke("containsPoint#$", "containsPoint(const QPoint&, Qt::FillRule) const", typeof(bool), typeof(QPoint), pt, typeof(Qt.FillRule), fillRule);
		}
		public QPolygon United(QPolygon r) {
			return (QPolygon) interceptor.Invoke("united#", "united(const QPolygon&) const", typeof(QPolygon), typeof(QPolygon), r);
		}
		public QPolygon Intersected(QPolygon r) {
			return (QPolygon) interceptor.Invoke("intersected#", "intersected(const QPolygon&) const", typeof(QPolygon), typeof(QPolygon), r);
		}
		public QPolygon Subtracted(QPolygon r) {
			return (QPolygon) interceptor.Invoke("subtracted#", "subtracted(const QPolygon&) const", typeof(QPolygon), typeof(QPolygon), r);
		}
		~QPolygon() {
			interceptor.Invoke("~QPolygon", "~QPolygon()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QPolygon", "~QPolygon()", typeof(void));
		}
		public static QPolygon operator*(QPolygon a, QMatrix m) {
			return (QPolygon) staticInterceptor.Invoke("operator*##", "operator*(const QPolygon&, const QMatrix&)", typeof(QPolygon), typeof(QPolygon), a, typeof(QMatrix), m);
		}
		public static QPolygon operator*(QPolygon a, QTransform m) {
			return (QPolygon) staticInterceptor.Invoke("operator*##", "operator*(const QPolygon&, const QTransform&)", typeof(QPolygon), typeof(QPolygon), a, typeof(QTransform), m);
		}
	}
}
