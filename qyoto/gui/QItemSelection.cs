//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QItemSelection")]
	public class QItemSelection : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QItemSelection(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QItemSelection), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QItemSelection() {
			staticInterceptor = new SmokeInvocation(typeof(QItemSelection), null);
		}
		public QItemSelection() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QItemSelection", "QItemSelection()", typeof(void));
		}
		public QItemSelection(QModelIndex topLeft, QModelIndex bottomRight) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QItemSelection##", "QItemSelection(const QModelIndex&, const QModelIndex&)", typeof(void), typeof(QModelIndex), topLeft, typeof(QModelIndex), bottomRight);
		}
		public void Select(QModelIndex topLeft, QModelIndex bottomRight) {
			interceptor.Invoke("select##", "select(const QModelIndex&, const QModelIndex&)", typeof(void), typeof(QModelIndex), topLeft, typeof(QModelIndex), bottomRight);
		}
		public bool Contains(QModelIndex index) {
			return (bool) interceptor.Invoke("contains#", "contains(const QModelIndex&) const", typeof(bool), typeof(QModelIndex), index);
		}
		public List<QModelIndex> Indexes() {
			return (List<QModelIndex>) interceptor.Invoke("indexes", "indexes() const", typeof(List<QModelIndex>));
		}
		public void Merge(QItemSelection other, int command) {
			interceptor.Invoke("merge#$", "merge(const QItemSelection&, QItemSelectionModel::SelectionFlags)", typeof(void), typeof(QItemSelection), other, typeof(int), command);
		}
		~QItemSelection() {
			interceptor.Invoke("~QItemSelection", "~QItemSelection()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QItemSelection", "~QItemSelection()", typeof(void));
		}
		public static void Split(QItemSelectionRange range, QItemSelectionRange other, QItemSelection result) {
			staticInterceptor.Invoke("split###", "split(const QItemSelectionRange&, const QItemSelectionRange&, QItemSelection*)", typeof(void), typeof(QItemSelectionRange), range, typeof(QItemSelectionRange), other, typeof(QItemSelection), result);
		}
	}
}
