//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
using System.Collections;
	using System.Text;

	public class QListViewItem : Qt, IDisposable {
 		protected QListViewItem(Type dummy) : base((Type) null) {}
		interface IQListViewItemProxy {
		}

		protected void CreateQListViewItemProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QListViewItem), this);
			_interceptor = (QListViewItem) realProxy.GetTransparentProxy();
		}
		private QListViewItem ProxyQListViewItem() {
			return (QListViewItem) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QListViewItem() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQListViewItemProxy), null);
			_staticInterceptor = (IQListViewItemProxy) realProxy.GetTransparentProxy();
		}
		private static IQListViewItemProxy StaticQListViewItem() {
			return (IQListViewItemProxy) _staticInterceptor;
		}

		public QListViewItem(QListView parent) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent);
		}
		[SmokeMethod("QListViewItem(QListView*)")]
		private void NewQListViewItem(QListView parent) {
			ProxyQListViewItem().NewQListViewItem(parent);
		}
		public QListViewItem(QListViewItem parent) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent);
		}
		[SmokeMethod("QListViewItem(QListViewItem*)")]
		private void NewQListViewItem(QListViewItem parent) {
			ProxyQListViewItem().NewQListViewItem(parent);
		}
		public QListViewItem(QListView parent, QListViewItem after) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,after);
		}
		[SmokeMethod("QListViewItem(QListView*, QListViewItem*)")]
		private void NewQListViewItem(QListView parent, QListViewItem after) {
			ProxyQListViewItem().NewQListViewItem(parent,after);
		}
		public QListViewItem(QListViewItem parent, QListViewItem after) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,after);
		}
		[SmokeMethod("QListViewItem(QListViewItem*, QListViewItem*)")]
		private void NewQListViewItem(QListViewItem parent, QListViewItem after) {
			ProxyQListViewItem().NewQListViewItem(parent,after);
		}
		public QListViewItem(QListView parent, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,arg2,arg3,arg4,arg5,arg6,arg7,arg8,arg9);
		}
		[SmokeMethod("QListViewItem(QListView*, QString, QString, QString, QString, QString, QString, QString, QString)")]
		private void NewQListViewItem(QListView parent, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9) {
			ProxyQListViewItem().NewQListViewItem(parent,arg2,arg3,arg4,arg5,arg6,arg7,arg8,arg9);
		}
		public QListViewItem(QListView parent, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,arg2,arg3,arg4,arg5,arg6,arg7,arg8);
		}
		[SmokeMethod("QListViewItem(QListView*, QString, QString, QString, QString, QString, QString, QString)")]
		private void NewQListViewItem(QListView parent, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8) {
			ProxyQListViewItem().NewQListViewItem(parent,arg2,arg3,arg4,arg5,arg6,arg7,arg8);
		}
		public QListViewItem(QListView parent, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,arg2,arg3,arg4,arg5,arg6,arg7);
		}
		[SmokeMethod("QListViewItem(QListView*, QString, QString, QString, QString, QString, QString)")]
		private void NewQListViewItem(QListView parent, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7) {
			ProxyQListViewItem().NewQListViewItem(parent,arg2,arg3,arg4,arg5,arg6,arg7);
		}
		public QListViewItem(QListView parent, string arg2, string arg3, string arg4, string arg5, string arg6) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,arg2,arg3,arg4,arg5,arg6);
		}
		[SmokeMethod("QListViewItem(QListView*, QString, QString, QString, QString, QString)")]
		private void NewQListViewItem(QListView parent, string arg2, string arg3, string arg4, string arg5, string arg6) {
			ProxyQListViewItem().NewQListViewItem(parent,arg2,arg3,arg4,arg5,arg6);
		}
		public QListViewItem(QListView parent, string arg2, string arg3, string arg4, string arg5) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,arg2,arg3,arg4,arg5);
		}
		[SmokeMethod("QListViewItem(QListView*, QString, QString, QString, QString)")]
		private void NewQListViewItem(QListView parent, string arg2, string arg3, string arg4, string arg5) {
			ProxyQListViewItem().NewQListViewItem(parent,arg2,arg3,arg4,arg5);
		}
		public QListViewItem(QListView parent, string arg2, string arg3, string arg4) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,arg2,arg3,arg4);
		}
		[SmokeMethod("QListViewItem(QListView*, QString, QString, QString)")]
		private void NewQListViewItem(QListView parent, string arg2, string arg3, string arg4) {
			ProxyQListViewItem().NewQListViewItem(parent,arg2,arg3,arg4);
		}
		public QListViewItem(QListView parent, string arg2, string arg3) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,arg2,arg3);
		}
		[SmokeMethod("QListViewItem(QListView*, QString, QString)")]
		private void NewQListViewItem(QListView parent, string arg2, string arg3) {
			ProxyQListViewItem().NewQListViewItem(parent,arg2,arg3);
		}
		public QListViewItem(QListView parent, string arg2) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,arg2);
		}
		[SmokeMethod("QListViewItem(QListView*, QString)")]
		private void NewQListViewItem(QListView parent, string arg2) {
			ProxyQListViewItem().NewQListViewItem(parent,arg2);
		}
		public QListViewItem(QListViewItem parent, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,arg2,arg3,arg4,arg5,arg6,arg7,arg8,arg9);
		}
		[SmokeMethod("QListViewItem(QListViewItem*, QString, QString, QString, QString, QString, QString, QString, QString)")]
		private void NewQListViewItem(QListViewItem parent, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9) {
			ProxyQListViewItem().NewQListViewItem(parent,arg2,arg3,arg4,arg5,arg6,arg7,arg8,arg9);
		}
		public QListViewItem(QListViewItem parent, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,arg2,arg3,arg4,arg5,arg6,arg7,arg8);
		}
		[SmokeMethod("QListViewItem(QListViewItem*, QString, QString, QString, QString, QString, QString, QString)")]
		private void NewQListViewItem(QListViewItem parent, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8) {
			ProxyQListViewItem().NewQListViewItem(parent,arg2,arg3,arg4,arg5,arg6,arg7,arg8);
		}
		public QListViewItem(QListViewItem parent, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,arg2,arg3,arg4,arg5,arg6,arg7);
		}
		[SmokeMethod("QListViewItem(QListViewItem*, QString, QString, QString, QString, QString, QString)")]
		private void NewQListViewItem(QListViewItem parent, string arg2, string arg3, string arg4, string arg5, string arg6, string arg7) {
			ProxyQListViewItem().NewQListViewItem(parent,arg2,arg3,arg4,arg5,arg6,arg7);
		}
		public QListViewItem(QListViewItem parent, string arg2, string arg3, string arg4, string arg5, string arg6) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,arg2,arg3,arg4,arg5,arg6);
		}
		[SmokeMethod("QListViewItem(QListViewItem*, QString, QString, QString, QString, QString)")]
		private void NewQListViewItem(QListViewItem parent, string arg2, string arg3, string arg4, string arg5, string arg6) {
			ProxyQListViewItem().NewQListViewItem(parent,arg2,arg3,arg4,arg5,arg6);
		}
		public QListViewItem(QListViewItem parent, string arg2, string arg3, string arg4, string arg5) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,arg2,arg3,arg4,arg5);
		}
		[SmokeMethod("QListViewItem(QListViewItem*, QString, QString, QString, QString)")]
		private void NewQListViewItem(QListViewItem parent, string arg2, string arg3, string arg4, string arg5) {
			ProxyQListViewItem().NewQListViewItem(parent,arg2,arg3,arg4,arg5);
		}
		public QListViewItem(QListViewItem parent, string arg2, string arg3, string arg4) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,arg2,arg3,arg4);
		}
		[SmokeMethod("QListViewItem(QListViewItem*, QString, QString, QString)")]
		private void NewQListViewItem(QListViewItem parent, string arg2, string arg3, string arg4) {
			ProxyQListViewItem().NewQListViewItem(parent,arg2,arg3,arg4);
		}
		public QListViewItem(QListViewItem parent, string arg2, string arg3) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,arg2,arg3);
		}
		[SmokeMethod("QListViewItem(QListViewItem*, QString, QString)")]
		private void NewQListViewItem(QListViewItem parent, string arg2, string arg3) {
			ProxyQListViewItem().NewQListViewItem(parent,arg2,arg3);
		}
		public QListViewItem(QListViewItem parent, string arg2) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,arg2);
		}
		[SmokeMethod("QListViewItem(QListViewItem*, QString)")]
		private void NewQListViewItem(QListViewItem parent, string arg2) {
			ProxyQListViewItem().NewQListViewItem(parent,arg2);
		}
		public QListViewItem(QListView parent, QListViewItem after, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,after,arg3,arg4,arg5,arg6,arg7,arg8,arg9,arg10);
		}
		[SmokeMethod("QListViewItem(QListView*, QListViewItem*, QString, QString, QString, QString, QString, QString, QString, QString)")]
		private void NewQListViewItem(QListView parent, QListViewItem after, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10) {
			ProxyQListViewItem().NewQListViewItem(parent,after,arg3,arg4,arg5,arg6,arg7,arg8,arg9,arg10);
		}
		public QListViewItem(QListView parent, QListViewItem after, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,after,arg3,arg4,arg5,arg6,arg7,arg8,arg9);
		}
		[SmokeMethod("QListViewItem(QListView*, QListViewItem*, QString, QString, QString, QString, QString, QString, QString)")]
		private void NewQListViewItem(QListView parent, QListViewItem after, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9) {
			ProxyQListViewItem().NewQListViewItem(parent,after,arg3,arg4,arg5,arg6,arg7,arg8,arg9);
		}
		public QListViewItem(QListView parent, QListViewItem after, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,after,arg3,arg4,arg5,arg6,arg7,arg8);
		}
		[SmokeMethod("QListViewItem(QListView*, QListViewItem*, QString, QString, QString, QString, QString, QString)")]
		private void NewQListViewItem(QListView parent, QListViewItem after, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8) {
			ProxyQListViewItem().NewQListViewItem(parent,after,arg3,arg4,arg5,arg6,arg7,arg8);
		}
		public QListViewItem(QListView parent, QListViewItem after, string arg3, string arg4, string arg5, string arg6, string arg7) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,after,arg3,arg4,arg5,arg6,arg7);
		}
		[SmokeMethod("QListViewItem(QListView*, QListViewItem*, QString, QString, QString, QString, QString)")]
		private void NewQListViewItem(QListView parent, QListViewItem after, string arg3, string arg4, string arg5, string arg6, string arg7) {
			ProxyQListViewItem().NewQListViewItem(parent,after,arg3,arg4,arg5,arg6,arg7);
		}
		public QListViewItem(QListView parent, QListViewItem after, string arg3, string arg4, string arg5, string arg6) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,after,arg3,arg4,arg5,arg6);
		}
		[SmokeMethod("QListViewItem(QListView*, QListViewItem*, QString, QString, QString, QString)")]
		private void NewQListViewItem(QListView parent, QListViewItem after, string arg3, string arg4, string arg5, string arg6) {
			ProxyQListViewItem().NewQListViewItem(parent,after,arg3,arg4,arg5,arg6);
		}
		public QListViewItem(QListView parent, QListViewItem after, string arg3, string arg4, string arg5) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,after,arg3,arg4,arg5);
		}
		[SmokeMethod("QListViewItem(QListView*, QListViewItem*, QString, QString, QString)")]
		private void NewQListViewItem(QListView parent, QListViewItem after, string arg3, string arg4, string arg5) {
			ProxyQListViewItem().NewQListViewItem(parent,after,arg3,arg4,arg5);
		}
		public QListViewItem(QListView parent, QListViewItem after, string arg3, string arg4) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,after,arg3,arg4);
		}
		[SmokeMethod("QListViewItem(QListView*, QListViewItem*, QString, QString)")]
		private void NewQListViewItem(QListView parent, QListViewItem after, string arg3, string arg4) {
			ProxyQListViewItem().NewQListViewItem(parent,after,arg3,arg4);
		}
		public QListViewItem(QListView parent, QListViewItem after, string arg3) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,after,arg3);
		}
		[SmokeMethod("QListViewItem(QListView*, QListViewItem*, QString)")]
		private void NewQListViewItem(QListView parent, QListViewItem after, string arg3) {
			ProxyQListViewItem().NewQListViewItem(parent,after,arg3);
		}
		public QListViewItem(QListViewItem parent, QListViewItem after, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,after,arg3,arg4,arg5,arg6,arg7,arg8,arg9,arg10);
		}
		[SmokeMethod("QListViewItem(QListViewItem*, QListViewItem*, QString, QString, QString, QString, QString, QString, QString, QString)")]
		private void NewQListViewItem(QListViewItem parent, QListViewItem after, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9, string arg10) {
			ProxyQListViewItem().NewQListViewItem(parent,after,arg3,arg4,arg5,arg6,arg7,arg8,arg9,arg10);
		}
		public QListViewItem(QListViewItem parent, QListViewItem after, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,after,arg3,arg4,arg5,arg6,arg7,arg8,arg9);
		}
		[SmokeMethod("QListViewItem(QListViewItem*, QListViewItem*, QString, QString, QString, QString, QString, QString, QString)")]
		private void NewQListViewItem(QListViewItem parent, QListViewItem after, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8, string arg9) {
			ProxyQListViewItem().NewQListViewItem(parent,after,arg3,arg4,arg5,arg6,arg7,arg8,arg9);
		}
		public QListViewItem(QListViewItem parent, QListViewItem after, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,after,arg3,arg4,arg5,arg6,arg7,arg8);
		}
		[SmokeMethod("QListViewItem(QListViewItem*, QListViewItem*, QString, QString, QString, QString, QString, QString)")]
		private void NewQListViewItem(QListViewItem parent, QListViewItem after, string arg3, string arg4, string arg5, string arg6, string arg7, string arg8) {
			ProxyQListViewItem().NewQListViewItem(parent,after,arg3,arg4,arg5,arg6,arg7,arg8);
		}
		public QListViewItem(QListViewItem parent, QListViewItem after, string arg3, string arg4, string arg5, string arg6, string arg7) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,after,arg3,arg4,arg5,arg6,arg7);
		}
		[SmokeMethod("QListViewItem(QListViewItem*, QListViewItem*, QString, QString, QString, QString, QString)")]
		private void NewQListViewItem(QListViewItem parent, QListViewItem after, string arg3, string arg4, string arg5, string arg6, string arg7) {
			ProxyQListViewItem().NewQListViewItem(parent,after,arg3,arg4,arg5,arg6,arg7);
		}
		public QListViewItem(QListViewItem parent, QListViewItem after, string arg3, string arg4, string arg5, string arg6) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,after,arg3,arg4,arg5,arg6);
		}
		[SmokeMethod("QListViewItem(QListViewItem*, QListViewItem*, QString, QString, QString, QString)")]
		private void NewQListViewItem(QListViewItem parent, QListViewItem after, string arg3, string arg4, string arg5, string arg6) {
			ProxyQListViewItem().NewQListViewItem(parent,after,arg3,arg4,arg5,arg6);
		}
		public QListViewItem(QListViewItem parent, QListViewItem after, string arg3, string arg4, string arg5) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,after,arg3,arg4,arg5);
		}
		[SmokeMethod("QListViewItem(QListViewItem*, QListViewItem*, QString, QString, QString)")]
		private void NewQListViewItem(QListViewItem parent, QListViewItem after, string arg3, string arg4, string arg5) {
			ProxyQListViewItem().NewQListViewItem(parent,after,arg3,arg4,arg5);
		}
		public QListViewItem(QListViewItem parent, QListViewItem after, string arg3, string arg4) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,after,arg3,arg4);
		}
		[SmokeMethod("QListViewItem(QListViewItem*, QListViewItem*, QString, QString)")]
		private void NewQListViewItem(QListViewItem parent, QListViewItem after, string arg3, string arg4) {
			ProxyQListViewItem().NewQListViewItem(parent,after,arg3,arg4);
		}
		public QListViewItem(QListViewItem parent, QListViewItem after, string arg3) : this((Type) null) {
			CreateQListViewItemProxy();
			NewQListViewItem(parent,after,arg3);
		}
		[SmokeMethod("QListViewItem(QListViewItem*, QListViewItem*, QString)")]
		private void NewQListViewItem(QListViewItem parent, QListViewItem after, string arg3) {
			ProxyQListViewItem().NewQListViewItem(parent,after,arg3);
		}
		[SmokeMethod("insertItem(QListViewItem*)")]
		public virtual void InsertItem(QListViewItem arg1) {
			ProxyQListViewItem().InsertItem(arg1);
		}
		[SmokeMethod("takeItem(QListViewItem*)")]
		public virtual void TakeItem(QListViewItem arg1) {
			ProxyQListViewItem().TakeItem(arg1);
		}
		[SmokeMethod("removeItem(QListViewItem*)")]
		public virtual void RemoveItem(QListViewItem item) {
			ProxyQListViewItem().RemoveItem(item);
		}
		[SmokeMethod("height() const")]
		public int Height() {
			return ProxyQListViewItem().Height();
		}
		[SmokeMethod("invalidateHeight()")]
		public virtual void InvalidateHeight() {
			ProxyQListViewItem().InvalidateHeight();
		}
		[SmokeMethod("totalHeight() const")]
		public int TotalHeight() {
			return ProxyQListViewItem().TotalHeight();
		}
		[SmokeMethod("width(const QFontMetrics&, const QListView*, int) const")]
		public virtual int Width(QFontMetrics arg1, QListView arg2, int column) {
			return ProxyQListViewItem().Width(arg1,arg2,column);
		}
		[SmokeMethod("widthChanged(int) const")]
		public void WidthChanged(int column) {
			ProxyQListViewItem().WidthChanged(column);
		}
		[SmokeMethod("widthChanged() const")]
		public void WidthChanged() {
			ProxyQListViewItem().WidthChanged();
		}
		[SmokeMethod("depth() const")]
		public int Depth() {
			return ProxyQListViewItem().Depth();
		}
		[SmokeMethod("setText(int, const QString&)")]
		public virtual void SetText(int arg1, string arg2) {
			ProxyQListViewItem().SetText(arg1,arg2);
		}
		[SmokeMethod("text(int) const")]
		public virtual string Text(int arg1) {
			return ProxyQListViewItem().Text(arg1);
		}
		[SmokeMethod("setPixmap(int, const QPixmap&)")]
		public virtual void SetPixmap(int arg1, QPixmap arg2) {
			ProxyQListViewItem().SetPixmap(arg1,arg2);
		}
		[SmokeMethod("pixmap(int) const")]
		public virtual QPixmap Pixmap(int arg1) {
			return ProxyQListViewItem().Pixmap(arg1);
		}
		[SmokeMethod("key(int, bool) const")]
		public virtual string Key(int arg1, bool arg2) {
			return ProxyQListViewItem().Key(arg1,arg2);
		}
		[SmokeMethod("compare(QListViewItem*, int, bool) const")]
		public virtual int Compare(QListViewItem i, int col, bool arg3) {
			return ProxyQListViewItem().Compare(i,col,arg3);
		}
		[SmokeMethod("sortChildItems(int, bool)")]
		public virtual void SortChildItems(int arg1, bool arg2) {
			ProxyQListViewItem().SortChildItems(arg1,arg2);
		}
		[SmokeMethod("childCount() const")]
		public int ChildCount() {
			return ProxyQListViewItem().ChildCount();
		}
		[SmokeMethod("isOpen() const")]
		public bool IsOpen() {
			return ProxyQListViewItem().IsOpen();
		}
		[SmokeMethod("setOpen(bool)")]
		public virtual void SetOpen(bool arg1) {
			ProxyQListViewItem().SetOpen(arg1);
		}
		[SmokeMethod("setup()")]
		public virtual void Setup() {
			ProxyQListViewItem().Setup();
		}
		[SmokeMethod("setSelected(bool)")]
		public virtual void SetSelected(bool arg1) {
			ProxyQListViewItem().SetSelected(arg1);
		}
		[SmokeMethod("isSelected() const")]
		public bool IsSelected() {
			return ProxyQListViewItem().IsSelected();
		}
		[SmokeMethod("paintCell(QPainter*, const QColorGroup&, int, int, int)")]
		public virtual void PaintCell(QPainter arg1, QColorGroup cg, int column, int width, int alignment) {
			ProxyQListViewItem().PaintCell(arg1,cg,column,width,alignment);
		}
		[SmokeMethod("paintBranches(QPainter*, const QColorGroup&, int, int, int)")]
		public virtual void PaintBranches(QPainter p, QColorGroup cg, int w, int y, int h) {
			ProxyQListViewItem().PaintBranches(p,cg,w,y,h);
		}
		[SmokeMethod("paintFocus(QPainter*, const QColorGroup&, const QRect&)")]
		public virtual void PaintFocus(QPainter arg1, QColorGroup cg, QRect r) {
			ProxyQListViewItem().PaintFocus(arg1,cg,r);
		}
		[SmokeMethod("firstChild() const")]
		public QListViewItem FirstChild() {
			return ProxyQListViewItem().FirstChild();
		}
		[SmokeMethod("nextSibling() const")]
		public QListViewItem NextSibling() {
			return ProxyQListViewItem().NextSibling();
		}
		[SmokeMethod("parent() const")]
		public QListViewItem Parent() {
			return ProxyQListViewItem().Parent();
		}
		[SmokeMethod("itemAbove()")]
		public QListViewItem ItemAbove() {
			return ProxyQListViewItem().ItemAbove();
		}
		[SmokeMethod("itemBelow()")]
		public QListViewItem ItemBelow() {
			return ProxyQListViewItem().ItemBelow();
		}
		[SmokeMethod("itemPos() const")]
		public int ItemPos() {
			return ProxyQListViewItem().ItemPos();
		}
		[SmokeMethod("listView() const")]
		public QListView ListView() {
			return ProxyQListViewItem().ListView();
		}
		[SmokeMethod("setSelectable(bool)")]
		public virtual void SetSelectable(bool enable) {
			ProxyQListViewItem().SetSelectable(enable);
		}
		[SmokeMethod("isSelectable() const")]
		public bool IsSelectable() {
			return ProxyQListViewItem().IsSelectable();
		}
		[SmokeMethod("setExpandable(bool)")]
		public virtual void SetExpandable(bool arg1) {
			ProxyQListViewItem().SetExpandable(arg1);
		}
		[SmokeMethod("isExpandable() const")]
		public bool IsExpandable() {
			return ProxyQListViewItem().IsExpandable();
		}
		[SmokeMethod("repaint() const")]
		public void Repaint() {
			ProxyQListViewItem().Repaint();
		}
		[SmokeMethod("sort()")]
		public virtual void Sort() {
			ProxyQListViewItem().Sort();
		}
		[SmokeMethod("moveItem(QListViewItem*)")]
		public void MoveItem(QListViewItem after) {
			ProxyQListViewItem().MoveItem(after);
		}
		[SmokeMethod("setDragEnabled(bool)")]
		public virtual void SetDragEnabled(bool allow) {
			ProxyQListViewItem().SetDragEnabled(allow);
		}
		[SmokeMethod("setDropEnabled(bool)")]
		public virtual void SetDropEnabled(bool allow) {
			ProxyQListViewItem().SetDropEnabled(allow);
		}
		[SmokeMethod("dragEnabled() const")]
		public bool DragEnabled() {
			return ProxyQListViewItem().DragEnabled();
		}
		[SmokeMethod("dropEnabled() const")]
		public bool DropEnabled() {
			return ProxyQListViewItem().DropEnabled();
		}
		[SmokeMethod("acceptDrop(const QMimeSource*) const")]
		public virtual bool AcceptDrop(IQMimeSource mime) {
			return ProxyQListViewItem().AcceptDrop(mime);
		}
		[SmokeMethod("setVisible(bool)")]
		public void SetVisible(bool b) {
			ProxyQListViewItem().SetVisible(b);
		}
		[SmokeMethod("isVisible() const")]
		public bool IsVisible() {
			return ProxyQListViewItem().IsVisible();
		}
		[SmokeMethod("setRenameEnabled(int, bool)")]
		public virtual void SetRenameEnabled(int col, bool b) {
			ProxyQListViewItem().SetRenameEnabled(col,b);
		}
		[SmokeMethod("renameEnabled(int) const")]
		public bool RenameEnabled(int col) {
			return ProxyQListViewItem().RenameEnabled(col);
		}
		[SmokeMethod("startRename(int)")]
		public virtual void StartRename(int col) {
			ProxyQListViewItem().StartRename(col);
		}
		[SmokeMethod("setEnabled(bool)")]
		public virtual void SetEnabled(bool b) {
			ProxyQListViewItem().SetEnabled(b);
		}
		[SmokeMethod("isEnabled() const")]
		public bool IsEnabled() {
			return ProxyQListViewItem().IsEnabled();
		}
		[SmokeMethod("rtti() const")]
		public virtual int Rtti() {
			return ProxyQListViewItem().Rtti();
		}
		[SmokeMethod("setMultiLinesEnabled(bool)")]
		public virtual void SetMultiLinesEnabled(bool b) {
			ProxyQListViewItem().SetMultiLinesEnabled(b);
		}
		[SmokeMethod("multiLinesEnabled() const")]
		public bool MultiLinesEnabled() {
			return ProxyQListViewItem().MultiLinesEnabled();
		}
		[SmokeMethod("enforceSortOrder() const")]
		protected virtual void EnforceSortOrder() {
			ProxyQListViewItem().EnforceSortOrder();
		}
		[SmokeMethod("setHeight(int)")]
		protected virtual void SetHeight(int arg1) {
			ProxyQListViewItem().SetHeight(arg1);
		}
		[SmokeMethod("activate()")]
		protected virtual void Activate() {
			ProxyQListViewItem().Activate();
		}
		[SmokeMethod("activatedPos(QPoint&)")]
		protected bool ActivatedPos(QPoint arg1) {
			return ProxyQListViewItem().ActivatedPos(arg1);
		}
		[SmokeMethod("dropped(QDropEvent*)")]
		protected virtual void Dropped(QDropEvent e) {
			ProxyQListViewItem().Dropped(e);
		}
		[SmokeMethod("dragEntered()")]
		protected virtual void DragEntered() {
			ProxyQListViewItem().DragEntered();
		}
		[SmokeMethod("dragLeft()")]
		protected virtual void DragLeft() {
			ProxyQListViewItem().DragLeft();
		}
		[SmokeMethod("okRename(int)")]
		protected virtual void OkRename(int col) {
			ProxyQListViewItem().OkRename(col);
		}
		[SmokeMethod("cancelRename(int)")]
		protected virtual void CancelRename(int col) {
			ProxyQListViewItem().CancelRename(col);
		}
		[SmokeMethod("ignoreDoubleClick()")]
		protected void IgnoreDoubleClick() {
			ProxyQListViewItem().IgnoreDoubleClick();
		}
		~QListViewItem() {
			DisposeQListViewItem();
		}
		public void Dispose() {
			DisposeQListViewItem();
		}
		private void DisposeQListViewItem() {
			ProxyQListViewItem().DisposeQListViewItem();
		}

	}
}
