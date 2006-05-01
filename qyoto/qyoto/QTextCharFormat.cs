//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QTextCharFormat")]
	public class QTextCharFormat : QTextFormat, IDisposable {
 		protected QTextCharFormat(Type dummy) : base((Type) null) {}
		interface IQTextCharFormatProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextCharFormat), this);
			_interceptor = (QTextCharFormat) realProxy.GetTransparentProxy();
		}
		private QTextCharFormat ProxyQTextCharFormat() {
			return (QTextCharFormat) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextCharFormat() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextCharFormatProxy), null);
			_staticInterceptor = (IQTextCharFormatProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextCharFormatProxy StaticQTextCharFormat() {
			return (IQTextCharFormatProxy) _staticInterceptor;
		}

		public enum VerticalAlignment {
			AlignNormal = 0,
			AlignSuperScript = 1,
			AlignSubScript = 2,
		}
		public QTextCharFormat() : this((Type) null) {
			CreateProxy();
			NewQTextCharFormat();
		}
		[SmokeMethod("QTextCharFormat()")]
		private void NewQTextCharFormat() {
			ProxyQTextCharFormat().NewQTextCharFormat();
		}
		[SmokeMethod("isValid() const")]
		public new bool IsValid() {
			return ProxyQTextCharFormat().IsValid();
		}
		[SmokeMethod("setFont(const QFont&)")]
		public void SetFont(QFont font) {
			ProxyQTextCharFormat().SetFont(font);
		}
		[SmokeMethod("font() const")]
		public QFont Font() {
			return ProxyQTextCharFormat().Font();
		}
		[SmokeMethod("setFontFamily(const QString&)")]
		public void SetFontFamily(string family) {
			ProxyQTextCharFormat().SetFontFamily(family);
		}
		[SmokeMethod("fontFamily() const")]
		public string FontFamily() {
			return ProxyQTextCharFormat().FontFamily();
		}
		[SmokeMethod("setFontPointSize(qreal)")]
		public void SetFontPointSize(double size) {
			ProxyQTextCharFormat().SetFontPointSize(size);
		}
		[SmokeMethod("fontPointSize() const")]
		public double FontPointSize() {
			return ProxyQTextCharFormat().FontPointSize();
		}
		[SmokeMethod("setFontWeight(int)")]
		public void SetFontWeight(int weight) {
			ProxyQTextCharFormat().SetFontWeight(weight);
		}
		[SmokeMethod("fontWeight() const")]
		public int FontWeight() {
			return ProxyQTextCharFormat().FontWeight();
		}
		[SmokeMethod("setFontItalic(bool)")]
		public void SetFontItalic(bool italic) {
			ProxyQTextCharFormat().SetFontItalic(italic);
		}
		[SmokeMethod("fontItalic() const")]
		public bool FontItalic() {
			return ProxyQTextCharFormat().FontItalic();
		}
		[SmokeMethod("setFontUnderline(bool)")]
		public void SetFontUnderline(bool underline) {
			ProxyQTextCharFormat().SetFontUnderline(underline);
		}
		[SmokeMethod("fontUnderline() const")]
		public bool FontUnderline() {
			return ProxyQTextCharFormat().FontUnderline();
		}
		[SmokeMethod("setFontOverline(bool)")]
		public void SetFontOverline(bool overline) {
			ProxyQTextCharFormat().SetFontOverline(overline);
		}
		[SmokeMethod("fontOverline() const")]
		public bool FontOverline() {
			return ProxyQTextCharFormat().FontOverline();
		}
		[SmokeMethod("setFontStrikeOut(bool)")]
		public void SetFontStrikeOut(bool strikeOut) {
			ProxyQTextCharFormat().SetFontStrikeOut(strikeOut);
		}
		[SmokeMethod("fontStrikeOut() const")]
		public bool FontStrikeOut() {
			return ProxyQTextCharFormat().FontStrikeOut();
		}
		[SmokeMethod("setUnderlineColor(const QColor&)")]
		public void SetUnderlineColor(QColor color) {
			ProxyQTextCharFormat().SetUnderlineColor(color);
		}
		[SmokeMethod("underlineColor() const")]
		public QColor UnderlineColor() {
			return ProxyQTextCharFormat().UnderlineColor();
		}
		[SmokeMethod("setFontFixedPitch(bool)")]
		public void SetFontFixedPitch(bool fixedPitch) {
			ProxyQTextCharFormat().SetFontFixedPitch(fixedPitch);
		}
		[SmokeMethod("fontFixedPitch() const")]
		public bool FontFixedPitch() {
			return ProxyQTextCharFormat().FontFixedPitch();
		}
		[SmokeMethod("setVerticalAlignment(QTextCharFormat::VerticalAlignment)")]
		public void SetVerticalAlignment(QTextCharFormat.VerticalAlignment alignment) {
			ProxyQTextCharFormat().SetVerticalAlignment(alignment);
		}
		[SmokeMethod("verticalAlignment() const")]
		public QTextCharFormat.VerticalAlignment verticalAlignment() {
			return ProxyQTextCharFormat().verticalAlignment();
		}
		[SmokeMethod("setTextOutline(const QPen&)")]
		public void SetTextOutline(QPen pen) {
			ProxyQTextCharFormat().SetTextOutline(pen);
		}
		[SmokeMethod("textOutline() const")]
		public QPen TextOutline() {
			return ProxyQTextCharFormat().TextOutline();
		}
		[SmokeMethod("setAnchor(bool)")]
		public void SetAnchor(bool anchor) {
			ProxyQTextCharFormat().SetAnchor(anchor);
		}
		[SmokeMethod("isAnchor() const")]
		public bool IsAnchor() {
			return ProxyQTextCharFormat().IsAnchor();
		}
		[SmokeMethod("setAnchorHref(const QString&)")]
		public void SetAnchorHref(string value) {
			ProxyQTextCharFormat().SetAnchorHref(value);
		}
		[SmokeMethod("anchorHref() const")]
		public string AnchorHref() {
			return ProxyQTextCharFormat().AnchorHref();
		}
		[SmokeMethod("setAnchorName(const QString&)")]
		public void SetAnchorName(string name) {
			ProxyQTextCharFormat().SetAnchorName(name);
		}
		[SmokeMethod("anchorName() const")]
		public string AnchorName() {
			return ProxyQTextCharFormat().AnchorName();
		}
		[SmokeMethod("setTableCellRowSpan(int)")]
		public void SetTableCellRowSpan(int tableCellRowSpan) {
			ProxyQTextCharFormat().SetTableCellRowSpan(tableCellRowSpan);
		}
		[SmokeMethod("tableCellRowSpan() const")]
		public int TableCellRowSpan() {
			return ProxyQTextCharFormat().TableCellRowSpan();
		}
		[SmokeMethod("setTableCellColumnSpan(int)")]
		public void SetTableCellColumnSpan(int tableCellColumnSpan) {
			ProxyQTextCharFormat().SetTableCellColumnSpan(tableCellColumnSpan);
		}
		[SmokeMethod("tableCellColumnSpan() const")]
		public int TableCellColumnSpan() {
			return ProxyQTextCharFormat().TableCellColumnSpan();
		}
		~QTextCharFormat() {
			DisposeQTextCharFormat();
		}
		public void Dispose() {
			DisposeQTextCharFormat();
		}
		private void DisposeQTextCharFormat() {
			ProxyQTextCharFormat().DisposeQTextCharFormat();
		}
	}
}
