//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QItemEditorFactory")]
	public class QItemEditorFactory : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QItemEditorFactory(Type dummy) {}
		[SmokeClass("QItemEditorFactory")]
		interface IQItemEditorFactoryProxy {
			[SmokeMethod("defaultFactory", "()", "")]
			QItemEditorFactory DefaultFactory();
			[SmokeMethod("setDefaultFactory", "(QItemEditorFactory*)", "#")]
			void SetDefaultFactory(QItemEditorFactory factory);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QItemEditorFactory), this);
			_interceptor = (QItemEditorFactory) realProxy.GetTransparentProxy();
		}
		private QItemEditorFactory ProxyQItemEditorFactory() {
			return (QItemEditorFactory) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QItemEditorFactory() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQItemEditorFactoryProxy), null);
			_staticInterceptor = (IQItemEditorFactoryProxy) realProxy.GetTransparentProxy();
		}
		private static IQItemEditorFactoryProxy StaticQItemEditorFactory() {
			return (IQItemEditorFactoryProxy) _staticInterceptor;
		}

		public QItemEditorFactory() : this((Type) null) {
			CreateProxy();
			NewQItemEditorFactory();
		}
		[SmokeMethod("QItemEditorFactory", "()", "")]
		private void NewQItemEditorFactory() {
			ProxyQItemEditorFactory().NewQItemEditorFactory();
		}
		[SmokeMethod("createEditor", "(QVariant::Type, QWidget*) const", "$#")]
		public virtual QWidget CreateEditor(QVariant.TypeOf type, QWidget parent) {
			return ProxyQItemEditorFactory().CreateEditor(type,parent);
		}
		[SmokeMethod("valuePropertyName", "(QVariant::Type) const", "$")]
		public virtual QByteArray ValuePropertyName(QVariant.TypeOf type) {
			return ProxyQItemEditorFactory().ValuePropertyName(type);
		}
		[SmokeMethod("registerEditor", "(QVariant::Type, QItemEditorCreatorBase*)", "$#")]
		public void RegisterEditor(QVariant.TypeOf type, QItemEditorCreatorBase creator) {
			ProxyQItemEditorFactory().RegisterEditor(type,creator);
		}
		public static QItemEditorFactory DefaultFactory() {
			return StaticQItemEditorFactory().DefaultFactory();
		}
		public static void SetDefaultFactory(QItemEditorFactory factory) {
			StaticQItemEditorFactory().SetDefaultFactory(factory);
		}
		~QItemEditorFactory() {
			DisposeQItemEditorFactory();
		}
		public void Dispose() {
			DisposeQItemEditorFactory();
		}
		[SmokeMethod("~QItemEditorFactory", "()", "")]
		private void DisposeQItemEditorFactory() {
			ProxyQItemEditorFactory().DisposeQItemEditorFactory();
		}
	}
}
