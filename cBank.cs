using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cBank
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
	public cBank(int Id)
	{
		if (Id > 0)
		{
			_id = Id;
			DataTable dataTable = new DataTable();
			string strSql = " SELECT *  FROM bank  WHERE bankId = " + Conversions.ToString(_id);
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				_name = Conversions.ToString(dataTable.Rows[0]["bankName"]);
				_active = Conversions.ToInteger(dataTable.Rows[0]["bankStatus"]);
			}
			else
			{
				_id = 0;
				Information.Err().Raise(513, null, "Bank tidak ditemukan. Kemungkinan telah dihapus.");
			}
		}
	}

	public void save()
	{
		if (_id == 0)
		{
			string strSql = " INSERT INTO bank(bankName, bankStatus)  VALUES  ('" + _name + "'," + Conversions.ToString(_active) + ")";
			Module1.sqlNonQuery(strSql, "data");
		}
		else
		{
			string strSql = " UPDATE bank  SET bankName = '" + _name + "',  bankStatus = " + Conversions.ToString(_active) + "  WHERE bankId = " + Conversions.ToString(_id) + " ";
			Module1.sqlNonQuery(strSql, "data");
		}
	}

	public static DataTable Search(int Active)
	{
		string text = " SELECT * FROM bank  WHERE bankStatus = bankStatus ";
		switch (Active)
		{
		case 0:
			text += " AND bankStatus = 0 ";
			break;
		case 1:
			text += " AND bankStatus = 1 ";
			break;
		}
		text += " ORDER BY bankName ";
		return Module1.sqlTable(text, "read", Clone: false);
	}

	public static bool IsExist(int Id, string Name)
	{
		bool result = false;
		string text = " SELECT * FROM bank  WHERE bankName = '" + Name + "'";
		if (Id > 0)
		{
			text = text + " AND bankId <> " + Conversions.ToString(Id);
		}
		DataTable dataTable = Module1.sqlTable(text, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			result = true;
		}
		return result;
	}
}
