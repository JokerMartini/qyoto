//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;
	using System.Collections.Generic;

	/// <remarks>
	///  @brief A generic "find" dialog.
	///  <b></b>etail:
	///  This widget inherits from KDialog and implements
	///  the following additional functionalities:  a find string
	///  object and an area for a user-defined widget to extend the dialog.
	///  <b></b>xample:
	///  To use the basic modal find dialog, and then run the search:
	///  <pre>
	///   KFindDialog dlg(....)
	///   if ( dlg.exec() != QDialog.Accepted )
	///       return;
	///   // proceed with KFind from here
	///  </pre>
	///  To create a non-modal find dialog:
	///  <pre>
	///    if ( m_findDia )
	///      KWindowSystem.ActivateWindow( m_findDia.WinId() );
	///    else
	///    {
	///      m_findDia = new KFindDialog(false,...);
	///      connect( m_findDia, SIGNAL("okClicked()"), this, SLOT("findTextNext()") );
	///    }
	///  </pre>
	///  Don't forget to delete and reset m_findDia when closed.
	///  (But do NOT delete your KFind object at that point, it's needed for "Find Next")
	///  To use your own extensions: see findExtension().
	///   See <see cref="IKFindDialogSignals"></see> for signals emitted by KFindDialog
	/// </remarks>		<author> S.R.Haque <srhaque@iee.org>
	/// </author>
	/// 		<short>    @brief A generic "find" dialog.</short>

	[SmokeClass("KFindDialog")]
	public class KFindDialog : KDialog, IDisposable {
 		protected KFindDialog(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocationKDE(typeof(KFindDialog), this);
		}
		/// <remarks>
		///  Construct a modal find dialog
		/// <param> name="parent" The parent object of this widget.
		/// </param><param> name="options" A bitfield of the Options to be checked.
		/// </param><param> name="findStrings" The find history, see findHistory()
		/// </param><param> name="hasSelection" Whether a selection exists
		///      </param></remarks>		<short>    Construct a modal find dialog </short>
		public KFindDialog(QWidget parent, long options, List<string> findStrings, bool hasSelection, bool replaceDialog) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KFindDialog#$?$$", "KFindDialog(QWidget*, long, const QStringList&, bool, bool)", typeof(void), typeof(QWidget), parent, typeof(long), options, typeof(List<string>), findStrings, typeof(bool), hasSelection, typeof(bool), replaceDialog);
		}
		public KFindDialog(QWidget parent, long options, List<string> findStrings, bool hasSelection) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KFindDialog#$?$", "KFindDialog(QWidget*, long, const QStringList&, bool)", typeof(void), typeof(QWidget), parent, typeof(long), options, typeof(List<string>), findStrings, typeof(bool), hasSelection);
		}
		public KFindDialog(QWidget parent, long options, List<string> findStrings) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KFindDialog#$?", "KFindDialog(QWidget*, long, const QStringList&)", typeof(void), typeof(QWidget), parent, typeof(long), options, typeof(List<string>), findStrings);
		}
		public KFindDialog(QWidget parent, long options) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KFindDialog#$", "KFindDialog(QWidget*, long)", typeof(void), typeof(QWidget), parent, typeof(long), options);
		}
		public KFindDialog(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KFindDialog#", "KFindDialog(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public KFindDialog() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KFindDialog", "KFindDialog()", typeof(void));
		}
		/// <remarks>
		///  Provide the list of <code>strings</code> to be displayed as the history
		///  of find strings. <code>strings</code> might get truncated if it is
		///  too long.
		/// <param> name="history" The find history.
		/// </param></remarks>		<short>    Provide the list of <code>strings</code> to be displayed as the history  of find strings.</short>
		/// 		<see> findHistory</see>
		public void SetFindHistory(List<string> history) {
			interceptor.Invoke("setFindHistory?", "setFindHistory(const QStringList&)", typeof(void), typeof(List<string>), history);
		}
		/// <remarks>
		///  Returns the list of history items.
		/// </remarks>		<short>    Returns the list of history items.</short>
		/// 		<see> setFindHistory</see>
		public List<string> FindHistory() {
			return (List<string>) interceptor.Invoke("findHistory", "findHistory() const", typeof(List<string>));
		}
		/// <remarks>
		///  Enable/disable the 'search in selection' option, depending
		///  on whether there actually is a selection.
		/// <param> name="hasSelection" true if a selection exists
		///      </param></remarks>		<short>    Enable/disable the 'search in selection' option, depending  on whether there actually is a selection.</short>
		public void SetHasSelection(bool hasSelection) {
			interceptor.Invoke("setHasSelection$", "setHasSelection(bool)", typeof(void), typeof(bool), hasSelection);
		}
		/// <remarks>
		///  Hide/show the 'from cursor' option, depending
		///  on whether the application implements a cursor.
		/// <param> name="hasCursor" true if the application features a cursor
		///  This is assumed to be the case by default.
		///      </param></remarks>		<short>    Hide/show the 'from cursor' option, depending  on whether the application implements a cursor.</short>
		public void SetHasCursor(bool hasCursor) {
			interceptor.Invoke("setHasCursor$", "setHasCursor(bool)", typeof(void), typeof(bool), hasCursor);
		}
		/// <remarks>
		///  Enable/disable the 'Find backwards' option, depending
		///  on whether the application supports it.
		/// <param> name="supports" true if the application supports backwards find
		///  This is assumed to be the case by default.
		///      </param></remarks>		<short>    Enable/disable the 'Find backwards' option, depending  on whether the application supports it.</short>
		public void SetSupportsBackwardsFind(bool supports) {
			interceptor.Invoke("setSupportsBackwardsFind$", "setSupportsBackwardsFind(bool)", typeof(void), typeof(bool), supports);
		}
		/// <remarks>
		///  Enable/disable the 'Case sensitive' option, depending
		///  on whether the application supports it.
		/// <param> name="supports" true if the application supports case sensitive find
		///  This is assumed to be the case by default.
		///      </param></remarks>		<short>    Enable/disable the 'Case sensitive' option, depending  on whether the application supports it.</short>
		public void SetSupportsCaseSensitiveFind(bool supports) {
			interceptor.Invoke("setSupportsCaseSensitiveFind$", "setSupportsCaseSensitiveFind(bool)", typeof(void), typeof(bool), supports);
		}
		/// <remarks>
		///  Enable/disable the 'Whole words only' option, depending
		///  on whether the application supports it.
		/// <param> name="supports" true if the application supports whole words only find
		///  This is assumed to be the case by default.
		///      </param></remarks>		<short>    Enable/disable the 'Whole words only' option, depending  on whether the application supports it.</short>
		public void SetSupportsWholeWordsFind(bool supports) {
			interceptor.Invoke("setSupportsWholeWordsFind$", "setSupportsWholeWordsFind(bool)", typeof(void), typeof(bool), supports);
		}
		/// <remarks>
		///  Enable/disable the 'Regular expression' option, depending
		///  on whether the application supports it.
		/// <param> name="supports" true if the application supports regular expression find
		///  This is assumed to be the case by default.
		///      </param></remarks>		<short>    Enable/disable the 'Regular expression' option, depending  on whether the application supports it.</short>
		public void SetSupportsRegularExpressionFind(bool supports) {
			interceptor.Invoke("setSupportsRegularExpressionFind$", "setSupportsRegularExpressionFind(bool)", typeof(void), typeof(bool), supports);
		}
		/// <remarks>
		///  Set the options which are checked.
		/// <param> name="options" The setting of the Options.
		/// </param></remarks>		<short>    Set the options which are checked.</short>
		/// 		<see> options</see>
		/// 		<see> KFind.Options</see>
		public void SetOptions(long options) {
			interceptor.Invoke("setOptions$", "setOptions(long)", typeof(void), typeof(long), options);
		}
		/// <remarks>
		///  Returns the state of the options. Disabled options may be returned in
		///  an indeterminate state.
		/// </remarks>		<short>    Returns the state of the options.</short>
		/// 		<see> setOptions</see>
		/// 		<see> KFind.Options</see>
		public long Options() {
			return (long) interceptor.Invoke("options", "options() const", typeof(long));
		}
		/// <remarks>
		///  Returns the pattern to find.
		///      </remarks>		<short>    Returns the pattern to find.</short>
		public string Pattern() {
			return (string) interceptor.Invoke("pattern", "pattern() const", typeof(string));
		}
		/// <remarks>
		///  Sets the pattern to find
		///      </remarks>		<short>    Sets the pattern to find      </short>
		public void SetPattern(string pattern) {
			interceptor.Invoke("setPattern$", "setPattern(const QString&)", typeof(void), typeof(string), pattern);
		}
		/// <remarks>
		///  Returns an empty widget which the user may fill with additional UI
		///  elements as required. The widget occupies the width of the dialog,
		///  and is positioned immediately below the regular expression support
		///  widgets for the pattern string.
		///      </remarks>		<short>    Returns an empty widget which the user may fill with additional UI  elements as required.</short>
		public QWidget FindExtension() {
			return (QWidget) interceptor.Invoke("findExtension", "findExtension() const", typeof(QWidget));
		}
		[SmokeMethod("showEvent(QShowEvent*)")]
		protected override void ShowEvent(QShowEvent arg1) {
			interceptor.Invoke("showEvent#", "showEvent(QShowEvent*)", typeof(void), typeof(QShowEvent), arg1);
		}
		~KFindDialog() {
			interceptor.Invoke("~KFindDialog", "~KFindDialog()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KFindDialog", "~KFindDialog()", typeof(void));
		}
		protected new IKFindDialogSignals Emit {
			get { return (IKFindDialogSignals) Q_EMIT; }
		}
	}

	public interface IKFindDialogSignals : IKDialogSignals {
		/// <remarks>
		///  This signal is sent whenever one of the option checkboxes is toggled.
		///  Call options() to get the new state of the checkboxes.
		///      </remarks>		<short>    This signal is sent whenever one of the option checkboxes is toggled.</short>
		[Q_SIGNAL("void optionsChanged()")]
		void OptionsChanged();
	}
}
