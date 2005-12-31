//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQTimeEditSignals"></see> for signals emitted by QTimeEdit
	public class QTimeEdit : QDateTimeEditBase, IDisposable {
 		protected QTimeEdit(Type dummy) : base((Type) null) {}
		interface IQTimeEditProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
		}

		protected void CreateQTimeEditProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTimeEdit), this);
			_interceptor = (QTimeEdit) realProxy.GetTransparentProxy();
		}
		private QTimeEdit ProxyQTimeEdit() {
			return (QTimeEdit) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTimeEdit() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTimeEditProxy), null);
			_staticInterceptor = (IQTimeEditProxy) realProxy.GetTransparentProxy();
		}
		private static IQTimeEditProxy StaticQTimeEdit() {
			return (IQTimeEditProxy) _staticInterceptor;
		}

		enum E_Display {
			Hours = 0x01,
			Minutes = 0x02,
			Seconds = 0x04,
			AMPM = 0x10,
		}
		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQTimeEdit().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQTimeEdit().ClassName();
		}
		public QTimeEdit(QWidget parent, string name) : this((Type) null) {
			CreateQTimeEditProxy();
			CreateQTimeEditSignalProxy();
			NewQTimeEdit(parent,name);
		}
		[SmokeMethod("QTimeEdit(QWidget*, const char*)")]
		private void NewQTimeEdit(QWidget parent, string name) {
			ProxyQTimeEdit().NewQTimeEdit(parent,name);
		}
		public QTimeEdit(QWidget parent) : this((Type) null) {
			CreateQTimeEditProxy();
			CreateQTimeEditSignalProxy();
			NewQTimeEdit(parent);
		}
		[SmokeMethod("QTimeEdit(QWidget*)")]
		private void NewQTimeEdit(QWidget parent) {
			ProxyQTimeEdit().NewQTimeEdit(parent);
		}
		public QTimeEdit() : this((Type) null) {
			CreateQTimeEditProxy();
			CreateQTimeEditSignalProxy();
			NewQTimeEdit();
		}
		[SmokeMethod("QTimeEdit()")]
		private void NewQTimeEdit() {
			ProxyQTimeEdit().NewQTimeEdit();
		}
		public QTimeEdit(DateTime time, QWidget parent, string name) : this((Type) null) {
			CreateQTimeEditProxy();
			CreateQTimeEditSignalProxy();
			NewQTimeEdit(time,parent,name);
		}
		[SmokeMethod("QTimeEdit(const QTime&, QWidget*, const char*)")]
		private void NewQTimeEdit(DateTime time, QWidget parent, string name) {
			ProxyQTimeEdit().NewQTimeEdit(time,parent,name);
		}
		public QTimeEdit(DateTime time, QWidget parent) : this((Type) null) {
			CreateQTimeEditProxy();
			CreateQTimeEditSignalProxy();
			NewQTimeEdit(time,parent);
		}
		[SmokeMethod("QTimeEdit(const QTime&, QWidget*)")]
		private void NewQTimeEdit(DateTime time, QWidget parent) {
			ProxyQTimeEdit().NewQTimeEdit(time,parent);
		}
		public QTimeEdit(DateTime time) : this((Type) null) {
			CreateQTimeEditProxy();
			CreateQTimeEditSignalProxy();
			NewQTimeEdit(time);
		}
		[SmokeMethod("QTimeEdit(const QTime&)")]
		private void NewQTimeEdit(DateTime time) {
			ProxyQTimeEdit().NewQTimeEdit(time);
		}
		[SmokeMethod("sizeHint() const")]
		public new QSize SizeHint() {
			return ProxyQTimeEdit().SizeHint();
		}
		[SmokeMethod("minimumSizeHint() const")]
		public new QSize MinimumSizeHint() {
			return ProxyQTimeEdit().MinimumSizeHint();
		}
		[SmokeMethod("time() const")]
		public DateTime Time() {
			return ProxyQTimeEdit().Time();
		}
		[SmokeMethod("setAutoAdvance(bool)")]
		public virtual void SetAutoAdvance(bool advance) {
			ProxyQTimeEdit().SetAutoAdvance(advance);
		}
		[SmokeMethod("autoAdvance() const")]
		public bool AutoAdvance() {
			return ProxyQTimeEdit().AutoAdvance();
		}
		[SmokeMethod("setMinValue(const QTime&)")]
		public virtual void SetMinValue(DateTime d) {
			ProxyQTimeEdit().SetMinValue(d);
		}
		[SmokeMethod("minValue() const")]
		public DateTime MinValue() {
			return ProxyQTimeEdit().MinValue();
		}
		[SmokeMethod("setMaxValue(const QTime&)")]
		public virtual void SetMaxValue(DateTime d) {
			ProxyQTimeEdit().SetMaxValue(d);
		}
		[SmokeMethod("maxValue() const")]
		public DateTime MaxValue() {
			return ProxyQTimeEdit().MaxValue();
		}
		[SmokeMethod("setRange(const QTime&, const QTime&)")]
		public virtual void SetRange(DateTime min, DateTime max) {
			ProxyQTimeEdit().SetRange(min,max);
		}
		[SmokeMethod("separator() const")]
		public string Separator() {
			return ProxyQTimeEdit().Separator();
		}
		[SmokeMethod("setSeparator(const QString&)")]
		public virtual void SetSeparator(string s) {
			ProxyQTimeEdit().SetSeparator(s);
		}
		[SmokeMethod("display() const")]
		public uint Display() {
			return ProxyQTimeEdit().Display();
		}
		[SmokeMethod("setDisplay(uint)")]
		public void SetDisplay(uint disp) {
			ProxyQTimeEdit().SetDisplay(disp);
		}
		[SmokeMethod("removeFirstNumber(int)")]
		public void RemoveFirstNumber(int sec) {
			ProxyQTimeEdit().RemoveFirstNumber(sec);
		}
		[Q_SLOT("setTime(const QTime&)")]
		[SmokeMethod("setTime(const QTime&)")]
		public virtual void SetTime(DateTime time) {
			ProxyQTimeEdit().SetTime(time);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQTimeEdit().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQTimeEdit().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQTimeEdit().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQTimeEdit().TrUtf8(arg1);
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent e) {
			return ProxyQTimeEdit().Event(e);
		}
		[SmokeMethod("timerEvent(QTimerEvent*)")]
		protected new void TimerEvent(QTimerEvent e) {
			ProxyQTimeEdit().TimerEvent(e);
		}
		[SmokeMethod("resizeEvent(QResizeEvent*)")]
		protected new void ResizeEvent(QResizeEvent arg1) {
			ProxyQTimeEdit().ResizeEvent(arg1);
		}
		[SmokeMethod("stepUp()")]
		public new void StepUp() {
			ProxyQTimeEdit().StepUp();
		}
		[SmokeMethod("stepDown()")]
		public new void StepDown() {
			ProxyQTimeEdit().StepDown();
		}
		[SmokeMethod("sectionFormattedText(int)")]
		public new string SectionFormattedText(int sec) {
			return ProxyQTimeEdit().SectionFormattedText(sec);
		}
		[SmokeMethod("addNumber(int, int)")]
		public new void AddNumber(int sec, int num) {
			ProxyQTimeEdit().AddNumber(sec,num);
		}
		[SmokeMethod("removeLastNumber(int)")]
		public new void RemoveLastNumber(int sec) {
			ProxyQTimeEdit().RemoveLastNumber(sec);
		}
		[SmokeMethod("setFocusSection(int)")]
		public new bool SetFocusSection(int s) {
			return ProxyQTimeEdit().SetFocusSection(s);
		}
		[SmokeMethod("outOfRange(int, int, int) const")]
		protected virtual bool OutOfRange(int h, int m, int s) {
			return ProxyQTimeEdit().OutOfRange(h,m,s);
		}
		[SmokeMethod("setHour(int)")]
		protected virtual void SetHour(int h) {
			ProxyQTimeEdit().SetHour(h);
		}
		[SmokeMethod("setMinute(int)")]
		protected virtual void SetMinute(int m) {
			ProxyQTimeEdit().SetMinute(m);
		}
		[SmokeMethod("setSecond(int)")]
		protected virtual void SetSecond(int s) {
			ProxyQTimeEdit().SetSecond(s);
		}
		[Q_SLOT("updateButtons()")]
		[SmokeMethod("updateButtons()")]
		protected void UpdateButtons() {
			ProxyQTimeEdit().UpdateButtons();
		}
		~QTimeEdit() {
			DisposeQTimeEdit();
		}
		public new void Dispose() {
			DisposeQTimeEdit();
		}
		private void DisposeQTimeEdit() {
			ProxyQTimeEdit().DisposeQTimeEdit();
		}
		protected void CreateQTimeEditSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQTimeEditSignals), this);
			_signalInterceptor = (IQTimeEditSignals) realProxy.GetTransparentProxy();
		}
		protected new IQTimeEditSignals Emit() {
			return (IQTimeEditSignals) _signalInterceptor;
		}
	}

	public interface IQTimeEditSignals : IQDateTimeEditBaseSignals {
		[Q_SIGNAL("valueChanged(const QTime&)")]
		void ValueChanged(DateTime time);
	}
}
