using System;
using System.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cCustomer
{
	private double _id;

	private string _name;

	private string _address;

	private string _city;

	private string _postCode;

	private string _phone;

	private string _fax;

	private string _PT;

	private string _NPWP;

	private string _taxAddress;

	private string _taxCity;

	private string _taxPostCode;

	private string _contact;

	private int _creditLimit;

	private int _TOP;

	private int _specialTOP;

	private DateTime _createdDate;

	private string _note;

	private int _customerCodeId;

	private string _customerCodeName;

	private int _priceCodeId;

	private string _priceCodeName;

	private int _salesPersonId;

	private string _salesPersonName;

	private int _collectorId;

	private string _collectorName;

	private int _discountId;

	private string _discountName;

	private int _discountType;

	private int _areaId;

	private string _areaName;

	private int _active;

	private int _tukarFaktur;

	private int _cashAccountId;

	private string _cashAccountName;

	private int _bankAccountId;

	private string _bankAccountName;

	private int _storageId;

	private string _storageName;

	private int _branchId;

	private double _parentId;

	private string _parentName;

	private int _isParent;

	private string[] _memberName;

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

	public string Name
	{
		get
		{
			return _name;
		}
		set
		{
			_name = Module1.cleanString(value);
		}
	}

	public string Address
	{
		get
		{
			return _address;
		}
		set
		{
			_address = Module1.cleanString(value);
		}
	}

	public string City
	{
		get
		{
			return _city;
		}
		set
		{
			_city = Module1.cleanString(value);
		}
	}

	public string PostCode
	{
		get
		{
			return _postCode;
		}
		set
		{
			_postCode = Module1.cleanString(value);
		}
	}

	public string Phone
	{
		get
		{
			return _phone;
		}
		set
		{
			_phone = Module1.cleanString(value);
		}
	}

	public string Fax
	{
		get
		{
			return _fax;
		}
		set
		{
			_fax = Module1.cleanString(value);
		}
	}

	public string PT
	{
		get
		{
			return _PT;
		}
		set
		{
			_PT = Module1.cleanString(value);
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
			_NPWP = Module1.cleanString(value);
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
			_taxAddress = Module1.cleanString(value);
		}
	}

	public string TaxCity
	{
		get
		{
			return _taxCity;
		}
		set
		{
			_taxCity = Module1.cleanString(value);
		}
	}

	public string TaxPostCode
	{
		get
		{
			return _taxPostCode;
		}
		set
		{
			_taxPostCode = Module1.cleanString(value);
		}
	}

	public string Contact
	{
		get
		{
			return _contact;
		}
		set
		{
			_contact = Module1.cleanString(value);
		}
	}

	public int CreditLimit
	{
		get
		{
			return _creditLimit;
		}
		set
		{
			_creditLimit = value;
		}
	}

	public int TOP
	{
		get
		{
			return _TOP;
		}
		set
		{
			_TOP = value;
		}
	}

	public int SpecialTOP
	{
		get
		{
			return _specialTOP;
		}
		set
		{
			_specialTOP = value;
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

	public int CustomerCodeId
	{
		get
		{
			return _customerCodeId;
		}
		set
		{
			_customerCodeId = value;
		}
	}

	public string CustomerCodeName
	{
		get
		{
			return _customerCodeName;
		}
		set
		{
			_customerCodeName = value;
		}
	}

	public int PriceCodeId
	{
		get
		{
			return _priceCodeId;
		}
		set
		{
			_priceCodeId = value;
		}
	}

	public string PriceCodeName
	{
		get
		{
			return _priceCodeName;
		}
		set
		{
			_priceCodeName = value;
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

	public string SalesPersonName
	{
		get
		{
			return _salesPersonName;
		}
		set
		{
			_salesPersonName = value;
		}
	}

	public int CollectorId
	{
		get
		{
			return _collectorId;
		}
		set
		{
			_collectorId = value;
		}
	}

	public string CollectorName
	{
		get
		{
			return _collectorName;
		}
		set
		{
			_collectorName = value;
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

	public string DiscountName
	{
		get
		{
			return _discountName;
		}
		set
		{
			_discountName = value;
		}
	}

	public int DiscountType
	{
		get
		{
			return _discountType;
		}
		set
		{
			_discountType = value;
		}
	}

	public int AreaId
	{
		get
		{
			return _areaId;
		}
		set
		{
			_areaId = value;
		}
	}

	public string AreaName
	{
		get
		{
			return _areaName;
		}
		set
		{
			_areaName = value;
		}
	}

	public int Active
	{
		get
		{
			return _active;
		}
		set
		{
			_active = value;
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

	public string BankAccountName
	{
		get
		{
			return _bankAccountName;
		}
		set
		{
			_bankAccountName = value;
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

	public string StorageName
	{
		get
		{
			return _storageName;
		}
		set
		{
			_storageName = value;
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

	public double ParentId
	{
		get
		{
			return _parentId;
		}
		set
		{
			_parentId = value;
		}
	}

	public string ParentName
	{
		get
		{
			return _parentName;
		}
		set
		{
			_parentName = value;
		}
	}

	public int IsParent
	{
		get
		{
			return _isParent;
		}
		set
		{
			_isParent = value;
		}
	}

	public string[] MemberName
	{
		get
		{
			return _memberName;
		}
		set
		{
			_memberName = value;
		}
	}

	public cCustomer(double CustomerId)
	{
		if (!(CustomerId > 0.0))
		{
			return;
		}
		_id = CustomerId;
		DataTable dataTable = new DataTable();
		string strSql = " SELECT a.*,b.ckName,c.HargaKode,d.salesName,e.discName,e.discType,f.wilName,g.accountName as cashAccountName,h.accountName as bankAccountName,i.storeName,  j.salesName AS tagihName, IFNULL(gc.custName,'----') as custParentName  FROM Customer a LEFT OUTER JOIN customer gc ON a.custParentId = gc.custId,CustKode b,Harga c,Sales d,Discount e,Wilayah f,account g,account h,Storages i, Sales j WHERE a.custId = " + Conversions.ToString(Id) + "  AND a.ckId = b.ckID  AND a.hargaId = c.hargaId  AND a.salesId = d.salesId  AND a.tagihId = j.salesId  AND a.discId = e.discId  AND a.wilId = f.wilId  AND a.kgId = g.accountId  AND a.tgId = h.accountId  AND a.storeId = i.storeId ";
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			_name = Conversions.ToString(dataTable.Rows[0]["custName"]);
			_address = Conversions.ToString(dataTable.Rows[0]["custAddress"]);
			_city = Conversions.ToString(dataTable.Rows[0]["custCity"]);
			_postCode = Conversions.ToString(dataTable.Rows[0]["custPc"]);
			_phone = Conversions.ToString(dataTable.Rows[0]["custPhone"]);
			_fax = Conversions.ToString(dataTable.Rows[0]["custFax"]);
			_PT = Conversions.ToString(dataTable.Rows[0]["custPt"]);
			_NPWP = Conversions.ToString(dataTable.Rows[0]["custNPWP"]);
			_taxAddress = Conversions.ToString(dataTable.Rows[0]["custTaxAddress"]);
			_taxCity = Conversions.ToString(dataTable.Rows[0]["custTaxCity"]);
			_taxPostCode = Conversions.ToString(dataTable.Rows[0]["custTaxPc"]);
			_contact = Conversions.ToString(dataTable.Rows[0]["custContact"]);
			_creditLimit = Conversions.ToInteger(dataTable.Rows[0]["custPiutang"]);
			_TOP = Conversions.ToInteger(dataTable.Rows[0]["custTop"]);
			_specialTOP = Conversions.ToInteger(dataTable.Rows[0]["custSTop"]);
			_createdDate = Conversions.ToDate(dataTable.Rows[0]["custSince"]);
			_note = Conversions.ToString(dataTable.Rows[0]["custNote"]);
			_customerCodeId = Conversions.ToInteger(dataTable.Rows[0]["ckId"]);
			_customerCodeName = Conversions.ToString(dataTable.Rows[0]["ckName"]);
			_priceCodeId = Conversions.ToInteger(dataTable.Rows[0]["hargaId"]);
			_priceCodeName = Conversions.ToString(dataTable.Rows[0]["hargaKode"]);
			_salesPersonId = Conversions.ToInteger(dataTable.Rows[0]["salesId"]);
			_salesPersonName = Conversions.ToString(dataTable.Rows[0]["salesName"]);
			_collectorId = Conversions.ToInteger(dataTable.Rows[0]["tagihId"]);
			_collectorName = Conversions.ToString(dataTable.Rows[0]["tagihName"]);
			_discountId = Conversions.ToInteger(dataTable.Rows[0]["discId"]);
			_discountName = Conversions.ToString(dataTable.Rows[0]["discName"]);
			_discountType = Conversions.ToInteger(dataTable.Rows[0]["discType"]);
			_areaId = Conversions.ToInteger(dataTable.Rows[0]["wilId"]);
			_areaName = Conversions.ToString(dataTable.Rows[0]["wilName"]);
			_cashAccountId = Conversions.ToInteger(dataTable.Rows[0]["kgId"]);
			_cashAccountName = Conversions.ToString(dataTable.Rows[0]["cashAccountName"]);
			_bankAccountId = Conversions.ToInteger(dataTable.Rows[0]["tgId"]);
			_bankAccountName = Conversions.ToString(dataTable.Rows[0]["bankAccountName"]);
			_storageId = Conversions.ToInteger(dataTable.Rows[0]["storeId"]);
			_storageName = Conversions.ToString(dataTable.Rows[0]["storeName"]);
			_active = Conversions.ToInteger(dataTable.Rows[0]["custActive"]);
			_tukarFaktur = Conversions.ToInteger(dataTable.Rows[0]["custTf"]);
			_branchId = Conversions.ToInteger(dataTable.Rows[0]["branchId"]);
			_parentId = Conversions.ToDouble(dataTable.Rows[0]["custParentId"]);
			_parentName = Conversions.ToString(dataTable.Rows[0]["custParentName"]);
			_isParent = Conversions.ToInteger(dataTable.Rows[0]["isParent"]);
		}
		strSql = " SELECT * FROM customer  WHERE isParent = 0  AND custParentId = " + Conversions.ToString(_id) + " AND custId <> custParentId  ORDER BY custName ";
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count <= 0)
		{
			return;
		}
		checked
		{
			_memberName = new string[dataTable.Rows.Count - 1 + 1];
			int num = 0;
			foreach (DataRow row in dataTable.Rows)
			{
				_memberName[num] = Conversions.ToString(row["custName"]);
				num++;
			}
		}
	}

	public void save()
	{
		if (_id == 0.0)
		{
			string strSql = " INSERT INTO Customer(custName,custAddress,custCity,  custPC,custPhone,custFax, custPT,custNPWP,custTaxAddress,  custTaxCity,custTaxPC,custContact,  custPiutang,custTOP,custSTOP,  custSince,custNote,custCreated,  ckID,hargaID,salesID,  discId,wilId,kgId,  tgId,storeId,custTf,  custParentId,custActive,branchId,  tagihId,isParent) values  ('" + _name + "','" + _address + "','" + _city + "','" + _postCode + "', '" + _phone + "','" + _fax + "','" + _PT + "','" + _NPWP + "','" + _taxAddress + "','" + _taxCity + "','" + _taxPostCode + "','" + _contact + "'," + Conversions.ToString(_creditLimit) + ", " + Conversions.ToString(_TOP) + ", " + Conversions.ToString(_specialTOP) + ",'" + Strings.Format(_createdDate, "yyyy-MM-dd") + "','" + _note + "','" + Strings.Format(DateAndTime.Now, "yyyy-MM-dd HH:mm:ss") + "'," + Conversions.ToString(_customerCodeId) + "," + Conversions.ToString(_priceCodeId) + "," + Conversions.ToString(_salesPersonId) + ", " + Conversions.ToString(_discountId) + "," + Conversions.ToString(_areaId) + "," + Conversions.ToString(_cashAccountId) + "," + Conversions.ToString(_bankAccountId) + ", " + Conversions.ToString(_storageId) + "," + Conversions.ToString(_tukarFaktur) + "," + Conversions.ToString(_parentId) + ", " + Conversions.ToString(_active) + ", " + Conversions.ToString(_branchId) + ", " + Conversions.ToString(_collectorId) + "," + Conversions.ToString(_isParent) + ")";
			Module1.sqlNonQuery(strSql, "data");
			_id = cDatabase.LastId("data");
			if (_parentId == 0.0)
			{
				strSql = " UPDATE customer SET  custParentId = " + Conversions.ToString(_id) + " WHERE custId = " + Conversions.ToString(_id);
				Module1.sqlNonQuery(strSql, "data");
			}
		}
		else
		{
			string strSql = " UPDATE Customer  SET custName = '" + _name + "', custAddress = '" + _address + "', custCity = '" + _city + "', custPc = '" + _postCode + "', custPhone = '" + _phone + "', custFax = '" + _fax + "', custPt = '" + _PT + "', custNPWP = '" + _NPWP + "', custTaxAddress = '" + _taxAddress + "', custTaxCity = '" + _taxCity + "', custTaxPc = '" + _taxPostCode + "', custContact = '" + _contact + "' , custPiutang = " + Conversions.ToString(_creditLimit) + ", custtop=" + Conversions.ToString(_TOP) + ", custstop=" + Conversions.ToString(_specialTOP) + ",  custSince = '" + Strings.Format(_createdDate, "yyyy-MM-dd") + "', custNote = '" + _note + "', custTf = " + Conversions.ToString(_tukarFaktur) + ",  ckId = " + Conversions.ToString(_customerCodeId) + ", hargaId = " + Conversions.ToString(_priceCodeId) + ", discId = " + Conversions.ToString(_discountId) + ", salesId = " + Conversions.ToString(_salesPersonId) + ", tagihId = " + Conversions.ToString(_collectorId) + ",  wilId = " + Conversions.ToString(_areaId) + ",  kgId = " + Conversions.ToString(_cashAccountId) + ",tgId = " + Conversions.ToString(_bankAccountId) + ", storeId = " + Conversions.ToString(_storageId) + ",  isParent = " + Conversions.ToString(_isParent) + ",custParentId = " + Conversions.ToString(_parentId) + ", custActive = " + Conversions.ToString(_active) + ",  BranchId = " + Conversions.ToString(_branchId) + " WHERE custId = " + Conversions.ToString(_id) + " ";
			Module1.sqlNonQuery(strSql, "data");
		}
	}

	public static DataTable Search(string Name, string Address, int CustomerCodeId, int SalesId, int PriceCodeId, int AreaId, int DiscountId, int Active, bool BelongToGroup, int StorageId, int GroupId, int BranchId, int intMM, int intYY, int isParent)
	{
		string text = " SELECT a.*,b.salesName,c.ckName, d.wilName  FROM customer a,sales b, custKode c, wilayah d  WHERE a.salesID = b.salesID and a.ckID = c.ckID and a.wilId = d.wilId ";
		if (Operators.CompareString(Name, "", TextCompare: false) != 0)
		{
			text = text + " AND custName like '%" + Name + "%'";
		}
		if (Operators.CompareString(Address, "", TextCompare: false) != 0)
		{
			text = text + " AND custAddress like '%" + Address + "%'";
		}
		if (CustomerCodeId != 0)
		{
			text = text + " AND a.ckId = " + Conversions.ToString(CustomerCodeId);
		}
		if (SalesId != 0)
		{
			text = text + " AND a.salesId = " + Conversions.ToString(SalesId);
		}
		if (PriceCodeId != 0)
		{
			text = text + " AND a.hargaId = " + Conversions.ToString(PriceCodeId);
		}
		if (AreaId != 0)
		{
			text = text + " AND a.wilId = " + Conversions.ToString(AreaId);
		}
		if (DiscountId != 0)
		{
			text = text + " AND a.discId = " + Conversions.ToString(DiscountId);
		}
		if (Active < 2)
		{
			text = text + " AND a.custActive = " + Conversions.ToString(Active);
		}
		if (intMM > 0 && intYY > 0)
		{
			text = text + " AND MONTH(a.custSince) = " + Conversions.ToString(intMM) + " AND YEAR(a.custSince) = " + Conversions.ToString(intYY);
		}
		if (BelongToGroup)
		{
			text += " AND a.custId <> a.custParentId ";
		}
		text = ((StorageId == 0) ? (text + " AND a.storeId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1)") : (text + " AND a.storeId = " + Conversions.ToString(StorageId)));
		text = ((BranchId <= 0) ? (text + " AND a.branchId IN ( SELECT branchId FROM groups_branches  WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1) ") : (text + " AND a.branchId = " + Conversions.ToString(BranchId)));
		if (isParent < 2)
		{
			text = text + " AND a.isParent = " + Conversions.ToString(isParent);
		}
		text += " ORDER BY custName ";
		return Module1.sqlTable(text, "read", Clone: false);
	}

	public static void NonActivate(double CustomerId)
	{
		string strSql = " UPDATE customer  SET custActive = 0  WHERE custId = " + Conversions.ToString(CustomerId);
		Module1.sqlNonQuery(strSql, "data");
	}
}
