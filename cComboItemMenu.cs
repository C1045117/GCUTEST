namespace GCUv2;

public class cComboItemMenu : cComboItem
{
	private string mFormName;

	public string FormName => mFormName;

	public cComboItemMenu(string pText, string pValue, string pForm)
		: base(pText, pValue)
	{
		mFormName = pForm;
	}
}
