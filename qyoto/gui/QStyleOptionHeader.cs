//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QStyleOptionHeader")]
	public class QStyleOptionHeader : QStyleOption, IDisposable {
 		protected QStyleOptionHeader(Type dummy) : base((Type) null) {}
		[SmokeClass("QStyleOptionHeader")]
		interface IQStyleOptionHeaderProxy {
		}

		protected new void CreateProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QStyleOptionHeader), this);
			_interceptor = (QStyleOptionHeader) realProxy.GetTransparentProxy();
		}
		private QStyleOptionHeader ProxyQStyleOptionHeader() {
			return (QStyleOptionHeader) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QStyleOptionHeader() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQStyleOptionHeaderProxy), null);
			_staticInterceptor = (IQStyleOptionHeaderProxy) realProxy.GetTransparentProxy();
		}
		private static IQStyleOptionHeaderProxy StaticQStyleOptionHeader() {
			return (IQStyleOptionHeaderProxy) _staticInterceptor;
		}

		public enum StyleOptionType {
			Type = QStyleOption.OptionType.SO_Header,
		}
		public enum StyleOptionVersion {
			Version = 1,
		}
		public enum SectionPosition {
			Beginning = 0,
			Middle = 1,
			End = 2,
			OnlyOneSection = 3,
		}
		public enum SelectedPosition {
			NotAdjacent = 0,
			NextIsSelected = 1,
			PreviousIsSelected = 2,
			NextAndPreviousAreSelected = 3,
		}
		public enum SortIndicator {
			None = 0,
			SortUp = 1,
			SortDown = 2,
		}
		public QStyleOptionHeader() : this((Type) null) {
			CreateProxy();
			NewQStyleOptionHeader();
		}
		[SmokeMethod("QStyleOptionHeader", "()", "")]
		private void NewQStyleOptionHeader() {
			ProxyQStyleOptionHeader().NewQStyleOptionHeader();
		}
		public QStyleOptionHeader(QStyleOptionHeader other) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionHeader(other);
		}
		[SmokeMethod("QStyleOptionHeader", "(const QStyleOptionHeader&)", "#")]
		private void NewQStyleOptionHeader(QStyleOptionHeader other) {
			ProxyQStyleOptionHeader().NewQStyleOptionHeader(other);
		}
		public QStyleOptionHeader(int version) : this((Type) null) {
			CreateProxy();
			NewQStyleOptionHeader(version);
		}
		[SmokeMethod("QStyleOptionHeader", "(int)", "$")]
		private void NewQStyleOptionHeader(int version) {
			ProxyQStyleOptionHeader().NewQStyleOptionHeader(version);
		}
		~QStyleOptionHeader() {
			DisposeQStyleOptionHeader();
		}
		public void Dispose() {
			DisposeQStyleOptionHeader();
		}
		[SmokeMethod("~QStyleOptionHeader", "()", "")]
		private void DisposeQStyleOptionHeader() {
			ProxyQStyleOptionHeader().DisposeQStyleOptionHeader();
		}
	}
}
