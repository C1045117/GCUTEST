using System;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace GCUv2;

public class cTaxInvoiceNumber
{
	public struct NumberRange
	{
		public double _begin;

		public double _end;
	}

	private int _branchId;

	private int _year;

	private double _latestNumber;

	private NumberRange[] _range;

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

	public cTaxInvoiceNumber(int BranchId, int Year)
	{
		if (!(BranchId > 0 && Year > 0))
		{
			return;
		}
		DataTable dataTable = SearchTaxInvoiceNumber(BranchId, Year, All: false);
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
			_latestNumber = cInvoiceNumber.GetLatestNumber(Year, 0, BranchId, 2);
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
					string strSql = " DELETE FROM FakturPajak  WHERE branchId = " + Conversions.ToString(_branchId) + " AND fakturYear = " + Conversions.ToString(_year);
					Module1.sqlNonQuery(strSql, "data");
					NumberRange[] range = _range;
					for (int i = 0; i < range.Length; i = checked(i + 1))
					{
						NumberRange numberRange = range[i];
						strSql = " INSERT INTO FakturPajak  (fsBegin, fsEnd, branchId, fakturYear) VALUES  ( " + Conversions.ToString(numberRange._begin) + "," + Conversions.ToString(numberRange._end) + "," + Conversions.ToString(_branchId) + "," + Conversions.ToString(_year) + ")";
						Module1.sqlNonQuery(strSql, "data");
					}
					strSql = " DELETE FROM FakturLatest  WHERE fakturYear = " + Conversions.ToString(_year) + " AND branchId = " + Conversions.ToString(_branchId) + " AND fakturType = 2 ";
					Module1.sqlNonQuery(strSql, "data");
					strSql = " INSERT INTO FakturLatest(fakturYear,fakturLatestNo,salesId,branchId,fakturType) VALUES  (" + Conversions.ToString(_year) + "," + Conversions.ToString(_latestNumber) + ",0," + Conversions.ToString(_branchId) + ",2)";
					Module1.sqlNonQuery(strSql, "data");
					val.Commit();
					goto end_IL_0001;
				}
				case 525:
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
				goto IL_0243;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 525;
				continue;
			}
			break;
			IL_0243:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static DataTable SearchTaxInvoiceNumber(int BranchId, int Year, bool All)
	{
		string strSql = ((!All) ? (" SELECT *  FROM FakturPajak WHERE branchId = " + Conversions.ToString(BranchId) + "  AND FakturYear = " + Conversions.ToString(Year) + "  ORDER BY fsBegin ") : (" SELECT *  FROM FakturPajak WHERE branchId <> " + Conversions.ToString(BranchId) + "  AND FakturYear = " + Conversions.ToString(Year) + "  ORDER BY fsBegin "));
		return Module1.sqlTable(strSql, "data", Clone: false);
	}
}
