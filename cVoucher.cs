using mscorlib;

namespace GCUv2
{
    public class 
    {

        private double _voucherId;
        private string _voucherNumber;
        private valuetype System.DateTime _voucherDate;
        private int32 _voucherType;
        private string _voucherDescription;
        private string _voucherNote;
        private int32 _salesId;
        private valuetype System.DateTime _voucherCreated;
        private class GCUv2.cVoucherAccount[] _account;


        public specialname double get_VoucherId() {

          double flt_1;

        }

        public specialname void set_VoucherId(double value) {

          loc_42A925: nop
          loc_42A926: ldarg.0
          loc_42A927: ldarg.1
          loc_42A928: stfld GCUv2.cUser::_voucherId
          loc_42A92D: ret
        }

        public specialname string get_VoucherNumber() {

          string str_1;

        }

        public specialname void set_VoucherNumber(string value) {

          loc_42A949: nop
          loc_42A94A: ldarg.0
          loc_42A94B: ldarg.1
          loc_42A94C: stfld GCUv2.cVoucher::_voucherNumber
          loc_42A951: ret
        }

        public specialname valuetype System.DateTime get_VoucherDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_VoucherDate(valuetype System.DateTime value) {

          loc_42A96D: nop
          loc_42A96E: ldarg.0
          loc_42A96F: ldarg.1
          loc_42A970: stfld GCUv2.cVoucher::_voucherDate
          loc_42A975: ret
        }

        public specialname int32 get_VoucherType() {

          int32 num_1;

        }

        public specialname void set_VoucherType(int32 value) {

          loc_42A991: nop
          loc_42A992: ldarg.0
          loc_42A993: ldarg.1
          loc_42A994: stfld GCUv2.cVoucher::_voucherType
          loc_42A999: ret
        }

        public specialname string get_VoucherDescription() {

          string str_1;

        }

        public specialname void set_VoucherDescription(string value) {

          loc_42A9B5: nop
          loc_42A9B6: ldarg.0
          loc_42A9B7: ldarg.1
          loc_42A9B8: call string GCUv2.Module1::cleanString(string)
          loc_42A9BD: stfld GCUv2.cVoucher::_voucherDescription
          loc_42A9C2: ret
        }

        public specialname string get_VoucherNote() {

          string str_1;

        }

        public specialname void set_VoucherNote(string value) {

          loc_42A9DD: nop
          loc_42A9DE: ldarg.0
          loc_42A9DF: ldarg.1
          loc_42A9E0: call string GCUv2.Module1::cleanStringKeepCrlf(string)
          loc_42A9E5: stfld GCUv2.cVoucher::_voucherNote
          loc_42A9EA: ret
        }

        public specialname valuetype System.DateTime get_VoucherCreated() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_VoucherCreated(valuetype System.DateTime value) {

          loc_42AA05: nop
          loc_42AA06: ldarg.0
          loc_42AA07: ldarg.1
          loc_42AA08: stfld GCUv2.cVoucher::_voucherCreated
          loc_42AA0D: ret
        }

        public specialname int32 get_SalesId() {

          int32 num_1;

        }

        public specialname void set_SalesId(int32 value) {

          loc_42AA29: nop
          loc_42AA2A: ldarg.0
          loc_42AA2B: ldarg.1
          loc_42AA2C: stfld GCUv2.cVoucher::_salesId
          loc_42AA31: ret
        }

        public specialname class GCUv2.cVoucherAccount[] get_Account() {

          class GCUv2.cVoucherAccount[] var_1;

        }

        public specialname void set_Account(class GCUv2.cVoucherAccount[] value) {

          loc_42AA4D: nop
          loc_42AA4E: ldarg.0
          loc_42AA4F: ldarg.1
          loc_42AA50: stfld GCUv2.cVoucher::_account
          loc_42AA55: ret
        }

        public void cVoucher(double VoucherId) {

          string str_1;
          boolean var_1;
          class DataTable var_2;
          int32 num_1;
          boolean var_3;
          class System.Collections.IEnumerator var_4;
          class DataRow var_5;
          boolean var_6;

        }

        public void save() {

          int32 num_1;
          int32 num_2;
          string str_1;
          class MySqlClient.MySqlTransaction var_1;
          boolean var_2;
          class GCUv2.cVoucherAccount[] var_3;
          int32 num_3;
          class GCUv2.cVoucherAccount var_4;
          boolean var_5;
          boolean var_6;

        }

        public void Delete() {

          string str_1;

        }

        public static class DataTable Search(int32 intRange, valuetype System.DateTime dateFirst, valuetype System.DateTime dateLast, int32 VoucherType, int32 AccountId, string Description) {

          class DataTable var_1;
          string str_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;

        }

        public static class DataTable SearchCashBank(int32 intRange, valuetype System.DateTime dateFirst, valuetype System.DateTime dateLast, int32 VoucherType, int32 AccountId, int32 CounterAccountId, int32 DebitCredit, int32 SalesId, string Description, int32 GroupId) {

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
