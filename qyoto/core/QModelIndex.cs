//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QModelIndex")]
	public partial class QModelIndex : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QModelIndex(Type dummy) {}
		[SmokeClass("QModelIndex")]
		interface IQModelIndexProxy {
			[SmokeMethod("operator==", "(const QModelIndex&) const", "#")]
			bool op_equals(QModelIndex lhs, QModelIndex other);
			[SmokeMethod("operator<", "(const QModelIndex&) const", "#")]
			bool op_lt(QModelIndex lhs, QModelIndex other);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QModelIndex), this);
			_interceptor = (QModelIndex) realProxy.GetTransparentProxy();
		}
		private QModelIndex ProxyQModelIndex() {
			return (QModelIndex) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QModelIndex() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQModelIndexProxy), null);
			_staticInterceptor = (IQModelIndexProxy) realProxy.GetTransparentProxy();
		}
		private static IQModelIndexProxy StaticQModelIndex() {
			return (IQModelIndexProxy) _staticInterceptor;
		}
		public QModelIndex() : this((Type) null) {
			CreateProxy();
			NewQModelIndex();
		}
		[SmokeMethod("QModelIndex", "()", "")]
		private void NewQModelIndex() {
			ProxyQModelIndex().NewQModelIndex();
		}
		public QModelIndex(QModelIndex other) : this((Type) null) {
			CreateProxy();
			NewQModelIndex(other);
		}
		[SmokeMethod("QModelIndex", "(const QModelIndex&)", "#")]
		private void NewQModelIndex(QModelIndex other) {
			ProxyQModelIndex().NewQModelIndex(other);
		}
		[SmokeMethod("row", "() const", "")]
		public int Row() {
			return ProxyQModelIndex().Row();
		}
		[SmokeMethod("column", "() const", "")]
		public int Column() {
			return ProxyQModelIndex().Column();
		}
		// void* internalPointer(); >>>> NOT CONVERTED
		[SmokeMethod("internalId", "() const", "")]
		public long InternalId() {
			return ProxyQModelIndex().InternalId();
		}
		[SmokeMethod("parent", "() const", "")]
		public QModelIndex Parent() {
			return ProxyQModelIndex().Parent();
		}
		[SmokeMethod("sibling", "(int, int) const", "$$")]
		public QModelIndex Sibling(int row, int column) {
			return ProxyQModelIndex().Sibling(row,column);
		}
		[SmokeMethod("child", "(int, int) const", "$$")]
		public QModelIndex Child(int row, int column) {
			return ProxyQModelIndex().Child(row,column);
		}
		[SmokeMethod("data", "(int) const", "$")]
		public QVariant Data(int role) {
			return ProxyQModelIndex().Data(role);
		}
		[SmokeMethod("data", "() const", "")]
		public QVariant Data() {
			return ProxyQModelIndex().Data();
		}
		[SmokeMethod("flags", "() const", "")]
		public int Flags() {
			return ProxyQModelIndex().Flags();
		}
		[SmokeMethod("model", "() const", "")]
		public QAbstractItemModel Model() {
			return ProxyQModelIndex().Model();
		}
		[SmokeMethod("isValid", "() const", "")]
		public bool IsValid() {
			return ProxyQModelIndex().IsValid();
		}
		public static bool operator==(QModelIndex lhs, QModelIndex other) {
			return StaticQModelIndex().op_equals(lhs,other);
		}
		public static bool operator!=(QModelIndex lhs, QModelIndex other) {
			return !StaticQModelIndex().op_equals(lhs,other);
		}
		public override bool Equals(object o) {
			if (!(o is QModelIndex)) { return false; }
			return this == (QModelIndex) o;
		}
		public override int GetHashCode() {
			return ProxyQModelIndex().GetHashCode();
		}
		public static bool operator<(QModelIndex lhs, QModelIndex other) {
			return StaticQModelIndex().op_lt(lhs,other);
		}
		public static bool operator>(QModelIndex lhs, QModelIndex other) {
			return !StaticQModelIndex().op_lt(lhs,other)
						&& !StaticQModelIndex().op_equals(lhs,other);
		}
		~QModelIndex() {
			DisposeQModelIndex();
		}
		public void Dispose() {
			DisposeQModelIndex();
		}
		[SmokeMethod("~QModelIndex", "()", "")]
		private void DisposeQModelIndex() {
			QAbstractItemModel.DerefIndexHandle(InternalPointer());
			ProxyQModelIndex().DisposeQModelIndex();
		}
	}
}
