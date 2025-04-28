using System.Data;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace GCUv2;

public class cReturnTaxInvoiceNumber
{
	private int _year;

	private double _latestNumber;

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

	public cReturnTaxInvoiceNumber(int Year)
	{
		if (Year > 0)
		{
			string strSql = " SELECT *  FROM fakturLatest  WHERE fakturType = 4  AND fakturYear = " + Conversions.ToString(Year);
			DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				_latestNumber = Conversions.ToDouble(dataTable.Rows[0]["fakturLatestNo"]);
			}
			else
			{
				_latestNumber = 0.0;
			}
		}
	}

	public void Save()
	{
		MySqlTransaction val = Module1.connectData.BeginTransaction();
		string strSql = " DELETE FROM FakturLatest  WHERE fakturYear = " + Conversions.ToString(_year) + " AND fakturType = 4 ";
		Module1.sqlNonQuery(strSql, "data");
		strSql = " INSERT INTO FakturLatest";
		strSql = " INSERT INTO FakturLatest(fakturYear,fakturLatestNo,salesId,branchId,fakturType) VALUES  (" + Conversions.ToString(_year) + "," + Conversions.ToString(_latestNumber) + ",0,0,4)";
		Module1.sqlNonQuery(strSql, "data");
		val.Commit();
	}
}
