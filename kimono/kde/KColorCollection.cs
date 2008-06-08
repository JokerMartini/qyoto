//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;
	using System.Collections.Generic;

	/// <remarks>
	///  Class for handling color collections ("palettes").
	///  This class makes it easy to handle color collections, sometimes referred to
	///  as "palettes". This class can read and write collections from and to a file.
	///  This class uses the "GIMP" palette file format.
	/// </remarks>		<author> Waldo Bastian (bastian@kde.org)
	/// </author>
	/// 		<short>    Class for handling color collections ("palettes").</short>

	[SmokeClass("KColorCollection")]
	public class KColorCollection : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected KColorCollection(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocationKDE(typeof(KColorCollection), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static KColorCollection() {
			staticInterceptor = new SmokeInvocationKDE(typeof(KColorCollection), null);
		}
		/// <remarks>
		///  Used to specify whether a collection may be edited.
		/// </remarks>		<short>    Used to specify whether a collection may be edited.</short>
		/// 		<see> editable</see>
		/// 		<see> setEditable</see>
		public enum Editable {
			Yes = 0,
			No = 1,
			Ask = 2,
		}
		/// <remarks>
		///  KColorCollection constructor. Creates a KColorCollection from a file
		///  the filename is derived from the name.
		/// <param> name="name" The name of collection as returned by installedCollections()
		/// </param></remarks>		<short>    KColorCollection constructor.</short>
		public KColorCollection(string name) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KColorCollection$", "KColorCollection(const QString&)", typeof(void), typeof(string), name);
		}
		public KColorCollection() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KColorCollection", "KColorCollection()", typeof(void));
		}
		/// <remarks>
		///  KColorCollection copy constructor.
		/// </remarks>		<short>    KColorCollection copy constructor.</short>
		public KColorCollection(KColorCollection arg1) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KColorCollection#", "KColorCollection(const KColorCollection&)", typeof(void), typeof(KColorCollection), arg1);
		}
		/// <remarks>
		///  Save the collection
		/// </remarks>		<return> 'true' if successful
		/// </return>
		/// 		<short>    Save the collection </short>
		public bool Save() {
			return (bool) interceptor.Invoke("save", "save()", typeof(bool));
		}
		/// <remarks>
		///  Get the description of the collection.
		/// </remarks>		<return> the description of the collection.
		/// </return>
		/// 		<short>    Get the description of the collection.</short>
		public string Description() {
			return (string) interceptor.Invoke("description", "description() const", typeof(string));
		}
		/// <remarks>   	
		///  Set the description of the collection.
		/// <param> name="desc" the new description
		/// </param></remarks>		<short>     	  Set the description of the collection.</short>
		public void SetDescription(string desc) {
			interceptor.Invoke("setDescription$", "setDescription(const QString&)", typeof(void), typeof(string), desc);
		}
		/// <remarks>
		///  Get the name of the collection.
		/// </remarks>		<return> the name of the collection
		/// </return>
		/// 		<short>    Get the name of the collection.</short>
		public string Name() {
			return (string) interceptor.Invoke("name", "name() const", typeof(string));
		}
		/// <remarks>
		///  Set the name of the collection.
		/// <param> name="name" the name of the collection
		/// </param></remarks>		<short>    Set the name of the collection.</short>
		public void SetName(string name) {
			interceptor.Invoke("setName$", "setName(const QString&)", typeof(void), typeof(string), name);
		}
		/// <remarks>
		///  Returns whether the collection may be edited.
		/// </remarks>		<return> the state of the collection
		/// </return>
		/// 		<short>    Returns whether the collection may be edited.</short>
		public KColorCollection.Editable editable() {
			return (KColorCollection.Editable) interceptor.Invoke("editable", "editable() const", typeof(KColorCollection.Editable));
		}
		/// <remarks>
		///  Change whether the collection may be edited.
		/// <param> name="editable" the state of the collection
		/// </param></remarks>		<short>    Change whether the collection may be edited.</short>
		public void SetEditable(KColorCollection.Editable editable) {
			interceptor.Invoke("setEditable$", "setEditable(KColorCollection::Editable)", typeof(void), typeof(KColorCollection.Editable), editable);
		}
		/// <remarks>
		///  Return the number of colors in the collection.
		/// </remarks>		<return> the number of colors
		/// </return>
		/// 		<short>    Return the number of colors in the collection.</short>
		public int Count() {
			return (int) interceptor.Invoke("count", "count() const", typeof(int));
		}
		/// <remarks>
		///  Find color by index.
		/// <param> name="index" the index of the desired color
		/// </param></remarks>		<return> The <code>index</code> -th color of the collection, null if not found.
		/// </return>
		/// 		<short>    Find color by index.</short>
		public QColor Color(int index) {
			return (QColor) interceptor.Invoke("color$", "color(int) const", typeof(QColor), typeof(int), index);
		}
		/// <remarks>
		///  Find index by <code>color.</code>
		/// <param> name="color" the color to find
		/// </param></remarks>		<return> The index of the color in the collection or -1 if the
		///  color is not found.
		/// </return>
		/// 		<short>    Find index by <code>color.</code></short>
		public int FindColor(QColor color) {
			return (int) interceptor.Invoke("findColor#", "findColor(const QColor&) const", typeof(int), typeof(QColor), color);
		}
		/// <remarks>
		///  Find color name by <code>index.</code>
		/// <param> name="index" the index of the color
		/// </param></remarks>		<return> The name of the <code>index</code> -th color.
		///  Note that not all collections have named the colors. Null is
		///  returned if the color does not exist or has no name.
		/// </return>
		/// 		<short>    Find color name by <code>index.</code></short>
		public string Name(int index) {
			return (string) interceptor.Invoke("name$", "name(int) const", typeof(string), typeof(int), index);
		}
		/// <remarks>
		///  Find color name by <code>color.</code>
		/// </remarks>		<return> The name of color according to this collection.
		///  Note that not all collections have named the colors.
		///  Note also that each collection can give the same color
		///  a different name.
		/// </return>
		/// 		<short>    Find color name by <code>color.</code></short>
		public string Name(QColor color) {
			return (string) interceptor.Invoke("name#", "name(const QColor&) const", typeof(string), typeof(QColor), color);
		}
		/// <remarks>
		///  Add a color.
		/// <param> name="newColor" The color to add.
		/// </param><param> name="newColorName" The name of the color, null to remove 
		///                      the name.
		/// </param></remarks>		<return> The index of the added color.
		/// </return>
		/// 		<short>    Add a color.</short>
		public int AddColor(QColor newColor, string newColorName) {
			return (int) interceptor.Invoke("addColor#$", "addColor(const QColor&, const QString&)", typeof(int), typeof(QColor), newColor, typeof(string), newColorName);
		}
		public int AddColor(QColor newColor) {
			return (int) interceptor.Invoke("addColor#", "addColor(const QColor&)", typeof(int), typeof(QColor), newColor);
		}
		/// <remarks>
		///  Change a color.
		/// <param> name="index" Index of the color to change
		/// </param><param> name="newColor" The new color.
		/// </param><param> name="newColorName" The new color name, null to remove 
		///                      the name.
		/// </param></remarks>		<return> The index of the new color or -1 if the color couldn't
		///  be changed.
		/// </return>
		/// 		<short>    Change a color.</short>
		public int ChangeColor(int index, QColor newColor, string newColorName) {
			return (int) interceptor.Invoke("changeColor$#$", "changeColor(int, const QColor&, const QString&)", typeof(int), typeof(int), index, typeof(QColor), newColor, typeof(string), newColorName);
		}
		public int ChangeColor(int index, QColor newColor) {
			return (int) interceptor.Invoke("changeColor$#", "changeColor(int, const QColor&)", typeof(int), typeof(int), index, typeof(QColor), newColor);
		}
		/// <remarks>
		///  Change a color.
		/// <param> name="oldColor" The original color
		/// </param><param> name="newColor" The new color.
		/// </param><param> name="newColorName" The new color name, null to remove 
		///                      the name.
		/// </param></remarks>		<return> The index of the new color or -1 if the color couldn't
		///  be changed.
		/// </return>
		/// 		<short>    Change a color.</short>
		public int ChangeColor(QColor oldColor, QColor newColor, string newColorName) {
			return (int) interceptor.Invoke("changeColor##$", "changeColor(const QColor&, const QColor&, const QString&)", typeof(int), typeof(QColor), oldColor, typeof(QColor), newColor, typeof(string), newColorName);
		}
		public int ChangeColor(QColor oldColor, QColor newColor) {
			return (int) interceptor.Invoke("changeColor##", "changeColor(const QColor&, const QColor&)", typeof(int), typeof(QColor), oldColor, typeof(QColor), newColor);
		}
		~KColorCollection() {
			interceptor.Invoke("~KColorCollection", "~KColorCollection()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~KColorCollection", "~KColorCollection()", typeof(void));
		}
		/// <remarks>
		///  Query which KDE color collections are installed.
		/// </remarks>		<return> A list with installed color collection names.
		///     </return>
		/// 		<short>    Query which KDE color collections are installed.</short>
		public static List<string> InstalledCollections() {
			return (List<string>) staticInterceptor.Invoke("installedCollections", "installedCollections()", typeof(List<string>));
		}
	}
}
