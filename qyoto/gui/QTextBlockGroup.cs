//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QTextBlockGroup")]
	public class QTextBlockGroup : QTextObject {
 		protected QTextBlockGroup(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QTextBlockGroup), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QTextBlockGroup() {
			staticInterceptor = new SmokeInvocation(typeof(QTextBlockGroup), null);
		}
		public QTextBlockGroup(QTextDocument doc) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTextBlockGroup#", "QTextBlockGroup(QTextDocument*)", typeof(void), typeof(QTextDocument), doc);
		}
		[SmokeMethod("blockInserted(const QTextBlock&)")]
		protected virtual void BlockInserted(QTextBlock block) {
			interceptor.Invoke("blockInserted#", "blockInserted(const QTextBlock&)", typeof(void), typeof(QTextBlock), block);
		}
		[SmokeMethod("blockRemoved(const QTextBlock&)")]
		protected virtual void BlockRemoved(QTextBlock block) {
			interceptor.Invoke("blockRemoved#", "blockRemoved(const QTextBlock&)", typeof(void), typeof(QTextBlock), block);
		}
		[SmokeMethod("blockFormatChanged(const QTextBlock&)")]
		protected virtual void BlockFormatChanged(QTextBlock block) {
			interceptor.Invoke("blockFormatChanged#", "blockFormatChanged(const QTextBlock&)", typeof(void), typeof(QTextBlock), block);
		}
		protected List<QTextBlock> BlockList() {
			return (List<QTextBlock>) interceptor.Invoke("blockList", "blockList() const", typeof(List<QTextBlock>));
		}
		public static string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQTextBlockGroupSignals Emit {
			get { return (IQTextBlockGroupSignals) Q_EMIT; }
		}
	}

	public interface IQTextBlockGroupSignals : IQTextObjectSignals {
	}
}
