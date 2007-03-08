//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QSettings")]
	public class QSettings : QObject, IDisposable {
 		protected QSettings(Type dummy) : base((Type) null) {}
		[SmokeClass("QSettings")]
		interface IQSettingsProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
			[SmokeMethod("setSystemIniPath", "(const QString&)", "$")]
			void SetSystemIniPath(string dir);
			[SmokeMethod("setUserIniPath", "(const QString&)", "$")]
			void SetUserIniPath(string dir);
			[SmokeMethod("setPath", "(QSettings::Format, QSettings::Scope, const QString&)", "$$$")]
			void SetPath(QSettings.Format format, QSettings.Scope scope, string path);
		}
		protected new void CreateProxy() {
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
		public enum Status {
			NoError = 0,
			AccessError = 1,
			FormatError = 2,
		}
		public enum Format {
			NativeFormat = 0,
			IniFormat = 1,
			InvalidFormat = 16,
			CustomFormat1 = 17,
			CustomFormat2 = 18,
			CustomFormat3 = 19,
			CustomFormat4 = 20,
			CustomFormat5 = 21,
			CustomFormat6 = 22,
			CustomFormat7 = 23,
			CustomFormat8 = 24,
			CustomFormat9 = 25,
			CustomFormat10 = 26,
			CustomFormat11 = 27,
			CustomFormat12 = 28,
			CustomFormat13 = 29,
			CustomFormat14 = 30,
			CustomFormat15 = 31,
			CustomFormat16 = 32,
		}
		public enum Scope {
			UserScope = 0,
			SystemScope = 1,
		}
		public QSettings(string organization, string application, QObject parent) : this((Type) null) {
			CreateProxy();
			NewQSettings(organization,application,parent);
		}
		[SmokeMethod("QSettings", "(const QString&, const QString&, QObject*)", "$$#")]
		private void NewQSettings(string organization, string application, QObject parent) {
			ProxyQSettings().NewQSettings(organization,application,parent);
		}
		public QSettings(string organization, string application) : this((Type) null) {
			CreateProxy();
			NewQSettings(organization,application);
		}
		[SmokeMethod("QSettings", "(const QString&, const QString&)", "$$")]
		private void NewQSettings(string organization, string application) {
			ProxyQSettings().NewQSettings(organization,application);
		}
		public QSettings(string organization) : this((Type) null) {
			CreateProxy();
			NewQSettings(organization);
		}
		[SmokeMethod("QSettings", "(const QString&)", "$")]
		private void NewQSettings(string organization) {
			ProxyQSettings().NewQSettings(organization);
		}
		public QSettings(QSettings.Scope scope, string organization, string application, QObject parent) : this((Type) null) {
			CreateProxy();
			NewQSettings(scope,organization,application,parent);
		}
		[SmokeMethod("QSettings", "(QSettings::Scope, const QString&, const QString&, QObject*)", "$$$#")]
		private void NewQSettings(QSettings.Scope scope, string organization, string application, QObject parent) {
			ProxyQSettings().NewQSettings(scope,organization,application,parent);
		}
		public QSettings(QSettings.Scope scope, string organization, string application) : this((Type) null) {
			CreateProxy();
			NewQSettings(scope,organization,application);
		}
		[SmokeMethod("QSettings", "(QSettings::Scope, const QString&, const QString&)", "$$$")]
		private void NewQSettings(QSettings.Scope scope, string organization, string application) {
			ProxyQSettings().NewQSettings(scope,organization,application);
		}
		public QSettings(QSettings.Scope scope, string organization) : this((Type) null) {
			CreateProxy();
			NewQSettings(scope,organization);
		}
		[SmokeMethod("QSettings", "(QSettings::Scope, const QString&)", "$$")]
		private void NewQSettings(QSettings.Scope scope, string organization) {
			ProxyQSettings().NewQSettings(scope,organization);
		}
		public QSettings(QSettings.Format format, QSettings.Scope scope, string organization, string application, QObject parent) : this((Type) null) {
			CreateProxy();
			NewQSettings(format,scope,organization,application,parent);
		}
		[SmokeMethod("QSettings", "(QSettings::Format, QSettings::Scope, const QString&, const QString&, QObject*)", "$$$$#")]
		private void NewQSettings(QSettings.Format format, QSettings.Scope scope, string organization, string application, QObject parent) {
			ProxyQSettings().NewQSettings(format,scope,organization,application,parent);
		}
		public QSettings(QSettings.Format format, QSettings.Scope scope, string organization, string application) : this((Type) null) {
			CreateProxy();
			NewQSettings(format,scope,organization,application);
		}
		[SmokeMethod("QSettings", "(QSettings::Format, QSettings::Scope, const QString&, const QString&)", "$$$$")]
		private void NewQSettings(QSettings.Format format, QSettings.Scope scope, string organization, string application) {
			ProxyQSettings().NewQSettings(format,scope,organization,application);
		}
		public QSettings(QSettings.Format format, QSettings.Scope scope, string organization) : this((Type) null) {
			CreateProxy();
			NewQSettings(format,scope,organization);
		}
		[SmokeMethod("QSettings", "(QSettings::Format, QSettings::Scope, const QString&)", "$$$")]
		private void NewQSettings(QSettings.Format format, QSettings.Scope scope, string organization) {
			ProxyQSettings().NewQSettings(format,scope,organization);
		}
		public QSettings(string fileName, QSettings.Format format, QObject parent) : this((Type) null) {
			CreateProxy();
			NewQSettings(fileName,format,parent);
		}
		[SmokeMethod("QSettings", "(const QString&, QSettings::Format, QObject*)", "$$#")]
		private void NewQSettings(string fileName, QSettings.Format format, QObject parent) {
			ProxyQSettings().NewQSettings(fileName,format,parent);
		}
		public QSettings(string fileName, QSettings.Format format) : this((Type) null) {
			CreateProxy();
			NewQSettings(fileName,format);
		}
		[SmokeMethod("QSettings", "(const QString&, QSettings::Format)", "$$")]
		private void NewQSettings(string fileName, QSettings.Format format) {
			ProxyQSettings().NewQSettings(fileName,format);
		}
		public QSettings(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQSettings(parent);
		}
		[SmokeMethod("QSettings", "(QObject*)", "#")]
		private void NewQSettings(QObject parent) {
			ProxyQSettings().NewQSettings(parent);
		}
		public QSettings() : this((Type) null) {
			CreateProxy();
			NewQSettings();
		}
		[SmokeMethod("QSettings", "()", "")]
		private void NewQSettings() {
			ProxyQSettings().NewQSettings();
		}
		[SmokeMethod("clear", "()", "")]
		public void Clear() {
			ProxyQSettings().Clear();
		}
		[SmokeMethod("sync", "()", "")]
		public void Sync() {
			ProxyQSettings().Sync();
		}
		[SmokeMethod("status", "() const", "")]
		public QSettings.Status status() {
			return ProxyQSettings().status();
		}
		[SmokeMethod("beginGroup", "(const QString&)", "$")]
		public void BeginGroup(string prefix) {
			ProxyQSettings().BeginGroup(prefix);
		}
		[SmokeMethod("endGroup", "()", "")]
		public void EndGroup() {
			ProxyQSettings().EndGroup();
		}
		[SmokeMethod("group", "() const", "")]
		public string Group() {
			return ProxyQSettings().Group();
		}
		[SmokeMethod("beginReadArray", "(const QString&)", "$")]
		public int BeginReadArray(string prefix) {
			return ProxyQSettings().BeginReadArray(prefix);
		}
		[SmokeMethod("beginWriteArray", "(const QString&, int)", "$$")]
		public void BeginWriteArray(string prefix, int size) {
			ProxyQSettings().BeginWriteArray(prefix,size);
		}
		[SmokeMethod("beginWriteArray", "(const QString&)", "$")]
		public void BeginWriteArray(string prefix) {
			ProxyQSettings().BeginWriteArray(prefix);
		}
		[SmokeMethod("endArray", "()", "")]
		public void EndArray() {
			ProxyQSettings().EndArray();
		}
		[SmokeMethod("setArrayIndex", "(int)", "$")]
		public void SetArrayIndex(int i) {
			ProxyQSettings().SetArrayIndex(i);
		}
		[SmokeMethod("allKeys", "() const", "")]
		public List<string> AllKeys() {
			return ProxyQSettings().AllKeys();
		}
		[SmokeMethod("childKeys", "() const", "")]
		public List<string> ChildKeys() {
			return ProxyQSettings().ChildKeys();
		}
		[SmokeMethod("childGroups", "() const", "")]
		public List<string> ChildGroups() {
			return ProxyQSettings().ChildGroups();
		}
		[SmokeMethod("isWritable", "() const", "")]
		public bool IsWritable() {
			return ProxyQSettings().IsWritable();
		}
		[SmokeMethod("setValue", "(const QString&, const QVariant&)", "$#")]
		public void SetValue(string key, QVariant value) {
			ProxyQSettings().SetValue(key,value);
		}
		[SmokeMethod("value", "(const QString&, const QVariant&) const", "$#")]
		public QVariant Value(string key, QVariant defaultValue) {
			return ProxyQSettings().Value(key,defaultValue);
		}
		[SmokeMethod("value", "(const QString&) const", "$")]
		public QVariant Value(string key) {
			return ProxyQSettings().Value(key);
		}
		[SmokeMethod("remove", "(const QString&)", "$")]
		public void Remove(string key) {
			ProxyQSettings().Remove(key);
		}
		[SmokeMethod("contains", "(const QString&) const", "$")]
		public bool Contains(string key) {
			return ProxyQSettings().Contains(key);
		}
		[SmokeMethod("setFallbacksEnabled", "(bool)", "$")]
		public void SetFallbacksEnabled(bool b) {
			ProxyQSettings().SetFallbacksEnabled(b);
		}
		[SmokeMethod("fallbacksEnabled", "() const", "")]
		public bool FallbacksEnabled() {
			return ProxyQSettings().FallbacksEnabled();
		}
		[SmokeMethod("fileName", "() const", "")]
		public string FileName() {
			return ProxyQSettings().FileName();
		}
		public static string Tr(string s, string c) {
			return StaticQSettings().Tr(s,c);
		}
		public static string Tr(string s) {
			return StaticQSettings().Tr(s);
		}
		public static void SetSystemIniPath(string dir) {
			StaticQSettings().SetSystemIniPath(dir);
		}
		public static void SetUserIniPath(string dir) {
			StaticQSettings().SetUserIniPath(dir);
		}
		public static void SetPath(QSettings.Format format, QSettings.Scope scope, string path) {
			StaticQSettings().SetPath(format,scope,path);
		}
		// QSettings::Format registerFormat(const QString& arg1,ReadFunc arg2,WriteFunc arg3,Qt::CaseSensitivity arg4); >>>> NOT CONVERTED
		// QSettings::Format registerFormat(const QString& arg1,ReadFunc arg2,WriteFunc arg3); >>>> NOT CONVERTED
		[SmokeMethod("event", "(QEvent*)", "#")]
		public override bool Event(QEvent arg1) {
			return ProxyQSettings().Event(arg1);
		}
		~QSettings() {
			DisposeQSettings();
		}
		public new void Dispose() {
			DisposeQSettings();
		}
		[SmokeMethod("~QSettings", "()", "")]
		private void DisposeQSettings() {
			ProxyQSettings().DisposeQSettings();
		}
		protected new IQSettingsSignals Emit {
			get { return (IQSettingsSignals) Q_EMIT; }
		}
	}

	public interface IQSettingsSignals : IQObjectSignals {
	}
}
