//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QKeyEvent")]
	public class QKeyEvent : QInputEvent, IDisposable {
 		protected QKeyEvent(Type dummy) : base((Type) null) {}
		[SmokeClass("QKeyEvent")]
		interface IQKeyEventProxy {
			[SmokeMethod("createExtendedKeyEvent", "(QEvent::Type, int, Qt::KeyboardModifiers, quint32, quint32, quint32, const QString&, bool, ushort)", "$$$$$$$$$")]
			QKeyEvent CreateExtendedKeyEvent(QEvent.TypeOf type, int key, int modifiers, uint nativeScanCode, uint nativeVirtualKey, uint nativeModifiers, string text, bool autorep, ushort count);
			[SmokeMethod("createExtendedKeyEvent", "(QEvent::Type, int, Qt::KeyboardModifiers, quint32, quint32, quint32, const QString&, bool)", "$$$$$$$$")]
			QKeyEvent CreateExtendedKeyEvent(QEvent.TypeOf type, int key, int modifiers, uint nativeScanCode, uint nativeVirtualKey, uint nativeModifiers, string text, bool autorep);
			[SmokeMethod("createExtendedKeyEvent", "(QEvent::Type, int, Qt::KeyboardModifiers, quint32, quint32, quint32, const QString&)", "$$$$$$$")]
			QKeyEvent CreateExtendedKeyEvent(QEvent.TypeOf type, int key, int modifiers, uint nativeScanCode, uint nativeVirtualKey, uint nativeModifiers, string text);
			[SmokeMethod("createExtendedKeyEvent", "(QEvent::Type, int, Qt::KeyboardModifiers, quint32, quint32, quint32)", "$$$$$$")]
			QKeyEvent CreateExtendedKeyEvent(QEvent.TypeOf type, int key, int modifiers, uint nativeScanCode, uint nativeVirtualKey, uint nativeModifiers);
			[SmokeMethod("operator==", "(QKeyEvent*, QKeySequence::StandardKey)", "#$")]
			bool op_equals(QKeyEvent e, QKeySequence.StandardKey key);
			[SmokeMethod("operator==", "(QKeySequence::StandardKey, QKeyEvent*)", "$#")]
			bool op_equals(QKeySequence.StandardKey key, QKeyEvent e);
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QKeyEvent), this);
			_interceptor = (QKeyEvent) realProxy.GetTransparentProxy();
		}
		private QKeyEvent ProxyQKeyEvent() {
			return (QKeyEvent) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QKeyEvent() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQKeyEventProxy), null);
			_staticInterceptor = (IQKeyEventProxy) realProxy.GetTransparentProxy();
		}
		private static IQKeyEventProxy StaticQKeyEvent() {
			return (IQKeyEventProxy) _staticInterceptor;
		}
		public QKeyEvent(QEvent.TypeOf type, int key, int modifiers, string text, bool autorep, ushort count) : this((Type) null) {
			CreateProxy();
			NewQKeyEvent(type,key,modifiers,text,autorep,count);
		}
		[SmokeMethod("QKeyEvent", "(QEvent::Type, int, Qt::KeyboardModifiers, const QString&, bool, ushort)", "$$$$$$")]
		private void NewQKeyEvent(QEvent.TypeOf type, int key, int modifiers, string text, bool autorep, ushort count) {
			ProxyQKeyEvent().NewQKeyEvent(type,key,modifiers,text,autorep,count);
		}
		public QKeyEvent(QEvent.TypeOf type, int key, int modifiers, string text, bool autorep) : this((Type) null) {
			CreateProxy();
			NewQKeyEvent(type,key,modifiers,text,autorep);
		}
		[SmokeMethod("QKeyEvent", "(QEvent::Type, int, Qt::KeyboardModifiers, const QString&, bool)", "$$$$$")]
		private void NewQKeyEvent(QEvent.TypeOf type, int key, int modifiers, string text, bool autorep) {
			ProxyQKeyEvent().NewQKeyEvent(type,key,modifiers,text,autorep);
		}
		public QKeyEvent(QEvent.TypeOf type, int key, int modifiers, string text) : this((Type) null) {
			CreateProxy();
			NewQKeyEvent(type,key,modifiers,text);
		}
		[SmokeMethod("QKeyEvent", "(QEvent::Type, int, Qt::KeyboardModifiers, const QString&)", "$$$$")]
		private void NewQKeyEvent(QEvent.TypeOf type, int key, int modifiers, string text) {
			ProxyQKeyEvent().NewQKeyEvent(type,key,modifiers,text);
		}
		public QKeyEvent(QEvent.TypeOf type, int key, int modifiers) : this((Type) null) {
			CreateProxy();
			NewQKeyEvent(type,key,modifiers);
		}
		[SmokeMethod("QKeyEvent", "(QEvent::Type, int, Qt::KeyboardModifiers)", "$$$")]
		private void NewQKeyEvent(QEvent.TypeOf type, int key, int modifiers) {
			ProxyQKeyEvent().NewQKeyEvent(type,key,modifiers);
		}
		[SmokeMethod("key", "() const", "")]
		public int Key() {
			return ProxyQKeyEvent().Key();
		}
		[SmokeMethod("matches", "(QKeySequence::StandardKey) const", "$")]
		public bool Matches(QKeySequence.StandardKey key) {
			return ProxyQKeyEvent().Matches(key);
		}
		[SmokeMethod("modifiers", "() const", "")]
		public int Modifiers() {
			return ProxyQKeyEvent().Modifiers();
		}
		[SmokeMethod("text", "() const", "")]
		public string Text() {
			return ProxyQKeyEvent().Text();
		}
		[SmokeMethod("isAutoRepeat", "() const", "")]
		public bool IsAutoRepeat() {
			return ProxyQKeyEvent().IsAutoRepeat();
		}
		[SmokeMethod("count", "() const", "")]
		public int Count() {
			return ProxyQKeyEvent().Count();
		}
		[SmokeMethod("hasExtendedInfo", "() const", "")]
		public bool HasExtendedInfo() {
			return ProxyQKeyEvent().HasExtendedInfo();
		}
		[SmokeMethod("nativeScanCode", "() const", "")]
		public uint NativeScanCode() {
			return ProxyQKeyEvent().NativeScanCode();
		}
		[SmokeMethod("nativeVirtualKey", "() const", "")]
		public uint NativeVirtualKey() {
			return ProxyQKeyEvent().NativeVirtualKey();
		}
		[SmokeMethod("nativeModifiers", "() const", "")]
		public uint NativeModifiers() {
			return ProxyQKeyEvent().NativeModifiers();
		}
		public static QKeyEvent CreateExtendedKeyEvent(QEvent.TypeOf type, int key, int modifiers, uint nativeScanCode, uint nativeVirtualKey, uint nativeModifiers, string text, bool autorep, ushort count) {
			return StaticQKeyEvent().CreateExtendedKeyEvent(type,key,modifiers,nativeScanCode,nativeVirtualKey,nativeModifiers,text,autorep,count);
		}
		public static QKeyEvent CreateExtendedKeyEvent(QEvent.TypeOf type, int key, int modifiers, uint nativeScanCode, uint nativeVirtualKey, uint nativeModifiers, string text, bool autorep) {
			return StaticQKeyEvent().CreateExtendedKeyEvent(type,key,modifiers,nativeScanCode,nativeVirtualKey,nativeModifiers,text,autorep);
		}
		public static QKeyEvent CreateExtendedKeyEvent(QEvent.TypeOf type, int key, int modifiers, uint nativeScanCode, uint nativeVirtualKey, uint nativeModifiers, string text) {
			return StaticQKeyEvent().CreateExtendedKeyEvent(type,key,modifiers,nativeScanCode,nativeVirtualKey,nativeModifiers,text);
		}
		public static QKeyEvent CreateExtendedKeyEvent(QEvent.TypeOf type, int key, int modifiers, uint nativeScanCode, uint nativeVirtualKey, uint nativeModifiers) {
			return StaticQKeyEvent().CreateExtendedKeyEvent(type,key,modifiers,nativeScanCode,nativeVirtualKey,nativeModifiers);
		}
		~QKeyEvent() {
			DisposeQKeyEvent();
		}
		public new void Dispose() {
			DisposeQKeyEvent();
		}
		[SmokeMethod("~QKeyEvent", "()", "")]
		private void DisposeQKeyEvent() {
			ProxyQKeyEvent().DisposeQKeyEvent();
		}
		public static bool operator==(QKeyEvent e, QKeySequence.StandardKey key) {
			return StaticQKeyEvent().op_equals(e,key);
		}
		public static bool operator!=(QKeyEvent e, QKeySequence.StandardKey key) {
			return !StaticQKeyEvent().op_equals(e,key);
		}
		public static bool operator==(QKeySequence.StandardKey key, QKeyEvent e) {
			return StaticQKeyEvent().op_equals(key,e);
		}
		public static bool operator!=(QKeySequence.StandardKey key, QKeyEvent e) {
			return !StaticQKeyEvent().op_equals(key,e);
		}
	}
}
