//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;

	/// <remarks>
	/// </remarks>		<author> Holger Freyther <freyher@yahoo.com>
	/// </author>
	/// 		<short> An abstract class for GUI data such as ToolTip and Icon. </short>
	/// 		<see> KStandardGuiItem</see>

	[SmokeClass("KGuiItem")]
	public class KGuiItem : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected KGuiItem(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocationKDE(typeof(KGuiItem), this);
		}
		public KGuiItem() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KGuiItem", "KGuiItem()", typeof(void));
		}
		public KGuiItem(string text, string iconName, string toolTip, string whatsThis) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KGuiItem$$$$", "KGuiItem(const QString&, const QString&, const QString&, const QString&)", typeof(void), typeof(string), text, typeof(string), iconName, typeof(string), toolTip, typeof(string), whatsThis);
		}
		public KGuiItem(string text, string iconName, string toolTip) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KGuiItem$$$", "KGuiItem(const QString&, const QString&, const QString&)", typeof(void), typeof(string), text, typeof(string), iconName, typeof(string), toolTip);
		}
		public KGuiItem(string text, string iconName) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KGuiItem$$", "KGuiItem(const QString&, const QString&)", typeof(void), typeof(string), text, typeof(string), iconName);
		}
		public KGuiItem(string text) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KGuiItem$", "KGuiItem(const QString&)", typeof(void), typeof(string), text);
		}
		public KGuiItem(string text, KIcon icon, string toolTip, string whatsThis) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KGuiItem$#$$", "KGuiItem(const QString&, const KIcon&, const QString&, const QString&)", typeof(void), typeof(string), text, typeof(KIcon), icon, typeof(string), toolTip, typeof(string), whatsThis);
		}
		public KGuiItem(string text, KIcon icon, string toolTip) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KGuiItem$#$", "KGuiItem(const QString&, const KIcon&, const QString&)", typeof(void), typeof(string), text, typeof(KIcon), icon, typeof(string), toolTip);
		}
		public KGuiItem(string text, KIcon icon) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KGuiItem$#", "KGuiItem(const QString&, const KIcon&)", typeof(void), typeof(string), text, typeof(KIcon), icon);
		}
		public KGuiItem(KGuiItem rhs) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KGuiItem#", "KGuiItem(const KGuiItem&)", typeof(void), typeof(KGuiItem), rhs);
		}
		public string Text() {
			return (string) interceptor.Invoke("text", "text() const", typeof(string));
		}
		public string PlainText() {
			return (string) interceptor.Invoke("plainText", "plainText() const", typeof(string));
		}
		public KIcon Icon() {
			return (KIcon) interceptor.Invoke("icon", "icon() const", typeof(KIcon));
		}
		public string IconName() {
			return (string) interceptor.Invoke("iconName", "iconName() const", typeof(string));
		}
		public string ToolTip() {
			return (string) interceptor.Invoke("toolTip", "toolTip() const", typeof(string));
		}
		public string WhatsThis() {
			return (string) interceptor.Invoke("whatsThis", "whatsThis() const", typeof(string));
		}
		public bool IsEnabled() {
			return (bool) interceptor.Invoke("isEnabled", "isEnabled() const", typeof(bool));
		}
		public bool HasIcon() {
			return (bool) interceptor.Invoke("hasIcon", "hasIcon() const", typeof(bool));
		}
		public void SetText(string text) {
			interceptor.Invoke("setText$", "setText(const QString&)", typeof(void), typeof(string), text);
		}
		public void SetIcon(KIcon iconset) {
			interceptor.Invoke("setIcon#", "setIcon(const KIcon&)", typeof(void), typeof(KIcon), iconset);
		}
		public void SetIconName(string iconName) {
			interceptor.Invoke("setIconName$", "setIconName(const QString&)", typeof(void), typeof(string), iconName);
		}
		public void SetToolTip(string tooltip) {
			interceptor.Invoke("setToolTip$", "setToolTip(const QString&)", typeof(void), typeof(string), tooltip);
		}
		public void SetWhatsThis(string whatsThis) {
			interceptor.Invoke("setWhatsThis$", "setWhatsThis(const QString&)", typeof(void), typeof(string), whatsThis);
		}
		public void SetEnabled(bool enable) {
			interceptor.Invoke("setEnabled$", "setEnabled(bool)", typeof(void), typeof(bool), enable);
		}
		~KGuiItem() {
			interceptor.Invoke("~KGuiItem", "~KGuiItem()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~KGuiItem", "~KGuiItem()", typeof(void));
		}
	}
}
