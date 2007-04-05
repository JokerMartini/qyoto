//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QFont")]
	public class QFont : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QFont(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QFont), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QFont() {
			staticInterceptor = new SmokeInvocation(typeof(QFont), null);
		}
		public enum StyleHint {
			Helvetica = 0,
			SansSerif = Helvetica,
			Times = 1,
			Serif = Times,
			Courier = 2,
			TypeWriter = Courier,
			OldEnglish = 3,
			Decorative = OldEnglish,
			System = 4,
			AnyStyle = 5,
		}
		public enum StyleStrategy {
			PreferDefault = 0x0001,
			PreferBitmap = 0x0002,
			PreferDevice = 0x0004,
			PreferOutline = 0x0008,
			ForceOutline = 0x0010,
			PreferMatch = 0x0020,
			PreferQuality = 0x0040,
			PreferAntialias = 0x0080,
			NoAntialias = 0x0100,
			OpenGLCompatible = 0x0200,
			NoFontMerging = 0x8000,
		}
		public enum Weight {
			Light = 25,
			Normal = 50,
			DemiBold = 63,
			Bold = 75,
			Black = 87,
		}
		public enum Style {
			StyleNormal = 0,
			StyleItalic = 1,
			StyleOblique = 2,
		}
		public enum Stretch {
			UltraCondensed = 50,
			ExtraCondensed = 62,
			Condensed = 75,
			SemiCondensed = 87,
			Unstretched = 100,
			SemiExpanded = 112,
			Expanded = 125,
			ExtraExpanded = 150,
			UltraExpanded = 200,
		}
		//  operator QVariant(); >>>> NOT CONVERTED
		public QFont() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFont", "QFont()", typeof(void));
		}
		public QFont(string family, int pointSize, int weight, bool italic) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFont$$$$", "QFont(const QString&, int, int, bool)", typeof(void), typeof(string), family, typeof(int), pointSize, typeof(int), weight, typeof(bool), italic);
		}
		public QFont(string family, int pointSize, int weight) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFont$$$", "QFont(const QString&, int, int)", typeof(void), typeof(string), family, typeof(int), pointSize, typeof(int), weight);
		}
		public QFont(string family, int pointSize) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFont$$", "QFont(const QString&, int)", typeof(void), typeof(string), family, typeof(int), pointSize);
		}
		public QFont(string family) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFont$", "QFont(const QString&)", typeof(void), typeof(string), family);
		}
		public QFont(QFont arg1, IQPaintDevice pd) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFont##", "QFont(const QFont&, QPaintDevice*)", typeof(void), typeof(QFont), arg1, typeof(IQPaintDevice), pd);
		}
		public QFont(QFont arg1) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFont#", "QFont(const QFont&)", typeof(void), typeof(QFont), arg1);
		}
		public string Family() {
			return (string) interceptor.Invoke("family", "family() const", typeof(string));
		}
		public void SetFamily(string arg1) {
			interceptor.Invoke("setFamily$", "setFamily(const QString&)", typeof(void), typeof(string), arg1);
		}
		public int PointSize() {
			return (int) interceptor.Invoke("pointSize", "pointSize() const", typeof(int));
		}
		public void SetPointSize(int arg1) {
			interceptor.Invoke("setPointSize$", "setPointSize(int)", typeof(void), typeof(int), arg1);
		}
		public double PointSizeF() {
			return (double) interceptor.Invoke("pointSizeF", "pointSizeF() const", typeof(double));
		}
		public void SetPointSizeF(double arg1) {
			interceptor.Invoke("setPointSizeF$", "setPointSizeF(qreal)", typeof(void), typeof(double), arg1);
		}
		public int PixelSize() {
			return (int) interceptor.Invoke("pixelSize", "pixelSize() const", typeof(int));
		}
		public void SetPixelSize(int arg1) {
			interceptor.Invoke("setPixelSize$", "setPixelSize(int)", typeof(void), typeof(int), arg1);
		}
		public int weight() {
			return (int) interceptor.Invoke("weight", "weight() const", typeof(int));
		}
		public void SetWeight(int arg1) {
			interceptor.Invoke("setWeight$", "setWeight(int)", typeof(void), typeof(int), arg1);
		}
		public bool Bold() {
			return (bool) interceptor.Invoke("bold", "bold() const", typeof(bool));
		}
		public void SetBold(bool arg1) {
			interceptor.Invoke("setBold$", "setBold(bool)", typeof(void), typeof(bool), arg1);
		}
		public void SetStyle(QFont.Style style) {
			interceptor.Invoke("setStyle$", "setStyle(QFont::Style)", typeof(void), typeof(QFont.Style), style);
		}
		public QFont.Style style() {
			return (QFont.Style) interceptor.Invoke("style", "style() const", typeof(QFont.Style));
		}
		public bool Italic() {
			return (bool) interceptor.Invoke("italic", "italic() const", typeof(bool));
		}
		public void SetItalic(bool b) {
			interceptor.Invoke("setItalic$", "setItalic(bool)", typeof(void), typeof(bool), b);
		}
		public bool Underline() {
			return (bool) interceptor.Invoke("underline", "underline() const", typeof(bool));
		}
		public void SetUnderline(bool arg1) {
			interceptor.Invoke("setUnderline$", "setUnderline(bool)", typeof(void), typeof(bool), arg1);
		}
		public bool Overline() {
			return (bool) interceptor.Invoke("overline", "overline() const", typeof(bool));
		}
		public void SetOverline(bool arg1) {
			interceptor.Invoke("setOverline$", "setOverline(bool)", typeof(void), typeof(bool), arg1);
		}
		public bool StrikeOut() {
			return (bool) interceptor.Invoke("strikeOut", "strikeOut() const", typeof(bool));
		}
		public void SetStrikeOut(bool arg1) {
			interceptor.Invoke("setStrikeOut$", "setStrikeOut(bool)", typeof(void), typeof(bool), arg1);
		}
		public bool FixedPitch() {
			return (bool) interceptor.Invoke("fixedPitch", "fixedPitch() const", typeof(bool));
		}
		public void SetFixedPitch(bool arg1) {
			interceptor.Invoke("setFixedPitch$", "setFixedPitch(bool)", typeof(void), typeof(bool), arg1);
		}
		public bool Kerning() {
			return (bool) interceptor.Invoke("kerning", "kerning() const", typeof(bool));
		}
		public void SetKerning(bool arg1) {
			interceptor.Invoke("setKerning$", "setKerning(bool)", typeof(void), typeof(bool), arg1);
		}
		public QFont.StyleHint styleHint() {
			return (QFont.StyleHint) interceptor.Invoke("styleHint", "styleHint() const", typeof(QFont.StyleHint));
		}
		public QFont.StyleStrategy styleStrategy() {
			return (QFont.StyleStrategy) interceptor.Invoke("styleStrategy", "styleStrategy() const", typeof(QFont.StyleStrategy));
		}
		public void SetStyleHint(QFont.StyleHint arg1, QFont.StyleStrategy arg2) {
			interceptor.Invoke("setStyleHint$$", "setStyleHint(QFont::StyleHint, QFont::StyleStrategy)", typeof(void), typeof(QFont.StyleHint), arg1, typeof(QFont.StyleStrategy), arg2);
		}
		public void SetStyleHint(QFont.StyleHint arg1) {
			interceptor.Invoke("setStyleHint$", "setStyleHint(QFont::StyleHint)", typeof(void), typeof(QFont.StyleHint), arg1);
		}
		public void SetStyleStrategy(QFont.StyleStrategy s) {
			interceptor.Invoke("setStyleStrategy$", "setStyleStrategy(QFont::StyleStrategy)", typeof(void), typeof(QFont.StyleStrategy), s);
		}
		public int stretch() {
			return (int) interceptor.Invoke("stretch", "stretch() const", typeof(int));
		}
		public void SetStretch(int arg1) {
			interceptor.Invoke("setStretch$", "setStretch(int)", typeof(void), typeof(int), arg1);
		}
		public bool RawMode() {
			return (bool) interceptor.Invoke("rawMode", "rawMode() const", typeof(bool));
		}
		public void SetRawMode(bool arg1) {
			interceptor.Invoke("setRawMode$", "setRawMode(bool)", typeof(void), typeof(bool), arg1);
		}
		public bool ExactMatch() {
			return (bool) interceptor.Invoke("exactMatch", "exactMatch() const", typeof(bool));
		}
		public override bool Equals(object o) {
			if (!(o is QFont)) { return false; }
			return this == (QFont) o;
		}
		public override int GetHashCode() {
			return interceptor.GetHashCode();
		}
		public bool IsCopyOf(QFont arg1) {
			return (bool) interceptor.Invoke("isCopyOf#", "isCopyOf(const QFont&) const", typeof(bool), typeof(QFont), arg1);
		}
		public void SetRawName(string arg1) {
			interceptor.Invoke("setRawName$", "setRawName(const QString&)", typeof(void), typeof(string), arg1);
		}
		public string RawName() {
			return (string) interceptor.Invoke("rawName", "rawName() const", typeof(string));
		}
		public string Key() {
			return (string) interceptor.Invoke("key", "key() const", typeof(string));
		}
		public string ToString() {
			return (string) interceptor.Invoke("toString", "toString() const", typeof(string));
		}
		public bool FromString(string arg1) {
			return (bool) interceptor.Invoke("fromString$", "fromString(const QString&)", typeof(bool), typeof(string), arg1);
		}
		public string DefaultFamily() {
			return (string) interceptor.Invoke("defaultFamily", "defaultFamily() const", typeof(string));
		}
		public string LastResortFamily() {
			return (string) interceptor.Invoke("lastResortFamily", "lastResortFamily() const", typeof(string));
		}
		public string LastResortFont() {
			return (string) interceptor.Invoke("lastResortFont", "lastResortFont() const", typeof(string));
		}
		public QFont Resolve(QFont arg1) {
			return (QFont) interceptor.Invoke("resolve#", "resolve(const QFont&) const", typeof(QFont), typeof(QFont), arg1);
		}
		public uint Resolve() {
			return (uint) interceptor.Invoke("resolve", "resolve() const", typeof(uint));
		}
		public void Resolve(uint mask) {
			interceptor.Invoke("resolve$", "resolve(uint)", typeof(void), typeof(uint), mask);
		}
		~QFont() {
			interceptor.Invoke("~QFont", "~QFont()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QFont", "~QFont()", typeof(void));
		}
		public static bool operator==(QFont lhs, QFont arg1) {
			return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QFont&) const", typeof(bool), typeof(QFont), lhs, typeof(QFont), arg1);
		}
		public static bool operator!=(QFont lhs, QFont arg1) {
			return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QFont&) const", typeof(bool), typeof(QFont), lhs, typeof(QFont), arg1);
		}
		public static bool operator<(QFont lhs, QFont arg1) {
			return (bool) staticInterceptor.Invoke("operator<#", "operator<(const QFont&) const", typeof(bool), typeof(QFont), lhs, typeof(QFont), arg1);
		}
		public static bool operator>(QFont lhs, QFont arg1) {
			return !(bool) staticInterceptor.Invoke("operator<#", "operator<(const QFont&) const", typeof(bool), typeof(QFont), lhs, typeof(QFont), arg1)
						&& !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QFont&) const", typeof(bool), typeof(QFont), lhs, typeof(QFont), arg1);
		}
		public static string Substitute(string arg1) {
			return (string) staticInterceptor.Invoke("substitute$", "substitute(const QString&)", typeof(string), typeof(string), arg1);
		}
		public static List<string> Substitutes(string arg1) {
			return (List<string>) staticInterceptor.Invoke("substitutes$", "substitutes(const QString&)", typeof(List<string>), typeof(string), arg1);
		}
		public static List<string> Substitutions() {
			return (List<string>) staticInterceptor.Invoke("substitutions", "substitutions()", typeof(List<string>));
		}
		public static void InsertSubstitution(string arg1, string arg2) {
			staticInterceptor.Invoke("insertSubstitution$$", "insertSubstitution(const QString&, const QString&)", typeof(void), typeof(string), arg1, typeof(string), arg2);
		}
		public static void InsertSubstitutions(string arg1, List<string> arg2) {
			staticInterceptor.Invoke("insertSubstitutions$?", "insertSubstitutions(const QString&, const QStringList&)", typeof(void), typeof(string), arg1, typeof(List<string>), arg2);
		}
		public static void RemoveSubstitution(string arg1) {
			staticInterceptor.Invoke("removeSubstitution$", "removeSubstitution(const QString&)", typeof(void), typeof(string), arg1);
		}
		public static void Initialize() {
			staticInterceptor.Invoke("initialize", "initialize()", typeof(void));
		}
		public static void Cleanup() {
			staticInterceptor.Invoke("cleanup", "cleanup()", typeof(void));
		}
		public static void CacheStatistics() {
			staticInterceptor.Invoke("cacheStatistics", "cacheStatistics()", typeof(void));
		}
	}
}
