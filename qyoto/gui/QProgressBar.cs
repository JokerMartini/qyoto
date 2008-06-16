//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	/// <remarks> See <see cref="IQProgressBarSignals"></see> for signals emitted by QProgressBar
	/// </remarks>
	[SmokeClass("QProgressBar")]
	public class QProgressBar : QWidget, IDisposable {
 		protected QProgressBar(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QProgressBar), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QProgressBar() {
			staticInterceptor = new SmokeInvocation(typeof(QProgressBar), null);
		}
		public enum Direction {
			TopToBottom = 0,
			BottomToTop = 1,
		}
		[Q_PROPERTY("int", "minimum")]
		public int Minimum {
			get { return (int) interceptor.Invoke("minimum", "minimum()", typeof(int)); }
			set { interceptor.Invoke("setMinimum$", "setMinimum(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("int", "maximum")]
		public int Maximum {
			get { return (int) interceptor.Invoke("maximum", "maximum()", typeof(int)); }
			set { interceptor.Invoke("setMaximum$", "setMaximum(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("QString", "text")]
		public string Text {
			get { return (string) interceptor.Invoke("text", "text()", typeof(string)); }
		}
		[Q_PROPERTY("int", "value")]
		public int Value {
			get { return (int) interceptor.Invoke("value", "value()", typeof(int)); }
			set { interceptor.Invoke("setValue$", "setValue(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("Qt::Alignment", "alignment")]
		public uint Alignment {
			get { return (uint) interceptor.Invoke("alignment", "alignment()", typeof(uint)); }
			set { interceptor.Invoke("setAlignment$", "setAlignment(Qt::Alignment)", typeof(void), typeof(uint), value); }
		}
		[Q_PROPERTY("bool", "textVisible")]
		public bool TextVisible {
			get { return (bool) interceptor.Invoke("isTextVisible", "isTextVisible()", typeof(bool)); }
			set { interceptor.Invoke("setTextVisible$", "setTextVisible(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("Qt::Orientation", "orientation")]
		public new Qt.Orientation Orientation {
			get { return (Qt.Orientation) interceptor.Invoke("orientation", "orientation()", typeof(Qt.Orientation)); }
			set { interceptor.Invoke("setOrientation$", "setOrientation(Qt::Orientation)", typeof(void), typeof(Qt.Orientation), value); }
		}
		[Q_PROPERTY("bool", "invertedAppearance")]
		public bool InvertedAppearance {
			get { return (bool) interceptor.Invoke("invertedAppearance", "invertedAppearance()", typeof(bool)); }
			set { interceptor.Invoke("setInvertedAppearance$", "setInvertedAppearance(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("QProgressBar::Direction", "textDirection")]
		public QProgressBar.Direction TextDirection {
			get { return (QProgressBar.Direction) interceptor.Invoke("textDirection", "textDirection()", typeof(QProgressBar.Direction)); }
			set { interceptor.Invoke("setTextDirection$", "setTextDirection(QProgressBar::Direction)", typeof(void), typeof(QProgressBar.Direction), value); }
		}
		[Q_PROPERTY("QString", "format")]
		public string Format {
			get { return (string) interceptor.Invoke("format", "format()", typeof(string)); }
			set { interceptor.Invoke("setFormat$", "setFormat(QString)", typeof(void), typeof(string), value); }
		}
		public QProgressBar(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QProgressBar#", "QProgressBar(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public QProgressBar() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QProgressBar", "QProgressBar()", typeof(void));
		}
		[SmokeMethod("text() const")]
		public virtual string text() {
			return (string) interceptor.Invoke("text", "text() const", typeof(string));
		}
		[SmokeMethod("sizeHint() const")]
		public override QSize SizeHint() {
			return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
		}
		[SmokeMethod("minimumSizeHint() const")]
		public override QSize MinimumSizeHint() {
			return (QSize) interceptor.Invoke("minimumSizeHint", "minimumSizeHint() const", typeof(QSize));
		}
		[Q_SLOT("void reset()")]
		public void Reset() {
			interceptor.Invoke("reset", "reset()", typeof(void));
		}
		[Q_SLOT("void setRange(int, int)")]
		public void SetRange(int minimum, int maximum) {
			interceptor.Invoke("setRange$$", "setRange(int, int)", typeof(void), typeof(int), minimum, typeof(int), maximum);
		}
		[Q_SLOT("void setMinimum(int)")]
		public void SetMinimum(int minimum) {
			interceptor.Invoke("setMinimum$", "setMinimum(int)", typeof(void), typeof(int), minimum);
		}
		[Q_SLOT("void setMaximum(int)")]
		public void SetMaximum(int maximum) {
			interceptor.Invoke("setMaximum$", "setMaximum(int)", typeof(void), typeof(int), maximum);
		}
		[Q_SLOT("void setValue(int)")]
		public void SetValue(int value) {
			interceptor.Invoke("setValue$", "setValue(int)", typeof(void), typeof(int), value);
		}
		[Q_SLOT("void setOrientation(Qt::Orientation)")]
		public void SetOrientation(Qt.Orientation arg1) {
			interceptor.Invoke("setOrientation$", "setOrientation(Qt::Orientation)", typeof(void), typeof(Qt.Orientation), arg1);
		}
		[SmokeMethod("event(QEvent*)")]
		protected override bool Event(QEvent e) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), e);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected override void PaintEvent(QPaintEvent arg1) {
			interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), arg1);
		}
		protected void InitStyleOption(QStyleOptionProgressBar option) {
			interceptor.Invoke("initStyleOption#", "initStyleOption(QStyleOptionProgressBar*) const", typeof(void), typeof(QStyleOptionProgressBar), option);
		}
		~QProgressBar() {
			interceptor.Invoke("~QProgressBar", "~QProgressBar()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QProgressBar", "~QProgressBar()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQProgressBarSignals Emit {
			get { return (IQProgressBarSignals) Q_EMIT; }
		}
	}

	public interface IQProgressBarSignals : IQWidgetSignals {
		[Q_SIGNAL("void valueChanged(int)")]
		void ValueChanged(int value);
	}
}
