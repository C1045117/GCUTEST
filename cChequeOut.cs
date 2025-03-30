using mscorlib;

namespace GCUv2
{
    public class 
    {

        private double _id;
        private double _paymentId;
        private double _multiPaymentId;
        private string _number;
        private valuetype System.DateTime _chequeDate;


        public specialname double get_Id() {

          double flt_1;

        }

        public specialname void set_Id(double value) {

          loc_406EE9: nop
          loc_406EEA: ldarg.0
          loc_406EEB: ldarg.1
          loc_406EEC: stfld GCUv2.cChequeIn::_id
          loc_406EF1: ret
        }

        public specialname double get_PaymentId() {

          double flt_1;

        }

        public specialname void set_PaymentId(double value) {

          loc_406F0D: nop
          loc_406F0E: ldarg.0
          loc_406F0F: ldarg.1
          loc_406F10: stfld GCUv2.cChequeOut::_paymentId
          loc_406F15: ret
        }

        public specialname double get_MultiPaymentId() {

          double flt_1;

        }

        public specialname void set_MultiPaymentId(double value) {

          loc_406F31: nop
          loc_406F32: ldarg.0
          loc_406F33: ldarg.1
          loc_406F34: stfld GCUv2.cChequeOut::_multiPaymentId
          loc_406F39: ret
        }

        public specialname string get_Number() {

          string str_1;

        }

        public specialname void set_Number(string value) {

          loc_406F55: nop
          loc_406F56: ldarg.0
          loc_406F57: ldarg.1
          loc_406F58: stfld GCUv2.cChequeOut::_number
          loc_406F5D: ret
        }

        public specialname valuetype System.DateTime get_ChequeDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_ChequeDate(valuetype System.DateTime value) {

          loc_406F79: nop
          loc_406F7A: ldarg.0
          loc_406F7B: ldarg.1
          loc_406F7C: stfld GCUv2.cChequeOut::_chequeDate
          loc_406F81: ret
        }

        public void cChequeOut(double PaymentId, double MultiPaymentId) {

          string str_1;
          class DataTable var_1;
          boolean var_2;
          boolean var_3;

        }

        public static class DataTable Search(int32 Range, valuetype System.DateTime FirstDate, valuetype System.DateTime LastDate, string ChequeNo, int32 BankAccountId, int32 GroupId) {

          class DataTable var_1;
          string str_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;

        }

    }
}
