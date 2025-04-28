using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace GCUv2;

public class cInvoiceNumber
{
	public struct NumberRange
	{
		public double _begin;

		public double _end;
	}

	private int _salesPersonId;

	private int _year;

	private double _latestNumber;

	private NumberRange[] _range;

	private string _salesPersonCode;

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

	public int Year
	{
		get
		{
			return _year;
		}
		set
		{
			_year = value;
		}
	}

	public double LatestNumber
	{
		get
		{
			return _latestNumber;
		}
		set
		{
			_latestNumber = value;
		}
	}

	public NumberRange[] Range
	{
		get
		{
			return _range;
		}
		set
		{
			_range = value;
		}
	}

	public string SalesPersonCode
	{
		get
		{
			return _salesPersonCode;
		}
		set
		{
			_salesPersonCode = value;
		}
	}

	public cInvoiceNumber(int SalesPersonId, int Year)
	{
		if (!(SalesPersonId > 0 && Year > 0))
		{
			return;
		}
		DataTable dataTable = SearchInvoiceNumber(SalesPersonId, Year, blnAll: false, 0);
		checked
		{
			_range = new NumberRange[dataTable.Rows.Count - 1 + 1];
			int num = default(int);
			foreach (DataRow row in dataTable.Rows)
			{
				_range[num]._begin = Conversion.Val(RuntimeHelpers.GetObjectValue(row["fsBegin"]));
				_range[num]._end = Conversion.Val(RuntimeHelpers.GetObjectValue(row["fsEnd"]));
				num++;
			}
			_latestNumber = GetLatestNumber(Year, SalesPersonId, 0, 1);
			string strSql = " SELECT salesFakNo  FROM sales  WHERE salesId = " + Conversions.ToString(SalesPersonId);
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			_salesPersonCode = Conversions.ToString(dataTable.Rows[0]["salesFakNo"]);
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
					string strSql = " UPDATE sales  SET salesFakNo = '" + _salesPersonCode + "' WHERE salesId = " + Conversions.ToString(_salesPersonId);
					Module1.sqlNonQuery(strSql, "data");
					strSql = " DELETE FROM FakturSales  WHERE salesId = " + Conversions.ToString(_salesPersonId) + " AND fakturYear = " + Conversions.ToString(_year);
					Module1.sqlNonQuery(strSql, "data");
					NumberRange[] range = _range;
					for (int i = 0; i < range.Length; i = checked(i + 1))
					{
						NumberRange numberRange = range[i];
						strSql = " INSERT INTO FakturSales  (fsBegin, fsEnd, salesId, fakturYear) VALUES  ( " + Conversions.ToString(numberRange._begin) + "," + Conversions.ToString(numberRange._end) + "," + Conversions.ToString(_salesPersonId) + "," + Conversions.ToString(_year) + ")";
						Module1.sqlNonQuery(strSql, "data");
					}
					strSql = " DELETE FROM FakturLatest  WHERE fakturYear = " + Conversions.ToString(_year) + " AND salesId = " + Conversions.ToString(_salesPersonId) + " AND fakturType = 1 ";
					Module1.sqlNonQuery(strSql, "data");
					strSql = " INSERT INTO FakturLatest(fakturYear,fakturLatestNo,salesId,branchId,fakturType) VALUES  (" + Conversions.ToString(_year) + "," + Conversions.ToString(_latestNumber) + "," + Conversions.ToString(_salesPersonId) + ",0,1)";
					Module1.sqlNonQuery(strSql, "data");
					val.Commit();
					goto end_IL_0001;
				}
				case 570:
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
				goto IL_0270;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 570;
				continue;
			}
			break;
			IL_0270:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static DataTable SearchInvoiceNumber(int intSales, int intYear, bool blnAll, int intBranchId)
	{
		string strSql = ((!blnAll) ? (" SELECT * FROM FakturSales  WHERE salesId = " + Conversions.ToString(intSales) + "  AND FakturYear = " + Conversions.ToString(intYear) + "  ORDER BY CONVERT(fsBegin,SIGNED) ") : (" SELECT a.*, salesName  FROM FakturSales a, sales b WHERE a.salesId <> " + Conversions.ToString(intSales) + " AND a.salesId = b.salesId  AND FakturYear = " + Conversions.ToString(intYear) + "  AND a.salesId IN (SELECT salesId FROM sales WHERE branchId = " + Conversions.ToString(intBranchId) + ")  AND a.salesId NOT IN (SELECT salesId FROM sales WHERE salesDonation = 1)  ORDER BY CONVERT(fsBegin,SIGNED) "));
		return Module1.sqlTable(strSql, "data", Clone: false);
	}

	public static double GetLatestNumber(int intYear, int intSalesId, int intBranchId, int intType)
	{
		double result = 0.0;
		string text = " SELECT * FROM fakturLatest  WHERE fakturYear = " + Conversions.ToString(intYear) + " AND fakturType = " + Conversions.ToString(intType);
		switch (intType)
		{
		case 1:
			text = text + " AND salesId = " + Conversions.ToString(intSalesId);
			break;
		case 2:
			text = text + " AND branchId = " + Conversions.ToString(intBranchId);
			break;
		}
		DataTable dataTable = Module1.sqlTable(text, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			result = Conversions.ToDouble(dataTable.Rows[0]["fakturLatestNo"]);
		}
		return result;
	}

	public static bool IsUsed(DataTable MyData, DataGridView dgvList)
	{
		bool flag = false;
		checked
		{
			foreach (DataRow row in MyData.Rows)
			{
				int num = dgvList.Rows.Count - 2;
				int i;
				for (i = 0; i <= num; i++)
				{
					if ((Conversion.Val(RuntimeHelpers.GetObjectValue(dgvList[0, i].Value)) >= Conversion.Val(RuntimeHelpers.GetObjectValue(row["fsBegin"]))) & (Conversion.Val(RuntimeHelpers.GetObjectValue(dgvList[0, i].Value)) <= Conversion.Val(RuntimeHelpers.GetObjectValue(row["fsEnd"]))))
					{
						flag = true;
						break;
					}
					if ((Conversion.Val(RuntimeHelpers.GetObjectValue(dgvList[1, i].Value)) >= Conversion.Val(RuntimeHelpers.GetObjectValue(row["fsBegin"]))) & (Conversion.Val(RuntimeHelpers.GetObjectValue(dgvList[1, i].Value)) <= Conversion.Val(RuntimeHelpers.GetObjectValue(row["fsEnd"]))))
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Kelompok No Faktur ", dgvList[0, i].Value), "-"), dgvList[1, i].Value), " telah dipakai oleh sales "), row["salesName"]), ". Masukkan nomer lain."), MsgBoxStyle.Information);
					bool flag2 = true;
					break;
				}
			}
			return flag;
		}
	}

	public static bool isExist(string strFaktur, bool blnFP, DateTime datInput, double intId)
	{
		int num = DateAndTime.Year(datInput);
		bool flag = false;
		if (!blnFP)
		{
			if (Module1.pubDuplicateSalesInvoiceNumber == -1)
			{
				strFaktur = Module1.FormatInvoiceNumber(strFaktur);
			}
			else
			{
				strFaktur = Module1.RemoveChar(strFaktur);
				strFaktur = Module1.FormatTaxInvoiceNumber(strFaktur);
			}
			string strSql = " select PenjFaktur from Penjualan  where Year(penjDate) = " + Conversions.ToString(num) + " and penjFaktur like '%" + strFaktur + "'  and penjFp = 0  and penjId <> " + Conversions.ToString(intId) + " ";
			DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count == 0)
			{
				flag = false;
			}
			else
			{
				string inputStr = "";
				foreach (DataRow row in dataTable.Rows)
				{
					if (Module1.pubDuplicateSalesInvoiceNumber == 0)
					{
						inputStr = Module1.RemoveChar(Conversions.ToString(dataTable.Rows[0]["penjFaktur"]));
					}
					if (Conversion.Val(strFaktur) == Conversion.Val(inputStr))
					{
						flag = true;
						break;
					}
				}
			}
		}
		else
		{
			string strSql = " select PenjFaktur from Penjualan  where penjFaktur = '" + Module1.FormatInvoiceNumber(strFaktur) + "'  and Year(penjDate) = " + Conversions.ToString(num) + "  and penjId <> " + Conversions.ToString(intId) + " ";
			DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			flag = ((dataTable.Rows.Count != 0) ? true : false);
		}
		if (blnFP && !flag)
		{
			string strSql = " select PenjFP from Penjualan  where penjFP = " + Conversions.ToString(Conversion.Val(strFaktur)) + "  and Year(penjDate) = " + Conversions.ToString(num) + "  and penjId <> " + Conversions.ToString(intId) + " ";
			DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				flag = true;
			}
		}
		return flag;
	}

	public static bool isMyNumber(string strFaktur, bool blnFP, int intSalesId, int intYear)
	{
		strFaktur = Module1.RemoveChar(strFaktur);
		bool result = false;
		if (!blnFP)
		{
			string strSql = " select * from fakturSales  where salesId = " + Conversions.ToString(intSalesId) + "  and CONVERT(fsBegin,SIGNED) <= " + Conversions.ToString(Conversion.Val(strFaktur)) + "  and CONVERT(fsEnd,SIGNED) >= " + Conversions.ToString(Conversion.Val(strFaktur)) + "  and FakturYear = " + Conversions.ToString(intYear) + " ";
			DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				result = true;
			}
		}
		else if (blnFP)
		{
			string strSql = " select * from FakturPajak  where CONVERT(fsBegin,SIGNED) <= " + Conversions.ToString(Conversion.Val(strFaktur)) + "  and CONVERT(fsEnd,SIGNED) >= " + Conversions.ToString(Conversion.Val(strFaktur)) + "  and FakturYear = " + Conversions.ToString(intYear) + "  and branchId = (select branchId from sales where salesId=" + Conversions.ToString(intSalesId) + ") ";
			DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				result = true;
			}
		}
		return result;
	}

	public static bool isMyCode(string strFaktur, bool blnFP, int intSalesId)
	{
		bool result = false;
		string startingChar = Module1.GetStartingChar(Module1.cleanString(strFaktur));
		if (!blnFP)
		{
			strFaktur = Module1.RemoveChar(strFaktur);
			string strSql = " select salesId from Sales  where salesId = " + Conversions.ToString(intSalesId) + "  and salesFakNo = '" + startingChar + "' ";
			DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				result = true;
			}
		}
		else if (blnFP)
		{
			if (Operators.CompareString(startingChar, "", TextCompare: false) == 0)
			{
				result = true;
			}
		}
		else if (Operators.CompareString(startingChar, "IT", TextCompare: false) == 0)
		{
			result = true;
		}
		return result;
	}
}
