//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Collections.Generic;
    [SmokeClass("QTextOption")]
    public class QTextOption : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QTextOption(Type dummy) {}
        [SmokeClass("QTextOption::Tab")]
        public class Tab : Object, IDisposable {
            protected SmokeInvocation interceptor = null;
            private IntPtr smokeObject;
            protected Tab(Type dummy) {}
            protected void CreateProxy() {
                interceptor = new SmokeInvocation(typeof(Tab), this);
            }
            private static SmokeInvocation staticInterceptor = null;
            static Tab() {
                staticInterceptor = new SmokeInvocation(typeof(Tab), null);
            }
            public double Position {
                get { return (double) interceptor.Invoke("position", "position()", typeof(double)); }
                set { interceptor.Invoke("setPosition$", "setPosition(qreal)", typeof(void), typeof(double), value); }
            }
            public QChar Delimiter {
                get { return (QChar) interceptor.Invoke("delimiter", "delimiter()", typeof(QChar)); }
                set { interceptor.Invoke("setDelimiter#", "setDelimiter(QChar)", typeof(void), typeof(QChar), value); }
            }
            public Tab() : this((Type) null) {
                CreateProxy();
                interceptor.Invoke("Tab", "Tab()", typeof(void));
            }
            public override bool Equals(object o) {
                if (!(o is Tab)) { return false; }
                return this == (Tab) o;
            }
            public override int GetHashCode() {
                return interceptor.GetHashCode();
            }
            ~Tab() {
                interceptor.Invoke("~Tab", "~Tab()", typeof(void));
            }
            public void Dispose() {
                interceptor.Invoke("~Tab", "~Tab()", typeof(void));
            }
            public static bool operator==(Tab lhs, QTextOption.Tab other) {
                return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QTextOption::Tab&) const", typeof(bool), typeof(Tab), lhs, typeof(QTextOption.Tab), other);
            }
            public static bool operator!=(Tab lhs, QTextOption.Tab other) {
                return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QTextOption::Tab&) const", typeof(bool), typeof(Tab), lhs, typeof(QTextOption.Tab), other);
            }
        }
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QTextOption), this);
        }
        public enum TabType {
            LeftTab = 0,
            RightTab = 1,
            CenterTab = 2,
            DelimiterTab = 3,
        }
        public enum WrapMode {
            NoWrap = 0,
            WordWrap = 1,
            ManualWrap = 2,
            WrapAnywhere = 3,
            WrapAtWordBoundaryOrAnywhere = 4,
        }
        public enum Flag : uint {
            ShowTabsAndSpaces = 0x1,
            ShowLineAndParagraphSeparators = 0x2,
            AddSpaceForLineAndParagraphSeparators = 0x4,
            SuppressColors = 0x8,
            IncludeTrailingSpaces = 0x80000000,
        }
        public QTextOption() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTextOption", "QTextOption()", typeof(void));
        }
        public QTextOption(uint alignment) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTextOption$", "QTextOption(Qt::Alignment)", typeof(void), typeof(uint), alignment);
        }
        public QTextOption(QTextOption o) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTextOption#", "QTextOption(const QTextOption&)", typeof(void), typeof(QTextOption), o);
        }
        public void SetAlignment(uint alignment) {
            interceptor.Invoke("setAlignment$", "setAlignment(Qt::Alignment)", typeof(void), typeof(uint), alignment);
        }
        public uint Alignment() {
            return (uint) interceptor.Invoke("alignment", "alignment() const", typeof(uint));
        }
        public void SetTextDirection(Qt.LayoutDirection aDirection) {
            interceptor.Invoke("setTextDirection$", "setTextDirection(Qt::LayoutDirection)", typeof(void), typeof(Qt.LayoutDirection), aDirection);
        }
        public Qt.LayoutDirection TextDirection() {
            return (Qt.LayoutDirection) interceptor.Invoke("textDirection", "textDirection() const", typeof(Qt.LayoutDirection));
        }
        public void SetWrapMode(QTextOption.WrapMode wrap) {
            interceptor.Invoke("setWrapMode$", "setWrapMode(QTextOption::WrapMode)", typeof(void), typeof(QTextOption.WrapMode), wrap);
        }
        public QTextOption.WrapMode wrapMode() {
            return (QTextOption.WrapMode) interceptor.Invoke("wrapMode", "wrapMode() const", typeof(QTextOption.WrapMode));
        }
        public void SetFlags(uint flags) {
            interceptor.Invoke("setFlags$", "setFlags(QTextOption::Flags)", typeof(void), typeof(uint), flags);
        }
        public uint Flags() {
            return (uint) interceptor.Invoke("flags", "flags() const", typeof(uint));
        }
        public void SetTabStop(double tabStop) {
            interceptor.Invoke("setTabStop$", "setTabStop(qreal)", typeof(void), typeof(double), tabStop);
        }
        public double TabStop() {
            return (double) interceptor.Invoke("tabStop", "tabStop() const", typeof(double));
        }
        public void SetTabArray(List<double> tabStops) {
            interceptor.Invoke("setTabArray?", "setTabArray(QList<qreal>)", typeof(void), typeof(List<double>), tabStops);
        }
        public List<double> TabArray() {
            return (List<double>) interceptor.Invoke("tabArray", "tabArray() const", typeof(List<double>));
        }
        public void SetTabs(List<QTextOption.Tab> tabStops) {
            interceptor.Invoke("setTabs?", "setTabs(QList<QTextOption::Tab>)", typeof(void), typeof(List<QTextOption.Tab>), tabStops);
        }
        public List<QTextOption.Tab> Tabs() {
            return (List<QTextOption.Tab>) interceptor.Invoke("tabs", "tabs() const", typeof(List<QTextOption.Tab>));
        }
        public void SetUseDesignMetrics(bool b) {
            interceptor.Invoke("setUseDesignMetrics$", "setUseDesignMetrics(bool)", typeof(void), typeof(bool), b);
        }
        public bool UseDesignMetrics() {
            return (bool) interceptor.Invoke("useDesignMetrics", "useDesignMetrics() const", typeof(bool));
        }
        ~QTextOption() {
            interceptor.Invoke("~QTextOption", "~QTextOption()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QTextOption", "~QTextOption()", typeof(void));
        }
    }
}
