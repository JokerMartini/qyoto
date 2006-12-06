//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	/// See <see cref="IQCalendarWidgetSignals"></see> for signals emitted by QCalendarWidget
	[SmokeClass("QCalendarWidget")]
	public class QCalendarWidget : QWidget, IDisposable {
 		protected QCalendarWidget(Type dummy) : base((Type) null) {}
		interface IQCalendarWidgetProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QCalendarWidget), this);
			_interceptor = (QCalendarWidget) realProxy.GetTransparentProxy();
		}
		private QCalendarWidget ProxyQCalendarWidget() {
			return (QCalendarWidget) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QCalendarWidget() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQCalendarWidgetProxy), null);
			_staticInterceptor = (IQCalendarWidgetProxy) realProxy.GetTransparentProxy();
		}
		private static IQCalendarWidgetProxy StaticQCalendarWidget() {
			return (IQCalendarWidgetProxy) _staticInterceptor;
		}

		public enum HorizontalHeaderFormat {
			NoHorizontalHeader = 0,
			SingleLetterDayNames = 1,
			ShortDayNames = 2,
			LongDayNames = 3,
		}
		public enum VerticalHeaderFormat {
			NoVerticalHeader = 0,
			ISOWeekNumbers = 1,
		}
		public enum SelectionMode {
			NoSelection = 0,
			SingleSelection = 1,
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QCalendarWidget(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQCalendarWidget(parent);
		}
		[SmokeMethod("QCalendarWidget(QWidget*)")]
		private void NewQCalendarWidget(QWidget parent) {
			ProxyQCalendarWidget().NewQCalendarWidget(parent);
		}
		public QCalendarWidget() : this((Type) null) {
			CreateProxy();
			NewQCalendarWidget();
		}
		[SmokeMethod("QCalendarWidget()")]
		private void NewQCalendarWidget() {
			ProxyQCalendarWidget().NewQCalendarWidget();
		}
		[SmokeMethod("sizeHint() const")]
		public new virtual QSize SizeHint() {
			return ProxyQCalendarWidget().SizeHint();
		}
		[SmokeMethod("minimumSizeHint() const")]
		public new virtual QSize MinimumSizeHint() {
			return ProxyQCalendarWidget().MinimumSizeHint();
		}
		[SmokeMethod("selectedDate() const")]
		public DateTime SelectedDate() {
			return ProxyQCalendarWidget().SelectedDate();
		}
		[SmokeMethod("yearShown() const")]
		public int YearShown() {
			return ProxyQCalendarWidget().YearShown();
		}
		[SmokeMethod("monthShown() const")]
		public int MonthShown() {
			return ProxyQCalendarWidget().MonthShown();
		}
		[SmokeMethod("minimumDate() const")]
		public DateTime MinimumDate() {
			return ProxyQCalendarWidget().MinimumDate();
		}
		[SmokeMethod("setMinimumDate(const QDate&)")]
		public void SetMinimumDate(DateTime date) {
			ProxyQCalendarWidget().SetMinimumDate(date);
		}
		[SmokeMethod("maximumDate() const")]
		public DateTime MaximumDate() {
			return ProxyQCalendarWidget().MaximumDate();
		}
		[SmokeMethod("setMaximumDate(const QDate&)")]
		public void SetMaximumDate(DateTime date) {
			ProxyQCalendarWidget().SetMaximumDate(date);
		}
		[SmokeMethod("firstDayOfWeek() const")]
		public Qt.DayOfWeek FirstDayOfWeek() {
			return ProxyQCalendarWidget().FirstDayOfWeek();
		}
		[SmokeMethod("setFirstDayOfWeek(Qt::DayOfWeek)")]
		public void SetFirstDayOfWeek(Qt.DayOfWeek dayOfWeek) {
			ProxyQCalendarWidget().SetFirstDayOfWeek(dayOfWeek);
		}
		[SmokeMethod("isHeaderVisible() const")]
		public bool IsHeaderVisible() {
			return ProxyQCalendarWidget().IsHeaderVisible();
		}
		[SmokeMethod("setHeaderVisible(bool)")]
		public void SetHeaderVisible(bool show) {
			ProxyQCalendarWidget().SetHeaderVisible(show);
		}
		[SmokeMethod("isGridVisible() const")]
		public bool IsGridVisible() {
			return ProxyQCalendarWidget().IsGridVisible();
		}
		[SmokeMethod("setGridVisible(bool)")]
		public void SetGridVisible(bool show) {
			ProxyQCalendarWidget().SetGridVisible(show);
		}
		[SmokeMethod("selectionMode() const")]
		public QCalendarWidget.SelectionMode selectionMode() {
			return ProxyQCalendarWidget().selectionMode();
		}
		[SmokeMethod("setSelectionMode(QCalendarWidget::SelectionMode)")]
		public void SetSelectionMode(QCalendarWidget.SelectionMode mode) {
			ProxyQCalendarWidget().SetSelectionMode(mode);
		}
		[SmokeMethod("horizontalHeaderFormat() const")]
		public QCalendarWidget.HorizontalHeaderFormat horizontalHeaderFormat() {
			return ProxyQCalendarWidget().horizontalHeaderFormat();
		}
		[SmokeMethod("setHorizontalHeaderFormat(QCalendarWidget::HorizontalHeaderFormat)")]
		public void SetHorizontalHeaderFormat(QCalendarWidget.HorizontalHeaderFormat format) {
			ProxyQCalendarWidget().SetHorizontalHeaderFormat(format);
		}
		[SmokeMethod("verticalHeaderFormat() const")]
		public QCalendarWidget.VerticalHeaderFormat verticalHeaderFormat() {
			return ProxyQCalendarWidget().verticalHeaderFormat();
		}
		[SmokeMethod("setVerticalHeaderFormat(QCalendarWidget::VerticalHeaderFormat)")]
		public void SetVerticalHeaderFormat(QCalendarWidget.VerticalHeaderFormat format) {
			ProxyQCalendarWidget().SetVerticalHeaderFormat(format);
		}
		[SmokeMethod("headerTextFormat() const")]
		public QTextCharFormat HeaderTextFormat() {
			return ProxyQCalendarWidget().HeaderTextFormat();
		}
		[SmokeMethod("setHeaderTextFormat(const QTextCharFormat&)")]
		public void SetHeaderTextFormat(QTextCharFormat format) {
			ProxyQCalendarWidget().SetHeaderTextFormat(format);
		}
		[SmokeMethod("weekdayTextFormat(Qt::DayOfWeek) const")]
		public QTextCharFormat WeekdayTextFormat(Qt.DayOfWeek dayOfWeek) {
			return ProxyQCalendarWidget().WeekdayTextFormat(dayOfWeek);
		}
		[SmokeMethod("setWeekdayTextFormat(Qt::DayOfWeek, const QTextCharFormat&)")]
		public void SetWeekdayTextFormat(Qt.DayOfWeek dayOfWeek, QTextCharFormat format) {
			ProxyQCalendarWidget().SetWeekdayTextFormat(dayOfWeek,format);
		}
		// QMap<QDate, QTextCharFormat> dateTextFormat(); >>>> NOT CONVERTED
		[SmokeMethod("dateTextFormat(const QDate&) const")]
		public QTextCharFormat DateTextFormat(DateTime date) {
			return ProxyQCalendarWidget().DateTextFormat(date);
		}
		[SmokeMethod("setDateTextFormat(const QDate&, const QTextCharFormat&)")]
		public void SetDateTextFormat(DateTime date, QTextCharFormat color) {
			ProxyQCalendarWidget().SetDateTextFormat(date,color);
		}
		[SmokeMethod("setSelectedDate(const QDate&)")]
		public void SetSelectedDate(DateTime date) {
			ProxyQCalendarWidget().SetSelectedDate(date);
		}
		[SmokeMethod("setDateRange(const QDate&, const QDate&)")]
		public void SetDateRange(DateTime min, DateTime max) {
			ProxyQCalendarWidget().SetDateRange(min,max);
		}
		[SmokeMethod("setCurrentPage(int, int)")]
		public void SetCurrentPage(int year, int month) {
			ProxyQCalendarWidget().SetCurrentPage(year,month);
		}
		[SmokeMethod("showNextMonth()")]
		public void ShowNextMonth() {
			ProxyQCalendarWidget().ShowNextMonth();
		}
		[SmokeMethod("showPreviousMonth()")]
		public void ShowPreviousMonth() {
			ProxyQCalendarWidget().ShowPreviousMonth();
		}
		[SmokeMethod("showNextYear()")]
		public void ShowNextYear() {
			ProxyQCalendarWidget().ShowNextYear();
		}
		[SmokeMethod("showPreviousYear()")]
		public void ShowPreviousYear() {
			ProxyQCalendarWidget().ShowPreviousYear();
		}
		[SmokeMethod("showSelectedDate()")]
		public void ShowSelectedDate() {
			ProxyQCalendarWidget().ShowSelectedDate();
		}
		[SmokeMethod("showToday()")]
		public void ShowToday() {
			ProxyQCalendarWidget().ShowToday();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQCalendarWidget().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQCalendarWidget().Tr(s);
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent arg1) {
			return ProxyQCalendarWidget().Event(arg1);
		}
		[SmokeMethod("mousePressEvent(QMouseEvent*)")]
		protected new void MousePressEvent(QMouseEvent arg1) {
			ProxyQCalendarWidget().MousePressEvent(arg1);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected new void ResizeEvent(QResizeEvent arg1) {
			ProxyQCalendarWidget().ResizeEvent(arg1);
		}
		[SmokeMethod("keyPressEvent(QKeyEvent*)")]
		protected new void KeyPressEvent(QKeyEvent arg1) {
			ProxyQCalendarWidget().KeyPressEvent(arg1);
		}
		[SmokeMethod("paintCell(QPainter*, const QRect&, const QDate&) const")]
		public virtual void PaintCell(QPainter painter, QRect rect, DateTime date) {
			ProxyQCalendarWidget().PaintCell(painter,rect,date);
		}
		~QCalendarWidget() {
			DisposeQCalendarWidget();
		}
		public new void Dispose() {
			DisposeQCalendarWidget();
		}
		[SmokeMethod("~QCalendarWidget()")]
		private void DisposeQCalendarWidget() {
			ProxyQCalendarWidget().DisposeQCalendarWidget();
		}
		protected new IQCalendarWidgetSignals Emit() {
			return (IQCalendarWidgetSignals) Q_EMIT;
		}
	}

	public interface IQCalendarWidgetSignals : IQWidgetSignals {
		[Q_SIGNAL("void selectionChanged()")]
		void SelectionChanged();
		[Q_SIGNAL("void clicked(const QDate&)")]
		void Clicked(DateTime date);
		[Q_SIGNAL("void activated(const QDate&)")]
		void Activated(DateTime date);
		[Q_SIGNAL("void currentPageChanged(int, int)")]
		void CurrentPageChanged(int year, int month);
	}
}
