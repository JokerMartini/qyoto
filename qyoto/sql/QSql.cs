//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QSql")]
	public class QSql : Object {
		protected SmokeInvocation interceptor = null;
		public enum Location {
			BeforeFirstRow = -1,
			AfterLastRow = -2,
		}
		public enum ParamTypeFlag {
			In = 0x00000001,
			Out = 0x00000002,
			InOut = In|Out,
			Binary = 0x00000004,
		}
		public enum TableType {
			Tables = 0x01,
			SystemTables = 0x02,
			Views = 0x04,
			AllTables = 0xff,
		}
		public enum NumericalPrecisionPolicy {
			LowPrecisionInt32 = 0x01,
			LowPrecisionInt64 = 0x02,
			LowPrecisionDouble = 0x04,
			HighPrecision = 0,
		}
	}
}
