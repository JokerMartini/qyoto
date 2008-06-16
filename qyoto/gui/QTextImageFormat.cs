//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	[SmokeClass("QTextImageFormat")]
	public class QTextImageFormat : QTextCharFormat, IDisposable {
 		protected QTextImageFormat(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QTextImageFormat), this);
		}
		public QTextImageFormat() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTextImageFormat", "QTextImageFormat()", typeof(void));
		}
		public new bool IsValid() {
			return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
		}
		public void SetName(string name) {
			interceptor.Invoke("setName$", "setName(const QString&)", typeof(void), typeof(string), name);
		}
		public string Name() {
			return (string) interceptor.Invoke("name", "name() const", typeof(string));
		}
		public void SetWidth(double width) {
			interceptor.Invoke("setWidth$", "setWidth(qreal)", typeof(void), typeof(double), width);
		}
		public double Width() {
			return (double) interceptor.Invoke("width", "width() const", typeof(double));
		}
		public void SetHeight(double height) {
			interceptor.Invoke("setHeight$", "setHeight(qreal)", typeof(void), typeof(double), height);
		}
		public double Height() {
			return (double) interceptor.Invoke("height", "height() const", typeof(double));
		}
		public QTextImageFormat(QTextFormat format) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTextImageFormat#", "QTextImageFormat(const QTextFormat&)", typeof(void), typeof(QTextFormat), format);
		}
		~QTextImageFormat() {
			interceptor.Invoke("~QTextImageFormat", "~QTextImageFormat()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QTextImageFormat", "~QTextImageFormat()", typeof(void));
		}
	}
}
