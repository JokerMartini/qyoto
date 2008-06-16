//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
	using System;
	using System.Collections.Generic;
	[SmokeClass("QAbstractFileEngineIterator")]
	public abstract class QAbstractFileEngineIterator : Object {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QAbstractFileEngineIterator(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QAbstractFileEngineIterator), this);
		}
		public enum EntryInfoType {
		}
		public QAbstractFileEngineIterator(uint filters, List<string> nameFilters) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QAbstractFileEngineIterator$?", "QAbstractFileEngineIterator(QDir::Filters, const QStringList&)", typeof(void), typeof(uint), filters, typeof(List<string>), nameFilters);
		}
		[SmokeMethod("next()")]
		public abstract string Next();
		[SmokeMethod("hasNext() const")]
		public abstract bool HasNext();
		public string Path() {
			return (string) interceptor.Invoke("path", "path() const", typeof(string));
		}
		public List<string> NameFilters() {
			return (List<string>) interceptor.Invoke("nameFilters", "nameFilters() const", typeof(List<string>));
		}
		public uint Filters() {
			return (uint) interceptor.Invoke("filters", "filters() const", typeof(uint));
		}
		[SmokeMethod("currentFileName() const")]
		public abstract string CurrentFileName();
		[SmokeMethod("currentFileInfo() const")]
		public virtual QFileInfo CurrentFileInfo() {
			return (QFileInfo) interceptor.Invoke("currentFileInfo", "currentFileInfo() const", typeof(QFileInfo));
		}
		public string CurrentFilePath() {
			return (string) interceptor.Invoke("currentFilePath", "currentFilePath() const", typeof(string));
		}
		[SmokeMethod("entryInfo(QAbstractFileEngineIterator::EntryInfoType) const")]
		protected virtual QVariant EntryInfo(QAbstractFileEngineIterator.EntryInfoType type) {
			return (QVariant) interceptor.Invoke("entryInfo$", "entryInfo(QAbstractFileEngineIterator::EntryInfoType) const", typeof(QVariant), typeof(QAbstractFileEngineIterator.EntryInfoType), type);
		}
	}
}
