//Auto-generated by kalyptus. DO NOT EDIT.
namespace KTextEditor {
    using Kimono;
    using System;
    using Qyoto;
    using System.Collections.Generic;
    /// <remarks>
    ///  \brief Search interface extension for the Document.
    ///  \ingroup kte_group_doc_extensions
    ///  \section searchiface_intro Introduction
    ///  The SearchInterface provides methods to search for a given text pattern in
    ///  a Document. You can either search for a simple text or for a regular
    ///  expression, see searchText.
    ///  \section searchiface_access Accessing the SearchInterface
    ///  The SearchInterface is supposed to be an extension interface for a
    ///  Document, i.e. the Document inherits the interface \e provided that the
    ///  used KTextEditor library implements the interface. Use qobject_cast to
    ///  access the interface:
    ///  <pre>
    ///  // doc is of type KTextEditor.Document
    ///  KTextEditor.SearchInterface iface =
    ///      qobject_cast<KTextEditor.SearchInterface>( doc );
    ///  if( iface ) {
    ///      // the implementation supports the interface
    ///      // do stuff
    ///  }
    ///  </pre>
    ///  \see KTextEditor.Document
    ///  \author Christoph Cullmann \<cullmann@kde.org\>
    ///  </remarks>        <short>    \brief Search interface extension for the Document.</short>
    [SmokeClass("KTextEditor::SearchInterface")]
    public abstract class SearchInterface : Object {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected SearchInterface(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(SearchInterface), this);
        }
        /// <remarks>
        ///  Constructor.
        ///      </remarks>        <short>    Constructor.</short>
        public SearchInterface() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("SearchInterface", "SearchInterface()", typeof(void));
        }
        /// <remarks>
        ///  \brief Searches the given input range for a text pattern.
        ///  Searches for a text pattern within the given input range.
        ///  The kind of search performed depends on the <code>options</code>
        ///  used. Use this function for plaintext searches as well as
        ///  regular expression searches. Query supportedSearchOptions
        ///  to find out, which options the current implementation does
        ///  support. If no match is found the first (and only) element
        ///  in the vector return is the invalid range. When searching
        ///  for regular expressions, the first element holds the
        ///  range of the full match, the subsequent elements hold
        ///  the ranges of the capturing parentheses.
        ///  \param range    Input range to search in
        ///  \param pattern  Text pattern to search for
        ///  \param options  Combination of search flags
        ///  \return         List of ranges (length >=1)
        ///  \see Search.SearchOptionsEnum
        ///  \author Sebastian Pipping \<webmaster@hartwork.org\>
        ///      </remarks>        <short>    \brief Searches the given input range for a text pattern.</short>
        [SmokeMethod("searchText(const KTextEditor::Range&, const QString&, const KTextEditor::Search::SearchOptions)")]
        public virtual List<KTextEditor.Range> SearchText(KTextEditor.Range range, string pattern, uint options) {
            return (List<KTextEditor.Range>) interceptor.Invoke("searchText#$$", "searchText(const KTextEditor::Range&, const QString&, const KTextEditor::Search::SearchOptions)", typeof(List<KTextEditor.Range>), typeof(KTextEditor.Range), range, typeof(string), pattern, typeof(uint), options);
        }
        [SmokeMethod("searchText(const KTextEditor::Range&, const QString&)")]
        public virtual List<KTextEditor.Range> SearchText(KTextEditor.Range range, string pattern) {
            return (List<KTextEditor.Range>) interceptor.Invoke("searchText#$", "searchText(const KTextEditor::Range&, const QString&)", typeof(List<KTextEditor.Range>), typeof(KTextEditor.Range), range, typeof(string), pattern);
        }
        /// <remarks>
        ///  \brief Specifies all options supported by searchText.
        ///  \return  Combination of all flags supported by searchText
        ///  \see Search.SearchOptionsEnum
        ///  \author Sebastian Pipping \<webmaster@hartwork.org\>
        ///      </remarks>        <short>    \brief Specifies all options supported by searchText.</short>
        [SmokeMethod("supportedSearchOptions() const")]
        public virtual uint SupportedSearchOptions() {
            return (uint) interceptor.Invoke("supportedSearchOptions", "supportedSearchOptions() const", typeof(uint));
        }
    }
}
