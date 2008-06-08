//Auto-generated by kalyptus. DO NOT EDIT.
namespace KIO {

	using Kimono;
	using System;
	using Qyoto;
	using System.Collections.Generic;

	/// <remarks>
	///  CopyJob is used to move, copy or symlink files and directories.
	///  Don't create the job directly, but use KIO.Copy(),
	///  KIO.Move(), KIO.Link() and friends.
	///  See <see cref="ICopyJobSignals"></see> for signals emitted by CopyJob
	/// </remarks>		<short>    CopyJob is used to move, copy or symlink files and directories.</short>
	/// 		<see> copy</see>
	/// 		<see> copyAs</see>
	/// 		<see> move</see>
	/// 		<see> moveAs</see>
	/// 		<see> link</see>
	/// 		<see> linkAs</see>

	[SmokeClass("KIO::CopyJob")]
	public class CopyJob : KIO.Job {
 		protected CopyJob(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocationKDE(typeof(CopyJob), this);
		}
		/// <remarks>
		///  Defines the mode of the operation
		/// 	 </remarks>		<short>    Defines the mode of the operation 	 </short>
		public enum CopyMode {
			Copy = 0,
			Move = 1,
			Link = 2,
		}
		// KIO::CopyJob* CopyJob(KIO::CopyJobPrivate& arg1); >>>> NOT CONVERTED
		/// <remarks>
		///  Returns the mode of the operation (copy, move, or link),
		///  depending on whether KIO.Copy(), KIO.Move() or KIO.Link() was called.
		/// 	 </remarks>		<short>    Returns the mode of the operation (copy, move, or link),  depending on whether KIO.Copy(), KIO.Move() or KIO.Link() was called.</short>
		public KIO.CopyJob.CopyMode OperationMode() {
			return (KIO.CopyJob.CopyMode) interceptor.Invoke("operationMode", "operationMode() const", typeof(KIO.CopyJob.CopyMode));
		}
		/// <remarks>
		///  Returns the list of source URLs.
		/// </remarks>		<return> the list of source URLs.
		/// 	 </return>
		/// 		<short>    Returns the list of source URLs.</short>
		public List<KUrl> SrcUrls() {
			return (List<KUrl>) interceptor.Invoke("srcUrls", "srcUrls() const", typeof(List<KUrl>));
		}
		/// <remarks>
		///  Returns the destination URL.
		/// </remarks>		<return> the destination URL
		/// 	 </return>
		/// 		<short>    Returns the destination URL.</short>
		public KUrl DestUrl() {
			return (KUrl) interceptor.Invoke("destUrl", "destUrl() const", typeof(KUrl));
		}
		/// <remarks>
		///  By default the permissions of the copied files will be those of the source files.
		///  But when copying "template" files to "new" files, people prefer the umask
		///  to apply, rather than the template's permissions.
		///  For that case, call setDefaultPermissions(true)
		///          </remarks>		<short>    By default the permissions of the copied files will be those of the source files.</short>
		public void SetDefaultPermissions(bool b) {
			interceptor.Invoke("setDefaultPermissions$", "setDefaultPermissions(bool)", typeof(void), typeof(bool), b);
		}
		/// <remarks>
		///  Reimplemented for internal reasons
		///          </remarks>		<short>    Reimplemented for internal reasons          </short>
		[SmokeMethod("doSuspend()")]
		public new virtual bool DoSuspend() {
			return (bool) interceptor.Invoke("doSuspend", "doSuspend()", typeof(bool));
		}
		[Q_SLOT("void slotResult(KJob*)")]
		[SmokeMethod("slotResult(KJob*)")]
		protected override void SlotResult(KJob job) {
			interceptor.Invoke("slotResult#", "slotResult(KJob*)", typeof(void), typeof(KJob), job);
		}
		protected new ICopyJobSignals Emit {
			get { return (ICopyJobSignals) Q_EMIT; }
		}
	}

	public interface ICopyJobSignals : KIO.IJobSignals {
		/// <remarks>
		///  Emitted when the total number of files is known.
		/// <param> name="job" the job that emitted this signal
		/// </param><param> name="files" the total number of files
		/// 	 </param></remarks>		<short>    Emitted when the total number of files is known.</short>
		[Q_SIGNAL("void totalFiles(KJob*, unsigned long)")]
		void TotalFiles(KJob job, ulong files);
		/// <remarks>
		///  Emitted when the toal number of direcotries is known.
		/// <param> name="job" the job that emitted this signal
		/// </param><param> name="dirs" the total number of directories
		/// 	 </param></remarks>		<short>    Emitted when the toal number of direcotries is known.</short>
		[Q_SIGNAL("void totalDirs(KJob*, unsigned long)")]
		void TotalDirs(KJob job, ulong dirs);
		/// <remarks>
		///  Emitted when it is known which files / directories are going
		///  to be created. Note that this may still change e.g. when
		///  existing files with the same name are discovered.
		/// <param> name="job" the job that emitted this signal
		/// </param><param> name="files" a list of items that are about to be created.
		/// 	 </param></remarks>		<short>    Emitted when it is known which files / directories are going  to be created.</short>
		[Q_SIGNAL("void aboutToCreate(KIO::Job*, const QList<KIO::CopyInfo>&)")]
		void AboutToCreate(KIO.Job job, List<KIO.CopyInfo> files);
		/// <remarks>
		///  Sends the number of processed files.
		/// <param> name="job" the job that emitted this signal
		/// </param><param> name="files" the number of processed files
		/// 	 </param></remarks>		<short>    Sends the number of processed files.</short>
		[Q_SIGNAL("void processedFiles(KIO::Job*, unsigned long)")]
		void ProcessedFiles(KIO.Job job, ulong files);
		/// <remarks>
		///  Sends the number of processed directories.
		/// <param> name="job" the job that emitted this signal
		/// </param><param> name="dirs" the number of processed dirs
		/// 	 </param></remarks>		<short>    Sends the number of processed directories.</short>
		[Q_SIGNAL("void processedDirs(KIO::Job*, unsigned long)")]
		void ProcessedDirs(KIO.Job job, ulong dirs);
		/// <remarks>
		///  The job is copying a file or directory.
		///  Note: This signal is used for progress dialogs, it's not emitted for
		///  every file or directory (this would be too slow), but every 200ms.
		/// <param> name="job" the job that emitted this signal
		/// </param><param> name="src" the URL of the file or directory that is currently
		///              being copied
		/// </param><param> name="dest" the destination of the current operation
		///          </param></remarks>		<short>    The job is copying a file or directory.</short>
		[Q_SIGNAL("void copying(KIO::Job*, const KUrl&, const KUrl&)")]
		void Copying(KIO.Job job, KUrl src, KUrl dest);
		/// <remarks>
		///  The job is creating a symbolic link.
		///  Note: This signal is used for progress dialogs, it's not emitted for
		///  every file or directory (this would be too slow), but every 200ms.
		/// <param> name="job" the job that emitted this signal
		/// </param><param> name="target" the URL of the file or directory that is currently
		///              being linked
		/// </param><param> name="to" the destination of the current operation
		///          </param></remarks>		<short>    The job is creating a symbolic link.</short>
		[Q_SIGNAL("void linking(KIO::Job*, const QString&, const KUrl&)")]
		void Linking(KIO.Job job, string target, KUrl to);
		/// <remarks>
		///  The job is moving a file or directory.
		///  Note: This signal is used for progress dialogs, it's not emitted for
		///  every file or directory (this would be too slow), but every 200ms.
		/// <param> name="job" the job that emitted this signal
		/// </param><param> name="from" the URL of the file or directory that is currently
		///              being moved
		/// </param><param> name="to" the destination of the current operation
		///          </param></remarks>		<short>    The job is moving a file or directory.</short>
		[Q_SIGNAL("void moving(KIO::Job*, const KUrl&, const KUrl&)")]
		void Moving(KIO.Job job, KUrl from, KUrl to);
		/// <remarks>
		///  The job is creating the directory <code>dir.</code>
		///  This signal is emitted for every directory being created.
		/// <param> name="job" the job that emitted this signal
		/// </param><param> name="dir" the directory that is currently being created
		///          </param></remarks>		<short>    The job is creating the directory <code>dir.</code></short>
		[Q_SIGNAL("void creatingDir(KIO::Job*, const KUrl&)")]
		void CreatingDir(KIO.Job job, KUrl dir);
		/// <remarks>
		///  The user chose to rename <code>from</code> to <code>to.</code>
		/// <param> name="job" the job that emitted this signal
		/// </param><param> name="from" the original name
		/// </param><param> name="to" the new name
		///          </param></remarks>		<short>    The user chose to rename <code>from</code> to <code>to.</code></short>
		[Q_SIGNAL("void renamed(KIO::Job*, const KUrl&, const KUrl&)")]
		void Renamed(KIO.Job job, KUrl from, KUrl to);
		/// <remarks>
		///  The job emits this signal when copying or moving a file or directory successfully finished.
		///  This signal is mainly for the Undo feature.
		///  If you simply want to know when a copy job is done, use result().
		/// <param> name="job" the job that emitted this signal
		/// </param><param> name="from" the source URL
		/// </param><param> name="to" the destination URL
		/// </param><param> name="mtime" the modification time of the source file, hopefully set on the destination file
		///  too (when the kioslave supports it).
		/// </param><param> name="directory" indicates whether a file or directory was successfully copied/moved.
		///                   true for a directory, false for file
		/// </param><param> name="renamed" indicates that the destination URL was created using a
		///  rename operation (i.e. fast directory moving). true if is has been renamed
		///          </param></remarks>		<short>    The job emits this signal when copying or moving a file or directory successfully finished.</short>
		[Q_SIGNAL("void copyingDone(KIO::Job*, const KUrl&, const KUrl&, time_t, bool, bool)")]
		void CopyingDone(KIO.Job job, KUrl from, KUrl to, int mtime, bool directory, bool renamed);
		/// <remarks>
		///  The job is copying or moving a symbolic link, that points to target.
		///  The new link is created in <code>to.</code> The existing one is/was in <code>from.</code>
		///  This signal is mainly for the Undo feature.
		/// <param> name="job" the job that emitted this signal
		/// </param><param> name="from" the source URL
		/// </param><param> name="target" the target
		/// </param><param> name="to" the destination URL
		///          </param></remarks>		<short>    The job is copying or moving a symbolic link, that points to target.</short>
		[Q_SIGNAL("void copyingLinkDone(KIO::Job*, const KUrl&, const QString&, const KUrl&)")]
		void CopyingLinkDone(KIO.Job job, KUrl from, string target, KUrl to);
	}
}
