//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QFrame")]
	public class QFrame : QWidget, IDisposable {
 		protected QFrame(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QFrame), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QFrame() {
			staticInterceptor = new SmokeInvocation(typeof(QFrame), null);
		}
		public enum Shape {
			NoFrame = 0,
			Box = 0x0001,
			Panel = 0x0002,
			WinPanel = 0x0003,
			HLine = 0x0004,
			VLine = 0x0005,
			StyledPanel = 0x0006,
		}
		public enum Shadow {
			Plain = 0x0010,
			Raised = 0x0020,
			Sunken = 0x0030,
		}
		public enum StyleMask {
			Shadow_Mask = 0x00f0,
			Shape_Mask = 0x000f,
		}
		[Q_PROPERTY("QFrame::Shape", "frameShape")]
		public QFrame.Shape FrameShape {
			get { return (QFrame.Shape) interceptor.Invoke("frameShape", "frameShape()", typeof(QFrame.Shape)); }
			set { interceptor.Invoke("setFrameShape$", "setFrameShape(QFrame::Shape)", typeof(void), typeof(QFrame.Shape), value); }
		}
		[Q_PROPERTY("QFrame::Shadow", "frameShadow")]
		public QFrame.Shadow FrameShadow {
			get { return (QFrame.Shadow) interceptor.Invoke("frameShadow", "frameShadow()", typeof(QFrame.Shadow)); }
			set { interceptor.Invoke("setFrameShadow$", "setFrameShadow(QFrame::Shadow)", typeof(void), typeof(QFrame.Shadow), value); }
		}
		[Q_PROPERTY("int", "lineWidth")]
		public int LineWidth {
			get { return (int) interceptor.Invoke("lineWidth", "lineWidth()", typeof(int)); }
			set { interceptor.Invoke("setLineWidth$", "setLineWidth(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("int", "midLineWidth")]
		public int MidLineWidth {
			get { return (int) interceptor.Invoke("midLineWidth", "midLineWidth()", typeof(int)); }
			set { interceptor.Invoke("setMidLineWidth$", "setMidLineWidth(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("int", "frameWidth")]
		public int FrameWidth {
			get { return (int) interceptor.Invoke("frameWidth", "frameWidth()", typeof(int)); }
		}
		[Q_PROPERTY("QRect", "frameRect")]
		public QRect FrameRect {
			get { return (QRect) interceptor.Invoke("frameRect", "frameRect()", typeof(QRect)); }
			set { interceptor.Invoke("setFrameRect#", "setFrameRect(QRect)", typeof(void), typeof(QRect), value); }
		}
		// QFrame* QFrame(QFramePrivate& arg1,QWidget* arg2,Qt::WindowFlags arg3); >>>> NOT CONVERTED
		// QFrame* QFrame(QFramePrivate& arg1,QWidget* arg2); >>>> NOT CONVERTED
		// QFrame* QFrame(QFramePrivate& arg1); >>>> NOT CONVERTED
		public QFrame(QWidget parent, uint f) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFrame#$", "QFrame(QWidget*, Qt::WindowFlags)", typeof(void), typeof(QWidget), parent, typeof(uint), f);
		}
		public QFrame(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFrame#", "QFrame(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public QFrame() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFrame", "QFrame()", typeof(void));
		}
		public int FrameStyle() {
			return (int) interceptor.Invoke("frameStyle", "frameStyle() const", typeof(int));
		}
		public void SetFrameStyle(int arg1) {
			interceptor.Invoke("setFrameStyle$", "setFrameStyle(int)", typeof(void), typeof(int), arg1);
		}
		[SmokeMethod("sizeHint() const")]
		public override QSize SizeHint() {
			return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
		}
		[SmokeMethod("event(QEvent*)")]
		protected override bool Event(QEvent e) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), e);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected override void PaintEvent(QPaintEvent arg1) {
			interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), arg1);
		}
		[SmokeMethod("changeEvent(QEvent*)")]
		protected override void ChangeEvent(QEvent arg1) {
			interceptor.Invoke("changeEvent#", "changeEvent(QEvent*)", typeof(void), typeof(QEvent), arg1);
		}
		protected void DrawFrame(QPainter arg1) {
			interceptor.Invoke("drawFrame#", "drawFrame(QPainter*)", typeof(void), typeof(QPainter), arg1);
		}
		~QFrame() {
			interceptor.Invoke("~QFrame", "~QFrame()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QFrame", "~QFrame()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQFrameSignals Emit {
			get { return (IQFrameSignals) Q_EMIT; }
		}
	}

	public interface IQFrameSignals : IQWidgetSignals {
	}
}
