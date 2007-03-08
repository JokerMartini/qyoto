//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	/// See <see cref="IQDataWidgetMapperSignals"></see> for signals emitted by QDataWidgetMapper
	[SmokeClass("QDataWidgetMapper")]
	public class QDataWidgetMapper : QObject, IDisposable {
 		protected QDataWidgetMapper(Type dummy) : base((Type) null) {}
		[SmokeClass("QDataWidgetMapper")]
		interface IQDataWidgetMapperProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDataWidgetMapper), this);
			_interceptor = (QDataWidgetMapper) realProxy.GetTransparentProxy();
		}
		private QDataWidgetMapper ProxyQDataWidgetMapper() {
			return (QDataWidgetMapper) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDataWidgetMapper() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDataWidgetMapperProxy), null);
			_staticInterceptor = (IQDataWidgetMapperProxy) realProxy.GetTransparentProxy();
		}
		private static IQDataWidgetMapperProxy StaticQDataWidgetMapper() {
			return (IQDataWidgetMapperProxy) _staticInterceptor;
		}
		public enum SubmitPolicy {
			AutoSubmit = 0,
			ManualSubmit = 1,
		}
		[Q_PROPERTY("int", "currentIndex")]
		public int CurrentIndex {
			get { return Property("currentIndex").Value<int>(); }
			set { SetProperty("currentIndex", QVariant.FromValue<int>(value)); }
		}
		[Q_PROPERTY("Qt::Orientation", "orientation")]
		public Qt.Orientation Orientation {
			get { return Property("orientation").Value<Qt.Orientation>(); }
			set { SetProperty("orientation", QVariant.FromValue<Qt.Orientation>(value)); }
		}
		[Q_PROPERTY("QDataWidgetMapper::SubmitPolicy", "submitPolicy")]
		public QDataWidgetMapper.SubmitPolicy submitPolicy {
			get { return Property("submitPolicy").Value<QDataWidgetMapper.SubmitPolicy>(); }
			set { SetProperty("submitPolicy", QVariant.FromValue<QDataWidgetMapper.SubmitPolicy>(value)); }
		}
		public QDataWidgetMapper(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQDataWidgetMapper(parent);
		}
		[SmokeMethod("QDataWidgetMapper", "(QObject*)", "#")]
		private void NewQDataWidgetMapper(QObject parent) {
			ProxyQDataWidgetMapper().NewQDataWidgetMapper(parent);
		}
		public QDataWidgetMapper() : this((Type) null) {
			CreateProxy();
			NewQDataWidgetMapper();
		}
		[SmokeMethod("QDataWidgetMapper", "()", "")]
		private void NewQDataWidgetMapper() {
			ProxyQDataWidgetMapper().NewQDataWidgetMapper();
		}
		[SmokeMethod("setModel", "(QAbstractItemModel*)", "#")]
		public void SetModel(QAbstractItemModel model) {
			ProxyQDataWidgetMapper().SetModel(model);
		}
		[SmokeMethod("model", "() const", "")]
		public QAbstractItemModel Model() {
			return ProxyQDataWidgetMapper().Model();
		}
		[SmokeMethod("setItemDelegate", "(QAbstractItemDelegate*)", "#")]
		public void SetItemDelegate(QAbstractItemDelegate arg1) {
			ProxyQDataWidgetMapper().SetItemDelegate(arg1);
		}
		[SmokeMethod("itemDelegate", "() const", "")]
		public QAbstractItemDelegate ItemDelegate() {
			return ProxyQDataWidgetMapper().ItemDelegate();
		}
		[SmokeMethod("setRootIndex", "(const QModelIndex&)", "#")]
		public void SetRootIndex(QModelIndex index) {
			ProxyQDataWidgetMapper().SetRootIndex(index);
		}
		[SmokeMethod("rootIndex", "() const", "")]
		public QModelIndex RootIndex() {
			return ProxyQDataWidgetMapper().RootIndex();
		}
		[SmokeMethod("addMapping", "(QWidget*, int)", "#$")]
		public void AddMapping(QWidget widget, int section) {
			ProxyQDataWidgetMapper().AddMapping(widget,section);
		}
		[SmokeMethod("removeMapping", "(QWidget*)", "#")]
		public void RemoveMapping(QWidget widget) {
			ProxyQDataWidgetMapper().RemoveMapping(widget);
		}
		[SmokeMethod("mappedSection", "(QWidget*) const", "#")]
		public int MappedSection(QWidget widget) {
			return ProxyQDataWidgetMapper().MappedSection(widget);
		}
		[SmokeMethod("mappedWidgetAt", "(int) const", "$")]
		public QWidget MappedWidgetAt(int section) {
			return ProxyQDataWidgetMapper().MappedWidgetAt(section);
		}
		[SmokeMethod("clearMapping", "()", "")]
		public void ClearMapping() {
			ProxyQDataWidgetMapper().ClearMapping();
		}
		[Q_SLOT("void revert()")]
		[SmokeMethod("revert", "()", "")]
		public void Revert() {
			ProxyQDataWidgetMapper().Revert();
		}
		[Q_SLOT("bool submit()")]
		[SmokeMethod("submit", "()", "")]
		public bool Submit() {
			return ProxyQDataWidgetMapper().Submit();
		}
		[Q_SLOT("void toFirst()")]
		[SmokeMethod("toFirst", "()", "")]
		public void ToFirst() {
			ProxyQDataWidgetMapper().ToFirst();
		}
		[Q_SLOT("void toLast()")]
		[SmokeMethod("toLast", "()", "")]
		public void ToLast() {
			ProxyQDataWidgetMapper().ToLast();
		}
		[Q_SLOT("void toNext()")]
		[SmokeMethod("toNext", "()", "")]
		public void ToNext() {
			ProxyQDataWidgetMapper().ToNext();
		}
		[Q_SLOT("void toPrevious()")]
		[SmokeMethod("toPrevious", "()", "")]
		public void ToPrevious() {
			ProxyQDataWidgetMapper().ToPrevious();
		}
		[Q_SLOT("void setCurrentModelIndex(const QModelIndex&)")]
		[SmokeMethod("setCurrentModelIndex", "(const QModelIndex&)", "#")]
		public void SetCurrentModelIndex(QModelIndex index) {
			ProxyQDataWidgetMapper().SetCurrentModelIndex(index);
		}
		public static string Tr(string s, string c) {
			return StaticQDataWidgetMapper().Tr(s,c);
		}
		public static string Tr(string s) {
			return StaticQDataWidgetMapper().Tr(s);
		}
		~QDataWidgetMapper() {
			DisposeQDataWidgetMapper();
		}
		public new void Dispose() {
			DisposeQDataWidgetMapper();
		}
		[SmokeMethod("~QDataWidgetMapper", "()", "")]
		private void DisposeQDataWidgetMapper() {
			ProxyQDataWidgetMapper().DisposeQDataWidgetMapper();
		}
		protected new IQDataWidgetMapperSignals Emit {
			get { return (IQDataWidgetMapperSignals) Q_EMIT; }
		}
	}

	public interface IQDataWidgetMapperSignals : IQObjectSignals {
		[Q_SIGNAL("void currentIndexChanged(int)")]
		void CurrentIndexChanged(int index);
	}
}
