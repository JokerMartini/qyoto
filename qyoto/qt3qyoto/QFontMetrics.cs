//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QFontMetrics : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QFontMetrics(Type dummy) {}
		interface IQFontMetricsProxy {
		}

		protected void CreateQFontMetricsProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QFontMetrics), this);
			_interceptor = (QFontMetrics) realProxy.GetTransparentProxy();
		}
		private QFontMetrics ProxyQFontMetrics() {
			return (QFontMetrics) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QFontMetrics() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQFontMetricsProxy), null);
			_staticInterceptor = (IQFontMetricsProxy) realProxy.GetTransparentProxy();
		}
		private static IQFontMetricsProxy StaticQFontMetrics() {
			return (IQFontMetricsProxy) _staticInterceptor;
		}

		public QFontMetrics(QFont arg1) : this((Type) null) {
			CreateQFontMetricsProxy();
			NewQFontMetrics(arg1);
		}
		[SmokeMethod("QFontMetrics(const QFont&)")]
		private void NewQFontMetrics(QFont arg1) {
			ProxyQFontMetrics().NewQFontMetrics(arg1);
		}
		public QFontMetrics(QFont arg1, int arg2) : this((Type) null) {
			CreateQFontMetricsProxy();
			NewQFontMetrics(arg1,arg2);
		}
		[SmokeMethod("QFontMetrics(const QFont&, QFont::Script)")]
		private void NewQFontMetrics(QFont arg1, int arg2) {
			ProxyQFontMetrics().NewQFontMetrics(arg1,arg2);
		}
		public QFontMetrics(QFontMetrics arg1) : this((Type) null) {
			CreateQFontMetricsProxy();
			NewQFontMetrics(arg1);
		}
		[SmokeMethod("QFontMetrics(const QFontMetrics&)")]
		private void NewQFontMetrics(QFontMetrics arg1) {
			ProxyQFontMetrics().NewQFontMetrics(arg1);
		}
		[SmokeMethod("ascent() const")]
		public int Ascent() {
			return ProxyQFontMetrics().Ascent();
		}
		[SmokeMethod("descent() const")]
		public int Descent() {
			return ProxyQFontMetrics().Descent();
		}
		[SmokeMethod("height() const")]
		public int Height() {
			return ProxyQFontMetrics().Height();
		}
		[SmokeMethod("leading() const")]
		public int Leading() {
			return ProxyQFontMetrics().Leading();
		}
		[SmokeMethod("lineSpacing() const")]
		public int LineSpacing() {
			return ProxyQFontMetrics().LineSpacing();
		}
		[SmokeMethod("minLeftBearing() const")]
		public int MinLeftBearing() {
			return ProxyQFontMetrics().MinLeftBearing();
		}
		[SmokeMethod("minRightBearing() const")]
		public int MinRightBearing() {
			return ProxyQFontMetrics().MinRightBearing();
		}
		[SmokeMethod("maxWidth() const")]
		public int MaxWidth() {
			return ProxyQFontMetrics().MaxWidth();
		}
		[SmokeMethod("inFont(QChar) const")]
		public bool InFont(char arg1) {
			return ProxyQFontMetrics().InFont(arg1);
		}
		[SmokeMethod("leftBearing(QChar) const")]
		public int LeftBearing(char arg1) {
			return ProxyQFontMetrics().LeftBearing(arg1);
		}
		[SmokeMethod("rightBearing(QChar) const")]
		public int RightBearing(char arg1) {
			return ProxyQFontMetrics().RightBearing(arg1);
		}
		[SmokeMethod("width(const QString&, int) const")]
		public int Width(string arg1, int len) {
			return ProxyQFontMetrics().Width(arg1,len);
		}
		[SmokeMethod("width(const QString&) const")]
		public int Width(string arg1) {
			return ProxyQFontMetrics().Width(arg1);
		}
		[SmokeMethod("width(QChar) const")]
		public int Width(char arg1) {
			return ProxyQFontMetrics().Width(arg1);
		}
		[SmokeMethod("charWidth(const QString&, int) const")]
		public int CharWidth(string str, int pos) {
			return ProxyQFontMetrics().CharWidth(str,pos);
		}
		[SmokeMethod("boundingRect(const QString&, int) const")]
		public QRect BoundingRect(string arg1, int len) {
			return ProxyQFontMetrics().BoundingRect(arg1,len);
		}
		[SmokeMethod("boundingRect(const QString&) const")]
		public QRect BoundingRect(string arg1) {
			return ProxyQFontMetrics().BoundingRect(arg1);
		}
		[SmokeMethod("boundingRect(QChar) const")]
		public QRect BoundingRect(char arg1) {
			return ProxyQFontMetrics().BoundingRect(arg1);
		}
		// QRect boundingRect(int arg1,int arg2,int arg3,int arg4,int arg5,const QString& arg6,int arg7,int arg8,int* arg9,QTextParag** arg10); >>>> NOT CONVERTED
		[SmokeMethod("boundingRect(int, int, int, int, int, const QString&, int, int, int*) const")]
		public QRect BoundingRect(int x, int y, int w, int h, int flags, string str, int len, int tabstops, out int tabarray) {
			return ProxyQFontMetrics().BoundingRect(x,y,w,h,flags,str,len,tabstops,out tabarray);
		}
		[SmokeMethod("boundingRect(int, int, int, int, int, const QString&, int, int) const")]
		public QRect BoundingRect(int x, int y, int w, int h, int flags, string str, int len, int tabstops) {
			return ProxyQFontMetrics().BoundingRect(x,y,w,h,flags,str,len,tabstops);
		}
		[SmokeMethod("boundingRect(int, int, int, int, int, const QString&, int) const")]
		public QRect BoundingRect(int x, int y, int w, int h, int flags, string str, int len) {
			return ProxyQFontMetrics().BoundingRect(x,y,w,h,flags,str,len);
		}
		[SmokeMethod("boundingRect(int, int, int, int, int, const QString&) const")]
		public QRect BoundingRect(int x, int y, int w, int h, int flags, string str) {
			return ProxyQFontMetrics().BoundingRect(x,y,w,h,flags,str);
		}
		// QSize size(int arg1,const QString& arg2,int arg3,int arg4,int* arg5,QTextParag** arg6); >>>> NOT CONVERTED
		[SmokeMethod("size(int, const QString&, int, int, int*) const")]
		public QSize Size(int flags, string str, int len, int tabstops, out int tabarray) {
			return ProxyQFontMetrics().Size(flags,str,len,tabstops,out tabarray);
		}
		[SmokeMethod("size(int, const QString&, int, int) const")]
		public QSize Size(int flags, string str, int len, int tabstops) {
			return ProxyQFontMetrics().Size(flags,str,len,tabstops);
		}
		[SmokeMethod("size(int, const QString&, int) const")]
		public QSize Size(int flags, string str, int len) {
			return ProxyQFontMetrics().Size(flags,str,len);
		}
		[SmokeMethod("size(int, const QString&) const")]
		public QSize Size(int flags, string str) {
			return ProxyQFontMetrics().Size(flags,str);
		}
		[SmokeMethod("underlinePos() const")]
		public int UnderlinePos() {
			return ProxyQFontMetrics().UnderlinePos();
		}
		[SmokeMethod("overlinePos() const")]
		public int OverlinePos() {
			return ProxyQFontMetrics().OverlinePos();
		}
		[SmokeMethod("strikeOutPos() const")]
		public int StrikeOutPos() {
			return ProxyQFontMetrics().StrikeOutPos();
		}
		[SmokeMethod("lineWidth() const")]
		public int LineWidth() {
			return ProxyQFontMetrics().LineWidth();
		}
		~QFontMetrics() {
			DisposeQFontMetrics();
		}
		public void Dispose() {
			DisposeQFontMetrics();
		}
		private void DisposeQFontMetrics() {
			ProxyQFontMetrics().DisposeQFontMetrics();
		}
	}
}
