//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;

	/// <remarks>
	///  KCategorizedView allows you to use it as it were a QListView. 
	///  Subclass KCategorizedSortFilterProxyModel to provide category information for items.
	/// </remarks>		<author> Rafael Fernández López <ereslibre@kde.org>
	///   </author>
	/// 		<short> Item view for listing items.</short>
	/// 		<see> KCategorizedSortFilterProxyModel</see>

	[SmokeClass("KCategorizedView")]
	public class KCategorizedView : QListView, IDisposable {
 		protected KCategorizedView(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocationKDE(typeof(KCategorizedView), this);
		}
		// KCategoryDrawer* categoryDrawer(); >>>> NOT CONVERTED
		// void setCategoryDrawer(KCategoryDrawer* arg1); >>>> NOT CONVERTED
		public KCategorizedView(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KCategorizedView#", "KCategorizedView(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public KCategorizedView() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KCategorizedView", "KCategorizedView()", typeof(void));
		}
		[SmokeMethod("setModel(QAbstractItemModel*)")]
		public override void SetModel(QAbstractItemModel model) {
			interceptor.Invoke("setModel#", "setModel(QAbstractItemModel*)", typeof(void), typeof(QAbstractItemModel), model);
		}
		public void SetGridSize(QSize size) {
			interceptor.Invoke("setGridSize#", "setGridSize(const QSize&)", typeof(void), typeof(QSize), size);
		}
		[SmokeMethod("visualRect(const QModelIndex&) const")]
		public override QRect VisualRect(QModelIndex index) {
			return (QRect) interceptor.Invoke("visualRect#", "visualRect(const QModelIndex&) const", typeof(QRect), typeof(QModelIndex), index);
		}
		[SmokeMethod("indexAt(const QPoint&) const")]
		public override QModelIndex IndexAt(QPoint point) {
			return (QModelIndex) interceptor.Invoke("indexAt#", "indexAt(const QPoint&) const", typeof(QModelIndex), typeof(QPoint), point);
		}
		[Q_SLOT("void reset()")]
		[SmokeMethod("reset()")]
		public override void Reset() {
			interceptor.Invoke("reset", "reset()", typeof(void));
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected override void PaintEvent(QPaintEvent arg1) {
			interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), arg1);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected override void ResizeEvent(QResizeEvent arg1) {
			interceptor.Invoke("resizeEvent#", "resizeEvent(QResizeEvent*)", typeof(void), typeof(QResizeEvent), arg1);
		}
		[SmokeMethod("setSelection(const QRect&, QItemSelectionModel::SelectionFlags)")]
		protected override void SetSelection(QRect rect, uint flags) {
			interceptor.Invoke("setSelection#$", "setSelection(const QRect&, QItemSelectionModel::SelectionFlags)", typeof(void), typeof(QRect), rect, typeof(uint), flags);
		}
		[SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
		protected override void MouseMoveEvent(QMouseEvent arg1) {
			interceptor.Invoke("mouseMoveEvent#", "mouseMoveEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
		}
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected override void MousePressEvent(QMouseEvent arg1) {
			interceptor.Invoke("mousePressEvent#", "mousePressEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
		}
		[SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
		protected override void MouseReleaseEvent(QMouseEvent arg1) {
			interceptor.Invoke("mouseReleaseEvent#", "mouseReleaseEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
		}
		[SmokeMethod("leaveEvent(QEvent*)")]
		protected override void LeaveEvent(QEvent arg1) {
			interceptor.Invoke("leaveEvent#", "leaveEvent(QEvent*)", typeof(void), typeof(QEvent), arg1);
		}
		[SmokeMethod("startDrag(Qt::DropActions)")]
		protected override void StartDrag(uint supportedActions) {
			interceptor.Invoke("startDrag$", "startDrag(Qt::DropActions)", typeof(void), typeof(uint), supportedActions);
		}
		[SmokeMethod("dragMoveEvent(QDragMoveEvent*)")]
		protected override void DragMoveEvent(QDragMoveEvent arg1) {
			interceptor.Invoke("dragMoveEvent#", "dragMoveEvent(QDragMoveEvent*)", typeof(void), typeof(QDragMoveEvent), arg1);
		}
		[SmokeMethod("dragLeaveEvent(QDragLeaveEvent*)")]
		protected override void DragLeaveEvent(QDragLeaveEvent arg1) {
			interceptor.Invoke("dragLeaveEvent#", "dragLeaveEvent(QDragLeaveEvent*)", typeof(void), typeof(QDragLeaveEvent), arg1);
		}
		[SmokeMethod("dropEvent(QDropEvent*)")]
		protected override void DropEvent(QDropEvent arg1) {
			interceptor.Invoke("dropEvent#", "dropEvent(QDropEvent*)", typeof(void), typeof(QDropEvent), arg1);
		}
		[SmokeMethod("moveCursor(QAbstractItemView::CursorAction, Qt::KeyboardModifiers)")]
		protected override QModelIndex MoveCursor(QAbstractItemView.CursorAction cursorAction, uint modifiers) {
			return (QModelIndex) interceptor.Invoke("moveCursor$$", "moveCursor(QAbstractItemView::CursorAction, Qt::KeyboardModifiers)", typeof(QModelIndex), typeof(QAbstractItemView.CursorAction), cursorAction, typeof(uint), modifiers);
		}
		[Q_SLOT("void rowsInserted(const QModelIndex&, int, int)")]
		[SmokeMethod("rowsInserted(const QModelIndex&, int, int)")]
		protected override void RowsInserted(QModelIndex parent, int start, int end) {
			interceptor.Invoke("rowsInserted#$$", "rowsInserted(const QModelIndex&, int, int)", typeof(void), typeof(QModelIndex), parent, typeof(int), start, typeof(int), end);
		}
		[Q_SLOT("void rowsInsertedArtifficial(const QModelIndex&, int, int)")]
		[SmokeMethod("rowsInsertedArtifficial(const QModelIndex&, int, int)")]
		protected virtual void RowsInsertedArtifficial(QModelIndex parent, int start, int end) {
			interceptor.Invoke("rowsInsertedArtifficial#$$", "rowsInsertedArtifficial(const QModelIndex&, int, int)", typeof(void), typeof(QModelIndex), parent, typeof(int), start, typeof(int), end);
		}
		[Q_SLOT("void rowsRemoved(const QModelIndex&, int, int)")]
		[SmokeMethod("rowsRemoved(const QModelIndex&, int, int)")]
		protected virtual void RowsRemoved(QModelIndex parent, int start, int end) {
			interceptor.Invoke("rowsRemoved#$$", "rowsRemoved(const QModelIndex&, int, int)", typeof(void), typeof(QModelIndex), parent, typeof(int), start, typeof(int), end);
		}
		[Q_SLOT("void updateGeometries()")]
		[SmokeMethod("updateGeometries()")]
		protected override void UpdateGeometries() {
			interceptor.Invoke("updateGeometries", "updateGeometries()", typeof(void));
		}
		[Q_SLOT("void slotLayoutChanged()")]
		[SmokeMethod("slotLayoutChanged()")]
		protected virtual void SlotLayoutChanged() {
			interceptor.Invoke("slotLayoutChanged", "slotLayoutChanged()", typeof(void));
		}
		[Q_SLOT("void currentChanged(const QModelIndex&, const QModelIndex&)")]
		[SmokeMethod("currentChanged(const QModelIndex&, const QModelIndex&)")]
		protected override void CurrentChanged(QModelIndex current, QModelIndex previous) {
			interceptor.Invoke("currentChanged##", "currentChanged(const QModelIndex&, const QModelIndex&)", typeof(void), typeof(QModelIndex), current, typeof(QModelIndex), previous);
		}
		[Q_SLOT("void dataChanged(const QModelIndex&, const QModelIndex&)")]
		[SmokeMethod("dataChanged(const QModelIndex&, const QModelIndex&)")]
		protected override void DataChanged(QModelIndex topLeft, QModelIndex bottomRight) {
			interceptor.Invoke("dataChanged##", "dataChanged(const QModelIndex&, const QModelIndex&)", typeof(void), typeof(QModelIndex), topLeft, typeof(QModelIndex), bottomRight);
		}
		~KCategorizedView() {
			interceptor.Invoke("~KCategorizedView", "~KCategorizedView()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KCategorizedView", "~KCategorizedView()", typeof(void));
		}
		protected new IKCategorizedViewSignals Emit {
			get { return (IKCategorizedViewSignals) Q_EMIT; }
		}
	}

	public interface IKCategorizedViewSignals : IQListViewSignals {
	}
}
