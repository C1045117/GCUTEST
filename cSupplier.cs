namespace GCUv2
{
    public class 
    {

        private int32 _id;
        private string _name;
        private string _address;
        private string _NPWP;
        private int32 _cashAccountId;
        private int32 _bankAccountId;
        private int32 _active;
        private int32 _parentId;
        private int32 _isParent;
        private int32 _currencyId;
        private string _currencyName;
        private double _currencyRate;
        private string[] _memberName;


        public specialname int32 get_Id() {

          int32 num_1;

        }

        public specialname void set_Id(int32 value) {

          loc_428279: nop
          loc_42827A: ldarg.0
          loc_42827B: ldarg.1
          loc_42827C: stfld GCUv2.cStorage::_id
          loc_428281: ret
        }

        public specialname string get_Name() {

          string str_1;

        }

        public specialname void set_Name(string value) {

          loc_42829D: nop
          loc_42829E: ldarg.0
          loc_42829F: ldarg.1
          loc_4282A0: call string GCUv2.Module1::cleanString(string)
          loc_4282A5: stfld GCUv2.cSupplier::_name
          loc_4282AA: ret
        }

        public specialname string get_NPWP() {

          string str_1;

        }

        public specialname void set_NPWP(string value) {

          loc_4282C5: nop
          loc_4282C6: ldarg.0
          loc_4282C7: ldarg.1
          loc_4282C8: call string GCUv2.Module1::cleanString(string)
          loc_4282CD: stfld GCUv2.cSupplier::_NPWP
          loc_4282D2: ret
        }

        public specialname string get_Address() {

          string str_1;

        }

        public specialname void set_Address(string value) {

          loc_4282ED: nop
          loc_4282EE: ldarg.0
          loc_4282EF: ldarg.1
          loc_4282F0: call string GCUv2.Module1::cleanString(string)
          loc_4282F5: stfld GCUv2.cSupplier::_address
          loc_4282FA: ret
        }

        public specialname int32 get_CashAccountId() {

          int32 num_1;

        }

        public specialname void set_CashAccountId(int32 value) {

          loc_428315: nop
          loc_428316: ldarg.0
          loc_428317: ldarg.1
          loc_428318: stfld GCUv2.cSupplier::_cashAccountId
          loc_42831D: ret
        }

        public specialname int32 get_BankAccountId() {

          int32 num_1;

        }

        public specialname void set_BankAccountId(int32 value) {

          loc_428339: nop
          loc_42833A: ldarg.0
          loc_42833B: ldarg.1
          loc_42833C: stfld GCUv2.cSupplier::_bankAccountId
          loc_428341: ret
        }

        public specialname int32 get_Active() {

          int32 num_1;

        }

        public specialname void set_Active(int32 value) {

          loc_42835D: nop
          loc_42835E: ldarg.0
          loc_42835F: ldarg.1
          loc_428360: stfld GCUv2.cSupplier::_active
          loc_428365: ret
        }

        public specialname int32 get_ParentId() {

          int32 num_1;

        }

        public specialname void set_ParentId(int32 value) {

          loc_428381: nop
          loc_428382: ldarg.0
          loc_428383: ldarg.1
          loc_428384: stfld GCUv2.cSupplier::_parentId
          loc_428389: ret
        }

        public specialname int32 get_IsParent() {

          int32 num_1;

        }

        public specialname void set_IsParent(int32 value) {

          loc_4283A5: nop
          loc_4283A6: ldarg.0
          loc_4283A7: ldarg.1
          loc_4283A8: stfld GCUv2.cSupplier::_isParent
          loc_4283AD: ret
        }

        public specialname int32 get_CurrencyId() {

          int32 num_1;

        }

        public specialname void set_CurrencyId(int32 value) {

          loc_4283C9: nop
          loc_4283CA: ldarg.0
          loc_4283CB: ldarg.1
          loc_4283CC: stfld GCUv2.cSupplier::_currencyId
          loc_4283D1: ret
        }

        public specialname string get_CurrencyName() {

          string str_1;

        }

        public specialname void set_CurrencyName(string value) {

          loc_4283ED: nop
          loc_4283EE: ldarg.0
          loc_4283EF: ldarg.1
          loc_4283F0: stfld GCUv2.cSupplier::_currencyName
          loc_4283F5: ret
        }

        public specialname double get_CurrencyRate() {

          double flt_1;

        }

        public specialname void set_CurrencyRate(double value) {

          loc_428411: nop
          loc_428412: ldarg.0
          loc_428413: ldarg.1
          loc_428414: stfld GCUv2.cSupplier::_currencyRate
          loc_428419: ret
        }

        public specialname string[] get_MemberName() {

          string[] var_1;

        }

        public specialname void set_MemberName(string[] value) {

          loc_428435: nop
          loc_428436: ldarg.0
          loc_428437: ldarg.1
          loc_428438: stfld GCUv2.cSupplier::_memberName
          loc_42843D: ret
        }

        public override strict string ToString() {

          string str_1;

        }

        public void cSupplier(int32 SupplierId) {

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

        public void save() {

          string str_1;
          boolean var_1;
          boolean var_2;

        }

        public static class DataTable Search(string Name, int32 GroupId, int32 IsParent) {

          class DataTable var_1;
          string str_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;

        }

        public static class DataTable dtSupplier(int32 GroupId, boolean FlowerOnly, boolean IncludeParent, boolean Active) {

          class DataTable var_1;
          string str_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;

        }

        public static class DataTable GetParentSupplier(int32 GroupId) {

          class DataTable var_1;
          string str_1;

        }

    }
}
