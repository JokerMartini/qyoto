//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;

	[SmokeClass("QColorGroup")]
	public class QColorGroup : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QColorGroup(Type dummy) {}
		interface IQColorGroupProxy {
			bool op_equals(QColorGroup lhs, QColorGroup g);
		}

		protected void CreateQColorGroupProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QColorGroup), this);
			_interceptor = (QColorGroup) realProxy.GetTransparentProxy();
		}
		private QColorGroup ProxyQColorGroup() {
			return (QColorGroup) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QColorGroup() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQColorGroupProxy), null);
			_staticInterceptor = (IQColorGroupProxy) realProxy.GetTransparentProxy();
		}
		private static IQColorGroupProxy StaticQColorGroup() {
			return (IQColorGroupProxy) _staticInterceptor;
		}

		public enum ColorRole {
			Foreground = 0,
			Button = 1,
			Light = 2,
			Midlight = 3,
			Dark = 4,
			Mid = 5,
			Text = 6,
			BrightText = 7,
			ButtonText = 8,
			Base = 9,
			Background = 10,
			Shadow = 11,
			Highlight = 12,
			HighlightedText = 13,
			Link = 14,
			LinkVisited = 15,
			NColorRoles = 16,
		}
		public QColorGroup() : this((Type) null) {
			CreateQColorGroupProxy();
			NewQColorGroup();
		}
		[SmokeMethod("QColorGroup()")]
		private void NewQColorGroup() {
			ProxyQColorGroup().NewQColorGroup();
		}
		public QColorGroup(QColor foreground, QColor button, QColor light, QColor dark, QColor mid, QColor text, QColor arg7) : this((Type) null) {
			CreateQColorGroupProxy();
			NewQColorGroup(foreground,button,light,dark,mid,text,arg7);
		}
		[SmokeMethod("QColorGroup(const QColor&, const QColor&, const QColor&, const QColor&, const QColor&, const QColor&, const QColor&)")]
		private void NewQColorGroup(QColor foreground, QColor button, QColor light, QColor dark, QColor mid, QColor text, QColor arg7) {
			ProxyQColorGroup().NewQColorGroup(foreground,button,light,dark,mid,text,arg7);
		}
		public QColorGroup(QBrush foreground, QBrush button, QBrush light, QBrush dark, QBrush mid, QBrush text, QBrush bright_text, QBrush arg8, QBrush background) : this((Type) null) {
			CreateQColorGroupProxy();
			NewQColorGroup(foreground,button,light,dark,mid,text,bright_text,arg8,background);
		}
		[SmokeMethod("QColorGroup(const QBrush&, const QBrush&, const QBrush&, const QBrush&, const QBrush&, const QBrush&, const QBrush&, const QBrush&, const QBrush&)")]
		private void NewQColorGroup(QBrush foreground, QBrush button, QBrush light, QBrush dark, QBrush mid, QBrush text, QBrush bright_text, QBrush arg8, QBrush background) {
			ProxyQColorGroup().NewQColorGroup(foreground,button,light,dark,mid,text,bright_text,arg8,background);
		}
		public QColorGroup(QColorGroup arg1) : this((Type) null) {
			CreateQColorGroupProxy();
			NewQColorGroup(arg1);
		}
		[SmokeMethod("QColorGroup(const QColorGroup&)")]
		private void NewQColorGroup(QColorGroup arg1) {
			ProxyQColorGroup().NewQColorGroup(arg1);
		}
		[SmokeMethod("color(QColorGroup::ColorRole) const")]
		public QColor Color(QColorGroup.ColorRole arg1) {
			return ProxyQColorGroup().Color(arg1);
		}
		[SmokeMethod("brush(QColorGroup::ColorRole) const")]
		public QBrush Brush(QColorGroup.ColorRole arg1) {
			return ProxyQColorGroup().Brush(arg1);
		}
		[SmokeMethod("setColor(QColorGroup::ColorRole, const QColor&)")]
		public void SetColor(QColorGroup.ColorRole arg1, QColor arg2) {
			ProxyQColorGroup().SetColor(arg1,arg2);
		}
		[SmokeMethod("setBrush(QColorGroup::ColorRole, const QBrush&)")]
		public void SetBrush(QColorGroup.ColorRole arg1, QBrush arg2) {
			ProxyQColorGroup().SetBrush(arg1,arg2);
		}
		[SmokeMethod("foreground() const")]
		public QColor Foreground() {
			return ProxyQColorGroup().Foreground();
		}
		[SmokeMethod("button() const")]
		public QColor Button() {
			return ProxyQColorGroup().Button();
		}
		[SmokeMethod("light() const")]
		public QColor Light() {
			return ProxyQColorGroup().Light();
		}
		[SmokeMethod("dark() const")]
		public QColor Dark() {
			return ProxyQColorGroup().Dark();
		}
		[SmokeMethod("mid() const")]
		public QColor Mid() {
			return ProxyQColorGroup().Mid();
		}
		[SmokeMethod("text() const")]
		public QColor Text() {
			return ProxyQColorGroup().Text();
		}
		[SmokeMethod("base() const")]
		public QColor Base() {
			return ProxyQColorGroup().Base();
		}
		[SmokeMethod("background() const")]
		public QColor Background() {
			return ProxyQColorGroup().Background();
		}
		[SmokeMethod("midlight() const")]
		public QColor Midlight() {
			return ProxyQColorGroup().Midlight();
		}
		[SmokeMethod("brightText() const")]
		public QColor BrightText() {
			return ProxyQColorGroup().BrightText();
		}
		[SmokeMethod("buttonText() const")]
		public QColor ButtonText() {
			return ProxyQColorGroup().ButtonText();
		}
		[SmokeMethod("shadow() const")]
		public QColor Shadow() {
			return ProxyQColorGroup().Shadow();
		}
		[SmokeMethod("highlight() const")]
		public QColor Highlight() {
			return ProxyQColorGroup().Highlight();
		}
		[SmokeMethod("highlightedText() const")]
		public QColor HighlightedText() {
			return ProxyQColorGroup().HighlightedText();
		}
		[SmokeMethod("link() const")]
		public QColor Link() {
			return ProxyQColorGroup().Link();
		}
		[SmokeMethod("linkVisited() const")]
		public QColor LinkVisited() {
			return ProxyQColorGroup().LinkVisited();
		}
		[SmokeMethod("operator==(const QColorGroup&) const")]
		public static bool operator==(QColorGroup lhs, QColorGroup g) {
			return StaticQColorGroup().op_equals(lhs,g);
		}
		public static bool operator!=(QColorGroup lhs, QColorGroup g) {
			return !StaticQColorGroup().op_equals(lhs,g);
		}
		public override bool Equals(object o) {
			if (!(o is QColorGroup)) { return false; }
			return this == (QColorGroup) o;
		}
		public override int GetHashCode() {
			return ProxyQColorGroup().GetHashCode();
		}
		~QColorGroup() {
			DisposeQColorGroup();
		}
		public void Dispose() {
			DisposeQColorGroup();
		}
		private void DisposeQColorGroup() {
			ProxyQColorGroup().DisposeQColorGroup();
		}
	}
}
