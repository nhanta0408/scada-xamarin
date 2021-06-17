package crc64040167e161b8a64b;


public class DelayCallback
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.os.Handler.Callback
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_handleMessage:(Landroid/os/Message;)Z:GetHandleMessage_Landroid_os_Message_Handler:Android.OS.Handler/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("DelayCallback, C1.Android.Core", DelayCallback.class, __md_methods);
	}


	public DelayCallback ()
	{
		super ();
		if (getClass () == DelayCallback.class)
			mono.android.TypeManager.Activate ("DelayCallback, C1.Android.Core", "", this, new java.lang.Object[] {  });
	}


	public boolean handleMessage (android.os.Message p0)
	{
		return n_handleMessage (p0);
	}

	private native boolean n_handleMessage (android.os.Message p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
