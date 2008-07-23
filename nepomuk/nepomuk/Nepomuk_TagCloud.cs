//Auto-generated by kalyptus. DO NOT EDIT.
namespace Nepomuk {
    using Kimono;
    using System;
    using Qyoto;
    /// <remarks>
    ///  Tag cloud widget that displays all tags stored in the
    ///  local Nepomuk store.
    ///       See <see cref="ITagCloudSignals"></see> for signals emitted by TagCloud
    /// </remarks>        <short>    Tag cloud widget that displays all tags stored in the  local Nepomuk store.</short>
    [SmokeClass("Nepomuk::TagCloud")]
    public class TagCloud : KTagCloudWidget, IDisposable {
        protected TagCloud(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(TagCloud), this);
        }
        /// <remarks>
        ///  Create a new TagCloud widget.
        ///  The widget will be populated immediately.
        ///          </remarks>        <short>    Create a new TagCloud widget.</short>
        public TagCloud(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("TagCloud#", "TagCloud(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        public TagCloud() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("TagCloud", "TagCloud()", typeof(void));
        }
        /// <remarks>
        ///  \return true if auto updating is enabled (the default).
        ///  \sa setAutoUpdate
        ///          </remarks>        <short>    \return true if auto updating is enabled (the default).</short>
        public bool AutoUpdate() {
            return (bool) interceptor.Invoke("autoUpdate", "autoUpdate() const", typeof(bool));
        }
        /// <remarks>
        ///  Update the tag cloud, ie. reload all tags from the store
        ///  and recalculate their importance.
        ///  There is no need to call this unless auto updating is
        ///  disabled.
        ///  \sa setAutoUpdate
        ///          </remarks>        <short>    Update the tag cloud, ie.</short>
        [Q_SLOT("void updateTags()")]
        public void UpdateTags() {
            interceptor.Invoke("updateTags", "updateTags()", typeof(void));
        }
        /// <remarks>
        ///  If auto updating is enabled the tag cloud is updated
        ///  regularly to keep in sync with the local Nepomuk store.
        ///  \sa updateTags
        ///          </remarks>        <short>    If auto updating is enabled the tag cloud is updated  regularly to keep in sync with the local Nepomuk store.</short>
        [Q_SLOT("void setAutoUpdate(bool)")]
        public void SetAutoUpdate(bool enable) {
            interceptor.Invoke("setAutoUpdate$", "setAutoUpdate(bool)", typeof(void), typeof(bool), enable);
        }
        ~TagCloud() {
            interceptor.Invoke("~TagCloud", "~TagCloud()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~TagCloud", "~TagCloud()", typeof(void));
        }
        protected new ITagCloudSignals Emit {
            get { return (ITagCloudSignals) Q_EMIT; }
        }
    }

    public interface ITagCloudSignals : IKTagCloudWidgetSignals {
        /// <remarks>
        ///  This signal is emitted whenever a tag is clicked.
        ///  \sa KTagCloudWidget.TagClicked
        ///          </remarks>        <short>    This signal is emitted whenever a tag is clicked.</short>
        [Q_SIGNAL("void tagClicked(Tag)")]
        void TagClicked(Nepomuk.Tag arg1);
    }
}