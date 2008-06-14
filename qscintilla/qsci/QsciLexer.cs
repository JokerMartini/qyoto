//Auto-generated by kalyptus. DO NOT EDIT.
namespace QScintilla {

	using System;
	using Qyoto;
	using System.Runtime.InteropServices;
	using System.Collections.Generic;

	/// <remarks> See <see cref="IQsciLexerSignals"></see> for signals emitted by QsciLexer
	/// </remarks>

	[SmokeClass("QsciLexer")]
	public abstract class QsciLexer : QObject {
 		protected QsciLexer(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QsciLexer), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QsciLexer() {
			staticInterceptor = new SmokeInvocation(typeof(QsciLexer), null);
		}
		public QsciLexer(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QsciLexer#", "QsciLexer(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public QsciLexer() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QsciLexer", "QsciLexer()", typeof(void));
		}
		[SmokeMethod("language() const")]
		public abstract string Language();
		[SmokeMethod("lexer() const")]
		public abstract string Lexer();
		public QsciAPIs Apis() {
			return (QsciAPIs) interceptor.Invoke("apis", "apis() const", typeof(QsciAPIs));
		}
		[SmokeMethod("autoCompletionFillups() const")]
		public virtual string AutoCompletionFillups() {
			return (string) interceptor.Invoke("autoCompletionFillups", "autoCompletionFillups() const", typeof(string));
		}
		[SmokeMethod("autoCompletionWordSeparators() const")]
		public virtual List<string> AutoCompletionWordSeparators() {
			return (List<string>) interceptor.Invoke("autoCompletionWordSeparators", "autoCompletionWordSeparators() const", typeof(List<string>));
		}
		public int AutoIndentStyle() {
			return (int) interceptor.Invoke("autoIndentStyle", "autoIndentStyle()", typeof(int));
		}
		[SmokeMethod("blockEnd(int*) const")]
		public virtual string BlockEnd(ref int style) {
			StackItem[] stack = new StackItem[2];
			stack[1].s_int = style;
			interceptor.Invoke("blockEnd$", "blockEnd(int*) const", stack);
			style = stack[1].s_int;
			object returnValue = ((GCHandle) stack[0].s_class).Target;
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[0].s_class);
#else
			((GCHandle) stack[0].s_class).Free();
#endif
			return (string) returnValue;
		}
		[SmokeMethod("blockEnd() const")]
		public virtual string BlockEnd() {
			return (string) interceptor.Invoke("blockEnd", "blockEnd() const", typeof(string));
		}
		[SmokeMethod("blockLookback() const")]
		public virtual int BlockLookback() {
			return (int) interceptor.Invoke("blockLookback", "blockLookback() const", typeof(int));
		}
		[SmokeMethod("blockStart(int*) const")]
		public virtual string BlockStart(ref int style) {
			StackItem[] stack = new StackItem[2];
			stack[1].s_int = style;
			interceptor.Invoke("blockStart$", "blockStart(int*) const", stack);
			style = stack[1].s_int;
			object returnValue = ((GCHandle) stack[0].s_class).Target;
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[0].s_class);
#else
			((GCHandle) stack[0].s_class).Free();
#endif
			return (string) returnValue;
		}
		[SmokeMethod("blockStart() const")]
		public virtual string BlockStart() {
			return (string) interceptor.Invoke("blockStart", "blockStart() const", typeof(string));
		}
		[SmokeMethod("blockStartKeyword(int*) const")]
		public virtual string BlockStartKeyword(ref int style) {
			StackItem[] stack = new StackItem[2];
			stack[1].s_int = style;
			interceptor.Invoke("blockStartKeyword$", "blockStartKeyword(int*) const", stack);
			style = stack[1].s_int;
			object returnValue = ((GCHandle) stack[0].s_class).Target;
#if DEBUG
			DebugGCHandle.Free((GCHandle) stack[0].s_class);
#else
			((GCHandle) stack[0].s_class).Free();
#endif
			return (string) returnValue;
		}
		[SmokeMethod("blockStartKeyword() const")]
		public virtual string BlockStartKeyword() {
			return (string) interceptor.Invoke("blockStartKeyword", "blockStartKeyword() const", typeof(string));
		}
		[SmokeMethod("braceStyle() const")]
		public virtual int BraceStyle() {
			return (int) interceptor.Invoke("braceStyle", "braceStyle() const", typeof(int));
		}
		[SmokeMethod("caseSensitive() const")]
		public virtual bool CaseSensitive() {
			return (bool) interceptor.Invoke("caseSensitive", "caseSensitive() const", typeof(bool));
		}
		[SmokeMethod("color(int) const")]
		public virtual QColor Color(int style) {
			return (QColor) interceptor.Invoke("color$", "color(int) const", typeof(QColor), typeof(int), style);
		}
		[SmokeMethod("eolFill(int) const")]
		public virtual bool EolFill(int style) {
			return (bool) interceptor.Invoke("eolFill$", "eolFill(int) const", typeof(bool), typeof(int), style);
		}
		[SmokeMethod("font(int) const")]
		public virtual QFont Font(int style) {
			return (QFont) interceptor.Invoke("font$", "font(int) const", typeof(QFont), typeof(int), style);
		}
		[SmokeMethod("indentationGuideView() const")]
		public virtual int IndentationGuideView() {
			return (int) interceptor.Invoke("indentationGuideView", "indentationGuideView() const", typeof(int));
		}
		[SmokeMethod("keywords(int) const")]
		public virtual string Keywords(int set) {
			return (string) interceptor.Invoke("keywords$", "keywords(int) const", typeof(string), typeof(int), set);
		}
		[SmokeMethod("defaultStyle() const")]
		public virtual int DefaultStyle() {
			return (int) interceptor.Invoke("defaultStyle", "defaultStyle() const", typeof(int));
		}
		[SmokeMethod("description(int) const")]
		public abstract string Description(int style);
		[SmokeMethod("paper(int) const")]
		public virtual QColor Paper(int style) {
			return (QColor) interceptor.Invoke("paper$", "paper(int) const", typeof(QColor), typeof(int), style);
		}
		public QColor DefaultColor() {
			return (QColor) interceptor.Invoke("defaultColor", "defaultColor() const", typeof(QColor));
		}
		[SmokeMethod("defaultColor(int) const")]
		public virtual QColor DefaultColor(int style) {
			return (QColor) interceptor.Invoke("defaultColor$", "defaultColor(int) const", typeof(QColor), typeof(int), style);
		}
		[SmokeMethod("defaultEolFill(int) const")]
		public virtual bool DefaultEolFill(int style) {
			return (bool) interceptor.Invoke("defaultEolFill$", "defaultEolFill(int) const", typeof(bool), typeof(int), style);
		}
		public QFont DefaultFont() {
			return (QFont) interceptor.Invoke("defaultFont", "defaultFont() const", typeof(QFont));
		}
		[SmokeMethod("defaultFont(int) const")]
		public virtual QFont DefaultFont(int style) {
			return (QFont) interceptor.Invoke("defaultFont$", "defaultFont(int) const", typeof(QFont), typeof(int), style);
		}
		public QColor DefaultPaper() {
			return (QColor) interceptor.Invoke("defaultPaper", "defaultPaper() const", typeof(QColor));
		}
		[SmokeMethod("defaultPaper(int) const")]
		public virtual QColor DefaultPaper(int style) {
			return (QColor) interceptor.Invoke("defaultPaper$", "defaultPaper(int) const", typeof(QColor), typeof(int), style);
		}
		public void SetAPIs(QsciAPIs apis) {
			interceptor.Invoke("setAPIs#", "setAPIs(QsciAPIs*)", typeof(void), typeof(QsciAPIs), apis);
		}
		public void SetDefaultColor(QColor c) {
			interceptor.Invoke("setDefaultColor#", "setDefaultColor(const QColor&)", typeof(void), typeof(QColor), c);
		}
		public void SetDefaultFont(QFont f) {
			interceptor.Invoke("setDefaultFont#", "setDefaultFont(const QFont&)", typeof(void), typeof(QFont), f);
		}
		public void SetDefaultPaper(QColor c) {
			interceptor.Invoke("setDefaultPaper#", "setDefaultPaper(const QColor&)", typeof(void), typeof(QColor), c);
		}
		public bool ReadSettings(QSettings qs, string prefix) {
			return (bool) interceptor.Invoke("readSettings#$", "readSettings(QSettings&, const char*)", typeof(bool), typeof(QSettings), qs, typeof(string), prefix);
		}
		public bool ReadSettings(QSettings qs) {
			return (bool) interceptor.Invoke("readSettings#", "readSettings(QSettings&)", typeof(bool), typeof(QSettings), qs);
		}
		[SmokeMethod("refreshProperties()")]
		public virtual void RefreshProperties() {
			interceptor.Invoke("refreshProperties", "refreshProperties()", typeof(void));
		}
		[SmokeMethod("wordCharacters() const")]
		public virtual string WordCharacters() {
			return (string) interceptor.Invoke("wordCharacters", "wordCharacters() const", typeof(string));
		}
		public bool WriteSettings(QSettings qs, string prefix) {
			return (bool) interceptor.Invoke("writeSettings#$", "writeSettings(QSettings&, const char*) const", typeof(bool), typeof(QSettings), qs, typeof(string), prefix);
		}
		public bool WriteSettings(QSettings qs) {
			return (bool) interceptor.Invoke("writeSettings#", "writeSettings(QSettings&) const", typeof(bool), typeof(QSettings), qs);
		}
		[Q_SLOT("void setAutoIndentStyle(int)")]
		[SmokeMethod("setAutoIndentStyle(int)")]
		public virtual void SetAutoIndentStyle(int autoindentstyle) {
			interceptor.Invoke("setAutoIndentStyle$", "setAutoIndentStyle(int)", typeof(void), typeof(int), autoindentstyle);
		}
		[Q_SLOT("void setColor(const QColor&, int)")]
		[SmokeMethod("setColor(const QColor&, int)")]
		public virtual void SetColor(QColor c, int style) {
			interceptor.Invoke("setColor#$", "setColor(const QColor&, int)", typeof(void), typeof(QColor), c, typeof(int), style);
		}
		[Q_SLOT("void setColor(const QColor&)")]
		[SmokeMethod("setColor(const QColor&)")]
		public virtual void SetColor(QColor c) {
			interceptor.Invoke("setColor#", "setColor(const QColor&)", typeof(void), typeof(QColor), c);
		}
		[Q_SLOT("void setEolFill(bool, int)")]
		[SmokeMethod("setEolFill(bool, int)")]
		public virtual void SetEolFill(bool eoffill, int style) {
			interceptor.Invoke("setEolFill$$", "setEolFill(bool, int)", typeof(void), typeof(bool), eoffill, typeof(int), style);
		}
		[Q_SLOT("void setEolFill(bool)")]
		[SmokeMethod("setEolFill(bool)")]
		public virtual void SetEolFill(bool eoffill) {
			interceptor.Invoke("setEolFill$", "setEolFill(bool)", typeof(void), typeof(bool), eoffill);
		}
		[Q_SLOT("void setFont(const QFont&, int)")]
		[SmokeMethod("setFont(const QFont&, int)")]
		public virtual void SetFont(QFont f, int style) {
			interceptor.Invoke("setFont#$", "setFont(const QFont&, int)", typeof(void), typeof(QFont), f, typeof(int), style);
		}
		[Q_SLOT("void setFont(const QFont&)")]
		[SmokeMethod("setFont(const QFont&)")]
		public virtual void SetFont(QFont f) {
			interceptor.Invoke("setFont#", "setFont(const QFont&)", typeof(void), typeof(QFont), f);
		}
		[Q_SLOT("void setPaper(const QColor&, int)")]
		[SmokeMethod("setPaper(const QColor&, int)")]
		public virtual void SetPaper(QColor c, int style) {
			interceptor.Invoke("setPaper#$", "setPaper(const QColor&, int)", typeof(void), typeof(QColor), c, typeof(int), style);
		}
		[Q_SLOT("void setPaper(const QColor&)")]
		[SmokeMethod("setPaper(const QColor&)")]
		public virtual void SetPaper(QColor c) {
			interceptor.Invoke("setPaper#", "setPaper(const QColor&)", typeof(void), typeof(QColor), c);
		}
		[SmokeMethod("readProperties(QSettings&, const QString&)")]
		protected virtual bool ReadProperties(QSettings qs, string prefix) {
			return (bool) interceptor.Invoke("readProperties#$", "readProperties(QSettings&, const QString&)", typeof(bool), typeof(QSettings), qs, typeof(string), prefix);
		}
		[SmokeMethod("writeProperties(QSettings&, const QString&) const")]
		protected virtual bool WriteProperties(QSettings qs, string prefix) {
			return (bool) interceptor.Invoke("writeProperties#$", "writeProperties(QSettings&, const QString&) const", typeof(bool), typeof(QSettings), qs, typeof(string), prefix);
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQsciLexerSignals Emit {
			get { return (IQsciLexerSignals) Q_EMIT; }
		}
	}

	public interface IQsciLexerSignals : IQObjectSignals {
		[Q_SIGNAL("void colorChanged(const QColor&, int)")]
		void ColorChanged(QColor c, int style);
		[Q_SIGNAL("void eolFillChanged(bool, int)")]
		void EolFillChanged(bool eolfilled, int style);
		[Q_SIGNAL("void fontChanged(const QFont&, int)")]
		void FontChanged(QFont f, int style);
		[Q_SIGNAL("void paperChanged(const QColor&, int)")]
		void PaperChanged(QColor c, int style);
		[Q_SIGNAL("void propertyChanged(const char*, const char*)")]
		void PropertyChanged(string prop, string val);
	}
}
