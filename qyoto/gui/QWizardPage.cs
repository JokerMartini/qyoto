//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	/// <remarks> See <see cref="IQWizardPageSignals"></see> for signals emitted by QWizardPage
	/// </remarks>
	[SmokeClass("QWizardPage")]
	public class QWizardPage : QWidget, IDisposable {
 		protected QWizardPage(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QWizardPage), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QWizardPage() {
			staticInterceptor = new SmokeInvocation(typeof(QWizardPage), null);
		}
		[Q_PROPERTY("QString", "title")]
		public string Title {
			get { return (string) interceptor.Invoke("title", "title()", typeof(string)); }
			set { interceptor.Invoke("setTitle$", "setTitle(QString)", typeof(void), typeof(string), value); }
		}
		[Q_PROPERTY("QString", "subTitle")]
		public string SubTitle {
			get { return (string) interceptor.Invoke("subTitle", "subTitle()", typeof(string)); }
			set { interceptor.Invoke("setSubTitle$", "setSubTitle(QString)", typeof(void), typeof(string), value); }
		}
		public QWizardPage(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QWizardPage#", "QWizardPage(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public QWizardPage() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QWizardPage", "QWizardPage()", typeof(void));
		}
		public void SetPixmap(QWizard.WizardPixmap which, QPixmap pixmap) {
			interceptor.Invoke("setPixmap$#", "setPixmap(QWizard::WizardPixmap, const QPixmap&)", typeof(void), typeof(QWizard.WizardPixmap), which, typeof(QPixmap), pixmap);
		}
		public QPixmap Pixmap(QWizard.WizardPixmap which) {
			return (QPixmap) interceptor.Invoke("pixmap$", "pixmap(QWizard::WizardPixmap) const", typeof(QPixmap), typeof(QWizard.WizardPixmap), which);
		}
		public void SetFinalPage(bool finalPage) {
			interceptor.Invoke("setFinalPage$", "setFinalPage(bool)", typeof(void), typeof(bool), finalPage);
		}
		public bool IsFinalPage() {
			return (bool) interceptor.Invoke("isFinalPage", "isFinalPage() const", typeof(bool));
		}
		public void SetCommitPage(bool commitPage) {
			interceptor.Invoke("setCommitPage$", "setCommitPage(bool)", typeof(void), typeof(bool), commitPage);
		}
		public bool IsCommitPage() {
			return (bool) interceptor.Invoke("isCommitPage", "isCommitPage() const", typeof(bool));
		}
		public void SetButtonText(QWizard.WizardButton which, string text) {
			interceptor.Invoke("setButtonText$$", "setButtonText(QWizard::WizardButton, const QString&)", typeof(void), typeof(QWizard.WizardButton), which, typeof(string), text);
		}
		public string ButtonText(QWizard.WizardButton which) {
			return (string) interceptor.Invoke("buttonText$", "buttonText(QWizard::WizardButton) const", typeof(string), typeof(QWizard.WizardButton), which);
		}
		[SmokeMethod("initializePage()")]
		public virtual void InitializePage() {
			interceptor.Invoke("initializePage", "initializePage()", typeof(void));
		}
		[SmokeMethod("cleanupPage()")]
		public virtual void CleanupPage() {
			interceptor.Invoke("cleanupPage", "cleanupPage()", typeof(void));
		}
		[SmokeMethod("validatePage()")]
		public virtual bool ValidatePage() {
			return (bool) interceptor.Invoke("validatePage", "validatePage()", typeof(bool));
		}
		[SmokeMethod("isComplete() const")]
		public virtual bool IsComplete() {
			return (bool) interceptor.Invoke("isComplete", "isComplete() const", typeof(bool));
		}
		[SmokeMethod("nextId() const")]
		public virtual int NextId() {
			return (int) interceptor.Invoke("nextId", "nextId() const", typeof(int));
		}
		protected void SetField(string name, QVariant value) {
			interceptor.Invoke("setField$#", "setField(const QString&, const QVariant&)", typeof(void), typeof(string), name, typeof(QVariant), value);
		}
		protected QVariant Field(string name) {
			return (QVariant) interceptor.Invoke("field$", "field(const QString&) const", typeof(QVariant), typeof(string), name);
		}
		protected void RegisterField(string name, QWidget widget, string property, string changedSignal) {
			interceptor.Invoke("registerField$#$$", "registerField(const QString&, QWidget*, const char*, const char*)", typeof(void), typeof(string), name, typeof(QWidget), widget, typeof(string), property, typeof(string), changedSignal);
		}
		protected void RegisterField(string name, QWidget widget, string property) {
			interceptor.Invoke("registerField$#$", "registerField(const QString&, QWidget*, const char*)", typeof(void), typeof(string), name, typeof(QWidget), widget, typeof(string), property);
		}
		protected void RegisterField(string name, QWidget widget) {
			interceptor.Invoke("registerField$#", "registerField(const QString&, QWidget*)", typeof(void), typeof(string), name, typeof(QWidget), widget);
		}
		protected QWizard Wizard() {
			return (QWizard) interceptor.Invoke("wizard", "wizard() const", typeof(QWizard));
		}
		~QWizardPage() {
			interceptor.Invoke("~QWizardPage", "~QWizardPage()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QWizardPage", "~QWizardPage()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQWizardPageSignals Emit {
			get { return (IQWizardPageSignals) Q_EMIT; }
		}
	}

	public interface IQWizardPageSignals : IQWidgetSignals {
		[Q_SIGNAL("void completeChanged()")]
		void CompleteChanged();
	}
}
