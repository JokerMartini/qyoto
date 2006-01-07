//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QGridLayout")]
	public class QGridLayout : QLayout, IDisposable {
 		protected QGridLayout(Type dummy) : base((Type) null) {}
		interface IQGridLayoutProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQGridLayoutProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGridLayout), this);
			_interceptor = (QGridLayout) realProxy.GetTransparentProxy();
		}
		private QGridLayout ProxyQGridLayout() {
			return (QGridLayout) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGridLayout() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGridLayoutProxy), null);
			_staticInterceptor = (IQGridLayoutProxy) realProxy.GetTransparentProxy();
		}
		private static IQGridLayoutProxy StaticQGridLayout() {
			return (IQGridLayoutProxy) _staticInterceptor;
		}

		public enum Corner {
			TopLeft = 0,
			TopRight = 1,
			BottomLeft = 2,
			BottomRight = 3,
		}
		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQGridLayout().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQGridLayout().ClassName();
		}
		public QGridLayout(QWidget parent, int nRows, int nCols, int border, int spacing, string name) : this((Type) null) {
			CreateQGridLayoutProxy();
			CreateQGridLayoutSignalProxy();
			NewQGridLayout(parent,nRows,nCols,border,spacing,name);
		}
		[SmokeMethod("QGridLayout(QWidget*, int, int, int, int, const char*)")]
		private void NewQGridLayout(QWidget parent, int nRows, int nCols, int border, int spacing, string name) {
			ProxyQGridLayout().NewQGridLayout(parent,nRows,nCols,border,spacing,name);
		}
		public QGridLayout(QWidget parent, int nRows, int nCols, int border, int spacing) : this((Type) null) {
			CreateQGridLayoutProxy();
			CreateQGridLayoutSignalProxy();
			NewQGridLayout(parent,nRows,nCols,border,spacing);
		}
		[SmokeMethod("QGridLayout(QWidget*, int, int, int, int)")]
		private void NewQGridLayout(QWidget parent, int nRows, int nCols, int border, int spacing) {
			ProxyQGridLayout().NewQGridLayout(parent,nRows,nCols,border,spacing);
		}
		public QGridLayout(QWidget parent, int nRows, int nCols, int border) : this((Type) null) {
			CreateQGridLayoutProxy();
			CreateQGridLayoutSignalProxy();
			NewQGridLayout(parent,nRows,nCols,border);
		}
		[SmokeMethod("QGridLayout(QWidget*, int, int, int)")]
		private void NewQGridLayout(QWidget parent, int nRows, int nCols, int border) {
			ProxyQGridLayout().NewQGridLayout(parent,nRows,nCols,border);
		}
		public QGridLayout(QWidget parent, int nRows, int nCols) : this((Type) null) {
			CreateQGridLayoutProxy();
			CreateQGridLayoutSignalProxy();
			NewQGridLayout(parent,nRows,nCols);
		}
		[SmokeMethod("QGridLayout(QWidget*, int, int)")]
		private void NewQGridLayout(QWidget parent, int nRows, int nCols) {
			ProxyQGridLayout().NewQGridLayout(parent,nRows,nCols);
		}
		public QGridLayout(QWidget parent, int nRows) : this((Type) null) {
			CreateQGridLayoutProxy();
			CreateQGridLayoutSignalProxy();
			NewQGridLayout(parent,nRows);
		}
		[SmokeMethod("QGridLayout(QWidget*, int)")]
		private void NewQGridLayout(QWidget parent, int nRows) {
			ProxyQGridLayout().NewQGridLayout(parent,nRows);
		}
		public QGridLayout(QWidget parent) : this((Type) null) {
			CreateQGridLayoutProxy();
			CreateQGridLayoutSignalProxy();
			NewQGridLayout(parent);
		}
		[SmokeMethod("QGridLayout(QWidget*)")]
		private void NewQGridLayout(QWidget parent) {
			ProxyQGridLayout().NewQGridLayout(parent);
		}
		public QGridLayout(int nRows, int nCols, int spacing, string name) : this((Type) null) {
			CreateQGridLayoutProxy();
			CreateQGridLayoutSignalProxy();
			NewQGridLayout(nRows,nCols,spacing,name);
		}
		[SmokeMethod("QGridLayout(int, int, int, const char*)")]
		private void NewQGridLayout(int nRows, int nCols, int spacing, string name) {
			ProxyQGridLayout().NewQGridLayout(nRows,nCols,spacing,name);
		}
		public QGridLayout(int nRows, int nCols, int spacing) : this((Type) null) {
			CreateQGridLayoutProxy();
			CreateQGridLayoutSignalProxy();
			NewQGridLayout(nRows,nCols,spacing);
		}
		[SmokeMethod("QGridLayout(int, int, int)")]
		private void NewQGridLayout(int nRows, int nCols, int spacing) {
			ProxyQGridLayout().NewQGridLayout(nRows,nCols,spacing);
		}
		public QGridLayout(int nRows, int nCols) : this((Type) null) {
			CreateQGridLayoutProxy();
			CreateQGridLayoutSignalProxy();
			NewQGridLayout(nRows,nCols);
		}
		[SmokeMethod("QGridLayout(int, int)")]
		private void NewQGridLayout(int nRows, int nCols) {
			ProxyQGridLayout().NewQGridLayout(nRows,nCols);
		}
		public QGridLayout(int nRows) : this((Type) null) {
			CreateQGridLayoutProxy();
			CreateQGridLayoutSignalProxy();
			NewQGridLayout(nRows);
		}
		[SmokeMethod("QGridLayout(int)")]
		private void NewQGridLayout(int nRows) {
			ProxyQGridLayout().NewQGridLayout(nRows);
		}
		public QGridLayout() : this((Type) null) {
			CreateQGridLayoutProxy();
			CreateQGridLayoutSignalProxy();
			NewQGridLayout();
		}
		[SmokeMethod("QGridLayout()")]
		private void NewQGridLayout() {
			ProxyQGridLayout().NewQGridLayout();
		}
		public QGridLayout(QLayout parentLayout, int nRows, int nCols, int spacing, string name) : this((Type) null) {
			CreateQGridLayoutProxy();
			CreateQGridLayoutSignalProxy();
			NewQGridLayout(parentLayout,nRows,nCols,spacing,name);
		}
		[SmokeMethod("QGridLayout(QLayout*, int, int, int, const char*)")]
		private void NewQGridLayout(QLayout parentLayout, int nRows, int nCols, int spacing, string name) {
			ProxyQGridLayout().NewQGridLayout(parentLayout,nRows,nCols,spacing,name);
		}
		public QGridLayout(QLayout parentLayout, int nRows, int nCols, int spacing) : this((Type) null) {
			CreateQGridLayoutProxy();
			CreateQGridLayoutSignalProxy();
			NewQGridLayout(parentLayout,nRows,nCols,spacing);
		}
		[SmokeMethod("QGridLayout(QLayout*, int, int, int)")]
		private void NewQGridLayout(QLayout parentLayout, int nRows, int nCols, int spacing) {
			ProxyQGridLayout().NewQGridLayout(parentLayout,nRows,nCols,spacing);
		}
		public QGridLayout(QLayout parentLayout, int nRows, int nCols) : this((Type) null) {
			CreateQGridLayoutProxy();
			CreateQGridLayoutSignalProxy();
			NewQGridLayout(parentLayout,nRows,nCols);
		}
		[SmokeMethod("QGridLayout(QLayout*, int, int)")]
		private void NewQGridLayout(QLayout parentLayout, int nRows, int nCols) {
			ProxyQGridLayout().NewQGridLayout(parentLayout,nRows,nCols);
		}
		public QGridLayout(QLayout parentLayout, int nRows) : this((Type) null) {
			CreateQGridLayoutProxy();
			CreateQGridLayoutSignalProxy();
			NewQGridLayout(parentLayout,nRows);
		}
		[SmokeMethod("QGridLayout(QLayout*, int)")]
		private void NewQGridLayout(QLayout parentLayout, int nRows) {
			ProxyQGridLayout().NewQGridLayout(parentLayout,nRows);
		}
		public QGridLayout(QLayout parentLayout) : this((Type) null) {
			CreateQGridLayoutProxy();
			CreateQGridLayoutSignalProxy();
			NewQGridLayout(parentLayout);
		}
		[SmokeMethod("QGridLayout(QLayout*)")]
		private void NewQGridLayout(QLayout parentLayout) {
			ProxyQGridLayout().NewQGridLayout(parentLayout);
		}
		[SmokeMethod("sizeHint() const")]
		public new QSize SizeHint() {
			return ProxyQGridLayout().SizeHint();
		}
		[SmokeMethod("minimumSize() const")]
		public new QSize MinimumSize() {
			return ProxyQGridLayout().MinimumSize();
		}
		[SmokeMethod("maximumSize() const")]
		public new QSize MaximumSize() {
			return ProxyQGridLayout().MaximumSize();
		}
		[SmokeMethod("setRowStretch(int, int)")]
		public virtual void SetRowStretch(int row, int stretch) {
			ProxyQGridLayout().SetRowStretch(row,stretch);
		}
		[SmokeMethod("setColStretch(int, int)")]
		public virtual void SetColStretch(int col, int stretch) {
			ProxyQGridLayout().SetColStretch(col,stretch);
		}
		[SmokeMethod("rowStretch(int) const")]
		public int RowStretch(int row) {
			return ProxyQGridLayout().RowStretch(row);
		}
		[SmokeMethod("colStretch(int) const")]
		public int ColStretch(int col) {
			return ProxyQGridLayout().ColStretch(col);
		}
		[SmokeMethod("setRowSpacing(int, int)")]
		public void SetRowSpacing(int row, int minSize) {
			ProxyQGridLayout().SetRowSpacing(row,minSize);
		}
		[SmokeMethod("setColSpacing(int, int)")]
		public void SetColSpacing(int col, int minSize) {
			ProxyQGridLayout().SetColSpacing(col,minSize);
		}
		[SmokeMethod("rowSpacing(int) const")]
		public int RowSpacing(int row) {
			return ProxyQGridLayout().RowSpacing(row);
		}
		[SmokeMethod("colSpacing(int) const")]
		public int ColSpacing(int col) {
			return ProxyQGridLayout().ColSpacing(col);
		}
		[SmokeMethod("numRows() const")]
		public int NumRows() {
			return ProxyQGridLayout().NumRows();
		}
		[SmokeMethod("numCols() const")]
		public int NumCols() {
			return ProxyQGridLayout().NumCols();
		}
		[SmokeMethod("cellGeometry(int, int) const")]
		public QRect CellGeometry(int row, int col) {
			return ProxyQGridLayout().CellGeometry(row,col);
		}
		[SmokeMethod("hasHeightForWidth() const")]
		public new bool HasHeightForWidth() {
			return ProxyQGridLayout().HasHeightForWidth();
		}
		[SmokeMethod("heightForWidth(int) const")]
		public new int HeightForWidth(int arg1) {
			return ProxyQGridLayout().HeightForWidth(arg1);
		}
		[SmokeMethod("minimumHeightForWidth(int) const")]
		public int MinimumHeightForWidth(int arg1) {
			return ProxyQGridLayout().MinimumHeightForWidth(arg1);
		}
		[SmokeMethod("expanding() const")]
		public new QSizePolicy.ExpandData Expanding() {
			return ProxyQGridLayout().Expanding();
		}
		[SmokeMethod("invalidate()")]
		public new void Invalidate() {
			ProxyQGridLayout().Invalidate();
		}
		[SmokeMethod("addItem(QLayoutItem*)")]
		public new void AddItem(IQLayoutItem arg1) {
			ProxyQGridLayout().AddItem(arg1);
		}
		[SmokeMethod("addItem(QLayoutItem*, int, int)")]
		public new void AddItem(IQLayoutItem item, int row, int col) {
			ProxyQGridLayout().AddItem(item,row,col);
		}
		[SmokeMethod("addMultiCell(QLayoutItem*, int, int, int, int, int)")]
		public void AddMultiCell(IQLayoutItem arg1, int fromRow, int toRow, int fromCol, int toCol, int align) {
			ProxyQGridLayout().AddMultiCell(arg1,fromRow,toRow,fromCol,toCol,align);
		}
		[SmokeMethod("addMultiCell(QLayoutItem*, int, int, int, int)")]
		public void AddMultiCell(IQLayoutItem arg1, int fromRow, int toRow, int fromCol, int toCol) {
			ProxyQGridLayout().AddMultiCell(arg1,fromRow,toRow,fromCol,toCol);
		}
		[SmokeMethod("addWidget(QWidget*, int, int, int)")]
		public void AddWidget(QWidget arg1, int row, int col, int align) {
			ProxyQGridLayout().AddWidget(arg1,row,col,align);
		}
		[SmokeMethod("addWidget(QWidget*, int, int)")]
		public void AddWidget(QWidget arg1, int row, int col) {
			ProxyQGridLayout().AddWidget(arg1,row,col);
		}
		[SmokeMethod("addMultiCellWidget(QWidget*, int, int, int, int, int)")]
		public void AddMultiCellWidget(QWidget arg1, int fromRow, int toRow, int fromCol, int toCol, int align) {
			ProxyQGridLayout().AddMultiCellWidget(arg1,fromRow,toRow,fromCol,toCol,align);
		}
		[SmokeMethod("addMultiCellWidget(QWidget*, int, int, int, int)")]
		public void AddMultiCellWidget(QWidget arg1, int fromRow, int toRow, int fromCol, int toCol) {
			ProxyQGridLayout().AddMultiCellWidget(arg1,fromRow,toRow,fromCol,toCol);
		}
		[SmokeMethod("addLayout(QLayout*, int, int)")]
		public void AddLayout(QLayout layout, int row, int col) {
			ProxyQGridLayout().AddLayout(layout,row,col);
		}
		[SmokeMethod("addMultiCellLayout(QLayout*, int, int, int, int, int)")]
		public void AddMultiCellLayout(QLayout layout, int fromRow, int toRow, int fromCol, int toCol, int align) {
			ProxyQGridLayout().AddMultiCellLayout(layout,fromRow,toRow,fromCol,toCol,align);
		}
		[SmokeMethod("addMultiCellLayout(QLayout*, int, int, int, int)")]
		public void AddMultiCellLayout(QLayout layout, int fromRow, int toRow, int fromCol, int toCol) {
			ProxyQGridLayout().AddMultiCellLayout(layout,fromRow,toRow,fromCol,toCol);
		}
		[SmokeMethod("addRowSpacing(int, int)")]
		public void AddRowSpacing(int row, int minsize) {
			ProxyQGridLayout().AddRowSpacing(row,minsize);
		}
		[SmokeMethod("addColSpacing(int, int)")]
		public void AddColSpacing(int col, int minsize) {
			ProxyQGridLayout().AddColSpacing(col,minsize);
		}
		[SmokeMethod("expand(int, int)")]
		public void Expand(int rows, int cols) {
			ProxyQGridLayout().Expand(rows,cols);
		}
		[SmokeMethod("setOrigin(QGridLayout::Corner)")]
		public void SetOrigin(QGridLayout.Corner arg1) {
			ProxyQGridLayout().SetOrigin(arg1);
		}
		[SmokeMethod("origin() const")]
		public QGridLayout.Corner Origin() {
			return ProxyQGridLayout().Origin();
		}
		// QLayoutIterator iterator(); >>>> NOT CONVERTED
		[SmokeMethod("setGeometry(const QRect&)")]
		public new void SetGeometry(QRect arg1) {
			ProxyQGridLayout().SetGeometry(arg1);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQGridLayout().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQGridLayout().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQGridLayout().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQGridLayout().TrUtf8(arg1);
		}
		[SmokeMethod("findWidget(QWidget*, int*, int*)")]
		protected bool FindWidget(QWidget w, out int r, out int c) {
			return ProxyQGridLayout().FindWidget(w,out r,out c);
		}
		[SmokeMethod("add(QLayoutItem*, int, int)")]
		protected new void Add(IQLayoutItem arg1, int row, int col) {
			ProxyQGridLayout().Add(arg1,row,col);
		}
		~QGridLayout() {
			DisposeQGridLayout();
		}
		public new void Dispose() {
			DisposeQGridLayout();
		}
		private void DisposeQGridLayout() {
			ProxyQGridLayout().DisposeQGridLayout();
		}
		protected void CreateQGridLayoutSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQGridLayoutSignals), this);
			Q_EMIT = (IQGridLayoutSignals) realProxy.GetTransparentProxy();
		}
		protected new IQGridLayoutSignals Emit() {
			return (IQGridLayoutSignals) Q_EMIT;
		}
	}

	public interface IQGridLayoutSignals : IQLayoutSignals {
	}
}
