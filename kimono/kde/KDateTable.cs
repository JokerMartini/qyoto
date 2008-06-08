//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;

	/// <remarks>
	///  Date selection table.
	///  This is a support class for the KDatePicker class.  It just
	///  draws the calender table without titles, but could theoretically
	///  be used as a standalone.
	///  When a date is selected by the user, it emits a signal:
	///  dateSelected(QDate)
	///  See <see cref="IKDateTableSignals"></see> for signals emitted by KDateTable
	/// </remarks>		<author> Tim Gilman, Mirko Boehm
	///  </author>
	/// 		<short>    Date selection table.</short>

	[SmokeClass("KDateTable")]
	public class KDateTable : QWidget, IDisposable {
 		protected KDateTable(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocationKDE(typeof(KDateTable), this);
		}
		public enum BackgroundMode {
			NoBgMode = 0,
			RectangleMode = 1,
			CircleMode = 2,
		}
		[Q_PROPERTY("QDate", "date")]
		public QDate Date {
			get { return (QDate) interceptor.Invoke("date", "date()", typeof(QDate)); }
			set { interceptor.Invoke("setDate#", "setDate(QDate)", typeof(void), typeof(QDate), value); }
		}
		[Q_PROPERTY("bool", "popupMenu")]
		public bool PopupMenu {
			get { return (bool) interceptor.Invoke("popupMenuEnabled", "popupMenuEnabled()", typeof(bool)); }
			set { interceptor.Invoke("setPopupMenuEnabled$", "setPopupMenuEnabled(bool)", typeof(void), typeof(bool), value); }
		}
		/// <remarks>
		///  The constructor.
		///      </remarks>		<short>    The constructor.</short>
		public KDateTable(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KDateTable#", "KDateTable(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public KDateTable() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KDateTable", "KDateTable()", typeof(void));
		}
		/// <remarks>
		///  The constructor.
		///      </remarks>		<short>    The constructor.</short>
		public KDateTable(QDate arg1, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KDateTable##", "KDateTable(const QDate&, QWidget*)", typeof(void), typeof(QDate), arg1, typeof(QWidget), parent);
		}
		public KDateTable(QDate arg1) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KDateTable#", "KDateTable(const QDate&)", typeof(void), typeof(QDate), arg1);
		}
		/// <remarks>
		///  Returns a recommended size for the widget.
		///  To save some time, the size of the largest used cell content is
		///  calculated in each paintCell() call, since all calculations have
		///  to be done there anyway. The size is stored in maxCell. The
		///  sizeHint() simply returns a multiple of maxCell.
		///      </remarks>		<short>    Returns a recommended size for the widget.</short>
		[SmokeMethod("sizeHint() const")]
		public override QSize SizeHint() {
			return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
		}
		/// <remarks>
		///  Set the font size of the date table.
		///      </remarks>		<short>    Set the font size of the date table.</short>
		public void SetFontSize(int size) {
			interceptor.Invoke("setFontSize$", "setFontSize(int)", typeof(void), typeof(int), size);
		}
		/// <remarks>
		///  Returns the currently selected calendar system.
		/// </remarks>		<return> a KCalendarSystem object
		///      </return>
		/// 		<short>    Returns the currently selected calendar system.</short>
		public KCalendarSystem Calendar() {
			return (KCalendarSystem) interceptor.Invoke("calendar", "calendar() const", typeof(KCalendarSystem));
		}
		/// <remarks>
		///  Changes the calendar system to use.  Can use its own local locale if set.
		/// <param> name="calendar" the calendar system object to use, defaults to global
		/// </param></remarks>		<return> @c true if the calendar system was successfully set, @c false otherwise
		///      </return>
		/// 		<short>    Changes the calendar system to use.</short>
		public bool SetCalendar(KCalendarSystem calendar) {
			return (bool) interceptor.Invoke("setCalendar#", "setCalendar(KCalendarSystem*)", typeof(bool), typeof(KCalendarSystem), calendar);
		}
		public bool SetCalendar() {
			return (bool) interceptor.Invoke("setCalendar", "setCalendar()", typeof(bool));
		}
		/// <remarks>
		///  Changes the calendar system to use.  Will always use global locale.
		/// <param> name="calendarType" the calendar system type to use
		/// </param></remarks>		<return> @c true if the calendar system was successfully set, @c false otherwise
		///      </return>
		/// 		<short>    Changes the calendar system to use.</short>
		public bool SetCalendar(string calendarType) {
			return (bool) interceptor.Invoke("setCalendar$", "setCalendar(const QString&)", typeof(bool), typeof(string), calendarType);
		}
		/// <remarks>
		///  Makes a given date be painted with a given foregroundColor, and background
		///  (a rectangle, or a circle/ellipse) in a given color.
		///      </remarks>		<short>    Makes a given date be painted with a given foregroundColor, and background  (a rectangle, or a circle/ellipse) in a given color.</short>
		public void SetCustomDatePainting(QDate date, QColor fgColor, KDateTable.BackgroundMode bgMode, QColor bgColor) {
			interceptor.Invoke("setCustomDatePainting##$#", "setCustomDatePainting(const QDate&, const QColor&, KDateTable::BackgroundMode, const QColor&)", typeof(void), typeof(QDate), date, typeof(QColor), fgColor, typeof(KDateTable.BackgroundMode), bgMode, typeof(QColor), bgColor);
		}
		public void SetCustomDatePainting(QDate date, QColor fgColor, KDateTable.BackgroundMode bgMode) {
			interceptor.Invoke("setCustomDatePainting##$", "setCustomDatePainting(const QDate&, const QColor&, KDateTable::BackgroundMode)", typeof(void), typeof(QDate), date, typeof(QColor), fgColor, typeof(KDateTable.BackgroundMode), bgMode);
		}
		public void SetCustomDatePainting(QDate date, QColor fgColor) {
			interceptor.Invoke("setCustomDatePainting##", "setCustomDatePainting(const QDate&, const QColor&)", typeof(void), typeof(QDate), date, typeof(QColor), fgColor);
		}
		/// <remarks>
		///  Unsets the custom painting of a date so that the date is painted as usual.
		///      </remarks>		<short>    Unsets the custom painting of a date so that the date is painted as usual.</short>
		public void UnsetCustomDatePainting(QDate date) {
			interceptor.Invoke("unsetCustomDatePainting#", "unsetCustomDatePainting(const QDate&)", typeof(void), typeof(QDate), date);
		}
		/// <remarks>
		///  calculate the position of the cell in the matrix for the given date.
		///  The result is the 0-based index.
		///      </remarks>		<short>    calculate the position of the cell in the matrix for the given date.</short>
		[SmokeMethod("posFromDate(const QDate&)")]
		protected virtual int PosFromDate(QDate date) {
			return (int) interceptor.Invoke("posFromDate#", "posFromDate(const QDate&)", typeof(int), typeof(QDate), date);
		}
		/// <remarks>
		///  calculate the date that is displayed at a given cell in the matrix. pos is the
		///  0-based index in the matrix. Inverse function to posForDate().
		///      </remarks>		<short>    calculate the date that is displayed at a given cell in the matrix.</short>
		[SmokeMethod("dateFromPos(int)")]
		protected virtual QDate DateFromPos(int pos) {
			return (QDate) interceptor.Invoke("dateFromPos$", "dateFromPos(int)", typeof(QDate), typeof(int), pos);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected override void PaintEvent(QPaintEvent e) {
			interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), e);
		}
		/// <remarks>
		///  React on mouse clicks that select a date.
		///      </remarks>		<short>    React on mouse clicks that select a date.</short>
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected override void MousePressEvent(QMouseEvent e) {
			interceptor.Invoke("mousePressEvent#", "mousePressEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), e);
		}
		[SmokeMethod("wheelEvent(QWheelEvent*)")]
		protected override void WheelEvent(QWheelEvent e) {
			interceptor.Invoke("wheelEvent#", "wheelEvent(QWheelEvent*)", typeof(void), typeof(QWheelEvent), e);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected override void KeyPressEvent(QKeyEvent e) {
			interceptor.Invoke("keyPressEvent#", "keyPressEvent(QKeyEvent*)", typeof(void), typeof(QKeyEvent), e);
		}
		[SmokeMethod("focusInEvent(QFocusEvent*)")]
		protected override void FocusInEvent(QFocusEvent e) {
			interceptor.Invoke("focusInEvent#", "focusInEvent(QFocusEvent*)", typeof(void), typeof(QFocusEvent), e);
		}
		[SmokeMethod("focusOutEvent(QFocusEvent*)")]
		protected override void FocusOutEvent(QFocusEvent e) {
			interceptor.Invoke("focusOutEvent#", "focusOutEvent(QFocusEvent*)", typeof(void), typeof(QFocusEvent), e);
		}
		~KDateTable() {
			interceptor.Invoke("~KDateTable", "~KDateTable()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KDateTable", "~KDateTable()", typeof(void));
		}
		protected new IKDateTableSignals Emit {
			get { return (IKDateTableSignals) Q_EMIT; }
		}
	}

	public interface IKDateTableSignals : IQWidgetSignals {
		/// <remarks>
		///  The selected date changed.
		///      </remarks>		<short>    The selected date changed.</short>
		[Q_SIGNAL("void dateChanged(const QDate&)")]
		void DateChanged(QDate date);
		/// <remarks>
		///  This function behaves essentially like the one above.
		///  The selected date changed.
		/// <param> name="cur" The current date
		/// </param><param> name="old" The date before the date was changed
		///      </param></remarks>		<short>    This function behaves essentially like the one above.</short>
		[Q_SIGNAL("void dateChanged(const QDate&, const QDate&)")]
		void DateChanged(QDate cur, QDate old);
		/// <remarks>
		///  A date has been selected by clicking on the table.
		///      </remarks>		<short>    A date has been selected by clicking on the table.</short>
		[Q_SIGNAL("void tableClicked()")]
		void TableClicked();
		/// <remarks>
		///  A popup menu for a given date is about to be shown (as when the user
		///  right clicks on that date and the popup menu is enabled). Connect
		///  the slot where you fill the menu to this signal.
		///      </remarks>		<short>    A popup menu for a given date is about to be shown (as when the user  right clicks on that date and the popup menu is enabled).</short>
		[Q_SIGNAL("void aboutToShowContextMenu(KMenu*, const QDate&)")]
		void AboutToShowContextMenu(KMenu menu, QDate date);
	}
}
