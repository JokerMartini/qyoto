//Auto-generated by kalyptus. DO NOT EDIT.
namespace KParts {

	using Kimono;
	using System;
	using Qyoto;

	/// <remarks>
	///  This class extends KRun to provide additional functionality for browsers:
	///  - "save or open" dialog boxes
	///  - "save" functionality
	///  - support for HTTP POST (including saving the result to a temp file if
	///    opening a separate application)
	///  - warning before launching executables off the web
	///  - custom error handling (i.e. treating errors as HTML pages)
	///  - generation of SSL metadata depending on the previous URL shown by the part
	/// </remarks>		<author> David Faure <faure@kde.org>
	///      </author>
	/// 		<short>    This class extends KRun to provide additional functionality for browsers:  - "save or open" dialog boxes  - "save" functionality  - support for HTTP POST (including saving the result to a temp file if    opening a separate application)  - warning before launching executables off the web  - custom error handling (i.</short>

	[SmokeClass("KParts::BrowserRun")]
	public class BrowserRun : KRun, IDisposable {
 		protected BrowserRun(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocationKDE(typeof(BrowserRun), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static BrowserRun() {
			staticInterceptor = new SmokeInvocationKDE(typeof(BrowserRun), null);
		}
		public enum AskSaveResult {
			Save = 0,
			Open = 1,
			Cancel = 2,
		}
		public enum AskEmbedOrSaveFlags {
			InlineDisposition = 0,
			AttachmentDisposition = 1,
		}
		/// <remarks>
		///  NotHandled means that foundMimeType should call KRun.FoundMimeType,
		///  i.e. launch an external app.
		///          </remarks>		<short>    NotHandled means that foundMimeType should call KRun.FoundMimeType,  i.</short>
		public enum NonEmbeddableResult {
			Handled = 0,
			NotHandled = 1,
			Delayed = 2,
		}
		/// <remarks>
		/// <param> name="url" the URL we're probing
		/// </param><param> name="args" URL args - includes reload, metaData, etc.
		/// </param><param> name="browserArgs" browser-related args - includes data for a HTTP POST, etc.
		/// </param><param> name="part" the part going to open this URL - can be 0 if not created yet
		/// </param><param> name="window" the mainwindow - passed to KIO.Job.SetWindow()
		/// </param><param> name="removeReferrer" if true, the "referrer" metadata from <code>args</code> isn't passed on
		/// </param><param> name="trustedSource" if false, a warning will be shown before launching an executable.
		///           Always pass false for <code>trustedSource</code>, except for local directory views.
		/// </param><param> name="hideErrorDialog" if true, no dialog will be shown in case of errors.
		///          </param></remarks>		<short>   </short>
		public BrowserRun(KUrl url, KParts.OpenUrlArguments args, KParts.BrowserArguments browserArgs, KParts.ReadOnlyPart part, QWidget window, bool removeReferrer, bool trustedSource, bool hideErrorDialog) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("BrowserRun#####$$$", "BrowserRun(const KUrl&, const KParts::OpenUrlArguments&, const KParts::BrowserArguments&, KParts::ReadOnlyPart*, QWidget*, bool, bool, bool)", typeof(void), typeof(KUrl), url, typeof(KParts.OpenUrlArguments), args, typeof(KParts.BrowserArguments), browserArgs, typeof(KParts.ReadOnlyPart), part, typeof(QWidget), window, typeof(bool), removeReferrer, typeof(bool), trustedSource, typeof(bool), hideErrorDialog);
		}
		public BrowserRun(KUrl url, KParts.OpenUrlArguments args, KParts.BrowserArguments browserArgs, KParts.ReadOnlyPart part, QWidget window, bool removeReferrer, bool trustedSource) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("BrowserRun#####$$", "BrowserRun(const KUrl&, const KParts::OpenUrlArguments&, const KParts::BrowserArguments&, KParts::ReadOnlyPart*, QWidget*, bool, bool)", typeof(void), typeof(KUrl), url, typeof(KParts.OpenUrlArguments), args, typeof(KParts.BrowserArguments), browserArgs, typeof(KParts.ReadOnlyPart), part, typeof(QWidget), window, typeof(bool), removeReferrer, typeof(bool), trustedSource);
		}
		public KParts.OpenUrlArguments Arguments() {
			return (KParts.OpenUrlArguments) interceptor.Invoke("arguments", "arguments()", typeof(KParts.OpenUrlArguments));
		}
		public KParts.BrowserArguments BrowserArguments() {
			return (KParts.BrowserArguments) interceptor.Invoke("browserArguments", "browserArguments()", typeof(KParts.BrowserArguments));
		}
		public KParts.ReadOnlyPart Part() {
			return (KParts.ReadOnlyPart) interceptor.Invoke("part", "part() const", typeof(KParts.ReadOnlyPart));
		}
		public new KUrl Url() {
			return (KUrl) interceptor.Invoke("url", "url() const", typeof(KUrl));
		}
		public bool HideErrorDialog() {
			return (bool) interceptor.Invoke("hideErrorDialog", "hideErrorDialog() const", typeof(bool));
		}
		/// <remarks>
		/// </remarks>		<return> Suggested disposition by the server (e.g. HTTP content-disposition)
		///         </return>
		/// 		<short>   </short>
		public string ContentDisposition() {
			return (string) interceptor.Invoke("contentDisposition", "contentDisposition() const", typeof(string));
		}
		public bool ServerSuggestsSave() {
			return (bool) interceptor.Invoke("serverSuggestsSave", "serverSuggestsSave() const", typeof(bool));
		}
		[SmokeMethod("save(const KUrl&, const QString&)")]
		public virtual void Save(KUrl url, string suggestedFileName) {
			interceptor.Invoke("save#$", "save(const KUrl&, const QString&)", typeof(void), typeof(KUrl), url, typeof(string), suggestedFileName);
		}
		/// <remarks>
		///  Reimplemented from KRun
		///          </remarks>		<short>    Reimplemented from KRun          </short>
		[SmokeMethod("scanFile()")]
		protected override void ScanFile() {
			interceptor.Invoke("scanFile", "scanFile()", typeof(void));
		}
		/// <remarks>
		///  Reimplemented from KRun
		///          </remarks>		<short>    Reimplemented from KRun          </short>
		[SmokeMethod("init()")]
		protected override void Init() {
			interceptor.Invoke("init", "init()", typeof(void));
		}
		/// <remarks>
		///  Called when an error happens.
		///  NOTE: <code>job</code> could be null, if you passed hideErrorDialog=true.
		///  The default implementation shows a message box, but only when job != 0 ....
		///  It is strongly recommended to reimplement this method if
		///  you passed hideErrorDialog=true.
		///          </remarks>		<short>    Called when an error happens.</short>
		[SmokeMethod("handleError(KJob*)")]
		protected virtual void HandleError(KJob job) {
			interceptor.Invoke("handleError#", "handleError(KJob*)", typeof(void), typeof(KJob), job);
		}
		/// <remarks>
		///  Helper for foundMimeType: call this if the mimetype couldn't be embedded
		///          </remarks>		<short>    Helper for foundMimeType: call this if the mimetype couldn't be embedded          </short>
		protected KParts.BrowserRun.NonEmbeddableResult HandleNonEmbeddable(string mimeType) {
			return (KParts.BrowserRun.NonEmbeddableResult) interceptor.Invoke("handleNonEmbeddable$", "handleNonEmbeddable(const QString&)", typeof(KParts.BrowserRun.NonEmbeddableResult), typeof(string), mimeType);
		}
		[Q_SLOT("void slotBrowserScanFinished(KJob*)")]
		protected void SlotBrowserScanFinished(KJob job) {
			interceptor.Invoke("slotBrowserScanFinished#", "slotBrowserScanFinished(KJob*)", typeof(void), typeof(KJob), job);
		}
		[Q_SLOT("void slotBrowserMimetype(KIO::Job*, const QString&)")]
		protected void SlotBrowserMimetype(KIO.Job job, string type) {
			interceptor.Invoke("slotBrowserMimetype#$", "slotBrowserMimetype(KIO::Job*, const QString&)", typeof(void), typeof(KIO.Job), job, typeof(string), type);
		}
		[Q_SLOT("void slotCopyToTempFileResult(KJob*)")]
		protected void SlotCopyToTempFileResult(KJob job) {
			interceptor.Invoke("slotCopyToTempFileResult#", "slotCopyToTempFileResult(KJob*)", typeof(void), typeof(KJob), job);
		}
		[Q_SLOT("void slotStatResult(KJob*)")]
		[SmokeMethod("slotStatResult(KJob*)")]
		protected override void SlotStatResult(KJob job) {
			interceptor.Invoke("slotStatResult#", "slotStatResult(KJob*)", typeof(void), typeof(KJob), job);
		}
		~BrowserRun() {
			interceptor.Invoke("~BrowserRun", "~BrowserRun()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~BrowserRun", "~BrowserRun()", typeof(void));
		}
		/// <remarks>
		///  Ask the user whether to save or open a url in another application.
		/// <param> name="url" the URL in question
		/// </param><param> name="offer" the application that will be used to open the URL
		/// </param><param> name="mimeType" the mimetype of the URL
		/// </param><param> name="suggestedFileName" optional file name suggested by the server
		/// </param></remarks>		<return> Save, Open or Cancel.
		///          </return>
		/// 		<short>    Ask the user whether to save or open a url in another application.</short>
		public static KParts.BrowserRun.AskSaveResult AskSave(KUrl url, KService offer, string mimeType, string suggestedFileName) {
			return (KParts.BrowserRun.AskSaveResult) staticInterceptor.Invoke("askSave##$$", "askSave(const KUrl&, KService::Ptr, const QString&, const QString&)", typeof(KParts.BrowserRun.AskSaveResult), typeof(KUrl), url, typeof(KService), offer, typeof(string), mimeType, typeof(string), suggestedFileName);
		}
		public static KParts.BrowserRun.AskSaveResult AskSave(KUrl url, KService offer, string mimeType) {
			return (KParts.BrowserRun.AskSaveResult) staticInterceptor.Invoke("askSave##$", "askSave(const KUrl&, KService::Ptr, const QString&)", typeof(KParts.BrowserRun.AskSaveResult), typeof(KUrl), url, typeof(KService), offer, typeof(string), mimeType);
		}
		/// <remarks>
		///  Similar to askSave but for the case where the current application is
		///  able to embed the url itself (instead of passing it to another app).
		/// <param> name="url" the URL in question
		/// </param><param> name="mimeType" the mimetype of the URL
		/// </param><param> name="suggestedFileName" optional filename suggested by the server
		/// </param><param> name="flags" set to AttachmentDisposition if suggested by the server
		/// </param></remarks>		<return> Save, Open or Cancel.
		///          </return>
		/// 		<short>    Similar to askSave but for the case where the current application is  able to embed the url itself (instead of passing it to another app).</short>
		public static KParts.BrowserRun.AskSaveResult AskEmbedOrSave(KUrl url, string mimeType, string suggestedFileName, int flags) {
			return (KParts.BrowserRun.AskSaveResult) staticInterceptor.Invoke("askEmbedOrSave#$$$", "askEmbedOrSave(const KUrl&, const QString&, const QString&, int)", typeof(KParts.BrowserRun.AskSaveResult), typeof(KUrl), url, typeof(string), mimeType, typeof(string), suggestedFileName, typeof(int), flags);
		}
		public static KParts.BrowserRun.AskSaveResult AskEmbedOrSave(KUrl url, string mimeType, string suggestedFileName) {
			return (KParts.BrowserRun.AskSaveResult) staticInterceptor.Invoke("askEmbedOrSave#$$", "askEmbedOrSave(const KUrl&, const QString&, const QString&)", typeof(KParts.BrowserRun.AskSaveResult), typeof(KUrl), url, typeof(string), mimeType, typeof(string), suggestedFileName);
		}
		public static KParts.BrowserRun.AskSaveResult AskEmbedOrSave(KUrl url, string mimeType) {
			return (KParts.BrowserRun.AskSaveResult) staticInterceptor.Invoke("askEmbedOrSave#$", "askEmbedOrSave(const KUrl&, const QString&)", typeof(KParts.BrowserRun.AskSaveResult), typeof(KUrl), url, typeof(string), mimeType);
		}
		public static void SimpleSave(KUrl url, string suggestedFileName, QWidget window) {
			staticInterceptor.Invoke("simpleSave#$#", "simpleSave(const KUrl&, const QString&, QWidget*)", typeof(void), typeof(KUrl), url, typeof(string), suggestedFileName, typeof(QWidget), window);
		}
		public static void SimpleSave(KUrl url, string suggestedFileName) {
			staticInterceptor.Invoke("simpleSave#$", "simpleSave(const KUrl&, const QString&)", typeof(void), typeof(KUrl), url, typeof(string), suggestedFileName);
		}
		public static bool AllowExecution(string mimeType, KUrl url) {
			return (bool) staticInterceptor.Invoke("allowExecution$#", "allowExecution(const QString&, const KUrl&)", typeof(bool), typeof(string), mimeType, typeof(KUrl), url);
		}
		public static bool IsTextExecutable(string mimeType) {
			return (bool) staticInterceptor.Invoke("isTextExecutable$", "isTextExecutable(const QString&)", typeof(bool), typeof(string), mimeType);
		}
		protected new IBrowserRunSignals Emit {
			get { return (IBrowserRunSignals) Q_EMIT; }
		}
	}

	public interface IBrowserRunSignals : IKRunSignals {
	}
}
