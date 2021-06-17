package crc64100cc7d154c046fc;


public class C1TreeMap
	extends crc64100cc7d154c046fc.ChartBase
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_invalidate:()V:GetInvalidateHandler\n" +
			"";
		mono.android.Runtime.register ("C1.Android.Chart.C1TreeMap, C1.Android.Chart", C1TreeMap.class, __md_methods);
	}


	public C1TreeMap (android.content.Context p0)
	{
		super (p0);
		if (getClass () == C1TreeMap.class)
			mono.android.TypeManager.Activate ("C1.Android.Chart.C1TreeMap, C1.Android.Chart", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public C1TreeMap (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == C1TreeMap.class)
			mono.android.TypeManager.Activate ("C1.Android.Chart.C1TreeMap, C1.Android.Chart", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public C1TreeMap (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == C1TreeMap.class)
			mono.android.TypeManager.Activate ("C1.Android.Chart.C1TreeMap, C1.Android.Chart", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public C1TreeMap (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == C1TreeMap.class)
			mono.android.TypeManager.Activate ("C1.Android.Chart.C1TreeMap, C1.Android.Chart", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}


	public void invalidate ()
	{
		n_invalidate ();
	}

	private native void n_invalidate ();

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
