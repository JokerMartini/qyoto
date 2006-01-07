//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQDateEditSignals"></see> for signals emitted by QDateEdit
	[SmokeClass("QDateEdit")]
	public class QDateEdit : QDateTimeEditBase, IDisposable {
 		protected QDateEdit(Type dummy) : base((Type) null) {}
		interface IQDateEditProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQDateEditProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDateEdit), this);
			_interceptor = (QDateEdit) realProxy.GetTransparentProxy();
		}
		private QDateEdit ProxyQDateEdit() {
			return (QDateEdit) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDateEdit() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDateEditProxy), null);
			_staticInterceptor = (IQDateEditProxy) realProxy.GetTransparentProxy();
		}
		private static IQDateEditProxy StaticQDateEdit() {
			return (IQDateEditProxy) _staticInterceptor;
		}

		public enum Order {
			DMY = 0,
			MDY = 1,
			YMD = 2,
			YDM = 3,
		}
		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQDateEdit().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQDateEdit().ClassName();
		}
		public QDateEdit(QWidget parent, string name) : this((Type) null) {
			CreateQDateEditProxy();
			CreateQDateEditSignalProxy();
			NewQDateEdit(parent,name);
		}
		[SmokeMethod("QDateEdit(QWidget*, const char*)")]
		private void NewQDateEdit(QWidget parent, string name) {
			ProxyQDateEdit().NewQDateEdit(parent,name);
		}
		public QDateEdit(QWidget parent) : this((Type) null) {
			CreateQDateEditProxy();
			CreateQDateEditSignalProxy();
			NewQDateEdit(parent);
		}
		[SmokeMethod("QDateEdit(QWidget*)")]
		private void NewQDateEdit(QWidget parent) {
			ProxyQDateEdit().NewQDateEdit(parent);
		}
		public QDateEdit() : this((Type) null) {
			CreateQDateEditProxy();
			CreateQDateEditSignalProxy();
			NewQDateEdit();
		}
		[SmokeMethod("QDateEdit()")]
		private void NewQDateEdit() {
			ProxyQDateEdit().NewQDateEdit();
		}
		public QDateEdit(DateTime date, QWidget parent, string name) : this((Type) null) {
			CreateQDateEditProxy();
			CreateQDateEditSignalProxy();
			NewQDateEdit(date,parent,name);
		}
		[SmokeMethod("QDateEdit(const QDate&, QWidget*, const char*)")]
		private void NewQDateEdit(DateTime date, QWidget parent, string name) {
			ProxyQDateEdit().NewQDateEdit(date,parent,name);
		}
		public QDateEdit(DateTime date, QWidget parent) : this((Type) null) {
			CreateQDateEditProxy();
			CreateQDateEditSignalProxy();
			NewQDateEdit(date,parent);
		}
		[SmokeMethod("QDateEdit(const QDate&, QWidget*)")]
		private void NewQDateEdit(DateTime date, QWidget parent) {
			ProxyQDateEdit().NewQDateEdit(date,parent);
		}
		public QDateEdit(DateTime date) : this((Type) null) {
			CreateQDateEditProxy();
			CreateQDateEditSignalProxy();
			NewQDateEdit(date);
		}
		[SmokeMethod("QDateEdit(const QDate&)")]
		private void NewQDateEdit(DateTime date) {
			ProxyQDateEdit().NewQDateEdit(date);
		}
		[SmokeMethod("sizeHint() const")]
		public new QSize SizeHint() {
			return ProxyQDateEdit().SizeHint();
		}
		[SmokeMethod("minimumSizeHint() const")]
		public new QSize MinimumSizeHint() {
			return ProxyQDateEdit().MinimumSizeHint();
		}
		[SmokeMethod("date() const")]
		public DateTime Date() {
			return ProxyQDateEdit().Date();
		}
		[SmokeMethod("setOrder(QDateEdit::Order)")]
		public virtual void SetOrder(QDateEdit.Order order) {
			ProxyQDateEdit().SetOrder(order);
		}
		[SmokeMethod("order() const")]
		public QDateEdit.Order order() {
			return ProxyQDateEdit().order();
		}
		[SmokeMethod("setAutoAdvance(bool)")]
		public virtual void SetAutoAdvance(bool advance) {
			ProxyQDateEdit().SetAutoAdvance(advance);
		}
		[SmokeMethod("autoAdvance() const")]
		public bool AutoAdvance() {
			return ProxyQDateEdit().AutoAdvance();
		}
		[SmokeMethod("setMinValue(const QDate&)")]
		public virtual void SetMinValue(DateTime d) {
			ProxyQDateEdit().SetMinValue(d);
		}
		[SmokeMethod("minValue() const")]
		public DateTime MinValue() {
			return ProxyQDateEdit().MinValue();
		}
		[SmokeMethod("setMaxValue(const QDate&)")]
		public virtual void SetMaxValue(DateTime d) {
			ProxyQDateEdit().SetMaxValue(d);
		}
		[SmokeMethod("maxValue() const")]
		public DateTime MaxValue() {
			return ProxyQDateEdit().MaxValue();
		}
		[SmokeMethod("setRange(const QDate&, const QDate&)")]
		public virtual void SetRange(DateTime min, DateTime max) {
			ProxyQDateEdit().SetRange(min,max);
		}
		[SmokeMethod("separator() const")]
		public string Separator() {
			return ProxyQDateEdit().Separator();
		}
		[SmokeMethod("setSeparator(const QString&)")]
		public virtual void SetSeparator(string s) {
			ProxyQDateEdit().SetSeparator(s);
		}
		[SmokeMethod("removeFirstNumber(int)")]
		public void RemoveFirstNumber(int sec) {
			ProxyQDateEdit().RemoveFirstNumber(sec);
		}
		[Q_SLOT("void setDate(const QDate&)")]
		[SmokeMethod("setDate(const QDate&)")]
		public virtual void SetDate(DateTime date) {
			ProxyQDateEdit().SetDate(date);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQDateEdit().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQDateEdit().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQDateEdit().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQDateEdit().TrUtf8(arg1);
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent e) {
			return ProxyQDateEdit().Event(e);
		}
		[SmokeMethod("timerEvent(QTimerEvent*)")]
		protected new void TimerEvent(QTimerEvent arg1) {
			ProxyQDateEdit().TimerEvent(arg1);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected new void ResizeEvent(QResizeEvent arg1) {
			ProxyQDateEdit().ResizeEvent(arg1);
		}
		[SmokeMethod("stepUp()")]
		public new void StepUp() {
			ProxyQDateEdit().StepUp();
		}
		[SmokeMethod("stepDown()")]
		public new void StepDown() {
			ProxyQDateEdit().StepDown();
		}
		[SmokeMethod("sectionFormattedText(int)")]
		public new string SectionFormattedText(int sec) {
			return ProxyQDateEdit().SectionFormattedText(sec);
		}
		[SmokeMethod("addNumber(int, int)")]
		public new void AddNumber(int sec, int num) {
			ProxyQDateEdit().AddNumber(sec,num);
		}
		[SmokeMethod("removeLastNumber(int)")]
		public new void RemoveLastNumber(int sec) {
			ProxyQDateEdit().RemoveLastNumber(sec);
		}
		[SmokeMethod("setFocusSection(int)")]
		public new bool SetFocusSection(int s) {
			return ProxyQDateEdit().SetFocusSection(s);
		}
		[SmokeMethod("setYear(int)")]
		protected virtual void SetYear(int year) {
			ProxyQDateEdit().SetYear(year);
		}
		[SmokeMethod("setMonth(int)")]
		protected virtual void SetMonth(int month) {
			ProxyQDateEdit().SetMonth(month);
		}
		[SmokeMethod("setDay(int)")]
		protected virtual void SetDay(int day) {
			ProxyQDateEdit().SetDay(day);
		}
		[SmokeMethod("fix()")]
		protected virtual void Fix() {
			ProxyQDateEdit().Fix();
		}
		[SmokeMethod("outOfRange(int, int, int) const")]
		protected virtual bool OutOfRange(int y, int m, int d) {
			return ProxyQDateEdit().OutOfRange(y,m,d);
		}
		[Q_SLOT("void updateButtons()")]
		[SmokeMethod("updateButtons()")]
		protected void UpdateButtons() {
			ProxyQDateEdit().UpdateButtons();
		}
		~QDateEdit() {
			DisposeQDateEdit();
		}
		public new void Dispose() {
			DisposeQDateEdit();
		}
		private void DisposeQDateEdit() {
			ProxyQDateEdit().DisposeQDateEdit();
		}
		protected void CreateQDateEditSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQDateEditSignals), this);
			Q_EMIT = (IQDateEditSignals) realProxy.GetTransparentProxy();
		}
		protected new IQDateEditSignals Emit() {
			return (IQDateEditSignals) Q_EMIT;
		}
	}

	public interface IQDateEditSignals : IQDateTimeEditBaseSignals {
		[Q_SIGNAL("void valueChanged(const QDate&)")]
		void ValueChanged(DateTime date);
	}
}
