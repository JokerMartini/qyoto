//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	public interface IQLayoutItem {
			QSize SizeHint();
			QSize MinimumSize();
			QSize MaximumSize();
			QSizePolicy.ExpandData Expanding();
			void SetGeometry(QRect arg1);
			QRect Geometry();
			bool IsEmpty();
			bool HasHeightForWidth();
			int HeightForWidth(int arg1);
			void Invalidate();
			QWidget Widget();
			QLayout Layout();
			QSpacerItem SpacerItem();
			int Alignment();
			void SetAlignment(int a);
	}

	[SmokeClass("QLayoutItem")]
	public class QLayoutItem : MarshalByRefObject, IQLayoutItem {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QLayoutItem(Type dummy) {}
		interface IQLayoutItemProxy {
		}

		protected void CreateQLayoutItemProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QLayoutItem), this);
			_interceptor = (QLayoutItem) realProxy.GetTransparentProxy();
		}
		private QLayoutItem ProxyQLayoutItem() {
			return (QLayoutItem) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QLayoutItem() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQLayoutItemProxy), null);
			_staticInterceptor = (IQLayoutItemProxy) realProxy.GetTransparentProxy();
		}
		private static IQLayoutItemProxy StaticQLayoutItem() {
			return (IQLayoutItemProxy) _staticInterceptor;
		}

		public QLayoutItem(int alignment) : this((Type) null) {
			CreateQLayoutItemProxy();
			NewQLayoutItem(alignment);
		}
		[SmokeMethod("QLayoutItem(int)")]
		private void NewQLayoutItem(int alignment) {
			ProxyQLayoutItem().NewQLayoutItem(alignment);
		}
		public QLayoutItem() : this((Type) null) {
			CreateQLayoutItemProxy();
			NewQLayoutItem();
		}
		[SmokeMethod("QLayoutItem()")]
		private void NewQLayoutItem() {
			ProxyQLayoutItem().NewQLayoutItem();
		}
		[SmokeMethod("sizeHint() const")]
		public virtual QSize SizeHint() {
			return ProxyQLayoutItem().SizeHint();
		}
		[SmokeMethod("minimumSize() const")]
		public virtual QSize MinimumSize() {
			return ProxyQLayoutItem().MinimumSize();
		}
		[SmokeMethod("maximumSize() const")]
		public virtual QSize MaximumSize() {
			return ProxyQLayoutItem().MaximumSize();
		}
		[SmokeMethod("expanding() const")]
		public virtual QSizePolicy.ExpandData Expanding() {
			return ProxyQLayoutItem().Expanding();
		}
		[SmokeMethod("setGeometry(const QRect&)")]
		public virtual void SetGeometry(QRect arg1) {
			ProxyQLayoutItem().SetGeometry(arg1);
		}
		[SmokeMethod("geometry() const")]
		public virtual QRect Geometry() {
			return ProxyQLayoutItem().Geometry();
		}
		[SmokeMethod("isEmpty() const")]
		public virtual bool IsEmpty() {
			return ProxyQLayoutItem().IsEmpty();
		}
		[SmokeMethod("hasHeightForWidth() const")]
		public virtual bool HasHeightForWidth() {
			return ProxyQLayoutItem().HasHeightForWidth();
		}
		[SmokeMethod("heightForWidth(int) const")]
		public virtual int HeightForWidth(int arg1) {
			return ProxyQLayoutItem().HeightForWidth(arg1);
		}
		[SmokeMethod("invalidate()")]
		public virtual void Invalidate() {
			ProxyQLayoutItem().Invalidate();
		}
		[SmokeMethod("widget()")]
		public virtual QWidget Widget() {
			return ProxyQLayoutItem().Widget();
		}
		// QLayoutIterator iterator(); >>>> NOT CONVERTED
		[SmokeMethod("layout()")]
		public virtual QLayout Layout() {
			return ProxyQLayoutItem().Layout();
		}
		[SmokeMethod("spacerItem()")]
		public virtual QSpacerItem SpacerItem() {
			return ProxyQLayoutItem().SpacerItem();
		}
		[SmokeMethod("alignment() const")]
		public int Alignment() {
			return ProxyQLayoutItem().Alignment();
		}
		[SmokeMethod("setAlignment(int)")]
		public virtual void SetAlignment(int a) {
			ProxyQLayoutItem().SetAlignment(a);
		}
		~QLayoutItem() {
			DisposeQLayoutItem();
		}
		public void Dispose() {
			DisposeQLayoutItem();
		}
		private void DisposeQLayoutItem() {
			ProxyQLayoutItem().DisposeQLayoutItem();
		}
	}
}
