namespace GCUv2;

public class cItemGroup
{
	private int _componentId;

	private string _componentName;

	private double _qty;

	public int ComponentId
	{
		get
		{
			return _componentId;
		}
		set
		{
			_componentId = value;
		}
	}

	public string ComponentName
	{
		get
		{
			return _componentName;
		}
		set
		{
			_componentName = value;
		}
	}

	public double Qty
	{
		get
		{
			return _qty;
		}
		set
		{
			_qty = value;
		}
	}
}
