//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	using System.Collections.Generic;
	[SmokeClass("QPrinter")]
	public class QPrinter : QPaintDevice, IDisposable {
 		protected QPrinter(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QPrinter), this);
		}
		public enum PrinterMode {
			ScreenResolution = 0,
			PrinterResolution = 1,
			HighResolution = 2,
		}
		public enum Orientation {
			Portrait = 0,
			Landscape = 1,
		}
		public enum PageSize {
			A4 = 0,
			B5 = 1,
			Letter = 2,
			Legal = 3,
			Executive = 4,
			A0 = 5,
			A1 = 6,
			A2 = 7,
			A3 = 8,
			A5 = 9,
			A6 = 10,
			A7 = 11,
			A8 = 12,
			A9 = 13,
			B0 = 14,
			B1 = 15,
			B10 = 16,
			B2 = 17,
			B3 = 18,
			B4 = 19,
			B6 = 20,
			B7 = 21,
			B8 = 22,
			B9 = 23,
			C5E = 24,
			Comm10E = 25,
			DLE = 26,
			Folio = 27,
			Ledger = 28,
			Tabloid = 29,
			Custom = 30,
			NPageSize = Custom,
			NPaperSize = Custom,
		}
		public enum PageOrder {
			FirstPageFirst = 0,
			LastPageFirst = 1,
		}
		public enum ColorMode {
			GrayScale = 0,
			Color = 1,
		}
		public enum PaperSource {
			OnlyOne = 0,
			Lower = 1,
			Middle = 2,
			Manual = 3,
			Envelope = 4,
			EnvelopeManual = 5,
			Auto = 6,
			Tractor = 7,
			SmallFormat = 8,
			LargeFormat = 9,
			LargeCapacity = 10,
			Cassette = 11,
			FormSource = 12,
			MaxPageSource = 13,
		}
		public enum PrinterState {
			Idle = 0,
			Active = 1,
			Aborted = 2,
			Error = 3,
		}
		public enum OutputFormat {
			NativeFormat = 0,
			PdfFormat = 1,
			PostScriptFormat = 2,
		}
		public enum PrintRange {
			AllPages = 0,
			Selection = 1,
			PageRange = 2,
		}
		public enum Unit {
			Millimeter = 0,
			Point = 1,
			Inch = 2,
			Pica = 3,
			Didot = 4,
			Cicero = 5,
			DevicePixel = 6,
		}
		public enum DuplexMode {
			DuplexNone = 0,
			DuplexAuto = 1,
			DuplexLongSide = 2,
			DuplexShortSide = 3,
		}
		// void setPaperSize(QPrinter::PaperSize arg1); >>>> NOT CONVERTED
		// QPrinter::PaperSize paperSize(); >>>> NOT CONVERTED
		public QPrinter(QPrinter.PrinterMode mode) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QPrinter$", "QPrinter(QPrinter::PrinterMode)", typeof(void), typeof(QPrinter.PrinterMode), mode);
		}
		public QPrinter() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QPrinter", "QPrinter()", typeof(void));
		}
		public QPrinter(QPrinterInfo printer, QPrinter.PrinterMode mode) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QPrinter#$", "QPrinter(const QPrinterInfo&, QPrinter::PrinterMode)", typeof(void), typeof(QPrinterInfo), printer, typeof(QPrinter.PrinterMode), mode);
		}
		public QPrinter(QPrinterInfo printer) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QPrinter#", "QPrinter(const QPrinterInfo&)", typeof(void), typeof(QPrinterInfo), printer);
		}
		[SmokeMethod("devType() const")]
		public override int DevType() {
			return (int) interceptor.Invoke("devType", "devType() const", typeof(int));
		}
		public void SetOutputFormat(QPrinter.OutputFormat format) {
			interceptor.Invoke("setOutputFormat$", "setOutputFormat(QPrinter::OutputFormat)", typeof(void), typeof(QPrinter.OutputFormat), format);
		}
		public QPrinter.OutputFormat outputFormat() {
			return (QPrinter.OutputFormat) interceptor.Invoke("outputFormat", "outputFormat() const", typeof(QPrinter.OutputFormat));
		}
		public void SetPrinterName(string arg1) {
			interceptor.Invoke("setPrinterName$", "setPrinterName(const QString&)", typeof(void), typeof(string), arg1);
		}
		public string PrinterName() {
			return (string) interceptor.Invoke("printerName", "printerName() const", typeof(string));
		}
		public bool IsValid() {
			return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
		}
		public void SetOutputFileName(string arg1) {
			interceptor.Invoke("setOutputFileName$", "setOutputFileName(const QString&)", typeof(void), typeof(string), arg1);
		}
		public string OutputFileName() {
			return (string) interceptor.Invoke("outputFileName", "outputFileName() const", typeof(string));
		}
		public void SetPrintProgram(string arg1) {
			interceptor.Invoke("setPrintProgram$", "setPrintProgram(const QString&)", typeof(void), typeof(string), arg1);
		}
		public string PrintProgram() {
			return (string) interceptor.Invoke("printProgram", "printProgram() const", typeof(string));
		}
		public void SetDocName(string arg1) {
			interceptor.Invoke("setDocName$", "setDocName(const QString&)", typeof(void), typeof(string), arg1);
		}
		public string DocName() {
			return (string) interceptor.Invoke("docName", "docName() const", typeof(string));
		}
		public void SetCreator(string arg1) {
			interceptor.Invoke("setCreator$", "setCreator(const QString&)", typeof(void), typeof(string), arg1);
		}
		public string Creator() {
			return (string) interceptor.Invoke("creator", "creator() const", typeof(string));
		}
		public void SetOrientation(QPrinter.Orientation arg1) {
			interceptor.Invoke("setOrientation$", "setOrientation(QPrinter::Orientation)", typeof(void), typeof(QPrinter.Orientation), arg1);
		}
		public QPrinter.Orientation orientation() {
			return (QPrinter.Orientation) interceptor.Invoke("orientation", "orientation() const", typeof(QPrinter.Orientation));
		}
		public void SetPageSize(QPrinter.PageSize arg1) {
			interceptor.Invoke("setPageSize$", "setPageSize(QPrinter::PageSize)", typeof(void), typeof(QPrinter.PageSize), arg1);
		}
		public QPrinter.PageSize pageSize() {
			return (QPrinter.PageSize) interceptor.Invoke("pageSize", "pageSize() const", typeof(QPrinter.PageSize));
		}
		public void SetPaperSize(QSizeF paperSize, QPrinter.Unit unit) {
			interceptor.Invoke("setPaperSize#$", "setPaperSize(const QSizeF&, QPrinter::Unit)", typeof(void), typeof(QSizeF), paperSize, typeof(QPrinter.Unit), unit);
		}
		public QSizeF PaperSize(QPrinter.Unit unit) {
			return (QSizeF) interceptor.Invoke("paperSize$", "paperSize(QPrinter::Unit) const", typeof(QSizeF), typeof(QPrinter.Unit), unit);
		}
		public void SetPageOrder(QPrinter.PageOrder arg1) {
			interceptor.Invoke("setPageOrder$", "setPageOrder(QPrinter::PageOrder)", typeof(void), typeof(QPrinter.PageOrder), arg1);
		}
		public QPrinter.PageOrder pageOrder() {
			return (QPrinter.PageOrder) interceptor.Invoke("pageOrder", "pageOrder() const", typeof(QPrinter.PageOrder));
		}
		public void SetResolution(int arg1) {
			interceptor.Invoke("setResolution$", "setResolution(int)", typeof(void), typeof(int), arg1);
		}
		public int Resolution() {
			return (int) interceptor.Invoke("resolution", "resolution() const", typeof(int));
		}
		public void SetColorMode(QPrinter.ColorMode arg1) {
			interceptor.Invoke("setColorMode$", "setColorMode(QPrinter::ColorMode)", typeof(void), typeof(QPrinter.ColorMode), arg1);
		}
		public QPrinter.ColorMode colorMode() {
			return (QPrinter.ColorMode) interceptor.Invoke("colorMode", "colorMode() const", typeof(QPrinter.ColorMode));
		}
		public void SetCollateCopies(bool collate) {
			interceptor.Invoke("setCollateCopies$", "setCollateCopies(bool)", typeof(void), typeof(bool), collate);
		}
		public bool CollateCopies() {
			return (bool) interceptor.Invoke("collateCopies", "collateCopies() const", typeof(bool));
		}
		public void SetFullPage(bool arg1) {
			interceptor.Invoke("setFullPage$", "setFullPage(bool)", typeof(void), typeof(bool), arg1);
		}
		public bool FullPage() {
			return (bool) interceptor.Invoke("fullPage", "fullPage() const", typeof(bool));
		}
		public void SetNumCopies(int arg1) {
			interceptor.Invoke("setNumCopies$", "setNumCopies(int)", typeof(void), typeof(int), arg1);
		}
		public int NumCopies() {
			return (int) interceptor.Invoke("numCopies", "numCopies() const", typeof(int));
		}
		public void SetPaperSource(QPrinter.PaperSource arg1) {
			interceptor.Invoke("setPaperSource$", "setPaperSource(QPrinter::PaperSource)", typeof(void), typeof(QPrinter.PaperSource), arg1);
		}
		public QPrinter.PaperSource paperSource() {
			return (QPrinter.PaperSource) interceptor.Invoke("paperSource", "paperSource() const", typeof(QPrinter.PaperSource));
		}
		public void SetDuplex(QPrinter.DuplexMode duplex) {
			interceptor.Invoke("setDuplex$", "setDuplex(QPrinter::DuplexMode)", typeof(void), typeof(QPrinter.DuplexMode), duplex);
		}
		public QPrinter.DuplexMode Duplex() {
			return (QPrinter.DuplexMode) interceptor.Invoke("duplex", "duplex() const", typeof(QPrinter.DuplexMode));
		}
		public List<int> SupportedResolutions() {
			return (List<int>) interceptor.Invoke("supportedResolutions", "supportedResolutions() const", typeof(List<int>));
		}
		public void SetFontEmbeddingEnabled(bool enable) {
			interceptor.Invoke("setFontEmbeddingEnabled$", "setFontEmbeddingEnabled(bool)", typeof(void), typeof(bool), enable);
		}
		public bool FontEmbeddingEnabled() {
			return (bool) interceptor.Invoke("fontEmbeddingEnabled", "fontEmbeddingEnabled() const", typeof(bool));
		}
		public void SetDoubleSidedPrinting(bool enable) {
			interceptor.Invoke("setDoubleSidedPrinting$", "setDoubleSidedPrinting(bool)", typeof(void), typeof(bool), enable);
		}
		public bool DoubleSidedPrinting() {
			return (bool) interceptor.Invoke("doubleSidedPrinting", "doubleSidedPrinting() const", typeof(bool));
		}
		public QRect PaperRect() {
			return (QRect) interceptor.Invoke("paperRect", "paperRect() const", typeof(QRect));
		}
		public QRect PageRect() {
			return (QRect) interceptor.Invoke("pageRect", "pageRect() const", typeof(QRect));
		}
		public QRectF PaperRect(QPrinter.Unit arg1) {
			return (QRectF) interceptor.Invoke("paperRect$", "paperRect(QPrinter::Unit) const", typeof(QRectF), typeof(QPrinter.Unit), arg1);
		}
		public QRectF PageRect(QPrinter.Unit arg1) {
			return (QRectF) interceptor.Invoke("pageRect$", "pageRect(QPrinter::Unit) const", typeof(QRectF), typeof(QPrinter.Unit), arg1);
		}
		public bool NewPage() {
			return (bool) interceptor.Invoke("newPage", "newPage()", typeof(bool));
		}
		public bool Abort() {
			return (bool) interceptor.Invoke("abort", "abort()", typeof(bool));
		}
		public QPrinter.PrinterState printerState() {
			return (QPrinter.PrinterState) interceptor.Invoke("printerState", "printerState() const", typeof(QPrinter.PrinterState));
		}
		[SmokeMethod("paintEngine() const")]
		public override QPaintEngine PaintEngine() {
			return (QPaintEngine) interceptor.Invoke("paintEngine", "paintEngine() const", typeof(QPaintEngine));
		}
		public QPrintEngine PrintEngine() {
			return (QPrintEngine) interceptor.Invoke("printEngine", "printEngine() const", typeof(QPrintEngine));
		}
		public void SetFromTo(int fromPage, int toPage) {
			interceptor.Invoke("setFromTo$$", "setFromTo(int, int)", typeof(void), typeof(int), fromPage, typeof(int), toPage);
		}
		public int FromPage() {
			return (int) interceptor.Invoke("fromPage", "fromPage() const", typeof(int));
		}
		public int ToPage() {
			return (int) interceptor.Invoke("toPage", "toPage() const", typeof(int));
		}
		public void SetPrintRange(QPrinter.PrintRange range) {
			interceptor.Invoke("setPrintRange$", "setPrintRange(QPrinter::PrintRange)", typeof(void), typeof(QPrinter.PrintRange), range);
		}
		public QPrinter.PrintRange printRange() {
			return (QPrinter.PrintRange) interceptor.Invoke("printRange", "printRange() const", typeof(QPrinter.PrintRange));
		}
		public void SetPageMargins(double left, double top, double right, double bottom, QPrinter.Unit unit) {
			interceptor.Invoke("setPageMargins$$$$$", "setPageMargins(qreal, qreal, qreal, qreal, QPrinter::Unit)", typeof(void), typeof(double), left, typeof(double), top, typeof(double), right, typeof(double), bottom, typeof(QPrinter.Unit), unit);
		}
		public void GetPageMargins(ref double left, ref double top, ref double right, ref double bottom, QPrinter.Unit unit) {
			StackItem[] stack = new StackItem[6];
			stack[1].s_double = left;
			stack[2].s_double = top;
			stack[3].s_double = right;
			stack[4].s_double = bottom;
			stack[5].s_int = (int) unit;
			interceptor.Invoke("getPageMargins$$$$$", "getPageMargins(qreal*, qreal*, qreal*, qreal*, QPrinter::Unit) const", stack);
			left = stack[1].s_double;
			top = stack[2].s_double;
			right = stack[3].s_double;
			bottom = stack[4].s_double;
			return;
		}
		[SmokeMethod("metric(QPaintDevice::PaintDeviceMetric) const")]
		protected override int Metric(IQPaintDevice arg1) {
			return (int) interceptor.Invoke("metric$", "metric(QPaintDevice::PaintDeviceMetric) const", typeof(int), typeof(IQPaintDevice), arg1);
		}
		protected void SetEngines(QPrintEngine printEngine, QPaintEngine paintEngine) {
			interceptor.Invoke("setEngines##", "setEngines(QPrintEngine*, QPaintEngine*)", typeof(void), typeof(QPrintEngine), printEngine, typeof(QPaintEngine), paintEngine);
		}
		~QPrinter() {
			interceptor.Invoke("~QPrinter", "~QPrinter()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QPrinter", "~QPrinter()", typeof(void));
		}
	}
}
