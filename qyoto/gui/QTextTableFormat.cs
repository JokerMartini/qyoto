//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QTextTableFormat")]
	public class QTextTableFormat : QTextFrameFormat, IDisposable {
 		protected QTextTableFormat(Type dummy) : base((Type) null) {}
		[SmokeClass("QTextTableFormat")]
		interface IQTextTableFormatProxy {
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextTableFormat), this);
			_interceptor = (QTextTableFormat) realProxy.GetTransparentProxy();
		}
		private QTextTableFormat ProxyQTextTableFormat() {
			return (QTextTableFormat) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextTableFormat() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextTableFormatProxy), null);
			_staticInterceptor = (IQTextTableFormatProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextTableFormatProxy StaticQTextTableFormat() {
			return (IQTextTableFormatProxy) _staticInterceptor;
		}
		public QTextTableFormat() : this((Type) null) {
			CreateProxy();
			NewQTextTableFormat();
		}
		[SmokeMethod("QTextTableFormat", "()", "")]
		private void NewQTextTableFormat() {
			ProxyQTextTableFormat().NewQTextTableFormat();
		}
		[SmokeMethod("isValid", "() const", "")]
		public bool IsValid() {
			return ProxyQTextTableFormat().IsValid();
		}
		[SmokeMethod("columns", "() const", "")]
		public int Columns() {
			return ProxyQTextTableFormat().Columns();
		}
		[SmokeMethod("setColumns", "(int)", "$")]
		public void SetColumns(int columns) {
			ProxyQTextTableFormat().SetColumns(columns);
		}
		[SmokeMethod("setColumnWidthConstraints", "(const QVector<QTextLength>&)", "?")]
		public void SetColumnWidthConstraints(List<QTextLength> constraints) {
			ProxyQTextTableFormat().SetColumnWidthConstraints(constraints);
		}
		[SmokeMethod("columnWidthConstraints", "() const", "")]
		public List<QTextLength> ColumnWidthConstraints() {
			return ProxyQTextTableFormat().ColumnWidthConstraints();
		}
		[SmokeMethod("clearColumnWidthConstraints", "()", "")]
		public void ClearColumnWidthConstraints() {
			ProxyQTextTableFormat().ClearColumnWidthConstraints();
		}
		[SmokeMethod("cellSpacing", "() const", "")]
		public double CellSpacing() {
			return ProxyQTextTableFormat().CellSpacing();
		}
		[SmokeMethod("setCellSpacing", "(qreal)", "$")]
		public void SetCellSpacing(double spacing) {
			ProxyQTextTableFormat().SetCellSpacing(spacing);
		}
		[SmokeMethod("cellPadding", "() const", "")]
		public double CellPadding() {
			return ProxyQTextTableFormat().CellPadding();
		}
		[SmokeMethod("setCellPadding", "(qreal)", "$")]
		public void SetCellPadding(double padding) {
			ProxyQTextTableFormat().SetCellPadding(padding);
		}
		[SmokeMethod("setAlignment", "(Qt::Alignment)", "$")]
		public void SetAlignment(int alignment) {
			ProxyQTextTableFormat().SetAlignment(alignment);
		}
		[SmokeMethod("alignment", "() const", "")]
		public int Alignment() {
			return ProxyQTextTableFormat().Alignment();
		}
		[SmokeMethod("setHeaderRowCount", "(int)", "$")]
		public void SetHeaderRowCount(int count) {
			ProxyQTextTableFormat().SetHeaderRowCount(count);
		}
		[SmokeMethod("headerRowCount", "() const", "")]
		public int HeaderRowCount() {
			return ProxyQTextTableFormat().HeaderRowCount();
		}
		~QTextTableFormat() {
			DisposeQTextTableFormat();
		}
		public void Dispose() {
			DisposeQTextTableFormat();
		}
		[SmokeMethod("~QTextTableFormat", "()", "")]
		private void DisposeQTextTableFormat() {
			ProxyQTextTableFormat().DisposeQTextTableFormat();
		}
	}
}
