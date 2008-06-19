//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
	using Plasma;
	using System;
	using Kimono;
	using Qyoto;
	/// <remarks>
	///  Item delegate for rendering items in Plasma menus implemented with item views.
	///  The delegate makes use of its own data roles that are:
	///  SubTitleRole: the text of the subtitle
	///  SubTitleMandatoryRole: if the subtitle is to always be displayed (as default the subtitle is displayed only on mouse over)
	///  ColumnTypeRole: if the column is a main column (with title and subtitle)
	///  or a secondary action column (only a little icon that appears on mouse over is displayed)
	///  </remarks>		<short>    Item delegate for rendering items in Plasma menus implemented with item views.</short>
	[SmokeClass("Plasma::Delegate")]
	public class Delegate : QAbstractItemDelegate, IDisposable {
 		protected Delegate(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(Delegate), this);
		}
		public enum SpecificRoles {
			SubTitleRole = Qt.ItemDataRole.UserRole+1,
			SubTitleMandatoryRole = Qt.ItemDataRole.UserRole+2,
			ColumnTypeRole = Qt.ItemDataRole.UserRole+3,
		}
		public enum ColumnType {
			MainColumn = 1,
			SecondaryActionColumn = 2,
		}
		public Delegate(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Delegate#", "Delegate(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public Delegate() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Delegate", "Delegate()", typeof(void));
		}
		/// <remarks>
		///  Maps an arbitrary role to a role belonging to SpecificRoles.
		///  Using this function you can use any model with this delegate.
		/// <param> name="role" a role belonging to SpecificRoles
		/// </param><param> name="actual" an arbitrary role of the model we are using
		///      </param></remarks>		<short>    Maps an arbitrary role to a role belonging to SpecificRoles.</short>
		public void SetRoleMapping(Plasma.Delegate.SpecificRoles role, int actual) {
			interceptor.Invoke("setRoleMapping$$", "setRoleMapping(Plasma::Delegate::SpecificRoles, int)", typeof(void), typeof(Plasma.Delegate.SpecificRoles), role, typeof(int), actual);
		}
		public int RoleMapping(Plasma.Delegate.SpecificRoles role) {
			return (int) interceptor.Invoke("roleMapping$", "roleMapping(Plasma::Delegate::SpecificRoles) const", typeof(int), typeof(Plasma.Delegate.SpecificRoles), role);
		}
		[SmokeMethod("paint(QPainter*, const QStyleOptionViewItem&, const QModelIndex&) const")]
		public override void Paint(QPainter painter, QStyleOptionViewItem option, QModelIndex index) {
			interceptor.Invoke("paint###", "paint(QPainter*, const QStyleOptionViewItem&, const QModelIndex&) const", typeof(void), typeof(QPainter), painter, typeof(QStyleOptionViewItem), option, typeof(QModelIndex), index);
		}
		/// <remarks>
		///  Returns the empty area after the title.
		///  The height is the height of the subtitle.
		///  It can be used by subclasses that wants to paint additional data after calling the paint function of the superclass.
		/// <param> name="option" options for the title text
		/// </param><param> name="index" model index that we want to compute the free area
		///      </param></remarks>		<short>    Returns the empty area after the title.</short>
		protected QRect RectAfterTitle(QStyleOptionViewItem option, QModelIndex index) {
			return (QRect) interceptor.Invoke("rectAfterTitle##", "rectAfterTitle(const QStyleOptionViewItem&, const QModelIndex&) const", typeof(QRect), typeof(QStyleOptionViewItem), option, typeof(QModelIndex), index);
		}
		/// <remarks>
		///  Returns the empty area after the subtitle.
		///  The height is the height of the subtitle.
		///  It can be used by subclasses, that wants to paint additional data.
		/// <param> name="option" options for the subtitle text
		/// </param><param> name="index" model index that we want to compute the free area
		///      </param></remarks>		<short>    Returns the empty area after the subtitle.</short>
		protected QRect RectAfterSubTitle(QStyleOptionViewItem option, QModelIndex index) {
			return (QRect) interceptor.Invoke("rectAfterSubTitle##", "rectAfterSubTitle(const QStyleOptionViewItem&, const QModelIndex&) const", typeof(QRect), typeof(QStyleOptionViewItem), option, typeof(QModelIndex), index);
		}
		/// <remarks>
		///  Returns the empty area after both the title and the subtitle.
		///  The height is the height of the item.
		///  It can be used by subclasses that wants to paint additional data
		/// <param> name="option" options for the title and subtitle text
		/// </param><param> name="index" model index that we want to compute the free area
		///      </param></remarks>		<short>    Returns the empty area after both the title and the subtitle.</short>
		protected QRect EmptyRect(QStyleOptionViewItem option, QModelIndex index) {
			return (QRect) interceptor.Invoke("emptyRect##", "emptyRect(const QStyleOptionViewItem&, const QModelIndex&) const", typeof(QRect), typeof(QStyleOptionViewItem), option, typeof(QModelIndex), index);
		}
		[SmokeMethod("sizeHint(const QStyleOptionViewItem&, const QModelIndex&) const")]
		public override QSize SizeHint(QStyleOptionViewItem option, QModelIndex index) {
			return (QSize) interceptor.Invoke("sizeHint##", "sizeHint(const QStyleOptionViewItem&, const QModelIndex&) const", typeof(QSize), typeof(QStyleOptionViewItem), option, typeof(QModelIndex), index);
		}
		~Delegate() {
			interceptor.Invoke("~Delegate", "~Delegate()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~Delegate", "~Delegate()", typeof(void));
		}
		protected new IDelegateSignals Emit {
			get { return (IDelegateSignals) Q_EMIT; }
		}
	}

	public interface IDelegateSignals : IQAbstractItemDelegateSignals {
	}
}