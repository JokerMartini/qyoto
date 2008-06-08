//Auto-generated by kalyptus. DO NOT EDIT.
namespace KStandardShortcut {

	using Kimono;
	using System;
	using Qyoto;

	/// <remarks>
	///  Defines the identifier of all standard accelerators.
	///    </remarks>		<short>    Defines the identifier of all standard accelerators.</short>
	public enum StandardShortcut {
		AccelNone = 0,
		Open = 1,
		New = 2,
		Close = 3,
		Save = 4,
		Print = 5,
		Quit = 6,
		Undo = 7,
		Redo = 8,
		Cut = 9,
		Copy = 10,
		Paste = 11,
		PasteSelection = 12,
		SelectAll = 13,
		Deselect = 14,
		DeleteWordBack = 15,
		DeleteWordForward = 16,
		Find = 17,
		FindNext = 18,
		FindPrev = 19,
		Replace = 20,
		Home = 21,
		Begin = 22,
		End = 23,
		Prior = 24,
		Next = 25,
		Up = 26,
		Back = 27,
		Forward = 28,
		Reload = 29,
		BeginningOfLine = 30,
		EndOfLine = 31,
		GotoLine = 32,
		BackwardWord = 33,
		ForwardWord = 34,
		AddBookmark = 35,
		ZoomIn = 36,
		ZoomOut = 37,
		FullScreen = 38,
		ShowMenubar = 39,
		TabNext = 40,
		TabPrev = 41,
		Help = 42,
		WhatsThis = 43,
		TextCompletion = 44,
		PrevCompletion = 45,
		NextCompletion = 46,
		SubstringCompletion = 47,
		RotateUp = 48,
		RotateDown = 49,
		StandardShortcutCount = 50,
	}


	/// <remarks>
	///  \namespace KStandardShortcut
	///  Convenient methods for access to the common accelerator keys in
	///  the key configuration. These are the standard keybindings that should
	///  be used in all KDE applications. They will be configurable,
	///  so do not hardcode the default behavior.
	///  </remarks>		<short>    \namespace KStandardShortcut  Convenient methods for access to the common accelerator keys in  the key configuration.</short>

	[SmokeClass("KStandardShortcut")]
	public class Global : Object {
		protected SmokeInvocation interceptor = null;
		private static SmokeInvocation staticInterceptor = null;
		static Global() {
			staticInterceptor = new SmokeInvocationKDE(typeof(Global), null);
		}
		/// <remarks>
		///  Returns the keybinding for <code>accel.</code>
		///  On X11, if QApplication was initialized with GUI disabled, the
		///  default keybinding will always be returned.
		/// <param> name="id" the id of the accelerator
		///    </param></remarks>		<short>    Returns the keybinding for <code>accel.</code></short>
		public static KShortcut Shortcut(KStandardShortcut.StandardShortcut id) {
			return (KShortcut) staticInterceptor.Invoke("shortcut$", "shortcut(KStandardShortcut::StandardShortcut)", typeof(KShortcut), typeof(KStandardShortcut.StandardShortcut), id);
		}
		/// <remarks>
		///  Returns a unique name for the given accel.
		/// <param> name="id" the id of the accelerator
		/// </param></remarks>		<return> the unique name of the accelerator
		///    </return>
		/// 		<short>    Returns a unique name for the given accel.</short>
		public static string Name(KStandardShortcut.StandardShortcut id) {
			return (string) staticInterceptor.Invoke("name$", "name(KStandardShortcut::StandardShortcut)", typeof(string), typeof(KStandardShortcut.StandardShortcut), id);
		}
		/// <remarks>
		///  Returns a localized label for user-visible display.
		/// <param> name="id" the id of the accelerator
		/// </param></remarks>		<return> a localized label for the accelerator
		///    </return>
		/// 		<short>    Returns a localized label for user-visible display.</short>
		public static string Label(KStandardShortcut.StandardShortcut id) {
			return (string) staticInterceptor.Invoke("label$", "label(KStandardShortcut::StandardShortcut)", typeof(string), typeof(KStandardShortcut.StandardShortcut), id);
		}
		/// <remarks>
		///  Returns an extended WhatsThis description for the given accelerator.
		/// <param> name="id" the id of the accelerator
		/// </param></remarks>		<return> a localized description of the accelerator
		///    </return>
		/// 		<short>    Returns an extended WhatsThis description for the given accelerator.</short>
		public static string WhatsThis(KStandardShortcut.StandardShortcut id) {
			return (string) staticInterceptor.Invoke("whatsThis$", "whatsThis(KStandardShortcut::StandardShortcut)", typeof(string), typeof(KStandardShortcut.StandardShortcut), id);
		}
		/// <remarks>
		///  Return the StandardShortcut id of the standard accel action which
		///  uses this key sequence, or AccelNone if none of them do.
		///  This is used by class KKeyChooser.
		/// <param> name="keySeq" the key sequence to search
		/// </param></remarks>		<return> the id of the standard accelerator, or AccelNone if there
		///           is none
		///    </return>
		/// 		<short>    Return the StandardShortcut id of the standard accel action which  uses this key sequence, or AccelNone if none of them do.</short>
		public static KStandardShortcut.StandardShortcut Find(QKeySequence keySeq) {
			return (KStandardShortcut.StandardShortcut) staticInterceptor.Invoke("find#", "find(const QKeySequence&)", typeof(KStandardShortcut.StandardShortcut), typeof(QKeySequence), keySeq);
		}
		/// <remarks>
		///  Return the StandardShortcut id of the standard accel action which
		///  has \a keyName as its name, or AccelNone if none of them do.
		///  This is used by class KKeyChooser.
		/// <param> name="keyName" the key sequence to search
		/// </param></remarks>		<return> the id of the standard accelerator, or AccelNone if there
		///           is none
		///    </return>
		/// 		<short>    Return the StandardShortcut id of the standard accel action which  has \a keyName as its name, or AccelNone if none of them do.</short>
		public static KStandardShortcut.StandardShortcut Find(string keyName) {
			return (KStandardShortcut.StandardShortcut) staticInterceptor.Invoke("find$", "find(const char*)", typeof(KStandardShortcut.StandardShortcut), typeof(string), keyName);
		}
		/// <remarks>
		///  Returns the hardcoded default shortcut for <code>id.</code>
		///  This does not take into account the user's configuration.
		/// <param> name="id" the id of the accelerator
		/// </param></remarks>		<return> the default shortcut of the accelerator
		///    </return>
		/// 		<short>    Returns the hardcoded default shortcut for <code>id.</code></short>
		public static KShortcut HardcodedDefaultShortcut(KStandardShortcut.StandardShortcut id) {
			return (KShortcut) staticInterceptor.Invoke("hardcodedDefaultShortcut$", "hardcodedDefaultShortcut(KStandardShortcut::StandardShortcut)", typeof(KShortcut), typeof(KStandardShortcut.StandardShortcut), id);
		}
		/// <remarks>
		///  Saves the new shortcut \a cut for standard accel \a id.
		///    </remarks>		<short>    Saves the new shortcut \a cut for standard accel \a id.</short>
		public static void SaveShortcut(KStandardShortcut.StandardShortcut id, KShortcut newShortcut) {
			staticInterceptor.Invoke("saveShortcut$#", "saveShortcut(KStandardShortcut::StandardShortcut, const KShortcut&)", typeof(void), typeof(KStandardShortcut.StandardShortcut), id, typeof(KShortcut), newShortcut);
		}
		/// <remarks>
		///  Open file. Default: Ctrl-o
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Open file.</short>
		public static KShortcut Open() {
			return (KShortcut) staticInterceptor.Invoke("open", "open()", typeof(KShortcut));
		}
		/// <remarks>
		///  Create a new document (or whatever). Default: Ctrl-n
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Create a new document (or whatever).</short>
		public static KShortcut OpenNew() {
			return (KShortcut) staticInterceptor.Invoke("openNew", "openNew()", typeof(KShortcut));
		}
		/// <remarks>
		///  Close current document. Default: Ctrl-w
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Close current document.</short>
		public static KShortcut Close() {
			return (KShortcut) staticInterceptor.Invoke("close", "close()", typeof(KShortcut));
		}
		/// <remarks>
		///  Save current document. Default: Ctrl-s
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Save current document.</short>
		public static KShortcut Save() {
			return (KShortcut) staticInterceptor.Invoke("save", "save()", typeof(KShortcut));
		}
		/// <remarks>
		///  Print current document. Default: Ctrl-p
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Print current document.</short>
		public static KShortcut Print() {
			return (KShortcut) staticInterceptor.Invoke("print", "print()", typeof(KShortcut));
		}
		/// <remarks>
		///  Quit the program. Default: Ctrl-q
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Quit the program.</short>
		public static KShortcut Quit() {
			return (KShortcut) staticInterceptor.Invoke("quit", "quit()", typeof(KShortcut));
		}
		/// <remarks>
		///  Undo last operation. Default: Ctrl-z
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Undo last operation.</short>
		public static KShortcut Undo() {
			return (KShortcut) staticInterceptor.Invoke("undo", "undo()", typeof(KShortcut));
		}
		/// <remarks>
		///  Redo. Default: Shift-Ctrl-z
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Redo.</short>
		public static KShortcut Redo() {
			return (KShortcut) staticInterceptor.Invoke("redo", "redo()", typeof(KShortcut));
		}
		/// <remarks>
		///  Cut selected area and store it in the clipboard. Default: Ctrl-x
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Cut selected area and store it in the clipboard.</short>
		public static KShortcut Cut() {
			return (KShortcut) staticInterceptor.Invoke("cut", "cut()", typeof(KShortcut));
		}
		/// <remarks>
		///  Copy selected area into the clipboard. Default: Ctrl-c
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Copy selected area into the clipboard.</short>
		public static KShortcut Copy() {
			return (KShortcut) staticInterceptor.Invoke("copy", "copy()", typeof(KShortcut));
		}
		/// <remarks>
		///  Paste contents of clipboard at mouse/cursor position. Default: Ctrl-v
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Paste contents of clipboard at mouse/cursor position.</short>
		public static KShortcut Paste() {
			return (KShortcut) staticInterceptor.Invoke("paste", "paste()", typeof(KShortcut));
		}
		/// <remarks>
		///  Paste the selection at mouse/cursor position. Default: Ctrl-Shift-Insert
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Paste the selection at mouse/cursor position.</short>
		public static KShortcut PasteSelection() {
			return (KShortcut) staticInterceptor.Invoke("pasteSelection", "pasteSelection()", typeof(KShortcut));
		}
		/// <remarks>
		///  Reload. Default: Ctrl-A
		/// </remarks>		<return> the shortcut of the standard accelerator
		/// </return>
		/// 		<short>    Reload.</short>
		public static KShortcut SelectAll() {
			return (KShortcut) staticInterceptor.Invoke("selectAll", "selectAll()", typeof(KShortcut));
		}
		/// <remarks>
		///  Delete a word back from mouse/cursor position. Default: Ctrl-Backspace
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Delete a word back from mouse/cursor position.</short>
		public static KShortcut DeleteWordBack() {
			return (KShortcut) staticInterceptor.Invoke("deleteWordBack", "deleteWordBack()", typeof(KShortcut));
		}
		/// <remarks>
		///  Delete a word forward from mouse/cursor position. Default: Ctrl-Delete
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Delete a word forward from mouse/cursor position.</short>
		public static KShortcut DeleteWordForward() {
			return (KShortcut) staticInterceptor.Invoke("deleteWordForward", "deleteWordForward()", typeof(KShortcut));
		}
		/// <remarks>
		///  Find, search. Default: Ctrl-f
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Find, search.</short>
		public static KShortcut Find() {
			return (KShortcut) staticInterceptor.Invoke("find", "find()", typeof(KShortcut));
		}
		/// <remarks>
		///  Find/search next. Default: F3
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Find/search next.</short>
		public static KShortcut FindNext() {
			return (KShortcut) staticInterceptor.Invoke("findNext", "findNext()", typeof(KShortcut));
		}
		/// <remarks>
		///  Find/search previous. Default: Shift-F3
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Find/search previous.</short>
		public static KShortcut FindPrev() {
			return (KShortcut) staticInterceptor.Invoke("findPrev", "findPrev()", typeof(KShortcut));
		}
		/// <remarks>
		///  Find and replace matches. Default: Ctrl-r
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Find and replace matches.</short>
		public static KShortcut Replace() {
			return (KShortcut) staticInterceptor.Invoke("replace", "replace()", typeof(KShortcut));
		}
		/// <remarks>
		///  Zoom in. Default: Ctrl-Plus
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Zoom in.</short>
		public static KShortcut ZoomIn() {
			return (KShortcut) staticInterceptor.Invoke("zoomIn", "zoomIn()", typeof(KShortcut));
		}
		/// <remarks>
		///  Zoom out. Default: Ctrl-Minus
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Zoom out.</short>
		public static KShortcut ZoomOut() {
			return (KShortcut) staticInterceptor.Invoke("zoomOut", "zoomOut()", typeof(KShortcut));
		}
		/// <remarks>
		///  Goto home page. Default: Alt-Home
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Goto home page.</short>
		public static KShortcut Home() {
			return (KShortcut) staticInterceptor.Invoke("home", "home()", typeof(KShortcut));
		}
		/// <remarks>
		///  Goto beginning of the document. Default: Ctrl-Home
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Goto beginning of the document.</short>
		public static KShortcut Begin() {
			return (KShortcut) staticInterceptor.Invoke("begin", "begin()", typeof(KShortcut));
		}
		/// <remarks>
		///  Goto end of the document. Default: Ctrl-End
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Goto end of the document.</short>
		public static KShortcut End() {
			return (KShortcut) staticInterceptor.Invoke("end", "end()", typeof(KShortcut));
		}
		/// <remarks>
		///  Goto beginning of current line. Default: Home
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Goto beginning of current line.</short>
		public static KShortcut BeginningOfLine() {
			return (KShortcut) staticInterceptor.Invoke("beginningOfLine", "beginningOfLine()", typeof(KShortcut));
		}
		/// <remarks>
		///  Goto end of current line. Default: End
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Goto end of current line.</short>
		public static KShortcut EndOfLine() {
			return (KShortcut) staticInterceptor.Invoke("endOfLine", "endOfLine()", typeof(KShortcut));
		}
		/// <remarks>
		///  Scroll up one page. Default: Prior
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Scroll up one page.</short>
		public static KShortcut Prior() {
			return (KShortcut) staticInterceptor.Invoke("prior", "prior()", typeof(KShortcut));
		}
		/// <remarks>
		///  Scroll down one page. Default: Next
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Scroll down one page.</short>
		public static KShortcut Next() {
			return (KShortcut) staticInterceptor.Invoke("next", "next()", typeof(KShortcut));
		}
		/// <remarks>
		///  Go to line. Default: Ctrl+G
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Go to line.</short>
		public static KShortcut GotoLine() {
			return (KShortcut) staticInterceptor.Invoke("gotoLine", "gotoLine()", typeof(KShortcut));
		}
		/// <remarks>
		///  Add current page to bookmarks. Default: Ctrl+B
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Add current page to bookmarks.</short>
		public static KShortcut AddBookmark() {
			return (KShortcut) staticInterceptor.Invoke("addBookmark", "addBookmark()", typeof(KShortcut));
		}
		/// <remarks>
		///  Next Tab. Default: Ctrl-<
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Next Tab.</short>
		public static KShortcut TabNext() {
			return (KShortcut) staticInterceptor.Invoke("tabNext", "tabNext()", typeof(KShortcut));
		}
		/// <remarks>
		///  Previous Tab. Default: Ctrl->
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Previous Tab.</short>
		public static KShortcut TabPrev() {
			return (KShortcut) staticInterceptor.Invoke("tabPrev", "tabPrev()", typeof(KShortcut));
		}
		/// <remarks>
		///  Full Screen Mode. Default: Ctrl+Shift+F
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Full Screen Mode.</short>
		public static KShortcut FullScreen() {
			return (KShortcut) staticInterceptor.Invoke("fullScreen", "fullScreen()", typeof(KShortcut));
		}
		/// <remarks>
		///  Help the user in the current situation. Default: F1
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Help the user in the current situation.</short>
		public static KShortcut Help() {
			return (KShortcut) staticInterceptor.Invoke("help", "help()", typeof(KShortcut));
		}
		/// <remarks>
		///  Complete text in input widgets. Default Ctrl+E
		/// </remarks>		<return> the shortcut of the standard accelerator
		/// </return>
		/// 		<short>    Complete text in input widgets.</short>
		public static KShortcut Completion() {
			return (KShortcut) staticInterceptor.Invoke("completion", "completion()", typeof(KShortcut));
		}
		/// <remarks>
		///  Iterate through a list when completion returns
		///  multiple items. Default: Ctrl+Up
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Iterate through a list when completion returns  multiple items.</short>
		public static KShortcut PrevCompletion() {
			return (KShortcut) staticInterceptor.Invoke("prevCompletion", "prevCompletion()", typeof(KShortcut));
		}
		/// <remarks>
		///  Iterate through a list when completion returns
		///  multiple items. Default: Ctrl+Down
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Iterate through a list when completion returns  multiple items.</short>
		public static KShortcut NextCompletion() {
			return (KShortcut) staticInterceptor.Invoke("nextCompletion", "nextCompletion()", typeof(KShortcut));
		}
		/// <remarks>
		///  Find a string within another string or list of strings.
		///  Default: Ctrl-T
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Find a string within another string or list of strings.</short>
		public static KShortcut SubstringCompletion() {
			return (KShortcut) staticInterceptor.Invoke("substringCompletion", "substringCompletion()", typeof(KShortcut));
		}
		/// <remarks>
		///  Help users iterate through a list of entries. Default: Up
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Help users iterate through a list of entries.</short>
		public static KShortcut RotateUp() {
			return (KShortcut) staticInterceptor.Invoke("rotateUp", "rotateUp()", typeof(KShortcut));
		}
		/// <remarks>
		///  Help users iterate through a list of entries. Default: Down
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Help users iterate through a list of entries.</short>
		public static KShortcut RotateDown() {
			return (KShortcut) staticInterceptor.Invoke("rotateDown", "rotateDown()", typeof(KShortcut));
		}
		/// <remarks>
		///  What's This button. Default: Shift+F1
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    What's This button.</short>
		public static KShortcut WhatsThis() {
			return (KShortcut) staticInterceptor.Invoke("whatsThis", "whatsThis()", typeof(KShortcut));
		}
		/// <remarks>
		///  Reload. Default: F5
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Reload.</short>
		public static KShortcut Reload() {
			return (KShortcut) staticInterceptor.Invoke("reload", "reload()", typeof(KShortcut));
		}
		/// <remarks>
		///  Up. Default: Alt+Up
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Up.</short>
		public static KShortcut Up() {
			return (KShortcut) staticInterceptor.Invoke("up", "up()", typeof(KShortcut));
		}
		/// <remarks>
		///  Back. Default: Alt+Left
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Back.</short>
		public static KShortcut Back() {
			return (KShortcut) staticInterceptor.Invoke("back", "back()", typeof(KShortcut));
		}
		/// <remarks>
		///  Forward. Default: ALT+Right
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Forward.</short>
		public static KShortcut Forward() {
			return (KShortcut) staticInterceptor.Invoke("forward", "forward()", typeof(KShortcut));
		}
		/// <remarks>
		///  BackwardWord. Default: Ctrl+Left
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    BackwardWord.</short>
		public static KShortcut BackwardWord() {
			return (KShortcut) staticInterceptor.Invoke("backwardWord", "backwardWord()", typeof(KShortcut));
		}
		/// <remarks>
		///  ForwardWord. Default: Ctrl+Right
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    ForwardWord.</short>
		public static KShortcut ForwardWord() {
			return (KShortcut) staticInterceptor.Invoke("forwardWord", "forwardWord()", typeof(KShortcut));
		}
		/// <remarks>
		///  Show Menu Bar.  Default: Ctrl-M
		/// </remarks>		<return> the shortcut of the standard accelerator
		///    </return>
		/// 		<short>    Show Menu Bar.</short>
		public static KShortcut ShowMenubar() {
			return (KShortcut) staticInterceptor.Invoke("showMenubar", "showMenubar()", typeof(KShortcut));
		}
	}
}
