//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QAccessibleInterfaceEx")]
	public abstract class QAccessibleInterfaceEx : QAccessibleInterface {
 		protected QAccessibleInterfaceEx(Type dummy) : base((Type) null) {}
		[SmokeClass("QAccessibleInterfaceEx")]
		interface IQAccessibleInterfaceExProxy {
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QAccessibleInterfaceEx), this);
			_interceptor = (QAccessibleInterfaceEx) realProxy.GetTransparentProxy();
		}
		private QAccessibleInterfaceEx ProxyQAccessibleInterfaceEx() {
			return (QAccessibleInterfaceEx) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QAccessibleInterfaceEx() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQAccessibleInterfaceExProxy), null);
			_staticInterceptor = (IQAccessibleInterfaceExProxy) realProxy.GetTransparentProxy();
		}
		private static IQAccessibleInterfaceExProxy StaticQAccessibleInterfaceEx() {
			return (IQAccessibleInterfaceExProxy) _staticInterceptor;
		}
		public abstract QVariant InvokeMethodEx(QAccessible.Method method, int child, List<QVariant> arg3);
		public QAccessibleInterfaceEx() : this((Type) null) {
			CreateProxy();
			NewQAccessibleInterfaceEx();
		}
		[SmokeMethod("QAccessibleInterfaceEx", "()", "")]
		private void NewQAccessibleInterfaceEx() {
			ProxyQAccessibleInterfaceEx().NewQAccessibleInterfaceEx();
		}
		~QAccessibleInterfaceEx() {
			DisposeQAccessibleInterfaceEx();
		}
		public new void Dispose() {
			DisposeQAccessibleInterfaceEx();
		}
		[SmokeMethod("~QAccessibleInterfaceEx", "()", "")]
		private void DisposeQAccessibleInterfaceEx() {
			ProxyQAccessibleInterfaceEx().DisposeQAccessibleInterfaceEx();
		}
	}
}
