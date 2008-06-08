//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;
	using System.Collections.Generic;

	/// <remarks>
	///  An editable listbox
	///  This class provides a editable listbox ;-), this means
	///  a listbox which is accompanied by a line edit to enter new
	///  items into the listbox and pushbuttons to add and remove
	///  items from the listbox and two buttons to move items up and down.
	///  \image html keditlistbox.png "KDE Edit List Box Widget"
	///   See <see cref="IKEditListBoxSignals"></see> for signals emitted by KEditListBox
	/// </remarks>		<short>    An editable listbox </short>

	[SmokeClass("KEditListBox")]
	public class KEditListBox : QGroupBox, IDisposable {
 		protected KEditListBox(Type dummy) : base((Type) null) {}

		/// <remarks>
		///  Custom editor class
		/// </remarks>		<short>    Custom editor class </short>

		[SmokeClass("KEditListBox::CustomEditor")]
		public class CustomEditor : Object {
			protected SmokeInvocation interceptor = null;
			private IntPtr smokeObject;
			protected CustomEditor(Type dummy) {}
			protected void CreateProxy() {
				interceptor = new SmokeInvocationKDE(typeof(CustomEditor), this);
			}
			//  CustomEditor(); >>>> NOT CONVERTED
			//  CustomEditor(QWidget* arg1,KLineEdit* arg2); >>>> NOT CONVERTED
			//  CustomEditor(KComboBox* arg1); >>>> NOT CONVERTED
			// QWidget * representationWidget(); >>>> NOT CONVERTED
			// KLineEdit * lineEdit(); >>>> NOT CONVERTED
			public void SetRepresentationWidget(QWidget repWidget) {
				interceptor.Invoke("setRepresentationWidget#", "setRepresentationWidget(QWidget*)", typeof(void), typeof(QWidget), repWidget);
			}
			public void SetLineEdit(KLineEdit edit) {
				interceptor.Invoke("setLineEdit#", "setLineEdit(KLineEdit*)", typeof(void), typeof(KLineEdit), edit);
			}
		}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocationKDE(typeof(KEditListBox), this);
		}
		/// <remarks>
		///  Enumeration of the buttons, the listbox offers. Specify them in the
		///  constructor in the buttons parameter, or in setButtons.
		///        </remarks>		<short>    Enumeration of the buttons, the listbox offers.</short>
		public enum Button {
			Add = 0x0001,
			Remove = 0x0002,
			UpDown = 0x0004,
			All = Add|Remove|UpDown,
		}
		[Q_PROPERTY("KEditListBox::Buttons", "buttons")]
		public uint Buttons {
			get { return (uint) interceptor.Invoke("buttons", "buttons()", typeof(uint)); }
			set { interceptor.Invoke("setButtons$", "setButtons(KEditListBox::Buttons)", typeof(void), typeof(uint), value); }
		}
		[Q_PROPERTY("QStringList", "items")]
		public List<string> Items {
			get { return (List<string>) interceptor.Invoke("items", "items()", typeof(List<string>)); }
			set { interceptor.Invoke("setItems?", "setItems(QStringList)", typeof(void), typeof(List<string>), value); }
		}
		// KEditListBox* KEditListBox(const QString& arg1,const KEditListBox::CustomEditor& arg2,QWidget* arg3,const char* arg4,bool arg5,KEditListBox::Buttons arg6); >>>> NOT CONVERTED
		// KEditListBox* KEditListBox(const QString& arg1,const KEditListBox::CustomEditor& arg2,QWidget* arg3,const char* arg4,bool arg5); >>>> NOT CONVERTED
		// KEditListBox* KEditListBox(const QString& arg1,const KEditListBox::CustomEditor& arg2,QWidget* arg3,const char* arg4); >>>> NOT CONVERTED
		// KEditListBox* KEditListBox(const QString& arg1,const KEditListBox::CustomEditor& arg2,QWidget* arg3); >>>> NOT CONVERTED
		// KEditListBox* KEditListBox(const QString& arg1,const KEditListBox::CustomEditor& arg2); >>>> NOT CONVERTED
		// void setCustomEditor(const KEditListBox::CustomEditor& arg1); >>>> NOT CONVERTED
		/// <remarks>
		///  Create an editable listbox.
		///        </remarks>		<short>    Create an editable listbox.</short>
		public KEditListBox(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KEditListBox#", "KEditListBox(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public KEditListBox() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KEditListBox", "KEditListBox()", typeof(void));
		}
		/// <remarks>
		///  Create an editable listbox.
		///  The same as the other constructor, additionally it takes
		///  <code>title</code>, which will be the title of the groupbox around the listbox.
		///        </remarks>		<short>    Create an editable listbox.</short>
		public KEditListBox(string title, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KEditListBox$#", "KEditListBox(const QString&, QWidget*)", typeof(void), typeof(string), title, typeof(QWidget), parent);
		}
		public KEditListBox(string title) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KEditListBox$", "KEditListBox(const QString&)", typeof(void), typeof(string), title);
		}
		/// <remarks>
		///  Another constructor, which allows to use a custom editing widget
		///  instead of the standard KLineEdit widget. E.g. you can use a
		///  KUrlRequester or a KComboBox as input widget. The custom
		///  editor must consist of a lineedit and optionally another widget that
		///  is used as representation. A KComboBox or a KUrlRequester have a
		///  KLineEdit as child-widget for example, so the KComboBox is used as
		///  the representation widget.
		/// </remarks>		<short>    Another constructor, which allows to use a custom editing widget  instead of the standard KLineEdit widget.</short>
		/// 		<see> KUrlRequester.CustomEditor</see>
		/// 		<see> setCustomEditor</see>
		/// <remarks>
		///  Return a pointer to the embedded QListView.
		///        </remarks>		<short>    Return a pointer to the embedded QListView.</short>
		public QListView ListView() {
			return (QListView) interceptor.Invoke("listView", "listView() const", typeof(QListView));
		}
		/// <remarks>
		///  Return a pointer to the embedded KLineEdit.
		///        </remarks>		<short>    Return a pointer to the embedded KLineEdit.</short>
		public KLineEdit LineEdit() {
			return (KLineEdit) interceptor.Invoke("lineEdit", "lineEdit() const", typeof(KLineEdit));
		}
		/// <remarks>
		///  Return a pointer to the Add button
		///        </remarks>		<short>    Return a pointer to the Add button        </short>
		public QPushButton AddButton() {
			return (QPushButton) interceptor.Invoke("addButton", "addButton() const", typeof(QPushButton));
		}
		/// <remarks>
		///  Return a pointer to the Remove button
		///        </remarks>		<short>    Return a pointer to the Remove button        </short>
		public QPushButton RemoveButton() {
			return (QPushButton) interceptor.Invoke("removeButton", "removeButton() const", typeof(QPushButton));
		}
		/// <remarks>
		///  Return a pointer to the Up button
		///        </remarks>		<short>    Return a pointer to the Up button        </short>
		public QPushButton UpButton() {
			return (QPushButton) interceptor.Invoke("upButton", "upButton() const", typeof(QPushButton));
		}
		/// <remarks>
		///  Return a pointer to the Down button
		///        </remarks>		<short>    Return a pointer to the Down button        </short>
		public QPushButton DownButton() {
			return (QPushButton) interceptor.Invoke("downButton", "downButton() const", typeof(QPushButton));
		}
		/// <remarks>
		///  See QListBox.Count()
		///        </remarks>		<short>    See QListBox.Count()        </short>
		public int Count() {
			return (int) interceptor.Invoke("count", "count() const", typeof(int));
		}
		/// <remarks>
		///  See QListBox.InsertStringList()
		///        </remarks>		<short>    See QListBox.InsertStringList()        </short>
		public void InsertStringList(List<string> list, int index) {
			interceptor.Invoke("insertStringList?$", "insertStringList(const QStringList&, int)", typeof(void), typeof(List<string>), list, typeof(int), index);
		}
		public void InsertStringList(List<string> list) {
			interceptor.Invoke("insertStringList?", "insertStringList(const QStringList&)", typeof(void), typeof(List<string>), list);
		}
		/// <remarks>
		///  See QListBox.InsertStrList()
		///        </remarks>		<short>    See QListBox.InsertStrList()        </short>
		public void InsertItem(string text, int index) {
			interceptor.Invoke("insertItem$$", "insertItem(const QString&, int)", typeof(void), typeof(string), text, typeof(int), index);
		}
		public void InsertItem(string text) {
			interceptor.Invoke("insertItem$", "insertItem(const QString&)", typeof(void), typeof(string), text);
		}
		/// <remarks>
		///  Clears both the listbox and the line edit.
		///        </remarks>		<short>    Clears both the listbox and the line edit.</short>
		public void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		/// <remarks>
		///  See QListBox.Text()
		///        </remarks>		<short>    See QListBox.Text()        </short>
		public string Text(int index) {
			return (string) interceptor.Invoke("text$", "text(int) const", typeof(string), typeof(int), index);
		}
		/// <remarks>
		///  See QListBox.CurrentItem()
		///        </remarks>		<short>    See QListBox.CurrentItem()        </short>
		public int CurrentItem() {
			return (int) interceptor.Invoke("currentItem", "currentItem() const", typeof(int));
		}
		/// <remarks>
		///  See QListBox.CurrentText()
		///        </remarks>		<short>    See QListBox.CurrentText()        </short>
		public string CurrentText() {
			return (string) interceptor.Invoke("currentText", "currentText() const", typeof(string));
		}
		/// <remarks>
		///  If <code>check</code> is true, after every character you type
		///  in the line edit KEditListBox will enable or disable
		///  the Add-button, depending whether the current content of the
		///  line edit is already in the listbox. Maybe this can become a
		///  performance hit with large lists on slow machines.
		///  If <code>check</code> is false,
		///  it will be checked if you press the Add-button. It is not
		///  possible to enter items twice into the listbox.
		///  Default is false.
		///        </remarks>		<short>    If <code>check</code> is true, after every character you type  in the line edit KEditListBox will enable or disable  the Add-button, depending whether the current content of the  line edit is already in the listbox.</short>
		public void SetCheckAtEntering(bool check) {
			interceptor.Invoke("setCheckAtEntering$", "setCheckAtEntering(bool)", typeof(void), typeof(bool), check);
		}
		/// <remarks>
		///  Returns true if check at entering is enabled.
		///        </remarks>		<short>    Returns true if check at entering is enabled.</short>
		public bool CheckAtEntering() {
			return (bool) interceptor.Invoke("checkAtEntering", "checkAtEntering()", typeof(bool));
		}
		/// <remarks>
		///  Allows to use a custom editing widget
		///  instead of the standard KLineEdit widget. E.g. you can use a
		///  KUrlRequester or a KComboBox as input widget. The custom
		///  editor must consist of a lineedit and optionally another widget that
		///  is used as representation. A KComboBox or a KUrlRequester have a
		///  KLineEdit as child-widget for example, so the KComboBox is used as
		///  the representation widget.
		/// </remarks>		<short>    Allows to use a custom editing widget  instead of the standard KLineEdit widget.</short>
		/// <remarks>
		///  Reimplented for interal reasons. The API is not affected.
		///        </remarks>		<short>    Reimplented for interal reasons.</short>
		[SmokeMethod("eventFilter(QObject*, QEvent*)")]
		public override bool EventFilter(QObject o, QEvent e) {
			return (bool) interceptor.Invoke("eventFilter##", "eventFilter(QObject*, QEvent*)", typeof(bool), typeof(QObject), o, typeof(QEvent), e);
		}
		[Q_SLOT("void moveItemUp()")]
		protected void MoveItemUp() {
			interceptor.Invoke("moveItemUp", "moveItemUp()", typeof(void));
		}
		[Q_SLOT("void moveItemDown()")]
		protected void MoveItemDown() {
			interceptor.Invoke("moveItemDown", "moveItemDown()", typeof(void));
		}
		[Q_SLOT("void addItem()")]
		protected void AddItem() {
			interceptor.Invoke("addItem", "addItem()", typeof(void));
		}
		[Q_SLOT("void removeItem()")]
		protected void RemoveItem() {
			interceptor.Invoke("removeItem", "removeItem()", typeof(void));
		}
		[Q_SLOT("void enableMoveButtons(const QModelIndex&, const QModelIndex&)")]
		protected void EnableMoveButtons(QModelIndex arg1, QModelIndex arg2) {
			interceptor.Invoke("enableMoveButtons##", "enableMoveButtons(const QModelIndex&, const QModelIndex&)", typeof(void), typeof(QModelIndex), arg1, typeof(QModelIndex), arg2);
		}
		[Q_SLOT("void typedSomething(const QString&)")]
		protected void TypedSomething(string text) {
			interceptor.Invoke("typedSomething$", "typedSomething(const QString&)", typeof(void), typeof(string), text);
		}
		~KEditListBox() {
			interceptor.Invoke("~KEditListBox", "~KEditListBox()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KEditListBox", "~KEditListBox()", typeof(void));
		}
		protected new IKEditListBoxSignals Emit {
			get { return (IKEditListBoxSignals) Q_EMIT; }
		}
	}

	public interface IKEditListBoxSignals : IQGroupBoxSignals {
		[Q_SIGNAL("void changed()")]
		void Changed();
		/// <remarks>
		///  This signal is emitted when the user adds a new string to the list,
		///  the parameter is the added string.
		///        </remarks>		<short>    This signal is emitted when the user adds a new string to the list,  the parameter is the added string.</short>
		[Q_SIGNAL("void added(const QString&)")]
		void Added(string text);
		/// <remarks>
		///  This signal is emitted when the user removes a string from the list,
		///  the parameter is the removed string.
		///        </remarks>		<short>    This signal is emitted when the user removes a string from the list,  the parameter is the removed string.</short>
		[Q_SIGNAL("void removed(const QString&)")]
		void Removed(string text);
	}
}
