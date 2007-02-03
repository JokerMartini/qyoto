//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Text;

	[SmokeClass("QDomNode")]
	public class QDomNode : MarshalByRefObject, IDisposable {
		protected Object _interceptor = null;
 
		private IntPtr _smokeObject;
		protected QDomNode(Type dummy) {}
		[SmokeClass("QDomNode")]
		interface IQDomNodeProxy {
			[SmokeMethod("operator==", "(const QDomNode&) const", "#")]
			bool op_equals(QDomNode lhs, QDomNode arg1);
		}

		protected new void CreateProxy() {
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
			CreateProxy();
			NewQDomNode();
		}
		[SmokeMethod("QDomNode", "()", "")]
		private void NewQDomNode() {
			ProxyQDomNode().NewQDomNode();
		}
		public QDomNode(QDomNode arg1) : this((Type) null) {
			CreateProxy();
			NewQDomNode(arg1);
		}
		[SmokeMethod("QDomNode", "(const QDomNode&)", "#")]
		private void NewQDomNode(QDomNode arg1) {
			ProxyQDomNode().NewQDomNode(arg1);
		}
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
		[SmokeMethod("insertBefore", "(const QDomNode&, const QDomNode&)", "##")]
		public QDomNode InsertBefore(QDomNode newChild, QDomNode refChild) {
			return ProxyQDomNode().InsertBefore(newChild,refChild);
		}
		[SmokeMethod("insertAfter", "(const QDomNode&, const QDomNode&)", "##")]
		public QDomNode InsertAfter(QDomNode newChild, QDomNode refChild) {
			return ProxyQDomNode().InsertAfter(newChild,refChild);
		}
		[SmokeMethod("replaceChild", "(const QDomNode&, const QDomNode&)", "##")]
		public QDomNode ReplaceChild(QDomNode newChild, QDomNode oldChild) {
			return ProxyQDomNode().ReplaceChild(newChild,oldChild);
		}
		[SmokeMethod("removeChild", "(const QDomNode&)", "#")]
		public QDomNode RemoveChild(QDomNode oldChild) {
			return ProxyQDomNode().RemoveChild(oldChild);
		}
		[SmokeMethod("appendChild", "(const QDomNode&)", "#")]
		public QDomNode AppendChild(QDomNode newChild) {
			return ProxyQDomNode().AppendChild(newChild);
		}
		[SmokeMethod("hasChildNodes", "() const", "")]
		public bool HasChildNodes() {
			return ProxyQDomNode().HasChildNodes();
		}
		[SmokeMethod("cloneNode", "(bool) const", "$")]
		public QDomNode CloneNode(bool deep) {
			return ProxyQDomNode().CloneNode(deep);
		}
		[SmokeMethod("cloneNode", "() const", "")]
		public QDomNode CloneNode() {
			return ProxyQDomNode().CloneNode();
		}
		[SmokeMethod("normalize", "()", "")]
		public void Normalize() {
			ProxyQDomNode().Normalize();
		}
		[SmokeMethod("isSupported", "(const QString&, const QString&) const", "$$")]
		public bool IsSupported(string feature, string version) {
			return ProxyQDomNode().IsSupported(feature,version);
		}
		[SmokeMethod("nodeName", "() const", "")]
		public string NodeName() {
			return ProxyQDomNode().NodeName();
		}
		[SmokeMethod("nodeType", "() const", "")]
		public QDomNode.NodeType nodeType() {
			return ProxyQDomNode().nodeType();
		}
		[SmokeMethod("parentNode", "() const", "")]
		public QDomNode ParentNode() {
			return ProxyQDomNode().ParentNode();
		}
		[SmokeMethod("childNodes", "() const", "")]
		public QDomNodeList ChildNodes() {
			return ProxyQDomNode().ChildNodes();
		}
		[SmokeMethod("firstChild", "() const", "")]
		public QDomNode FirstChild() {
			return ProxyQDomNode().FirstChild();
		}
		[SmokeMethod("lastChild", "() const", "")]
		public QDomNode LastChild() {
			return ProxyQDomNode().LastChild();
		}
		[SmokeMethod("previousSibling", "() const", "")]
		public QDomNode PreviousSibling() {
			return ProxyQDomNode().PreviousSibling();
		}
		[SmokeMethod("nextSibling", "() const", "")]
		public QDomNode NextSibling() {
			return ProxyQDomNode().NextSibling();
		}
		[SmokeMethod("attributes", "() const", "")]
		public QDomNamedNodeMap Attributes() {
			return ProxyQDomNode().Attributes();
		}
		[SmokeMethod("ownerDocument", "() const", "")]
		public QDomDocument OwnerDocument() {
			return ProxyQDomNode().OwnerDocument();
		}
		[SmokeMethod("namespaceURI", "() const", "")]
		public string NamespaceURI() {
			return ProxyQDomNode().NamespaceURI();
		}
		[SmokeMethod("localName", "() const", "")]
		public string LocalName() {
			return ProxyQDomNode().LocalName();
		}
		[SmokeMethod("hasAttributes", "() const", "")]
		public bool HasAttributes() {
			return ProxyQDomNode().HasAttributes();
		}
		[SmokeMethod("nodeValue", "() const", "")]
		public string NodeValue() {
			return ProxyQDomNode().NodeValue();
		}
		[SmokeMethod("setNodeValue", "(const QString&)", "$")]
		public void SetNodeValue(string arg1) {
			ProxyQDomNode().SetNodeValue(arg1);
		}
		[SmokeMethod("prefix", "() const", "")]
		public string Prefix() {
			return ProxyQDomNode().Prefix();
		}
		[SmokeMethod("setPrefix", "(const QString&)", "$")]
		public void SetPrefix(string pre) {
			ProxyQDomNode().SetPrefix(pre);
		}
		[SmokeMethod("isAttr", "() const", "")]
		public bool IsAttr() {
			return ProxyQDomNode().IsAttr();
		}
		[SmokeMethod("isCDATASection", "() const", "")]
		public bool IsCDATASection() {
			return ProxyQDomNode().IsCDATASection();
		}
		[SmokeMethod("isDocumentFragment", "() const", "")]
		public bool IsDocumentFragment() {
			return ProxyQDomNode().IsDocumentFragment();
		}
		[SmokeMethod("isDocument", "() const", "")]
		public bool IsDocument() {
			return ProxyQDomNode().IsDocument();
		}
		[SmokeMethod("isDocumentType", "() const", "")]
		public bool IsDocumentType() {
			return ProxyQDomNode().IsDocumentType();
		}
		[SmokeMethod("isElement", "() const", "")]
		public bool IsElement() {
			return ProxyQDomNode().IsElement();
		}
		[SmokeMethod("isEntityReference", "() const", "")]
		public bool IsEntityReference() {
			return ProxyQDomNode().IsEntityReference();
		}
		[SmokeMethod("isText", "() const", "")]
		public bool IsText() {
			return ProxyQDomNode().IsText();
		}
		[SmokeMethod("isEntity", "() const", "")]
		public bool IsEntity() {
			return ProxyQDomNode().IsEntity();
		}
		[SmokeMethod("isNotation", "() const", "")]
		public bool IsNotation() {
			return ProxyQDomNode().IsNotation();
		}
		[SmokeMethod("isProcessingInstruction", "() const", "")]
		public bool IsProcessingInstruction() {
			return ProxyQDomNode().IsProcessingInstruction();
		}
		[SmokeMethod("isCharacterData", "() const", "")]
		public bool IsCharacterData() {
			return ProxyQDomNode().IsCharacterData();
		}
		[SmokeMethod("isComment", "() const", "")]
		public bool IsComment() {
			return ProxyQDomNode().IsComment();
		}
		///<remarks>
		/// Shortcut to avoid dealing with QDomArrayList
		/// all the time.
		///     </remarks>		<short>    Shortcut to avoid dealing with QDomNodeList  all the time.</short>
		[SmokeMethod("namedItem", "(const QString&) const", "$")]
		public QDomNode NamedItem(string name) {
			return ProxyQDomNode().NamedItem(name);
		}
		[SmokeMethod("isNull", "() const", "")]
		public bool IsNull() {
			return ProxyQDomNode().IsNull();
		}
		[SmokeMethod("clear", "()", "")]
		public void Clear() {
			ProxyQDomNode().Clear();
		}
		[SmokeMethod("toAttr", "() const", "")]
		public QDomAttr ToAttr() {
			return ProxyQDomNode().ToAttr();
		}
		[SmokeMethod("toCDATASection", "() const", "")]
		public QDomCDATASection ToCDATASection() {
			return ProxyQDomNode().ToCDATASection();
		}
		[SmokeMethod("toDocumentFragment", "() const", "")]
		public QDomDocumentFragment ToDocumentFragment() {
			return ProxyQDomNode().ToDocumentFragment();
		}
		[SmokeMethod("toDocument", "() const", "")]
		public QDomDocument ToDocument() {
			return ProxyQDomNode().ToDocument();
		}
		[SmokeMethod("toDocumentType", "() const", "")]
		public QDomDocumentType ToDocumentType() {
			return ProxyQDomNode().ToDocumentType();
		}
		[SmokeMethod("toElement", "() const", "")]
		public QDomElement ToElement() {
			return ProxyQDomNode().ToElement();
		}
		[SmokeMethod("toEntityReference", "() const", "")]
		public QDomEntityReference ToEntityReference() {
			return ProxyQDomNode().ToEntityReference();
		}
		[SmokeMethod("toText", "() const", "")]
		public QDomText ToText() {
			return ProxyQDomNode().ToText();
		}
		[SmokeMethod("toEntity", "() const", "")]
		public QDomEntity ToEntity() {
			return ProxyQDomNode().ToEntity();
		}
		[SmokeMethod("toNotation", "() const", "")]
		public QDomNotation ToNotation() {
			return ProxyQDomNode().ToNotation();
		}
		[SmokeMethod("toProcessingInstruction", "() const", "")]
		public QDomProcessingInstruction ToProcessingInstruction() {
			return ProxyQDomNode().ToProcessingInstruction();
		}
		[SmokeMethod("toCharacterData", "() const", "")]
		public QDomCharacterData ToCharacterData() {
			return ProxyQDomNode().ToCharacterData();
		}
		[SmokeMethod("toComment", "() const", "")]
		public QDomComment ToComment() {
			return ProxyQDomNode().ToComment();
		}
		[SmokeMethod("save", "(QTextStream&, int) const", "#$")]
		public void Save(QTextStream arg1, int arg2) {
			ProxyQDomNode().Save(arg1,arg2);
		}
		[SmokeMethod("firstChildElement", "(const QString&) const", "$")]
		public QDomElement FirstChildElement(string tagName) {
			return ProxyQDomNode().FirstChildElement(tagName);
		}
		[SmokeMethod("firstChildElement", "() const", "")]
		public QDomElement FirstChildElement() {
			return ProxyQDomNode().FirstChildElement();
		}
		[SmokeMethod("lastChildElement", "(const QString&) const", "$")]
		public QDomElement LastChildElement(string tagName) {
			return ProxyQDomNode().LastChildElement(tagName);
		}
		[SmokeMethod("lastChildElement", "() const", "")]
		public QDomElement LastChildElement() {
			return ProxyQDomNode().LastChildElement();
		}
		[SmokeMethod("previousSiblingElement", "(const QString&) const", "$")]
		public QDomElement PreviousSiblingElement(string tagName) {
			return ProxyQDomNode().PreviousSiblingElement(tagName);
		}
		[SmokeMethod("previousSiblingElement", "() const", "")]
		public QDomElement PreviousSiblingElement() {
			return ProxyQDomNode().PreviousSiblingElement();
		}
		[SmokeMethod("nextSiblingElement", "(const QString&) const", "$")]
		public QDomElement NextSiblingElement(string taName) {
			return ProxyQDomNode().NextSiblingElement(taName);
		}
		[SmokeMethod("nextSiblingElement", "() const", "")]
		public QDomElement NextSiblingElement() {
			return ProxyQDomNode().NextSiblingElement();
		}
		[SmokeMethod("lineNumber", "() const", "")]
		public int LineNumber() {
			return ProxyQDomNode().LineNumber();
		}
		[SmokeMethod("columnNumber", "() const", "")]
		public int ColumnNumber() {
			return ProxyQDomNode().ColumnNumber();
		}
		// QDomNode* QDomNode(QDomNodePrivate* arg1); >>>> NOT CONVERTED
		~QDomNode() {
			DisposeQDomNode();
		}
		public void Dispose() {
			DisposeQDomNode();
		}
		[SmokeMethod("~QDomNode", "()", "")]
		private void DisposeQDomNode() {
			ProxyQDomNode().DisposeQDomNode();
		}
	}
}
