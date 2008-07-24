//Auto-generated by kalyptus. DO NOT EDIT.
namespace KTextEditor {
    using Kimono;
    using System;
    using Qyoto;
    /// <remarks>
    ///  \brief Annotation interface for the View
    ///  \ingroup kte_group_view_extensions
    ///  \section annoview_intro Introduction
    ///  The AnnotationViewInterface allows to do two things:
    ///  - (1) show/hide the annotation border along with the possibility to add actions
    ///        into its context menu.
    ///  - (2) set a separate AnnotationModel for the View: Not that this interface
    ///        inherits the AnnotationInterface.
    ///  For a more detailed explanation about whether you want an AnnotationModel
    ///  in the Document or the View, read the detailed documentation about the
    ///  AnnotationInterface.
    ///  \section annoview_access Accessing the AnnotationViewInterface
    ///  The AnnotationViewInterface is an extension interface for a
    ///  View, i.e. the View inherits the interface \e provided that the
    ///  used KTextEditor library implements the interface. Use qobject_cast to
    ///  access the interface:
    ///  <pre>
    ///  // view is of type KTextEditor.View
    ///  KTextEditor.AnnotationViewInterface iface =
    ///      qobject_cast<KTextEditor.AnnotationViewInterface>( view );
    ///  if( iface ) {
    ///      // the implementation supports the interface
    ///      // do stuff
    ///      iface.SetAnnotationBorderVisible( true );
    ///  }
    ///  </pre>
    ///  \since 4.1
    ///  </remarks>        <short>    \brief Annotation interface for the View </short>
    [SmokeClass("KTextEditor::AnnotationViewInterface")]
    public abstract class AnnotationViewInterface : KTextEditor.AnnotationInterface {
        protected AnnotationViewInterface(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(AnnotationViewInterface), this);
        }
        /// <remarks>
        ///  This function can be used to show or hide the annotation border
        ///  The annotation border is hidden by default.
        /// <param> name="visible" if \e true the annotation border is shown, otherwise hidden
        ///      </param></remarks>        <short>    This function can be used to show or hide the annotation border  The annotation border is hidden by default.</short>
        [SmokeMethod("setAnnotationBorderVisible(bool)")]
        public virtual void SetAnnotationBorderVisible(bool visible) {
            interceptor.Invoke("setAnnotationBorderVisible$", "setAnnotationBorderVisible(bool)", typeof(void), typeof(bool), visible);
        }
        /// <remarks>
        ///  Checks whether the View's annotation border is visible.
        ///      </remarks>        <short>    Checks whether the View's annotation border is visible.</short>
        [SmokeMethod("isAnnotationBorderVisible() const")]
        public virtual bool IsAnnotationBorderVisible() {
            return (bool) interceptor.Invoke("isAnnotationBorderVisible", "isAnnotationBorderVisible() const", typeof(bool));
        }
        /// <remarks>
        ///  This signal is emitted before a context menu is shown on the annotation
        ///  border for the given line and view.
        ///  <b>Note:<> Kate Part implementation detail: In Kate Part, the menu has an
        ///        entry to hide the annotation border.
        ///  \param view the view that the annotation border belongs to
        ///  \param menu the context menu that will be shown
        ///  \param line the annotated line for which the context menu is shown
        ///  \see setAnnotationContextMenu()
        ///      </remarks>        <short>    This signal is emitted before a context menu is shown on the annotation  border for the given line and view.</short>
        [SmokeMethod("annotationContextMenuAboutToShow(KTextEditor::View*, QMenu*, int)")]
        public virtual void AnnotationContextMenuAboutToShow(KTextEditor.View view, QMenu menu, int line) {
            interceptor.Invoke("annotationContextMenuAboutToShow##$", "annotationContextMenuAboutToShow(KTextEditor::View*, QMenu*, int)", typeof(void), typeof(KTextEditor.View), view, typeof(QMenu), menu, typeof(int), line);
        }
        /// <remarks>
        ///  This signal is emitted when an entry on the annotation border was activated,
        ///  for example by clicking or double-clicking it. This follows the KDE wide
        ///  setting for activation via click or double-clcik
        ///  \param view the view to which the activated border belongs to
        ///  \param line the document line that the activated posistion belongs to
        ///      </remarks>        <short>    This signal is emitted when an entry on the annotation border was activated,  for example by clicking or double-clicking it.</short>
        [SmokeMethod("annotationActivated(KTextEditor::View*, int)")]
        public virtual void AnnotationActivated(KTextEditor.View view, int line) {
            interceptor.Invoke("annotationActivated#$", "annotationActivated(KTextEditor::View*, int)", typeof(void), typeof(KTextEditor.View), view, typeof(int), line);
        }
        /// <remarks>
        ///  This signal is emitted when the annotation border is shown or hidden.
        ///  \param view the view to which the border belongs to
        ///  \param visible the current visibility state
        ///      </remarks>        <short>    This signal is emitted when the annotation border is shown or hidden.</short>
        [SmokeMethod("annotationBorderVisibilityChanged(KTextEditor::View*, bool)")]
        public virtual void AnnotationBorderVisibilityChanged(KTextEditor.View view, bool visible) {
            interceptor.Invoke("annotationBorderVisibilityChanged#$", "annotationBorderVisibilityChanged(KTextEditor::View*, bool)", typeof(void), typeof(KTextEditor.View), view, typeof(bool), visible);
        }
        public AnnotationViewInterface() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("AnnotationViewInterface", "AnnotationViewInterface()", typeof(void));
        }
    }
}
