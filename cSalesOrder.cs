using System;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace GCUv2;

public class cSalesOrder
{
	private double _id;

	private DateTime _soDate;

	private DateTime _expiredDate;

	private string _soNumber;

	private string _poNumber;

	private double _totalPrice;

	private double _discount;

	private string _discountDescription;

	private string _note;

	private DateTime _createdDate;

	private cSalesOrderItem[] _item;

	private double _customerId;

	private string _customerName;

	private string _customerAddress;

	private int _branchId;

	private double _invoiceId;

	private string _invoiceNumber;

	private int _discountId;

	public double Id
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

	public DateTime SODate
	{
		get
		{
			return _soDate;
		}
		set
		{
			_soDate = value;
		}
	}

	public DateTime ExpiredDate
	{
		get
		{
			return _expiredDate;
		}
		set
		{
			_expiredDate = value;
		}
	}

	public string SONumber
	{
		get
		{
			return _soNumber;
		}
		set
		{
			_soNumber = value;
		}
	}

	public string PONumber
	{
		get
		{
			return _poNumber;
		}
		set
		{
			_poNumber = value;
		}
	}

	public double TotalPrice
	{
		get
		{
			return _totalPrice;
		}
		set
		{
			_totalPrice = value;
		}
	}

	public double Discount
	{
		get
		{
			return _discount;
		}
		set
		{
			_discount = value;
		}
	}

	public string DiscountDescription
	{
		get
		{
			return _discountDescription;
		}
		set
		{
			_discountDescription = Module1.cleanString(value);
		}
	}

	public string Note
	{
		get
		{
			return _note;
		}
		set
		{
			_note = Module1.cleanString(value);
		}
	}

	public DateTime CreatedDate
	{
		get
		{
			return _createdDate;
		}
		set
		{
			_createdDate = value;
		}
	}

	public cSalesOrderItem[] Item
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

	public double CustomerId
	{
		get
		{
			return _customerId;
		}
		set
		{
			_customerId = value;
		}
	}

	public string CustomerName
	{
		get
		{
			return _customerName;
		}
		set
		{
			_customerName = value;
		}
	}

	public string CustomerAddress
	{
		get
		{
			return _customerAddress;
		}
		set
		{
			_customerAddress = value;
		}
	}

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

	public double InvoiceId
	{
		get
		{
			return _invoiceId;
		}
		set
		{
			_invoiceId = value;
		}
	}

	public string InvoiceNumber
	{
		get
		{
			return _invoiceNumber;
		}
		set
		{
			_invoiceNumber = value;
		}
	}

	public int DiscountId
	{
		get
		{
			return _discountId;
		}
		set
		{
			_discountId = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public cSalesOrder(double SOId)
	{
		if (!(SOId > 0.0))
		{
			return;
		}
		_id = SOId;
		DataTable dataTable = new DataTable();
		string strSql = " SELECT soDate, soExpiredDate, CONCAT('SO/',CAST(b.branchId AS CHAR),'/',SUBSTR(YEAR(soDate),3),'/',soNumber) AS soNumber,  poNumber, soDiscount, soDiscountDescription,  soNote, soCreatedDate, a.penjId, c.penjFaktur,  a.custId, b.custName, b.custAddress, b.branchId, b.discId  FROM salesOrder a LEFT OUTER JOIN penjualan c ON a.penjId = c.penjId, customer b WHERE soId = " + Conversions.ToString(_id) + " AND a.custId = b.custId ";
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			_soDate = Conversions.ToDate(dataTable.Rows[0]["soDate"]);
			_expiredDate = Conversions.ToDate(dataTable.Rows[0]["soExpiredDate"]);
			_soNumber = Conversions.ToString(dataTable.Rows[0]["soNumber"]);
			_poNumber = Conversions.ToString(dataTable.Rows[0]["poNumber"]);
			_discount = Conversions.ToDouble(dataTable.Rows[0]["soDiscount"]);
			_discountDescription = Conversions.ToString(dataTable.Rows[0]["soDiscountDescription"]);
			_note = Conversions.ToString(dataTable.Rows[0]["soNote"]);
			_createdDate = Conversions.ToDate(dataTable.Rows[0]["soCreatedDate"]);
			_customerId = Conversions.ToDouble(dataTable.Rows[0]["custId"]);
			_customerName = Conversions.ToString(dataTable.Rows[0]["custName"]);
			_customerAddress = Conversions.ToString(dataTable.Rows[0]["custAddress"]);
			_branchId = Conversions.ToInteger(dataTable.Rows[0]["branchId"]);
			_invoiceId = Conversions.ToDouble(dataTable.Rows[0]["penjId"]);
			_discountId = Conversions.ToInteger(dataTable.Rows[0]["discId"]);
			if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["penjFaktur"])))
			{
				_invoiceNumber = Conversions.ToString(dataTable.Rows[0]["penjFaktur"]);
			}
		}
		else
		{
			_id = 0.0;
			Information.Err().Raise(513, null, "Pesanan Penjualan tidak ditemukan. Kemungkinan telah dihapus.");
		}
		strSql = " SELECT soId, a.itemId, itemName, itemQty, itemPrice  FROM salesorder_item a, items b  WHERE a.itemId = b.itemId  AND soId = " + Conversions.ToString(_id);
		int num = 0;
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		checked
		{
			_item = new cSalesOrderItem[dataTable.Rows.Count - 1 + 1];
			foreach (DataRow row in dataTable.Rows)
			{
				_item[num] = new cSalesOrderItem();
				_item[num].SOId = Conversions.ToDouble(row["soId"]);
				_item[num].ItemId = Conversions.ToInteger(row["itemId"]);
				_item[num].ItemName = Conversions.ToString(row["itemName"]);
				_item[num].Qty = Conversions.ToDouble(row["itemQty"]);
				_item[num].Price = Conversions.ToDouble(row["itemPrice"]);
				num++;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public void Save()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		MySqlTransaction val = default(MySqlTransaction);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					val = Module1.connectData.BeginTransaction();
					if (_id == 0.0)
					{
						_soNumber = GenerateNewNumber();
						string strSql = " INSERT INTO salesOrder  (soDate, soExpiredDate, soNumber, poNumber, soTotalPrice, soDiscount,  soDiscountDescription, soNote, soCreatedDate,  custId) VALUES  ('" + Strings.Format(_soDate, "yyyy-MM-dd") + "','" + Strings.Format(_expiredDate, "yyyy-MM-dd") + "','" + _soNumber + "','" + _poNumber + "'," + Module1.unformatNumber(Conversions.ToString(_totalPrice)) + "," + Module1.unformatNumber(Conversions.ToString(_discount)) + ",'" + _discountDescription + "','" + _note + "','" + Strings.Format(DateAndTime.Now, "yyyy-MM-dd HH:mm:ss") + "'," + Conversions.ToString(CustomerId) + ")";
						Module1.sqlNonQuery(strSql, "data");
						_id = cDatabase.LastId("data");
					}
					else
					{
						string strSql = " UPDATE salesOrder  SET soDate = '" + Strings.Format(_soDate, "yyyy-MM-dd") + "', soExpiredDate = '" + Strings.Format(_expiredDate, "yyyy-MM-dd") + "', poNumber = '" + _poNumber + "', soTotalPrice = " + Module1.unformatNumber(Conversions.ToString(_totalPrice)) + ", soDiscount = " + Module1.unformatNumber(Conversions.ToString(_discount)) + ", soDiscountDescription = '" + _discountDescription + "', soNote = '" + _note + "', custId = " + Conversions.ToString(_customerId) + " WHERE soId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " DELETE FROM salesOrder_item  WHERE soId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
					}
					cSalesOrderItem[] item = _item;
					foreach (cSalesOrderItem cSalesOrderItem2 in item)
					{
						string strSql = " INSERT INTO salesOrder_item  (soId, itemId, itemQty, itemPrice) VALUES  ( " + Conversions.ToString(_id) + "," + Conversions.ToString(cSalesOrderItem2.ItemId) + "," + Module1.unformatNumber(Conversions.ToString(cSalesOrderItem2.Qty)) + "," + Module1.unformatNumber(Conversions.ToString(cSalesOrderItem2.Price)) + ")";
						Module1.sqlNonQuery(strSql, "data");
					}
					val.Commit();
					goto end_IL_0001;
				}
				case 941:
					num = -1;
					switch (num2)
					{
					case 2:
						if (Operators.CompareString(Information.Err().Description, "Fatal error encountered during command execution.", TextCompare: false) != 0 && Operators.CompareString(Information.Err().Description, "The connection is not open.", TextCompare: false) != 0)
						{
							val.Rollback();
						}
						Information.Err().Raise(513, null, Information.Err().Description);
						goto end_IL_0001;
					}
					break;
				}
				goto IL_03e3;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 941;
				continue;
			}
			break;
			IL_03e3:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static DataTable Search(int intRange, DateTime dateFirst, DateTime dateLast, double CustomerId, int GroupId, int BranchId, double InvoiceId)
	{
		string text = ((intRange != 5) ? " SELECT soId, soDate, soExpiredDate,  CONCAT('SO/',CAST(b.branchId AS CHAR),'/',SUBSTR(YEAR(soDate),3),'/',soNumber) AS soNumber, poNumber,  soTotalPrice, soDiscount, soDiscountDescription,  soNote, soCreatedDate, custName, CAST(COALESCE(penjDate,'0000-00-00 00:00:00') AS DATETIME) AS penjDate, COALESCE(penjFaktur,'') AS penjFaktur " : " SELECT DISTINCT soId, soDate, soExpiredDate,  CONCAT('SO/',CAST(b.branchId AS CHAR),'/',SUBSTR(YEAR(soDate),3),'/',soNumber) AS soNumber, poNumber,  soTotalPrice, soDiscount ");
		text += " FROM salesOrder a LEFT OUTER JOIN penjualan c ON a.penjId = c.penjId, customer b  WHERE a.custId = b.custId ";
		switch (intRange)
		{
		case 1:
			text = text + " AND soDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND soDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
			break;
		case 3:
			text = text + " AND soExpiredDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND soExpiredDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
			break;
		case 5:
			text = ((!(InvoiceId > 0.0)) ? (text + " AND a.soId NOT IN (SELECT soId FROM penjprod) ") : (text + " AND (a.soId NOT IN (SELECT soId FROM penjprod)  OR a.soId IN (SELECT soId FROM penjprod WHERE penjId = " + Conversions.ToString(InvoiceId) + "))"));
			break;
		}
		text = ((BranchId <= 0) ? (text + " AND b.branchId IN (SELECT branchId FROM groups_branches  WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1) ") : (text + " AND b.branchId = " + Conversions.ToString(BranchId)));
		if (CustomerId > 0.0)
		{
			text = text + " AND (a.custId = " + Conversions.ToString(CustomerId) + " OR b.custParentId = " + Conversions.ToString(CustomerId) + ")";
		}
		return Module1.sqlTable(intRange switch
		{
			2 => text + " ORDER BY soId DESC LIMIT 100 ", 
			4 => text + " ORDER BY soDate DESC ", 
			_ => text + " ORDER BY soDate, custName ", 
		}, "data", Clone: false);
	}

	public void Delete()
	{
		string strSql = " DELETE FROM salesOrder WHERE soId = " + Conversions.ToString(_id);
		Module1.sqlNonQuery(strSql, "data");
		strSql = " DELETE FROM salesOrder_item WHERE soId = " + Conversions.ToString(_id);
		Module1.sqlNonQuery(strSql, "data");
	}

	private string GenerateNewNumber()
	{
		string strSql = " SELECT * FROM salesOrder a, customer b WHERE YEAR(soDate) = " + Conversions.ToString(DateAndTime.Year(_soDate)) + " AND a.custId = b.custId  AND b.branchId = " + Conversions.ToString(_branchId) + " ORDER BY soId DESC LIMIT 1 ";
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		return ((dataTable.Rows.Count <= 0) ? 1 : checked((int)Math.Round(Conversion.Val(Strings.Right(Conversions.ToString(dataTable.Rows[0]["soNumber"]), 5)) + 1.0))).ToString("00000");
	}
}
