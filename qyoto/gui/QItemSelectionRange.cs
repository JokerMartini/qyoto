//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QItemSelectionRange")]
	public class QItemSelectionRange : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QItemSelectionRange(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QItemSelectionRange), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QItemSelectionRange() {
			staticInterceptor = new SmokeInvocation(typeof(QItemSelectionRange), null);
		}
		public QItemSelectionRange() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QItemSelectionRange", "QItemSelectionRange()", typeof(void));
		}
		public QItemSelectionRange(QItemSelectionRange other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QItemSelectionRange#", "QItemSelectionRange(const QItemSelectionRange&)", typeof(void), typeof(QItemSelectionRange), other);
		}
		public QItemSelectionRange(QModelIndex topLeft, QModelIndex bottomRight) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QItemSelectionRange##", "QItemSelectionRange(const QModelIndex&, const QModelIndex&)", typeof(void), typeof(QModelIndex), topLeft, typeof(QModelIndex), bottomRight);
		}
		public QItemSelectionRange(QModelIndex index) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QItemSelectionRange#", "QItemSelectionRange(const QModelIndex&)", typeof(void), typeof(QModelIndex), index);
		}
		public int Top() {
			return (int) interceptor.Invoke("top", "top() const", typeof(int));
		}
		public int Left() {
			return (int) interceptor.Invoke("left", "left() const", typeof(int));
		}
		public int Bottom() {
			return (int) interceptor.Invoke("bottom", "bottom() const", typeof(int));
		}
		public int Right() {
			return (int) interceptor.Invoke("right", "right() const", typeof(int));
		}
		public int Width() {
			return (int) interceptor.Invoke("width", "width() const", typeof(int));
		}
		public int Height() {
			return (int) interceptor.Invoke("height", "height() const", typeof(int));
		}
		public QModelIndex TopLeft() {
			return (QModelIndex) interceptor.Invoke("topLeft", "topLeft() const", typeof(QModelIndex));
		}
		public QModelIndex BottomRight() {
			return (QModelIndex) interceptor.Invoke("bottomRight", "bottomRight() const", typeof(QModelIndex));
		}
		public QModelIndex Parent() {
			return (QModelIndex) interceptor.Invoke("parent", "parent() const", typeof(QModelIndex));
		}
		public QAbstractItemModel Model() {
			return (QAbstractItemModel) interceptor.Invoke("model", "model() const", typeof(QAbstractItemModel));
		}
		public bool Contains(QModelIndex index) {
			return (bool) interceptor.Invoke("contains#", "contains(const QModelIndex&) const", typeof(bool), typeof(QModelIndex), index);
		}
		public bool Contains(int row, int column, QModelIndex parentIndex) {
			return (bool) interceptor.Invoke("contains$$#", "contains(int, int, const QModelIndex&) const", typeof(bool), typeof(int), row, typeof(int), column, typeof(QModelIndex), parentIndex);
		}
		public bool Intersects(QItemSelectionRange other) {
			return (bool) interceptor.Invoke("intersects#", "intersects(const QItemSelectionRange&) const", typeof(bool), typeof(QItemSelectionRange), other);
		}
		public QItemSelectionRange Intersect(QItemSelectionRange other) {
			return (QItemSelectionRange) interceptor.Invoke("intersect#", "intersect(const QItemSelectionRange&) const", typeof(QItemSelectionRange), typeof(QItemSelectionRange), other);
		}
		public QItemSelectionRange Intersected(QItemSelectionRange other) {
			return (QItemSelectionRange) interceptor.Invoke("intersected#", "intersected(const QItemSelectionRange&) const", typeof(QItemSelectionRange), typeof(QItemSelectionRange), other);
		}
		public override bool Equals(object o) {
			if (!(o is QItemSelectionRange)) { return false; }
			return this == (QItemSelectionRange) o;
		}
		public override int GetHashCode() {
			return interceptor.GetHashCode();
		}
		public bool IsValid() {
			return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
		}
		public List<QModelIndex> Indexes() {
			return (List<QModelIndex>) interceptor.Invoke("indexes", "indexes() const", typeof(List<QModelIndex>));
		}
		~QItemSelectionRange() {
			interceptor.Invoke("~QItemSelectionRange", "~QItemSelectionRange()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QItemSelectionRange", "~QItemSelectionRange()", typeof(void));
		}
		public static bool operator==(QItemSelectionRange lhs, QItemSelectionRange other) {
			return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QItemSelectionRange&) const", typeof(bool), typeof(QItemSelectionRange), lhs, typeof(QItemSelectionRange), other);
		}
		public static bool operator!=(QItemSelectionRange lhs, QItemSelectionRange other) {
			return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QItemSelectionRange&) const", typeof(bool), typeof(QItemSelectionRange), lhs, typeof(QItemSelectionRange), other);
		}
	}
}
