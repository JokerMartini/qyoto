//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQHeaderSignals"></see> for signals emitted by QHeader
	public class QHeader : QWidget, IDisposable {
 		protected QHeader(Type dummy) : base((Type) null) {}
		interface IQHeaderProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQHeaderProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QHeader), this);
			_interceptor = (QHeader) realProxy.GetTransparentProxy();
		}
		private QHeader ProxyQHeader() {
			return (QHeader) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QHeader() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQHeaderProxy), null);
			_staticInterceptor = (IQHeaderProxy) realProxy.GetTransparentProxy();
		}
		private static IQHeaderProxy StaticQHeader() {
			return (IQHeaderProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQHeader().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQHeader().ClassName();
		}
		public QHeader(QWidget parent, string name) : this((Type) null) {
			CreateQHeaderProxy();
			CreateQHeaderSignalProxy();
			NewQHeader(parent,name);
		}
		[SmokeMethod("QHeader(QWidget*, const char*)")]
		private void NewQHeader(QWidget parent, string name) {
			ProxyQHeader().NewQHeader(parent,name);
		}
		public QHeader(QWidget parent) : this((Type) null) {
			CreateQHeaderProxy();
			CreateQHeaderSignalProxy();
			NewQHeader(parent);
		}
		[SmokeMethod("QHeader(QWidget*)")]
		private void NewQHeader(QWidget parent) {
			ProxyQHeader().NewQHeader(parent);
		}
		public QHeader() : this((Type) null) {
			CreateQHeaderProxy();
			CreateQHeaderSignalProxy();
			NewQHeader();
		}
		[SmokeMethod("QHeader()")]
		private void NewQHeader() {
			ProxyQHeader().NewQHeader();
		}
		public QHeader(int arg1, QWidget parent, string name) : this((Type) null) {
			CreateQHeaderProxy();
			CreateQHeaderSignalProxy();
			NewQHeader(arg1,parent,name);
		}
		[SmokeMethod("QHeader(int, QWidget*, const char*)")]
		private void NewQHeader(int arg1, QWidget parent, string name) {
			ProxyQHeader().NewQHeader(arg1,parent,name);
		}
		public QHeader(int arg1, QWidget parent) : this((Type) null) {
			CreateQHeaderProxy();
			CreateQHeaderSignalProxy();
			NewQHeader(arg1,parent);
		}
		[SmokeMethod("QHeader(int, QWidget*)")]
		private void NewQHeader(int arg1, QWidget parent) {
			ProxyQHeader().NewQHeader(arg1,parent);
		}
		public QHeader(int arg1) : this((Type) null) {
			CreateQHeaderProxy();
			CreateQHeaderSignalProxy();
			NewQHeader(arg1);
		}
		[SmokeMethod("QHeader(int)")]
		private void NewQHeader(int arg1) {
			ProxyQHeader().NewQHeader(arg1);
		}
		[SmokeMethod("addLabel(const QString&, int)")]
		public int AddLabel(string arg1, int size) {
			return ProxyQHeader().AddLabel(arg1,size);
		}
		[SmokeMethod("addLabel(const QString&)")]
		public int AddLabel(string arg1) {
			return ProxyQHeader().AddLabel(arg1);
		}
		[SmokeMethod("addLabel(const QIconSet&, const QString&, int)")]
		public int AddLabel(QIconSet arg1, string arg2, int size) {
			return ProxyQHeader().AddLabel(arg1,arg2,size);
		}
		[SmokeMethod("addLabel(const QIconSet&, const QString&)")]
		public int AddLabel(QIconSet arg1, string arg2) {
			return ProxyQHeader().AddLabel(arg1,arg2);
		}
		[SmokeMethod("removeLabel(int)")]
		public void RemoveLabel(int section) {
			ProxyQHeader().RemoveLabel(section);
		}
		[SmokeMethod("setLabel(int, const QString&, int)")]
		public virtual void SetLabel(int arg1, string arg2, int size) {
			ProxyQHeader().SetLabel(arg1,arg2,size);
		}
		[SmokeMethod("setLabel(int, const QString&)")]
		public virtual void SetLabel(int arg1, string arg2) {
			ProxyQHeader().SetLabel(arg1,arg2);
		}
		[SmokeMethod("setLabel(int, const QIconSet&, const QString&, int)")]
		public virtual void SetLabel(int arg1, QIconSet arg2, string arg3, int size) {
			ProxyQHeader().SetLabel(arg1,arg2,arg3,size);
		}
		[SmokeMethod("setLabel(int, const QIconSet&, const QString&)")]
		public virtual void SetLabel(int arg1, QIconSet arg2, string arg3) {
			ProxyQHeader().SetLabel(arg1,arg2,arg3);
		}
		[SmokeMethod("label(int) const")]
		public string Label(int section) {
			return ProxyQHeader().Label(section);
		}
		[SmokeMethod("iconSet(int) const")]
		public QIconSet IconSet(int section) {
			return ProxyQHeader().IconSet(section);
		}
		[SmokeMethod("setOrientation(Qt::Orientation)")]
		public virtual void SetOrientation(int arg1) {
			ProxyQHeader().SetOrientation(arg1);
		}
		[SmokeMethod("orientation() const")]
		public int Orientation() {
			return ProxyQHeader().Orientation();
		}
		[SmokeMethod("setTracking(bool)")]
		public virtual void SetTracking(bool enable) {
			ProxyQHeader().SetTracking(enable);
		}
		[SmokeMethod("tracking() const")]
		public bool Tracking() {
			return ProxyQHeader().Tracking();
		}
		[SmokeMethod("setClickEnabled(bool, int)")]
		public virtual void SetClickEnabled(bool arg1, int section) {
			ProxyQHeader().SetClickEnabled(arg1,section);
		}
		[SmokeMethod("setClickEnabled(bool)")]
		public virtual void SetClickEnabled(bool arg1) {
			ProxyQHeader().SetClickEnabled(arg1);
		}
		[SmokeMethod("setResizeEnabled(bool, int)")]
		public virtual void SetResizeEnabled(bool arg1, int section) {
			ProxyQHeader().SetResizeEnabled(arg1,section);
		}
		[SmokeMethod("setResizeEnabled(bool)")]
		public virtual void SetResizeEnabled(bool arg1) {
			ProxyQHeader().SetResizeEnabled(arg1);
		}
		[SmokeMethod("setMovingEnabled(bool)")]
		public virtual void SetMovingEnabled(bool arg1) {
			ProxyQHeader().SetMovingEnabled(arg1);
		}
		[SmokeMethod("setStretchEnabled(bool, int)")]
		public virtual void SetStretchEnabled(bool b, int section) {
			ProxyQHeader().SetStretchEnabled(b,section);
		}
		[SmokeMethod("setStretchEnabled(bool)")]
		public void SetStretchEnabled(bool b) {
			ProxyQHeader().SetStretchEnabled(b);
		}
		[SmokeMethod("isClickEnabled(int) const")]
		public bool IsClickEnabled(int section) {
			return ProxyQHeader().IsClickEnabled(section);
		}
		[SmokeMethod("isClickEnabled() const")]
		public bool IsClickEnabled() {
			return ProxyQHeader().IsClickEnabled();
		}
		[SmokeMethod("isResizeEnabled(int) const")]
		public bool IsResizeEnabled(int section) {
			return ProxyQHeader().IsResizeEnabled(section);
		}
		[SmokeMethod("isResizeEnabled() const")]
		public bool IsResizeEnabled() {
			return ProxyQHeader().IsResizeEnabled();
		}
		[SmokeMethod("isMovingEnabled() const")]
		public bool IsMovingEnabled() {
			return ProxyQHeader().IsMovingEnabled();
		}
		[SmokeMethod("isStretchEnabled() const")]
		public bool IsStretchEnabled() {
			return ProxyQHeader().IsStretchEnabled();
		}
		[SmokeMethod("isStretchEnabled(int) const")]
		public bool IsStretchEnabled(int section) {
			return ProxyQHeader().IsStretchEnabled(section);
		}
		[SmokeMethod("resizeSection(int, int)")]
		public void ResizeSection(int section, int s) {
			ProxyQHeader().ResizeSection(section,s);
		}
		[SmokeMethod("sectionSize(int) const")]
		public int SectionSize(int section) {
			return ProxyQHeader().SectionSize(section);
		}
		[SmokeMethod("sectionPos(int) const")]
		public int SectionPos(int section) {
			return ProxyQHeader().SectionPos(section);
		}
		[SmokeMethod("sectionAt(int) const")]
		public int SectionAt(int pos) {
			return ProxyQHeader().SectionAt(pos);
		}
		[SmokeMethod("count() const")]
		public int Count() {
			return ProxyQHeader().Count();
		}
		[SmokeMethod("headerWidth() const")]
		public int HeaderWidth() {
			return ProxyQHeader().HeaderWidth();
		}
		[SmokeMethod("sectionRect(int) const")]
		public QRect SectionRect(int section) {
			return ProxyQHeader().SectionRect(section);
		}
		[SmokeMethod("setCellSize(int, int)")]
		public virtual void SetCellSize(int arg1, int arg2) {
			ProxyQHeader().SetCellSize(arg1,arg2);
		}
		[SmokeMethod("cellSize(int) const")]
		public int CellSize(int i) {
			return ProxyQHeader().CellSize(i);
		}
		[SmokeMethod("cellPos(int) const")]
		public int CellPos(int arg1) {
			return ProxyQHeader().CellPos(arg1);
		}
		[SmokeMethod("cellAt(int) const")]
		public int CellAt(int pos) {
			return ProxyQHeader().CellAt(pos);
		}
		[SmokeMethod("offset() const")]
		public int Offset() {
			return ProxyQHeader().Offset();
		}
		[SmokeMethod("sizeHint() const")]
		public new QSize SizeHint() {
			return ProxyQHeader().SizeHint();
		}
		[SmokeMethod("mapToSection(int) const")]
		public int MapToSection(int index) {
			return ProxyQHeader().MapToSection(index);
		}
		[SmokeMethod("mapToIndex(int) const")]
		public int MapToIndex(int section) {
			return ProxyQHeader().MapToIndex(section);
		}
		[SmokeMethod("mapToLogical(int) const")]
		public int MapToLogical(int arg1) {
			return ProxyQHeader().MapToLogical(arg1);
		}
		[SmokeMethod("mapToActual(int) const")]
		public int MapToActual(int arg1) {
			return ProxyQHeader().MapToActual(arg1);
		}
		[SmokeMethod("moveSection(int, int)")]
		public void MoveSection(int section, int toIndex) {
			ProxyQHeader().MoveSection(section,toIndex);
		}
		[SmokeMethod("moveCell(int, int)")]
		public virtual void MoveCell(int arg1, int arg2) {
			ProxyQHeader().MoveCell(arg1,arg2);
		}
		[SmokeMethod("setSortIndicator(int, bool)")]
		public void SetSortIndicator(int section, bool ascending) {
			ProxyQHeader().SetSortIndicator(section,ascending);
		}
		[SmokeMethod("setSortIndicator(int)")]
		public void SetSortIndicator(int section) {
			ProxyQHeader().SetSortIndicator(section);
		}
		[SmokeMethod("setSortIndicator(int, Qt::SortOrder)")]
		public void SetSortIndicator(int section, int order) {
			ProxyQHeader().SetSortIndicator(section,order);
		}
		[SmokeMethod("sortIndicatorSection() const")]
		public int SortIndicatorSection() {
			return ProxyQHeader().SortIndicatorSection();
		}
		[SmokeMethod("sortIndicatorOrder() const")]
		public int SortIndicatorOrder() {
			return ProxyQHeader().SortIndicatorOrder();
		}
		[SmokeMethod("adjustHeaderSize()")]
		public void AdjustHeaderSize() {
			ProxyQHeader().AdjustHeaderSize();
		}
		[Q_SLOT("setUpdatesEnabled(bool)")]
		[SmokeMethod("setUpdatesEnabled(bool)")]
		public new void SetUpdatesEnabled(bool enable) {
			ProxyQHeader().SetUpdatesEnabled(enable);
		}
		[Q_SLOT("setOffset(int)")]
		[SmokeMethod("setOffset(int)")]
		public virtual void SetOffset(int pos) {
			ProxyQHeader().SetOffset(pos);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQHeader().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQHeader().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQHeader().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQHeader().TrUtf8(arg1);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected new void PaintEvent(QPaintEvent arg1) {
			ProxyQHeader().PaintEvent(arg1);
		}
		[SmokeMethod("showEvent(QShowEvent*)")]
		public new void ShowEvent(QShowEvent e) {
			ProxyQHeader().ShowEvent(e);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected new void ResizeEvent(QResizeEvent e) {
			ProxyQHeader().ResizeEvent(e);
		}
		[SmokeMethod("sRect(int)")]
		protected QRect SRect(int index) {
			return ProxyQHeader().SRect(index);
		}
		[SmokeMethod("paintSection(QPainter*, int, const QRect&)")]
		protected virtual void PaintSection(QPainter p, int index, QRect fr) {
			ProxyQHeader().PaintSection(p,index,fr);
		}
		[SmokeMethod("paintSectionLabel(QPainter*, int, const QRect&)")]
		protected virtual void PaintSectionLabel(QPainter p, int index, QRect fr) {
			ProxyQHeader().PaintSectionLabel(p,index,fr);
		}
		[SmokeMethod("fontChange(const QFont&)")]
		protected new void FontChange(QFont arg1) {
			ProxyQHeader().FontChange(arg1);
		}
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected new void MousePressEvent(QMouseEvent arg1) {
			ProxyQHeader().MousePressEvent(arg1);
		}
		[SmokeMethod("mouseReleaseEvent(QMouseEvent*)")]
		protected new void MouseReleaseEvent(QMouseEvent arg1) {
			ProxyQHeader().MouseReleaseEvent(arg1);
		}
		[SmokeMethod("mouseMoveEvent(QMouseEvent*)")]
		protected new void MouseMoveEvent(QMouseEvent arg1) {
			ProxyQHeader().MouseMoveEvent(arg1);
		}
		[SmokeMethod("mouseDoubleClickEvent(QMouseEvent*)")]
		protected new void MouseDoubleClickEvent(QMouseEvent arg1) {
			ProxyQHeader().MouseDoubleClickEvent(arg1);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected new void KeyPressEvent(QKeyEvent arg1) {
			ProxyQHeader().KeyPressEvent(arg1);
		}
		[SmokeMethod("keyReleaseEvent(QKeyEvent*)")]
		protected new void KeyReleaseEvent(QKeyEvent arg1) {
			ProxyQHeader().KeyReleaseEvent(arg1);
		}
		~QHeader() {
			DisposeQHeader();
		}
		public new void Dispose() {
			DisposeQHeader();
		}
		private void DisposeQHeader() {
			ProxyQHeader().DisposeQHeader();
		}
		protected void CreateQHeaderSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQHeaderSignals), this);
			_signalInterceptor = (IQHeaderSignals) realProxy.GetTransparentProxy();
		}
		protected new IQHeaderSignals Emit() {
			return (IQHeaderSignals) _signalInterceptor;
		}
	}

	public interface IQHeaderSignals : IQWidgetSignals {
		[Q_SIGNAL("clicked(int)")]
		void Clicked(int section);
		[Q_SIGNAL("pressed(int)")]
		void Pressed(int section);
		[Q_SIGNAL("released(int)")]
		void Released(int section);
		[Q_SIGNAL("sizeChange(int, int, int)")]
		void SizeChange(int section, int oldSize, int newSize);
		[Q_SIGNAL("indexChange(int, int, int)")]
		void IndexChange(int section, int fromIndex, int toIndex);
		[Q_SIGNAL("sectionClicked(int)")]
		void SectionClicked(int arg1);
		[Q_SIGNAL("moved(int, int)")]
		void Moved(int arg1, int arg2);
		[Q_SIGNAL("sectionHandleDoubleClicked(int)")]
		void SectionHandleDoubleClicked(int section);
	}
}
