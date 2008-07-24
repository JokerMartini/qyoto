//Auto-generated by kalyptus. DO NOT EDIT.
namespace KTextEditor {
    using Kimono;
    using System;
    using Qyoto;
    /// <remarks>
    ///  \brief Config page interface for the Editor.
    ///  \section configpage_intro Introduction
    ///  The class ConfigPage represents a config page of the KTextEditor.Editor.
    ///  The Editor's config pages are usually embedded into a dialog that shows
    ///  buttons like \e Defaults, \e Reset and \e Apply. If one of the buttons is
    ///  clicked and the condig page sent the signal changed() beforehand the
    ///  Editor will call the corresponding slot, either defaults(), reset() or
    ///  apply().
    ///  \see KTextEditor.Editor
    ///  \author Christoph Cullmann \<cullmann@kde.org\>
    ///   See <see cref="IConfigPageSignals"></see> for signals emitted by ConfigPage
    /// </remarks>        <short>    \brief Config page interface for the Editor.</short>
    [SmokeClass("KTextEditor::ConfigPage")]
    public class ConfigPage : QWidget, IDisposable {
        protected ConfigPage(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(ConfigPage), this);
        }
        /// <remarks>
        ///  Constructor.
        ///  Create a new config page with <pre>parent</pre>.
        ///  \param parent parent widget
        ///      </remarks>        <short>    Constructor.</short>
        public ConfigPage(QWidget parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("ConfigPage#", "ConfigPage(QWidget*)", typeof(void), typeof(QWidget), parent);
        }
        /// <remarks>
        ///  This slot is called whenever the button \e Apply or \e OK was clicked.
        ///  Apply the changed settings made in the config page now.
        ///      </remarks>        <short>    This slot is called whenever the button \e Apply or \e OK was clicked.</short>
        [Q_SLOT("void apply()")]
        [SmokeMethod("apply()")]
        public virtual void Apply() {
            interceptor.Invoke("apply", "apply()", typeof(void));
        }
        /// <remarks>
        ///  This slot is called whenever the button \e Reset was clicked.
        ///  Reset the config page settings to the initial state.
        ///      </remarks>        <short>    This slot is called whenever the button \e Reset was clicked.</short>
        [Q_SLOT("void reset()")]
        [SmokeMethod("reset()")]
        public virtual void Reset() {
            interceptor.Invoke("reset", "reset()", typeof(void));
        }
        /// <remarks>
        ///  Sets default options
        ///  This slot is called whenever the button \e Defaults was clicked.
        ///  Set the config page settings to the default values.
        ///      </remarks>        <short>    Sets default options  This slot is called whenever the button \e Defaults was clicked.</short>
        [Q_SLOT("void defaults()")]
        [SmokeMethod("defaults()")]
        public virtual void Defaults() {
            interceptor.Invoke("defaults", "defaults()", typeof(void));
        }
        ~ConfigPage() {
            interceptor.Invoke("~ConfigPage", "~ConfigPage()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~ConfigPage", "~ConfigPage()", typeof(void));
        }
        protected new IConfigPageSignals Emit {
            get { return (IConfigPageSignals) Q_EMIT; }
        }
    }

    public interface IConfigPageSignals : IQWidgetSignals {
        /// <remarks>
        ///  Emit this signal whenever a config option changed.
        ///      </remarks>        <short>    Emit this signal whenever a config option changed.</short>
        [Q_SIGNAL("void changed()")]
        void Changed();
    }
}
