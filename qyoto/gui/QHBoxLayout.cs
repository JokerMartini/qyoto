//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QHBoxLayout")]
	public class QHBoxLayout : QBoxLayout, IDisposable {
 		protected QHBoxLayout(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QHBoxLayout), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QHBoxLayout() {
			staticInterceptor = new SmokeInvocation(typeof(QHBoxLayout), null);
		}
		public QHBoxLayout() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QHBoxLayout", "QHBoxLayout()", typeof(void));
		}
		public QHBoxLayout(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QHBoxLayout#", "QHBoxLayout(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		~QHBoxLayout() {
			interceptor.Invoke("~QHBoxLayout", "~QHBoxLayout()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QHBoxLayout", "~QHBoxLayout()", typeof(void));
		}
		public static string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQHBoxLayoutSignals Emit {
			get { return (IQHBoxLayoutSignals) Q_EMIT; }
		}
	}

	public interface IQHBoxLayoutSignals : IQBoxLayoutSignals {
	}
}
