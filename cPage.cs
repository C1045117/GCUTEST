using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cPage
{
	private int _id;

	private string _name;

	public int Id
	{
		get
		{
			return _id;
		}
		set
		{
			_id = value;
		}
	}

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

	public override string ToString()
	{
		return _name;
	}

	public cPage(int PageId)
	{
		if (PageId <= 0)
		{
			return;
		}
		_id = PageId;
		DataTable dataTable = new DataTable();
		string strSql = " SELECT *  FROM pages  WHERE pageId = " + Conversions.ToString(_id) + " ORDER BY pagePriority, pageLevel ";
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			if (Operators.ConditionalCompareObjectEqual(dataTable.Rows[0]["pageLevel"], 0, TextCompare: false))
			{
				_name = Conversions.ToString(dataTable.Rows[0]["pageName"]);
			}
			else if (Operators.ConditionalCompareObjectEqual(dataTable.Rows[0]["pageLevel"], 1, TextCompare: false))
			{
				_name = Conversions.ToString(Operators.ConcatenateObject("-- ", dataTable.Rows[0]["pageName"]));
			}
			else if (Operators.ConditionalCompareObjectEqual(dataTable.Rows[0]["pageLevel"], 2, TextCompare: false))
			{
				_name = Conversions.ToString(Operators.ConcatenateObject("---- ", dataTable.Rows[0]["pageName"]));
			}
		}
	}

	public static DataTable getParent()
	{
		string strSql = " SELECT pageId, pageName, pageIsParent  FROM pages  WHERE pageMenu <> ''  AND parentId = 0  AND pageAlways = 0  ORDER BY pagePriority, pageName ";
		return Module1.sqlTable(strSql, "data", Clone: false);
	}

	public static DataTable getChild(int ParentId)
	{
		string strSql = " SELECT pageId, pageName, pageIsParent  FROM pages  WHERE pageMenu <> ''  AND parentId = " + Conversions.ToString(ParentId) + " ORDER BY pagePriority, pageName ";
		return Module1.sqlTable(strSql, "data", Clone: false);
	}
}
