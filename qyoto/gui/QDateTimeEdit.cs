//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Runtime.InteropServices;
	using System.Text;

	/// <remarks> See <see cref="IQDateTimeEditSignals"></see> for signals emitted by QDateTimeEdit
	/// </remarks>

	[SmokeClass("QDateTimeEdit")]
	public class QDateTimeEdit : QAbstractSpinBox, IDisposable {
 		protected QDateTimeEdit(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QDateTimeEdit), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QDateTimeEdit() {
			staticInterceptor = new SmokeInvocation(typeof(QDateTimeEdit), null);
		}
		public enum Section {
			NoSection = 0x0000,
			AmPmSection = 0x0001,
			MSecSection = 0x0002,
			SecondSection = 0x0004,
			MinuteSection = 0x0008,
			HourSection = 0x0010,
			DaySection = 0x0100,
			MonthSection = 0x0200,
			YearSection = 0x0400,
			TimeSections_Mask = AmPmSection|MSecSection|SecondSection|MinuteSection|HourSection,
			DateSections_Mask = DaySection|MonthSection|YearSection,
		}
		[Q_PROPERTY("QDateTime", "dateTime")]
		public QDateTime DateTime {
			get { return (QDateTime) interceptor.Invoke("dateTime", "dateTime()", typeof(QDateTime)); }
			set { interceptor.Invoke("setDateTime#", "setDateTime(QDateTime)", typeof(void), typeof(QDateTime), value); }
		}
		[Q_PROPERTY("QDate", "date")]
		public QDate Date {
			get { return (QDate) interceptor.Invoke("date", "date()", typeof(QDate)); }
			set { interceptor.Invoke("setDate#", "setDate(QDate)", typeof(void), typeof(QDate), value); }
		}
		[Q_PROPERTY("QTime", "time")]
		public QTime Time {
			get { return (QTime) interceptor.Invoke("time", "time()", typeof(QTime)); }
			set { interceptor.Invoke("setTime#", "setTime(QTime)", typeof(void), typeof(QTime), value); }
		}
		[Q_PROPERTY("QDate", "maximumDate")]
		public QDate MaximumDate {
			get { return (QDate) interceptor.Invoke("maximumDate", "maximumDate()", typeof(QDate)); }
			set { interceptor.Invoke("setMaximumDate#", "setMaximumDate(QDate)", typeof(void), typeof(QDate), value); }
		}
		[Q_PROPERTY("QDate", "minimumDate")]
		public QDate MinimumDate {
			get { return (QDate) interceptor.Invoke("minimumDate", "minimumDate()", typeof(QDate)); }
			set { interceptor.Invoke("setMinimumDate#", "setMinimumDate(QDate)", typeof(void), typeof(QDate), value); }
		}
		[Q_PROPERTY("QTime", "maximumTime")]
		public QTime MaximumTime {
			get { return (QTime) interceptor.Invoke("maximumTime", "maximumTime()", typeof(QTime)); }
			set { interceptor.Invoke("setMaximumTime#", "setMaximumTime(QTime)", typeof(void), typeof(QTime), value); }
		}
		[Q_PROPERTY("QTime", "minimumTime")]
		public QTime MinimumTime {
			get { return (QTime) interceptor.Invoke("minimumTime", "minimumTime()", typeof(QTime)); }
			set { interceptor.Invoke("setMinimumTime#", "setMinimumTime(QTime)", typeof(void), typeof(QTime), value); }
		}
		[Q_PROPERTY("QDateTimeEdit::Section", "currentSection")]
		public QDateTimeEdit.Section CurrentSection {
			get { return (QDateTimeEdit.Section) interceptor.Invoke("currentSection", "currentSection()", typeof(QDateTimeEdit.Section)); }
			set { interceptor.Invoke("setCurrentSection$", "setCurrentSection(QDateTimeEdit::Section)", typeof(void), typeof(QDateTimeEdit.Section), value); }
		}
		[Q_PROPERTY("Sections", "displayedSections")]
		public int DisplayedSections {
			get { return (int) interceptor.Invoke("displayedSections", "displayedSections()", typeof(int)); }
		}
		[Q_PROPERTY("QString", "displayFormat")]
		public string DisplayFormat {
			get { return (string) interceptor.Invoke("displayFormat", "displayFormat()", typeof(string)); }
			set { interceptor.Invoke("setDisplayFormat$", "setDisplayFormat(QString)", typeof(void), typeof(string), value); }
		}
		[Q_PROPERTY("bool", "calendarPopup")]
		public bool CalendarPopup {
			get { return (bool) interceptor.Invoke("calendarPopup", "calendarPopup()", typeof(bool)); }
			set { interceptor.Invoke("setCalendarPopup$", "setCalendarPopup(bool)", typeof(void), typeof(bool), value); }
		}
		[Q_PROPERTY("int", "currentSectionIndex")]
		public int CurrentSectionIndex {
			get { return (int) interceptor.Invoke("currentSectionIndex", "currentSectionIndex()", typeof(int)); }
			set { interceptor.Invoke("setCurrentSectionIndex$", "setCurrentSectionIndex(int)", typeof(void), typeof(int), value); }
		}
		[Q_PROPERTY("int", "sectionCount")]
		public int SectionCount {
			get { return (int) interceptor.Invoke("sectionCount", "sectionCount()", typeof(int)); }
		}
		public QDateTimeEdit(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDateTimeEdit#", "QDateTimeEdit(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public QDateTimeEdit() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDateTimeEdit", "QDateTimeEdit()", typeof(void));
		}
		public QDateTimeEdit(QDateTime dt, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDateTimeEdit##", "QDateTimeEdit(const QDateTime&, QWidget*)", typeof(void), typeof(QDateTime), dt, typeof(QWidget), parent);
		}
		public QDateTimeEdit(QDateTime dt) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDateTimeEdit#", "QDateTimeEdit(const QDateTime&)", typeof(void), typeof(QDateTime), dt);
		}
		public QDateTimeEdit(QDate d, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDateTimeEdit##", "QDateTimeEdit(const QDate&, QWidget*)", typeof(void), typeof(QDate), d, typeof(QWidget), parent);
		}
		public QDateTimeEdit(QDate d) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDateTimeEdit#", "QDateTimeEdit(const QDate&)", typeof(void), typeof(QDate), d);
		}
		public QDateTimeEdit(QTime t, QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDateTimeEdit##", "QDateTimeEdit(const QTime&, QWidget*)", typeof(void), typeof(QTime), t, typeof(QWidget), parent);
		}
		public QDateTimeEdit(QTime t) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDateTimeEdit#", "QDateTimeEdit(const QTime&)", typeof(void), typeof(QTime), t);
		}
		public void ClearMinimumDate() {
			interceptor.Invoke("clearMinimumDate", "clearMinimumDate()", typeof(void));
		}
		public void ClearMaximumDate() {
			interceptor.Invoke("clearMaximumDate", "clearMaximumDate()", typeof(void));
		}
		public void SetDateRange(QDate min, QDate max) {
			interceptor.Invoke("setDateRange##", "setDateRange(const QDate&, const QDate&)", typeof(void), typeof(QDate), min, typeof(QDate), max);
		}
		public void ClearMinimumTime() {
			interceptor.Invoke("clearMinimumTime", "clearMinimumTime()", typeof(void));
		}
		public void ClearMaximumTime() {
			interceptor.Invoke("clearMaximumTime", "clearMaximumTime()", typeof(void));
		}
		public void SetTimeRange(QTime min, QTime max) {
			interceptor.Invoke("setTimeRange##", "setTimeRange(const QTime&, const QTime&)", typeof(void), typeof(QTime), min, typeof(QTime), max);
		}
		public QDateTimeEdit.Section SectionAt(int index) {
			return (QDateTimeEdit.Section) interceptor.Invoke("sectionAt$", "sectionAt(int) const", typeof(QDateTimeEdit.Section), typeof(int), index);
		}
		public void SetSelectedSection(QDateTimeEdit.Section section) {
			interceptor.Invoke("setSelectedSection$", "setSelectedSection(QDateTimeEdit::Section)", typeof(void), typeof(QDateTimeEdit.Section), section);
		}
		public string SectionText(QDateTimeEdit.Section section) {
			return (string) interceptor.Invoke("sectionText$", "sectionText(QDateTimeEdit::Section) const", typeof(string), typeof(QDateTimeEdit.Section), section);
		}
		[SmokeMethod("sizeHint() const")]
		public override QSize SizeHint() {
			return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
		}
		[SmokeMethod("clear()")]
		public override void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		[SmokeMethod("stepBy(int)")]
		public override void StepBy(int steps) {
			interceptor.Invoke("stepBy$", "stepBy(int)", typeof(void), typeof(int), steps);
		}
		[SmokeMethod("event(QEvent*)")]
		public override bool Event(QEvent arg1) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
		}
		[Q_SLOT("void setDateTime(const QDateTime&)")]
		public void SetDateTime(QDateTime dateTime) {
			interceptor.Invoke("setDateTime#", "setDateTime(const QDateTime&)", typeof(void), typeof(QDateTime), dateTime);
		}
		[Q_SLOT("void setDate(const QDate&)")]
		public void SetDate(QDate date) {
			interceptor.Invoke("setDate#", "setDate(const QDate&)", typeof(void), typeof(QDate), date);
		}
		[Q_SLOT("void setTime(const QTime&)")]
		public void SetTime(QTime time) {
			interceptor.Invoke("setTime#", "setTime(const QTime&)", typeof(void), typeof(QTime), time);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected override void KeyPressEvent(QKeyEvent arg1) {
			interceptor.Invoke("keyPressEvent#", "keyPressEvent(QKeyEvent*)", typeof(void), typeof(QKeyEvent), arg1);
		}
		[SmokeMethod("wheelEvent(QWheelEvent*)")]
		protected override void WheelEvent(QWheelEvent arg1) {
			interceptor.Invoke("wheelEvent#", "wheelEvent(QWheelEvent*)", typeof(void), typeof(QWheelEvent), arg1);
		}
		[SmokeMethod("focusInEvent(QFocusEvent*)")]
		protected override void FocusInEvent(QFocusEvent arg1) {
			interceptor.Invoke("focusInEvent#", "focusInEvent(QFocusEvent*)", typeof(void), typeof(QFocusEvent), arg1);
		}
		[SmokeMethod("focusNextPrevChild(bool)")]
		protected override bool FocusNextPrevChild(bool next) {
			return (bool) interceptor.Invoke("focusNextPrevChild$", "focusNextPrevChild(bool)", typeof(bool), typeof(bool), next);
		}
		[SmokeMethod("validate(QString&, int&) const")]
		protected new virtual int Validate(StringBuilder input, ref int pos) {
			StackItem[] stack = new StackItem[3];
#if DEBUG
			stack[1].s_class = (IntPtr) DebugGCHandle.Alloc(input);
#else
			stack[1].s_class = (IntPtr) GCHandle.Alloc(input);
#endif
			stack[2].s_int = pos;
			interceptor.Invoke("validate$$", "validate(QString&, int&) const", stack);
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[1].s_class);
#else
			((GCHandle) stack[1].s_class).Free();
#endif
			pos = stack[2].s_int;
			return stack[0].s_int;
		}
		[SmokeMethod("fixup(QString&) const")]
		protected new virtual void Fixup(StringBuilder input) {
			interceptor.Invoke("fixup$", "fixup(QString&) const", typeof(void), typeof(StringBuilder), input);
		}
		[SmokeMethod("dateTimeFromText(const QString&) const")]
		protected virtual QDateTime DateTimeFromText(string text) {
			return (QDateTime) interceptor.Invoke("dateTimeFromText$", "dateTimeFromText(const QString&) const", typeof(QDateTime), typeof(string), text);
		}
		[SmokeMethod("textFromDateTime(const QDateTime&) const")]
		protected virtual string TextFromDateTime(QDateTime dt) {
			return (string) interceptor.Invoke("textFromDateTime#", "textFromDateTime(const QDateTime&) const", typeof(string), typeof(QDateTime), dt);
		}
		[SmokeMethod("stepEnabled() const")]
		protected override int StepEnabled() {
			return (int) interceptor.Invoke("stepEnabled", "stepEnabled() const", typeof(int));
		}
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected override void MousePressEvent(QMouseEvent arg1) {
			interceptor.Invoke("mousePressEvent#", "mousePressEvent(QMouseEvent*)", typeof(void), typeof(QMouseEvent), arg1);
		}
		[SmokeMethod("paintEvent(QPaintEvent*)")]
		protected override void PaintEvent(QPaintEvent arg1) {
			interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), arg1);
		}
		protected new void InitStyleOption(QStyleOptionSpinBox option) {
			interceptor.Invoke("initStyleOption#", "initStyleOption(QStyleOptionSpinBox*) const", typeof(void), typeof(QStyleOptionSpinBox), option);
		}
		~QDateTimeEdit() {
			interceptor.Invoke("~QDateTimeEdit", "~QDateTimeEdit()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QDateTimeEdit", "~QDateTimeEdit()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQDateTimeEditSignals Emit {
			get { return (IQDateTimeEditSignals) Q_EMIT; }
		}
	}

	public interface IQDateTimeEditSignals : IQAbstractSpinBoxSignals {
		[Q_SIGNAL("void dateTimeChanged(const QDateTime&)")]
		void DateTimeChanged(QDateTime date);
		[Q_SIGNAL("void timeChanged(const QTime&)")]
		void TimeChanged(QTime date);
		[Q_SIGNAL("void dateChanged(const QDate&)")]
		void DateChanged(QDate date);
	}
}
