//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QGraphicsItemAnimation")]
	public class QGraphicsItemAnimation : QObject, IDisposable {
 		protected QGraphicsItemAnimation(Type dummy) : base((Type) null) {}
		[SmokeClass("QGraphicsItemAnimation")]
		interface IQGraphicsItemAnimationProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QGraphicsItemAnimation), this);
			_interceptor = (QGraphicsItemAnimation) realProxy.GetTransparentProxy();
		}
		private QGraphicsItemAnimation ProxyQGraphicsItemAnimation() {
			return (QGraphicsItemAnimation) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QGraphicsItemAnimation() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQGraphicsItemAnimationProxy), null);
			_staticInterceptor = (IQGraphicsItemAnimationProxy) realProxy.GetTransparentProxy();
		}
		private static IQGraphicsItemAnimationProxy StaticQGraphicsItemAnimation() {
			return (IQGraphicsItemAnimationProxy) _staticInterceptor;
		}
		public QGraphicsItemAnimation(QObject parent) : this((Type) null) {
			CreateProxy();
			NewQGraphicsItemAnimation(parent);
		}
		[SmokeMethod("QGraphicsItemAnimation", "(QObject*)", "#")]
		private void NewQGraphicsItemAnimation(QObject parent) {
			ProxyQGraphicsItemAnimation().NewQGraphicsItemAnimation(parent);
		}
		public QGraphicsItemAnimation() : this((Type) null) {
			CreateProxy();
			NewQGraphicsItemAnimation();
		}
		[SmokeMethod("QGraphicsItemAnimation", "()", "")]
		private void NewQGraphicsItemAnimation() {
			ProxyQGraphicsItemAnimation().NewQGraphicsItemAnimation();
		}
		[SmokeMethod("item", "() const", "")]
		public QGraphicsItem Item() {
			return ProxyQGraphicsItemAnimation().Item();
		}
		[SmokeMethod("setItem", "(QGraphicsItem*)", "#")]
		public void SetItem(QGraphicsItem item) {
			ProxyQGraphicsItemAnimation().SetItem(item);
		}
		[SmokeMethod("timeLine", "() const", "")]
		public QTimeLine TimeLine() {
			return ProxyQGraphicsItemAnimation().TimeLine();
		}
		[SmokeMethod("setTimeLine", "(QTimeLine*)", "#")]
		public void SetTimeLine(QTimeLine timeLine) {
			ProxyQGraphicsItemAnimation().SetTimeLine(timeLine);
		}
		[SmokeMethod("posAt", "(qreal) const", "$")]
		public QPointF PosAt(double step) {
			return ProxyQGraphicsItemAnimation().PosAt(step);
		}
		[SmokeMethod("setPosAt", "(qreal, const QPointF&)", "$#")]
		public void SetPosAt(double step, QPointF pos) {
			ProxyQGraphicsItemAnimation().SetPosAt(step,pos);
		}
		[SmokeMethod("matrixAt", "(qreal) const", "$")]
		public QMatrix MatrixAt(double step) {
			return ProxyQGraphicsItemAnimation().MatrixAt(step);
		}
		[SmokeMethod("rotationAt", "(qreal) const", "$")]
		public double RotationAt(double step) {
			return ProxyQGraphicsItemAnimation().RotationAt(step);
		}
		[SmokeMethod("setRotationAt", "(qreal, qreal)", "$$")]
		public void SetRotationAt(double step, double angle) {
			ProxyQGraphicsItemAnimation().SetRotationAt(step,angle);
		}
		[SmokeMethod("xTranslationAt", "(qreal) const", "$")]
		public double XTranslationAt(double step) {
			return ProxyQGraphicsItemAnimation().XTranslationAt(step);
		}
		[SmokeMethod("yTranslationAt", "(qreal) const", "$")]
		public double YTranslationAt(double step) {
			return ProxyQGraphicsItemAnimation().YTranslationAt(step);
		}
		[SmokeMethod("setTranslationAt", "(qreal, qreal, qreal)", "$$$")]
		public void SetTranslationAt(double step, double dx, double dy) {
			ProxyQGraphicsItemAnimation().SetTranslationAt(step,dx,dy);
		}
		[SmokeMethod("verticalScaleAt", "(qreal) const", "$")]
		public double VerticalScaleAt(double step) {
			return ProxyQGraphicsItemAnimation().VerticalScaleAt(step);
		}
		[SmokeMethod("horizontalScaleAt", "(qreal) const", "$")]
		public double HorizontalScaleAt(double step) {
			return ProxyQGraphicsItemAnimation().HorizontalScaleAt(step);
		}
		[SmokeMethod("setScaleAt", "(qreal, qreal, qreal)", "$$$")]
		public void SetScaleAt(double step, double sx, double sy) {
			ProxyQGraphicsItemAnimation().SetScaleAt(step,sx,sy);
		}
		[SmokeMethod("verticalShearAt", "(qreal) const", "$")]
		public double VerticalShearAt(double step) {
			return ProxyQGraphicsItemAnimation().VerticalShearAt(step);
		}
		[SmokeMethod("horizontalShearAt", "(qreal) const", "$")]
		public double HorizontalShearAt(double step) {
			return ProxyQGraphicsItemAnimation().HorizontalShearAt(step);
		}
		[SmokeMethod("setShearAt", "(qreal, qreal, qreal)", "$$$")]
		public void SetShearAt(double step, double sh, double sv) {
			ProxyQGraphicsItemAnimation().SetShearAt(step,sh,sv);
		}
		[SmokeMethod("clear", "()", "")]
		public void Clear() {
			ProxyQGraphicsItemAnimation().Clear();
		}
		[Q_SLOT("void setStep(qreal)")]
		[SmokeMethod("setStep", "(qreal)", "$")]
		public void SetStep(double x) {
			ProxyQGraphicsItemAnimation().SetStep(x);
		}
		[Q_SLOT("void reset()")]
		[SmokeMethod("reset", "()", "")]
		public void Reset() {
			ProxyQGraphicsItemAnimation().Reset();
		}
		public static string Tr(string s, string c) {
			return StaticQGraphicsItemAnimation().Tr(s,c);
		}
		public static string Tr(string s) {
			return StaticQGraphicsItemAnimation().Tr(s);
		}
		[SmokeMethod("beforeAnimationStep", "(qreal)", "$")]
		protected virtual void BeforeAnimationStep(double step) {
			ProxyQGraphicsItemAnimation().BeforeAnimationStep(step);
		}
		[SmokeMethod("afterAnimationStep", "(qreal)", "$")]
		protected virtual void AfterAnimationStep(double step) {
			ProxyQGraphicsItemAnimation().AfterAnimationStep(step);
		}
		~QGraphicsItemAnimation() {
			DisposeQGraphicsItemAnimation();
		}
		public new void Dispose() {
			DisposeQGraphicsItemAnimation();
		}
		[SmokeMethod("~QGraphicsItemAnimation", "()", "")]
		private void DisposeQGraphicsItemAnimation() {
			ProxyQGraphicsItemAnimation().DisposeQGraphicsItemAnimation();
		}
		protected new IQGraphicsItemAnimationSignals Emit {
			get { return (IQGraphicsItemAnimationSignals) Q_EMIT; }
		}
	}

	public interface IQGraphicsItemAnimationSignals : IQObjectSignals {
	}
}
