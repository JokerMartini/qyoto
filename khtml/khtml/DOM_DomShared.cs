//Auto-generated by kalyptus. DO NOT EDIT.
namespace DOM {
	using Kimono;
	using System;
	using Qyoto;
	[SmokeClass("DOM::DomShared")]
	public class DomShared : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected DomShared(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(DomShared), this);
		}
		public DomShared() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("DomShared", "DomShared()", typeof(void));
		}
		[SmokeMethod("deleteMe()")]
		public virtual bool DeleteMe() {
			return (bool) interceptor.Invoke("deleteMe", "deleteMe()", typeof(bool));
		}
		public void Ref() {
			interceptor.Invoke("ref", "ref()", typeof(void));
		}
		public void Deref() {
			interceptor.Invoke("deref", "deref()", typeof(void));
		}
		public bool HasOneRef() {
			return (bool) interceptor.Invoke("hasOneRef", "hasOneRef() const", typeof(bool));
		}
		public uint RefCount() {
			return (uint) interceptor.Invoke("refCount", "refCount() const", typeof(uint));
		}
		~DomShared() {
			interceptor.Invoke("~DomShared", "~DomShared()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~DomShared", "~DomShared()", typeof(void));
		}
	}
}
