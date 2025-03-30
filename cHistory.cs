using mscorlib;

namespace GCUv2
{
    public class 
    {

        private double _id;
        private valuetype System.DateTime _createdDate;
        private string _content;
        private string _description;
        private int32 _historyType;
        private int32 _userId;
        private string _userLogin;
        private double _fKeyId;


        public void cHistory() {

          loc_403253: ldarg.0
          loc_403254: call instance void System.Object::.ctor()
          loc_403259: ret
        }

        public specialname double get_Id() {

          double flt_1;

        }

        public specialname void set_Id(double value) {

          loc_40F9DD: nop
          loc_40F9DE: ldarg.0
          loc_40F9DF: ldarg.1
          loc_40F9E0: stfld GCUv2.cGroupStorage::_id
          loc_40F9E5: ret
        }

        public specialname valuetype System.DateTime get_CreatedDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_CreatedDate(valuetype System.DateTime value) {

          loc_40FA01: nop
          loc_40FA02: ldarg.0
          loc_40FA03: ldarg.1
          loc_40FA04: stfld GCUv2.cHistory::_createdDate
          loc_40FA09: ret
        }

        public specialname string get_Content() {

          string str_1;

        }

        public specialname void set_Content(string value) {

          loc_40FA25: nop
          loc_40FA26: ldarg.0
          loc_40FA27: ldarg.1
          loc_40FA28: call string GCUv2.Module1::cleanString(string)
          loc_40FA2D: stfld GCUv2.cHistory::_content
          loc_40FA32: ret
        }

        public specialname string get_Description() {

          string str_1;

        }

        public specialname void set_Description(string value) {

          loc_40FA4D: nop
          loc_40FA4E: ldarg.0
          loc_40FA4F: ldarg.1
          loc_40FA50: call string GCUv2.Module1::cleanString(string)
          loc_40FA55: stfld GCUv2.cHistory::_description
          loc_40FA5A: ret
        }

        public specialname int32 get_HistoryType() {

          int32 num_1;

        }

        public specialname void set_HistoryType(int32 value) {

          loc_40FA75: nop
          loc_40FA76: ldarg.0
          loc_40FA77: ldarg.1
          loc_40FA78: stfld GCUv2.cHistory::_historyType
          loc_40FA7D: ret
        }

        public specialname int32 get_UserId() {

          int32 num_1;

        }

        public specialname void set_UserId(int32 value) {

          loc_40FA99: nop
          loc_40FA9A: ldarg.0
          loc_40FA9B: ldarg.1
          loc_40FA9C: stfld GCUv2.cHistory::_userId
          loc_40FAA1: ret
        }

        public specialname string get_UserLogin() {

          string str_1;

        }

        public specialname void set_UserLogin(string value) {

          loc_40FABD: nop
          loc_40FABE: ldarg.0
          loc_40FABF: ldarg.1
          loc_40FAC0: stfld GCUv2.cHistory::_userLogin
          loc_40FAC5: ret
        }

        public specialname double get_fKeyId() {

          double flt_1;

        }

        public specialname void set_fKeyId(double value) {

          loc_40FAE1: nop
          loc_40FAE2: ldarg.0
          loc_40FAE3: ldarg.1
          loc_40FAE4: stfld GCUv2.cHistory::_fKeyId
          loc_40FAE9: ret
        }

        public static class DataTable GetHistory(int32 intFkeyId, int32 HistoryType) {

          class DataTable var_1;
          string str_1;

        }

        public void Save() {

          string str_1;

        }

        public static class DataTable Search(valuetype System.DateTime dateFirst, valuetype System.DateTime dateLast, string UserLogin, int32 HistoryTypeId) {

          class DataTable var_1;
          string str_1;
          boolean var_2;
          boolean var_3;

        }

        public static class DataTable GetHistoryType() {

          class DataTable var_1;
          string str_1;

        }

    }
}
