package crc64f7ba61860e729fd1;


public class TreeMapRenderer
	extends crc64f7ba61860e729fd1.ChartBaseRenderer_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("C1.Xamarin.Forms.Chart.Platform.Android.TreeMapRenderer, C1.Xamarin.Forms.Chart.Platform.Android", TreeMapRenderer.class, __md_methods);
	}


	public TreeMapRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == TreeMapRenderer.class)
			mono.android.TypeManager.Activate ("C1.Xamarin.Forms.Chart.Platform.Android.TreeMapRenderer, C1.Xamarin.Forms.Chart.Platform.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public TreeMapRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == TreeMapRenderer.class)
			mono.android.TypeManager.Activate ("C1.Xamarin.Forms.Chart.Platform.Android.TreeMapRenderer, C1.Xamarin.Forms.Chart.Platform.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public TreeMapRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == TreeMapRenderer.class)
			mono.android.TypeManager.Activate ("C1.Xamarin.Forms.Chart.Platform.Android.TreeMapRenderer, C1.Xamarin.Forms.Chart.Platform.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
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
