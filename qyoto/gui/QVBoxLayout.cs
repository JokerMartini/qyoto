//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QVBoxLayout")]
	public class QVBoxLayout : QBoxLayout, IDisposable {
 		protected QVBoxLayout(Type dummy) : base((Type) null) {}
		[SmokeClass("QVBoxLayout")]
		interface IQVBoxLayoutProxy {
			[SmokeMethod("tr", "(const char*, const char*)", "$$")]
			string Tr(string s, string c);
			[SmokeMethod("tr", "(const char*)", "$")]
			string Tr(string s);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QVBoxLayout), this);
			_interceptor = (QVBoxLayout) realProxy.GetTransparentProxy();
		}
		private QVBoxLayout ProxyQVBoxLayout() {
			return (QVBoxLayout) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QVBoxLayout() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQVBoxLayoutProxy), null);
			_staticInterceptor = (IQVBoxLayoutProxy) realProxy.GetTransparentProxy();
		}
		private static IQVBoxLayoutProxy StaticQVBoxLayout() {
			return (IQVBoxLayoutProxy) _staticInterceptor;
		}

		// int qt_metacall(QMetaObject::Call arg1,int arg2,void** arg3); >>>> NOT CONVERTED
		public QVBoxLayout() : this((Type) null) {
			CreateProxy();
			NewQVBoxLayout();
		}
		[SmokeMethod("QVBoxLayout", "()", "")]
		private void NewQVBoxLayout() {
			ProxyQVBoxLayout().NewQVBoxLayout();
		}
		public QVBoxLayout(QWidget parent) : this((Type) null) {
			CreateProxy();
			NewQVBoxLayout(parent);
		}
		[SmokeMethod("QVBoxLayout", "(QWidget*)", "#")]
		private void NewQVBoxLayout(QWidget parent) {
			ProxyQVBoxLayout().NewQVBoxLayout(parent);
		}
		public static new string Tr(string s, string c) {
			return StaticQVBoxLayout().Tr(s,c);
		}
		public static new string Tr(string s) {
			return StaticQVBoxLayout().Tr(s);
		}
		~QVBoxLayout() {
			DisposeQVBoxLayout();
		}
		public new void Dispose() {
			DisposeQVBoxLayout();
		}
		[SmokeMethod("~QVBoxLayout", "()", "")]
		private void DisposeQVBoxLayout() {
			ProxyQVBoxLayout().DisposeQVBoxLayout();
		}
		protected new IQVBoxLayoutSignals Emit {
			get {
				return (IQVBoxLayoutSignals) Q_EMIT;
			}
		}
	}

	public interface IQVBoxLayoutSignals : IQBoxLayoutSignals {
	}
}
