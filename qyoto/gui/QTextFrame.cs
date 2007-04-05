//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QTextFrame")]
	public class QTextFrame : QTextObject, IDisposable {
 		protected QTextFrame(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QTextFrame), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QTextFrame() {
			staticInterceptor = new SmokeInvocation(typeof(QTextFrame), null);
		}
		public QTextFrame(QTextDocument doc) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTextFrame#", "QTextFrame(QTextDocument*)", typeof(void), typeof(QTextDocument), doc);
		}
		public void SetFrameFormat(QTextFrameFormat format) {
			interceptor.Invoke("setFrameFormat#", "setFrameFormat(const QTextFrameFormat&)", typeof(void), typeof(QTextFrameFormat), format);
		}
		public QTextFrameFormat FrameFormat() {
			return (QTextFrameFormat) interceptor.Invoke("frameFormat", "frameFormat() const", typeof(QTextFrameFormat));
		}
		public QTextCursor FirstCursorPosition() {
			return (QTextCursor) interceptor.Invoke("firstCursorPosition", "firstCursorPosition() const", typeof(QTextCursor));
		}
		public QTextCursor LastCursorPosition() {
			return (QTextCursor) interceptor.Invoke("lastCursorPosition", "lastCursorPosition() const", typeof(QTextCursor));
		}
		public int FirstPosition() {
			return (int) interceptor.Invoke("firstPosition", "firstPosition() const", typeof(int));
		}
		public int LastPosition() {
			return (int) interceptor.Invoke("lastPosition", "lastPosition() const", typeof(int));
		}
		public QTextFrameLayoutData LayoutData() {
			return (QTextFrameLayoutData) interceptor.Invoke("layoutData", "layoutData() const", typeof(QTextFrameLayoutData));
		}
		public void SetLayoutData(QTextFrameLayoutData data) {
			interceptor.Invoke("setLayoutData#", "setLayoutData(QTextFrameLayoutData*)", typeof(void), typeof(QTextFrameLayoutData), data);
		}
		public List<QTextFrame> ChildFrames() {
			return (List<QTextFrame>) interceptor.Invoke("childFrames", "childFrames() const", typeof(List<QTextFrame>));
		}
		public QTextFrame ParentFrame() {
			return (QTextFrame) interceptor.Invoke("parentFrame", "parentFrame() const", typeof(QTextFrame));
		}
		~QTextFrame() {
			interceptor.Invoke("~QTextFrame", "~QTextFrame()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QTextFrame", "~QTextFrame()", typeof(void));
		}
		public static string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQTextFrameSignals Emit {
			get { return (IQTextFrameSignals) Q_EMIT; }
		}
	}

	public interface IQTextFrameSignals : IQTextObjectSignals {
	}
}
