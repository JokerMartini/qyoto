//Auto-generated by kalyptus. DO NOT EDIT.
namespace KTextEditor {
    using Kimono;
    using System;
    using Qyoto;
    /// <remarks>
    ///  \brief Class that allows the kpart host to provide some extensions.
    ///  \ingroup kte_group_editor_extensions
    ///  The KTextEditor framework allows the kpart host to provide additional
    ///  services to the kpart. Those services are provided through the
    ///  ContainerInterface class.
    ///  If the container supports those specific services, it should set an
    ///  instance of the service class with ContainerInterface.SetContainer(). That
    ///  instance should inherit QObject, have the Q_OBJECT macro and declare a
    ///  Q_INTERFACES(), in order for the qobject_cast mechanism to work.
    ///  To obtain a ContainerInterface, in order to set a specific container
    ///  extension, the kpart host should do:
    ///  <pre>
    ///  // inside the kpart host
    ///  Editor  editor = KTextEditor.EditorChooser.Editor();
    ///  ContainerInterface  iface = qobject_cast<ContainerInterface >( editor );
    ///  if (iface != NULL) {
    ///    iface.SetContainer( myContainerExtension );
    ///  } else {
    ///    // the kpart does not support ContainerInterface.
    ///  }
    ///  </pre>
    ///  It is then up to the kpart to use it.
    ///  </remarks>        <short>    \brief Class that allows the kpart host to provide some extensions.</short>
    [SmokeClass("KTextEditor::ContainerInterface")]
    public abstract class ContainerInterface : Object {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected ContainerInterface(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(ContainerInterface), this);
        }
        /// <remarks>
        ///  Constructor.
        ///      </remarks>        <short>    Constructor.</short>
        public ContainerInterface() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("ContainerInterface", "ContainerInterface()", typeof(void));
        }
        /// <remarks>
        ///  Set the KTextEditor container.
        ///  This method is used by the KTextEditor host to set an instance
        ///  of a class providing optional container extensions.
        ///  \sa container
        ///      </remarks>        <short>    Set the KTextEditor container.</short>
        [SmokeMethod("setContainer(QObject*)")]
        public virtual void SetContainer(QObject container) {
            interceptor.Invoke("setContainer#", "setContainer(QObject*)", typeof(void), typeof(QObject), container);
        }
        /// <remarks>
        ///  Fetch the container extension.
        ///  This method is used by the KTextEditor component to know
        ///  which extensions are supported by the KTextEditor host.
        ///  The kpart will cast the result with qobject_cast() to the right
        ///  container extension to see if that particular extension is supported:
        ///  <b>Example:</b>
        ///  <pre>
        ///  // inside the kpart
        ///  Editor  editor = KTextEditor.EditorChooser.Editor();
        ///  ContainerInterface  iface = qobject_cast<ConainterInterace >( editor );
        ///  SomeContainerExtension  myExt =
        ///      qobject_cast<SomeContainerExtension >( iface.Container() );
        ///  if (myExt) {
        ///      // do some stuff with the specific container extension
        ///      // ...
        ///  } else {
        ///      // too bad, that extension is not supported.
        ///  }
        ///  </pre>
        ///  \sa setContainer
        ///      </remarks>        <short>    Fetch the container extension.</short>
        [SmokeMethod("container()")]
        public virtual QObject Container() {
            return (QObject) interceptor.Invoke("container", "container()", typeof(QObject));
        }
    }
}
