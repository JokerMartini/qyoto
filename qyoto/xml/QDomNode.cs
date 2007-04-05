//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;

	[SmokeClass("QDomNode")]
	public class QDomNode : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QDomNode(Type dummy) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QDomNode), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QDomNode() {
			staticInterceptor = new SmokeInvocation(typeof(QDomNode), null);
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
		public enum EncodingPolicy {
			EncodingFromDocument = 1,
			EncodingFromTextStream = 2,
		}
		// QDomNode* QDomNode(QDomNodePrivate* arg1); >>>> NOT CONVERTED
		public QDomNode() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDomNode", "QDomNode()", typeof(void));
		}
		public QDomNode(QDomNode arg1) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QDomNode#", "QDomNode(const QDomNode&)", typeof(void), typeof(QDomNode), arg1);
		}
		public override bool Equals(object o) {
			if (!(o is QDomNode)) { return false; }
			return this == (QDomNode) o;
		}
		public override int GetHashCode() {
			return interceptor.GetHashCode();
		}
		public QDomNode InsertBefore(QDomNode newChild, QDomNode refChild) {
			return (QDomNode) interceptor.Invoke("insertBefore##", "insertBefore(const QDomNode&, const QDomNode&)", typeof(QDomNode), typeof(QDomNode), newChild, typeof(QDomNode), refChild);
		}
		public QDomNode InsertAfter(QDomNode newChild, QDomNode refChild) {
			return (QDomNode) interceptor.Invoke("insertAfter##", "insertAfter(const QDomNode&, const QDomNode&)", typeof(QDomNode), typeof(QDomNode), newChild, typeof(QDomNode), refChild);
		}
		public QDomNode ReplaceChild(QDomNode newChild, QDomNode oldChild) {
			return (QDomNode) interceptor.Invoke("replaceChild##", "replaceChild(const QDomNode&, const QDomNode&)", typeof(QDomNode), typeof(QDomNode), newChild, typeof(QDomNode), oldChild);
		}
		public QDomNode RemoveChild(QDomNode oldChild) {
			return (QDomNode) interceptor.Invoke("removeChild#", "removeChild(const QDomNode&)", typeof(QDomNode), typeof(QDomNode), oldChild);
		}
		public QDomNode AppendChild(QDomNode newChild) {
			return (QDomNode) interceptor.Invoke("appendChild#", "appendChild(const QDomNode&)", typeof(QDomNode), typeof(QDomNode), newChild);
		}
		public bool HasChildNodes() {
			return (bool) interceptor.Invoke("hasChildNodes", "hasChildNodes() const", typeof(bool));
		}
		public QDomNode CloneNode(bool deep) {
			return (QDomNode) interceptor.Invoke("cloneNode$", "cloneNode(bool) const", typeof(QDomNode), typeof(bool), deep);
		}
		public QDomNode CloneNode() {
			return (QDomNode) interceptor.Invoke("cloneNode", "cloneNode() const", typeof(QDomNode));
		}
		public void Normalize() {
			interceptor.Invoke("normalize", "normalize()", typeof(void));
		}
		public bool IsSupported(string feature, string version) {
			return (bool) interceptor.Invoke("isSupported$$", "isSupported(const QString&, const QString&) const", typeof(bool), typeof(string), feature, typeof(string), version);
		}
		public string NodeName() {
			return (string) interceptor.Invoke("nodeName", "nodeName() const", typeof(string));
		}
		public QDomNode.NodeType nodeType() {
			return (QDomNode.NodeType) interceptor.Invoke("nodeType", "nodeType() const", typeof(QDomNode.NodeType));
		}
		public QDomNode ParentNode() {
			return (QDomNode) interceptor.Invoke("parentNode", "parentNode() const", typeof(QDomNode));
		}
		public QDomNodeList ChildNodes() {
			return (QDomNodeList) interceptor.Invoke("childNodes", "childNodes() const", typeof(QDomNodeList));
		}
		public QDomNode FirstChild() {
			return (QDomNode) interceptor.Invoke("firstChild", "firstChild() const", typeof(QDomNode));
		}
		public QDomNode LastChild() {
			return (QDomNode) interceptor.Invoke("lastChild", "lastChild() const", typeof(QDomNode));
		}
		public QDomNode PreviousSibling() {
			return (QDomNode) interceptor.Invoke("previousSibling", "previousSibling() const", typeof(QDomNode));
		}
		public QDomNode NextSibling() {
			return (QDomNode) interceptor.Invoke("nextSibling", "nextSibling() const", typeof(QDomNode));
		}
		public QDomNamedNodeMap Attributes() {
			return (QDomNamedNodeMap) interceptor.Invoke("attributes", "attributes() const", typeof(QDomNamedNodeMap));
		}
		public QDomDocument OwnerDocument() {
			return (QDomDocument) interceptor.Invoke("ownerDocument", "ownerDocument() const", typeof(QDomDocument));
		}
		public string NamespaceURI() {
			return (string) interceptor.Invoke("namespaceURI", "namespaceURI() const", typeof(string));
		}
		public string LocalName() {
			return (string) interceptor.Invoke("localName", "localName() const", typeof(string));
		}
		public bool HasAttributes() {
			return (bool) interceptor.Invoke("hasAttributes", "hasAttributes() const", typeof(bool));
		}
		public string NodeValue() {
			return (string) interceptor.Invoke("nodeValue", "nodeValue() const", typeof(string));
		}
		public void SetNodeValue(string arg1) {
			interceptor.Invoke("setNodeValue$", "setNodeValue(const QString&)", typeof(void), typeof(string), arg1);
		}
		public string Prefix() {
			return (string) interceptor.Invoke("prefix", "prefix() const", typeof(string));
		}
		public void SetPrefix(string pre) {
			interceptor.Invoke("setPrefix$", "setPrefix(const QString&)", typeof(void), typeof(string), pre);
		}
		public bool IsAttr() {
			return (bool) interceptor.Invoke("isAttr", "isAttr() const", typeof(bool));
		}
		public bool IsCDATASection() {
			return (bool) interceptor.Invoke("isCDATASection", "isCDATASection() const", typeof(bool));
		}
		public bool IsDocumentFragment() {
			return (bool) interceptor.Invoke("isDocumentFragment", "isDocumentFragment() const", typeof(bool));
		}
		public bool IsDocument() {
			return (bool) interceptor.Invoke("isDocument", "isDocument() const", typeof(bool));
		}
		public bool IsDocumentType() {
			return (bool) interceptor.Invoke("isDocumentType", "isDocumentType() const", typeof(bool));
		}
		public bool IsElement() {
			return (bool) interceptor.Invoke("isElement", "isElement() const", typeof(bool));
		}
		public bool IsEntityReference() {
			return (bool) interceptor.Invoke("isEntityReference", "isEntityReference() const", typeof(bool));
		}
		public bool IsText() {
			return (bool) interceptor.Invoke("isText", "isText() const", typeof(bool));
		}
		public bool IsEntity() {
			return (bool) interceptor.Invoke("isEntity", "isEntity() const", typeof(bool));
		}
		public bool IsNotation() {
			return (bool) interceptor.Invoke("isNotation", "isNotation() const", typeof(bool));
		}
		public bool IsProcessingInstruction() {
			return (bool) interceptor.Invoke("isProcessingInstruction", "isProcessingInstruction() const", typeof(bool));
		}
		public bool IsCharacterData() {
			return (bool) interceptor.Invoke("isCharacterData", "isCharacterData() const", typeof(bool));
		}
		public bool IsComment() {
			return (bool) interceptor.Invoke("isComment", "isComment() const", typeof(bool));
		}
		///<remarks>
		/// Shortcut to avoid dealing with QDomArrayList
		/// all the time.
		///     </remarks>		<short>    Shortcut to avoid dealing with QDomNodeList  all the time.</short>
		public QDomNode NamedItem(string name) {
			return (QDomNode) interceptor.Invoke("namedItem$", "namedItem(const QString&) const", typeof(QDomNode), typeof(string), name);
		}
		public bool IsNull() {
			return (bool) interceptor.Invoke("isNull", "isNull() const", typeof(bool));
		}
		public void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		public QDomAttr ToAttr() {
			return (QDomAttr) interceptor.Invoke("toAttr", "toAttr() const", typeof(QDomAttr));
		}
		public QDomCDATASection ToCDATASection() {
			return (QDomCDATASection) interceptor.Invoke("toCDATASection", "toCDATASection() const", typeof(QDomCDATASection));
		}
		public QDomDocumentFragment ToDocumentFragment() {
			return (QDomDocumentFragment) interceptor.Invoke("toDocumentFragment", "toDocumentFragment() const", typeof(QDomDocumentFragment));
		}
		public QDomDocument ToDocument() {
			return (QDomDocument) interceptor.Invoke("toDocument", "toDocument() const", typeof(QDomDocument));
		}
		public QDomDocumentType ToDocumentType() {
			return (QDomDocumentType) interceptor.Invoke("toDocumentType", "toDocumentType() const", typeof(QDomDocumentType));
		}
		public QDomElement ToElement() {
			return (QDomElement) interceptor.Invoke("toElement", "toElement() const", typeof(QDomElement));
		}
		public QDomEntityReference ToEntityReference() {
			return (QDomEntityReference) interceptor.Invoke("toEntityReference", "toEntityReference() const", typeof(QDomEntityReference));
		}
		public QDomText ToText() {
			return (QDomText) interceptor.Invoke("toText", "toText() const", typeof(QDomText));
		}
		public QDomEntity ToEntity() {
			return (QDomEntity) interceptor.Invoke("toEntity", "toEntity() const", typeof(QDomEntity));
		}
		public QDomNotation ToNotation() {
			return (QDomNotation) interceptor.Invoke("toNotation", "toNotation() const", typeof(QDomNotation));
		}
		public QDomProcessingInstruction ToProcessingInstruction() {
			return (QDomProcessingInstruction) interceptor.Invoke("toProcessingInstruction", "toProcessingInstruction() const", typeof(QDomProcessingInstruction));
		}
		public QDomCharacterData ToCharacterData() {
			return (QDomCharacterData) interceptor.Invoke("toCharacterData", "toCharacterData() const", typeof(QDomCharacterData));
		}
		public QDomComment ToComment() {
			return (QDomComment) interceptor.Invoke("toComment", "toComment() const", typeof(QDomComment));
		}
		public void Save(QTextStream arg1, int arg2) {
			interceptor.Invoke("save#$", "save(QTextStream&, int) const", typeof(void), typeof(QTextStream), arg1, typeof(int), arg2);
		}
		public void Save(QTextStream arg1, int arg2, QDomNode.EncodingPolicy arg3) {
			interceptor.Invoke("save#$$", "save(QTextStream&, int, QDomNode::EncodingPolicy) const", typeof(void), typeof(QTextStream), arg1, typeof(int), arg2, typeof(QDomNode.EncodingPolicy), arg3);
		}
		public QDomElement FirstChildElement(string tagName) {
			return (QDomElement) interceptor.Invoke("firstChildElement$", "firstChildElement(const QString&) const", typeof(QDomElement), typeof(string), tagName);
		}
		public QDomElement FirstChildElement() {
			return (QDomElement) interceptor.Invoke("firstChildElement", "firstChildElement() const", typeof(QDomElement));
		}
		public QDomElement LastChildElement(string tagName) {
			return (QDomElement) interceptor.Invoke("lastChildElement$", "lastChildElement(const QString&) const", typeof(QDomElement), typeof(string), tagName);
		}
		public QDomElement LastChildElement() {
			return (QDomElement) interceptor.Invoke("lastChildElement", "lastChildElement() const", typeof(QDomElement));
		}
		public QDomElement PreviousSiblingElement(string tagName) {
			return (QDomElement) interceptor.Invoke("previousSiblingElement$", "previousSiblingElement(const QString&) const", typeof(QDomElement), typeof(string), tagName);
		}
		public QDomElement PreviousSiblingElement() {
			return (QDomElement) interceptor.Invoke("previousSiblingElement", "previousSiblingElement() const", typeof(QDomElement));
		}
		public QDomElement NextSiblingElement(string taName) {
			return (QDomElement) interceptor.Invoke("nextSiblingElement$", "nextSiblingElement(const QString&) const", typeof(QDomElement), typeof(string), taName);
		}
		public QDomElement NextSiblingElement() {
			return (QDomElement) interceptor.Invoke("nextSiblingElement", "nextSiblingElement() const", typeof(QDomElement));
		}
		public int LineNumber() {
			return (int) interceptor.Invoke("lineNumber", "lineNumber() const", typeof(int));
		}
		public int ColumnNumber() {
			return (int) interceptor.Invoke("columnNumber", "columnNumber() const", typeof(int));
		}
		~QDomNode() {
			interceptor.Invoke("~QDomNode", "~QDomNode()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QDomNode", "~QDomNode()", typeof(void));
		}
		public static bool operator==(QDomNode lhs, QDomNode arg1) {
			return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QDomNode&) const", typeof(bool), typeof(QDomNode), lhs, typeof(QDomNode), arg1);
		}
		public static bool operator!=(QDomNode lhs, QDomNode arg1) {
			return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QDomNode&) const", typeof(bool), typeof(QDomNode), lhs, typeof(QDomNode), arg1);
		}
	}
}
