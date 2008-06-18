//Auto-generated by kalyptus. DO NOT EDIT.
namespace DOM {
	using Kimono;
	using System;
	using Qyoto;
	/// <remarks>
	///  DOM operations only raise exceptions in &quot;exceptional&quot;
	///  circumstances, i.e., when an operation is impossible to perform
	///  (either for logical reasons, because data is lost, or because the
	///  implementation has become unstable). In general, DOM methods return
	///  specific error values in ordinary processing situation, such as
	///  out-of-bound errors when using <code>ArrayList</code> .
	///   Implementations may raise other exceptions under other
	///  circumstances. For example, implementations may raise an
	///  implementation-dependent exception if a <code>null</code>
	///  argument is passed.
	///   Some languages and object systems do not support the concept of
	///  exceptions. For such systems, error conditions may be indicated
	///  using native error reporting mechanisms. For some bindings, for
	///  example, methods may return error codes similar to those listed in
	///  the corresponding method descriptions.
	///  </remarks>		<short>    DOM operations only raise exceptions in &quot;exceptional&quot;  circumstances, i.</short>
	[SmokeClass("DOM::DOMException")]
	public class DOMException : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected DOMException(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(DOMException), this);
		}
		/// <remarks>
		///  An integer indicating the type of error generated.
		///      </remarks>		<short>    An integer indicating the type of error generated.</short>
		public enum ExceptionCode {
			INDEX_SIZE_ERR = 1,
			DOMSTRING_SIZE_ERR = 2,
			HIERARCHY_REQUEST_ERR = 3,
			WRONG_DOCUMENT_ERR = 4,
			INVALID_CHARACTER_ERR = 5,
			NO_DATA_ALLOWED_ERR = 6,
			NO_MODIFICATION_ALLOWED_ERR = 7,
			NOT_FOUND_ERR = 8,
			NOT_SUPPORTED_ERR = 9,
			INUSE_ATTRIBUTE_ERR = 10,
			INVALID_STATE_ERR = 11,
			SYNTAX_ERR = 12,
			INVALID_MODIFICATION_ERR = 13,
			NAMESPACE_ERR = 14,
			INVALID_ACCESS_ERR = 15,
			VALIDATION_ERR = 16,
			TYPE_MISMATCH_ERR = 17,
		}
		public DOMException(ushort _code) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("DOMException$", "DOMException(unsigned short)", typeof(void), typeof(ushort), _code);
		}
		public DOMException(DOM.DOMException other) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("DOMException#", "DOMException(const DOM::DOMException&)", typeof(void), typeof(DOM.DOMException), other);
		}
		~DOMException() {
			interceptor.Invoke("~DOMException", "~DOMException()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~DOMException", "~DOMException()", typeof(void));
		}
	}
}
