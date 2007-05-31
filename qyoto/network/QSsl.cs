//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QSsl")]
	public class QSsl : Object {
		protected SmokeInvocation interceptor = null;
		public enum KeyType {
			PrivateKey = 0,
			PublicKey = 1,
		}
		public enum EncodingFormat {
			Pem = 0,
			Der = 1,
		}
		public enum KeyAlgorithm {
			Rsa = 0,
			Dsa = 1,
		}
		public enum AlternateNameEntryType {
			EmailEntry = 0,
			DnsEntry = 1,
		}
		public enum SslProtocol {
			SslV3 = 0,
			SslV2 = 1,
			TlsV1 = 2,
			AnyProtocol = 3,
			UnknownProtocol = -1,
		}
	}
}
