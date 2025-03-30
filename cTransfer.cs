using mscorlib;

namespace GCUv2
{
    public class 
    {

        private double _id;
        private string _transferNumber;
        private int32 _storageFromId;
        private string _storageFromName;
        private int32 _storageToId;
        private string _storageToName;
        private class GCUv2.cTransferItem[] _item;
        private valuetype System.DateTime _transferDate;
        private valuetype System.DateTime _createdDate;
        private int32 _currentStorageFrom;
        private int32 _currentStorageTo;
        private valuetype System.DateTime _currentDate;
        private class GCUv2.cTransferItem[] _currentItem;


        public specialname double get_Id() {

          double flt_1;

        }

        public specialname void set_Id(double value) {

          loc_54D931: nop
          loc_54D932: ldarg.0
          loc_54D933: ldarg.1
          loc_54D934: stfld GCUv2.MsWord::_id
          loc_54D939: ret
        }

        public specialname string get_TransferNumber() {

          string str_1;

        }

        public specialname void set_TransferNumber(string value) {

          loc_54D955: nop
          loc_54D956: ldarg.0
          loc_54D957: ldarg.1
          loc_54D958: stfld GCUv2.cTransfer::_transferNumber
          loc_54D95D: ret
        }

        public specialname int32 get_StorageFromId() {

          int32 num_1;

        }

        public specialname void set_StorageFromId(int32 value) {

          loc_54D979: nop
          loc_54D97A: ldarg.0
          loc_54D97B: ldarg.1
          loc_54D97C: stfld GCUv2.cTransfer::_storageFromId
          loc_54D981: ret
        }

        public specialname string get_StorageFromName() {

          string str_1;

        }

        public specialname void set_StorageFromName(string value) {

          loc_54D99D: nop
          loc_54D99E: ldarg.0
          loc_54D99F: ldarg.1
          loc_54D9A0: stfld GCUv2.cTransfer::_storageFromName
          loc_54D9A5: ret
        }

        public specialname int32 get_StorageToId() {

          int32 num_1;

        }

        public specialname void set_StorageToId(int32 value) {

          loc_54D9C1: nop
          loc_54D9C2: ldarg.0
          loc_54D9C3: ldarg.1
          loc_54D9C4: stfld GCUv2.cTransfer::_storageToId
          loc_54D9C9: ret
        }

        public specialname string get_StorageToName() {

          string str_1;

        }

        public specialname void set_StorageToName(string value) {

          loc_54D9E5: nop
          loc_54D9E6: ldarg.0
          loc_54D9E7: ldarg.1
          loc_54D9E8: stfld GCUv2.cTransfer::_storageToName
          loc_54D9ED: ret
        }

        public specialname valuetype System.DateTime get_TransferDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_TransferDate(valuetype System.DateTime value) {

          loc_54DA09: nop
          loc_54DA0A: ldarg.0
          loc_54DA0B: ldarg.1
          loc_54DA0C: stfld GCUv2.cTransfer::_transferDate
          loc_54DA11: ret
        }

        public specialname class GCUv2.cTransferItem[] get_Item() {

          class GCUv2.cTransferItem[] var_1;

        }

        public specialname void set_Item(class GCUv2.cTransferItem[] value) {

          loc_54DA2D: nop
          loc_54DA2E: ldarg.0
          loc_54DA2F: ldarg.1
          loc_54DA30: stfld GCUv2.cTransfer::_item
          loc_54DA35: ret
        }

        public specialname valuetype System.DateTime get_CreatedDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_CreatedDate(valuetype System.DateTime value) {

          loc_54DA51: nop
          loc_54DA52: ldarg.0
          loc_54DA53: ldarg.1
          loc_54DA54: stfld GCUv2.cTransfer::_createdDate
          loc_54DA59: ret
        }

        public specialname class GCUv2.cTransferItem[] get_CurrentItem() {

          class GCUv2.cTransferItem[] var_1;

        }

        public specialname void set_CurrentItem(class GCUv2.cTransferItem[] value) {

          loc_54DA75: nop
          loc_54DA76: ldarg.0
          loc_54DA77: ldarg.1
          loc_54DA78: stfld GCUv2.cTransfer::_currentItem
          loc_54DA7D: ret
        }

        public specialname int32 get_CurrentStorageFrom() {

          int32 num_1;

        }

        public specialname void set_CurrentStorageFrom(int32 value) {

          loc_54DA99: nop
          loc_54DA9A: ldarg.0
          loc_54DA9B: ldarg.1
          loc_54DA9C: stfld GCUv2.cTransfer::_currentStorageFrom
          loc_54DAA1: ret
        }

        public specialname int32 get_CurrentStorageTo() {

          int32 num_1;

        }

        public specialname void set_CurrentStorageTo(int32 value) {

          loc_54DABD: nop
          loc_54DABE: ldarg.0
          loc_54DABF: ldarg.1
          loc_54DAC0: stfld GCUv2.cTransfer::_currentStorageTo
          loc_54DAC5: ret
        }

        public specialname valuetype System.DateTime get_CurrentDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_CurrentDate(valuetype System.DateTime value) {

          loc_54DAE1: nop
          loc_54DAE2: ldarg.0
          loc_54DAE3: ldarg.1
          loc_54DAE4: stfld GCUv2.cTransfer::_currentDate
          loc_54DAE9: ret
        }

        public void cTransfer(double TransferId) {

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
          boolean var_3;
          int32 num_3;
          int32 num_4;
          class GCUv2.cTransferItem[] var_4;
          int32 num_5;
          class GCUv2.cTransferItem var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;

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

        }

        public static class DataTable Search(int32 intRange, int32 intMonth, int32 intYear, valuetype System.DateTime dateFirst, valuetype System.DateTime dateLast, int32 intItemId, int32 ItemCategoryId, int32 intStoreFromId, int32 intStoreToId, int32 intGroupId, int32 intBranchId, int32 intStepId) {

          class DataTable var_1;
          string str_1;
          string str_2;
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
          boolean var_12;

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
