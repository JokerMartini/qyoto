//Auto-generated by kalyptus. DO NOT EDIT.
namespace KTextEditor {
    using Kimono;
    using System;
    using Qyoto;
    using System.Text;
    using System.Collections.Generic;
    /// <remarks>
    ///  \brief An Editor command line command.
    ///  \section cmd_intro Introduction
    ///  The Command class represents a command for the editor command line. A
    ///  command simply consists of a string, for example \e find. To register a
    ///  command use CommandInterface.RegisterCommand(). The Editor itself queries
    ///  the command for a list of accepted strings/commands by calling cmds().
    ///  If the command gets invoked the function exec() is called, i.e. you have
    ///  to implement the \e reaction in exec(). Whenever the user needs help for
    ///  a command help() is called.
    ///  \section cmd_information Command Information
    ///  To provide reasonable information about a specific command there are the
    ///  following accessor functions for a given command string:
    ///   - name() returns a label
    ///   - description() returns a descriptive text
    ///   - category() returns a category into which the command fits.
    ///  These getters allow KTextEditor implementations to plug commands into menus
    ///  and toolbars, so that a user can assign shortcuts.
    ///  \section cmd_extension Command Extensions
    ///  If your command needs to interactively react on changes while the user is
    ///  typing text - look at the \e ifind command in Kate for example - you have
    ///  to additionally derive your command from the class CommandExtension. The
    ///  command extension provides methods to give help on \e flags or add a
    ///  KCompletion object and process the typed text interactively.
    ///  \see KTextEditor.CommandInterface, KTextEditor.CommandExtension
    ///  \author Christoph Cullmann \<cullmann@kde.org\>
    ///  </remarks>        <short>    \brief An Editor command line command.</short>
    [SmokeClass("KTextEditor::Command")]
    public abstract class Command : Object {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected Command(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(Command), this);
        }
        /// <remarks>
        ///  Return a list of strings a command may begin with.
        ///  A string is the start part of a pure text which can be handled by this
        ///  command, i.e. for the command s/sdl/sdf/g the corresponding string is
        ///  simply \e s, and for char:1212 simply \e char.
        ///  \return list of supported commands
        ///      </remarks>        <short>    Return a list of strings a command may begin with.</short>
        [SmokeMethod("cmds()")]
        public virtual List<string> Cmds() {
            return (List<string>) interceptor.Invoke("cmds", "cmds()", typeof(List<string>));
        }
        /// <remarks>
        ///  Execute the command for the given <pre>view</pre> and <pre>cmd</pre> string.
        ///  Return the success value and a <pre>msg</pre> for status. As example we
        ///  consider a replace command. The replace command would return the number
        ///  of replaced strings as <pre>msg</pre>, like "16 replacements made." If an error
        ///  occurred in the usage it would return \e false and set the <pre>msg</pre> to
        ///  something like "missing argument." or such.
        ///  \return \e true on success, otherwise \e false
        ///      </remarks>        <short>    Execute the command for the given \p view and \p cmd string.</short>
        [SmokeMethod("exec(KTextEditor::View*, const QString&, QString&)")]
        public virtual bool Exec(KTextEditor.View view, string cmd, StringBuilder msg) {
            return (bool) interceptor.Invoke("exec#$$", "exec(KTextEditor::View*, const QString&, QString&)", typeof(bool), typeof(KTextEditor.View), view, typeof(string), cmd, typeof(StringBuilder), msg);
        }
        /// <remarks>
        ///  Shows help for the given <pre>view</pre> and <pre>cmd</pre> string.
        ///  If your command has a help text for <pre>cmd</pre> you have to return \e true
        ///  and set the <pre>msg</pre> to a meaningful text. The help text is embedded by
        ///  the Editor in a Qt.RichText enabled widget, e.g. a QToolTip.
        ///  \return \e true if your command has a help text, otherwise \e false
        ///      </remarks>        <short>    Shows help for the given \p view and \p cmd string.</short>
        [SmokeMethod("help(KTextEditor::View*, const QString&, QString&)")]
        public virtual bool Help(KTextEditor.View view, string cmd, StringBuilder msg) {
            return (bool) interceptor.Invoke("help#$$", "help(KTextEditor::View*, const QString&, QString&)", typeof(bool), typeof(KTextEditor.View), view, typeof(string), cmd, typeof(StringBuilder), msg);
        }
        public Command() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("Command", "Command()", typeof(void));
        }
    }
}
