using mscorlib;

namespace GCUv2
{
    public class 
    {

        private double _id;
        private int32 _number;
        private int32 _month;
        private int32 _year;
        private valuetype System.DateTime _receiptDate;
        private double _amount;
        private string _receiveFrom;
        private string _name;
        private string _city;
        private valuetype SalesInvoice[] _invoice;
        private double _customerId;
        private string _customerName;
        private string _customerAddress;
        private string _customerPT;

        public struct SalesInvoice
        {
            public double _id;
            public string _number;
            public valuetype System.DateTime _date;
            public double _amount;
        }


        public specialname double get_Id() {

          double flt_1;

        }

        public specialname void set_Id(double value) {

          loc_4232BD: nop
          loc_4232BE: ldarg.0
          loc_4232BF: ldarg.1
          loc_4232C0: stfld GCUv2.cSalesPriceCodeItem::_id
          loc_4232C5: ret
        }

        public specialname int32 get_Number() {

          int32 num_1;

        }

        public specialname void set_Number(int32 value) {

          loc_4232E1: nop
          loc_4232E2: ldarg.0
          loc_4232E3: ldarg.1
          loc_4232E4: stfld GCUv2.cSalesReceipt::_number
          loc_4232E9: ret
        }

        public specialname int32 get_ReceiptMonth() {

          int32 num_1;

        }

        public specialname void set_ReceiptMonth(int32 value) {

          loc_423305: nop
          loc_423306: ldarg.0
          loc_423307: ldarg.1
          loc_423308: stfld GCUv2.cSalesReceipt::_month
          loc_42330D: ret
        }

        public specialname int32 get_ReceiptYear() {

          int32 num_1;

        }

        public specialname void set_ReceiptYear(int32 value) {

          loc_423329: nop
          loc_42332A: ldarg.0
          loc_42332B: ldarg.1
          loc_42332C: stfld GCUv2.cSalesReceipt::_year
          loc_423331: ret
        }

        public specialname valuetype System.DateTime get_ReceiptDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_ReceiptDate(valuetype System.DateTime value) {

          loc_42334D: nop
          loc_42334E: ldarg.0
          loc_42334F: ldarg.1
          loc_423350: stfld GCUv2.cSalesReceipt::_receiptDate
          loc_423355: ret
        }

        public specialname double get_Amount() {

          double flt_1;

        }

        public specialname void set_Amount(double value) {

          loc_423371: nop
          loc_423372: ldarg.0
          loc_423373: ldarg.1
          loc_423374: stfld GCUv2.cSalesReceipt::_amount
          loc_423379: ret
        }

        public specialname string get_ReceiveFrom() {

          string str_1;

        }

        public specialname void set_ReceiveFrom(string value) {

          loc_423395: nop
          loc_423396: ldarg.0
          loc_423397: ldarg.1
          loc_423398: stfld GCUv2.cSalesReceipt::_receiveFrom
          loc_42339D: ret
        }

        public specialname string get_Name() {

          string str_1;

        }

        public specialname void set_Name(string value) {

          loc_4233B9: nop
          loc_4233BA: ldarg.0
          loc_4233BB: ldarg.1
          loc_4233BC: call string GCUv2.Module1::cleanString(string)
          loc_4233C1: stfld GCUv2.cSalesReceipt::_name
          loc_4233C6: ret
        }

        public specialname string get_City() {

          string str_1;

        }

        public specialname void set_City(string value) {

          loc_4233E1: nop
          loc_4233E2: ldarg.0
          loc_4233E3: ldarg.1
          loc_4233E4: call string GCUv2.Module1::cleanString(string)
          loc_4233E9: stfld GCUv2.cSalesReceipt::_city
          loc_4233EE: ret
        }

        public specialname valuetype SalesInvoice[] get_Invoice() {

          valuetype SalesInvoice[] var_1;

        }

        public specialname void set_Invoice(valuetype SalesInvoice[] value) {

          loc_423409: nop
          loc_42340A: ldarg.0
          loc_42340B: ldarg.1
          loc_42340C: stfld GCUv2.cSalesReceipt::_invoice
          loc_423411: ret
        }

        public specialname double get_CustomerId() {

          double flt_1;

        }

        public specialname void set_CustomerId(double value) {

          loc_42342D: nop
          loc_42342E: ldarg.0
          loc_42342F: ldarg.1
          loc_423430: stfld GCUv2.cSalesReceipt::_customerId
          loc_423435: ret
        }

        public specialname string get_CustomerName() {

          string str_1;

        }

        public specialname void set_CustomerName(string value) {

          loc_423451: nop
          loc_423452: ldarg.0
          loc_423453: ldarg.1
          loc_423454: stfld GCUv2.cSalesReceipt::_customerName
          loc_423459: ret
        }

        public specialname string get_CustomerAddress() {

          string str_1;

        }

        public specialname void set_CustomerAddress(string value) {

          loc_423475: nop
          loc_423476: ldarg.0
          loc_423477: ldarg.1
          loc_423478: stfld GCUv2.cSalesReceipt::_customerAddress
          loc_42347D: ret
        }

        public specialname string get_CustomerPT() {

          string str_1;

        }

        public specialname void set_CustomerPT(string value) {

          loc_423499: nop
          loc_42349A: ldarg.0
          loc_42349B: ldarg.1
          loc_42349C: stfld GCUv2.cSalesReceipt::_customerPT
          loc_4234A1: ret
        }

        public void cSalesReceipt(double Id) {

          boolean var_1;
          class DataTable var_2;
          string str_1;
          int32 num_1;
          boolean var_3;
          class System.Collections.IEnumerator var_4;
          class DataRow var_5;
          boolean var_6;

        }

        public static class DataTable Search(int32 Range, valuetype System.DateTime FirstDate, valuetype System.DateTime LastDate, double CustomerId, int32 StorageId, int32 BranchId, int32 GroupId) {

          class DataTable var_1;
          string str_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;

        }

        public static object FormatSalesReceiptNumber(string ReceiptCode, int32 ReceiptNumber, int32 Month, int32 Year) {

          object var_1;

        }

        public void Save() {

          int32 num_1;
          int32 num_2;
          string str_1;
          class MySqlClient.MySqlTransaction var_1;
          boolean var_2;
          valuetype SalesInvoice[] var_3;
          int32 num_3;
          valuetype SalesInvoice var_4;
          boolean var_5;
          boolean var_6;

        }

        public void Delete() {

          string str_1;

        }

        private string GenerateNewNumber() {

          string str_1;
          string str_2;
          class DataTable var_1;
          int32 num_1;
          boolean var_2;

        }

        public static class DataTable GetReceiptCandidate(int32 CustomerId, int32 GroupId) {

          class DataTable var_1;
          string str_1;

        }

    }
}
