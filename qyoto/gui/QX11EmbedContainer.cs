//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	/// See <see cref="IQX11EmbedContainerSignals"></see> for signals emitted by QX11EmbedContainer
	[SmokeClass("QX11EmbedContainer")]
	public class QX11EmbedContainer : QWidget, IDisposable {
 		protected QX11EmbedContainer(Type dummy) : base((Type) null) {}
		[SmokeClass("QX11EmbedContainer")]
		interface IQX11EmbedContainerProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QX11EmbedContainer), this);
			_interceptor = (QX11EmbedContainer) realProxy.GetTransparentProxy();
		}
		private QX11EmbedContainer ProxyQX11EmbedContainer() {
			return (QX11EmbedContainer) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QX11EmbedContainer() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQX11EmbedContainerProxy), null);
			_staticInterceptor = (IQX11EmbedContainerProxy) realProxy.GetTransparentProxy();
		}
		private static IQX11EmbedContainerProxy StaticQX11EmbedContainer() {
			return (IQX11EmbedContainerProxy) _staticInterceptor;
		}
		public enum Error {
			Unknown = 0,
			Internal = 1,
			InvalidWindowID = 2,
		}
		public QX11EmbedContainer(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQX11EmbedContainer(parent);
		}
		[SmokeMethod("QX11EmbedContainer", "(QWidget*)", "#")]
		private void NewQX11EmbedContainer(QWidget parent) {
			ProxyQX11EmbedContainer().NewQX11EmbedContainer(parent);
		}
		public QX11EmbedContainer() : this((Type) null) {
			CreateProxy();
			NewQX11EmbedContainer();
		}
		[SmokeMethod("QX11EmbedContainer", "()", "")]
		private void NewQX11EmbedContainer() {
			ProxyQX11EmbedContainer().NewQX11EmbedContainer();
		}
		[SmokeMethod("embedClient", "(WId)", "$")]
		public void EmbedClient(ulong id) {
			ProxyQX11EmbedContainer().EmbedClient(id);
		}
		[SmokeMethod("discardClient", "()", "")]
		public void DiscardClient() {
			ProxyQX11EmbedContainer().DiscardClient();
		}
		[SmokeMethod("clientWinId", "() const", "")]
		public ulong ClientWinId() {
			return ProxyQX11EmbedContainer().ClientWinId();
		}
		[SmokeMethod("minimumSizeHint", "() const", "")]
		public override QSize MinimumSizeHint() {
			return ProxyQX11EmbedContainer().MinimumSizeHint();
		}
		[SmokeMethod("error", "() const", "")]
		public QX11EmbedContainer.Error error() {
			return ProxyQX11EmbedContainer().error();
		}
		public static string Tr(string s, string c) {
			return StaticQX11EmbedContainer().Tr(s,c);
		}
		public static string Tr(string s) {
			return StaticQX11EmbedContainer().Tr(s);
		}
		// bool x11Event(XEvent* arg1); >>>> NOT CONVERTED
		[SmokeMethod("eventFilter", "(QObject*, QEvent*)", "##")]
		public override bool EventFilter(QObject arg1, QEvent arg2) {
			return ProxyQX11EmbedContainer().EventFilter(arg1,arg2);
		}
		[SmokeMethod("paintEvent", "(QPaintEvent*)", "#")]
		protected override void PaintEvent(QPaintEvent e) {
			ProxyQX11EmbedContainer().PaintEvent(e);
		}
		[SmokeMethod("resizeEvent", "(QResizeEvent*)", "#")]
		protected override void ResizeEvent(QResizeEvent arg1) {
			ProxyQX11EmbedContainer().ResizeEvent(arg1);
		}
		[SmokeMethod("showEvent", "(QShowEvent*)", "#")]
		public override void ShowEvent(QShowEvent arg1) {
			ProxyQX11EmbedContainer().ShowEvent(arg1);
		}
		[SmokeMethod("hideEvent", "(QHideEvent*)", "#")]
		protected override void HideEvent(QHideEvent arg1) {
			ProxyQX11EmbedContainer().HideEvent(arg1);
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		public override bool Event(QEvent arg1) {
			return ProxyQX11EmbedContainer().Event(arg1);
		}
		~QX11EmbedContainer() {
			DisposeQX11EmbedContainer();
		}
		public new void Dispose() {
			DisposeQX11EmbedContainer();
		}
		[SmokeMethod("~QX11EmbedContainer", "()", "")]
		private void DisposeQX11EmbedContainer() {
			ProxyQX11EmbedContainer().DisposeQX11EmbedContainer();
		}
		protected new IQX11EmbedContainerSignals Emit {
			get { return (IQX11EmbedContainerSignals) Q_EMIT; }
		}
	}

	public interface IQX11EmbedContainerSignals : IQWidgetSignals {
		[Q_SIGNAL("void clientIsEmbedded()")]
		void ClientIsEmbedded();
		[Q_SIGNAL("void clientClosed()")]
		void ClientClosed();
		[Q_SIGNAL("void error(QX11EmbedContainer::Error)")]
		void Error(QX11EmbedContainer.Error arg1);
	}
}
