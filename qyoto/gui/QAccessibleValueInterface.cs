//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QAccessibleValueInterface")]
	public abstract class QAccessibleValueInterface : QAccessible2Interface {
 		protected QAccessibleValueInterface(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QAccessibleValueInterface), this);
		}
		public QAccessible2Interface QAccessibleValueCastHelper() {
			return (QAccessible2Interface) interceptor.Invoke("qAccessibleValueCastHelper", "qAccessibleValueCastHelper()", typeof(QAccessible2Interface));
		}
		[SmokeMethod("currentValue()")]
		public abstract QVariant CurrentValue();
		[SmokeMethod("setCurrentValue(const QVariant&)")]
		public abstract void SetCurrentValue(QVariant value);
		[SmokeMethod("maximumValue()")]
		public abstract QVariant MaximumValue();
		[SmokeMethod("minimumValue()")]
		public abstract QVariant MinimumValue();
		public QAccessibleValueInterface() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QAccessibleValueInterface", "QAccessibleValueInterface()", typeof(void));
		}
	}
}
