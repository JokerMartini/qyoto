//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;

	/// <remarks>
	///  A dialog that uses a KPixmapRegionSelectorWidget to allow the user
	///  to select a region of an image. If you want to use special features
	///  like forcing the selected area to have a fixed aspect ratio, you can use
	///  There are some convenience methods that allow to easily show a dialog
	///  for the user to select a region of an image, and just care about the selected
	///  image.
	/// </remarks>		<author> Antonio Larrosa <larrosa@kde.org>
	///  </author>
	/// 		<short>    A dialog that uses a KPixmapRegionSelectorWidget to allow the user  to select a region of an image.</short>
	/// 		<see> pixmapRegionSelectorWidget</see>
	/// 		<see> to</see>
	/// 		<see> get</see>
	/// 		<see> the</see>
	/// 		<see> pointer</see>
	/// 		<see> to</see>
	/// 		<see> the</see>
	/// 		<see> KPixmapRegionSelectorWidget</see>
	/// 		<see> object</see>
	/// 		<see> set</see>
	/// 		<see> the</see>
	/// 		<see> desired</see>
	/// 		<see> options</see>
	/// 		<see> there.</see>

	[SmokeClass("KPixmapRegionSelectorDialog")]
	public class KPixmapRegionSelectorDialog : KDialog, IDisposable {
 		protected KPixmapRegionSelectorDialog(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(KPixmapRegionSelectorDialog), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static KPixmapRegionSelectorDialog() {
			staticInterceptor = new SmokeInvocation(typeof(KPixmapRegionSelectorDialog), null);
		}
		/// <remarks>
		///  The constructor of an empty KPixmapRegionSelectorDialog, you have to call
		///  later the setPixmap method of the KPixmapRegionSelectorWidget widget of
		///  the new object.
		///     </remarks>		<short>    The constructor of an empty KPixmapRegionSelectorDialog, you have to call  later the setPixmap method of the KPixmapRegionSelectorWidget widget of  the new object.</short>
		public KPixmapRegionSelectorDialog(QWidget parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KPixmapRegionSelectorDialog#", "KPixmapRegionSelectorDialog(QWidget*)", typeof(void), typeof(QWidget), parent);
		}
		public KPixmapRegionSelectorDialog() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KPixmapRegionSelectorDialog", "KPixmapRegionSelectorDialog()", typeof(void));
		}
		/// <remarks>
		/// </remarks>		<return> the KPixmapRegionSelectorWidget widget so that additional
		///  parameters can be set by using it.
		///     </return>
		/// 		<short>   </short>
		public KPixmapRegionSelectorWidget PixmapRegionSelectorWidget() {
			return (KPixmapRegionSelectorWidget) interceptor.Invoke("pixmapRegionSelectorWidget", "pixmapRegionSelectorWidget() const", typeof(KPixmapRegionSelectorWidget));
		}
		~KPixmapRegionSelectorDialog() {
			interceptor.Invoke("~KPixmapRegionSelectorDialog", "~KPixmapRegionSelectorDialog()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KPixmapRegionSelectorDialog", "~KPixmapRegionSelectorDialog()", typeof(void));
		}
		/// <remarks>
		///  Creates a modal dialog, lets the user to select a region of the <code>pixmap</code>
		///  and returns when the dialog is closed.
		/// </remarks>		<return> the selected rectangle, or an invalid rectangle if the user 
		///  pressed the Cancel button.
		///     </return>
		/// 		<short>    Creates a modal dialog, lets the user to select a region of the <code>pixmap</code>  and returns when the dialog is closed.</short>
		public static QRect GetSelectedRegion(QPixmap pixmap, QWidget parent) {
			return (QRect) staticInterceptor.Invoke("getSelectedRegion##", "getSelectedRegion(const QPixmap&, QWidget*)", typeof(QRect), typeof(QPixmap), pixmap, typeof(QWidget), parent);
		}
		public static QRect GetSelectedRegion(QPixmap pixmap) {
			return (QRect) staticInterceptor.Invoke("getSelectedRegion#", "getSelectedRegion(const QPixmap&)", typeof(QRect), typeof(QPixmap), pixmap);
		}
		/// <remarks>
		///  Creates a modal dialog, lets the user to select a region of the <code>pixmap</code>
		///  with the same aspect ratio than <code>aspectRatioWidth</code> x <code>aspectRatioHeight</code>
		///  and returns when the dialog is closed.
		/// </remarks>		<return> the selected rectangle, or an invalid rectangle if the user 
		///  pressed the Cancel button.
		///     </return>
		/// 		<short>    Creates a modal dialog, lets the user to select a region of the <code>pixmap</code>  with the same aspect ratio than <code>aspectRatioWidth</code> x <code>aspectRatioHeight</code>  and returns when the dialog is closed.</short>
		public static QRect GetSelectedRegion(QPixmap pixmap, int aspectRatioWidth, int aspectRatioHeight, QWidget parent) {
			return (QRect) staticInterceptor.Invoke("getSelectedRegion#$$#", "getSelectedRegion(const QPixmap&, int, int, QWidget*)", typeof(QRect), typeof(QPixmap), pixmap, typeof(int), aspectRatioWidth, typeof(int), aspectRatioHeight, typeof(QWidget), parent);
		}
		public static QRect GetSelectedRegion(QPixmap pixmap, int aspectRatioWidth, int aspectRatioHeight) {
			return (QRect) staticInterceptor.Invoke("getSelectedRegion#$$", "getSelectedRegion(const QPixmap&, int, int)", typeof(QRect), typeof(QPixmap), pixmap, typeof(int), aspectRatioWidth, typeof(int), aspectRatioHeight);
		}
		/// <remarks>
		///  Creates a modal dialog, lets the user to select a region of the <code>pixmap</code>
		///  and returns when the dialog is closed.
		/// </remarks>		<return> the selected image, or an invalid image if the user 
		///  pressed the Cancel button.
		///     </return>
		/// 		<short>    Creates a modal dialog, lets the user to select a region of the <code>pixmap</code>  and returns when the dialog is closed.</short>
		public static QImage GetSelectedImage(QPixmap pixmap, QWidget parent) {
			return (QImage) staticInterceptor.Invoke("getSelectedImage##", "getSelectedImage(const QPixmap&, QWidget*)", typeof(QImage), typeof(QPixmap), pixmap, typeof(QWidget), parent);
		}
		public static QImage GetSelectedImage(QPixmap pixmap) {
			return (QImage) staticInterceptor.Invoke("getSelectedImage#", "getSelectedImage(const QPixmap&)", typeof(QImage), typeof(QPixmap), pixmap);
		}
		/// <remarks>
		///  Creates a modal dialog, lets the user to select a region of the <code>pixmap</code>
		///  with the same aspect ratio than <code>aspectRatioWidth</code> x <code>aspectRatioHeight</code>
		///  and returns when the dialog is closed.
		/// </remarks>		<return> the selected image, or an invalid image if the user 
		///  pressed the Cancel button.
		///     </return>
		/// 		<short>    Creates a modal dialog, lets the user to select a region of the <code>pixmap</code>  with the same aspect ratio than <code>aspectRatioWidth</code> x <code>aspectRatioHeight</code>  and returns when the dialog is closed.</short>
		public static QImage GetSelectedImage(QPixmap pixmap, int aspectRatioWidth, int aspectRatioHeight, QWidget parent) {
			return (QImage) staticInterceptor.Invoke("getSelectedImage#$$#", "getSelectedImage(const QPixmap&, int, int, QWidget*)", typeof(QImage), typeof(QPixmap), pixmap, typeof(int), aspectRatioWidth, typeof(int), aspectRatioHeight, typeof(QWidget), parent);
		}
		public static QImage GetSelectedImage(QPixmap pixmap, int aspectRatioWidth, int aspectRatioHeight) {
			return (QImage) staticInterceptor.Invoke("getSelectedImage#$$", "getSelectedImage(const QPixmap&, int, int)", typeof(QImage), typeof(QPixmap), pixmap, typeof(int), aspectRatioWidth, typeof(int), aspectRatioHeight);
		}
		protected new IKPixmapRegionSelectorDialogSignals Emit {
			get { return (IKPixmapRegionSelectorDialogSignals) Q_EMIT; }
		}
	}

	public interface IKPixmapRegionSelectorDialogSignals : IKDialogSignals {
	}
}