using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cMinimumStock
{
	private int _branchId;

	private cMinimumStockItem[] _item;

	public int BranchId
	{
		get
		{
			return _branchId;
		}
		set
		{
			_branchId = value;
		}
	}

	public cMinimumStockItem[] Item
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

	public void Save()
	{
		string strSql = " DELETE FROM prodBranches  WHERE branchId = " + Conversions.ToString(_branchId);
		Module1.sqlNonQuery(strSql, "data");
		cMinimumStockItem[] item = _item;
		foreach (cMinimumStockItem cMinimumStockItem2 in item)
		{
			strSql = " INSERT INTO prodbranches(branchId, prodId, prodMin) VALUES (" + Conversions.ToString(_branchId) + "," + Conversions.ToString(cMinimumStockItem2.ItemId) + "," + Module1.unformatNumber(Conversions.ToString(cMinimumStockItem2.Qty)) + ")";
			Module1.sqlNonQuery(strSql, "data");
		}
	}

	public static DataTable Search(int BranchId)
	{
		string text = " SELECT a.prodName, a.prodId, b.prodMin  FROM (SELECT * FROM produk  WHERE typeId = 1 AND prodId IN (SELECT prodId FROM produkstorages  WHERE psAvailable = 1 AND storeId IN (SELECT storeId FROM storages WHERE branchId = " + Conversions.ToString(BranchId) + "))) a  LEFT OUTER JOIN prodBranches b  ON (a.prodId = b.prodId AND branchId = " + Conversions.ToString(BranchId) + ")";
		text += " ORDER BY prodName ";
		return Module1.sqlTable(text, "data", Clone: false);
	}
}
