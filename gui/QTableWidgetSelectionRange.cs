//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QTableWidgetSelectionRange")]
    public class QTableWidgetSelectionRange : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QTableWidgetSelectionRange(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QTableWidgetSelectionRange), this);
        }
        public QTableWidgetSelectionRange() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTableWidgetSelectionRange", "QTableWidgetSelectionRange()", typeof(void));
        }
        public QTableWidgetSelectionRange(int top, int left, int bottom, int right) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTableWidgetSelectionRange$$$$", "QTableWidgetSelectionRange(int, int, int, int)", typeof(void), typeof(int), top, typeof(int), left, typeof(int), bottom, typeof(int), right);
        }
        public QTableWidgetSelectionRange(QTableWidgetSelectionRange other) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTableWidgetSelectionRange#", "QTableWidgetSelectionRange(const QTableWidgetSelectionRange&)", typeof(void), typeof(QTableWidgetSelectionRange), other);
        }
        public int TopRow() {
            return (int) interceptor.Invoke("topRow", "topRow() const", typeof(int));
        }
        public int BottomRow() {
            return (int) interceptor.Invoke("bottomRow", "bottomRow() const", typeof(int));
        }
        public int LeftColumn() {
            return (int) interceptor.Invoke("leftColumn", "leftColumn() const", typeof(int));
        }
        public int RightColumn() {
            return (int) interceptor.Invoke("rightColumn", "rightColumn() const", typeof(int));
        }
        public int RowCount() {
            return (int) interceptor.Invoke("rowCount", "rowCount() const", typeof(int));
        }
        public int ColumnCount() {
            return (int) interceptor.Invoke("columnCount", "columnCount() const", typeof(int));
        }
        ~QTableWidgetSelectionRange() {
            interceptor.Invoke("~QTableWidgetSelectionRange", "~QTableWidgetSelectionRange()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QTableWidgetSelectionRange", "~QTableWidgetSelectionRange()", typeof(void));
        }
    }
}
