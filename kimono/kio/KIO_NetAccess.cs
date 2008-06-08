//Auto-generated by kalyptus. DO NOT EDIT.
namespace KIO {

	using Kimono;
	using System;
	using Qyoto;
	using System.Text;
	using System.Collections.Generic;

	/// <remarks>
	///  Net Transparency.
	///  NetAccess allows you to do simple file operation (load, save,
	///  copy, delete...) without working with KIO.Job directly.
	///  Whereas a KIO.Job is asynchronous, meaning that the
	///  developer has to connect slots for it, KIO.NetAccess provides
	///  synchronous downloads and uploads, as well as temporary file
	///  creation and removal. The functions appear to be blocking,
	///  but the Qt event loop continues running while the operations
	///  are handled. This means that the GUI will not freeze.
	///  This class isn't meant to be used as a class but only as a simple
	///  namespace for static functions, though an instance of the class
	///  is built for internal purposes.
	///  Port to kio done by David Faure, faure@kde.org
	/// </remarks>		<short> Provides an easy, synchronous interface to KIO file operations.    </short>

	[SmokeClass("KIO::NetAccess")]
	public class NetAccess : QObject {
 		protected NetAccess(Type dummy) : base((Type) null) {}
		private static SmokeInvocation staticInterceptor = null;
		static NetAccess() {
			staticInterceptor = new SmokeInvocationKDE(typeof(NetAccess), null);
		}
		public enum StatSide {
			SourceSide = 0,
			DestinationSide = 1,
		}
		/// <remarks>
		///  Downloads a file from an arbitrary URL (<code>src</code>) to a
		///  temporary file on the local filesystem (<code>target</code>).
		///  If the argument
		///  for <code>target</code> is an empty string, download will generate a
		///  unique temporary filename in /tmp. Since <code>target</code> is a reference
		///  to string you can access this filename easily. Download will
		///  return true if the download was successful, otherwise false.
		///  Special case:
		///  If the URL is of kind file:, then no downloading is
		///  processed but the full filename is returned in <code>target.</code>
		///  That means you <b>have</b> to take care about the <code>target</code> argument.
		///  (This is very easy to do, please see the example below.)
		///  Download is synchronous. That means you can use it like this:
		///  (assuming your application has a loadFile() function)
		///  <pre>
		///  string tmpFile;
		///  if( KIO.NetAccess.Download(url, tmpFile, window)) {
		///      loadFile(tmpFile);
		///      KIO.NetAccess.RemoveTempFile(tmpFile);
		///  } else {
		///      KMessageBox.Error(this, KIO.NetAccess.LastErrorString());
		///  }
		///  </pre>
		///  Of course, your user interface will still process exposure/repaint
		///  events during the download.
		///  If the download fails, lastError() and lastErrorString() will be set.
		///  If the url is always remote, then you could also just write the more usual way:
		///  <pre>
		///  KTemporaryFile tmpFile;
		///  if (tmpFile.open()) {
		///      KIO.Job getJob = KIO.File_copy(url, KUrl(tmpFile.fileName()), -1, KIO.Overwrite | KIO.HideProgressInfo);
		///      getJob.Ui().SetWindow(window);
		///      if (KIO.NetAccess.SynchronousRun(getJob, 0)) {
		///          loadFile(tmpFile.fileName());
		///      } else {
		///          getJob.Ui().ShowErrorMessage();
		///      }
		///  }
		///  </pre>
		/// <param> name="src" URL Reference to the file to download.
		/// </param><param> name="target" String containing the final local location of the
		///                file.  If you insert an empty string, it will
		///                return a location in a temporary spot. <B>Note:</B>
		///                you are responsible for the removal of this file when
		///                you are finished reading it using removeTempFile.
		/// </param><param> name="window" main window associated with this job. This is used to
		///                automatically cache and discard authentication information
		///                as needed. If NULL, authentication information will be
		///                cached only for a short duration after which the user will
		///                again be prompted for passwords as needed.
		/// </param></remarks>		<return> true if successful, false for failure.  Use lastErrorString() to
		///          get the reason it failed.
		/// </return>
		/// 		<short>    Downloads a file from an arbitrary URL (<code>src</code>) to a  temporary file on the local filesystem (<code>target</code>).</short>
		/// 		<see> lastErrorString</see>
		public static bool Download(KUrl src, StringBuilder target, QWidget window) {
			return (bool) staticInterceptor.Invoke("download#$#", "download(const KUrl&, QString&, QWidget*)", typeof(bool), typeof(KUrl), src, typeof(StringBuilder), target, typeof(QWidget), window);
		}
		/// <remarks>
		///  Removes the specified file if and only if it was created
		///  by KIO.NetAccess as a temporary file for a former download.
		///  Note: This means that if you created your temporary with KTempFile,
		///  use KTempFile.Unlink() or KTempFile.SetAutoDelete() to have
		///  it removed.
		/// <param> name="name" Path to temporary file to remove.  May not be
		///              empty.
		///      </param></remarks>		<short>    Removes the specified file if and only if it was created  by KIO.NetAccess as a temporary file for a former download.</short>
		public static void RemoveTempFile(string name) {
			staticInterceptor.Invoke("removeTempFile$", "removeTempFile(const QString&)", typeof(void), typeof(string), name);
		}
		/// <remarks>
		///  Uploads file <code>src</code> to URL <code>target.</code>
		///  Both must be specified, unlike download.
		///  Note that this is assumed to be used for saving a file over
		///  the network, so overwriting is set to true. This is not the
		///  case with copy.
		/// <param> name="src" URL Referencing the file to upload.
		/// </param><param> name="target" URL containing the final location of the file.
		/// </param><param> name="window" main window associated with this job. This is used to
		///                automatically cache and discard authentication information
		///                as needed. If NULL, authentication information will be cached
		///                only for a short duration after which the user will again be
		///                prompted for passwords as needed.
		/// </param></remarks>		<return> true if successful, false for failure
		///      </return>
		/// 		<short>    Uploads file <code>src</code> to URL <code>target.</code></short>
		public static bool Upload(string src, KUrl target, QWidget window) {
			return (bool) staticInterceptor.Invoke("upload$##", "upload(const QString&, const KUrl&, QWidget*)", typeof(bool), typeof(string), src, typeof(KUrl), target, typeof(QWidget), window);
		}
		/// <remarks>
		///  Alternative to upload for copying over the network.
		///  Overwrite is false, so this will fail if <code>target</code> exists.
		///  This one takes two URLs and is a direct equivalent of KIO.File_copy.
		/// <param> name="src" URL Referencing the file to upload.
		/// </param><param> name="target" URL containing the final location of the file.
		/// </param><param> name="window" main window associated with this job. This is used to
		///                automatically cache and discard authentication information
		///                as needed. If NULL, authentication information will be cached
		///                only for a short duration after which the user will again be
		///                prompted for passwords as needed.
		/// </param></remarks>		<return> true if successful, false for failure
		///      </return>
		/// 		<short>    Alternative to upload for copying over the network.</short>
		public static bool File_copy(KUrl src, KUrl target, QWidget window) {
			return (bool) staticInterceptor.Invoke("file_copy###", "file_copy(const KUrl&, const KUrl&, QWidget*)", typeof(bool), typeof(KUrl), src, typeof(KUrl), target, typeof(QWidget), window);
		}
		public static bool File_copy(KUrl src, KUrl target) {
			return (bool) staticInterceptor.Invoke("file_copy##", "file_copy(const KUrl&, const KUrl&)", typeof(bool), typeof(KUrl), src, typeof(KUrl), target);
		}
		/// <remarks>
		///  Alternative method for copying over the network.
		///  This one takes two URLs and is a direct equivalent
		///  of KIO.Copy!.
		///  This means that it can copy files and directories alike
		///  (it should have been named copy()).
		///  This method will bring up a dialog if the destination already exists.
		/// <param> name="src" URL Referencing the file to upload.
		/// </param><param> name="target" URL containing the final location of the
		///                file.
		/// </param><param> name="window" main window associated with this job. This is used to
		///                automatically cache and discard authentication information
		///                as needed. If NULL, authentication information will be cached
		///                only for a short duration after which the user will again be
		///                prompted for passwords as needed.
		/// </param></remarks>		<return> true if successful, false for failure
		///      </return>
		/// 		<short>    Alternative method for copying over the network.</short>
		public static bool Dircopy(KUrl src, KUrl target, QWidget window) {
			return (bool) staticInterceptor.Invoke("dircopy###", "dircopy(const KUrl&, const KUrl&, QWidget*)", typeof(bool), typeof(KUrl), src, typeof(KUrl), target, typeof(QWidget), window);
		}
		/// <remarks>
		///  Overloaded method, which takes a list of source URLs
		///      </remarks>		<short>    Overloaded method, which takes a list of source URLs      </short>
		public static bool Dircopy(List<KUrl> src, KUrl target, QWidget window) {
			return (bool) staticInterceptor.Invoke("dircopy?##", "dircopy(const KUrl::List&, const KUrl&, QWidget*)", typeof(bool), typeof(List<KUrl>), src, typeof(KUrl), target, typeof(QWidget), window);
		}
		public static bool Dircopy(List<KUrl> src, KUrl target) {
			return (bool) staticInterceptor.Invoke("dircopy?#", "dircopy(const KUrl::List&, const KUrl&)", typeof(bool), typeof(List<KUrl>), src, typeof(KUrl), target);
		}
		/// <remarks>
		///  Tests whether a URL exists.
		/// <param> name="url" the URL we are testing
		/// </param><param> name="statSide" determines if we want to read or write.
		///  IMPORTANT: see documentation for KIO.Stat for more details about this.
		/// </param><param> name="window" main window associated with this job. This is used to
		///                automatically cache and discard authentication information
		///                as needed. If NULL, authentication information will be
		///                cached only for a short duration after which the user will
		///                again be prompted for passwords as needed.
		/// </param></remarks>		<return> true if the URL exists and we can do the operation specified by
		///               <code>source</code>, false otherwise
		///      </return>
		/// 		<short>    Tests whether a URL exists.</short>
		public static bool Exists(KUrl url, KIO.NetAccess.StatSide statSide, QWidget window) {
			return (bool) staticInterceptor.Invoke("exists#$#", "exists(const KUrl&, KIO::NetAccess::StatSide, QWidget*)", typeof(bool), typeof(KUrl), url, typeof(KIO.NetAccess.StatSide), statSide, typeof(QWidget), window);
		}
		/// <remarks>
		///  Tests whether a URL exists and return information on it.
		///  This is a convenience function for KIO.Stat
		///  (it saves creating a slot and testing for the job result).
		/// <param> name="url" The URL we are testing.
		/// </param><param> name="entry" The result of the stat. Iterate over the list
		///  of atoms to get hold of name, type, size, etc., or use KFileItem.
		/// </param><param> name="window" main window associated with this job. This is used to
		///                automatically cache and discard authentication information
		///                as needed. If NULL, authentication information will be
		///                cached only for a short duration after which the user will
		///                again be prompted for passwords as needed.
		/// </param></remarks>		<return> true if successful, false for failure
		///      </return>
		/// 		<short>    Tests whether a URL exists and return information on it.</short>
		public static bool Stat(KUrl url, KIO.UDSEntry entry, QWidget window) {
			return (bool) staticInterceptor.Invoke("stat###", "stat(const KUrl&, KIO::UDSEntry&, QWidget*)", typeof(bool), typeof(KUrl), url, typeof(KIO.UDSEntry), entry, typeof(QWidget), window);
		}
		/// <remarks>
		///  Tries to map a local URL for the given URL.
		///  This is a convenience function for KIO.Stat + parsing the
		///  resulting UDSEntry.
		/// <param> name="url" The URL we are testing.
		/// </param><param> name="window" main window associated with this job. This is used to
		///                automatically cache and discard authentication information
		///                as needed. If NULL, authentication information will be
		///                cached only for a short duration after which the user will
		///                again be prompted for passwords as needed.
		/// </param></remarks>		<return> a local URL corresponding to the same ressource than the
		///          original URL, or the original URL if no local URL can be mapped
		///      </return>
		/// 		<short>    Tries to map a local URL for the given URL.</short>
		public static KUrl MostLocalUrl(KUrl url, QWidget window) {
			return (KUrl) staticInterceptor.Invoke("mostLocalUrl##", "mostLocalUrl(const KUrl&, QWidget*)", typeof(KUrl), typeof(KUrl), url, typeof(QWidget), window);
		}
		/// <remarks>
		///  Deletes a file or a directory in a synchronous way.
		///  This is a convenience function for KIO.Del
		///  (it saves creating a slot and testing for the job result).
		/// <param> name="url" The file or directory to delete.
		/// </param><param> name="window" main window associated with this job. This is used to
		///                automatically cache and discard authentication information
		///                as needed. If NULL, authentication information will be
		///                cached only for a short duration after which the user will
		///                again be prompted for passwords as needed.
		/// </param></remarks>		<return> true on success, false on failure.
		///      </return>
		/// 		<short>    Deletes a file or a directory in a synchronous way.</short>
		public static bool Del(KUrl url, QWidget window) {
			return (bool) staticInterceptor.Invoke("del##", "del(const KUrl&, QWidget*)", typeof(bool), typeof(KUrl), url, typeof(QWidget), window);
		}
		/// <remarks>
		///  Creates a directory in a synchronous way.
		///  This is a convenience function for <code>KIO</code>.Mkdir
		///  (it saves creating a slot and testing for the job result).
		/// <param> name="url" The directory to create.
		/// </param><param> name="window" main window associated with this job. This is used to
		///                automatically cache and discard authentication information
		///                as needed. If NULL, authentication information will be
		///                cached only for a short duration after which the user will
		///                again be prompted for passwords as needed.
		/// </param><param> name="permissions" directory permissions.
		/// </param></remarks>		<return> true on success, false on failure.
		///      </return>
		/// 		<short>    Creates a directory in a synchronous way.</short>
		public static bool Mkdir(KUrl url, QWidget window, int permissions) {
			return (bool) staticInterceptor.Invoke("mkdir##$", "mkdir(const KUrl&, QWidget*, int)", typeof(bool), typeof(KUrl), url, typeof(QWidget), window, typeof(int), permissions);
		}
		public static bool Mkdir(KUrl url, QWidget window) {
			return (bool) staticInterceptor.Invoke("mkdir##", "mkdir(const KUrl&, QWidget*)", typeof(bool), typeof(KUrl), url, typeof(QWidget), window);
		}
		/// <remarks>
		///  Executes a remote process via the fish ioslave in a synchronous way.
		/// <param> name="url" The remote machine where the command should be executed.
		///             e.g. fish://someuser\@somehost:sshport/
		///             some special cases exist.
		///             fish://someuser\@localhost/
		///             will use su instead of ssh to connect and execute the command.
		///             fish://someuser\@localhost:port/
		///             will use ssh to connect and execute the command.
		/// </param><param> name="command" The command to be executed.
		/// </param><param> name="window" main window associated with this job. This is used to
		///                automatically cache and discard authentication information
		///                as needed. If NULL, authentication information will be
		///                cached only for a short duration after which the user will
		///                again be prompted for passwords as needed.
		/// </param></remarks>		<return> The resulting output of the <code>command</code> that is executed.
		///      </return>
		/// 		<short>    Executes a remote process via the fish ioslave in a synchronous way.</short>
		public static string Fish_execute(KUrl url, string command, QWidget window) {
			return (string) staticInterceptor.Invoke("fish_execute#$#", "fish_execute(const KUrl&, const QString&, QWidget*)", typeof(string), typeof(KUrl), url, typeof(string), command, typeof(QWidget), window);
		}
		/// <remarks>
		///  This function executes a job in a synchronous way.
		///  If a job fetches some data, pass a QByteArray pointer as data parameter to this function
		///  and after the function returns it will contain all the data fetched by this job.
		///  @code
		///  KIO.Job job = KIO.Get( url );
		///  QMap<string, string> metaData;
		///  metaData.insert( "PropagateHttpHeader", "true" );
		///  if ( NetAccess.SynchronousRun( job, 0, &data, &url, &metaData ) ) {
		///    string responseHeaders = metaData[ "HTTP-Headers" ];
		///    kDebug()<<"Response header = "<< responseHeaders;
		///  }
		///  @endcode
		/// <param> name="job" job which the function will run. Note that after this function
		///             finishes running, job is deleted and you can't access it anymore!
		/// </param><param> name="window" main window associated with this job. This is used to
		///                automatically cache and discard authentication information
		///                as needed. If NULL, authentication information will be
		///                cached only for a short duration after which the user will
		///                again be prompted for passwords as needed.
		/// </param><param> name="data" if passed and relevant to this job then it will contain the data
		///                that was fetched by the job
		/// </param><param> name="finalURL" if passed will contain the final url of this job (it might differ
		///                  from the one it was created with if there was a redirection)
		/// </param><param> name="metaData" you can pass a pointer to the map with meta data you wish to
		///                  set on the job. After the job finishes this map will hold all the
		///                  meta data from the job.
		/// </param></remarks>		<return> true on success, false on failure.
		///      </return>
		/// 		<short>    This function executes a job in a synchronous way.</short>
		public static bool SynchronousRun(KIO.Job job, QWidget window, QByteArray data, KUrl finalURL, StringBuilder metaData) {
			return (bool) staticInterceptor.Invoke("synchronousRun####?", "synchronousRun(KIO::Job*, QWidget*, QByteArray*, KUrl*, QMap<QString, QString>*)", typeof(bool), typeof(KIO.Job), job, typeof(QWidget), window, typeof(QByteArray), data, typeof(KUrl), finalURL, typeof(StringBuilder), metaData);
		}
		public static bool SynchronousRun(KIO.Job job, QWidget window, QByteArray data, KUrl finalURL) {
			return (bool) staticInterceptor.Invoke("synchronousRun####", "synchronousRun(KIO::Job*, QWidget*, QByteArray*, KUrl*)", typeof(bool), typeof(KIO.Job), job, typeof(QWidget), window, typeof(QByteArray), data, typeof(KUrl), finalURL);
		}
		public static bool SynchronousRun(KIO.Job job, QWidget window, QByteArray data) {
			return (bool) staticInterceptor.Invoke("synchronousRun###", "synchronousRun(KIO::Job*, QWidget*, QByteArray*)", typeof(bool), typeof(KIO.Job), job, typeof(QWidget), window, typeof(QByteArray), data);
		}
		public static bool SynchronousRun(KIO.Job job, QWidget window) {
			return (bool) staticInterceptor.Invoke("synchronousRun##", "synchronousRun(KIO::Job*, QWidget*)", typeof(bool), typeof(KIO.Job), job, typeof(QWidget), window);
		}
		/// <remarks>
		///  Determines the mimetype of a given URL.
		///  This is a convenience function for KIO.Mimetype.  You
		///  should call this only when really necessary.
		///  KMimeType.FindByUrl can determine extension a lot faster, but
		///  less reliably for remote files. Only when findByUrl() returns
		///  unknown (application/octet-stream) then this one should be
		///  used.
		/// <param> name="url" The URL whose mimetype we are interested in.
		/// </param><param> name="window" main window associated with this job. This is used to
		///                automatically cache and discard authentication information
		///                as needed. If NULL, authentication information will be
		///                cached only for a short duration after which the user will
		///                again be prompted for passwords as needed.
		/// </param></remarks>		<return> The mimetype name.
		///      </return>
		/// 		<short>    Determines the mimetype of a given URL.</short>
		public static string Mimetype(KUrl url, QWidget window) {
			return (string) staticInterceptor.Invoke("mimetype##", "mimetype(const KUrl&, QWidget*)", typeof(string), typeof(KUrl), url, typeof(QWidget), window);
		}
		/// <remarks>
		///  Returns the error string for the last job, in case it failed.
		///  Note that this is already translated.
		/// </remarks>		<return> the last error string, or string()
		///      </return>
		/// 		<short>    Returns the error string for the last job, in case it failed.</short>
		public static string LastErrorString() {
			return (string) staticInterceptor.Invoke("lastErrorString", "lastErrorString()", typeof(string));
		}
		/// <remarks>
		///  Returns the error code for the last job, in case it failed.
		/// </remarks>		<return> the last error code
		///      </return>
		/// 		<short>    Returns the error code for the last job, in case it failed.</short>
		public static int LastError() {
			return (int) staticInterceptor.Invoke("lastError", "lastError()", typeof(int));
		}
		protected new INetAccessSignals Emit {
			get { return (INetAccessSignals) Q_EMIT; }
		}
	}

	public interface INetAccessSignals : IQObjectSignals {
	}
}
