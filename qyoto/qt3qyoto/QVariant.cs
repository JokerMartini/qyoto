//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Collections;
	using System.Text;

	[SmokeClass("QVariant")]
	public class QVariant : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QVariant(Type dummy) {}
		interface IQVariantProxy {
			bool op_equals(QVariant lhs, QVariant arg1);
			string TypeToName(QVariant.E_Type typ);
			QVariant.E_Type NameToType(string name);
		}

		protected void CreateQVariantProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QVariant), this);
			_interceptor = (QVariant) realProxy.GetTransparentProxy();
		}
		private QVariant ProxyQVariant() {
			return (QVariant) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QVariant() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQVariantProxy), null);
			_staticInterceptor = (IQVariantProxy) realProxy.GetTransparentProxy();
		}
		private static IQVariantProxy StaticQVariant() {
			return (IQVariantProxy) _staticInterceptor;
		}

		public enum E_Type {
			Invalid = 0,
			Map = 1,
			List = 2,
			String = 3,
			StringList = 4,
			Font = 5,
			Pixmap = 6,
			Brush = 7,
			Rect = 8,
			Size = 9,
			Color = 10,
			Palette = 11,
			ColorGroup = 12,
			IconSet = 13,
			Point = 14,
			Image = 15,
			Int = 16,
			UInt = 17,
			Bool = 18,
			Double = 19,
			CString = 20,
			PointArray = 21,
			Region = 22,
			Bitmap = 23,
			Cursor = 24,
			SizePolicy = 25,
			Date = 26,
			Time = 27,
			DateTime = 28,
			ByteArray = 29,
			BitArray = 30,
			KeySequence = 31,
			Pen = 32,
			LongLong = 33,
			ULongLong = 34,
		}
		public QVariant() : this((Type) null) {
			CreateQVariantProxy();
			NewQVariant();
		}
		[SmokeMethod("QVariant()")]
		private void NewQVariant() {
			ProxyQVariant().NewQVariant();
		}
		public QVariant(QVariant arg1) : this((Type) null) {
			CreateQVariantProxy();
			NewQVariant(arg1);
		}
		[SmokeMethod("QVariant(const QVariant&)")]
		private void NewQVariant(QVariant arg1) {
			ProxyQVariant().NewQVariant(arg1);
		}
		public QVariant(QDataStream s) : this((Type) null) {
			CreateQVariantProxy();
			NewQVariant(s);
		}
		[SmokeMethod("QVariant(QDataStream&)")]
		private void NewQVariant(QDataStream s) {
			ProxyQVariant().NewQVariant(s);
		}
		public QVariant(string arg1) : this((Type) null) {
			CreateQVariantProxy();
			NewQVariant(arg1);
		}
		[SmokeMethod("QVariant(const QString&)")]
		private void NewQVariant(string arg1) {
			ProxyQVariant().NewQVariant(arg1);
		}
		public QVariant(string[] arg1) : this((Type) null) {
			CreateQVariantProxy();
			NewQVariant(arg1);
		}
		[SmokeMethod("QVariant(const QStringList&)")]
		private void NewQVariant(string[] arg1) {
			ProxyQVariant().NewQVariant(arg1);
		}
		public QVariant(QFont arg1) : this((Type) null) {
			CreateQVariantProxy();
			NewQVariant(arg1);
		}
		[SmokeMethod("QVariant(const QFont&)")]
		private void NewQVariant(QFont arg1) {
			ProxyQVariant().NewQVariant(arg1);
		}
		public QVariant(QPixmap arg1) : this((Type) null) {
			CreateQVariantProxy();
			NewQVariant(arg1);
		}
		[SmokeMethod("QVariant(const QPixmap&)")]
		private void NewQVariant(QPixmap arg1) {
			ProxyQVariant().NewQVariant(arg1);
		}
		public QVariant(QImage arg1) : this((Type) null) {
			CreateQVariantProxy();
			NewQVariant(arg1);
		}
		[SmokeMethod("QVariant(const QImage&)")]
		private void NewQVariant(QImage arg1) {
			ProxyQVariant().NewQVariant(arg1);
		}
		public QVariant(QBrush arg1) : this((Type) null) {
			CreateQVariantProxy();
			NewQVariant(arg1);
		}
		[SmokeMethod("QVariant(const QBrush&)")]
		private void NewQVariant(QBrush arg1) {
			ProxyQVariant().NewQVariant(arg1);
		}
		public QVariant(QPoint arg1) : this((Type) null) {
			CreateQVariantProxy();
			NewQVariant(arg1);
		}
		[SmokeMethod("QVariant(const QPoint&)")]
		private void NewQVariant(QPoint arg1) {
			ProxyQVariant().NewQVariant(arg1);
		}
		public QVariant(QRect arg1) : this((Type) null) {
			CreateQVariantProxy();
			NewQVariant(arg1);
		}
		[SmokeMethod("QVariant(const QRect&)")]
		private void NewQVariant(QRect arg1) {
			ProxyQVariant().NewQVariant(arg1);
		}
		public QVariant(QSize arg1) : this((Type) null) {
			CreateQVariantProxy();
			NewQVariant(arg1);
		}
		[SmokeMethod("QVariant(const QSize&)")]
		private void NewQVariant(QSize arg1) {
			ProxyQVariant().NewQVariant(arg1);
		}
		public QVariant(QColor arg1) : this((Type) null) {
			CreateQVariantProxy();
			NewQVariant(arg1);
		}
		[SmokeMethod("QVariant(const QColor&)")]
		private void NewQVariant(QColor arg1) {
			ProxyQVariant().NewQVariant(arg1);
		}
		public QVariant(QPalette arg1) : this((Type) null) {
			CreateQVariantProxy();
			NewQVariant(arg1);
		}
		[SmokeMethod("QVariant(const QPalette&)")]
		private void NewQVariant(QPalette arg1) {
			ProxyQVariant().NewQVariant(arg1);
		}
		public QVariant(QColorGroup arg1) : this((Type) null) {
			CreateQVariantProxy();
			NewQVariant(arg1);
		}
		[SmokeMethod("QVariant(const QColorGroup&)")]
		private void NewQVariant(QColorGroup arg1) {
			ProxyQVariant().NewQVariant(arg1);
		}
		public QVariant(QIconSet arg1) : this((Type) null) {
			CreateQVariantProxy();
			NewQVariant(arg1);
		}
		[SmokeMethod("QVariant(const QIconSet&)")]
		private void NewQVariant(QIconSet arg1) {
			ProxyQVariant().NewQVariant(arg1);
		}
		public QVariant(QPointArray arg1) : this((Type) null) {
			CreateQVariantProxy();
			NewQVariant(arg1);
		}
		[SmokeMethod("QVariant(const QPointArray&)")]
		private void NewQVariant(QPointArray arg1) {
			ProxyQVariant().NewQVariant(arg1);
		}
		public QVariant(QRegion arg1) : this((Type) null) {
			CreateQVariantProxy();
			NewQVariant(arg1);
		}
		[SmokeMethod("QVariant(const QRegion&)")]
		private void NewQVariant(QRegion arg1) {
			ProxyQVariant().NewQVariant(arg1);
		}
		public QVariant(QBitmap arg1) : this((Type) null) {
			CreateQVariantProxy();
			NewQVariant(arg1);
		}
		[SmokeMethod("QVariant(const QBitmap&)")]
		private void NewQVariant(QBitmap arg1) {
			ProxyQVariant().NewQVariant(arg1);
		}
		public QVariant(QCursor arg1) : this((Type) null) {
			CreateQVariantProxy();
			NewQVariant(arg1);
		}
		[SmokeMethod("QVariant(const QCursor&)")]
		private void NewQVariant(QCursor arg1) {
			ProxyQVariant().NewQVariant(arg1);
		}
		public QVariant(DateTime arg1) : this((Type) null) {
			CreateQVariantProxy();
			NewQVariant(arg1);
		}
		[SmokeMethod("QVariant(const QDate&)")]
		private void NewQVariant(DateTime arg1) {
			ProxyQVariant().NewQVariant(arg1);
		}
		public QVariant(QByteArray arg1) : this((Type) null) {
			CreateQVariantProxy();
			NewQVariant(arg1);
		}
		[SmokeMethod("QVariant(const QByteArray&)")]
		private void NewQVariant(QByteArray arg1) {
			ProxyQVariant().NewQVariant(arg1);
		}
		// QVariant* QVariant(const QBitArray& arg1); >>>> NOT CONVERTED
		public QVariant(QKeySequence arg1) : this((Type) null) {
			CreateQVariantProxy();
			NewQVariant(arg1);
		}
		[SmokeMethod("QVariant(const QKeySequence&)")]
		private void NewQVariant(QKeySequence arg1) {
			ProxyQVariant().NewQVariant(arg1);
		}
		public QVariant(QPen arg1) : this((Type) null) {
			CreateQVariantProxy();
			NewQVariant(arg1);
		}
		[SmokeMethod("QVariant(const QPen&)")]
		private void NewQVariant(QPen arg1) {
			ProxyQVariant().NewQVariant(arg1);
		}
		// QVariant* QVariant(const QValueList<QVariant>& arg1); >>>> NOT CONVERTED
		// QVariant* QVariant(const QMap<QString, QVariant>& arg1); >>>> NOT CONVERTED
		public QVariant(int arg1) : this((Type) null) {
			CreateQVariantProxy();
			NewQVariant(arg1);
		}
		[SmokeMethod("QVariant(int)")]
		private void NewQVariant(int arg1) {
			ProxyQVariant().NewQVariant(arg1);
		}
		public QVariant(uint arg1) : this((Type) null) {
			CreateQVariantProxy();
			NewQVariant(arg1);
		}
		[SmokeMethod("QVariant(uint)")]
		private void NewQVariant(uint arg1) {
			ProxyQVariant().NewQVariant(arg1);
		}
		// QVariant* QVariant(Q_LLONG arg1); >>>> NOT CONVERTED
		// QVariant* QVariant(Q_ULLONG arg1); >>>> NOT CONVERTED
		public QVariant(bool arg1, int arg2) : this((Type) null) {
			CreateQVariantProxy();
			NewQVariant(arg1,arg2);
		}
		[SmokeMethod("QVariant(bool, int)")]
		private void NewQVariant(bool arg1, int arg2) {
			ProxyQVariant().NewQVariant(arg1,arg2);
		}
		public QVariant(double arg1) : this((Type) null) {
			CreateQVariantProxy();
			NewQVariant(arg1);
		}
		[SmokeMethod("QVariant(double)")]
		private void NewQVariant(double arg1) {
			ProxyQVariant().NewQVariant(arg1);
		}
		public QVariant(QSizePolicy arg1) : this((Type) null) {
			CreateQVariantProxy();
			NewQVariant(arg1);
		}
		[SmokeMethod("QVariant(QSizePolicy)")]
		private void NewQVariant(QSizePolicy arg1) {
			ProxyQVariant().NewQVariant(arg1);
		}
		[SmokeMethod("operator==(const QVariant&) const")]
		public static bool operator==(QVariant lhs, QVariant arg1) {
			return StaticQVariant().op_equals(lhs,arg1);
		}
		public static bool operator!=(QVariant lhs, QVariant arg1) {
			return !StaticQVariant().op_equals(lhs,arg1);
		}
		public override bool Equals(object o) {
			if (!(o is QVariant)) { return false; }
			return this == (QVariant) o;
		}
		public override int GetHashCode() {
			return ProxyQVariant().GetHashCode();
		}
		[SmokeMethod("typeName() const")]
		public string TypeName() {
			return ProxyQVariant().TypeName();
		}
		[SmokeMethod("canCast(QVariant::Type) const")]
		public bool CanCast(QVariant.E_Type arg1) {
			return ProxyQVariant().CanCast(arg1);
		}
		[SmokeMethod("cast(QVariant::Type)")]
		public bool Cast(QVariant.E_Type arg1) {
			return ProxyQVariant().Cast(arg1);
		}
		[SmokeMethod("isValid() const")]
		public bool IsValid() {
			return ProxyQVariant().IsValid();
		}
		[SmokeMethod("isNull() const")]
		public bool IsNull() {
			return ProxyQVariant().IsNull();
		}
		[SmokeMethod("clear()")]
		public void Clear() {
			ProxyQVariant().Clear();
		}
		[SmokeMethod("toString() const")]
		public new string ToString() {
			return ProxyQVariant().ToString();
		}
		[SmokeMethod("toCString() const")]
		public string ToCString() {
			return ProxyQVariant().ToCString();
		}
		[SmokeMethod("toStringList() const")]
		public ArrayList ToStringList() {
			return ProxyQVariant().ToStringList();
		}
		[SmokeMethod("toFont() const")]
		public QFont ToFont() {
			return ProxyQVariant().ToFont();
		}
		[SmokeMethod("toPixmap() const")]
		public QPixmap ToPixmap() {
			return ProxyQVariant().ToPixmap();
		}
		[SmokeMethod("toImage() const")]
		public QImage ToImage() {
			return ProxyQVariant().ToImage();
		}
		[SmokeMethod("toBrush() const")]
		public QBrush ToBrush() {
			return ProxyQVariant().ToBrush();
		}
		[SmokeMethod("toPoint() const")]
		public QPoint ToPoint() {
			return ProxyQVariant().ToPoint();
		}
		[SmokeMethod("toRect() const")]
		public QRect ToRect() {
			return ProxyQVariant().ToRect();
		}
		[SmokeMethod("toSize() const")]
		public QSize ToSize() {
			return ProxyQVariant().ToSize();
		}
		[SmokeMethod("toColor() const")]
		public QColor ToColor() {
			return ProxyQVariant().ToColor();
		}
		[SmokeMethod("toPalette() const")]
		public QPalette ToPalette() {
			return ProxyQVariant().ToPalette();
		}
		[SmokeMethod("toColorGroup() const")]
		public QColorGroup ToColorGroup() {
			return ProxyQVariant().ToColorGroup();
		}
		[SmokeMethod("toIconSet() const")]
		public QIconSet ToIconSet() {
			return ProxyQVariant().ToIconSet();
		}
		[SmokeMethod("toPointArray() const")]
		public QPointArray ToPointArray() {
			return ProxyQVariant().ToPointArray();
		}
		[SmokeMethod("toBitmap() const")]
		public QBitmap ToBitmap() {
			return ProxyQVariant().ToBitmap();
		}
		[SmokeMethod("toRegion() const")]
		public QRegion ToRegion() {
			return ProxyQVariant().ToRegion();
		}
		[SmokeMethod("toCursor() const")]
		public QCursor ToCursor() {
			return ProxyQVariant().ToCursor();
		}
		[SmokeMethod("toDate() const")]
		public DateTime ToDate() {
			return ProxyQVariant().ToDate();
		}
		[SmokeMethod("toTime() const")]
		public DateTime ToTime() {
			return ProxyQVariant().ToTime();
		}
		[SmokeMethod("toDateTime() const")]
		public DateTime ToDateTime() {
			return ProxyQVariant().ToDateTime();
		}
		[SmokeMethod("toByteArray() const")]
		public QByteArray ToByteArray() {
			return ProxyQVariant().ToByteArray();
		}
		// const QBitArray toBitArray(); >>>> NOT CONVERTED
		[SmokeMethod("toKeySequence() const")]
		public QKeySequence ToKeySequence() {
			return ProxyQVariant().ToKeySequence();
		}
		[SmokeMethod("toPen() const")]
		public QPen ToPen() {
			return ProxyQVariant().ToPen();
		}
		[SmokeMethod("toInt(bool*) const")]
		public int ToInt(out bool ok) {
			return ProxyQVariant().ToInt(out ok);
		}
		[SmokeMethod("toInt() const")]
		public int ToInt() {
			return ProxyQVariant().ToInt();
		}
		[SmokeMethod("toUInt(bool*) const")]
		public uint ToUInt(out bool ok) {
			return ProxyQVariant().ToUInt(out ok);
		}
		[SmokeMethod("toUInt() const")]
		public uint ToUInt() {
			return ProxyQVariant().ToUInt();
		}
		// Q_LLONG toLongLong(bool* arg1); >>>> NOT CONVERTED
		// Q_LLONG toLongLong(); >>>> NOT CONVERTED
		// Q_ULLONG toULongLong(bool* arg1); >>>> NOT CONVERTED
		// Q_ULLONG toULongLong(); >>>> NOT CONVERTED
		[SmokeMethod("toBool() const")]
		public bool ToBool() {
			return ProxyQVariant().ToBool();
		}
		[SmokeMethod("toDouble(bool*) const")]
		public double ToDouble(out bool ok) {
			return ProxyQVariant().ToDouble(out ok);
		}
		[SmokeMethod("toDouble() const")]
		public double ToDouble() {
			return ProxyQVariant().ToDouble();
		}
		// const QValueList<QVariant> toList(); >>>> NOT CONVERTED
		// const QMap<QString, QVariant> toMap(); >>>> NOT CONVERTED
		[SmokeMethod("toSizePolicy() const")]
		public QSizePolicy ToSizePolicy() {
			return ProxyQVariant().ToSizePolicy();
		}
		// QValueListConstIterator<QString> stringListBegin(); >>>> NOT CONVERTED
		// QValueListConstIterator<QString> stringListEnd(); >>>> NOT CONVERTED
		// QValueListConstIterator<QVariant> listBegin(); >>>> NOT CONVERTED
		// QValueListConstIterator<QVariant> listEnd(); >>>> NOT CONVERTED
		// QMapConstIterator<QString, QVariant> mapBegin(); >>>> NOT CONVERTED
		// QMapConstIterator<QString, QVariant> mapEnd(); >>>> NOT CONVERTED
		// QMapConstIterator<QString, QVariant> mapFind(const QString& arg1); >>>> NOT CONVERTED
		[SmokeMethod("asString()")]
		public string AsString() {
			return ProxyQVariant().AsString();
		}
		[SmokeMethod("asCString()")]
		public string AsCString() {
			return ProxyQVariant().AsCString();
		}
		[SmokeMethod("asStringList()")]
		public ArrayList AsStringList() {
			return ProxyQVariant().AsStringList();
		}
		[SmokeMethod("asFont()")]
		public QFont AsFont() {
			return ProxyQVariant().AsFont();
		}
		[SmokeMethod("asPixmap()")]
		public QPixmap AsPixmap() {
			return ProxyQVariant().AsPixmap();
		}
		[SmokeMethod("asImage()")]
		public QImage AsImage() {
			return ProxyQVariant().AsImage();
		}
		[SmokeMethod("asBrush()")]
		public QBrush AsBrush() {
			return ProxyQVariant().AsBrush();
		}
		[SmokeMethod("asPoint()")]
		public QPoint AsPoint() {
			return ProxyQVariant().AsPoint();
		}
		[SmokeMethod("asRect()")]
		public QRect AsRect() {
			return ProxyQVariant().AsRect();
		}
		[SmokeMethod("asSize()")]
		public QSize AsSize() {
			return ProxyQVariant().AsSize();
		}
		[SmokeMethod("asColor()")]
		public QColor AsColor() {
			return ProxyQVariant().AsColor();
		}
		[SmokeMethod("asPalette()")]
		public QPalette AsPalette() {
			return ProxyQVariant().AsPalette();
		}
		[SmokeMethod("asColorGroup()")]
		public QColorGroup AsColorGroup() {
			return ProxyQVariant().AsColorGroup();
		}
		[SmokeMethod("asIconSet()")]
		public QIconSet AsIconSet() {
			return ProxyQVariant().AsIconSet();
		}
		[SmokeMethod("asPointArray()")]
		public QPointArray AsPointArray() {
			return ProxyQVariant().AsPointArray();
		}
		[SmokeMethod("asBitmap()")]
		public QBitmap AsBitmap() {
			return ProxyQVariant().AsBitmap();
		}
		[SmokeMethod("asRegion()")]
		public QRegion AsRegion() {
			return ProxyQVariant().AsRegion();
		}
		[SmokeMethod("asCursor()")]
		public QCursor AsCursor() {
			return ProxyQVariant().AsCursor();
		}
		[SmokeMethod("asDate()")]
		public DateTime AsDate() {
			return ProxyQVariant().AsDate();
		}
		[SmokeMethod("asTime()")]
		public DateTime AsTime() {
			return ProxyQVariant().AsTime();
		}
		[SmokeMethod("asDateTime()")]
		public DateTime AsDateTime() {
			return ProxyQVariant().AsDateTime();
		}
		[SmokeMethod("asByteArray()")]
		public QByteArray AsByteArray() {
			return ProxyQVariant().AsByteArray();
		}
		// QBitArray& asBitArray(); >>>> NOT CONVERTED
		[SmokeMethod("asKeySequence()")]
		public QKeySequence AsKeySequence() {
			return ProxyQVariant().AsKeySequence();
		}
		[SmokeMethod("asPen()")]
		public QPen AsPen() {
			return ProxyQVariant().AsPen();
		}
		[SmokeMethod("asInt()")]
		public int AsInt() {
			return ProxyQVariant().AsInt();
		}
		[SmokeMethod("asUInt()")]
		public uint AsUInt() {
			return ProxyQVariant().AsUInt();
		}
		// Q_LLONG& asLongLong(); >>>> NOT CONVERTED
		// Q_ULLONG& asULongLong(); >>>> NOT CONVERTED
		[SmokeMethod("asBool()")]
		public bool AsBool() {
			return ProxyQVariant().AsBool();
		}
		[SmokeMethod("asDouble()")]
		public double AsDouble() {
			return ProxyQVariant().AsDouble();
		}
		// QValueList<QVariant>& asList(); >>>> NOT CONVERTED
		// QMap<QString, QVariant>& asMap(); >>>> NOT CONVERTED
		[SmokeMethod("asSizePolicy()")]
		public QSizePolicy AsSizePolicy() {
			return ProxyQVariant().AsSizePolicy();
		}
		[SmokeMethod("load(QDataStream&)")]
		public void Load(QDataStream arg1) {
			ProxyQVariant().Load(arg1);
		}
		[SmokeMethod("save(QDataStream&) const")]
		public void Save(QDataStream arg1) {
			ProxyQVariant().Save(arg1);
		}
		// void* rawAccess(void* arg1,QVariant::Type arg2,bool arg3); >>>> NOT CONVERTED
		// void* rawAccess(void* arg1,QVariant::Type arg2); >>>> NOT CONVERTED
		// void* rawAccess(void* arg1); >>>> NOT CONVERTED
		// void* rawAccess(); >>>> NOT CONVERTED
		[SmokeMethod("typeToName(QVariant::Type)")]
		public static string TypeToName(QVariant.E_Type typ) {
			return StaticQVariant().TypeToName(typ);
		}
		[SmokeMethod("nameToType(const char*)")]
		public static QVariant.E_Type NameToType(string name) {
			return StaticQVariant().NameToType(name);
		}
		~QVariant() {
			DisposeQVariant();
		}
		public void Dispose() {
			DisposeQVariant();
		}
		private void DisposeQVariant() {
			ProxyQVariant().DisposeQVariant();
		}
	}
}
