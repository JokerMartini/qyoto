//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QAccessibleTextInterface")]
	public abstract class QAccessibleTextInterface : QAccessible2Interface {
 		protected QAccessibleTextInterface(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QAccessibleTextInterface), this);
		}
		public QAccessible2Interface QAccessibleTextCastHelper() {
			return (QAccessible2Interface) interceptor.Invoke("qAccessibleTextCastHelper", "qAccessibleTextCastHelper()", typeof(QAccessible2Interface));
		}
		[SmokeMethod("addSelection(int, int)")]
		public abstract void AddSelection(int startOffset, int endOffset);
		[SmokeMethod("attributes(int, int*, int*)")]
		public abstract string Attributes(int offset, int startOffset, int endOffset);
		[SmokeMethod("cursorPosition()")]
		public abstract int CursorPosition();
		[SmokeMethod("characterRect(int, QAccessible2::CoordinateType)")]
		public abstract QRect CharacterRect(int offset, QAccessible2.CoordinateType coordType);
		[SmokeMethod("selectionCount()")]
		public abstract int SelectionCount();
		[SmokeMethod("offsetAtPoint(const QPoint&, QAccessible2::CoordinateType)")]
		public abstract int OffsetAtPoint(QPoint point, QAccessible2.CoordinateType coordType);
		[SmokeMethod("selection(int, int*, int*)")]
		public abstract void Selection(int selectionIndex, int startOffset, int endOffset);
		[SmokeMethod("text(int, int)")]
		public abstract string Text(int startOffset, int endOffset);
		[SmokeMethod("textBeforeOffset(int, QAccessible2::BoundaryType, int*, int*)")]
		public abstract string TextBeforeOffset(int offset, QAccessible2.BoundaryType boundaryType, int startOffset, int endOffset);
		[SmokeMethod("textAfterOffset(int, QAccessible2::BoundaryType, int*, int*)")]
		public abstract string TextAfterOffset(int offset, QAccessible2.BoundaryType boundaryType, int startOffset, int endOffset);
		[SmokeMethod("textAtOffset(int, QAccessible2::BoundaryType, int*, int*)")]
		public abstract string TextAtOffset(int offset, QAccessible2.BoundaryType boundaryType, int startOffset, int endOffset);
		[SmokeMethod("removeSelection(int)")]
		public abstract void RemoveSelection(int selectionIndex);
		[SmokeMethod("setCursorPosition(int)")]
		public abstract void SetCursorPosition(int position);
		[SmokeMethod("setSelection(int, int, int)")]
		public abstract void SetSelection(int selectionIndex, int startOffset, int endOffset);
		[SmokeMethod("characterCount()")]
		public abstract int CharacterCount();
		[SmokeMethod("scrollToSubstring(int, int)")]
		public abstract void ScrollToSubstring(int startIndex, int endIndex);
		public QAccessibleTextInterface() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QAccessibleTextInterface", "QAccessibleTextInterface()", typeof(void));
		}
	}
}
