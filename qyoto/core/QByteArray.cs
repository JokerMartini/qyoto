//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	using System.Collections.Generic;
	[SmokeClass("QByteArray")]
	public class QByteArray : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QByteArray(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QByteArray), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QByteArray() {
			staticInterceptor = new SmokeInvocation(typeof(QByteArray), null);
		}
		//  operator const char *(); >>>> NOT CONVERTED
		//  operator const void *(); >>>> NOT CONVERTED
		// QByteArray::DataPtr& data_ptr(); >>>> NOT CONVERTED
		public QByteArray() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QByteArray", "QByteArray()", typeof(void));
		}
		public QByteArray(string arg1) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QByteArray$", "QByteArray(const char*)", typeof(void), typeof(string), arg1);
		}
		public QByteArray(string arg1, int size) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QByteArray$$", "QByteArray(const char*, int)", typeof(void), typeof(string), arg1, typeof(int), size);
		}
		public QByteArray(int size, char c) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QByteArray$$", "QByteArray(int, char)", typeof(void), typeof(int), size, typeof(char), c);
		}
		public QByteArray(QByteArray arg1) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QByteArray#", "QByteArray(const QByteArray&)", typeof(void), typeof(QByteArray), arg1);
		}
		public int Size() {
			return (int) interceptor.Invoke("size", "size() const", typeof(int));
		}
		public bool IsEmpty() {
			return (bool) interceptor.Invoke("isEmpty", "isEmpty() const", typeof(bool));
		}
		public void Resize(int size) {
			interceptor.Invoke("resize$", "resize(int)", typeof(void), typeof(int), size);
		}
		public QByteArray Fill(char c, int size) {
			return (QByteArray) interceptor.Invoke("fill$$", "fill(char, int)", typeof(QByteArray), typeof(char), c, typeof(int), size);
		}
		public QByteArray Fill(char c) {
			return (QByteArray) interceptor.Invoke("fill$", "fill(char)", typeof(QByteArray), typeof(char), c);
		}
		public int Capacity() {
			return (int) interceptor.Invoke("capacity", "capacity() const", typeof(int));
		}
		public void Reserve(int size) {
			interceptor.Invoke("reserve$", "reserve(int)", typeof(void), typeof(int), size);
		}
		public void Squeeze() {
			interceptor.Invoke("squeeze", "squeeze()", typeof(void));
		}
		public string Data() {
			return (string) interceptor.Invoke("data", "data()", typeof(string));
		}
		public string ConstData() {
			return (string) interceptor.Invoke("constData", "constData() const", typeof(string));
		}
		public void Detach() {
			interceptor.Invoke("detach", "detach()", typeof(void));
		}
		public bool IsDetached() {
			return (bool) interceptor.Invoke("isDetached", "isDetached() const", typeof(bool));
		}
		public void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		public char At(int i) {
			return (char) interceptor.Invoke("at$", "at(int) const", typeof(char), typeof(int), i);
		}
		public int IndexOf(char c, int from) {
			return (int) interceptor.Invoke("indexOf$$", "indexOf(char, int) const", typeof(int), typeof(char), c, typeof(int), from);
		}
		public int IndexOf(char c) {
			return (int) interceptor.Invoke("indexOf$", "indexOf(char) const", typeof(int), typeof(char), c);
		}
		public int IndexOf(string c, int from) {
			return (int) interceptor.Invoke("indexOf$$", "indexOf(const char*, int) const", typeof(int), typeof(string), c, typeof(int), from);
		}
		public int IndexOf(string c) {
			return (int) interceptor.Invoke("indexOf$", "indexOf(const char*) const", typeof(int), typeof(string), c);
		}
		public int IndexOf(QByteArray a, int from) {
			return (int) interceptor.Invoke("indexOf#$", "indexOf(const QByteArray&, int) const", typeof(int), typeof(QByteArray), a, typeof(int), from);
		}
		public int IndexOf(QByteArray a) {
			return (int) interceptor.Invoke("indexOf#", "indexOf(const QByteArray&) const", typeof(int), typeof(QByteArray), a);
		}
		public int LastIndexOf(char c, int from) {
			return (int) interceptor.Invoke("lastIndexOf$$", "lastIndexOf(char, int) const", typeof(int), typeof(char), c, typeof(int), from);
		}
		public int LastIndexOf(char c) {
			return (int) interceptor.Invoke("lastIndexOf$", "lastIndexOf(char) const", typeof(int), typeof(char), c);
		}
		public int LastIndexOf(string c, int from) {
			return (int) interceptor.Invoke("lastIndexOf$$", "lastIndexOf(const char*, int) const", typeof(int), typeof(string), c, typeof(int), from);
		}
		public int LastIndexOf(string c) {
			return (int) interceptor.Invoke("lastIndexOf$", "lastIndexOf(const char*) const", typeof(int), typeof(string), c);
		}
		public int LastIndexOf(QByteArray a, int from) {
			return (int) interceptor.Invoke("lastIndexOf#$", "lastIndexOf(const QByteArray&, int) const", typeof(int), typeof(QByteArray), a, typeof(int), from);
		}
		public int LastIndexOf(QByteArray a) {
			return (int) interceptor.Invoke("lastIndexOf#", "lastIndexOf(const QByteArray&) const", typeof(int), typeof(QByteArray), a);
		}
		public QBool Contains(char c) {
			return (QBool) interceptor.Invoke("contains$", "contains(char) const", typeof(QBool), typeof(char), c);
		}
		public QBool Contains(string a) {
			return (QBool) interceptor.Invoke("contains$", "contains(const char*) const", typeof(QBool), typeof(string), a);
		}
		public QBool Contains(QByteArray a) {
			return (QBool) interceptor.Invoke("contains#", "contains(const QByteArray&) const", typeof(QBool), typeof(QByteArray), a);
		}
		public int Count(char c) {
			return (int) interceptor.Invoke("count$", "count(char) const", typeof(int), typeof(char), c);
		}
		public int Count(string a) {
			return (int) interceptor.Invoke("count$", "count(const char*) const", typeof(int), typeof(string), a);
		}
		public int Count(QByteArray a) {
			return (int) interceptor.Invoke("count#", "count(const QByteArray&) const", typeof(int), typeof(QByteArray), a);
		}
		public QByteArray Left(int len) {
			return (QByteArray) interceptor.Invoke("left$", "left(int) const", typeof(QByteArray), typeof(int), len);
		}
		public QByteArray Right(int len) {
			return (QByteArray) interceptor.Invoke("right$", "right(int) const", typeof(QByteArray), typeof(int), len);
		}
		public QByteArray Mid(int index, int len) {
			return (QByteArray) interceptor.Invoke("mid$$", "mid(int, int) const", typeof(QByteArray), typeof(int), index, typeof(int), len);
		}
		public QByteArray Mid(int index) {
			return (QByteArray) interceptor.Invoke("mid$", "mid(int) const", typeof(QByteArray), typeof(int), index);
		}
		public bool StartsWith(QByteArray a) {
			return (bool) interceptor.Invoke("startsWith#", "startsWith(const QByteArray&) const", typeof(bool), typeof(QByteArray), a);
		}
		public bool StartsWith(char c) {
			return (bool) interceptor.Invoke("startsWith$", "startsWith(char) const", typeof(bool), typeof(char), c);
		}
		public bool StartsWith(string c) {
			return (bool) interceptor.Invoke("startsWith$", "startsWith(const char*) const", typeof(bool), typeof(string), c);
		}
		public bool EndsWith(QByteArray a) {
			return (bool) interceptor.Invoke("endsWith#", "endsWith(const QByteArray&) const", typeof(bool), typeof(QByteArray), a);
		}
		public bool EndsWith(char c) {
			return (bool) interceptor.Invoke("endsWith$", "endsWith(char) const", typeof(bool), typeof(char), c);
		}
		public bool EndsWith(string c) {
			return (bool) interceptor.Invoke("endsWith$", "endsWith(const char*) const", typeof(bool), typeof(string), c);
		}
		public void Truncate(int pos) {
			interceptor.Invoke("truncate$", "truncate(int)", typeof(void), typeof(int), pos);
		}
		public void Chop(int n) {
			interceptor.Invoke("chop$", "chop(int)", typeof(void), typeof(int), n);
		}
		public QByteArray ToLower() {
			return (QByteArray) interceptor.Invoke("toLower", "toLower() const", typeof(QByteArray));
		}
		public QByteArray ToUpper() {
			return (QByteArray) interceptor.Invoke("toUpper", "toUpper() const", typeof(QByteArray));
		}
		public QByteArray Trimmed() {
			return (QByteArray) interceptor.Invoke("trimmed", "trimmed() const", typeof(QByteArray));
		}
		public QByteArray Simplified() {
			return (QByteArray) interceptor.Invoke("simplified", "simplified() const", typeof(QByteArray));
		}
		public QByteArray LeftJustified(int width, char fill, bool truncate) {
			return (QByteArray) interceptor.Invoke("leftJustified$$$", "leftJustified(int, char, bool) const", typeof(QByteArray), typeof(int), width, typeof(char), fill, typeof(bool), truncate);
		}
		public QByteArray LeftJustified(int width, char fill) {
			return (QByteArray) interceptor.Invoke("leftJustified$$", "leftJustified(int, char) const", typeof(QByteArray), typeof(int), width, typeof(char), fill);
		}
		public QByteArray LeftJustified(int width) {
			return (QByteArray) interceptor.Invoke("leftJustified$", "leftJustified(int) const", typeof(QByteArray), typeof(int), width);
		}
		public QByteArray RightJustified(int width, char fill, bool truncate) {
			return (QByteArray) interceptor.Invoke("rightJustified$$$", "rightJustified(int, char, bool) const", typeof(QByteArray), typeof(int), width, typeof(char), fill, typeof(bool), truncate);
		}
		public QByteArray RightJustified(int width, char fill) {
			return (QByteArray) interceptor.Invoke("rightJustified$$", "rightJustified(int, char) const", typeof(QByteArray), typeof(int), width, typeof(char), fill);
		}
		public QByteArray RightJustified(int width) {
			return (QByteArray) interceptor.Invoke("rightJustified$", "rightJustified(int) const", typeof(QByteArray), typeof(int), width);
		}
		public QByteArray Prepend(char c) {
			return (QByteArray) interceptor.Invoke("prepend$", "prepend(char)", typeof(QByteArray), typeof(char), c);
		}
		public QByteArray Prepend(string s) {
			return (QByteArray) interceptor.Invoke("prepend$", "prepend(const char*)", typeof(QByteArray), typeof(string), s);
		}
		public QByteArray Prepend(QByteArray a) {
			return (QByteArray) interceptor.Invoke("prepend#", "prepend(const QByteArray&)", typeof(QByteArray), typeof(QByteArray), a);
		}
		public QByteArray Append(char c) {
			return (QByteArray) interceptor.Invoke("append$", "append(char)", typeof(QByteArray), typeof(char), c);
		}
		public QByteArray Append(string s) {
			return (QByteArray) interceptor.Invoke("append$", "append(const char*)", typeof(QByteArray), typeof(string), s);
		}
		public QByteArray Append(QByteArray a) {
			return (QByteArray) interceptor.Invoke("append#", "append(const QByteArray&)", typeof(QByteArray), typeof(QByteArray), a);
		}
		public QByteArray Insert(int i, char c) {
			return (QByteArray) interceptor.Invoke("insert$$", "insert(int, char)", typeof(QByteArray), typeof(int), i, typeof(char), c);
		}
		public QByteArray Insert(int i, string s) {
			return (QByteArray) interceptor.Invoke("insert$$", "insert(int, const char*)", typeof(QByteArray), typeof(int), i, typeof(string), s);
		}
		public QByteArray Insert(int i, QByteArray a) {
			return (QByteArray) interceptor.Invoke("insert$#", "insert(int, const QByteArray&)", typeof(QByteArray), typeof(int), i, typeof(QByteArray), a);
		}
		public QByteArray Remove(int index, int len) {
			return (QByteArray) interceptor.Invoke("remove$$", "remove(int, int)", typeof(QByteArray), typeof(int), index, typeof(int), len);
		}
		public QByteArray Replace(int index, int len, string s) {
			return (QByteArray) interceptor.Invoke("replace$$$", "replace(int, int, const char*)", typeof(QByteArray), typeof(int), index, typeof(int), len, typeof(string), s);
		}
		public QByteArray Replace(int index, int len, QByteArray s) {
			return (QByteArray) interceptor.Invoke("replace$$#", "replace(int, int, const QByteArray&)", typeof(QByteArray), typeof(int), index, typeof(int), len, typeof(QByteArray), s);
		}
		public QByteArray Replace(char before, string after) {
			return (QByteArray) interceptor.Invoke("replace$$", "replace(char, const char*)", typeof(QByteArray), typeof(char), before, typeof(string), after);
		}
		public QByteArray Replace(char before, QByteArray after) {
			return (QByteArray) interceptor.Invoke("replace$#", "replace(char, const QByteArray&)", typeof(QByteArray), typeof(char), before, typeof(QByteArray), after);
		}
		public QByteArray Replace(string before, string after) {
			return (QByteArray) interceptor.Invoke("replace$$", "replace(const char*, const char*)", typeof(QByteArray), typeof(string), before, typeof(string), after);
		}
		public QByteArray Replace(QByteArray before, QByteArray after) {
			return (QByteArray) interceptor.Invoke("replace##", "replace(const QByteArray&, const QByteArray&)", typeof(QByteArray), typeof(QByteArray), before, typeof(QByteArray), after);
		}
		public QByteArray Replace(QByteArray before, string after) {
			return (QByteArray) interceptor.Invoke("replace#$", "replace(const QByteArray&, const char*)", typeof(QByteArray), typeof(QByteArray), before, typeof(string), after);
		}
		public QByteArray Replace(string before, QByteArray after) {
			return (QByteArray) interceptor.Invoke("replace$#", "replace(const char*, const QByteArray&)", typeof(QByteArray), typeof(string), before, typeof(QByteArray), after);
		}
		public QByteArray Replace(char before, char after) {
			return (QByteArray) interceptor.Invoke("replace$$", "replace(char, char)", typeof(QByteArray), typeof(char), before, typeof(char), after);
		}
		public List<QByteArray> Split(char sep) {
			return (List<QByteArray>) interceptor.Invoke("split$", "split(char) const", typeof(List<QByteArray>), typeof(char), sep);
		}
		public override bool Equals(object o) {
			if (!(o is QByteArray)) { return false; }
			return this == (QByteArray) o;
		}
		public override int GetHashCode() {
			return interceptor.GetHashCode();
		}
		public short ToShort(ref bool ok, int arg2) {
			StackItem[] stack = new StackItem[3];
			stack[1].s_bool = ok;
			stack[2].s_int = arg2;
			interceptor.Invoke("toShort$$", "toShort(bool*, int) const", stack);
			ok = stack[1].s_bool;
			return stack[0].s_short;
		}
		public short ToShort(ref bool ok) {
			StackItem[] stack = new StackItem[2];
			stack[1].s_bool = ok;
			interceptor.Invoke("toShort$", "toShort(bool*) const", stack);
			ok = stack[1].s_bool;
			return stack[0].s_short;
		}
		public short ToShort() {
			return (short) interceptor.Invoke("toShort", "toShort() const", typeof(short));
		}
		public ushort ToUShort(ref bool ok, int arg2) {
			StackItem[] stack = new StackItem[3];
			stack[1].s_bool = ok;
			stack[2].s_int = arg2;
			interceptor.Invoke("toUShort$$", "toUShort(bool*, int) const", stack);
			ok = stack[1].s_bool;
			return stack[0].s_ushort;
		}
		public ushort ToUShort(ref bool ok) {
			StackItem[] stack = new StackItem[2];
			stack[1].s_bool = ok;
			interceptor.Invoke("toUShort$", "toUShort(bool*) const", stack);
			ok = stack[1].s_bool;
			return stack[0].s_ushort;
		}
		public ushort ToUShort() {
			return (ushort) interceptor.Invoke("toUShort", "toUShort() const", typeof(ushort));
		}
		public int ToInt(ref bool ok, int arg2) {
			StackItem[] stack = new StackItem[3];
			stack[1].s_bool = ok;
			stack[2].s_int = arg2;
			interceptor.Invoke("toInt$$", "toInt(bool*, int) const", stack);
			ok = stack[1].s_bool;
			return stack[0].s_int;
		}
		public int ToInt(ref bool ok) {
			StackItem[] stack = new StackItem[2];
			stack[1].s_bool = ok;
			interceptor.Invoke("toInt$", "toInt(bool*) const", stack);
			ok = stack[1].s_bool;
			return stack[0].s_int;
		}
		public int ToInt() {
			return (int) interceptor.Invoke("toInt", "toInt() const", typeof(int));
		}
		public uint ToUInt(ref bool ok, int arg2) {
			StackItem[] stack = new StackItem[3];
			stack[1].s_bool = ok;
			stack[2].s_int = arg2;
			interceptor.Invoke("toUInt$$", "toUInt(bool*, int) const", stack);
			ok = stack[1].s_bool;
			return stack[0].s_uint;
		}
		public uint ToUInt(ref bool ok) {
			StackItem[] stack = new StackItem[2];
			stack[1].s_bool = ok;
			interceptor.Invoke("toUInt$", "toUInt(bool*) const", stack);
			ok = stack[1].s_bool;
			return stack[0].s_uint;
		}
		public uint ToUInt() {
			return (uint) interceptor.Invoke("toUInt", "toUInt() const", typeof(uint));
		}
		public long ToLong(ref bool ok, int arg2) {
			StackItem[] stack = new StackItem[3];
			stack[1].s_bool = ok;
			stack[2].s_int = arg2;
			interceptor.Invoke("toLong$$", "toLong(bool*, int) const", stack);
			ok = stack[1].s_bool;
			return stack[0].s_long;
		}
		public long ToLong(ref bool ok) {
			StackItem[] stack = new StackItem[2];
			stack[1].s_bool = ok;
			interceptor.Invoke("toLong$", "toLong(bool*) const", stack);
			ok = stack[1].s_bool;
			return stack[0].s_long;
		}
		public long ToLong() {
			return (long) interceptor.Invoke("toLong", "toLong() const", typeof(long));
		}
		public ulong ToULong(ref bool ok, int arg2) {
			StackItem[] stack = new StackItem[3];
			stack[1].s_bool = ok;
			stack[2].s_int = arg2;
			interceptor.Invoke("toULong$$", "toULong(bool*, int) const", stack);
			ok = stack[1].s_bool;
			return stack[0].s_ulong;
		}
		public ulong ToULong(ref bool ok) {
			StackItem[] stack = new StackItem[2];
			stack[1].s_bool = ok;
			interceptor.Invoke("toULong$", "toULong(bool*) const", stack);
			ok = stack[1].s_bool;
			return stack[0].s_ulong;
		}
		public ulong ToULong() {
			return (ulong) interceptor.Invoke("toULong", "toULong() const", typeof(ulong));
		}
		public long ToLongLong(ref bool ok, int arg2) {
			StackItem[] stack = new StackItem[3];
			stack[1].s_bool = ok;
			stack[2].s_int = arg2;
			interceptor.Invoke("toLongLong$$", "toLongLong(bool*, int) const", stack);
			ok = stack[1].s_bool;
			return stack[0].s_long;
		}
		public long ToLongLong(ref bool ok) {
			StackItem[] stack = new StackItem[2];
			stack[1].s_bool = ok;
			interceptor.Invoke("toLongLong$", "toLongLong(bool*) const", stack);
			ok = stack[1].s_bool;
			return stack[0].s_long;
		}
		public long ToLongLong() {
			return (long) interceptor.Invoke("toLongLong", "toLongLong() const", typeof(long));
		}
		public ulong ToULongLong(ref bool ok, int arg2) {
			StackItem[] stack = new StackItem[3];
			stack[1].s_bool = ok;
			stack[2].s_int = arg2;
			interceptor.Invoke("toULongLong$$", "toULongLong(bool*, int) const", stack);
			ok = stack[1].s_bool;
			return stack[0].s_ulong;
		}
		public ulong ToULongLong(ref bool ok) {
			StackItem[] stack = new StackItem[2];
			stack[1].s_bool = ok;
			interceptor.Invoke("toULongLong$", "toULongLong(bool*) const", stack);
			ok = stack[1].s_bool;
			return stack[0].s_ulong;
		}
		public ulong ToULongLong() {
			return (ulong) interceptor.Invoke("toULongLong", "toULongLong() const", typeof(ulong));
		}
		public float ToFloat(ref bool ok) {
			StackItem[] stack = new StackItem[2];
			stack[1].s_bool = ok;
			interceptor.Invoke("toFloat$", "toFloat(bool*) const", stack);
			ok = stack[1].s_bool;
			return stack[0].s_float;
		}
		public float ToFloat() {
			return (float) interceptor.Invoke("toFloat", "toFloat() const", typeof(float));
		}
		public double ToDouble(ref bool ok) {
			StackItem[] stack = new StackItem[2];
			stack[1].s_bool = ok;
			interceptor.Invoke("toDouble$", "toDouble(bool*) const", stack);
			ok = stack[1].s_bool;
			return stack[0].s_double;
		}
		public double ToDouble() {
			return (double) interceptor.Invoke("toDouble", "toDouble() const", typeof(double));
		}
		public QByteArray ToBase64() {
			return (QByteArray) interceptor.Invoke("toBase64", "toBase64() const", typeof(QByteArray));
		}
		public QByteArray ToHex() {
			return (QByteArray) interceptor.Invoke("toHex", "toHex() const", typeof(QByteArray));
		}
		public QByteArray ToPercentEncoding(QByteArray exclude, QByteArray include, char percent) {
			return (QByteArray) interceptor.Invoke("toPercentEncoding##$", "toPercentEncoding(const QByteArray&, const QByteArray&, char) const", typeof(QByteArray), typeof(QByteArray), exclude, typeof(QByteArray), include, typeof(char), percent);
		}
		public QByteArray ToPercentEncoding(QByteArray exclude, QByteArray include) {
			return (QByteArray) interceptor.Invoke("toPercentEncoding##", "toPercentEncoding(const QByteArray&, const QByteArray&) const", typeof(QByteArray), typeof(QByteArray), exclude, typeof(QByteArray), include);
		}
		public QByteArray ToPercentEncoding(QByteArray exclude) {
			return (QByteArray) interceptor.Invoke("toPercentEncoding#", "toPercentEncoding(const QByteArray&) const", typeof(QByteArray), typeof(QByteArray), exclude);
		}
		public QByteArray ToPercentEncoding() {
			return (QByteArray) interceptor.Invoke("toPercentEncoding", "toPercentEncoding() const", typeof(QByteArray));
		}
		public QByteArray SetNum(short arg1, int arg2) {
			return (QByteArray) interceptor.Invoke("setNum$$", "setNum(short, int)", typeof(QByteArray), typeof(short), arg1, typeof(int), arg2);
		}
		public QByteArray SetNum(short arg1) {
			return (QByteArray) interceptor.Invoke("setNum$", "setNum(short)", typeof(QByteArray), typeof(short), arg1);
		}
		public QByteArray SetNum(ushort arg1, int arg2) {
			return (QByteArray) interceptor.Invoke("setNum$$", "setNum(ushort, int)", typeof(QByteArray), typeof(ushort), arg1, typeof(int), arg2);
		}
		public QByteArray SetNum(ushort arg1) {
			return (QByteArray) interceptor.Invoke("setNum$", "setNum(ushort)", typeof(QByteArray), typeof(ushort), arg1);
		}
		public QByteArray SetNum(int arg1, int arg2) {
			return (QByteArray) interceptor.Invoke("setNum$$", "setNum(int, int)", typeof(QByteArray), typeof(int), arg1, typeof(int), arg2);
		}
		public QByteArray SetNum(int arg1) {
			return (QByteArray) interceptor.Invoke("setNum$", "setNum(int)", typeof(QByteArray), typeof(int), arg1);
		}
		public QByteArray SetNum(uint arg1, int arg2) {
			return (QByteArray) interceptor.Invoke("setNum$$", "setNum(uint, int)", typeof(QByteArray), typeof(uint), arg1, typeof(int), arg2);
		}
		public QByteArray SetNum(uint arg1) {
			return (QByteArray) interceptor.Invoke("setNum$", "setNum(uint)", typeof(QByteArray), typeof(uint), arg1);
		}
		public QByteArray SetNum(long arg1, int arg2) {
			return (QByteArray) interceptor.Invoke("setNum?$", "setNum(qlonglong, int)", typeof(QByteArray), typeof(long), arg1, typeof(int), arg2);
		}
		public QByteArray SetNum(long arg1) {
			return (QByteArray) interceptor.Invoke("setNum?", "setNum(qlonglong)", typeof(QByteArray), typeof(long), arg1);
		}
		public QByteArray SetNum(ulong arg1, int arg2) {
			return (QByteArray) interceptor.Invoke("setNum$$", "setNum(qulonglong, int)", typeof(QByteArray), typeof(ulong), arg1, typeof(int), arg2);
		}
		public QByteArray SetNum(ulong arg1) {
			return (QByteArray) interceptor.Invoke("setNum$", "setNum(qulonglong)", typeof(QByteArray), typeof(ulong), arg1);
		}
		public QByteArray SetNum(float arg1, char f, int prec) {
			return (QByteArray) interceptor.Invoke("setNum$$$", "setNum(float, char, int)", typeof(QByteArray), typeof(float), arg1, typeof(char), f, typeof(int), prec);
		}
		public QByteArray SetNum(float arg1, char f) {
			return (QByteArray) interceptor.Invoke("setNum$$", "setNum(float, char)", typeof(QByteArray), typeof(float), arg1, typeof(char), f);
		}
		public QByteArray SetNum(float arg1) {
			return (QByteArray) interceptor.Invoke("setNum$", "setNum(float)", typeof(QByteArray), typeof(float), arg1);
		}
		public QByteArray SetNum(double arg1, char f, int prec) {
			return (QByteArray) interceptor.Invoke("setNum$$$", "setNum(double, char, int)", typeof(QByteArray), typeof(double), arg1, typeof(char), f, typeof(int), prec);
		}
		public QByteArray SetNum(double arg1, char f) {
			return (QByteArray) interceptor.Invoke("setNum$$", "setNum(double, char)", typeof(QByteArray), typeof(double), arg1, typeof(char), f);
		}
		public QByteArray SetNum(double arg1) {
			return (QByteArray) interceptor.Invoke("setNum$", "setNum(double)", typeof(QByteArray), typeof(double), arg1);
		}
		public void Push_back(char c) {
			interceptor.Invoke("push_back$", "push_back(char)", typeof(void), typeof(char), c);
		}
		public void Push_back(string c) {
			interceptor.Invoke("push_back$", "push_back(const char*)", typeof(void), typeof(string), c);
		}
		public void Push_back(QByteArray a) {
			interceptor.Invoke("push_back#", "push_back(const QByteArray&)", typeof(void), typeof(QByteArray), a);
		}
		public void Push_front(char c) {
			interceptor.Invoke("push_front$", "push_front(char)", typeof(void), typeof(char), c);
		}
		public void Push_front(string c) {
			interceptor.Invoke("push_front$", "push_front(const char*)", typeof(void), typeof(string), c);
		}
		public void Push_front(QByteArray a) {
			interceptor.Invoke("push_front#", "push_front(const QByteArray&)", typeof(void), typeof(QByteArray), a);
		}
		public int Count() {
			return (int) interceptor.Invoke("count", "count() const", typeof(int));
		}
		public int Length() {
			return (int) interceptor.Invoke("length", "length() const", typeof(int));
		}
		public bool IsNull() {
			return (bool) interceptor.Invoke("isNull", "isNull() const", typeof(bool));
		}
		~QByteArray() {
			interceptor.Invoke("~QByteArray", "~QByteArray()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QByteArray", "~QByteArray()", typeof(void));
		}
		public static bool operator==(QByteArray lhs, string s2) {
			return (bool) staticInterceptor.Invoke("operator==$", "operator==(const QString&) const", typeof(bool), typeof(QByteArray), lhs, typeof(string), s2);
		}
		public static bool operator!=(QByteArray lhs, string s2) {
			return !(bool) staticInterceptor.Invoke("operator==$", "operator==(const QString&) const", typeof(bool), typeof(QByteArray), lhs, typeof(string), s2);
		}
		public static bool operator<(QByteArray lhs, string s2) {
			return (bool) staticInterceptor.Invoke("operator<$", "operator<(const QString&) const", typeof(bool), typeof(QByteArray), lhs, typeof(string), s2);
		}
		public static bool operator>(QByteArray lhs, string s2) {
			return (bool) staticInterceptor.Invoke("operator>$", "operator>(const QString&) const", typeof(bool), typeof(QByteArray), lhs, typeof(string), s2);
		}
		public static bool operator<=(QByteArray lhs, string s2) {
			return (bool) staticInterceptor.Invoke("operator<=$", "operator<=(const QString&) const", typeof(bool), typeof(QByteArray), lhs, typeof(string), s2);
		}
		public static bool operator>=(QByteArray lhs, string s2) {
			return (bool) staticInterceptor.Invoke("operator>=$", "operator>=(const QString&) const", typeof(bool), typeof(QByteArray), lhs, typeof(string), s2);
		}
		public static QByteArray Number(int arg1, int arg2) {
			return (QByteArray) staticInterceptor.Invoke("number$$", "number(int, int)", typeof(QByteArray), typeof(int), arg1, typeof(int), arg2);
		}
		public static QByteArray Number(int arg1) {
			return (QByteArray) staticInterceptor.Invoke("number$", "number(int)", typeof(QByteArray), typeof(int), arg1);
		}
		public static QByteArray Number(uint arg1, int arg2) {
			return (QByteArray) staticInterceptor.Invoke("number$$", "number(uint, int)", typeof(QByteArray), typeof(uint), arg1, typeof(int), arg2);
		}
		public static QByteArray Number(uint arg1) {
			return (QByteArray) staticInterceptor.Invoke("number$", "number(uint)", typeof(QByteArray), typeof(uint), arg1);
		}
		public static QByteArray Number(long arg1, int arg2) {
			return (QByteArray) staticInterceptor.Invoke("number?$", "number(qlonglong, int)", typeof(QByteArray), typeof(long), arg1, typeof(int), arg2);
		}
		public static QByteArray Number(long arg1) {
			return (QByteArray) staticInterceptor.Invoke("number?", "number(qlonglong)", typeof(QByteArray), typeof(long), arg1);
		}
		public static QByteArray Number(ulong arg1, int arg2) {
			return (QByteArray) staticInterceptor.Invoke("number$$", "number(qulonglong, int)", typeof(QByteArray), typeof(ulong), arg1, typeof(int), arg2);
		}
		public static QByteArray Number(ulong arg1) {
			return (QByteArray) staticInterceptor.Invoke("number$", "number(qulonglong)", typeof(QByteArray), typeof(ulong), arg1);
		}
		public static QByteArray Number(double arg1, char f, int prec) {
			return (QByteArray) staticInterceptor.Invoke("number$$$", "number(double, char, int)", typeof(QByteArray), typeof(double), arg1, typeof(char), f, typeof(int), prec);
		}
		public static QByteArray Number(double arg1, char f) {
			return (QByteArray) staticInterceptor.Invoke("number$$", "number(double, char)", typeof(QByteArray), typeof(double), arg1, typeof(char), f);
		}
		public static QByteArray Number(double arg1) {
			return (QByteArray) staticInterceptor.Invoke("number$", "number(double)", typeof(QByteArray), typeof(double), arg1);
		}
		public static QByteArray FromRawData(string arg1, int size) {
			return (QByteArray) staticInterceptor.Invoke("fromRawData$$", "fromRawData(const char*, int)", typeof(QByteArray), typeof(string), arg1, typeof(int), size);
		}
		public static QByteArray FromBase64(QByteArray base64) {
			return (QByteArray) staticInterceptor.Invoke("fromBase64#", "fromBase64(const QByteArray&)", typeof(QByteArray), typeof(QByteArray), base64);
		}
		public static QByteArray FromHex(QByteArray hexEncoded) {
			return (QByteArray) staticInterceptor.Invoke("fromHex#", "fromHex(const QByteArray&)", typeof(QByteArray), typeof(QByteArray), hexEncoded);
		}
		public static QByteArray FromPercentEncoding(QByteArray pctEncoded, char percent) {
			return (QByteArray) staticInterceptor.Invoke("fromPercentEncoding#$", "fromPercentEncoding(const QByteArray&, char)", typeof(QByteArray), typeof(QByteArray), pctEncoded, typeof(char), percent);
		}
		public static QByteArray FromPercentEncoding(QByteArray pctEncoded) {
			return (QByteArray) staticInterceptor.Invoke("fromPercentEncoding#", "fromPercentEncoding(const QByteArray&)", typeof(QByteArray), typeof(QByteArray), pctEncoded);
		}
		public static bool operator==(QByteArray a1, QByteArray a2) {
			return (bool) staticInterceptor.Invoke("operator==##", "operator==(const QByteArray&, const QByteArray&)", typeof(bool), typeof(QByteArray), a1, typeof(QByteArray), a2);
		}
		public static bool operator!=(QByteArray a1, QByteArray a2) {
			return !(bool) staticInterceptor.Invoke("operator==##", "operator==(const QByteArray&, const QByteArray&)", typeof(bool), typeof(QByteArray), a1, typeof(QByteArray), a2);
		}
		public static bool operator==(string a1, QByteArray a2) {
			return (bool) staticInterceptor.Invoke("operator==$#", "operator==(const char*, const QByteArray&)", typeof(bool), typeof(string), a1, typeof(QByteArray), a2);
		}
		public static bool operator!=(string a1, QByteArray a2) {
			return !(bool) staticInterceptor.Invoke("operator==$#", "operator==(const char*, const QByteArray&)", typeof(bool), typeof(string), a1, typeof(QByteArray), a2);
		}
		public static bool operator<(QByteArray a1, QByteArray a2) {
			return (bool) staticInterceptor.Invoke("operator<##", "operator<(const QByteArray&, const QByteArray&)", typeof(bool), typeof(QByteArray), a1, typeof(QByteArray), a2);
		}
		public static bool operator<(string a1, QByteArray a2) {
			return (bool) staticInterceptor.Invoke("operator<$#", "operator<(const char*, const QByteArray&)", typeof(bool), typeof(string), a1, typeof(QByteArray), a2);
		}
		public static bool operator<=(QByteArray a1, QByteArray a2) {
			return (bool) staticInterceptor.Invoke("operator<=##", "operator<=(const QByteArray&, const QByteArray&)", typeof(bool), typeof(QByteArray), a1, typeof(QByteArray), a2);
		}
		public static bool operator<=(string a1, QByteArray a2) {
			return (bool) staticInterceptor.Invoke("operator<=$#", "operator<=(const char*, const QByteArray&)", typeof(bool), typeof(string), a1, typeof(QByteArray), a2);
		}
		public static bool operator>(QByteArray a1, QByteArray a2) {
			return (bool) staticInterceptor.Invoke("operator>##", "operator>(const QByteArray&, const QByteArray&)", typeof(bool), typeof(QByteArray), a1, typeof(QByteArray), a2);
		}
		public static bool operator>(string a1, QByteArray a2) {
			return (bool) staticInterceptor.Invoke("operator>$#", "operator>(const char*, const QByteArray&)", typeof(bool), typeof(string), a1, typeof(QByteArray), a2);
		}
		public static bool operator>=(QByteArray a1, QByteArray a2) {
			return (bool) staticInterceptor.Invoke("operator>=##", "operator>=(const QByteArray&, const QByteArray&)", typeof(bool), typeof(QByteArray), a1, typeof(QByteArray), a2);
		}
		public static bool operator>=(string a1, QByteArray a2) {
			return (bool) staticInterceptor.Invoke("operator>=$#", "operator>=(const char*, const QByteArray&)", typeof(bool), typeof(string), a1, typeof(QByteArray), a2);
		}
		public static QByteArray operator+(QByteArray a1, QByteArray a2) {
			return (QByteArray) staticInterceptor.Invoke("operator+##", "operator+(const QByteArray&, const QByteArray&)", typeof(QByteArray), typeof(QByteArray), a1, typeof(QByteArray), a2);
		}
		public static QByteArray operator+(QByteArray a1, string a2) {
			return (QByteArray) staticInterceptor.Invoke("operator+#$", "operator+(const QByteArray&, const char*)", typeof(QByteArray), typeof(QByteArray), a1, typeof(string), a2);
		}
		public static QByteArray operator+(QByteArray a1, char a2) {
			return (QByteArray) staticInterceptor.Invoke("operator+#$", "operator+(const QByteArray&, char)", typeof(QByteArray), typeof(QByteArray), a1, typeof(char), a2);
		}
		public static QByteArray operator+(string a1, QByteArray a2) {
			return (QByteArray) staticInterceptor.Invoke("operator+$#", "operator+(const char*, const QByteArray&)", typeof(QByteArray), typeof(string), a1, typeof(QByteArray), a2);
		}
		public static QByteArray operator+(char a1, QByteArray a2) {
			return (QByteArray) staticInterceptor.Invoke("operator+$#", "operator+(char, const QByteArray&)", typeof(QByteArray), typeof(char), a1, typeof(QByteArray), a2);
		}
	}
}
