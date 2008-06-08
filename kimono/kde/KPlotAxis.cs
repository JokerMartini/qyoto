//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;
	using System.Collections.Generic;

	/// <remarks>
	///  Contains all data for drawing an axis including format specification axis labels.
	/// </remarks>		<author> Andreas Nicolai
	/// </author>
	/// 		<version> 1.0
	///  </version>
	/// 		<short> Axis for KPlotWidget.</short>

	[SmokeClass("KPlotAxis")]
	public class KPlotAxis : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected KPlotAxis(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocationKDE(typeof(KPlotAxis), this);
		}
		/// <remarks>
		///  Constructor, constructs an axis with the label <code>label.</code>
		///      </remarks>		<short>    Constructor, constructs an axis with the label <code>label.</code></short>
		public KPlotAxis(string label) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KPlotAxis$", "KPlotAxis(const QString&)", typeof(void), typeof(string), label);
		}
		public KPlotAxis() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KPlotAxis", "KPlotAxis()", typeof(void));
		}
		/// <remarks>
		/// </remarks>		<return> whether the axis is visible or not
		///      </return>
		/// 		<short>   </short>
		public bool IsVisible() {
			return (bool) interceptor.Invoke("isVisible", "isVisible() const", typeof(bool));
		}
		/// <remarks>
		///  Sets the "visible" property of the axis.
		/// <param> name="visible" if true, this axis will be drawn on the KPlotWidget
		///      </param></remarks>		<short>    Sets the "visible" property of the axis.</short>
		public void SetVisible(bool visible) {
			interceptor.Invoke("setVisible$", "setVisible(bool)", typeof(void), typeof(bool), visible);
		}
		/// <remarks>
		/// </remarks>		<return> whether tick labels will be drawn for this axis
		///      </return>
		/// 		<short>   </short>
		public bool AreTickLabelsShown() {
			return (bool) interceptor.Invoke("areTickLabelsShown", "areTickLabelsShown() const", typeof(bool));
		}
		/// <remarks>
		///  Determine whether tick labels will be drawn for this axis.
		/// <param> name="b" if true, tick labels will be drawn.
		///      </param></remarks>		<short>    Determine whether tick labels will be drawn for this axis.</short>
		public void SetTickLabelsShown(bool b) {
			interceptor.Invoke("setTickLabelsShown$", "setTickLabelsShown(bool)", typeof(void), typeof(bool), b);
		}
		/// <remarks>
		///  Sets the axis label.
		///  Set the label to an empty string to omit the axis label.
		/// <param> name="label" a string describing the data plotted on the axis.
		///      </param></remarks>		<short>    Sets the axis label.</short>
		public void SetLabel(string label) {
			interceptor.Invoke("setLabel$", "setLabel(const QString&)", typeof(void), typeof(string), label);
		}
		/// <remarks>
		/// </remarks>		<return> the label string for this axis
		///      </return>
		/// 		<short>   </short>
		public string Label() {
			return (string) interceptor.Invoke("label", "label() const", typeof(string));
		}
		/// <remarks>
		/// <param> name="the" value to be rendered as a tick label.
		///  @sa setTickLabelFormat()
		///      </param></remarks>		<return> the ticklabel string for the given value, rendered according
		///  to the current format specification.
		/// </return>
		/// 		<short>   </short>
		public string TickLabel(double value) {
			return (string) interceptor.Invoke("tickLabel$", "tickLabel(double) const", typeof(string), typeof(double), value);
		}
		/// <remarks>
		///  Set the display format for converting the double value of the 
		///  tick's position to the string for the tick label.
		///  Normally, the format character is one of 'e', 'E', 'f', 'g', or 'G'
		///  (see the documentation for string.Arg(double) for details).
		///  In addition, it is possible to set the format character to 't';
		///  in this case the tickmark value is interpreted as a time in hours,
		///  and the ticklabel string will be in "hh:mm" clock format.
		///  Note that when the format character is 't', the fieldWidth and prec
		///  values are ignored.
		/// <param> name="format" the format specification character 
		/// </param><param> name="fieldWidth" the number of characters in the output string.
		///  If set to 0, the string will be as wide as it needs to be to fully 
		///  render the value.
		/// </param><param> name="precision" the number of characters following the decimal point.
		///      </param></remarks>		<short>    Set the display format for converting the double value of the   tick's position to the string for the tick label.</short>
		public void SetTickLabelFormat(char format, int fieldWidth, int precision) {
			interceptor.Invoke("setTickLabelFormat$$$", "setTickLabelFormat(char, int, int)", typeof(void), typeof(char), format, typeof(int), fieldWidth, typeof(int), precision);
		}
		public void SetTickLabelFormat(char format, int fieldWidth) {
			interceptor.Invoke("setTickLabelFormat$$", "setTickLabelFormat(char, int)", typeof(void), typeof(char), format, typeof(int), fieldWidth);
		}
		public void SetTickLabelFormat(char format) {
			interceptor.Invoke("setTickLabelFormat$", "setTickLabelFormat(char)", typeof(void), typeof(char), format);
		}
		public void SetTickLabelFormat() {
			interceptor.Invoke("setTickLabelFormat", "setTickLabelFormat()", typeof(void));
		}
		/// <remarks>
		/// </remarks>		<return> the field width of the tick labels
		///      </return>
		/// 		<short>   </short>
		public int TickLabelWidth() {
			return (int) interceptor.Invoke("tickLabelWidth", "tickLabelWidth() const", typeof(int));
		}
		/// <remarks>
		/// </remarks>		<return> the number format of the tick labels
		///      </return>
		/// 		<short>   </short>
		public char TickLabelFormat() {
			return (char) interceptor.Invoke("tickLabelFormat", "tickLabelFormat() const", typeof(char));
		}
		/// <remarks>
		/// </remarks>		<return> the number precision of the tick labels
		///      </return>
		/// 		<short>   </short>
		public int TickLabelPrecision() {
			return (int) interceptor.Invoke("tickLabelPrecision", "tickLabelPrecision() const", typeof(int));
		}
		/// <remarks>
		///  Determine the positions of major and minor tickmarks for this axis.
		///  @note this function is called by KPlotWidget whenever the plot's 
		///  limits are modified.
		/// <param> name="x0" the minimum data coordinate of the axis.
		/// </param><param> name="length" the range covered by the axis, in data units.
		///  @sa majorTickMarks()
		///  @sa minorTickMarks()
		///      </param></remarks>		<short>    Determine the positions of major and minor tickmarks for this axis.</short>
		public void SetTickMarks(double x0, double length) {
			interceptor.Invoke("setTickMarks$$", "setTickMarks(double, double)", typeof(void), typeof(double), x0, typeof(double), length);
		}
		/// <remarks>
		/// </remarks>		<return> the list of coordinates of the major tickmarks for this axis
		///  @note the positions of tickmarks are automatically computed by setTickMarks().
		///  @sa setTickMarks()
		///  @sa minorTickMarks()
		///      </return>
		/// 		<short>   </short>
		public List<double> MajorTickMarks() {
			return (List<double>) interceptor.Invoke("majorTickMarks", "majorTickMarks() const", typeof(List<double>));
		}
		/// <remarks>
		/// </remarks>		<return> the list with the minor tickmarks
		///  @note the positions of tickmarks are automatically computed by setTickMarks().
		///  @sa setTickMarks()
		///  @sa majorTickMarks()
		///      </return>
		/// 		<short>   </short>
		public List<double> MinorTickMarks() {
			return (List<double>) interceptor.Invoke("minorTickMarks", "minorTickMarks() const", typeof(List<double>));
		}
		~KPlotAxis() {
			interceptor.Invoke("~KPlotAxis", "~KPlotAxis()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~KPlotAxis", "~KPlotAxis()", typeof(void));
		}
	}
}
