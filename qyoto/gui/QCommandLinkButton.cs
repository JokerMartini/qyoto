//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	[SmokeClass("QCommandLinkButton")]
	public class QCommandLinkButton : QPushButton, IDisposable {
 		protected QCommandLinkButton(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QCommandLinkButton), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QCommandLinkButton() {
			staticInterceptor = new SmokeInvocation(typeof(QCommandLinkButton), null);
		}
		[Q_PROPERTY("QString", "description")]
		public string Description {
			get { return (string) interceptor.Invoke("description", "description()", typeof(string)); }
			set { interceptor.Invoke("setDescription$", "setDescription(QString)", typeof(void), typeof(string), value); }
		}
		[Q_PROPERTY("bool", "flat")]
		public new bool Flat {
			get { return (bool) interceptor.Invoke("false", "false()", typeof(bool)); }
		}
		public QCommandLinkButton(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QCommandLinkButton#", "QCommandLinkButton(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public QCommandLinkButton() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QCommandLinkButton", "QCommandLinkButton()", typeof(void));
		}
		public QCommandLinkButton(string text, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QCommandLinkButton$#", "QCommandLinkButton(const QString&, QWidget*)", typeof(void), typeof(string), text, typeof(QWidget), parent);
		}
		public QCommandLinkButton(string text) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QCommandLinkButton$", "QCommandLinkButton(const QString&)", typeof(void), typeof(string), text);
		}
		public QCommandLinkButton(string text, string description, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QCommandLinkButton$$#", "QCommandLinkButton(const QString&, const QString&, QWidget*)", typeof(void), typeof(string), text, typeof(string), description, typeof(QWidget), parent);
		}
		public QCommandLinkButton(string text, string description) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QCommandLinkButton$$", "QCommandLinkButton(const QString&, const QString&)", typeof(void), typeof(string), text, typeof(string), description);
		}
		[SmokeMethod("sizeHint() const")]
		public new virtual QSize SizeHint() {
			return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
		}
		[SmokeMethod("heightForWidth(int) const")]
		protected new virtual int HeightForWidth(int arg1) {
			return (int) interceptor.Invoke("heightForWidth$", "heightForWidth(int) const", typeof(int), typeof(int), arg1);
		}
		[SmokeMethod("minimumSizeHint() const")]
		protected new virtual QSize MinimumSizeHint() {
			return (QSize) interceptor.Invoke("minimumSizeHint", "minimumSizeHint() const", typeof(QSize));
		}
		[SmokeMethod("event(QEvent*)")]
		protected override bool Event(QEvent e) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), e);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected override void PaintEvent(QPaintEvent arg1) {
			interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), arg1);
		}
		~QCommandLinkButton() {
			interceptor.Invoke("~QCommandLinkButton", "~QCommandLinkButton()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QCommandLinkButton", "~QCommandLinkButton()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQCommandLinkButtonSignals Emit {
			get { return (IQCommandLinkButtonSignals) Q_EMIT; }
		}
	}

	public interface IQCommandLinkButtonSignals : IQPushButtonSignals {
	}
}
