//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QByteRef")]
	public class QByteRef : Object {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QByteRef(Type dummy) {}
		private static SmokeInvocation staticInterceptor = null;
		static QByteRef() {
			staticInterceptor = new SmokeInvocation(typeof(QByteRef), null);
		}
		//  operator const char(); >>>> NOT CONVERTED
		public static bool operator==(QByteRef lhs, char c) {
			return (bool) staticInterceptor.Invoke("operator==$", "operator==(char) const", typeof(bool), typeof(QByteRef), lhs, typeof(char), c);
		}
		public static bool operator!=(QByteRef lhs, char c) {
			return !(bool) staticInterceptor.Invoke("operator==$", "operator==(char) const", typeof(bool), typeof(QByteRef), lhs, typeof(char), c);
		}
		public static bool operator>(QByteRef lhs, char c) {
			return (bool) staticInterceptor.Invoke("operator>$", "operator>(char) const", typeof(bool), typeof(QByteRef), lhs, typeof(char), c);
		}
		public static bool operator>=(QByteRef lhs, char c) {
			return (bool) staticInterceptor.Invoke("operator>=$", "operator>=(char) const", typeof(bool), typeof(QByteRef), lhs, typeof(char), c);
		}
		public static bool operator<(QByteRef lhs, char c) {
			return (bool) staticInterceptor.Invoke("operator<$", "operator<(char) const", typeof(bool), typeof(QByteRef), lhs, typeof(char), c);
		}
		public static bool operator<=(QByteRef lhs, char c) {
			return (bool) staticInterceptor.Invoke("operator<=$", "operator<=(char) const", typeof(bool), typeof(QByteRef), lhs, typeof(char), c);
		}
	}
}
