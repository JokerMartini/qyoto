//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QPersistentModelIndex")]
	public class QPersistentModelIndex : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QPersistentModelIndex(Type dummy) {}
		interface IQPersistentModelIndexProxy {
			bool op_lt(QPersistentModelIndex lhs, QPersistentModelIndex other);
			bool op_equals(QPersistentModelIndex lhs, QPersistentModelIndex other);
			bool op_equals(QPersistentModelIndex lhs, QModelIndex other);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QPersistentModelIndex), this);
			_interceptor = (QPersistentModelIndex) realProxy.GetTransparentProxy();
		}
		private QPersistentModelIndex ProxyQPersistentModelIndex() {
			return (QPersistentModelIndex) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QPersistentModelIndex() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQPersistentModelIndexProxy), null);
			_staticInterceptor = (IQPersistentModelIndexProxy) realProxy.GetTransparentProxy();
		}
		private static IQPersistentModelIndexProxy StaticQPersistentModelIndex() {
			return (IQPersistentModelIndexProxy) _staticInterceptor;
		}

		public QPersistentModelIndex() : this((Type) null) {
			CreateProxy();
			NewQPersistentModelIndex();
		}
		[SmokeMethod("QPersistentModelIndex()")]
		private void NewQPersistentModelIndex() {
			ProxyQPersistentModelIndex().NewQPersistentModelIndex();
		}
		public QPersistentModelIndex(QModelIndex index) : this((Type) null) {
			CreateProxy();
			NewQPersistentModelIndex(index);
		}
		[SmokeMethod("QPersistentModelIndex(const QModelIndex&)")]
		private void NewQPersistentModelIndex(QModelIndex index) {
			ProxyQPersistentModelIndex().NewQPersistentModelIndex(index);
		}
		public QPersistentModelIndex(QPersistentModelIndex other) : this((Type) null) {
			CreateProxy();
			NewQPersistentModelIndex(other);
		}
		[SmokeMethod("QPersistentModelIndex(const QPersistentModelIndex&)")]
		private void NewQPersistentModelIndex(QPersistentModelIndex other) {
			ProxyQPersistentModelIndex().NewQPersistentModelIndex(other);
		}
		[SmokeMethod("operator<(const QPersistentModelIndex&) const")]
		public static bool operator<(QPersistentModelIndex lhs, QPersistentModelIndex other) {
			return StaticQPersistentModelIndex().op_lt(lhs,other);
		}
		public static bool operator>(QPersistentModelIndex lhs, QPersistentModelIndex other) {
			return !StaticQPersistentModelIndex().op_lt(lhs,other)
						&& !StaticQPersistentModelIndex().op_equals(lhs,other);
		}
		[SmokeMethod("operator==(const QPersistentModelIndex&) const")]
		public static bool operator==(QPersistentModelIndex lhs, QPersistentModelIndex other) {
			return StaticQPersistentModelIndex().op_equals(lhs,other);
		}
		public static bool operator!=(QPersistentModelIndex lhs, QPersistentModelIndex other) {
			return !StaticQPersistentModelIndex().op_equals(lhs,other);
		}
		public override bool Equals(object o) {
			if (!(o is QPersistentModelIndex)) { return false; }
			return this == (QPersistentModelIndex) o;
		}
		public override int GetHashCode() {
			return ProxyQPersistentModelIndex().GetHashCode();
		}
		[SmokeMethod("operator==(const QModelIndex&) const")]
		public static bool operator==(QPersistentModelIndex lhs, QModelIndex other) {
			return StaticQPersistentModelIndex().op_equals(lhs,other);
		}
		public static bool operator!=(QPersistentModelIndex lhs, QModelIndex other) {
			return !StaticQPersistentModelIndex().op_equals(lhs,other);
		}
		//  operator const QModelIndex&(); >>>> NOT CONVERTED
		[SmokeMethod("row() const")]
		public int Row() {
			return ProxyQPersistentModelIndex().Row();
		}
		[SmokeMethod("column() const")]
		public int Column() {
			return ProxyQPersistentModelIndex().Column();
		}
		// void* internalPointer(); >>>> NOT CONVERTED
		// qint64 internalId(); >>>> NOT CONVERTED
		[SmokeMethod("parent() const")]
		public QModelIndex Parent() {
			return ProxyQPersistentModelIndex().Parent();
		}
		[SmokeMethod("sibling(int, int) const")]
		public QModelIndex Sibling(int row, int column) {
			return ProxyQPersistentModelIndex().Sibling(row,column);
		}
		[SmokeMethod("child(int, int) const")]
		public QModelIndex Child(int row, int column) {
			return ProxyQPersistentModelIndex().Child(row,column);
		}
		[SmokeMethod("data(int) const")]
		public QVariant Data(int role) {
			return ProxyQPersistentModelIndex().Data(role);
		}
		[SmokeMethod("data() const")]
		public QVariant Data() {
			return ProxyQPersistentModelIndex().Data();
		}
		[SmokeMethod("model() const")]
		public QAbstractItemModel Model() {
			return ProxyQPersistentModelIndex().Model();
		}
		[SmokeMethod("isValid() const")]
		public bool IsValid() {
			return ProxyQPersistentModelIndex().IsValid();
		}
		~QPersistentModelIndex() {
			DisposeQPersistentModelIndex();
		}
		public void Dispose() {
			DisposeQPersistentModelIndex();
		}
		private void DisposeQPersistentModelIndex() {
			ProxyQPersistentModelIndex().DisposeQPersistentModelIndex();
		}
	}
}
