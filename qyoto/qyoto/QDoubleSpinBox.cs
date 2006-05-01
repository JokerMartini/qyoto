//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	/// See <see cref="IQDoubleSpinBoxSignals"></see> for signals emitted by QDoubleSpinBox
	[SmokeClass("QDoubleSpinBox")]
	public class QDoubleSpinBox : QAbstractSpinBox, IDisposable {
 		protected QDoubleSpinBox(Type dummy) : base((Type) null) {}
		interface IQDoubleSpinBoxProxy {
			string Tr(string s, string c);
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDoubleSpinBox), this);
			_interceptor = (QDoubleSpinBox) realProxy.GetTransparentProxy();
		}
		private QDoubleSpinBox ProxyQDoubleSpinBox() {
			return (QDoubleSpinBox) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDoubleSpinBox() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDoubleSpinBoxProxy), null);
			_staticInterceptor = (IQDoubleSpinBoxProxy) realProxy.GetTransparentProxy();
		}
		private static IQDoubleSpinBoxProxy StaticQDoubleSpinBox() {
			return (IQDoubleSpinBoxProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQDoubleSpinBox().MetaObject();
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QDoubleSpinBox(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQDoubleSpinBox(parent);
		}
		[SmokeMethod("QDoubleSpinBox(QWidget*)")]
		private void NewQDoubleSpinBox(QWidget parent) {
			ProxyQDoubleSpinBox().NewQDoubleSpinBox(parent);
		}
		public QDoubleSpinBox() : this((Type) null) {
			CreateProxy();
			NewQDoubleSpinBox();
		}
		[SmokeMethod("QDoubleSpinBox()")]
		private void NewQDoubleSpinBox() {
			ProxyQDoubleSpinBox().NewQDoubleSpinBox();
		}
		[SmokeMethod("value() const")]
		public double Value() {
			return ProxyQDoubleSpinBox().Value();
		}
		[SmokeMethod("prefix() const")]
		public string Prefix() {
			return ProxyQDoubleSpinBox().Prefix();
		}
		[SmokeMethod("setPrefix(const QString&)")]
		public void SetPrefix(string p) {
			ProxyQDoubleSpinBox().SetPrefix(p);
		}
		[SmokeMethod("suffix() const")]
		public string Suffix() {
			return ProxyQDoubleSpinBox().Suffix();
		}
		[SmokeMethod("setSuffix(const QString&)")]
		public void SetSuffix(string s) {
			ProxyQDoubleSpinBox().SetSuffix(s);
		}
		[SmokeMethod("cleanText() const")]
		public string CleanText() {
			return ProxyQDoubleSpinBox().CleanText();
		}
		[SmokeMethod("singleStep() const")]
		public double SingleStep() {
			return ProxyQDoubleSpinBox().SingleStep();
		}
		[SmokeMethod("setSingleStep(double)")]
		public void SetSingleStep(double val) {
			ProxyQDoubleSpinBox().SetSingleStep(val);
		}
		[SmokeMethod("minimum() const")]
		public double Minimum() {
			return ProxyQDoubleSpinBox().Minimum();
		}
		[SmokeMethod("setMinimum(double)")]
		public void SetMinimum(double min) {
			ProxyQDoubleSpinBox().SetMinimum(min);
		}
		[SmokeMethod("maximum() const")]
		public double Maximum() {
			return ProxyQDoubleSpinBox().Maximum();
		}
		[SmokeMethod("setMaximum(double)")]
		public void SetMaximum(double max) {
			ProxyQDoubleSpinBox().SetMaximum(max);
		}
		[SmokeMethod("setRange(double, double)")]
		public void SetRange(double min, double max) {
			ProxyQDoubleSpinBox().SetRange(min,max);
		}
		[SmokeMethod("decimals() const")]
		public int Decimals() {
			return ProxyQDoubleSpinBox().Decimals();
		}
		[SmokeMethod("setDecimals(int)")]
		public void SetDecimals(int prec) {
			ProxyQDoubleSpinBox().SetDecimals(prec);
		}
		[SmokeMethod("validate(QString&, int&) const")]
		public new virtual int Validate(StringBuilder input, out int pos) {
			return ProxyQDoubleSpinBox().Validate(input,out pos);
		}
		[SmokeMethod("valueFromText(const QString&) const")]
		public virtual double ValueFromText(string text) {
			return ProxyQDoubleSpinBox().ValueFromText(text);
		}
		[SmokeMethod("textFromValue(double) const")]
		public virtual string TextFromValue(double v) {
			return ProxyQDoubleSpinBox().TextFromValue(v);
		}
		[SmokeMethod("fixup(QString&) const")]
		public new virtual void Fixup(StringBuilder str) {
			ProxyQDoubleSpinBox().Fixup(str);
		}
		[SmokeMethod("setValue(double)")]
		public void SetValue(double val) {
			ProxyQDoubleSpinBox().SetValue(val);
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string s, string c) {
			return StaticQDoubleSpinBox().Tr(s,c);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string s) {
			return StaticQDoubleSpinBox().Tr(s);
		}
		~QDoubleSpinBox() {
			DisposeQDoubleSpinBox();
		}
		public new void Dispose() {
			DisposeQDoubleSpinBox();
		}
		private void DisposeQDoubleSpinBox() {
			ProxyQDoubleSpinBox().DisposeQDoubleSpinBox();
		}
		protected new IQDoubleSpinBoxSignals Emit() {
			return (IQDoubleSpinBoxSignals) Q_EMIT;
		}
	}

	public interface IQDoubleSpinBoxSignals : IQAbstractSpinBoxSignals {
		[Q_SIGNAL("void valueChanged(double)")]
		void ValueChanged(double arg1);
		[Q_SIGNAL("void valueChanged(const QString&)")]
		void ValueChanged(string arg1);
	}
}
