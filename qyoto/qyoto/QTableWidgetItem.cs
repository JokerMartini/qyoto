//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	[SmokeClass("QTableWidgetItem")]
	public class QTableWidgetItem : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QTableWidgetItem(Type dummy) {}
		interface IQTableWidgetItemProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTableWidgetItem), this);
			_interceptor = (QTableWidgetItem) realProxy.GetTransparentProxy();
		}
		private QTableWidgetItem ProxyQTableWidgetItem() {
			return (QTableWidgetItem) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTableWidgetItem() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTableWidgetItemProxy), null);
			_staticInterceptor = (IQTableWidgetItemProxy) realProxy.GetTransparentProxy();
		}
		private static IQTableWidgetItemProxy StaticQTableWidgetItem() {
			return (IQTableWidgetItemProxy) _staticInterceptor;
		}

		public const int Type = 0;
		public const int UserType = 1000;

		public QTableWidgetItem(int type) : this((Type) null) {
			CreateProxy();
			NewQTableWidgetItem(type);
		}
		[SmokeMethod("QTableWidgetItem(int)")]
		private void NewQTableWidgetItem(int type) {
			ProxyQTableWidgetItem().NewQTableWidgetItem(type);
		}
		public QTableWidgetItem() : this((Type) null) {
			CreateProxy();
			NewQTableWidgetItem();
		}
		[SmokeMethod("QTableWidgetItem()")]
		private void NewQTableWidgetItem() {
			ProxyQTableWidgetItem().NewQTableWidgetItem();
		}
		public QTableWidgetItem(string text, int type) : this((Type) null) {
			CreateProxy();
			NewQTableWidgetItem(text,type);
		}
		[SmokeMethod("QTableWidgetItem(const QString&, int)")]
		private void NewQTableWidgetItem(string text, int type) {
			ProxyQTableWidgetItem().NewQTableWidgetItem(text,type);
		}
		public QTableWidgetItem(string text) : this((Type) null) {
			CreateProxy();
			NewQTableWidgetItem(text);
		}
		[SmokeMethod("QTableWidgetItem(const QString&)")]
		private void NewQTableWidgetItem(string text) {
			ProxyQTableWidgetItem().NewQTableWidgetItem(text);
		}
		public QTableWidgetItem(QTableWidgetItem other) : this((Type) null) {
			CreateProxy();
			NewQTableWidgetItem(other);
		}
		[SmokeMethod("QTableWidgetItem(const QTableWidgetItem&)")]
		private void NewQTableWidgetItem(QTableWidgetItem other) {
			ProxyQTableWidgetItem().NewQTableWidgetItem(other);
		}
		[SmokeMethod("clone() const")]
		public virtual QTableWidgetItem Clone() {
			return ProxyQTableWidgetItem().Clone();
		}
		[SmokeMethod("tableWidget() const")]
		public QTableWidget TableWidget() {
			return ProxyQTableWidgetItem().TableWidget();
		}
		[SmokeMethod("flags() const")]
		public int Flags() {
			return ProxyQTableWidgetItem().Flags();
		}
		[SmokeMethod("setFlags(Qt::ItemFlags)")]
		public void SetFlags(int flags) {
			ProxyQTableWidgetItem().SetFlags(flags);
		}
		[SmokeMethod("text() const")]
		public string Text() {
			return ProxyQTableWidgetItem().Text();
		}
		[SmokeMethod("setText(const QString&)")]
		public void SetText(string text) {
			ProxyQTableWidgetItem().SetText(text);
		}
		[SmokeMethod("icon() const")]
		public QIcon Icon() {
			return ProxyQTableWidgetItem().Icon();
		}
		[SmokeMethod("setIcon(const QIcon&)")]
		public void SetIcon(QIcon icon) {
			ProxyQTableWidgetItem().SetIcon(icon);
		}
		[SmokeMethod("statusTip() const")]
		public string StatusTip() {
			return ProxyQTableWidgetItem().StatusTip();
		}
		[SmokeMethod("setStatusTip(const QString&)")]
		public void SetStatusTip(string statusTip) {
			ProxyQTableWidgetItem().SetStatusTip(statusTip);
		}
		[SmokeMethod("toolTip() const")]
		public string ToolTip() {
			return ProxyQTableWidgetItem().ToolTip();
		}
		[SmokeMethod("setToolTip(const QString&)")]
		public void SetToolTip(string toolTip) {
			ProxyQTableWidgetItem().SetToolTip(toolTip);
		}
		[SmokeMethod("whatsThis() const")]
		public string WhatsThis() {
			return ProxyQTableWidgetItem().WhatsThis();
		}
		[SmokeMethod("setWhatsThis(const QString&)")]
		public void SetWhatsThis(string whatsThis) {
			ProxyQTableWidgetItem().SetWhatsThis(whatsThis);
		}
		[SmokeMethod("font() const")]
		public QFont Font() {
			return ProxyQTableWidgetItem().Font();
		}
		[SmokeMethod("setFont(const QFont&)")]
		public void SetFont(QFont font) {
			ProxyQTableWidgetItem().SetFont(font);
		}
		[SmokeMethod("textAlignment() const")]
		public int TextAlignment() {
			return ProxyQTableWidgetItem().TextAlignment();
		}
		[SmokeMethod("setTextAlignment(int)")]
		public void SetTextAlignment(int alignment) {
			ProxyQTableWidgetItem().SetTextAlignment(alignment);
		}
		[SmokeMethod("backgroundColor() const")]
		public QColor BackgroundColor() {
			return ProxyQTableWidgetItem().BackgroundColor();
		}
		[SmokeMethod("setBackgroundColor(const QColor&)")]
		public void SetBackgroundColor(QColor color) {
			ProxyQTableWidgetItem().SetBackgroundColor(color);
		}
		[SmokeMethod("textColor() const")]
		public QColor TextColor() {
			return ProxyQTableWidgetItem().TextColor();
		}
		[SmokeMethod("setTextColor(const QColor&)")]
		public void SetTextColor(QColor color) {
			ProxyQTableWidgetItem().SetTextColor(color);
		}
		[SmokeMethod("checkState() const")]
		public Qt.CheckState CheckState() {
			return ProxyQTableWidgetItem().CheckState();
		}
		[SmokeMethod("setCheckState(Qt::CheckState)")]
		public void SetCheckState(Qt.CheckState state) {
			ProxyQTableWidgetItem().SetCheckState(state);
		}
		[SmokeMethod("sizeHint() const")]
		public QSize SizeHint() {
			return ProxyQTableWidgetItem().SizeHint();
		}
		[SmokeMethod("setSizeHint(const QSize&)")]
		public void SetSizeHint(QSize size) {
			ProxyQTableWidgetItem().SetSizeHint(size);
		}
		[SmokeMethod("data(int) const")]
		public virtual QVariant Data(int role) {
			return ProxyQTableWidgetItem().Data(role);
		}
		[SmokeMethod("setData(int, const QVariant&)")]
		public virtual void SetData(int role, QVariant value) {
			ProxyQTableWidgetItem().SetData(role,value);
		}
		[SmokeMethod("read(QDataStream&)")]
		public virtual void Read(QDataStream arg1) {
			ProxyQTableWidgetItem().Read(arg1);
		}
		[SmokeMethod("write(QDataStream&) const")]
		public virtual void Write(QDataStream arg1) {
			ProxyQTableWidgetItem().Write(arg1);
		}
		[SmokeMethod("type() const")]
		public int type() {
			return ProxyQTableWidgetItem().type();
		}
		~QTableWidgetItem() {
			DisposeQTableWidgetItem();
		}
		public void Dispose() {
			DisposeQTableWidgetItem();
		}
		private void DisposeQTableWidgetItem() {
			ProxyQTableWidgetItem().DisposeQTableWidgetItem();
		}
	}
}
