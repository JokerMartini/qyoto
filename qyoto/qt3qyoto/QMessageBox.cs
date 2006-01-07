//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QMessageBox")]
	public class QMessageBox : QDialog, IDisposable {
 		protected QMessageBox(Type dummy) : base((Type) null) {}
		interface IQMessageBoxProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
			int Information(QWidget parent, string caption, string text, int button0, int button1, int button2);
			int Information(QWidget parent, string caption, string text, int button0, int button1);
			int Information(QWidget parent, string caption, string text, int button0);
			int Information(QWidget parent, string caption, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber, int escapeButtonNumber);
			int Information(QWidget parent, string caption, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber);
			int Information(QWidget parent, string caption, string text, string button0Text, string button1Text, string button2Text);
			int Information(QWidget parent, string caption, string text, string button0Text, string button1Text);
			int Information(QWidget parent, string caption, string text, string button0Text);
			int Information(QWidget parent, string caption, string text);
			int Question(QWidget parent, string caption, string text, int button0, int button1, int button2);
			int Question(QWidget parent, string caption, string text, int button0, int button1);
			int Question(QWidget parent, string caption, string text, int button0);
			int Question(QWidget parent, string caption, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber, int escapeButtonNumber);
			int Question(QWidget parent, string caption, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber);
			int Question(QWidget parent, string caption, string text, string button0Text, string button1Text, string button2Text);
			int Question(QWidget parent, string caption, string text, string button0Text, string button1Text);
			int Question(QWidget parent, string caption, string text, string button0Text);
			int Question(QWidget parent, string caption, string text);
			int Warning(QWidget parent, string caption, string text, int button0, int button1, int button2);
			int Warning(QWidget parent, string caption, string text, int button0, int button1);
			int Warning(QWidget parent, string caption, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber, int escapeButtonNumber);
			int Warning(QWidget parent, string caption, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber);
			int Warning(QWidget parent, string caption, string text, string button0Text, string button1Text, string button2Text);
			int Warning(QWidget parent, string caption, string text, string button0Text, string button1Text);
			int Warning(QWidget parent, string caption, string text, string button0Text);
			int Warning(QWidget parent, string caption, string text);
			int Critical(QWidget parent, string caption, string text, int button0, int button1, int button2);
			int Critical(QWidget parent, string caption, string text, int button0, int button1);
			int Critical(QWidget parent, string caption, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber, int escapeButtonNumber);
			int Critical(QWidget parent, string caption, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber);
			int Critical(QWidget parent, string caption, string text, string button0Text, string button1Text, string button2Text);
			int Critical(QWidget parent, string caption, string text, string button0Text, string button1Text);
			int Critical(QWidget parent, string caption, string text, string button0Text);
			int Critical(QWidget parent, string caption, string text);
			void About(QWidget parent, string caption, string text);
			void AboutQt(QWidget parent, string caption);
			void AboutQt(QWidget parent);
			int Message(string caption, string text, string buttonText, QWidget parent, string arg5);
			int Message(string caption, string text, string buttonText, QWidget parent);
			int Message(string caption, string text, string buttonText);
			int Message(string caption, string text);
			bool Query(string caption, string text, string yesButtonText, string noButtonText, QWidget parent, string arg6);
			bool Query(string caption, string text, string yesButtonText, string noButtonText, QWidget parent);
			bool Query(string caption, string text, string yesButtonText, string noButtonText);
			bool Query(string caption, string text, string yesButtonText);
			bool Query(string caption, string text);
			QPixmap StandardIcon(QMessageBox.Icon icon, Qt.GUIStyle arg2);
			QPixmap StandardIcon(QMessageBox.Icon icon);
		}

		protected void CreateQMessageBoxProxy() {
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

		public const int NoButton = 0;
		public const int Ok = 1;
		public const int Cancel = 2;
		public const int Yes = 3;
		public const int No = 4;
		public const int Abort = 5;
		public const int Retry = 6;
		public const int Ignore = 7;
		public const int YesAll = 8;
		public const int NoAll = 9;
		public const int ButtonMask = 0xff;
		public const int Default = 0x100;
		public const int Escape = 0x200;
		public const int FlagMask = 0x300;

		public enum Icon {
			NoIcon = 0,
			Information = 1,
			Warning = 2,
			Critical = 3,
			Question = 4,
		}
		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQMessageBox().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQMessageBox().ClassName();
		}
		public QMessageBox(QWidget parent, string name) : this((Type) null) {
			CreateQMessageBoxProxy();
			CreateQMessageBoxSignalProxy();
			NewQMessageBox(parent,name);
		}
		[SmokeMethod("QMessageBox(QWidget*, const char*)")]
		private void NewQMessageBox(QWidget parent, string name) {
			ProxyQMessageBox().NewQMessageBox(parent,name);
		}
		public QMessageBox(QWidget parent) : this((Type) null) {
			CreateQMessageBoxProxy();
			CreateQMessageBoxSignalProxy();
			NewQMessageBox(parent);
		}
		[SmokeMethod("QMessageBox(QWidget*)")]
		private void NewQMessageBox(QWidget parent) {
			ProxyQMessageBox().NewQMessageBox(parent);
		}
		public QMessageBox() : this((Type) null) {
			CreateQMessageBoxProxy();
			CreateQMessageBoxSignalProxy();
			NewQMessageBox();
		}
		[SmokeMethod("QMessageBox()")]
		private void NewQMessageBox() {
			ProxyQMessageBox().NewQMessageBox();
		}
		public QMessageBox(string caption, string text, QMessageBox.Icon icon, int button0, int button1, int button2, QWidget parent, string name, bool modal, int f) : this((Type) null) {
			CreateQMessageBoxProxy();
			CreateQMessageBoxSignalProxy();
			NewQMessageBox(caption,text,icon,button0,button1,button2,parent,name,modal,f);
		}
		[SmokeMethod("QMessageBox(const QString&, const QString&, QMessageBox::Icon, int, int, int, QWidget*, const char*, bool, Qt::WFlags)")]
		private void NewQMessageBox(string caption, string text, QMessageBox.Icon icon, int button0, int button1, int button2, QWidget parent, string name, bool modal, int f) {
			ProxyQMessageBox().NewQMessageBox(caption,text,icon,button0,button1,button2,parent,name,modal,f);
		}
		public QMessageBox(string caption, string text, QMessageBox.Icon icon, int button0, int button1, int button2, QWidget parent, string name, bool modal) : this((Type) null) {
			CreateQMessageBoxProxy();
			CreateQMessageBoxSignalProxy();
			NewQMessageBox(caption,text,icon,button0,button1,button2,parent,name,modal);
		}
		[SmokeMethod("QMessageBox(const QString&, const QString&, QMessageBox::Icon, int, int, int, QWidget*, const char*, bool)")]
		private void NewQMessageBox(string caption, string text, QMessageBox.Icon icon, int button0, int button1, int button2, QWidget parent, string name, bool modal) {
			ProxyQMessageBox().NewQMessageBox(caption,text,icon,button0,button1,button2,parent,name,modal);
		}
		public QMessageBox(string caption, string text, QMessageBox.Icon icon, int button0, int button1, int button2, QWidget parent, string name) : this((Type) null) {
			CreateQMessageBoxProxy();
			CreateQMessageBoxSignalProxy();
			NewQMessageBox(caption,text,icon,button0,button1,button2,parent,name);
		}
		[SmokeMethod("QMessageBox(const QString&, const QString&, QMessageBox::Icon, int, int, int, QWidget*, const char*)")]
		private void NewQMessageBox(string caption, string text, QMessageBox.Icon icon, int button0, int button1, int button2, QWidget parent, string name) {
			ProxyQMessageBox().NewQMessageBox(caption,text,icon,button0,button1,button2,parent,name);
		}
		public QMessageBox(string caption, string text, QMessageBox.Icon icon, int button0, int button1, int button2, QWidget parent) : this((Type) null) {
			CreateQMessageBoxProxy();
			CreateQMessageBoxSignalProxy();
			NewQMessageBox(caption,text,icon,button0,button1,button2,parent);
		}
		[SmokeMethod("QMessageBox(const QString&, const QString&, QMessageBox::Icon, int, int, int, QWidget*)")]
		private void NewQMessageBox(string caption, string text, QMessageBox.Icon icon, int button0, int button1, int button2, QWidget parent) {
			ProxyQMessageBox().NewQMessageBox(caption,text,icon,button0,button1,button2,parent);
		}
		public QMessageBox(string caption, string text, QMessageBox.Icon icon, int button0, int button1, int button2) : this((Type) null) {
			CreateQMessageBoxProxy();
			CreateQMessageBoxSignalProxy();
			NewQMessageBox(caption,text,icon,button0,button1,button2);
		}
		[SmokeMethod("QMessageBox(const QString&, const QString&, QMessageBox::Icon, int, int, int)")]
		private void NewQMessageBox(string caption, string text, QMessageBox.Icon icon, int button0, int button1, int button2) {
			ProxyQMessageBox().NewQMessageBox(caption,text,icon,button0,button1,button2);
		}
		[SmokeMethod("text() const")]
		public string Text() {
			return ProxyQMessageBox().Text();
		}
		[SmokeMethod("setText(const QString&)")]
		public void SetText(string arg1) {
			ProxyQMessageBox().SetText(arg1);
		}
		[SmokeMethod("icon() const")]
		public new QMessageBox.Icon IconId() {
			return ProxyQMessageBox().IconId();
		}
		[SmokeMethod("setIcon(QMessageBox::Icon)")]
		public new void SetIcon(QMessageBox.Icon arg1) {
			ProxyQMessageBox().SetIcon(arg1);
		}
		[SmokeMethod("setIcon(const QPixmap&)")]
		public new void SetIcon(QPixmap arg1) {
			ProxyQMessageBox().SetIcon(arg1);
		}
		[SmokeMethod("iconPixmap() const")]
		public QPixmap IconPixmap() {
			return ProxyQMessageBox().IconPixmap();
		}
		[SmokeMethod("setIconPixmap(const QPixmap&)")]
		public void SetIconPixmap(QPixmap arg1) {
			ProxyQMessageBox().SetIconPixmap(arg1);
		}
		[SmokeMethod("buttonText(int) const")]
		public string ButtonText(int button) {
			return ProxyQMessageBox().ButtonText(button);
		}
		[SmokeMethod("setButtonText(int, const QString&)")]
		public void SetButtonText(int button, string arg2) {
			ProxyQMessageBox().SetButtonText(button,arg2);
		}
		[SmokeMethod("adjustSize()")]
		public new void AdjustSize() {
			ProxyQMessageBox().AdjustSize();
		}
		[SmokeMethod("textFormat() const")]
		public Qt.TextFormat TextFormat() {
			return ProxyQMessageBox().TextFormat();
		}
		[SmokeMethod("setTextFormat(Qt::TextFormat)")]
		public void SetTextFormat(Qt.TextFormat arg1) {
			ProxyQMessageBox().SetTextFormat(arg1);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQMessageBox().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQMessageBox().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQMessageBox().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQMessageBox().TrUtf8(arg1);
		}
		[SmokeMethod("information(QWidget*, const QString&, const QString&, int, int, int)")]
		public static int Information(QWidget parent, string caption, string text, int button0, int button1, int button2) {
			return StaticQMessageBox().Information(parent,caption,text,button0,button1,button2);
		}
		[SmokeMethod("information(QWidget*, const QString&, const QString&, int, int)")]
		public static int Information(QWidget parent, string caption, string text, int button0, int button1) {
			return StaticQMessageBox().Information(parent,caption,text,button0,button1);
		}
		[SmokeMethod("information(QWidget*, const QString&, const QString&, int)")]
		public static int Information(QWidget parent, string caption, string text, int button0) {
			return StaticQMessageBox().Information(parent,caption,text,button0);
		}
		[SmokeMethod("information(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&, int, int)")]
		public static int Information(QWidget parent, string caption, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber, int escapeButtonNumber) {
			return StaticQMessageBox().Information(parent,caption,text,button0Text,button1Text,button2Text,defaultButtonNumber,escapeButtonNumber);
		}
		[SmokeMethod("information(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&, int)")]
		public static int Information(QWidget parent, string caption, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber) {
			return StaticQMessageBox().Information(parent,caption,text,button0Text,button1Text,button2Text,defaultButtonNumber);
		}
		[SmokeMethod("information(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&)")]
		public static int Information(QWidget parent, string caption, string text, string button0Text, string button1Text, string button2Text) {
			return StaticQMessageBox().Information(parent,caption,text,button0Text,button1Text,button2Text);
		}
		[SmokeMethod("information(QWidget*, const QString&, const QString&, const QString&, const QString&)")]
		public static int Information(QWidget parent, string caption, string text, string button0Text, string button1Text) {
			return StaticQMessageBox().Information(parent,caption,text,button0Text,button1Text);
		}
		[SmokeMethod("information(QWidget*, const QString&, const QString&, const QString&)")]
		public static int Information(QWidget parent, string caption, string text, string button0Text) {
			return StaticQMessageBox().Information(parent,caption,text,button0Text);
		}
		[SmokeMethod("information(QWidget*, const QString&, const QString&)")]
		public static int Information(QWidget parent, string caption, string text) {
			return StaticQMessageBox().Information(parent,caption,text);
		}
		[SmokeMethod("question(QWidget*, const QString&, const QString&, int, int, int)")]
		public static int Question(QWidget parent, string caption, string text, int button0, int button1, int button2) {
			return StaticQMessageBox().Question(parent,caption,text,button0,button1,button2);
		}
		[SmokeMethod("question(QWidget*, const QString&, const QString&, int, int)")]
		public static int Question(QWidget parent, string caption, string text, int button0, int button1) {
			return StaticQMessageBox().Question(parent,caption,text,button0,button1);
		}
		[SmokeMethod("question(QWidget*, const QString&, const QString&, int)")]
		public static int Question(QWidget parent, string caption, string text, int button0) {
			return StaticQMessageBox().Question(parent,caption,text,button0);
		}
		[SmokeMethod("question(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&, int, int)")]
		public static int Question(QWidget parent, string caption, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber, int escapeButtonNumber) {
			return StaticQMessageBox().Question(parent,caption,text,button0Text,button1Text,button2Text,defaultButtonNumber,escapeButtonNumber);
		}
		[SmokeMethod("question(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&, int)")]
		public static int Question(QWidget parent, string caption, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber) {
			return StaticQMessageBox().Question(parent,caption,text,button0Text,button1Text,button2Text,defaultButtonNumber);
		}
		[SmokeMethod("question(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&)")]
		public static int Question(QWidget parent, string caption, string text, string button0Text, string button1Text, string button2Text) {
			return StaticQMessageBox().Question(parent,caption,text,button0Text,button1Text,button2Text);
		}
		[SmokeMethod("question(QWidget*, const QString&, const QString&, const QString&, const QString&)")]
		public static int Question(QWidget parent, string caption, string text, string button0Text, string button1Text) {
			return StaticQMessageBox().Question(parent,caption,text,button0Text,button1Text);
		}
		[SmokeMethod("question(QWidget*, const QString&, const QString&, const QString&)")]
		public static int Question(QWidget parent, string caption, string text, string button0Text) {
			return StaticQMessageBox().Question(parent,caption,text,button0Text);
		}
		[SmokeMethod("question(QWidget*, const QString&, const QString&)")]
		public static int Question(QWidget parent, string caption, string text) {
			return StaticQMessageBox().Question(parent,caption,text);
		}
		[SmokeMethod("warning(QWidget*, const QString&, const QString&, int, int, int)")]
		public static int Warning(QWidget parent, string caption, string text, int button0, int button1, int button2) {
			return StaticQMessageBox().Warning(parent,caption,text,button0,button1,button2);
		}
		[SmokeMethod("warning(QWidget*, const QString&, const QString&, int, int)")]
		public static int Warning(QWidget parent, string caption, string text, int button0, int button1) {
			return StaticQMessageBox().Warning(parent,caption,text,button0,button1);
		}
		[SmokeMethod("warning(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&, int, int)")]
		public static int Warning(QWidget parent, string caption, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber, int escapeButtonNumber) {
			return StaticQMessageBox().Warning(parent,caption,text,button0Text,button1Text,button2Text,defaultButtonNumber,escapeButtonNumber);
		}
		[SmokeMethod("warning(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&, int)")]
		public static int Warning(QWidget parent, string caption, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber) {
			return StaticQMessageBox().Warning(parent,caption,text,button0Text,button1Text,button2Text,defaultButtonNumber);
		}
		[SmokeMethod("warning(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&)")]
		public static int Warning(QWidget parent, string caption, string text, string button0Text, string button1Text, string button2Text) {
			return StaticQMessageBox().Warning(parent,caption,text,button0Text,button1Text,button2Text);
		}
		[SmokeMethod("warning(QWidget*, const QString&, const QString&, const QString&, const QString&)")]
		public static int Warning(QWidget parent, string caption, string text, string button0Text, string button1Text) {
			return StaticQMessageBox().Warning(parent,caption,text,button0Text,button1Text);
		}
		[SmokeMethod("warning(QWidget*, const QString&, const QString&, const QString&)")]
		public static int Warning(QWidget parent, string caption, string text, string button0Text) {
			return StaticQMessageBox().Warning(parent,caption,text,button0Text);
		}
		[SmokeMethod("warning(QWidget*, const QString&, const QString&)")]
		public static int Warning(QWidget parent, string caption, string text) {
			return StaticQMessageBox().Warning(parent,caption,text);
		}
		[SmokeMethod("critical(QWidget*, const QString&, const QString&, int, int, int)")]
		public static int Critical(QWidget parent, string caption, string text, int button0, int button1, int button2) {
			return StaticQMessageBox().Critical(parent,caption,text,button0,button1,button2);
		}
		[SmokeMethod("critical(QWidget*, const QString&, const QString&, int, int)")]
		public static int Critical(QWidget parent, string caption, string text, int button0, int button1) {
			return StaticQMessageBox().Critical(parent,caption,text,button0,button1);
		}
		[SmokeMethod("critical(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&, int, int)")]
		public static int Critical(QWidget parent, string caption, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber, int escapeButtonNumber) {
			return StaticQMessageBox().Critical(parent,caption,text,button0Text,button1Text,button2Text,defaultButtonNumber,escapeButtonNumber);
		}
		[SmokeMethod("critical(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&, int)")]
		public static int Critical(QWidget parent, string caption, string text, string button0Text, string button1Text, string button2Text, int defaultButtonNumber) {
			return StaticQMessageBox().Critical(parent,caption,text,button0Text,button1Text,button2Text,defaultButtonNumber);
		}
		[SmokeMethod("critical(QWidget*, const QString&, const QString&, const QString&, const QString&, const QString&)")]
		public static int Critical(QWidget parent, string caption, string text, string button0Text, string button1Text, string button2Text) {
			return StaticQMessageBox().Critical(parent,caption,text,button0Text,button1Text,button2Text);
		}
		[SmokeMethod("critical(QWidget*, const QString&, const QString&, const QString&, const QString&)")]
		public static int Critical(QWidget parent, string caption, string text, string button0Text, string button1Text) {
			return StaticQMessageBox().Critical(parent,caption,text,button0Text,button1Text);
		}
		[SmokeMethod("critical(QWidget*, const QString&, const QString&, const QString&)")]
		public static int Critical(QWidget parent, string caption, string text, string button0Text) {
			return StaticQMessageBox().Critical(parent,caption,text,button0Text);
		}
		[SmokeMethod("critical(QWidget*, const QString&, const QString&)")]
		public static int Critical(QWidget parent, string caption, string text) {
			return StaticQMessageBox().Critical(parent,caption,text);
		}
		[SmokeMethod("about(QWidget*, const QString&, const QString&)")]
		public static void About(QWidget parent, string caption, string text) {
			StaticQMessageBox().About(parent,caption,text);
		}
		[SmokeMethod("aboutQt(QWidget*, const QString&)")]
		public static void AboutQt(QWidget parent, string caption) {
			StaticQMessageBox().AboutQt(parent,caption);
		}
		[SmokeMethod("aboutQt(QWidget*)")]
		public static void AboutQt(QWidget parent) {
			StaticQMessageBox().AboutQt(parent);
		}
		[SmokeMethod("message(const QString&, const QString&, const QString&, QWidget*, const char*)")]
		public static int Message(string caption, string text, string buttonText, QWidget parent, string arg5) {
			return StaticQMessageBox().Message(caption,text,buttonText,parent,arg5);
		}
		[SmokeMethod("message(const QString&, const QString&, const QString&, QWidget*)")]
		public static int Message(string caption, string text, string buttonText, QWidget parent) {
			return StaticQMessageBox().Message(caption,text,buttonText,parent);
		}
		[SmokeMethod("message(const QString&, const QString&, const QString&)")]
		public static int Message(string caption, string text, string buttonText) {
			return StaticQMessageBox().Message(caption,text,buttonText);
		}
		[SmokeMethod("message(const QString&, const QString&)")]
		public static int Message(string caption, string text) {
			return StaticQMessageBox().Message(caption,text);
		}
		[SmokeMethod("query(const QString&, const QString&, const QString&, const QString&, QWidget*, const char*)")]
		public static bool Query(string caption, string text, string yesButtonText, string noButtonText, QWidget parent, string arg6) {
			return StaticQMessageBox().Query(caption,text,yesButtonText,noButtonText,parent,arg6);
		}
		[SmokeMethod("query(const QString&, const QString&, const QString&, const QString&, QWidget*)")]
		public static bool Query(string caption, string text, string yesButtonText, string noButtonText, QWidget parent) {
			return StaticQMessageBox().Query(caption,text,yesButtonText,noButtonText,parent);
		}
		[SmokeMethod("query(const QString&, const QString&, const QString&, const QString&)")]
		public static bool Query(string caption, string text, string yesButtonText, string noButtonText) {
			return StaticQMessageBox().Query(caption,text,yesButtonText,noButtonText);
		}
		[SmokeMethod("query(const QString&, const QString&, const QString&)")]
		public static bool Query(string caption, string text, string yesButtonText) {
			return StaticQMessageBox().Query(caption,text,yesButtonText);
		}
		[SmokeMethod("query(const QString&, const QString&)")]
		public static bool Query(string caption, string text) {
			return StaticQMessageBox().Query(caption,text);
		}
		[SmokeMethod("standardIcon(QMessageBox::Icon, Qt::GUIStyle)")]
		public static QPixmap StandardIcon(QMessageBox.Icon icon, Qt.GUIStyle arg2) {
			return StaticQMessageBox().StandardIcon(icon,arg2);
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
		[SmokeMethod("styleChanged(QStyle&)")]
		protected void StyleChanged(QStyle arg1) {
			ProxyQMessageBox().StyleChanged(arg1);
		}
		~QMessageBox() {
			DisposeQMessageBox();
		}
		public new void Dispose() {
			DisposeQMessageBox();
		}
		private void DisposeQMessageBox() {
			ProxyQMessageBox().DisposeQMessageBox();
		}
		protected void CreateQMessageBoxSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQMessageBoxSignals), this);
			Q_EMIT = (IQMessageBoxSignals) realProxy.GetTransparentProxy();
		}
		protected new IQMessageBoxSignals Emit() {
			return (IQMessageBoxSignals) Q_EMIT;
		}
	}

	public interface IQMessageBoxSignals : IQDialogSignals {
	}
}
