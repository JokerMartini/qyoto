//Auto-generated by kalyptus. DO NOT EDIT.
namespace Kimono {

	using System;
	using Qyoto;

	/// <remarks>
	///  Extends QUndoStack with functions that creates actions with KDE's default icons and shortcuts.
	///  See QUndoStack for more information.
	///  </remarks>		<short>    Extends QUndoStack with functions that creates actions with KDE's default icons and shortcuts.</short>

	[SmokeClass("KUndoStack")]
	public class KUndoStack : QUndoStack, IDisposable {
 		protected KUndoStack(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocationKDE(typeof(KUndoStack), this);
		}
		/// <remarks>
		///  Constructs a KUndoStack with <code>parent</code> as parent
		/// <param> name="parent" parent of the object
		///          </param></remarks>		<short>    Constructs a KUndoStack with <code>parent</code> as parent </short>
		public KUndoStack(QObject parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KUndoStack#", "KUndoStack(QObject*)", typeof(void), typeof(QObject), parent);
		}
		public KUndoStack() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("KUndoStack", "KUndoStack()", typeof(void));
		}
		/// <remarks>
		///  Creates an redo action with the default shortcut and icon and adds it to <code>actionCollection</code>
		/// <param> name="actionCollection" the KActionCollection that should be the parent of the action
		/// </param><param> name="actionName" the created action's object name, empty string will set it to the KDE default
		/// </param></remarks>		<return> the created action.
		///          </return>
		/// 		<short>    Creates an redo action with the default shortcut and icon and adds it to <code>actionCollection</code> </short>
		public QAction CreateRedoAction(KActionCollection actionCollection, string actionName) {
			return (QAction) interceptor.Invoke("createRedoAction#$", "createRedoAction(KActionCollection*, const QString&)", typeof(QAction), typeof(KActionCollection), actionCollection, typeof(string), actionName);
		}
		public QAction CreateRedoAction(KActionCollection actionCollection) {
			return (QAction) interceptor.Invoke("createRedoAction#", "createRedoAction(KActionCollection*)", typeof(QAction), typeof(KActionCollection), actionCollection);
		}
		/// <remarks>
		///  Creates an undo action with the default KDE shortcut and icon and adds it to <code>actionCollection</code>
		/// <param> name="actionCollection" the KActionCollection that should be the parent of the action
		/// </param><param> name="actionName" the created action's object name, empty string will set it to the KDE default
		/// </param></remarks>		<return> the created action.
		///          </return>
		/// 		<short>    Creates an undo action with the default KDE shortcut and icon and adds it to <code>actionCollection</code> </short>
		public QAction CreateUndoAction(KActionCollection actionCollection, string actionName) {
			return (QAction) interceptor.Invoke("createUndoAction#$", "createUndoAction(KActionCollection*, const QString&)", typeof(QAction), typeof(KActionCollection), actionCollection, typeof(string), actionName);
		}
		public QAction CreateUndoAction(KActionCollection actionCollection) {
			return (QAction) interceptor.Invoke("createUndoAction#", "createUndoAction(KActionCollection*)", typeof(QAction), typeof(KActionCollection), actionCollection);
		}
		~KUndoStack() {
			interceptor.Invoke("~KUndoStack", "~KUndoStack()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~KUndoStack", "~KUndoStack()", typeof(void));
		}
		protected new IKUndoStackSignals Emit {
			get { return (IKUndoStackSignals) Q_EMIT; }
		}
	}

	public interface IKUndoStackSignals : IQUndoStackSignals {
	}
}
