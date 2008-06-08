//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;

	/// <remarks>
	///  The interface to implement to track the progresses of a job.
	///  </remarks>		<short>    The interface to implement to track the progresses of a job.</short>

	[SmokeClass("KJobTrackerInterface")]
	public class KJobTrackerInterface : QObject, IDisposable {
 		protected KJobTrackerInterface(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocationKDE(typeof(KJobTrackerInterface), this);
		}
		/// <remarks>
		///  Creates a new KJobTrackerInterface
		/// <param> name="parent" the parent object
		///      </param></remarks>		<short>    Creates a new KJobTrackerInterface </short>
		public KJobTrackerInterface(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KJobTrackerInterface#", "KJobTrackerInterface(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public KJobTrackerInterface() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KJobTrackerInterface", "KJobTrackerInterface()", typeof(void));
		}
		/// <remarks>
		///  Register a new job in this tracker.
		/// <param> name="job" the job to register
		///      </param></remarks>		<short>    Register a new job in this tracker.</short>
		[SmokeMethod("registerJob(KJob*)")]
		public virtual void RegisterJob(KJob job) {
			interceptor.Invoke("registerJob#", "registerJob(KJob*)", typeof(void), typeof(KJob), job);
		}
		/// <remarks>
		///  Unregister a job from this tracker.
		/// <param> name="job" the job to unregister
		///      </param></remarks>		<short>    Unregister a job from this tracker.</short>
		[SmokeMethod("unregisterJob(KJob*)")]
		public virtual void UnregisterJob(KJob job) {
			interceptor.Invoke("unregisterJob#", "unregisterJob(KJob*)", typeof(void), typeof(KJob), job);
		}
		/// <remarks>
		///  Called when a job is finished, in any case. It is used to notify
		///  that the job is terminated and that progress UI (if any) can be hidden.
		/// <param> name="job" the job that emitted this signal
		///      </param></remarks>		<short>    Called when a job is finished, in any case.</short>
		[Q_SLOT("void finished(KJob*)")]
		[SmokeMethod("finished(KJob*)")]
		protected virtual void Finished(KJob job) {
			interceptor.Invoke("finished#", "finished(KJob*)", typeof(void), typeof(KJob), job);
		}
		/// <remarks>
		///  Called when a job is suspended.
		/// <param> name="job" the job that emitted this signal
		///      </param></remarks>		<short>    Called when a job is suspended.</short>
		[Q_SLOT("void suspended(KJob*)")]
		[SmokeMethod("suspended(KJob*)")]
		protected virtual void Suspended(KJob job) {
			interceptor.Invoke("suspended#", "suspended(KJob*)", typeof(void), typeof(KJob), job);
		}
		/// <remarks>
		///  Called when a job is resumed.
		/// <param> name="job" the job that emitted this signal
		///      </param></remarks>		<short>    Called when a job is resumed.</short>
		[Q_SLOT("void resumed(KJob*)")]
		[SmokeMethod("resumed(KJob*)")]
		protected virtual void Resumed(KJob job) {
			interceptor.Invoke("resumed#", "resumed(KJob*)", typeof(void), typeof(KJob), job);
		}
		/// <remarks>
		///  Called to display general description of a job. A description has
		///  a title and two optional fields which can be used to complete the
		///  description.
		///  Examples of titles are "Copying", "Creating resource", etc.
		///  The fields of the description can be "Source" with an URL, and,
		///  "Destination" with an URL for a "Copying" description.
		/// <param> name="job" the job that emitted this signal
		/// </param><param> name="title" the general description of the job
		/// </param><param> name="field1" first field (localized name and value)
		/// </param><param> name="field2" second field (localized name and value)
		///      </param></remarks>		<short>    Called to display general description of a job.</short>
		[Q_SLOT("void description(KJob*, const QString&, const QPair<QString, QString>&, const QPair<QString, QString>&)")]
		[SmokeMethod("description(KJob*, const QString&, const QPair<QString, QString>&, const QPair<QString, QString>&)")]
		protected virtual void Description(KJob job, string title, QPair<string, string> field1, QPair<string, string> field2) {
			interceptor.Invoke("description#$??", "description(KJob*, const QString&, const QPair<QString, QString>&, const QPair<QString, QString>&)", typeof(void), typeof(KJob), job, typeof(string), title, typeof(QPair<string, string>), field1, typeof(QPair<string, string>), field2);
		}
		/// <remarks>
		///  Called to display state information about a job.
		///  Examples of message are "Resolving host", "Connecting to host...", etc.
		/// <param> name="job" the job that emitted this signal
		/// </param><param> name="plain" the info message
		/// </param><param> name="rich" the rich text version of the message, or string() is none is available
		///      </param></remarks>		<short>    Called to display state information about a job.</short>
		[Q_SLOT("void infoMessage(KJob*, const QString&, const QString&)")]
		[SmokeMethod("infoMessage(KJob*, const QString&, const QString&)")]
		protected virtual void InfoMessage(KJob job, string plain, string rich) {
			interceptor.Invoke("infoMessage#$$", "infoMessage(KJob*, const QString&, const QString&)", typeof(void), typeof(KJob), job, typeof(string), plain, typeof(string), rich);
		}
		/// <remarks>
		///  Emitted to display a warning about a job.
		/// <param> name="job" the job that emitted this signal
		/// </param><param> name="plain" the warning message
		/// </param><param> name="rich" the rich text version of the message, or string() is none is available
		///      </param></remarks>		<short>    Emitted to display a warning about a job.</short>
		[Q_SLOT("void warning(KJob*, const QString&, const QString&)")]
		[SmokeMethod("warning(KJob*, const QString&, const QString&)")]
		protected virtual void Warning(KJob job, string plain, string rich) {
			interceptor.Invoke("warning#$$", "warning(KJob*, const QString&, const QString&)", typeof(void), typeof(KJob), job, typeof(string), plain, typeof(string), rich);
		}
		/// <remarks>
		///  Called when we know the amount a job will have to process. The unit of this
		///  amount is provided too. It can be called several times for a given job if the job
		///  manages several different units.
		/// <param> name="job" the job that emitted this signal
		/// </param><param> name="unit" the unit of the total amount
		/// </param><param> name="amount" the total amount
		///      </param></remarks>		<short>    Called when we know the amount a job will have to process.</short>
		[Q_SLOT("void totalAmount(KJob*, KJob::Unit, qulonglong)")]
		[SmokeMethod("totalAmount(KJob*, KJob::Unit, qulonglong)")]
		protected virtual void TotalAmount(KJob job, KJob.Unit unit, ulong amount) {
			interceptor.Invoke("totalAmount#$$", "totalAmount(KJob*, KJob::Unit, qulonglong)", typeof(void), typeof(KJob), job, typeof(KJob.Unit), unit, typeof(ulong), amount);
		}
		/// <remarks>
		///  Regularly called to show the progress of a job by giving the current amount.
		///  The unit of this amount is provided too. It can be called several times for a given
		///  job if the job manages several different units.
		/// <param> name="job" the job that emitted this signal
		/// </param><param> name="unit" the unit of the processed amount
		/// </param><param> name="amount" the processed amount
		///      </param></remarks>		<short>    Regularly called to show the progress of a job by giving the current amount.</short>
		[Q_SLOT("void processedAmount(KJob*, KJob::Unit, qulonglong)")]
		[SmokeMethod("processedAmount(KJob*, KJob::Unit, qulonglong)")]
		protected virtual void ProcessedAmount(KJob job, KJob.Unit unit, ulong amount) {
			interceptor.Invoke("processedAmount#$$", "processedAmount(KJob*, KJob::Unit, qulonglong)", typeof(void), typeof(KJob), job, typeof(KJob.Unit), unit, typeof(ulong), amount);
		}
		/// <remarks>
		///  Called to show the overall progress of the job.
		///  Note that this is not called for finished jobs.
		/// <param> name="job" the job that emitted this signal
		/// </param><param> name="percent" the percentage
		///      </param></remarks>		<short>    Called to show the overall progress of the job.</short>
		[Q_SLOT("void percent(KJob*, unsigned long)")]
		[SmokeMethod("percent(KJob*, unsigned long)")]
		protected virtual void Percent(KJob job, ulong percent) {
			interceptor.Invoke("percent#$", "percent(KJob*, unsigned long)", typeof(void), typeof(KJob), job, typeof(ulong), percent);
		}
		/// <remarks>
		///  Called to show the speed of the job.
		/// <param> name="job" the job that emitted this signal
		/// </param><param> name="value" the current speed of the job
		///      </param></remarks>		<short>    Called to show the speed of the job.</short>
		[Q_SLOT("void speed(KJob*, unsigned long)")]
		[SmokeMethod("speed(KJob*, unsigned long)")]
		protected virtual void Speed(KJob job, ulong value) {
			interceptor.Invoke("speed#$", "speed(KJob*, unsigned long)", typeof(void), typeof(KJob), job, typeof(ulong), value);
		}
		~KJobTrackerInterface() {
			interceptor.Invoke("~KJobTrackerInterface", "~KJobTrackerInterface()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KJobTrackerInterface", "~KJobTrackerInterface()", typeof(void));
		}
		protected new IKJobTrackerInterfaceSignals Emit {
			get { return (IKJobTrackerInterfaceSignals) Q_EMIT; }
		}
	}

	public interface IKJobTrackerInterfaceSignals : IQObjectSignals {
	}
}
