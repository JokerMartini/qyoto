//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	namespace KParts {

	using System;
	using Qyoto;

	/// <remarks>
	///  The WindowArgs are used to specify arguments to the "create new window"
	///  call (see the createNewWindow variant that uses WindowArgs).
	///  The primary reason for this is the javascript window.open function.
	///  </remarks>		<short>    The WindowArgs are used to specify arguments to the "create new window"  call (see the createNewWindow variant that uses WindowArgs).</short>

	[SmokeClass("KParts::WindowArgs")]
	public class WindowArgs : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected WindowArgs(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(WindowArgs), this);
		}
		public WindowArgs() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("WindowArgs", "WindowArgs()", typeof(void));
		}
		public WindowArgs(KParts.WindowArgs args) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("WindowArgs#", "WindowArgs(const KParts::WindowArgs&)", typeof(void), typeof(KParts.WindowArgs), args);
		}
		public WindowArgs(QRect _geometry, bool _fullscreen, bool _menuBarVisible, bool _toolBarsVisible, bool _statusBarVisible, bool _resizable) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("WindowArgs#$$$$$", "WindowArgs(const QRect&, bool, bool, bool, bool, bool)", typeof(void), typeof(QRect), _geometry, typeof(bool), _fullscreen, typeof(bool), _menuBarVisible, typeof(bool), _toolBarsVisible, typeof(bool), _statusBarVisible, typeof(bool), _resizable);
		}
		public WindowArgs(int _x, int _y, int _width, int _height, bool _fullscreen, bool _menuBarVisible, bool _toolBarsVisible, bool _statusBarVisible, bool _resizable) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("WindowArgs$$$$$$$$$", "WindowArgs(int, int, int, int, bool, bool, bool, bool, bool)", typeof(void), typeof(int), _x, typeof(int), _y, typeof(int), _width, typeof(int), _height, typeof(bool), _fullscreen, typeof(bool), _menuBarVisible, typeof(bool), _toolBarsVisible, typeof(bool), _statusBarVisible, typeof(bool), _resizable);
		}
		~WindowArgs() {
			interceptor.Invoke("~WindowArgs", "~WindowArgs()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~WindowArgs", "~WindowArgs()", typeof(void));
		}
	}
	}
}