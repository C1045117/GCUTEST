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
        private double _amount;
        private valuetype System.DateTime _depositDate;
        private valuetype System.DateTime _clearingDate;
        private int32 _bankId;
        private string _bankName;
        private string _accountName;


        public specialname double get_Id() {

          double flt_1;

        }

        public specialname void set_Id(double value) {

          loc_406815: nop
          loc_406816: ldarg.0
          loc_406817: ldarg.1
          loc_406818: stfld GCUv2.cBranch::_id
          loc_40681D: ret
        }

        public specialname double get_PaymentId() {

          double flt_1;

        }

        public specialname void set_PaymentId(double value) {

          loc_406839: nop
          loc_40683A: ldarg.0
          loc_40683B: ldarg.1
          loc_40683C: stfld GCUv2.cChequeIn::_paymentId
          loc_406841: ret
        }

        public specialname double get_MultiPaymentId() {

          double flt_1;

        }

        public specialname void set_MultiPaymentId(double value) {

          loc_40685D: nop
          loc_40685E: ldarg.0
          loc_40685F: ldarg.1
          loc_406860: stfld GCUv2.cChequeIn::_multiPaymentId
          loc_406865: ret
        }

        public specialname string get_Number() {

          string str_1;

        }

        public specialname void set_Number(string value) {

          loc_406881: nop
          loc_406882: ldarg.0
          loc_406883: ldarg.1
          loc_406884: stfld GCUv2.cChequeIn::_number
          loc_406889: ret
        }

        public specialname valuetype System.DateTime get_ChequeDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_ChequeDate(valuetype System.DateTime value) {

          loc_4068A5: nop
          loc_4068A6: ldarg.0
          loc_4068A7: ldarg.1
          loc_4068A8: stfld GCUv2.cChequeIn::_chequeDate
          loc_4068AD: ret
        }

        public specialname double get_Amount() {

          double flt_1;

        }

        public specialname void set_Amount(double value) {

          loc_4068C9: nop
          loc_4068CA: ldarg.0
          loc_4068CB: ldarg.1
          loc_4068CC: stfld GCUv2.cChequeIn::_amount
          loc_4068D1: ret
        }

        public specialname valuetype System.DateTime get_DepositDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_DepositDate(valuetype System.DateTime value) {

          loc_4068ED: nop
          loc_4068EE: ldarg.0
          loc_4068EF: ldarg.1
          loc_4068F0: stfld GCUv2.cChequeIn::_depositDate
          loc_4068F5: ret
        }

        public specialname valuetype System.DateTime get_ClearingDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_ClearingDate(valuetype System.DateTime value) {

          loc_406911: nop
          loc_406912: ldarg.0
          loc_406913: ldarg.1
          loc_406914: stfld GCUv2.cChequeIn::_clearingDate
          loc_406919: ret
        }

        public specialname int32 get_BankId() {

          int32 num_1;

        }

        public specialname void set_BankId(int32 value) {

          loc_406935: nop
          loc_406936: ldarg.0
          loc_406937: ldarg.1
          loc_406938: stfld GCUv2.cChequeIn::_bankId
          loc_40693D: ret
        }

        public specialname string get_BankName() {

          string str_1;

        }

        public specialname void set_BankName(string value) {

          loc_406959: nop
          loc_40695A: ldarg.0
          loc_40695B: ldarg.1
          loc_40695C: stfld GCUv2.cChequeIn::_bankName
          loc_406961: ret
        }

        public specialname string get_AccountName() {

          string str_1;

        }

        public specialname void set_AccountName(string value) {

          loc_40697D: nop
          loc_40697E: ldarg.0
          loc_40697F: ldarg.1
          loc_406980: stfld GCUv2.cChequeIn::_accountName
          loc_406985: ret
        }

        public void cChequeIn(double ChequeId, double PaymentId, double MultiPaymentId) {

          string str_1;
          class DataTable var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;

        }

        public static void SaveDepositClearingDate(double ChequeId, boolean Deposit, valuetype System.DateTime DepositDate, boolean Clearing, valuetype System.DateTime ClearingDate) {

          string str_1;
          boolean var_1;
          boolean var_2;

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
          boolean var_8;
          boolean var_9;

        }

    }
}
