//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	using System.Collections.Generic;
	/// <remarks> See <see cref="IQColumnViewSignals"></see> for signals emitted by QColumnView
	/// </remarks>
	[SmokeClass("QColumnView")]
	public class QColumnView : QAbstractItemView, IDisposable {
 		protected QColumnView(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QColumnView), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QColumnView() {
			staticInterceptor = new SmokeInvocation(typeof(QColumnView), null);
		}
		[Q_PROPERTY("bool", "resizeGripsVisible")]
		public bool ResizeGripsVisible {
			get { return (bool) interceptor.Invoke("resizeGripsVisible", "resizeGripsVisible()", typeof(bool)); }
			set { interceptor.Invoke("setResizeGripsVisible$", "setResizeGripsVisible(bool)", typeof(void), typeof(bool), value); }
		}
		// QColumnView* QColumnView(QColumnViewPrivate& arg1,QWidget* arg2); >>>> NOT CONVERTED
		// QColumnView* QColumnView(QColumnViewPrivate& arg1); >>>> NOT CONVERTED
		public QColumnView(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QColumnView#", "QColumnView(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public QColumnView() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QColumnView", "QColumnView()", typeof(void));
		}
		[SmokeMethod("indexAt(const QPoint&) const")]
		public override QModelIndex IndexAt(QPoint point) {
			return (QModelIndex) interceptor.Invoke("indexAt#", "indexAt(const QPoint&) const", typeof(QModelIndex), typeof(QPoint), point);
		}
		[SmokeMethod("scrollTo(const QModelIndex&, QAbstractItemView::ScrollHint)")]
		public override void ScrollTo(QModelIndex index, QAbstractItemView.ScrollHint hint) {
			interceptor.Invoke("scrollTo#$", "scrollTo(const QModelIndex&, QAbstractItemView::ScrollHint)", typeof(void), typeof(QModelIndex), index, typeof(QAbstractItemView.ScrollHint), hint);
		}
		[SmokeMethod("scrollTo(const QModelIndex&)")]
		public virtual void ScrollTo(QModelIndex index) {
			interceptor.Invoke("scrollTo#", "scrollTo(const QModelIndex&)", typeof(void), typeof(QModelIndex), index);
		}
		[SmokeMethod("sizeHint() const")]
		public override QSize SizeHint() {
			return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
		}
		[SmokeMethod("visualRect(const QModelIndex&) const")]
		public override QRect VisualRect(QModelIndex index) {
			return (QRect) interceptor.Invoke("visualRect#", "visualRect(const QModelIndex&) const", typeof(QRect), typeof(QModelIndex), index);
		}
		[SmokeMethod("setModel(QAbstractItemModel*)")]
		public override void SetModel(QAbstractItemModel model) {
			interceptor.Invoke("setModel#", "setModel(QAbstractItemModel*)", typeof(void), typeof(QAbstractItemModel), model);
		}
		[SmokeMethod("setSelectionModel(QItemSelectionModel*)")]
		public override void SetSelectionModel(QItemSelectionModel selectionModel) {
			interceptor.Invoke("setSelectionModel#", "setSelectionModel(QItemSelectionModel*)", typeof(void), typeof(QItemSelectionModel), selectionModel);
		}
		[SmokeMethod("setRootIndex(const QModelIndex&)")]
		public override void SetRootIndex(QModelIndex index) {
			interceptor.Invoke("setRootIndex#", "setRootIndex(const QModelIndex&)", typeof(void), typeof(QModelIndex), index);
		}
		[SmokeMethod("selectAll()")]
		public override void SelectAll() {
			interceptor.Invoke("selectAll", "selectAll()", typeof(void));
		}
		public QWidget PreviewWidget() {
			return (QWidget) interceptor.Invoke("previewWidget", "previewWidget() const", typeof(QWidget));
		}
		public void SetPreviewWidget(QWidget widget) {
			interceptor.Invoke("setPreviewWidget#", "setPreviewWidget(QWidget*)", typeof(void), typeof(QWidget), widget);
		}
		public void SetColumnWidths(List<int> list) {
			interceptor.Invoke("setColumnWidths?", "setColumnWidths(const QList<int>&)", typeof(void), typeof(List<int>), list);
		}
		public List<int> ColumnWidths() {
			return (List<int>) interceptor.Invoke("columnWidths", "columnWidths() const", typeof(List<int>));
		}
		[SmokeMethod("isIndexHidden(const QModelIndex&) const")]
		protected override bool IsIndexHidden(QModelIndex index) {
			return (bool) interceptor.Invoke("isIndexHidden#", "isIndexHidden(const QModelIndex&) const", typeof(bool), typeof(QModelIndex), index);
		}
		[SmokeMethod("moveCursor(QAbstractItemView::CursorAction, Qt::KeyboardModifiers)")]
		protected override QModelIndex MoveCursor(QAbstractItemView.CursorAction cursorAction, uint modifiers) {
			return (QModelIndex) interceptor.Invoke("moveCursor$$", "moveCursor(QAbstractItemView::CursorAction, Qt::KeyboardModifiers)", typeof(QModelIndex), typeof(QAbstractItemView.CursorAction), cursorAction, typeof(uint), modifiers);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected override void ResizeEvent(QResizeEvent arg1) {
			interceptor.Invoke("resizeEvent#", "resizeEvent(QResizeEvent*)", typeof(void), typeof(QResizeEvent), arg1);
		}
		[SmokeMethod("setSelection(const QRect&, QItemSelectionModel::SelectionFlags)")]
		protected override void SetSelection(QRect rect, uint command) {
			interceptor.Invoke("setSelection#$", "setSelection(const QRect&, QItemSelectionModel::SelectionFlags)", typeof(void), typeof(QRect), rect, typeof(uint), command);
		}
		[SmokeMethod("visualRegionForSelection(const QItemSelection&) const")]
		protected override QRegion VisualRegionForSelection(QItemSelection selection) {
			return (QRegion) interceptor.Invoke("visualRegionForSelection#", "visualRegionForSelection(const QItemSelection&) const", typeof(QRegion), typeof(QItemSelection), selection);
		}
		[SmokeMethod("horizontalOffset() const")]
		protected override int HorizontalOffset() {
			return (int) interceptor.Invoke("horizontalOffset", "horizontalOffset() const", typeof(int));
		}
		[SmokeMethod("verticalOffset() const")]
		protected override int VerticalOffset() {
			return (int) interceptor.Invoke("verticalOffset", "verticalOffset() const", typeof(int));
		}
		[SmokeMethod("scrollContentsBy(int, int)")]
		protected override void ScrollContentsBy(int dx, int dy) {
			interceptor.Invoke("scrollContentsBy$$", "scrollContentsBy(int, int)", typeof(void), typeof(int), dx, typeof(int), dy);
		}
		[SmokeMethod("createColumn(const QModelIndex&)")]
		protected virtual QAbstractItemView CreateColumn(QModelIndex rootIndex) {
			return (QAbstractItemView) interceptor.Invoke("createColumn#", "createColumn(const QModelIndex&)", typeof(QAbstractItemView), typeof(QModelIndex), rootIndex);
		}
		protected void InitializeColumn(QAbstractItemView column) {
			interceptor.Invoke("initializeColumn#", "initializeColumn(QAbstractItemView*) const", typeof(void), typeof(QAbstractItemView), column);
		}
		[Q_SLOT("void currentChanged(const QModelIndex&, const QModelIndex&)")]
		[SmokeMethod("currentChanged(const QModelIndex&, const QModelIndex&)")]
		protected override void CurrentChanged(QModelIndex current, QModelIndex previous) {
			interceptor.Invoke("currentChanged##", "currentChanged(const QModelIndex&, const QModelIndex&)", typeof(void), typeof(QModelIndex), current, typeof(QModelIndex), previous);
		}
		~QColumnView() {
			interceptor.Invoke("~QColumnView", "~QColumnView()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QColumnView", "~QColumnView()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQColumnViewSignals Emit {
			get { return (IQColumnViewSignals) Q_EMIT; }
		}
	}

	public interface IQColumnViewSignals : IQAbstractItemViewSignals {
		[Q_SIGNAL("void updatePreviewWidget(const QModelIndex&)")]
		void UpdatePreviewWidget(QModelIndex index);
	}
}
