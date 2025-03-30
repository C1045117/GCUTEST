using mscorlib;

namespace GCUv2
{
    public class 
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
        private int32 _creditLimit;
        private int32 _TOP;
        private int32 _specialTOP;
        private valuetype System.DateTime _createdDate;
        private string _note;
        private int32 _customerCodeId;
        private string _customerCodeName;
        private int32 _priceCodeId;
        private string _priceCodeName;
        private int32 _salesPersonId;
        private string _salesPersonName;
        private int32 _collectorId;
        private string _collectorName;
        private int32 _discountId;
        private string _discountName;
        private int32 _discountType;
        private int32 _areaId;
        private string _areaName;
        private int32 _active;
        private int32 _tukarFaktur;
        private int32 _cashAccountId;
        private string _cashAccountName;
        private int32 _bankAccountId;
        private string _bankAccountName;
        private int32 _storageId;
        private string _storageName;
        private int32 _branchId;
        private double _parentId;
        private string _parentName;
        private int32 _isParent;
        private string[] _memberName;


        public specialname double get_Id() {

          double flt_1;

        }

        public specialname void set_Id(double value) {

          loc_40A61D: nop
          loc_40A61E: ldarg.0
          loc_40A61F: ldarg.1
          loc_40A620: stfld GCUv2.cCurrency::_id
          loc_40A625: ret
        }

        public specialname string get_Name() {

          string str_1;

        }

        public specialname void set_Name(string value) {

          loc_40A641: nop
          loc_40A642: ldarg.0
          loc_40A643: ldarg.1
          loc_40A644: call string GCUv2.Module1::cleanString(string)
          loc_40A649: stfld GCUv2.cCustomer::_name
          loc_40A64E: ret
        }

        public specialname string get_Address() {

          string str_1;

        }

        public specialname void set_Address(string value) {

          loc_40A669: nop
          loc_40A66A: ldarg.0
          loc_40A66B: ldarg.1
          loc_40A66C: call string GCUv2.Module1::cleanString(string)
          loc_40A671: stfld GCUv2.cCustomer::_address
          loc_40A676: ret
        }

        public specialname string get_City() {

          string str_1;

        }

        public specialname void set_City(string value) {

          loc_40A691: nop
          loc_40A692: ldarg.0
          loc_40A693: ldarg.1
          loc_40A694: call string GCUv2.Module1::cleanString(string)
          loc_40A699: stfld GCUv2.cCustomer::_city
          loc_40A69E: ret
        }

        public specialname string get_PostCode() {

          string str_1;

        }

        public specialname void set_PostCode(string value) {

          loc_40A6B9: nop
          loc_40A6BA: ldarg.0
          loc_40A6BB: ldarg.1
          loc_40A6BC: call string GCUv2.Module1::cleanString(string)
          loc_40A6C1: stfld GCUv2.cCustomer::_postCode
          loc_40A6C6: ret
        }

        public specialname string get_Phone() {

          string str_1;

        }

        public specialname void set_Phone(string value) {

          loc_40A6E1: nop
          loc_40A6E2: ldarg.0
          loc_40A6E3: ldarg.1
          loc_40A6E4: call string GCUv2.Module1::cleanString(string)
          loc_40A6E9: stfld GCUv2.cCustomer::_phone
          loc_40A6EE: ret
        }

        public specialname string get_Fax() {

          string str_1;

        }

        public specialname void set_Fax(string value) {

          loc_40A709: nop
          loc_40A70A: ldarg.0
          loc_40A70B: ldarg.1
          loc_40A70C: call string GCUv2.Module1::cleanString(string)
          loc_40A711: stfld GCUv2.cCustomer::_fax
          loc_40A716: ret
        }

        public specialname string get_PT() {

          string str_1;

        }

        public specialname void set_PT(string value) {

          loc_40A731: nop
          loc_40A732: ldarg.0
          loc_40A733: ldarg.1
          loc_40A734: call string GCUv2.Module1::cleanString(string)
          loc_40A739: stfld GCUv2.cCustomer::_PT
          loc_40A73E: ret
        }

        public specialname string get_NPWP() {

          string str_1;

        }

        public specialname void set_NPWP(string value) {

          loc_40A759: nop
          loc_40A75A: ldarg.0
          loc_40A75B: ldarg.1
          loc_40A75C: call string GCUv2.Module1::cleanString(string)
          loc_40A761: stfld GCUv2.cCustomer::_NPWP
          loc_40A766: ret
        }

        public specialname string get_TaxAddress() {

          string str_1;

        }

        public specialname void set_TaxAddress(string value) {

          loc_40A781: nop
          loc_40A782: ldarg.0
          loc_40A783: ldarg.1
          loc_40A784: call string GCUv2.Module1::cleanString(string)
          loc_40A789: stfld GCUv2.cCustomer::_taxAddress
          loc_40A78E: ret
        }

        public specialname string get_TaxCity() {

          string str_1;

        }

        public specialname void set_TaxCity(string value) {

          loc_40A7A9: nop
          loc_40A7AA: ldarg.0
          loc_40A7AB: ldarg.1
          loc_40A7AC: call string GCUv2.Module1::cleanString(string)
          loc_40A7B1: stfld GCUv2.cCustomer::_taxCity
          loc_40A7B6: ret
        }

        public specialname string get_TaxPostCode() {

          string str_1;

        }

        public specialname void set_TaxPostCode(string value) {

          loc_40A7D1: nop
          loc_40A7D2: ldarg.0
          loc_40A7D3: ldarg.1
          loc_40A7D4: call string GCUv2.Module1::cleanString(string)
          loc_40A7D9: stfld GCUv2.cCustomer::_taxPostCode
          loc_40A7DE: ret
        }

        public specialname string get_Contact() {

          string str_1;

        }

        public specialname void set_Contact(string value) {

          loc_40A7F9: nop
          loc_40A7FA: ldarg.0
          loc_40A7FB: ldarg.1
          loc_40A7FC: call string GCUv2.Module1::cleanString(string)
          loc_40A801: stfld GCUv2.cCustomer::_contact
          loc_40A806: ret
        }

        public specialname int32 get_CreditLimit() {

          int32 num_1;

        }

        public specialname void set_CreditLimit(int32 value) {

          loc_40A821: nop
          loc_40A822: ldarg.0
          loc_40A823: ldarg.1
          loc_40A824: stfld GCUv2.cCustomer::_creditLimit
          loc_40A829: ret
        }

        public specialname int32 get_TOP() {

          int32 num_1;

        }

        public specialname void set_TOP(int32 value) {

          loc_40A845: nop
          loc_40A846: ldarg.0
          loc_40A847: ldarg.1
          loc_40A848: stfld GCUv2.cCustomer::_TOP
          loc_40A84D: ret
        }

        public specialname int32 get_SpecialTOP() {

          int32 num_1;

        }

        public specialname void set_SpecialTOP(int32 value) {

          loc_40A869: nop
          loc_40A86A: ldarg.0
          loc_40A86B: ldarg.1
          loc_40A86C: stfld GCUv2.cCustomer::_specialTOP
          loc_40A871: ret
        }

        public specialname valuetype System.DateTime get_CreatedDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_CreatedDate(valuetype System.DateTime value) {

          loc_40A88D: nop
          loc_40A88E: ldarg.0
          loc_40A88F: ldarg.1
          loc_40A890: stfld GCUv2.cCustomer::_createdDate
          loc_40A895: ret
        }

        public specialname string get_Note() {

          string str_1;

        }

        public specialname void set_Note(string value) {

          loc_40A8B1: nop
          loc_40A8B2: ldarg.0
          loc_40A8B3: ldarg.1
          loc_40A8B4: call string GCUv2.Module1::cleanString(string)
          loc_40A8B9: stfld GCUv2.cCustomer::_note
          loc_40A8BE: ret
        }

        public specialname int32 get_CustomerCodeId() {

          int32 num_1;

        }

        public specialname void set_CustomerCodeId(int32 value) {

          loc_40A8D9: nop
          loc_40A8DA: ldarg.0
          loc_40A8DB: ldarg.1
          loc_40A8DC: stfld GCUv2.cCustomer::_customerCodeId
          loc_40A8E1: ret
        }

        public specialname string get_CustomerCodeName() {

          string str_1;

        }

        public specialname void set_CustomerCodeName(string value) {

          loc_40A8FD: nop
          loc_40A8FE: ldarg.0
          loc_40A8FF: ldarg.1
          loc_40A900: stfld GCUv2.cCustomer::_customerCodeName
          loc_40A905: ret
        }

        public specialname int32 get_PriceCodeId() {

          int32 num_1;

        }

        public specialname void set_PriceCodeId(int32 value) {

          loc_40A921: nop
          loc_40A922: ldarg.0
          loc_40A923: ldarg.1
          loc_40A924: stfld GCUv2.cCustomer::_priceCodeId
          loc_40A929: ret
        }

        public specialname string get_PriceCodeName() {

          string str_1;

        }

        public specialname void set_PriceCodeName(string value) {

          loc_40A945: nop
          loc_40A946: ldarg.0
          loc_40A947: ldarg.1
          loc_40A948: stfld GCUv2.cCustomer::_priceCodeName
          loc_40A94D: ret
        }

        public specialname int32 get_SalesPersonId() {

          int32 num_1;

        }

        public specialname void set_SalesPersonId(int32 value) {

          loc_40A969: nop
          loc_40A96A: ldarg.0
          loc_40A96B: ldarg.1
          loc_40A96C: stfld GCUv2.cCustomer::_salesPersonId
          loc_40A971: ret
        }

        public specialname string get_SalesPersonName() {

          string str_1;

        }

        public specialname void set_SalesPersonName(string value) {

          loc_40A98D: nop
          loc_40A98E: ldarg.0
          loc_40A98F: ldarg.1
          loc_40A990: stfld GCUv2.cCustomer::_salesPersonName
          loc_40A995: ret
        }

        public specialname int32 get_CollectorId() {

          int32 num_1;

        }

        public specialname void set_CollectorId(int32 value) {

          loc_40A9B1: nop
          loc_40A9B2: ldarg.0
          loc_40A9B3: ldarg.1
          loc_40A9B4: stfld GCUv2.cCustomer::_collectorId
          loc_40A9B9: ret
        }

        public specialname string get_CollectorName() {

          string str_1;

        }

        public specialname void set_CollectorName(string value) {

          loc_40A9D5: nop
          loc_40A9D6: ldarg.0
          loc_40A9D7: ldarg.1
          loc_40A9D8: stfld GCUv2.cCustomer::_collectorName
          loc_40A9DD: ret
        }

        public specialname int32 get_DiscountId() {

          int32 num_1;

        }

        public specialname void set_DiscountId(int32 value) {

          loc_40A9F9: nop
          loc_40A9FA: ldarg.0
          loc_40A9FB: ldarg.1
          loc_40A9FC: stfld GCUv2.cCustomer::_discountId
          loc_40AA01: ret
        }

        public specialname string get_DiscountName() {

          string str_1;

        }

        public specialname void set_DiscountName(string value) {

          loc_40AA1D: nop
          loc_40AA1E: ldarg.0
          loc_40AA1F: ldarg.1
          loc_40AA20: stfld GCUv2.cCustomer::_discountName
          loc_40AA25: ret
        }

        public specialname int32 get_DiscountType() {

          int32 num_1;

        }

        public specialname void set_DiscountType(int32 value) {

          loc_40AA41: nop
          loc_40AA42: ldarg.0
          loc_40AA43: ldarg.1
          loc_40AA44: stfld GCUv2.cCustomer::_discountType
          loc_40AA49: ret
        }

        public specialname int32 get_AreaId() {

          int32 num_1;

        }

        public specialname void set_AreaId(int32 value) {

          loc_40AA65: nop
          loc_40AA66: ldarg.0
          loc_40AA67: ldarg.1
          loc_40AA68: stfld GCUv2.cCustomer::_areaId
          loc_40AA6D: ret
        }

        public specialname string get_AreaName() {

          string str_1;

        }

        public specialname void set_AreaName(string value) {

          loc_40AA89: nop
          loc_40AA8A: ldarg.0
          loc_40AA8B: ldarg.1
          loc_40AA8C: stfld GCUv2.cCustomer::_areaName
          loc_40AA91: ret
        }

        public specialname int32 get_Active() {

          int32 num_1;

        }

        public specialname void set_Active(int32 value) {

          loc_40AAAD: nop
          loc_40AAAE: ldarg.0
          loc_40AAAF: ldarg.1
          loc_40AAB0: stfld GCUv2.cCustomer::_active
          loc_40AAB5: ret
        }

        public specialname int32 get_TukarFaktur() {

          int32 num_1;

        }

        public specialname void set_TukarFaktur(int32 value) {

          loc_40AAD1: nop
          loc_40AAD2: ldarg.0
          loc_40AAD3: ldarg.1
          loc_40AAD4: stfld GCUv2.cCustomer::_tukarFaktur
          loc_40AAD9: ret
        }

        public specialname int32 get_CashAccountId() {

          int32 num_1;

        }

        public specialname void set_CashAccountId(int32 value) {

          loc_40AAF5: nop
          loc_40AAF6: ldarg.0
          loc_40AAF7: ldarg.1
          loc_40AAF8: stfld GCUv2.cCustomer::_cashAccountId
          loc_40AAFD: ret
        }

        public specialname string get_CashAccountName() {

          string str_1;

        }

        public specialname void set_CashAccountName(string value) {

          loc_40AB19: nop
          loc_40AB1A: ldarg.0
          loc_40AB1B: ldarg.1
          loc_40AB1C: stfld GCUv2.cCustomer::_cashAccountName
          loc_40AB21: ret
        }

        public specialname int32 get_BankAccountId() {

          int32 num_1;

        }

        public specialname void set_BankAccountId(int32 value) {

          loc_40AB3D: nop
          loc_40AB3E: ldarg.0
          loc_40AB3F: ldarg.1
          loc_40AB40: stfld GCUv2.cCustomer::_bankAccountId
          loc_40AB45: ret
        }

        public specialname string get_BankAccountName() {

          string str_1;

        }

        public specialname void set_BankAccountName(string value) {

          loc_40AB61: nop
          loc_40AB62: ldarg.0
          loc_40AB63: ldarg.1
          loc_40AB64: stfld GCUv2.cCustomer::_bankAccountName
          loc_40AB69: ret
        }

        public specialname int32 get_StorageId() {

          int32 num_1;

        }

        public specialname void set_StorageId(int32 value) {

          loc_40AB85: nop
          loc_40AB86: ldarg.0
          loc_40AB87: ldarg.1
          loc_40AB88: stfld GCUv2.cCustomer::_storageId
          loc_40AB8D: ret
        }

        public specialname string get_StorageName() {

          string str_1;

        }

        public specialname void set_StorageName(string value) {

          loc_40ABA9: nop
          loc_40ABAA: ldarg.0
          loc_40ABAB: ldarg.1
          loc_40ABAC: stfld GCUv2.cCustomer::_storageName
          loc_40ABB1: ret
        }

        public specialname int32 get_BranchId() {

          int32 num_1;

        }

        public specialname void set_BranchId(int32 value) {

          loc_40ABCD: nop
          loc_40ABCE: ldarg.0
          loc_40ABCF: ldarg.1
          loc_40ABD0: stfld GCUv2.cCustomer::_branchId
          loc_40ABD5: ret
        }

        public specialname double get_ParentId() {

          double flt_1;

        }

        public specialname void set_ParentId(double value) {

          loc_40ABF1: nop
          loc_40ABF2: ldarg.0
          loc_40ABF3: ldarg.1
          loc_40ABF4: stfld GCUv2.cCustomer::_parentId
          loc_40ABF9: ret
        }

        public specialname string get_ParentName() {

          string str_1;

        }

        public specialname void set_ParentName(string value) {

          loc_40AC15: nop
          loc_40AC16: ldarg.0
          loc_40AC17: ldarg.1
          loc_40AC18: stfld GCUv2.cCustomer::_parentName
          loc_40AC1D: ret
        }

        public specialname int32 get_IsParent() {

          int32 num_1;

        }

        public specialname void set_IsParent(int32 value) {

          loc_40AC39: nop
          loc_40AC3A: ldarg.0
          loc_40AC3B: ldarg.1
          loc_40AC3C: stfld GCUv2.cCustomer::_isParent
          loc_40AC41: ret
        }

        public specialname string[] get_MemberName() {

          string[] var_1;

        }

        public specialname void set_MemberName(string[] value) {

          loc_40AC5D: nop
          loc_40AC5E: ldarg.0
          loc_40AC5F: ldarg.1
          loc_40AC60: stfld GCUv2.cCustomer::_memberName
          loc_40AC65: ret
        }

        public void cCustomer(double CustomerId) {

          boolean var_1;
          class DataTable var_2;
          string str_1;
          int32 num_1;
          boolean var_3;
          boolean var_4;
          class System.Collections.IEnumerator var_5;
          class DataRow var_6;
          boolean var_7;

        }

        public void save() {

          string str_1;
          boolean var_1;
          boolean var_2;

        }

        public static class DataTable Search(string Name, string Address, int32 CustomerCodeId, int32 SalesId, int32 PriceCodeId, int32 AreaId, int32 DiscountId, int32 Active, boolean BelongToGroup, int32 StorageId, int32 GroupId, int32 BranchId, int32 intMM, int32 intYY, int32 isParent) {

          class DataTable var_1;
          string str_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;
          boolean var_9;
          boolean var_10;
          boolean var_11;
          boolean var_12;
          boolean var_13;
          boolean var_14;

        }

        public static void NonActivate(double CustomerId) {

          string str_1;

        }

    }
}
