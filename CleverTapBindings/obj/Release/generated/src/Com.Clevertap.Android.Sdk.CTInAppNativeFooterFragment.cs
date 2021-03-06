using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInAppNativeFooterFragment']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/CTInAppNativeFooterFragment", DoNotGenerateAcw=true)]
	public partial class CTInAppNativeFooterFragment : global::Com.Clevertap.Android.Sdk.CTInAppBasePartialNativeFragment {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/clevertap/android/sdk/CTInAppNativeFooterFragment", typeof (CTInAppNativeFooterFragment));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected CTInAppNativeFooterFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInAppNativeFooterFragment']/constructor[@name='CTInAppNativeFooterFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CTInAppNativeFooterFragment ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

	}
}
