namespace GCUv2
{
    public class 
    {

        private int32 _id;
        private string _name;
        private string _symbol;
        private double _rate;
        private int32 _active;
        private int32 _accountPayableId;
        private int32 _accountReceivableId;
        private int32 _advancePurchaseId;
        private int32 _advanceSalesId;
        private int32 _realizeGainLossId;
        private int32 _unrealizeGainLossId;


        public specialname int32 get_Id() {

          int32 num_1;

        }

        public specialname void set_Id(int32 value) {

          loc_409D15: nop
          loc_409D16: ldarg.0
          loc_409D17: ldarg.1
          loc_409D18: stfld GCUv2.cComponent::_id
          loc_409D1D: ret
        }

        public specialname string get_Name() {

          string str_1;

        }

        public specialname void set_Name(string value) {

          loc_409D39: nop
          loc_409D3A: ldarg.0
          loc_409D3B: ldarg.1
          loc_409D3C: call string GCUv2.Module1::cleanString(string)
          loc_409D41: stfld GCUv2.cCurrency::_name
          loc_409D46: ret
        }

        public specialname string get_Symbol() {

          string str_1;

        }

        public specialname void set_Symbol(string value) {

          loc_409D61: nop
          loc_409D62: ldarg.0
          loc_409D63: ldarg.1
          loc_409D64: call string GCUv2.Module1::cleanString(string)
          loc_409D69: stfld GCUv2.cCurrency::_symbol
          loc_409D6E: ret
        }

        public specialname double get_Rate() {

          double flt_1;

        }

        public specialname void set_Rate(double value) {

          loc_409D89: nop
          loc_409D8A: ldarg.0
          loc_409D8B: ldarg.1
          loc_409D8C: stfld GCUv2.cCurrency::_rate
          loc_409D91: ret
        }

        public specialname int32 get_Active() {

          int32 num_1;

        }

        public specialname void set_Active(int32 value) {

          loc_409DAD: nop
          loc_409DAE: ldarg.0
          loc_409DAF: ldarg.1
          loc_409DB0: stfld GCUv2.cCurrency::_active
          loc_409DB5: ret
        }

        public specialname int32 get_AccountPayableId() {

          int32 num_1;

        }

        public specialname void set_AccountPayableId(int32 value) {

          loc_409DD1: nop
          loc_409DD2: ldarg.0
          loc_409DD3: ldarg.1
          loc_409DD4: stfld GCUv2.cCurrency::_accountPayableId
          loc_409DD9: ret
        }

        public specialname int32 get_AccountReceivableId() {

          int32 num_1;

        }

        public specialname void set_AccountReceivableId(int32 value) {

          loc_409DF5: nop
          loc_409DF6: ldarg.0
          loc_409DF7: ldarg.1
          loc_409DF8: stfld GCUv2.cCurrency::_accountReceivableId
          loc_409DFD: ret
        }

        public specialname int32 get_AdvancePurchaseId() {

          int32 num_1;

        }

        public specialname void set_AdvancePurchaseId(int32 value) {

          loc_409E19: nop
          loc_409E1A: ldarg.0
          loc_409E1B: ldarg.1
          loc_409E1C: stfld GCUv2.cCurrency::_advancePurchaseId
          loc_409E21: ret
        }

        public specialname int32 get_AdvanceSalesId() {

          int32 num_1;

        }

        public specialname void set_AdvanceSalesId(int32 value) {

          loc_409E3D: nop
          loc_409E3E: ldarg.0
          loc_409E3F: ldarg.1
          loc_409E40: stfld GCUv2.cCurrency::_advanceSalesId
          loc_409E45: ret
        }

        public specialname int32 get_RealizeGainLossId() {

          int32 num_1;

        }

        public specialname void set_RealizeGainLossId(int32 value) {

          loc_409E61: nop
          loc_409E62: ldarg.0
          loc_409E63: ldarg.1
          loc_409E64: stfld GCUv2.cCurrency::_realizeGainLossId
          loc_409E69: ret
        }

        public specialname int32 get_UnrealizeGainLossId() {

          int32 num_1;

        }

        public specialname void set_UnrealizeGainLossId(int32 value) {

          loc_409E85: nop
          loc_409E86: ldarg.0
          loc_409E87: ldarg.1
          loc_409E88: stfld GCUv2.cCurrency::_unrealizeGainLossId
          loc_409E8D: ret
        }

        public void cCurrency(int32 Id) {

          boolean var_1;
          class DataTable var_2;
          string str_1;
          boolean var_3;

        }

        public void Save() {

          string str_1;
          boolean var_1;

        }

        private void CreateDefaultAccount() {

          class GCUv2.cAccount var_1;

        }

        public static class DataTable Search(int32 Active) {

          class DataTable var_1;
          string str_1;
          boolean var_2;
          boolean var_3;

        }

        public static boolean IsExist(int32 Id, string Name, string Symbol) {

          boolean var_1;
          string str_1;
          class DataTable var_2;
          boolean var_3;
          boolean var_4;

        }

        public static class DataTable GetCurrencyOfAccount(int32 AccountId) {

          class DataTable var_1;
          string str_1;

        }

        public static int32 GetAccountPayableId(int32 CurrencyId) {

          int32 num_1;
          string str_1;
          class DataTable var_1;

        }

    }
}
