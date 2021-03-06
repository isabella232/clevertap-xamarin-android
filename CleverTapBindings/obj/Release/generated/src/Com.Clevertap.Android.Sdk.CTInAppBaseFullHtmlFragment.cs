using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInAppBaseFullHtmlFragment']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/CTInAppBaseFullHtmlFragment", DoNotGenerateAcw=true)]
	public abstract partial class CTInAppBaseFullHtmlFragment : global::Com.Clevertap.Android.Sdk.CTInAppBaseFullFragment {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/clevertap/android/sdk/CTInAppBaseFullHtmlFragment", typeof (CTInAppBaseFullHtmlFragment));
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

		protected CTInAppBaseFullHtmlFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInAppBaseFullHtmlFragment']/constructor[@name='CTInAppBaseFullHtmlFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CTInAppBaseFullHtmlFragment ()
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

	[global::Android.Runtime.Register ("com/clevertap/android/sdk/CTInAppBaseFullHtmlFragment", DoNotGenerateAcw=true)]
	internal partial class CTInAppBaseFullHtmlFragmentInvoker : CTInAppBaseFullHtmlFragment {

		public CTInAppBaseFullHtmlFragmentInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/clevertap/android/sdk/CTInAppBaseFullHtmlFragment", typeof (CTInAppBaseFullHtmlFragmentInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
