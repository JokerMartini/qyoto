//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	[SmokeClass("QTextObject")]
	public class QTextObject : QObject {
 		protected QTextObject(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QTextObject), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QTextObject() {
			staticInterceptor = new SmokeInvocation(typeof(QTextObject), null);
		}
		// QTextDocumentPrivate* docHandle(); >>>> NOT CONVERTED
		// QTextObject* QTextObject(QTextObjectPrivate& arg1,QTextDocument* arg2); >>>> NOT CONVERTED
		public QTextFormat Format() {
			return (QTextFormat) interceptor.Invoke("format", "format() const", typeof(QTextFormat));
		}
		public int FormatIndex() {
			return (int) interceptor.Invoke("formatIndex", "formatIndex() const", typeof(int));
		}
		public QTextDocument Document() {
			return (QTextDocument) interceptor.Invoke("document", "document() const", typeof(QTextDocument));
		}
		public int ObjectIndex() {
			return (int) interceptor.Invoke("objectIndex", "objectIndex() const", typeof(int));
		}
		public QTextObject(QTextDocument doc) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTextObject#", "QTextObject(QTextDocument*)", typeof(void), typeof(QTextDocument), doc);
		}
		protected void SetFormat(QTextFormat format) {
			interceptor.Invoke("setFormat#", "setFormat(const QTextFormat&)", typeof(void), typeof(QTextFormat), format);
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQTextObjectSignals Emit {
			get { return (IQTextObjectSignals) Q_EMIT; }
		}
	}

	public interface IQTextObjectSignals : IQObjectSignals {
	}
}
