//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	using System.Collections.Generic;
	[SmokeClass("QTextCharFormat")]
	public class QTextCharFormat : QTextFormat, IDisposable {
 		protected QTextCharFormat(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QTextCharFormat), this);
		}
		public enum VerticalAlignment {
			AlignNormal = 0,
			AlignSuperScript = 1,
			AlignSubScript = 2,
			AlignMiddle = 3,
			AlignTop = 4,
			AlignBottom = 5,
		}
		public enum UnderlineStyle {
			NoUnderline = 0,
			SingleUnderline = 1,
			DashUnderline = 2,
			DotLine = 3,
			DashDotLine = 4,
			DashDotDotLine = 5,
			WaveUnderline = 6,
			SpellCheckUnderline = 7,
		}
		public QTextCharFormat() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTextCharFormat", "QTextCharFormat()", typeof(void));
		}
		public new bool IsValid() {
			return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
		}
		public void SetFont(QFont font) {
			interceptor.Invoke("setFont#", "setFont(const QFont&)", typeof(void), typeof(QFont), font);
		}
		public QFont Font() {
			return (QFont) interceptor.Invoke("font", "font() const", typeof(QFont));
		}
		public void SetFontFamily(string family) {
			interceptor.Invoke("setFontFamily$", "setFontFamily(const QString&)", typeof(void), typeof(string), family);
		}
		public string FontFamily() {
			return (string) interceptor.Invoke("fontFamily", "fontFamily() const", typeof(string));
		}
		public void SetFontPointSize(double size) {
			interceptor.Invoke("setFontPointSize$", "setFontPointSize(qreal)", typeof(void), typeof(double), size);
		}
		public double FontPointSize() {
			return (double) interceptor.Invoke("fontPointSize", "fontPointSize() const", typeof(double));
		}
		public void SetFontWeight(int weight) {
			interceptor.Invoke("setFontWeight$", "setFontWeight(int)", typeof(void), typeof(int), weight);
		}
		public int FontWeight() {
			return (int) interceptor.Invoke("fontWeight", "fontWeight() const", typeof(int));
		}
		public void SetFontItalic(bool italic) {
			interceptor.Invoke("setFontItalic$", "setFontItalic(bool)", typeof(void), typeof(bool), italic);
		}
		public bool FontItalic() {
			return (bool) interceptor.Invoke("fontItalic", "fontItalic() const", typeof(bool));
		}
		public void SetFontCapitalization(QFont.Capitalization capitalization) {
			interceptor.Invoke("setFontCapitalization$", "setFontCapitalization(QFont::Capitalization)", typeof(void), typeof(QFont.Capitalization), capitalization);
		}
		public QFont.Capitalization FontCapitalization() {
			return (QFont.Capitalization) interceptor.Invoke("fontCapitalization", "fontCapitalization() const", typeof(QFont.Capitalization));
		}
		public void SetFontLetterSpacing(double spacing) {
			interceptor.Invoke("setFontLetterSpacing$", "setFontLetterSpacing(qreal)", typeof(void), typeof(double), spacing);
		}
		public double FontLetterSpacing() {
			return (double) interceptor.Invoke("fontLetterSpacing", "fontLetterSpacing() const", typeof(double));
		}
		public void SetFontWordSpacing(double spacing) {
			interceptor.Invoke("setFontWordSpacing$", "setFontWordSpacing(qreal)", typeof(void), typeof(double), spacing);
		}
		public double FontWordSpacing() {
			return (double) interceptor.Invoke("fontWordSpacing", "fontWordSpacing() const", typeof(double));
		}
		public void SetFontUnderline(bool underline) {
			interceptor.Invoke("setFontUnderline$", "setFontUnderline(bool)", typeof(void), typeof(bool), underline);
		}
		public bool FontUnderline() {
			return (bool) interceptor.Invoke("fontUnderline", "fontUnderline() const", typeof(bool));
		}
		public void SetFontOverline(bool overline) {
			interceptor.Invoke("setFontOverline$", "setFontOverline(bool)", typeof(void), typeof(bool), overline);
		}
		public bool FontOverline() {
			return (bool) interceptor.Invoke("fontOverline", "fontOverline() const", typeof(bool));
		}
		public void SetFontStrikeOut(bool strikeOut) {
			interceptor.Invoke("setFontStrikeOut$", "setFontStrikeOut(bool)", typeof(void), typeof(bool), strikeOut);
		}
		public bool FontStrikeOut() {
			return (bool) interceptor.Invoke("fontStrikeOut", "fontStrikeOut() const", typeof(bool));
		}
		public void SetUnderlineColor(QColor color) {
			interceptor.Invoke("setUnderlineColor#", "setUnderlineColor(const QColor&)", typeof(void), typeof(QColor), color);
		}
		public QColor UnderlineColor() {
			return (QColor) interceptor.Invoke("underlineColor", "underlineColor() const", typeof(QColor));
		}
		public void SetFontFixedPitch(bool fixedPitch) {
			interceptor.Invoke("setFontFixedPitch$", "setFontFixedPitch(bool)", typeof(void), typeof(bool), fixedPitch);
		}
		public bool FontFixedPitch() {
			return (bool) interceptor.Invoke("fontFixedPitch", "fontFixedPitch() const", typeof(bool));
		}
		public void SetUnderlineStyle(QTextCharFormat.UnderlineStyle style) {
			interceptor.Invoke("setUnderlineStyle$", "setUnderlineStyle(QTextCharFormat::UnderlineStyle)", typeof(void), typeof(QTextCharFormat.UnderlineStyle), style);
		}
		public QTextCharFormat.UnderlineStyle underlineStyle() {
			return (QTextCharFormat.UnderlineStyle) interceptor.Invoke("underlineStyle", "underlineStyle() const", typeof(QTextCharFormat.UnderlineStyle));
		}
		public void SetVerticalAlignment(QTextCharFormat.VerticalAlignment alignment) {
			interceptor.Invoke("setVerticalAlignment$", "setVerticalAlignment(QTextCharFormat::VerticalAlignment)", typeof(void), typeof(QTextCharFormat.VerticalAlignment), alignment);
		}
		public QTextCharFormat.VerticalAlignment verticalAlignment() {
			return (QTextCharFormat.VerticalAlignment) interceptor.Invoke("verticalAlignment", "verticalAlignment() const", typeof(QTextCharFormat.VerticalAlignment));
		}
		public void SetTextOutline(QPen pen) {
			interceptor.Invoke("setTextOutline#", "setTextOutline(const QPen&)", typeof(void), typeof(QPen), pen);
		}
		public QPen TextOutline() {
			return (QPen) interceptor.Invoke("textOutline", "textOutline() const", typeof(QPen));
		}
		public void SetToolTip(string tip) {
			interceptor.Invoke("setToolTip$", "setToolTip(const QString&)", typeof(void), typeof(string), tip);
		}
		public string ToolTip() {
			return (string) interceptor.Invoke("toolTip", "toolTip() const", typeof(string));
		}
		public void SetAnchor(bool anchor) {
			interceptor.Invoke("setAnchor$", "setAnchor(bool)", typeof(void), typeof(bool), anchor);
		}
		public bool IsAnchor() {
			return (bool) interceptor.Invoke("isAnchor", "isAnchor() const", typeof(bool));
		}
		public void SetAnchorHref(string value) {
			interceptor.Invoke("setAnchorHref$", "setAnchorHref(const QString&)", typeof(void), typeof(string), value);
		}
		public string AnchorHref() {
			return (string) interceptor.Invoke("anchorHref", "anchorHref() const", typeof(string));
		}
		public void SetAnchorName(string name) {
			interceptor.Invoke("setAnchorName$", "setAnchorName(const QString&)", typeof(void), typeof(string), name);
		}
		public string AnchorName() {
			return (string) interceptor.Invoke("anchorName", "anchorName() const", typeof(string));
		}
		public void SetAnchorNames(List<string> names) {
			interceptor.Invoke("setAnchorNames?", "setAnchorNames(const QStringList&)", typeof(void), typeof(List<string>), names);
		}
		public List<string> AnchorNames() {
			return (List<string>) interceptor.Invoke("anchorNames", "anchorNames() const", typeof(List<string>));
		}
		public void SetTableCellRowSpan(int tableCellRowSpan) {
			interceptor.Invoke("setTableCellRowSpan$", "setTableCellRowSpan(int)", typeof(void), typeof(int), tableCellRowSpan);
		}
		public int TableCellRowSpan() {
			return (int) interceptor.Invoke("tableCellRowSpan", "tableCellRowSpan() const", typeof(int));
		}
		public void SetTableCellColumnSpan(int tableCellColumnSpan) {
			interceptor.Invoke("setTableCellColumnSpan$", "setTableCellColumnSpan(int)", typeof(void), typeof(int), tableCellColumnSpan);
		}
		public int TableCellColumnSpan() {
			return (int) interceptor.Invoke("tableCellColumnSpan", "tableCellColumnSpan() const", typeof(int));
		}
		public QTextCharFormat(QTextFormat fmt) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QTextCharFormat#", "QTextCharFormat(const QTextFormat&)", typeof(void), typeof(QTextFormat), fmt);
		}
		~QTextCharFormat() {
			interceptor.Invoke("~QTextCharFormat", "~QTextCharFormat()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QTextCharFormat", "~QTextCharFormat()", typeof(void));
		}
	}
}
