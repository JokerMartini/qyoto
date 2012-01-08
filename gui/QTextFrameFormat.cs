//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QTextFrameFormat")]
    public class QTextFrameFormat : QTextFormat, IDisposable {
        protected QTextFrameFormat(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QTextFrameFormat), this);
        }
        public enum Position {
            InFlow = 0,
            FloatLeft = 1,
            FloatRight = 2,
        }
        public enum BorderStyle {
            BorderStyle_None = 0,
            BorderStyle_Dotted = 1,
            BorderStyle_Dashed = 2,
            BorderStyle_Solid = 3,
            BorderStyle_Double = 4,
            BorderStyle_DotDash = 5,
            BorderStyle_DotDotDash = 6,
            BorderStyle_Groove = 7,
            BorderStyle_Ridge = 8,
            BorderStyle_Inset = 9,
            BorderStyle_Outset = 10,
        }
        public QTextFrameFormat() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTextFrameFormat", "QTextFrameFormat()", typeof(void));
        }
        public new bool IsValid() {
            return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
        }
        public void SetPosition(QTextFrameFormat.Position f) {
            interceptor.Invoke("setPosition$", "setPosition(QTextFrameFormat::Position)", typeof(void), typeof(QTextFrameFormat.Position), f);
        }
        public QTextFrameFormat.Position position() {
            return (QTextFrameFormat.Position) interceptor.Invoke("position", "position() const", typeof(QTextFrameFormat.Position));
        }
        public void SetBorder(double border) {
            interceptor.Invoke("setBorder$", "setBorder(qreal)", typeof(void), typeof(double), border);
        }
        public double Border() {
            return (double) interceptor.Invoke("border", "border() const", typeof(double));
        }
        public void SetBorderBrush(QBrush brush) {
            interceptor.Invoke("setBorderBrush#", "setBorderBrush(const QBrush&)", typeof(void), typeof(QBrush), brush);
        }
        public QBrush BorderBrush() {
            return (QBrush) interceptor.Invoke("borderBrush", "borderBrush() const", typeof(QBrush));
        }
        public void SetBorderStyle(QTextFrameFormat.BorderStyle style) {
            interceptor.Invoke("setBorderStyle$", "setBorderStyle(QTextFrameFormat::BorderStyle)", typeof(void), typeof(QTextFrameFormat.BorderStyle), style);
        }
        public QTextFrameFormat.BorderStyle borderStyle() {
            return (QTextFrameFormat.BorderStyle) interceptor.Invoke("borderStyle", "borderStyle() const", typeof(QTextFrameFormat.BorderStyle));
        }
        public void SetMargin(double margin) {
            interceptor.Invoke("setMargin$", "setMargin(qreal)", typeof(void), typeof(double), margin);
        }
        public double Margin() {
            return (double) interceptor.Invoke("margin", "margin() const", typeof(double));
        }
        public void SetTopMargin(double margin) {
            interceptor.Invoke("setTopMargin$", "setTopMargin(qreal)", typeof(void), typeof(double), margin);
        }
        public double TopMargin() {
            return (double) interceptor.Invoke("topMargin", "topMargin() const", typeof(double));
        }
        public void SetBottomMargin(double margin) {
            interceptor.Invoke("setBottomMargin$", "setBottomMargin(qreal)", typeof(void), typeof(double), margin);
        }
        public double BottomMargin() {
            return (double) interceptor.Invoke("bottomMargin", "bottomMargin() const", typeof(double));
        }
        public void SetLeftMargin(double margin) {
            interceptor.Invoke("setLeftMargin$", "setLeftMargin(qreal)", typeof(void), typeof(double), margin);
        }
        public double LeftMargin() {
            return (double) interceptor.Invoke("leftMargin", "leftMargin() const", typeof(double));
        }
        public void SetRightMargin(double margin) {
            interceptor.Invoke("setRightMargin$", "setRightMargin(qreal)", typeof(void), typeof(double), margin);
        }
        public double RightMargin() {
            return (double) interceptor.Invoke("rightMargin", "rightMargin() const", typeof(double));
        }
        public void SetPadding(double padding) {
            interceptor.Invoke("setPadding$", "setPadding(qreal)", typeof(void), typeof(double), padding);
        }
        public double Padding() {
            return (double) interceptor.Invoke("padding", "padding() const", typeof(double));
        }
        public void SetWidth(double width) {
            interceptor.Invoke("setWidth$", "setWidth(qreal)", typeof(void), typeof(double), width);
        }
        public void SetWidth(QTextLength length) {
            interceptor.Invoke("setWidth#", "setWidth(const QTextLength&)", typeof(void), typeof(QTextLength), length);
        }
        public QTextLength Width() {
            return (QTextLength) interceptor.Invoke("width", "width() const", typeof(QTextLength));
        }
        public void SetHeight(double height) {
            interceptor.Invoke("setHeight$", "setHeight(qreal)", typeof(void), typeof(double), height);
        }
        public void SetHeight(QTextLength height) {
            interceptor.Invoke("setHeight#", "setHeight(const QTextLength&)", typeof(void), typeof(QTextLength), height);
        }
        public QTextLength Height() {
            return (QTextLength) interceptor.Invoke("height", "height() const", typeof(QTextLength));
        }
        public void SetPageBreakPolicy(uint flags) {
            interceptor.Invoke("setPageBreakPolicy$", "setPageBreakPolicy(QTextFormat::PageBreakFlags)", typeof(void), typeof(uint), flags);
        }
        public uint PageBreakPolicy() {
            return (uint) interceptor.Invoke("pageBreakPolicy", "pageBreakPolicy() const", typeof(uint));
        }
        public QTextFrameFormat(QTextFormat fmt) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTextFrameFormat#", "QTextFrameFormat(const QTextFormat&)", typeof(void), typeof(QTextFormat), fmt);
        }
        ~QTextFrameFormat() {
            interceptor.Invoke("~QTextFrameFormat", "~QTextFrameFormat()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QTextFrameFormat", "~QTextFrameFormat()", typeof(void));
        }
    }
}