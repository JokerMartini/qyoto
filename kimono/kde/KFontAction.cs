//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;

	/// <remarks>
	///  An action to select a font family.
	///  On a toolbar this will show a combobox with all the fonts on the system.
	///  </remarks>		<short>    An action to select a font family.</short>

	[SmokeClass("KFontAction")]
	public class KFontAction : KSelectAction, IDisposable {
 		protected KFontAction(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocationKDE(typeof(KFontAction), this);
		}
		[Q_PROPERTY("QString", "font")]
		public new string Font {
			get { return (string) interceptor.Invoke("font", "font()", typeof(string)); }
			set { interceptor.Invoke("setFont$", "setFont(QString)", typeof(void), typeof(string), value); }
		}
		public KFontAction(uint fontListCriteria, QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KFontAction$#", "KFontAction(uint, QObject*)", typeof(void), typeof(uint), fontListCriteria, typeof(QObject), parent);
		}
		public KFontAction(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KFontAction#", "KFontAction(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public KFontAction(string text, QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KFontAction$#", "KFontAction(const QString&, QObject*)", typeof(void), typeof(string), text, typeof(QObject), parent);
		}
		public KFontAction(KIcon icon, string text, QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KFontAction#$#", "KFontAction(const KIcon&, const QString&, QObject*)", typeof(void), typeof(KIcon), icon, typeof(string), text, typeof(QObject), parent);
		}
		[SmokeMethod("createWidget(QWidget*)")]
		public new virtual QWidget CreateWidget(QWidget parent) {
			return (QWidget) interceptor.Invoke("createWidget#", "createWidget(QWidget*)", typeof(QWidget), typeof(QWidget), parent);
		}
		~KFontAction() {
			interceptor.Invoke("~KFontAction", "~KFontAction()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KFontAction", "~KFontAction()", typeof(void));
		}
		protected new IKFontActionSignals Emit {
			get { return (IKFontActionSignals) Q_EMIT; }
		}
	}

	public interface IKFontActionSignals : IKSelectActionSignals {
	}
}
