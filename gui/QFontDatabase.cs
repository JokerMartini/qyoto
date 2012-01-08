//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Collections.Generic;
    [SmokeClass("QFontDatabase")]
    public class QFontDatabase : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QFontDatabase(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QFontDatabase), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QFontDatabase() {
            staticInterceptor = new SmokeInvocation(typeof(QFontDatabase), null);
        }
        public enum WritingSystem {
            Any = 0,
            Latin = 1,
            Greek = 2,
            Cyrillic = 3,
            Armenian = 4,
            Hebrew = 5,
            Arabic = 6,
            Syriac = 7,
            Thaana = 8,
            Devanagari = 9,
            Bengali = 10,
            Gurmukhi = 11,
            Gujarati = 12,
            Oriya = 13,
            Tamil = 14,
            Telugu = 15,
            Kannada = 16,
            Malayalam = 17,
            Sinhala = 18,
            Thai = 19,
            Lao = 20,
            Tibetan = 21,
            Myanmar = 22,
            Georgian = 23,
            Khmer = 24,
            SimplifiedChinese = 25,
            TraditionalChinese = 26,
            Japanese = 27,
            Korean = 28,
            Vietnamese = 29,
            Symbol = 30,
            Other = Symbol,
            Ogham = 31,
            Runic = 32,
            WritingSystemsCount = 33,
        }
        public QFontDatabase() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QFontDatabase", "QFontDatabase()", typeof(void));
        }
        public List<QFontDatabase.WritingSystem> WritingSystems() {
            return (List<QFontDatabase.WritingSystem>) interceptor.Invoke("writingSystems", "writingSystems() const", typeof(List<QFontDatabase.WritingSystem>));
        }
        public List<QFontDatabase.WritingSystem> WritingSystems(string family) {
            return (List<QFontDatabase.WritingSystem>) interceptor.Invoke("writingSystems$", "writingSystems(const QString&) const", typeof(List<QFontDatabase.WritingSystem>), typeof(string), family);
        }
        public List<string> Families(QFontDatabase.WritingSystem writingSystem) {
            return (List<string>) interceptor.Invoke("families$", "families(QFontDatabase::WritingSystem) const", typeof(List<string>), typeof(QFontDatabase.WritingSystem), writingSystem);
        }
        public List<string> Families() {
            return (List<string>) interceptor.Invoke("families", "families() const", typeof(List<string>));
        }
        public List<string> Styles(string family) {
            return (List<string>) interceptor.Invoke("styles$", "styles(const QString&) const", typeof(List<string>), typeof(string), family);
        }
        public List<int> PointSizes(string family, string style) {
            return (List<int>) interceptor.Invoke("pointSizes$$", "pointSizes(const QString&, const QString&)", typeof(List<int>), typeof(string), family, typeof(string), style);
        }
        public List<int> PointSizes(string family) {
            return (List<int>) interceptor.Invoke("pointSizes$", "pointSizes(const QString&)", typeof(List<int>), typeof(string), family);
        }
        public List<int> SmoothSizes(string family, string style) {
            return (List<int>) interceptor.Invoke("smoothSizes$$", "smoothSizes(const QString&, const QString&)", typeof(List<int>), typeof(string), family, typeof(string), style);
        }
        public string StyleString(QFont font) {
            return (string) interceptor.Invoke("styleString#", "styleString(const QFont&)", typeof(string), typeof(QFont), font);
        }
        public string StyleString(QFontInfo fontInfo) {
            return (string) interceptor.Invoke("styleString#", "styleString(const QFontInfo&)", typeof(string), typeof(QFontInfo), fontInfo);
        }
        public QFont Font(string family, string style, int pointSize) {
            return (QFont) interceptor.Invoke("font$$$", "font(const QString&, const QString&, int) const", typeof(QFont), typeof(string), family, typeof(string), style, typeof(int), pointSize);
        }
        public bool IsBitmapScalable(string family, string style) {
            return (bool) interceptor.Invoke("isBitmapScalable$$", "isBitmapScalable(const QString&, const QString&) const", typeof(bool), typeof(string), family, typeof(string), style);
        }
        public bool IsBitmapScalable(string family) {
            return (bool) interceptor.Invoke("isBitmapScalable$", "isBitmapScalable(const QString&) const", typeof(bool), typeof(string), family);
        }
        public bool IsSmoothlyScalable(string family, string style) {
            return (bool) interceptor.Invoke("isSmoothlyScalable$$", "isSmoothlyScalable(const QString&, const QString&) const", typeof(bool), typeof(string), family, typeof(string), style);
        }
        public bool IsSmoothlyScalable(string family) {
            return (bool) interceptor.Invoke("isSmoothlyScalable$", "isSmoothlyScalable(const QString&) const", typeof(bool), typeof(string), family);
        }
        public bool IsScalable(string family, string style) {
            return (bool) interceptor.Invoke("isScalable$$", "isScalable(const QString&, const QString&) const", typeof(bool), typeof(string), family, typeof(string), style);
        }
        public bool IsScalable(string family) {
            return (bool) interceptor.Invoke("isScalable$", "isScalable(const QString&) const", typeof(bool), typeof(string), family);
        }
        public bool IsFixedPitch(string family, string style) {
            return (bool) interceptor.Invoke("isFixedPitch$$", "isFixedPitch(const QString&, const QString&) const", typeof(bool), typeof(string), family, typeof(string), style);
        }
        public bool IsFixedPitch(string family) {
            return (bool) interceptor.Invoke("isFixedPitch$", "isFixedPitch(const QString&) const", typeof(bool), typeof(string), family);
        }
        public bool Italic(string family, string style) {
            return (bool) interceptor.Invoke("italic$$", "italic(const QString&, const QString&) const", typeof(bool), typeof(string), family, typeof(string), style);
        }
        public bool Bold(string family, string style) {
            return (bool) interceptor.Invoke("bold$$", "bold(const QString&, const QString&) const", typeof(bool), typeof(string), family, typeof(string), style);
        }
        public int Weight(string family, string style) {
            return (int) interceptor.Invoke("weight$$", "weight(const QString&, const QString&) const", typeof(int), typeof(string), family, typeof(string), style);
        }
        ~QFontDatabase() {
            interceptor.Invoke("~QFontDatabase", "~QFontDatabase()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QFontDatabase", "~QFontDatabase()", typeof(void));
        }
        public static List<int> StandardSizes() {
            return (List<int>) staticInterceptor.Invoke("standardSizes", "standardSizes()", typeof(List<int>));
        }
        public static string WritingSystemName(QFontDatabase.WritingSystem writingSystem) {
            return (string) staticInterceptor.Invoke("writingSystemName$", "writingSystemName(QFontDatabase::WritingSystem)", typeof(string), typeof(QFontDatabase.WritingSystem), writingSystem);
        }
        public static string WritingSystemSample(QFontDatabase.WritingSystem writingSystem) {
            return (string) staticInterceptor.Invoke("writingSystemSample$", "writingSystemSample(QFontDatabase::WritingSystem)", typeof(string), typeof(QFontDatabase.WritingSystem), writingSystem);
        }
        public static int AddApplicationFont(string fileName) {
            return (int) staticInterceptor.Invoke("addApplicationFont$", "addApplicationFont(const QString&)", typeof(int), typeof(string), fileName);
        }
        public static int AddApplicationFontFromData(QByteArray fontData) {
            return (int) staticInterceptor.Invoke("addApplicationFontFromData#", "addApplicationFontFromData(const QByteArray&)", typeof(int), typeof(QByteArray), fontData);
        }
        public static List<string> ApplicationFontFamilies(int id) {
            return (List<string>) staticInterceptor.Invoke("applicationFontFamilies$", "applicationFontFamilies(int)", typeof(List<string>), typeof(int), id);
        }
        public static bool RemoveApplicationFont(int id) {
            return (bool) staticInterceptor.Invoke("removeApplicationFont$", "removeApplicationFont(int)", typeof(bool), typeof(int), id);
        }
        public static bool RemoveAllApplicationFonts() {
            return (bool) staticInterceptor.Invoke("removeAllApplicationFonts", "removeAllApplicationFonts()", typeof(bool));
        }
        public static bool SupportsThreadedFontRendering() {
            return (bool) staticInterceptor.Invoke("supportsThreadedFontRendering", "supportsThreadedFontRendering()", typeof(bool));
        }
    }
}