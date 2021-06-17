package crc64f204578e57a29fff;


public class C1ClearableEditText
	extends android.widget.EditText
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("C1.Android.Core.C1ClearableEditText, C1.Android.Core", C1ClearableEditText.class, __md_methods);
	}


	public C1ClearableEditText (android.content.Context p0)
	{
		super (p0);
		if (getClass () == C1ClearableEditText.class)
			mono.android.TypeManager.Activate ("C1.Android.Core.C1ClearableEditText, C1.Android.Core", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public C1ClearableEditText (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == C1ClearableEditText.class)
			mono.android.TypeManager.Activate ("C1.Android.Core.C1ClearableEditText, C1.Android.Core", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public C1ClearableEditText (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == C1ClearableEditText.class)
			mono.android.TypeManager.Activate ("C1.Android.Core.C1ClearableEditText, C1.Android.Core", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public C1ClearableEditText (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == C1ClearableEditText.class)
			mono.android.TypeManager.Activate ("C1.Android.Core.C1ClearableEditText, C1.Android.Core", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
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
