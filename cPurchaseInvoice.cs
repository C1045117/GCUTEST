using mscorlib;

namespace GCUv2
{
    public class 
    {

        private double _id;
        private int32 _supplierId;
        private valuetype System.DateTime _invoiceDate;
        private valuetype System.DateTime _taxInvoiceDate;
        private string _number;
        private string _taxNumber;
        private int32 _isTaxIncluded;
        private int32 _invoiceCode;
        private double _discount;
        private double _deduction;
        private class GCUv2.cPurchaseInvoiceItem[] _currentItem;
        private valuetype System.DateTime _currentDate;
        private class GCUv2.cPurchaseInvoiceItem[] _item;
        private class GCUv2.cPurchaseInvoicePayment[] _payment;
        private class GCUv2.cPurchaseInvoiceReturn[] _invoiceReturn;
        private double _totalPrice;
        private double _totalReturn;
        private double _totalPayment;
        private valuetype System.DateTime _paidDate;
        private int32 _isReturn;
        private boolean _isTaxInvoice;
        private double _parentInvoiceId;
        private string _parentInvoiceNumber;
        private valuetype System.DateTime _createdDate;
        private double[] _riId;
        private int32 _currencyId;
        private double _currencyRate;
        private string _currencyName;
        private int32 _storageId;


        public specialname double get_Id() {

          double flt_1;

        }

        public specialname void set_Id(double value) {

          loc_416ADD: nop
          loc_416ADE: ldarg.0
          loc_416ADF: ldarg.1
          loc_416AE0: stfld GCUv2.cProcess::_id
          loc_416AE5: ret
        }

        public specialname int32 get_SupplierId() {

          int32 num_1;

        }

        public specialname void set_SupplierId(int32 value) {

          loc_416B01: nop
          loc_416B02: ldarg.0
          loc_416B03: ldarg.1
          loc_416B04: stfld GCUv2.cPurchaseInvoice::_supplierId
          loc_416B09: ret
        }

        public specialname valuetype System.DateTime get_InvoiceDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_InvoiceDate(valuetype System.DateTime value) {

          loc_416B25: nop
          loc_416B26: ldarg.0
          loc_416B27: ldarg.1
          loc_416B28: stfld GCUv2.cPurchaseInvoice::_invoiceDate
          loc_416B2D: ret
        }

        public specialname valuetype System.DateTime get_TaxInvoiceDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_TaxInvoiceDate(valuetype System.DateTime value) {

          loc_416B49: nop
          loc_416B4A: ldarg.0
          loc_416B4B: ldarg.1
          loc_416B4C: stfld GCUv2.cPurchaseInvoice::_taxInvoiceDate
          loc_416B51: ret
        }

        public specialname valuetype System.DateTime get_CurrentDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_CurrentDate(valuetype System.DateTime value) {

          loc_416B6D: nop
          loc_416B6E: ldarg.0
          loc_416B6F: ldarg.1
          loc_416B70: stfld GCUv2.cPurchaseInvoice::_currentDate
          loc_416B75: ret
        }

        public specialname string get_Number() {

          string str_1;

        }

        public specialname void set_Number(string value) {

          loc_416B91: nop
          loc_416B92: ldarg.0
          loc_416B93: ldarg.1
          loc_416B94: stfld GCUv2.cPurchaseInvoice::_number
          loc_416B99: ret
        }

        public specialname string get_TaxNumber() {

          string str_1;

        }

        public specialname void set_TaxNumber(string value) {

          loc_416BB5: nop
          loc_416BB6: ldarg.0
          loc_416BB7: ldarg.1
          loc_416BB8: stfld GCUv2.cPurchaseInvoice::_taxNumber
          loc_416BBD: ret
        }

        public specialname int32 get_isTaxIncluded() {

          int32 num_1;

        }

        public specialname void set_isTaxIncluded(int32 value) {

          loc_416BD9: nop
          loc_416BDA: ldarg.0
          loc_416BDB: ldarg.1
          loc_416BDC: stfld GCUv2.cPurchaseInvoice::_isTaxIncluded
          loc_416BE1: ret
        }

        public specialname int32 get_InvoiceCode() {

          int32 num_1;

        }

        public specialname void set_InvoiceCode(int32 value) {

          loc_416BFD: nop
          loc_416BFE: ldarg.0
          loc_416BFF: ldarg.1
          loc_416C00: stfld GCUv2.cPurchaseInvoice::_invoiceCode
          loc_416C05: ret
        }

        public specialname double get_Discount() {

          double flt_1;

        }

        public specialname void set_Discount(double value) {

          loc_416C21: nop
          loc_416C22: ldarg.0
          loc_416C23: ldarg.1
          loc_416C24: stfld GCUv2.cPurchaseInvoice::_discount
          loc_416C29: ret
        }

        public specialname double get_Deduction() {

          double flt_1;

        }

        public specialname void set_Deduction(double value) {

          loc_416C45: nop
          loc_416C46: ldarg.0
          loc_416C47: ldarg.1
          loc_416C48: stfld GCUv2.cPurchaseInvoice::_deduction
          loc_416C4D: ret
        }

        public specialname class GCUv2.cPurchaseInvoiceItem[] get_Item() {

          class GCUv2.cPurchaseInvoiceItem[] var_1;

        }

        public specialname void set_Item(class GCUv2.cPurchaseInvoiceItem[] value) {

          loc_416C69: nop
          loc_416C6A: ldarg.0
          loc_416C6B: ldarg.1
          loc_416C6C: stfld GCUv2.cPurchaseInvoice::_item
          loc_416C71: ret
        }

        public specialname class GCUv2.cPurchaseInvoiceItem[] get_CurrentItem() {

          class GCUv2.cPurchaseInvoiceItem[] var_1;

        }

        public specialname void set_CurrentItem(class GCUv2.cPurchaseInvoiceItem[] value) {

          loc_416C8D: nop
          loc_416C8E: ldarg.0
          loc_416C8F: ldarg.1
          loc_416C90: stfld GCUv2.cPurchaseInvoice::_currentItem
          loc_416C95: ret
        }

        public specialname class GCUv2.cPurchaseInvoicePayment[] get_Payment() {

          class GCUv2.cPurchaseInvoicePayment[] var_1;

        }

        public specialname void set_Payment(class GCUv2.cPurchaseInvoicePayment[] value) {

          loc_416CB1: nop
          loc_416CB2: ldarg.0
          loc_416CB3: ldarg.1
          loc_416CB4: stfld GCUv2.cPurchaseInvoice::_payment
          loc_416CB9: ret
        }

        public specialname class GCUv2.cPurchaseInvoiceReturn[] get_InvoiceReturn() {

          class GCUv2.cPurchaseInvoiceReturn[] var_1;

        }

        public specialname void set_InvoiceReturn(class GCUv2.cPurchaseInvoiceReturn[] value) {

          loc_416CD5: nop
          loc_416CD6: ldarg.0
          loc_416CD7: ldarg.1
          loc_416CD8: stfld GCUv2.cPurchaseInvoice::_invoiceReturn
          loc_416CDD: ret
        }

        public specialname double get_TotalPrice() {

          double flt_1;

        }

        public specialname void set_TotalPrice(double value) {

          loc_416CF9: nop
          loc_416CFA: ldarg.0
          loc_416CFB: ldarg.1
          loc_416CFC: stfld GCUv2.cPurchaseInvoice::_totalPrice
          loc_416D01: ret
        }

        public specialname double get_TotalReturn() {

          double flt_1;

        }

        public specialname void set_TotalReturn(double value) {

          loc_416D1D: nop
          loc_416D1E: ldarg.0
          loc_416D1F: ldarg.1
          loc_416D20: stfld GCUv2.cPurchaseInvoice::_totalReturn
          loc_416D25: ret
        }

        public specialname double get_TotalPayment() {

          double flt_1;

        }

        public specialname void set_TotalPayment(double value) {

          loc_416D41: nop
          loc_416D42: ldarg.0
          loc_416D43: ldarg.1
          loc_416D44: stfld GCUv2.cPurchaseInvoice::_totalPayment
          loc_416D49: ret
        }

        public specialname valuetype System.DateTime get_PaidDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_PaidDate(valuetype System.DateTime value) {

          loc_416D65: nop
          loc_416D66: ldarg.0
          loc_416D67: ldarg.1
          loc_416D68: stfld GCUv2.cPurchaseInvoice::_paidDate
          loc_416D6D: ret
        }

        public specialname int32 get_isReturn() {

          int32 num_1;

        }

        public specialname void set_isReturn(int32 value) {

          loc_416D89: nop
          loc_416D8A: ldarg.0
          loc_416D8B: ldarg.1
          loc_416D8C: stfld GCUv2.cPurchaseInvoice::_isReturn
          loc_416D91: ret
        }

        public specialname boolean get_IsTaxInvoice() {

          boolean var_1;

        }

        public specialname void set_IsTaxInvoice(boolean value) {

          loc_416DAD: nop
          loc_416DAE: ldarg.0
          loc_416DAF: ldarg.1
          loc_416DB0: stfld GCUv2.cPurchaseInvoice::_isTaxInvoice
          loc_416DB5: ret
        }

        public specialname double get_ParentInvoiceId() {

          double flt_1;

        }

        public specialname void set_ParentInvoiceId(double value) {

          loc_416DD1: nop
          loc_416DD2: ldarg.0
          loc_416DD3: ldarg.1
          loc_416DD4: stfld GCUv2.cPurchaseInvoice::_parentInvoiceId
          loc_416DD9: ret
        }

        public specialname string get_ParentInvoiceNumber() {

          string str_1;

        }

        public specialname void set_ParentInvoiceNumber(string value) {

          loc_416DF5: nop
          loc_416DF6: ldarg.0
          loc_416DF7: ldarg.1
          loc_416DF8: stfld GCUv2.cPurchaseInvoice::_parentInvoiceNumber
          loc_416DFD: ret
        }

        public specialname valuetype System.DateTime get_CreatedDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_CreatedDate(valuetype System.DateTime value) {

          loc_416E19: nop
          loc_416E1A: ldarg.0
          loc_416E1B: ldarg.1
          loc_416E1C: stfld GCUv2.cPurchaseInvoice::_createdDate
          loc_416E21: ret
        }

        public specialname double[] get_RiId() {

          double[] var_1;

        }

        public specialname void set_RiId(double[] value) {

          loc_416E3D: nop
          loc_416E3E: ldarg.0
          loc_416E3F: ldarg.1
          loc_416E40: stfld GCUv2.cPurchaseInvoice::_riId
          loc_416E45: ret
        }

        public specialname int32 get_CurrencyId() {

          int32 num_1;

        }

        public specialname void set_CurrencyId(int32 value) {

          loc_416E61: nop
          loc_416E62: ldarg.0
          loc_416E63: ldarg.1
          loc_416E64: stfld GCUv2.cPurchaseInvoice::_currencyId
          loc_416E69: ret
        }

        public specialname string get_CurrencyName() {

          string str_1;

        }

        public specialname void set_CurrencyName(string value) {

          loc_416E85: nop
          loc_416E86: ldarg.0
          loc_416E87: ldarg.1
          loc_416E88: stfld GCUv2.cPurchaseInvoice::_currencyName
          loc_416E8D: ret
        }

        public specialname double get_CurrencyRate() {

          double flt_1;

        }

        public specialname void set_CurrencyRate(double value) {

          loc_416EA9: nop
          loc_416EAA: ldarg.0
          loc_416EAB: ldarg.1
          loc_416EAC: stfld GCUv2.cPurchaseInvoice::_currencyRate
          loc_416EB1: ret
        }

        public specialname int32 get_StorageId() {

          int32 num_1;

        }

        public specialname void set_StorageId(int32 value) {

          loc_416ECD: nop
          loc_416ECE: ldarg.0
          loc_416ECF: ldarg.1
          loc_416ED0: stfld GCUv2.cPurchaseInvoice::_storageId
          loc_416ED5: ret
        }

        public void cPurchaseInvoice(double InvId) {

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
          class GCUv2.cChequeOut var_13;
          boolean var_14;
          boolean var_15;
          class System.Collections.IEnumerator var_16;
          class DataRow var_17;
          boolean var_18;

        }

        public void Save() {

          int32 num_1;
          int32 num_2;
          string str_1;
          class DataTable var_1;
          class MySqlClient.MySqlTransaction var_2;
          int32 num_3;
          valuetype System.DateTime var_3;
          int32[] var_4;
          double[] var_5;
          int32 num_4;
          double flt_1;
          double flt_2;
          double flt_3;
          double flt_4;
          int32 num_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;
          boolean var_9;
          int32 num_6;
          boolean var_10;
          class System.Collections.IEnumerator var_11;
          class DataRow var_12;
          boolean var_13;
          class GCUv2.cPurchaseInvoiceItem[] var_14;
          int32 num_7;
          class GCUv2.cPurchaseInvoiceItem var_15;
          boolean var_16;
          boolean var_17;
          boolean var_18;
          class GCUv2.cPurchaseInvoicePayment[] var_19;
          int32 num_8;
          class GCUv2.cPurchaseInvoicePayment var_20;
          boolean var_21;
          boolean var_22;
          boolean var_23;
          boolean var_24;
          boolean var_25;
          class GCUv2.cPurchaseInvoiceReturn[] var_26;
          int32 num_9;
          class GCUv2.cPurchaseInvoiceReturn var_27;
          boolean var_28;
          boolean var_29;
          class GCUv2.cPurchaseInvoiceItem[] var_30;
          int32 num_10;
          class GCUv2.cPurchaseInvoiceItem var_31;
          boolean var_32;
          int32 num_11;
          boolean var_33;
          double & var_34;
          boolean var_35;
          int32 num_12;
          class GCUv2.cPurchaseInvoicePayment[] var_36;
          int32 num_13;
          class GCUv2.cPurchaseInvoicePayment var_37;
          boolean var_38;
          boolean var_39;
          boolean var_40;

        }

        public void Delete() {

          int32 num_1;
          int32 num_2;
          string str_1;
          int32 num_3;
          class DataTable var_1;
          class MySqlClient.MySqlTransaction var_2;
          boolean var_3;
          int32 num_4;
          boolean var_4;
          class System.Collections.IEnumerator var_5;
          class DataRow var_6;
          boolean var_7;
          boolean var_8;
          double flt_1;
          boolean var_9;

        }

        public static class DataTable Search(int32 intRange, valuetype System.DateTime dateFirst, valuetype System.DateTime dateLast, int32 ItemId, int32 SupplierId, string InvoiceNumber, int32 InvoiceCode, int32 InvoiceType, int32 GroupId, int32 BranchId, int32 SupplierHasNPWP, int32 PaymentStatus, boolean ShowPrice) {

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

        }

        public static class DataTable SearchItem(valuetype System.DateTime dateFirst, valuetype System.DateTime dateLast, int32 SupplierId, int32 InvoiceType, int32 SearchType, int32 ItemCategoryId, int32 ItemId, int32 GroupId) {

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

        }

        public static class DataTable dtUnpaid(int32 SupplierId, int32 GroupId) {

          class DataTable var_1;
          string str_1;

        }

        public static double GetSupplierBalance(valuetype System.DateTime FirstBalanceDate, valuetype System.DateTime BalanceDate, int32 SupplierId) {

          double flt_1;
          string str_1;
          double flt_2;
          class DataTable var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;
          boolean var_9;

        }

        public static class DataTable SearchTransaction(valuetype System.DateTime FirstBalanceDate, valuetype System.DateTime dateFirst, valuetype System.DateTime dateLast, int32 SupplierId) {

          class DataTable var_1;
          string str_1;
          double flt_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;
          boolean var_9;
          boolean var_10;

        }

        private string GenerateNewNumber() {

          string str_1;
          string str_2;
          class DataTable var_1;
          double flt_1;
          boolean var_2;
          boolean var_3;
          double flt_2;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;

        }

        public static class DataTable GetUnpaidReturn(int32 SupplierId) {

          class DataTable var_1;
          string str_1;

        }

    }
}
