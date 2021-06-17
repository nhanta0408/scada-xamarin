package crc6498c6b4d776f4c9b6;


public abstract class C1ViewRenderer_2
	extends crc643f46942d9dd1fff9.ViewRenderer_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMeasure:(II)V:GetOnMeasure_IIHandler\n" +
			"";
		mono.android.Runtime.register ("C1.Xamarin.Forms.Core.Platform.Android.C1ViewRenderer`2, C1.Xamarin.Forms.Core.Platform.Android", C1ViewRenderer_2.class, __md_methods);
	}


	public C1ViewRenderer_2 (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == C1ViewRenderer_2.class)
			mono.android.TypeManager.Activate ("C1.Xamarin.Forms.Core.Platform.Android.C1ViewRenderer`2, C1.Xamarin.Forms.Core.Platform.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public C1ViewRenderer_2 (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == C1ViewRenderer_2.class)
			mono.android.TypeManager.Activate ("C1.Xamarin.Forms.Core.Platform.Android.C1ViewRenderer`2, C1.Xamarin.Forms.Core.Platform.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public C1ViewRenderer_2 (android.content.Context p0)
	{
		super (p0);
		if (getClass () == C1ViewRenderer_2.class)
			mono.android.TypeManager.Activate ("C1.Xamarin.Forms.Core.Platform.Android.C1ViewRenderer`2, C1.Xamarin.Forms.Core.Platform.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public void onMeasure (int p0, int p1)
	{
		n_onMeasure (p0, p1);
	}

	private native void n_onMeasure (int p0, int p1);

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
