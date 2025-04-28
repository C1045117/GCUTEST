using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cItemPrintDetail
{
	private string _generalType;

	private string _longName;

	private string _packaging;

	private string _smallUnit;

	private double _smallQtyMultiplier;

	private string _largeUnit;

	public string GeneralType
	{
		get
		{
			return _generalType;
		}
		set
		{
			_generalType = value;
		}
	}

	public string LongName
	{
		get
		{
			return _longName;
		}
		set
		{
			_longName = value;
		}
	}

	public string Packaging
	{
		get
		{
			return _packaging;
		}
		set
		{
			_packaging = value;
		}
	}

	public string SmallUnit
	{
		get
		{
			return _smallUnit;
		}
		set
		{
			_smallUnit = value;
		}
	}

	public double SmallQtyMultiplier
	{
		get
		{
			return _smallQtyMultiplier;
		}
		set
		{
			_smallQtyMultiplier = value;
		}
	}

	public string LargeUnit
	{
		get
		{
			return _largeUnit;
		}
		set
		{
			_largeUnit = value;
		}
	}

	public cItemPrintDetail(int ItemId)
	{
		string strSql = " SELECT IF(a.prodTea=1,'Teh GOPEK','') as generalType, a.prodLongName, a.prodBox,  smallUnit.unitName AS smallUnitName, smallUnit.unitQty AS smallUnitQty, largeUnit.unitName AS largeUnitName FROM produk a, (SELECT * FROM itemUnit WHERE unitQty > 0 AND itemId = " + Conversions.ToString(ItemId) + " ORDER BY unitQty ASC LIMIT 1) smallUnit,  (SELECT * FROM itemUnit WHERE unitQty = 1 AND itemId = " + Conversions.ToString(ItemId) + " ORDER BY unitQty DESC LIMIT 1) largeUnit  WHERE a.prodId = " + Conversions.ToString(ItemId);
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			_generalType = Conversions.ToString(dataTable.Rows[0]["generalType"]);
			_longName = Conversions.ToString(dataTable.Rows[0]["prodLongName"]);
			_packaging = Conversions.ToString(dataTable.Rows[0]["prodBox"]);
			_smallUnit = Conversions.ToString(dataTable.Rows[0]["smallUnitName"]);
			_smallQtyMultiplier = Conversions.ToDouble(dataTable.Rows[0]["smallUnitQty"]);
			_largeUnit = Conversions.ToString(dataTable.Rows[0]["largeUnitName"]);
		}
	}
}
