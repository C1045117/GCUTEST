using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cPrintSetting
{
	private string _companyName;

	private string _companyDetail1;

	private string _companyDetail2;

	private string _companyDetail3;

	private string _companyCity;

	private string _NPWP;

	private string _taxAddress;

	private string _taxNumber;

	private string _taxPersonName;

	private string _taxPersonPosition;

	private string _salesReceiptCode;

	private string _salesReceiptDescription;

	private string _salesReceiptPersonName;

	private string _salesReceiptCity;

	public string CompanyName
	{
		get
		{
			return _companyName;
		}
		set
		{
			_companyName = Module1.cleanString(value);
		}
	}

	public string CompanyDetail1
	{
		get
		{
			return _companyDetail1;
		}
		set
		{
			_companyDetail1 = Module1.cleanString(value);
		}
	}

	public string CompanyDetail2
	{
		get
		{
			return _companyDetail2;
		}
		set
		{
			_companyDetail2 = Module1.cleanString(value);
		}
	}

	public string CompanyDetail3
	{
		get
		{
			return _companyDetail3;
		}
		set
		{
			_companyDetail3 = Module1.cleanString(value);
		}
	}

	public string CompanyCity
	{
		get
		{
			return _companyCity;
		}
		set
		{
			_companyCity = Module1.cleanString(value);
		}
	}

	public string NPWP
	{
		get
		{
			return _NPWP;
		}
		set
		{
			_NPWP = value;
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

	public string TaxAddress
	{
		get
		{
			return _taxAddress;
		}
		set
		{
			_taxAddress = value;
		}
	}

	public string TaxPersonName
	{
		get
		{
			return _taxPersonName;
		}
		set
		{
			_taxPersonName = Module1.cleanString(value);
		}
	}

	public string TaxPersonPosition
	{
		get
		{
			return _taxPersonPosition;
		}
		set
		{
			_taxPersonPosition = Module1.cleanString(value);
		}
	}

	public string SalesReceiptCode
	{
		get
		{
			return _salesReceiptCode;
		}
		set
		{
			_salesReceiptCode = Module1.cleanString(value);
		}
	}

	public string SalesReceiptDescription
	{
		get
		{
			return _salesReceiptDescription;
		}
		set
		{
			_salesReceiptDescription = Module1.cleanString(value);
		}
	}

	public string SalesReceiptPersonName
	{
		get
		{
			return _salesReceiptPersonName;
		}
		set
		{
			_salesReceiptPersonName = Module1.cleanString(value);
		}
	}

	public string SalesReceiptCity
	{
		get
		{
			return _salesReceiptCity;
		}
		set
		{
			_salesReceiptCity = Module1.cleanString(value);
		}
	}

	public cPrintSetting(int Id)
	{
		if (Id > 0)
		{
			string strSql = " SELECT * FROM settingsPrint ";
			DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				_companyName = Conversions.ToString(dataTable.Rows[0]["printCompany"]);
				_companyDetail1 = Conversions.ToString(dataTable.Rows[0]["printNote1"]);
				_companyDetail2 = Conversions.ToString(dataTable.Rows[0]["printNote2"]);
				_companyDetail3 = Conversions.ToString(dataTable.Rows[0]["printNote3"]);
				_companyCity = Conversions.ToString(dataTable.Rows[0]["printCity"]);
				_NPWP = Conversions.ToString(dataTable.Rows[0]["printNpwp"]);
				_taxNumber = Conversions.ToString(dataTable.Rows[0]["printTaxNumber"]);
				_taxAddress = Conversions.ToString(dataTable.Rows[0]["printTaxAddress"]);
				_taxPersonName = Conversions.ToString(dataTable.Rows[0]["printTaxName"]);
				_taxPersonPosition = Conversions.ToString(dataTable.Rows[0]["printPosition"]);
				_salesReceiptCode = Conversions.ToString(dataTable.Rows[0]["salesReceiptCode"]);
				_salesReceiptDescription = Conversions.ToString(dataTable.Rows[0]["salesReceiptDescription"]);
				_salesReceiptPersonName = Conversions.ToString(dataTable.Rows[0]["printKuiName"]);
				_salesReceiptCity = Conversions.ToString(dataTable.Rows[0]["printKuiCity"]);
			}
		}
	}

	public void Save()
	{
		string strSql = " UPDATE settingsPrint SET  printCompany = '" + _companyName + "', printNote1 = '" + _companyDetail1 + "', printNote2 = '" + _companyDetail2 + "', printNote3 = '" + _companyDetail3 + "', printCity = '" + _companyCity + "', printNpwp = '" + _NPWP + "', printTaxNumber = '" + _taxNumber + "', printTaxAddress = '" + _taxAddress + "', printTaxName = '" + _taxPersonName + "', printPosition = '" + _taxPersonPosition + "', salesReceiptCode = '" + _salesReceiptCode + "', salesReceiptDescription = '" + _salesReceiptDescription + "', printKuiName = '" + _salesReceiptPersonName + "', printKuiCity = '" + _salesReceiptCity + "'";
		Module1.sqlNonQuery(strSql, "data");
	}
}
