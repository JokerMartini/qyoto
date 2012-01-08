//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QTableWidgetItem")]
    public class QTableWidgetItem : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QTableWidgetItem(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QTableWidgetItem), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QTableWidgetItem() {
            staticInterceptor = new SmokeInvocation(typeof(QTableWidgetItem), null);
        }
        public enum ItemType {
            Type = 0,
            UserType = 1000,
        }
        public QTableWidgetItem(int type) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTableWidgetItem$", "QTableWidgetItem(int)", typeof(void), typeof(int), type);
        }
        public QTableWidgetItem() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTableWidgetItem", "QTableWidgetItem()", typeof(void));
        }
        public QTableWidgetItem(string text, int type) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTableWidgetItem$$", "QTableWidgetItem(const QString&, int)", typeof(void), typeof(string), text, typeof(int), type);
        }
        public QTableWidgetItem(string text) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTableWidgetItem$", "QTableWidgetItem(const QString&)", typeof(void), typeof(string), text);
        }
        public QTableWidgetItem(QIcon icon, string text, int type) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTableWidgetItem#$$", "QTableWidgetItem(const QIcon&, const QString&, int)", typeof(void), typeof(QIcon), icon, typeof(string), text, typeof(int), type);
        }
        public QTableWidgetItem(QIcon icon, string text) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTableWidgetItem#$", "QTableWidgetItem(const QIcon&, const QString&)", typeof(void), typeof(QIcon), icon, typeof(string), text);
        }
        public QTableWidgetItem(QTableWidgetItem other) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTableWidgetItem#", "QTableWidgetItem(const QTableWidgetItem&)", typeof(void), typeof(QTableWidgetItem), other);
        }
        [SmokeMethod("clone() const")]
        public virtual QTableWidgetItem Clone() {
            return (QTableWidgetItem) interceptor.Invoke("clone", "clone() const", typeof(QTableWidgetItem));
        }
        public QTableWidget TableWidget() {
            return (QTableWidget) interceptor.Invoke("tableWidget", "tableWidget() const", typeof(QTableWidget));
        }
        public int Row() {
            return (int) interceptor.Invoke("row", "row() const", typeof(int));
        }
        public int Column() {
            return (int) interceptor.Invoke("column", "column() const", typeof(int));
        }
        public void SetSelected(bool select) {
            interceptor.Invoke("setSelected$", "setSelected(bool)", typeof(void), typeof(bool), select);
        }
        public bool IsSelected() {
            return (bool) interceptor.Invoke("isSelected", "isSelected() const", typeof(bool));
        }
        public uint Flags() {
            return (uint) interceptor.Invoke("flags", "flags() const", typeof(uint));
        }
        public void SetFlags(uint flags) {
            interceptor.Invoke("setFlags$", "setFlags(Qt::ItemFlags)", typeof(void), typeof(uint), flags);
        }
        public string Text() {
            return (string) interceptor.Invoke("text", "text() const", typeof(string));
        }
        public void SetText(string text) {
            interceptor.Invoke("setText$", "setText(const QString&)", typeof(void), typeof(string), text);
        }
        public QIcon Icon() {
            return (QIcon) interceptor.Invoke("icon", "icon() const", typeof(QIcon));
        }
        public void SetIcon(QIcon icon) {
            interceptor.Invoke("setIcon#", "setIcon(const QIcon&)", typeof(void), typeof(QIcon), icon);
        }
        public string StatusTip() {
            return (string) interceptor.Invoke("statusTip", "statusTip() const", typeof(string));
        }
        public void SetStatusTip(string statusTip) {
            interceptor.Invoke("setStatusTip$", "setStatusTip(const QString&)", typeof(void), typeof(string), statusTip);
        }
        public string ToolTip() {
            return (string) interceptor.Invoke("toolTip", "toolTip() const", typeof(string));
        }
        public void SetToolTip(string toolTip) {
            interceptor.Invoke("setToolTip$", "setToolTip(const QString&)", typeof(void), typeof(string), toolTip);
        }
        public string WhatsThis() {
            return (string) interceptor.Invoke("whatsThis", "whatsThis() const", typeof(string));
        }
        public void SetWhatsThis(string whatsThis) {
            interceptor.Invoke("setWhatsThis$", "setWhatsThis(const QString&)", typeof(void), typeof(string), whatsThis);
        }
        public QFont Font() {
            return (QFont) interceptor.Invoke("font", "font() const", typeof(QFont));
        }
        public void SetFont(QFont font) {
            interceptor.Invoke("setFont#", "setFont(const QFont&)", typeof(void), typeof(QFont), font);
        }
        public int TextAlignment() {
            return (int) interceptor.Invoke("textAlignment", "textAlignment() const", typeof(int));
        }
        public void SetTextAlignment(int alignment) {
            interceptor.Invoke("setTextAlignment$", "setTextAlignment(int)", typeof(void), typeof(int), alignment);
        }
        public QColor BackgroundColor() {
            return (QColor) interceptor.Invoke("backgroundColor", "backgroundColor() const", typeof(QColor));
        }
        public void SetBackgroundColor(QColor color) {
            interceptor.Invoke("setBackgroundColor#", "setBackgroundColor(const QColor&)", typeof(void), typeof(QColor), color);
        }
        public QBrush Background() {
            return (QBrush) interceptor.Invoke("background", "background() const", typeof(QBrush));
        }
        public void SetBackground(QBrush brush) {
            interceptor.Invoke("setBackground#", "setBackground(const QBrush&)", typeof(void), typeof(QBrush), brush);
        }
        public QColor TextColor() {
            return (QColor) interceptor.Invoke("textColor", "textColor() const", typeof(QColor));
        }
        public void SetTextColor(QColor color) {
            interceptor.Invoke("setTextColor#", "setTextColor(const QColor&)", typeof(void), typeof(QColor), color);
        }
        public QBrush Foreground() {
            return (QBrush) interceptor.Invoke("foreground", "foreground() const", typeof(QBrush));
        }
        public void SetForeground(QBrush brush) {
            interceptor.Invoke("setForeground#", "setForeground(const QBrush&)", typeof(void), typeof(QBrush), brush);
        }
        public Qt.CheckState CheckState() {
            return (Qt.CheckState) interceptor.Invoke("checkState", "checkState() const", typeof(Qt.CheckState));
        }
        public void SetCheckState(Qt.CheckState state) {
            interceptor.Invoke("setCheckState$", "setCheckState(Qt::CheckState)", typeof(void), typeof(Qt.CheckState), state);
        }
        public QSize SizeHint() {
            return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
        }
        public void SetSizeHint(QSize size) {
            interceptor.Invoke("setSizeHint#", "setSizeHint(const QSize&)", typeof(void), typeof(QSize), size);
        }
        [SmokeMethod("data(int) const")]
        public virtual QVariant Data(int role) {
            return (QVariant) interceptor.Invoke("data$", "data(int) const", typeof(QVariant), typeof(int), role);
        }
        [SmokeMethod("setData(int, const QVariant&)")]
        public virtual void SetData(int role, QVariant value) {
            interceptor.Invoke("setData$#", "setData(int, const QVariant&)", typeof(void), typeof(int), role, typeof(QVariant), value);
        }
        [SmokeMethod("read(QDataStream&)")]
        public virtual void Read(QDataStream arg1) {
            interceptor.Invoke("read#", "read(QDataStream&)", typeof(void), typeof(QDataStream), arg1);
        }
        [SmokeMethod("write(QDataStream&) const")]
        public virtual void Write(QDataStream arg1) {
            interceptor.Invoke("write#", "write(QDataStream&) const", typeof(void), typeof(QDataStream), arg1);
        }
        public int type() {
            return (int) interceptor.Invoke("type", "type() const", typeof(int));
        }
        ~QTableWidgetItem() {
            interceptor.Invoke("~QTableWidgetItem", "~QTableWidgetItem()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QTableWidgetItem", "~QTableWidgetItem()", typeof(void));
        }
        public static bool operator<(QTableWidgetItem lhs, QTableWidgetItem other) {
            return (bool) staticInterceptor.Invoke("operator<#", "operator<(const QTableWidgetItem&) const", typeof(bool), typeof(QTableWidgetItem), lhs, typeof(QTableWidgetItem), other);
        }
        public static bool operator>(QTableWidgetItem lhs, QTableWidgetItem other) {
            return !(bool) staticInterceptor.Invoke("operator<#", "operator<(const QTableWidgetItem&) const", typeof(bool), typeof(QTableWidgetItem), lhs, typeof(QTableWidgetItem), other)
                        && !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QTableWidgetItem&) const", typeof(bool), typeof(QTableWidgetItem), lhs, typeof(QTableWidgetItem), other);
        }
    }
}