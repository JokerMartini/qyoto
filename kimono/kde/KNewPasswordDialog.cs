//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;

	/// <remarks>
	///  This dialog asks the user to enter a password.
	///  \image html kpassworddialog.png "KDE Password Dialog"
	///  \section usage Usage Exemple
	///  \subsection asynchronous Asynchronous
	///  <pre>
	///   KNewPasswordDialog dlg = new KNewPasswordDialog( parent );
	///   dlg.SetPrompt( i18n( "Enter a password" );
	///   connect( dlg, SIGNAL("newPassword( string )")  , this, SLOT("setPassword( string)") );
	///   connect( dlg, SIGNAL("rejected()")  , this, SLOT("slotCancel()") );
	///   dlg.Show();
	///  </pre>
	///  \subsection synchronous Synchronous
	///  <pre>
	///   KNewPasswordDialog dlg( parent );
	///   dlg.setPrompt( i18n( "Enter a password" );
	///   if( dlg.exec() )
	///       setPassword( dlg.password() );
	///  </pre>
	///  See <see cref="IKNewPasswordDialogSignals"></see> for signals emitted by KNewPasswordDialog
	/// </remarks>		<author> Olivier Goffart <ogoffart@kde.org>
	///  </author>
	/// 		<short> A password input dialog. </short>

	[SmokeClass("KNewPasswordDialog")]
	public class KNewPasswordDialog : KDialog, IDisposable {
 		protected KNewPasswordDialog(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocationKDE(typeof(KNewPasswordDialog), this);
		}
		/// <remarks>
		///  Constructs a password dialog.
		/// <param> name="parent" Passed to lower level constructor.
		///      </param></remarks>		<short>    Constructs a password dialog.</short>
		public KNewPasswordDialog(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KNewPasswordDialog#", "KNewPasswordDialog(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public KNewPasswordDialog() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KNewPasswordDialog", "KNewPasswordDialog()", typeof(void));
		}
		/// <remarks>
		///  Sets the password prompt.
		///      </remarks>		<short>    Sets the password prompt.</short>
		public void SetPrompt(string prompt) {
			interceptor.Invoke("setPrompt$", "setPrompt(const QString&)", typeof(void), typeof(string), prompt);
		}
		/// <remarks>
		///  Returns the password prompt.
		///      </remarks>		<short>    Returns the password prompt.</short>
		public string Prompt() {
			return (string) interceptor.Invoke("prompt", "prompt() const", typeof(string));
		}
		/// <remarks>
		///  Sets the pixmap that appears next to the prompt in the dialog.  The default pixmap represent a simple key.
		///  the recommended size is KIconLoader.SizeHuge
		///      </remarks>		<short>    Sets the pixmap that appears next to the prompt in the dialog.</short>
		public void SetPixmap(QPixmap arg1) {
			interceptor.Invoke("setPixmap#", "setPixmap(const QPixmap&)", typeof(void), typeof(QPixmap), arg1);
		}
		/// <remarks>
		///  Returns the pixmap that appears next to the prompt in the dialog
		///      </remarks>		<short>    Returns the pixmap that appears next to the prompt in the dialog      </short>
		public QPixmap Pixmap() {
			return (QPixmap) interceptor.Invoke("pixmap", "pixmap() const", typeof(QPixmap));
		}
		/// <remarks>
		///  Allow empty passwords? - Default: true
		///  same as setMinimumPasswordLength( allowed ? 0 : 1 )
		///      </remarks>		<short>    Allow empty passwords? - Default: true </short>
		public void SetAllowEmptyPasswords(bool allowed) {
			interceptor.Invoke("setAllowEmptyPasswords$", "setAllowEmptyPasswords(bool)", typeof(void), typeof(bool), allowed);
		}
		/// <remarks>
		///  Allow empty passwords?
		/// </remarks>		<return> true if minimumPasswordLength() == 0
		///      </return>
		/// 		<short>    Allow empty passwords? </short>
		public bool AllowEmptyPasswords() {
			return (bool) interceptor.Invoke("allowEmptyPasswords", "allowEmptyPasswords() const", typeof(bool));
		}
		/// <remarks>
		///  Minimum acceptable password length.
		///  Default: 0
		/// <param> name="minLength" : The new minimum password length
		///      </param></remarks>		<short>    Minimum acceptable password length.</short>
		public void SetMinimumPasswordLength(int minLength) {
			interceptor.Invoke("setMinimumPasswordLength$", "setMinimumPasswordLength(int)", typeof(void), typeof(int), minLength);
		}
		/// <remarks>
		///  Minimum acceptable password length.
		///      </remarks>		<short>    Minimum acceptable password length.</short>
		public int MinimumPasswordLength() {
			return (int) interceptor.Invoke("minimumPasswordLength", "minimumPasswordLength() const", typeof(int));
		}
		/// <remarks>
		///  Maximum acceptable password length.
		/// <param> name="maxLength" : The new maximum password length.
		///      </param></remarks>		<short>    Maximum acceptable password length.</short>
		public void SetMaximumPasswordLength(int maxLength) {
			interceptor.Invoke("setMaximumPasswordLength$", "setMaximumPasswordLength(int)", typeof(void), typeof(int), maxLength);
		}
		/// <remarks>
		///  Maximum acceptable password length.
		///      </remarks>		<short>    Maximum acceptable password length.</short>
		public int MaximumPasswordLength() {
			return (int) interceptor.Invoke("maximumPasswordLength", "maximumPasswordLength() const", typeof(int));
		}
		/// <remarks>
		///  Password length that is expected to be reasonably safe.
		///  Used to compute the strength level
		///  Default: 8 - the standard UNIX password length
		/// <param> name="reasonableLength" : The new reasonable password length.
		///      </param></remarks>		<short>    Password length that is expected to be reasonably safe.</short>
		public void SetReasonablePasswordLength(int reasonableLength) {
			interceptor.Invoke("setReasonablePasswordLength$", "setReasonablePasswordLength(int)", typeof(void), typeof(int), reasonableLength);
		}
		/// <remarks>
		///  Password length that is expected to be reasonably safe.
		///      </remarks>		<short>    Password length that is expected to be reasonably safe.</short>
		public int ReasonablePasswordLength() {
			return (int) interceptor.Invoke("reasonablePasswordLength", "reasonablePasswordLength() const", typeof(int));
		}
		/// <remarks>
		///  Set the password strength level below which a warning is given
		///  Value is in the range 0 to 99. Empty passwords score 0;
		///  non-empty passwords score up to 100, depending on their length and whether they
		///  contain numbers, mixed case letters and punctuation.
		///  Default: 1 - warn if the password has no discernable strength whatsoever
		/// <param> name="warningLevel" : The level below which a warning should be given.
		///      </param></remarks>		<short>    Set the password strength level below which a warning is given  Value is in the range 0 to 99.</short>
		public void SetPasswordStrengthWarningLevel(int warningLevel) {
			interceptor.Invoke("setPasswordStrengthWarningLevel$", "setPasswordStrengthWarningLevel(int)", typeof(void), typeof(int), warningLevel);
		}
		/// <remarks>
		///  Password strength level below which a warning is given
		///      </remarks>		<short>    Password strength level below which a warning is given      </short>
		public int PasswordStrengthWarningLevel() {
			return (int) interceptor.Invoke("passwordStrengthWarningLevel", "passwordStrengthWarningLevel() const", typeof(int));
		}
		/// <remarks>
		///  Returns the password entered.
		///      </remarks>		<short>    Returns the password entered.</short>
		public string Password() {
			return (string) interceptor.Invoke("password", "password() const", typeof(string));
		}
		/// <remarks>
		///      </remarks>		<short>   </short>
		[SmokeMethod("accept()")]
		public override void Accept() {
			interceptor.Invoke("accept", "accept()", typeof(void));
		}
		/// <remarks>
		///  Virtual function that can be overridden to provide password
		///  checking in derived classes. It should return <code>true</code> if the
		///  password is valid, <code>false</code> otherwise.
		///      </remarks>		<short>    Virtual function that can be overridden to provide password  checking in derived classes.</short>
		[SmokeMethod("checkPassword(const QString&)")]
		protected virtual bool CheckPassword(string arg1) {
			return (bool) interceptor.Invoke("checkPassword$", "checkPassword(const QString&)", typeof(bool), typeof(string), arg1);
		}
		~KNewPasswordDialog() {
			interceptor.Invoke("~KNewPasswordDialog", "~KNewPasswordDialog()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KNewPasswordDialog", "~KNewPasswordDialog()", typeof(void));
		}
		protected new IKNewPasswordDialogSignals Emit {
			get { return (IKNewPasswordDialogSignals) Q_EMIT; }
		}
	}

	public interface IKNewPasswordDialogSignals : IKDialogSignals {
		/// <remarks>
		///  The dialog has been accepted, and the new password is <code>password</code>
		///      </remarks>		<short>    The dialog has been accepted, and the new password is <code>password</code>      </short>
		[Q_SIGNAL("void newPassword(const QString&)")]
		void NewPassword(string password);
	}
}
