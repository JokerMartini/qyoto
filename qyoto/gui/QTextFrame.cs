//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	[SmokeClass("QTextFrame")]
	public class QTextFrame : QTextObject, IDisposable {
 		protected QTextFrame(Type dummy) : base((Type) null) {}
		interface IQTextFrameProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextFrame), this);
			_interceptor = (QTextFrame) realProxy.GetTransparentProxy();
		}
		private QTextFrame ProxyQTextFrame() {
			return (QTextFrame) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextFrame() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextFrameProxy), null);
			_staticInterceptor = (IQTextFrameProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextFrameProxy StaticQTextFrame() {
			return (IQTextFrameProxy) _staticInterceptor;
		}

		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		// QTextFrame* QTextFrame(QTextDocument* arg1); >>>> NOT CONVERTED
		[SmokeMethod("setFrameFormat(const QTextFrameFormat&)")]
		public void SetFrameFormat(QTextFrameFormat format) {
			ProxyQTextFrame().SetFrameFormat(format);
		}
		[SmokeMethod("frameFormat() const")]
		public QTextFrameFormat FrameFormat() {
			return ProxyQTextFrame().FrameFormat();
		}
		// QTextCursor firstCursorPosition(); >>>> NOT CONVERTED
		// QTextCursor lastCursorPosition(); >>>> NOT CONVERTED
		[SmokeMethod("firstPosition() const")]
		public int FirstPosition() {
			return ProxyQTextFrame().FirstPosition();
		}
		[SmokeMethod("lastPosition() const")]
		public int LastPosition() {
			return ProxyQTextFrame().LastPosition();
		}
		[SmokeMethod("layoutData() const")]
		public QTextFrameLayoutData LayoutData() {
			return ProxyQTextFrame().LayoutData();
		}
		[SmokeMethod("setLayoutData(QTextFrameLayoutData*)")]
		public void SetLayoutData(QTextFrameLayoutData data) {
			ProxyQTextFrame().SetLayoutData(data);
		}
		[SmokeMethod("childFrames() const")]
		public List<QTextFrame> ChildFrames() {
			return ProxyQTextFrame().ChildFrames();
		}
		[SmokeMethod("parentFrame() const")]
		public QTextFrame ParentFrame() {
			return ProxyQTextFrame().ParentFrame();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQTextFrame().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQTextFrame().Tr(s);
		}
		~QTextFrame() {
			DisposeQTextFrame();
		}
		public new void Dispose() {
			DisposeQTextFrame();
		}
		[SmokeMethod("~QTextFrame()")]
		private void DisposeQTextFrame() {
			ProxyQTextFrame().DisposeQTextFrame();
		}
		protected new IQTextFrameSignals Emit() {
			return (IQTextFrameSignals) Q_EMIT;
		}
	}

	public interface IQTextFrameSignals : IQTextObjectSignals {
	}
}
