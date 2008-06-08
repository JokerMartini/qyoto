//Auto-generated by kalyptus. DO NOT EDIT.
namespace KParts {

	using Kimono;
	using System;
	using Qyoto;

	/// <remarks>
	///  This event is sent to a Part when its GUI has been activated or deactivated.
	///  This is related to PartActivateEvent, but the difference is that
	///  GUIActivateEvent happens later (when the GUI is actually built),
	///  only for parts that have GUI elements, and only if using KParts.MainWindow.
	/// </remarks>		<short>    This event is sent to a Part when its GUI has been activated or deactivated.</short>
	/// 		<see> Part.GuiActivateEvent</see>

	[SmokeClass("KParts::GUIActivateEvent")]
	public class GUIActivateEvent : KParts.Event, IDisposable {
 		protected GUIActivateEvent(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocationKDE(typeof(GUIActivateEvent), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static GUIActivateEvent() {
			staticInterceptor = new SmokeInvocationKDE(typeof(GUIActivateEvent), null);
		}
		public GUIActivateEvent(bool activated) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("GUIActivateEvent$", "GUIActivateEvent(bool)", typeof(void), typeof(bool), activated);
		}
		public bool Activated() {
			return (bool) interceptor.Invoke("activated", "activated() const", typeof(bool));
		}
		~GUIActivateEvent() {
			interceptor.Invoke("~GUIActivateEvent", "~GUIActivateEvent()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~GUIActivateEvent", "~GUIActivateEvent()", typeof(void));
		}
		public static new bool Test(QEvent arg1) {
			return (bool) staticInterceptor.Invoke("test#", "test(const QEvent*)", typeof(bool), typeof(QEvent), arg1);
		}
	}
}
