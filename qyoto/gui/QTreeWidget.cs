//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;
	using System.Collections.Generic;

	/// See <see cref="IQTreeWidgetSignals"></see> for signals emitted by QTreeWidget
	[SmokeClass("QTreeWidget")]
	public class QTreeWidget : QTreeView, IDisposable {
 		protected QTreeWidget(Type dummy) : base((Type) null) {}
		interface IQTreeWidgetProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTreeWidget), this);
			_interceptor = (QTreeWidget) realProxy.GetTransparentProxy();
		}
		private QTreeWidget ProxyQTreeWidget() {
			return (QTreeWidget) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTreeWidget() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTreeWidgetProxy), null);
			_staticInterceptor = (IQTreeWidgetProxy) realProxy.GetTransparentProxy();
		}
		private static IQTreeWidgetProxy StaticQTreeWidget() {
			return (IQTreeWidgetProxy) _staticInterceptor;
		}

		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QTreeWidget(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQTreeWidget(parent);
		}
		[SmokeMethod("QTreeWidget(QWidget*)")]
		private void NewQTreeWidget(QWidget parent) {
			ProxyQTreeWidget().NewQTreeWidget(parent);
		}
		public QTreeWidget() : this((Type) null) {
			CreateProxy();
			NewQTreeWidget();
		}
		[SmokeMethod("QTreeWidget()")]
		private void NewQTreeWidget() {
			ProxyQTreeWidget().NewQTreeWidget();
		}
		[SmokeMethod("columnCount() const")]
		public int ColumnCount() {
			return ProxyQTreeWidget().ColumnCount();
		}
		[SmokeMethod("setColumnCount(int)")]
		public void SetColumnCount(int columns) {
			ProxyQTreeWidget().SetColumnCount(columns);
		}
		[SmokeMethod("invisibleRootItem() const")]
		public QTreeWidgetItem InvisibleRootItem() {
			return ProxyQTreeWidget().InvisibleRootItem();
		}
		[SmokeMethod("topLevelItem(int) const")]
		public QTreeWidgetItem TopLevelItem(int index) {
			return ProxyQTreeWidget().TopLevelItem(index);
		}
		[SmokeMethod("topLevelItemCount() const")]
		public int TopLevelItemCount() {
			return ProxyQTreeWidget().TopLevelItemCount();
		}
		[SmokeMethod("insertTopLevelItem(int, QTreeWidgetItem*)")]
		public void InsertTopLevelItem(int index, QTreeWidgetItem item) {
			ProxyQTreeWidget().InsertTopLevelItem(index,item);
		}
		[SmokeMethod("addTopLevelItem(QTreeWidgetItem*)")]
		public void AddTopLevelItem(QTreeWidgetItem item) {
			ProxyQTreeWidget().AddTopLevelItem(item);
		}
		[SmokeMethod("takeTopLevelItem(int)")]
		public QTreeWidgetItem TakeTopLevelItem(int index) {
			return ProxyQTreeWidget().TakeTopLevelItem(index);
		}
		[SmokeMethod("indexOfTopLevelItem(QTreeWidgetItem*)")]
		public int IndexOfTopLevelItem(QTreeWidgetItem item) {
			return ProxyQTreeWidget().IndexOfTopLevelItem(item);
		}
		[SmokeMethod("insertTopLevelItems(int, const QList<QTreeWidgetItem*>&)")]
		public void InsertTopLevelItems(int index, List<QTreeWidgetItem> items) {
			ProxyQTreeWidget().InsertTopLevelItems(index,items);
		}
		[SmokeMethod("addTopLevelItems(const QList<QTreeWidgetItem*>&)")]
		public void AddTopLevelItems(List<QTreeWidgetItem> items) {
			ProxyQTreeWidget().AddTopLevelItems(items);
		}
		[SmokeMethod("headerItem() const")]
		public QTreeWidgetItem HeaderItem() {
			return ProxyQTreeWidget().HeaderItem();
		}
		[SmokeMethod("setHeaderItem(QTreeWidgetItem*)")]
		public void SetHeaderItem(QTreeWidgetItem item) {
			ProxyQTreeWidget().SetHeaderItem(item);
		}
		[SmokeMethod("setHeaderLabels(const QStringList&)")]
		public void SetHeaderLabels(List<string> labels) {
			ProxyQTreeWidget().SetHeaderLabels(labels);
		}
		[SmokeMethod("setHeaderLabel(const QString&)")]
		public void SetHeaderLabel(string label) {
			ProxyQTreeWidget().SetHeaderLabel(label);
		}
		[SmokeMethod("currentItem() const")]
		public QTreeWidgetItem CurrentItem() {
			return ProxyQTreeWidget().CurrentItem();
		}
		[SmokeMethod("currentColumn() const")]
		public int CurrentColumn() {
			return ProxyQTreeWidget().CurrentColumn();
		}
		[SmokeMethod("setCurrentItem(QTreeWidgetItem*)")]
		public void SetCurrentItem(QTreeWidgetItem item) {
			ProxyQTreeWidget().SetCurrentItem(item);
		}
		[SmokeMethod("setCurrentItem(QTreeWidgetItem*, int)")]
		public void SetCurrentItem(QTreeWidgetItem item, int column) {
			ProxyQTreeWidget().SetCurrentItem(item,column);
		}
		[SmokeMethod("itemAt(const QPoint&) const")]
		public QTreeWidgetItem ItemAt(QPoint p) {
			return ProxyQTreeWidget().ItemAt(p);
		}
		[SmokeMethod("itemAt(int, int) const")]
		public QTreeWidgetItem ItemAt(int x, int y) {
			return ProxyQTreeWidget().ItemAt(x,y);
		}
		[SmokeMethod("visualItemRect(const QTreeWidgetItem*) const")]
		public QRect VisualItemRect(QTreeWidgetItem item) {
			return ProxyQTreeWidget().VisualItemRect(item);
		}
		[SmokeMethod("sortColumn() const")]
		public int SortColumn() {
			return ProxyQTreeWidget().SortColumn();
		}
		[SmokeMethod("sortItems(int, Qt::SortOrder)")]
		public void SortItems(int column, Qt.SortOrder order) {
			ProxyQTreeWidget().SortItems(column,order);
		}
		[SmokeMethod("setSortingEnabled(bool)")]
		public new void SetSortingEnabled(bool enable) {
			ProxyQTreeWidget().SetSortingEnabled(enable);
		}
		[SmokeMethod("isSortingEnabled() const")]
		public new bool IsSortingEnabled() {
			return ProxyQTreeWidget().IsSortingEnabled();
		}
		[SmokeMethod("editItem(QTreeWidgetItem*, int)")]
		public void EditItem(QTreeWidgetItem item, int column) {
			ProxyQTreeWidget().EditItem(item,column);
		}
		[SmokeMethod("editItem(QTreeWidgetItem*)")]
		public void EditItem(QTreeWidgetItem item) {
			ProxyQTreeWidget().EditItem(item);
		}
		[SmokeMethod("openPersistentEditor(QTreeWidgetItem*, int)")]
		public new void OpenPersistentEditor(QTreeWidgetItem item, int column) {
			ProxyQTreeWidget().OpenPersistentEditor(item,column);
		}
		[SmokeMethod("openPersistentEditor(QTreeWidgetItem*)")]
		public new void OpenPersistentEditor(QTreeWidgetItem item) {
			ProxyQTreeWidget().OpenPersistentEditor(item);
		}
		[SmokeMethod("closePersistentEditor(QTreeWidgetItem*, int)")]
		public new void ClosePersistentEditor(QTreeWidgetItem item, int column) {
			ProxyQTreeWidget().ClosePersistentEditor(item,column);
		}
		[SmokeMethod("closePersistentEditor(QTreeWidgetItem*)")]
		public new void ClosePersistentEditor(QTreeWidgetItem item) {
			ProxyQTreeWidget().ClosePersistentEditor(item);
		}
		[SmokeMethod("itemWidget(QTreeWidgetItem*, int) const")]
		public QWidget ItemWidget(QTreeWidgetItem item, int column) {
			return ProxyQTreeWidget().ItemWidget(item,column);
		}
		[SmokeMethod("setItemWidget(QTreeWidgetItem*, int, QWidget*)")]
		public void SetItemWidget(QTreeWidgetItem item, int column, QWidget widget) {
			ProxyQTreeWidget().SetItemWidget(item,column,widget);
		}
		[SmokeMethod("isItemSelected(const QTreeWidgetItem*) const")]
		public bool IsItemSelected(QTreeWidgetItem item) {
			return ProxyQTreeWidget().IsItemSelected(item);
		}
		[SmokeMethod("setItemSelected(const QTreeWidgetItem*, bool)")]
		public void SetItemSelected(QTreeWidgetItem item, bool select) {
			ProxyQTreeWidget().SetItemSelected(item,select);
		}
		[SmokeMethod("selectedItems() const")]
		public List<QTreeWidgetItem> SelectedItems() {
			return ProxyQTreeWidget().SelectedItems();
		}
		[SmokeMethod("findItems(const QString&, Qt::MatchFlags, int) const")]
		public List<QTreeWidgetItem> FindItems(string text, int flags, int column) {
			return ProxyQTreeWidget().FindItems(text,flags,column);
		}
		[SmokeMethod("findItems(const QString&, Qt::MatchFlags) const")]
		public List<QTreeWidgetItem> FindItems(string text, int flags) {
			return ProxyQTreeWidget().FindItems(text,flags);
		}
		[SmokeMethod("isItemHidden(const QTreeWidgetItem*) const")]
		public bool IsItemHidden(QTreeWidgetItem item) {
			return ProxyQTreeWidget().IsItemHidden(item);
		}
		[SmokeMethod("setItemHidden(const QTreeWidgetItem*, bool)")]
		public void SetItemHidden(QTreeWidgetItem item, bool hide) {
			ProxyQTreeWidget().SetItemHidden(item,hide);
		}
		[SmokeMethod("isItemExpanded(const QTreeWidgetItem*) const")]
		public bool IsItemExpanded(QTreeWidgetItem item) {
			return ProxyQTreeWidget().IsItemExpanded(item);
		}
		[SmokeMethod("setItemExpanded(const QTreeWidgetItem*, bool)")]
		public void SetItemExpanded(QTreeWidgetItem item, bool expand) {
			ProxyQTreeWidget().SetItemExpanded(item,expand);
		}
		[SmokeMethod("scrollToItem(const QTreeWidgetItem*, QAbstractItemView::ScrollHint)")]
		public void ScrollToItem(QTreeWidgetItem item, QAbstractItemView.ScrollHint hint) {
			ProxyQTreeWidget().ScrollToItem(item,hint);
		}
		[SmokeMethod("scrollToItem(const QTreeWidgetItem*)")]
		public void ScrollToItem(QTreeWidgetItem item) {
			ProxyQTreeWidget().ScrollToItem(item);
		}
		[SmokeMethod("expandItem(const QTreeWidgetItem*)")]
		public void ExpandItem(QTreeWidgetItem item) {
			ProxyQTreeWidget().ExpandItem(item);
		}
		[SmokeMethod("collapseItem(const QTreeWidgetItem*)")]
		public void CollapseItem(QTreeWidgetItem item) {
			ProxyQTreeWidget().CollapseItem(item);
		}
		[SmokeMethod("clear()")]
		public void Clear() {
			ProxyQTreeWidget().Clear();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQTreeWidget().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQTreeWidget().Tr(s);
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent e) {
			return ProxyQTreeWidget().Event(e);
		}
		[SmokeMethod("mimeTypes() const")]
		protected virtual List<string> MimeTypes() {
			return ProxyQTreeWidget().MimeTypes();
		}
		[SmokeMethod("mimeData(const QList<QTreeWidgetItem*>) const")]
		protected virtual QMimeData MimeData(List<QTreeWidgetItem> items) {
			return ProxyQTreeWidget().MimeData(items);
		}
		[SmokeMethod("dropMimeData(QTreeWidgetItem*, int, const QMimeData*, Qt::DropAction)")]
		protected virtual bool DropMimeData(QTreeWidgetItem parent, int index, QMimeData data, Qt.DropAction action) {
			return ProxyQTreeWidget().DropMimeData(parent,index,data,action);
		}
		[SmokeMethod("supportedDropActions() const")]
		protected virtual int SupportedDropActions() {
			return ProxyQTreeWidget().SupportedDropActions();
		}
		[SmokeMethod("items(const QMimeData*) const")]
		protected List<QTreeWidgetItem> Items(QMimeData data) {
			return ProxyQTreeWidget().Items(data);
		}
		[SmokeMethod("indexFromItem(QTreeWidgetItem*, int) const")]
		protected QModelIndex IndexFromItem(QTreeWidgetItem item, int column) {
			return ProxyQTreeWidget().IndexFromItem(item,column);
		}
		[SmokeMethod("indexFromItem(QTreeWidgetItem*) const")]
		protected QModelIndex IndexFromItem(QTreeWidgetItem item) {
			return ProxyQTreeWidget().IndexFromItem(item);
		}
		[SmokeMethod("itemFromIndex(const QModelIndex&) const")]
		protected QTreeWidgetItem ItemFromIndex(QModelIndex index) {
			return ProxyQTreeWidget().ItemFromIndex(index);
		}
		[SmokeMethod("dropEvent(QDropEvent*)")]
		protected new void DropEvent(QDropEvent arg1) {
			ProxyQTreeWidget().DropEvent(arg1);
		}
		~QTreeWidget() {
			DisposeQTreeWidget();
		}
		public new void Dispose() {
			DisposeQTreeWidget();
		}
		[SmokeMethod("~QTreeWidget()")]
		private void DisposeQTreeWidget() {
			ProxyQTreeWidget().DisposeQTreeWidget();
		}
		protected new IQTreeWidgetSignals Emit() {
			return (IQTreeWidgetSignals) Q_EMIT;
		}
	}

	public interface IQTreeWidgetSignals : IQTreeViewSignals {
		[Q_SIGNAL("void itemPressed(QTreeWidgetItem*, int)")]
		void ItemPressed(QTreeWidgetItem item, int column);
		[Q_SIGNAL("void itemClicked(QTreeWidgetItem*, int)")]
		void ItemClicked(QTreeWidgetItem item, int column);
		[Q_SIGNAL("void itemDoubleClicked(QTreeWidgetItem*, int)")]
		void ItemDoubleClicked(QTreeWidgetItem item, int column);
		[Q_SIGNAL("void itemActivated(QTreeWidgetItem*, int)")]
		void ItemActivated(QTreeWidgetItem item, int column);
		[Q_SIGNAL("void itemEntered(QTreeWidgetItem*, int)")]
		void ItemEntered(QTreeWidgetItem item, int column);
		[Q_SIGNAL("void itemChanged(QTreeWidgetItem*, int)")]
		void ItemChanged(QTreeWidgetItem item, int column);
		[Q_SIGNAL("void itemExpanded(QTreeWidgetItem*)")]
		void ItemExpanded(QTreeWidgetItem item);
		[Q_SIGNAL("void itemCollapsed(QTreeWidgetItem*)")]
		void ItemCollapsed(QTreeWidgetItem item);
		[Q_SIGNAL("void currentItemChanged(QTreeWidgetItem*, QTreeWidgetItem*)")]
		void CurrentItemChanged(QTreeWidgetItem current, QTreeWidgetItem previous);
		[Q_SIGNAL("void itemSelectionChanged()")]
		void ItemSelectionChanged();
	}
}
