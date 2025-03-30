namespace GCUv2
{
    public class 
    {

        private int32 _id;
        private string _description;
        private int32 _permissionValue;


        public void cGroupPermission() {

          loc_403253: ldarg.0
          loc_403254: call instance void System.Object::.ctor()
          loc_403259: ret
        }

        public specialname int32 get_Id() {

          int32 num_1;

        }

        public specialname void set_Id(int32 value) {

          loc_40F7F5: nop
          loc_40F7F6: ldarg.0
          loc_40F7F7: ldarg.1
          loc_40F7F8: stfld GCUv2.cGroupCashAccount::_id
          loc_40F7FD: ret
        }

        public specialname string get_Description() {

          string str_1;

        }

        public specialname void set_Description(string value) {

          loc_40F819: nop
          loc_40F81A: ldarg.0
          loc_40F81B: ldarg.1
          loc_40F81C: stfld GCUv2.cGroupPermission::_description
          loc_40F821: ret
        }

        public specialname int32 get_PermissionValue() {

          int32 num_1;

        }

        public specialname void set_PermissionValue(int32 value) {

          loc_40F83D: nop
          loc_40F83E: ldarg.0
          loc_40F83F: ldarg.1
          loc_40F840: stfld GCUv2.cGroupPermission::_permissionValue
          loc_40F845: ret
        }

        public static int32 getPermissionValue(int32 GroupId, string PermissionName) {

          int32 num_1;
          string str_1;
          class DataTable var_1;
          boolean var_2;

        }

        public static boolean IsAllowed(int32 GroupId, string PermissionName) {

          boolean var_1;
          string str_1;
          class DataTable var_2;
          boolean var_3;

        }

    }
}
