//Auto-generated by kalyptus. DO NOT EDIT.
namespace KParts {

	using Kimono;
	using System;
	using Qyoto;

	/// <remarks>
	///  This event is sent when a part is selected or deselected.
	/// </remarks>		<short>    This event is sent when a part is selected or deselected.</short>
	/// 		<see> PartManager.SetSelectionPolicy</see>

	[SmokeClass("KParts::PartSelectEvent")]
	public class PartSelectEvent : KParts.Event, IDisposable {
 		protected PartSelectEvent(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocationKDE(typeof(PartSelectEvent), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static PartSelectEvent() {
			staticInterceptor = new SmokeInvocationKDE(typeof(PartSelectEvent), null);
		}
		public PartSelectEvent(bool selected, KParts.Part part, QWidget widget) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("PartSelectEvent$##", "PartSelectEvent(bool, KParts::Part*, QWidget*)", typeof(void), typeof(bool), selected, typeof(KParts.Part), part, typeof(QWidget), widget);
		}
		public bool Selected() {
			return (bool) interceptor.Invoke("selected", "selected() const", typeof(bool));
		}
		public KParts.Part Part() {
			return (KParts.Part) interceptor.Invoke("part", "part() const", typeof(KParts.Part));
		}
		public QWidget Widget() {
			return (QWidget) interceptor.Invoke("widget", "widget() const", typeof(QWidget));
		}
		~PartSelectEvent() {
			interceptor.Invoke("~PartSelectEvent", "~PartSelectEvent()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~PartSelectEvent", "~PartSelectEvent()", typeof(void));
		}
		public static new bool Test(QEvent arg1) {
			return (bool) staticInterceptor.Invoke("test#", "test(const QEvent*)", typeof(bool), typeof(QEvent), arg1);
		}
	}
}
