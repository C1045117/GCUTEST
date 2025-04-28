using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace GCUv2;

public class cSalesInvoice
{
	private double _id;

	private double _customerId;

	private double _customerParentId;

	private string _customerName;

	private string _customerAddress;

	private string _customerPT;

	private string _customerNPWP;

	private string _customerTaxAddress;

	private int _customerUnpaidLimit;

	private int _discountId;

	private int _salesPersonId;

	private DateTime _invoiceDate;

	private DateTime _taxInvoiceDate;

	private string _number;

	private double _taxNumber;

	private int _invoiceCode;

	private double _discount;

	private string _discountDescription;

	private double _deduction;

	private int _useOldPrice;

	private cSalesInvoiceItem[] _item;

	private cSalesInvoiceItem[] _currentItem;

	private DateTime _currentDate;

	private int _currentStorage;

	private cSalesInvoicePayment[] _payment;

	private cSalesInvoiceReturn[] _invoiceReturn;

	private double _totalPrice;

	private double _totalBasePrice;

	private double _totalReturn;

	private double _totalPayment;

	private double _dpp;

	private double _ppn;

	private DateTime _paidDate;

	private int _isReturn;

	private DateTime _createdDate;

	private string _note;

	private int _tukarFaktur;

	private DateTime _tukarFakturDate;

	private int _storageId;

	private int _branchId;

	private double _parentInvoiceId;

	private string _parentInvoiceNumber;

	private int _cashAccountId;

	private int _bankAccountId;

	private string _cashAccountName;

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

	public double CustomerParentId
	{
		get
		{
			return _customerParentId;
		}
		set
		{
			_customerParentId = value;
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

	public string CustomerPT
	{
		get
		{
			return _customerPT;
		}
		set
		{
			_customerPT = value;
		}
	}

	public string CustomerNPWP
	{
		get
		{
			return _customerNPWP;
		}
		set
		{
			_customerNPWP = value;
		}
	}

	public string CustomerTaxAddress
	{
		get
		{
			return _customerTaxAddress;
		}
		set
		{
			_customerTaxAddress = value;
		}
	}

	public int CustomerUnpaidLimit
	{
		get
		{
			return _customerUnpaidLimit;
		}
		set
		{
			_customerUnpaidLimit = value;
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

	public int SalesPersonId
	{
		get
		{
			return _salesPersonId;
		}
		set
		{
			_salesPersonId = value;
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

	public double TaxNumber
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

	public int UseOldPrice
	{
		get
		{
			return _useOldPrice;
		}
		set
		{
			_useOldPrice = value;
		}
	}

	public cSalesInvoiceItem[] Item
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

	public cSalesInvoicePayment[] Payment
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

	public cSalesInvoiceReturn[] InvoiceReturn
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

	public double TotalBasePrice
	{
		get
		{
			return _totalBasePrice;
		}
		set
		{
			_totalBasePrice = value;
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

	public double Dpp
	{
		get
		{
			return _dpp;
		}
		set
		{
			_dpp = value;
		}
	}

	public double Ppn
	{
		get
		{
			return _ppn;
		}
		set
		{
			_ppn = value;
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

	public string Note
	{
		get
		{
			return _note;
		}
		set
		{
			_note = Module1.cleanStringKeepCrlf(value);
		}
	}

	public int TukarFaktur
	{
		get
		{
			return _tukarFaktur;
		}
		set
		{
			_tukarFaktur = value;
		}
	}

	public DateTime TukarFakturDate
	{
		get
		{
			return _tukarFakturDate;
		}
		set
		{
			_tukarFakturDate = value;
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

	public int CashAccountId
	{
		get
		{
			return _cashAccountId;
		}
		set
		{
			_cashAccountId = value;
		}
	}

	public string CashAccountName
	{
		get
		{
			return _cashAccountName;
		}
		set
		{
			_cashAccountName = value;
		}
	}

	public int BankAccountId
	{
		get
		{
			return _bankAccountId;
		}
		set
		{
			_bankAccountId = value;
		}
	}

	public cSalesInvoiceItem[] CurrentItem
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

	public int CurrentStorage
	{
		get
		{
			return _currentStorage;
		}
		set
		{
			_currentStorage = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public cSalesInvoice(double InvId)
	{
		if (!(InvId > 0.0))
		{
			return;
		}
		_id = InvId;
		DataTable dataTable = new DataTable();
		string strSql = " SELECT a.custId, a.salesId, a.penjDate, a.penjDateFp,  a.penjFaktur, a.penjFP, a.penjKode,  a.penjDisc, a.penjDiscDesc, a.penjPot, a.penjOldPrice, a.penjBsType,  a.penjBayar, a.penjCreated, a.storeId as storageId,  a.penjNote, a.penjTF, a.penjDateTF, penjLunas,  d.branchId,  d.custName, d.custAddress, d.custPT,  d.custNPWP, d.custTaxAddress, d.custPiutang,  d.custParentId, d.kgId, d.tgId, d.discId, b.accountName  FROM penjualan a, customer d, account b  WHERE penjId = " + Conversions.ToString(_id) + " AND d.kgId = b.accountId  AND a.custId = d.custId ";
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			_customerId = Conversions.ToDouble(dataTable.Rows[0]["custId"]);
			_customerParentId = Conversions.ToDouble(dataTable.Rows[0]["custParentId"]);
			_customerName = Conversions.ToString(dataTable.Rows[0]["custName"]);
			_customerAddress = Conversions.ToString(dataTable.Rows[0]["custAddress"]);
			_customerPT = Conversions.ToString(dataTable.Rows[0]["custPT"]);
			_customerNPWP = Conversions.ToString(dataTable.Rows[0]["custNPWP"]);
			_customerTaxAddress = Conversions.ToString(dataTable.Rows[0]["custTaxAddress"]);
			_customerUnpaidLimit = Conversions.ToInteger(dataTable.Rows[0]["custPiutang"]);
			_discountId = Conversions.ToInteger(dataTable.Rows[0]["discId"]);
			_salesPersonId = Conversions.ToInteger(dataTable.Rows[0]["salesId"]);
			_invoiceDate = Conversions.ToDate(dataTable.Rows[0]["penjDate"]);
			_taxInvoiceDate = Conversions.ToDate(dataTable.Rows[0]["penjDateFp"]);
			_number = Conversions.ToString(dataTable.Rows[0]["penjFaktur"]);
			_taxNumber = Conversions.ToDouble(dataTable.Rows[0]["penjFP"]);
			_invoiceCode = Conversions.ToInteger(dataTable.Rows[0]["penjKode"]);
			_isReturn = Conversions.ToInteger(Interaction.IIf(Operators.ConditionalCompareObjectEqual(dataTable.Rows[0]["penjBsType"], 0, TextCompare: false), 0, 1));
			_discount = Conversions.ToDouble(dataTable.Rows[0]["penjDisc"]);
			_discountDescription = Conversions.ToString(dataTable.Rows[0]["penjDiscDesc"]);
			_deduction = Conversions.ToDouble(dataTable.Rows[0]["penjPot"]);
			_useOldPrice = Conversions.ToInteger(dataTable.Rows[0]["penjOldPrice"]);
			_totalPayment = Conversions.ToDouble(dataTable.Rows[0]["penjBayar"]);
			_createdDate = Conversions.ToDate(dataTable.Rows[0]["penjCreated"]);
			_storageId = Conversions.ToInteger(dataTable.Rows[0]["storageId"]);
			_note = Conversions.ToString(dataTable.Rows[0]["penjNote"]);
			_tukarFaktur = Conversions.ToInteger(dataTable.Rows[0]["penjTf"]);
			_tukarFakturDate = Conversions.ToDate(dataTable.Rows[0]["penjDateTf"]);
			if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["penjLunas"])))
			{
				_paidDate = Conversions.ToDate(dataTable.Rows[0]["penjLunas"]);
			}
			_branchId = Conversions.ToInteger(dataTable.Rows[0]["branchId"]);
			_cashAccountId = Conversions.ToInteger(dataTable.Rows[0]["kgId"]);
			_bankAccountId = Conversions.ToInteger(dataTable.Rows[0]["tgId"]);
			_cashAccountName = Conversions.ToString(dataTable.Rows[0]["accountName"]);
		}
		else
		{
			_id = 0.0;
			Information.Err().Raise(513, null, "Faktur tidak ditemukan. Kemungkinan telah dihapus.");
		}
		if (_isReturn == 1)
		{
			strSql = " SELECT * FROM penjualan  WHERE penjId IN  (SELECT penjId FROM penjbs   WHERE penjBsId = " + Conversions.ToString(_id) + ")";
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				_parentInvoiceId = Conversions.ToDouble(dataTable.Rows[0]["penjId"]);
				_parentInvoiceNumber = Conversions.ToString(dataTable.Rows[0]["penjFaktur"]);
			}
		}
		strSql = " SELECT ppId, ppAmount, ppPrice,  ppPriceOrig, a.prodId, b.prodName,  IF(b.prodTea=1,'Teh GOPEK','') as generalType, b.prodLongName, b.prodBox,  e.unitName AS psSmallName, e.unitQty AS psQty, d.unitName AS psLargeName,  a.soId, IFNULL(so.PONumber,'-----') AS PONumber, a.doId,  IFNULL(CONCAT('DO/',CAST(do.storeId AS CHAR),'/',SUBSTR(YEAR(doDate),3),'/',doNumber),'-----') AS DONumber, ppDescription,  parentItemId  FROM (penjprod a LEFT OUTER JOIN salesOrder so ON a.soId = so.soId) LEFT OUTER JOIN deliveryOrder do ON a.doId = do.doId,  produk b, items d, itemUnit e  WHERE a.prodId = b.prodId  AND b.prodId = d.itemId  AND b.taxInvoiceUnitId = e.unitId  AND a.penjId = " + Conversions.ToString(_id);
		int num = 0;
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		checked
		{
			_item = new cSalesInvoiceItem[dataTable.Rows.Count - 1 + 1];
			foreach (DataRow row in dataTable.Rows)
			{
				_item[num] = new cSalesInvoiceItem();
				_item[num].Id = Conversions.ToDouble(row["ppId"]);
				_item[num].ItemId = Conversions.ToInteger(row["prodId"]);
				_item[num].Description = Strings.Trim(Conversions.ToString(row["ppDescription"]));
				_item[num].Name = Conversions.ToString(row["prodName"]);
				_item[num].GeneralType = Conversions.ToString(row["generalType"]);
				_item[num].LongName = Conversions.ToString(row["prodLongName"]);
				_item[num].Packaging = Conversions.ToString(row["prodBox"]);
				_item[num].Qty = Conversions.ToDouble(row["ppAmount"]);
				_item[num].Price = Conversions.ToDouble(row["ppPrice"]);
				_item[num].BasePrice = Conversions.ToDouble(row["ppPriceOrig"]);
				_item[num].SmallUnit = Conversions.ToString(row["psSmallName"]);
				_item[num].SmallQtyMultiplier = Conversions.ToDouble(row["psQty"]);
				_item[num].LargeUnit = Conversions.ToString(row["psLargeName"]);
				_item[num].SOId = Conversions.ToDouble(row["soId"]);
				_item[num].PONumber = Conversions.ToString(row["PONumber"]);
				_item[num].DOId = Conversions.ToDouble(Interaction.IIf(row["doId"] == DBNull.Value, 0, RuntimeHelpers.GetObjectValue(row["doId"])));
				_item[num].DONumber = Conversions.ToString(row["DONumber"]);
				_item[num].ParentItemId = Conversions.ToInteger(row["parentItemId"]);
				num++;
			}
			strSql = " SELECT a.pkId, IF(pbgId != 0,CONCAT('M-',pkName),pkName) as pkName,  pbDate as payDate, pbAmount as payAmount, pbId as payId,  pbgId as mpayId, b.salesId, c.salesName,  b.accountId, d.accountName  FROM pembkode a, penjBayar b, sales c, account d  WHERE a.pkId = b.pkId  AND b.salesId = c.salesId  AND b.accountId = d.accountId  AND penjId = " + Conversions.ToString(_id);
			num = 0;
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			_payment = new cSalesInvoicePayment[dataTable.Rows.Count - 1 + 1];
			foreach (DataRow row2 in dataTable.Rows)
			{
				_payment[num] = new cSalesInvoicePayment();
				_payment[num].PaymentId = Conversions.ToDouble(row2["payId"]);
				_payment[num].MultiPaymentId = Conversions.ToDouble(row2["mpayId"]);
				_payment[num].PaymentCodeId = Conversions.ToByte(row2["pkId"]);
				_payment[num].PaymentCodeName = Conversions.ToString(row2["pkName"]);
				_payment[num].SalesPersonId = Conversions.ToInteger(row2["salesId"]);
				_payment[num].SalesPersonName = Conversions.ToString(row2["salesName"]);
				_payment[num].PaymentDate = Conversions.ToDate(row2["payDate"]);
				_payment[num].Amount = Conversions.ToDouble(row2["payAmount"]);
				_payment[num].AccountId = Conversions.ToInteger(row2["accountId"]);
				_payment[num].AccountName = Conversions.ToString(row2["accountName"]);
				if (Operators.CompareString(Strings.Right(_payment[num].PaymentCodeName, 3), "C/G", TextCompare: false) == 0)
				{
					cChequeIn cChequeIn2 = new cChequeIn(0.0, _payment[num].PaymentId, _payment[num].MultiPaymentId);
					_payment[num].BankId = cChequeIn2.BankId;
					_payment[num].BankName = cChequeIn2.BankName;
					_payment[num].ChequeId = cChequeIn2.Id;
					_payment[num].ChequeDate = cChequeIn2.ChequeDate;
					_payment[num].ChequeNumber = cChequeIn2.Number;
					_payment[num].ChequeDepositDate = cChequeIn2.DepositDate;
					_payment[num].ChequeClearingDate = cChequeIn2.ClearingDate;
				}
				num++;
			}
			strSql = " SELECT b.penjId as InvId, penjFaktur as invNumber, penjDate as invDate,  penjBs+penjPot+penjDisc as invReturn  FROM penjBs a, penjualan b  WHERE a.penjBsId = b.penjId  AND a.penjId = " + Conversions.ToString(_id);
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			num = 0;
			_invoiceReturn = new cSalesInvoiceReturn[dataTable.Rows.Count - 1 + 1];
			foreach (DataRow row3 in dataTable.Rows)
			{
				_invoiceReturn[num] = new cSalesInvoiceReturn();
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
		double sOId = default(double);
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
						if (_isReturn == 1)
						{
							_discount *= -1.0;
							_deduction *= -1.0;
							_totalPayment *= -1.0;
						}
						if (_id == 0.0)
						{
							string text = " INSERT INTO penjualan  (penjFaktur, penjFp, penjDate,  penjDateFP, penjKode, penjTotal,  penjTotalOrig, penjBs, penjDisc,  penjDiscDesc, penjPot, penjBayar,  penjDpp,penjPpn,penjTF,  penjDateTf, penjNote, penjLunas,  penjCreated, custId, salesId,  storeId, penjBsType, penjOldPrice) VALUES  ('" + _number + "'," + Conversions.ToString(_taxNumber) + ", '" + Strings.Format(_invoiceDate, "yyyy-MM-dd") + "', '" + Strings.Format(_taxInvoiceDate, "yyyy-MM-dd") + "', " + Conversions.ToString(_invoiceCode) + "," + Module1.unformatNumber(Conversions.ToString(_totalPrice)) + "," + Module1.unformatNumber(Conversions.ToString(_totalBasePrice)) + "," + Module1.unformatNumber(Conversions.ToString(_totalReturn)) + "," + Module1.unformatNumber(Conversions.ToString(_discount)) + ",'" + _discountDescription + "'," + Module1.unformatNumber(Conversions.ToString(_deduction)) + "," + Module1.unformatNumber(Conversions.ToString(_totalPayment)) + "," + Module1.unformatNumber(Conversions.ToString(_dpp)) + "," + Module1.unformatNumber(Conversions.ToString(_ppn)) + "," + Conversions.ToString(_tukarFaktur) + ",'" + Strings.Format(_tukarFakturDate, "yyyy-MM-dd") + "','" + _note + "',";
							text = ((DateTime.Compare(_paidDate, DateTime.MinValue) != 0) ? (text + "'" + Strings.Format(_paidDate, "yyyy-MM-dd") + "', ") : (text + "NULL, "));
							text = text + "'" + Strings.Format(DateAndTime.Now, "yyyy-MM-dd") + "'," + Conversions.ToString(_customerId) + "," + Conversions.ToString(_salesPersonId) + "," + Conversions.ToString(_storageId) + "," + Conversions.ToString(_isReturn) + "," + Conversions.ToString(_useOldPrice) + ")";
							Module1.sqlNonQuery(text, "data");
							_id = cDatabase.LastId("data");
						}
						else
						{
							string text = " UPDATE penjualan SET  penjFaktur = '" + _number + "',  penjFP = " + Conversions.ToString(_taxNumber) + ",  penjDate = '" + Strings.Format(_invoiceDate, "yyyy-MM-dd") + "',  penjDateFP = '" + Strings.Format(_taxInvoiceDate, "yyyy-MM-dd") + "',  penjKode = " + Conversions.ToString(_invoiceCode) + ", penjTotal = " + Module1.unformatNumber(Conversions.ToString(_totalPrice)) + ", penjTotalOrig = " + Module1.unformatNumber(Conversions.ToString(_totalBasePrice)) + ", penjBs = " + Module1.unformatNumber(Conversions.ToString(_totalReturn)) + ", penjDisc = " + Module1.unformatNumber(Conversions.ToString(_discount)) + ", penjDiscDesc = '" + _discountDescription + "', penjPot = " + Module1.unformatNumber(Conversions.ToString(_deduction)) + ", penjBayar = " + Module1.unformatNumber(Conversions.ToString(_totalPayment)) + ", penjDpp = " + Module1.unformatNumber(Conversions.ToString(_dpp)) + ", penjPpn = " + Module1.unformatNumber(Conversions.ToString(_ppn)) + ", penjTF = " + Conversions.ToString(_tukarFaktur) + ", penjDateTf = '" + Strings.Format(_tukarFakturDate, "yyyy-MM-dd") + "', penjNote = '" + _note + "', ";
							text = ((DateTime.Compare(_paidDate, DateTime.MinValue) != 0) ? (text + " penjLunas = '" + Strings.Format(_paidDate, "yyyy-MM-dd") + "', ") : (text + " penjLunas = NULL, "));
							text = text + " custId = " + Conversions.ToString(_customerId) + ", salesId = " + Conversions.ToString(_salesPersonId) + ",  storeId = " + Conversions.ToString(_storageId) + ", penjBsType = " + Conversions.ToString(_isReturn) + ", penjOldPrice = " + Conversions.ToString(_useOldPrice) + " WHERE penjId = " + Conversions.ToString(_id) + " ";
							Module1.sqlNonQuery(text, "data");
							if (Module1.pubActivateDailyStockCode)
							{
								int num3 = _currentItem.Length - 1;
								for (int i = 0; i <= num3; i++)
								{
									if (_currentItem[i].DOId == 0.0)
									{
										cDailyStock.add(_currentItem[i].ItemId, _currentStorage, _currentDate, Conversions.ToDouble(Interaction.IIf(_isReturn == 0, _currentItem[i].Qty, _currentItem[i].Qty * -1.0)));
									}
								}
							}
							text = " DELETE FROM penjprod  WHERE penjId = " + Conversions.ToString(_id);
							Module1.sqlNonQuery(text, "data");
							text = " DELETE FROM girocek  WHERE pbId IN (SELECT pbId FROM penjbayar  WHERE pbgId = 0 AND penjId = " + Conversions.ToString(_id) + ")";
							Module1.sqlNonQuery(text, "data");
							text = " DELETE FROM penjbayar  WHERE pbgId = 0  AND penjId = " + Conversions.ToString(_id);
							Module1.sqlNonQuery(text, "data");
							text = " SELECT * FROM penjualan  WHERE penjId IN  (SELECT penjBsId FROM penjbs  WHERE penjId = " + Conversions.ToString(_id) + ")";
							DataTable dataTable = Module1.sqlTable(text, "data", Clone: false);
							IEnumerator enumerator = dataTable.Rows.GetEnumerator();
							while (enumerator.MoveNext())
							{
								DataRow dataRow = (DataRow)enumerator.Current;
								text = Conversions.ToString(Operators.ConcatenateObject(" UPDATE penjualan  SET penjBayar = 0  WHERE penjId = ", dataRow["penjId"]));
								Module1.sqlNonQuery(text, "data");
								text = Conversions.ToString(Operators.ConcatenateObject(" DELETE FROM penjbayar  WHERE penjId = ", dataRow["penjId"]));
								Module1.sqlNonQuery(text, "data");
							}
							if (enumerator is IDisposable)
							{
								(enumerator as IDisposable).Dispose();
							}
							text = " DELETE FROM penjbs  WHERE penjId = " + Conversions.ToString(_id);
							Module1.sqlNonQuery(text, "data");
							text = " UPDATE salesOrder  SET penjId = 0  WHERE penjId = " + Conversions.ToString(_id);
							Module1.sqlNonQuery(text, "data");
						}
						cSalesInvoiceItem[] item = _item;
						foreach (cSalesInvoiceItem cSalesInvoiceItem2 in item)
						{
							string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" INSERT INTO PenjProd  (ppAmount, ppMissing, ppPrice,  ppPriceOrig, penjId, prodId,  soId, doId, ppDescription,  parentItemId) VALUES (" + Module1.unformatNumber(Conversions.ToString(cSalesInvoiceItem2.Qty)) + "," + Module1.unformatNumber(Conversions.ToString(cSalesInvoiceItem2.MissingQty)) + "," + Module1.unformatNumber(Conversions.ToString(cSalesInvoiceItem2.Price)) + "," + Module1.unformatNumber(Conversions.ToString(cSalesInvoiceItem2.BasePrice)) + "," + Conversions.ToString(_id) + "," + Conversions.ToString(cSalesInvoiceItem2.ItemId) + "," + Conversions.ToString(cSalesInvoiceItem2.SOId) + ",", Interaction.IIf(cSalesInvoiceItem2.DOId == 0.0, "NULL", cSalesInvoiceItem2.DOId)), ",'"), cSalesInvoiceItem2.Description), "',"), cSalesInvoiceItem2.ParentItemId), ")"));
							Module1.sqlNonQuery(text, "data");
							if (cSalesInvoiceItem2.SOId > 0.0 && sOId != cSalesInvoiceItem2.SOId)
							{
								sOId = cSalesInvoiceItem2.SOId;
								text = " UPDATE salesOrder  SET penjId = " + Conversions.ToString(_id) + " WHERE soId = " + Conversions.ToString(cSalesInvoiceItem2.SOId);
								Module1.sqlNonQuery(text, "data");
							}
							if (Module1.pubActivateDailyStockCode && cSalesInvoiceItem2.DOId == 0.0)
							{
								cDailyStock.add(cSalesInvoiceItem2.ItemId, _storageId, _invoiceDate, Conversions.ToDouble(Interaction.IIf(_isReturn == 0, cSalesInvoiceItem2.Qty * -1.0, cSalesInvoiceItem2.Qty)));
							}
						}
						cSalesInvoicePayment[] payment = _payment;
						foreach (cSalesInvoicePayment cSalesInvoicePayment2 in payment)
						{
							if (cSalesInvoicePayment2.MultiPaymentId == 0.0)
							{
								string text = " INSERT INTO PenjBayar(pbDate,pbAmount,pkId,  penjId,salesId,pbgId,  accountId,createdDate) VALUES ('" + Strings.Format(cSalesInvoicePayment2.PaymentDate, "yyyy-MM-dd") + "'," + Module1.unformatNumber(Conversions.ToString((_isReturn == 1) ? (cSalesInvoicePayment2.Amount * -1.0) : cSalesInvoicePayment2.Amount)) + "," + Conversions.ToString(cSalesInvoicePayment2.PaymentCodeId) + "," + Conversions.ToString(_id) + "," + Conversions.ToString(cSalesInvoicePayment2.SalesPersonId) + ",0," + Conversions.ToString(cSalesInvoicePayment2.AccountId) + ",'" + Strings.Format(cSalesInvoicePayment2.CreatedDate, "yyyy-MM-dd") + "')";
								Module1.sqlNonQuery(text, "data");
								cSalesInvoicePayment2.PaymentId = cDatabase.LastId("data");
								if (Operators.CompareString(cSalesInvoicePayment2.PaymentCodeName, "C/G", TextCompare: false) == 0)
								{
									text = " INSERT INTO GiroCek  (gcDate,gcNo,gcAmount,  gcReceivedDate,gcSetorDate,gcMasukDate,  bankId,pbId,pbgId,  custId,tgId) VALUES ( '" + Strings.Format(cSalesInvoicePayment2.ChequeDate, "yyyy-MM-dd") + "','" + cSalesInvoicePayment2.ChequeNumber + "'," + Module1.unformatNumber(Conversions.ToString(cSalesInvoicePayment2.Amount)) + ",'" + Strings.Format(cSalesInvoicePayment2.PaymentDate, "yyyy-MM-dd") + "',";
									text = ((DateTime.Compare(cSalesInvoicePayment2.ChequeDepositDate, DateTime.MinValue) != 0) ? (text + "'" + Strings.Format(cSalesInvoicePayment2.ChequeDepositDate, "yyyy-MM-dd") + "',") : (text + "Null,"));
									text = ((DateTime.Compare(cSalesInvoicePayment2.ChequeClearingDate, DateTime.MinValue) != 0) ? (text + "'" + Strings.Format(cSalesInvoicePayment2.ChequeClearingDate, "yyyy-MM-dd") + "',") : (text + "Null,"));
									text = text + Conversions.ToString(cSalesInvoicePayment2.BankId) + "," + Conversions.ToString(cSalesInvoicePayment2.PaymentId) + ",0," + Conversions.ToString(_customerId) + "," + Conversions.ToString(cSalesInvoicePayment2.AccountId) + ")";
									Module1.sqlNonQuery(text, "data");
								}
							}
						}
						if (_isReturn == 0)
						{
							cSalesInvoiceReturn[] invoiceReturn = _invoiceReturn;
							foreach (cSalesInvoiceReturn cSalesInvoiceReturn2 in invoiceReturn)
							{
								string text = " INSERT INTO penjbs(penjId, penjBsId) VALUES (" + Conversions.ToString(_id) + "," + Conversions.ToString(cSalesInvoiceReturn2.Id) + ")";
								Module1.sqlNonQuery(text, "data");
								text = " INSERT INTO penjbayar  (penjId,pbAmount,pbDate,pkId,pbBs) VALUES  (" + Conversions.ToString(cSalesInvoiceReturn2.Id) + "," + Conversions.ToString(cSalesInvoiceReturn2.Amount * -1.0) + ",'0000-00-00',0,1)";
								Module1.sqlNonQuery(text, "data");
								text = " UPDATE penjualan  SET penjBayar = " + Conversions.ToString(cSalesInvoiceReturn2.Amount * -1.0) + " WHERE penjId = " + Conversions.ToString(cSalesInvoiceReturn2.Id);
								Module1.sqlNonQuery(text, "data");
							}
						}
						goto end_IL_0001;
					}
					case 3895:
						num = -1;
						switch (num2)
						{
						case 2:
							Information.Err().Raise(513, null, Information.Err().Description);
							goto end_IL_0001;
						}
						break;
					}
					goto IL_0f6d;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 3895;
				continue;
			}
			break;
			IL_0f6d:
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
						string strSql = " DELETE FROM penjualan  WHERE penjId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						if (Module1.pubActivateDailyStockCode)
						{
							int num3 = _currentItem.Length - 1;
							for (int i = 0; i <= num3; i++)
							{
								if (_currentItem[i].DOId == 0.0)
								{
									cDailyStock.add(_currentItem[i].ItemId, _currentStorage, _currentDate, Conversions.ToDouble(Interaction.IIf(_isReturn == 0, _currentItem[i].Qty, _currentItem[i].Qty * -1.0)));
								}
							}
						}
						strSql = " DELETE FROM penjprod  WHERE penjId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " SELECT * FROM PenjBayar  WHERE pbBs = 1  AND penjId in  (SELECT penjBsId FROM penjBs   WHERE penjId = " + Conversions.ToString(_id) + ") ";
						DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
						IEnumerator enumerator = dataTable.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							strSql = Conversions.ToString(Operators.ConcatenateObject(" UPDATE penjualan  SET penjBayar = 0  WHERE penjId = ", dataRow["penjId"]));
							Module1.sqlNonQuery(strSql, "data");
							strSql = Conversions.ToString(Operators.ConcatenateObject(" DELETE FROM penjbayar  WHERE penjId = ", dataRow["penjId"]));
							Module1.sqlNonQuery(strSql, "data");
						}
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
						strSql = " DELETE FROM penjbs  WHERE penjId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " DELETE FROM GiroCek  WHERE pbId IN (SELECT pbId FROM PenjBayar  WHERE penjId = " + Conversions.ToString(_id) + ") ";
						Module1.sqlNonQuery(strSql, "data");
						strSql = " DELETE FROM PenjBayar  WHERE PenjID = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						val.Commit();
						goto end_IL_0001;
					}
					case 673:
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
					goto IL_02d7;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 673;
				continue;
			}
			break;
			IL_02d7:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static DataTable Search(int intRange, DateTime dateFirst, DateTime dateLast, int CustomerCodeId, int SalesPersonId, int PaymentStatus, int AreaId, string InvoiceNumber, double CustomerId, double ParentId, int InvoiceCode, int IsRetur, int HasNPWP, int UseOldPrice, int StorageId, int BranchId, int GroupId, string Order)
	{
		string text = " SELECT penjId,penjTotal,penjBs,  penjDisc,penjPot,penjBayar,  penjFaktur, penjDate, IF(penjKode=0,'T','K') AS penjKode,  penjPrintKomTotal, penjPrintPajakTotal, a.penjDateFp,  penjFp, if(a.penjtf>0 ,cast(DATE_FORMAT(a.penjdatetf,'%d/%m/%Y') as char) , '-') as tfDate,  (penjTotal-penjBs-penjDisc-penjPot-penjBayar) AS penjReceivable,  IF(penjTotal-penjBs-penjDisc-penjPot-penjBayar=0, 0, DATEDIFF(CURDATE(),penjDate)) as penjReceivableDays, custName, penjBsType  FROM penjualan a,customer b  WHERE a.custId = b.custId ";
		switch (intRange)
		{
		case 1:
			text = text + " AND penjDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'  AND penjDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' ";
			break;
		case 2:
			text = text + " AND penjDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'";
			break;
		case 3:
			text = text + " AND penjDateFP <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'  AND penjDateFP >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'  AND penjFp > 0 ";
			break;
		case 4:
			text = text + " AND penjLunas <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'  AND penjLunas >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'  AND (penjTotal-penjBs-penjDisc-penjPot-penjBayar) <= 0 ";
			break;
		case 5:
			text = text + " AND penjDateTf <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'  AND penjDateTf >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'  AND penjTf > 0 ";
			break;
		case 6:
			text = text + " AND penjFaktur like '%" + InvoiceNumber + "%'";
			break;
		}
		text = ((StorageId <= 0) ? (text + " AND a.storeId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1) ") : (text + " and a.storeId = " + Conversions.ToString(StorageId)));
		text = ((BranchId <= 0) ? (text + " AND b.branchId IN (SELECT branchId FROM groups_branches WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1) ") : (text + " and b.branchId = " + Conversions.ToString(BranchId)));
		switch (InvoiceCode)
		{
		case 0:
			text += " and penjKode = 0";
			break;
		case 1:
			text += " and penjKode = 1";
			break;
		}
		switch (HasNPWP)
		{
		case 1:
			text += " and custNPWP <> '' ";
			break;
		case 0:
			text += " and custNPWP = '' ";
			break;
		}
		switch (IsRetur)
		{
		case 1:
			text += " AND penjBsType > 0 ";
			break;
		case 0:
			text += " AND penjBsType = 0 ";
			break;
		}
		switch (UseOldPrice)
		{
		case 1:
			text += " AND penjOldPrice = 1 ";
			break;
		case 0:
			text += " AND penjOldPrice = 0 ";
			break;
		}
		if (AreaId > 0)
		{
			text = text + " AND b.wilId = " + Conversions.ToString(AreaId);
		}
		if (CustomerCodeId > 0)
		{
			text = text + " AND b.ckId = " + Conversions.ToString(CustomerCodeId);
		}
		if (SalesPersonId > 0)
		{
			text = text + " AND a.salesId = " + Conversions.ToString(SalesPersonId);
		}
		if (CustomerId > 0.0)
		{
			text = text + " AND (b.custId = " + Conversions.ToString(CustomerId) + " OR custParentId = " + Conversions.ToString(CustomerId) + ")";
		}
		if (ParentId > 0.0)
		{
			text = text + " AND b.custParentId = " + Conversions.ToString(ParentId);
		}
		switch (PaymentStatus)
		{
		case 1:
			text += " AND (penjTotal-penjBs-penjDisc-penjPot-penjBayar) = 0 ";
			break;
		case 2:
			text += " AND (penjTotal-penjBs-penjDisc-penjPot-penjBayar) <> 0 ";
			break;
		}
		if (intRange == 2)
		{
			text += " ORDER BY penjId DESC LIMIT 100 ";
		}
		else
		{
			text += " ORDER BY penjDate";
			if (Operators.CompareString(Order, "DESC", TextCompare: false) == 0)
			{
				text += " DESC ";
			}
		}
		return Module1.sqlTable(text, "data", Clone: true);
	}

	public static DataTable SearchItem(DateTime dateFirst, DateTime dateLast, double CustomerId, int AreaId, int SalesId, int UseOldPrice, int ItemCategoryId, int ItemId, int StorageId, int BranchId, int InvoiceType, int SearchType, string GroupBy, bool IncludeDO, int GroupId)
	{
		string text = "";
		switch (SearchType)
		{
		case 1:
			switch (GroupBy)
			{
			case "-":
				text = " SELECT a.penjId, penjDate, custName,  wilName, salesName, penjFaktur,  prodName AS itemName, ppAmount AS qty, 0 AS orderBy ";
				break;
			case "Barang":
				text = " SELECT 0 AS penjId, penjDate, '' AS custName,  '' AS wilName, '' AS salesName, '' AS penjFaktur,  prodName AS itemName, SUM(ppAmount) AS qty, 0 AS orderBy ";
				break;
			case "Sales":
				text = " SELECT 0 AS penjId, penjDate, '' AS custName,  '' AS wilName, salesName, '' AS penjFaktur,  prodName AS itemName, SUM(ppAmount) AS qty, 0 AS orderBy ";
				break;
			case "Wilayah":
				text = " SELECT 0 AS penjId, penjDate, '' AS custName,  wilName, '' AS salesName, '' AS penjFaktur,  prodName AS itemName, SUM(ppAmount) AS qty, 0 AS orderBy ";
				break;
			case "Customer":
				text = " SELECT 0 AS penjId, penjDate, custName,  '' AS wilName, '' AS salesName, '' AS penjFaktur,  prodName AS itemName, SUM(ppAmount) AS qty, 0 AS orderBy ";
				break;
			}
			break;
		case 2:
			switch (GroupBy)
			{
			case "Barang":
				text = " SELECT 0 as penjId, CURDATE() as penjDate, '' AS custName,  '' AS wilName, '' AS salesName, '' AS penjFaktur,  prodName as itemName, SUM(ppAmount) AS qty, 0 AS orderBy ";
				break;
			case "Sales":
				text = " SELECT 0 as penjId, CURDATE() as penjDate, '' AS custName,  '' AS wilName, salesName, '' AS penjFaktur,  prodName as itemName, SUM(ppAmount) AS qty, 0 AS orderBy ";
				break;
			case "Wilayah":
				text = " SELECT 0 as penjId, CURDATE() as penjDate, '' AS custName,  wilName, '' AS salesName, '' AS penjFaktur,  prodName as itemName, SUM(ppAmount) AS qty, 0 AS orderBy ";
				break;
			case "Customer":
				text = " SELECT 0 as penjId, CURDATE() as penjDate, custName,  '' AS wilName, '' AS salesName, '' AS penjFaktur,  prodName as itemName, SUM(ppAmount) AS qty, 0 AS orderBy ";
				break;
			}
			break;
		}
		string text2 = " FROM penjualan a, penjProd b, produk c, sales d, wilayah e, customer f  WHERE a.penjId = b.penjId  AND b.prodId = c.prodId  AND a.salesId = d.salesId  AND f.wilId = e.wilId  AND a.custId = f.custId  AND penjDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND penjDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
		if (!IncludeDO)
		{
			text2 += " AND b.doId IS NULL ";
		}
		if (CustomerId > 0.0)
		{
			text2 = text2 + " AND (f.custId = " + Conversions.ToString(CustomerId) + " OR f.custParentId = " + Conversions.ToString(CustomerId) + ")";
		}
		switch (InvoiceType)
		{
		case 0:
			text2 += " AND penjBsType = 0 ";
			break;
		case 1:
			text2 += " AND penjBsType > 0 ";
			break;
		}
		switch (UseOldPrice)
		{
		case 1:
			text2 += " AND penjOldPrice = 1 ";
			break;
		case 0:
			text2 += " AND penjOldPrice = 0 ";
			break;
		}
		text2 = ((StorageId <= 0) ? (text2 + " AND a.storeId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1) ") : (text2 + " AND a.storeId = " + Conversions.ToString(StorageId)));
		if (BranchId > 0)
		{
			text2 = text2 + " AND f.branchId = " + Conversions.ToString(BranchId);
		}
		text2 = ((ItemId > 0) ? (text2 + " AND c.prodId = " + Conversions.ToString(ItemId)) : ((ItemCategoryId <= 0) ? (text2 + " AND c.catId IN (SELECT catId FROM group_itemcategory WHERE groupId = " + Conversions.ToString(GroupId) + ")") : (text2 + " AND c.catId = " + Conversions.ToString(ItemCategoryId))));
		if (SalesId > 0)
		{
			text2 = text2 + " AND a.salesId = " + Conversions.ToString(SalesId);
		}
		if (AreaId > 0)
		{
			text2 = text2 + " AND f.wilId = " + Conversions.ToString(AreaId);
		}
		text += text2;
		switch (SearchType)
		{
		case 1:
			switch (GroupBy)
			{
			case "Barang":
				text += " GROUP BY penjDate, prodName ";
				break;
			case "Sales":
				text += " GROUP BY penjDate, salesName, prodName ";
				break;
			case "Wilayah":
				text += " GROUP BY penjDate, wilName, prodName ";
				break;
			case "Customer":
				text += " GROUP BY penjDate, custName, prodName ";
				break;
			}
			break;
		case 2:
			switch (GroupBy)
			{
			case "Barang":
				text += " GROUP BY prodName ";
				break;
			case "Sales":
				text += " GROUP BY salesName, prodName ";
				break;
			case "Wilayah":
				text += " GROUP BY wilName, prodName ";
				break;
			case "Wilayah,Sales":
				text += " GROUP BY wilName, salesName, prodName ";
				break;
			}
			break;
		}
		text += " UNION ALL ";
		text += " SELECT 0, CURDATE(), '',  '', '', '',  prodName, SUM(ppAmount), 2 AS orderBy ";
		text += text2;
		text += " GROUP BY prodName ";
		text += " ORDER BY orderBy, penjDate, wilName,salesName,penjFaktur, custName, itemName ";
		return Module1.sqlTable(text, "data", Clone: false);
	}

	public static DataTable SearchReceivable(int Range, DateTime dateFirst, DateTime dateLast, double CustomerId, int[] AreaId, int SalesId, int CustomerCodeId, int StorageId, int InvoiceType, int BranchId, int GroupId)
	{
		string strSql = "";
		checked
		{
			switch (Range)
			{
			case 1:
				strSql = " SELECT a.penjId, penjFaktur, penjDate, d.custName,  (penjTotal-penjBs-penjDisc-penjPot-penjBayar) AS penjReceivable,  IF(penjTotal-penjBs-penjDisc-penjPot-penjBayar=0, 0, DATEDIFF(CURDATE(),penjDate)) as penjReceivableDays  FROM penjualan a,sales b,custKode c,customer d,wilayah e  WHERE a.salesID = b.salesID  AND d.ckID = c.ckID  AND a.custId = d.custId  AND d.wilId = e.wilId  AND a.penjDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'  AND a.penjDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'  AND (penjTotal-penjBs-penjDisc-penjPot-penjBayar) > 0 ";
				switch (InvoiceType)
				{
				case 0:
					strSql += " AND penjBsType = 0 ";
					break;
				case 1:
					strSql += " AND penjBsType > 0 ";
					break;
				}
				strSql = ((StorageId <= 0) ? (strSql + " AND a.storeId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1) ") : (strSql + " AND a.storeId = " + Conversions.ToString(StorageId)));
				if (BranchId > 0)
				{
					strSql = strSql + " AND d.branchId = " + Conversions.ToString(BranchId);
				}
				if (AreaId.Count() > 0)
				{
					strSql += " AND e.wilId IN (";
					int num2 = AreaId.Count() - 1;
					for (int i = 0; i <= num2; i++)
					{
						strSql += Conversions.ToString(AreaId[i]);
						if (i < AreaId.Count() - 1)
						{
							strSql += ",";
						}
					}
					strSql += ")";
				}
				if (CustomerCodeId > 0)
				{
					strSql = strSql + " AND d.ckId = " + Conversions.ToString(CustomerCodeId);
				}
				if (SalesId > 0)
				{
					strSql = strSql + " AND a.salesId = " + Conversions.ToString(SalesId);
				}
				if (CustomerId > 0.0)
				{
					strSql = strSql + " AND d.custId IN (SELECT custId FROM customer WHERE custParentId = " + Conversions.ToString(CustomerId) + " OR custId = " + Conversions.ToString(CustomerId) + ")";
				}
				strSql += " ORDER BY penjDate ";
				break;
			case 2:
				strSql = " SELECT a.penjId  FROM penjualan a,sales b,custKode c,customer d,wilayah e  WHERE a.salesID = b.salesID  AND d.ckID = c.ckID  AND a.custId = d.custId  AND d.wilId = e.wilId  AND a.penjDate < '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'  AND (a.penjlunas='0000-00-00 00:00:00' OR a.penjLunas IS NULL OR a.penjLunas >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "')";
				switch (InvoiceType)
				{
				case 0:
					strSql += " AND penjBsType = 0 ";
					break;
				case 1:
					strSql += " AND penjBsType > 0 ";
					break;
				}
				strSql = ((StorageId <= 0) ? (strSql + " AND a.storeId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1) ") : (strSql + " AND a.storeId = " + Conversions.ToString(StorageId)));
				if (BranchId > 0)
				{
					strSql = strSql + " AND d.branchId = " + Conversions.ToString(BranchId);
				}
				if (AreaId.Count() > 0)
				{
					strSql += " AND e.wilId IN (";
					int num = AreaId.Count() - 1;
					for (int i = 0; i <= num; i++)
					{
						strSql += Conversions.ToString(AreaId[i]);
						if (i < AreaId.Count() - 1)
						{
							strSql += ",";
						}
					}
					strSql += ")";
				}
				if (CustomerCodeId > 0)
				{
					strSql = strSql + " AND d.ckId = " + Conversions.ToString(CustomerCodeId);
				}
				if (SalesId > 0)
				{
					strSql = strSql + " AND a.salesId = " + Conversions.ToString(SalesId);
				}
				if (CustomerId > 0.0)
				{
					strSql = strSql + " AND d.custId = " + Conversions.ToString(CustomerId);
					strSql = strSql + " AND d.custId IN (SELECT custId FROM customer WHERE custParentId = " + Conversions.ToString(CustomerId) + " OR custId = " + Conversions.ToString(CustomerId) + ")";
				}
				strSql = " SELECT a.penjId, penjFaktur, penjDate, d.custName,  (penjTotal-IFNULL(g.penjBs,0)-penjDisc-IFNULL(f.payAmount,0)) AS penjReceivable,  DATEDIFF('" + Strings.Format(dateFirst, "yyyy-MM-dd") + "',penjDate) as penjReceivableDays  FROM penjualan a LEFT OUTER JOIN  (SELECT penjId, SUM(pbAmount) AS payAmount FROM penjBayar WHERE penjId IN (" + strSql + ")  AND pbDate < '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'  GROUP BY penjId) f ON a.penjId = f.penjId  LEFT OUTER JOIN  (SELECT aa.penjId, SUM(cc.penjBs+cc.penjDisc+cc.penjPot) AS penjBs FROM penjualan aa, penjBs bb, penjualan cc   WHERE cc.penjId IN (SELECT penjBsId FROM penjBs WHERE penjId IN (" + strSql + "))   AND cc.penjDate < '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'   AND aa.penjId = bb.penjId   AND bb.penjBsId = cc.penjId   GROUP BY aa.penjId) g ON a.penjId = g.penjId,  sales b,custKode c,customer d,wilayah e  WHERE a.salesID = b.salesID  AND d.ckID = c.ckID  AND a.custId = d.custId  AND d.wilId = e.wilId  AND a.penjId IN (" + strSql + ") ORDER BY penjDate ";
				break;
			}
			return Module1.sqlTable(strSql, "data", Clone: false);
		}
	}

	public static DataTable SearchCommission(DateTime DateFirst, DateTime DateLast, double SalesPersonId)
	{
		string text = " SELECT a.salesId, SUM(pbAmount) AS amount, b.*, c.custName  FROM penjBayar a, penjualan b, customer c WHERE a.penjId = b.penjId  AND b.custId = c.custId  AND a.penjId IN (  SELECT penjId  FROM penjualan  WHERE penjLunas >= '" + Strings.Format(DateFirst, "yyyy-MM-dd") + "'  AND penjLunas <= '" + Strings.Format(DateLast, "yyyy-MM-dd") + "'  AND penjBsType = 0)  AND (a.salesId = " + Conversions.ToString(SalesPersonId) + " OR b.penjTf = " + Conversions.ToString(SalesPersonId) + ")";
		text += " GROUP BY penjId, a.salesId  ORDER BY penjLunas, penjFaktur, custName ";
		return Module1.sqlTable(text, "data", Clone: false);
	}

	public static DataTable SearchCustomerVisit(bool IsVisit, DateTime dateVisit, bool IsNoVisit, DateTime dateNoVisit, int Month, int Year, int AreaId, int SalesPersonId, int BranchId)
	{
		string text = " SELECT a.custId, a.custAddress,a.custName, numberOfVisit  FROM CUSTOMER a LEFT OUTER JOIN  (  SELECT a.custId, COUNT(b.custId) AS numberOfVisit  FROM customer a, penjualan b where a.custid=b.custid  AND month(penjDate) = " + Conversions.ToString(Month) + " AND year(penjDate) = " + Conversions.ToString(Year) + " AND penjBsType = 0  GROUP BY a.custId  ) AS b  ON a.custId = b.custId  WHERE a.custActive = 1  AND a.branchId = " + Conversions.ToString(BranchId);
		if (AreaId > 0)
		{
			text = text + " AND a.wilId = " + Conversions.ToString(AreaId);
		}
		if (SalesPersonId > 0)
		{
			text = text + " AND a.salesId = " + Conversions.ToString(SalesPersonId);
		}
		if (IsVisit)
		{
			text = text + " AND a.custId IN (SELECT DISTINCT custId FROM penjualan WHERE penjDate >= '" + Strings.Format(dateVisit, "yyyy-MM-dd") + "')";
		}
		else if (IsNoVisit)
		{
			text = text + " AND a.custId NOT IN (SELECT DISTINCT custId FROM penjualan WHERE penjDate >= '" + Strings.Format(dateNoVisit, "yyyy-MM-dd") + "')";
		}
		text += " ORDER BY custName ";
		return Module1.sqlTable(text, "data", Clone: false);
	}

	public static DataTable SearchPayment(DateTime DateFirst, DateTime DateLast, int PaymentCodeId, int InvoiceType, int InvoiceCode, int SalesPersonId, int CollectorId, int TFId, int AreaId, int StorageId, int BranchId, int GroupId)
	{
		string text = " SELECT a.penjId,penjFaktur,pbDate,pbAmount,c.pkId, c.pkName,b.penjKode, d.salesName,  e.salesName AS collector, d.salesId, e.salesId as kolId, wilName, penjTf  FROM PenjBayar a, penjualan b, pembKode c, sales d, sales e, wilayah f,customer g  WHERE b.custId = g.custId  AND a.penjId = b.penjId  AND a.pkId = c.pkId  AND g.wilId = f.wilId  AND b.salesId = d.salesId  AND a.salesId = e.salesId  AND b.penjId NOT IN (SELECT penjBsId FROM penjBs)  AND pbDate >= '" + Strings.Format(DateFirst, "yyyy-MM-dd") + "'  AND pbDate <= '" + Strings.Format(DateLast, "yyyy-MM-dd") + "' ";
		text = ((StorageId <= 0) ? (text + " AND b.storeId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1) ") : (text + " AND b.storeId = " + Conversions.ToString(StorageId) + " "));
		if (BranchId > 0)
		{
			text = text + " AND g.branchId = " + Conversions.ToString(BranchId);
		}
		if (PaymentCodeId > 0)
		{
			text = text + " AND a.pkId = " + Conversions.ToString(PaymentCodeId);
		}
		switch (InvoiceCode)
		{
		case 0:
			text += " AND b.penjKode = 0 ";
			break;
		case 1:
			text += " AND b.penjKode = 1 ";
			break;
		}
		if (SalesPersonId > 0)
		{
			text = text + " AND b.salesId = " + Conversions.ToString(SalesPersonId);
		}
		if (CollectorId > 0)
		{
			text = text + " AND a.salesId = " + Conversions.ToString(CollectorId);
		}
		if (TFId > 0)
		{
			text = text + " AND b.penjTf = " + Conversions.ToString(TFId);
		}
		if (AreaId > 0)
		{
			text = text + " AND g.wilId = " + Conversions.ToString(AreaId);
		}
		switch (InvoiceType)
		{
		case 1:
			text += " AND b.penjBsType = 0 ";
			break;
		case 2:
			text += " AND b.penjBsType > 0 ";
			break;
		}
		text = " SELECT a.*, b.salesName AS TF  FROM (" + text + ") a LEFT OUTER JOIN sales b  ON a.penjTf = b.salesId  ORDER BY pbDate, penjFaktur ";
		return Module1.sqlTable(text, "data", Clone: false);
	}

	public static string getInvoiceNumber(int intSales, DateTime datInput, bool blnUseDeleted, int intBranchId, bool blnUpdate)
	{
		string strSql = " SELECT salesFakNo FROM Sales WHERE salesId = " + Conversions.ToString(intSales) + " ";
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: true);
		string result;
		if (Conversions.ToBoolean(Operators.OrObject(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["salesFakNo"])), Operators.CompareObjectEqual(dataTable.Rows[0]["salesFakNo"], "", TextCompare: false))))
		{
			result = "";
		}
		else
		{
			string text = Conversions.ToString(dataTable.Rows[0]["salesFakNo"]);
			strSql = " SELECT fakturLatestNo FROM fakturLatest  WHERE fakturType = 1  AND fakturYear = " + Conversions.ToString(DateAndTime.Year(datInput)) + " AND salesId = " + Conversions.ToString(intSales);
			dataTable = Module1.sqlTable(strSql, "data", Clone: true);
			double num = default(double);
			if (dataTable.Rows.Count > 0)
			{
				num = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["fakturLatestNo"])) + 1.0;
			}
			if (blnUseDeleted)
			{
				strSql = " SELECT * FROM fakturDeleted  WHERE fdType = 1  AND FakturYear = " + Conversions.ToString(DateAndTime.Year(datInput)) + "  AND branchId = " + Conversions.ToString(intBranchId) + " ORDER BY fs ";
				dataTable = Module1.sqlTable(strSql, "data", Clone: true);
				foreach (DataRow row in dataTable.Rows)
				{
					strSql = " SELECT * FROM FakturSales  WHERE salesId = " + Conversions.ToString(intSales) + "  AND CONVERT(fsBegin,SIGNED) <= " + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(row["fs"]))) + "  AND CONVERT(fsEnd,SIGNED) >= " + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(row["fs"]))) + "  AND FakturYear = " + Conversions.ToString(DateAndTime.Year(datInput)) + " ";
					DataTable dataTable2 = Module1.sqlTable(strSql, "data", Clone: true);
					if (dataTable2.Rows.Count <= 0)
					{
						continue;
					}
					result = text + Module1.FormatInvoiceNumber(Conversions.ToString(row["fs"]));
					if (blnUpdate)
					{
						strSql = Conversions.ToString(Operators.ConcatenateObject(" DELETE FROM fakturDeleted  WHERE fdId = ", row["fdId"]));
						Module1.sqlNonQuery(strSql, "data");
					}
					goto IL_05b9;
				}
			}
			bool flag = default(bool);
			while (!flag)
			{
				strSql = " SELECT * FROM FakturSales  WHERE salesId = " + Conversions.ToString(intSales) + "  AND CONVERT(fsBegin,SIGNED) <= " + Conversions.ToString(num) + "  AND CONVERT(fsEnd,SIGNED) >= " + Conversions.ToString(num) + "  AND FakturYear = " + Conversions.ToString(DateAndTime.Year(datInput)) + " ";
				dataTable = Module1.sqlTable(strSql, "data", Clone: true);
				if (dataTable.Rows.Count == 0)
				{
					strSql = " SELECT * FROM FakturSales  WHERE salesId = " + Conversions.ToString(intSales) + "  AND CONVERT(fsBegin,SIGNED) > " + Conversions.ToString(num) + "  AND FakturYear = " + Conversions.ToString(DateAndTime.Year(datInput)) + "  ORDER BY CONVERT(fsBegin,SIGNED) ";
					dataTable = Module1.sqlTable(strSql, "data", Clone: true);
					num = ((dataTable.Rows.Count != 0) ? Conversions.ToDouble(dataTable.Rows[0]["fsBegin"]) : 0.0);
					if (num == 0.0)
					{
						flag = true;
						continue;
					}
					string text2 = text + Module1.FormatInvoiceNumber(Conversion.Str(num));
					strSql = " SELECT penjFaktur FROM penjualan  WHERE penjFaktur = '" + text2 + "'  AND YEAR(penjDate) = " + Conversions.ToString(DateAndTime.Year(datInput)) + " ";
					dataTable = Module1.sqlTable(strSql, "data", Clone: true);
					if (dataTable.Rows.Count == 0)
					{
						flag = true;
					}
					else
					{
						num += 1.0;
					}
				}
				else
				{
					string text2 = text + Module1.FormatInvoiceNumber(Conversion.Str(num));
					strSql = " SELECT penjFaktur FROM penjualan  WHERE penjFaktur = '" + text2 + "'  AND YEAR(penjDate) = " + Conversions.ToString(DateAndTime.Year(datInput)) + " ";
					dataTable = Module1.sqlTable(strSql, "data", Clone: true);
					if (dataTable.Rows.Count == 0)
					{
						flag = true;
					}
					else
					{
						num += 1.0;
					}
				}
			}
			if (blnUpdate && num > 0.0)
			{
				strSql = " UPDATE fakturLatest  SET fakturLatestNo = " + Conversions.ToString(num) + " WHERE salesId = " + Conversions.ToString(intSales) + " AND fakturType = 1  AND fakturYear = " + Conversions.ToString(DateAndTime.Year(datInput));
				Module1.sqlNonQuery(strSql, "data");
			}
			result = ((num != 0.0) ? (text + Module1.FormatInvoiceNumber(Conversion.Str(num))) : "");
		}
		goto IL_05b9;
		IL_05b9:
		return result;
	}

	public static string getTaxInvoiceNumber(int intSales, DateTime datInput, int intBranchId, bool blnUpdate)
	{
		string strSql = " SELECT * FROM fakturDeleted  WHERE fdType = 2  AND FakturYear = " + Conversions.ToString(DateAndTime.Year(datInput)) + "  AND branchId = " + Conversions.ToString(intBranchId) + " ORDER BY fs ";
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: true);
		string result;
		foreach (DataRow row in dataTable.Rows)
		{
			strSql = " SELECT * FROM FakturPajak  WHERE CONVERT(fsBegin,SIGNED) <= " + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(row["fs"]))) + "  and CONVERT(fsEnd,SIGNED) >= " + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(row["fs"]))) + "  and FakturYear = " + Conversions.ToString(DateAndTime.Year(datInput)) + "  and branchId = (select branchId from sales where salesId=" + Conversions.ToString(intSales) + ") ";
			DataTable dataTable2 = Module1.sqlTable(strSql, "data", Clone: true);
			if (dataTable2.Rows.Count <= 0)
			{
				continue;
			}
			result = Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(row["fs"])));
			if (blnUpdate)
			{
				strSql = Conversions.ToString(Operators.ConcatenateObject(" DELETE FROM FakturDeleted  WHERE fdId = ", row["fdId"]));
				Module1.sqlNonQuery(strSql, "data");
			}
			goto IL_043a;
		}
		strSql = " SELECT fakturLatestNo FROM fakturLatest  WHERE fakturType = 2  AND fakturYear = " + Conversions.ToString(DateAndTime.Year(datInput)) + " AND branchId = ( SELECT branchId FROM Sales WHERE salesId = " + Conversions.ToString(intSales) + ")";
		dataTable = Module1.sqlTable(strSql, "data", Clone: true);
		double num = default(double);
		if (dataTable.Rows.Count > 0)
		{
			num = Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["fakturLatestNo"])) + 1.0;
		}
		bool flag = default(bool);
		while (!flag)
		{
			strSql = " select * from FakturPajak  where CONVERT(fsBegin,SIGNED) <= " + Conversions.ToString(num) + "  and CONVERT(fsEnd,SIGNED) >= " + Conversions.ToString(num) + "  and FakturYear = " + Conversions.ToString(DateAndTime.Year(datInput)) + "  and branchId = (select branchId from sales where salesId=" + Conversions.ToString(intSales) + ") ";
			dataTable = Module1.sqlTable(strSql, "data", Clone: true);
			if (dataTable.Rows.Count == 0)
			{
				strSql = " select * from FakturPajak  where CONVERT(fsBegin,SIGNED) > " + Conversions.ToString(num) + "  and FakturYear = " + Conversions.ToString(DateAndTime.Year(datInput)) + "  and branchId = (select branchId from sales where salesId=" + Conversions.ToString(intSales) + ")  order by CONVERT(fsBegin,SIGNED) ";
				dataTable = Module1.sqlTable(strSql, "data", Clone: true);
				num = ((dataTable.Rows.Count != 0) ? Conversions.ToDouble(dataTable.Rows[0]["fsBegin"]) : 0.0);
			}
			if (num == 0.0)
			{
				flag = true;
				continue;
			}
			strSql = " SELECT penjFP FROM penjualan  WHERE penjFP = " + Conversions.ToString(num) + "  AND YEAR(penjDateFp) = " + Conversions.ToString(DateAndTime.Year(datInput));
			dataTable = Module1.sqlTable(strSql, "data", Clone: true);
			if (dataTable.Rows.Count == 0)
			{
				flag = true;
			}
			else
			{
				num += 1.0;
			}
		}
		if (blnUpdate && num > 0.0)
		{
			strSql = " UPDATE fakturLatest  SET fakturLatestNo = " + Conversions.ToString(num) + " WHERE branchId = (SELECT branchId FROM sales WHERE salesId = " + Conversions.ToString(intSales) + ") AND fakturType = 2  AND fakturYear = " + Conversions.ToString(DateAndTime.Year(datInput));
			Module1.sqlNonQuery(strSql, "data");
		}
		result = Module1.FormatInvoiceNumber(Conversion.Str(num));
		goto IL_043a;
		IL_043a:
		return result;
	}

	public static int TotalUnpaidInvoice(double CustomerId)
	{
		string strSql = " select penjId from penjualan where custId = " + Conversions.ToString(CustomerId) + "  and (penjTotal-penjBs-penjDisc-penjPot-penjBayar) > 0  and penjFaktur not like 'BS%'  UNION  SELECT a.penjid  FROM penjualan a, penjbayar b, girocek c, customer d  Where b.pkId = 2 and a.custId = " + Conversions.ToString(CustomerId) + " and b.pbgid = 0  and a.penjid = b.penjid  and b.pbid = c.pbid  and a.custid = d.custid  and gcdate > '" + Strings.Format(DateAndTime.Now, "yyyy-MM-dd") + "' and gcdate > date_add(penjdate, interval custtop day)  Union  SELECT a.penjid  FROM penjualan a, penjbayar b, girocek c, customer d, penjbayargroup e  Where b.pkId = 2 and a.custId = " + Conversions.ToString(CustomerId) + " and b.pbgid > 0  and a.penjid = b.penjid  and b.pbgid = e.pbgid  and c.pbgid = e.pbgId  and a.custid = d.custid  and gcdate > '" + Strings.Format(DateAndTime.Now, "yyyy-MM-dd") + "' and gcdate > date_add(penjdate, interval custtop day) ";
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		return dataTable.Rows.Count;
	}

	public static bool isMoreThanLimit(double dblCustId)
	{
		cCustomer cCustomer2 = new cCustomer(dblCustId);
		bool result = false;
		if (checked(TotalUnpaidInvoice(dblCustId) + 1) > cCustomer2.CreditLimit)
		{
			result = true;
		}
		return result;
	}

	public static double[] arrChequeNotDue(double intId)
	{
		string strSql = " SELECT a.penjId  FROM penjualan a, penjbayar b, girocek c, customer d  Where b.pkId = 2 and a.custId = " + Conversions.ToString(intId) + " and b.pbgid = 0  and a.penjid = b.penjid  and b.pbid = c.pbid  and a.custid = d.custid  and gcdate > '" + Strings.Format(DateAndTime.Now, "yyyy-MM-dd") + "' and gcdate > date_add(penjdate, interval custtop day)  UNION  SELECT a.penjId  FROM penjualan a, penjbayar b, girocek c, customer d, penjbayargroup e  Where b.pkId = 2 and a.custId = " + Conversions.ToString(intId) + " and b.pbgid > 0  and a.penjid = b.penjid  and b.pbgid = e.pbgid  and c.pbgid = e.pbgId  and a.custid = d.custid  and gcdate > '" + Strings.Format(DateAndTime.Now, "yyyy-MM-dd") + "' and gcdate > date_add(penjdate, interval custtop day)  order by penjId desc ";
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		double[] array = null;
		checked
		{
			if (dataTable.Rows.Count > 0)
			{
				array = new double[dataTable.Rows.Count - 1 + 1];
				int num = 0;
				foreach (DataRow row in dataTable.Rows)
				{
					array[num] = Conversions.ToDouble(row["penjId"]);
					num++;
				}
			}
			return array;
		}
	}

	public static DataTable GetUnpaidReturn(double CustomerParentId)
	{
		string strSql = " SELECT penjId, penjDate, penjFaktur, penjBs+penjDisc+penjPot+penjBayar AS Payable FROM penjualan  WHERE penjBs + penjDisc + penjPot + penjBayar > 0  AND penjId NOT IN (SELECT penjId FROM penjBayar)  AND penjBsType > 0  AND custId IN (SELECT custId FROM customer WHERE custParentId = " + Conversions.ToString(CustomerParentId) + ") ORDER BY penjDate ";
		return Module1.sqlTable(strSql, "data", Clone: false);
	}

	public static DataTable SearchUnpaid(int CustomerId)
	{
		string strSql = " SELECT penjId, penjFaktur,penjDate, penjTotal-penjBs-penjDisc-penjPot-penjBayar AS Receivable, penjTf  FROM penjualan  WHERE penjTotal-penjBs-penjDisc-penjPot-penjBayar > 0  AND custId IN (SELECT custId FROM customer WHERE custParentId = " + Conversions.ToString(CustomerId) + " OR custId = " + Conversions.ToString(CustomerId) + ") ORDER BY penjDate DESC ";
		return Module1.sqlTable(strSql, "data", Clone: false);
	}

	public static double GetTotalReturnConnectedToCreditInvoice(DateTime BeginDate, DateTime EndDate, int BranchId, int GroupId)
	{
		double num = 0.0;
		string strSql = " SELECT SUM(penjBs+penjDisc+penjPot) AS total  FROM penjualan  WHERE penjBsType > 0  AND penjDate <= '" + Strings.Format(EndDate, "yyyy-MM-dd") + "'  AND penjDate >= '" + Strings.Format(BeginDate, "yyyy-MM-dd") + "' AND penjId IN ( SELECT penjBsId FROM penjBs  WHERE penjId IN (  SELECT penjId FROM penjualan  WHERE penjKode = 1  )) AND custId IN (SELECT custId FROM customer WHERE branchId = " + Conversions.ToString(BranchId) + ") AND storeId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1) ";
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["total"])))
		{
		}
		strSql = " SELECT SUM(a.penjBs+a.penjDisc+a.penjPot) AS total  FROM penjualan a, penjbs b, penjualan c WHERE a.penjBsType > 0  AND c.penjBsType = 0  AND a.penjId = b.penjBsId  AND b.penjId = c.penjId  AND a.penjDate >= c.penjDate  AND c.penjKode = 1  AND a.penjDate <= '" + Strings.Format(EndDate, "yyyy-MM-dd") + "'  AND a.penjDate >= '" + Strings.Format(BeginDate, "yyyy-MM-dd") + "' AND a.custId IN (SELECT custId FROM customer WHERE branchId = " + Conversions.ToString(BranchId) + ") AND a.storeId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1) ";
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["total"])))
		{
			num = Conversions.ToDouble(dataTable.Rows[0]["total"]);
		}
		strSql = " SELECT SUM(a.penjBs+a.penjDisc+a.penjPot) AS total  FROM penjualan a, penjbs b, penjualan c WHERE a.penjBsType > 0  AND c.penjBsType = 0  AND a.penjId = b.penjBsId  AND b.penjId = c.penjId  AND a.penjDate < c.penjDate  AND c.penjKode = 1  AND c.penjDate <= '" + Strings.Format(EndDate, "yyyy-MM-dd") + "'  AND c.penjDate >= '" + Strings.Format(BeginDate, "yyyy-MM-dd") + "' AND a.custId IN (SELECT custId FROM customer WHERE branchId = " + Conversions.ToString(BranchId) + ") AND a.storeId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1) ";
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["total"])))
		{
			num = Conversions.ToDouble(Operators.AddObject(num, dataTable.Rows[0]["total"]));
		}
		return num;
	}

	public static double GetTotalPaymentDiscountOfCreditInvoice(DateTime BeginDate, DateTime EndDate, int BranchId, int GroupId)
	{
		double result = 0.0;
		string strSql = " SELECT SUM(penjPot) AS total  FROM penjualan  WHERE penjBsType = 0  AND penjKode = 1  AND penjLunas <= '" + Strings.Format(EndDate, "yyyy-MM-dd") + "'  AND penjLunas >= '" + Strings.Format(BeginDate, "yyyy-MM-dd") + "' AND custId IN (SELECT custId FROM customer WHERE branchId = " + Conversions.ToString(BranchId) + ") AND storeId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1) ";
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["total"])))
		{
			result = Conversions.ToDouble(dataTable.Rows[0]["total"]);
		}
		return result;
	}

	private string GenerateNewNumber()
	{
		string strSql = " SELECT * FROM penjualan  WHERE YEAR(penjDate) = " + Conversions.ToString(DateAndTime.Year(_invoiceDate)) + " AND storeId = " + Conversions.ToString(_storageId) + " AND penjBsType > 0  ORDER BY penjId DESC LIMIT 1 ";
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		return ((dataTable.Rows.Count <= 0) ? 1 : checked((int)Math.Round(Conversion.Val(Strings.Right(Conversions.ToString(dataTable.Rows[0]["penjFaktur"]), 5)) + 1.0))).ToString("00000");
	}

	public static int GetTotalPrint(double InvoiceId, int InvoiceType)
	{
		string strSql = "";
		int result = 0;
		switch (InvoiceType)
		{
		case 1:
			strSql = " SELECT penjPrintKomTotal AS total FROM penjualan  WHERE penjId = " + Conversions.ToString(InvoiceId);
			break;
		case 2:
			strSql = " SELECT penjPrintPajakTotal AS total FROM penjualan  WHERE penjId = " + Conversions.ToString(InvoiceId);
			break;
		}
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			result = Conversions.ToInteger(dataTable.Rows[0]["total"]);
		}
		return result;
	}

	public static void SetTotalPrint(double InvoiceId, int InvoiceType)
	{
		string strSql = "";
		switch (InvoiceType)
		{
		case 1:
			strSql = " UPDATE penjualan SET penjPrintKomTotal = penjPrintKomTotal+1  WHERE penjId = " + Conversions.ToString(InvoiceId);
			break;
		case 2:
			strSql = " UPDATE penjualan SET penjPrintPajakTotal = penjPrintPajakTotal+1  WHERE penjId = " + Conversions.ToString(InvoiceId);
			break;
		}
		Module1.sqlNonQuery(strSql, "data");
	}
}
