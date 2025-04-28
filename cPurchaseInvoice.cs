using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace GCUv2;

public class cPurchaseInvoice
{
	private double _id;

	private int _supplierId;

	private DateTime _invoiceDate;

	private DateTime _taxInvoiceDate;

	private string _number;

	private string _taxNumber;

	private int _isTaxIncluded;

	private int _invoiceCode;

	private double _discount;

	private double _deduction;

	private cPurchaseInvoiceItem[] _currentItem;

	private DateTime _currentDate;

	private cPurchaseInvoiceItem[] _item;

	private cPurchaseInvoicePayment[] _payment;

	private cPurchaseInvoiceReturn[] _invoiceReturn;

	private double _totalPrice;

	private double _totalReturn;

	private double _totalPayment;

	private DateTime _paidDate;

	private int _isReturn;

	private bool _isTaxInvoice;

	private double _parentInvoiceId;

	private string _parentInvoiceNumber;

	private DateTime _createdDate;

	private double[] _riId;

	private int _currencyId;

	private double _currencyRate;

	private string _currencyName;

	private int _storageId;

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

	public int SupplierId
	{
		get
		{
			return _supplierId;
		}
		set
		{
			_supplierId = value;
		}
	}

	public DateTime InvoiceDate
	{
		get
		{
			return _invoiceDate;
		}
		set
		{
			_invoiceDate = value;
		}
	}

	public DateTime TaxInvoiceDate
	{
		get
		{
			return _taxInvoiceDate;
		}
		set
		{
			_taxInvoiceDate = value;
		}
	}

	public DateTime CurrentDate
	{
		get
		{
			return _currentDate;
		}
		set
		{
			_currentDate = value;
		}
	}

	public string Number
	{
		get
		{
			return _number;
		}
		set
		{
			_number = value;
		}
	}

	public string TaxNumber
	{
		get
		{
			return _taxNumber;
		}
		set
		{
			_taxNumber = value;
		}
	}

	public int isTaxIncluded
	{
		get
		{
			return _isTaxIncluded;
		}
		set
		{
			_isTaxIncluded = value;
		}
	}

	public int InvoiceCode
	{
		get
		{
			return _invoiceCode;
		}
		set
		{
			_invoiceCode = value;
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

	public double Deduction
	{
		get
		{
			return _deduction;
		}
		set
		{
			_deduction = value;
		}
	}

	public cPurchaseInvoiceItem[] Item
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

	public cPurchaseInvoiceItem[] CurrentItem
	{
		get
		{
			return _currentItem;
		}
		set
		{
			_currentItem = value;
		}
	}

	public cPurchaseInvoicePayment[] Payment
	{
		get
		{
			return _payment;
		}
		set
		{
			_payment = value;
		}
	}

	public cPurchaseInvoiceReturn[] InvoiceReturn
	{
		get
		{
			return _invoiceReturn;
		}
		set
		{
			_invoiceReturn = value;
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

	public double TotalReturn
	{
		get
		{
			return _totalReturn;
		}
		set
		{
			_totalReturn = value;
		}
	}

	public double TotalPayment
	{
		get
		{
			return _totalPayment;
		}
		set
		{
			_totalPayment = value;
		}
	}

	public DateTime PaidDate
	{
		get
		{
			return _paidDate;
		}
		set
		{
			_paidDate = value;
		}
	}

	public int isReturn
	{
		get
		{
			return _isReturn;
		}
		set
		{
			_isReturn = value;
		}
	}

	public bool IsTaxInvoice
	{
		get
		{
			return _isTaxInvoice;
		}
		set
		{
			_isTaxInvoice = value;
		}
	}

	public double ParentInvoiceId
	{
		get
		{
			return _parentInvoiceId;
		}
		set
		{
			_parentInvoiceId = value;
		}
	}

	public string ParentInvoiceNumber
	{
		get
		{
			return _parentInvoiceNumber;
		}
		set
		{
			_parentInvoiceNumber = value;
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

	public double[] RiId
	{
		get
		{
			return _riId;
		}
		set
		{
			_riId = value;
		}
	}

	public int CurrencyId
	{
		get
		{
			return _currencyId;
		}
		set
		{
			_currencyId = value;
		}
	}

	public string CurrencyName
	{
		get
		{
			return _currencyName;
		}
		set
		{
			_currencyName = value;
		}
	}

	public double CurrencyRate
	{
		get
		{
			return _currencyRate;
		}
		set
		{
			_currencyRate = value;
		}
	}

	public int StorageId
	{
		get
		{
			return _storageId;
		}
		set
		{
			_storageId = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public cPurchaseInvoice(double InvId)
	{
		if (!(InvId > 0.0))
		{
			return;
		}
		_id = InvId;
		DataTable dataTable = new DataTable();
		string strSql = " SELECT a.*, d.supNpwp, e.currencyName  FROM purchaseinvoices a,suppliers d, currency e  WHERE invId = " + Conversions.ToString(_id) + " AND a.supId = d.supId  AND a.currencyId = e.currencyId ";
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			_supplierId = Conversions.ToInteger(dataTable.Rows[0]["supId"]);
			_invoiceDate = Conversions.ToDate(dataTable.Rows[0]["invDate"]);
			_taxInvoiceDate = Conversions.ToDate(dataTable.Rows[0]["invTaxDate"]);
			_isTaxIncluded = Conversions.ToInteger(dataTable.Rows[0]["invIsTaxIncluded"]);
			_totalPrice = Conversions.ToDouble(dataTable.Rows[0]["invTotal"]);
			_isReturn = Conversions.ToInteger(Interaction.IIf(Operators.ConditionalCompareObjectEqual(dataTable.Rows[0]["invIsReturn"], false, TextCompare: false), 0, 1));
			_number = Conversions.ToString(dataTable.Rows[0]["invNumber"]);
			_taxNumber = Conversions.ToString(dataTable.Rows[0]["invTaxNumber"]);
			_invoiceCode = Conversions.ToInteger(dataTable.Rows[0]["invCode"]);
			_totalPayment = Conversions.ToDouble(dataTable.Rows[0]["invPayment"]);
			_discount = Conversions.ToDouble(dataTable.Rows[0]["invDiscount"]);
			_deduction = Conversions.ToDouble(dataTable.Rows[0]["invDeduction"]);
			_createdDate = Conversions.ToDate(dataTable.Rows[0]["invCreated"]);
			_paidDate = Conversions.ToDate(dataTable.Rows[0]["invDatePaid"]);
			_currencyId = Conversions.ToInteger(dataTable.Rows[0]["currencyId"]);
			_currencyName = Conversions.ToString(dataTable.Rows[0]["currencyName"]);
			_currencyRate = Conversions.ToDouble(dataTable.Rows[0]["currencyRate"]);
			_storageId = Conversions.ToInteger(dataTable.Rows[0]["storageId"]);
			if (Operators.CompareString(Strings.Trim(Conversions.ToString(dataTable.Rows[0]["supNpwp"])), "", TextCompare: false) == 0)
			{
				_isTaxInvoice = false;
			}
			else
			{
				_isTaxInvoice = true;
			}
		}
		else
		{
			_id = 0.0;
			Information.Err().Raise(513, null, "Faktur tidak ditemukan. Kemungkinan telah dihapus.");
		}
		if (_isReturn == 1)
		{
			strSql = " SELECT * FROM purchaseinvoices  WHERE invId IN  (SELECT invId FROM purchaseinvoices_returns   WHERE invReturnId = " + Conversions.ToString(_id) + ")";
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				_parentInvoiceId = Conversions.ToDouble(dataTable.Rows[0]["invId"]);
				_parentInvoiceNumber = Conversions.ToString(dataTable.Rows[0]["invNumber"]);
			}
		}
		strSql = " SELECT iiId, a.itemId, a.storeId,  storeName, itemName, iiDescription, iiQty,  iiMainQty, iiParkedQty, iiDeduction,  iiNetQty, iiPrice, iiExtraPrice,  (iiNetQty * (iiPrice + iiExtraPrice)) as iiTotal,  IF(d.prodTea=1,'Teh GOPEK','') as generalType, d.prodLongName, d.prodBox,  e.unitName AS largeUnitName, a.riId, IFNULL(CONCAT('RI/',CAST(f.storeId AS CHAR),'/',SUBSTR(YEAR(riDate),3),'/',riNumber),'----') AS riNumber,  a.riItemId, a.currencyId, a.currencyRate,  g.currencyName, a.unitName, b.unitName AS baseUnitName,  b.inventoryAccountId  FROM purchaseinvoices_items a LEFT OUTER JOIN receivedItem f ON a.riId = f.riId, items b, storages c, produk d, itemUnit e, currency g  WHERE a.itemId = b.itemId  AND a.itemId = d.prodId  AND d.prodId = e.itemId  AND e.unitQty = 1  AND a.storeId = c.storeId  AND a.currencyId = g.currencyId  AND invId = " + Conversions.ToString(_id);
		int num = 0;
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		checked
		{
			_item = new cPurchaseInvoiceItem[dataTable.Rows.Count - 1 + 1];
			foreach (DataRow row in dataTable.Rows)
			{
				_item[num] = new cPurchaseInvoiceItem();
				_item[num].Id = Conversions.ToDouble(row["iiId"]);
				_item[num].ItemId = Conversions.ToInteger(row["itemId"]);
				_item[num].StorageId = Conversions.ToInteger(row["storeId"]);
				_item[num].StorageName = Conversions.ToString(row["storeName"]);
				_item[num].ItemName = Conversions.ToString(row["itemName"]);
				_item[num].Description = Conversions.ToString(row["iiDescription"]);
				_item[num].InvoiceQty = Conversions.ToDouble(row["iiQty"]);
				_item[num].StockQty = Conversions.ToDouble(row["iiMainQty"]);
				_item[num].ParkedQty = Conversions.ToDouble(row["iiParkedQty"]);
				_item[num].Deduction = Conversions.ToDouble(row["iiDeduction"]);
				_item[num].NetQty = Conversions.ToDouble(row["iiNetQty"]);
				_item[num].Price = Conversions.ToDouble(row["iiPrice"]);
				_item[num].ExtraPrice = Conversions.ToDouble(row["iiExtraPrice"]);
				_item[num].Total = Conversions.ToDouble(row["iiTotal"]);
				_item[num].GeneralType = Conversions.ToString(row["generalType"]);
				_item[num].LongName = Conversions.ToString(row["prodLongName"]);
				_item[num].Packaging = Conversions.ToString(row["prodBox"]);
				_item[num].LargeUnit = Conversions.ToString(row["largeUnitName"]);
				_item[num].RiId = Conversions.ToDouble(Interaction.IIf(row["riId"] == DBNull.Value, 0, RuntimeHelpers.GetObjectValue(row["riId"])));
				_item[num].RiNumber = Conversions.ToString(row["riNumber"]);
				_item[num].RiItemId = Conversions.ToDouble(row["riItemId"]);
				_item[num].CurrencyId = Conversions.ToInteger(row["currencyId"]);
				_item[num].CurrencyName = Conversions.ToString(row["currencyName"]);
				_item[num].CurrencyRate = Conversions.ToDouble(row["currencyRate"]);
				_item[num].UnitName = Conversions.ToString(row["unitName"]);
				_item[num].BaseUnitName = Conversions.ToString(row["baseUnitName"]);
				_item[num].InventoryAccountId = Conversions.ToInteger(row["inventoryAccountId"]);
				num++;
			}
			strSql = " SELECT a.pcId, IF(mpayId != 0,CONCAT('M-',pcName),pcName) as pcName,  payDate, payAmount, payId,  payInFront, mpayId,payCreated,  b.accountId, c.accountName, c.currencyId,  b.currencyRate, d.currencyName  FROM paymentcodes a, purchaseinvoices_payments b, account c, currency d  WHERE a.pcId = b.pcId  AND b.accountId = c.accountId  AND c.currencyId = d.currencyId  AND invId = " + Conversions.ToString(_id);
			num = 0;
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			_payment = new cPurchaseInvoicePayment[dataTable.Rows.Count - 1 + 1];
			foreach (DataRow row2 in dataTable.Rows)
			{
				_payment[num] = new cPurchaseInvoicePayment();
				_payment[num].PaymentId = Conversions.ToDouble(row2["payId"]);
				_payment[num].MultiPaymentId = Conversions.ToDouble(row2["mpayId"]);
				_payment[num].PaymentCodeId = Conversions.ToByte(row2["pcId"]);
				_payment[num].PaymentCodeName = Conversions.ToString(row2["pcName"]);
				_payment[num].PaymentDate = Conversions.ToDate(row2["payDate"]);
				_payment[num].Amount = Conversions.ToDouble((_isReturn == 1) ? Operators.MultiplyObject(row2["payAmount"], -1) : row2["payAmount"]);
				_payment[num].InFront = Conversions.ToByte(row2["payInFront"]);
				_payment[num].AccountId = Conversions.ToInteger(row2["accountId"]);
				_payment[num].AccountName = Conversions.ToString(row2["accountName"]);
				_payment[num].CurrencyName = Conversions.ToString(row2["currencyName"]);
				_payment[num].CurrencyRate = Conversions.ToDouble(row2["currencyRate"]);
				if (Operators.CompareString(Strings.Right(_payment[num].PaymentCodeName, 3), "C/G", TextCompare: false) == 0)
				{
					cChequeOut cChequeOut2 = new cChequeOut(_payment[num].PaymentId, _payment[num].MultiPaymentId);
					_payment[num].ChequeId = cChequeOut2.Id;
					_payment[num].ChequeDate = cChequeOut2.ChequeDate;
					_payment[num].ChequeNumber = cChequeOut2.Number;
				}
				if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(row2["payCreated"])))
				{
					_payment[num].CreatedDate = Conversions.ToDate(row2["payCreated"]);
				}
				num++;
			}
			strSql = " SELECT invReturnId as InvId, invNumber, invDate,  invReturn+invDeduction+invDiscount as invReturn  FROM purchaseinvoices_returns a, purchaseinvoices b  WHERE a.invReturnId = b.invId  AND a.invId = " + Conversions.ToString(_id);
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			num = 0;
			_invoiceReturn = new cPurchaseInvoiceReturn[dataTable.Rows.Count - 1 + 1];
			foreach (DataRow row3 in dataTable.Rows)
			{
				_invoiceReturn[num] = new cPurchaseInvoiceReturn();
				_invoiceReturn[num].Id = Conversions.ToDouble(row3["invId"]);
				_invoiceReturn[num].Number = Conversions.ToString(row3["invNumber"]);
				_invoiceReturn[num].InvoiceDate = Conversions.ToDate(row3["invDate"]);
				_invoiceReturn[num].Amount = Conversions.ToDouble(row3["invReturn"]);
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
				checked
				{
					switch (try0001_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						val = Module1.connectData.BeginTransaction();
						if (_isReturn == 1)
						{
							_discount *= -1.0;
							_deduction *= -1.0;
							_totalPayment *= -1.0;
						}
						string strSql;
						if (_id == 0.0)
						{
							if (_isReturn == 1)
							{
								_number = GenerateNewNumber();
							}
							strSql = " INSERT INTO purchaseinvoices  (invNumber, invDate, invTaxNumber,  invTaxDate, invCode, invTotal,  invReturn, invDiscount, invDeduction,  invPayment, invNote, invDatePaid,  invIsReturn, invCreated, supId,  currencyId, currencyRate, storageId,  invIsTaxIncluded) VALUES  ('" + _number + "','" + Strings.Format(InvoiceDate, "yyyy-MM-dd") + "', '" + _taxNumber + "','" + Strings.Format(_taxInvoiceDate, "yyyy-MM-dd") + "'," + Conversions.ToString(_invoiceCode) + "," + Module1.unformatNumber(Conversions.ToString(_totalPrice)) + ", " + Module1.unformatNumber(Conversions.ToString(_totalReturn)) + "," + Module1.unformatNumber(Conversions.ToString(_discount)) + "," + Module1.unformatNumber(Conversions.ToString(_deduction)) + "," + Module1.unformatNumber(Conversions.ToString(_totalPayment)) + ",'','" + Strings.Format(PaidDate, "yyyy-MM-dd") + "'," + Conversions.ToString(_isReturn) + ",'" + Strings.Format(DateAndTime.Now, "yyyy-MM-dd") + "'," + Conversions.ToString(_supplierId) + "," + Conversions.ToString(_currencyId) + "," + Module1.unformatNumber(Conversions.ToString(_currencyRate)) + "," + Conversions.ToString(_storageId) + "," + Conversions.ToString(_isTaxIncluded) + ")";
							Module1.sqlNonQuery(strSql, "data");
							_id = cDatabase.LastId("data");
						}
						else
						{
							strSql = " UPDATE purchaseinvoices  SET invNumber = '" + _number + "', invDate = '" + Strings.Format(_invoiceDate, "yyyy-MM-dd") + "',  invTaxNumber = '" + _taxNumber + "', invTaxDate = '" + Strings.Format(_taxInvoiceDate, "yyyy-MM-dd") + "',  invIsTaxIncluded = " + Conversions.ToString(_isTaxIncluded) + ", invCode = " + Conversions.ToString(_invoiceCode) + ", invTotal = " + Module1.unformatNumber(Conversions.ToString(_totalPrice)) + ", invReturn = " + Module1.unformatNumber(Conversions.ToString(_totalReturn)) + ", invDiscount = " + Module1.unformatNumber(Conversions.ToString(_discount)) + ", invDeduction = " + Module1.unformatNumber(Conversions.ToString(_deduction)) + ", invPayment = " + Module1.unformatNumber(Conversions.ToString(_totalPayment)) + ", invDatePaid = '" + Strings.Format(_paidDate, "yyyy-MM-dd") + "', invIsReturn = " + Conversions.ToString(_isReturn) + ", supId = " + Conversions.ToString(_supplierId) + ", currencyId = " + Conversions.ToString(_currencyId) + ", currencyRate = " + Module1.unformatNumber(Conversions.ToString(_currencyRate)) + ", storageId = " + Conversions.ToString(_storageId) + " WHERE invId = " + Conversions.ToString(_id);
							Module1.sqlNonQuery(strSql, "data");
							if (Module1.pubActivateDailyStockCode)
							{
								int num3 = _currentItem.Length - 1;
								for (int i = 0; i <= num3; i++)
								{
									if (_currentItem[i].RiId == 0.0)
									{
										cDailyStock.add(_currentItem[i].ItemId, _currentItem[i].StorageId, _currentDate, Conversions.ToDouble(Interaction.IIf(_isReturn == 0, _currentItem[i].StockQty * -1.0, _currentItem[i].StockQty)));
									}
								}
							}
							strSql = " DELETE FROM purchaseinvoices_items  WHERE invId = " + Conversions.ToString(_id);
							Module1.sqlNonQuery(strSql, "data");
							strSql = " DELETE FROM chequesout  WHERE payId IN (SELECT payId FROM purchaseinvoices_payments  WHERE mpayId = 0 AND invId = " + Conversions.ToString(_id) + ")";
							Module1.sqlNonQuery(strSql, "data");
							strSql = " DELETE FROM purchaseinvoices_payments  WHERE mpayId = 0  AND invId = " + Conversions.ToString(_id);
							Module1.sqlNonQuery(strSql, "data");
							strSql = " SELECT * FROM purchaseinvoices  WHERE invId IN  (SELECT invReturnId FROM purchaseinvoices_returns  WHERE invId = " + Conversions.ToString(_id) + ")";
							DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
							IEnumerator enumerator = dataTable.Rows.GetEnumerator();
							while (enumerator.MoveNext())
							{
								DataRow dataRow = (DataRow)enumerator.Current;
								strSql = Conversions.ToString(Operators.ConcatenateObject(" UPDATE purchaseinvoices  SET invPayment = 0  WHERE invId = ", dataRow["invId"]));
								Module1.sqlNonQuery(strSql, "data");
								strSql = Conversions.ToString(Operators.ConcatenateObject(" DELETE FROM purchaseinvoices_payments  WHERE invId = ", dataRow["invId"]));
								Module1.sqlNonQuery(strSql, "data");
							}
							if (enumerator is IDisposable)
							{
								(enumerator as IDisposable).Dispose();
							}
							strSql = " DELETE FROM purchaseinvoices_returns  WHERE invId = " + Conversions.ToString(_id);
							Module1.sqlNonQuery(strSql, "data");
							strSql = " DELETE FROM journal  WHERE journalType = 1  AND fkeyId = " + Conversions.ToString(_id);
							Module1.sqlNonQuery(strSql, "data");
						}
						cPurchaseInvoiceItem[] item = _item;
						foreach (cPurchaseInvoiceItem cPurchaseInvoiceItem2 in item)
						{
							strSql = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" INSERT INTO purchaseinvoices_items  (iiQty, iiMainQty, iiPrice,  iiParkedQty, iiAgreedQty, iiDeduction,  iiExtraPrice, iiNetQty, invId,  itemId, storeId,riId,  riItemId, currencyId, currencyRate,  unitName, iiDescription) VALUES  ( " + Module1.unformatNumber(Conversions.ToString(cPurchaseInvoiceItem2.InvoiceQty)) + "," + Module1.unformatNumber(Conversions.ToString(cPurchaseInvoiceItem2.StockQty)) + "," + Module1.unformatNumber(Conversions.ToString(cPurchaseInvoiceItem2.Price)) + "," + Module1.unformatNumber(Conversions.ToString(cPurchaseInvoiceItem2.ParkedQty)) + ", " + Module1.unformatNumber(Conversions.ToString(cPurchaseInvoiceItem2.InvoiceQty - cPurchaseInvoiceItem2.ParkedQty)) + "," + Module1.unformatNumber(Conversions.ToString(cPurchaseInvoiceItem2.Deduction)) + "," + Module1.unformatNumber(Conversions.ToString(cPurchaseInvoiceItem2.ExtraPrice)) + "," + Module1.unformatNumber(Conversions.ToString(cPurchaseInvoiceItem2.NetQty)) + "," + Conversions.ToString(_id) + "," + Conversions.ToString(cPurchaseInvoiceItem2.ItemId) + "," + Conversions.ToString(_storageId) + ",", Interaction.IIf(cPurchaseInvoiceItem2.RiId == 0.0, "NULL", cPurchaseInvoiceItem2.RiId)), ","), cPurchaseInvoiceItem2.RiItemId), ","), cPurchaseInvoiceItem2.CurrencyId), ","), Module1.unformatNumber(Conversions.ToString(cPurchaseInvoiceItem2.CurrencyRate))), ","), "'"), cPurchaseInvoiceItem2.UnitName), "','"), cPurchaseInvoiceItem2.Description), "')"));
							Module1.sqlNonQuery(strSql, "data");
							if (Module1.pubActivateDailyStockCode && cPurchaseInvoiceItem2.RiId == 0.0)
							{
								cDailyStock.add(cPurchaseInvoiceItem2.ItemId, _storageId, _invoiceDate, Conversions.ToDouble(Interaction.IIf(_isReturn == 0, cPurchaseInvoiceItem2.StockQty, cPurchaseInvoiceItem2.StockQty * -1.0)));
							}
						}
						cPurchaseInvoicePayment[] payment = _payment;
						foreach (cPurchaseInvoicePayment cPurchaseInvoicePayment2 in payment)
						{
							if (cPurchaseInvoicePayment2.MultiPaymentId == 0.0)
							{
								DateTime dateTime = ((DateTime.Compare(cPurchaseInvoicePayment2.CreatedDate, DateTime.MinValue) != 0) ? cPurchaseInvoicePayment2.CreatedDate : DateAndTime.Now);
								strSql = " INSERT INTO purchaseinvoices_payments  (payDate, payAmount, pcId,  payInFront, mpayId, invId,  accountId, currencyRate,payCreated)  VALUES  ('" + Strings.Format(cPurchaseInvoicePayment2.PaymentDate, "yyyy-MM-dd") + "'," + Module1.unformatNumber(Conversions.ToString((_isReturn == 1) ? (cPurchaseInvoicePayment2.Amount * -1.0) : cPurchaseInvoicePayment2.Amount)) + "," + Conversions.ToString(cPurchaseInvoicePayment2.PaymentCodeId) + "," + Conversions.ToString(cPurchaseInvoicePayment2.InFront) + ",0," + Conversions.ToString(_id) + "," + Conversions.ToString(cPurchaseInvoicePayment2.AccountId) + "," + Module1.unformatNumber(Conversions.ToString(cPurchaseInvoicePayment2.CurrencyRate)) + ",'" + Strings.Format(dateTime, "yyyy-MM-dd") + "')";
								Module1.sqlNonQuery(strSql, "data");
								cPurchaseInvoicePayment2.PaymentId = cDatabase.LastId("data");
								if (Operators.CompareString(cPurchaseInvoicePayment2.PaymentCodeName, "C/G", TextCompare: false) == 0)
								{
									strSql = " INSERT INTO chequesOut(cheqNumber,cheqDate,bankId,  payId, mpayId) VALUES  ('" + cPurchaseInvoicePayment2.ChequeNumber + "','" + Strings.Format(cPurchaseInvoicePayment2.ChequeDate, "yyyy-MM-dd") + "',0," + Conversions.ToString(cPurchaseInvoicePayment2.PaymentId) + ",0)";
									Module1.sqlNonQuery(strSql, "data");
								}
							}
						}
						if (_isReturn == 0)
						{
							cPurchaseInvoiceReturn[] invoiceReturn = _invoiceReturn;
							foreach (cPurchaseInvoiceReturn cPurchaseInvoiceReturn2 in invoiceReturn)
							{
								strSql = " INSERT INTO purchaseinvoices_returns(invId, invReturnId) VALUES (" + Conversions.ToString(_id) + "," + Conversions.ToString(cPurchaseInvoiceReturn2.Id) + ")";
								Module1.sqlNonQuery(strSql, "data");
								strSql = " UPDATE purchaseinvoices  SET invPayment = " + Conversions.ToString(cPurchaseInvoiceReturn2.Amount * -1.0) + " WHERE invId = " + Conversions.ToString(cPurchaseInvoiceReturn2.Id);
								Module1.sqlNonQuery(strSql, "data");
							}
						}
						int[] array = null;
						double[] array2 = null;
						int num4 = 0;
						double num5 = ((!(_totalPrice > 0.0)) ? 0.0 : (_discount / _totalPrice));
						cPurchaseInvoiceItem[] item2 = _item;
						foreach (cPurchaseInvoiceItem cPurchaseInvoiceItem3 in item2)
						{
							if (!Information.IsNothing(array) && array.Contains(cPurchaseInvoiceItem3.InventoryAccountId))
							{
								int num6 = array.Count() - 1;
								for (int i = 0; i <= num6; i++)
								{
									if (array[i] == cPurchaseInvoiceItem3.InventoryAccountId)
									{
										double num7 = cPurchaseInvoiceItem3.NetQty * (cPurchaseInvoiceItem3.Price + cPurchaseInvoiceItem3.ExtraPrice);
										double num8 = num7 * num5;
										array2[i] += num7 - num8;
									}
								}
							}
							else
							{
								array = (int[])Utils.CopyArray(array, new int[num4 + 1]);
								array2 = (double[])Utils.CopyArray(array2, new double[num4 + 1]);
								array[num4] = cPurchaseInvoiceItem3.InventoryAccountId;
								double num7 = cPurchaseInvoiceItem3.NetQty * (cPurchaseInvoiceItem3.Price + cPurchaseInvoiceItem3.ExtraPrice);
								double num8 = num7 * num5;
								array2[num4] = num7 - num8;
								num4++;
							}
						}
						int accountPayableId = cCurrency.GetAccountPayableId(_currencyId);
						strSql = " INSERT INTO journal(journalDate,journalDescription,journalType,fkeyId)  VALUES ('" + Strings.Format(_invoiceDate, "yyyy-MM-dd") + "','Faktur Pembelian: " + _number + "',1," + Conversions.ToString(_id) + ")";
						Module1.sqlNonQuery(strSql, "data");
						double num9 = cDatabase.LastId("data");
						int num10 = num4 - 1;
						for (int i = 0; i <= num10; i++)
						{
							strSql = " INSERT INTO journalDetail(journalDebitCredit,journalAmount,accountId,journalId)  VALUES (1," + Module1.unformatNumber(Conversions.ToString(array2[i])) + "," + Conversions.ToString(array[i]) + "," + Conversions.ToString(num9) + ")";
							Module1.sqlNonQuery(strSql, "data");
							strSql = " INSERT INTO journalDetail(journalDebitCredit,journalAmount,accountId,journalId)  VALUES (2," + Module1.unformatNumber(Conversions.ToString(array2[i])) + "," + Conversions.ToString(accountPayableId) + "," + Conversions.ToString(num9) + ")";
							Module1.sqlNonQuery(strSql, "data");
						}
						cPurchaseInvoicePayment[] payment2 = _payment;
						foreach (cPurchaseInvoicePayment cPurchaseInvoicePayment3 in payment2)
						{
							strSql = " INSERT INTO journal(journalDate,journalDescription,journalType,fkeyId)  VALUES ('" + Strings.Format(cPurchaseInvoicePayment3.PaymentDate, "yyyy-MM-dd") + "','Pembayaran Faktur Pembelian: " + _number + "',1," + Conversions.ToString(_id) + ")";
							Module1.sqlNonQuery(strSql, "data");
							num9 = cDatabase.LastId("data");
							if (cPurchaseInvoicePayment3.MultiPaymentId == 0.0)
							{
								strSql = " INSERT INTO journalDetail(journalDebitCredit,journalAmount,accountId,journalId)  VALUES (1," + Module1.unformatNumber(Conversions.ToString(cPurchaseInvoicePayment3.Amount)) + "," + Conversions.ToString(accountPayableId) + "," + Conversions.ToString(num9) + ")";
								Module1.sqlNonQuery(strSql, "data");
								strSql = " INSERT INTO journalDetail(journalDebitCredit,journalAmount,accountId,journalId)  VALUES (2," + Module1.unformatNumber(Conversions.ToString(cPurchaseInvoicePayment3.Amount)) + "," + Conversions.ToString(cPurchaseInvoicePayment3.AccountId) + "," + Conversions.ToString(num9) + ")";
								Module1.sqlNonQuery(strSql, "data");
							}
						}
						val.Commit();
						goto end_IL_0001;
					}
					case 4447:
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
					goto IL_1195;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 4447;
				continue;
			}
			break;
			IL_1195:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public void Delete()
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
				checked
				{
					switch (try0001_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						val = Module1.connectData.BeginTransaction();
						string strSql = " DELETE FROM purchaseinvoices  WHERE invId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						if (Module1.pubActivateDailyStockCode)
						{
							int num3 = _currentItem.Length - 1;
							for (int i = 0; i <= num3; i++)
							{
								if (_currentItem[i].RiId == 0.0)
								{
									cDailyStock.add(_currentItem[i].ItemId, _currentItem[i].StorageId, _currentDate, Conversions.ToDouble(Interaction.IIf(_isReturn == 0, _currentItem[i].StockQty * -1.0, _currentItem[i].StockQty)));
								}
							}
						}
						strSql = " DELETE FROM purchaseinvoices_items  WHERE invId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " SELECT * FROM purchaseinvoices  WHERE invId IN (  SELECT invReturnId FROM purchaseinvoices_returns  WHERE invid = " + Conversions.ToString(Id) + ")";
						DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
						IEnumerator enumerator = dataTable.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							strSql = Conversions.ToString(Operators.ConcatenateObject(" UPDATE purchaseinvoices  SET invPayment = 0  WHERE invId = ", dataRow["invId"]));
							Module1.sqlNonQuery(strSql, "data");
							strSql = Conversions.ToString(Operators.ConcatenateObject(" DELETE FROM purchaseinvoices_payments  WHERE invId = ", dataRow["invId"]));
							Module1.sqlNonQuery(strSql, "data");
						}
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
						strSql = " DELETE FROM purchaseinvoices_returns  WHERE invId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " DELETE FROM purchaseinvoices WHERE invId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " DELETE FROM chequesout  WHERE payId IN (  SELECT payId FROM purchaseinvoices_payments  WHERE invId = " + Conversions.ToString(_id) + ")";
						Module1.sqlNonQuery(strSql, "data");
						strSql = " DELETE FROM purchaseinvoices_payments  WHERE invId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						if (_isReturn == 1)
						{
							double num4 = Conversion.Val(Strings.Right(_number, 8));
							strSql = " INSERT INTO fakturDeleted(fs,fdType,fakturYear,branchId) VALUES(" + Conversions.ToString(num4) + ",4," + Conversions.ToString(DateAndTime.Year(_invoiceDate)) + ",0)";
							Module1.sqlNonQuery(strSql, "data");
						}
						val.Commit();
						goto end_IL_0001;
					}
					case 821:
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
					goto IL_036b;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 821;
				continue;
			}
			break;
			IL_036b:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static DataTable Search(int intRange, DateTime dateFirst, DateTime dateLast, int ItemId, int SupplierId, string InvoiceNumber, int InvoiceCode, int InvoiceType, int GroupId, int BranchId, int SupplierHasNPWP, int PaymentStatus, bool ShowPrice)
	{
		string text = " SELECT invId, invDate, invTaxDate,  invNumber, invTaxNumber, supName,  IF(invCode=0,'T','K') as invCode, invTotal, invReturn,  invDiscount, invPayment, invDeduction,  (invTotal-invReturn-invDiscount-invDeduction-invPayment) as invPayable,  IF(invTotal-invReturn-invDiscount-invDeduction-invPayment=0, 0, DATEDIFF(CURDATE(),invDate)) as invPayableDays,  invIsReturn, 0 as type, invDate as origDate  FROM purchaseInvoices a, suppliers b  WHERE a.supId = b.supId ";
		switch (intRange)
		{
		case 1:
			text = text + " AND invDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND invDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
			break;
		case 3:
			text = text + " AND invTaxDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND invTaxDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "' AND invTaxNumber <> '' ";
			break;
		case 4:
			text = text + " AND invNumber like '%" + InvoiceNumber + "%'";
			break;
		case 5:
			text = text + " AND invTaxNumber like '%" + InvoiceNumber + "%'";
			break;
		}
		switch (InvoiceCode)
		{
		case 0:
			text += " AND invCode = 0 ";
			break;
		case 1:
			text += " AND invCode = 1 ";
			break;
		}
		switch (PaymentStatus)
		{
		case 1:
			text += " AND invTotal-invReturn-invDiscount-invDeduction-invPayment <= 0 ";
			break;
		case 2:
			text += " AND invTotal-invReturn-invDiscount-invDeduction-invPayment > 0 ";
			break;
		}
		if (!ShowPrice)
		{
			text += " AND invTotal = 0 ";
		}
		if (ItemId > 0)
		{
			text = text + " AND invId IN (SELECT invId FROM purchaseinvoices_items WHERE itemId = " + Conversions.ToString(ItemId) + ")";
		}
		if (SupplierId > 0)
		{
			text = text + " AND b.supId IN (SELECT supId FROM suppliers WHERE supId = " + Conversions.ToString(SupplierId) + " OR supParentId = " + Conversions.ToString(SupplierId) + ")";
		}
		if (GroupId > 0)
		{
			text = text + " AND b.supId IN  (SELECT supId FROM groups_suppliers   WHERE groupId = " + Conversions.ToString(GroupId) + ")";
		}
		switch (SupplierHasNPWP)
		{
		case 0:
			text += " AND b.supId IN  (SELECT supId FROM suppliers WHERE supNPWP='') ";
			break;
		case 1:
			text += " AND b.supId IN  (SELECT supId FROM suppliers WHERE supNPWP<>'') ";
			break;
		}
		switch (InvoiceType)
		{
		case 0:
			text += " AND invIsReturn = 0 ";
			break;
		case 1:
			text += " AND invIsReturn = 1 ";
			break;
		}
		text = ((intRange == 2) ? (text + " ORDER BY invId DESC LIMIT 100 ") : ((intRange == 3 || intRange == 5) ? (text + " ORDER BY invTaxDate ") : ((intRange != 6) ? (text + " ORDER BY invDate ") : (text + " ORDER BY invDate DESC"))));
		return Module1.sqlTable(text, "data", Clone: false);
	}

	public static DataTable SearchItem(DateTime dateFirst, DateTime dateLast, int SupplierId, int InvoiceType, int SearchType, int ItemCategoryId, int ItemId, int GroupId)
	{
		string text = ((SearchType != 1) ? " SELECT 0 as invId, CURDATE() as invDate, '' as invNumber,  supName, itemName, SUM(iiMainQty) as qty, 1 as orderBy " : " SELECT a.invId, invDate, invNumber,  supName, itemName, iiMainQty as qty, 0 as orderBy ");
		string text2 = " FROM purchaseInvoices a, purchaseInvoices_items b, suppliers c, items d, produk e  WHERE a.supId = c.supId  AND a.invId = b.invId  AND b.itemId = d.itemId  AND d.itemId = e.prodId  AND invDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND invDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
		text2 = ((ItemId > 0) ? (text2 + " AND d.itemId = " + Conversions.ToString(ItemId)) : ((ItemCategoryId <= 0) ? (text2 + " AND e.catId IN (SELECT catId FROM group_itemcategory WHERE groupId = " + Conversions.ToString(GroupId) + ")") : (text2 + " AND e.catId = " + Conversions.ToString(ItemCategoryId))));
		if (SupplierId > 0)
		{
			text2 = text2 + " AND c.supId IN (SELECT supId FROM suppliers WHERE supId = " + Conversions.ToString(SupplierId) + " OR supParentId = " + Conversions.ToString(SupplierId) + ")";
		}
		if (GroupId > 0)
		{
			text2 = text2 + " AND c.supId IN  (SELECT supId FROM groups_suppliers   WHERE groupId = " + Conversions.ToString(GroupId) + ")";
		}
		switch (InvoiceType)
		{
		case 0:
			text2 += " AND invIsReturn = 0 ";
			break;
		case 1:
			text2 += " AND invIsReturn = 1 ";
			break;
		}
		text += text2;
		if (SearchType == 2)
		{
			text += " GROUP BY supName,itemName ";
		}
		text += " UNION ALL ";
		text += " SELECT 0, NOW(), '',  '', itemName, SUM(iiMainQty) as qty, 2 as orderBy ";
		text += text2;
		text += " GROUP BY itemName ";
		text = ((SearchType != 1) ? (text + " ORDER BY orderBy, supName,itemName ") : (text + " ORDER BY orderBy, invDate, invId, itemName "));
		return Module1.sqlTable(text, "data", Clone: false);
	}

	public static DataTable dtUnpaid(int SupplierId, int GroupId)
	{
		string strSql = " SELECT invId, invNumber,invDate, invTotal-invReturn-invDiscount-invDeduction-invPayment as invPayable  FROM purchaseinvoices  WHERE invTotal-invReturn-invDiscount-invDeduction-invPayment > 0  AND supId IN (SELECT supId FROM suppliers WHERE supParentId = " + Conversions.ToString(SupplierId) + " OR supId = " + Conversions.ToString(SupplierId) + ") AND supId IN  (SELECT supId FROM groups_suppliers   WHERE groupId = " + Conversions.ToString(GroupId) + ") ORDER BY invDate DESC ";
		return Module1.sqlTable(strSql, "data", Clone: false);
	}

	public static double GetSupplierBalance(DateTime FirstBalanceDate, DateTime BalanceDate, int SupplierId)
	{
		string text = "SELECT supUnpaid FROM suppliers";
		if (SupplierId > 0)
		{
			text = text + " WHERE supId = " + Conversions.ToString(SupplierId);
		}
		DataTable dataTable = Module1.sqlTable(text, "data", Clone: false);
		double num = default(double);
		if (dataTable.Rows.Count > 0)
		{
			num = Conversions.ToDouble(Operators.AddObject(num, dataTable.Rows[0]["supUnpaid"]));
		}
		text = " SELECT SUM(invTotal) as total  FROM purchaseinvoices  WHERE invDate < '" + Strings.Format(BalanceDate, "yyyy-MM-dd") + "' AND invDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "'";
		if (SupplierId > 0)
		{
			text = text + " AND supId = " + Conversions.ToString(SupplierId);
		}
		dataTable = Module1.sqlTable(text, "data", Clone: false);
		if (dataTable.Rows.Count > 0 && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["total"])))
		{
			num = Conversions.ToDouble(Operators.AddObject(num, dataTable.Rows[0]["total"]));
		}
		text = " SELECT SUM(payAmount) as totalPaid  FROM purchaseinvoices_payments a,purchaseinvoices b  WHERE payDate < '" + Strings.Format(BalanceDate, "yyyy-MM-dd") + "' AND payDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "' AND a.invId = b.invId  AND mpayId = 0";
		if (SupplierId > 0)
		{
			text = text + " AND b.supId = " + Conversions.ToString(SupplierId);
		}
		dataTable = Module1.sqlTable(text, "data", Clone: false);
		if (dataTable.Rows.Count > 0 && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["totalPaid"])))
		{
			num = Conversions.ToDouble(Operators.SubtractObject(num, dataTable.Rows[0]["totalPaid"]));
		}
		text = " SELECT SUM(mpayAmount) as totalPaid  FROM purchaseinvoices_multipayments  WHERE mpayDate < '" + Strings.Format(BalanceDate, "yyyy-MM-dd") + "' AND mpayDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "'";
		if (SupplierId > 0)
		{
			text = text + " AND supId = " + Conversions.ToString(SupplierId);
		}
		dataTable = Module1.sqlTable(text, "data", Clone: false);
		if (dataTable.Rows.Count > 0 && !Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["totalPaid"])))
		{
			num = Conversions.ToDouble(Operators.SubtractObject(num, dataTable.Rows[0]["totalPaid"]));
		}
		return num;
	}

	public static DataTable SearchTransaction(DateTime FirstBalanceDate, DateTime dateFirst, DateTime dateLast, int SupplierId)
	{
		string text = " SELECT a.invDate as transactionDate, c.itemName as description,iiQty, iiParkedQty, iiAgreedQty, iiDeduction,  iiNetQty,iiPrice,iiExtraPrice,  (iiNetQty * (iiPrice + iiExtraPrice)) as iiTotal,0 as mpayInFront,0 as mpayAmount,  0 as balance,a.invId as id,3 as type,  1 as orderBy  FROM purchaseinvoices a, purchaseinvoices_items b, items c  WHERE a.invId = b.invId  AND b.itemId = c.itemId  AND invIsReturn = 0  AND invDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND invDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
		if (SupplierId > 0)
		{
			text = text + " AND supId = " + Conversions.ToString(SupplierId);
		}
		text = text + " UNION ALL SELECT a.invDate as transactionDate, c.itemName as description,iiQty*-1,  iiParkedQty*-1, iiAgreedQty*-1, iiDeduction*-1,  iiNetQty*-1,iiPrice,iiExtraPrice,  (iiNetQty * (iiPrice + iiExtraPrice))*-1 as iiTotal,0 as mpayInFront,0 as mpayAmount,  0 as balance,a.invId as id,5 as type,  1 as orderBy  FROM purchaseinvoices a, purchaseinvoices_items b, items c  WHERE a.invId = b.invId  AND b.itemId = c.itemId  AND invIsReturn = 1  AND invDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND invDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
		if (SupplierId > 0)
		{
			text = text + " AND supId = " + Conversions.ToString(SupplierId);
		}
		text = text + " UNION ALL SELECT a.invDate as transactionDate, 'Discount' as description,0,  0,0,0,  0,0,0,  invDiscount*-1 as iiTotal,0, 0,  0 as balance,a.invId as id,4 as type,  1 as orderBy  FROM purchaseinvoices a  WHERE invDiscount <> 0  AND invDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND invDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
		if (SupplierId > 0)
		{
			text = text + " AND supId = " + Conversions.ToString(SupplierId);
		}
		text = text + " UNION ALL SELECT a.invDate as transactionDate, 'Potongan Pembayaran' as description,0,  0,0,0,  0,0,0,  invDeduction*-1 as iiTotal,0, 0,  0 as balance,a.invId as id,4 as type,  1 as orderBy  FROM purchaseinvoices a  WHERE invDiscount <> 0  AND invDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND invDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
		if (SupplierId > 0)
		{
			text = text + " AND supId = " + Conversions.ToString(SupplierId);
		}
		text = text + " UNION ALL SELECT mpayDate as transactionDate,'Pembayaran',0,  0,0,0,  0,0,0,  0,0,mpayAmount,  0,mpayId as id,1,  1 as orderBy  FROM purchaseinvoices_multipayments  WHERE mpayInFront = 0  AND mpayDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND mpayDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
		if (SupplierId > 0)
		{
			text = text + " AND supId = " + Conversions.ToString(SupplierId);
		}
		text = text + " UNION ALL SELECT payDate as transactionDate,'Pembayaran',0,  0,0,0,  0,0,0,  0,0,payAmount,  0,b.invId,2,  1 as orderBy  FROM purchaseinvoices_payments a,purchaseinvoices b  WHERE payInFront = 0  AND a.invId = b.invId  AND mpayId = 0  AND payDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND payDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
		if (SupplierId > 0)
		{
			text = text + " AND b.supId = " + Conversions.ToString(SupplierId);
		}
		text = text + " UNION ALL SELECT mpayDate as transactionDate,'Pembayaran',0,  0,0,0,  0,0,0,   0,mpayAmount,0, 0,mpayId as id,1,  1 as orderBy  FROM purchaseinvoices_multipayments  WHERE mpayInFront = 1  AND mpayDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND mpayDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
		if (SupplierId > 0)
		{
			text = text + " AND supId = " + Conversions.ToString(SupplierId);
		}
		text = text + " UNION ALL SELECT payDate as transactionDate,'Pembayaran',0,  0,0,0,  0,0,0,  0,payAmount,0,  0,b.invId,2,  1 as orderBy  FROM purchaseinvoices_payments a, purchaseinvoices b  WHERE payInFront = 1  AND a.invId = b.invId  AND mpayId = 0  AND payDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND payDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
		if (SupplierId > 0)
		{
			text = text + " AND b.supId = " + Conversions.ToString(SupplierId);
		}
		double supplierBalance = GetSupplierBalance(FirstBalanceDate, dateFirst, SupplierId);
		text = text + " UNION ALL SELECT NOW(0),'Saldo Awal',0,  0,0,0,   0,0,0,  " + Conversions.ToString(supplierBalance) + ",0,0, " + Conversions.ToString(supplierBalance) + ",0,0,  0 as orderBy ";
		text = text + " UNION ALL SELECT NOW(), c.itemName as description,0, 0,0,0,  SUM(iiNetQty),0,0,  SUM((iiNetQty * (iiPrice + iiExtraPrice))) as iiTotal,0,0,  0 as balance,0,99 as type,  2 as orderBy   FROM purchaseinvoices a, purchaseinvoices_items b, items c  WHERE a.invId = b.invId  AND b.itemId = c.itemId  AND invDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND invDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
		if (SupplierId > 0)
		{
			text = text + " AND supId = " + Conversions.ToString(SupplierId);
		}
		text += " GROUP BY itemName  ORDER BY orderBy,transactionDate,type,description ";
		return Module1.sqlTable(text, "data", Clone: false);
	}

	private string GenerateNewNumber()
	{
		string text = "";
		string strSql = " select * from fakturDeleted  where fdType = 4  and FakturYear = " + Conversions.ToString(DateAndTime.Year(_invoiceDate)) + "  order by fs ";
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			text = "BS" + Conversions.ToDouble(dataTable.Rows[0]["fs"]).ToString("00000000");
			double num = Conversions.ToDouble(dataTable.Rows[0]["fdId"]);
			strSql = " SELECT invNumber  FROM purchaseinvoices  WHERE invNumber = '" + text + "'  AND YEAR(invDate) = " + Conversions.ToString(DateAndTime.Year(_invoiceDate)) + " AND invIsReturn = 1";
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count == 0)
			{
				strSql = " DELETE FROM fakturDeleted  WHERE fdId = " + Conversions.ToString(num);
				Module1.sqlNonQuery(strSql, "data");
				goto IL_0278;
			}
		}
		strSql = " SELECT * FROM fakturLatest  WHERE fakturYear = " + Conversions.ToString(DateAndTime.Year(_invoiceDate)) + " AND fakturType = 4 ";
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		double num2 = ((dataTable.Rows.Count <= 0) ? 0.0 : Conversion.Val(Strings.Right(Conversions.ToString(dataTable.Rows[0]["fakturLatestNo"]), 8)));
		bool flag = default(bool);
		while (!flag)
		{
			num2 += 1.0;
			text = "BS" + num2.ToString("00000000");
			strSql = " SELECT invNumber  FROM purchaseinvoices  WHERE invNumber = '" + text + "'  AND YEAR(invDate) = " + Conversions.ToString(DateAndTime.Year(_invoiceDate)) + " AND invIsReturn = 1";
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count == 0)
			{
				strSql = " UPDATE fakturLatest  SET fakturLatestNo = " + Conversions.ToString(num2) + " WHERE fakturYear = " + Conversions.ToString(DateAndTime.Year(_invoiceDate)) + " AND fakturType = 4 ";
				Module1.sqlNonQuery(strSql, "data");
				flag = true;
			}
		}
		goto IL_0278;
		IL_0278:
		return text;
	}

	public static DataTable GetUnpaidReturn(int SupplierId)
	{
		string strSql = " SELECT invId, invDate, invNumber, invReturn+invDiscount+invDeduction+invPayment as invReceivable FROM purchaseinvoices  WHERE invReturn + invDiscount + invDeduction + invPayment > 0  AND invId NOT IN (SELECT invId FROM purchaseinvoices_payments)  AND invIsReturn = 1  AND supId = " + Conversions.ToString(SupplierId) + " ORDER BY invDate ";
		return Module1.sqlTable(strSql, "data", Clone: false);
	}
}
