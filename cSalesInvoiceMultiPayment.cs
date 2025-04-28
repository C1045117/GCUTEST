using System;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace GCUv2;

public class cSalesInvoiceMultiPayment : cSalesInvoicePayment
{
	private double _customerId;

	private string _customerName;

	private string _customerAddress;

	private int _branchId;

	private cSalesInvoicePayment[] _allocation;

	private double _allocatedAmount;

	private string _description;

	private int _cashAccountId;

	private int _bankAccountId;

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

	public cSalesInvoicePayment[] Allocation
	{
		get
		{
			return _allocation;
		}
		set
		{
			_allocation = value;
		}
	}

	public double AllocatedAmount
	{
		get
		{
			return _allocatedAmount;
		}
		set
		{
			_allocatedAmount = value;
		}
	}

	public string Description
	{
		get
		{
			return _description;
		}
		set
		{
			_description = Module1.cleanStringKeepCrlf(value);
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

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public cSalesInvoiceMultiPayment(double MultiPaymentId)
	{
		if (!(MultiPaymentId > 0.0))
		{
			return;
		}
		base.MultiPaymentId = MultiPaymentId;
		DataTable dataTable = new DataTable();
		string strSql = " SELECT a.*, b.pcName, c.custName, c.custAddress, c.branchId, c.kgId, c.tgId  FROM penjbayargroup a, paymentcodes b, customer c  WHERE a.pkId = b.pcId  AND a.custId = c.custId  AND pbgId = " + Conversions.ToString(base.MultiPaymentId);
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			_customerId = Conversions.ToDouble(dataTable.Rows[0]["custId"]);
			_customerName = Conversions.ToString(dataTable.Rows[0]["custName"]);
			_customerAddress = Conversions.ToString(dataTable.Rows[0]["custAddress"]);
			_branchId = Conversions.ToInteger(dataTable.Rows[0]["branchId"]);
			_cashAccountId = Conversions.ToInteger(dataTable.Rows[0]["kgId"]);
			_bankAccountId = Conversions.ToInteger(dataTable.Rows[0]["tgId"]);
			base.SalesPersonId = Conversions.ToInteger(dataTable.Rows[0]["salesId"]);
			base.PaymentDate = Conversions.ToDate(dataTable.Rows[0]["pbgDate"]);
			base.PaymentCodeId = Conversions.ToByte(dataTable.Rows[0]["pkId"]);
			base.PaymentCodeName = Conversions.ToString(dataTable.Rows[0]["pcName"]);
			base.Amount = Conversions.ToDouble(dataTable.Rows[0]["pbgAmount"]);
			base.AccountId = Conversions.ToInteger(dataTable.Rows[0]["accountId"]);
			_description = Conversions.ToString(dataTable.Rows[0]["pbgNote"]);
			_allocatedAmount = Conversions.ToDouble(dataTable.Rows[0]["allocatedAmount"]);
			base.CreatedDate = Conversions.ToDate(dataTable.Rows[0]["createdDate"]);
			if (Operators.ConditionalCompareObjectEqual(dataTable.Rows[0]["pcName"], "C/G", TextCompare: false))
			{
				strSql = " SELECT gcDate, gcNo, bankId,  gcSetorDate, gcMasukDate  FROM girocek  WHERE pbgId = " + Conversions.ToString(base.MultiPaymentId);
				dataTable = Module1.sqlTable(strSql, "data", Clone: false);
				if (dataTable.Rows.Count > 0)
				{
					base.ChequeDate = Conversions.ToDate(dataTable.Rows[0]["gcDate"]);
					base.ChequeNumber = Conversions.ToString(dataTable.Rows[0]["gcNo"]);
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["gcSetorDate"])))
					{
						base.ChequeDepositDate = Conversions.ToDate(dataTable.Rows[0]["gcSetorDate"]);
					}
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["gcMasukDate"])))
					{
						base.ChequeClearingDate = Conversions.ToDate(dataTable.Rows[0]["gcMasukDate"]);
					}
					base.BankId = Conversions.ToInteger(dataTable.Rows[0]["bankId"]);
				}
			}
		}
		else
		{
			base.MultiPaymentId = 0.0;
			Information.Err().Raise(513, null, "Pembayaran tidak ditemukan. Kemungkinan telah dihapus.");
		}
		strSql = " SELECT a.penjId, penjFaktur, penjDate, penjTotal-penjBs-penjDisc-penjPot-penjBayar AS Receivable, pbAmount  FROM penjualan a, penjBayar b  WHERE a.penjId = b.penjId  AND pbgId = " + Conversions.ToString(base.MultiPaymentId) + " ORDER BY penjDate ";
		int num = 0;
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		checked
		{
			_allocation = new cSalesInvoicePayment[dataTable.Rows.Count - 1 + 1];
			foreach (DataRow row in dataTable.Rows)
			{
				_allocation[num] = new cSalesInvoicePayment();
				_allocation[num].InvoiceId = Conversions.ToDouble(row["penjId"]);
				_allocation[num].InvoiceDate = Conversions.ToDate(row["penjDate"]);
				_allocation[num].InvoiceNumber = Conversions.ToString(row["penjFaktur"]);
				_allocation[num].InvoiceReceivable = Conversions.ToDouble(row["Receivable"]);
				_allocation[num].Amount = Conversions.ToDouble(row["pbAmount"]);
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
						ProjectData.ClearProjectError();
						num2 = 2;
						val = Module1.connectData.BeginTransaction();
						if (base.MultiPaymentId == 0.0)
						{
							string strSql = " INSERT INTO penjbayargroup  (pbgDate, pbgAmount, pkId,  salesId, custId, accountId,  createdDate, AllocatedAmount, pbgNote  ) VALUES  ('" + Strings.Format(base.PaymentDate, "yyyy-MM-dd") + "'," + Module1.unformatNumber(Conversions.ToString(base.Amount)) + "," + Conversions.ToString(base.PaymentCodeId) + "," + Conversions.ToString(base.SalesPersonId) + "," + Conversions.ToString(_customerId) + "," + Conversions.ToString(base.AccountId) + ",'" + Strings.Format(DateAndTime.Now, "yyyy-MM-dd HH:mm:ss") + "'," + Module1.unformatNumber(Conversions.ToString(AllocatedAmount)) + ",'" + _description + "')";
							Module1.sqlNonQuery(strSql, "data");
							base.MultiPaymentId = cDatabase.LastId("data");
						}
						else
						{
							string strSql = " UPDATE penjbayargroup  SET pbgDate = '" + Strings.Format(base.PaymentDate, "yyyy-MM-dd") + "', pbgAmount = " + Module1.unformatNumber(Conversions.ToString(base.Amount)) + ", pkId = " + Conversions.ToString(base.PaymentCodeId) + ", salesId = " + Conversions.ToString(base.SalesPersonId) + ", custId = " + Conversions.ToString(_customerId) + ", accountId = " + Conversions.ToString(base.AccountId) + ", AllocatedAmount = " + Module1.unformatNumber(Conversions.ToString(_allocatedAmount)) + ", pbgNote = '" + _description + "' WHERE pbgId = " + Conversions.ToString(base.MultiPaymentId);
							Module1.sqlNonQuery(strSql, "data");
							strSql = " DELETE FROM girocek  WHERE pbgId = " + Conversions.ToString(base.MultiPaymentId);
							Module1.sqlNonQuery(strSql, "data");
							strSql = " SELECT * FROM penjbayar  WHERE pbgId = " + Conversions.ToString(base.MultiPaymentId);
							DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
							int num3 = dataTable.Rows.Count - 1;
							for (int i = 0; i <= num3; i++)
							{
								strSql = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" UPDATE penjualan  SET penjLunas = '0000-00-00',  penjBayar =  (SELECT IFNULL(SUM(pbAmount),0) FROM penjbayar  WHERE penjId = ", dataTable.Rows[i]["penjId"]), " AND pbgId <> "), base.MultiPaymentId), ") "), " WHERE penjId = "), dataTable.Rows[i]["penjId"]));
								Module1.sqlNonQuery(strSql, "data");
							}
							strSql = " DELETE FROM penjbayar  WHERE pbgId = " + Conversions.ToString(base.MultiPaymentId);
							Module1.sqlNonQuery(strSql, "data");
						}
						if (Operators.CompareString(base.PaymentCodeName, "C/G", TextCompare: false) == 0)
						{
							string strSql = " INSERT INTO girocek(gcNo,gcDate,bankId,  pbId, pbgId, gcAmount,  custId, tgId, gcReceivedDate,  gcSetorDate, gcMasukDate) VALUES  ('" + base.ChequeNumber + "','" + Strings.Format(base.ChequeDate, "yyyy-MM-dd") + "'," + Conversions.ToString(base.BankId) + ", 0," + Conversions.ToString(base.MultiPaymentId) + "," + Module1.unformatNumber(Conversions.ToString(base.Amount)) + "," + Conversions.ToString(_customerId) + "," + Conversions.ToString(base.AccountId) + ",'" + Strings.Format(base.PaymentDate, "yyyy-MM-dd") + "',";
							strSql = ((DateTime.Compare(base.ChequeDepositDate, DateTime.MinValue) != 0) ? (strSql + "'" + Strings.Format(base.ChequeDepositDate, "yyyy-MM-dd") + "',") : (strSql + "Null,"));
							strSql = ((DateTime.Compare(base.ChequeClearingDate, DateTime.MinValue) != 0) ? (strSql + "'" + Strings.Format(base.ChequeClearingDate, "yyyy-MM-dd") + "'") : (strSql + "Null"));
							strSql += ")";
							Module1.sqlNonQuery(strSql, "data");
						}
						if (!Information.IsNothing(_allocation))
						{
							cSalesInvoicePayment[] allocation = _allocation;
							foreach (cSalesInvoicePayment cSalesInvoicePayment2 in allocation)
							{
								string strSql = " INSERT INTO penjbayar  (pbDate,pbAmount,pkId, salesId,penjId,pbgId, accountId) VALUES  ('" + Strings.Format(base.PaymentDate, "yyyy-MM-dd") + "'," + Module1.unformatNumber(Conversions.ToString(cSalesInvoicePayment2.Amount)) + "," + Conversions.ToString(base.PaymentCodeId) + "," + Conversions.ToString(base.SalesPersonId) + "," + Conversions.ToString(cSalesInvoicePayment2.InvoiceId) + "," + Conversions.ToString(base.MultiPaymentId) + "," + Conversions.ToString(base.AccountId) + ")";
								Module1.sqlNonQuery(strSql, "data");
								strSql = " UPDATE penjualan  SET penjBayar =  (SELECT SUM(pbAmount) FROM penjBayar  WHERE penjId = " + Conversions.ToString(cSalesInvoicePayment2.InvoiceId) + ")  WHERE penjId = " + Conversions.ToString(cSalesInvoicePayment2.InvoiceId);
								Module1.sqlNonQuery(strSql, "data");
								strSql = " SELECT penjTotal-penjBs-penjDisc-penjPot-penjBayar AS Receivable  FROM penjualan  WHERE penjId = " + Conversions.ToString(cSalesInvoicePayment2.InvoiceId);
								DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
								double num4 = Conversions.ToDouble(dataTable.Rows[0]["Receivable"]);
								if (num4 == 0.0)
								{
									strSql = " SELECT pbDate  FROM penjbayar  WHERE penjId = " + Conversions.ToString(cSalesInvoicePayment2.InvoiceId) + " ORDER BY pbDate DESC ";
									dataTable = Module1.sqlTable(strSql, "data", Clone: false);
									DateTime dateTime = Conversions.ToDate(dataTable.Rows[0]["pbDate"]);
									strSql = " SELECT penjDate  FROM penjualan  WHERE penjId IN  (SELECT penjBsId   FROM penjBs   WHERE penjId = " + Conversions.ToString(cSalesInvoicePayment2.InvoiceId) + ") ORDER BY penjDate DESC ";
									dataTable = Module1.sqlTable(strSql, "data", Clone: false);
									if (dataTable.Rows.Count > 0 && Operators.ConditionalCompareObjectLess(dateTime, dataTable.Rows[0]["penjDate"], TextCompare: false))
									{
										dateTime = Conversions.ToDate(dataTable.Rows[0]["penjDate"]);
									}
									strSql = " UPDATE penjualan  SET penjLunas = '" + Strings.Format(dateTime, "yyyy-MM-dd") + "' WHERE penjId = " + Conversions.ToString(cSalesInvoicePayment2.InvoiceId);
									Module1.sqlNonQuery(strSql, "data");
								}
							}
						}
						val.Commit();
						goto end_IL_0001;
					case 2094:
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
					goto IL_0864;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 2094;
				continue;
			}
			break;
			IL_0864:
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
						string strSql = " DELETE FROM girocek  WHERE pbgId = " + Conversions.ToString(base.MultiPaymentId);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " SELECT * FROM penjbayar  WHERE pbgId = " + Conversions.ToString(base.MultiPaymentId);
						DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
						int num3 = dataTable.Rows.Count - 1;
						for (int i = 0; i <= num3; i++)
						{
							strSql = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" UPDATE penjualan  SET penjBayar =  (SELECT IFNULL(SUM(pbAmount),0) FROM penjbayar  WHERE penjId = ", dataTable.Rows[i]["penjId"]), " AND pbgId = 0) "), " WHERE penjId = "), dataTable.Rows[i]["penjId"]));
							Module1.sqlNonQuery(strSql, "data");
						}
						strSql = " DELETE FROM penjBayar  WHERE pbgId = " + Conversions.ToString(base.MultiPaymentId);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " DELETE FROM penjbayargroup  WHERE pbgId = " + Conversions.ToString(base.MultiPaymentId);
						Module1.sqlNonQuery(strSql, "data");
						val.Commit();
						goto end_IL_0001;
					}
					case 399:
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
					goto IL_01c5;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 399;
				continue;
			}
			break;
			IL_01c5:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
