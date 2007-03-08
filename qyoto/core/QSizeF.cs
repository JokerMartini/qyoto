//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QSizeF")]
	public class QSizeF : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QSizeF(Type dummy) {}
		[SmokeClass("QSizeF")]
		interface IQSizeFProxy {
			[SmokeMethod("operator*=", "(qreal)", "$")]
			QSizeF op_mult(QSizeF lhs, double c);
			[SmokeMethod("operator/=", "(qreal)", "$")]
			QSizeF op_div(QSizeF lhs, double c);
			[SmokeMethod("operator==", "(const QSizeF&, const QSizeF&)", "##")]
			bool op_equals(QSizeF s1, QSizeF s2);
			[SmokeMethod("operator+", "(const QSizeF&, const QSizeF&)", "##")]
			QSizeF op_plus(QSizeF s1, QSizeF s2);
			[SmokeMethod("operator-", "(const QSizeF&, const QSizeF&)", "##")]
			QSizeF op_minus(QSizeF s1, QSizeF s2);
			[SmokeMethod("operator*", "(qreal, const QSizeF&)", "$#")]
			QSizeF op_mult(double c, QSizeF s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QSizeF), this);
			_interceptor = (QSizeF) realProxy.GetTransparentProxy();
		}
		private QSizeF ProxyQSizeF() {
			return (QSizeF) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QSizeF() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQSizeFProxy), null);
			_staticInterceptor = (IQSizeFProxy) realProxy.GetTransparentProxy();
		}
		private static IQSizeFProxy StaticQSizeF() {
			return (IQSizeFProxy) _staticInterceptor;
		}
		public QSizeF() : this((Type) null) {
			CreateProxy();
			NewQSizeF();
		}
		[SmokeMethod("QSizeF", "()", "")]
		private void NewQSizeF() {
			ProxyQSizeF().NewQSizeF();
		}
		public QSizeF(QSize sz) : this((Type) null) {
			CreateProxy();
			NewQSizeF(sz);
		}
		[SmokeMethod("QSizeF", "(const QSize&)", "#")]
		private void NewQSizeF(QSize sz) {
			ProxyQSizeF().NewQSizeF(sz);
		}
		public QSizeF(double w, double h) : this((Type) null) {
			CreateProxy();
			NewQSizeF(w,h);
		}
		[SmokeMethod("QSizeF", "(qreal, qreal)", "$$")]
		private void NewQSizeF(double w, double h) {
			ProxyQSizeF().NewQSizeF(w,h);
		}
		[SmokeMethod("isNull", "() const", "")]
		public bool IsNull() {
			return ProxyQSizeF().IsNull();
		}
		[SmokeMethod("isEmpty", "() const", "")]
		public bool IsEmpty() {
			return ProxyQSizeF().IsEmpty();
		}
		[SmokeMethod("isValid", "() const", "")]
		public bool IsValid() {
			return ProxyQSizeF().IsValid();
		}
		[SmokeMethod("width", "() const", "")]
		public double Width() {
			return ProxyQSizeF().Width();
		}
		[SmokeMethod("height", "() const", "")]
		public double Height() {
			return ProxyQSizeF().Height();
		}
		[SmokeMethod("setWidth", "(qreal)", "$")]
		public void SetWidth(double w) {
			ProxyQSizeF().SetWidth(w);
		}
		[SmokeMethod("setHeight", "(qreal)", "$")]
		public void SetHeight(double h) {
			ProxyQSizeF().SetHeight(h);
		}
		[SmokeMethod("transpose", "()", "")]
		public void Transpose() {
			ProxyQSizeF().Transpose();
		}
		[SmokeMethod("scale", "(qreal, qreal, Qt::AspectRatioMode)", "$$$")]
		public void Scale(double w, double h, Qt.AspectRatioMode mode) {
			ProxyQSizeF().Scale(w,h,mode);
		}
		[SmokeMethod("scale", "(const QSizeF&, Qt::AspectRatioMode)", "#$")]
		public void Scale(QSizeF s, Qt.AspectRatioMode mode) {
			ProxyQSizeF().Scale(s,mode);
		}
		[SmokeMethod("expandedTo", "(const QSizeF&) const", "#")]
		public QSizeF ExpandedTo(QSizeF arg1) {
			return ProxyQSizeF().ExpandedTo(arg1);
		}
		[SmokeMethod("boundedTo", "(const QSizeF&) const", "#")]
		public QSizeF BoundedTo(QSizeF arg1) {
			return ProxyQSizeF().BoundedTo(arg1);
		}
		// qreal& rwidth(); >>>> NOT CONVERTED
		// qreal& rheight(); >>>> NOT CONVERTED
		public static QSizeF operator*(QSizeF lhs, double c) {
			return StaticQSizeF().op_mult(lhs,c);
		}
		public static QSizeF operator/(QSizeF lhs, double c) {
			return StaticQSizeF().op_div(lhs,c);
		}
		[SmokeMethod("toSize", "() const", "")]
		public QSize ToSize() {
			return ProxyQSizeF().ToSize();
		}
		~QSizeF() {
			DisposeQSizeF();
		}
		public void Dispose() {
			DisposeQSizeF();
		}
		[SmokeMethod("~QSizeF", "()", "")]
		private void DisposeQSizeF() {
			ProxyQSizeF().DisposeQSizeF();
		}
		public static bool operator==(QSizeF s1, QSizeF s2) {
			return StaticQSizeF().op_equals(s1,s2);
		}
		public static bool operator!=(QSizeF s1, QSizeF s2) {
			return !StaticQSizeF().op_equals(s1,s2);
		}
		public override bool Equals(object o) {
			if (!(o is QSizeF)) { return false; }
			return this == (QSizeF) o;
		}
		public override int GetHashCode() {
			return ProxyQSizeF().GetHashCode();
		}
		public static QSizeF operator+(QSizeF s1, QSizeF s2) {
			return StaticQSizeF().op_plus(s1,s2);
		}
		public static QSizeF operator-(QSizeF s1, QSizeF s2) {
			return StaticQSizeF().op_minus(s1,s2);
		}
		public static QSizeF operator*(double c, QSizeF s) {
			return StaticQSizeF().op_mult(c,s);
		}
	}
}
