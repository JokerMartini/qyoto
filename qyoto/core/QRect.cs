//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QRect")]
	public class QRect : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QRect(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QRect), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QRect() {
			staticInterceptor = new SmokeInvocation(typeof(QRect), null);
		}
		public QRect() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QRect", "QRect()", typeof(void));
		}
		public QRect(QPoint topleft, QPoint bottomright) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QRect##", "QRect(const QPoint&, const QPoint&)", typeof(void), typeof(QPoint), topleft, typeof(QPoint), bottomright);
		}
		public QRect(QPoint topleft, QSize size) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QRect##", "QRect(const QPoint&, const QSize&)", typeof(void), typeof(QPoint), topleft, typeof(QSize), size);
		}
		public QRect(int left, int top, int width, int height) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QRect$$$$", "QRect(int, int, int, int)", typeof(void), typeof(int), left, typeof(int), top, typeof(int), width, typeof(int), height);
		}
		public bool IsNull() {
			return (bool) interceptor.Invoke("isNull", "isNull() const", typeof(bool));
		}
		public bool IsEmpty() {
			return (bool) interceptor.Invoke("isEmpty", "isEmpty() const", typeof(bool));
		}
		public bool IsValid() {
			return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
		}
		public int Left() {
			return (int) interceptor.Invoke("left", "left() const", typeof(int));
		}
		public int Top() {
			return (int) interceptor.Invoke("top", "top() const", typeof(int));
		}
		public int Right() {
			return (int) interceptor.Invoke("right", "right() const", typeof(int));
		}
		public int Bottom() {
			return (int) interceptor.Invoke("bottom", "bottom() const", typeof(int));
		}
		public QRect Normalized() {
			return (QRect) interceptor.Invoke("normalized", "normalized() const", typeof(QRect));
		}
		public int X() {
			return (int) interceptor.Invoke("x", "x() const", typeof(int));
		}
		public int Y() {
			return (int) interceptor.Invoke("y", "y() const", typeof(int));
		}
		public void SetLeft(int pos) {
			interceptor.Invoke("setLeft$", "setLeft(int)", typeof(void), typeof(int), pos);
		}
		public void SetTop(int pos) {
			interceptor.Invoke("setTop$", "setTop(int)", typeof(void), typeof(int), pos);
		}
		public void SetRight(int pos) {
			interceptor.Invoke("setRight$", "setRight(int)", typeof(void), typeof(int), pos);
		}
		public void SetBottom(int pos) {
			interceptor.Invoke("setBottom$", "setBottom(int)", typeof(void), typeof(int), pos);
		}
		public void SetX(int x) {
			interceptor.Invoke("setX$", "setX(int)", typeof(void), typeof(int), x);
		}
		public void SetY(int y) {
			interceptor.Invoke("setY$", "setY(int)", typeof(void), typeof(int), y);
		}
		public void SetTopLeft(QPoint p) {
			interceptor.Invoke("setTopLeft#", "setTopLeft(const QPoint&)", typeof(void), typeof(QPoint), p);
		}
		public void SetBottomRight(QPoint p) {
			interceptor.Invoke("setBottomRight#", "setBottomRight(const QPoint&)", typeof(void), typeof(QPoint), p);
		}
		public void SetTopRight(QPoint p) {
			interceptor.Invoke("setTopRight#", "setTopRight(const QPoint&)", typeof(void), typeof(QPoint), p);
		}
		public void SetBottomLeft(QPoint p) {
			interceptor.Invoke("setBottomLeft#", "setBottomLeft(const QPoint&)", typeof(void), typeof(QPoint), p);
		}
		public QPoint TopLeft() {
			return (QPoint) interceptor.Invoke("topLeft", "topLeft() const", typeof(QPoint));
		}
		public QPoint BottomRight() {
			return (QPoint) interceptor.Invoke("bottomRight", "bottomRight() const", typeof(QPoint));
		}
		public QPoint TopRight() {
			return (QPoint) interceptor.Invoke("topRight", "topRight() const", typeof(QPoint));
		}
		public QPoint BottomLeft() {
			return (QPoint) interceptor.Invoke("bottomLeft", "bottomLeft() const", typeof(QPoint));
		}
		public QPoint Center() {
			return (QPoint) interceptor.Invoke("center", "center() const", typeof(QPoint));
		}
		public void MoveLeft(int pos) {
			interceptor.Invoke("moveLeft$", "moveLeft(int)", typeof(void), typeof(int), pos);
		}
		public void MoveTop(int pos) {
			interceptor.Invoke("moveTop$", "moveTop(int)", typeof(void), typeof(int), pos);
		}
		public void MoveRight(int pos) {
			interceptor.Invoke("moveRight$", "moveRight(int)", typeof(void), typeof(int), pos);
		}
		public void MoveBottom(int pos) {
			interceptor.Invoke("moveBottom$", "moveBottom(int)", typeof(void), typeof(int), pos);
		}
		public void MoveTopLeft(QPoint p) {
			interceptor.Invoke("moveTopLeft#", "moveTopLeft(const QPoint&)", typeof(void), typeof(QPoint), p);
		}
		public void MoveBottomRight(QPoint p) {
			interceptor.Invoke("moveBottomRight#", "moveBottomRight(const QPoint&)", typeof(void), typeof(QPoint), p);
		}
		public void MoveTopRight(QPoint p) {
			interceptor.Invoke("moveTopRight#", "moveTopRight(const QPoint&)", typeof(void), typeof(QPoint), p);
		}
		public void MoveBottomLeft(QPoint p) {
			interceptor.Invoke("moveBottomLeft#", "moveBottomLeft(const QPoint&)", typeof(void), typeof(QPoint), p);
		}
		public void MoveCenter(QPoint p) {
			interceptor.Invoke("moveCenter#", "moveCenter(const QPoint&)", typeof(void), typeof(QPoint), p);
		}
		public void Translate(int dx, int dy) {
			interceptor.Invoke("translate$$", "translate(int, int)", typeof(void), typeof(int), dx, typeof(int), dy);
		}
		public void Translate(QPoint p) {
			interceptor.Invoke("translate#", "translate(const QPoint&)", typeof(void), typeof(QPoint), p);
		}
		public QRect Translated(int dx, int dy) {
			return (QRect) interceptor.Invoke("translated$$", "translated(int, int) const", typeof(QRect), typeof(int), dx, typeof(int), dy);
		}
		public QRect Translated(QPoint p) {
			return (QRect) interceptor.Invoke("translated#", "translated(const QPoint&) const", typeof(QRect), typeof(QPoint), p);
		}
		public void MoveTo(int x, int t) {
			interceptor.Invoke("moveTo$$", "moveTo(int, int)", typeof(void), typeof(int), x, typeof(int), t);
		}
		public void MoveTo(QPoint p) {
			interceptor.Invoke("moveTo#", "moveTo(const QPoint&)", typeof(void), typeof(QPoint), p);
		}
		public void SetRect(int x, int y, int w, int h) {
			interceptor.Invoke("setRect$$$$", "setRect(int, int, int, int)", typeof(void), typeof(int), x, typeof(int), y, typeof(int), w, typeof(int), h);
		}
		public void GetRect(int x, int y, int w, int h) {
			interceptor.Invoke("getRect$$$$", "getRect(int*, int*, int*, int*) const", typeof(void), typeof(int), x, typeof(int), y, typeof(int), w, typeof(int), h);
		}
		public void SetCoords(int x1, int y1, int x2, int y2) {
			interceptor.Invoke("setCoords$$$$", "setCoords(int, int, int, int)", typeof(void), typeof(int), x1, typeof(int), y1, typeof(int), x2, typeof(int), y2);
		}
		public void GetCoords(int x1, int y1, int x2, int y2) {
			interceptor.Invoke("getCoords$$$$", "getCoords(int*, int*, int*, int*) const", typeof(void), typeof(int), x1, typeof(int), y1, typeof(int), x2, typeof(int), y2);
		}
		public void Adjust(int x1, int y1, int x2, int y2) {
			interceptor.Invoke("adjust$$$$", "adjust(int, int, int, int)", typeof(void), typeof(int), x1, typeof(int), y1, typeof(int), x2, typeof(int), y2);
		}
		public QRect Adjusted(int x1, int y1, int x2, int y2) {
			return (QRect) interceptor.Invoke("adjusted$$$$", "adjusted(int, int, int, int) const", typeof(QRect), typeof(int), x1, typeof(int), y1, typeof(int), x2, typeof(int), y2);
		}
		public QSize Size() {
			return (QSize) interceptor.Invoke("size", "size() const", typeof(QSize));
		}
		public int Width() {
			return (int) interceptor.Invoke("width", "width() const", typeof(int));
		}
		public int Height() {
			return (int) interceptor.Invoke("height", "height() const", typeof(int));
		}
		public void SetWidth(int w) {
			interceptor.Invoke("setWidth$", "setWidth(int)", typeof(void), typeof(int), w);
		}
		public void SetHeight(int h) {
			interceptor.Invoke("setHeight$", "setHeight(int)", typeof(void), typeof(int), h);
		}
		public void SetSize(QSize s) {
			interceptor.Invoke("setSize#", "setSize(const QSize&)", typeof(void), typeof(QSize), s);
		}
		public bool Contains(QPoint p, bool proper) {
			return (bool) interceptor.Invoke("contains#$", "contains(const QPoint&, bool) const", typeof(bool), typeof(QPoint), p, typeof(bool), proper);
		}
		public bool Contains(QPoint p) {
			return (bool) interceptor.Invoke("contains#", "contains(const QPoint&) const", typeof(bool), typeof(QPoint), p);
		}
		public bool Contains(int x, int y) {
			return (bool) interceptor.Invoke("contains$$", "contains(int, int) const", typeof(bool), typeof(int), x, typeof(int), y);
		}
		public bool Contains(int x, int y, bool proper) {
			return (bool) interceptor.Invoke("contains$$$", "contains(int, int, bool) const", typeof(bool), typeof(int), x, typeof(int), y, typeof(bool), proper);
		}
		public bool Contains(QRect r, bool proper) {
			return (bool) interceptor.Invoke("contains#$", "contains(const QRect&, bool) const", typeof(bool), typeof(QRect), r, typeof(bool), proper);
		}
		public bool Contains(QRect r) {
			return (bool) interceptor.Invoke("contains#", "contains(const QRect&) const", typeof(bool), typeof(QRect), r);
		}
		public QRect Unite(QRect r) {
			return (QRect) interceptor.Invoke("unite#", "unite(const QRect&) const", typeof(QRect), typeof(QRect), r);
		}
		public QRect United(QRect other) {
			return (QRect) interceptor.Invoke("united#", "united(const QRect&) const", typeof(QRect), typeof(QRect), other);
		}
		public QRect Intersect(QRect r) {
			return (QRect) interceptor.Invoke("intersect#", "intersect(const QRect&) const", typeof(QRect), typeof(QRect), r);
		}
		public QRect Intersected(QRect other) {
			return (QRect) interceptor.Invoke("intersected#", "intersected(const QRect&) const", typeof(QRect), typeof(QRect), other);
		}
		public bool Intersects(QRect r) {
			return (bool) interceptor.Invoke("intersects#", "intersects(const QRect&) const", typeof(bool), typeof(QRect), r);
		}
		~QRect() {
			interceptor.Invoke("~QRect", "~QRect()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QRect", "~QRect()", typeof(void));
		}
		public override bool Equals(object o) {
			if (!(o is QRect)) { return false; }
			return this == (QRect) o;
		}
		public override int GetHashCode() {
			return interceptor.GetHashCode();
		}
		public static QRect operator|(QRect lhs, QRect r) {
			return (QRect) staticInterceptor.Invoke("operator|#", "operator|(const QRect&) const", typeof(QRect), typeof(QRect), lhs, typeof(QRect), r);
		}
		public static QRect operator&(QRect lhs, QRect r) {
			return (QRect) staticInterceptor.Invoke("operator&#", "operator&(const QRect&) const", typeof(QRect), typeof(QRect), lhs, typeof(QRect), r);
		}
		public static bool operator==(QRect arg1, QRect arg2) {
			return (bool) staticInterceptor.Invoke("operator==##", "operator==(const QRect&, const QRect&)", typeof(bool), typeof(QRect), arg1, typeof(QRect), arg2);
		}
		public static bool operator!=(QRect arg1, QRect arg2) {
			return !(bool) staticInterceptor.Invoke("operator==##", "operator==(const QRect&, const QRect&)", typeof(bool), typeof(QRect), arg1, typeof(QRect), arg2);
		}
	}
}
