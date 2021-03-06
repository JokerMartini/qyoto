//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Collections.Generic;
    [SmokeClass("QImage")]
    public class QImage : QPaintDevice, IDisposable {
        protected QImage(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QImage), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QImage() {
            staticInterceptor = new SmokeInvocation(typeof(QImage), null);
        }
        public enum InvertMode {
            InvertRgb = 0,
            InvertRgba = 1,
        }
        public enum Format {
            Format_Invalid = 0,
            Format_Mono = 1,
            Format_MonoLSB = 2,
            Format_Indexed8 = 3,
            Format_RGB32 = 4,
            Format_ARGB32 = 5,
            Format_ARGB32_Premultiplied = 6,
            Format_RGB16 = 7,
            Format_ARGB8565_Premultiplied = 8,
            Format_RGB666 = 9,
            Format_ARGB6666_Premultiplied = 10,
            Format_RGB555 = 11,
            Format_ARGB8555_Premultiplied = 12,
            Format_RGB888 = 13,
            Format_RGB444 = 14,
            Format_ARGB4444_Premultiplied = 15,
            NImageFormats = 16,
        }
        // QImage* QImage(const char** arg1); >>>> NOT CONVERTED
        //  operator QVariant(); >>>> NOT CONVERTED
        // QList<QImageTextKeyLang> textList(); >>>> NOT CONVERTED
        // QString text(const QImageTextKeyLang& arg1); >>>> NOT CONVERTED
        // QImageData*& data_ptr(); >>>> NOT CONVERTED
        public QImage() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QImage", "QImage()", typeof(void));
        }
        public QImage(QSize size, QImage.Format format) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QImage#$", "QImage(const QSize&, QImage::Format)", typeof(void), typeof(QSize), size, typeof(QImage.Format), format);
        }
        public QImage(int width, int height, QImage.Format format) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QImage$$$", "QImage(int, int, QImage::Format)", typeof(void), typeof(int), width, typeof(int), height, typeof(QImage.Format), format);
        }
        public QImage(Pointer<byte> data, int width, int height, QImage.Format format) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QImage$$$$", "QImage(unsigned char*, int, int, QImage::Format)", typeof(void), typeof(Pointer<byte>), data, typeof(int), width, typeof(int), height, typeof(QImage.Format), format);
        }
        public QImage(Pointer<byte> data, int width, int height, int bytesPerLine, QImage.Format format) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QImage$$$$$", "QImage(unsigned char*, int, int, int, QImage::Format)", typeof(void), typeof(Pointer<byte>), data, typeof(int), width, typeof(int), height, typeof(int), bytesPerLine, typeof(QImage.Format), format);
        }
        public QImage(string fileName, string format) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QImage$$", "QImage(const QString&, const char*)", typeof(void), typeof(string), fileName, typeof(string), format);
        }
        public QImage(string fileName) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QImage$", "QImage(const QString&)", typeof(void), typeof(string), fileName);
        }
        public QImage(QImage arg1) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QImage#", "QImage(const QImage&)", typeof(void), typeof(QImage), arg1);
        }
        public bool IsNull() {
            return (bool) interceptor.Invoke("isNull", "isNull() const", typeof(bool));
        }
        [SmokeMethod("devType() const")]
        public override int DevType() {
            return (int) interceptor.Invoke("devType", "devType() const", typeof(int));
        }
        public override bool Equals(object o) {
            if (!(o is QImage)) { return false; }
            return this == (QImage) o;
        }
        public override int GetHashCode() {
            return interceptor.GetHashCode();
        }
        public void Detach() {
            interceptor.Invoke("detach", "detach()", typeof(void));
        }
        public bool IsDetached() {
            return (bool) interceptor.Invoke("isDetached", "isDetached() const", typeof(bool));
        }
        public QImage Copy(QRect rect) {
            return (QImage) interceptor.Invoke("copy#", "copy(const QRect&) const", typeof(QImage), typeof(QRect), rect);
        }
        public QImage Copy() {
            return (QImage) interceptor.Invoke("copy", "copy() const", typeof(QImage));
        }
        public QImage Copy(int x, int y, int w, int h) {
            return (QImage) interceptor.Invoke("copy$$$$", "copy(int, int, int, int) const", typeof(QImage), typeof(int), x, typeof(int), y, typeof(int), w, typeof(int), h);
        }
        public QImage.Format format() {
            return (QImage.Format) interceptor.Invoke("format", "format() const", typeof(QImage.Format));
        }
        public QImage ConvertToFormat(QImage.Format f, uint flags) {
            return (QImage) interceptor.Invoke("convertToFormat$$", "convertToFormat(QImage::Format, Qt::ImageConversionFlags) const", typeof(QImage), typeof(QImage.Format), f, typeof(uint), flags);
        }
        public QImage ConvertToFormat(QImage.Format f) {
            return (QImage) interceptor.Invoke("convertToFormat$", "convertToFormat(QImage::Format) const", typeof(QImage), typeof(QImage.Format), f);
        }
        public QImage ConvertToFormat(QImage.Format f, List<uint> colorTable, uint flags) {
            return (QImage) interceptor.Invoke("convertToFormat$?$", "convertToFormat(QImage::Format, const QVector<unsigned int>&, Qt::ImageConversionFlags) const", typeof(QImage), typeof(QImage.Format), f, typeof(List<uint>), colorTable, typeof(uint), flags);
        }
        public QImage ConvertToFormat(QImage.Format f, List<uint> colorTable) {
            return (QImage) interceptor.Invoke("convertToFormat$?", "convertToFormat(QImage::Format, const QVector<unsigned int>&) const", typeof(QImage), typeof(QImage.Format), f, typeof(List<uint>), colorTable);
        }
        public new int Width() {
            return (int) interceptor.Invoke("width", "width() const", typeof(int));
        }
        public new int Height() {
            return (int) interceptor.Invoke("height", "height() const", typeof(int));
        }
        public QSize Size() {
            return (QSize) interceptor.Invoke("size", "size() const", typeof(QSize));
        }
        public QRect Rect() {
            return (QRect) interceptor.Invoke("rect", "rect() const", typeof(QRect));
        }
        public new int Depth() {
            return (int) interceptor.Invoke("depth", "depth() const", typeof(int));
        }
        public new int NumColors() {
            return (int) interceptor.Invoke("numColors", "numColors() const", typeof(int));
        }
        public uint Color(int i) {
            return (uint) interceptor.Invoke("color$", "color(int) const", typeof(uint), typeof(int), i);
        }
        public void SetColor(int i, uint c) {
            interceptor.Invoke("setColor$$", "setColor(int, unsigned int)", typeof(void), typeof(int), i, typeof(uint), c);
        }
        public void SetNumColors(int arg1) {
            interceptor.Invoke("setNumColors$", "setNumColors(int)", typeof(void), typeof(int), arg1);
        }
        public bool AllGray() {
            return (bool) interceptor.Invoke("allGray", "allGray() const", typeof(bool));
        }
        public bool IsGrayscale() {
            return (bool) interceptor.Invoke("isGrayscale", "isGrayscale() const", typeof(bool));
        }
        public Pointer<byte> Bits() {
            return (Pointer<byte>) interceptor.Invoke("bits", "bits()", typeof(Pointer<byte>));
        }
        public int NumBytes() {
            return (int) interceptor.Invoke("numBytes", "numBytes() const", typeof(int));
        }
        public Pointer<byte> ScanLine(int arg1) {
            return (Pointer<byte>) interceptor.Invoke("scanLine$", "scanLine(int)", typeof(Pointer<byte>), typeof(int), arg1);
        }
        public int BytesPerLine() {
            return (int) interceptor.Invoke("bytesPerLine", "bytesPerLine() const", typeof(int));
        }
        public bool Valid(int x, int y) {
            return (bool) interceptor.Invoke("valid$$", "valid(int, int) const", typeof(bool), typeof(int), x, typeof(int), y);
        }
        public bool Valid(QPoint pt) {
            return (bool) interceptor.Invoke("valid#", "valid(const QPoint&) const", typeof(bool), typeof(QPoint), pt);
        }
        public int PixelIndex(int x, int y) {
            return (int) interceptor.Invoke("pixelIndex$$", "pixelIndex(int, int) const", typeof(int), typeof(int), x, typeof(int), y);
        }
        public int PixelIndex(QPoint pt) {
            return (int) interceptor.Invoke("pixelIndex#", "pixelIndex(const QPoint&) const", typeof(int), typeof(QPoint), pt);
        }
        public uint Pixel(int x, int y) {
            return (uint) interceptor.Invoke("pixel$$", "pixel(int, int) const", typeof(uint), typeof(int), x, typeof(int), y);
        }
        public uint Pixel(QPoint pt) {
            return (uint) interceptor.Invoke("pixel#", "pixel(const QPoint&) const", typeof(uint), typeof(QPoint), pt);
        }
        public void SetPixel(int x, int y, uint index_or_rgb) {
            interceptor.Invoke("setPixel$$$", "setPixel(int, int, uint)", typeof(void), typeof(int), x, typeof(int), y, typeof(uint), index_or_rgb);
        }
        public void SetPixel(QPoint pt, uint index_or_rgb) {
            interceptor.Invoke("setPixel#$", "setPixel(const QPoint&, uint)", typeof(void), typeof(QPoint), pt, typeof(uint), index_or_rgb);
        }
        public List<uint> ColorTable() {
            return (List<uint>) interceptor.Invoke("colorTable", "colorTable() const", typeof(List<uint>));
        }
        public void SetColorTable(List<uint> colors) {
            interceptor.Invoke("setColorTable?", "setColorTable(const QVector<unsigned int>)", typeof(void), typeof(List<uint>), colors);
        }
        public void Fill(uint pixel) {
            interceptor.Invoke("fill$", "fill(uint)", typeof(void), typeof(uint), pixel);
        }
        public bool HasAlphaChannel() {
            return (bool) interceptor.Invoke("hasAlphaChannel", "hasAlphaChannel() const", typeof(bool));
        }
        public void SetAlphaChannel(QImage alphaChannel) {
            interceptor.Invoke("setAlphaChannel#", "setAlphaChannel(const QImage&)", typeof(void), typeof(QImage), alphaChannel);
        }
        public QImage AlphaChannel() {
            return (QImage) interceptor.Invoke("alphaChannel", "alphaChannel() const", typeof(QImage));
        }
        public QImage CreateAlphaMask(uint flags) {
            return (QImage) interceptor.Invoke("createAlphaMask$", "createAlphaMask(Qt::ImageConversionFlags) const", typeof(QImage), typeof(uint), flags);
        }
        public QImage CreateAlphaMask() {
            return (QImage) interceptor.Invoke("createAlphaMask", "createAlphaMask() const", typeof(QImage));
        }
        public QImage CreateHeuristicMask(bool clipTight) {
            return (QImage) interceptor.Invoke("createHeuristicMask$", "createHeuristicMask(bool) const", typeof(QImage), typeof(bool), clipTight);
        }
        public QImage CreateHeuristicMask() {
            return (QImage) interceptor.Invoke("createHeuristicMask", "createHeuristicMask() const", typeof(QImage));
        }
        public QImage CreateMaskFromColor(uint color, Qt.MaskMode mode) {
            return (QImage) interceptor.Invoke("createMaskFromColor$$", "createMaskFromColor(unsigned int, Qt::MaskMode) const", typeof(QImage), typeof(uint), color, typeof(Qt.MaskMode), mode);
        }
        public QImage CreateMaskFromColor(uint color) {
            return (QImage) interceptor.Invoke("createMaskFromColor$", "createMaskFromColor(unsigned int) const", typeof(QImage), typeof(uint), color);
        }
        public QImage Scaled(int w, int h, Qt.AspectRatioMode aspectMode, Qt.TransformationMode mode) {
            return (QImage) interceptor.Invoke("scaled$$$$", "scaled(int, int, Qt::AspectRatioMode, Qt::TransformationMode) const", typeof(QImage), typeof(int), w, typeof(int), h, typeof(Qt.AspectRatioMode), aspectMode, typeof(Qt.TransformationMode), mode);
        }
        public QImage Scaled(int w, int h, Qt.AspectRatioMode aspectMode) {
            return (QImage) interceptor.Invoke("scaled$$$", "scaled(int, int, Qt::AspectRatioMode) const", typeof(QImage), typeof(int), w, typeof(int), h, typeof(Qt.AspectRatioMode), aspectMode);
        }
        public QImage Scaled(int w, int h) {
            return (QImage) interceptor.Invoke("scaled$$", "scaled(int, int) const", typeof(QImage), typeof(int), w, typeof(int), h);
        }
        public QImage Scaled(QSize s, Qt.AspectRatioMode aspectMode, Qt.TransformationMode mode) {
            return (QImage) interceptor.Invoke("scaled#$$", "scaled(const QSize&, Qt::AspectRatioMode, Qt::TransformationMode) const", typeof(QImage), typeof(QSize), s, typeof(Qt.AspectRatioMode), aspectMode, typeof(Qt.TransformationMode), mode);
        }
        public QImage Scaled(QSize s, Qt.AspectRatioMode aspectMode) {
            return (QImage) interceptor.Invoke("scaled#$", "scaled(const QSize&, Qt::AspectRatioMode) const", typeof(QImage), typeof(QSize), s, typeof(Qt.AspectRatioMode), aspectMode);
        }
        public QImage Scaled(QSize s) {
            return (QImage) interceptor.Invoke("scaled#", "scaled(const QSize&) const", typeof(QImage), typeof(QSize), s);
        }
        public QImage ScaledToWidth(int w, Qt.TransformationMode mode) {
            return (QImage) interceptor.Invoke("scaledToWidth$$", "scaledToWidth(int, Qt::TransformationMode) const", typeof(QImage), typeof(int), w, typeof(Qt.TransformationMode), mode);
        }
        public QImage ScaledToWidth(int w) {
            return (QImage) interceptor.Invoke("scaledToWidth$", "scaledToWidth(int) const", typeof(QImage), typeof(int), w);
        }
        public QImage ScaledToHeight(int h, Qt.TransformationMode mode) {
            return (QImage) interceptor.Invoke("scaledToHeight$$", "scaledToHeight(int, Qt::TransformationMode) const", typeof(QImage), typeof(int), h, typeof(Qt.TransformationMode), mode);
        }
        public QImage ScaledToHeight(int h) {
            return (QImage) interceptor.Invoke("scaledToHeight$", "scaledToHeight(int) const", typeof(QImage), typeof(int), h);
        }
        public QImage Transformed(QMatrix matrix, Qt.TransformationMode mode) {
            return (QImage) interceptor.Invoke("transformed#$", "transformed(const QMatrix&, Qt::TransformationMode) const", typeof(QImage), typeof(QMatrix), matrix, typeof(Qt.TransformationMode), mode);
        }
        public QImage Transformed(QMatrix matrix) {
            return (QImage) interceptor.Invoke("transformed#", "transformed(const QMatrix&) const", typeof(QImage), typeof(QMatrix), matrix);
        }
        public QImage Transformed(QTransform matrix, Qt.TransformationMode mode) {
            return (QImage) interceptor.Invoke("transformed#$", "transformed(const QTransform&, Qt::TransformationMode) const", typeof(QImage), typeof(QTransform), matrix, typeof(Qt.TransformationMode), mode);
        }
        public QImage Transformed(QTransform matrix) {
            return (QImage) interceptor.Invoke("transformed#", "transformed(const QTransform&) const", typeof(QImage), typeof(QTransform), matrix);
        }
        public QImage Mirrored(bool horizontally, bool vertically) {
            return (QImage) interceptor.Invoke("mirrored$$", "mirrored(bool, bool) const", typeof(QImage), typeof(bool), horizontally, typeof(bool), vertically);
        }
        public QImage Mirrored(bool horizontally) {
            return (QImage) interceptor.Invoke("mirrored$", "mirrored(bool) const", typeof(QImage), typeof(bool), horizontally);
        }
        public QImage Mirrored() {
            return (QImage) interceptor.Invoke("mirrored", "mirrored() const", typeof(QImage));
        }
        public QImage RgbSwapped() {
            return (QImage) interceptor.Invoke("rgbSwapped", "rgbSwapped() const", typeof(QImage));
        }
        public void InvertPixels(QImage.InvertMode arg1) {
            interceptor.Invoke("invertPixels$", "invertPixels(QImage::InvertMode)", typeof(void), typeof(QImage.InvertMode), arg1);
        }
        public void InvertPixels() {
            interceptor.Invoke("invertPixels", "invertPixels()", typeof(void));
        }
        public bool Load(QIODevice device, string format) {
            return (bool) interceptor.Invoke("load#$", "load(QIODevice*, const char*)", typeof(bool), typeof(QIODevice), device, typeof(string), format);
        }
        public bool Load(string fileName, string format) {
            return (bool) interceptor.Invoke("load$$", "load(const QString&, const char*)", typeof(bool), typeof(string), fileName, typeof(string), format);
        }
        public bool Load(string fileName) {
            return (bool) interceptor.Invoke("load$", "load(const QString&)", typeof(bool), typeof(string), fileName);
        }
        public bool LoadFromData(Pointer<byte> buf, int len, string format) {
            return (bool) interceptor.Invoke("loadFromData$$$", "loadFromData(const unsigned char*, int, const char*)", typeof(bool), typeof(Pointer<byte>), buf, typeof(int), len, typeof(string), format);
        }
        public bool LoadFromData(Pointer<byte> buf, int len) {
            return (bool) interceptor.Invoke("loadFromData$$", "loadFromData(const unsigned char*, int)", typeof(bool), typeof(Pointer<byte>), buf, typeof(int), len);
        }
        public bool LoadFromData(QByteArray data, string aformat) {
            return (bool) interceptor.Invoke("loadFromData#$", "loadFromData(const QByteArray&, const char*)", typeof(bool), typeof(QByteArray), data, typeof(string), aformat);
        }
        public bool LoadFromData(QByteArray data) {
            return (bool) interceptor.Invoke("loadFromData#", "loadFromData(const QByteArray&)", typeof(bool), typeof(QByteArray), data);
        }
        public bool Save(string fileName, string format, int quality) {
            return (bool) interceptor.Invoke("save$$$", "save(const QString&, const char*, int) const", typeof(bool), typeof(string), fileName, typeof(string), format, typeof(int), quality);
        }
        public bool Save(string fileName, string format) {
            return (bool) interceptor.Invoke("save$$", "save(const QString&, const char*) const", typeof(bool), typeof(string), fileName, typeof(string), format);
        }
        public bool Save(string fileName) {
            return (bool) interceptor.Invoke("save$", "save(const QString&) const", typeof(bool), typeof(string), fileName);
        }
        public bool Save(QIODevice device, string format, int quality) {
            return (bool) interceptor.Invoke("save#$$", "save(QIODevice*, const char*, int) const", typeof(bool), typeof(QIODevice), device, typeof(string), format, typeof(int), quality);
        }
        public bool Save(QIODevice device, string format) {
            return (bool) interceptor.Invoke("save#$", "save(QIODevice*, const char*) const", typeof(bool), typeof(QIODevice), device, typeof(string), format);
        }
        public bool Save(QIODevice device) {
            return (bool) interceptor.Invoke("save#", "save(QIODevice*) const", typeof(bool), typeof(QIODevice), device);
        }
        public int SerialNumber() {
            return (int) interceptor.Invoke("serialNumber", "serialNumber() const", typeof(int));
        }
        public long CacheKey() {
            return (long) interceptor.Invoke("cacheKey", "cacheKey() const", typeof(long));
        }
        [SmokeMethod("paintEngine() const")]
        public override QPaintEngine PaintEngine() {
            return (QPaintEngine) interceptor.Invoke("paintEngine", "paintEngine() const", typeof(QPaintEngine));
        }
        public int DotsPerMeterX() {
            return (int) interceptor.Invoke("dotsPerMeterX", "dotsPerMeterX() const", typeof(int));
        }
        public int DotsPerMeterY() {
            return (int) interceptor.Invoke("dotsPerMeterY", "dotsPerMeterY() const", typeof(int));
        }
        public void SetDotsPerMeterX(int arg1) {
            interceptor.Invoke("setDotsPerMeterX$", "setDotsPerMeterX(int)", typeof(void), typeof(int), arg1);
        }
        public void SetDotsPerMeterY(int arg1) {
            interceptor.Invoke("setDotsPerMeterY$", "setDotsPerMeterY(int)", typeof(void), typeof(int), arg1);
        }
        public QPoint Offset() {
            return (QPoint) interceptor.Invoke("offset", "offset() const", typeof(QPoint));
        }
        public void SetOffset(QPoint arg1) {
            interceptor.Invoke("setOffset#", "setOffset(const QPoint&)", typeof(void), typeof(QPoint), arg1);
        }
        public List<string> TextKeys() {
            return (List<string>) interceptor.Invoke("textKeys", "textKeys() const", typeof(List<string>));
        }
        public string Text(string key) {
            return (string) interceptor.Invoke("text$", "text(const QString&) const", typeof(string), typeof(string), key);
        }
        public string Text() {
            return (string) interceptor.Invoke("text", "text() const", typeof(string));
        }
        public void SetText(string key, string value) {
            interceptor.Invoke("setText$$", "setText(const QString&, const QString&)", typeof(void), typeof(string), key, typeof(string), value);
        }
        public string Text(string key, string lang) {
            return (string) interceptor.Invoke("text$$", "text(const char*, const char*) const", typeof(string), typeof(string), key, typeof(string), lang);
        }
        public List<string> TextLanguages() {
            return (List<string>) interceptor.Invoke("textLanguages", "textLanguages() const", typeof(List<string>));
        }
        public void SetText(string key, string lang, string arg3) {
            interceptor.Invoke("setText$$$", "setText(const char*, const char*, const QString&)", typeof(void), typeof(string), key, typeof(string), lang, typeof(string), arg3);
        }
        [SmokeMethod("metric(QPaintDevice::PaintDeviceMetric) const")]
        protected override int Metric(QPaintDevice.PaintDeviceMetric metric) {
            return (int) interceptor.Invoke("metric$", "metric(QPaintDevice::PaintDeviceMetric) const", typeof(int), typeof(QPaintDevice.PaintDeviceMetric), metric);
        }
        ~QImage() {
            interceptor.Invoke("~QImage", "~QImage()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QImage", "~QImage()", typeof(void));
        }
        public static bool operator==(QImage lhs, QImage arg1) {
            return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QImage&) const", typeof(bool), typeof(QImage), lhs, typeof(QImage), arg1);
        }
        public static bool operator!=(QImage lhs, QImage arg1) {
            return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QImage&) const", typeof(bool), typeof(QImage), lhs, typeof(QImage), arg1);
        }
        public static QMatrix TrueMatrix(QMatrix arg1, int w, int h) {
            return (QMatrix) staticInterceptor.Invoke("trueMatrix#$$", "trueMatrix(const QMatrix&, int, int)", typeof(QMatrix), typeof(QMatrix), arg1, typeof(int), w, typeof(int), h);
        }
        public static QTransform TrueMatrix(QTransform arg1, int w, int h) {
            return (QTransform) staticInterceptor.Invoke("trueMatrix#$$", "trueMatrix(const QTransform&, int, int)", typeof(QTransform), typeof(QTransform), arg1, typeof(int), w, typeof(int), h);
        }
        public static QImage FromData(Pointer<byte> data, int size, string format) {
            return (QImage) staticInterceptor.Invoke("fromData$$$", "fromData(const unsigned char*, int, const char*)", typeof(QImage), typeof(Pointer<byte>), data, typeof(int), size, typeof(string), format);
        }
        public static QImage FromData(Pointer<byte> data, int size) {
            return (QImage) staticInterceptor.Invoke("fromData$$", "fromData(const unsigned char*, int)", typeof(QImage), typeof(Pointer<byte>), data, typeof(int), size);
        }
        public static QImage FromData(QByteArray data, string format) {
            return (QImage) staticInterceptor.Invoke("fromData#$", "fromData(const QByteArray&, const char*)", typeof(QImage), typeof(QByteArray), data, typeof(string), format);
        }
        public static QImage FromData(QByteArray data) {
            return (QImage) staticInterceptor.Invoke("fromData#", "fromData(const QByteArray&)", typeof(QImage), typeof(QByteArray), data);
        }
    }
}
