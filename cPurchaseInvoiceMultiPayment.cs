namespace GCUv2
{
    public class GCUv2.cPurchaseInvoicePayment
    {

        private int32 _supplierId;
        private string _supplierName;
        private class GCUv2.cPurchaseInvoicePayment[] _allocation;
        private double _allocatedAmount;
        private string _description;


        public specialname int32 get_SupplierId() {

          int32 num_1;

        }

        public specialname void set_SupplierId(int32 value) {

          loc_411F51: nop
          loc_411F52: ldarg.0
          loc_411F53: ldarg.1
          loc_411F54: stfld GCUv2.cPurchaseInvoiceItem::_supplierId
          loc_411F59: ret
        }

        public specialname string get_SupplierName() {

          string str_1;

        }

        public specialname void set_SupplierName(string value) {

          loc_411F75: nop
          loc_411F76: ldarg.0
          loc_411F77: ldarg.1
          loc_411F78: stfld GCUv2.cPurchaseInvoiceMultiPayment::_supplierName
          loc_411F7D: ret
        }

        public specialname string get_Description() {

          string str_1;

        }

        public specialname void set_Description(string value) {

          loc_411F99: nop
          loc_411F9A: ldarg.0
          loc_411F9B: ldarg.1
          loc_411F9C: call string GCUv2.Module1::cleanStringKeepCrlf(string)
          loc_411FA1: stfld GCUv2.cPurchaseInvoiceMultiPayment::_description
          loc_411FA6: ret
        }

        public specialname double get_AllocatedAmount() {

          double flt_1;

        }

        public specialname void set_AllocatedAmount(double value) {

          loc_411FC1: nop
          loc_411FC2: ldarg.0
          loc_411FC3: ldarg.1
          loc_411FC4: stfld GCUv2.cPurchaseInvoiceMultiPayment::_allocatedAmount
          loc_411FC9: ret
        }

        public specialname class GCUv2.cPurchaseInvoicePayment[] get_Allocation() {

          class GCUv2.cPurchaseInvoicePayment[] var_1;

        }

        public specialname void set_Allocation(class GCUv2.cPurchaseInvoicePayment[] value) {

          loc_411FE5: nop
          loc_411FE6: ldarg.0
          loc_411FE7: ldarg.1
          loc_411FE8: stfld GCUv2.cPurchaseInvoiceMultiPayment::_allocation
          loc_411FED: ret
        }

        public void cPurchaseInvoiceMultiPayment(double MultiPaymentId) {

          boolean var_1;
          class DataTable var_2;
          string str_1;
          int32 num_1;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          class System.Collections.IEnumerator var_6;
          class DataRow var_7;
          boolean var_8;

        }

        public void Save() {

          int32 num_1;
          int32 num_2;
          class MySqlClient.MySqlTransaction var_1;
          string str_1;
          class DataTable var_2;
          double flt_1;
          valuetype System.DateTime var_3;
          int32 num_3;
          boolean var_4;
          int32 num_4;
          boolean var_5;
          boolean var_6;
          class GCUv2.cPurchaseInvoicePayment[] var_7;
          int32 num_5;
          class GCUv2.cPurchaseInvoicePayment var_8;
          boolean var_9;
          boolean var_10;
          boolean var_11;

        }

        public void Delete() {

          int32 num_1;
          int32 num_2;
          string str_1;
          class MySqlClient.MySqlTransaction var_1;
          class DataTable var_2;
          int32 num_3;
          int32 num_4;
          boolean var_3;

        }

        public static class DataTable Search(int32 intRange, valuetype System.DateTime dateFirst, valuetype System.DateTime dateLast, int32 SupplierId, int32 PaymentCode, int32 PaymentType, int32 IsReturn, int32 GroupId, int32 BranchId) {

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

        }

    }
}
