namespace GCUv2
{
    public class 
    {

        private int32 _id;
        private int32[] _catId;
        private int32[] _pageId;
        private int32[] _permissionType1;
        private int32[] _supplierId;
        private string[] _userName;
        private class GCUv2.cGroupPermission[] _permission;
        private class GCUv2.cGroupCashAccount[] _groupCashAccount;
        private class GCUv2.cGroupBankAccount[] _groupBankAccount;
        private class GCUv2.cGroupStorage[] _groupStorage;
        private class GCUv2.cGroupBranch[] _groupBranch;


        public specialname object get_Id() {

          object var_1;

        }

        public specialname void set_Id(object value) {

          loc_40DCB2: nop
          loc_40DCB3: ldarg.0
          loc_40DCB4: ldarg.1
          loc_40DCB5: call int32 Microsoft.VisualBasic.CompilerServices.Conversions::ToInteger(object)
          loc_40DCBA: stfld GCUv2.cDiscount::_id
          loc_40DCBF: ret
        }

        public specialname int32[] get_CatId() {

          int32[] var_1;

        }

        public specialname void set_CatId(int32[] value) {

          loc_40DCD9: nop
          loc_40DCDA: ldarg.0
          loc_40DCDB: ldarg.1
          loc_40DCDC: stfld GCUv2.cGroup::_catId
          loc_40DCE1: ret
        }

        public specialname int32[] get_PageId() {

          int32[] var_1;

        }

        public specialname void set_PageId(int32[] value) {

          loc_40DCFD: nop
          loc_40DCFE: ldarg.0
          loc_40DCFF: ldarg.1
          loc_40DD00: stfld GCUv2.cGroup::_pageId
          loc_40DD05: ret
        }

        public specialname int32[] get_PermissionType1() {

          int32[] var_1;

        }

        public specialname void set_PermissionType1(int32[] value) {

          loc_40DD21: nop
          loc_40DD22: ldarg.0
          loc_40DD23: ldarg.1
          loc_40DD24: stfld GCUv2.cGroup::_permissionType1
          loc_40DD29: ret
        }

        public specialname int32[] get_SupplierId() {

          int32[] var_1;

        }

        public specialname void set_SupplierId(int32[] value) {

          loc_40DD45: nop
          loc_40DD46: ldarg.0
          loc_40DD47: ldarg.1
          loc_40DD48: stfld GCUv2.cGroup::_supplierId
          loc_40DD4D: ret
        }

        public specialname string[] get_UserName() {

          string[] var_1;

        }

        public specialname void set_UserName(string[] value) {

          loc_40DD69: nop
          loc_40DD6A: ldarg.0
          loc_40DD6B: ldarg.1
          loc_40DD6C: stfld GCUv2.cGroup::_userName
          loc_40DD71: ret
        }

        public specialname class GCUv2.cGroupPermission[] get_Permission() {

          class GCUv2.cGroupPermission[] var_1;

        }

        public specialname void set_Permission(class GCUv2.cGroupPermission[] value) {

          loc_40DD8D: nop
          loc_40DD8E: ldarg.0
          loc_40DD8F: ldarg.1
          loc_40DD90: stfld GCUv2.cGroup::_permission
          loc_40DD95: ret
        }

        public specialname class GCUv2.cGroupCashAccount[] get_GroupCashAccount() {

          class GCUv2.cGroupCashAccount[] var_1;

        }

        public specialname void set_GroupCashAccount(class GCUv2.cGroupCashAccount[] value) {

          loc_40DDB1: nop
          loc_40DDB2: ldarg.0
          loc_40DDB3: ldarg.1
          loc_40DDB4: stfld GCUv2.cGroup::_groupCashAccount
          loc_40DDB9: ret
        }

        public specialname class GCUv2.cGroupBankAccount[] get_GroupBankAccount() {

          class GCUv2.cGroupBankAccount[] var_1;

        }

        public specialname void set_GroupBankAccount(class GCUv2.cGroupBankAccount[] value) {

          loc_40DDD5: nop
          loc_40DDD6: ldarg.0
          loc_40DDD7: ldarg.1
          loc_40DDD8: stfld GCUv2.cGroup::_groupBankAccount
          loc_40DDDD: ret
        }

        public specialname class GCUv2.cGroupStorage[] get_GroupStorage() {

          class GCUv2.cGroupStorage[] var_1;

        }

        public specialname void set_GroupStorage(class GCUv2.cGroupStorage[] value) {

          loc_40DDF9: nop
          loc_40DDFA: ldarg.0
          loc_40DDFB: ldarg.1
          loc_40DDFC: stfld GCUv2.cGroup::_groupStorage
          loc_40DE01: ret
        }

        public specialname class GCUv2.cGroupBranch[] get_GroupBranch() {

          class GCUv2.cGroupBranch[] var_1;

        }

        public specialname void set_GroupBranch(class GCUv2.cGroupBranch[] value) {

          loc_40DE1D: nop
          loc_40DE1E: ldarg.0
          loc_40DE1F: ldarg.1
          loc_40DE20: stfld GCUv2.cGroup::_groupBranch
          loc_40DE25: ret
        }

        public void cGroup(int32 GroupId) {

          boolean var_1;
          string str_1;
          int32 num_1;
          class DataTable var_2;
          boolean var_3;
          class System.Collections.IEnumerator var_4;
          class DataRow var_5;
          boolean var_6;
          boolean var_7;
          class System.Collections.IEnumerator var_8;
          class DataRow var_9;
          boolean var_10;
          class System.Collections.IEnumerator var_11;
          class DataRow var_12;
          boolean var_13;
          boolean var_14;
          class System.Collections.IEnumerator var_15;
          class DataRow var_16;
          boolean var_17;
          boolean var_18;
          class System.Collections.IEnumerator var_19;
          class DataRow var_20;
          boolean var_21;
          boolean var_22;
          class System.Collections.IEnumerator var_23;
          class DataRow var_24;
          boolean var_25;
          class System.Collections.IEnumerator var_26;
          class DataRow var_27;
          boolean var_28;
          class System.Collections.IEnumerator var_29;
          class DataRow var_30;
          boolean var_31;
          class System.Collections.IEnumerator var_32;
          class DataRow var_33;
          boolean var_34;
          class System.Collections.IEnumerator var_35;
          class DataRow var_36;
          boolean var_37;

        }

        public static class DataTable dtGroup() {

          class DataTable var_1;
          string str_1;

        }

        public void Save() {

          int32 num_1;
          int32 num_2;
          string str_1;
          class MySqlClient.MySqlTransaction var_1;
          int32 num_3;
          int32 num_4;
          int32 num_5;
          int32 num_6;
          int32 num_7;
          class GCUv2.cGroupPermission[] var_2;
          int32 num_8;
          class GCUv2.cGroupPermission var_3;
          boolean var_4;
          class GCUv2.cGroupCashAccount[] var_5;
          int32 num_9;
          class GCUv2.cGroupCashAccount var_6;
          boolean var_7;
          class GCUv2.cGroupBankAccount[] var_8;
          int32 num_10;
          class GCUv2.cGroupBankAccount var_9;
          boolean var_10;
          class GCUv2.cGroupStorage[] var_11;
          int32 num_11;
          class GCUv2.cGroupStorage var_12;
          boolean var_13;
          class GCUv2.cGroupBranch[] var_14;
          int32 num_12;
          class GCUv2.cGroupBranch var_15;
          boolean var_16;
          boolean var_17;

        }

        public static void SaveGroupName(int32 GroupId, string GroupName) {

          string str_1;
          boolean var_1;

        }

        public static boolean NameIsUsed(int32 GroupId, string GroupName) {

          boolean var_1;
          string str_1;
          class DataTable var_2;
          boolean var_3;
          boolean var_4;

        }

        public static void Delete(int32 GroupId) {

          string str_1;

        }

        public static boolean ShowCashBalance(int32 GroupId, int32 AccountId) {

          boolean var_1;
          string str_1;
          class DataTable var_2;

        }

        public static boolean ShowBankBalance(int32 GroupId, int32 AccountId) {

          boolean var_1;
          string str_1;
          class DataTable var_2;

        }

        public static boolean HasUser(int32 GroupId) {

          boolean var_1;
          string str_1;
          class DataTable var_2;
          boolean var_3;

        }

    }
}
