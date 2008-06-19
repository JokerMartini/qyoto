//Auto-generated by kalyptus. DO NOT EDIT.
namespace Soprano.Error {
	using Soprano;
	using System;
	using Qyoto;
	/// <remarks>
	///  %Soprano defines a number of error codes that are
	///  used to provide a quick success status check in methods
	///  such as Model.AddStatement().
	///  \sa Error.Error.Code()
	///          </remarks>		<short>    %Soprano defines a number of error codes that are  used to provide a quick success status check in methods  such as Model.AddStatement().</short>
	public enum ErrorCode {
		ErrorNone = 0x0,
		ErrorInvalidArgument = 0x1,
		ErrorInvalidStatement = ErrorInvalidArgument,
		ErrorNotSupported = 0x2,
		ErrorParsingFailed = 0x3,
		ErrorPermissionDenied = 0x4,
		ErrorUnknown = 0x1000,
	}
	[SmokeClass("Soprano::Error")]
	public class Global {
		private static SmokeInvocation staticInterceptor = null;
		static Global() {
			staticInterceptor = new SmokeInvocation(typeof(Global), null);
		}
		/// <remarks>
		///  Translate an error code into a human-readable error message.
		///          </remarks>		<short>    Translate an error code into a human-readable error message.</short>
		public static string ErrorMessage(Soprano.Error.ErrorCode arg1) {
			return (string) staticInterceptor.Invoke("errorMessage$", "errorMessage(Soprano::Error::ErrorCode)", typeof(string), typeof(Soprano.Error.ErrorCode), arg1);
		}
		/// <remarks>
		///  Converts a plain error code (as for example used in Error.Code())
		///  into an ErrorCode value.
		///  \return <pre>code</pre> converted to ErrorCode. If it is an unknown value,
		///  ErrorUnknown will be returned.
		///          </remarks>		<short>    Converts a plain error code (as for example used in Error.Code())  into an ErrorCode value.</short>
		public static Soprano.Error.ErrorCode ConvertErrorCode(int code) {
			return (Soprano.Error.ErrorCode) staticInterceptor.Invoke("convertErrorCode$", "convertErrorCode(int)", typeof(Soprano.Error.ErrorCode), typeof(int), code);
		}
	}
}