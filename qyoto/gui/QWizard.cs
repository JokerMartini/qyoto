//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	using System.Collections.Generic;
	/// <remarks> See <see cref="IQWizardSignals"></see> for signals emitted by QWizard
	/// </remarks>
	[SmokeClass("QWizard")]
	public class QWizard : QDialog, IDisposable {
 		protected QWizard(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QWizard), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QWizard() {
			staticInterceptor = new SmokeInvocation(typeof(QWizard), null);
		}
		public enum WizardButton {
			BackButton = 0,
			NextButton = 1,
			CommitButton = 2,
			FinishButton = 3,
			CancelButton = 4,
			HelpButton = 5,
			CustomButton1 = 6,
			CustomButton2 = 7,
			CustomButton3 = 8,
			Stretch = 9,
			NoButton = -1,
			NStandardButtons = 6,
			NButtons = 9,
		}
		public enum WizardPixmap {
			WatermarkPixmap = 0,
			LogoPixmap = 1,
			BannerPixmap = 2,
			BackgroundPixmap = 3,
			NPixmaps = 4,
		}
		public enum WizardStyle {
			ClassicStyle = 0,
			ModernStyle = 1,
			MacStyle = 2,
			AeroStyle = 3,
			NStyles = 4,
		}
		public enum WizardOption {
			IndependentPages = 0x00000001,
			IgnoreSubTitles = 0x00000002,
			ExtendedWatermarkPixmap = 0x00000004,
			NoDefaultButton = 0x00000008,
			NoBackButtonOnStartPage = 0x00000010,
			NoBackButtonOnLastPage = 0x00000020,
			DisabledBackButtonOnLastPage = 0x00000040,
			HaveNextButtonOnLastPage = 0x00000080,
			HaveFinishButtonOnEarlyPages = 0x00000100,
			NoCancelButton = 0x00000200,
			CancelButtonOnLeft = 0x00000400,
			HaveHelpButton = 0x00000800,
			HelpButtonOnRight = 0x00001000,
			HaveCustomButton1 = 0x00002000,
			HaveCustomButton2 = 0x00004000,
			HaveCustomButton3 = 0x00008000,
		}
		[Q_PROPERTY("QWizard::WizardStyle", "wizardStyle")]
		public QWizard.WizardStyle wizardStyle {
			get { return (QWizard.WizardStyle) interceptor.Invoke("wizardStyle", "wizardStyle()", typeof(QWizard.WizardStyle)); }
			set { interceptor.Invoke("setWizardStyle$", "setWizardStyle(QWizard::WizardStyle)", typeof(void), typeof(QWizard.WizardStyle), value); }
		}
		[Q_PROPERTY("QWizard::WizardOptions", "options")]
		public uint Options {
			get { return (uint) interceptor.Invoke("options", "options()", typeof(uint)); }
			set { interceptor.Invoke("setOptions$", "setOptions(QWizard::WizardOptions)", typeof(void), typeof(uint), value); }
		}
		[Q_PROPERTY("Qt::TextFormat", "titleFormat")]
		public Qt.TextFormat TitleFormat {
			get { return (Qt.TextFormat) interceptor.Invoke("titleFormat", "titleFormat()", typeof(Qt.TextFormat)); }
			set { interceptor.Invoke("setTitleFormat$", "setTitleFormat(Qt::TextFormat)", typeof(void), typeof(Qt.TextFormat), value); }
		}
		[Q_PROPERTY("Qt::TextFormat", "subTitleFormat")]
		public Qt.TextFormat SubTitleFormat {
			get { return (Qt.TextFormat) interceptor.Invoke("subTitleFormat", "subTitleFormat()", typeof(Qt.TextFormat)); }
			set { interceptor.Invoke("setSubTitleFormat$", "setSubTitleFormat(Qt::TextFormat)", typeof(void), typeof(Qt.TextFormat), value); }
		}
		[Q_PROPERTY("int", "startId")]
		public int StartId {
			get { return (int) interceptor.Invoke("startId", "startId()", typeof(int)); }
			set { interceptor.Invoke("setStartId$", "setStartId(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("int", "currentId")]
		public int CurrentId {
			get { return (int) interceptor.Invoke("currentId", "currentId()", typeof(int)); }
			set { interceptor.Invoke("currentIdChanged$", "currentIdChanged(int)", typeof(void), typeof(int), value); }
		}
		public QWizard(QWidget parent, uint flags) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QWizard#$", "QWizard(QWidget*, Qt::WindowFlags)", typeof(void), typeof(QWidget), parent, typeof(uint), flags);
		}
		public QWizard(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QWizard#", "QWizard(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public QWizard() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QWizard", "QWizard()", typeof(void));
		}
		public int AddPage(QWizardPage page) {
			return (int) interceptor.Invoke("addPage#", "addPage(QWizardPage*)", typeof(int), typeof(QWizardPage), page);
		}
		public void SetPage(int id, QWizardPage page) {
			interceptor.Invoke("setPage$#", "setPage(int, QWizardPage*)", typeof(void), typeof(int), id, typeof(QWizardPage), page);
		}
		public QWizardPage Page(int id) {
			return (QWizardPage) interceptor.Invoke("page$", "page(int) const", typeof(QWizardPage), typeof(int), id);
		}
		public bool HasVisitedPage(int id) {
			return (bool) interceptor.Invoke("hasVisitedPage$", "hasVisitedPage(int) const", typeof(bool), typeof(int), id);
		}
		public List<int> VisitedPages() {
			return (List<int>) interceptor.Invoke("visitedPages", "visitedPages() const", typeof(List<int>));
		}
		public QWizardPage CurrentPage() {
			return (QWizardPage) interceptor.Invoke("currentPage", "currentPage() const", typeof(QWizardPage));
		}
		[SmokeMethod("validateCurrentPage()")]
		public virtual bool ValidateCurrentPage() {
			return (bool) interceptor.Invoke("validateCurrentPage", "validateCurrentPage()", typeof(bool));
		}
		[SmokeMethod("nextId() const")]
		public virtual int NextId() {
			return (int) interceptor.Invoke("nextId", "nextId() const", typeof(int));
		}
		public void SetField(string name, QVariant value) {
			interceptor.Invoke("setField$#", "setField(const QString&, const QVariant&)", typeof(void), typeof(string), name, typeof(QVariant), value);
		}
		public QVariant Field(string name) {
			return (QVariant) interceptor.Invoke("field$", "field(const QString&) const", typeof(QVariant), typeof(string), name);
		}
		public void SetOption(QWizard.WizardOption option, bool on) {
			interceptor.Invoke("setOption$$", "setOption(QWizard::WizardOption, bool)", typeof(void), typeof(QWizard.WizardOption), option, typeof(bool), on);
		}
		public void SetOption(QWizard.WizardOption option) {
			interceptor.Invoke("setOption$", "setOption(QWizard::WizardOption)", typeof(void), typeof(QWizard.WizardOption), option);
		}
		public bool TestOption(QWizard.WizardOption option) {
			return (bool) interceptor.Invoke("testOption$", "testOption(QWizard::WizardOption) const", typeof(bool), typeof(QWizard.WizardOption), option);
		}
		public void SetButtonText(QWizard.WizardButton which, string text) {
			interceptor.Invoke("setButtonText$$", "setButtonText(QWizard::WizardButton, const QString&)", typeof(void), typeof(QWizard.WizardButton), which, typeof(string), text);
		}
		public string ButtonText(QWizard.WizardButton which) {
			return (string) interceptor.Invoke("buttonText$", "buttonText(QWizard::WizardButton) const", typeof(string), typeof(QWizard.WizardButton), which);
		}
		public void SetButtonLayout(List<QWizard.WizardButton> layout) {
			interceptor.Invoke("setButtonLayout?", "setButtonLayout(const QList<QWizard::WizardButton>&)", typeof(void), typeof(List<QWizard.WizardButton>), layout);
		}
		public void SetButton(QWizard.WizardButton which, QAbstractButton button) {
			interceptor.Invoke("setButton$#", "setButton(QWizard::WizardButton, QAbstractButton*)", typeof(void), typeof(QWizard.WizardButton), which, typeof(QAbstractButton), button);
		}
		public QAbstractButton Button(QWizard.WizardButton which) {
			return (QAbstractButton) interceptor.Invoke("button$", "button(QWizard::WizardButton) const", typeof(QAbstractButton), typeof(QWizard.WizardButton), which);
		}
		public void SetPixmap(QWizard.WizardPixmap which, QPixmap pixmap) {
			interceptor.Invoke("setPixmap$#", "setPixmap(QWizard::WizardPixmap, const QPixmap&)", typeof(void), typeof(QWizard.WizardPixmap), which, typeof(QPixmap), pixmap);
		}
		public QPixmap Pixmap(QWizard.WizardPixmap which) {
			return (QPixmap) interceptor.Invoke("pixmap$", "pixmap(QWizard::WizardPixmap) const", typeof(QPixmap), typeof(QWizard.WizardPixmap), which);
		}
		public void SetDefaultProperty(string className, string property, string changedSignal) {
			interceptor.Invoke("setDefaultProperty$$$", "setDefaultProperty(const char*, const char*, const char*)", typeof(void), typeof(string), className, typeof(string), property, typeof(string), changedSignal);
		}
		[SmokeMethod("setVisible(bool)")]
		public override void SetVisible(bool visible) {
			interceptor.Invoke("setVisible$", "setVisible(bool)", typeof(void), typeof(bool), visible);
		}
		[SmokeMethod("sizeHint() const")]
		public override QSize SizeHint() {
			return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
		}
		[Q_SLOT("void back()")]
		public void Back() {
			interceptor.Invoke("back", "back()", typeof(void));
		}
		[Q_SLOT("void next()")]
		public void Next() {
			interceptor.Invoke("next", "next()", typeof(void));
		}
		[Q_SLOT("void restart()")]
		public void Restart() {
			interceptor.Invoke("restart", "restart()", typeof(void));
		}
		[SmokeMethod("event(QEvent*)")]
		protected override bool Event(QEvent arg1) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected override void ResizeEvent(QResizeEvent arg1) {
			interceptor.Invoke("resizeEvent#", "resizeEvent(QResizeEvent*)", typeof(void), typeof(QResizeEvent), arg1);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected override void PaintEvent(QPaintEvent arg1) {
			interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), arg1);
		}
		[SmokeMethod("done(int)")]
		protected new virtual void Done(int result) {
			interceptor.Invoke("done$", "done(int)", typeof(void), typeof(int), result);
		}
		[SmokeMethod("initializePage(int)")]
		protected virtual void InitializePage(int id) {
			interceptor.Invoke("initializePage$", "initializePage(int)", typeof(void), typeof(int), id);
		}
		[SmokeMethod("cleanupPage(int)")]
		protected virtual void CleanupPage(int id) {
			interceptor.Invoke("cleanupPage$", "cleanupPage(int)", typeof(void), typeof(int), id);
		}
		~QWizard() {
			interceptor.Invoke("~QWizard", "~QWizard()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QWizard", "~QWizard()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQWizardSignals Emit {
			get { return (IQWizardSignals) Q_EMIT; }
		}
	}

	public interface IQWizardSignals : IQDialogSignals {
		[Q_SIGNAL("void currentIdChanged(int)")]
		void CurrentIdChanged(int id);
		[Q_SIGNAL("void helpRequested()")]
		void HelpRequested();
		[Q_SIGNAL("void customButtonClicked(int)")]
		void CustomButtonClicked(int which);
	}
}
