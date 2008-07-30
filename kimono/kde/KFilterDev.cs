//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {
    using System;
    using Qyoto;
    /// <remarks>
    ///  A class for reading and writing compressed data onto a device
    ///  (e.g. file, but other usages are possible, like a buffer or a socket).
    ///  To simply read/write compressed files, see deviceForFile.
    /// </remarks>        <author> David Faure <faure@kde.org>
    ///  </author>
    ///         <short>    A class for reading and writing compressed data onto a device  (e.</short>
    [SmokeClass("KFilterDev")]
    public class KFilterDev : QIODevice {
        protected KFilterDev(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(KFilterDev), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static KFilterDev() {
            staticInterceptor = new SmokeInvocation(typeof(KFilterDev), null);
        }
        /// <remarks>
        ///  Open for reading or writing.
        ///  If the KFilterBase's device is not opened, it will be opened.
        ///      </remarks>        <short>    Open for reading or writing.</short>
        [SmokeMethod("open(QIODevice::OpenMode)")]
        public override bool Open(uint mode) {
            return (bool) interceptor.Invoke("open$", "open(QIODevice::OpenMode)", typeof(bool), typeof(uint), mode);
        }
        /// <remarks>
        ///  Close after reading or writing.
        ///  If the KFilterBase's device was opened by open(), it will be closed.
        ///      </remarks>        <short>    Close after reading or writing.</short>
        [SmokeMethod("close()")]
        public override void Close() {
            interceptor.Invoke("close", "close()", typeof(void));
        }
        /// <remarks>
        ///  For writing gzip compressed files only:
        ///  set the name of the original file, to be used in the gzip header.
        /// <param> name="fileName" the name of the original file
        ///      </param></remarks>        <short>    For writing gzip compressed files only:  set the name of the original file, to be used in the gzip header.</short>
        public void SetOrigFileName(QByteArray fileName) {
            interceptor.Invoke("setOrigFileName#", "setOrigFileName(const QByteArray&)", typeof(void), typeof(QByteArray), fileName);
        }
        /// <remarks>
        ///  Call this let this device skip the gzip headers when reading/writing.
        ///  This way KFilterDev (with gzip filter) can be used as a direct wrapper
        ///  around zlib - this is used by KZip.
        ///      </remarks>        <short>    Call this let this device skip the gzip headers when reading/writing.</short>
        public void SetSkipHeaders() {
            interceptor.Invoke("setSkipHeaders", "setSkipHeaders()", typeof(void));
        }
        /// <remarks>
        ///  That one can be quite slow, when going back. Use with care.
        ///      </remarks>        <short>    That one can be quite slow, when going back.</short>
        [SmokeMethod("seek(qint64)")]
        public override bool Seek(long arg1) {
            return (bool) interceptor.Invoke("seek$", "seek(qint64)", typeof(bool), typeof(long), arg1);
        }
        [SmokeMethod("atEnd() const")]
        public override bool AtEnd() {
            return (bool) interceptor.Invoke("atEnd", "atEnd() const", typeof(bool));
        }
        // WARNING: Unimplemented C++ pure virtual - DO NOT CALL
        [SmokeMethod("writeData(const char*, qint64)")]
        protected override long WriteData(string data, long len) {
            return (long) interceptor.Invoke("writeData$$", "writeData(const char*, qint64)", typeof(long), typeof(string), data, typeof(long), len);
        }
        // WARNING: Unimplemented C++ pure virtual - DO NOT CALL
        [SmokeMethod("readData(char*, qint64)")]
        protected override long ReadData(Pointer<sbyte> data, long maxlen) {
            return (long) interceptor.Invoke("readData$$", "readData(char*, qint64)", typeof(long), typeof(Pointer<sbyte>), data, typeof(long), maxlen);
        }
        /// <remarks>
        ///  Creates an i/o device that is able to read from <code>fileName</code>,
        ///  whether it's compressed or not. Available compression filters
        ///  (gzip/bzip2 etc.) will automatically be used.
        ///  The compression filter to be used is determined from the <code>fileName</code>
        ///  if <code>mimetype</code> is empty. Pass "application/x-gzip" or "application/x-bzip"
        ///  to force the corresponding decompression filter, if available.
        ///  Warning: application/x-bzip may not be available.
        ///  In that case a QFile opened on the compressed data will be returned !
        ///  Use KFilterBase.FindFilterByMimeType and code similar to what
        ///  deviceForFile is doing, to better control what's happening.
        ///  The returned QIODevice has to be deleted after using.
        /// <param> name="fileName" the name of the file to filter
        /// </param><param> name="mimetype" the mime type of the file to filter, or string() if unknown
        /// </param><param> name="forceFilter" if true, the function will either find a compression filter, or return 0.
        ///                     If false, it will always return a QIODevice. If no
        ///                     filter is available it will return a simple QFile.
        ///                     This can be useful if the file is usable without a filter.
        /// </param></remarks>        <return> if a filter has been found, the QIODevice for the filter. If the
        ///          filter does not exist, the return value depends on <code>forceFilter.</code>
        ///          The returned QIODevice has to be deleted after using.
        ///      </return>
        ///         <short>    Creates an i/o device that is able to read from <code>fileName</code>,  whether it's compressed or not.</short>
        public static QIODevice DeviceForFile(string fileName, string mimetype, bool forceFilter) {
            return (QIODevice) staticInterceptor.Invoke("deviceForFile$$$", "deviceForFile(const QString&, const QString&, bool)", typeof(QIODevice), typeof(string), fileName, typeof(string), mimetype, typeof(bool), forceFilter);
        }
        public static QIODevice DeviceForFile(string fileName, string mimetype) {
            return (QIODevice) staticInterceptor.Invoke("deviceForFile$$", "deviceForFile(const QString&, const QString&)", typeof(QIODevice), typeof(string), fileName, typeof(string), mimetype);
        }
        public static QIODevice DeviceForFile(string fileName) {
            return (QIODevice) staticInterceptor.Invoke("deviceForFile$", "deviceForFile(const QString&)", typeof(QIODevice), typeof(string), fileName);
        }
        /// <remarks>
        ///  Creates an i/o device that is able to read from the QIODevice <code>inDevice</code>,
        ///  whether the data is compressed or not. Available compression filters
        ///  (gzip/bzip2 etc.) will automatically be used.
        ///  The compression filter to be used is determined <code>mimetype</code> .
        ///  Pass "application/x-gzip" or "application/x-bzip"
        ///  to use the corresponding decompression filter.
        ///  Warning: application/x-bzip may not be available.
        ///  In that case 0 will be returned !
        ///  The returned QIODevice has to be deleted after using.
        /// <param> name="inDevice" input device. Won't be deleted if <code>autoDeleteInDevice</code> = false
        /// </param><param> name="mimetype" the mime type for the filter
        /// </param><param> name="autoDeleteInDevice" if true, <code>inDevice</code> will be deleted automatically
        /// </param></remarks>        <return> a QIODevice that filters the original stream. Must be deleted after
        ///          using
        ///      </return>
        ///         <short>    Creates an i/o device that is able to read from the QIODevice <code>inDevice</code>,  whether the data is compressed or not.</short>
        public static QIODevice Device(QIODevice inDevice, string mimetype, bool autoDeleteInDevice) {
            return (QIODevice) staticInterceptor.Invoke("device#$$", "device(QIODevice*, const QString&, bool)", typeof(QIODevice), typeof(QIODevice), inDevice, typeof(string), mimetype, typeof(bool), autoDeleteInDevice);
        }
        public static QIODevice Device(QIODevice inDevice, string mimetype) {
            return (QIODevice) staticInterceptor.Invoke("device#$", "device(QIODevice*, const QString&)", typeof(QIODevice), typeof(QIODevice), inDevice, typeof(string), mimetype);
        }
        protected new IKFilterDevSignals Emit {
            get { return (IKFilterDevSignals) Q_EMIT; }
        }
    }

    public interface IKFilterDevSignals : IQIODeviceSignals {
    }
}
