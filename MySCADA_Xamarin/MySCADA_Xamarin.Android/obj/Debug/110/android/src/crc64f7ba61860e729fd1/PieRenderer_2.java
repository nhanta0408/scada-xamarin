package crc64f7ba61860e729fd1;


public abstract class PieRenderer_2
	extends crc64f7ba61860e729fd1.ChartBaseRenderer_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("C1.Xamarin.Forms.Chart.Platform.Android.PieRenderer`2, C1.Xamarin.Forms.Chart.Platform.Android", PieRenderer_2.class, __md_methods);
	}


	public PieRenderer_2 (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == PieRenderer_2.class)
			mono.android.TypeManager.Activate ("C1.Xamarin.Forms.Chart.Platform.Android.PieRenderer`2, C1.Xamarin.Forms.Chart.Platform.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public PieRenderer_2 (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == PieRenderer_2.class)
			mono.android.TypeManager.Activate ("C1.Xamarin.Forms.Chart.Platform.Android.PieRenderer`2, C1.Xamarin.Forms.Chart.Platform.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public PieRenderer_2 (android.content.Context p0)
	{
		super (p0);
		if (getClass () == PieRenderer_2.class)
			mono.android.TypeManager.Activate ("C1.Xamarin.Forms.Chart.Platform.Android.PieRenderer`2, C1.Xamarin.Forms.Chart.Platform.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}

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
