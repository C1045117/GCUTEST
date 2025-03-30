using mscorlib;

namespace GCUv2
{
    public class 
    {

        private double _id;
        private double _customerId;
        private double _customerParentId;
        private string _customerName;
        private string _customerAddress;
        private string _customerPT;
        private string _customerNPWP;
        private string _customerTaxAddress;
        private int32 _customerUnpaidLimit;
        private int32 _discountId;
        private int32 _salesPersonId;
        private valuetype System.DateTime _invoiceDate;
        private valuetype System.DateTime _taxInvoiceDate;
        private string _number;
        private double _taxNumber;
        private int32 _invoiceCode;
        private double _discount;
        private string _discountDescription;
        private double _deduction;
        private int32 _useOldPrice;
        private class GCUv2.cSalesInvoiceItem[] _item;
        private class GCUv2.cSalesInvoiceItem[] _currentItem;
        private valuetype System.DateTime _currentDate;
        private int32 _currentStorage;
        private class GCUv2.cSalesInvoicePayment[] _payment;
        private class GCUv2.cSalesInvoiceReturn[] _invoiceReturn;
        private double _totalPrice;
        private double _totalBasePrice;
        private double _totalReturn;
        private double _totalPayment;
        private double _dpp;
        private double _ppn;
        private valuetype System.DateTime _paidDate;
        private int32 _isReturn;
        private valuetype System.DateTime _createdDate;
        private string _note;
        private int32 _tukarFaktur;
        private valuetype System.DateTime _tukarFakturDate;
        private int32 _storageId;
        private int32 _branchId;
        private double _parentInvoiceId;
        private string _parentInvoiceNumber;
        private int32 _cashAccountId;
        private int32 _bankAccountId;
        private string _cashAccountName;


        public specialname double get_Id() {

          double flt_1;

        }

        public specialname void set_Id(double value) {

          loc_41B1DD: nop
          loc_41B1DE: ldarg.0
          loc_41B1DF: ldarg.1
          loc_41B1E0: stfld GCUv2.cReturnTaxInvoiceNumber::_id
          loc_41B1E5: ret
        }

        public specialname double get_CustomerId() {

          double flt_1;

        }

        public specialname void set_CustomerId(double value) {

          loc_41B201: nop
          loc_41B202: ldarg.0
          loc_41B203: ldarg.1
          loc_41B204: stfld GCUv2.cSalesInvoice::_customerId
          loc_41B209: ret
        }

        public specialname double get_CustomerParentId() {

          double flt_1;

        }

        public specialname void set_CustomerParentId(double value) {

          loc_41B225: nop
          loc_41B226: ldarg.0
          loc_41B227: ldarg.1
          loc_41B228: stfld GCUv2.cSalesInvoice::_customerParentId
          loc_41B22D: ret
        }

        public specialname string get_CustomerName() {

          string str_1;

        }

        public specialname void set_CustomerName(string value) {

          loc_41B249: nop
          loc_41B24A: ldarg.0
          loc_41B24B: ldarg.1
          loc_41B24C: stfld GCUv2.cSalesInvoice::_customerName
          loc_41B251: ret
        }

        public specialname string get_CustomerAddress() {

          string str_1;

        }

        public specialname void set_CustomerAddress(string value) {

          loc_41B26D: nop
          loc_41B26E: ldarg.0
          loc_41B26F: ldarg.1
          loc_41B270: stfld GCUv2.cSalesInvoice::_customerAddress
          loc_41B275: ret
        }

        public specialname string get_CustomerPT() {

          string str_1;

        }

        public specialname void set_CustomerPT(string value) {

          loc_41B291: nop
          loc_41B292: ldarg.0
          loc_41B293: ldarg.1
          loc_41B294: stfld GCUv2.cSalesInvoice::_customerPT
          loc_41B299: ret
        }

        public specialname string get_CustomerNPWP() {

          string str_1;

        }

        public specialname void set_CustomerNPWP(string value) {

          loc_41B2B5: nop
          loc_41B2B6: ldarg.0
          loc_41B2B7: ldarg.1
          loc_41B2B8: stfld GCUv2.cSalesInvoice::_customerNPWP
          loc_41B2BD: ret
        }

        public specialname string get_CustomerTaxAddress() {

          string str_1;

        }

        public specialname void set_CustomerTaxAddress(string value) {

          loc_41B2D9: nop
          loc_41B2DA: ldarg.0
          loc_41B2DB: ldarg.1
          loc_41B2DC: stfld GCUv2.cSalesInvoice::_customerTaxAddress
          loc_41B2E1: ret
        }

        public specialname int32 get_CustomerUnpaidLimit() {

          int32 num_1;

        }

        public specialname void set_CustomerUnpaidLimit(int32 value) {

          loc_41B2FD: nop
          loc_41B2FE: ldarg.0
          loc_41B2FF: ldarg.1
          loc_41B300: stfld GCUv2.cSalesInvoice::_customerUnpaidLimit
          loc_41B305: ret
        }

        public specialname int32 get_DiscountId() {

          int32 num_1;

        }

        public specialname void set_DiscountId(int32 value) {

          loc_41B321: nop
          loc_41B322: ldarg.0
          loc_41B323: ldarg.1
          loc_41B324: stfld GCUv2.cSalesInvoice::_discountId
          loc_41B329: ret
        }

        public specialname int32 get_SalesPersonId() {

          int32 num_1;

        }

        public specialname void set_SalesPersonId(int32 value) {

          loc_41B345: nop
          loc_41B346: ldarg.0
          loc_41B347: ldarg.1
          loc_41B348: stfld GCUv2.cSalesInvoice::_salesPersonId
          loc_41B34D: ret
        }

        public specialname valuetype System.DateTime get_InvoiceDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_InvoiceDate(valuetype System.DateTime value) {

          loc_41B369: nop
          loc_41B36A: ldarg.0
          loc_41B36B: ldarg.1
          loc_41B36C: stfld GCUv2.cSalesInvoice::_invoiceDate
          loc_41B371: ret
        }

        public specialname valuetype System.DateTime get_TaxInvoiceDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_TaxInvoiceDate(valuetype System.DateTime value) {

          loc_41B38D: nop
          loc_41B38E: ldarg.0
          loc_41B38F: ldarg.1
          loc_41B390: stfld GCUv2.cSalesInvoice::_taxInvoiceDate
          loc_41B395: ret
        }

        public specialname string get_Number() {

          string str_1;

        }

        public specialname void set_Number(string value) {

          loc_41B3B1: nop
          loc_41B3B2: ldarg.0
          loc_41B3B3: ldarg.1
          loc_41B3B4: stfld GCUv2.cSalesInvoice::_number
          loc_41B3B9: ret
        }

        public specialname double get_TaxNumber() {

          double flt_1;

        }

        public specialname void set_TaxNumber(double value) {

          loc_41B3D5: nop
          loc_41B3D6: ldarg.0
          loc_41B3D7: ldarg.1
          loc_41B3D8: stfld GCUv2.cSalesInvoice::_taxNumber
          loc_41B3DD: ret
        }

        public specialname int32 get_InvoiceCode() {

          int32 num_1;

        }

        public specialname void set_InvoiceCode(int32 value) {

          loc_41B3F9: nop
          loc_41B3FA: ldarg.0
          loc_41B3FB: ldarg.1
          loc_41B3FC: stfld GCUv2.cSalesInvoice::_invoiceCode
          loc_41B401: ret
        }

        public specialname double get_Discount() {

          double flt_1;

        }

        public specialname void set_Discount(double value) {

          loc_41B41D: nop
          loc_41B41E: ldarg.0
          loc_41B41F: ldarg.1
          loc_41B420: stfld GCUv2.cSalesInvoice::_discount
          loc_41B425: ret
        }

        public specialname string get_DiscountDescription() {

          string str_1;

        }

        public specialname void set_DiscountDescription(string value) {

          loc_41B441: nop
          loc_41B442: ldarg.0
          loc_41B443: ldarg.1
          loc_41B444: call string GCUv2.Module1::cleanString(string)
          loc_41B449: stfld GCUv2.cSalesInvoice::_discountDescription
          loc_41B44E: ret
        }

        public specialname double get_Deduction() {

          double flt_1;

        }

        public specialname void set_Deduction(double value) {

          loc_41B469: nop
          loc_41B46A: ldarg.0
          loc_41B46B: ldarg.1
          loc_41B46C: stfld GCUv2.cSalesInvoice::_deduction
          loc_41B471: ret
        }

        public specialname int32 get_UseOldPrice() {

          int32 num_1;

        }

        public specialname void set_UseOldPrice(int32 value) {

          loc_41B48D: nop
          loc_41B48E: ldarg.0
          loc_41B48F: ldarg.1
          loc_41B490: stfld GCUv2.cSalesInvoice::_useOldPrice
          loc_41B495: ret
        }

        public specialname class GCUv2.cSalesInvoiceItem[] get_Item() {

          class GCUv2.cSalesInvoiceItem[] var_1;

        }

        public specialname void set_Item(class GCUv2.cSalesInvoiceItem[] value) {

          loc_41B4B1: nop
          loc_41B4B2: ldarg.0
          loc_41B4B3: ldarg.1
          loc_41B4B4: stfld GCUv2.cSalesInvoice::_item
          loc_41B4B9: ret
        }

        public specialname class GCUv2.cSalesInvoicePayment[] get_Payment() {

          class GCUv2.cSalesInvoicePayment[] var_1;

        }

        public specialname void set_Payment(class GCUv2.cSalesInvoicePayment[] value) {

          loc_41B4D5: nop
          loc_41B4D6: ldarg.0
          loc_41B4D7: ldarg.1
          loc_41B4D8: stfld GCUv2.cSalesInvoice::_payment
          loc_41B4DD: ret
        }

        public specialname class GCUv2.cSalesInvoiceReturn[] get_InvoiceReturn() {

          class GCUv2.cSalesInvoiceReturn[] var_1;

        }

        public specialname void set_InvoiceReturn(class GCUv2.cSalesInvoiceReturn[] value) {

          loc_41B4F9: nop
          loc_41B4FA: ldarg.0
          loc_41B4FB: ldarg.1
          loc_41B4FC: stfld GCUv2.cSalesInvoice::_invoiceReturn
          loc_41B501: ret
        }

        public specialname double get_TotalPrice() {

          double flt_1;

        }

        public specialname void set_TotalPrice(double value) {

          loc_41B51D: nop
          loc_41B51E: ldarg.0
          loc_41B51F: ldarg.1
          loc_41B520: stfld GCUv2.cSalesInvoice::_totalPrice
          loc_41B525: ret
        }

        public specialname double get_TotalBasePrice() {

          double flt_1;

        }

        public specialname void set_TotalBasePrice(double value) {

          loc_41B541: nop
          loc_41B542: ldarg.0
          loc_41B543: ldarg.1
          loc_41B544: stfld GCUv2.cSalesInvoice::_totalBasePrice
          loc_41B549: ret
        }

        public specialname double get_TotalReturn() {

          double flt_1;

        }

        public specialname void set_TotalReturn(double value) {

          loc_41B565: nop
          loc_41B566: ldarg.0
          loc_41B567: ldarg.1
          loc_41B568: stfld GCUv2.cSalesInvoice::_totalReturn
          loc_41B56D: ret
        }

        public specialname double get_TotalPayment() {

          double flt_1;

        }

        public specialname void set_TotalPayment(double value) {

          loc_41B589: nop
          loc_41B58A: ldarg.0
          loc_41B58B: ldarg.1
          loc_41B58C: stfld GCUv2.cSalesInvoice::_totalPayment
          loc_41B591: ret
        }

        public specialname double get_Dpp() {

          double flt_1;

        }

        public specialname void set_Dpp(double value) {

          loc_41B5AD: nop
          loc_41B5AE: ldarg.0
          loc_41B5AF: ldarg.1
          loc_41B5B0: stfld GCUv2.cSalesInvoice::_dpp
          loc_41B5B5: ret
        }

        public specialname double get_Ppn() {

          double flt_1;

        }

        public specialname void set_Ppn(double value) {

          loc_41B5D1: nop
          loc_41B5D2: ldarg.0
          loc_41B5D3: ldarg.1
          loc_41B5D4: stfld GCUv2.cSalesInvoice::_ppn
          loc_41B5D9: ret
        }

        public specialname valuetype System.DateTime get_PaidDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_PaidDate(valuetype System.DateTime value) {

          loc_41B5F5: nop
          loc_41B5F6: ldarg.0
          loc_41B5F7: ldarg.1
          loc_41B5F8: stfld GCUv2.cSalesInvoice::_paidDate
          loc_41B5FD: ret
        }

        public specialname int32 get_isReturn() {

          int32 num_1;

        }

        public specialname void set_isReturn(int32 value) {

          loc_41B619: nop
          loc_41B61A: ldarg.0
          loc_41B61B: ldarg.1
          loc_41B61C: stfld GCUv2.cSalesInvoice::_isReturn
          loc_41B621: ret
        }

        public specialname valuetype System.DateTime get_CreatedDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_CreatedDate(valuetype System.DateTime value) {

          loc_41B63D: nop
          loc_41B63E: ldarg.0
          loc_41B63F: ldarg.1
          loc_41B640: stfld GCUv2.cSalesInvoice::_createdDate
          loc_41B645: ret
        }

        public specialname int32 get_StorageId() {

          int32 num_1;

        }

        public specialname void set_StorageId(int32 value) {

          loc_41B661: nop
          loc_41B662: ldarg.0
          loc_41B663: ldarg.1
          loc_41B664: stfld GCUv2.cSalesInvoice::_storageId
          loc_41B669: ret
        }

        public specialname string get_Note() {

          string str_1;

        }

        public specialname void set_Note(string value) {

          loc_41B685: nop
          loc_41B686: ldarg.0
          loc_41B687: ldarg.1
          loc_41B688: call string GCUv2.Module1::cleanStringKeepCrlf(string)
          loc_41B68D: stfld GCUv2.cSalesInvoice::_note
          loc_41B692: ret
        }

        public specialname int32 get_TukarFaktur() {

          int32 num_1;

        }

        public specialname void set_TukarFaktur(int32 value) {

          loc_41B6AD: nop
          loc_41B6AE: ldarg.0
          loc_41B6AF: ldarg.1
          loc_41B6B0: stfld GCUv2.cSalesInvoice::_tukarFaktur
          loc_41B6B5: ret
        }

        public specialname valuetype System.DateTime get_TukarFakturDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_TukarFakturDate(valuetype System.DateTime value) {

          loc_41B6D1: nop
          loc_41B6D2: ldarg.0
          loc_41B6D3: ldarg.1
          loc_41B6D4: stfld GCUv2.cSalesInvoice::_tukarFakturDate
          loc_41B6D9: ret
        }

        public specialname int32 get_BranchId() {

          int32 num_1;

        }

        public specialname void set_BranchId(int32 value) {

          loc_41B6F5: nop
          loc_41B6F6: ldarg.0
          loc_41B6F7: ldarg.1
          loc_41B6F8: stfld GCUv2.cSalesInvoice::_branchId
          loc_41B6FD: ret
        }

        public specialname double get_ParentInvoiceId() {

          double flt_1;

        }

        public specialname void set_ParentInvoiceId(double value) {

          loc_41B719: nop
          loc_41B71A: ldarg.0
          loc_41B71B: ldarg.1
          loc_41B71C: stfld GCUv2.cSalesInvoice::_parentInvoiceId
          loc_41B721: ret
        }

        public specialname string get_ParentInvoiceNumber() {

          string str_1;

        }

        public specialname void set_ParentInvoiceNumber(string value) {

          loc_41B73D: nop
          loc_41B73E: ldarg.0
          loc_41B73F: ldarg.1
          loc_41B740: stfld GCUv2.cSalesInvoice::_parentInvoiceNumber
          loc_41B745: ret
        }

        public specialname int32 get_CashAccountId() {

          int32 num_1;

        }

        public specialname void set_CashAccountId(int32 value) {

          loc_41B761: nop
          loc_41B762: ldarg.0
          loc_41B763: ldarg.1
          loc_41B764: stfld GCUv2.cSalesInvoice::_cashAccountId
          loc_41B769: ret
        }

        public specialname string get_CashAccountName() {

          string str_1;

        }

        public specialname void set_CashAccountName(string value) {

          loc_41B785: nop
          loc_41B786: ldarg.0
          loc_41B787: ldarg.1
          loc_41B788: stfld GCUv2.cSalesInvoice::_cashAccountName
          loc_41B78D: ret
        }

        public specialname int32 get_BankAccountId() {

          int32 num_1;

        }

        public specialname void set_BankAccountId(int32 value) {

          loc_41B7A9: nop
          loc_41B7AA: ldarg.0
          loc_41B7AB: ldarg.1
          loc_41B7AC: stfld GCUv2.cSalesInvoice::_bankAccountId
          loc_41B7B1: ret
        }

        public specialname class GCUv2.cSalesInvoiceItem[] get_CurrentItem() {

          class GCUv2.cSalesInvoiceItem[] var_1;

        }

        public specialname void set_CurrentItem(class GCUv2.cSalesInvoiceItem[] value) {

          loc_41B7CD: nop
          loc_41B7CE: ldarg.0
          loc_41B7CF: ldarg.1
          loc_41B7D0: stfld GCUv2.cSalesInvoice::_currentItem
          loc_41B7D5: ret
        }

        public specialname valuetype System.DateTime get_CurrentDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_CurrentDate(valuetype System.DateTime value) {

          loc_41B7F1: nop
          loc_41B7F2: ldarg.0
          loc_41B7F3: ldarg.1
          loc_41B7F4: stfld GCUv2.cSalesInvoice::_currentDate
          loc_41B7F9: ret
        }

        public specialname int32 get_CurrentStorage() {

          int32 num_1;

        }

        public specialname void set_CurrentStorage(int32 value) {

          loc_41B815: nop
          loc_41B816: ldarg.0
          loc_41B817: ldarg.1
          loc_41B818: stfld GCUv2.cSalesInvoice::_currentStorage
          loc_41B81D: ret
        }

        public void cSalesInvoice(double InvId) {

          boolean var_1;
          class DataTable var_2;
          string str_1;
          int32 num_1;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          class System.Collections.IEnumerator var_7;
          class DataRow var_8;
          boolean var_9;
          class System.Collections.IEnumerator var_10;
          class DataRow var_11;
          boolean var_12;
          class GCUv2.cChequeIn var_13;
          boolean var_14;
          class System.Collections.IEnumerator var_15;
          class DataRow var_16;
          boolean var_17;

        }

        public void Save() {

          int32 num_1;
          int32 num_2;
          string str_1;
          class DataTable var_1;
          double flt_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          int32 num_3;
          int32 num_4;
          boolean var_7;
          class System.Collections.IEnumerator var_8;
          class DataRow var_9;
          boolean var_10;
          class GCUv2.cSalesInvoiceItem[] var_11;
          int32 num_5;
          class GCUv2.cSalesInvoiceItem var_12;
          boolean var_13;
          boolean var_14;
          boolean var_15;
          boolean var_16;
          class GCUv2.cSalesInvoicePayment[] var_17;
          int32 num_6;
          class GCUv2.cSalesInvoicePayment var_18;
          boolean var_19;
          boolean var_20;
          boolean var_21;
          boolean var_22;
          boolean var_23;
          boolean var_24;
          class GCUv2.cSalesInvoiceReturn[] var_25;
          int32 num_7;
          class GCUv2.cSalesInvoiceReturn var_26;
          boolean var_27;

        }

        public void Delete() {

          int32 num_1;
          int32 num_2;
          string str_1;
          class DataTable var_1;
          class MySqlClient.MySqlTransaction var_2;
          boolean var_3;
          int32 num_3;
          int32 num_4;
          boolean var_4;
          class System.Collections.IEnumerator var_5;
          class DataRow var_6;
          boolean var_7;
          boolean var_8;

        }

        public static class DataTable Search(int32 intRange, valuetype System.DateTime dateFirst, valuetype System.DateTime dateLast, int32 CustomerCodeId, int32 SalesPersonId, int32 PaymentStatus, int32 AreaId, string InvoiceNumber, double CustomerId, double ParentId, int32 InvoiceCode, int32 IsRetur, int32 HasNPWP, int32 UseOldPrice, int32 StorageId, int32 BranchId, int32 GroupId, string Order) {

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
          boolean var_15;
          boolean var_16;
          boolean var_17;
          boolean var_18;
          boolean var_19;
          boolean var_20;
          boolean var_21;
          boolean var_22;
          boolean var_23;
          boolean var_24;
          boolean var_25;
          boolean var_26;

        }

        public static class DataTable SearchItem(valuetype System.DateTime dateFirst, valuetype System.DateTime dateLast, double CustomerId, int32 AreaId, int32 SalesId, int32 UseOldPrice, int32 ItemCategoryId, int32 ItemId, int32 StorageId, int32 BranchId, int32 InvoiceType, int32 SearchType, string GroupBy, boolean IncludeDO, int32 GroupId) {

          class DataTable var_1;
          string str_1;
          string str_2;
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
          boolean var_15;
          boolean var_16;
          boolean var_17;
          boolean var_18;
          boolean var_19;
          boolean var_20;
          boolean var_21;
          boolean var_22;
          boolean var_23;
          boolean var_24;
          boolean var_25;
          boolean var_26;
          boolean var_27;
          boolean var_28;
          boolean var_29;
          boolean var_30;
          boolean var_31;
          boolean var_32;
          boolean var_33;
          boolean var_34;

        }

        public static class DataTable SearchReceivable(int32 Range, valuetype System.DateTime dateFirst, valuetype System.DateTime dateLast, double CustomerId, int32[] AreaId, int32 SalesId, int32 CustomerCodeId, int32 StorageId, int32 InvoiceType, int32 BranchId, int32 GroupId) {

          class DataTable var_1;
          int32 num_1;
          string str_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;
          int32 num_2;
          boolean var_8;
          boolean var_9;
          boolean var_10;
          boolean var_11;
          boolean var_12;
          boolean var_13;
          boolean var_14;
          boolean var_15;
          boolean var_16;
          boolean var_17;
          int32 num_3;
          boolean var_18;
          boolean var_19;
          boolean var_20;
          boolean var_21;

        }

        public static class DataTable SearchCommission(valuetype System.DateTime DateFirst, valuetype System.DateTime DateLast, double SalesPersonId) {

          class DataTable var_1;
          string str_1;

        }

        public static class DataTable SearchCustomerVisit(boolean IsVisit, valuetype System.DateTime dateVisit, boolean IsNoVisit, valuetype System.DateTime dateNoVisit, int32 Month, int32 Year, int32 AreaId, int32 SalesPersonId, int32 BranchId) {

          class DataTable var_1;
          string str_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;

        }

        public static class DataTable SearchPayment(valuetype System.DateTime DateFirst, valuetype System.DateTime DateLast, int32 PaymentCodeId, int32 InvoiceType, int32 InvoiceCode, int32 SalesPersonId, int32 CollectorId, int32 TFId, int32 AreaId, int32 StorageId, int32 BranchId, int32 GroupId) {

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

        }

        public static string getInvoiceNumber(int32 intSales, valuetype System.DateTime datInput, boolean blnUseDeleted, int32 intBranchId, boolean blnUpdate) {

          string str_1;
          string str_2;
          double flt_1;
          boolean var_1;
          string str_3;
          string str_4;
          class DataTable var_2;
          class DataTable var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          class System.Collections.IEnumerator var_7;
          class DataRow var_8;
          boolean var_9;
          boolean var_10;
          boolean var_11;
          boolean var_12;
          boolean var_13;
          boolean var_14;
          boolean var_15;
          boolean var_16;
          boolean var_17;
          boolean var_18;
          boolean var_19;

        }

        public static string getTaxInvoiceNumber(int32 intSales, valuetype System.DateTime datInput, int32 intBranchId, boolean blnUpdate) {

          string str_1;
          string str_2;
          double flt_1;
          boolean var_1;
          class DataTable var_2;
          class DataTable var_3;
          class System.Collections.IEnumerator var_4;
          class DataRow var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;
          boolean var_9;
          boolean var_10;
          boolean var_11;
          boolean var_12;
          boolean var_13;
          boolean var_14;
          boolean var_15;

        }

        public static int32 TotalUnpaidInvoice(double CustomerId) {

          int32 num_1;
          string str_1;
          class DataTable var_1;

        }

        public static boolean isMoreThanLimit(double dblCustId) {

          boolean var_1;
          class GCUv2.cCustomer var_2;
          boolean var_3;

        }

        public static double[] arrChequeNotDue(double intId) {

          double[] var_1;
          string str_1;
          class DataTable var_2;
          double[] var_3;
          boolean var_4;
          int32 num_1;
          class System.Collections.IEnumerator var_5;
          class DataRow var_6;
          boolean var_7;

        }

        public static class DataTable GetUnpaidReturn(double CustomerParentId) {

          class DataTable var_1;
          string str_1;

        }

        public static class DataTable SearchUnpaid(int32 CustomerId) {

          class DataTable var_1;
          string str_1;

        }

        public static double GetTotalReturnConnectedToCreditInvoice(valuetype System.DateTime BeginDate, valuetype System.DateTime EndDate, int32 BranchId, int32 GroupId) {

          double flt_1;
          class DataTable var_1;
          string str_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;

        }

        public static double GetTotalPaymentDiscountOfCreditInvoice(valuetype System.DateTime BeginDate, valuetype System.DateTime EndDate, int32 BranchId, int32 GroupId) {

          double flt_1;
          class DataTable var_1;
          string str_1;
          boolean var_2;

        }

        private string GenerateNewNumber() {

          string str_1;
          string str_2;
          class DataTable var_1;
          int32 num_1;
          boolean var_2;

        }

        public static int32 GetTotalPrint(double InvoiceId, int32 InvoiceType) {

          int32 num_1;
          string str_1;
          class DataTable var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;

        }

        public static void SetTotalPrint(double InvoiceId, int32 InvoiceType) {

          string str_1;
          boolean var_1;
          boolean var_2;

        }

    }
}
