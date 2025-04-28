namespace GCUv2;

public class cComboItem
{
	private string mText;

	private string mValue;

	public string Text => mText;

	public string Value => mValue;

	public cComboItem(string pText, string pValue)
	{
		mText = pText;
		mValue = pValue;
	}

	public override string ToString()
	{
		return mText;
	}
}
