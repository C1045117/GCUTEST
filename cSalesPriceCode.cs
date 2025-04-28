using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cSalesPriceCode
{
	private int _id;

	private string _name;

	private cSalesPriceCodeItem[] _item;

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

	public cSalesPriceCodeItem[] Item
	{
		get
		{
			return _item;
		}
		set
		{
			_item = value;
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
	public cSalesPriceCode(int Id)
	{
		if (Id <= 0)
		{
			return;
		}
		_id = Id;
		DataTable dataTable = new DataTable();
		string strSql = " SELECT *  FROM harga  WHERE hargaId = " + Conversions.ToString(_id);
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			_name = Conversions.ToString(dataTable.Rows[0]["hargaKode"]);
			_active = Conversions.ToInteger(dataTable.Rows[0]["hargaStatus"]);
		}
		else
		{
			_id = 0;
			Information.Err().Raise(513, null, "Kode Harga tidak ditemukan. Kemungkinan telah dihapus.");
		}
		strSql = " SELECT a.prodId, prodName, phAmount as price  FROM (SELECT prodId, prodName  FROM produk WHERE prodAllowSell = 1 and prodStatus = 1) as a  LEFT OUTER JOIN ProdHarga b  ON a.prodId = b.prodId  AND b.hargaId = " + Conversions.ToString(_id) + " ORDER BY prodName ";
		int num = 0;
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		checked
		{
			_item = new cSalesPriceCodeItem[dataTable.Rows.Count - 1 + 1];
			foreach (DataRow row in dataTable.Rows)
			{
				_item[num] = new cSalesPriceCodeItem();
				_item[num].ItemId = Conversions.ToInteger(row["prodId"]);
				_item[num].ItemName = Conversions.ToString(row["prodName"]);
				_item[num].Price = Conversions.ToDouble((!Information.IsDBNull(RuntimeHelpers.GetObjectValue(row["price"]))) ? row["price"] : ((object)0));
				num++;
			}
		}
	}

	public void Save()
	{
		if (_id == 0)
		{
			string strSql = " INSERT INTO harga(hargaKode, hargaStatus)  VALUES  ('" + _name + "'," + Conversions.ToString(_active) + ")";
			Module1.sqlNonQuery(strSql, "data");
		}
		else
		{
			string strSql = " UPDATE harga  SET hargaKode = '" + _name + "',  hargaStatus = " + Conversions.ToString(_active) + "  WHERE hargaId = " + Conversions.ToString(_id) + " ";
			Module1.sqlNonQuery(strSql, "data");
			strSql = " DELETE FROM ProdHarga  WHERE hargaId = " + Conversions.ToString(_id);
			Module1.sqlNonQuery(strSql, "data");
		}
		cSalesPriceCodeItem[] item = _item;
		foreach (cSalesPriceCodeItem cSalesPriceCodeItem2 in item)
		{
			string strSql = " INSERT INTO ProdHarga  (hargaId, prodId, PhAmount) VALUES  ( " + Conversions.ToString(_id) + "," + Conversions.ToString(cSalesPriceCodeItem2.ItemId) + "," + Module1.unformatNumber(Conversions.ToString(cSalesPriceCodeItem2.Price)) + ")";
			Module1.sqlNonQuery(strSql, "data");
		}
	}

	public static DataTable Search(int Active)
	{
		string text = " SELECT * FROM harga  WHERE hargaStatus = hargaStatus ";
		switch (Active)
		{
		case 0:
			text += " AND hargaStatus = 0 ";
			break;
		case 1:
			text += " AND hargaStatus = 1 ";
			break;
		}
		text += " ORDER BY hargaKode ";
		return Module1.sqlTable(text, "read", Clone: false);
	}

	public static bool IsExist(int Id, string Name)
	{
		bool result = false;
		string text = " SELECT * FROM harga  WHERE hargaKode = '" + Name + "'";
		if (Id > 0)
		{
			text = text + " AND hargaId <> " + Conversions.ToString(Id);
		}
		DataTable dataTable = Module1.sqlTable(text, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			result = true;
		}
		return result;
	}

	public static double GetPrice(int ItemId, double CustomerId)
	{
		double result = 0.0;
		string strSql = " SELECT * FROM ProdHarga  WHERE ProdId = " + Conversions.ToString(ItemId) + " AND HargaId = (SELECT hargaId FROM customer  WHERE custId = " + Conversions.ToString(CustomerId) + ") ";
		DataTable dataTable = Module1.sqlTable(strSql, "read", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			result = Conversions.ToDouble(dataTable.Rows[0]["phAmount"]);
		}
		return result;
	}
}
