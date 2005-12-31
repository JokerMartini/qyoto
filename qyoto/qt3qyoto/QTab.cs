//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	public class QTab : Qt, IDisposable {
 		protected QTab(Type dummy) : base((Type) null) {}
		interface IQTabProxy {
		}

		protected void CreateQTabProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTab), this);
			_interceptor = (QTab) realProxy.GetTransparentProxy();
		}
		private QTab ProxyQTab() {
			return (QTab) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTab() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTabProxy), null);
			_staticInterceptor = (IQTabProxy) realProxy.GetTransparentProxy();
		}
		private static IQTabProxy StaticQTab() {
			return (IQTabProxy) _staticInterceptor;
		}

		public QTab() : this((Type) null) {
			CreateQTabProxy();
			NewQTab();
		}
		[SmokeMethod("QTab()")]
		private void NewQTab() {
			ProxyQTab().NewQTab();
		}
		public QTab(string text) : this((Type) null) {
			CreateQTabProxy();
			NewQTab(text);
		}
		[SmokeMethod("QTab(const QString&)")]
		private void NewQTab(string text) {
			ProxyQTab().NewQTab(text);
		}
		public QTab(QIconSet icon, string text) : this((Type) null) {
			CreateQTabProxy();
			NewQTab(icon,text);
		}
		[SmokeMethod("QTab(const QIconSet&, const QString&)")]
		private void NewQTab(QIconSet icon, string text) {
			ProxyQTab().NewQTab(icon,text);
		}
		public QTab(QIconSet icon) : this((Type) null) {
			CreateQTabProxy();
			NewQTab(icon);
		}
		[SmokeMethod("QTab(const QIconSet&)")]
		private void NewQTab(QIconSet icon) {
			ProxyQTab().NewQTab(icon);
		}
		[SmokeMethod("setText(const QString&)")]
		public void SetText(string text) {
			ProxyQTab().SetText(text);
		}
		[SmokeMethod("text() const")]
		public string Text() {
			return ProxyQTab().Text();
		}
		[SmokeMethod("setIconSet(const QIconSet&)")]
		public void SetIconSet(QIconSet icon) {
			ProxyQTab().SetIconSet(icon);
		}
		[SmokeMethod("iconSet() const")]
		public QIconSet IconSet() {
			return ProxyQTab().IconSet();
		}
		[SmokeMethod("setRect(const QRect&)")]
		public void SetRect(QRect rect) {
			ProxyQTab().SetRect(rect);
		}
		[SmokeMethod("rect() const")]
		public QRect Rect() {
			return ProxyQTab().Rect();
		}
		[SmokeMethod("setEnabled(bool)")]
		public void SetEnabled(bool enable) {
			ProxyQTab().SetEnabled(enable);
		}
		[SmokeMethod("isEnabled() const")]
		public bool IsEnabled() {
			return ProxyQTab().IsEnabled();
		}
		[SmokeMethod("setIdentifier(int)")]
		public void SetIdentifier(int i) {
			ProxyQTab().SetIdentifier(i);
		}
		[SmokeMethod("identifier() const")]
		public int Identifier() {
			return ProxyQTab().Identifier();
		}
		~QTab() {
			DisposeQTab();
		}
		public void Dispose() {
			DisposeQTab();
		}
		private void DisposeQTab() {
			ProxyQTab().DisposeQTab();
		}
	}
}
