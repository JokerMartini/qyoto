//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	/// <remarks> See <see cref="IQButtonGroupSignals"></see> for signals emitted by QButtonGroup
	/// </remarks>

	[SmokeClass("QButtonGroup")]
	public class QButtonGroup : QObject, IDisposable {
 		protected QButtonGroup(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QButtonGroup), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QButtonGroup() {
			staticInterceptor = new SmokeInvocation(typeof(QButtonGroup), null);
		}
		[Q_PROPERTY("bool", "exclusive")]
		public bool Exclusive {
			get { return (bool) interceptor.Invoke("exclusive", "exclusive()", typeof(bool)); }
			set { interceptor.Invoke("setExclusive$", "setExclusive(bool)", typeof(void), typeof(bool), value); }
		}
		public QButtonGroup(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QButtonGroup#", "QButtonGroup(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public QButtonGroup() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QButtonGroup", "QButtonGroup()", typeof(void));
		}
		public void AddButton(QAbstractButton arg1) {
			interceptor.Invoke("addButton#", "addButton(QAbstractButton*)", typeof(void), typeof(QAbstractButton), arg1);
		}
		public void AddButton(QAbstractButton arg1, int id) {
			interceptor.Invoke("addButton#$", "addButton(QAbstractButton*, int)", typeof(void), typeof(QAbstractButton), arg1, typeof(int), id);
		}
		public void RemoveButton(QAbstractButton arg1) {
			interceptor.Invoke("removeButton#", "removeButton(QAbstractButton*)", typeof(void), typeof(QAbstractButton), arg1);
		}
		public List<QAbstractButton> Buttons() {
			return (List<QAbstractButton>) interceptor.Invoke("buttons", "buttons() const", typeof(List<QAbstractButton>));
		}
		public QAbstractButton CheckedButton() {
			return (QAbstractButton) interceptor.Invoke("checkedButton", "checkedButton() const", typeof(QAbstractButton));
		}
		public QAbstractButton Button(int id) {
			return (QAbstractButton) interceptor.Invoke("button$", "button(int) const", typeof(QAbstractButton), typeof(int), id);
		}
		public void SetId(QAbstractButton button, int id) {
			interceptor.Invoke("setId#$", "setId(QAbstractButton*, int)", typeof(void), typeof(QAbstractButton), button, typeof(int), id);
		}
		public int Id(QAbstractButton button) {
			return (int) interceptor.Invoke("id#", "id(QAbstractButton*) const", typeof(int), typeof(QAbstractButton), button);
		}
		public int CheckedId() {
			return (int) interceptor.Invoke("checkedId", "checkedId() const", typeof(int));
		}
		~QButtonGroup() {
			interceptor.Invoke("~QButtonGroup", "~QButtonGroup()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QButtonGroup", "~QButtonGroup()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQButtonGroupSignals Emit {
			get { return (IQButtonGroupSignals) Q_EMIT; }
		}
	}

	public interface IQButtonGroupSignals : IQObjectSignals {
		[Q_SIGNAL("void buttonClicked(QAbstractButton*)")]
		void ButtonClicked(QAbstractButton arg1);
		[Q_SIGNAL("void buttonClicked(int)")]
		void ButtonClicked(int arg1);
		[Q_SIGNAL("void buttonPressed(QAbstractButton*)")]
		void ButtonPressed(QAbstractButton arg1);
		[Q_SIGNAL("void buttonPressed(int)")]
		void ButtonPressed(int arg1);
		[Q_SIGNAL("void buttonReleased(QAbstractButton*)")]
		void ButtonReleased(QAbstractButton arg1);
		[Q_SIGNAL("void buttonReleased(int)")]
		void ButtonReleased(int arg1);
	}
}
