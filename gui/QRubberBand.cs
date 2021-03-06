//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QRubberBand")]
    public class QRubberBand : QWidget, IDisposable {
        protected QRubberBand(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QRubberBand), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QRubberBand() {
            staticInterceptor = new SmokeInvocation(typeof(QRubberBand), null);
        }
        public enum Shape {
            Line = 0,
            Rectangle = 1,
        }
        public QRubberBand(QRubberBand.Shape arg1, QWidget arg2) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QRubberBand$#", "QRubberBand(QRubberBand::Shape, QWidget*)", typeof(void), typeof(QRubberBand.Shape), arg1, typeof(QWidget), arg2);
        }
        public QRubberBand(QRubberBand.Shape arg1) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QRubberBand$", "QRubberBand(QRubberBand::Shape)", typeof(void), typeof(QRubberBand.Shape), arg1);
        }
        public QRubberBand.Shape shape() {
            return (QRubberBand.Shape) interceptor.Invoke("shape", "shape() const", typeof(QRubberBand.Shape));
        }
        public void SetGeometry(QRect r) {
            interceptor.Invoke("setGeometry#", "setGeometry(const QRect&)", typeof(void), typeof(QRect), r);
        }
        public new void SetGeometry(int x, int y, int w, int h) {
            interceptor.Invoke("setGeometry$$$$", "setGeometry(int, int, int, int)", typeof(void), typeof(int), x, typeof(int), y, typeof(int), w, typeof(int), h);
        }
        public new void Move(int x, int y) {
            interceptor.Invoke("move$$", "move(int, int)", typeof(void), typeof(int), x, typeof(int), y);
        }
        public void Move(QPoint p) {
            interceptor.Invoke("move#", "move(const QPoint&)", typeof(void), typeof(QPoint), p);
        }
        public new void Resize(int w, int h) {
            interceptor.Invoke("resize$$", "resize(int, int)", typeof(void), typeof(int), w, typeof(int), h);
        }
        public void Resize(QSize s) {
            interceptor.Invoke("resize#", "resize(const QSize&)", typeof(void), typeof(QSize), s);
        }
        [SmokeMethod("event(QEvent*)")]
        protected override bool Event(QEvent e) {
            return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), e);
        }
        [SmokeMethod("paintEvent(QPaintEvent*)")]
        protected override void PaintEvent(QPaintEvent arg1) {
            interceptor.Invoke("paintEvent#", "paintEvent(QPaintEvent*)", typeof(void), typeof(QPaintEvent), arg1);
        }
        [SmokeMethod("changeEvent(QEvent*)")]
        protected override void ChangeEvent(QEvent arg1) {
            interceptor.Invoke("changeEvent#", "changeEvent(QEvent*)", typeof(void), typeof(QEvent), arg1);
        }
        [SmokeMethod("showEvent(QShowEvent*)")]
        protected override void ShowEvent(QShowEvent arg1) {
            interceptor.Invoke("showEvent#", "showEvent(QShowEvent*)", typeof(void), typeof(QShowEvent), arg1);
        }
        [SmokeMethod("resizeEvent(QResizeEvent*)")]
        protected override void ResizeEvent(QResizeEvent arg1) {
            interceptor.Invoke("resizeEvent#", "resizeEvent(QResizeEvent*)", typeof(void), typeof(QResizeEvent), arg1);
        }
        [SmokeMethod("moveEvent(QMoveEvent*)")]
        protected override void MoveEvent(QMoveEvent arg1) {
            interceptor.Invoke("moveEvent#", "moveEvent(QMoveEvent*)", typeof(void), typeof(QMoveEvent), arg1);
        }
        protected void InitStyleOption(QStyleOptionRubberBand option) {
            interceptor.Invoke("initStyleOption#", "initStyleOption(QStyleOptionRubberBand*) const", typeof(void), typeof(QStyleOptionRubberBand), option);
        }
        ~QRubberBand() {
            interceptor.Invoke("~QRubberBand", "~QRubberBand()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QRubberBand", "~QRubberBand()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQRubberBandSignals Emit {
            get { return (IQRubberBandSignals) Q_EMIT; }
        }
    }

    public interface IQRubberBandSignals : IQWidgetSignals {
    }
}
