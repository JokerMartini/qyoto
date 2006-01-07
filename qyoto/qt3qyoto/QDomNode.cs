//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Collections;
	using System.Text;

	[SmokeClass("QDomNode")]
	public class QDomNode : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
 		protected QDomNode(Type dummy) {}
		interface IQDomNodeProxy {
			bool op_equals(QDomNode lhs, QDomNode arg1);
		}

		protected void CreateQDomNodeProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QDomNode), this);
			_interceptor = (QDomNode) realProxy.GetTransparentProxy();
		}
		private QDomNode ProxyQDomNode() {
			return (QDomNode) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QDomNode() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQDomNodeProxy), null);
			_staticInterceptor = (IQDomNodeProxy) realProxy.GetTransparentProxy();
		}
		private static IQDomNodeProxy StaticQDomNode() {
			return (IQDomNodeProxy) _staticInterceptor;
		}

		public enum NodeType {
			ElementNode = 1,
			AttributeNode = 2,
			TextNode = 3,
			CDATASectionNode = 4,
			EntityReferenceNode = 5,
			EntityNode = 6,
			ProcessingInstructionNode = 7,
			CommentNode = 8,
			DocumentNode = 9,
			DocumentTypeNode = 10,
			DocumentFragmentNode = 11,
			NotationNode = 12,
			BaseNode = 21,
			CharacterDataNode = 22,
		}
		public QDomNode() : this((Type) null) {
			CreateQDomNodeProxy();
			NewQDomNode();
		}
		[SmokeMethod("QDomNode()")]
		private void NewQDomNode() {
			ProxyQDomNode().NewQDomNode();
		}
		public QDomNode(QDomNode arg1) : this((Type) null) {
			CreateQDomNodeProxy();
			NewQDomNode(arg1);
		}
		[SmokeMethod("QDomNode(const QDomNode&)")]
		private void NewQDomNode(QDomNode arg1) {
			ProxyQDomNode().NewQDomNode(arg1);
		}
		[SmokeMethod("operator==(const QDomNode&) const")]
		public static bool operator==(QDomNode lhs, QDomNode arg1) {
			return StaticQDomNode().op_equals(lhs,arg1);
		}
		public static bool operator!=(QDomNode lhs, QDomNode arg1) {
			return !StaticQDomNode().op_equals(lhs,arg1);
		}
		public override bool Equals(object o) {
			if (!(o is QDomNode)) { return false; }
			return this == (QDomNode) o;
		}
		public override int GetHashCode() {
			return ProxyQDomNode().GetHashCode();
		}
		[SmokeMethod("insertBefore(const QDomNode&, const QDomNode&)")]
		public virtual QDomNode InsertBefore(QDomNode newChild, QDomNode refChild) {
			return ProxyQDomNode().InsertBefore(newChild,refChild);
		}
		[SmokeMethod("insertAfter(const QDomNode&, const QDomNode&)")]
		public virtual QDomNode InsertAfter(QDomNode newChild, QDomNode refChild) {
			return ProxyQDomNode().InsertAfter(newChild,refChild);
		}
		[SmokeMethod("replaceChild(const QDomNode&, const QDomNode&)")]
		public virtual QDomNode ReplaceChild(QDomNode newChild, QDomNode oldChild) {
			return ProxyQDomNode().ReplaceChild(newChild,oldChild);
		}
		[SmokeMethod("removeChild(const QDomNode&)")]
		public virtual QDomNode RemoveChild(QDomNode oldChild) {
			return ProxyQDomNode().RemoveChild(oldChild);
		}
		[SmokeMethod("appendChild(const QDomNode&)")]
		public virtual QDomNode AppendChild(QDomNode newChild) {
			return ProxyQDomNode().AppendChild(newChild);
		}
		[SmokeMethod("hasChildNodes() const")]
		public virtual bool HasChildNodes() {
			return ProxyQDomNode().HasChildNodes();
		}
		[SmokeMethod("cloneNode(bool) const")]
		public virtual QDomNode CloneNode(bool deep) {
			return ProxyQDomNode().CloneNode(deep);
		}
		[SmokeMethod("cloneNode() const")]
		public virtual QDomNode CloneNode() {
			return ProxyQDomNode().CloneNode();
		}
		[SmokeMethod("normalize()")]
		public virtual void Normalize() {
			ProxyQDomNode().Normalize();
		}
		[SmokeMethod("isSupported(const QString&, const QString&) const")]
		public virtual bool IsSupported(string feature, string version) {
			return ProxyQDomNode().IsSupported(feature,version);
		}
		[SmokeMethod("nodeName() const")]
		public virtual string NodeName() {
			return ProxyQDomNode().NodeName();
		}
		[SmokeMethod("nodeType() const")]
		public virtual QDomNode.NodeType nodeType() {
			return ProxyQDomNode().nodeType();
		}
		[SmokeMethod("parentNode() const")]
		public virtual QDomNode ParentNode() {
			return ProxyQDomNode().ParentNode();
		}
		[SmokeMethod("childNodes() const")]
		public virtual ArrayList ChildNodes() {
			return ProxyQDomNode().ChildNodes();
		}
		[SmokeMethod("firstChild() const")]
		public virtual QDomNode FirstChild() {
			return ProxyQDomNode().FirstChild();
		}
		[SmokeMethod("lastChild() const")]
		public virtual QDomNode LastChild() {
			return ProxyQDomNode().LastChild();
		}
		[SmokeMethod("previousSibling() const")]
		public virtual QDomNode PreviousSibling() {
			return ProxyQDomNode().PreviousSibling();
		}
		[SmokeMethod("nextSibling() const")]
		public virtual QDomNode NextSibling() {
			return ProxyQDomNode().NextSibling();
		}
		[SmokeMethod("attributes() const")]
		public virtual QDomNamedNodeMap Attributes() {
			return ProxyQDomNode().Attributes();
		}
		[SmokeMethod("ownerDocument() const")]
		public virtual QDomDocument OwnerDocument() {
			return ProxyQDomNode().OwnerDocument();
		}
		[SmokeMethod("namespaceURI() const")]
		public virtual string NamespaceURI() {
			return ProxyQDomNode().NamespaceURI();
		}
		[SmokeMethod("localName() const")]
		public virtual string LocalName() {
			return ProxyQDomNode().LocalName();
		}
		[SmokeMethod("hasAttributes() const")]
		public virtual bool HasAttributes() {
			return ProxyQDomNode().HasAttributes();
		}
		[SmokeMethod("nodeValue() const")]
		public virtual string NodeValue() {
			return ProxyQDomNode().NodeValue();
		}
		[SmokeMethod("setNodeValue(const QString&)")]
		public virtual void SetNodeValue(string arg1) {
			ProxyQDomNode().SetNodeValue(arg1);
		}
		[SmokeMethod("prefix() const")]
		public virtual string Prefix() {
			return ProxyQDomNode().Prefix();
		}
		[SmokeMethod("setPrefix(const QString&)")]
		public virtual void SetPrefix(string pre) {
			ProxyQDomNode().SetPrefix(pre);
		}
		[SmokeMethod("isAttr() const")]
		public virtual bool IsAttr() {
			return ProxyQDomNode().IsAttr();
		}
		[SmokeMethod("isCDATASection() const")]
		public virtual bool IsCDATASection() {
			return ProxyQDomNode().IsCDATASection();
		}
		[SmokeMethod("isDocumentFragment() const")]
		public virtual bool IsDocumentFragment() {
			return ProxyQDomNode().IsDocumentFragment();
		}
		[SmokeMethod("isDocument() const")]
		public virtual bool IsDocument() {
			return ProxyQDomNode().IsDocument();
		}
		[SmokeMethod("isDocumentType() const")]
		public virtual bool IsDocumentType() {
			return ProxyQDomNode().IsDocumentType();
		}
		[SmokeMethod("isElement() const")]
		public virtual bool IsElement() {
			return ProxyQDomNode().IsElement();
		}
		[SmokeMethod("isEntityReference() const")]
		public virtual bool IsEntityReference() {
			return ProxyQDomNode().IsEntityReference();
		}
		[SmokeMethod("isText() const")]
		public virtual bool IsText() {
			return ProxyQDomNode().IsText();
		}
		[SmokeMethod("isEntity() const")]
		public virtual bool IsEntity() {
			return ProxyQDomNode().IsEntity();
		}
		[SmokeMethod("isNotation() const")]
		public virtual bool IsNotation() {
			return ProxyQDomNode().IsNotation();
		}
		[SmokeMethod("isProcessingInstruction() const")]
		public virtual bool IsProcessingInstruction() {
			return ProxyQDomNode().IsProcessingInstruction();
		}
		[SmokeMethod("isCharacterData() const")]
		public virtual bool IsCharacterData() {
			return ProxyQDomNode().IsCharacterData();
		}
		[SmokeMethod("isComment() const")]
		public virtual bool IsComment() {
			return ProxyQDomNode().IsComment();
		}
		///<remarks>
		/// Shortcut to avoid dealing with QDomArrayList
		/// all the time.
		///     </remarks>		<short>    Shortcut to avoid dealing with QDomNodeList  all the time.</short>
		[SmokeMethod("namedItem(const QString&) const")]
		public QDomNode NamedItem(string name) {
			return ProxyQDomNode().NamedItem(name);
		}
		[SmokeMethod("isNull() const")]
		public bool IsNull() {
			return ProxyQDomNode().IsNull();
		}
		[SmokeMethod("clear()")]
		public void Clear() {
			ProxyQDomNode().Clear();
		}
		[SmokeMethod("toAttr()")]
		public QDomAttr ToAttr() {
			return ProxyQDomNode().ToAttr();
		}
		[SmokeMethod("toCDATASection()")]
		public QDomCDATASection ToCDATASection() {
			return ProxyQDomNode().ToCDATASection();
		}
		[SmokeMethod("toDocumentFragment()")]
		public QDomDocumentFragment ToDocumentFragment() {
			return ProxyQDomNode().ToDocumentFragment();
		}
		[SmokeMethod("toDocument()")]
		public QDomDocument ToDocument() {
			return ProxyQDomNode().ToDocument();
		}
		[SmokeMethod("toDocumentType()")]
		public QDomDocumentType ToDocumentType() {
			return ProxyQDomNode().ToDocumentType();
		}
		[SmokeMethod("toElement()")]
		public QDomElement ToElement() {
			return ProxyQDomNode().ToElement();
		}
		[SmokeMethod("toEntityReference()")]
		public QDomEntityReference ToEntityReference() {
			return ProxyQDomNode().ToEntityReference();
		}
		[SmokeMethod("toText()")]
		public QDomText ToText() {
			return ProxyQDomNode().ToText();
		}
		[SmokeMethod("toEntity()")]
		public QDomEntity ToEntity() {
			return ProxyQDomNode().ToEntity();
		}
		[SmokeMethod("toNotation()")]
		public QDomNotation ToNotation() {
			return ProxyQDomNode().ToNotation();
		}
		[SmokeMethod("toProcessingInstruction()")]
		public QDomProcessingInstruction ToProcessingInstruction() {
			return ProxyQDomNode().ToProcessingInstruction();
		}
		[SmokeMethod("toCharacterData()")]
		public QDomCharacterData ToCharacterData() {
			return ProxyQDomNode().ToCharacterData();
		}
		[SmokeMethod("toComment()")]
		public QDomComment ToComment() {
			return ProxyQDomNode().ToComment();
		}
		[SmokeMethod("save(QTextStream&, int) const")]
		public void Save(QTextStream arg1, int arg2) {
			ProxyQDomNode().Save(arg1,arg2);
		}
		// QDomNode* QDomNode(QDomNodePrivate* arg1); >>>> NOT CONVERTED
		~QDomNode() {
			DisposeQDomNode();
		}
		public void Dispose() {
			DisposeQDomNode();
		}
		private void DisposeQDomNode() {
			ProxyQDomNode().DisposeQDomNode();
		}
	}
}
