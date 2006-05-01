//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Collections;
	using System.Text;

	[SmokeClass("QColor")]
	public class QColor : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QColor(Type dummy) {}
		interface IQColorProxy {
			bool op_equals(QColor lhs, QColor c);
			ArrayList ColorNames();
			QColor FromRgb(uint rgb);
			QColor FromRgba(uint rgba);
			QColor FromRgb(int r, int g, int b, int a);
			QColor FromRgb(int r, int g, int b);
			QColor FromRgbF(double r, double g, double b, double a);
			QColor FromRgbF(double r, double g, double b);
			QColor FromHsv(int h, int s, int v, int a);
			QColor FromHsv(int h, int s, int v);
			QColor FromHsvF(double h, double s, double v, double a);
			QColor FromHsvF(double h, double s, double v);
			QColor FromCmyk(int c, int m, int y, int k, int a);
			QColor FromCmyk(int c, int m, int y, int k);
			QColor FromCmykF(double c, double m, double y, double k, double a);
			QColor FromCmykF(double c, double m, double y, double k);
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QColor), this);
			_interceptor = (QColor) realProxy.GetTransparentProxy();
		}
		private QColor ProxyQColor() {
			return (QColor) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QColor() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQColorProxy), null);
			_staticInterceptor = (IQColorProxy) realProxy.GetTransparentProxy();
		}
		private static IQColorProxy StaticQColor() {
			return (IQColorProxy) _staticInterceptor;
		}

		public enum Spec {
			Invalid = 0,
			Rgb = 1,
			Hsv = 2,
			Cmyk = 3,
		}
		public QColor() : this((Type) null) {
			CreateProxy();
			NewQColor();
		}
		[SmokeMethod("QColor()")]
		private void NewQColor() {
			ProxyQColor().NewQColor();
		}
		public QColor(Qt.GlobalColor color) : this((Type) null) {
			CreateProxy();
			NewQColor(color);
		}
		[SmokeMethod("QColor(Qt::GlobalColor)")]
		private void NewQColor(Qt.GlobalColor color) {
			ProxyQColor().NewQColor(color);
		}
		public QColor(int r, int g, int b, int a) : this((Type) null) {
			CreateProxy();
			NewQColor(r,g,b,a);
		}
		[SmokeMethod("QColor(int, int, int, int)")]
		private void NewQColor(int r, int g, int b, int a) {
			ProxyQColor().NewQColor(r,g,b,a);
		}
		public QColor(int r, int g, int b) : this((Type) null) {
			CreateProxy();
			NewQColor(r,g,b);
		}
		[SmokeMethod("QColor(int, int, int)")]
		private void NewQColor(int r, int g, int b) {
			ProxyQColor().NewQColor(r,g,b);
		}
		public QColor(uint rgb) : this((Type) null) {
			CreateProxy();
			NewQColor(rgb);
		}
		[SmokeMethod("QColor(QRgb)")]
		private void NewQColor(uint rgb) {
			ProxyQColor().NewQColor(rgb);
		}
		public QColor(string name) : this((Type) null) {
			CreateProxy();
			NewQColor(name);
		}
		[SmokeMethod("QColor(const QString&)")]
		private void NewQColor(string name) {
			ProxyQColor().NewQColor(name);
		}
		public QColor(QColor color) : this((Type) null) {
			CreateProxy();
			NewQColor(color);
		}
		[SmokeMethod("QColor(const QColor&)")]
		private void NewQColor(QColor color) {
			ProxyQColor().NewQColor(color);
		}
		[SmokeMethod("isValid() const")]
		public bool IsValid() {
			return ProxyQColor().IsValid();
		}
		[SmokeMethod("name() const")]
		public string Name() {
			return ProxyQColor().Name();
		}
		[SmokeMethod("setNamedColor(const QString&)")]
		public void SetNamedColor(string name) {
			ProxyQColor().SetNamedColor(name);
		}
		[SmokeMethod("spec() const")]
		public QColor.Spec spec() {
			return ProxyQColor().spec();
		}
		[SmokeMethod("alpha() const")]
		public int Alpha() {
			return ProxyQColor().Alpha();
		}
		[SmokeMethod("setAlpha(int)")]
		public void SetAlpha(int alpha) {
			ProxyQColor().SetAlpha(alpha);
		}
		[SmokeMethod("alphaF() const")]
		public double AlphaF() {
			return ProxyQColor().AlphaF();
		}
		[SmokeMethod("setAlphaF(qreal)")]
		public void SetAlphaF(double alpha) {
			ProxyQColor().SetAlphaF(alpha);
		}
		[SmokeMethod("red() const")]
		public int Red() {
			return ProxyQColor().Red();
		}
		[SmokeMethod("green() const")]
		public int Green() {
			return ProxyQColor().Green();
		}
		[SmokeMethod("blue() const")]
		public int Blue() {
			return ProxyQColor().Blue();
		}
		[SmokeMethod("setRed(int)")]
		public void SetRed(int red) {
			ProxyQColor().SetRed(red);
		}
		[SmokeMethod("setGreen(int)")]
		public void SetGreen(int green) {
			ProxyQColor().SetGreen(green);
		}
		[SmokeMethod("setBlue(int)")]
		public void SetBlue(int blue) {
			ProxyQColor().SetBlue(blue);
		}
		[SmokeMethod("redF() const")]
		public double RedF() {
			return ProxyQColor().RedF();
		}
		[SmokeMethod("greenF() const")]
		public double GreenF() {
			return ProxyQColor().GreenF();
		}
		[SmokeMethod("blueF() const")]
		public double BlueF() {
			return ProxyQColor().BlueF();
		}
		[SmokeMethod("setRedF(qreal)")]
		public void SetRedF(double red) {
			ProxyQColor().SetRedF(red);
		}
		[SmokeMethod("setGreenF(qreal)")]
		public void SetGreenF(double green) {
			ProxyQColor().SetGreenF(green);
		}
		[SmokeMethod("setBlueF(qreal)")]
		public void SetBlueF(double blue) {
			ProxyQColor().SetBlueF(blue);
		}
		[SmokeMethod("getRgb(int*, int*, int*, int*) const")]
		public void GetRgb(out int r, out int g, out int b, out int a) {
			ProxyQColor().GetRgb(out r,out g,out b,out a);
		}
		[SmokeMethod("getRgb(int*, int*, int*) const")]
		public void GetRgb(out int r, out int g, out int b) {
			ProxyQColor().GetRgb(out r,out g,out b);
		}
		[SmokeMethod("setRgb(int, int, int, int)")]
		public void SetRgb(int r, int g, int b, int a) {
			ProxyQColor().SetRgb(r,g,b,a);
		}
		[SmokeMethod("setRgb(int, int, int)")]
		public void SetRgb(int r, int g, int b) {
			ProxyQColor().SetRgb(r,g,b);
		}
		// void getRgbF(qreal* arg1,qreal* arg2,qreal* arg3,qreal* arg4); >>>> NOT CONVERTED
		// void getRgbF(qreal* arg1,qreal* arg2,qreal* arg3); >>>> NOT CONVERTED
		[SmokeMethod("setRgbF(qreal, qreal, qreal, qreal)")]
		public void SetRgbF(double r, double g, double b, double a) {
			ProxyQColor().SetRgbF(r,g,b,a);
		}
		[SmokeMethod("setRgbF(qreal, qreal, qreal)")]
		public void SetRgbF(double r, double g, double b) {
			ProxyQColor().SetRgbF(r,g,b);
		}
		[SmokeMethod("rgba() const")]
		public uint Rgba() {
			return ProxyQColor().Rgba();
		}
		[SmokeMethod("setRgba(QRgb)")]
		public void SetRgba(uint rgba) {
			ProxyQColor().SetRgba(rgba);
		}
		[SmokeMethod("rgb() const")]
		public uint Rgb() {
			return ProxyQColor().Rgb();
		}
		[SmokeMethod("setRgb(QRgb)")]
		public void SetRgb(uint rgb) {
			ProxyQColor().SetRgb(rgb);
		}
		[SmokeMethod("hue() const")]
		public int Hue() {
			return ProxyQColor().Hue();
		}
		[SmokeMethod("saturation() const")]
		public int Saturation() {
			return ProxyQColor().Saturation();
		}
		[SmokeMethod("value() const")]
		public int Value() {
			return ProxyQColor().Value();
		}
		[SmokeMethod("hueF() const")]
		public double HueF() {
			return ProxyQColor().HueF();
		}
		[SmokeMethod("saturationF() const")]
		public double SaturationF() {
			return ProxyQColor().SaturationF();
		}
		[SmokeMethod("valueF() const")]
		public double ValueF() {
			return ProxyQColor().ValueF();
		}
		[SmokeMethod("getHsv(int*, int*, int*, int*) const")]
		public void GetHsv(out int h, out int s, out int v, out int a) {
			ProxyQColor().GetHsv(out h,out s,out v,out a);
		}
		[SmokeMethod("getHsv(int*, int*, int*) const")]
		public void GetHsv(out int h, out int s, out int v) {
			ProxyQColor().GetHsv(out h,out s,out v);
		}
		[SmokeMethod("setHsv(int, int, int, int)")]
		public void SetHsv(int h, int s, int v, int a) {
			ProxyQColor().SetHsv(h,s,v,a);
		}
		[SmokeMethod("setHsv(int, int, int)")]
		public void SetHsv(int h, int s, int v) {
			ProxyQColor().SetHsv(h,s,v);
		}
		// void getHsvF(qreal* arg1,qreal* arg2,qreal* arg3,qreal* arg4); >>>> NOT CONVERTED
		// void getHsvF(qreal* arg1,qreal* arg2,qreal* arg3); >>>> NOT CONVERTED
		[SmokeMethod("setHsvF(qreal, qreal, qreal, qreal)")]
		public void SetHsvF(double h, double s, double v, double a) {
			ProxyQColor().SetHsvF(h,s,v,a);
		}
		[SmokeMethod("setHsvF(qreal, qreal, qreal)")]
		public void SetHsvF(double h, double s, double v) {
			ProxyQColor().SetHsvF(h,s,v);
		}
		[SmokeMethod("cyan() const")]
		public int Cyan() {
			return ProxyQColor().Cyan();
		}
		[SmokeMethod("magenta() const")]
		public int Magenta() {
			return ProxyQColor().Magenta();
		}
		[SmokeMethod("yellow() const")]
		public int Yellow() {
			return ProxyQColor().Yellow();
		}
		[SmokeMethod("black() const")]
		public int Black() {
			return ProxyQColor().Black();
		}
		[SmokeMethod("cyanF() const")]
		public double CyanF() {
			return ProxyQColor().CyanF();
		}
		[SmokeMethod("magentaF() const")]
		public double MagentaF() {
			return ProxyQColor().MagentaF();
		}
		[SmokeMethod("yellowF() const")]
		public double YellowF() {
			return ProxyQColor().YellowF();
		}
		[SmokeMethod("blackF() const")]
		public double BlackF() {
			return ProxyQColor().BlackF();
		}
		[SmokeMethod("getCmyk(int*, int*, int*, int*, int*)")]
		public void GetCmyk(out int c, out int m, out int y, out int k, out int a) {
			ProxyQColor().GetCmyk(out c,out m,out y,out k,out a);
		}
		[SmokeMethod("getCmyk(int*, int*, int*, int*)")]
		public void GetCmyk(out int c, out int m, out int y, out int k) {
			ProxyQColor().GetCmyk(out c,out m,out y,out k);
		}
		[SmokeMethod("setCmyk(int, int, int, int, int)")]
		public void SetCmyk(int c, int m, int y, int k, int a) {
			ProxyQColor().SetCmyk(c,m,y,k,a);
		}
		[SmokeMethod("setCmyk(int, int, int, int)")]
		public void SetCmyk(int c, int m, int y, int k) {
			ProxyQColor().SetCmyk(c,m,y,k);
		}
		// void getCmykF(qreal* arg1,qreal* arg2,qreal* arg3,qreal* arg4,qreal* arg5); >>>> NOT CONVERTED
		// void getCmykF(qreal* arg1,qreal* arg2,qreal* arg3,qreal* arg4); >>>> NOT CONVERTED
		[SmokeMethod("setCmykF(qreal, qreal, qreal, qreal, qreal)")]
		public void SetCmykF(double c, double m, double y, double k, double a) {
			ProxyQColor().SetCmykF(c,m,y,k,a);
		}
		[SmokeMethod("setCmykF(qreal, qreal, qreal, qreal)")]
		public void SetCmykF(double c, double m, double y, double k) {
			ProxyQColor().SetCmykF(c,m,y,k);
		}
		[SmokeMethod("toRgb() const")]
		public QColor ToRgb() {
			return ProxyQColor().ToRgb();
		}
		[SmokeMethod("toHsv() const")]
		public QColor ToHsv() {
			return ProxyQColor().ToHsv();
		}
		[SmokeMethod("toCmyk() const")]
		public QColor ToCmyk() {
			return ProxyQColor().ToCmyk();
		}
		[SmokeMethod("convertTo(QColor::Spec) const")]
		public QColor ConvertTo(QColor.Spec colorSpec) {
			return ProxyQColor().ConvertTo(colorSpec);
		}
		[SmokeMethod("light(int) const")]
		public QColor Light(int f) {
			return ProxyQColor().Light(f);
		}
		[SmokeMethod("light() const")]
		public QColor Light() {
			return ProxyQColor().Light();
		}
		[SmokeMethod("dark(int) const")]
		public QColor Dark(int f) {
			return ProxyQColor().Dark(f);
		}
		[SmokeMethod("dark() const")]
		public QColor Dark() {
			return ProxyQColor().Dark();
		}
		[SmokeMethod("operator==(const QColor&) const")]
		public static bool operator==(QColor lhs, QColor c) {
			return StaticQColor().op_equals(lhs,c);
		}
		public static bool operator!=(QColor lhs, QColor c) {
			return !StaticQColor().op_equals(lhs,c);
		}
		public override bool Equals(object o) {
			if (!(o is QColor)) { return false; }
			return this == (QColor) o;
		}
		public override int GetHashCode() {
			return ProxyQColor().GetHashCode();
		}
		//  operator QVariant(); >>>> NOT CONVERTED
		[SmokeMethod("colorNames()")]
		public static ArrayList ColorNames() {
			return StaticQColor().ColorNames();
		}
		[SmokeMethod("fromRgb(QRgb)")]
		public static QColor FromRgb(uint rgb) {
			return StaticQColor().FromRgb(rgb);
		}
		[SmokeMethod("fromRgba(QRgb)")]
		public static QColor FromRgba(uint rgba) {
			return StaticQColor().FromRgba(rgba);
		}
		[SmokeMethod("fromRgb(int, int, int, int)")]
		public static QColor FromRgb(int r, int g, int b, int a) {
			return StaticQColor().FromRgb(r,g,b,a);
		}
		[SmokeMethod("fromRgb(int, int, int)")]
		public static QColor FromRgb(int r, int g, int b) {
			return StaticQColor().FromRgb(r,g,b);
		}
		[SmokeMethod("fromRgbF(qreal, qreal, qreal, qreal)")]
		public static QColor FromRgbF(double r, double g, double b, double a) {
			return StaticQColor().FromRgbF(r,g,b,a);
		}
		[SmokeMethod("fromRgbF(qreal, qreal, qreal)")]
		public static QColor FromRgbF(double r, double g, double b) {
			return StaticQColor().FromRgbF(r,g,b);
		}
		[SmokeMethod("fromHsv(int, int, int, int)")]
		public static QColor FromHsv(int h, int s, int v, int a) {
			return StaticQColor().FromHsv(h,s,v,a);
		}
		[SmokeMethod("fromHsv(int, int, int)")]
		public static QColor FromHsv(int h, int s, int v) {
			return StaticQColor().FromHsv(h,s,v);
		}
		[SmokeMethod("fromHsvF(qreal, qreal, qreal, qreal)")]
		public static QColor FromHsvF(double h, double s, double v, double a) {
			return StaticQColor().FromHsvF(h,s,v,a);
		}
		[SmokeMethod("fromHsvF(qreal, qreal, qreal)")]
		public static QColor FromHsvF(double h, double s, double v) {
			return StaticQColor().FromHsvF(h,s,v);
		}
		[SmokeMethod("fromCmyk(int, int, int, int, int)")]
		public static QColor FromCmyk(int c, int m, int y, int k, int a) {
			return StaticQColor().FromCmyk(c,m,y,k,a);
		}
		[SmokeMethod("fromCmyk(int, int, int, int)")]
		public static QColor FromCmyk(int c, int m, int y, int k) {
			return StaticQColor().FromCmyk(c,m,y,k);
		}
		[SmokeMethod("fromCmykF(qreal, qreal, qreal, qreal, qreal)")]
		public static QColor FromCmykF(double c, double m, double y, double k, double a) {
			return StaticQColor().FromCmykF(c,m,y,k,a);
		}
		[SmokeMethod("fromCmykF(qreal, qreal, qreal, qreal)")]
		public static QColor FromCmykF(double c, double m, double y, double k) {
			return StaticQColor().FromCmykF(c,m,y,k);
		}
		~QColor() {
			DisposeQColor();
		}
		public void Dispose() {
			DisposeQColor();
		}
		private void DisposeQColor() {
			ProxyQColor().DisposeQColor();
		}
	}
}
