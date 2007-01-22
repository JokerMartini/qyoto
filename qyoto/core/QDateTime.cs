//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QDateTime")]
	public class QDateTime : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QDateTime(Type dummy) {}
		interface IQDateTimeProxy {
			bool op_equals(QDateTime lhs, QDateTime other);
			bool op_lt(QDateTime lhs, QDateTime other);
			bool op_lte(QDateTime lhs, QDateTime other);
			bool op_gt(QDateTime lhs, QDateTime other);
			bool op_gte(QDateTime lhs, QDateTime other);
			QDateTime CurrentDateTime();
			QDateTime FromString(string s, Qt.DateFormat f);
			QDateTime FromString(string s);
			QDateTime FromString(string s, string format);
			QDateTime FromTime_t(uint secsSince1Jan1970UTC);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDateTime), this);
			_interceptor = (QDateTime) realProxy.GetTransparentProxy();
		}
		private QDateTime ProxyQDateTime() {
			return (QDateTime) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDateTime() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDateTimeProxy), null);
			_staticInterceptor = (IQDateTimeProxy) realProxy.GetTransparentProxy();
		}
		private static IQDateTimeProxy StaticQDateTime() {
			return (IQDateTimeProxy) _staticInterceptor;
		}

		public QDateTime() : this((Type) null) {
			CreateProxy();
			NewQDateTime();
		}
		[SmokeMethod("QDateTime()")]
		private void NewQDateTime() {
			ProxyQDateTime().NewQDateTime();
		}
		public QDateTime(QDate arg1) : this((Type) null) {
			CreateProxy();
			NewQDateTime(arg1);
		}
		[SmokeMethod("QDateTime(const QDate&)")]
		private void NewQDateTime(QDate arg1) {
			ProxyQDateTime().NewQDateTime(arg1);
		}
		public QDateTime(QDate arg1, QTime arg2, Qt.TimeSpec spec) : this((Type) null) {
			CreateProxy();
			NewQDateTime(arg1,arg2,spec);
		}
		[SmokeMethod("QDateTime(const QDate&, const QTime&, Qt::TimeSpec)")]
		private void NewQDateTime(QDate arg1, QTime arg2, Qt.TimeSpec spec) {
			ProxyQDateTime().NewQDateTime(arg1,arg2,spec);
		}
		public QDateTime(QDate arg1, QTime arg2) : this((Type) null) {
			CreateProxy();
			NewQDateTime(arg1,arg2);
		}
		[SmokeMethod("QDateTime(const QDate&, const QTime&)")]
		private void NewQDateTime(QDate arg1, QTime arg2) {
			ProxyQDateTime().NewQDateTime(arg1,arg2);
		}
		public QDateTime(QDateTime other) : this((Type) null) {
			CreateProxy();
			NewQDateTime(other);
		}
		[SmokeMethod("QDateTime(const QDateTime&)")]
		private void NewQDateTime(QDateTime other) {
			ProxyQDateTime().NewQDateTime(other);
		}
		[SmokeMethod("isNull() const")]
		public bool IsNull() {
			return ProxyQDateTime().IsNull();
		}
		[SmokeMethod("isValid() const")]
		public bool IsValid() {
			return ProxyQDateTime().IsValid();
		}
		[SmokeMethod("date() const")]
		public QDate Date() {
			return ProxyQDateTime().Date();
		}
		[SmokeMethod("time() const")]
		public QTime Time() {
			return ProxyQDateTime().Time();
		}
		[SmokeMethod("timeSpec() const")]
		public Qt.TimeSpec TimeSpec() {
			return ProxyQDateTime().TimeSpec();
		}
		[SmokeMethod("toTime_t() const")]
		public uint ToTime_t() {
			return ProxyQDateTime().ToTime_t();
		}
		[SmokeMethod("setDate(const QDate&)")]
		public void SetDate(QDate date) {
			ProxyQDateTime().SetDate(date);
		}
		[SmokeMethod("setTime(const QTime&)")]
		public void SetTime(QTime time) {
			ProxyQDateTime().SetTime(time);
		}
		[SmokeMethod("setTimeSpec(Qt::TimeSpec)")]
		public void SetTimeSpec(Qt.TimeSpec spec) {
			ProxyQDateTime().SetTimeSpec(spec);
		}
		[SmokeMethod("setTime_t(uint)")]
		public void SetTime_t(uint secsSince1Jan1970UTC) {
			ProxyQDateTime().SetTime_t(secsSince1Jan1970UTC);
		}
		[SmokeMethod("toString(Qt::DateFormat) const")]
		public new string ToString(Qt.DateFormat f) {
			return ProxyQDateTime().ToString(f);
		}
		[SmokeMethod("toString() const")]
		public new string ToString() {
			return ProxyQDateTime().ToString();
		}
		[SmokeMethod("toString(const QString&) const")]
		public new string ToString(string format) {
			return ProxyQDateTime().ToString(format);
		}
		[SmokeMethod("addDays(int) const")]
		public QDateTime AddDays(int days) {
			return ProxyQDateTime().AddDays(days);
		}
		[SmokeMethod("addMonths(int) const")]
		public QDateTime AddMonths(int months) {
			return ProxyQDateTime().AddMonths(months);
		}
		[SmokeMethod("addYears(int) const")]
		public QDateTime AddYears(int years) {
			return ProxyQDateTime().AddYears(years);
		}
		[SmokeMethod("addSecs(int) const")]
		public QDateTime AddSecs(int secs) {
			return ProxyQDateTime().AddSecs(secs);
		}
		[SmokeMethod("addMSecs(qint64) const")]
		public QDateTime AddMSecs(long msecs) {
			return ProxyQDateTime().AddMSecs(msecs);
		}
		[SmokeMethod("toTimeSpec(Qt::TimeSpec) const")]
		public QDateTime ToTimeSpec(Qt.TimeSpec spec) {
			return ProxyQDateTime().ToTimeSpec(spec);
		}
		[SmokeMethod("toLocalTime() const")]
		public QDateTime ToLocalTime() {
			return ProxyQDateTime().ToLocalTime();
		}
		[SmokeMethod("toUTC() const")]
		public QDateTime ToUTC() {
			return ProxyQDateTime().ToUTC();
		}
		[SmokeMethod("daysTo(const QDateTime&) const")]
		public int DaysTo(QDateTime arg1) {
			return ProxyQDateTime().DaysTo(arg1);
		}
		[SmokeMethod("secsTo(const QDateTime&) const")]
		public int SecsTo(QDateTime arg1) {
			return ProxyQDateTime().SecsTo(arg1);
		}
		[SmokeMethod("operator==(const QDateTime&) const")]
		public static bool operator==(QDateTime lhs, QDateTime other) {
			return StaticQDateTime().op_equals(lhs,other);
		}
		public static bool operator!=(QDateTime lhs, QDateTime other) {
			return !StaticQDateTime().op_equals(lhs,other);
		}
		public override bool Equals(object o) {
			if (!(o is QDateTime)) { return false; }
			return this == (QDateTime) o;
		}
		public override int GetHashCode() {
			return ProxyQDateTime().GetHashCode();
		}
		[SmokeMethod("operator<(const QDateTime&) const")]
		public static bool operator<(QDateTime lhs, QDateTime other) {
			return StaticQDateTime().op_lt(lhs,other);
		}
		[SmokeMethod("operator<=(const QDateTime&) const")]
		public static bool operator<=(QDateTime lhs, QDateTime other) {
			return StaticQDateTime().op_lte(lhs,other);
		}
		[SmokeMethod("operator>(const QDateTime&) const")]
		public static bool operator>(QDateTime lhs, QDateTime other) {
			return StaticQDateTime().op_gt(lhs,other);
		}
		[SmokeMethod("operator>=(const QDateTime&) const")]
		public static bool operator>=(QDateTime lhs, QDateTime other) {
			return StaticQDateTime().op_gte(lhs,other);
		}
		[SmokeMethod("currentDateTime()")]
		public static QDateTime CurrentDateTime() {
			return StaticQDateTime().CurrentDateTime();
		}
		[SmokeMethod("fromString(const QString&, Qt::DateFormat)")]
		public static QDateTime FromString(string s, Qt.DateFormat f) {
			return StaticQDateTime().FromString(s,f);
		}
		[SmokeMethod("fromString(const QString&)")]
		public static QDateTime FromString(string s) {
			return StaticQDateTime().FromString(s);
		}
		[SmokeMethod("fromString(const QString&, const QString&)")]
		public static QDateTime FromString(string s, string format) {
			return StaticQDateTime().FromString(s,format);
		}
		[SmokeMethod("fromTime_t(uint)")]
		public static QDateTime FromTime_t(uint secsSince1Jan1970UTC) {
			return StaticQDateTime().FromTime_t(secsSince1Jan1970UTC);
		}
		~QDateTime() {
			DisposeQDateTime();
		}
		public void Dispose() {
			DisposeQDateTime();
		}
		[SmokeMethod("~QDateTime()")]
		private void DisposeQDateTime() {
			ProxyQDateTime().DisposeQDateTime();
		}
	}
}
