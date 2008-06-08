//Auto-generated by kalyptus. DO NOT EDIT.
namespace KNS {

	using Kimono;
	using System;
	using Qyoto;

	/// <remarks>
	///  The installation class stores all information related to an entry's
	///  installation. However, the installation itself is performed by the
	///  engine.
	///  </remarks>		<author> Josef Spillner (spillner@kde.org)
	/// </author>
	/// 		<short> KNewStuff entry installation. </short>

	[SmokeClass("KNS::Installation")]
	public class Installation : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected Installation(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocationKDE(typeof(Installation), this);
		}
		public enum Policy {
			CheckNever = 0,
			CheckIfPossible = 1,
			CheckAlways = 2,
		}
		public enum Scope {
			ScopeUser = 0,
			ScopeSystem = 1,
		}
		/// <remarks>
		///  Constructor.
		///      </remarks>		<short>    Constructor.</short>
		public Installation() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Installation", "Installation()", typeof(void));
		}
		public void SetUncompression(string uncompression) {
			interceptor.Invoke("setUncompression$", "setUncompression(const QString&)", typeof(void), typeof(string), uncompression);
		}
		public void SetCommand(string command) {
			interceptor.Invoke("setCommand$", "setCommand(const QString&)", typeof(void), typeof(string), command);
		}
		public void SetStandardResourceDir(string dir) {
			interceptor.Invoke("setStandardResourceDir$", "setStandardResourceDir(const QString&)", typeof(void), typeof(string), dir);
		}
		public void SetTargetDir(string dir) {
			interceptor.Invoke("setTargetDir$", "setTargetDir(const QString&)", typeof(void), typeof(string), dir);
		}
		public void SetInstallPath(string dir) {
			interceptor.Invoke("setInstallPath$", "setInstallPath(const QString&)", typeof(void), typeof(string), dir);
		}
		public void SetAbsoluteInstallPath(string dir) {
			interceptor.Invoke("setAbsoluteInstallPath$", "setAbsoluteInstallPath(const QString&)", typeof(void), typeof(string), dir);
		}
		public void SetScope(KNS.Installation.Scope scope) {
			interceptor.Invoke("setScope$", "setScope(KNS::Installation::Scope)", typeof(void), typeof(KNS.Installation.Scope), scope);
		}
		public void SetChecksumPolicy(KNS.Installation.Policy policy) {
			interceptor.Invoke("setChecksumPolicy$", "setChecksumPolicy(KNS::Installation::Policy)", typeof(void), typeof(KNS.Installation.Policy), policy);
		}
		public void SetSignaturePolicy(KNS.Installation.Policy policy) {
			interceptor.Invoke("setSignaturePolicy$", "setSignaturePolicy(KNS::Installation::Policy)", typeof(void), typeof(KNS.Installation.Policy), policy);
		}
		public void SetCustomName(bool customname) {
			interceptor.Invoke("setCustomName$", "setCustomName(bool)", typeof(void), typeof(bool), customname);
		}
		public string Uncompression() {
			return (string) interceptor.Invoke("uncompression", "uncompression() const", typeof(string));
		}
		public string Command() {
			return (string) interceptor.Invoke("command", "command() const", typeof(string));
		}
		public string StandardResourceDir() {
			return (string) interceptor.Invoke("standardResourceDir", "standardResourceDir() const", typeof(string));
		}
		public string TargetDir() {
			return (string) interceptor.Invoke("targetDir", "targetDir() const", typeof(string));
		}
		public string InstallPath() {
			return (string) interceptor.Invoke("installPath", "installPath() const", typeof(string));
		}
		public string AbsoluteInstallPath() {
			return (string) interceptor.Invoke("absoluteInstallPath", "absoluteInstallPath() const", typeof(string));
		}
		public bool IsRemote() {
			return (bool) interceptor.Invoke("isRemote", "isRemote() const", typeof(bool));
		}
		public KNS.Installation.Policy ChecksumPolicy() {
			return (KNS.Installation.Policy) interceptor.Invoke("checksumPolicy", "checksumPolicy() const", typeof(KNS.Installation.Policy));
		}
		public KNS.Installation.Policy SignaturePolicy() {
			return (KNS.Installation.Policy) interceptor.Invoke("signaturePolicy", "signaturePolicy() const", typeof(KNS.Installation.Policy));
		}
		public KNS.Installation.Scope scope() {
			return (KNS.Installation.Scope) interceptor.Invoke("scope", "scope() const", typeof(KNS.Installation.Scope));
		}
		public bool CustomName() {
			return (bool) interceptor.Invoke("customName", "customName() const", typeof(bool));
		}
		~Installation() {
			interceptor.Invoke("~Installation", "~Installation()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~Installation", "~Installation()", typeof(void));
		}
	}
}
