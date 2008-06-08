//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;

	/// <remarks>
	///  Implementation of KPixmapProvider.
	///  Uses KMimeType.PixmapForURL() to resolve icons.
	///  Instatiate this class and supply it to the desired class, e.g.
	///  <pre>
	///  KHistoryCombo combo = new KHistoryCombo( this );
	///  combo.SetPixmapProvider( new KUrlPixmapProvider );
	///  [...]
	///  </pre>
	/// </remarks>		<author> Carsten Pfeiffer <pfeiffer@kde.org>
	///  </author>
	/// 		<short> Resolves pixmaps for URLs.</short>

	[SmokeClass("KUrlPixmapProvider")]
	public class KUrlPixmapProvider : KPixmapProvider, IDisposable {
 		protected KUrlPixmapProvider(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocationKDE(typeof(KUrlPixmapProvider), this);
		}
		/// <remarks>
		///  Creates a new url pixmap provider.
		///      </remarks>		<short>    Creates a new url pixmap provider.</short>
		public KUrlPixmapProvider() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KUrlPixmapProvider", "KUrlPixmapProvider()", typeof(void));
		}
		/// <remarks>
		///  Returns a pixmap for <code>url</code> with size <code>size.</code>
		///  Uses KMimeType.PixmapForURL().
		/// <param> name="url" the URL to fetch a pixmap for
		/// </param><param> name="size" the size of the pixmap in pixels, or 0 for default.
		/// </param></remarks>		<return> the resulting pixmap
		/// </return>
		/// 		<short>    Returns a pixmap for <code>url</code> with size <code>size.</code></short>
		/// 		<see> KIconLoader.StdSizes</see>
		[SmokeMethod("pixmapFor(const QString&, int)")]
		public override QPixmap PixmapFor(string url, int size) {
			return (QPixmap) interceptor.Invoke("pixmapFor$$", "pixmapFor(const QString&, int)", typeof(QPixmap), typeof(string), url, typeof(int), size);
		}
		[SmokeMethod("pixmapFor(const QString&)")]
		public virtual QPixmap PixmapFor(string url) {
			return (QPixmap) interceptor.Invoke("pixmapFor$", "pixmapFor(const QString&)", typeof(QPixmap), typeof(string), url);
		}
		~KUrlPixmapProvider() {
			interceptor.Invoke("~KUrlPixmapProvider", "~KUrlPixmapProvider()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~KUrlPixmapProvider", "~KUrlPixmapProvider()", typeof(void));
		}
	}
}
