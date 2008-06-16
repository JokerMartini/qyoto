//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	using System.Collections.Generic;
	/// <remarks> See <see cref="IQAbstractTextDocumentLayoutSignals"></see> for signals emitted by QAbstractTextDocumentLayout
	/// </remarks>
	[SmokeClass("QAbstractTextDocumentLayout")]
	public abstract class QAbstractTextDocumentLayout : QObject {
 		protected QAbstractTextDocumentLayout(Type dummy) : base((Type) null) {}
		[SmokeClass("QAbstractTextDocumentLayout::Selection")]
		public class Selection : Object {
			protected SmokeInvocation interceptor = null;
			private IntPtr smokeObject;
			protected Selection(Type dummy) {}
			public QTextCursor Cursor {
				get { return (QTextCursor) interceptor.Invoke("cursor", "cursor()", typeof(QTextCursor)); }
			}
			public QTextCharFormat Format {
				get { return (QTextCharFormat) interceptor.Invoke("format", "format()", typeof(QTextCharFormat)); }
			}
		}
		[SmokeClass("QAbstractTextDocumentLayout::PaintContext")]
		public class PaintContext : Object {
			protected SmokeInvocation interceptor = null;
			private IntPtr smokeObject;
			protected PaintContext(Type dummy) {}
			public int CursorPosition {
				get { return (int) interceptor.Invoke("cursorPosition", "cursorPosition()", typeof(int)); }
			}
			public QPalette Palette {
				get { return (QPalette) interceptor.Invoke("palette", "palette()", typeof(QPalette)); }
			}
			public QRectF Clip {
				get { return (QRectF) interceptor.Invoke("clip", "clip()", typeof(QRectF)); }
			}
			public List<QAbstractTextDocumentLayout.Selection> Selections {
				get { return (List<QAbstractTextDocumentLayout.Selection>) interceptor.Invoke("selections", "selections()", typeof(List<QAbstractTextDocumentLayout.Selection>)); }
			}
			//  PaintContext(); >>>> NOT CONVERTED
		}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QAbstractTextDocumentLayout), this);
		}
		private static SmokeInvocation staticInterceptor = null;
		static QAbstractTextDocumentLayout() {
			staticInterceptor = new SmokeInvocation(typeof(QAbstractTextDocumentLayout), null);
		}
		// void draw(QPainter* arg1,const QAbstractTextDocumentLayout::PaintContext& arg2); >>>> NOT CONVERTED
		// QAbstractTextDocumentLayout* QAbstractTextDocumentLayout(QAbstractTextDocumentLayoutPrivate& arg1,QTextDocument* arg2); >>>> NOT CONVERTED
		public QAbstractTextDocumentLayout(QTextDocument doc) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QAbstractTextDocumentLayout#", "QAbstractTextDocumentLayout(QTextDocument*)", typeof(void), typeof(QTextDocument), doc);
		}
		[SmokeMethod("hitTest(const QPointF&, Qt::HitTestAccuracy) const")]
		public abstract int HitTest(QPointF point, Qt.HitTestAccuracy accuracy);
		public string AnchorAt(QPointF pos) {
			return (string) interceptor.Invoke("anchorAt#", "anchorAt(const QPointF&) const", typeof(string), typeof(QPointF), pos);
		}
		[SmokeMethod("pageCount() const")]
		public abstract int PageCount();
		[SmokeMethod("documentSize() const")]
		public abstract QSizeF DocumentSize();
		[SmokeMethod("frameBoundingRect(QTextFrame*) const")]
		public abstract QRectF FrameBoundingRect(QTextFrame frame);
		[SmokeMethod("blockBoundingRect(const QTextBlock&) const")]
		public abstract QRectF BlockBoundingRect(QTextBlock block);
		public void SetPaintDevice(IQPaintDevice device) {
			interceptor.Invoke("setPaintDevice#", "setPaintDevice(QPaintDevice*)", typeof(void), typeof(IQPaintDevice), device);
		}
		public IQPaintDevice PaintDevice() {
			return (IQPaintDevice) interceptor.Invoke("paintDevice", "paintDevice() const", typeof(IQPaintDevice));
		}
		public QTextDocument Document() {
			return (QTextDocument) interceptor.Invoke("document", "document() const", typeof(QTextDocument));
		}
		public void RegisterHandler(int objectType, QObject component) {
			interceptor.Invoke("registerHandler$#", "registerHandler(int, QObject*)", typeof(void), typeof(int), objectType, typeof(QObject), component);
		}
		public QTextObjectInterface HandlerForObject(int objectType) {
			return (QTextObjectInterface) interceptor.Invoke("handlerForObject$", "handlerForObject(int) const", typeof(QTextObjectInterface), typeof(int), objectType);
		}
		[SmokeMethod("documentChanged(int, int, int)")]
		protected abstract void DocumentChanged(int from, int charsRemoved, int charsAdded);
		[SmokeMethod("resizeInlineObject(QTextInlineObject, int, const QTextFormat&)")]
		protected virtual void ResizeInlineObject(QTextInlineObject item, int posInDocument, QTextFormat format) {
			interceptor.Invoke("resizeInlineObject#$#", "resizeInlineObject(QTextInlineObject, int, const QTextFormat&)", typeof(void), typeof(QTextInlineObject), item, typeof(int), posInDocument, typeof(QTextFormat), format);
		}
		[SmokeMethod("positionInlineObject(QTextInlineObject, int, const QTextFormat&)")]
		protected virtual void PositionInlineObject(QTextInlineObject item, int posInDocument, QTextFormat format) {
			interceptor.Invoke("positionInlineObject#$#", "positionInlineObject(QTextInlineObject, int, const QTextFormat&)", typeof(void), typeof(QTextInlineObject), item, typeof(int), posInDocument, typeof(QTextFormat), format);
		}
		[SmokeMethod("drawInlineObject(QPainter*, const QRectF&, QTextInlineObject, int, const QTextFormat&)")]
		protected virtual void DrawInlineObject(QPainter painter, QRectF rect, QTextInlineObject arg3, int posInDocument, QTextFormat format) {
			interceptor.Invoke("drawInlineObject###$#", "drawInlineObject(QPainter*, const QRectF&, QTextInlineObject, int, const QTextFormat&)", typeof(void), typeof(QPainter), painter, typeof(QRectF), rect, typeof(QTextInlineObject), arg3, typeof(int), posInDocument, typeof(QTextFormat), format);
		}
		protected int FormatIndex(int pos) {
			return (int) interceptor.Invoke("formatIndex$", "formatIndex(int)", typeof(int), typeof(int), pos);
		}
		protected QTextCharFormat Format(int pos) {
			return (QTextCharFormat) interceptor.Invoke("format$", "format(int)", typeof(QTextCharFormat), typeof(int), pos);
		}
		public static new string Tr(string s, string c) {
			return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
		}
		public static new string Tr(string s) {
			return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
		}
		protected new IQAbstractTextDocumentLayoutSignals Emit {
			get { return (IQAbstractTextDocumentLayoutSignals) Q_EMIT; }
		}
	}

	public interface IQAbstractTextDocumentLayoutSignals : IQObjectSignals {
		[Q_SIGNAL("void update(const QRectF&)")]
		void Update(QRectF arg1);
		[Q_SIGNAL("void update()")]
		void Update();
		[Q_SIGNAL("void updateBlock(const QTextBlock&)")]
		void UpdateBlock(QTextBlock block);
		[Q_SIGNAL("void documentSizeChanged(const QSizeF&)")]
		void DocumentSizeChanged(QSizeF newSize);
		[Q_SIGNAL("void pageCountChanged(int)")]
		void PageCountChanged(int newPages);
	}
}
