//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
	using Plasma;
	using System;
	using Kimono;
	using Qyoto;
	/// <remarks>
	///  Accessed via Plasma.Theme.DefaultTheme() e.g:
	///  <pre>
	///  string imagePath = Plasma.Theme.DefaultTheme().ImagePath("widgets/clock")
	///  </pre>
	///  Plasma.Theme provides access to a common and standardized set of graphic
	///  elements stored in SVG format. This allows artists to create single packages
	///  of SVGs that will affect the look and feel of all workspace components.
	///  Plasma.Svg uses Plasma.Theme internally to locate and load the appropriate
	///  SVG data. Alternatively, Plasma.Theme can be used directly to retrieve
	///  file system paths to SVGs by name.
	///   See <see cref="IThemeSignals"></see> for signals emitted by Theme
	/// </remarks>		<short> Interface to the Plasma theme.</short>
	[SmokeClass("Plasma::Theme")]
	public class Theme : QObject, IDisposable {
 		protected Theme(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(Theme), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static Theme() {
			staticInterceptor = new SmokeInvocation(typeof(Theme), null);
		}
		public enum ColorRole {
			TextColor = 0,
			HighlightColor = 1,
			BackgroundColor = 2,
		}
		public enum FontRole {
			DefaultFont = 0,
		}
		[Q_PROPERTY("QString", "themeName")]
		public string ThemeName {
			get { return (string) interceptor.Invoke("themeName", "themeName()", typeof(string)); }
		}
		/// <remarks>
		///  Default constructor. Usually you want to use the singleton instead.
		///          </remarks>		<short>    Default constructor.</short>
		public Theme(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Theme#", "Theme(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public Theme() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("Theme", "Theme()", typeof(void));
		}
		/// <remarks>
		///  Retrieve the path for an SVG image in the current theme.
		///  @arg name the name of the file in the theme directory (without the
		///            ".svg" part or a leading slash)
		/// </remarks>		<return> the full path to the requested file for the current theme
		///          </return>
		/// 		<short>    Retrieve the path for an SVG image in the current theme.</short>
		public string ImagePath(string name) {
			return (string) interceptor.Invoke("imagePath$", "imagePath(const QString&) const", typeof(string), typeof(string), name);
		}
		/// <remarks>
		///  Checks if this theme has an image named in a certain way
		///  @arg name the name of the file in the theme directory (without the
		///            ".svg" part or a leading slash)
		/// </remarks>		<return> true if the image exists for this theme
		///          </return>
		/// 		<short>    Checks if this theme has an image named in a certain way </short>
		public bool CurrentThemeHasImage(string name) {
			return (bool) interceptor.Invoke("currentThemeHasImage$", "currentThemeHasImage(const QString&) const", typeof(bool), typeof(string), name);
		}
		/// <remarks>
		///  Returns the color scheme configurationthat goes along this theme.
		///  This can be used with KStatefulBrush and KColorScheme to determine
		///  the proper colours to use along with the visual elements in this theme.
		///          </remarks>		<short>    Returns the color scheme configurationthat goes along this theme.</short>
		public KSharedConfig ColorScheme() {
			return (KSharedConfig) interceptor.Invoke("colorScheme", "colorScheme() const", typeof(KSharedConfig));
		}
		/// <remarks>
		///  Returns the text color to be used by items resting on the background
		///  @arg role which role (usage pattern) to get the color for
		///          </remarks>		<short>    Returns the text color to be used by items resting on the background </short>
		public QColor Color(Plasma.Theme.ColorRole role) {
			return (QColor) interceptor.Invoke("color$", "color(Plasma::Theme::ColorRole) const", typeof(QColor), typeof(Plasma.Theme.ColorRole), role);
		}
		/// <remarks>
		///  Sets the default font to be used with themed items. Defaults to
		///  the application wide default font.
		///  @arg font the new font
		///  @arg role which role (usage pattern) to set the font for
		///          </remarks>		<short>    Sets the default font to be used with themed items.</short>
		public void SetFont(QFont font, Plasma.Theme.FontRole role) {
			interceptor.Invoke("setFont#$", "setFont(const QFont&, Plasma::Theme::FontRole)", typeof(void), typeof(QFont), font, typeof(Plasma.Theme.FontRole), role);
		}
		public void SetFont(QFont font) {
			interceptor.Invoke("setFont#", "setFont(const QFont&)", typeof(void), typeof(QFont), font);
		}
		/// <remarks>
		///  Returns the font to be used by themed items
		///  @arg role which role (usage pattern) to get the font for
		///          </remarks>		<short>    Returns the font to be used by themed items </short>
		public QFont Font(Plasma.Theme.FontRole role) {
			return (QFont) interceptor.Invoke("font$", "font(Plasma::Theme::FontRole) const", typeof(QFont), typeof(Plasma.Theme.FontRole), role);
		}
		/// <remarks>
		///  Returns the font metrics for the font to be used by themed items
		///          </remarks>		<short>    Returns the font metrics for the font to be used by themed items          </short>
		public QFontMetrics FontMetrics() {
			return (QFontMetrics) interceptor.Invoke("fontMetrics", "fontMetrics() const", typeof(QFontMetrics));
		}
		/// <remarks>
		///  Returns if the window manager effects (e.g. translucency, compositing) is active or not
		///          </remarks>		<short>    Returns if the window manager effects (e.</short>
		public bool WindowTranslucencyEnabled() {
			return (bool) interceptor.Invoke("windowTranslucencyEnabled", "windowTranslucencyEnabled() const", typeof(bool));
		}
		/// <remarks>
		///  Tells the theme whether to follow the global settings or use application
		///  specific settings
		///  @arg useGlobal pass in true to follow the global settings
		///          </remarks>		<short>    Tells the theme whether to follow the global settings or use application  specific settings </short>
		public void SetUseGlobalSettings(bool useGlobal) {
			interceptor.Invoke("setUseGlobalSettings$", "setUseGlobalSettings(bool)", typeof(void), typeof(bool), useGlobal);
		}
		/// <remarks>
		/// </remarks>		<return> true if the global settings are followed, false if application
		///  specific settings are used.
		///          </return>
		/// 		<short>   </short>
		public bool UseGlobalSettings() {
			return (bool) interceptor.Invoke("useGlobalSettings", "useGlobalSettings() const", typeof(bool));
		}
		/// <remarks>
		///  Notifies the Theme object that the theme settings have changed
		///  and should be read from the config file
		/// </remarks>		<short>    Notifies the Theme object that the theme settings have changed  and should be read from the config file </short>
		[Q_SLOT("void settingsChanged()")]
		public void SettingsChanged() {
			interceptor.Invoke("settingsChanged", "settingsChanged()", typeof(void));
		}
		~Theme() {
			interceptor.Invoke("~Theme", "~Theme()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~Theme", "~Theme()", typeof(void));
		}
		/// <remarks>
		///  Singleton pattern accessor
		/// </remarks>		<short>    Singleton pattern accessor </short>
		public static Plasma.Theme DefaultTheme() {
			return (Plasma.Theme) staticInterceptor.Invoke("defaultTheme", "defaultTheme()", typeof(Plasma.Theme));
		}
		/// <remarks>
		/// </remarks>		<return> a package structure representing a Theme
		///          </return>
		/// 		<short>   </short>
		public static Plasma.PackageStructure PackageStructure() {
			return (Plasma.PackageStructure) staticInterceptor.Invoke("packageStructure", "packageStructure()", typeof(Plasma.PackageStructure));
		}
		protected new IThemeSignals Emit {
			get { return (IThemeSignals) Q_EMIT; }
		}
	}

	public interface IThemeSignals : IQObjectSignals {
		/// <remarks>
		///  Emitted when the user changes the theme. SVGs should be reloaded at
		///  that point
		///          </remarks>		<short>    Emitted when the user changes the theme.</short>
		[Q_SIGNAL("void themeChanged()")]
		void ThemeChanged();
	}
}