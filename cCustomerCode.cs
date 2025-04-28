using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cCustomerCode
{
	private int _id;

	private string _name;

	private int _active;

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
			_name = Module1.cleanString(value);
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

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public cCustomerCode(int Id)
	{
		if (Id > 0)
		{
			_id = Id;
			DataTable dataTable = new DataTable();
			string strSql = " SELECT *  FROM custKode  WHERE ckId = " + Conversions.ToString(_id);
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				_name = Conversions.ToString(dataTable.Rows[0]["ckName"]);
				_active = Conversions.ToInteger(dataTable.Rows[0]["ckStatus"]);
			}
			else
			{
				_id = 0;
				Information.Err().Raise(513, null, "Kode customer tidak ditemukan. Kemungkinan telah dihapus.");
			}
		}
	}

	public void save()
	{
		if (_id == 0)
		{
			string strSql = " INSERT INTO custKode(ckName, ckStatus)  VALUES  ('" + _name + "'," + Conversions.ToString(_active) + ")";
			Module1.sqlNonQuery(strSql, "data");
		}
		else
		{
			string strSql = " UPDATE custKode  SET ckName = '" + _name + "',  ckStatus = " + Conversions.ToString(_active) + "  WHERE ckId = " + Conversions.ToString(_id) + " ";
			Module1.sqlNonQuery(strSql, "data");
		}
	}

	public static DataTable Search(int Active)
	{
		string text = " SELECT *  FROM custKode  WHERE ckStatus = ckStatus ";
		switch (Active)
		{
		case 0:
			text += " AND ckStatus = 0 ";
			break;
		case 1:
			text += " AND ckStatus = 1 ";
			break;
		}
		text += " ORDER BY ckName ";
		return Module1.sqlTable(text, "read", Clone: false);
	}

	public static bool IsExist(int Id, string Name)
	{
		bool result = false;
		string text = " SELECT * FROM custKode  WHERE ckName = '" + Name + "'";
		if (Id > 0)
		{
			text = text + " AND ckId <> " + Conversions.ToString(Id);
		}
		DataTable dataTable = Module1.sqlTable(text, "read", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			result = true;
		}
		return result;
	}
}
