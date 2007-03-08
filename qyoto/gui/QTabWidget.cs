//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	/// See <see cref="IQTabWidgetSignals"></see> for signals emitted by QTabWidget
	[SmokeClass("QTabWidget")]
	public class QTabWidget : QWidget, IDisposable {
 		protected QTabWidget(Type dummy) : base((Type) null) {}
		[SmokeClass("QTabWidget")]
		interface IQTabWidgetProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTabWidget), this);
			_interceptor = (QTabWidget) realProxy.GetTransparentProxy();
		}
		private QTabWidget ProxyQTabWidget() {
			return (QTabWidget) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTabWidget() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTabWidgetProxy), null);
			_staticInterceptor = (IQTabWidgetProxy) realProxy.GetTransparentProxy();
		}
		private static IQTabWidgetProxy StaticQTabWidget() {
			return (IQTabWidgetProxy) _staticInterceptor;
		}
		public enum TabPosition {
			North = 0,
			South = 1,
			West = 2,
			East = 3,
		}
		public enum TabShape {
			Rounded = 0,
			Triangular = 1,
		}
		[Q_PROPERTY("QTabWidget::TabPosition", "tabPosition")]
		public QTabWidget.TabPosition tabPosition {
			get { return Property("tabPosition").Value<QTabWidget.TabPosition>(); }
			set { SetProperty("tabPosition", QVariant.FromValue<QTabWidget.TabPosition>(value)); }
		}
		[Q_PROPERTY("QTabWidget::TabShape", "tabShape")]
		public QTabWidget.TabShape tabShape {
			get { return Property("tabShape").Value<QTabWidget.TabShape>(); }
			set { SetProperty("tabShape", QVariant.FromValue<QTabWidget.TabShape>(value)); }
		}
		[Q_PROPERTY("int", "currentIndex")]
		public int CurrentIndex {
			get { return Property("currentIndex").Value<int>(); }
			set { SetProperty("currentIndex", QVariant.FromValue<int>(value)); }
		}
		[Q_PROPERTY("int", "count")]
		public int Count {
			get { return Property("count").Value<int>(); }
		}
		[Q_PROPERTY("QSize", "iconSize")]
		public QSize IconSize {
			get { return Property("iconSize").Value<QSize>(); }
			set { SetProperty("iconSize", QVariant.FromValue<QSize>(value)); }
		}
		[Q_PROPERTY("Qt::TextElideMode", "elideMode")]
		public Qt.TextElideMode ElideMode {
			get { return Property("elideMode").Value<Qt.TextElideMode>(); }
			set { SetProperty("elideMode", QVariant.FromValue<Qt.TextElideMode>(value)); }
		}
		[Q_PROPERTY("bool", "usesScrollButtons")]
		public bool UsesScrollButtons {
			get { return Property("usesScrollButtons").Value<bool>(); }
			set { SetProperty("usesScrollButtons", QVariant.FromValue<bool>(value)); }
		}
		public QTabWidget(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQTabWidget(parent);
		}
		[SmokeMethod("QTabWidget", "(QWidget*)", "#")]
		private void NewQTabWidget(QWidget parent) {
			ProxyQTabWidget().NewQTabWidget(parent);
		}
		public QTabWidget() : this((Type) null) {
			CreateProxy();
			NewQTabWidget();
		}
		[SmokeMethod("QTabWidget", "()", "")]
		private void NewQTabWidget() {
			ProxyQTabWidget().NewQTabWidget();
		}
		[SmokeMethod("addTab", "(QWidget*, const QString&)", "#$")]
		public int AddTab(QWidget widget, string arg2) {
			return ProxyQTabWidget().AddTab(widget,arg2);
		}
		[SmokeMethod("addTab", "(QWidget*, const QIcon&, const QString&)", "##$")]
		public int AddTab(QWidget widget, QIcon icon, string label) {
			return ProxyQTabWidget().AddTab(widget,icon,label);
		}
		[SmokeMethod("insertTab", "(int, QWidget*, const QString&)", "$#$")]
		public int InsertTab(int index, QWidget widget, string arg3) {
			return ProxyQTabWidget().InsertTab(index,widget,arg3);
		}
		[SmokeMethod("insertTab", "(int, QWidget*, const QIcon&, const QString&)", "$##$")]
		public int InsertTab(int index, QWidget widget, QIcon icon, string label) {
			return ProxyQTabWidget().InsertTab(index,widget,icon,label);
		}
		[SmokeMethod("removeTab", "(int)", "$")]
		public void RemoveTab(int index) {
			ProxyQTabWidget().RemoveTab(index);
		}
		[SmokeMethod("isTabEnabled", "(int) const", "$")]
		public bool IsTabEnabled(int index) {
			return ProxyQTabWidget().IsTabEnabled(index);
		}
		[SmokeMethod("setTabEnabled", "(int, bool)", "$$")]
		public void SetTabEnabled(int index, bool arg2) {
			ProxyQTabWidget().SetTabEnabled(index,arg2);
		}
		[SmokeMethod("tabText", "(int) const", "$")]
		public string TabText(int index) {
			return ProxyQTabWidget().TabText(index);
		}
		[SmokeMethod("setTabText", "(int, const QString&)", "$$")]
		public void SetTabText(int index, string arg2) {
			ProxyQTabWidget().SetTabText(index,arg2);
		}
		[SmokeMethod("tabIcon", "(int) const", "$")]
		public QIcon TabIcon(int index) {
			return ProxyQTabWidget().TabIcon(index);
		}
		[SmokeMethod("setTabIcon", "(int, const QIcon&)", "$#")]
		public void SetTabIcon(int index, QIcon icon) {
			ProxyQTabWidget().SetTabIcon(index,icon);
		}
		[SmokeMethod("setTabToolTip", "(int, const QString&)", "$$")]
		public void SetTabToolTip(int index, string tip) {
			ProxyQTabWidget().SetTabToolTip(index,tip);
		}
		[SmokeMethod("tabToolTip", "(int) const", "$")]
		public string TabToolTip(int index) {
			return ProxyQTabWidget().TabToolTip(index);
		}
		[SmokeMethod("setTabWhatsThis", "(int, const QString&)", "$$")]
		public void SetTabWhatsThis(int index, string text) {
			ProxyQTabWidget().SetTabWhatsThis(index,text);
		}
		[SmokeMethod("tabWhatsThis", "(int) const", "$")]
		public string TabWhatsThis(int index) {
			return ProxyQTabWidget().TabWhatsThis(index);
		}
		[SmokeMethod("currentWidget", "() const", "")]
		public QWidget CurrentWidget() {
			return ProxyQTabWidget().CurrentWidget();
		}
		[SmokeMethod("widget", "(int) const", "$")]
		public QWidget Widget(int index) {
			return ProxyQTabWidget().Widget(index);
		}
		[SmokeMethod("indexOf", "(QWidget*) const", "#")]
		public int IndexOf(QWidget widget) {
			return ProxyQTabWidget().IndexOf(widget);
		}
		[SmokeMethod("sizeHint", "() const", "")]
		public override QSize SizeHint() {
			return ProxyQTabWidget().SizeHint();
		}
		[SmokeMethod("minimumSizeHint", "() const", "")]
		public override QSize MinimumSizeHint() {
			return ProxyQTabWidget().MinimumSizeHint();
		}
		[SmokeMethod("setCornerWidget", "(QWidget*, Qt::Corner)", "#$")]
		public void SetCornerWidget(QWidget w, Qt.Corner corner) {
			ProxyQTabWidget().SetCornerWidget(w,corner);
		}
		[SmokeMethod("setCornerWidget", "(QWidget*)", "#")]
		public void SetCornerWidget(QWidget w) {
			ProxyQTabWidget().SetCornerWidget(w);
		}
		[SmokeMethod("cornerWidget", "(Qt::Corner) const", "$")]
		public QWidget CornerWidget(Qt.Corner corner) {
			return ProxyQTabWidget().CornerWidget(corner);
		}
		[SmokeMethod("cornerWidget", "() const", "")]
		public QWidget CornerWidget() {
			return ProxyQTabWidget().CornerWidget();
		}
		[Q_SLOT("void setCurrentWidget(QWidget*)")]
		[SmokeMethod("setCurrentWidget", "(QWidget*)", "#")]
		public void SetCurrentWidget(QWidget widget) {
			ProxyQTabWidget().SetCurrentWidget(widget);
		}
		public static string Tr(string s, string c) {
			return StaticQTabWidget().Tr(s,c);
		}
		public static string Tr(string s) {
			return StaticQTabWidget().Tr(s);
		}
		[SmokeMethod("tabInserted", "(int)", "$")]
		protected virtual void TabInserted(int index) {
			ProxyQTabWidget().TabInserted(index);
		}
		[SmokeMethod("tabRemoved", "(int)", "$")]
		protected virtual void TabRemoved(int index) {
			ProxyQTabWidget().TabRemoved(index);
		}
		[SmokeMethod("showEvent", "(QShowEvent*)", "#")]
		public override void ShowEvent(QShowEvent arg1) {
			ProxyQTabWidget().ShowEvent(arg1);
		}
		[SmokeMethod("resizeEvent", "(QResizeEvent*)", "#")]
		protected override void ResizeEvent(QResizeEvent arg1) {
			ProxyQTabWidget().ResizeEvent(arg1);
		}
		[SmokeMethod("keyPressEvent", "(QKeyEvent*)", "#")]
		protected override void KeyPressEvent(QKeyEvent arg1) {
			ProxyQTabWidget().KeyPressEvent(arg1);
		}
		[SmokeMethod("paintEvent", "(QPaintEvent*)", "#")]
		protected override void PaintEvent(QPaintEvent arg1) {
			ProxyQTabWidget().PaintEvent(arg1);
		}
		[SmokeMethod("setTabBar", "(QTabBar*)", "#")]
		protected void SetTabBar(QTabBar arg1) {
			ProxyQTabWidget().SetTabBar(arg1);
		}
		[SmokeMethod("tabBar", "() const", "")]
		protected QTabBar TabBar() {
			return ProxyQTabWidget().TabBar();
		}
		[SmokeMethod("changeEvent", "(QEvent*)", "#")]
		protected override void ChangeEvent(QEvent arg1) {
			ProxyQTabWidget().ChangeEvent(arg1);
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		public override bool Event(QEvent arg1) {
			return ProxyQTabWidget().Event(arg1);
		}
		~QTabWidget() {
			DisposeQTabWidget();
		}
		public new void Dispose() {
			DisposeQTabWidget();
		}
		[SmokeMethod("~QTabWidget", "()", "")]
		private void DisposeQTabWidget() {
			ProxyQTabWidget().DisposeQTabWidget();
		}
		protected new IQTabWidgetSignals Emit {
			get { return (IQTabWidgetSignals) Q_EMIT; }
		}
	}

	public interface IQTabWidgetSignals : IQWidgetSignals {
		[Q_SIGNAL("void currentChanged(int)")]
		void CurrentChanged(int index);
	}
}
