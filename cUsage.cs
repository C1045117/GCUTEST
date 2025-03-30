using mscorlib;

namespace GCUv2
{
    public class 
    {

        private double _id;
        private valuetype System.DateTime _usageDate;
        private string _usageNumber;
        private string _note;
        private valuetype System.DateTime _createdDate;
        private int32 _storageId;
        private string _storageName;
        private class GCUv2.cUsageItem[] _item;
        private class GCUv2.cUsageItem[] _currentItem;
        private int32 _currentStorage;
        private valuetype System.DateTime _currentDate;


        public specialname double get_Id() {

          double flt_1;

        }

        public specialname void set_Id(double value) {

          loc_429359: nop
          loc_42935A: ldarg.0
          loc_42935B: ldarg.1
          loc_42935C: stfld GCUv2.cTransferItem::_id
          loc_429361: ret
        }

        public specialname valuetype System.DateTime get_UsageDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_UsageDate(valuetype System.DateTime value) {

          loc_42937D: nop
          loc_42937E: ldarg.0
          loc_42937F: ldarg.1
          loc_429380: stfld GCUv2.cUsage::_usageDate
          loc_429385: ret
        }

        public specialname string get_UsageNumber() {

          string str_1;

        }

        public specialname void set_UsageNumber(string value) {

          loc_4293A1: nop
          loc_4293A2: ldarg.0
          loc_4293A3: ldarg.1
          loc_4293A4: stfld GCUv2.cUsage::_usageNumber
          loc_4293A9: ret
        }

        public specialname string get_Note() {

          string str_1;

        }

        public specialname void set_Note(string value) {

          loc_4293C5: nop
          loc_4293C6: ldarg.0
          loc_4293C7: ldarg.1
          loc_4293C8: call string GCUv2.Module1::cleanString(string)
          loc_4293CD: stfld GCUv2.cUsage::_note
          loc_4293D2: ret
        }

        public specialname valuetype System.DateTime get_CreatedDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_CreatedDate(valuetype System.DateTime value) {

          loc_4293ED: nop
          loc_4293EE: ldarg.0
          loc_4293EF: ldarg.1
          loc_4293F0: stfld GCUv2.cUsage::_createdDate
          loc_4293F5: ret
        }

        public specialname int32 get_StorageId() {

          int32 num_1;

        }

        public specialname void set_StorageId(int32 value) {

          loc_429411: nop
          loc_429412: ldarg.0
          loc_429413: ldarg.1
          loc_429414: stfld GCUv2.cUsage::_storageId
          loc_429419: ret
        }

        public specialname string get_StorageName() {

          string str_1;

        }

        public specialname void set_StorageName(string value) {

          loc_429435: nop
          loc_429436: ldarg.0
          loc_429437: ldarg.1
          loc_429438: stfld GCUv2.cUsage::_storageName
          loc_42943D: ret
        }

        public specialname class GCUv2.cUsageItem[] get_Item() {

          class GCUv2.cUsageItem[] var_1;

        }

        public specialname void set_Item(class GCUv2.cUsageItem[] value) {

          loc_429459: nop
          loc_42945A: ldarg.0
          loc_42945B: ldarg.1
          loc_42945C: stfld GCUv2.cUsage::_item
          loc_429461: ret
        }

        public specialname class GCUv2.cUsageItem[] get_CurrentItem() {

          class GCUv2.cUsageItem[] var_1;

        }

        public specialname void set_CurrentItem(class GCUv2.cUsageItem[] value) {

          loc_42947D: nop
          loc_42947E: ldarg.0
          loc_42947F: ldarg.1
          loc_429480: stfld GCUv2.cUsage::_currentItem
          loc_429485: ret
        }

        public specialname valuetype System.DateTime get_CurrentDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_CurrentDate(valuetype System.DateTime value) {

          loc_4294A1: nop
          loc_4294A2: ldarg.0
          loc_4294A3: ldarg.1
          loc_4294A4: stfld GCUv2.cUsage::_currentDate
          loc_4294A9: ret
        }

        public specialname int32 get_CurrentStorage() {

          int32 num_1;

        }

        public specialname void set_CurrentStorage(int32 value) {

          loc_4294C5: nop
          loc_4294C6: ldarg.0
          loc_4294C7: ldarg.1
          loc_4294C8: stfld GCUv2.cUsage::_currentStorage
          loc_4294CD: ret
        }

        public void cUsage(double UsageId) {

          boolean var_1;
          class DataTable var_2;
          string str_1;
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
          boolean var_3;
          int32 num_3;
          int32 num_4;
          boolean var_4;
          class GCUv2.cUsageItem[] var_5;
          int32 num_5;
          class GCUv2.cUsageItem var_6;
          boolean var_7;
          boolean var_8;
          boolean var_9;

        }

        private string GenerateNewNumber() {

          string str_1;
          string str_2;
          class DataTable var_1;
          int32 num_1;
          boolean var_2;

        }

        public static class DataTable Search(int32 intRange, valuetype System.DateTime dateFirst, valuetype System.DateTime dateLast, int32 StorageId, int32 GroupId, int32 BranchId) {

          class DataTable var_1;
          string str_1;
          string str_2;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;

        }

        public void Delete() {

          int32 num_1;
          int32 num_2;
          string str_1;
          int32 num_3;
          class MySqlClient.MySqlTransaction var_1;
          boolean var_2;
          int32 num_4;
          boolean var_3;
          boolean var_4;

        }

        public static class DataTable SearchStandard(valuetype System.DateTime dateFirst, valuetype System.DateTime dateLast, int32 StorageId, int32 GroupId, int32 BranchId) {

          class DataTable var_1;
          string str_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;

        }

        public static class DataTable SearchVariance(valuetype System.DateTime dateFirst, valuetype System.DateTime dateLast, int32 StorageId, int32 GroupId, int32 BranchId) {

          class DataTable var_1;
          string str_1;
          boolean var_2;
          boolean var_3;

        }

    }
}
