package crc64f7ba61860e729fd1;


public class SunburstRenderer
	extends crc64f7ba61860e729fd1.FlexPieRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("C1.Xamarin.Forms.Chart.Platform.Android.SunburstRenderer, C1.Xamarin.Forms.Chart.Platform.Android", SunburstRenderer.class, __md_methods);
	}


	public SunburstRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == SunburstRenderer.class)
			mono.android.TypeManager.Activate ("C1.Xamarin.Forms.Chart.Platform.Android.SunburstRenderer, C1.Xamarin.Forms.Chart.Platform.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public SunburstRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == SunburstRenderer.class)
			mono.android.TypeManager.Activate ("C1.Xamarin.Forms.Chart.Platform.Android.SunburstRenderer, C1.Xamarin.Forms.Chart.Platform.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public SunburstRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == SunburstRenderer.class)
			mono.android.TypeManager.Activate ("C1.Xamarin.Forms.Chart.Platform.Android.SunburstRenderer, C1.Xamarin.Forms.Chart.Platform.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
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
