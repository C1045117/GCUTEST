using mscorlib;

namespace GCUv2
{
    public class 
    {

        private double _id;
        private valuetype System.DateTime _soDate;
        private valuetype System.DateTime _expiredDate;
        private string _soNumber;
        private string _poNumber;
        private double _totalPrice;
        private double _discount;
        private string _discountDescription;
        private string _note;
        private valuetype System.DateTime _createdDate;
        private class GCUv2.cSalesOrderItem[] _item;
        private double _customerId;
        private string _customerName;
        private string _customerAddress;
        private int32 _branchId;
        private double _invoiceId;
        private string _invoiceNumber;
        private int32 _discountId;


        public specialname double get_Id() {

          double flt_1;

        }

        public specialname void set_Id(double value) {

          loc_4214D9: nop
          loc_4214DA: ldarg.0
          loc_4214DB: ldarg.1
          loc_4214DC: stfld GCUv2.cSalesInvoiceReturn::_id
          loc_4214E1: ret
        }

        public specialname valuetype System.DateTime get_SODate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_SODate(valuetype System.DateTime value) {

          loc_4214FD: nop
          loc_4214FE: ldarg.0
          loc_4214FF: ldarg.1
          loc_421500: stfld GCUv2.cSalesOrder::_soDate
          loc_421505: ret
        }

        public specialname valuetype System.DateTime get_ExpiredDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_ExpiredDate(valuetype System.DateTime value) {

          loc_421521: nop
          loc_421522: ldarg.0
          loc_421523: ldarg.1
          loc_421524: stfld GCUv2.cSalesOrder::_expiredDate
          loc_421529: ret
        }

        public specialname string get_SONumber() {

          string str_1;

        }

        public specialname void set_SONumber(string value) {

          loc_421545: nop
          loc_421546: ldarg.0
          loc_421547: ldarg.1
          loc_421548: stfld GCUv2.cSalesOrder::_soNumber
          loc_42154D: ret
        }

        public specialname string get_PONumber() {

          string str_1;

        }

        public specialname void set_PONumber(string value) {

          loc_421569: nop
          loc_42156A: ldarg.0
          loc_42156B: ldarg.1
          loc_42156C: stfld GCUv2.cSalesOrder::_poNumber
          loc_421571: ret
        }

        public specialname double get_TotalPrice() {

          double flt_1;

        }

        public specialname void set_TotalPrice(double value) {

          loc_42158D: nop
          loc_42158E: ldarg.0
          loc_42158F: ldarg.1
          loc_421590: stfld GCUv2.cSalesOrder::_totalPrice
          loc_421595: ret
        }

        public specialname double get_Discount() {

          double flt_1;

        }

        public specialname void set_Discount(double value) {

          loc_4215B1: nop
          loc_4215B2: ldarg.0
          loc_4215B3: ldarg.1
          loc_4215B4: stfld GCUv2.cSalesOrder::_discount
          loc_4215B9: ret
        }

        public specialname string get_DiscountDescription() {

          string str_1;

        }

        public specialname void set_DiscountDescription(string value) {

          loc_4215D5: nop
          loc_4215D6: ldarg.0
          loc_4215D7: ldarg.1
          loc_4215D8: call string GCUv2.Module1::cleanString(string)
          loc_4215DD: stfld GCUv2.cSalesOrder::_discountDescription
          loc_4215E2: ret
        }

        public specialname string get_Note() {

          string str_1;

        }

        public specialname void set_Note(string value) {

          loc_4215FD: nop
          loc_4215FE: ldarg.0
          loc_4215FF: ldarg.1
          loc_421600: call string GCUv2.Module1::cleanString(string)
          loc_421605: stfld GCUv2.cSalesOrder::_note
          loc_42160A: ret
        }

        public specialname valuetype System.DateTime get_CreatedDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_CreatedDate(valuetype System.DateTime value) {

          loc_421625: nop
          loc_421626: ldarg.0
          loc_421627: ldarg.1
          loc_421628: stfld GCUv2.cSalesOrder::_createdDate
          loc_42162D: ret
        }

        public specialname class GCUv2.cSalesOrderItem[] get_Item() {

          class GCUv2.cSalesOrderItem[] var_1;

        }

        public specialname void set_Item(class GCUv2.cSalesOrderItem[] value) {

          loc_421649: nop
          loc_42164A: ldarg.0
          loc_42164B: ldarg.1
          loc_42164C: stfld GCUv2.cSalesOrder::_item
          loc_421651: ret
        }

        public specialname double get_CustomerId() {

          double flt_1;

        }

        public specialname void set_CustomerId(double value) {

          loc_42166D: nop
          loc_42166E: ldarg.0
          loc_42166F: ldarg.1
          loc_421670: stfld GCUv2.cSalesOrder::_customerId
          loc_421675: ret
        }

        public specialname string get_CustomerName() {

          string str_1;

        }

        public specialname void set_CustomerName(string value) {

          loc_421691: nop
          loc_421692: ldarg.0
          loc_421693: ldarg.1
          loc_421694: stfld GCUv2.cSalesOrder::_customerName
          loc_421699: ret
        }

        public specialname string get_CustomerAddress() {

          string str_1;

        }

        public specialname void set_CustomerAddress(string value) {

          loc_4216B5: nop
          loc_4216B6: ldarg.0
          loc_4216B7: ldarg.1
          loc_4216B8: stfld GCUv2.cSalesOrder::_customerAddress
          loc_4216BD: ret
        }

        public specialname int32 get_BranchId() {

          int32 num_1;

        }

        public specialname void set_BranchId(int32 value) {

          loc_4216D9: nop
          loc_4216DA: ldarg.0
          loc_4216DB: ldarg.1
          loc_4216DC: stfld GCUv2.cSalesOrder::_branchId
          loc_4216E1: ret
        }

        public specialname double get_InvoiceId() {

          double flt_1;

        }

        public specialname void set_InvoiceId(double value) {

          loc_4216FD: nop
          loc_4216FE: ldarg.0
          loc_4216FF: ldarg.1
          loc_421700: stfld GCUv2.cSalesOrder::_invoiceId
          loc_421705: ret
        }

        public specialname string get_InvoiceNumber() {

          string str_1;

        }

        public specialname void set_InvoiceNumber(string value) {

          loc_421721: nop
          loc_421722: ldarg.0
          loc_421723: ldarg.1
          loc_421724: stfld GCUv2.cSalesOrder::_invoiceNumber
          loc_421729: ret
        }

        public specialname int32 get_DiscountId() {

          int32 num_1;

        }

        public specialname void set_DiscountId(int32 value) {

          loc_421745: nop
          loc_421746: ldarg.0
          loc_421747: ldarg.1
          loc_421748: stfld GCUv2.cSalesOrder::_discountId
          loc_42174D: ret
        }

        public void cSalesOrder(double SOId) {

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

        public void Save() {

          int32 num_1;
          int32 num_2;
          string str_1;
          class MySqlClient.MySqlTransaction var_1;
          boolean var_2;
          class GCUv2.cSalesOrderItem[] var_3;
          int32 num_3;
          class GCUv2.cSalesOrderItem var_4;
          boolean var_5;
          boolean var_6;

        }

        public static class DataTable Search(int32 intRange, valuetype System.DateTime dateFirst, valuetype System.DateTime dateLast, double CustomerId, int32 GroupId, int32 BranchId, double InvoiceId) {

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

    }
}
