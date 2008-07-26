//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    /// <remarks>
    ///  Provides a widget for calendar date input.
    ///      Different from the
    ///      previous versions, it now emits two types of signals, either
    ///  dateSelected() or dateEntered() (see documentation for both
    ///      signals).
    ///      A line edit has been added in the newer versions to allow the user
    ///      to select a date directly by entering numbers like 19990101
    ///      or 990101.
    ///  \image html kdatepicker.png "KDE Date Widget"
    ///  See <see cref="IKDatePickerSignals"></see> for signals emitted by KDatePicker
    /// </remarks>        <author> Tim Gilman, Mirko Boehm
    /// </author>
    ///         <short> A date selection widget. </short>
    [SmokeClass("KDatePicker")]
    public class KDatePicker : QFrame, IDisposable {
        protected KDatePicker(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KDatePicker), this);
        }
        [Q_PROPERTY("QDate", "date")]
        public QDate Date {
            get { return (QDate) interceptor.Invoke("date", "date()", typeof(QDate)); }
            set { interceptor.Invoke("setDate#", "setDate(QDate)", typeof(void), typeof(QDate), value); }
        }
        [Q_PROPERTY("bool", "closeButton")]
        public bool CloseButton {
            get { return (bool) interceptor.Invoke("hasCloseButton", "hasCloseButton()", typeof(bool)); }
            set { interceptor.Invoke("setCloseButton$", "setCloseButton(bool)", typeof(void), typeof(bool), value); }
        }
        [Q_PROPERTY("int", "fontSize")]
        public int FontSize {
            get { return (int) interceptor.Invoke("fontSize", "fontSize()", typeof(int)); }
            set { interceptor.Invoke("setFontSize$", "setFontSize(int)", typeof(void), typeof(int), value); }
        }
        /// <remarks>
        ///  The constructor. The current date will be displayed initially.
        /// </remarks>        <short>    The constructor.</short>
        public KDatePicker(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KDatePicker#", "KDatePicker(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public KDatePicker() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KDatePicker", "KDatePicker()", typeof(void));
        }
        /// <remarks>
        ///  The constructor. The given date will be displayed initially.
        /// </remarks>        <short>    The constructor.</short>
        public KDatePicker(QDate dt, QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KDatePicker##", "KDatePicker(const QDate&, QWidget*)", typeof(void), typeof(QDate), dt, typeof(QWidget), parent);
        }
        public KDatePicker(QDate dt) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("KDatePicker#", "KDatePicker(const QDate&)", typeof(void), typeof(QDate), dt);
        }
        /// <remarks> The size hint for date pickers. The size hint recommends the
        ///    minimum size of the widget so that all elements may be placed
        ///   without clipping. This sometimes looks ugly, so when using the
        ///   size hint, try adding 28 to each of the reported numbers of
        ///   pixels.
        /// </remarks>        <short>   The size hint for date pickers.</short>
        [SmokeMethod("sizeHint() const")]
        public override QSize SizeHint() {
            return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
        }
        /// <remarks>
        ///  Returns the currently selected calendar system.
        /// </remarks>        <return> a KCalendarSystem object
        ///      </return>
        ///         <short>    Returns the currently selected calendar system.</short>
        public KCalendarSystem Calendar() {
            return (KCalendarSystem) interceptor.Invoke("calendar", "calendar() const", typeof(KCalendarSystem));
        }
        /// <remarks>
        ///  Changes the calendar system to use.  Can use its own local locale if set.
        /// <param> name="calendar" the calendar system object to use, defaults to global
        /// </param></remarks>        <return> @c true if the calendar system was successfully set, @c false otherwise
        ///      </return>
        ///         <short>    Changes the calendar system to use.</short>
        public bool SetCalendar(KCalendarSystem calendar) {
            return (bool) interceptor.Invoke("setCalendar#", "setCalendar(KCalendarSystem*)", typeof(bool), typeof(KCalendarSystem), calendar);
        }
        public bool SetCalendar() {
            return (bool) interceptor.Invoke("setCalendar", "setCalendar()", typeof(bool));
        }
        /// <remarks>
        ///  Changes the calendar system to use.  Will always use global locale.
        /// <param> name="calendarType" the calendar system type to use
        /// </param></remarks>        <return> @c true if the calendar system was successfully set, @c false otherwise
        ///      </return>
        ///         <short>    Changes the calendar system to use.</short>
        public bool SetCalendar(string calendarType) {
            return (bool) interceptor.Invoke("setCalendar$", "setCalendar(const QString&)", typeof(bool), typeof(string), calendarType);
        }
        /// <remarks>
        ///  Enables or disables the widget.
        /// </remarks>        <short>    Enables or disables the widget.</short>
        public void SetEnabled(bool enable) {
            interceptor.Invoke("setEnabled$", "setEnabled(bool)", typeof(void), typeof(bool), enable);
        }
        /// <remarks>
        /// </remarks>        <return> the KDateTable widget child of this KDatePicker
        ///  widget.
        ///      </return>
        ///         <short>   </short>
        public KDateTable DateTable() {
            return (KDateTable) interceptor.Invoke("dateTable", "dateTable() const", typeof(KDateTable));
        }
        [SmokeMethod("eventFilter(QObject*, QEvent*)")]
        protected new virtual bool EventFilter(QObject o, QEvent e) {
            return (bool) interceptor.Invoke("eventFilter##", "eventFilter(QObject*, QEvent*)", typeof(bool), typeof(QObject), o, typeof(QEvent), e);
        }
        [SmokeMethod("resizeEvent(QResizeEvent*)")]
        protected override void ResizeEvent(QResizeEvent arg1) {
            interceptor.Invoke("resizeEvent#", "resizeEvent(QResizeEvent*)", typeof(void), typeof(QResizeEvent), arg1);
        }
        [Q_SLOT("void dateChangedSlot(QDate)")]
        protected void DateChangedSlot(QDate date) {
            interceptor.Invoke("dateChangedSlot#", "dateChangedSlot(const QDate&)", typeof(void), typeof(QDate), date);
        }
        [Q_SLOT("void tableClickedSlot()")]
        protected void TableClickedSlot() {
            interceptor.Invoke("tableClickedSlot", "tableClickedSlot()", typeof(void));
        }
        [Q_SLOT("void monthForwardClicked()")]
        protected void MonthForwardClicked() {
            interceptor.Invoke("monthForwardClicked", "monthForwardClicked()", typeof(void));
        }
        [Q_SLOT("void monthBackwardClicked()")]
        protected void MonthBackwardClicked() {
            interceptor.Invoke("monthBackwardClicked", "monthBackwardClicked()", typeof(void));
        }
        [Q_SLOT("void yearForwardClicked()")]
        protected void YearForwardClicked() {
            interceptor.Invoke("yearForwardClicked", "yearForwardClicked()", typeof(void));
        }
        [Q_SLOT("void yearBackwardClicked()")]
        protected void YearBackwardClicked() {
            interceptor.Invoke("yearBackwardClicked", "yearBackwardClicked()", typeof(void));
        }
        [Q_SLOT("void selectMonthClicked()")]
        protected void SelectMonthClicked() {
            interceptor.Invoke("selectMonthClicked", "selectMonthClicked()", typeof(void));
        }
        [Q_SLOT("void selectYearClicked()")]
        protected void SelectYearClicked() {
            interceptor.Invoke("selectYearClicked", "selectYearClicked()", typeof(void));
        }
        [Q_SLOT("void uncheckYearSelector()")]
        protected void UncheckYearSelector() {
            interceptor.Invoke("uncheckYearSelector", "uncheckYearSelector()", typeof(void));
        }
        [Q_SLOT("void lineEnterPressed()")]
        protected void LineEnterPressed() {
            interceptor.Invoke("lineEnterPressed", "lineEnterPressed()", typeof(void));
        }
        [Q_SLOT("void todayButtonClicked()")]
        protected void TodayButtonClicked() {
            interceptor.Invoke("todayButtonClicked", "todayButtonClicked()", typeof(void));
        }
        [Q_SLOT("void weekSelected(int)")]
        protected void WeekSelected(int arg1) {
            interceptor.Invoke("weekSelected$", "weekSelected(int)", typeof(void), typeof(int), arg1);
        }
        ~KDatePicker() {
            interceptor.Invoke("~KDatePicker", "~KDatePicker()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~KDatePicker", "~KDatePicker()", typeof(void));
        }
        protected new IKDatePickerSignals Emit {
            get { return (IKDatePickerSignals) Q_EMIT; }
        }
    }

    public interface IKDatePickerSignals : IQFrameSignals {
        /// <remarks> This signal is emitted each time the selected date is changed.
        ///   Usually, this does not mean that the date has been entered,
        ///   since the date also changes, for example, when another month is
        ///   selected.
        /// </remarks>        <short>   This signal is emitted each time the selected date is changed.</short>
        ///         <see> dateSelected</see>
        [Q_SIGNAL("void dateChanged(QDate)")]
        void DateChanged(QDate date);
        /// <remarks> This signal is emitted each time a day has been selected by
        ///   clicking on the table (hitting a day in the current month). It
        ///   has the same meaning as dateSelected() in older versions of
        ///   KDatePicker.
        ///      </remarks>        <short>   This signal is emitted each time a day has been selected by   clicking on the table (hitting a day in the current month).</short>
        [Q_SIGNAL("void dateSelected(QDate)")]
        void DateSelected(QDate date);
        /// <remarks> This signal is emitted when enter is pressed and a VALID date
        ///   has been entered before into the line edit. Connect to both
        ///   dateEntered() and dateSelected() to receive all events where the
        ///   user really enters a date.
        ///      </remarks>        <short>   This signal is emitted when enter is pressed and a VALID date   has been entered before into the line edit.</short>
        [Q_SIGNAL("void dateEntered(QDate)")]
        void DateEntered(QDate date);
        /// <remarks> This signal is emitted when the day has been selected by
        ///   clicking on it in the table.
        ///      </remarks>        <short>   This signal is emitted when the day has been selected by   clicking on it in the table.</short>
        [Q_SIGNAL("void tableClicked()")]
        void TableClicked();
    }
}
