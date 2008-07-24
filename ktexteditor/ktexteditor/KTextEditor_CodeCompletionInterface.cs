//Auto-generated by kalyptus. DO NOT EDIT.
namespace KTextEditor {
    using Kimono;
    using System;
    using Qyoto;
    /// <remarks>
    ///  \brief Code completion extension interface for the View.
    ///  \ingroup kte_group_view_extensions
    ///  \section compiface_intro Introduction
    ///  The CodeCompletionInterface is designed to provide code completion
    ///  functionality for a KTextEditor.View. This interface provides the basic
    ///  mechanisms to display a list of completions, update this list according
    ///  to user input, and allow the user to select a completion.
    ///  Essentially, this provides an item view for the available completions. In
    ///  order to use this interface, you will need to implement a
    ///  CodeCompletionModel that generates the relevant completions given the
    ///  current input.
    ///  \section compiface_access Accessing the CodeCompletionInterface
    ///  The CodeCompletionInterface is an extension interface for a
    ///  View, i.e. the View inherits the interface \e provided that the
    ///  used KTextEditor library implements the interface. Use qobject_cast to
    ///  access the interface:
    ///  <pre>
    ///  // view is of type KTextEditor.View
    ///  KTextEditor.CodeCompletionInterface iface =
    ///      qobject_cast<KTextEditor.CodeCompletionInterface>( view );
    ///  if( iface ) {
    ///      // the implementation supports the interface
    ///      // do stuff
    ///  }
    ///  </pre>
    ///  \section compiface_usage Using the CodeCompletionInterface
    ///  The CodeCompletionInterface can be used in different ways, which we
    ///  will call "automatic", and "manual".
    ///  \subsection compiface_automatic Automatic
    ///  In automatic mode, the CodeCompletionInterface will take care of
    ///  starting and aborting the generation of code completions as
    ///  appropriate, when the users inserts or changes text.
    ///  To use the interface in this way, first register a CodeCompletionModel
    ///  using registerCompletionModel(). Now call setAutomaticCompletionEnabled()
    ///  to enabled automatic completions.
    ///  \subsection compiface_manual Manual
    ///  If you need more control over when code completions get shown or not,
    ///  or which fragment of the text should be considered as the basis for
    ///  generated completions, proceed as follows:
    ///  Call setAutomaticCompletionEnabled(false) to disable automatic
    ///  completions. To start the generation of code completions for the current
    ///  word, call startCompletion(), with the appropriate parameters. To hide the
    ///  generated completions, use abortCompletion().
    ///  \see KTextEditor.View, KTextEditor.CodeCompletionModel
    ///  </remarks>        <short>    \brief Code completion extension interface for the View.</short>
    [SmokeClass("KTextEditor::CodeCompletionInterface")]
    public class CodeCompletionInterface : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected CodeCompletionInterface(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(CodeCompletionInterface), this);
        }
        /// <remarks>
        ///  Query whether the code completion box is currently displayed.
        ///      </remarks>        <short>    Query whether the code completion box is currently displayed.</short>
        [SmokeMethod("isCompletionActive() const")]
        public virtual bool IsCompletionActive() {
            return (bool) interceptor.Invoke("isCompletionActive", "isCompletionActive() const", typeof(bool));
        }
        /// <remarks>
        ///  Invoke code completion over a given range, with a specific \a model.
        ///      </remarks>        <short>    Invoke code completion over a given range, with a specific \a model.</short>
        [SmokeMethod("startCompletion(const KTextEditor::Range&, KTextEditor::CodeCompletionModel*)")]
        public virtual void StartCompletion(KTextEditor.Range word, KTextEditor.CodeCompletionModel model) {
            interceptor.Invoke("startCompletion##", "startCompletion(const KTextEditor::Range&, KTextEditor::CodeCompletionModel*)", typeof(void), typeof(KTextEditor.Range), word, typeof(KTextEditor.CodeCompletionModel), model);
        }
        /// <remarks>
        ///  Abort the currently displayed code completion without executing any currently
        ///  selected completion. This is safe, even when the completion box is not currently
        ///  active.
        ///  \see isCompletionActive()
        ///      </remarks>        <short>    Abort the currently displayed code completion without executing any currently  selected completion.</short>
        [SmokeMethod("abortCompletion()")]
        public virtual void AbortCompletion() {
            interceptor.Invoke("abortCompletion", "abortCompletion()", typeof(void));
        }
        /// <remarks>
        ///  Force execution of the currently selected completion, and hide the code completion
        ///  box.
        ///      </remarks>        <short>    Force execution of the currently selected completion, and hide the code completion  box.</short>
        [SmokeMethod("forceCompletion()")]
        public virtual void ForceCompletion() {
            interceptor.Invoke("forceCompletion", "forceCompletion()", typeof(void));
        }
        /// <remarks>
        ///  Register a new code completion <pre>model</pre>.
        ///  \param model new completion model
        ///  \see unregisterCompletionModel()
        ///      </remarks>        <short>    Register a new code completion \p model.</short>
        [SmokeMethod("registerCompletionModel(KTextEditor::CodeCompletionModel*)")]
        public virtual void RegisterCompletionModel(KTextEditor.CodeCompletionModel model) {
            interceptor.Invoke("registerCompletionModel#", "registerCompletionModel(KTextEditor::CodeCompletionModel*)", typeof(void), typeof(KTextEditor.CodeCompletionModel), model);
        }
        /// <remarks>
        ///  Unregister a code completion <pre>model</pre>.
        ///  \param model the model that should be unregistered
        ///  \see registerCompletionModel()
        ///      </remarks>        <short>    Unregister a code completion \p model.</short>
        [SmokeMethod("unregisterCompletionModel(KTextEditor::CodeCompletionModel*)")]
        public virtual void UnregisterCompletionModel(KTextEditor.CodeCompletionModel model) {
            interceptor.Invoke("unregisterCompletionModel#", "unregisterCompletionModel(KTextEditor::CodeCompletionModel*)", typeof(void), typeof(KTextEditor.CodeCompletionModel), model);
        }
        /// <remarks>
        ///  Determine the status of automatic code completion invocation.
        ///      </remarks>        <short>    Determine the status of automatic code completion invocation.</short>
        [SmokeMethod("isAutomaticInvocationEnabled() const")]
        public virtual bool IsAutomaticInvocationEnabled() {
            return (bool) interceptor.Invoke("isAutomaticInvocationEnabled", "isAutomaticInvocationEnabled() const", typeof(bool));
        }
        /// <remarks>
        ///  Enable or disable automatic code completion invocation.
        ///      </remarks>        <short>    Enable or disable automatic code completion invocation.</short>
        [SmokeMethod("setAutomaticInvocationEnabled(bool)")]
        public virtual void SetAutomaticInvocationEnabled(bool enabled) {
            interceptor.Invoke("setAutomaticInvocationEnabled$", "setAutomaticInvocationEnabled(bool)", typeof(void), typeof(bool), enabled);
        }
        [SmokeMethod("setAutomaticInvocationEnabled()")]
        public virtual void SetAutomaticInvocationEnabled() {
            interceptor.Invoke("setAutomaticInvocationEnabled", "setAutomaticInvocationEnabled()", typeof(void));
        }
        public CodeCompletionInterface() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("CodeCompletionInterface", "CodeCompletionInterface()", typeof(void));
        }
        ~CodeCompletionInterface() {
            interceptor.Invoke("~CodeCompletionInterface", "~CodeCompletionInterface()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~CodeCompletionInterface", "~CodeCompletionInterface()", typeof(void));
        }
    }
}
