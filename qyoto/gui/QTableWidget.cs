//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	/// See <see cref="IQTableWidgetSignals"></see> for signals emitted by QTableWidget
	[SmokeClass("QTableWidget")]
	public class QTableWidget : QTableView, IDisposable {
 		protected QTableWidget(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QTableWidget), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QTableWidget() {
			staticInterceptor = new SmokeInvocation(typeof(QTableWidget), null);
		}
		[Q_PROPERTY("int", "rowCount")]
		public int RowCount {
			get { return (int) interceptor.Invoke("rowCount", "rowCount()", typeof(int)); }
			set { interceptor.Invoke("setRowCount$", "setRowCount(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("int", "columnCount")]
		public int ColumnCount {
			get { return (int) interceptor.Invoke("columnCount", "columnCount()", typeof(int)); }
			set { interceptor.Invoke("setColumnCount$", "setColumnCount(int)", typeof(void), typeof(int), value); }
		}
		public QTableWidget(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTableWidget#", "QTableWidget(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public QTableWidget() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTableWidget", "QTableWidget()", typeof(void));
		}
		public QTableWidget(int rows, int columns, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTableWidget$$#", "QTableWidget(int, int, QWidget*)", typeof(void), typeof(int), rows, typeof(int), columns, typeof(QWidget), parent);
		}
		public QTableWidget(int rows, int columns) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTableWidget$$", "QTableWidget(int, int)", typeof(void), typeof(int), rows, typeof(int), columns);
		}
		public int Row(QTableWidgetItem item) {
			return (int) interceptor.Invoke("row#", "row(const QTableWidgetItem*) const", typeof(int), typeof(QTableWidgetItem), item);
		}
		public int Column(QTableWidgetItem item) {
			return (int) interceptor.Invoke("column#", "column(const QTableWidgetItem*) const", typeof(int), typeof(QTableWidgetItem), item);
		}
		public QTableWidgetItem Item(int row, int column) {
			return (QTableWidgetItem) interceptor.Invoke("item$$", "item(int, int) const", typeof(QTableWidgetItem), typeof(int), row, typeof(int), column);
		}
		public void SetItem(int row, int column, QTableWidgetItem item) {
			interceptor.Invoke("setItem$$#", "setItem(int, int, QTableWidgetItem*)", typeof(void), typeof(int), row, typeof(int), column, typeof(QTableWidgetItem), item);
		}
		public QTableWidgetItem TakeItem(int row, int column) {
			return (QTableWidgetItem) interceptor.Invoke("takeItem$$", "takeItem(int, int)", typeof(QTableWidgetItem), typeof(int), row, typeof(int), column);
		}
		public QTableWidgetItem VerticalHeaderItem(int row) {
			return (QTableWidgetItem) interceptor.Invoke("verticalHeaderItem$", "verticalHeaderItem(int) const", typeof(QTableWidgetItem), typeof(int), row);
		}
		public void SetVerticalHeaderItem(int row, QTableWidgetItem item) {
			interceptor.Invoke("setVerticalHeaderItem$#", "setVerticalHeaderItem(int, QTableWidgetItem*)", typeof(void), typeof(int), row, typeof(QTableWidgetItem), item);
		}
		public QTableWidgetItem TakeVerticalHeaderItem(int row) {
			return (QTableWidgetItem) interceptor.Invoke("takeVerticalHeaderItem$", "takeVerticalHeaderItem(int)", typeof(QTableWidgetItem), typeof(int), row);
		}
		public QTableWidgetItem HorizontalHeaderItem(int column) {
			return (QTableWidgetItem) interceptor.Invoke("horizontalHeaderItem$", "horizontalHeaderItem(int) const", typeof(QTableWidgetItem), typeof(int), column);
		}
		public void SetHorizontalHeaderItem(int column, QTableWidgetItem item) {
			interceptor.Invoke("setHorizontalHeaderItem$#", "setHorizontalHeaderItem(int, QTableWidgetItem*)", typeof(void), typeof(int), column, typeof(QTableWidgetItem), item);
		}
		public QTableWidgetItem TakeHorizontalHeaderItem(int column) {
			return (QTableWidgetItem) interceptor.Invoke("takeHorizontalHeaderItem$", "takeHorizontalHeaderItem(int)", typeof(QTableWidgetItem), typeof(int), column);
		}
		public void SetVerticalHeaderLabels(List<string> labels) {
			interceptor.Invoke("setVerticalHeaderLabels?", "setVerticalHeaderLabels(const QStringList&)", typeof(void), typeof(List<string>), labels);
		}
		public void SetHorizontalHeaderLabels(List<string> labels) {
			interceptor.Invoke("setHorizontalHeaderLabels?", "setHorizontalHeaderLabels(const QStringList&)", typeof(void), typeof(List<string>), labels);
		}
		public int CurrentRow() {
			return (int) interceptor.Invoke("currentRow", "currentRow() const", typeof(int));
		}
		public int CurrentColumn() {
			return (int) interceptor.Invoke("currentColumn", "currentColumn() const", typeof(int));
		}
		public QTableWidgetItem CurrentItem() {
			return (QTableWidgetItem) interceptor.Invoke("currentItem", "currentItem() const", typeof(QTableWidgetItem));
		}
		public void SetCurrentItem(QTableWidgetItem item) {
			interceptor.Invoke("setCurrentItem#", "setCurrentItem(QTableWidgetItem*)", typeof(void), typeof(QTableWidgetItem), item);
		}
		public void SetCurrentCell(int row, int column) {
			interceptor.Invoke("setCurrentCell$$", "setCurrentCell(int, int)", typeof(void), typeof(int), row, typeof(int), column);
		}
		public void SortItems(int column, Qt.SortOrder order) {
			interceptor.Invoke("sortItems$$", "sortItems(int, Qt::SortOrder)", typeof(void), typeof(int), column, typeof(Qt.SortOrder), order);
		}
		public void SortItems(int column) {
			interceptor.Invoke("sortItems$", "sortItems(int)", typeof(void), typeof(int), column);
		}
		public void SetSortingEnabled(bool enable) {
			interceptor.Invoke("setSortingEnabled$", "setSortingEnabled(bool)", typeof(void), typeof(bool), enable);
		}
		public bool IsSortingEnabled() {
			return (bool) interceptor.Invoke("isSortingEnabled", "isSortingEnabled() const", typeof(bool));
		}
		public void EditItem(QTableWidgetItem item) {
			interceptor.Invoke("editItem#", "editItem(QTableWidgetItem*)", typeof(void), typeof(QTableWidgetItem), item);
		}
		public void OpenPersistentEditor(QTableWidgetItem item) {
			interceptor.Invoke("openPersistentEditor#", "openPersistentEditor(QTableWidgetItem*)", typeof(void), typeof(QTableWidgetItem), item);
		}
		public void ClosePersistentEditor(QTableWidgetItem item) {
			interceptor.Invoke("closePersistentEditor#", "closePersistentEditor(QTableWidgetItem*)", typeof(void), typeof(QTableWidgetItem), item);
		}
		public QWidget CellWidget(int row, int column) {
			return (QWidget) interceptor.Invoke("cellWidget$$", "cellWidget(int, int) const", typeof(QWidget), typeof(int), row, typeof(int), column);
		}
		public void SetCellWidget(int row, int column, QWidget widget) {
			interceptor.Invoke("setCellWidget$$#", "setCellWidget(int, int, QWidget*)", typeof(void), typeof(int), row, typeof(int), column, typeof(QWidget), widget);
		}
		public void RemoveCellWidget(int row, int column) {
			interceptor.Invoke("removeCellWidget$$", "removeCellWidget(int, int)", typeof(void), typeof(int), row, typeof(int), column);
		}
		public bool IsItemSelected(QTableWidgetItem item) {
			return (bool) interceptor.Invoke("isItemSelected#", "isItemSelected(const QTableWidgetItem*) const", typeof(bool), typeof(QTableWidgetItem), item);
		}
		public void SetItemSelected(QTableWidgetItem item, bool select) {
			interceptor.Invoke("setItemSelected#$", "setItemSelected(const QTableWidgetItem*, bool)", typeof(void), typeof(QTableWidgetItem), item, typeof(bool), select);
		}
		public void SetRangeSelected(QTableWidgetSelectionRange range, bool select) {
			interceptor.Invoke("setRangeSelected#$", "setRangeSelected(const QTableWidgetSelectionRange&, bool)", typeof(void), typeof(QTableWidgetSelectionRange), range, typeof(bool), select);
		}
		public List<QTableWidgetSelectionRange> SelectedRanges() {
			return (List<QTableWidgetSelectionRange>) interceptor.Invoke("selectedRanges", "selectedRanges() const", typeof(List<QTableWidgetSelectionRange>));
		}
		public List<QTableWidgetItem> SelectedItems() {
			return (List<QTableWidgetItem>) interceptor.Invoke("selectedItems", "selectedItems()", typeof(List<QTableWidgetItem>));
		}
		public List<QTableWidgetItem> FindItems(string text, int flags) {
			return (List<QTableWidgetItem>) interceptor.Invoke("findItems$$", "findItems(const QString&, Qt::MatchFlags) const", typeof(List<QTableWidgetItem>), typeof(string), text, typeof(int), flags);
		}
		public int VisualRow(int logicalRow) {
			return (int) interceptor.Invoke("visualRow$", "visualRow(int) const", typeof(int), typeof(int), logicalRow);
		}
		public int VisualColumn(int logicalColumn) {
			return (int) interceptor.Invoke("visualColumn$", "visualColumn(int) const", typeof(int), typeof(int), logicalColumn);
		}
		public QTableWidgetItem ItemAt(QPoint p) {
			return (QTableWidgetItem) interceptor.Invoke("itemAt#", "itemAt(const QPoint&) const", typeof(QTableWidgetItem), typeof(QPoint), p);
		}
		public QTableWidgetItem ItemAt(int x, int y) {
			return (QTableWidgetItem) interceptor.Invoke("itemAt$$", "itemAt(int, int) const", typeof(QTableWidgetItem), typeof(int), x, typeof(int), y);
		}
		public QRect VisualItemRect(QTableWidgetItem item) {
			return (QRect) interceptor.Invoke("visualItemRect#", "visualItemRect(const QTableWidgetItem*) const", typeof(QRect), typeof(QTableWidgetItem), item);
		}
		public QTableWidgetItem ItemPrototype() {
			return (QTableWidgetItem) interceptor.Invoke("itemPrototype", "itemPrototype() const", typeof(QTableWidgetItem));
		}
		public void SetItemPrototype(QTableWidgetItem item) {
			interceptor.Invoke("setItemPrototype#", "setItemPrototype(const QTableWidgetItem*)", typeof(void), typeof(QTableWidgetItem), item);
		}
		[Q_SLOT("void scrollToItem(const QTableWidgetItem*, QAbstractItemView::ScrollHint)")]
		public void ScrollToItem(QTableWidgetItem item, QAbstractItemView.ScrollHint hint) {
			interceptor.Invoke("scrollToItem#$", "scrollToItem(const QTableWidgetItem*, QAbstractItemView::ScrollHint)", typeof(void), typeof(QTableWidgetItem), item, typeof(QAbstractItemView.ScrollHint), hint);
		}
		[Q_SLOT("void scrollToItem(const QTableWidgetItem*)")]
		public void ScrollToItem(QTableWidgetItem item) {
			interceptor.Invoke("scrollToItem#", "scrollToItem(const QTableWidgetItem*)", typeof(void), typeof(QTableWidgetItem), item);
		}
		[Q_SLOT("void insertRow(int)")]
		public void InsertRow(int row) {
			interceptor.Invoke("insertRow$", "insertRow(int)", typeof(void), typeof(int), row);
		}
		[Q_SLOT("void insertColumn(int)")]
		public void InsertColumn(int column) {
			interceptor.Invoke("insertColumn$", "insertColumn(int)", typeof(void), typeof(int), column);
		}
		[Q_SLOT("void removeRow(int)")]
		public void RemoveRow(int row) {
			interceptor.Invoke("removeRow$", "removeRow(int)", typeof(void), typeof(int), row);
		}
		[Q_SLOT("void removeColumn(int)")]
		public void RemoveColumn(int column) {
			interceptor.Invoke("removeColumn$", "removeColumn(int)", typeof(void), typeof(int), column);
		}
		[Q_SLOT("void clear()")]
		public void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		[Q_SLOT("void clearContents()")]
		public void ClearContents() {
			interceptor.Invoke("clearContents", "clearContents()", typeof(void));
		}
		[SmokeMethod("event(QEvent*)")]
		protected override bool Event(QEvent e) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), e);
		}
		[SmokeMethod("mimeTypes() const")]
		protected virtual List<string> MimeTypes() {
			return (List<string>) interceptor.Invoke("mimeTypes", "mimeTypes() const", typeof(List<string>));
		}
		[SmokeMethod("mimeData(const QList<QTableWidgetItem*>) const")]
		protected virtual QMimeData MimeData(List<QTableWidgetItem> items) {
			return (QMimeData) interceptor.Invoke("mimeData?", "mimeData(const QList<QTableWidgetItem*>) const", typeof(QMimeData), typeof(List<QTableWidgetItem>), items);
		}
		[SmokeMethod("dropMimeData(int, int, const QMimeData*, Qt::DropAction)")]
		protected virtual bool DropMimeData(int row, int column, QMimeData data, Qt.DropAction action) {
			return (bool) interceptor.Invoke("dropMimeData$$#$", "dropMimeData(int, int, const QMimeData*, Qt::DropAction)", typeof(bool), typeof(int), row, typeof(int), column, typeof(QMimeData), data, typeof(Qt.DropAction), action);
		}
		[SmokeMethod("supportedDropActions() const")]
		protected virtual int SupportedDropActions() {
			return (int) interceptor.Invoke("supportedDropActions", "supportedDropActions() const", typeof(int));
		}
		protected List<QTableWidgetItem> Items(QMimeData data) {
			return (List<QTableWidgetItem>) interceptor.Invoke("items#", "items(const QMimeData*) const", typeof(List<QTableWidgetItem>), typeof(QMimeData), data);
		}
		protected QModelIndex IndexFromItem(QTableWidgetItem item) {
			return (QModelIndex) interceptor.Invoke("indexFromItem#", "indexFromItem(QTableWidgetItem*) const", typeof(QModelIndex), typeof(QTableWidgetItem), item);
		}
		protected QTableWidgetItem ItemFromIndex(QModelIndex index) {
			return (QTableWidgetItem) interceptor.Invoke("itemFromIndex#", "itemFromIndex(const QModelIndex&) const", typeof(QTableWidgetItem), typeof(QModelIndex), index);
		}
		[SmokeMethod("dropEvent(QDropEvent*)")]
		protected override void DropEvent(QDropEvent arg1) {
			interceptor.Invoke("dropEvent#", "dropEvent(QDropEvent*)", typeof(void), typeof(QDropEvent), arg1);
		}
		~QTableWidget() {
			interceptor.Invoke("~QTableWidget", "~QTableWidget()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QTableWidget", "~QTableWidget()", typeof(void));
		}
		public static string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQTableWidgetSignals Emit {
			get { return (IQTableWidgetSignals) Q_EMIT; }
		}
	}

	public interface IQTableWidgetSignals : IQTableViewSignals {
		[Q_SIGNAL("void itemPressed(QTableWidgetItem*)")]
		void ItemPressed(QTableWidgetItem item);
		[Q_SIGNAL("void itemClicked(QTableWidgetItem*)")]
		void ItemClicked(QTableWidgetItem item);
		[Q_SIGNAL("void itemDoubleClicked(QTableWidgetItem*)")]
		void ItemDoubleClicked(QTableWidgetItem item);
		[Q_SIGNAL("void itemActivated(QTableWidgetItem*)")]
		void ItemActivated(QTableWidgetItem item);
		[Q_SIGNAL("void itemEntered(QTableWidgetItem*)")]
		void ItemEntered(QTableWidgetItem item);
		[Q_SIGNAL("void itemChanged(QTableWidgetItem*)")]
		void ItemChanged(QTableWidgetItem item);
		[Q_SIGNAL("void currentItemChanged(QTableWidgetItem*, QTableWidgetItem*)")]
		void CurrentItemChanged(QTableWidgetItem current, QTableWidgetItem previous);
		[Q_SIGNAL("void itemSelectionChanged()")]
		void ItemSelectionChanged();
		[Q_SIGNAL("void cellPressed(int, int)")]
		void CellPressed(int row, int column);
		[Q_SIGNAL("void cellClicked(int, int)")]
		void CellClicked(int row, int column);
		[Q_SIGNAL("void cellDoubleClicked(int, int)")]
		void CellDoubleClicked(int row, int column);
		[Q_SIGNAL("void cellActivated(int, int)")]
		void CellActivated(int row, int column);
		[Q_SIGNAL("void cellEntered(int, int)")]
		void CellEntered(int row, int column);
		[Q_SIGNAL("void cellChanged(int, int)")]
		void CellChanged(int row, int column);
		[Q_SIGNAL("void currentCellChanged(int, int, int, int)")]
		void CurrentCellChanged(int currentRow, int currentColumn, int previousRow, int previousColumn);
	}
}
