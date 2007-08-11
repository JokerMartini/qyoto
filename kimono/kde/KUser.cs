//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;
	using System.Collections.Generic;

	/// <remarks>
	///  This class represents a user on your system. You can either get
	///  information about the current user, of fetch information about
	///  a user on the system. Instances of this class will be explicitly shared,
	///  so copying objects is very cheap and you can safely pass objects by value.
	/// </remarks>		<author> Tim Jansen <tim@tjansen.de>
	///  </author>
	/// 		<short> Represents a user on your system.</short>

	[SmokeClass("KUser")]
	public class KUser : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected KUser(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KUser), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static KUser() {
			staticInterceptor = new SmokeInvocation(typeof(KUser), null);
		}
		public enum UIDMode {
			UseEffectiveUID = 0,
			UseRealUserID = 1,
		}
		// KUser* KUser(uid_t arg1); >>>> NOT CONVERTED
		// KUser* KUser(const passwd* arg1); >>>> NOT CONVERTED
		// uid_t uid(); >>>> NOT CONVERTED
		// gid_t gid(); >>>> NOT CONVERTED
		/// <remarks>
		///  Creates an object that contains information about the current user.
		///  (as returned by getuid(2) or geteuid(2), taking $LOGNAME/$USER into
		///  account).
		/// <param> name="mode" if #UseEffectiveUID is passed the effective
		///              user is returned.
		///         If #UseRealUserID is passed the real user will be
		///         returned.
		///         The real UID will be different than the effective UID in setuid
		///         programs; in
		///         such a case use the effective UID for checking permissions, and
		///         the real UID for displaying information about the user.
		///    </param></remarks>		<short>    Creates an object that contains information about the current user.</short>
		public KUser(KUser.UIDMode mode) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KUser$", "KUser(KUser::UIDMode)", typeof(void), typeof(KUser.UIDMode), mode);
		}
		public KUser() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KUser", "KUser()", typeof(void));
		}
		/// <remarks>
		///  Creates an object that contains information about the user with the given
		///  name. If the user does not exist isValid() will return false.
		/// <param> name="name" the name of the user
		///    </param></remarks>		<short>    Creates an object that contains information about the user with the given  name.</short>
		public KUser(string name) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KUser$", "KUser(const QString&)", typeof(void), typeof(string), name);
		}
		/// <remarks>
		///  Creates an object from another KUser object
		/// <param> name="user" the user to create the new object from
		///    </param></remarks>		<short>    Creates an object from another KUser object </short>
		public KUser(KUser user) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KUser#", "KUser(const KUser&)", typeof(void), typeof(KUser), user);
		}
		/// <remarks>
		///  Two KUser objects are equal if the uid() are identical.
		///  Invalid users never compare equal.
		///    </remarks>		<short>    Two KUser objects are equal if the uid() are identical.</short>
		public override bool Equals(object o) {
			if (!(o is KUser)) { return false; }
			return this == (KUser) o;
		}
		public override int GetHashCode() {
			return interceptor.GetHashCode();
		}
		/// <remarks>
		///  Returns true if the user is valid. A KUser object can be invalid if
		///  you created it with an non-existing uid or name.
		/// </remarks>		<return> true if the user is valid
		///    </return>
		/// 		<short>    Returns true if the user is valid.</short>
		public bool IsValid() {
			return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
		}
		/// <remarks>
		///  Returns the user id of the user.
		/// </remarks>		<return> the id of the user or -1 if user is invalid
		///    </return>
		/// 		<short>    Returns the user id of the user.</short>
		/// <remarks>
		///  Returns the group id of the user.
		/// </remarks>		<return> the id of the group or -1 if user is invalid
		///    </return>
		/// 		<short>    Returns the group id of the user.</short>
		/// <remarks>
		///  Checks whether the user is the super user (root).
		/// </remarks>		<return> true if the user is root
		///    </return>
		/// 		<short>    Checks whether the user is the super user (root).</short>
		public bool IsSuperUser() {
			return (bool) interceptor.Invoke("isSuperUser", "isSuperUser() const", typeof(bool));
		}
		/// <remarks>
		///  The login name of the user.
		/// </remarks>		<return> the login name of the user or string() if user is invalid
		///    </return>
		/// 		<short>    The login name of the user.</short>
		public string LoginName() {
			return (string) interceptor.Invoke("loginName", "loginName() const", typeof(string));
		}
		/// <remarks>
		///  The full name of the user.
		/// </remarks>		<return> the full name of the user or string() if user is invalid
		///    </return>
		/// 		<short>    The full name of the user.</short>
		public string FullName() {
			return (string) interceptor.Invoke("fullName", "fullName() const", typeof(string));
		}
		/// <remarks>
		///  The user's room number.
		/// </remarks>		<return> the room number of the user or string() if not set or the
		///          user is invalid
		///    </return>
		/// 		<short>    The user's room number.</short>
		public string RoomNumber() {
			return (string) interceptor.Invoke("roomNumber", "roomNumber() const", typeof(string));
		}
		/// <remarks>
		///  The user's work phone.
		/// </remarks>		<return> the work phone of the user or string() if not set or the
		///          user is invalid
		///    </return>
		/// 		<short>    The user's work phone.</short>
		public string WorkPhone() {
			return (string) interceptor.Invoke("workPhone", "workPhone() const", typeof(string));
		}
		/// <remarks>
		///  The user's home phone.
		/// </remarks>		<return> the home phone of the user or string() if not set or the
		///          user is invalid
		///    </return>
		/// 		<short>    The user's home phone.</short>
		public string HomePhone() {
			return (string) interceptor.Invoke("homePhone", "homePhone() const", typeof(string));
		}
		/// <remarks>
		///  The path to the user's home directory.
		/// </remarks>		<return> the home directory of the user or string() if the
		///          user is invalid
		///    </return>
		/// 		<short>    The path to the user's home directory.</short>
		public string HomeDir() {
			return (string) interceptor.Invoke("homeDir", "homeDir() const", typeof(string));
		}
		/// <remarks>
		///  The path to the user's login shell.
		/// </remarks>		<return> the login shell of the user or string() if the
		///          user is invalid
		///    </return>
		/// 		<short>    The path to the user's login shell.</short>
		public string Shell() {
			return (string) interceptor.Invoke("shell", "shell() const", typeof(string));
		}
		/// <remarks>
		///  Returns all groups of the user
		/// </remarks>		<return> all groups of the user
		///    </return>
		/// 		<short>    Returns all groups of the user </short>
		public List<KUserGroup> Groups() {
			return (List<KUserGroup>) interceptor.Invoke("groups", "groups() const", typeof(List<KUserGroup>));
		}
		/// <remarks>
		///  Returns all group names of the user
		/// </remarks>		<return> all group names of the user
		///    </return>
		/// 		<short>    Returns all group names of the user </short>
		public List<string> GroupNames() {
			return (List<string>) interceptor.Invoke("groupNames", "groupNames() const", typeof(List<string>));
		}
		~KUser() {
			interceptor.Invoke("~KUser", "~KUser()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~KUser", "~KUser()", typeof(void));
		}
		public static bool operator==(KUser lhs, KUser user) {
			return (bool) staticInterceptor.Invoke("operator==#", "operator==(const KUser&) const", typeof(bool), typeof(KUser), lhs, typeof(KUser), user);
		}
		public static bool operator!=(KUser lhs, KUser user) {
			return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const KUser&) const", typeof(bool), typeof(KUser), lhs, typeof(KUser), user);
		}
		/// <remarks>
		///  Returns all users of the system.
		/// </remarks>		<return> all users of the system.
		///    </return>
		/// 		<short>    Returns all users of the system.</short>
		public static List<KUser> AllUsers() {
			return (List<KUser>) staticInterceptor.Invoke("allUsers", "allUsers()", typeof(List<KUser>));
		}
		/// <remarks>
		///  Returns all user names of the system.
		/// </remarks>		<return> all user names of the system.
		///    </return>
		/// 		<short>    Returns all user names of the system.</short>
		public static List<string> AllUserNames() {
			return (List<string>) staticInterceptor.Invoke("allUserNames", "allUserNames()", typeof(List<string>));
		}
	}
}