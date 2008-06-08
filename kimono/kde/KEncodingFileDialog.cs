//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;

	/// <remarks>
	///  Provides a user (and developer) friendly way to
	///  select files with support for choosing encoding
	///  The dialog has been designed to allow applications to customize it
	///  by subclassing. It uses geometry management to ensure that subclasses
	///  can easily add children that will be incorporated into the layout.
	///  </remarks>		<short>    Provides a user (and developer) friendly way to  select files with support for choosing encoding </short>

	[SmokeClass("KEncodingFileDialog")]
	public class KEncodingFileDialog : KFileDialog, IDisposable {
 		protected KEncodingFileDialog(Type dummy) : base((Type) null) {}


		[SmokeClass("KEncodingFileDialog::Result")]
		public class Result : Object, IDisposable {
			protected SmokeInvocation interceptor = null;
			private IntPtr smokeObject;
			protected Result(Type dummy) {}
			protected void CreateProxy() {
				interceptor = new SmokeInvocationKDE(typeof(Result), this);
			}
			public Result() : this((Type) null) {
				CreateProxy();
				interceptor.Invoke("Result", "Result()", typeof(void));
			}
			~Result() {
				interceptor.Invoke("~Result", "~Result()", typeof(void));
			}
			public void Dispose() {
				interceptor.Invoke("~Result", "~Result()", typeof(void));
			}
		}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocationKDE(typeof(KEncodingFileDialog), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static KEncodingFileDialog() {
			staticInterceptor = new SmokeInvocationKDE(typeof(KEncodingFileDialog), null);
		}
		/// <remarks>
		///  Constructs a file dialog for text files with encoding selection possibility.
		/// <param> name="startDir" This can either be
		/// </param>
		/// <li>
		/// The URL of the directory to start in.
		/// </li>
		/// 
		/// <li>
		/// string() to start in the current working
		/// 		    directory, or the last directory where a file has been
		/// 		    selected.
		/// </li>
		/// 
		/// <li>
		/// ':&lt;keyword&gt;' to start in the directory last used
		///              by a filedialog in the same application that specified
		///              the same keyword.
		/// </li>
		/// 
		/// <li>
		/// '.&lt;keyword&gt;' to start in the directory last used
		///              by a filedialog in any application that specified the
		///              same keyword.
		/// </li>
		/// <param> name="encoding" The encoding shown in the encoding combo. If it's
		/// 		    string(), the global default encoding will be shown.
		/// </param><param> name="filter" A shell glob or a mime-type-filter that specifies which files to display.
		///     The preferred option is to set a list of mimetype names, see setMimeFilter() for details.
		///     Otherwise you can set the text to be displayed for the each glob, and
		///     provide multiple globs, see setFilter() for details.
		/// </param><param> name="caption" The caption of the dialog
		/// </param><param> name="type" This can either be
		/// </param>
		/// <li>
		/// Opening (open dialog, the default setting)
		/// </li>
		/// 
		/// <li>
		/// Saving
		/// </li>
		/// <param> name="parent" The parent widget of this dialog
		///      </param></remarks>		<short>    Constructs a file dialog for text files with encoding selection possibility.</short>
		public KEncodingFileDialog(string startDir, string encoding, string filter, string caption, KFileDialog.OperationMode type, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KEncodingFileDialog$$$$$#", "KEncodingFileDialog(const QString&, const QString&, const QString&, const QString&, KFileDialog::OperationMode, QWidget*)", typeof(void), typeof(string), startDir, typeof(string), encoding, typeof(string), filter, typeof(string), caption, typeof(KFileDialog.OperationMode), type, typeof(QWidget), parent);
		}
		public KEncodingFileDialog(string startDir, string encoding, string filter, string caption, KFileDialog.OperationMode type) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KEncodingFileDialog$$$$$", "KEncodingFileDialog(const QString&, const QString&, const QString&, const QString&, KFileDialog::OperationMode)", typeof(void), typeof(string), startDir, typeof(string), encoding, typeof(string), filter, typeof(string), caption, typeof(KFileDialog.OperationMode), type);
		}
		public KEncodingFileDialog(string startDir, string encoding, string filter, string caption) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KEncodingFileDialog$$$$", "KEncodingFileDialog(const QString&, const QString&, const QString&, const QString&)", typeof(void), typeof(string), startDir, typeof(string), encoding, typeof(string), filter, typeof(string), caption);
		}
		public KEncodingFileDialog(string startDir, string encoding, string filter) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KEncodingFileDialog$$$", "KEncodingFileDialog(const QString&, const QString&, const QString&)", typeof(void), typeof(string), startDir, typeof(string), encoding, typeof(string), filter);
		}
		public KEncodingFileDialog(string startDir, string encoding) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KEncodingFileDialog$$", "KEncodingFileDialog(const QString&, const QString&)", typeof(void), typeof(string), startDir, typeof(string), encoding);
		}
		public KEncodingFileDialog(string startDir) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KEncodingFileDialog$", "KEncodingFileDialog(const QString&)", typeof(void), typeof(string), startDir);
		}
		public KEncodingFileDialog() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KEncodingFileDialog", "KEncodingFileDialog()", typeof(void));
		}
		/// <remarks>
		/// </remarks>		<return> The selected encoding if the constructor with the encoding parameter was used, otherwise string().
		///     </return>
		/// 		<short>   </short>
		public string SelectedEncoding() {
			return (string) interceptor.Invoke("selectedEncoding", "selectedEncoding() const", typeof(string));
		}
		~KEncodingFileDialog() {
			interceptor.Invoke("~KEncodingFileDialog", "~KEncodingFileDialog()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KEncodingFileDialog", "~KEncodingFileDialog()", typeof(void));
		}
		/// <remarks>
		///  Creates a modal file dialog and return the selected
		///  filename or an empty string if none was chosen additionally a chosen
		///  encoding value is returned.
		///  Note that with
		///  this method the user must select an existing filename.
		/// <param> name="startDir" This can either be
		/// </param>
		/// <li>
		/// The URL of the directory to start in.
		/// </li>
		/// 
		/// <li>
		/// string() to start in the current working
		/// 		    directory, or the last directory where a file has been
		/// 		    selected.
		/// </li>
		/// 
		/// <li>
		/// ':&lt;keyword&gt;' to start in the directory last used
		///              by a filedialog in the same application that specified
		///              the same keyword.
		/// </li>
		/// 
		/// <li>
		/// '.&lt;keyword&gt;' to start in the directory last used
		///              by a filedialog in any application that specified the
		///              same keyword.
		/// </li>
		/// <param> name="encoding" The encoding shown in the encoding combo.
		/// </param><param> name="filter" A shell glob or a mime-type-filter that specifies which files to display.
		///     The preferred option is to set a list of mimetype names, see setMimeFilter() for details.
		///     Otherwise you can set the text to be displayed for the each glob, and
		///     provide multiple globs, see setFilter() for details.
		/// </param><param> name="parent" The widget the dialog will be centered on initially.
		/// </param><param> name="caption" The name of the dialog widget.
		///      </param></remarks>		<short>    Creates a modal file dialog and return the selected  filename or an empty string if none was chosen additionally a chosen  encoding value is returned.</short>
		public static KEncodingFileDialog.Result GetOpenFileNameAndEncoding(string encoding, string startDir, string filter, QWidget parent, string caption) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getOpenFileNameAndEncoding$$$#$", "getOpenFileNameAndEncoding(const QString&, const QString&, const QString&, QWidget*, const QString&)", typeof(KEncodingFileDialog.Result), typeof(string), encoding, typeof(string), startDir, typeof(string), filter, typeof(QWidget), parent, typeof(string), caption);
		}
		public static KEncodingFileDialog.Result GetOpenFileNameAndEncoding(string encoding, string startDir, string filter, QWidget parent) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getOpenFileNameAndEncoding$$$#", "getOpenFileNameAndEncoding(const QString&, const QString&, const QString&, QWidget*)", typeof(KEncodingFileDialog.Result), typeof(string), encoding, typeof(string), startDir, typeof(string), filter, typeof(QWidget), parent);
		}
		public static KEncodingFileDialog.Result GetOpenFileNameAndEncoding(string encoding, string startDir, string filter) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getOpenFileNameAndEncoding$$$", "getOpenFileNameAndEncoding(const QString&, const QString&, const QString&)", typeof(KEncodingFileDialog.Result), typeof(string), encoding, typeof(string), startDir, typeof(string), filter);
		}
		public static KEncodingFileDialog.Result GetOpenFileNameAndEncoding(string encoding, string startDir) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getOpenFileNameAndEncoding$$", "getOpenFileNameAndEncoding(const QString&, const QString&)", typeof(KEncodingFileDialog.Result), typeof(string), encoding, typeof(string), startDir);
		}
		public static KEncodingFileDialog.Result GetOpenFileNameAndEncoding(string encoding) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getOpenFileNameAndEncoding$", "getOpenFileNameAndEncoding(const QString&)", typeof(KEncodingFileDialog.Result), typeof(string), encoding);
		}
		public static KEncodingFileDialog.Result GetOpenFileNameAndEncoding() {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getOpenFileNameAndEncoding", "getOpenFileNameAndEncoding()", typeof(KEncodingFileDialog.Result));
		}
		/// <remarks>
		///  Creates a modal file dialog and returns the selected encoding and the selected
		///  filenames or an empty list if none was chosen.
		///  Note that with
		///  this method the user must select an existing filename.
		/// <param> name="startDir" This can either be
		/// </param>
		/// <li>
		/// The URL of the directory to start in.
		/// </li>
		/// 
		/// <li>
		/// string() to start in the current working
		/// 		    directory, or the last directory where a file has been
		/// 		    selected.
		/// </li>
		/// 
		/// <li>
		/// ':&lt;keyword&gt;' to start in the directory last used
		///              by a filedialog in the same application that specified
		///              the same keyword.
		/// </li>
		/// 
		/// <li>
		/// '.&lt;keyword&gt;' to start in the directory last used
		///              by a filedialog in any application that specified the
		///              same keyword.
		/// </li>
		/// <param> name="encoding" The encoding shown in the encoding combo.
		/// </param><param> name="filter" A shell glob or a mime-type-filter that specifies which files to display.
		///     The preferred option is to set a list of mimetype names, see setMimeFilter() for details.
		///     Otherwise you can set the text to be displayed for the each glob, and
		///     provide multiple globs, see setFilter() for details.
		/// </param><param> name="parent" The widget the dialog will be centered on initially.
		/// </param><param> name="caption" The name of the dialog widget.
		///      </param></remarks>		<short>    Creates a modal file dialog and returns the selected encoding and the selected  filenames or an empty list if none was chosen.</short>
		public static KEncodingFileDialog.Result GetOpenFileNamesAndEncoding(string encoding, string startDir, string filter, QWidget parent, string caption) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getOpenFileNamesAndEncoding$$$#$", "getOpenFileNamesAndEncoding(const QString&, const QString&, const QString&, QWidget*, const QString&)", typeof(KEncodingFileDialog.Result), typeof(string), encoding, typeof(string), startDir, typeof(string), filter, typeof(QWidget), parent, typeof(string), caption);
		}
		public static KEncodingFileDialog.Result GetOpenFileNamesAndEncoding(string encoding, string startDir, string filter, QWidget parent) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getOpenFileNamesAndEncoding$$$#", "getOpenFileNamesAndEncoding(const QString&, const QString&, const QString&, QWidget*)", typeof(KEncodingFileDialog.Result), typeof(string), encoding, typeof(string), startDir, typeof(string), filter, typeof(QWidget), parent);
		}
		public static KEncodingFileDialog.Result GetOpenFileNamesAndEncoding(string encoding, string startDir, string filter) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getOpenFileNamesAndEncoding$$$", "getOpenFileNamesAndEncoding(const QString&, const QString&, const QString&)", typeof(KEncodingFileDialog.Result), typeof(string), encoding, typeof(string), startDir, typeof(string), filter);
		}
		public static KEncodingFileDialog.Result GetOpenFileNamesAndEncoding(string encoding, string startDir) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getOpenFileNamesAndEncoding$$", "getOpenFileNamesAndEncoding(const QString&, const QString&)", typeof(KEncodingFileDialog.Result), typeof(string), encoding, typeof(string), startDir);
		}
		public static KEncodingFileDialog.Result GetOpenFileNamesAndEncoding(string encoding) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getOpenFileNamesAndEncoding$", "getOpenFileNamesAndEncoding(const QString&)", typeof(KEncodingFileDialog.Result), typeof(string), encoding);
		}
		public static KEncodingFileDialog.Result GetOpenFileNamesAndEncoding() {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getOpenFileNamesAndEncoding", "getOpenFileNamesAndEncoding()", typeof(KEncodingFileDialog.Result));
		}
		/// <remarks>
		///  Creates a modal file dialog and returns the selected encoding and
		///  URL or an empty string if none was chosen.
		///  Note that with
		///  this method the user must select an existing URL.
		/// <param> name="startDir" This can either be
		/// </param>
		/// <li>
		/// The URL of the directory to start in.
		/// </li>
		/// 
		/// <li>
		/// string() to start in the current working
		/// 		    directory, or the last directory where a file has been
		/// 		    selected.
		/// </li>
		/// 
		/// <li>
		/// ':&lt;keyword&gt;' to start in the directory last used
		///              by a filedialog in the same application that specified
		///              the same keyword.
		/// </li>
		/// 
		/// <li>
		/// '.&lt;keyword&gt;' to start in the directory last used
		///              by a filedialog in any application that specified the
		///              same keyword.
		/// </li>
		/// <param> name="encoding" The encoding shown in the encoding combo.
		/// </param><param> name="filter" A shell glob or a mime-type-filter that specifies which files to display.
		///     The preferred option is to set a list of mimetype names, see setMimeFilter() for details.
		///     Otherwise you can set the text to be displayed for the each glob, and
		///     provide multiple globs, see setFilter() for details.
		/// </param><param> name="parent" The widget the dialog will be centered on initially.
		/// </param><param> name="caption" The name of the dialog widget.
		///      </param></remarks>		<short>    Creates a modal file dialog and returns the selected encoding and  URL or an empty string if none was chosen.</short>
		public static KEncodingFileDialog.Result GetOpenUrlAndEncoding(string encoding, string startDir, string filter, QWidget parent, string caption) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getOpenUrlAndEncoding$$$#$", "getOpenUrlAndEncoding(const QString&, const QString&, const QString&, QWidget*, const QString&)", typeof(KEncodingFileDialog.Result), typeof(string), encoding, typeof(string), startDir, typeof(string), filter, typeof(QWidget), parent, typeof(string), caption);
		}
		public static KEncodingFileDialog.Result GetOpenUrlAndEncoding(string encoding, string startDir, string filter, QWidget parent) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getOpenUrlAndEncoding$$$#", "getOpenUrlAndEncoding(const QString&, const QString&, const QString&, QWidget*)", typeof(KEncodingFileDialog.Result), typeof(string), encoding, typeof(string), startDir, typeof(string), filter, typeof(QWidget), parent);
		}
		public static KEncodingFileDialog.Result GetOpenUrlAndEncoding(string encoding, string startDir, string filter) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getOpenUrlAndEncoding$$$", "getOpenUrlAndEncoding(const QString&, const QString&, const QString&)", typeof(KEncodingFileDialog.Result), typeof(string), encoding, typeof(string), startDir, typeof(string), filter);
		}
		public static KEncodingFileDialog.Result GetOpenUrlAndEncoding(string encoding, string startDir) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getOpenUrlAndEncoding$$", "getOpenUrlAndEncoding(const QString&, const QString&)", typeof(KEncodingFileDialog.Result), typeof(string), encoding, typeof(string), startDir);
		}
		public static KEncodingFileDialog.Result GetOpenUrlAndEncoding(string encoding) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getOpenUrlAndEncoding$", "getOpenUrlAndEncoding(const QString&)", typeof(KEncodingFileDialog.Result), typeof(string), encoding);
		}
		public static KEncodingFileDialog.Result GetOpenUrlAndEncoding() {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getOpenUrlAndEncoding", "getOpenUrlAndEncoding()", typeof(KEncodingFileDialog.Result));
		}
		/// <remarks>
		///  Creates a modal file dialog and returns the selected encoding
		///  URLs or an empty list if none was chosen.
		///  Note that with
		///  this method the user must select an existing filename.
		/// <param> name="startDir" This can either be
		/// </param>
		/// <li>
		/// The URL of the directory to start in.
		/// </li>
		/// 
		/// <li>
		/// string() to start in the current working
		/// 		    directory, or the last directory where a file has been
		/// 		    selected.
		/// </li>
		/// 
		/// <li>
		/// ':&lt;keyword&gt;' to start in the directory last used
		///              by a filedialog in the same application that specified
		///              the same keyword.
		/// </li>
		/// 
		/// <li>
		/// '.&lt;keyword&gt;' to start in the directory last used
		///              by a filedialog in any application that specified the
		///              same keyword.
		/// </li>
		/// <param> name="encoding" The encoding shown in the encoding combo.
		/// </param><param> name="filter" A shell glob or a mime-type-filter that specifies which files to display.
		///     The preferred option is to set a list of mimetype names, see setMimeFilter() for details.
		///     Otherwise you can set the text to be displayed for the each glob, and
		///     provide multiple globs, see setFilter() for details.
		/// </param><param> name="parent" The widget the dialog will be centered on initially.
		/// </param><param> name="caption" The name of the dialog widget.
		///      </param></remarks>		<short>    Creates a modal file dialog and returns the selected encoding  URLs or an empty list if none was chosen.</short>
		public static KEncodingFileDialog.Result GetOpenUrlsAndEncoding(string encoding, string startDir, string filter, QWidget parent, string caption) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getOpenUrlsAndEncoding$$$#$", "getOpenUrlsAndEncoding(const QString&, const QString&, const QString&, QWidget*, const QString&)", typeof(KEncodingFileDialog.Result), typeof(string), encoding, typeof(string), startDir, typeof(string), filter, typeof(QWidget), parent, typeof(string), caption);
		}
		public static KEncodingFileDialog.Result GetOpenUrlsAndEncoding(string encoding, string startDir, string filter, QWidget parent) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getOpenUrlsAndEncoding$$$#", "getOpenUrlsAndEncoding(const QString&, const QString&, const QString&, QWidget*)", typeof(KEncodingFileDialog.Result), typeof(string), encoding, typeof(string), startDir, typeof(string), filter, typeof(QWidget), parent);
		}
		public static KEncodingFileDialog.Result GetOpenUrlsAndEncoding(string encoding, string startDir, string filter) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getOpenUrlsAndEncoding$$$", "getOpenUrlsAndEncoding(const QString&, const QString&, const QString&)", typeof(KEncodingFileDialog.Result), typeof(string), encoding, typeof(string), startDir, typeof(string), filter);
		}
		public static KEncodingFileDialog.Result GetOpenUrlsAndEncoding(string encoding, string startDir) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getOpenUrlsAndEncoding$$", "getOpenUrlsAndEncoding(const QString&, const QString&)", typeof(KEncodingFileDialog.Result), typeof(string), encoding, typeof(string), startDir);
		}
		public static KEncodingFileDialog.Result GetOpenUrlsAndEncoding(string encoding) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getOpenUrlsAndEncoding$", "getOpenUrlsAndEncoding(const QString&)", typeof(KEncodingFileDialog.Result), typeof(string), encoding);
		}
		public static KEncodingFileDialog.Result GetOpenUrlsAndEncoding() {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getOpenUrlsAndEncoding", "getOpenUrlsAndEncoding()", typeof(KEncodingFileDialog.Result));
		}
		/// <remarks>
		///  Creates a modal file dialog and returns the selected encoding and
		///  filename or an empty string if none was chosen.
		///  Note that with this
		///  method the user need not select an existing filename.
		/// <param> name="startDir" This can either be
		/// </param>
		/// <li>
		/// The URL of the directory to start in.
		/// </li>
		/// 
		/// <li>
		/// a relative path or a filename determining the
		///              directory to start in and the file to be selected.
		/// </li>
		/// 
		/// <li>
		/// string() to start in the current working
		/// 		    directory, or the last directory where a file has been
		/// 		    selected.
		/// </li>
		/// 
		/// <li>
		/// ':&lt;keyword&gt;' to start in the directory last used
		///              by a filedialog in the same application that specified
		///              the same keyword.
		/// </li>
		/// 
		/// <li>
		/// '.&lt;keyword&gt;' to start in the directory last used
		///              by a filedialog in any application that specified the
		///              same keyword.
		/// </li>
		/// <param> name="encoding" The encoding shown in the encoding combo.
		/// </param><param> name="filter" A shell glob or a mime-type-filter that specifies which files to display.
		///     The preferred option is to set a list of mimetype names, see setMimeFilter() for details.
		///     Otherwise you can set the text to be displayed for the each glob, and
		///     provide multiple globs, see setFilter() for details.
		/// </param><param> name="parent" The widget the dialog will be centered on initially.
		/// </param><param> name="caption" The name of the dialog widget.
		///      </param></remarks>		<short>    Creates a modal file dialog and returns the selected encoding and  filename or an empty string if none was chosen.</short>
		public static KEncodingFileDialog.Result GetSaveFileNameAndEncoding(string encoding, string startDir, string filter, QWidget parent, string caption) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getSaveFileNameAndEncoding$$$#$", "getSaveFileNameAndEncoding(const QString&, const QString&, const QString&, QWidget*, const QString&)", typeof(KEncodingFileDialog.Result), typeof(string), encoding, typeof(string), startDir, typeof(string), filter, typeof(QWidget), parent, typeof(string), caption);
		}
		public static KEncodingFileDialog.Result GetSaveFileNameAndEncoding(string encoding, string startDir, string filter, QWidget parent) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getSaveFileNameAndEncoding$$$#", "getSaveFileNameAndEncoding(const QString&, const QString&, const QString&, QWidget*)", typeof(KEncodingFileDialog.Result), typeof(string), encoding, typeof(string), startDir, typeof(string), filter, typeof(QWidget), parent);
		}
		public static KEncodingFileDialog.Result GetSaveFileNameAndEncoding(string encoding, string startDir, string filter) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getSaveFileNameAndEncoding$$$", "getSaveFileNameAndEncoding(const QString&, const QString&, const QString&)", typeof(KEncodingFileDialog.Result), typeof(string), encoding, typeof(string), startDir, typeof(string), filter);
		}
		public static KEncodingFileDialog.Result GetSaveFileNameAndEncoding(string encoding, string startDir) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getSaveFileNameAndEncoding$$", "getSaveFileNameAndEncoding(const QString&, const QString&)", typeof(KEncodingFileDialog.Result), typeof(string), encoding, typeof(string), startDir);
		}
		public static KEncodingFileDialog.Result GetSaveFileNameAndEncoding(string encoding) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getSaveFileNameAndEncoding$", "getSaveFileNameAndEncoding(const QString&)", typeof(KEncodingFileDialog.Result), typeof(string), encoding);
		}
		public static KEncodingFileDialog.Result GetSaveFileNameAndEncoding() {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getSaveFileNameAndEncoding", "getSaveFileNameAndEncoding()", typeof(KEncodingFileDialog.Result));
		}
		/// <remarks>
		///  Creates a modal file dialog and returns the selected encoding and
		///  filename or an empty string if none was chosen.
		///  Note that with this
		///  method the user need not select an existing filename.
		/// <param> name="startDir" This can either be
		/// </param>
		/// <li>
		/// The URL of the directory to start in.
		/// </li>
		/// 
		/// <li>
		/// a relative path or a filename determining the
		///              directory to start in and the file to be selected.
		/// </li>
		/// 
		/// <li>
		/// string() to start in the current working
		/// 		    directory, or the last directory where a file has been
		/// 		    selected.
		/// </li>
		/// 
		/// <li>
		/// ':&lt;keyword&gt;' to start in the directory last used
		///              by a filedialog in the same application that specified
		///              the same keyword.
		/// </li>
		/// 
		/// <li>
		/// '.&lt;keyword&gt;' to start in the directory last used
		///              by a filedialog in any application that specified the
		///              same keyword.
		/// </li>
		/// <param> name="encoding" The encoding shown in the encoding combo.
		/// </param><param> name="filter" A shell glob or a mime-type-filter that specifies which files to display.
		///     The preferred option is to set a list of mimetype names, see setMimeFilter() for details.
		///     Otherwise you can set the text to be displayed for the each glob, and
		///     provide multiple globs, see setFilter() for details.
		/// </param><param> name="parent" The widget the dialog will be centered on initially.
		/// </param><param> name="caption" The name of the dialog widget.
		///      </param></remarks>		<short>    Creates a modal file dialog and returns the selected encoding and  filename or an empty string if none was chosen.</short>
		public static KEncodingFileDialog.Result GetSaveUrlAndEncoding(string encoding, string startDir, string filter, QWidget parent, string caption) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getSaveUrlAndEncoding$$$#$", "getSaveUrlAndEncoding(const QString&, const QString&, const QString&, QWidget*, const QString&)", typeof(KEncodingFileDialog.Result), typeof(string), encoding, typeof(string), startDir, typeof(string), filter, typeof(QWidget), parent, typeof(string), caption);
		}
		public static KEncodingFileDialog.Result GetSaveUrlAndEncoding(string encoding, string startDir, string filter, QWidget parent) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getSaveUrlAndEncoding$$$#", "getSaveUrlAndEncoding(const QString&, const QString&, const QString&, QWidget*)", typeof(KEncodingFileDialog.Result), typeof(string), encoding, typeof(string), startDir, typeof(string), filter, typeof(QWidget), parent);
		}
		public static KEncodingFileDialog.Result GetSaveUrlAndEncoding(string encoding, string startDir, string filter) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getSaveUrlAndEncoding$$$", "getSaveUrlAndEncoding(const QString&, const QString&, const QString&)", typeof(KEncodingFileDialog.Result), typeof(string), encoding, typeof(string), startDir, typeof(string), filter);
		}
		public static KEncodingFileDialog.Result GetSaveUrlAndEncoding(string encoding, string startDir) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getSaveUrlAndEncoding$$", "getSaveUrlAndEncoding(const QString&, const QString&)", typeof(KEncodingFileDialog.Result), typeof(string), encoding, typeof(string), startDir);
		}
		public static KEncodingFileDialog.Result GetSaveUrlAndEncoding(string encoding) {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getSaveUrlAndEncoding$", "getSaveUrlAndEncoding(const QString&)", typeof(KEncodingFileDialog.Result), typeof(string), encoding);
		}
		public static KEncodingFileDialog.Result GetSaveUrlAndEncoding() {
			return (KEncodingFileDialog.Result) staticInterceptor.Invoke("getSaveUrlAndEncoding", "getSaveUrlAndEncoding()", typeof(KEncodingFileDialog.Result));
		}
		protected new IKEncodingFileDialogSignals Emit {
			get { return (IKEncodingFileDialogSignals) Q_EMIT; }
		}
	}

	public interface IKEncodingFileDialogSignals : IKFileDialogSignals {
	}
}
