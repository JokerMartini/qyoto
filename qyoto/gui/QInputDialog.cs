//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QInputDialog")]
	public class QInputDialog : QDialog {
 		protected QInputDialog(Type dummy) : base((Type) null) {}
		private static SmokeInvocation staticInterceptor = null;
		static QInputDialog() {
			staticInterceptor = new SmokeInvocation(typeof(QInputDialog), null);
		}
		public static string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		public static string GetText(QWidget parent, string title, string label, QLineEdit.EchoMode echo, string text, bool ok, int f) {
			return (string) staticInterceptor.Invoke("getText#$$$$$$", "getText(QWidget*, const QString&, const QString&, QLineEdit::EchoMode, const QString&, bool*, Qt::WindowFlags)", typeof(string), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(QLineEdit.EchoMode), echo, typeof(string), text, typeof(bool), ok, typeof(int), f);
		}
		public static string GetText(QWidget parent, string title, string label, QLineEdit.EchoMode echo, string text, bool ok) {
			return (string) staticInterceptor.Invoke("getText#$$$$$", "getText(QWidget*, const QString&, const QString&, QLineEdit::EchoMode, const QString&, bool*)", typeof(string), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(QLineEdit.EchoMode), echo, typeof(string), text, typeof(bool), ok);
		}
		public static string GetText(QWidget parent, string title, string label, QLineEdit.EchoMode echo, string text) {
			return (string) staticInterceptor.Invoke("getText#$$$$", "getText(QWidget*, const QString&, const QString&, QLineEdit::EchoMode, const QString&)", typeof(string), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(QLineEdit.EchoMode), echo, typeof(string), text);
		}
		public static string GetText(QWidget parent, string title, string label, QLineEdit.EchoMode echo) {
			return (string) staticInterceptor.Invoke("getText#$$$", "getText(QWidget*, const QString&, const QString&, QLineEdit::EchoMode)", typeof(string), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(QLineEdit.EchoMode), echo);
		}
		public static string GetText(QWidget parent, string title, string label) {
			return (string) staticInterceptor.Invoke("getText#$$", "getText(QWidget*, const QString&, const QString&)", typeof(string), typeof(QWidget), parent, typeof(string), title, typeof(string), label);
		}
		public static int GetInteger(QWidget parent, string title, string label, int value, int minValue, int maxValue, int step, bool ok, int f) {
			return (int) staticInterceptor.Invoke("getInteger#$$$$$$$$", "getInteger(QWidget*, const QString&, const QString&, int, int, int, int, bool*, Qt::WindowFlags)", typeof(int), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(int), value, typeof(int), minValue, typeof(int), maxValue, typeof(int), step, typeof(bool), ok, typeof(int), f);
		}
		public static int GetInteger(QWidget parent, string title, string label, int value, int minValue, int maxValue, int step, bool ok) {
			return (int) staticInterceptor.Invoke("getInteger#$$$$$$$", "getInteger(QWidget*, const QString&, const QString&, int, int, int, int, bool*)", typeof(int), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(int), value, typeof(int), minValue, typeof(int), maxValue, typeof(int), step, typeof(bool), ok);
		}
		public static int GetInteger(QWidget parent, string title, string label, int value, int minValue, int maxValue, int step) {
			return (int) staticInterceptor.Invoke("getInteger#$$$$$$", "getInteger(QWidget*, const QString&, const QString&, int, int, int, int)", typeof(int), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(int), value, typeof(int), minValue, typeof(int), maxValue, typeof(int), step);
		}
		public static int GetInteger(QWidget parent, string title, string label, int value, int minValue, int maxValue) {
			return (int) staticInterceptor.Invoke("getInteger#$$$$$", "getInteger(QWidget*, const QString&, const QString&, int, int, int)", typeof(int), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(int), value, typeof(int), minValue, typeof(int), maxValue);
		}
		public static int GetInteger(QWidget parent, string title, string label, int value, int minValue) {
			return (int) staticInterceptor.Invoke("getInteger#$$$$", "getInteger(QWidget*, const QString&, const QString&, int, int)", typeof(int), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(int), value, typeof(int), minValue);
		}
		public static int GetInteger(QWidget parent, string title, string label, int value) {
			return (int) staticInterceptor.Invoke("getInteger#$$$", "getInteger(QWidget*, const QString&, const QString&, int)", typeof(int), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(int), value);
		}
		public static int GetInteger(QWidget parent, string title, string label) {
			return (int) staticInterceptor.Invoke("getInteger#$$", "getInteger(QWidget*, const QString&, const QString&)", typeof(int), typeof(QWidget), parent, typeof(string), title, typeof(string), label);
		}
		public static double GetDouble(QWidget parent, string title, string label, double value, double minValue, double maxValue, int decimals, bool ok, int f) {
			return (double) staticInterceptor.Invoke("getDouble#$$$$$$$$", "getDouble(QWidget*, const QString&, const QString&, double, double, double, int, bool*, Qt::WindowFlags)", typeof(double), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(double), value, typeof(double), minValue, typeof(double), maxValue, typeof(int), decimals, typeof(bool), ok, typeof(int), f);
		}
		public static double GetDouble(QWidget parent, string title, string label, double value, double minValue, double maxValue, int decimals, bool ok) {
			return (double) staticInterceptor.Invoke("getDouble#$$$$$$$", "getDouble(QWidget*, const QString&, const QString&, double, double, double, int, bool*)", typeof(double), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(double), value, typeof(double), minValue, typeof(double), maxValue, typeof(int), decimals, typeof(bool), ok);
		}
		public static double GetDouble(QWidget parent, string title, string label, double value, double minValue, double maxValue, int decimals) {
			return (double) staticInterceptor.Invoke("getDouble#$$$$$$", "getDouble(QWidget*, const QString&, const QString&, double, double, double, int)", typeof(double), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(double), value, typeof(double), minValue, typeof(double), maxValue, typeof(int), decimals);
		}
		public static double GetDouble(QWidget parent, string title, string label, double value, double minValue, double maxValue) {
			return (double) staticInterceptor.Invoke("getDouble#$$$$$", "getDouble(QWidget*, const QString&, const QString&, double, double, double)", typeof(double), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(double), value, typeof(double), minValue, typeof(double), maxValue);
		}
		public static double GetDouble(QWidget parent, string title, string label, double value, double minValue) {
			return (double) staticInterceptor.Invoke("getDouble#$$$$", "getDouble(QWidget*, const QString&, const QString&, double, double)", typeof(double), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(double), value, typeof(double), minValue);
		}
		public static double GetDouble(QWidget parent, string title, string label, double value) {
			return (double) staticInterceptor.Invoke("getDouble#$$$", "getDouble(QWidget*, const QString&, const QString&, double)", typeof(double), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(double), value);
		}
		public static double GetDouble(QWidget parent, string title, string label) {
			return (double) staticInterceptor.Invoke("getDouble#$$", "getDouble(QWidget*, const QString&, const QString&)", typeof(double), typeof(QWidget), parent, typeof(string), title, typeof(string), label);
		}
		public static string GetItem(QWidget parent, string title, string label, List<string> list, int current, bool editable, bool ok, int f) {
			return (string) staticInterceptor.Invoke("getItem#$$?$$$$", "getItem(QWidget*, const QString&, const QString&, const QStringList&, int, bool, bool*, Qt::WindowFlags)", typeof(string), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(List<string>), list, typeof(int), current, typeof(bool), editable, typeof(bool), ok, typeof(int), f);
		}
		public static string GetItem(QWidget parent, string title, string label, List<string> list, int current, bool editable, bool ok) {
			return (string) staticInterceptor.Invoke("getItem#$$?$$$", "getItem(QWidget*, const QString&, const QString&, const QStringList&, int, bool, bool*)", typeof(string), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(List<string>), list, typeof(int), current, typeof(bool), editable, typeof(bool), ok);
		}
		public static string GetItem(QWidget parent, string title, string label, List<string> list, int current, bool editable) {
			return (string) staticInterceptor.Invoke("getItem#$$?$$", "getItem(QWidget*, const QString&, const QString&, const QStringList&, int, bool)", typeof(string), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(List<string>), list, typeof(int), current, typeof(bool), editable);
		}
		public static string GetItem(QWidget parent, string title, string label, List<string> list, int current) {
			return (string) staticInterceptor.Invoke("getItem#$$?$", "getItem(QWidget*, const QString&, const QString&, const QStringList&, int)", typeof(string), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(List<string>), list, typeof(int), current);
		}
		public static string GetItem(QWidget parent, string title, string label, List<string> list) {
			return (string) staticInterceptor.Invoke("getItem#$$?", "getItem(QWidget*, const QString&, const QString&, const QStringList&)", typeof(string), typeof(QWidget), parent, typeof(string), title, typeof(string), label, typeof(List<string>), list);
		}
		protected new IQInputDialogSignals Emit {
			get { return (IQInputDialogSignals) Q_EMIT; }
		}
	}

	public interface IQInputDialogSignals : IQDialogSignals {
	}
}
