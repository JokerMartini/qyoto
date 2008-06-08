//Auto-generated by kalyptus. DO NOT EDIT.
namespace KIO {

	using Kimono;
	using System;
	using Qyoto;

	/// <remarks>
	///   The file-job is an asynchronious version of normal file handling.
	///   It allows block-wise reading and writing, and allows seeking. Results are returned through signals.
	///   Should always be created using KIO.Open(KUrl&)
	///   See <see cref="IFileJobSignals"></see> for signals emitted by FileJob
	/// </remarks>		<short>     The file-job is an asynchronious version of normal file handling.</short>

	[SmokeClass("KIO::FileJob")]
	public class FileJob : KIO.SimpleJob, IDisposable {
 		protected FileJob(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocationKDE(typeof(FileJob), this);
		}
		// void read(KIO::filesize_t arg1); >>>> NOT CONVERTED
		// void seek(KIO::filesize_t arg1); >>>> NOT CONVERTED
		// KIO::filesize_t size(); >>>> NOT CONVERTED
		// KIO::FileJob* FileJob(KIO::FileJobPrivate& arg1); >>>> NOT CONVERTED
		/// <remarks>
		///  Read block
		///  The slave emits the data through data().
		/// <param> name="size" the requested amount of data
		///      </param></remarks>		<short>    Read block </short>
		/// <remarks>
		///  Write block
		/// <param> name="data" the data to write
		///      </param></remarks>		<short>    Write block </short>
		public void Write(QByteArray data) {
			interceptor.Invoke("write#", "write(const QByteArray&)", typeof(void), typeof(QByteArray), data);
		}
		/// <remarks>
		///  Close
		///  Closes the file-slave
		///      </remarks>		<short>    Close </short>
		public void Close() {
			interceptor.Invoke("close", "close()", typeof(void));
		}
		/// <remarks>
		///  Seek
		///  The slave emits position()
		/// <param> name="offset" the position from start to go to
		///      </param></remarks>		<short>    Seek </short>
		/// <remarks>
		///  Size
		/// </remarks>		<return> the file size
		///      </return>
		/// 		<short>    Size </short>
		~FileJob() {
			interceptor.Invoke("~FileJob", "~FileJob()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~FileJob", "~FileJob()", typeof(void));
		}
		protected new IFileJobSignals Emit {
			get { return (IFileJobSignals) Q_EMIT; }
		}
	}

	public interface IFileJobSignals : KIO.ISimpleJobSignals {
		/// <remarks>
		///  Data from the slave has arrived.
		/// <param> name="job" the job that emitted this signal
		/// </param><param> name="data" data received from the slave.
		///      </param></remarks>		<short>    Data from the slave has arrived.</short>
		[Q_SIGNAL("void data(KIO::Job*, const QByteArray&)")]
		void Data(KIO.Job job, QByteArray data);
		/// <remarks>
		///  Signals the file is a redirection.
		///  Follow this url manually to reach data
		/// <param> name="job" the job that emitted this signal
		/// </param><param> name="url" the new URL
		///      </param></remarks>		<short>    Signals the file is a redirection.</short>
		[Q_SIGNAL("void redirection(KIO::Job*, const KUrl&)")]
		void Redirection(KIO.Job job, KUrl url);
		/// <remarks>
		///  Mimetype determined.
		/// <param> name="job" the job that emitted this signal
		/// </param><param> name="type" the mime type
		///      </param></remarks>		<short>    Mimetype determined.</short>
		[Q_SIGNAL("void mimetype(KIO::Job*, const QString&)")]
		void Mimetype(KIO.Job job, string type);
		/// <remarks>
		///  File is open, metadata has been determined and the
		///  file-slave is ready to receive commands.
		/// <param> name="job" the job that emitted this signal
		///      </param></remarks>		<short>    File is open, metadata has been determined and the  file-slave is ready to receive commands.</short>
		[Q_SIGNAL("void open(KIO::Job*)")]
		void Open(KIO.Job job);
		// void written(KIO::Job* arg1,KIO::filesize_t arg2); >>>> NOT CONVERTED
		/// <remarks>
		///  File is closed and will accept no more commands
		/// <param> name="job" the job that emitted this signal
		///      </param></remarks>		<short>    File is closed and will accept no more commands </short>
		[Q_SIGNAL("void close(KIO::Job*)")]
		void Close(KIO.Job job);
		// void position(KIO::Job* arg1,KIO::filesize_t arg2); >>>> NOT CONVERTED
	}
}
