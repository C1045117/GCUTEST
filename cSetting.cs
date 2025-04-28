using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cSetting
{
	private string _name;

	private string _value;

	public string Name
	{
		get
		{
			return _name;
		}
		set
		{
			_name = value;
		}
	}

	public string Value
	{
		get
		{
			return _value;
		}
		set
		{
			_value = value;
		}
	}

	public static int GetMaximumTOP()
	{
		string strSql = " SELECT MAX(custTop) AS maximum  FROM customer ";
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		return Conversions.ToInteger(dataTable.Rows[0]["maximum"]);
	}

	public static int GetMaximumCredit()
	{
		string strSql = " SELECT MAX(custPiutang) AS maximum  FROM customer ";
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		return Conversions.ToInteger(dataTable.Rows[0]["maximum"]);
	}

	public cSetting(string Name)
	{
		if (Operators.CompareString(Name, "", TextCompare: false) != 0)
		{
			string strSql = " SELECT * FROM settings  WHERE setName = '" + Name + "'";
			DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				_name = Conversions.ToString(dataTable.Rows[0]["setName"]);
				_value = Conversions.ToString(dataTable.Rows[0]["setVal"]);
			}
		}
	}

	public void Save()
	{
		string strSql = " UPDATE Settings  SET setVal = '" + _value + "'  WHERE setName = '" + _name + "'";
		Module1.sqlNonQuery(strSql, "data");
	}
}
