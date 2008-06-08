//Auto-generated by kalyptus. DO NOT EDIT.
namespace Sonnet {

	using Kimono;
	using System;
	using Qyoto;
	using System.Collections.Generic;

	/// <remarks>
	///  BackgroundChecker is used to perform spell checking without
	///  blocking the application. You can use it as is by calling
	///  the checkText function or subclass it and reimplement
	///  getMoreText function.
	///  The misspelling signal is emitted whenever a misspelled word
	///  is found. The background checker stops right before emitting
	///  the signal. So the parent has to call continueChecking function
	///  to resume the checking.
	///  done signal is emitted when whole text is spell checked.
	///  See <see cref="IBackgroundCheckerSignals"></see> for signals emitted by BackgroundChecker
	/// </remarks>		<author> Zack Rusin <zack@kde.org>
	/// </author>
	/// 		<short> class used for spell checking in the background.</short>

	[SmokeClass("Sonnet::BackgroundChecker")]
	public class BackgroundChecker : QObject, IDisposable {
 		protected BackgroundChecker(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocationKDE(typeof(BackgroundChecker), this);
		}
		public BackgroundChecker(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("BackgroundChecker#", "BackgroundChecker(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public BackgroundChecker() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("BackgroundChecker", "BackgroundChecker()", typeof(void));
		}
		public BackgroundChecker(Sonnet.Speller speller, QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("BackgroundChecker##", "BackgroundChecker(const Sonnet::Speller&, QObject*)", typeof(void), typeof(Sonnet.Speller), speller, typeof(QObject), parent);
		}
		public BackgroundChecker(Sonnet.Speller speller) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("BackgroundChecker#", "BackgroundChecker(const Sonnet::Speller&)", typeof(void), typeof(Sonnet.Speller), speller);
		}
		/// <remarks>
		///  This method is used to spell check static text.
		///  It automatically invokes start().
		///  Use fetchMoreText() with start() to spell check a stream.
		///          </remarks>		<short>    This method is used to spell check static text.</short>
		public void SetText(string text) {
			interceptor.Invoke("setText$", "setText(const QString&)", typeof(void), typeof(string), text);
		}
		public string Text() {
			return (string) interceptor.Invoke("text", "text() const", typeof(string));
		}
		public string CurrentContext() {
			return (string) interceptor.Invoke("currentContext", "currentContext() const", typeof(string));
		}
		public Sonnet.Speller Speller() {
			return (Sonnet.Speller) interceptor.Invoke("speller", "speller() const", typeof(Sonnet.Speller));
		}
		public void SetSpeller(Sonnet.Speller speller) {
			interceptor.Invoke("setSpeller#", "setSpeller(const Sonnet::Speller&)", typeof(void), typeof(Sonnet.Speller), speller);
		}
		public bool CheckWord(string word) {
			return (bool) interceptor.Invoke("checkWord$", "checkWord(const QString&)", typeof(bool), typeof(string), word);
		}
		public List<string> Suggest(string word) {
			return (List<string>) interceptor.Invoke("suggest$", "suggest(const QString&) const", typeof(List<string>), typeof(string), word);
		}
		public bool AddWordToPersonal(string word) {
			return (bool) interceptor.Invoke("addWordToPersonal$", "addWordToPersonal(const QString&)", typeof(bool), typeof(string), word);
		}
		[Q_SLOT("void start()")]
		[SmokeMethod("start()")]
		public virtual void Start() {
			interceptor.Invoke("start", "start()", typeof(void));
		}
		[Q_SLOT("void stop()")]
		[SmokeMethod("stop()")]
		public virtual void Stop() {
			interceptor.Invoke("stop", "stop()", typeof(void));
		}
		[Q_SLOT("void replace(int, const QString&, const QString&)")]
		public void Replace(int start, string oldText, string newText) {
			interceptor.Invoke("replace$$$", "replace(int, const QString&, const QString&)", typeof(void), typeof(int), start, typeof(string), oldText, typeof(string), newText);
		}
		[Q_SLOT("void changeLanguage(const QString&)")]
		public void ChangeLanguage(string lang) {
			interceptor.Invoke("changeLanguage$", "changeLanguage(const QString&)", typeof(void), typeof(string), lang);
		}
		/// <remarks>
		///  After emitting misspelling signal the background
		///  checker stops. The catcher is responsible for calling
		///  continueChecking function to resume checking.
		///          </remarks>		<short>    After emitting misspelling signal the background  checker stops.</short>
		[Q_SLOT("void continueChecking()")]
		[SmokeMethod("continueChecking()")]
		public virtual void ContinueChecking() {
			interceptor.Invoke("continueChecking", "continueChecking()", typeof(void));
		}
		/// <remarks>
		///  This function is called to get the text to spell check.
		///  It will be called continuesly until it returns string()
		///  in which case the done() signal is emitted.
		///  Note: the start parameter in mispelling() is not a combined
		///  position but a position in the last string returned
		///  by fetchMoreText. You need to store the state in the derivatives.
		///          </remarks>		<short>    This function is called to get the text to spell check.</short>
		[SmokeMethod("fetchMoreText()")]
		protected virtual string FetchMoreText() {
			return (string) interceptor.Invoke("fetchMoreText", "fetchMoreText()", typeof(string));
		}
		/// <remarks>
		///  This function will be called whenever the background checker
		///  will be finished text which it got from fetchMoreText.
		///          </remarks>		<short>    This function will be called whenever the background checker  will be finished text which it got from fetchMoreText.</short>
		[SmokeMethod("finishedCurrentFeed()")]
		protected virtual void FinishedCurrentFeed() {
			interceptor.Invoke("finishedCurrentFeed", "finishedCurrentFeed()", typeof(void));
		}
		[Q_SLOT("void slotEngineDone()")]
		protected void SlotEngineDone() {
			interceptor.Invoke("slotEngineDone", "slotEngineDone()", typeof(void));
		}
		~BackgroundChecker() {
			interceptor.Invoke("~BackgroundChecker", "~BackgroundChecker()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~BackgroundChecker", "~BackgroundChecker()", typeof(void));
		}
		protected new IBackgroundCheckerSignals Emit {
			get { return (IBackgroundCheckerSignals) Q_EMIT; }
		}
	}

	public interface IBackgroundCheckerSignals : IQObjectSignals {
		/// <remarks>
		///  Emitted whenever a misspelled word is found
		///          </remarks>		<short>    Emitted whenever a misspelled word is found          </short>
		[Q_SIGNAL("void misspelling(const QString&, int)")]
		void Misspelling(string word, int start);
		/// <remarks>
		///  Emitted after the whole text has been spell checked.
		///          </remarks>		<short>    Emitted after the whole text has been spell checked.</short>
		[Q_SIGNAL("void done()")]
		void Done();
	}
}
