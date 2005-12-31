//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QCheckListItem : QListViewItem, IDisposable {
 		protected QCheckListItem(Type dummy) : base((Type) null) {}
		interface IQCheckListItemProxy {
		}

		protected void CreateQCheckListItemProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QCheckListItem), this);
			_interceptor = (QCheckListItem) realProxy.GetTransparentProxy();
		}
		private QCheckListItem ProxyQCheckListItem() {
			return (QCheckListItem) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QCheckListItem() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQCheckListItemProxy), null);
			_staticInterceptor = (IQCheckListItemProxy) realProxy.GetTransparentProxy();
		}
		private static IQCheckListItemProxy StaticQCheckListItem() {
			return (IQCheckListItemProxy) _staticInterceptor;
		}

		enum E_Type {
			RadioButton = 0,
			CheckBox = 1,
			Controller = 2,
			RadioButtonController = Controller,
			CheckBoxController = 3,
		}
		enum ToggleState {
			Off = 0,
			NoChange = 1,
			On = 2,
		}
		public QCheckListItem(QCheckListItem parent, string text, int arg3) : this((Type) null) {
			CreateQCheckListItemProxy();
			NewQCheckListItem(parent,text,arg3);
		}
		[SmokeMethod("QCheckListItem(QCheckListItem*, const QString&, QCheckListItem::Type)")]
		private void NewQCheckListItem(QCheckListItem parent, string text, int arg3) {
			ProxyQCheckListItem().NewQCheckListItem(parent,text,arg3);
		}
		public QCheckListItem(QCheckListItem parent, string text) : this((Type) null) {
			CreateQCheckListItemProxy();
			NewQCheckListItem(parent,text);
		}
		[SmokeMethod("QCheckListItem(QCheckListItem*, const QString&)")]
		private void NewQCheckListItem(QCheckListItem parent, string text) {
			ProxyQCheckListItem().NewQCheckListItem(parent,text);
		}
		public QCheckListItem(QCheckListItem parent, QListViewItem after, string text, int arg4) : this((Type) null) {
			CreateQCheckListItemProxy();
			NewQCheckListItem(parent,after,text,arg4);
		}
		[SmokeMethod("QCheckListItem(QCheckListItem*, QListViewItem*, const QString&, QCheckListItem::Type)")]
		private void NewQCheckListItem(QCheckListItem parent, QListViewItem after, string text, int arg4) {
			ProxyQCheckListItem().NewQCheckListItem(parent,after,text,arg4);
		}
		public QCheckListItem(QCheckListItem parent, QListViewItem after, string text) : this((Type) null) {
			CreateQCheckListItemProxy();
			NewQCheckListItem(parent,after,text);
		}
		[SmokeMethod("QCheckListItem(QCheckListItem*, QListViewItem*, const QString&)")]
		private void NewQCheckListItem(QCheckListItem parent, QListViewItem after, string text) {
			ProxyQCheckListItem().NewQCheckListItem(parent,after,text);
		}
		public QCheckListItem(QListViewItem parent, string text, int arg3) : this((Type) null) {
			CreateQCheckListItemProxy();
			NewQCheckListItem(parent,text,arg3);
		}
		[SmokeMethod("QCheckListItem(QListViewItem*, const QString&, QCheckListItem::Type)")]
		private void NewQCheckListItem(QListViewItem parent, string text, int arg3) {
			ProxyQCheckListItem().NewQCheckListItem(parent,text,arg3);
		}
		public QCheckListItem(QListViewItem parent, string text) : this((Type) null) {
			CreateQCheckListItemProxy();
			NewQCheckListItem(parent,text);
		}
		[SmokeMethod("QCheckListItem(QListViewItem*, const QString&)")]
		private void NewQCheckListItem(QListViewItem parent, string text) {
			ProxyQCheckListItem().NewQCheckListItem(parent,text);
		}
		public QCheckListItem(QListViewItem parent, QListViewItem after, string text, int arg4) : this((Type) null) {
			CreateQCheckListItemProxy();
			NewQCheckListItem(parent,after,text,arg4);
		}
		[SmokeMethod("QCheckListItem(QListViewItem*, QListViewItem*, const QString&, QCheckListItem::Type)")]
		private void NewQCheckListItem(QListViewItem parent, QListViewItem after, string text, int arg4) {
			ProxyQCheckListItem().NewQCheckListItem(parent,after,text,arg4);
		}
		public QCheckListItem(QListViewItem parent, QListViewItem after, string text) : this((Type) null) {
			CreateQCheckListItemProxy();
			NewQCheckListItem(parent,after,text);
		}
		[SmokeMethod("QCheckListItem(QListViewItem*, QListViewItem*, const QString&)")]
		private void NewQCheckListItem(QListViewItem parent, QListViewItem after, string text) {
			ProxyQCheckListItem().NewQCheckListItem(parent,after,text);
		}
		public QCheckListItem(QListView parent, string text, int arg3) : this((Type) null) {
			CreateQCheckListItemProxy();
			NewQCheckListItem(parent,text,arg3);
		}
		[SmokeMethod("QCheckListItem(QListView*, const QString&, QCheckListItem::Type)")]
		private void NewQCheckListItem(QListView parent, string text, int arg3) {
			ProxyQCheckListItem().NewQCheckListItem(parent,text,arg3);
		}
		public QCheckListItem(QListView parent, string text) : this((Type) null) {
			CreateQCheckListItemProxy();
			NewQCheckListItem(parent,text);
		}
		[SmokeMethod("QCheckListItem(QListView*, const QString&)")]
		private void NewQCheckListItem(QListView parent, string text) {
			ProxyQCheckListItem().NewQCheckListItem(parent,text);
		}
		public QCheckListItem(QListView parent, QListViewItem after, string text, int arg4) : this((Type) null) {
			CreateQCheckListItemProxy();
			NewQCheckListItem(parent,after,text,arg4);
		}
		[SmokeMethod("QCheckListItem(QListView*, QListViewItem*, const QString&, QCheckListItem::Type)")]
		private void NewQCheckListItem(QListView parent, QListViewItem after, string text, int arg4) {
			ProxyQCheckListItem().NewQCheckListItem(parent,after,text,arg4);
		}
		public QCheckListItem(QListView parent, QListViewItem after, string text) : this((Type) null) {
			CreateQCheckListItemProxy();
			NewQCheckListItem(parent,after,text);
		}
		[SmokeMethod("QCheckListItem(QListView*, QListViewItem*, const QString&)")]
		private void NewQCheckListItem(QListView parent, QListViewItem after, string text) {
			ProxyQCheckListItem().NewQCheckListItem(parent,after,text);
		}
		public QCheckListItem(QListViewItem parent, string text, QPixmap arg3) : this((Type) null) {
			CreateQCheckListItemProxy();
			NewQCheckListItem(parent,text,arg3);
		}
		[SmokeMethod("QCheckListItem(QListViewItem*, const QString&, const QPixmap&)")]
		private void NewQCheckListItem(QListViewItem parent, string text, QPixmap arg3) {
			ProxyQCheckListItem().NewQCheckListItem(parent,text,arg3);
		}
		public QCheckListItem(QListView parent, string text, QPixmap arg3) : this((Type) null) {
			CreateQCheckListItemProxy();
			NewQCheckListItem(parent,text,arg3);
		}
		[SmokeMethod("QCheckListItem(QListView*, const QString&, const QPixmap&)")]
		private void NewQCheckListItem(QListView parent, string text, QPixmap arg3) {
			ProxyQCheckListItem().NewQCheckListItem(parent,text,arg3);
		}
		[SmokeMethod("paintCell(QPainter*, const QColorGroup&, int, int, int)")]
		public new void PaintCell(QPainter arg1, QColorGroup cg, int column, int width, int alignment) {
			ProxyQCheckListItem().PaintCell(arg1,cg,column,width,alignment);
		}
		[SmokeMethod("paintFocus(QPainter*, const QColorGroup&, const QRect&)")]
		public new virtual void PaintFocus(QPainter arg1, QColorGroup cg, QRect r) {
			ProxyQCheckListItem().PaintFocus(arg1,cg,r);
		}
		[SmokeMethod("width(const QFontMetrics&, const QListView*, int) const")]
		public new int Width(QFontMetrics arg1, QListView arg2, int column) {
			return ProxyQCheckListItem().Width(arg1,arg2,column);
		}
		[SmokeMethod("setup()")]
		public new void Setup() {
			ProxyQCheckListItem().Setup();
		}
		[SmokeMethod("setOn(bool)")]
		public virtual void SetOn(bool arg1) {
			ProxyQCheckListItem().SetOn(arg1);
		}
		[SmokeMethod("isOn() const")]
		public bool IsOn() {
			return ProxyQCheckListItem().IsOn();
		}
		[SmokeMethod("text() const")]
		public new string Text() {
			return ProxyQCheckListItem().Text();
		}
		[SmokeMethod("text(int) const")]
		public new string Text(int n) {
			return ProxyQCheckListItem().Text(n);
		}
		[SmokeMethod("setTristate(bool)")]
		public void SetTristate(bool arg1) {
			ProxyQCheckListItem().SetTristate(arg1);
		}
		[SmokeMethod("isTristate() const")]
		public bool IsTristate() {
			return ProxyQCheckListItem().IsTristate();
		}
		[SmokeMethod("state() const")]
		public int State() {
			return ProxyQCheckListItem().State();
		}
		[SmokeMethod("setState(QCheckListItem::ToggleState)")]
		public void SetState(int s) {
			ProxyQCheckListItem().SetState(s);
		}
		[SmokeMethod("rtti() const")]
		public new int Rtti() {
			return ProxyQCheckListItem().Rtti();
		}
		[SmokeMethod("activate()")]
		protected new void Activate() {
			ProxyQCheckListItem().Activate();
		}
		[SmokeMethod("turnOffChild()")]
		protected void TurnOffChild() {
			ProxyQCheckListItem().TurnOffChild();
		}
		[SmokeMethod("stateChange(bool)")]
		protected virtual void StateChange(bool arg1) {
			ProxyQCheckListItem().StateChange(arg1);
		}
		~QCheckListItem() {
			DisposeQCheckListItem();
		}
		public new void Dispose() {
			DisposeQCheckListItem();
		}
		private void DisposeQCheckListItem() {
			ProxyQCheckListItem().DisposeQCheckListItem();
		}
	}
}
