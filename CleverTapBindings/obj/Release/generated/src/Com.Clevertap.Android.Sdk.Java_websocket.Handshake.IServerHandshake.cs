using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket.Handshake {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.handshake']/interface[@name='ServerHandshake']"
	[Register ("com/clevertap/android/sdk/java_websocket/handshake/ServerHandshake", "", "Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeInvoker")]
	public partial interface IServerHandshake : global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.handshake']/interface[@name='ServerHandshake']/method[@name='getHttpStatus' and count(parameter)=0]"
		[Register ("getHttpStatus", "()S", "GetGetHttpStatusHandler:Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeInvoker, CleverTapBindings")]
		short GetHttpStatus ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.handshake']/interface[@name='ServerHandshake']/method[@name='getHttpStatusMessage' and count(parameter)=0]"
		[Register ("getHttpStatusMessage", "()Ljava/lang/String;", "GetGetHttpStatusMessageHandler:Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeInvoker, CleverTapBindings")]
		string GetHttpStatusMessage ();

	}

	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/handshake/ServerHandshake", DoNotGenerateAcw=true)]
	internal class IServerHandshakeInvoker : global::Java.Lang.Object, IServerHandshake {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/clevertap/android/sdk/java_websocket/handshake/ServerHandshake", typeof (IServerHandshakeInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IServerHandshake GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IServerHandshake> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.clevertap.android.sdk.java_websocket.handshake.ServerHandshake"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IServerHandshakeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getHttpStatus;
#pragma warning disable 0169
		static Delegate GetGetHttpStatusHandler ()
		{
			if (cb_getHttpStatus == null)
				cb_getHttpStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetHttpStatus);
			return cb_getHttpStatus;
		}

		static short n_GetHttpStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHttpStatus ();
		}
#pragma warning restore 0169

		IntPtr id_getHttpStatus;
		public unsafe short GetHttpStatus ()
		{
			if (id_getHttpStatus == IntPtr.Zero)
				id_getHttpStatus = JNIEnv.GetMethodID (class_ref, "getHttpStatus", "()S");
			return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_getHttpStatus);
		}

		static Delegate cb_getHttpStatusMessage;
#pragma warning disable 0169
		static Delegate GetGetHttpStatusMessageHandler ()
		{
			if (cb_getHttpStatusMessage == null)
				cb_getHttpStatusMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHttpStatusMessage);
			return cb_getHttpStatusMessage;
		}

		static IntPtr n_GetHttpStatusMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetHttpStatusMessage ());
		}
#pragma warning restore 0169

		IntPtr id_getHttpStatusMessage;
		public unsafe string GetHttpStatusMessage ()
		{
			if (id_getHttpStatusMessage == IntPtr.Zero)
				id_getHttpStatusMessage = JNIEnv.GetMethodID (class_ref, "getHttpStatusMessage", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHttpStatusMessage), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getContent;
#pragma warning disable 0169
		static Delegate GetGetContentHandler ()
		{
			if (cb_getContent == null)
				cb_getContent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContent);
			return cb_getContent;
		}

		static IntPtr n_GetContent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetContent ());
		}
#pragma warning restore 0169

		IntPtr id_getContent;
		public unsafe byte[] GetContent ()
		{
			if (id_getContent == IntPtr.Zero)
				id_getContent = JNIEnv.GetMethodID (class_ref, "getContent", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContent), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_getFieldValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFieldValue_Ljava_lang_String_Handler ()
		{
			if (cb_getFieldValue_Ljava_lang_String_ == null)
				cb_getFieldValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetFieldValue_Ljava_lang_String_);
			return cb_getFieldValue_Ljava_lang_String_;
		}

		static IntPtr n_GetFieldValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetFieldValue (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getFieldValue_Ljava_lang_String_;
		public unsafe string GetFieldValue (string p0)
		{
			if (id_getFieldValue_Ljava_lang_String_ == IntPtr.Zero)
				id_getFieldValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getFieldValue", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFieldValue_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_hasFieldValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHasFieldValue_Ljava_lang_String_Handler ()
		{
			if (cb_hasFieldValue_Ljava_lang_String_ == null)
				cb_hasFieldValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_HasFieldValue_Ljava_lang_String_);
			return cb_hasFieldValue_Ljava_lang_String_;
		}

		static bool n_HasFieldValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasFieldValue (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_hasFieldValue_Ljava_lang_String_;
		public unsafe bool HasFieldValue (string p0)
		{
			if (id_hasFieldValue_Ljava_lang_String_ == IntPtr.Zero)
				id_hasFieldValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "hasFieldValue", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasFieldValue_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_iterateHttpFields;
#pragma warning disable 0169
		static Delegate GetIterateHttpFieldsHandler ()
		{
			if (cb_iterateHttpFields == null)
				cb_iterateHttpFields = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IterateHttpFields);
			return cb_iterateHttpFields;
		}

		static IntPtr n_IterateHttpFields (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IterateHttpFields ());
		}
#pragma warning restore 0169

		IntPtr id_iterateHttpFields;
		public unsafe global::Java.Util.IIterator IterateHttpFields ()
		{
			if (id_iterateHttpFields == IntPtr.Zero)
				id_iterateHttpFields = JNIEnv.GetMethodID (class_ref, "iterateHttpFields", "()Ljava/util/Iterator;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_iterateHttpFields), JniHandleOwnership.TransferLocalRef);
		}

	}

}
