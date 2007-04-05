//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QCleanlooksStyle")]
	public class QCleanlooksStyle : QWindowsStyle, IDisposable {
 		protected QCleanlooksStyle(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QCleanlooksStyle), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QCleanlooksStyle() {
			staticInterceptor = new SmokeInvocation(typeof(QCleanlooksStyle), null);
		}
		public QCleanlooksStyle() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QCleanlooksStyle", "QCleanlooksStyle()", typeof(void));
		}
		[SmokeMethod("standardPalette() const")]
		public override QPalette StandardPalette() {
			return (QPalette) interceptor.Invoke("standardPalette", "standardPalette() const", typeof(QPalette));
		}
		[SmokeMethod("drawPrimitive(QStyle::PrimitiveElement, const QStyleOption*, QPainter*, const QWidget*) const")]
		public override void DrawPrimitive(QStyle.PrimitiveElement elem, int option, QPainter painter, QWidget widget) {
			interceptor.Invoke("drawPrimitive$###", "drawPrimitive(QStyle::PrimitiveElement, const QStyleOption*, QPainter*, const QWidget*) const", typeof(void), typeof(QStyle.PrimitiveElement), elem, typeof(int), option, typeof(QPainter), painter, typeof(QWidget), widget);
		}
		[SmokeMethod("drawPrimitive(QStyle::PrimitiveElement, const QStyleOption*, QPainter*) const")]
		public override void DrawPrimitive(QStyle.PrimitiveElement elem, int option, QPainter painter) {
			interceptor.Invoke("drawPrimitive$##", "drawPrimitive(QStyle::PrimitiveElement, const QStyleOption*, QPainter*) const", typeof(void), typeof(QStyle.PrimitiveElement), elem, typeof(int), option, typeof(QPainter), painter);
		}
		[SmokeMethod("drawControl(QStyle::ControlElement, const QStyleOption*, QPainter*, const QWidget*) const")]
		public override void DrawControl(QStyle.ControlElement ce, int option, QPainter painter, QWidget widget) {
			interceptor.Invoke("drawControl$###", "drawControl(QStyle::ControlElement, const QStyleOption*, QPainter*, const QWidget*) const", typeof(void), typeof(QStyle.ControlElement), ce, typeof(int), option, typeof(QPainter), painter, typeof(QWidget), widget);
		}
		[SmokeMethod("pixelMetric(QStyle::PixelMetric, const QStyleOption*, const QWidget*) const")]
		public override int pixelMetric(QStyle.PixelMetric metric, int option, QWidget widget) {
			return (int) interceptor.Invoke("pixelMetric$##", "pixelMetric(QStyle::PixelMetric, const QStyleOption*, const QWidget*) const", typeof(int), typeof(QStyle.PixelMetric), metric, typeof(int), option, typeof(QWidget), widget);
		}
		[SmokeMethod("pixelMetric(QStyle::PixelMetric, const QStyleOption*) const")]
		public override int pixelMetric(QStyle.PixelMetric metric, int option) {
			return (int) interceptor.Invoke("pixelMetric$#", "pixelMetric(QStyle::PixelMetric, const QStyleOption*) const", typeof(int), typeof(QStyle.PixelMetric), metric, typeof(int), option);
		}
		[SmokeMethod("pixelMetric(QStyle::PixelMetric) const")]
		public override int pixelMetric(QStyle.PixelMetric metric) {
			return (int) interceptor.Invoke("pixelMetric$", "pixelMetric(QStyle::PixelMetric) const", typeof(int), typeof(QStyle.PixelMetric), metric);
		}
		[SmokeMethod("drawComplexControl(QStyle::ComplexControl, const QStyleOptionComplex*, QPainter*, const QWidget*) const")]
		public override void DrawComplexControl(QStyle.ComplexControl control, QStyleOptionComplex option, QPainter painter, QWidget widget) {
			interceptor.Invoke("drawComplexControl$###", "drawComplexControl(QStyle::ComplexControl, const QStyleOptionComplex*, QPainter*, const QWidget*) const", typeof(void), typeof(QStyle.ComplexControl), control, typeof(QStyleOptionComplex), option, typeof(QPainter), painter, typeof(QWidget), widget);
		}
		[SmokeMethod("subElementRect(QStyle::SubElement, const QStyleOption*, const QWidget*) const")]
		public override QRect SubElementRect(QStyle.SubElement r, int opt, QWidget widget) {
			return (QRect) interceptor.Invoke("subElementRect$##", "subElementRect(QStyle::SubElement, const QStyleOption*, const QWidget*) const", typeof(QRect), typeof(QStyle.SubElement), r, typeof(int), opt, typeof(QWidget), widget);
		}
		[SmokeMethod("subElementRect(QStyle::SubElement, const QStyleOption*) const")]
		public override QRect SubElementRect(QStyle.SubElement r, int opt) {
			return (QRect) interceptor.Invoke("subElementRect$#", "subElementRect(QStyle::SubElement, const QStyleOption*) const", typeof(QRect), typeof(QStyle.SubElement), r, typeof(int), opt);
		}
		[SmokeMethod("sizeFromContents(QStyle::ContentsType, const QStyleOption*, const QSize&, const QWidget*) const")]
		public override QSize SizeFromContents(QStyle.ContentsType type, int option, QSize size, QWidget widget) {
			return (QSize) interceptor.Invoke("sizeFromContents$###", "sizeFromContents(QStyle::ContentsType, const QStyleOption*, const QSize&, const QWidget*) const", typeof(QSize), typeof(QStyle.ContentsType), type, typeof(int), option, typeof(QSize), size, typeof(QWidget), widget);
		}
		[SmokeMethod("hitTestComplexControl(QStyle::ComplexControl, const QStyleOptionComplex*, const QPoint&, const QWidget*) const")]
		public override QStyle.SubControl HitTestComplexControl(QStyle.ComplexControl cc, QStyleOptionComplex opt, QPoint pt, QWidget w) {
			return (QStyle.SubControl) interceptor.Invoke("hitTestComplexControl$###", "hitTestComplexControl(QStyle::ComplexControl, const QStyleOptionComplex*, const QPoint&, const QWidget*) const", typeof(QStyle.SubControl), typeof(QStyle.ComplexControl), cc, typeof(QStyleOptionComplex), opt, typeof(QPoint), pt, typeof(QWidget), w);
		}
		[SmokeMethod("hitTestComplexControl(QStyle::ComplexControl, const QStyleOptionComplex*, const QPoint&) const")]
		public override QStyle.SubControl HitTestComplexControl(QStyle.ComplexControl cc, QStyleOptionComplex opt, QPoint pt) {
			return (QStyle.SubControl) interceptor.Invoke("hitTestComplexControl$##", "hitTestComplexControl(QStyle::ComplexControl, const QStyleOptionComplex*, const QPoint&) const", typeof(QStyle.SubControl), typeof(QStyle.ComplexControl), cc, typeof(QStyleOptionComplex), opt, typeof(QPoint), pt);
		}
		[SmokeMethod("subControlRect(QStyle::ComplexControl, const QStyleOptionComplex*, QStyle::SubControl, const QWidget*) const")]
		public override QRect SubControlRect(QStyle.ComplexControl cc, QStyleOptionComplex opt, QStyle.SubControl sc, QWidget widget) {
			return (QRect) interceptor.Invoke("subControlRect$#$#", "subControlRect(QStyle::ComplexControl, const QStyleOptionComplex*, QStyle::SubControl, const QWidget*) const", typeof(QRect), typeof(QStyle.ComplexControl), cc, typeof(QStyleOptionComplex), opt, typeof(QStyle.SubControl), sc, typeof(QWidget), widget);
		}
		[SmokeMethod("generatedIconPixmap(QIcon::Mode, const QPixmap&, const QStyleOption*) const")]
		public override QPixmap GeneratedIconPixmap(QIcon.Mode iconMode, QPixmap pixmap, int opt) {
			return (QPixmap) interceptor.Invoke("generatedIconPixmap$##", "generatedIconPixmap(QIcon::Mode, const QPixmap&, const QStyleOption*) const", typeof(QPixmap), typeof(QIcon.Mode), iconMode, typeof(QPixmap), pixmap, typeof(int), opt);
		}
		[SmokeMethod("styleHint(QStyle::StyleHint, const QStyleOption*, const QWidget*, QStyleHintReturn*) const")]
		public override int styleHint(QStyle.StyleHint hint, int option, QWidget widget, QStyleHintReturn returnData) {
			return (int) interceptor.Invoke("styleHint$###", "styleHint(QStyle::StyleHint, const QStyleOption*, const QWidget*, QStyleHintReturn*) const", typeof(int), typeof(QStyle.StyleHint), hint, typeof(int), option, typeof(QWidget), widget, typeof(QStyleHintReturn), returnData);
		}
		[SmokeMethod("styleHint(QStyle::StyleHint, const QStyleOption*, const QWidget*) const")]
		public override int styleHint(QStyle.StyleHint hint, int option, QWidget widget) {
			return (int) interceptor.Invoke("styleHint$##", "styleHint(QStyle::StyleHint, const QStyleOption*, const QWidget*) const", typeof(int), typeof(QStyle.StyleHint), hint, typeof(int), option, typeof(QWidget), widget);
		}
		[SmokeMethod("styleHint(QStyle::StyleHint, const QStyleOption*) const")]
		public override int styleHint(QStyle.StyleHint hint, int option) {
			return (int) interceptor.Invoke("styleHint$#", "styleHint(QStyle::StyleHint, const QStyleOption*) const", typeof(int), typeof(QStyle.StyleHint), hint, typeof(int), option);
		}
		[SmokeMethod("styleHint(QStyle::StyleHint) const")]
		public override int styleHint(QStyle.StyleHint hint) {
			return (int) interceptor.Invoke("styleHint$", "styleHint(QStyle::StyleHint) const", typeof(int), typeof(QStyle.StyleHint), hint);
		}
		[SmokeMethod("itemPixmapRect(const QRect&, int, const QPixmap&) const")]
		public override QRect ItemPixmapRect(QRect r, int flags, QPixmap pixmap) {
			return (QRect) interceptor.Invoke("itemPixmapRect#$#", "itemPixmapRect(const QRect&, int, const QPixmap&) const", typeof(QRect), typeof(QRect), r, typeof(int), flags, typeof(QPixmap), pixmap);
		}
		[SmokeMethod("standardPixmap(QStyle::StandardPixmap, const QStyleOption*, const QWidget*) const")]
		public override QPixmap standardPixmap(QStyle.StandardPixmap standardPixmap, int opt, QWidget widget) {
			return (QPixmap) interceptor.Invoke("standardPixmap$##", "standardPixmap(QStyle::StandardPixmap, const QStyleOption*, const QWidget*) const", typeof(QPixmap), typeof(QStyle.StandardPixmap), standardPixmap, typeof(int), opt, typeof(QWidget), widget);
		}
		[SmokeMethod("standardPixmap(QStyle::StandardPixmap, const QStyleOption*) const")]
		public override QPixmap standardPixmap(QStyle.StandardPixmap standardPixmap, int opt) {
			return (QPixmap) interceptor.Invoke("standardPixmap$#", "standardPixmap(QStyle::StandardPixmap, const QStyleOption*) const", typeof(QPixmap), typeof(QStyle.StandardPixmap), standardPixmap, typeof(int), opt);
		}
		[SmokeMethod("drawItemPixmap(QPainter*, const QRect&, int, const QPixmap&) const")]
		public override void DrawItemPixmap(QPainter painter, QRect rect, int alignment, QPixmap pixmap) {
			interceptor.Invoke("drawItemPixmap##$#", "drawItemPixmap(QPainter*, const QRect&, int, const QPixmap&) const", typeof(void), typeof(QPainter), painter, typeof(QRect), rect, typeof(int), alignment, typeof(QPixmap), pixmap);
		}
		[SmokeMethod("drawItemText(QPainter*, const QRect&, int, const QPalette&, bool, const QString&, QPalette::ColorRole) const")]
		public override void DrawItemText(QPainter painter, QRect rect, int flags, QPalette pal, bool enabled, string text, QPalette.ColorRole textRole) {
			interceptor.Invoke("drawItemText##$#$$$", "drawItemText(QPainter*, const QRect&, int, const QPalette&, bool, const QString&, QPalette::ColorRole) const", typeof(void), typeof(QPainter), painter, typeof(QRect), rect, typeof(int), flags, typeof(QPalette), pal, typeof(bool), enabled, typeof(string), text, typeof(QPalette.ColorRole), textRole);
		}
		[SmokeMethod("drawItemText(QPainter*, const QRect&, int, const QPalette&, bool, const QString&) const")]
		public override void DrawItemText(QPainter painter, QRect rect, int flags, QPalette pal, bool enabled, string text) {
			interceptor.Invoke("drawItemText##$#$$", "drawItemText(QPainter*, const QRect&, int, const QPalette&, bool, const QString&) const", typeof(void), typeof(QPainter), painter, typeof(QRect), rect, typeof(int), flags, typeof(QPalette), pal, typeof(bool), enabled, typeof(string), text);
		}
		[SmokeMethod("polish(QWidget*)")]
		public override void Polish(QWidget widget) {
			interceptor.Invoke("polish#", "polish(QWidget*)", typeof(void), typeof(QWidget), widget);
		}
		[SmokeMethod("polish(QApplication*)")]
		public override void Polish(QApplication app) {
			interceptor.Invoke("polish#", "polish(QApplication*)", typeof(void), typeof(QApplication), app);
		}
		[SmokeMethod("polish(QPalette&)")]
		public override void Polish(QPalette pal) {
			interceptor.Invoke("polish#", "polish(QPalette&)", typeof(void), typeof(QPalette), pal);
		}
		[SmokeMethod("unpolish(QWidget*)")]
		public override void Unpolish(QWidget widget) {
			interceptor.Invoke("unpolish#", "unpolish(QWidget*)", typeof(void), typeof(QWidget), widget);
		}
		[SmokeMethod("unpolish(QApplication*)")]
		public override void Unpolish(QApplication app) {
			interceptor.Invoke("unpolish#", "unpolish(QApplication*)", typeof(void), typeof(QApplication), app);
		}
		[Q_SLOT("QIcon standardIconImplementation(QStyle::StandardPixmap, const QStyleOption*, const QWidget*) const")]
		protected QIcon StandardIconImplementation(QStyle.StandardPixmap standardIcon, int option, QWidget widget) {
			return (QIcon) interceptor.Invoke("standardIconImplementation$##", "standardIconImplementation(QStyle::StandardPixmap, const QStyleOption*, const QWidget*) const", typeof(QIcon), typeof(QStyle.StandardPixmap), standardIcon, typeof(int), option, typeof(QWidget), widget);
		}
		[Q_SLOT("QIcon standardIconImplementation(QStyle::StandardPixmap, const QStyleOption*) const")]
		protected QIcon StandardIconImplementation(QStyle.StandardPixmap standardIcon, int option) {
			return (QIcon) interceptor.Invoke("standardIconImplementation$#", "standardIconImplementation(QStyle::StandardPixmap, const QStyleOption*) const", typeof(QIcon), typeof(QStyle.StandardPixmap), standardIcon, typeof(int), option);
		}
		~QCleanlooksStyle() {
			interceptor.Invoke("~QCleanlooksStyle", "~QCleanlooksStyle()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QCleanlooksStyle", "~QCleanlooksStyle()", typeof(void));
		}
		public static string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQCleanlooksStyleSignals Emit {
			get { return (IQCleanlooksStyleSignals) Q_EMIT; }
		}
	}

	public interface IQCleanlooksStyleSignals : IQWindowsStyleSignals {
	}
}
