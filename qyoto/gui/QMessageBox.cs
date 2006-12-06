//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QMessageBox")]
	public class QMessageBox : QDialog, IDisposable {
 		protected QMessageBox(Type dummy) : base((Type) null) {}
		interface IQMessageBoxProxy {
			string Tr(string s, string c);
			string Tr(string s);
			QMessageBox.StandardButton Information(QWidget parent, string title, string text, int buttons, QMessageBox.StandardButton defaultButton);
			QMessageBox.StandardButton Information(QWidget parent, string title, string text, int buttons);
			QMessageBox.StandardButton Information(QWidget parent, string title, string text);
			QMessageBox.StandardButton Question(QWidget parent, string title, string text, int buttons, QMessageBox.StandardButton defaultButton);
			QMessageBox.StandardButton Question(QWidget parent, string title, string text, int buttons);
			QMessageBox.StandardButton Question(QWidget parent, string title, string text);
			QMessageBox.StandardButton Warning(QWidget parent, string title, string text, int buttons, QMessageBox.StandardButton defaultButton);
			QMessageBox.StandardButton Warning(QWidget parent, string title, string text, int buttons);
			QMessageBox.StandardButton Warning(QWidget parent, string title, string text);
			QMessageBox.StandardButton Critical(QWidget parent, string title, string text, int buttons, QMessageBox.StandardButton defaultButton);
			QMessageBox.StandardButton Critical(QWidget parent, string title, string text, int buttons);
			QMessageBox.StandardButton Critical(QWidget parent, string title, string text);
			void About(QWidget parent, string title, string text);
			void AboutQt(QWidget parent, string title);
			void AboutQt(QWidget parent);
			int Information(QWidget parent, string title, string text, int button0, int button1, int button2);
			int Information(QWidget parent, string title, string text, int button0, int button1);
			int Information(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber, int escapeButtonNumber);
			int Information(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber);
			int Information(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text);
			int Information(QWidget parent, string title, string text, string button0Text, string button1Text);
			int Information(QWidget parent, string title, string text, string button0Text);
			QMessageBox.StandardButton Information(QWidget parent, string title, string text, QMessageBox.StandardButton button0, QMessageBox.StandardButton button1);
			QMessageBox.StandardButton Information(QWidget parent, string title, string text, QMessageBox.StandardButton button0);
			int Question(QWidget parent, string title, string text, int button0, int button1, int button2);
			int Question(QWidget parent, string title, string text, int button0, int button1);
			int Question(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber, int escapeButtonNumber);
			int Question(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber);
			int Question(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text);
			int Question(QWidget parent, string title, string text, string button0Text, string button1Text);
			int Question(QWidget parent, string title, string text, string button0Text);
			int Question(QWidget parent, string title, string text, QMessageBox.StandardButton button0, QMessageBox.StandardButton button1);
			int Warning(QWidget parent, string title, string text, int button0, int button1, int button2);
			int Warning(QWidget parent, string title, string text, int button0, int button1);
			int Warning(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber, int escapeButtonNumber);
			int Warning(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber);
			int Warning(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text);
			int Warning(QWidget parent, string title, string text, string button0Text, string button1Text);
			int Warning(QWidget parent, string title, string text, string button0Text);
			int Warning(QWidget parent, string title, string text, QMessageBox.StandardButton button0, QMessageBox.StandardButton button1);
			int Critical(QWidget parent, string title, string text, int button0, int button1, int button2);
			int Critical(QWidget parent, string title, string text, int button0, int button1);
			int Critical(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber, int escapeButtonNumber);
			int Critical(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber);
			int Critical(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text);
			int Critical(QWidget parent, string title, string text, string button0Text, string button1Text);
			int Critical(QWidget parent, string title, string text, string button0Text);
			int Critical(QWidget parent, string title, string text, QMessageBox.StandardButton button0, QMessageBox.StandardButton button1);
			QPixmap StandardIcon(QMessageBox.Icon icon);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QMessageBox), this);
			_interceptor = (QMessageBox) realProxy.GetTransparentProxy();
		}
		private QMessageBox ProxyQMessageBox() {
			return (QMessageBox) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QMessageBox() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQMessageBoxProxy), null);
			_staticInterceptor = (IQMessageBoxProxy) realProxy.GetTransparentProxy();
		}
		private static IQMessageBoxProxy StaticQMessageBox() {
			return (IQMessageBoxProxy) _staticInterceptor;
		}

		public enum Icon {
			NoIcon = 0,
			Information = 1,
			Warning = 2,
			Critical = 3,
			Question = 4,
		}
		public enum ButtonRole {
			InvalidRole = -1,
			AcceptRole = 0,
			RejectRole = 1,
			DestructiveRole = 2,
			ActionRole = 3,
			HelpRole = 4,
			YesRole = 5,
			NoRole = 6,
			ResetRole = 7,
			ApplyRole = 8,
			NRoles = 9,
		}
		public enum StandardButton {
			NoButton = 0x00000000,
			Ok = 0x00000400,
			Save = 0x00000800,
			SaveAll = 0x00001000,
			Open = 0x00002000,
			Yes = 0x00004000,
			YesToAll = 0x00008000,
			No = 0x00010000,
			NoToAll = 0x00020000,
			Abort = 0x00040000,
			Retry = 0x00080000,
			Ignore = 0x00100000,
			Close = 0x00200000,
			Cancel = 0x00400000,
			Discard = 0x00800000,
			Help = 0x01000000,
			Apply = 0x02000000,
			Reset = 0x04000000,
			RestoreDefaults = 0x08000000,
			FirstButton = Ok,
			LastButton = RestoreDefaults,
			YesAll = YesToAll,
			NoAll = NoToAll,
			Default = 0x00000100,
			Escape = 0x00000200,
			FlagMask = 0x00000300,
			ButtonMask = ~FlagMask,
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QMessageBox(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQMessageBox(parent);
		}
		[SmokeMethod("QMessageBox(QWidget*)")]
		private void NewQMessageBox(QWidget parent) {
			ProxyQMessageBox().NewQMessageBox(parent);
		}
		public QMessageBox() : this((Type) null) {
			CreateProxy();
			NewQMessageBox();
		}
		[SmokeMethod("QMessageBox()")]
		private void NewQMessageBox() {
			ProxyQMessageBox().NewQMessageBox();
		}
		public QMessageBox(QMessageBox.Icon icon, string title, string text, int buttons, QWidget parent, int f) : this((Type) null) {
			CreateProxy();
			NewQMessageBox(icon,title,text,buttons,parent,f);
		}
		[SmokeMethod("QMessageBox(QMessageBox::Icon, const QString&, const QString&, StandardButtons, QWidget*, Qt::WindowFlags)")]
		private void NewQMessageBox(QMessageBox.Icon icon, string title, string text, int buttons, QWidget parent, int f) {
			ProxyQMessageBox().NewQMessageBox(icon,title,text,buttons,parent,f);
		}
		public QMessageBox(QMessageBox.Icon icon, string title, string text, int buttons, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQMessageBox(icon,title,text,buttons,parent);
		}
		[SmokeMethod("QMessageBox(QMessageBox::Icon, const QString&, const QString&, StandardButtons, QWidget*)")]
		private void NewQMessageBox(QMessageBox.Icon icon, string title, string text, int buttons, QWidget parent) {
			ProxyQMessageBox().NewQMessageBox(icon,title,text,buttons,parent);
		}
		public QMessageBox(QMessageBox.Icon icon, string title, string text, int buttons) : this((Type) null) {
			CreateProxy();
			NewQMessageBox(icon,title,text,buttons);
		}
		[SmokeMethod("QMessageBox(QMessageBox::Icon, const QString&, const QString&, StandardButtons)")]
		private void NewQMessageBox(QMessageBox.Icon icon, string title, string text, int buttons) {
			ProxyQMessageBox().NewQMessageBox(icon,title,text,buttons);
		}
		public QMessageBox(QMessageBox.Icon icon, string title, string text) : this((Type) null) {
			CreateProxy();
			NewQMessageBox(icon,title,text);
		}
		[SmokeMethod("QMessageBox(QMessageBox::Icon, const QString&, const QString&)")]
		private void NewQMessageBox(QMessageBox.Icon icon, string title, string text) {
			ProxyQMessageBox().NewQMessageBox(icon,title,text);
		}
		[SmokeMethod("addButton(QAbstractButton*, QMessageBox::ButtonRole)")]
		public void AddButton(QAbstractButton button, QMessageBox.ButtonRole role) {
			ProxyQMessageBox().AddButton(button,role);
		}
		[SmokeMethod("addButton(const QString&, QMessageBox::ButtonRole)")]
		public QPushButton AddButton(string text, QMessageBox.ButtonRole role) {
			return ProxyQMessageBox().AddButton(text,role);
		}
		[SmokeMethod("addButton(QMessageBox::StandardButton)")]
		public QPushButton AddButton(QMessageBox.StandardButton button) {
			return ProxyQMessageBox().AddButton(button);
		}
		[SmokeMethod("removeButton(QAbstractButton*)")]
		public void RemoveButton(QAbstractButton button) {
			ProxyQMessageBox().RemoveButton(button);
		}
		[SmokeMethod("setStandardButtons(StandardButtons)")]
		public void SetStandardButtons(int buttons) {
			ProxyQMessageBox().SetStandardButtons(buttons);
		}
		[SmokeMethod("standardButtons() const")]
		public int StandardButtons() {
			return ProxyQMessageBox().StandardButtons();
		}
		[SmokeMethod("standardButton(QAbstractButton*) const")]
		public QMessageBox.StandardButton standardButton(QAbstractButton button) {
			return ProxyQMessageBox().standardButton(button);
		}
		[SmokeMethod("button(QMessageBox::StandardButton) const")]
		public QAbstractButton Button(QMessageBox.StandardButton which) {
			return ProxyQMessageBox().Button(which);
		}
		[SmokeMethod("defaultButton() const")]
		public QPushButton DefaultButton() {
			return ProxyQMessageBox().DefaultButton();
		}
		[SmokeMethod("setDefaultButton(QPushButton*)")]
		public void SetDefaultButton(QPushButton button) {
			ProxyQMessageBox().SetDefaultButton(button);
		}
		[SmokeMethod("escapeButton() const")]
		public QAbstractButton EscapeButton() {
			return ProxyQMessageBox().EscapeButton();
		}
		[SmokeMethod("setEscapeButton(QAbstractButton*)")]
		public void SetEscapeButton(QAbstractButton button) {
			ProxyQMessageBox().SetEscapeButton(button);
		}
		[SmokeMethod("clickedButton() const")]
		public QAbstractButton ClickedButton() {
			return ProxyQMessageBox().ClickedButton();
		}
		[SmokeMethod("text() const")]
		public string Text() {
			return ProxyQMessageBox().Text();
		}
		[SmokeMethod("setText(const QString&)")]
		public void SetText(string text) {
			ProxyQMessageBox().SetText(text);
		}
		[SmokeMethod("icon() const")]
		public QMessageBox.Icon IconId() {
			return ProxyQMessageBox().IconId();
		}
		[SmokeMethod("setIcon(QMessageBox::Icon)")]
		public void SetIcon(QMessageBox.Icon arg1) {
			ProxyQMessageBox().SetIcon(arg1);
		}
		[SmokeMethod("iconPixmap() const")]
		public QPixmap IconPixmap() {
			return ProxyQMessageBox().IconPixmap();
		}
		[SmokeMethod("setIconPixmap(const QPixmap&)")]
		public void SetIconPixmap(QPixmap pixmap) {
			ProxyQMessageBox().SetIconPixmap(pixmap);
		}
		[SmokeMethod("textFormat() const")]
		public Qt.TextFormat TextFormat() {
			return ProxyQMessageBox().TextFormat();
		}
		[SmokeMethod("setTextFormat(Qt::TextFormat)")]
		public void SetTextFormat(Qt.TextFormat format) {
			ProxyQMessageBox().SetTextFormat(format);
		}
		[SmokeMethod("sizeHint() const")]
		public new QSize SizeHint() {
			return ProxyQMessageBox().SizeHint();
		}
		public QMessageBox(string title, string text, QMessageBox.Icon icon, int button0, int button1, int button2, QWidget parent, int f) : this((Type) null) {
			CreateProxy();
			NewQMessageBox(title,text,icon,button0,button1,button2,parent,f);
		}
		[SmokeMethod("QMessageBox(const QString&, const QString&, QMessageBox::Icon, int, int, int, QWidget*, Qt::WindowFlags)")]
		private void NewQMessageBox(string title, string text, QMessageBox.Icon icon, int button0, int button1, int button2, QWidget parent, int f) {
			ProxyQMessageBox().NewQMessageBox(title,text,icon,button0,button1,button2,parent,f);
		}
		public QMessageBox(string title, string text, QMessageBox.Icon icon, int button0, int button1, int button2, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQMessageBox(title,text,icon,button0,button1,button2,parent);
		}
		[SmokeMethod("QMessageBox(const QString&, const QString&, QMessageBox::Icon, int, int, int, QWidget*)")]
		private void NewQMessageBox(string title, string text, QMessageBox.Icon icon, int button0, int button1, int button2, QWidget parent) {
			ProxyQMessageBox().NewQMessageBox(title,text,icon,button0,button1,button2,parent);
		}
		public QMessageBox(string title, string text, QMessageBox.Icon icon, int button0, int button1, int button2) : this((Type) null) {
			CreateProxy();
			NewQMessageBox(title,text,icon,button0,button1,button2);
		}
		[SmokeMethod("QMessageBox(const QString&, const QString&, QMessageBox::Icon, int, int, int)")]
		private void NewQMessageBox(string title, string text, QMessageBox.Icon icon, int button0, int button1, int button2) {
			ProxyQMessageBox().NewQMessageBox(title,text,icon,button0,button1,button2);
		}
		[SmokeMethod("buttonText(int) const")]
		public string ButtonText(int button) {
			return ProxyQMessageBox().ButtonText(button);
		}
		[SmokeMethod("setButtonText(int, const QString&)")]
		public void SetButtonText(int button, string text) {
			ProxyQMessageBox().SetButtonText(button,text);
		}
		[SmokeMethod("informativeText() const")]
		public string InformativeText() {
			return ProxyQMessageBox().InformativeText();
		}
		[SmokeMethod("setInformativeText(const QString&)")]
		public void SetInformativeText(string text) {
			ProxyQMessageBox().SetInformativeText(text);
		}
		[SmokeMethod("detailedText() const")]
		public string DetailedText() {
			return ProxyQMessageBox().DetailedText();
		}
		[SmokeMethod("setDetailedText(const QString&)")]
		public void SetDetailedText(string text) {
			ProxyQMessageBox().SetDetailedText(text);
		}
		[SmokeMethod("setWindowTitle(const QString&)")]
		public new void SetWindowTitle(string title) {
			ProxyQMessageBox().SetWindowTitle(title);
		}
		[SmokeMethod("setWindowModality(Qt::WindowModality)")]
		public new void SetWindowModality(Qt.WindowModality windowModality) {
			ProxyQMessageBox().SetWindowModality(windowModality);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQMessageBox().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQMessageBox().Tr(s);
		}
		[SmokeMethod("information(QWidget*, const QString&, const QString&, StandardButtons, QMessageBox::StandardButton)")]
		public static QMessageBox.StandardButton Information(QWidget parent, string title, string text, int buttons, QMessageBox.StandardButton defaultButton) {
			return StaticQMessageBox().Information(parent,title,text,buttons,defaultButton);
		}
		[SmokeMethod("information(QWidget*, const QString&, const QString&, StandardButtons)")]
		public static QMessageBox.StandardButton Information(QWidget parent, string title, string text, int buttons) {
			return StaticQMessageBox().Information(parent,title,text,buttons);
		}
		[SmokeMethod("information(QWidget*, const QString&, const QString&)")]
		public static QMessageBox.StandardButton Information(QWidget parent, string title, string text) {
			return StaticQMessageBox().Information(parent,title,text);
		}
		[SmokeMethod("question(QWidget*, const QString&, const QString&, StandardButtons, QMessageBox::StandardButton)")]
		public static QMessageBox.StandardButton Question(QWidget parent, string title, string text, int buttons, QMessageBox.StandardButton defaultButton) {
			return StaticQMessageBox().Question(parent,title,text,buttons,defaultButton);
		}
		[SmokeMethod("question(QWidget*, const QString&, const QString&, StandardButtons)")]
		public static QMessageBox.StandardButton Question(QWidget parent, string title, string text, int buttons) {
			return StaticQMessageBox().Question(parent,title,text,buttons);
		}
		[SmokeMethod("question(QWidget*, const QString&, const QString&)")]
		public static QMessageBox.StandardButton Question(QWidget parent, string title, string text) {
			return StaticQMessageBox().Question(parent,title,text);
		}
		[SmokeMethod("warning(QWidget*, const QString&, const QString&, StandardButtons, QMessageBox::StandardButton)")]
		public static QMessageBox.StandardButton Warning(QWidget parent, string title, string text, int buttons, QMessageBox.StandardButton defaultButton) {
			return StaticQMessageBox().Warning(parent,title,text,buttons,defaultButton);
		}
		[SmokeMethod("warning(QWidget*, const QString&, const QString&, StandardButtons)")]
		public static QMessageBox.StandardButton Warning(QWidget parent, string title, string text, int buttons) {
			return StaticQMessageBox().Warning(parent,title,text,buttons);
		}
		[SmokeMethod("warning(QWidget*, const QString&, const QString&)")]
		public static QMessageBox.StandardButton Warning(QWidget parent, string title, string text) {
			return StaticQMessageBox().Warning(parent,title,text);
		}
		[SmokeMethod("critical(QWidget*, const QString&, const QString&, StandardButtons, QMessageBox::StandardButton)")]
		public static QMessageBox.StandardButton Critical(QWidget parent, string title, string text, int buttons, QMessageBox.StandardButton defaultButton) {
			return StaticQMessageBox().Critical(parent,title,text,buttons,defaultButton);
		}
		[SmokeMethod("critical(QWidget*, const QString&, const QString&, StandardButtons)")]
		public static QMessageBox.StandardButton Critical(QWidget parent, string title, string text, int buttons) {
			return StaticQMessageBox().Critical(parent,title,text,buttons);
		}
		[SmokeMethod("critical(QWidget*, const QString&, const QString&)")]
		public static QMessageBox.StandardButton Critical(QWidget parent, string title, string text) {
			return StaticQMessageBox().Critical(parent,title,text);
		}
		[SmokeMethod("about(QWidget*, const QString&, const QString&)")]
		public static void About(QWidget parent, string title, string text) {
			StaticQMessageBox().About(parent,title,text);
		}
		[SmokeMethod("aboutQt(QWidget*, const QString&)")]
		public static void AboutQt(QWidget parent, string title) {
			StaticQMessageBox().AboutQt(parent,title);
		}
		[SmokeMethod("aboutQt(QWidget*)")]
		public static void AboutQt(QWidget parent) {
			StaticQMessageBox().AboutQt(parent);
		}
		[SmokeMethod("information(QWidget*, const QString&, const QString&, int, int, int)")]
		public static int Information(QWidget parent, string title, string text, int button0, int button1, int button2) {
			return StaticQMessageBox().Information(parent,title,text,button0,button1,button2);
		}
		[SmokeMethod("information(QWidget*, const QString&, const QString&, int, int)")]
		public static int Information(QWidget parent, string title, string text, int button0, int button1) {
			return StaticQMessageBox().Information(parent,title,text,button0,button1);
		}
		[SmokeMethod("information(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&, int, int)")]
		public static int Information(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber, int escapeButtonNumber) {
			return StaticQMessageBox().Information(parent,title,text,button0Text,button1Text,button2Text,defaultButtonNumber,escapeButtonNumber);
		}
		[SmokeMethod("information(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&, int)")]
		public static int Information(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber) {
			return StaticQMessageBox().Information(parent,title,text,button0Text,button1Text,button2Text,defaultButtonNumber);
		}
		[SmokeMethod("information(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&)")]
		public static int Information(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text) {
			return StaticQMessageBox().Information(parent,title,text,button0Text,button1Text,button2Text);
		}
		[SmokeMethod("information(QWidget*, const QString&, const QString&, const QString&, const QString&)")]
		public static int Information(QWidget parent, string title, string text, string button0Text, string button1Text) {
			return StaticQMessageBox().Information(parent,title,text,button0Text,button1Text);
		}
		[SmokeMethod("information(QWidget*, const QString&, const QString&, const QString&)")]
		public static int Information(QWidget parent, string title, string text, string button0Text) {
			return StaticQMessageBox().Information(parent,title,text,button0Text);
		}
		[SmokeMethod("information(QWidget*, const QString&, const QString&, QMessageBox::StandardButton, QMessageBox::StandardButton)")]
		public static QMessageBox.StandardButton Information(QWidget parent, string title, string text, QMessageBox.StandardButton button0, QMessageBox.StandardButton button1) {
			return StaticQMessageBox().Information(parent,title,text,button0,button1);
		}
		[SmokeMethod("information(QWidget*, const QString&, const QString&, QMessageBox::StandardButton)")]
		public static QMessageBox.StandardButton Information(QWidget parent, string title, string text, QMessageBox.StandardButton button0) {
			return StaticQMessageBox().Information(parent,title,text,button0);
		}
		[SmokeMethod("question(QWidget*, const QString&, const QString&, int, int, int)")]
		public static int Question(QWidget parent, string title, string text, int button0, int button1, int button2) {
			return StaticQMessageBox().Question(parent,title,text,button0,button1,button2);
		}
		[SmokeMethod("question(QWidget*, const QString&, const QString&, int, int)")]
		public static int Question(QWidget parent, string title, string text, int button0, int button1) {
			return StaticQMessageBox().Question(parent,title,text,button0,button1);
		}
		[SmokeMethod("question(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&, int, int)")]
		public static int Question(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber, int escapeButtonNumber) {
			return StaticQMessageBox().Question(parent,title,text,button0Text,button1Text,button2Text,defaultButtonNumber,escapeButtonNumber);
		}
		[SmokeMethod("question(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&, int)")]
		public static int Question(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber) {
			return StaticQMessageBox().Question(parent,title,text,button0Text,button1Text,button2Text,defaultButtonNumber);
		}
		[SmokeMethod("question(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&)")]
		public static int Question(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text) {
			return StaticQMessageBox().Question(parent,title,text,button0Text,button1Text,button2Text);
		}
		[SmokeMethod("question(QWidget*, const QString&, const QString&, const QString&, const QString&)")]
		public static int Question(QWidget parent, string title, string text, string button0Text, string button1Text) {
			return StaticQMessageBox().Question(parent,title,text,button0Text,button1Text);
		}
		[SmokeMethod("question(QWidget*, const QString&, const QString&, const QString&)")]
		public static int Question(QWidget parent, string title, string text, string button0Text) {
			return StaticQMessageBox().Question(parent,title,text,button0Text);
		}
		[SmokeMethod("question(QWidget*, const QString&, const QString&, QMessageBox::StandardButton, QMessageBox::StandardButton)")]
		public static int Question(QWidget parent, string title, string text, QMessageBox.StandardButton button0, QMessageBox.StandardButton button1) {
			return StaticQMessageBox().Question(parent,title,text,button0,button1);
		}
		[SmokeMethod("warning(QWidget*, const QString&, const QString&, int, int, int)")]
		public static int Warning(QWidget parent, string title, string text, int button0, int button1, int button2) {
			return StaticQMessageBox().Warning(parent,title,text,button0,button1,button2);
		}
		[SmokeMethod("warning(QWidget*, const QString&, const QString&, int, int)")]
		public static int Warning(QWidget parent, string title, string text, int button0, int button1) {
			return StaticQMessageBox().Warning(parent,title,text,button0,button1);
		}
		[SmokeMethod("warning(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&, int, int)")]
		public static int Warning(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber, int escapeButtonNumber) {
			return StaticQMessageBox().Warning(parent,title,text,button0Text,button1Text,button2Text,defaultButtonNumber,escapeButtonNumber);
		}
		[SmokeMethod("warning(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&, int)")]
		public static int Warning(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber) {
			return StaticQMessageBox().Warning(parent,title,text,button0Text,button1Text,button2Text,defaultButtonNumber);
		}
		[SmokeMethod("warning(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&)")]
		public static int Warning(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text) {
			return StaticQMessageBox().Warning(parent,title,text,button0Text,button1Text,button2Text);
		}
		[SmokeMethod("warning(QWidget*, const QString&, const QString&, const QString&, const QString&)")]
		public static int Warning(QWidget parent, string title, string text, string button0Text, string button1Text) {
			return StaticQMessageBox().Warning(parent,title,text,button0Text,button1Text);
		}
		[SmokeMethod("warning(QWidget*, const QString&, const QString&, const QString&)")]
		public static int Warning(QWidget parent, string title, string text, string button0Text) {
			return StaticQMessageBox().Warning(parent,title,text,button0Text);
		}
		[SmokeMethod("warning(QWidget*, const QString&, const QString&, QMessageBox::StandardButton, QMessageBox::StandardButton)")]
		public static int Warning(QWidget parent, string title, string text, QMessageBox.StandardButton button0, QMessageBox.StandardButton button1) {
			return StaticQMessageBox().Warning(parent,title,text,button0,button1);
		}
		[SmokeMethod("critical(QWidget*, const QString&, const QString&, int, int, int)")]
		public static int Critical(QWidget parent, string title, string text, int button0, int button1, int button2) {
			return StaticQMessageBox().Critical(parent,title,text,button0,button1,button2);
		}
		[SmokeMethod("critical(QWidget*, const QString&, const QString&, int, int)")]
		public static int Critical(QWidget parent, string title, string text, int button0, int button1) {
			return StaticQMessageBox().Critical(parent,title,text,button0,button1);
		}
		[SmokeMethod("critical(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&, int, int)")]
		public static int Critical(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber, int escapeButtonNumber) {
			return StaticQMessageBox().Critical(parent,title,text,button0Text,button1Text,button2Text,defaultButtonNumber,escapeButtonNumber);
		}
		[SmokeMethod("critical(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&, int)")]
		public static int Critical(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber) {
			return StaticQMessageBox().Critical(parent,title,text,button0Text,button1Text,button2Text,defaultButtonNumber);
		}
		[SmokeMethod("critical(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&)")]
		public static int Critical(QWidget parent, string title, string text, string button0Text, string button1Text, string button2Text) {
			return StaticQMessageBox().Critical(parent,title,text,button0Text,button1Text,button2Text);
		}
		[SmokeMethod("critical(QWidget*, const QString&, const QString&, const QString&, const QString&)")]
		public static int Critical(QWidget parent, string title, string text, string button0Text, string button1Text) {
			return StaticQMessageBox().Critical(parent,title,text,button0Text,button1Text);
		}
		[SmokeMethod("critical(QWidget*, const QString&, const QString&, const QString&)")]
		public static int Critical(QWidget parent, string title, string text, string button0Text) {
			return StaticQMessageBox().Critical(parent,title,text,button0Text);
		}
		[SmokeMethod("critical(QWidget*, const QString&, const QString&, QMessageBox::StandardButton, QMessageBox::StandardButton)")]
		public static int Critical(QWidget parent, string title, string text, QMessageBox.StandardButton button0, QMessageBox.StandardButton button1) {
			return StaticQMessageBox().Critical(parent,title,text,button0,button1);
		}
		[SmokeMethod("standardIcon(QMessageBox::Icon)")]
		public static QPixmap StandardIcon(QMessageBox.Icon icon) {
			return StaticQMessageBox().StandardIcon(icon);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected new void ResizeEvent(QResizeEvent arg1) {
			ProxyQMessageBox().ResizeEvent(arg1);
		}
		[SmokeMethod("showEvent(QShowEvent*)")]
		public new void ShowEvent(QShowEvent arg1) {
			ProxyQMessageBox().ShowEvent(arg1);
		}
		[SmokeMethod("closeEvent(QCloseEvent*)")]
		protected new void CloseEvent(QCloseEvent arg1) {
			ProxyQMessageBox().CloseEvent(arg1);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected new void KeyPressEvent(QKeyEvent arg1) {
			ProxyQMessageBox().KeyPressEvent(arg1);
		}
		[SmokeMethod("changeEvent(QEvent*)")]
		protected new void ChangeEvent(QEvent arg1) {
			ProxyQMessageBox().ChangeEvent(arg1);
		}
		~QMessageBox() {
			DisposeQMessageBox();
		}
		public new void Dispose() {
			DisposeQMessageBox();
		}
		[SmokeMethod("~QMessageBox()")]
		private void DisposeQMessageBox() {
			ProxyQMessageBox().DisposeQMessageBox();
		}
		protected new IQMessageBoxSignals Emit() {
			return (IQMessageBoxSignals) Q_EMIT;
		}
	}

	public interface IQMessageBoxSignals : IQDialogSignals {
	}
}
