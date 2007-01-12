//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QDropEvent")]
	public class QDropEvent : QEvent, IQMimeSource, IDisposable {
 		protected QDropEvent(Type dummy) : base((Type) null) {}
		interface IQDropEventProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDropEvent), this);
			_interceptor = (QDropEvent) realProxy.GetTransparentProxy();
		}
		private QDropEvent ProxyQDropEvent() {
			return (QDropEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDropEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDropEventProxy), null);
			_staticInterceptor = (IQDropEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQDropEventProxy StaticQDropEvent() {
			return (IQDropEventProxy) _staticInterceptor;
		}

		public QDropEvent(QPoint pos, int actions, QMimeData data, int buttons, int modifiers, QEvent.E_Type type) : this((Type) null) {
			CreateProxy();
			NewQDropEvent(pos,actions,data,buttons,modifiers,type);
		}
		[SmokeMethod("QDropEvent(const QPoint&, Qt::DropActions, const QMimeData*, Qt::MouseButtons, Qt::KeyboardModifiers, QEvent::Type)")]
		private void NewQDropEvent(QPoint pos, int actions, QMimeData data, int buttons, int modifiers, QEvent.E_Type type) {
			ProxyQDropEvent().NewQDropEvent(pos,actions,data,buttons,modifiers,type);
		}
		public QDropEvent(QPoint pos, int actions, QMimeData data, int buttons, int modifiers) : this((Type) null) {
			CreateProxy();
			NewQDropEvent(pos,actions,data,buttons,modifiers);
		}
		[SmokeMethod("QDropEvent(const QPoint&, Qt::DropActions, const QMimeData*, Qt::MouseButtons, Qt::KeyboardModifiers)")]
		private void NewQDropEvent(QPoint pos, int actions, QMimeData data, int buttons, int modifiers) {
			ProxyQDropEvent().NewQDropEvent(pos,actions,data,buttons,modifiers);
		}
		[SmokeMethod("pos() const")]
		public QPoint Pos() {
			return ProxyQDropEvent().Pos();
		}
		[SmokeMethod("mouseButtons() const")]
		public int MouseButtons() {
			return ProxyQDropEvent().MouseButtons();
		}
		[SmokeMethod("keyboardModifiers() const")]
		public int KeyboardModifiers() {
			return ProxyQDropEvent().KeyboardModifiers();
		}
		[SmokeMethod("possibleActions() const")]
		public int PossibleActions() {
			return ProxyQDropEvent().PossibleActions();
		}
		[SmokeMethod("proposedAction() const")]
		public Qt.DropAction ProposedAction() {
			return ProxyQDropEvent().ProposedAction();
		}
		[SmokeMethod("acceptProposedAction()")]
		public void AcceptProposedAction() {
			ProxyQDropEvent().AcceptProposedAction();
		}
		[SmokeMethod("dropAction() const")]
		public Qt.DropAction DropAction() {
			return ProxyQDropEvent().DropAction();
		}
		[SmokeMethod("setDropAction(Qt::DropAction)")]
		public void SetDropAction(Qt.DropAction action) {
			ProxyQDropEvent().SetDropAction(action);
		}
		[SmokeMethod("source() const")]
		public QWidget Source() {
			return ProxyQDropEvent().Source();
		}
		[SmokeMethod("mimeData() const")]
		public QMimeData MimeData() {
			return ProxyQDropEvent().MimeData();
		}
		[SmokeMethod("format(int) const")]
		public string Format(int n) {
			return ProxyQDropEvent().Format(n);
		}
		[SmokeMethod("format() const")]
		public string Format() {
			return ProxyQDropEvent().Format();
		}
		[SmokeMethod("encodedData(const char*) const")]
		public QByteArray EncodedData(string arg1) {
			return ProxyQDropEvent().EncodedData(arg1);
		}
		[SmokeMethod("provides(const char*) const")]
		public bool Provides(string arg1) {
			return ProxyQDropEvent().Provides(arg1);
		}
		~QDropEvent() {
			DisposeQDropEvent();
		}
		public new void Dispose() {
			DisposeQDropEvent();
		}
		[SmokeMethod("~QDropEvent()")]
		private void DisposeQDropEvent() {
			ProxyQDropEvent().DisposeQDropEvent();
		}
	}
}