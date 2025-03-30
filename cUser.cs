namespace GCUv2
{
    public class 
    {

        private int32 _id;
        private string _name;
        private string _password;
        private int32 _groupId;
        private string _groupName;
        private int32 _active;


        public specialname int32 get_Id() {

          int32 num_1;

        }

        public specialname void set_Id(int32 value) {

          loc_42A2E1: nop
          loc_42A2E2: ldarg.0
          loc_42A2E3: ldarg.1
          loc_42A2E4: stfld GCUv2.cUsageItem::_id
          loc_42A2E9: ret
        }

        public specialname string get_Name() {

          string str_1;

        }

        public specialname void set_Name(string value) {

          loc_42A305: nop
          loc_42A306: ldarg.0
          loc_42A307: ldarg.1
          loc_42A308: call string GCUv2.Module1::cleanString(string)
          loc_42A30D: stfld GCUv2.cUser::_name
          loc_42A312: ret
        }

        public specialname string get_Password() {

          string str_1;

        }

        public specialname void set_Password(string value) {

          loc_42A32D: nop
          loc_42A32E: ldarg.0
          loc_42A32F: ldarg.1
          loc_42A330: call string GCUv2.Module1::cleanString(string)
          loc_42A335: stfld GCUv2.cUser::_password
          loc_42A33A: ret
        }

        public specialname int32 get_GroupId() {

          int32 num_1;

        }

        public specialname void set_GroupId(int32 value) {

          loc_42A355: nop
          loc_42A356: ldarg.0
          loc_42A357: ldarg.1
          loc_42A358: stfld GCUv2.cUser::_groupId
          loc_42A35D: ret
        }

        public specialname string get_GroupName() {

          string str_1;

        }

        public specialname void set_GroupName(string value) {

          loc_42A379: nop
          loc_42A37A: ldarg.0
          loc_42A37B: ldarg.1
          loc_42A37C: stfld GCUv2.cUser::_groupName
          loc_42A381: ret
        }

        public specialname int32 get_Active() {

          int32 num_1;

        }

        public specialname void set_Active(int32 value) {

          loc_42A39D: nop
          loc_42A39E: ldarg.0
          loc_42A39F: ldarg.1
          loc_42A3A0: stfld GCUv2.cUser::_active
          loc_42A3A5: ret
        }

        public void cUser(int32 UserId) {

          boolean var_1;
          class DataTable var_2;
          string str_1;
          boolean var_3;

        }

        public void Save() {

          string str_1;
          boolean var_1;

        }

        public static void Delete(int32 UserId) {

          string str_1;

        }

        public static class DataTable Search(int32 Active) {

          class DataTable var_1;
          string str_1;
          boolean var_2;
          boolean var_3;

        }

        public static boolean IsExist(string Name) {

          boolean var_1;
          string str_1;
          class DataTable var_2;
          boolean var_3;

        }

        public static class DataTable Login(string UserName, string Password) {

          class DataTable var_1;
          string str_1;

        }

        public static int32 GetUserPermission(string UserName, string Permission) {

          int32 num_1;
          string str_1;
          class DataTable var_1;
          boolean var_2;

        }

    }
}
