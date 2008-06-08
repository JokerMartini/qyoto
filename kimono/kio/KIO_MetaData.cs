//Auto-generated by kalyptus. DO NOT EDIT.
namespace KIO {

	using Kimono;
	using System;
	using Qyoto;
	using System.Collections.Generic;

	/// <remarks>
	///  MetaData is a simple map of key/value strings.
	///  </remarks>		<short>    MetaData is a simple map of key/value strings.</short>

	[SmokeClass("KIO::MetaData")]
	public class MetaData : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected MetaData(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocationKDE(typeof(MetaData), this);
		}
		/// <remarks>
		///  Creates an empty meta data map.
		///    </remarks>		<short>    Creates an empty meta data map.</short>
		public MetaData() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("MetaData", "MetaData()", typeof(void));
		}
		/// <remarks>
		///  Copy constructor.
		///    </remarks>		<short>    Copy constructor.</short>
		public MetaData(Dictionary<string, string> metaData) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("MetaData?", "MetaData(const QMap<QString, QString>&)", typeof(void), typeof(Dictionary<string, string>), metaData);
		}
		~MetaData() {
			interceptor.Invoke("~MetaData", "~MetaData()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~MetaData", "~MetaData()", typeof(void));
		}
	}
}
