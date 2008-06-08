//Auto-generated by kalyptus. DO NOT EDIT.
namespace KParts {

	using Kimono;
	using System;
	using Qyoto;

	/// <remarks>
	///  BrowserArguments is a set of web-browsing-specific arguments,
	///  which allow specifying how a URL should be opened by openUrl()
	///  (as a complement to KParts.OpenUrlArguments which are the non-web-specific arguments)
	///  The arguments remain stored in the browser extension after that,
	///  and can be used for instance to jump to the xOffset/yOffset position
	///  once the url has finished loading.
	///  The parts (with a browser extension) who care about urlargs will
	///  use those arguments, others will ignore them.
	///  This can also be used the other way round, when a part asks
	///  for a URL to be opened (with openUrlRequest or createNewWindow).
	///  </remarks>		<short>    BrowserArguments is a set of web-browsing-specific arguments,  which allow specifying how a URL should be opened by openUrl()  (as a complement to KParts.OpenUrlArguments which are the non-web-specific arguments) </short>

	[SmokeClass("KParts::BrowserArguments")]
	public class BrowserArguments : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected BrowserArguments(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocationKDE(typeof(BrowserArguments), this);
		}
		public BrowserArguments() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("BrowserArguments", "BrowserArguments()", typeof(void));
		}
		public BrowserArguments(KParts.BrowserArguments args) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("BrowserArguments#", "BrowserArguments(const KParts::BrowserArguments&)", typeof(void), typeof(KParts.BrowserArguments), args);
		}
		/// <remarks>
		///  KHTML-specific field, header defining the type of the POST data.
		///    </remarks>		<short>    KHTML-specific field, header defining the type of the POST data.</short>
		public void SetContentType(string contentType) {
			interceptor.Invoke("setContentType$", "setContentType(const QString&)", typeof(void), typeof(string), contentType);
		}
		/// <remarks>
		///  KHTML-specific field, header defining the type of the POST data.
		///    </remarks>		<short>    KHTML-specific field, header defining the type of the POST data.</short>
		public string ContentType() {
			return (string) interceptor.Invoke("contentType", "contentType() const", typeof(string));
		}
		/// <remarks>
		///  KHTML-specific field, whether to do a POST instead of a GET,
		///  for the next openURL.
		///    </remarks>		<short>    KHTML-specific field, whether to do a POST instead of a GET,  for the next openURL.</short>
		public void SetDoPost(bool enable) {
			interceptor.Invoke("setDoPost$", "setDoPost(bool)", typeof(void), typeof(bool), enable);
		}
		/// <remarks>
		///  KHTML-specific field, whether to do a POST instead of a GET,
		///  for the next openURL.
		///    </remarks>		<short>    KHTML-specific field, whether to do a POST instead of a GET,  for the next openURL.</short>
		public bool DoPost() {
			return (bool) interceptor.Invoke("doPost", "doPost() const", typeof(bool));
		}
		/// <remarks>
		///  Whether to lock the history when opening the next URL.
		///  This is used during e.g. a redirection, to avoid a new entry
		///  in the history.
		///    </remarks>		<short>    Whether to lock the history when opening the next URL.</short>
		public void SetLockHistory(bool arg1) {
			interceptor.Invoke("setLockHistory$", "setLockHistory(bool)", typeof(void), typeof(bool), arg1);
		}
		public bool LockHistory() {
			return (bool) interceptor.Invoke("lockHistory", "lockHistory() const", typeof(bool));
		}
		/// <remarks>
		///  Whether the URL should be opened in a new tab instead in a new window.
		///    </remarks>		<short>    Whether the URL should be opened in a new tab instead in a new window.</short>
		public void SetNewTab(bool newTab) {
			interceptor.Invoke("setNewTab$", "setNewTab(bool)", typeof(void), typeof(bool), newTab);
		}
		public bool NewTab() {
			return (bool) interceptor.Invoke("newTab", "newTab() const", typeof(bool));
		}
		/// <remarks>
		/// </remarks>		<return> true if the request was a result of a META refresh/redirect request or
		///  HTTP redirect.
		///    </return>
		/// 		<short>   </short>
		public bool RedirectedRequest() {
			return (bool) interceptor.Invoke("redirectedRequest", "redirectedRequest() const", typeof(bool));
		}
		/// <remarks>
		///  Set the redirect flag to indicate URL is a result of either a META redirect
		///  or HTTP redirect.
		/// <param> name="redirected"    </param></remarks>		<short>    Set the redirect flag to indicate URL is a result of either a META redirect  or HTTP redirect.</short>
		public void SetRedirectedRequest(bool redirected) {
			interceptor.Invoke("setRedirectedRequest$", "setRedirectedRequest(bool)", typeof(void), typeof(bool), redirected);
		}
		/// <remarks>
		///  Set whether the URL specifies to be opened in a new window
		///    </remarks>		<short>    Set whether the URL specifies to be opened in a new window    </short>
		public void SetForcesNewWindow(bool forcesNewWindow) {
			interceptor.Invoke("setForcesNewWindow$", "setForcesNewWindow(bool)", typeof(void), typeof(bool), forcesNewWindow);
		}
		/// <remarks>
		///  Whether the URL specifies to be opened in a new window
		///    </remarks>		<short>    Whether the URL specifies to be opened in a new window    </short>
		public bool ForcesNewWindow() {
			return (bool) interceptor.Invoke("forcesNewWindow", "forcesNewWindow() const", typeof(bool));
		}
		~BrowserArguments() {
			interceptor.Invoke("~BrowserArguments", "~BrowserArguments()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~BrowserArguments", "~BrowserArguments()", typeof(void));
		}
	}
}
