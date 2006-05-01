//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QTreeWidgetItem")]
	public class QTreeWidgetItem : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QTreeWidgetItem(Type dummy) {}
		interface IQTreeWidgetItemProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTreeWidgetItem), this);
			_interceptor = (QTreeWidgetItem) realProxy.GetTransparentProxy();
		}
		private QTreeWidgetItem ProxyQTreeWidgetItem() {
			return (QTreeWidgetItem) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTreeWidgetItem() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTreeWidgetItemProxy), null);
			_staticInterceptor = (IQTreeWidgetItemProxy) realProxy.GetTransparentProxy();
		}
		private static IQTreeWidgetItemProxy StaticQTreeWidgetItem() {
			return (IQTreeWidgetItemProxy) _staticInterceptor;
		}

		public const int Type = 0;
		public const int UserType = 1000;

		public QTreeWidgetItem(int type) : this((Type) null) {
			CreateProxy();
			NewQTreeWidgetItem(type);
		}
		[SmokeMethod("QTreeWidgetItem(int)")]
		private void NewQTreeWidgetItem(int type) {
			ProxyQTreeWidgetItem().NewQTreeWidgetItem(type);
		}
		public QTreeWidgetItem() : this((Type) null) {
			CreateProxy();
			NewQTreeWidgetItem();
		}
		[SmokeMethod("QTreeWidgetItem()")]
		private void NewQTreeWidgetItem() {
			ProxyQTreeWidgetItem().NewQTreeWidgetItem();
		}
		public QTreeWidgetItem(string[] strings, int type) : this((Type) null) {
			CreateProxy();
			NewQTreeWidgetItem(strings,type);
		}
		[SmokeMethod("QTreeWidgetItem(const QStringList&, int)")]
		private void NewQTreeWidgetItem(string[] strings, int type) {
			ProxyQTreeWidgetItem().NewQTreeWidgetItem(strings,type);
		}
		public QTreeWidgetItem(string[] strings) : this((Type) null) {
			CreateProxy();
			NewQTreeWidgetItem(strings);
		}
		[SmokeMethod("QTreeWidgetItem(const QStringList&)")]
		private void NewQTreeWidgetItem(string[] strings) {
			ProxyQTreeWidgetItem().NewQTreeWidgetItem(strings);
		}
		public QTreeWidgetItem(QTreeWidget view, int type) : this((Type) null) {
			CreateProxy();
			NewQTreeWidgetItem(view,type);
		}
		[SmokeMethod("QTreeWidgetItem(QTreeWidget*, int)")]
		private void NewQTreeWidgetItem(QTreeWidget view, int type) {
			ProxyQTreeWidgetItem().NewQTreeWidgetItem(view,type);
		}
		public QTreeWidgetItem(QTreeWidget view) : this((Type) null) {
			CreateProxy();
			NewQTreeWidgetItem(view);
		}
		[SmokeMethod("QTreeWidgetItem(QTreeWidget*)")]
		private void NewQTreeWidgetItem(QTreeWidget view) {
			ProxyQTreeWidgetItem().NewQTreeWidgetItem(view);
		}
		public QTreeWidgetItem(QTreeWidget view, string[] strings, int type) : this((Type) null) {
			CreateProxy();
			NewQTreeWidgetItem(view,strings,type);
		}
		[SmokeMethod("QTreeWidgetItem(QTreeWidget*, const QStringList&, int)")]
		private void NewQTreeWidgetItem(QTreeWidget view, string[] strings, int type) {
			ProxyQTreeWidgetItem().NewQTreeWidgetItem(view,strings,type);
		}
		public QTreeWidgetItem(QTreeWidget view, string[] strings) : this((Type) null) {
			CreateProxy();
			NewQTreeWidgetItem(view,strings);
		}
		[SmokeMethod("QTreeWidgetItem(QTreeWidget*, const QStringList&)")]
		private void NewQTreeWidgetItem(QTreeWidget view, string[] strings) {
			ProxyQTreeWidgetItem().NewQTreeWidgetItem(view,strings);
		}
		public QTreeWidgetItem(QTreeWidget view, QTreeWidgetItem after, int type) : this((Type) null) {
			CreateProxy();
			NewQTreeWidgetItem(view,after,type);
		}
		[SmokeMethod("QTreeWidgetItem(QTreeWidget*, QTreeWidgetItem*, int)")]
		private void NewQTreeWidgetItem(QTreeWidget view, QTreeWidgetItem after, int type) {
			ProxyQTreeWidgetItem().NewQTreeWidgetItem(view,after,type);
		}
		public QTreeWidgetItem(QTreeWidget view, QTreeWidgetItem after) : this((Type) null) {
			CreateProxy();
			NewQTreeWidgetItem(view,after);
		}
		[SmokeMethod("QTreeWidgetItem(QTreeWidget*, QTreeWidgetItem*)")]
		private void NewQTreeWidgetItem(QTreeWidget view, QTreeWidgetItem after) {
			ProxyQTreeWidgetItem().NewQTreeWidgetItem(view,after);
		}
		public QTreeWidgetItem(QTreeWidgetItem parent, int type) : this((Type) null) {
			CreateProxy();
			NewQTreeWidgetItem(parent,type);
		}
		[SmokeMethod("QTreeWidgetItem(QTreeWidgetItem*, int)")]
		private void NewQTreeWidgetItem(QTreeWidgetItem parent, int type) {
			ProxyQTreeWidgetItem().NewQTreeWidgetItem(parent,type);
		}
		public QTreeWidgetItem(QTreeWidgetItem parent) : this((Type) null) {
			CreateProxy();
			NewQTreeWidgetItem(parent);
		}
		[SmokeMethod("QTreeWidgetItem(QTreeWidgetItem*)")]
		private void NewQTreeWidgetItem(QTreeWidgetItem parent) {
			ProxyQTreeWidgetItem().NewQTreeWidgetItem(parent);
		}
		public QTreeWidgetItem(QTreeWidgetItem parent, string[] strings, int type) : this((Type) null) {
			CreateProxy();
			NewQTreeWidgetItem(parent,strings,type);
		}
		[SmokeMethod("QTreeWidgetItem(QTreeWidgetItem*, const QStringList&, int)")]
		private void NewQTreeWidgetItem(QTreeWidgetItem parent, string[] strings, int type) {
			ProxyQTreeWidgetItem().NewQTreeWidgetItem(parent,strings,type);
		}
		public QTreeWidgetItem(QTreeWidgetItem parent, string[] strings) : this((Type) null) {
			CreateProxy();
			NewQTreeWidgetItem(parent,strings);
		}
		[SmokeMethod("QTreeWidgetItem(QTreeWidgetItem*, const QStringList&)")]
		private void NewQTreeWidgetItem(QTreeWidgetItem parent, string[] strings) {
			ProxyQTreeWidgetItem().NewQTreeWidgetItem(parent,strings);
		}
		public QTreeWidgetItem(QTreeWidgetItem parent, QTreeWidgetItem after, int type) : this((Type) null) {
			CreateProxy();
			NewQTreeWidgetItem(parent,after,type);
		}
		[SmokeMethod("QTreeWidgetItem(QTreeWidgetItem*, QTreeWidgetItem*, int)")]
		private void NewQTreeWidgetItem(QTreeWidgetItem parent, QTreeWidgetItem after, int type) {
			ProxyQTreeWidgetItem().NewQTreeWidgetItem(parent,after,type);
		}
		public QTreeWidgetItem(QTreeWidgetItem parent, QTreeWidgetItem after) : this((Type) null) {
			CreateProxy();
			NewQTreeWidgetItem(parent,after);
		}
		[SmokeMethod("QTreeWidgetItem(QTreeWidgetItem*, QTreeWidgetItem*)")]
		private void NewQTreeWidgetItem(QTreeWidgetItem parent, QTreeWidgetItem after) {
			ProxyQTreeWidgetItem().NewQTreeWidgetItem(parent,after);
		}
		[SmokeMethod("clone() const")]
		public virtual QTreeWidgetItem Clone() {
			return ProxyQTreeWidgetItem().Clone();
		}
		[SmokeMethod("treeWidget() const")]
		public QTreeWidget TreeWidget() {
			return ProxyQTreeWidgetItem().TreeWidget();
		}
		[SmokeMethod("flags() const")]
		public int Flags() {
			return ProxyQTreeWidgetItem().Flags();
		}
		[SmokeMethod("setFlags(Qt::ItemFlags)")]
		public void SetFlags(int flags) {
			ProxyQTreeWidgetItem().SetFlags(flags);
		}
		[SmokeMethod("text(int) const")]
		public string Text(int column) {
			return ProxyQTreeWidgetItem().Text(column);
		}
		[SmokeMethod("setText(int, const QString&)")]
		public void SetText(int column, string text) {
			ProxyQTreeWidgetItem().SetText(column,text);
		}
		[SmokeMethod("icon(int) const")]
		public QIcon Icon(int column) {
			return ProxyQTreeWidgetItem().Icon(column);
		}
		[SmokeMethod("setIcon(int, const QIcon&)")]
		public void SetIcon(int column, QIcon icon) {
			ProxyQTreeWidgetItem().SetIcon(column,icon);
		}
		[SmokeMethod("statusTip(int) const")]
		public string StatusTip(int column) {
			return ProxyQTreeWidgetItem().StatusTip(column);
		}
		[SmokeMethod("setStatusTip(int, const QString&)")]
		public void SetStatusTip(int column, string statusTip) {
			ProxyQTreeWidgetItem().SetStatusTip(column,statusTip);
		}
		[SmokeMethod("toolTip(int) const")]
		public string ToolTip(int column) {
			return ProxyQTreeWidgetItem().ToolTip(column);
		}
		[SmokeMethod("setToolTip(int, const QString&)")]
		public void SetToolTip(int column, string toolTip) {
			ProxyQTreeWidgetItem().SetToolTip(column,toolTip);
		}
		[SmokeMethod("whatsThis(int) const")]
		public string WhatsThis(int column) {
			return ProxyQTreeWidgetItem().WhatsThis(column);
		}
		[SmokeMethod("setWhatsThis(int, const QString&)")]
		public void SetWhatsThis(int column, string whatsThis) {
			ProxyQTreeWidgetItem().SetWhatsThis(column,whatsThis);
		}
		[SmokeMethod("font(int) const")]
		public QFont Font(int column) {
			return ProxyQTreeWidgetItem().Font(column);
		}
		[SmokeMethod("setFont(int, const QFont&)")]
		public void SetFont(int column, QFont font) {
			ProxyQTreeWidgetItem().SetFont(column,font);
		}
		[SmokeMethod("textAlignment(int) const")]
		public int TextAlignment(int column) {
			return ProxyQTreeWidgetItem().TextAlignment(column);
		}
		[SmokeMethod("setTextAlignment(int, int)")]
		public void SetTextAlignment(int column, int alignment) {
			ProxyQTreeWidgetItem().SetTextAlignment(column,alignment);
		}
		[SmokeMethod("backgroundColor(int) const")]
		public QColor BackgroundColor(int column) {
			return ProxyQTreeWidgetItem().BackgroundColor(column);
		}
		[SmokeMethod("setBackgroundColor(int, const QColor&)")]
		public void SetBackgroundColor(int column, QColor color) {
			ProxyQTreeWidgetItem().SetBackgroundColor(column,color);
		}
		[SmokeMethod("textColor(int) const")]
		public QColor TextColor(int column) {
			return ProxyQTreeWidgetItem().TextColor(column);
		}
		[SmokeMethod("setTextColor(int, const QColor&)")]
		public void SetTextColor(int column, QColor color) {
			ProxyQTreeWidgetItem().SetTextColor(column,color);
		}
		[SmokeMethod("checkState(int) const")]
		public Qt.CheckState CheckState(int column) {
			return ProxyQTreeWidgetItem().CheckState(column);
		}
		[SmokeMethod("setCheckState(int, Qt::CheckState)")]
		public void SetCheckState(int column, Qt.CheckState state) {
			ProxyQTreeWidgetItem().SetCheckState(column,state);
		}
		[SmokeMethod("sizeHint(int) const")]
		public QSize SizeHint(int column) {
			return ProxyQTreeWidgetItem().SizeHint(column);
		}
		[SmokeMethod("setSizeHint(int, const QSize&)")]
		public void SetSizeHint(int column, QSize size) {
			ProxyQTreeWidgetItem().SetSizeHint(column,size);
		}
		[SmokeMethod("data(int, int) const")]
		public virtual QVariant Data(int column, int role) {
			return ProxyQTreeWidgetItem().Data(column,role);
		}
		[SmokeMethod("setData(int, int, const QVariant&)")]
		public virtual void SetData(int column, int role, QVariant value) {
			ProxyQTreeWidgetItem().SetData(column,role,value);
		}
		[SmokeMethod("read(QDataStream&)")]
		public virtual void Read(QDataStream arg1) {
			ProxyQTreeWidgetItem().Read(arg1);
		}
		[SmokeMethod("write(QDataStream&) const")]
		public virtual void Write(QDataStream arg1) {
			ProxyQTreeWidgetItem().Write(arg1);
		}
		[SmokeMethod("parent() const")]
		public QTreeWidgetItem Parent() {
			return ProxyQTreeWidgetItem().Parent();
		}
		[SmokeMethod("child(int) const")]
		public QTreeWidgetItem Child(int index) {
			return ProxyQTreeWidgetItem().Child(index);
		}
		[SmokeMethod("childCount() const")]
		public int ChildCount() {
			return ProxyQTreeWidgetItem().ChildCount();
		}
		[SmokeMethod("columnCount() const")]
		public int ColumnCount() {
			return ProxyQTreeWidgetItem().ColumnCount();
		}
		[SmokeMethod("indexOfChild(QTreeWidgetItem*) const")]
		public int IndexOfChild(QTreeWidgetItem child) {
			return ProxyQTreeWidgetItem().IndexOfChild(child);
		}
		[SmokeMethod("addChild(QTreeWidgetItem*)")]
		public void AddChild(QTreeWidgetItem child) {
			ProxyQTreeWidgetItem().AddChild(child);
		}
		[SmokeMethod("insertChild(int, QTreeWidgetItem*)")]
		public void InsertChild(int index, QTreeWidgetItem child) {
			ProxyQTreeWidgetItem().InsertChild(index,child);
		}
		[SmokeMethod("takeChild(int)")]
		public QTreeWidgetItem TakeChild(int index) {
			return ProxyQTreeWidgetItem().TakeChild(index);
		}
		// void addChildren(const QList<QTreeWidgetItem*>& arg1); >>>> NOT CONVERTED
		// void insertChildren(int arg1,const QList<QTreeWidgetItem*>& arg2); >>>> NOT CONVERTED
		// QList<QTreeWidgetItem*> takeChildren(); >>>> NOT CONVERTED
		[SmokeMethod("type() const")]
		public int type() {
			return ProxyQTreeWidgetItem().type();
		}
		~QTreeWidgetItem() {
			DisposeQTreeWidgetItem();
		}
		public void Dispose() {
			DisposeQTreeWidgetItem();
		}
		private void DisposeQTreeWidgetItem() {
			ProxyQTreeWidgetItem().DisposeQTreeWidgetItem();
		}
	}
}
