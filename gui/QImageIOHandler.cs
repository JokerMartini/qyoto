//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QImageIOHandler")]
    public abstract class QImageIOHandler : Object {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QImageIOHandler(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QImageIOHandler), this);
        }
        public enum ImageOption {
            Size = 0,
            ClipRect = 1,
            Description = 2,
            ScaledClipRect = 3,
            ScaledSize = 4,
            CompressionRatio = 5,
            Gamma = 6,
            Quality = 7,
            Name = 8,
            SubType = 9,
            IncrementalReading = 10,
            Endianness = 11,
            Animation = 12,
            BackgroundColor = 13,
            ImageFormat = 14,
        }
        // QImageIOHandler* QImageIOHandler(QImageIOHandlerPrivate& arg1); >>>> NOT CONVERTED
        public QImageIOHandler() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QImageIOHandler", "QImageIOHandler()", typeof(void));
        }
        public void SetDevice(QIODevice device) {
            interceptor.Invoke("setDevice#", "setDevice(QIODevice*)", typeof(void), typeof(QIODevice), device);
        }
        public QIODevice Device() {
            return (QIODevice) interceptor.Invoke("device", "device() const", typeof(QIODevice));
        }
        public void SetFormat(QByteArray format) {
            interceptor.Invoke("setFormat#", "setFormat(const QByteArray&)", typeof(void), typeof(QByteArray), format);
        }
        public QByteArray Format() {
            return (QByteArray) interceptor.Invoke("format", "format() const", typeof(QByteArray));
        }
        [SmokeMethod("name() const")]
        public virtual QByteArray Name() {
            return (QByteArray) interceptor.Invoke("name", "name() const", typeof(QByteArray));
        }
        [SmokeMethod("canRead() const")]
        public abstract bool CanRead();
        [SmokeMethod("read(QImage*)")]
        public abstract bool Read(QImage image);
        [SmokeMethod("write(const QImage&)")]
        public virtual bool Write(QImage image) {
            return (bool) interceptor.Invoke("write#", "write(const QImage&)", typeof(bool), typeof(QImage), image);
        }
        [SmokeMethod("option(QImageIOHandler::ImageOption) const")]
        public virtual QVariant Option(QImageIOHandler.ImageOption option) {
            return (QVariant) interceptor.Invoke("option$", "option(QImageIOHandler::ImageOption) const", typeof(QVariant), typeof(QImageIOHandler.ImageOption), option);
        }
        [SmokeMethod("setOption(QImageIOHandler::ImageOption, const QVariant&)")]
        public virtual void SetOption(QImageIOHandler.ImageOption option, QVariant value) {
            interceptor.Invoke("setOption$#", "setOption(QImageIOHandler::ImageOption, const QVariant&)", typeof(void), typeof(QImageIOHandler.ImageOption), option, typeof(QVariant), value);
        }
        [SmokeMethod("supportsOption(QImageIOHandler::ImageOption) const")]
        public virtual bool SupportsOption(QImageIOHandler.ImageOption option) {
            return (bool) interceptor.Invoke("supportsOption$", "supportsOption(QImageIOHandler::ImageOption) const", typeof(bool), typeof(QImageIOHandler.ImageOption), option);
        }
        [SmokeMethod("jumpToNextImage()")]
        public virtual bool JumpToNextImage() {
            return (bool) interceptor.Invoke("jumpToNextImage", "jumpToNextImage()", typeof(bool));
        }
        [SmokeMethod("jumpToImage(int)")]
        public virtual bool JumpToImage(int imageNumber) {
            return (bool) interceptor.Invoke("jumpToImage$", "jumpToImage(int)", typeof(bool), typeof(int), imageNumber);
        }
        [SmokeMethod("loopCount() const")]
        public virtual int LoopCount() {
            return (int) interceptor.Invoke("loopCount", "loopCount() const", typeof(int));
        }
        [SmokeMethod("imageCount() const")]
        public virtual int ImageCount() {
            return (int) interceptor.Invoke("imageCount", "imageCount() const", typeof(int));
        }
        [SmokeMethod("nextImageDelay() const")]
        public virtual int NextImageDelay() {
            return (int) interceptor.Invoke("nextImageDelay", "nextImageDelay() const", typeof(int));
        }
        [SmokeMethod("currentImageNumber() const")]
        public virtual int CurrentImageNumber() {
            return (int) interceptor.Invoke("currentImageNumber", "currentImageNumber() const", typeof(int));
        }
        [SmokeMethod("currentImageRect() const")]
        public virtual QRect CurrentImageRect() {
            return (QRect) interceptor.Invoke("currentImageRect", "currentImageRect() const", typeof(QRect));
        }
    }
}
