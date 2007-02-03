//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	/// See <see cref="IQShortcutSignals"></see> for signals emitted by QShortcut
	[SmokeClass("QShortcut")]
	public class QShortcut : QObject, IDisposable {
 		protected QShortcut(Type dummy) : base((Type) null) {}
		[SmokeClass("QShortcut")]
		interface IQShortcutProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QShortcut), this);
			_interceptor = (QShortcut) realProxy.GetTransparentProxy();
		}
		private QShortcut ProxyQShortcut() {
			return (QShortcut) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QShortcut() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQShortcutProxy), null);
			_staticInterceptor = (IQShortcutProxy) realProxy.GetTransparentProxy();
		}
		private static IQShortcutProxy StaticQShortcut() {
			return (IQShortcutProxy) _staticInterceptor;
		}

		[Q_PROPERTY("QKeySequence", "key")]
		public QKeySequence Key {
			get {
				return Property("key").Value<QKeySequence>();
			}
			set {
				SetProperty("key", QVariant.FromValue<QKeySequence>(value));
			}
		}
		[Q_PROPERTY("QString", "whatsThis")]
		public string WhatsThis {
			get {
				return Property("whatsThis").Value<string>();
			}
			set {
				SetProperty("whatsThis", QVariant.FromValue<string>(value));
			}
		}
		[Q_PROPERTY("bool", "enabled")]
		public bool Enabled {
			get {
				return Property("enabled").Value<bool>();
			}
			set {
				SetProperty("enabled", QVariant.FromValue<bool>(value));
			}
		}
		[Q_PROPERTY("bool", "autoRepeat")]
		public bool AutoRepeat {
			get {
				return Property("autoRepeat").Value<bool>();
			}
			set {
				SetProperty("autoRepeat", QVariant.FromValue<bool>(value));
			}
		}
		[Q_PROPERTY("Qt::ShortcutContext", "context")]
		public Qt.ShortcutContext Context {
			get {
				return Property("context").Value<Qt.ShortcutContext>();
			}
			set {
				SetProperty("context", QVariant.FromValue<Qt.ShortcutContext>(value));
			}
		}
		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QShortcut(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQShortcut(parent);
		}
		[SmokeMethod("QShortcut", "(QWidget*)", "#")]
		private void NewQShortcut(QWidget parent) {
			ProxyQShortcut().NewQShortcut(parent);
		}
		public QShortcut(QKeySequence key, QWidget parent, string member, string ambiguousMember, Qt.ShortcutContext context) : this((Type) null) {
			CreateProxy();
			NewQShortcut(key,parent,member,ambiguousMember,context);
		}
		[SmokeMethod("QShortcut", "(const QKeySequence&, QWidget*, const char*, const char*, Qt::ShortcutContext)", "##$$$")]
		private void NewQShortcut(QKeySequence key, QWidget parent, string member, string ambiguousMember, Qt.ShortcutContext context) {
			ProxyQShortcut().NewQShortcut(key,parent,member,ambiguousMember,context);
		}
		public QShortcut(QKeySequence key, QWidget parent, string member, string ambiguousMember) : this((Type) null) {
			CreateProxy();
			NewQShortcut(key,parent,member,ambiguousMember);
		}
		[SmokeMethod("QShortcut", "(const QKeySequence&, QWidget*, const char*, const char*)", "##$$")]
		private void NewQShortcut(QKeySequence key, QWidget parent, string member, string ambiguousMember) {
			ProxyQShortcut().NewQShortcut(key,parent,member,ambiguousMember);
		}
		public QShortcut(QKeySequence key, QWidget parent, string member) : this((Type) null) {
			CreateProxy();
			NewQShortcut(key,parent,member);
		}
		[SmokeMethod("QShortcut", "(const QKeySequence&, QWidget*, const char*)", "##$")]
		private void NewQShortcut(QKeySequence key, QWidget parent, string member) {
			ProxyQShortcut().NewQShortcut(key,parent,member);
		}
		public QShortcut(QKeySequence key, QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQShortcut(key,parent);
		}
		[SmokeMethod("QShortcut", "(const QKeySequence&, QWidget*)", "##")]
		private void NewQShortcut(QKeySequence key, QWidget parent) {
			ProxyQShortcut().NewQShortcut(key,parent);
		}
		[SmokeMethod("isEnabled", "() const", "")]
		public bool IsEnabled() {
			return ProxyQShortcut().IsEnabled();
		}
		[SmokeMethod("id", "() const", "")]
		public int Id() {
			return ProxyQShortcut().Id();
		}
		[SmokeMethod("parentWidget", "() const", "")]
		public QWidget ParentWidget() {
			return ProxyQShortcut().ParentWidget();
		}
		public static new string Tr(string s, string c) {
			return StaticQShortcut().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQShortcut().Tr(s);
		}
		[SmokeMethod("event", "(QEvent*)", "#")]
		public new bool Event(QEvent e) {
			return ProxyQShortcut().Event(e);
		}
		~QShortcut() {
			DisposeQShortcut();
		}
		public new void Dispose() {
			DisposeQShortcut();
		}
		[SmokeMethod("~QShortcut", "()", "")]
		private void DisposeQShortcut() {
			ProxyQShortcut().DisposeQShortcut();
		}
		protected new IQShortcutSignals Emit {
			get {
				return (IQShortcutSignals) Q_EMIT;
			}
		}
	}

	public interface IQShortcutSignals : IQObjectSignals {
		[Q_SIGNAL("void activated()")]
		void Activated();
		[Q_SIGNAL("void activatedAmbiguously()")]
		void ActivatedAmbiguously();
	}
}
