//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	[SmokeClass("QAccessibleSimpleEditableTextInterface")]
	public class QAccessibleSimpleEditableTextInterface : QAccessibleEditableTextInterface, IDisposable {
 		protected QAccessibleSimpleEditableTextInterface(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QAccessibleSimpleEditableTextInterface), this);
		}
		public QAccessibleSimpleEditableTextInterface(QAccessibleInterface accessibleInterface) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QAccessibleSimpleEditableTextInterface#", "QAccessibleSimpleEditableTextInterface(QAccessibleInterface*)", typeof(void), typeof(QAccessibleInterface), accessibleInterface);
		}
		[SmokeMethod("copyText(int, int)")]
		public override void CopyText(int startOffset, int endOffset) {
			interceptor.Invoke("copyText$$", "copyText(int, int)", typeof(void), typeof(int), startOffset, typeof(int), endOffset);
		}
		[SmokeMethod("deleteText(int, int)")]
		public override void DeleteText(int startOffset, int endOffset) {
			interceptor.Invoke("deleteText$$", "deleteText(int, int)", typeof(void), typeof(int), startOffset, typeof(int), endOffset);
		}
		[SmokeMethod("insertText(int, const QString&)")]
		public override void InsertText(int offset, string text) {
			interceptor.Invoke("insertText$$", "insertText(int, const QString&)", typeof(void), typeof(int), offset, typeof(string), text);
		}
		[SmokeMethod("cutText(int, int)")]
		public override void CutText(int startOffset, int endOffset) {
			interceptor.Invoke("cutText$$", "cutText(int, int)", typeof(void), typeof(int), startOffset, typeof(int), endOffset);
		}
		[SmokeMethod("pasteText(int)")]
		public override void PasteText(int offset) {
			interceptor.Invoke("pasteText$", "pasteText(int)", typeof(void), typeof(int), offset);
		}
		[SmokeMethod("replaceText(int, int, const QString&)")]
		public override void ReplaceText(int startOffset, int endOffset, string text) {
			interceptor.Invoke("replaceText$$$", "replaceText(int, int, const QString&)", typeof(void), typeof(int), startOffset, typeof(int), endOffset, typeof(string), text);
		}
		[SmokeMethod("setAttributes(int, int, const QString&)")]
		public override void SetAttributes(int arg1, int arg2, string arg3) {
			interceptor.Invoke("setAttributes$$$", "setAttributes(int, int, const QString&)", typeof(void), typeof(int), arg1, typeof(int), arg2, typeof(string), arg3);
		}
		~QAccessibleSimpleEditableTextInterface() {
			interceptor.Invoke("~QAccessibleSimpleEditableTextInterface", "~QAccessibleSimpleEditableTextInterface()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QAccessibleSimpleEditableTextInterface", "~QAccessibleSimpleEditableTextInterface()", typeof(void));
		}
	}
}
