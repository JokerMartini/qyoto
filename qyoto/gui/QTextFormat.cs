//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QTextFormat")]
	public class QTextFormat : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QTextFormat(Type dummy) {}
		[SmokeClass("QTextFormat")]
		interface IQTextFormatProxy {
			[SmokeMethod("operator==", "(const QTextFormat&) const", "#")]
			bool op_equals(QTextFormat lhs, QTextFormat rhs);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTextFormat), this);
			_interceptor = (QTextFormat) realProxy.GetTransparentProxy();
		}
		private QTextFormat ProxyQTextFormat() {
			return (QTextFormat) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTextFormat() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTextFormatProxy), null);
			_staticInterceptor = (IQTextFormatProxy) realProxy.GetTransparentProxy();
		}
		private static IQTextFormatProxy StaticQTextFormat() {
			return (IQTextFormatProxy) _staticInterceptor;
		}
		public enum FormatType {
			InvalidFormat = -1,
			BlockFormat = 1,
			CharFormat = 2,
			ListFormat = 3,
			TableFormat = 4,
			FrameFormat = 5,
			UserFormat = 100,
		}
		public enum Property {
			ObjectIndex = 0x0,
			CssFloat = 0x0800,
			LayoutDirection = 0x0801,
			OutlinePen = 0x810,
			BackgroundBrush = 0x820,
			ForegroundBrush = 0x821,
			BlockAlignment = 0x1010,
			BlockTopMargin = 0x1030,
			BlockBottomMargin = 0x1031,
			BlockLeftMargin = 0x1032,
			BlockRightMargin = 0x1033,
			TextIndent = 0x1034,
			BlockIndent = 0x1040,
			BlockNonBreakableLines = 0x1050,
			BlockTrailingHorizontalRulerWidth = 0x1060,
			FontFamily = 0x2000,
			FontPointSize = 0x2001,
			FontSizeAdjustment = 0x2002,
			FontSizeIncrement = FontSizeAdjustment,
			FontWeight = 0x2003,
			FontItalic = 0x2004,
			FontUnderline = 0x2005,
			FontOverline = 0x2006,
			FontStrikeOut = 0x2007,
			FontFixedPitch = 0x2008,
			FontPixelSize = 0x2009,
			TextUnderlineColor = 0x2010,
			TextVerticalAlignment = 0x2021,
			TextOutline = 0x2022,
			TextUnderlineStyle = 0x2023,
			IsAnchor = 0x2030,
			AnchorHref = 0x2031,
			AnchorName = 0x2032,
			ObjectType = 0x2f00,
			ListStyle = 0x3000,
			ListIndent = 0x3001,
			FrameBorder = 0x4000,
			FrameMargin = 0x4001,
			FramePadding = 0x4002,
			FrameWidth = 0x4003,
			FrameHeight = 0x4004,
			TableColumns = 0x4100,
			TableColumnWidthConstraints = 0x4101,
			TableCellSpacing = 0x4102,
			TableCellPadding = 0x4103,
			TableHeaderRowCount = 0x4104,
			TableCellRowSpan = 0x4810,
			TableCellColumnSpan = 0x4811,
			ImageName = 0x5000,
			ImageWidth = 0x5010,
			ImageHeight = 0x5011,
			FullWidthSelection = 0x06000,
			PageBreakPolicy = 0x7000,
			UserProperty = 0x100000,
		}
		public enum ObjectTypes {
			NoObject = 0,
			ImageObject = 1,
			TableObject = 2,
			UserObject = 0x1000,
		}
		public enum PageBreakFlag {
			PageBreak_Auto = 0,
			PageBreak_AlwaysBefore = 0x001,
			PageBreak_AlwaysAfter = 0x010,
		}
		public QTextFormat() : this((Type) null) {
			CreateProxy();
			NewQTextFormat();
		}
		[SmokeMethod("QTextFormat", "()", "")]
		private void NewQTextFormat() {
			ProxyQTextFormat().NewQTextFormat();
		}
		public QTextFormat(int type) : this((Type) null) {
			CreateProxy();
			NewQTextFormat(type);
		}
		[SmokeMethod("QTextFormat", "(int)", "$")]
		private void NewQTextFormat(int type) {
			ProxyQTextFormat().NewQTextFormat(type);
		}
		public QTextFormat(QTextFormat rhs) : this((Type) null) {
			CreateProxy();
			NewQTextFormat(rhs);
		}
		[SmokeMethod("QTextFormat", "(const QTextFormat&)", "#")]
		private void NewQTextFormat(QTextFormat rhs) {
			ProxyQTextFormat().NewQTextFormat(rhs);
		}
		[SmokeMethod("merge", "(const QTextFormat&)", "#")]
		public void Merge(QTextFormat other) {
			ProxyQTextFormat().Merge(other);
		}
		[SmokeMethod("isValid", "() const", "")]
		public bool IsValid() {
			return ProxyQTextFormat().IsValid();
		}
		[SmokeMethod("type", "() const", "")]
		public int type() {
			return ProxyQTextFormat().type();
		}
		[SmokeMethod("objectIndex", "() const", "")]
		public int ObjectIndex() {
			return ProxyQTextFormat().ObjectIndex();
		}
		[SmokeMethod("setObjectIndex", "(int)", "$")]
		public void SetObjectIndex(int arg1) {
			ProxyQTextFormat().SetObjectIndex(arg1);
		}
		[SmokeMethod("property", "(int) const", "$")]
		public QVariant property(int propertyId) {
			return ProxyQTextFormat().property(propertyId);
		}
		[SmokeMethod("setProperty", "(int, const QVariant&)", "$#")]
		public void SetProperty(int propertyId, QVariant value) {
			ProxyQTextFormat().SetProperty(propertyId,value);
		}
		[SmokeMethod("clearProperty", "(int)", "$")]
		public void ClearProperty(int propertyId) {
			ProxyQTextFormat().ClearProperty(propertyId);
		}
		[SmokeMethod("hasProperty", "(int) const", "$")]
		public bool HasProperty(int propertyId) {
			return ProxyQTextFormat().HasProperty(propertyId);
		}
		[SmokeMethod("boolProperty", "(int) const", "$")]
		public bool BoolProperty(int propertyId) {
			return ProxyQTextFormat().BoolProperty(propertyId);
		}
		[SmokeMethod("intProperty", "(int) const", "$")]
		public int IntProperty(int propertyId) {
			return ProxyQTextFormat().IntProperty(propertyId);
		}
		[SmokeMethod("doubleProperty", "(int) const", "$")]
		public double DoubleProperty(int propertyId) {
			return ProxyQTextFormat().DoubleProperty(propertyId);
		}
		[SmokeMethod("stringProperty", "(int) const", "$")]
		public string StringProperty(int propertyId) {
			return ProxyQTextFormat().StringProperty(propertyId);
		}
		[SmokeMethod("colorProperty", "(int) const", "$")]
		public QColor ColorProperty(int propertyId) {
			return ProxyQTextFormat().ColorProperty(propertyId);
		}
		[SmokeMethod("penProperty", "(int) const", "$")]
		public QPen PenProperty(int propertyId) {
			return ProxyQTextFormat().PenProperty(propertyId);
		}
		[SmokeMethod("brushProperty", "(int) const", "$")]
		public QBrush BrushProperty(int propertyId) {
			return ProxyQTextFormat().BrushProperty(propertyId);
		}
		[SmokeMethod("lengthProperty", "(int) const", "$")]
		public QTextLength LengthProperty(int propertyId) {
			return ProxyQTextFormat().LengthProperty(propertyId);
		}
		[SmokeMethod("lengthVectorProperty", "(int) const", "$")]
		public List<QTextLength> LengthVectorProperty(int propertyId) {
			return ProxyQTextFormat().LengthVectorProperty(propertyId);
		}
		[SmokeMethod("setProperty", "(int, const QVector<QTextLength>&)", "$?")]
		public void SetProperty(int propertyId, List<QTextLength> lengths) {
			ProxyQTextFormat().SetProperty(propertyId,lengths);
		}
		[SmokeMethod("properties", "() const", "")]
		public Dictionary<int, QVariant> Properties() {
			return ProxyQTextFormat().Properties();
		}
		[SmokeMethod("setObjectType", "(int)", "$")]
		public void SetObjectType(int type) {
			ProxyQTextFormat().SetObjectType(type);
		}
		[SmokeMethod("objectType", "() const", "")]
		public int ObjectType() {
			return ProxyQTextFormat().ObjectType();
		}
		[SmokeMethod("isCharFormat", "() const", "")]
		public bool IsCharFormat() {
			return ProxyQTextFormat().IsCharFormat();
		}
		[SmokeMethod("isBlockFormat", "() const", "")]
		public bool IsBlockFormat() {
			return ProxyQTextFormat().IsBlockFormat();
		}
		[SmokeMethod("isListFormat", "() const", "")]
		public bool IsListFormat() {
			return ProxyQTextFormat().IsListFormat();
		}
		[SmokeMethod("isFrameFormat", "() const", "")]
		public bool IsFrameFormat() {
			return ProxyQTextFormat().IsFrameFormat();
		}
		[SmokeMethod("isImageFormat", "() const", "")]
		public bool IsImageFormat() {
			return ProxyQTextFormat().IsImageFormat();
		}
		[SmokeMethod("isTableFormat", "() const", "")]
		public bool IsTableFormat() {
			return ProxyQTextFormat().IsTableFormat();
		}
		[SmokeMethod("toBlockFormat", "() const", "")]
		public QTextBlockFormat ToBlockFormat() {
			return ProxyQTextFormat().ToBlockFormat();
		}
		[SmokeMethod("toCharFormat", "() const", "")]
		public QTextCharFormat ToCharFormat() {
			return ProxyQTextFormat().ToCharFormat();
		}
		[SmokeMethod("toListFormat", "() const", "")]
		public QTextListFormat ToListFormat() {
			return ProxyQTextFormat().ToListFormat();
		}
		[SmokeMethod("toTableFormat", "() const", "")]
		public QTextTableFormat ToTableFormat() {
			return ProxyQTextFormat().ToTableFormat();
		}
		[SmokeMethod("toFrameFormat", "() const", "")]
		public QTextFrameFormat ToFrameFormat() {
			return ProxyQTextFormat().ToFrameFormat();
		}
		[SmokeMethod("toImageFormat", "() const", "")]
		public QTextImageFormat ToImageFormat() {
			return ProxyQTextFormat().ToImageFormat();
		}
		public static bool operator==(QTextFormat lhs, QTextFormat rhs) {
			return StaticQTextFormat().op_equals(lhs,rhs);
		}
		public static bool operator!=(QTextFormat lhs, QTextFormat rhs) {
			return !StaticQTextFormat().op_equals(lhs,rhs);
		}
		public override bool Equals(object o) {
			if (!(o is QTextFormat)) { return false; }
			return this == (QTextFormat) o;
		}
		public override int GetHashCode() {
			return ProxyQTextFormat().GetHashCode();
		}
		//  operator QVariant(); >>>> NOT CONVERTED
		[SmokeMethod("setLayoutDirection", "(Qt::LayoutDirection)", "$")]
		public void SetLayoutDirection(Qt.LayoutDirection direction) {
			ProxyQTextFormat().SetLayoutDirection(direction);
		}
		[SmokeMethod("layoutDirection", "() const", "")]
		public Qt.LayoutDirection LayoutDirection() {
			return ProxyQTextFormat().LayoutDirection();
		}
		[SmokeMethod("setBackground", "(const QBrush&)", "#")]
		public void SetBackground(QBrush brush) {
			ProxyQTextFormat().SetBackground(brush);
		}
		[SmokeMethod("background", "() const", "")]
		public QBrush Background() {
			return ProxyQTextFormat().Background();
		}
		[SmokeMethod("clearBackground", "()", "")]
		public void ClearBackground() {
			ProxyQTextFormat().ClearBackground();
		}
		[SmokeMethod("setForeground", "(const QBrush&)", "#")]
		public void SetForeground(QBrush brush) {
			ProxyQTextFormat().SetForeground(brush);
		}
		[SmokeMethod("foreground", "() const", "")]
		public QBrush Foreground() {
			return ProxyQTextFormat().Foreground();
		}
		[SmokeMethod("clearForeground", "()", "")]
		public void ClearForeground() {
			ProxyQTextFormat().ClearForeground();
		}
		~QTextFormat() {
			DisposeQTextFormat();
		}
		public void Dispose() {
			DisposeQTextFormat();
		}
		[SmokeMethod("~QTextFormat", "()", "")]
		private void DisposeQTextFormat() {
			ProxyQTextFormat().DisposeQTextFormat();
		}
	}
}
