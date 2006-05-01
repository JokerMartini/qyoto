//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QEvent")]
	public class QEvent : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QEvent(Type dummy) {}
		interface IQEventProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QEvent), this);
			_interceptor = (QEvent) realProxy.GetTransparentProxy();
		}
		private QEvent ProxyQEvent() {
			return (QEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQEventProxy), null);
			_staticInterceptor = (IQEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQEventProxy StaticQEvent() {
			return (IQEventProxy) _staticInterceptor;
		}

		public enum E_Type {
			None = 0,
			Timer = 1,
			MouseButtonPress = 2,
			MouseButtonRelease = 3,
			MouseButtonDblClick = 4,
			MouseMove = 5,
			KeyPress = 6,
			KeyRelease = 7,
			FocusIn = 8,
			FocusOut = 9,
			Enter = 10,
			Leave = 11,
			Paint = 12,
			Move = 13,
			Resize = 14,
			Create = 15,
			Destroy = 16,
			Show = 17,
			Hide = 18,
			Close = 19,
			Quit = 20,
			ParentChange = 21,
			ParentAboutToChange = 131,
			ThreadChange = 22,
			WindowActivate = 24,
			WindowDeactivate = 25,
			ShowToParent = 26,
			HideToParent = 27,
			Wheel = 31,
			WindowTitleChange = 33,
			WindowIconChange = 34,
			ApplicationWindowIconChange = 35,
			ApplicationFontChange = 36,
			ApplicationLayoutDirectionChange = 37,
			ApplicationPaletteChange = 38,
			PaletteChange = 39,
			Clipboard = 40,
			Speech = 42,
			MetaCall = 43,
			SockAct = 50,
			WinEventAct = 132,
			DeferredDelete = 52,
			DragEnter = 60,
			DragMove = 61,
			DragLeave = 62,
			Drop = 63,
			DragResponse = 64,
			ChildAdded = 68,
			ChildPolished = 69,
			ChildRemoved = 71,
			ShowWindowRequest = 73,
			PolishRequest = 74,
			Polish = 75,
			LayoutRequest = 76,
			UpdateRequest = 77,
			UpdateLater = 78,
			EmbeddingControl = 79,
			ActivateControl = 80,
			DeactivateControl = 81,
			ContextMenu = 82,
			InputMethod = 83,
			AccessibilityPrepare = 86,
			TabletMove = 87,
			LocaleChange = 88,
			LanguageChange = 89,
			LayoutDirectionChange = 90,
			Style = 91,
			TabletPress = 92,
			TabletRelease = 93,
			OkRequest = 94,
			HelpRequest = 95,
			IconDrag = 96,
			FontChange = 97,
			EnabledChange = 98,
			ActivationChange = 99,
			StyleChange = 100,
			IconTextChange = 101,
			ModifiedChange = 102,
			MouseTrackingChange = 109,
			WindowBlocked = 103,
			WindowUnblocked = 104,
			WindowStateChange = 105,
			ToolTip = 110,
			WhatsThis = 111,
			StatusTip = 112,
			ActionChanged = 113,
			ActionAdded = 114,
			ActionRemoved = 115,
			FileOpen = 116,
			Shortcut = 117,
			ShortcutOverride = 51,
			WhatsThisClicked = 118,
			ToolBarChange = 120,
			ApplicationActivated = 121,
			ApplicationDeactivated = 122,
			QueryWhatsThis = 123,
			EnterWhatsThisMode = 124,
			LeaveWhatsThisMode = 125,
			ZOrderChange = 126,
			HoverEnter = 127,
			HoverLeave = 128,
			HoverMove = 129,
			AccessibilityHelp = 119,
			AccessibilityDescription = 130,
			AcceptDropsChange = 152,
			MenubarUpdated = 153,
			ZeroTimerEvent = 154,
			User = 1000,
			MaxUser = 65535,
		}
		public QEvent(QEvent.E_Type type) : this((Type) null) {
			CreateProxy();
			NewQEvent(type);
		}
		[SmokeMethod("QEvent(QEvent::Type)")]
		private void NewQEvent(QEvent.E_Type type) {
			ProxyQEvent().NewQEvent(type);
		}
		[SmokeMethod("type() const")]
		public QEvent.E_Type type() {
			return ProxyQEvent().type();
		}
		[SmokeMethod("spontaneous() const")]
		public bool Spontaneous() {
			return ProxyQEvent().Spontaneous();
		}
		[SmokeMethod("setAccepted(bool)")]
		public void SetAccepted(bool accepted) {
			ProxyQEvent().SetAccepted(accepted);
		}
		[SmokeMethod("isAccepted() const")]
		public bool IsAccepted() {
			return ProxyQEvent().IsAccepted();
		}
		[SmokeMethod("accept()")]
		public void Accept() {
			ProxyQEvent().Accept();
		}
		[SmokeMethod("ignore()")]
		public void Ignore() {
			ProxyQEvent().Ignore();
		}
		~QEvent() {
			DisposeQEvent();
		}
		public void Dispose() {
			DisposeQEvent();
		}
		private void DisposeQEvent() {
			ProxyQEvent().DisposeQEvent();
		}
	}
}
