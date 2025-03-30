namespace GCUv2
{
    public class GCUv2.cSalesInvoicePayment
    {

        private double _customerId;
        private string _customerName;
        private string _customerAddress;
        private int32 _branchId;
        private class GCUv2.cSalesInvoicePayment[] _allocation;
        private double _allocatedAmount;
        private string _description;
        private int32 _cashAccountId;
        private int32 _bankAccountId;


        public specialname double get_CustomerId() {

          double flt_1;

        }

        public specialname void set_CustomerId(double value) {

          loc_41FD65: nop
          loc_41FD66: ldarg.0
          loc_41FD67: ldarg.1
          loc_41FD68: stfld GCUv2.cSalesInvoiceItem::_customerId
          loc_41FD6D: ret
        }

        public specialname string get_CustomerName() {

          string str_1;

        }

        public specialname void set_CustomerName(string value) {

          loc_41FD89: nop
          loc_41FD8A: ldarg.0
          loc_41FD8B: ldarg.1
          loc_41FD8C: stfld GCUv2.cSalesInvoiceMultiPayment::_customerName
          loc_41FD91: ret
        }

        public specialname string get_CustomerAddress() {

          string str_1;

        }

        public specialname void set_CustomerAddress(string value) {

          loc_41FDAD: nop
          loc_41FDAE: ldarg.0
          loc_41FDAF: ldarg.1
          loc_41FDB0: stfld GCUv2.cSalesInvoiceMultiPayment::_customerAddress
          loc_41FDB5: ret
        }

        public specialname int32 get_BranchId() {

          int32 num_1;

        }

        public specialname void set_BranchId(int32 value) {

          loc_41FDD1: nop
          loc_41FDD2: ldarg.0
          loc_41FDD3: ldarg.1
          loc_41FDD4: stfld GCUv2.cSalesInvoiceMultiPayment::_branchId
          loc_41FDD9: ret
        }

        public specialname class GCUv2.cSalesInvoicePayment[] get_Allocation() {

          class GCUv2.cSalesInvoicePayment[] var_1;

        }

        public specialname void set_Allocation(class GCUv2.cSalesInvoicePayment[] value) {

          loc_41FDF5: nop
          loc_41FDF6: ldarg.0
          loc_41FDF7: ldarg.1
          loc_41FDF8: stfld GCUv2.cSalesInvoiceMultiPayment::_allocation
          loc_41FDFD: ret
        }

        public specialname double get_AllocatedAmount() {

          double flt_1;

        }

        public specialname void set_AllocatedAmount(double value) {

          loc_41FE19: nop
          loc_41FE1A: ldarg.0
          loc_41FE1B: ldarg.1
          loc_41FE1C: stfld GCUv2.cSalesInvoiceMultiPayment::_allocatedAmount
          loc_41FE21: ret
        }

        public specialname string get_Description() {

          string str_1;

        }

        public specialname void set_Description(string value) {

          loc_41FE3D: nop
          loc_41FE3E: ldarg.0
          loc_41FE3F: ldarg.1
          loc_41FE40: call string GCUv2.Module1::cleanStringKeepCrlf(string)
          loc_41FE45: stfld GCUv2.cSalesInvoiceMultiPayment::_description
          loc_41FE4A: ret
        }

        public specialname int32 get_CashAccountId() {

          int32 num_1;

        }

        public specialname void set_CashAccountId(int32 value) {

          loc_41FE65: nop
          loc_41FE66: ldarg.0
          loc_41FE67: ldarg.1
          loc_41FE68: stfld GCUv2.cSalesInvoiceMultiPayment::_cashAccountId
          loc_41FE6D: ret
        }

        public specialname int32 get_BankAccountId() {

          int32 num_1;

        }

        public specialname void set_BankAccountId(int32 value) {

          loc_41FE89: nop
          loc_41FE8A: ldarg.0
          loc_41FE8B: ldarg.1
          loc_41FE8C: stfld GCUv2.cSalesInvoiceMultiPayment::_bankAccountId
          loc_41FE91: ret
        }

        public void cSalesInvoiceMultiPayment(double MultiPaymentId) {

          boolean var_1;
          class DataTable var_2;
          string str_1;
          int32 num_1;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;
          class System.Collections.IEnumerator var_8;
          class DataRow var_9;
          boolean var_10;

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
          boolean var_7;
          boolean var_8;
          class GCUv2.cSalesInvoicePayment[] var_9;
          int32 num_5;
          class GCUv2.cSalesInvoicePayment var_10;
          boolean var_11;
          boolean var_12;
          boolean var_13;
          boolean var_14;

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

    }
}
