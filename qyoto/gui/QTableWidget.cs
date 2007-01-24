//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	/// See <see cref="IQTableWidgetSignals"></see> for signals emitted by QTableWidget
	[SmokeClass("QTableWidget")]
	public class QTableWidget : QTableView, IDisposable {
 		protected QTableWidget(Type dummy) : base((Type) null) {}
		interface IQTableWidgetProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTableWidget), this);
			_interceptor = (QTableWidget) realProxy.GetTransparentProxy();
		}
		private QTableWidget ProxyQTableWidget() {
			return (QTableWidget) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTableWidget() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTableWidgetProxy), null);
			_staticInterceptor = (IQTableWidgetProxy) realProxy.GetTransparentProxy();
		}
		private static IQTableWidgetProxy StaticQTableWidget() {
			return (IQTableWidgetProxy) _staticInterceptor;
		}

		public int RowCount {
			get {
				return Property("RowCount").Value<int>();
			}
			set {
				SetProperty("RowCount", QVariant.FromValue<int>(value));
			}
		}
		public int ColumnCount {
			get {
				return Property("ColumnCount").Value<int>();
			}
			set {
				SetProperty("ColumnCount", QVariant.FromValue<int>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QTableWidget(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQTableWidget(parent);
		}
		[SmokeMethod("QTableWidget(QWidget*)")]
		private void NewQTableWidget(QWidget parent) {
			ProxyQTableWidget().NewQTableWidget(parent);
		}
		public QTableWidget() : this((Type) null) {
			CreateProxy();
			NewQTableWidget();
		}
		[SmokeMethod("QTableWidget()")]
		private void NewQTableWidget() {
			ProxyQTableWidget().NewQTableWidget();
		}
		public QTableWidget(int rows, int columns, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQTableWidget(rows,columns,parent);
		}
		[SmokeMethod("QTableWidget(int, int, QWidget*)")]
		private void NewQTableWidget(int rows, int columns, QWidget parent) {
			ProxyQTableWidget().NewQTableWidget(rows,columns,parent);
		}
		public QTableWidget(int rows, int columns) : this((Type) null) {
			CreateProxy();
			NewQTableWidget(rows,columns);
		}
		[SmokeMethod("QTableWidget(int, int)")]
		private void NewQTableWidget(int rows, int columns) {
			ProxyQTableWidget().NewQTableWidget(rows,columns);
		}
		[SmokeMethod("row(const QTableWidgetItem*) const")]
		public int Row(QTableWidgetItem item) {
			return ProxyQTableWidget().Row(item);
		}
		[SmokeMethod("column(const QTableWidgetItem*) const")]
		public int Column(QTableWidgetItem item) {
			return ProxyQTableWidget().Column(item);
		}
		[SmokeMethod("item(int, int) const")]
		public QTableWidgetItem Item(int row, int column) {
			return ProxyQTableWidget().Item(row,column);
		}
		[SmokeMethod("setItem(int, int, QTableWidgetItem*)")]
		public void SetItem(int row, int column, QTableWidgetItem item) {
			ProxyQTableWidget().SetItem(row,column,item);
		}
		[SmokeMethod("takeItem(int, int)")]
		public QTableWidgetItem TakeItem(int row, int column) {
			return ProxyQTableWidget().TakeItem(row,column);
		}
		[SmokeMethod("verticalHeaderItem(int) const")]
		public QTableWidgetItem VerticalHeaderItem(int row) {
			return ProxyQTableWidget().VerticalHeaderItem(row);
		}
		[SmokeMethod("setVerticalHeaderItem(int, QTableWidgetItem*)")]
		public void SetVerticalHeaderItem(int row, QTableWidgetItem item) {
			ProxyQTableWidget().SetVerticalHeaderItem(row,item);
		}
		[SmokeMethod("takeVerticalHeaderItem(int)")]
		public QTableWidgetItem TakeVerticalHeaderItem(int row) {
			return ProxyQTableWidget().TakeVerticalHeaderItem(row);
		}
		[SmokeMethod("horizontalHeaderItem(int) const")]
		public QTableWidgetItem HorizontalHeaderItem(int column) {
			return ProxyQTableWidget().HorizontalHeaderItem(column);
		}
		[SmokeMethod("setHorizontalHeaderItem(int, QTableWidgetItem*)")]
		public void SetHorizontalHeaderItem(int column, QTableWidgetItem item) {
			ProxyQTableWidget().SetHorizontalHeaderItem(column,item);
		}
		[SmokeMethod("takeHorizontalHeaderItem(int)")]
		public QTableWidgetItem TakeHorizontalHeaderItem(int column) {
			return ProxyQTableWidget().TakeHorizontalHeaderItem(column);
		}
		[SmokeMethod("setVerticalHeaderLabels(const QStringList&)")]
		public void SetVerticalHeaderLabels(List<string> labels) {
			ProxyQTableWidget().SetVerticalHeaderLabels(labels);
		}
		[SmokeMethod("setHorizontalHeaderLabels(const QStringList&)")]
		public void SetHorizontalHeaderLabels(List<string> labels) {
			ProxyQTableWidget().SetHorizontalHeaderLabels(labels);
		}
		[SmokeMethod("currentRow() const")]
		public int CurrentRow() {
			return ProxyQTableWidget().CurrentRow();
		}
		[SmokeMethod("currentColumn() const")]
		public int CurrentColumn() {
			return ProxyQTableWidget().CurrentColumn();
		}
		[SmokeMethod("currentItem() const")]
		public QTableWidgetItem CurrentItem() {
			return ProxyQTableWidget().CurrentItem();
		}
		[SmokeMethod("setCurrentItem(QTableWidgetItem*)")]
		public void SetCurrentItem(QTableWidgetItem item) {
			ProxyQTableWidget().SetCurrentItem(item);
		}
		[SmokeMethod("setCurrentCell(int, int)")]
		public void SetCurrentCell(int row, int column) {
			ProxyQTableWidget().SetCurrentCell(row,column);
		}
		[SmokeMethod("sortItems(int, Qt::SortOrder)")]
		public void SortItems(int column, Qt.SortOrder order) {
			ProxyQTableWidget().SortItems(column,order);
		}
		[SmokeMethod("sortItems(int)")]
		public void SortItems(int column) {
			ProxyQTableWidget().SortItems(column);
		}
		[SmokeMethod("setSortingEnabled(bool)")]
		public new void SetSortingEnabled(bool enable) {
			ProxyQTableWidget().SetSortingEnabled(enable);
		}
		[SmokeMethod("isSortingEnabled() const")]
		public new bool IsSortingEnabled() {
			return ProxyQTableWidget().IsSortingEnabled();
		}
		[SmokeMethod("editItem(QTableWidgetItem*)")]
		public void EditItem(QTableWidgetItem item) {
			ProxyQTableWidget().EditItem(item);
		}
		[SmokeMethod("openPersistentEditor(QTableWidgetItem*)")]
		public new void OpenPersistentEditor(QTableWidgetItem item) {
			ProxyQTableWidget().OpenPersistentEditor(item);
		}
		[SmokeMethod("closePersistentEditor(QTableWidgetItem*)")]
		public new void ClosePersistentEditor(QTableWidgetItem item) {
			ProxyQTableWidget().ClosePersistentEditor(item);
		}
		[SmokeMethod("cellWidget(int, int) const")]
		public QWidget CellWidget(int row, int column) {
			return ProxyQTableWidget().CellWidget(row,column);
		}
		[SmokeMethod("setCellWidget(int, int, QWidget*)")]
		public void SetCellWidget(int row, int column, QWidget widget) {
			ProxyQTableWidget().SetCellWidget(row,column,widget);
		}
		[SmokeMethod("isItemSelected(const QTableWidgetItem*) const")]
		public bool IsItemSelected(QTableWidgetItem item) {
			return ProxyQTableWidget().IsItemSelected(item);
		}
		[SmokeMethod("setItemSelected(const QTableWidgetItem*, bool)")]
		public void SetItemSelected(QTableWidgetItem item, bool select) {
			ProxyQTableWidget().SetItemSelected(item,select);
		}
		[SmokeMethod("setRangeSelected(const QTableWidgetSelectionRange&, bool)")]
		public void SetRangeSelected(QTableWidgetSelectionRange range, bool select) {
			ProxyQTableWidget().SetRangeSelected(range,select);
		}
		[SmokeMethod("selectedRanges() const")]
		public List<QTableWidgetSelectionRange> SelectedRanges() {
			return ProxyQTableWidget().SelectedRanges();
		}
		[SmokeMethod("selectedItems()")]
		public List<QTableWidgetItem> SelectedItems() {
			return ProxyQTableWidget().SelectedItems();
		}
		[SmokeMethod("findItems(const QString&, Qt::MatchFlags) const")]
		public List<QTableWidgetItem> FindItems(string text, int flags) {
			return ProxyQTableWidget().FindItems(text,flags);
		}
		[SmokeMethod("visualRow(int) const")]
		public int VisualRow(int logicalRow) {
			return ProxyQTableWidget().VisualRow(logicalRow);
		}
		[SmokeMethod("visualColumn(int) const")]
		public int VisualColumn(int logicalColumn) {
			return ProxyQTableWidget().VisualColumn(logicalColumn);
		}
		[SmokeMethod("itemAt(const QPoint&) const")]
		public QTableWidgetItem ItemAt(QPoint p) {
			return ProxyQTableWidget().ItemAt(p);
		}
		[SmokeMethod("itemAt(int, int) const")]
		public QTableWidgetItem ItemAt(int x, int y) {
			return ProxyQTableWidget().ItemAt(x,y);
		}
		[SmokeMethod("visualItemRect(const QTableWidgetItem*) const")]
		public QRect VisualItemRect(QTableWidgetItem item) {
			return ProxyQTableWidget().VisualItemRect(item);
		}
		[SmokeMethod("itemPrototype() const")]
		public QTableWidgetItem ItemPrototype() {
			return ProxyQTableWidget().ItemPrototype();
		}
		[SmokeMethod("setItemPrototype(const QTableWidgetItem*)")]
		public void SetItemPrototype(QTableWidgetItem item) {
			ProxyQTableWidget().SetItemPrototype(item);
		}
		[SmokeMethod("scrollToItem(const QTableWidgetItem*, QAbstractItemView::ScrollHint)")]
		public void ScrollToItem(QTableWidgetItem item, QAbstractItemView.ScrollHint hint) {
			ProxyQTableWidget().ScrollToItem(item,hint);
		}
		[SmokeMethod("scrollToItem(const QTableWidgetItem*)")]
		public void ScrollToItem(QTableWidgetItem item) {
			ProxyQTableWidget().ScrollToItem(item);
		}
		[SmokeMethod("insertRow(int)")]
		public void InsertRow(int row) {
			ProxyQTableWidget().InsertRow(row);
		}
		[SmokeMethod("insertColumn(int)")]
		public void InsertColumn(int column) {
			ProxyQTableWidget().InsertColumn(column);
		}
		[SmokeMethod("removeRow(int)")]
		public void RemoveRow(int row) {
			ProxyQTableWidget().RemoveRow(row);
		}
		[SmokeMethod("removeColumn(int)")]
		public void RemoveColumn(int column) {
			ProxyQTableWidget().RemoveColumn(column);
		}
		[SmokeMethod("clear()")]
		public void Clear() {
			ProxyQTableWidget().Clear();
		}
		[SmokeMethod("clearContents()")]
		public void ClearContents() {
			ProxyQTableWidget().ClearContents();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQTableWidget().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQTableWidget().Tr(s);
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent e) {
			return ProxyQTableWidget().Event(e);
		}
		[SmokeMethod("mimeTypes() const")]
		protected virtual List<string> MimeTypes() {
			return ProxyQTableWidget().MimeTypes();
		}
		[SmokeMethod("mimeData(const QList<QTableWidgetItem*>) const")]
		protected virtual QMimeData MimeData(List<QTableWidgetItem> items) {
			return ProxyQTableWidget().MimeData(items);
		}
		[SmokeMethod("dropMimeData(int, int, const QMimeData*, Qt::DropAction)")]
		protected virtual bool DropMimeData(int row, int column, QMimeData data, Qt.DropAction action) {
			return ProxyQTableWidget().DropMimeData(row,column,data,action);
		}
		[SmokeMethod("supportedDropActions() const")]
		protected virtual int SupportedDropActions() {
			return ProxyQTableWidget().SupportedDropActions();
		}
		[SmokeMethod("items(const QMimeData*) const")]
		protected List<QTableWidgetItem> Items(QMimeData data) {
			return ProxyQTableWidget().Items(data);
		}
		[SmokeMethod("indexFromItem(QTableWidgetItem*) const")]
		protected QModelIndex IndexFromItem(QTableWidgetItem item) {
			return ProxyQTableWidget().IndexFromItem(item);
		}
		[SmokeMethod("itemFromIndex(const QModelIndex&) const")]
		protected QTableWidgetItem ItemFromIndex(QModelIndex index) {
			return ProxyQTableWidget().ItemFromIndex(index);
		}
		[SmokeMethod("dropEvent(QDropEvent*)")]
		protected new void DropEvent(QDropEvent arg1) {
			ProxyQTableWidget().DropEvent(arg1);
		}
		~QTableWidget() {
			DisposeQTableWidget();
		}
		public new void Dispose() {
			DisposeQTableWidget();
		}
		[SmokeMethod("~QTableWidget()")]
		private void DisposeQTableWidget() {
			ProxyQTableWidget().DisposeQTableWidget();
		}
		protected new IQTableWidgetSignals Emit() {
			return (IQTableWidgetSignals) Q_EMIT;
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
