//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QWhatsThis")]
	public class QWhatsThis : Object {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QWhatsThis(Type dummy) {}
		private static SmokeInvocation staticInterceptor = null;
		static QWhatsThis() {
			staticInterceptor = new SmokeInvocation(typeof(QWhatsThis), null);
		}
		public static void EnterWhatsThisMode() {
			staticInterceptor.Invoke("enterWhatsThisMode", "enterWhatsThisMode()", typeof(void));
		}
		public static bool InWhatsThisMode() {
			return (bool) staticInterceptor.Invoke("inWhatsThisMode", "inWhatsThisMode()", typeof(bool));
		}
		public static void LeaveWhatsThisMode() {
			staticInterceptor.Invoke("leaveWhatsThisMode", "leaveWhatsThisMode()", typeof(void));
		}
		public static void ShowText(QPoint pos, string text, QWidget w) {
			staticInterceptor.Invoke("showText#$#", "showText(const QPoint&, const QString&, QWidget*)", typeof(void), typeof(QPoint), pos, typeof(string), text, typeof(QWidget), w);
		}
		public static void ShowText(QPoint pos, string text) {
			staticInterceptor.Invoke("showText#$", "showText(const QPoint&, const QString&)", typeof(void), typeof(QPoint), pos, typeof(string), text);
		}
		public static void HideText() {
			staticInterceptor.Invoke("hideText", "hideText()", typeof(void));
		}
		public static QAction CreateAction(QObject parent) {
			return (QAction) staticInterceptor.Invoke("createAction#", "createAction(QObject*)", typeof(QAction), typeof(QObject), parent);
		}
		public static QAction CreateAction() {
			return (QAction) staticInterceptor.Invoke("createAction", "createAction()", typeof(QAction));
		}
	}
}
