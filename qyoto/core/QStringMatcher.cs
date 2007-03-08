//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QStringMatcher")]
	public class QStringMatcher : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
		private IntPtr _smokeObject;
		protected QStringMatcher(Type dummy) {}
		[SmokeClass("QStringMatcher")]
		interface IQStringMatcherProxy {
		}
		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStringMatcher), this);
			_interceptor = (QStringMatcher) realProxy.GetTransparentProxy();
		}
		private QStringMatcher ProxyQStringMatcher() {
			return (QStringMatcher) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStringMatcher() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStringMatcherProxy), null);
			_staticInterceptor = (IQStringMatcherProxy) realProxy.GetTransparentProxy();
		}
		private static IQStringMatcherProxy StaticQStringMatcher() {
			return (IQStringMatcherProxy) _staticInterceptor;
		}
		public QStringMatcher() : this((Type) null) {
			CreateProxy();
			NewQStringMatcher();
		}
		[SmokeMethod("QStringMatcher", "()", "")]
		private void NewQStringMatcher() {
			ProxyQStringMatcher().NewQStringMatcher();
		}
		public QStringMatcher(string pattern, Qt.CaseSensitivity cs) : this((Type) null) {
			CreateProxy();
			NewQStringMatcher(pattern,cs);
		}
		[SmokeMethod("QStringMatcher", "(const QString&, Qt::CaseSensitivity)", "$$")]
		private void NewQStringMatcher(string pattern, Qt.CaseSensitivity cs) {
			ProxyQStringMatcher().NewQStringMatcher(pattern,cs);
		}
		public QStringMatcher(string pattern) : this((Type) null) {
			CreateProxy();
			NewQStringMatcher(pattern);
		}
		[SmokeMethod("QStringMatcher", "(const QString&)", "$")]
		private void NewQStringMatcher(string pattern) {
			ProxyQStringMatcher().NewQStringMatcher(pattern);
		}
		[SmokeMethod("setPattern", "(const QString&)", "$")]
		public void SetPattern(string pattern) {
			ProxyQStringMatcher().SetPattern(pattern);
		}
		[SmokeMethod("setCaseSensitivity", "(Qt::CaseSensitivity)", "$")]
		public void SetCaseSensitivity(Qt.CaseSensitivity cs) {
			ProxyQStringMatcher().SetCaseSensitivity(cs);
		}
		[SmokeMethod("indexIn", "(const QString&, int) const", "$$")]
		public int IndexIn(string str, int from) {
			return ProxyQStringMatcher().IndexIn(str,from);
		}
		[SmokeMethod("indexIn", "(const QString&) const", "$")]
		public int IndexIn(string str) {
			return ProxyQStringMatcher().IndexIn(str);
		}
		[SmokeMethod("pattern", "() const", "")]
		public string Pattern() {
			return ProxyQStringMatcher().Pattern();
		}
		[SmokeMethod("caseSensitivity", "() const", "")]
		public Qt.CaseSensitivity CaseSensitivity() {
			return ProxyQStringMatcher().CaseSensitivity();
		}
		~QStringMatcher() {
			DisposeQStringMatcher();
		}
		public void Dispose() {
			DisposeQStringMatcher();
		}
		[SmokeMethod("~QStringMatcher", "()", "")]
		private void DisposeQStringMatcher() {
			ProxyQStringMatcher().DisposeQStringMatcher();
		}
	}
}
