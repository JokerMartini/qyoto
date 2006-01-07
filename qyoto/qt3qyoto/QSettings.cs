//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Collections;
	using System.Text;

	[SmokeClass("QSettings")]
	public class QSettings : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QSettings(Type dummy) {}
		interface IQSettingsProxy {
		}

		protected void CreateQSettingsProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSettings), this);
			_interceptor = (QSettings) realProxy.GetTransparentProxy();
		}
		private QSettings ProxyQSettings() {
			return (QSettings) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSettings() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSettingsProxy), null);
			_staticInterceptor = (IQSettingsProxy) realProxy.GetTransparentProxy();
		}
		private static IQSettingsProxy StaticQSettings() {
			return (IQSettingsProxy) _staticInterceptor;
		}

		public enum Format {
			Native = 0,
			Ini = 1,
		}
		public enum System {
			Unix = 0,
			Windows = 1,
			Mac = 2,
		}
		public enum Scope {
			User = 0,
			Global = 1,
		}
		public QSettings() : this((Type) null) {
			CreateQSettingsProxy();
			NewQSettings();
		}
		[SmokeMethod("QSettings()")]
		private void NewQSettings() {
			ProxyQSettings().NewQSettings();
		}
		public QSettings(QSettings.Format format) : this((Type) null) {
			CreateQSettingsProxy();
			NewQSettings(format);
		}
		[SmokeMethod("QSettings(QSettings::Format)")]
		private void NewQSettings(QSettings.Format format) {
			ProxyQSettings().NewQSettings(format);
		}
		[SmokeMethod("writeEntry(const QString&, bool)")]
		public bool WriteEntry(string arg1, bool arg2) {
			return ProxyQSettings().WriteEntry(arg1,arg2);
		}
		[SmokeMethod("writeEntry(const QString&, double)")]
		public bool WriteEntry(string arg1, double arg2) {
			return ProxyQSettings().WriteEntry(arg1,arg2);
		}
		[SmokeMethod("writeEntry(const QString&, int)")]
		public bool WriteEntry(string arg1, int arg2) {
			return ProxyQSettings().WriteEntry(arg1,arg2);
		}
		[SmokeMethod("writeEntry(const QString&, const char*)")]
		public bool WriteEntry(string arg1, string arg2) {
			return ProxyQSettings().WriteEntry(arg1,arg2);
		}
		[SmokeMethod("writeEntry(const QString&, const QStringList&)")]
		public bool WriteEntry(string arg1, string[] arg2) {
			return ProxyQSettings().WriteEntry(arg1,arg2);
		}
		[SmokeMethod("writeEntry(const QString&, const QStringList&, const QChar&)")]
		public bool WriteEntry(string arg1, string[] arg2, char sep) {
			return ProxyQSettings().WriteEntry(arg1,arg2,sep);
		}
		[SmokeMethod("entryList(const QString&) const")]
		public ArrayList EntryList(string arg1) {
			return ProxyQSettings().EntryList(arg1);
		}
		[SmokeMethod("subkeyList(const QString&) const")]
		public ArrayList SubkeyList(string arg1) {
			return ProxyQSettings().SubkeyList(arg1);
		}
		[SmokeMethod("readListEntry(const QString&, bool*)")]
		public ArrayList ReadListEntry(string arg1, out bool arg2) {
			return ProxyQSettings().ReadListEntry(arg1,out arg2);
		}
		[SmokeMethod("readListEntry(const QString&)")]
		public ArrayList ReadListEntry(string arg1) {
			return ProxyQSettings().ReadListEntry(arg1);
		}
		[SmokeMethod("readListEntry(const QString&, const QChar&, bool*)")]
		public ArrayList ReadListEntry(string arg1, char sep, out bool arg3) {
			return ProxyQSettings().ReadListEntry(arg1,sep,out arg3);
		}
		[SmokeMethod("readListEntry(const QString&, const QChar&)")]
		public ArrayList ReadListEntry(string arg1, char sep) {
			return ProxyQSettings().ReadListEntry(arg1,sep);
		}
		[SmokeMethod("readEntry(const QString&, const QString&, bool*)")]
		public string ReadEntry(string arg1, string def, out bool arg3) {
			return ProxyQSettings().ReadEntry(arg1,def,out arg3);
		}
		[SmokeMethod("readEntry(const QString&, const QString&)")]
		public string ReadEntry(string arg1, string def) {
			return ProxyQSettings().ReadEntry(arg1,def);
		}
		[SmokeMethod("readEntry(const QString&)")]
		public string ReadEntry(string arg1) {
			return ProxyQSettings().ReadEntry(arg1);
		}
		[SmokeMethod("readNumEntry(const QString&, int, bool*)")]
		public int ReadNumEntry(string arg1, int def, out bool arg3) {
			return ProxyQSettings().ReadNumEntry(arg1,def,out arg3);
		}
		[SmokeMethod("readNumEntry(const QString&, int)")]
		public int ReadNumEntry(string arg1, int def) {
			return ProxyQSettings().ReadNumEntry(arg1,def);
		}
		[SmokeMethod("readNumEntry(const QString&)")]
		public int ReadNumEntry(string arg1) {
			return ProxyQSettings().ReadNumEntry(arg1);
		}
		[SmokeMethod("readDoubleEntry(const QString&, double, bool*)")]
		public double ReadDoubleEntry(string arg1, double def, out bool arg3) {
			return ProxyQSettings().ReadDoubleEntry(arg1,def,out arg3);
		}
		[SmokeMethod("readDoubleEntry(const QString&, double)")]
		public double ReadDoubleEntry(string arg1, double def) {
			return ProxyQSettings().ReadDoubleEntry(arg1,def);
		}
		[SmokeMethod("readDoubleEntry(const QString&)")]
		public double ReadDoubleEntry(string arg1) {
			return ProxyQSettings().ReadDoubleEntry(arg1);
		}
		[SmokeMethod("readBoolEntry(const QString&, bool, bool*)")]
		public bool ReadBoolEntry(string arg1, bool def, out bool arg3) {
			return ProxyQSettings().ReadBoolEntry(arg1,def,out arg3);
		}
		[SmokeMethod("readBoolEntry(const QString&, bool)")]
		public bool ReadBoolEntry(string arg1, bool def) {
			return ProxyQSettings().ReadBoolEntry(arg1,def);
		}
		[SmokeMethod("readBoolEntry(const QString&)")]
		public bool ReadBoolEntry(string arg1) {
			return ProxyQSettings().ReadBoolEntry(arg1);
		}
		[SmokeMethod("removeEntry(const QString&)")]
		public bool RemoveEntry(string arg1) {
			return ProxyQSettings().RemoveEntry(arg1);
		}
		[SmokeMethod("insertSearchPath(QSettings::System, const QString&)")]
		public void InsertSearchPath(QSettings.System arg1, string arg2) {
			ProxyQSettings().InsertSearchPath(arg1,arg2);
		}
		[SmokeMethod("removeSearchPath(QSettings::System, const QString&)")]
		public void RemoveSearchPath(QSettings.System arg1, string arg2) {
			ProxyQSettings().RemoveSearchPath(arg1,arg2);
		}
		[SmokeMethod("setPath(const QString&, const QString&, QSettings::Scope)")]
		public void SetPath(string domain, string product, QSettings.Scope arg3) {
			ProxyQSettings().SetPath(domain,product,arg3);
		}
		[SmokeMethod("setPath(const QString&, const QString&)")]
		public void SetPath(string domain, string product) {
			ProxyQSettings().SetPath(domain,product);
		}
		[SmokeMethod("beginGroup(const QString&)")]
		public void BeginGroup(string group) {
			ProxyQSettings().BeginGroup(group);
		}
		[SmokeMethod("endGroup()")]
		public void EndGroup() {
			ProxyQSettings().EndGroup();
		}
		[SmokeMethod("resetGroup()")]
		public void ResetGroup() {
			ProxyQSettings().ResetGroup();
		}
		[SmokeMethod("group() const")]
		public string Group() {
			return ProxyQSettings().Group();
		}
		[SmokeMethod("sync()")]
		public bool Sync() {
			return ProxyQSettings().Sync();
		}
		~QSettings() {
			DisposeQSettings();
		}
		public void Dispose() {
			DisposeQSettings();
		}
		private void DisposeQSettings() {
			ProxyQSettings().DisposeQSettings();
		}
	}
}
