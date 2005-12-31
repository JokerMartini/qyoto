//Auto-generated by ../../kalyptus/kalyptus. DO NOT EDIT.
namespace Qt {

	using System;
	using System.Text;

	///<remarks>*************************************************
	/// $Id: qt/qtimer.h   3.3.5   edited Aug 31 12:17 $
	///
	///* Definition of QTimer class
	///
	///* Created : 931111
	///
	///* Copyright (C) 1992-2005 Trolltech AS.  All rights reserved.
	///
	///* This file is part of the kernel module of the Qt GUI Toolkit.
	///
	///* This file may be distributed under the terms of the Q Public License
	/// as defined by Trolltech AS of Norway and appearing in the file
	/// LICENSE.QPL included in the packaging of this file.
	///
	///* This file may be distributed and/or modified under the terms of the
	/// GNU General Public License version 2 as published by the Free Software
	/// Foundation and appearing in the file LICENSE.GPL included in the
	/// packaging of this file.
	///
	///* Licensees holding valid Qt Enterprise Edition or Qt Professional Edition
	/// licenses may use this file in accordance with the Qt Commercial License
	/// Agreement provided with the Software.
	///
	///* This file is provided AS IS with NO WARRANTY OF ANY KIND, INCLUDING THE
	/// WARRANTY OF DESIGN, MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE.
	///
	///* See http://www.trolltech.com/pricing.html or email sales@trolltech.com for
	///   information about Qt Commercial License Agreements.
	/// See http://www.trolltech.com/qpl/ for QPL licensing information.
	/// See http://www.trolltech.com/gpl/ for GPL licensing information.
	///
	///* Contact info@trolltech.com if any conditions of this licensing are
	/// not clear to you.
	///
	///********************************************** See <see cref="IQTimerSignals"></see> for signals emitted by QTimer
	///</remarks>		<short>                                                                               $Id: qt/qtimer.</short>

	public class QTimer : QObject, IDisposable {
 		protected QTimer(Type dummy) : base((Type) null) {}
		interface IQTimerProxy {
			string Tr(string arg1, string arg2);
			string Tr(string arg1);
			string TrUtf8(string arg1, string arg2);
			string TrUtf8(string arg1);
			void SingleShot(int msec, QObject receiver, string member);
		}

		protected void CreateQTimerProxy() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(QTimer), this);
			_interceptor = (QTimer) realProxy.GetTransparentProxy();
		}
		private QTimer ProxyQTimer() {
			return (QTimer) _interceptor;
		}
		private static Object _staticInterceptor = null;
		static QTimer() {
			SmokeInvocation realProxy = new SmokeInvocation(typeof(IQTimerProxy), null);
			_staticInterceptor = (IQTimerProxy) realProxy.GetTransparentProxy();
		}
		private static IQTimerProxy StaticQTimer() {
			return (IQTimerProxy) _staticInterceptor;
		}

		[SmokeMethod("metaObject() const")]
		public new virtual QMetaObject MetaObject() {
			return ProxyQTimer().MetaObject();
		}
		[SmokeMethod("className() const")]
		public new virtual string ClassName() {
			return ProxyQTimer().ClassName();
		}
		public QTimer(QObject parent, string name) : this((Type) null) {
			CreateQTimerProxy();
			CreateQTimerSignalProxy();
			NewQTimer(parent,name);
		}
		[SmokeMethod("QTimer(QObject*, const char*)")]
		private void NewQTimer(QObject parent, string name) {
			ProxyQTimer().NewQTimer(parent,name);
		}
		public QTimer(QObject parent) : this((Type) null) {
			CreateQTimerProxy();
			CreateQTimerSignalProxy();
			NewQTimer(parent);
		}
		[SmokeMethod("QTimer(QObject*)")]
		private void NewQTimer(QObject parent) {
			ProxyQTimer().NewQTimer(parent);
		}
		public QTimer() : this((Type) null) {
			CreateQTimerProxy();
			CreateQTimerSignalProxy();
			NewQTimer();
		}
		[SmokeMethod("QTimer()")]
		private void NewQTimer() {
			ProxyQTimer().NewQTimer();
		}
		[SmokeMethod("isActive() const")]
		public bool IsActive() {
			return ProxyQTimer().IsActive();
		}
		[SmokeMethod("start(int, bool)")]
		public int Start(int msec, bool sshot) {
			return ProxyQTimer().Start(msec,sshot);
		}
		[SmokeMethod("start(int)")]
		public int Start(int msec) {
			return ProxyQTimer().Start(msec);
		}
		[SmokeMethod("changeInterval(int)")]
		public void ChangeInterval(int msec) {
			ProxyQTimer().ChangeInterval(msec);
		}
		[SmokeMethod("stop()")]
		public void Stop() {
			ProxyQTimer().Stop();
		}
		[SmokeMethod("timerId() const")]
		public int TimerId() {
			return ProxyQTimer().TimerId();
		}
		[SmokeMethod("tr(const char*, const char*)")]
		public static new string Tr(string arg1, string arg2) {
			return StaticQTimer().Tr(arg1,arg2);
		}
		[SmokeMethod("tr(const char*)")]
		public static new string Tr(string arg1) {
			return StaticQTimer().Tr(arg1);
		}
		[SmokeMethod("trUtf8(const char*, const char*)")]
		public static new string TrUtf8(string arg1, string arg2) {
			return StaticQTimer().TrUtf8(arg1,arg2);
		}
		[SmokeMethod("trUtf8(const char*)")]
		public static new string TrUtf8(string arg1) {
			return StaticQTimer().TrUtf8(arg1);
		}
		[SmokeMethod("singleShot(int, QObject*, const char*)")]
		public static void SingleShot(int msec, QObject receiver, string member) {
			StaticQTimer().SingleShot(msec,receiver,member);
		}
		[SmokeMethod("event(QEvent*)")]
		public new bool Event(QEvent arg1) {
			return ProxyQTimer().Event(arg1);
		}
		~QTimer() {
			DisposeQTimer();
		}
		public new void Dispose() {
			DisposeQTimer();
		}
		private void DisposeQTimer() {
			ProxyQTimer().DisposeQTimer();
		}
		protected void CreateQTimerSignalProxy() {
			SignalInvocation realProxy = new SignalInvocation(typeof(IQTimerSignals), this);
			_signalInterceptor = (IQTimerSignals) realProxy.GetTransparentProxy();
		}
		protected new IQTimerSignals Emit() {
			return (IQTimerSignals) _signalInterceptor;
		}
	}

	public interface IQTimerSignals : IQObjectSignals {
		[Q_SIGNAL("timeout()")]
		void Timeout();
	}
}
