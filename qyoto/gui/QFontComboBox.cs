//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	/// <remarks> See <see cref="IQFontComboBoxSignals"></see> for signals emitted by QFontComboBox
	/// </remarks>
	[SmokeClass("QFontComboBox")]
	public class QFontComboBox : QComboBox, IDisposable {
 		protected QFontComboBox(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QFontComboBox), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QFontComboBox() {
			staticInterceptor = new SmokeInvocation(typeof(QFontComboBox), null);
		}
		public enum FontFilter {
			AllFonts = 0,
			ScalableFonts = 0x1,
			NonScalableFonts = 0x2,
			MonospacedFonts = 0x4,
			ProportionalFonts = 0x8,
		}
		[Q_PROPERTY("QFontDatabase::WritingSystem", "writingSystem")]
		public QFontDatabase.WritingSystem WritingSystem {
			get { return (QFontDatabase.WritingSystem) interceptor.Invoke("writingSystem", "writingSystem()", typeof(QFontDatabase.WritingSystem)); }
			set { interceptor.Invoke("setWritingSystem$", "setWritingSystem(QFontDatabase::WritingSystem)", typeof(void), typeof(QFontDatabase.WritingSystem), value); }
		}
		[Q_PROPERTY("QFontComboBox::FontFilters", "fontFilters")]
		public uint FontFilters {
			get { return (uint) interceptor.Invoke("fontFilters", "fontFilters()", typeof(uint)); }
			set { interceptor.Invoke("setFontFilters$", "setFontFilters(QFontComboBox::FontFilters)", typeof(void), typeof(uint), value); }
		}
		[Q_PROPERTY("QFont", "currentFont")]
		public QFont CurrentFont {
			get { return (QFont) interceptor.Invoke("currentFont", "currentFont()", typeof(QFont)); }
			set { interceptor.Invoke("setCurrentFont#", "setCurrentFont(QFont)", typeof(void), typeof(QFont), value); }
		}
		public QFontComboBox(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFontComboBox#", "QFontComboBox(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public QFontComboBox() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QFontComboBox", "QFontComboBox()", typeof(void));
		}
		[SmokeMethod("sizeHint() const")]
		public override QSize SizeHint() {
			return (QSize) interceptor.Invoke("sizeHint", "sizeHint() const", typeof(QSize));
		}
		[Q_SLOT("void setCurrentFont(const QFont&)")]
		public void SetCurrentFont(QFont f) {
			interceptor.Invoke("setCurrentFont#", "setCurrentFont(const QFont&)", typeof(void), typeof(QFont), f);
		}
		[SmokeMethod("event(QEvent*)")]
		protected new virtual bool Event(QEvent e) {
			return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), e);
		}
		~QFontComboBox() {
			interceptor.Invoke("~QFontComboBox", "~QFontComboBox()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~QFontComboBox", "~QFontComboBox()", typeof(void));
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQFontComboBoxSignals Emit {
			get { return (IQFontComboBoxSignals) Q_EMIT; }
		}
	}

	public interface IQFontComboBoxSignals : IQComboBoxSignals {
		[Q_SIGNAL("void currentFontChanged(const QFont&)")]
		void CurrentFontChanged(QFont f);
	}
}
