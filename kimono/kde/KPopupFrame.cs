//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;

	/// <remarks>
	///  Frame with popup menu behavior.
	///  See <see cref="IKPopupFrameSignals"></see> for signals emitted by KPopupFrame
	/// </remarks>		<author> Tim Gilman, Mirko Boehm
	///  </author>
	/// 		<short>    Frame with popup menu behavior.</short>

	[SmokeClass("KPopupFrame")]
	public class KPopupFrame : QFrame, IDisposable {
 		protected KPopupFrame(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocationKDE(typeof(KPopupFrame), this);
		}
		/// <remarks>
		///  The contructor. Creates a dialog without buttons.
		///      </remarks>		<short>    The contructor.</short>
		public KPopupFrame(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KPopupFrame#", "KPopupFrame(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public KPopupFrame() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KPopupFrame", "KPopupFrame()", typeof(void));
		}
		/// <remarks>
		///  Set the main widget. You cannot set the main widget from the constructor,
		///  since it must be a child of the frame itselfes.
		///  Be careful: the size is set to the main widgets size. It is up to you to
		///  set the main widgets correct size before setting it as the main
		///  widget.
		///      </remarks>		<short>    Set the main widget.</short>
		public void SetMainWidget(QWidget m) {
			interceptor.Invoke("setMainWidget#", "setMainWidget(QWidget*)", typeof(void), typeof(QWidget), m);
		}
		/// <remarks>
		///  The resize event. Simply resizes the main widget to the whole
		///  widgets client size.
		///      </remarks>		<short>    The resize event.</short>
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		public new virtual void ResizeEvent(QResizeEvent resize) {
			interceptor.Invoke("resizeEvent#", "resizeEvent(QResizeEvent*)", typeof(void), typeof(QResizeEvent), resize);
		}
		/// <remarks>
		///  Open the popup window at position pos.
		///      </remarks>		<short>    Open the popup window at position pos.</short>
		public void Popup(QPoint pos) {
			interceptor.Invoke("popup#", "popup(const QPoint&)", typeof(void), typeof(QPoint), pos);
		}
		/// <remarks>
		///  Execute the popup window.
		///      </remarks>		<short>    Execute the popup window.</short>
		public int Exec(QPoint p) {
			return (int) interceptor.Invoke("exec#", "exec(const QPoint&)", typeof(int), typeof(QPoint), p);
		}
		/// <remarks>
		///  Execute the popup window.
		///      </remarks>		<short>    Execute the popup window.</short>
		public int Exec(int x, int y) {
			return (int) interceptor.Invoke("exec$$", "exec(int, int)", typeof(int), typeof(int), x, typeof(int), y);
		}
		/// <remarks>
		///  Close the popup window. This is called from the main widget, usually.
		///  <code>r</code> is the result returned from exec().
		///      </remarks>		<short>    Close the popup window.</short>
		[Q_SLOT("void close(int)")]
		public void Close(int r) {
			interceptor.Invoke("close$", "close(int)", typeof(void), typeof(int), r);
		}
		/// <remarks>
		///  Catch key press events.
		///      </remarks>		<short>    Catch key press events.</short>
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected override void KeyPressEvent(QKeyEvent e) {
			interceptor.Invoke("keyPressEvent#", "keyPressEvent(QKeyEvent*)", typeof(void), typeof(QKeyEvent), e);
		}
		~KPopupFrame() {
			interceptor.Invoke("~KPopupFrame", "~KPopupFrame()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KPopupFrame", "~KPopupFrame()", typeof(void));
		}
		protected new IKPopupFrameSignals Emit {
			get { return (IKPopupFrameSignals) Q_EMIT; }
		}
	}

	public interface IKPopupFrameSignals : IQFrameSignals {
		[Q_SIGNAL("void leaveModality()")]
		void LeaveModality();
	}
}
