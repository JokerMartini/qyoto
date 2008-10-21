//Auto-generated by kalyptus. DO NOT EDIT.
namespace Plasma {
    using Plasma;
    using System;
    using Kimono;
    using Qyoto;
    using System.Collections.Generic;
    [SmokeClass("Plasma::Package")]
    public class Package : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected Package(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(Package), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static Package() {
            staticInterceptor = new SmokeInvocation(typeof(Package), null);
        }
        /// <remarks>
        ///  Default constructor
        ///  @arg packageRoot path to the package installation root
        ///  @arg package the name of the package
        ///  @arg structure the package structure describing this package
        /// </remarks>        <short>    Default constructor </short>
        public Package(string packageRoot, string package, Plasma.PackageStructure structure) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Package$$?", "Package(const QString&, const QString&, KSharedPtr<Plasma::PackageStructure>)", typeof(void), typeof(string), packageRoot, typeof(string), package, typeof(Plasma.PackageStructure), structure);
        }
        /// <remarks>
        ///  Construct a Package object.
        ///  @arg packagePath full path to the package directory
        ///  @arg structure the package structure describing this package
        ///           </remarks>        <short>    Construct a Package object.</short>
        public Package(string packagePath, Plasma.PackageStructure structure) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Package$?", "Package(const QString&, KSharedPtr<Plasma::PackageStructure>)", typeof(void), typeof(string), packagePath, typeof(Plasma.PackageStructure), structure);
        }
        /// <remarks>
        /// </remarks>        <return> true if all the required components as defined in
        ///  the PackageStructure exist
        /// </return>
        ///         <short>   </short>
        public bool IsValid() {
            return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
        }
        /// <remarks>
        ///  Get the path to a given file.
        ///  @arg fileType the type of file to look for, as defined in the
        ///                package structure
        ///  @arg filename the name of the file
        /// </remarks>        <return> path to the file on disk. string() if not found.
        /// </return>
        ///         <short>    Get the path to a given file.</short>
        public string FilePath(string fileType, string filename) {
            return (string) interceptor.Invoke("filePath$$", "filePath(const char*, const QString&) const", typeof(string), typeof(string), fileType, typeof(string), filename);
        }
        /// <remarks>
        ///  Get the path to a given file.
        ///  @arg fileType the type of file to look for, as defined in the
        ///                package structure. The type must refer to a file
        ///                in the package structure and not a directory.
        /// </remarks>        <return> path to the file on disk. string() if not found
        /// </return>
        ///         <short>    Get the path to a given file.</short>
        public string FilePath(string fileType) {
            return (string) interceptor.Invoke("filePath$", "filePath(const char*) const", typeof(string), typeof(string), fileType);
        }
        /// <remarks>
        ///  Get the list of files of a given type.
        ///  @arg fileType the type of file to look for, as defined in the
        ///                package structure.
        /// </remarks>        <return> list of files by name, suitable for passing to filePath
        /// </return>
        ///         <short>    Get the list of files of a given type.</short>
        public List<string> EntryList(string fileType) {
            return (List<string>) interceptor.Invoke("entryList$", "entryList(const char*) const", typeof(List<string>), typeof(string), fileType);
        }
        /// <remarks>
        /// </remarks>        <return> the package metadata object.
        ///           </return>
        ///         <short>   </short>
        public Plasma.PackageMetadata Metadata() {
            return (Plasma.PackageMetadata) interceptor.Invoke("metadata", "metadata() const", typeof(Plasma.PackageMetadata));
        }
        /// <remarks>
        /// </remarks>        <return> the path to the root of this particular package
        ///          </return>
        ///         <short>   </short>
        public string Path() {
            return (string) interceptor.Invoke("path", "path() const", typeof(string));
        }
        /// <remarks>
        /// </remarks>        <return> the PackageStructure use in this Package
        ///          </return>
        ///         <short>   </short>
        public Plasma.PackageStructure Structure() {
            return (Plasma.PackageStructure) interceptor.Invoke("structure", "structure() const", typeof(Plasma.PackageStructure));
        }
        ~Package() {
            interceptor.Invoke("~Package", "~Package()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~Package", "~Package()", typeof(void));
        }
        /// <remarks>
        ///  Returns a list of all installed packages
        /// <param> name="packageRoot" path to the directory where Plasmagik packages
        ///                     have been installed to
        /// </param></remarks>        <return> a list of installed Plasmagik packages
        /// </return>
        ///         <short>    Returns a list of all installed packages </short>
        public static List<string> ListInstalled(string packageRoot) {
            return (List<string>) staticInterceptor.Invoke("listInstalled$", "listInstalled(const QString&)", typeof(List<string>), typeof(string), packageRoot);
        }
        /// <remarks>
        ///  Installs a package.
        /// <param> name="package" path to the Plasmagik package
        /// </param><param> name="packageRoot" path to the directory where the package should be
        ///                     installed to
        /// </param></remarks>        <return> true on successful installation, false otherwise
        /// </return>
        ///         <short>    Installs a package.</short>
        public static bool InstallPackage(string package, string packageRoot, string servicePrefix) {
            return (bool) staticInterceptor.Invoke("installPackage$$$", "installPackage(const QString&, const QString&, const QString&)", typeof(bool), typeof(string), package, typeof(string), packageRoot, typeof(string), servicePrefix);
        }
        /// <remarks>
        ///  Uninstalls a package.
        /// <param> name="package" path to the Plasmagik package
        /// </param><param> name="packageRoot" path to the directory where the package should be
        ///                     installed to
        /// </param></remarks>        <return> true on successful uninstallation, false otherwise
        /// </return>
        ///         <short>    Uninstalls a package.</short>
        public static bool UninstallPackage(string package, string packageRoot, string servicePrefix) {
            return (bool) staticInterceptor.Invoke("uninstallPackage$$$", "uninstallPackage(const QString&, const QString&, const QString&)", typeof(bool), typeof(string), package, typeof(string), packageRoot, typeof(string), servicePrefix);
        }
        /// <remarks>
        ///  Registers a package described by the given desktop file
        ///  @arg the full path to the desktop file (must be KPluginInfo compatible)
        /// </remarks>        <return> true on success, false on failure
        ///          </return>
        ///         <short>    Registers a package described by the given desktop file </short>
        public static bool RegisterPackage(Plasma.PackageMetadata data, string iconPath) {
            return (bool) staticInterceptor.Invoke("registerPackage#$", "registerPackage(const Plasma::PackageMetadata&, const QString&)", typeof(bool), typeof(Plasma.PackageMetadata), data, typeof(string), iconPath);
        }
        /// <remarks>
        ///  Creates a package based on the metadata from the files contained
        ///  in the source directory
        ///  @arg metadata description of the package to create
        ///  @arg source path to local directory containing the individual
        ///              files to be added to the package
        ///  @arg destination path to the package that should be created
        ///  @arg icon path to the package icon
        /// </remarks>        <short>    Creates a package based on the metadata from the files contained  in the source directory </short>
        public static bool CreatePackage(Plasma.PackageMetadata metadata, string source, string destination, string icon) {
            return (bool) staticInterceptor.Invoke("createPackage#$$$", "createPackage(const Plasma::PackageMetadata&, const QString&, const QString&, const QString&)", typeof(bool), typeof(Plasma.PackageMetadata), metadata, typeof(string), source, typeof(string), destination, typeof(string), icon);
        }
        public static bool CreatePackage(Plasma.PackageMetadata metadata, string source, string destination) {
            return (bool) staticInterceptor.Invoke("createPackage#$$", "createPackage(const Plasma::PackageMetadata&, const QString&, const QString&)", typeof(bool), typeof(Plasma.PackageMetadata), metadata, typeof(string), source, typeof(string), destination);
        }
    }
}
