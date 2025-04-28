using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cItemCategory
{
	private int _id;

	private string _name;

	private int _active;

	private bool _used;

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

	public int Active
	{
		get
		{
			return _active;
		}
		set
		{
			_active = value;
		}
	}

	public bool Used
	{
		get
		{
			return _used;
		}
		set
		{
			_used = value;
		}
	}

	public override string ToString()
	{
		return _name;
	}

	public cItemCategory(int CatId)
	{
		if (CatId > 0)
		{
			_id = CatId;
			DataTable dataTable = new DataTable();
			string strSql = " SELECT *  FROM itemcategory  WHERE catId = " + Conversions.ToString(_id) + " ORDER BY catName ";
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				_name = Conversions.ToString(dataTable.Rows[0]["catName"]);
				_active = Conversions.ToInteger(dataTable.Rows[0]["catActive"]);
			}
			strSql = " SELECT catId  FROM produk  WHERE catId = " + Conversions.ToString(_id);
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				_used = true;
			}
			else
			{
				_used = false;
			}
		}
	}

	public static DataTable getItemCategory(int GroupId, bool Active)
	{
		string text = " SELECT catId, catName  FROM itemCategory  WHERE catId = catId ";
		if (Active)
		{
			text += " AND catActive = 1 ";
		}
		if (GroupId > 0)
		{
			text = text + " AND catId IN (SELECT catId FROM group_itemcategory WHERE groupId = " + Conversions.ToString(GroupId) + ")";
		}
		text += " ORDER BY catName ";
		return Module1.sqlTable(text, "read", Clone: false);
	}

	public void Save()
	{
		if (_id == 0)
		{
			string strSql = " INSERT INTO itemcategory  (catName,catActive) VALUES  ('" + _name + "'," + Conversions.ToString(_active) + ")";
			Module1.sqlNonQuery(strSql, "data");
		}
		else
		{
			string strSql = " UPDATE itemcategory  SET catName = '" + _name + "',  catActive = " + Conversions.ToString(_active) + " WHERE catId = " + Conversions.ToString(_id);
			Module1.sqlNonQuery(strSql, "data");
		}
	}

	public void Delete()
	{
		if (!_used)
		{
			string strSql = " DELETE FROM itemcategory  WHERE catId = " + Conversions.ToString(_id);
			Module1.sqlNonQuery(strSql, "data");
		}
	}
}
