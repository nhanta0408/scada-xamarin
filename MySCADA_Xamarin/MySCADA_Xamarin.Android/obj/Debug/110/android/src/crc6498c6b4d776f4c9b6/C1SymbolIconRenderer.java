package crc6498c6b4d776f4c9b6;


public class C1SymbolIconRenderer
	extends crc6498c6b4d776f4c9b6.C1IconRenderer_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("C1.Xamarin.Forms.Core.Platform.Android.C1SymbolIconRenderer, C1.Xamarin.Forms.Core.Platform.Android", C1SymbolIconRenderer.class, __md_methods);
	}


	public C1SymbolIconRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == C1SymbolIconRenderer.class)
			mono.android.TypeManager.Activate ("C1.Xamarin.Forms.Core.Platform.Android.C1SymbolIconRenderer, C1.Xamarin.Forms.Core.Platform.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public C1SymbolIconRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == C1SymbolIconRenderer.class)
			mono.android.TypeManager.Activate ("C1.Xamarin.Forms.Core.Platform.Android.C1SymbolIconRenderer, C1.Xamarin.Forms.Core.Platform.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public C1SymbolIconRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == C1SymbolIconRenderer.class)
			mono.android.TypeManager.Activate ("C1.Xamarin.Forms.Core.Platform.Android.C1SymbolIconRenderer, C1.Xamarin.Forms.Core.Platform.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
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
