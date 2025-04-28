using System;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cStock
{
	public static DataTable StockDetail(int ItemId, DateTime BalanceDate, DateTime dateFirst, DateTime dateLast, string StorageType, int StorageId, int GroupId, int BranchId, bool blnNewCode)
	{
		Module1.SaveDebug(Module1.pubLogin + " before beginningstock");
		double stock = getStock(ItemId, BalanceDate, dateFirst, StorageType, StorageId, GroupId, BranchId, blnNewCode);
		Module1.SaveDebug(Module1.pubLogin + " after beginningstock");
		string text = " SELECT CURDATE() AS stockDate,'Stok Awal' AS description, " + Module1.unformatNumber(Conversions.ToString(stock)) + " AS stockIn,  0 AS stockOut,1 AS orderby1, 1 as orderby2 ";
		text += " UNION ALL ";
		text = text + " select penjDate as stockDate, 'Penjualan' as description,0 as stockIn,  sum(ppAmount)-sum(ppMissing) as stockOut, 2 AS orderby1, 2 as orderby2  from penjualan a, penjProd b  where a.penjId = b.penjId  and b.prodId = " + Conversions.ToString(ItemId) + " AND penjBsType = 0  AND b.doId IS NULL ";
		if (StorageId > 0)
		{
			text = text + " AND a.storeId = " + Conversions.ToString(StorageId) + " ";
		}
		else
		{
			text = text + " AND a.storeId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1)  AND a.storeId IN (SELECT storeId FROM storages WHERE branchId = " + Conversions.ToString(BranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND a.storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND a.storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		text = text + " and a.penjDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'  and a.penjDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "' ";
		text += " group by a.penjDate ";
		text += " UNION ALL ";
		text = text + " select penjDate as stockDate, 'Retur Penjualan(BS)' as description, sum(ppAmount)-sum(ppMissing) as stockIn,  0 as stockOut, 2 AS orderby1, 1 as orderby2  from penjualan a, penjProd b  where a.penjId = b.penjId  and b.prodId = " + Conversions.ToString(ItemId) + " AND penjBsType > 0 ";
		if (StorageId > 0)
		{
			text = text + " AND a.storeId = " + Conversions.ToString(StorageId) + " ";
		}
		else
		{
			text = text + " AND a.storeId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1)  AND a.storeId IN (SELECT storeId FROM storages WHERE branchId = " + Conversions.ToString(BranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND a.storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND a.storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		text = text + " and a.penjDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'  and a.penjDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "' ";
		text += " group by a.penjDate ";
		text += " UNION ALL ";
		text = text + " SELECT usageDate as stockDate, 'Penggunaan' as description, 0 as stockIn,  SUM(useQty) + SUM(wasteQty) as stockOut, 2 AS orderby1, 2 as orderby2  FROM usages a, usage_item b  WHERE a.usageId = b.usageId  AND b.itemId = " + Conversions.ToString(ItemId);
		if (StorageId > 0)
		{
			text = text + " AND storeId = " + Conversions.ToString(StorageId);
		}
		else
		{
			text = text + " AND storeId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1)  AND storeId IN (SELECT storeId FROM storages WHERE branchId = " + Conversions.ToString(BranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		text = text + " AND usageDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'  AND usageDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "' ";
		text += " GROUP BY usageDate ";
		text += " UNION ALL ";
		text = text + " SELECT doDate as stockDate, 'Pengiriman Pesanan' as description, 0 as stockIn,  SUM(doQty) as stockOut, 2 AS orderby1, 2 as orderby2  FROM deliveryorder a, deliveryorder_item b  WHERE a.doId = b.doId  AND b.itemId = " + Conversions.ToString(ItemId);
		if (StorageId > 0)
		{
			text = text + " AND storeId = " + Conversions.ToString(StorageId);
		}
		else
		{
			text = text + " AND storeId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1)  AND storeId IN (SELECT storeId FROM storages WHERE branchId = " + Conversions.ToString(BranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		text = text + " AND doDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'  AND doDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "' ";
		text += " GROUP BY doDate ";
		text += " UNION ALL ";
		text = text + " SELECT riDate as stockDate, 'Penerimaan Barang' as description, SUM(riQty) as stockIn,  0 as stockOut, 2 AS orderby1, 1 as orderby2  FROM receiveditem a, receiveditem_item b  WHERE a.riId = b.riId  AND b.itemId = " + Conversions.ToString(ItemId);
		if (StorageId > 0)
		{
			text = text + " AND storeId = " + Conversions.ToString(StorageId);
		}
		else
		{
			text = text + " AND storeId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1)  AND storeId IN (SELECT storeId FROM storages WHERE branchId = " + Conversions.ToString(BranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		text = text + " AND riDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'  AND riDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "' ";
		text += " GROUP BY riDate ";
		text += " UNION ALL ";
		text = text + " SELECT invDate as stockDate, CONCAT('Pembelian: ',supName) as description, SUM(iiMainQty) AS stockIn,  0 as stockOut, 2 AS orderby1, 1 as orderby2  FROM purchaseinvoices a, purchaseinvoices_items b, suppliers c  WHERE a.invId = b.invId  AND a.supId = c.supId  AND b.itemId = " + Conversions.ToString(ItemId) + " AND invIsReturn = 0  AND b.riId IS NULL ";
		if (StorageId > 0)
		{
			text = text + " AND b.storeId = " + Conversions.ToString(StorageId) + " ";
		}
		else
		{
			text = text + " AND b.storeId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1)  AND b.storeId IN (SELECT storeId FROM storages WHERE branchId = " + Conversions.ToString(BranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND b.storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND b.storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		text = text + " AND invDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'  AND invDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "' ";
		text += " GROUP BY a.supId,invDate ";
		text += " UNION ALL ";
		text = text + " SELECT invDate as stockDate, CONCAT('Retur Pembelian: ', supName) as description, 0 as stockIn,  SUM(iiMainQty) AS stockOut, 2 AS orderby1, 2 as orderby2  FROM purchaseinvoices a, purchaseinvoices_items b, suppliers c  WHERE a.invId = b.invId  AND a.supId = c.supId  AND invIsReturn = 1  AND b.itemId = " + Conversions.ToString(ItemId);
		if (StorageId > 0)
		{
			text = text + " AND b.storeId = " + Conversions.ToString(StorageId);
		}
		else
		{
			text = text + " AND b.storeId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1)  AND b.storeId IN (SELECT storeId FROM storages WHERE branchId = " + Conversions.ToString(BranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND b.storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND b.storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		text = text + " AND invDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'  AND invDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "' ";
		text += " group by a.supId, invDate ";
		text += " UNION ALL ";
		text = text + " SELECT proDate as stockDate, 'Produksi' as description, SUM(proMainQty) AS stockIn,  0 as stockOut, 2 AS orderby1, 1 as orderby2  FROM processes  WHERE itemId = " + Conversions.ToString(ItemId);
		if (StorageId != 0)
		{
			text = text + " AND storeId = " + Conversions.ToString(StorageId) + " ";
		}
		else
		{
			text = text + " AND storeId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1)  AND storeId IN (SELECT storeId FROM storages WHERE branchId = " + Conversions.ToString(BranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		text = text + " AND proDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'  AND proDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "' ";
		text += " group by proDate ";
		text += " UNION ALL ";
		text = text + " SELECT adjDate as stockDate, CONCAT('Penyesuaian(+) ',adjTypeName) as description, SUM(adjMainQty) AS stockIn,  0 as stockOut, 2 AS orderby1, 1 as orderby2  FROM adjustments a, adjustment_types b  WHERE a.adjCategory = b.adjTypeId  AND adjType = 0  AND itemId = " + Conversions.ToString(ItemId);
		if (StorageId > 0)
		{
			text = text + " AND storeId = " + Conversions.ToString(StorageId) + " ";
		}
		else
		{
			text = text + " AND storeId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1)  AND storeId IN (SELECT storeId FROM storages WHERE branchId = " + Conversions.ToString(BranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		text = text + " AND adjDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'  AND adjDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "' ";
		text += " group by adjDate ";
		text += " UNION ALL ";
		text = text + " SELECT adjDate as stockDate, CONCAT('Penyesuaian(-) ',adjTypeName) as description, 0 AS stockIn,  SUM(adjMainQty) as stockOut, 2 AS orderby1, 2 as orderby2  FROM adjustments a, adjustment_types b  WHERE a.adjCategory = b.adjTypeId  AND adjType = 1  AND itemId = " + Conversions.ToString(ItemId);
		if (StorageId > 0)
		{
			text = text + " AND storeId = " + Conversions.ToString(StorageId) + " ";
		}
		else
		{
			text = text + " AND storeId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1)  AND storeId IN (SELECT storeId FROM storages WHERE branchId = " + Conversions.ToString(BranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		text = text + " AND adjDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'  AND adjDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "' ";
		text += " group by adjDate ";
		text += " UNION ALL ";
		text = text + " SELECT transferDate as stockDate, 'Transfer masuk' as description, SUM(transferQty) as stockIn,  0 as stockOut, 2 AS orderby1, 1 as orderby2  FROM transfer a, transfer_item b  WHERE a.transferId = b.transferId  AND itemId = " + Conversions.ToString(ItemId);
		if (StorageId > 0)
		{
			text = text + " AND storageToId = " + Conversions.ToString(StorageId);
		}
		else
		{
			text = text + " AND storageToId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1)  AND storageToId IN (SELECT storeId FROM storages WHERE branchId = " + Conversions.ToString(BranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storageToId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storageToId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		text = text + " AND transferDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'  AND transferDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "' ";
		text += " group by transferDate ";
		text += " UNION ALL ";
		text = text + " SELECT transferDate as stockDate, 'Transfer keluar' as description, 0 as stockIn,  SUM(transferQty) as stockOut, 2 AS orderby1, 2 as orderby2  FROM transfer a, transfer_item b  WHERE a.transferId = b.transferId  AND itemId = " + Conversions.ToString(ItemId);
		if (StorageId > 0)
		{
			text = text + " AND storageFromId = " + Conversions.ToString(StorageId);
		}
		else
		{
			text = text + " AND storageFromId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1)  AND storageFromId IN (SELECT storeId FROM storages WHERE branchId = " + Conversions.ToString(BranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storageFromId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storageFromId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		text = text + " AND transferDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'  AND transferDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "' ";
		text += " group by transferDate ";
		text += " UNION ALL ";
		text = text + " SELECT comDate as stockDate, CONCAT('Komponen: ',itemName) as description, 0 as stockIn,  SUM(comMainQty) as stockOut, 2 AS orderby1, 2 as orderby2  FROM processes a, processcomponents b, items c  WHERE a.proId = b.proId  AND a.itemId = c.itemId  AND b.itemId = " + Conversions.ToString(ItemId);
		if (StorageId > 0)
		{
			text = text + " AND b.storeId = " + Conversions.ToString(StorageId) + " ";
		}
		else
		{
			text = text + " AND b.storeId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1)  AND b.storeId IN (SELECT storeId FROM storages WHERE branchId = " + Conversions.ToString(BranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND b.storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND b.storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		text = text + " AND comDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'  AND comDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "' ";
		text += " group by comDate ";
		text += " ORDER BY orderby1, stockDate, orderby2 ";
		Module1.SaveDebug(Module1.pubLogin + " before StockDetail");
		Module1.SaveDebug(text);
		DataTable result = Module1.sqlTable(text, "data", Clone: false);
		Module1.SaveDebug(Module1.pubLogin + " after StockDetail");
		return result;
	}

	public static double getStockNew(int intItemId, DateTime FirstBalanceDate, DateTime StockDate, string StorageType, int intStoreId, int intGroupId, int intBranchId)
	{
		double num = 0.0;
		string text = " SELECT SUM(stockTotal) AS stockTotal  FROM dailystock  WHERE itemId = " + Conversions.ToString(intItemId) + " AND stockDate < '" + Strings.Format(StockDate, "yyyy-MM-dd") + "' AND stockDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "'";
		if (intStoreId > 0)
		{
			text = text + " AND storeId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = text + " AND storeId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1) AND storeId IN  (SELECT storeId FROM storages   WHERE branchId = " + Conversions.ToString(intBranchId) + ") AND storeId IN  (SELECT storeId FROM produkstorages   WHERE prodId = " + Conversions.ToString(intItemId) + "  AND psAvailable = 1) ";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		DataTable dataTable = Module1.sqlTable(text, "read", Clone: true);
		double value = default(double);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["stockTotal"])))
		{
			value = Conversions.ToDouble(dataTable.Rows[0]["stockTotal"]);
		}
		text = " SELECT SUM(psQty) AS psQty  FROM produkstorages  WHERE prodId = " + Conversions.ToString(intItemId);
		if (intStoreId > 0)
		{
			text = text + " AND storeId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = text + " AND storeId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)  AND storeId IN   (SELECT storeId FROM storages    WHERE branchId = " + Conversions.ToString(intBranchId) + ") AND storeId IN  (SELECT storeId FROM produkstorages   WHERE prodId = " + Conversions.ToString(intItemId) + "  AND psAvailable = 1) ";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		dataTable = Module1.sqlTable(text, "read", Clone: true);
		double value2 = default(double);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["psQty"])))
		{
			value2 = Conversions.ToDouble(dataTable.Rows[0]["psQty"]);
		}
		num = Convert.ToDouble(decimal.Add(new decimal(value), new decimal(value2)));
		return Math.Round(num, 3);
	}

	public static double getStock(int intItemId, DateTime FirstBalanceDate, DateTime StockDate, string StorageType, int intStoreId, int intGroupId, int intBranchId, bool blnNewGetStockCode)
	{
		if (blnNewGetStockCode)
		{
			return getStockNew(intItemId, FirstBalanceDate, StockDate, StorageType, intStoreId, intGroupId, intBranchId);
		}
		double num = 0.0;
		string text = " SELECT SUM(ppAmount)-SUM(ppMissing) as ppAmount  FROM penjProd  WHERE prodId = " + Conversions.ToString(intItemId) + " AND penjId IN  (SELECT penjId FROM penjualan   WHERE penjDate < '" + Strings.Format(StockDate, "yyyy-MM-dd") + "'  AND penjDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "'  AND penjBsType = 0  AND doId IS NULL ";
		if (intStoreId > 0)
		{
			text = text + " AND storeId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = text + " AND storeId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)  AND storeId IN   (SELECT storeId FROM storages    WHERE branchId = " + Conversions.ToString(intBranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		text += ")";
		DataTable dataTable = Module1.sqlTable(text, "read", Clone: true);
		double value = default(double);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["ppAmount"])))
		{
			value = Conversions.ToDouble(dataTable.Rows[0]["ppAmount"]);
		}
		text = " SELECT SUM(ppAmount)-SUM(ppMissing) as ppAmount  FROM penjProd  WHERE prodId =  (SELECT prodId FROM produk   WHERE prodName = (SELECT itemName FROM items WHERE itemId = " + Conversions.ToString(intItemId) + ")) AND penjId IN  (SELECT penjId FROM penjualan   WHERE penjDate < '" + Strings.Format(StockDate, "yyyy-MM-dd") + "'  AND penjDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "'  AND penjBsType > 0 ";
		if (intStoreId > 0)
		{
			text = text + " AND storeId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = text + " AND storeId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)  AND storeId IN   (SELECT storeId FROM storages    WHERE branchId = " + Conversions.ToString(intBranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		text += ")";
		dataTable = Module1.sqlTable(text, "read", Clone: true);
		double value2 = default(double);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["ppAmount"])))
		{
			value2 = Conversions.ToDouble(dataTable.Rows[0]["ppAmount"]);
		}
		text = " SELECT SUM(useQty)+SUM(wasteQty) as usageQty  FROM usage_item  WHERE itemId = " + Conversions.ToString(intItemId) + " AND usageId IN  (SELECT usageId FROM usages   WHERE usageDate < '" + Strings.Format(StockDate, "yyyy-MM-dd") + "'  AND usageDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "'";
		if (intStoreId > 0)
		{
			text = text + " AND storeId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = text + " AND storeId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)  AND storeId IN   (SELECT storeId FROM storages    WHERE branchId = " + Conversions.ToString(intBranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		text += ")";
		dataTable = Module1.sqlTable(text, "read", Clone: true);
		double value3 = default(double);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["usageQty"])))
		{
			value3 = Conversions.ToDouble(dataTable.Rows[0]["usageQty"]);
		}
		text = " SELECT SUM(doQty) as doQty  FROM deliveryorder_item  WHERE itemId = " + Conversions.ToString(intItemId) + " AND doId IN  (SELECT doId FROM deliveryorder   WHERE doDate < '" + Strings.Format(StockDate, "yyyy-MM-dd") + "'  AND doDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "'";
		if (intStoreId > 0)
		{
			text = text + " AND storeId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = text + " AND storeId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)  AND storeId IN   (SELECT storeId FROM storages    WHERE branchId = " + Conversions.ToString(intBranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		text += ")";
		dataTable = Module1.sqlTable(text, "read", Clone: true);
		double value4 = default(double);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["doQty"])))
		{
			value4 = Conversions.ToDouble(dataTable.Rows[0]["doQty"]);
		}
		text = " SELECT SUM(riQty) as riQty  FROM receiveditem_item  WHERE itemId = " + Conversions.ToString(intItemId) + " AND riId IN  (SELECT riId FROM receiveditem   WHERE riDate < '" + Strings.Format(StockDate, "yyyy-MM-dd") + "'  AND riDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "'";
		if (intStoreId > 0)
		{
			text = text + " AND storeId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = text + " AND storeId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)  AND storeId IN   (SELECT storeId FROM storages    WHERE branchId = " + Conversions.ToString(intBranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		text += ")";
		dataTable = Module1.sqlTable(text, "read", Clone: true);
		double value5 = default(double);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["riQty"])))
		{
			value5 = Conversions.ToDouble(dataTable.Rows[0]["riQty"]);
		}
		text = " SELECT SUM(iiMainQty) as iiQty  FROM purchaseinvoices a, purchaseinvoices_items b  WHERE a.invId = b.invId  AND b.itemId = " + Conversions.ToString(intItemId) + " AND a.invDate < '" + Strings.Format(StockDate, "yyyy-MM-dd") + "' AND a.invDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "' AND invIsReturn = 0  AND b.riId IS NULL ";
		if (intStoreId > 0)
		{
			text = text + " AND storeId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = text + " AND storeId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)  AND storeId IN   (SELECT storeId FROM storages    WHERE branchId = " + Conversions.ToString(intBranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		dataTable = Module1.sqlTable(text, "read", Clone: true);
		double value6 = default(double);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["iiQty"])))
		{
			value6 = Conversions.ToDouble(dataTable.Rows[0]["iiQty"]);
		}
		text = " SELECT SUM(iiMainQty) as iiQty  FROM purchaseinvoices a, purchaseinvoices_items b  WHERE a.invId = b.invId  AND b.itemId = " + Conversions.ToString(intItemId) + " AND a.invDate < '" + Strings.Format(StockDate, "yyyy-MM-dd") + "' AND a.invDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "' AND a.invIsReturn = 1 ";
		if (intStoreId > 0)
		{
			text = text + " AND storeId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = text + " AND storeId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)  AND storeId IN   (SELECT storeId FROM storages    WHERE branchId = " + Conversions.ToString(intBranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		dataTable = Module1.sqlTable(text, "read", Clone: true);
		double value7 = default(double);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["iiQty"])))
		{
			value7 = Conversions.ToDouble(dataTable.Rows[0]["iiQty"]);
		}
		text = " SELECT SUM(comMainQty) as comQty  FROM processes a, processcomponents b  WHERE a.proId = b.proId  AND b.itemId = " + Conversions.ToString(intItemId) + " AND b.comDate < '" + Strings.Format(StockDate, "yyyy-MM-dd") + "' AND b.comDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "'";
		if (intStoreId > 0)
		{
			text = text + " AND b.storeId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = text + " AND b.storeId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)  AND b.storeId IN   (SELECT storeId FROM storages    WHERE branchId = " + Conversions.ToString(intBranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND b.storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND b.storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		dataTable = Module1.sqlTable(text, "read", Clone: true);
		double value8 = default(double);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["comQty"])))
		{
			value8 = Conversions.ToDouble(dataTable.Rows[0]["comQty"]);
		}
		text = " SELECT SUM(adjMainQty) as adjQty FROM adjustments  WHERE itemId = " + Conversions.ToString(intItemId) + " AND adjDate < '" + Strings.Format(StockDate, "yyyy-MM-dd") + "' AND adjDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "' AND adjType = 1 ";
		if (intStoreId > 0)
		{
			text = text + " AND storeId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = text + " AND storeId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)  AND storeId IN   (SELECT storeId FROM storages    WHERE branchId = " + Conversions.ToString(intBranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		dataTable = Module1.sqlTable(text, "read", Clone: true);
		double value9 = default(double);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["adjQty"])))
		{
			value9 = Conversions.ToDouble(dataTable.Rows[0]["adjQty"]);
		}
		text = " SELECT SUM(adjMainQty) as adjQty FROM adjustments  WHERE itemId = " + Conversions.ToString(intItemId) + " AND adjDate < '" + Strings.Format(StockDate, "yyyy-MM-dd") + "' AND adjDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "' AND adjType = 0 ";
		if (intStoreId > 0)
		{
			text = text + " AND storeId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = text + " AND storeId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)  AND storeId IN   (SELECT storeId FROM storages    WHERE branchId = " + Conversions.ToString(intBranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		dataTable = Module1.sqlTable(text, "read", Clone: true);
		double value10 = default(double);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["adjQty"])))
		{
			value10 = Conversions.ToDouble(dataTable.Rows[0]["adjQty"]);
		}
		text = " SELECT SUM(psQty) AS psQty  FROM produkstorages  WHERE prodId = " + Conversions.ToString(intItemId);
		if (intStoreId > 0)
		{
			text = text + " AND storeId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = text + " AND storeId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)  AND storeId IN   (SELECT storeId FROM storages    WHERE branchId = " + Conversions.ToString(intBranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		dataTable = Module1.sqlTable(text, "read", Clone: true);
		double value11 = default(double);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["psQty"])))
		{
			value11 = Conversions.ToDouble(dataTable.Rows[0]["psQty"]);
		}
		text = " SELECT SUM(proMainQty) AS proQty  FROM processes  WHERE itemId = " + Conversions.ToString(intItemId) + " AND proDate < '" + Strings.Format(StockDate, "yyyy-MM-dd") + "' AND proDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "'";
		if (intStoreId > 0)
		{
			text = text + " AND storeId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = text + " AND storeId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)  AND storeId IN   (SELECT storeId FROM storages    WHERE branchId = " + Conversions.ToString(intBranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		dataTable = Module1.sqlTable(text, "read", Clone: true);
		double value12 = default(double);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["proQty"])))
		{
			value12 = Conversions.ToDouble(dataTable.Rows[0]["proQty"]);
		}
		text = " SELECT SUM(transferQty) as transferQty  FROM transfer a, transfer_item b  WHERE a.transferId = b.transferId  AND itemId = " + Conversions.ToString(intItemId) + " AND transferDate < '" + Strings.Format(StockDate, "yyyy-MM-dd") + "' AND transferDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "'";
		if (intStoreId > 0)
		{
			text = text + " AND storageToId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storageToId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storageToId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
			text = text + "  AND storageToId IN   (SELECT storeId FROM storages    WHERE branchId = " + Conversions.ToString(intBranchId) + ")";
			text = text + " AND storageToId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)";
		}
		dataTable = Module1.sqlTable(text, "read", Clone: true);
		double value13 = default(double);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["transferQty"])))
		{
			value13 = Conversions.ToDouble(dataTable.Rows[0]["transferQty"]);
		}
		text = " SELECT SUM(transferQty) as transferQty  FROM transfer a, transfer_item b  WHERE a.transferId = b.transferId  AND itemId = " + Conversions.ToString(intItemId) + " AND transferDate < '" + Strings.Format(StockDate, "yyyy-MM-dd") + "' AND transferDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "'";
		if (intStoreId > 0)
		{
			text = text + " AND storageFromId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storageFromId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storageFromId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
			text = text + "  AND storageFromId IN   (SELECT storeId FROM storages    WHERE branchId = " + Conversions.ToString(intBranchId) + ")";
			text = text + " AND storageFromId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)";
		}
		dataTable = Module1.sqlTable(text, "read", Clone: true);
		double value14 = default(double);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["transferQty"])))
		{
			value14 = Conversions.ToDouble(dataTable.Rows[0]["transferQty"]);
		}
		num = Convert.ToDouble(decimal.Subtract(decimal.Subtract(decimal.Subtract(decimal.Subtract(decimal.Subtract(decimal.Subtract(decimal.Subtract(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(value11), new decimal(value2)), new decimal(value6)), new decimal(value10)), new decimal(value12)), new decimal(value13)), new decimal(value5)), new decimal(value3)), new decimal(value)), new decimal(value4)), new decimal(value7)), new decimal(value8)), new decimal(value9)), new decimal(value14)));
		return Math.Round(num, 3);
	}

	public static double getInStock(int intItemId, DateTime BeginDate, DateTime EndDate, string StorageType, int intStoreId, int intGroupId, int intBranchId)
	{
		double num = 0.0;
		double inSalesReturn = getInSalesReturn(intItemId, BeginDate, EndDate, StorageType, intStoreId, intGroupId, intBranchId);
		double inPurchase = getInPurchase(intItemId, BeginDate, EndDate, StorageType, intStoreId, intGroupId, intBranchId);
		double inAdjustment = getInAdjustment(intItemId, BeginDate, EndDate, StorageType, intStoreId, intGroupId, intBranchId);
		double inProcess = getInProcess(intItemId, BeginDate, EndDate, StorageType, intStoreId, intGroupId, intBranchId);
		double inTransfer = getInTransfer(intItemId, BeginDate, EndDate, StorageType, intStoreId, intGroupId, intBranchId);
		double inReceiveItem = getInReceiveItem(intItemId, BeginDate, EndDate, StorageType, intStoreId, intGroupId, intBranchId);
		return Convert.ToDouble(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(inSalesReturn), new decimal(inPurchase)), new decimal(inAdjustment)), new decimal(inProcess)), new decimal(inTransfer)), new decimal(inReceiveItem)));
	}

	public static double getOutStock(int intItemId, DateTime BeginDate, DateTime EndDate, string StorageType, int intStoreId, int intGroupId, int intBranchId)
	{
		double num = 0.0;
		double outUsage = getOutUsage(intItemId, BeginDate, EndDate, StorageType, intStoreId, intGroupId, intBranchId);
		double outSales = getOutSales(intItemId, BeginDate, EndDate, StorageType, intStoreId, intGroupId, intBranchId);
		double outDeliveryOrder = getOutDeliveryOrder(intItemId, BeginDate, EndDate, StorageType, intStoreId, intGroupId, intBranchId);
		double outPurchaseReturn = getOutPurchaseReturn(intItemId, BeginDate, EndDate, StorageType, intStoreId, intGroupId, intBranchId);
		double outComponent = getOutComponent(intItemId, BeginDate, EndDate, StorageType, intStoreId, intGroupId, intBranchId);
		double outAdjustment = getOutAdjustment(intItemId, BeginDate, EndDate, StorageType, intStoreId, intGroupId, intBranchId);
		double outTransfer = getOutTransfer(intItemId, BeginDate, EndDate, StorageType, intStoreId, intGroupId, intBranchId);
		return Convert.ToDouble(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(outUsage), new decimal(outSales)), new decimal(outDeliveryOrder)), new decimal(outPurchaseReturn)), new decimal(outComponent)), new decimal(outAdjustment)), new decimal(outTransfer)));
	}

	public static double getInSalesReturn(int intItemId, DateTime BeginDate, DateTime EndDate, string StorageType, int intStoreId, int intGroupId, int intBranchId)
	{
		double result = 0.0;
		string text = " SELECT SUM(ppAmount)-SUM(ppMissing) as ppAmount  FROM penjProd  WHERE prodId =  (SELECT prodId FROM produk   WHERE prodName = (SELECT itemName FROM items WHERE itemId = " + Conversions.ToString(intItemId) + ")) AND penjId IN  (SELECT penjId FROM penjualan   WHERE penjDate < '" + Strings.Format(EndDate, "yyyy-MM-dd") + "'  AND penjDate >= '" + Strings.Format(BeginDate, "yyyy-MM-dd") + "'  AND penjBsType > 0 ";
		if (intStoreId > 0)
		{
			text = text + " AND storeId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = text + " AND storeId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)  AND storeId IN   (SELECT storeId FROM storages    WHERE branchId = " + Conversions.ToString(intBranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		text += ")";
		DataTable dataTable = Module1.sqlTable(text, "read", Clone: true);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["ppAmount"])))
		{
			result = Conversions.ToDouble(dataTable.Rows[0]["ppAmount"]);
		}
		return result;
	}

	public static double getInPurchase(int intItemId, DateTime BeginDate, DateTime EndDate, string StorageType, int intStoreId, int intGroupId, int intBranchId)
	{
		double result = 0.0;
		string text = " SELECT SUM(iiMainQty) as iiQty  FROM purchaseinvoices a, purchaseinvoices_items b  WHERE a.invId = b.invId  AND b.itemId = " + Conversions.ToString(intItemId) + " AND a.invDate < '" + Strings.Format(EndDate, "yyyy-MM-dd") + "' AND a.invDate >= '" + Strings.Format(BeginDate, "yyyy-MM-dd") + "' AND invIsReturn = 0  AND b.riId IS NULL ";
		if (intStoreId > 0)
		{
			text = text + " AND storeId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = text + " AND storeId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)  AND storeId IN   (SELECT storeId FROM storages    WHERE branchId = " + Conversions.ToString(intBranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		DataTable dataTable = Module1.sqlTable(text, "read", Clone: true);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["iiQty"])))
		{
			result = Conversions.ToDouble(dataTable.Rows[0]["iiQty"]);
		}
		return result;
	}

	public static double getInAdjustment(int intItemId, DateTime BeginDate, DateTime EndDate, string StorageType, int intStoreId, int intGroupId, int intBranchId)
	{
		double result = 0.0;
		string text = " SELECT SUM(adjMainQty) as adjQty FROM adjustments  WHERE itemId = " + Conversions.ToString(intItemId) + " AND adjDate < '" + Strings.Format(EndDate, "yyyy-MM-dd") + "' AND adjDate >= '" + Strings.Format(BeginDate, "yyyy-MM-dd") + "' AND adjType = 0 ";
		if (intStoreId > 0)
		{
			text = text + " AND storeId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = text + " AND storeId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)  AND storeId IN   (SELECT storeId FROM storages    WHERE branchId = " + Conversions.ToString(intBranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		DataTable dataTable = Module1.sqlTable(text, "read", Clone: true);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["adjQty"])))
		{
			result = Conversions.ToDouble(dataTable.Rows[0]["adjQty"]);
		}
		return result;
	}

	public static double getInProcess(int intItemId, DateTime BeginDate, DateTime EndDate, string StorageType, int intStoreId, int intGroupId, int intBranchId)
	{
		double result = 0.0;
		string text = " SELECT SUM(proMainQty) AS proQty  FROM processes  WHERE itemId = " + Conversions.ToString(intItemId) + " AND proDate < '" + Strings.Format(EndDate, "yyyy-MM-dd") + "' AND proDate >= '" + Strings.Format(BeginDate, "yyyy-MM-dd") + "'";
		if (intStoreId > 0)
		{
			text = text + " AND storeId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = text + " AND storeId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)  AND storeId IN   (SELECT storeId FROM storages    WHERE branchId = " + Conversions.ToString(intBranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		DataTable dataTable = Module1.sqlTable(text, "read", Clone: true);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["proQty"])))
		{
			result = Conversions.ToDouble(dataTable.Rows[0]["proQty"]);
		}
		return result;
	}

	public static double getInTransfer(int intItemId, DateTime BeginDate, DateTime EndDate, string StorageType, int intStoreId, int intGroupId, int intBranchId)
	{
		double result = 0.0;
		string text = " SELECT SUM(transferQty) as transferQty  FROM transfer a, transfer_item b  WHERE a.transferId = b.transferId  AND itemId = " + Conversions.ToString(intItemId) + " AND transferDate < '" + Strings.Format(EndDate, "yyyy-MM-dd") + "' AND transferDate >= '" + Strings.Format(BeginDate, "yyyy-MM-dd") + "'";
		if (intStoreId > 0)
		{
			text = text + " AND storageToId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storageToId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storageToId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
			text = text + "  AND storageToId IN   (SELECT storeId FROM storages    WHERE branchId = " + Conversions.ToString(intBranchId) + ")";
			text = text + " AND storageToId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)";
		}
		DataTable dataTable = Module1.sqlTable(text, "read", Clone: true);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["transferQty"])))
		{
			result = Conversions.ToDouble(dataTable.Rows[0]["transferQty"]);
		}
		return result;
	}

	public static double getInReceiveItem(int intItemId, DateTime BeginDate, DateTime EndDate, string StorageType, int intStoreId, int intGroupId, int intBranchId)
	{
		double result = 0.0;
		string text = " SELECT SUM(riQty) as riQty  FROM receiveditem_item  WHERE itemId = " + Conversions.ToString(intItemId) + " AND riId IN  (SELECT riId FROM receiveditem   WHERE riDate < '" + Strings.Format(EndDate, "yyyy-MM-dd") + "'  AND riDate >= '" + Strings.Format(BeginDate, "yyyy-MM-dd") + "'";
		if (intStoreId > 0)
		{
			text = text + " AND storeId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = text + " AND storeId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)  AND storeId IN   (SELECT storeId FROM storages    WHERE branchId = " + Conversions.ToString(intBranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		text += ")";
		DataTable dataTable = Module1.sqlTable(text, "read", Clone: true);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["riQty"])))
		{
			result = Conversions.ToDouble(dataTable.Rows[0]["riQty"]);
		}
		return result;
	}

	public static double getOutSales(int intItemId, DateTime BeginDate, DateTime EndDate, string StorageType, int intStoreId, int intGroupId, int intBranchId)
	{
		double result = 0.0;
		string text = " SELECT SUM(ppAmount)-SUM(ppMissing) as ppAmount  FROM penjProd  WHERE prodId = " + Conversions.ToString(intItemId) + " AND doId IS NULL  AND penjId IN  (SELECT penjId FROM penjualan   WHERE penjDate < '" + Strings.Format(EndDate, "yyyy-MM-dd") + "'  AND penjDate >= '" + Strings.Format(BeginDate, "yyyy-MM-dd") + "'  AND penjBsType = 0 ";
		if (intStoreId > 0)
		{
			text = text + " AND storeId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = text + " AND storeId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)  AND storeId IN   (SELECT storeId FROM storages    WHERE branchId = " + Conversions.ToString(intBranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		text += ")";
		DataTable dataTable = Module1.sqlTable(text, "read", Clone: true);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["ppAmount"])))
		{
			result = Conversions.ToDouble(dataTable.Rows[0]["ppAmount"]);
		}
		return result;
	}

	public static double getOutUsage(int intItemId, DateTime BeginDate, DateTime EndDate, string StorageType, int intStoreId, int intGroupId, int intBranchId)
	{
		double result = 0.0;
		string text = " SELECT SUM(useQty)+SUM(wasteQty) as usageQty  FROM usage_item  WHERE itemId = " + Conversions.ToString(intItemId) + " AND usageId IN  (SELECT usageId FROM usages   WHERE usageDate < '" + Strings.Format(EndDate, "yyyy-MM-dd") + "'  AND usageDate >= '" + Strings.Format(BeginDate, "yyyy-MM-dd") + "'";
		if (intStoreId > 0)
		{
			text = text + " AND storeId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = text + " AND storeId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)  AND storeId IN   (SELECT storeId FROM storages    WHERE branchId = " + Conversions.ToString(intBranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		text += ")";
		DataTable dataTable = Module1.sqlTable(text, "read", Clone: true);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["usageQty"])))
		{
			result = Conversions.ToDouble(dataTable.Rows[0]["usageQty"]);
		}
		return result;
	}

	public static double getOutDeliveryOrder(int intItemId, DateTime BeginDate, DateTime EndDate, string StorageType, int intStoreId, int intGroupId, int intBranchId)
	{
		double result = 0.0;
		string text = " SELECT SUM(doQty) as doQty  FROM deliveryorder_item  WHERE itemId = " + Conversions.ToString(intItemId) + " AND doId IN  (SELECT doId FROM deliveryorder   WHERE doDate < '" + Strings.Format(EndDate, "yyyy-MM-dd") + "'  AND doDate >= '" + Strings.Format(BeginDate, "yyyy-MM-dd") + "'";
		if (intStoreId > 0)
		{
			text = text + " AND storeId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = text + " AND storeId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)  AND storeId IN   (SELECT storeId FROM storages    WHERE branchId = " + Conversions.ToString(intBranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		text += ")";
		DataTable dataTable = Module1.sqlTable(text, "read", Clone: true);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["doQty"])))
		{
			result = Conversions.ToDouble(dataTable.Rows[0]["doQty"]);
		}
		return result;
	}

	public static double getOutPurchaseReturn(int intItemId, DateTime BeginDate, DateTime EndDate, string StorageType, int intStoreId, int intGroupId, int intBranchId)
	{
		double result = 0.0;
		string text = " SELECT SUM(iiMainQty) as iiQty  FROM purchaseinvoices a, purchaseinvoices_items b  WHERE a.invId = b.invId  AND b.itemId = " + Conversions.ToString(intItemId) + " AND a.invDate < '" + Strings.Format(EndDate, "yyyy-MM-dd") + "' AND a.invDate >= '" + Strings.Format(BeginDate, "yyyy-MM-dd") + "' AND a.invIsReturn = 1 ";
		if (intStoreId > 0)
		{
			text = text + " AND storeId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = text + " AND storeId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)  AND storeId IN   (SELECT storeId FROM storages    WHERE branchId = " + Conversions.ToString(intBranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		DataTable dataTable = Module1.sqlTable(text, "read", Clone: true);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["iiQty"])))
		{
			result = Conversions.ToDouble(dataTable.Rows[0]["iiQty"]);
		}
		return result;
	}

	public static double getOutComponent(int intItemId, DateTime BeginDate, DateTime EndDate, string StorageType, int intStoreId, int intGroupId, int intBranchId)
	{
		double result = 0.0;
		string text = " SELECT SUM(comMainQty) as comQty  FROM processes a, processcomponents b  WHERE a.proId = b.proId  AND b.itemId = " + Conversions.ToString(intItemId) + " AND b.comDate < '" + Strings.Format(EndDate, "yyyy-MM-dd") + "' AND b.comDate >= '" + Strings.Format(BeginDate, "yyyy-MM-dd") + "'";
		if (intStoreId > 0)
		{
			text = text + " AND b.storeId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = text + " AND b.storeId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)  AND b.storeId IN   (SELECT storeId FROM storages    WHERE branchId = " + Conversions.ToString(intBranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND b.storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND b.storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		DataTable dataTable = Module1.sqlTable(text, "read", Clone: true);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["comQty"])))
		{
			result = Conversions.ToDouble(dataTable.Rows[0]["comQty"]);
		}
		return result;
	}

	public static double getOutAdjustment(int intItemId, DateTime BeginDate, DateTime EndDate, string StorageType, int intStoreId, int intGroupId, int intBranchId)
	{
		double result = 0.0;
		string text = " SELECT SUM(adjMainQty) as adjQty FROM adjustments  WHERE itemId = " + Conversions.ToString(intItemId) + " AND adjDate < '" + Strings.Format(EndDate, "yyyy-MM-dd") + "' AND adjDate >= '" + Strings.Format(BeginDate, "yyyy-MM-dd") + "' AND adjType = 1 ";
		if (intStoreId > 0)
		{
			text = text + " AND storeId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = text + " AND storeId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)  AND storeId IN   (SELECT storeId FROM storages    WHERE branchId = " + Conversions.ToString(intBranchId) + ")";
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storeId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
		}
		DataTable dataTable = Module1.sqlTable(text, "read", Clone: true);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["adjQty"])))
		{
			result = Conversions.ToDouble(dataTable.Rows[0]["adjQty"]);
		}
		return result;
	}

	public static double getOutTransfer(int intItemId, DateTime BeginDate, DateTime EndDate, string StorageType, int intStoreId, int intGroupId, int intBranchId)
	{
		double result = 0.0;
		string text = " SELECT SUM(transferQty) as transferQty  FROM transfer a, transfer_item b  WHERE a.transferId = b.transferId  AND itemId = " + Conversions.ToString(intItemId) + " AND transferDate < '" + Strings.Format(EndDate, "yyyy-MM-dd") + "' AND transferDate >= '" + Strings.Format(BeginDate, "yyyy-MM-dd") + "'";
		if (intStoreId > 0)
		{
			text = text + " AND storageFromId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = ((Operators.CompareString(StorageType, "Good", TextCompare: false) != 0) ? (text + " AND storageFromId IN (SELECT storeId FROM storages WHERE storeReturn = 1)") : (text + " AND storageFromId IN (SELECT storeId FROM storages WHERE storeReturn = 0)"));
			text = text + "  AND storageFromId IN   (SELECT storeId FROM storages    WHERE branchId = " + Conversions.ToString(intBranchId) + ")";
			text = text + " AND storageFromId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)";
		}
		DataTable dataTable = Module1.sqlTable(text, "read", Clone: true);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["transferQty"])))
		{
			result = Conversions.ToDouble(dataTable.Rows[0]["transferQty"]);
		}
		return result;
	}
}
