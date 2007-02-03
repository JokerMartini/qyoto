//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	/// See <see cref="IQAbstractButtonSignals"></see> for signals emitted by QAbstractButton
	[SmokeClass("QAbstractButton")]
	public class QAbstractButton : QWidget {
 		protected QAbstractButton(Type dummy) : base((Type) null) {}
		[SmokeClass("QAbstractButton")]
		interface IQAbstractButtonProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QAbstractButton), this);
			_interceptor = (QAbstractButton) realProxy.GetTransparentProxy();
		}
		private QAbstractButton ProxyQAbstractButton() {
			return (QAbstractButton) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QAbstractButton() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQAbstractButtonProxy), null);
			_staticInterceptor = (IQAbstractButtonProxy) realProxy.GetTransparentProxy();
		}
		private static IQAbstractButtonProxy StaticQAbstractButton() {
			return (IQAbstractButtonProxy) _staticInterceptor;
		}

		[Q_PROPERTY("QString", "text")]
		public string Text {
			get {
				return Property("text").Value<string>();
			}
			set {
				SetProperty("text", QVariant.FromValue<string>(value));
			}
		}
		[Q_PROPERTY("QIcon", "icon")]
		public QIcon Icon {
			get {
				return Property("icon").Value<QIcon>();
			}
			set {
				SetProperty("icon", QVariant.FromValue<QIcon>(value));
			}
		}
		[Q_PROPERTY("QSize", "iconSize")]
		public QSize IconSize {
			get {
				return Property("iconSize").Value<QSize>();
			}
			set {
				SetProperty("iconSize", QVariant.FromValue<QSize>(value));
			}
		}
		[Q_PROPERTY("QKeySequence", "shortcut")]
		public QKeySequence Shortcut {
			get {
				return Property("shortcut").Value<QKeySequence>();
			}
			set {
				SetProperty("shortcut", QVariant.FromValue<QKeySequence>(value));
			}
		}
		[Q_PROPERTY("bool", "checkable")]
		public bool Checkable {
			get {
				return Property("checkable").Value<bool>();
			}
			set {
				SetProperty("checkable", QVariant.FromValue<bool>(value));
			}
		}
		[Q_PROPERTY("bool", "checked")]
		public bool Checked {
			get {
				return Property("checked").Value<bool>();
			}
			set {
				SetProperty("checked", QVariant.FromValue<bool>(value));
			}
		}
		[Q_PROPERTY("bool", "autoRepeat")]
		public bool AutoRepeat {
			get {
				return Property("autoRepeat").Value<bool>();
			}
			set {
				SetProperty("autoRepeat", QVariant.FromValue<bool>(value));
			}
		}
		[Q_PROPERTY("bool", "autoExclusive")]
		public bool AutoExclusive {
			get {
				return Property("autoExclusive").Value<bool>();
			}
			set {
				SetProperty("autoExclusive", QVariant.FromValue<bool>(value));
			}
		}
		[Q_PROPERTY("int", "autoRepeatDelay")]
		public int AutoRepeatDelay {
			get {
				return Property("autoRepeatDelay").Value<int>();
			}
			set {
				SetProperty("autoRepeatDelay", QVariant.FromValue<int>(value));
			}
		}
		[Q_PROPERTY("int", "autoRepeatInterval")]
		public int AutoRepeatInterval {
			get {
				return Property("autoRepeatInterval").Value<int>();
			}
			set {
				SetProperty("autoRepeatInterval", QVariant.FromValue<int>(value));
			}
		}
		[Q_PROPERTY("bool", "down")]
		public bool Down {
			get {
				return Property("down").Value<bool>();
			}
			set {
				SetProperty("down", QVariant.FromValue<bool>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QAbstractButton(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQAbstractButton(parent);
		}
		[SmokeMethod("QAbstractButton", "(QWidget*)", "#")]
		private void NewQAbstractButton(QWidget parent) {
			ProxyQAbstractButton().NewQAbstractButton(parent);
		}
		public QAbstractButton() : this((Type) null) {
			CreateProxy();
			NewQAbstractButton();
		}
		[SmokeMethod("QAbstractButton", "()", "")]
		private void NewQAbstractButton() {
			ProxyQAbstractButton().NewQAbstractButton();
		}
		[SmokeMethod("isCheckable", "() const", "")]
		public bool IsCheckable() {
			return ProxyQAbstractButton().IsCheckable();
		}
		[SmokeMethod("isChecked", "() const", "")]
		public bool IsChecked() {
			return ProxyQAbstractButton().IsChecked();
		}
		[SmokeMethod("isDown", "() const", "")]
		public bool IsDown() {
			return ProxyQAbstractButton().IsDown();
		}
		[SmokeMethod("group", "() const", "")]
		public QButtonGroup Group() {
			return ProxyQAbstractButton().Group();
		}
		[Q_SLOT("void animateClick(int)")]
		[SmokeMethod("animateClick", "(int)", "$")]
		public void AnimateClick(int msec) {
			ProxyQAbstractButton().AnimateClick(msec);
		}
		[Q_SLOT("void animateClick()")]
		[SmokeMethod("animateClick", "()", "")]
		public void AnimateClick() {
			ProxyQAbstractButton().AnimateClick();
		}
		[Q_SLOT("void click()")]
		[SmokeMethod("click", "()", "")]
		public void Click() {
			ProxyQAbstractButton().Click();
		}
		[Q_SLOT("void toggle()")]
		[SmokeMethod("toggle", "()", "")]
		public void Toggle() {
			ProxyQAbstractButton().Toggle();
		}
		public static new string Tr(string s, string c) {
			return StaticQAbstractButton().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQAbstractButton().Tr(s);
		}
		~QAbstractButton() {
			DisposeQAbstractButton();
		}
		public new void Dispose() {
			DisposeQAbstractButton();
		}
		[SmokeMethod("~QAbstractButton", "()", "")]
		private void DisposeQAbstractButton() {
			ProxyQAbstractButton().DisposeQAbstractButton();
		}
		protected new IQAbstractButtonSignals Emit {
			get {
				return (IQAbstractButtonSignals) Q_EMIT;
			}
		}
	}

	public interface IQAbstractButtonSignals : IQWidgetSignals {
		[Q_SIGNAL("void pressed()")]
		void Pressed();
		[Q_SIGNAL("void released()")]
		void Released();
		[Q_SIGNAL("void clicked(bool)")]
		void Clicked(bool arg1);
		[Q_SIGNAL("void clicked()")]
		void Clicked();
		[Q_SIGNAL("void toggled(bool)")]
		void Toggled(bool arg1);
	}
}
