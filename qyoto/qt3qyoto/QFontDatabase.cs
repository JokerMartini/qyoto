//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Collections;
	using System.Text;

	[SmokeClass("QFontDatabase")]
	public class QFontDatabase : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QFontDatabase(Type dummy) {}
		interface IQFontDatabaseProxy {
			int[] StandardSizes();
			string ScriptName(QFont.Script arg1);
			string ScriptSample(QFont.Script arg1);
		}

		protected void CreateQFontDatabaseProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QFontDatabase), this);
			_interceptor = (QFontDatabase) realProxy.GetTransparentProxy();
		}
		private QFontDatabase ProxyQFontDatabase() {
			return (QFontDatabase) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QFontDatabase() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQFontDatabaseProxy), null);
			_staticInterceptor = (IQFontDatabaseProxy) realProxy.GetTransparentProxy();
		}
		private static IQFontDatabaseProxy StaticQFontDatabase() {
			return (IQFontDatabaseProxy) _staticInterceptor;
		}

		public QFontDatabase() : this((Type) null) {
			CreateQFontDatabaseProxy();
			NewQFontDatabase();
		}
		[SmokeMethod("QFontDatabase()")]
		private void NewQFontDatabase() {
			ProxyQFontDatabase().NewQFontDatabase();
		}
		[SmokeMethod("families() const")]
		public ArrayList Families() {
			return ProxyQFontDatabase().Families();
		}
		[SmokeMethod("families(QFont::Script) const")]
		public ArrayList Families(QFont.Script arg1) {
			return ProxyQFontDatabase().Families(arg1);
		}
		[SmokeMethod("styles(const QString&) const")]
		public ArrayList Styles(string arg1) {
			return ProxyQFontDatabase().Styles(arg1);
		}
		[SmokeMethod("pointSizes(const QString&, const QString&)")]
		public int[] PointSizes(string arg1, string arg2) {
			return ProxyQFontDatabase().PointSizes(arg1,arg2);
		}
		[SmokeMethod("pointSizes(const QString&)")]
		public int[] PointSizes(string arg1) {
			return ProxyQFontDatabase().PointSizes(arg1);
		}
		[SmokeMethod("smoothSizes(const QString&, const QString&)")]
		public int[] SmoothSizes(string arg1, string arg2) {
			return ProxyQFontDatabase().SmoothSizes(arg1,arg2);
		}
		[SmokeMethod("styleString(const QFont&)")]
		public string StyleString(QFont arg1) {
			return ProxyQFontDatabase().StyleString(arg1);
		}
		[SmokeMethod("font(const QString&, const QString&, int)")]
		public QFont Font(string arg1, string arg2, int arg3) {
			return ProxyQFontDatabase().Font(arg1,arg2,arg3);
		}
		[SmokeMethod("isBitmapScalable(const QString&, const QString&) const")]
		public bool IsBitmapScalable(string arg1, string arg2) {
			return ProxyQFontDatabase().IsBitmapScalable(arg1,arg2);
		}
		[SmokeMethod("isBitmapScalable(const QString&) const")]
		public bool IsBitmapScalable(string arg1) {
			return ProxyQFontDatabase().IsBitmapScalable(arg1);
		}
		[SmokeMethod("isSmoothlyScalable(const QString&, const QString&) const")]
		public bool IsSmoothlyScalable(string arg1, string arg2) {
			return ProxyQFontDatabase().IsSmoothlyScalable(arg1,arg2);
		}
		[SmokeMethod("isSmoothlyScalable(const QString&) const")]
		public bool IsSmoothlyScalable(string arg1) {
			return ProxyQFontDatabase().IsSmoothlyScalable(arg1);
		}
		[SmokeMethod("isScalable(const QString&, const QString&) const")]
		public bool IsScalable(string arg1, string arg2) {
			return ProxyQFontDatabase().IsScalable(arg1,arg2);
		}
		[SmokeMethod("isScalable(const QString&) const")]
		public bool IsScalable(string arg1) {
			return ProxyQFontDatabase().IsScalable(arg1);
		}
		[SmokeMethod("isFixedPitch(const QString&, const QString&) const")]
		public bool IsFixedPitch(string arg1, string arg2) {
			return ProxyQFontDatabase().IsFixedPitch(arg1,arg2);
		}
		[SmokeMethod("isFixedPitch(const QString&) const")]
		public bool IsFixedPitch(string arg1) {
			return ProxyQFontDatabase().IsFixedPitch(arg1);
		}
		[SmokeMethod("italic(const QString&, const QString&) const")]
		public bool Italic(string arg1, string arg2) {
			return ProxyQFontDatabase().Italic(arg1,arg2);
		}
		[SmokeMethod("bold(const QString&, const QString&) const")]
		public bool Bold(string arg1, string arg2) {
			return ProxyQFontDatabase().Bold(arg1,arg2);
		}
		[SmokeMethod("weight(const QString&, const QString&) const")]
		public int Weight(string arg1, string arg2) {
			return ProxyQFontDatabase().Weight(arg1,arg2);
		}
		[SmokeMethod("families(bool) const")]
		public ArrayList Families(bool arg1) {
			return ProxyQFontDatabase().Families(arg1);
		}
		[SmokeMethod("styles(const QString&, const QString&) const")]
		public ArrayList Styles(string arg1, string arg2) {
			return ProxyQFontDatabase().Styles(arg1,arg2);
		}
		[SmokeMethod("pointSizes(const QString&, const QString&, const QString&)")]
		public int[] PointSizes(string arg1, string arg2, string arg3) {
			return ProxyQFontDatabase().PointSizes(arg1,arg2,arg3);
		}
		[SmokeMethod("smoothSizes(const QString&, const QString&, const QString&)")]
		public int[] SmoothSizes(string arg1, string arg2, string arg3) {
			return ProxyQFontDatabase().SmoothSizes(arg1,arg2,arg3);
		}
		[SmokeMethod("font(const QString&, const QString&, int, const QString&)")]
		public QFont Font(string arg1, string arg2, int arg3, string arg4) {
			return ProxyQFontDatabase().Font(arg1,arg2,arg3,arg4);
		}
		[SmokeMethod("isBitmapScalable(const QString&, const QString&, const QString&) const")]
		public bool IsBitmapScalable(string arg1, string arg2, string arg3) {
			return ProxyQFontDatabase().IsBitmapScalable(arg1,arg2,arg3);
		}
		[SmokeMethod("isSmoothlyScalable(const QString&, const QString&, const QString&) const")]
		public bool IsSmoothlyScalable(string arg1, string arg2, string arg3) {
			return ProxyQFontDatabase().IsSmoothlyScalable(arg1,arg2,arg3);
		}
		[SmokeMethod("isScalable(const QString&, const QString&, const QString&) const")]
		public bool IsScalable(string arg1, string arg2, string arg3) {
			return ProxyQFontDatabase().IsScalable(arg1,arg2,arg3);
		}
		[SmokeMethod("isFixedPitch(const QString&, const QString&, const QString&) const")]
		public bool IsFixedPitch(string arg1, string arg2, string arg3) {
			return ProxyQFontDatabase().IsFixedPitch(arg1,arg2,arg3);
		}
		[SmokeMethod("italic(const QString&, const QString&, const QString&) const")]
		public bool Italic(string arg1, string arg2, string arg3) {
			return ProxyQFontDatabase().Italic(arg1,arg2,arg3);
		}
		[SmokeMethod("bold(const QString&, const QString&, const QString&) const")]
		public bool Bold(string arg1, string arg2, string arg3) {
			return ProxyQFontDatabase().Bold(arg1,arg2,arg3);
		}
		[SmokeMethod("weight(const QString&, const QString&, const QString&) const")]
		public int Weight(string arg1, string arg2, string arg3) {
			return ProxyQFontDatabase().Weight(arg1,arg2,arg3);
		}
		[SmokeMethod("standardSizes()")]
		public static int[] StandardSizes() {
			return StaticQFontDatabase().StandardSizes();
		}
		[SmokeMethod("scriptName(QFont::Script)")]
		public static string ScriptName(QFont.Script arg1) {
			return StaticQFontDatabase().ScriptName(arg1);
		}
		[SmokeMethod("scriptSample(QFont::Script)")]
		public static string ScriptSample(QFont.Script arg1) {
			return StaticQFontDatabase().ScriptSample(arg1);
		}
		~QFontDatabase() {
			DisposeQFontDatabase();
		}
		public void Dispose() {
			DisposeQFontDatabase();
		}
		private void DisposeQFontDatabase() {
			ProxyQFontDatabase().DisposeQFontDatabase();
		}
	}
}
