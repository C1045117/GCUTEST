using mscorlib;

namespace GCUv2
{
    public class 
    {

        private double _id;
        private valuetype System.DateTime _riDate;
        private string _number;
        private string _note;
        private valuetype System.DateTime _createdDate;
        private int32 _storageId;
        private string _storageName;
        private class GCUv2.cReceivedItemItem[] _item;
        private int32 _supplierId;
        private string _supplierName;
        private double _invoiceId;
        private string _invoiceNumber;
        private class GCUv2.cReceivedItemItem[] _currentItem;
        private int32 _currentStorage;
        private valuetype System.DateTime _currentDate;


        public specialname double get_Id() {

          double flt_1;

        }

        public specialname void set_Id(double value) {

          loc_419FC9: nop
          loc_419FCA: ldarg.0
          loc_419FCB: ldarg.1
          loc_419FCC: stfld GCUv2.cPurchaseInvoice::_id
          loc_419FD1: ret
        }

        public specialname valuetype System.DateTime get_RIDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_RIDate(valuetype System.DateTime value) {

          loc_419FED: nop
          loc_419FEE: ldarg.0
          loc_419FEF: ldarg.1
          loc_419FF0: stfld GCUv2.cReceivedItem::_riDate
          loc_419FF5: ret
        }

        public specialname string get_Number() {

          string str_1;

        }

        public specialname void set_Number(string value) {

          loc_41A011: nop
          loc_41A012: ldarg.0
          loc_41A013: ldarg.1
          loc_41A014: stfld GCUv2.cReceivedItem::_number
          loc_41A019: ret
        }

        public specialname string get_Note() {

          string str_1;

        }

        public specialname void set_Note(string value) {

          loc_41A035: nop
          loc_41A036: ldarg.0
          loc_41A037: ldarg.1
          loc_41A038: call string GCUv2.Module1::cleanString(string)
          loc_41A03D: stfld GCUv2.cReceivedItem::_note
          loc_41A042: ret
        }

        public specialname valuetype System.DateTime get_CreatedDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_CreatedDate(valuetype System.DateTime value) {

          loc_41A05D: nop
          loc_41A05E: ldarg.0
          loc_41A05F: ldarg.1
          loc_41A060: stfld GCUv2.cReceivedItem::_createdDate
          loc_41A065: ret
        }

        public specialname int32 get_StorageId() {

          int32 num_1;

        }

        public specialname void set_StorageId(int32 value) {

          loc_41A081: nop
          loc_41A082: ldarg.0
          loc_41A083: ldarg.1
          loc_41A084: stfld GCUv2.cReceivedItem::_storageId
          loc_41A089: ret
        }

        public specialname string get_StorageName() {

          string str_1;

        }

        public specialname void set_StorageName(string value) {

          loc_41A0A5: nop
          loc_41A0A6: ldarg.0
          loc_41A0A7: ldarg.1
          loc_41A0A8: stfld GCUv2.cReceivedItem::_storageName
          loc_41A0AD: ret
        }

        public specialname class GCUv2.cReceivedItemItem[] get_Item() {

          class GCUv2.cReceivedItemItem[] var_1;

        }

        public specialname void set_Item(class GCUv2.cReceivedItemItem[] value) {

          loc_41A0C9: nop
          loc_41A0CA: ldarg.0
          loc_41A0CB: ldarg.1
          loc_41A0CC: stfld GCUv2.cReceivedItem::_item
          loc_41A0D1: ret
        }

        public specialname int32 get_SupplierId() {

          int32 num_1;

        }

        public specialname void set_SupplierId(int32 value) {

          loc_41A0ED: nop
          loc_41A0EE: ldarg.0
          loc_41A0EF: ldarg.1
          loc_41A0F0: stfld GCUv2.cReceivedItem::_supplierId
          loc_41A0F5: ret
        }

        public specialname string get_SupplierName() {

          string str_1;

        }

        public specialname void set_SupplierName(string value) {

          loc_41A111: nop
          loc_41A112: ldarg.0
          loc_41A113: ldarg.1
          loc_41A114: stfld GCUv2.cReceivedItem::_supplierName
          loc_41A119: ret
        }

        public specialname double get_InvoiceId() {

          double flt_1;

        }

        public specialname void set_InvoiceId(double value) {

          loc_41A135: nop
          loc_41A136: ldarg.0
          loc_41A137: ldarg.1
          loc_41A138: stfld GCUv2.cReceivedItem::_invoiceId
          loc_41A13D: ret
        }

        public specialname string get_InvoiceNumber() {

          string str_1;

        }

        public specialname void set_InvoiceNumber(string value) {

          loc_41A159: nop
          loc_41A15A: ldarg.0
          loc_41A15B: ldarg.1
          loc_41A15C: stfld GCUv2.cReceivedItem::_invoiceNumber
          loc_41A161: ret
        }

        public specialname class GCUv2.cReceivedItemItem[] get_CurrentItem() {

          class GCUv2.cReceivedItemItem[] var_1;

        }

        public specialname void set_CurrentItem(class GCUv2.cReceivedItemItem[] value) {

          loc_41A17D: nop
          loc_41A17E: ldarg.0
          loc_41A17F: ldarg.1
          loc_41A180: stfld GCUv2.cReceivedItem::_currentItem
          loc_41A185: ret
        }

        public specialname int32 get_CurrentStorage() {

          int32 num_1;

        }

        public specialname void set_CurrentStorage(int32 value) {

          loc_41A1A1: nop
          loc_41A1A2: ldarg.0
          loc_41A1A3: ldarg.1
          loc_41A1A4: stfld GCUv2.cReceivedItem::_currentStorage
          loc_41A1A9: ret
        }

        public specialname valuetype System.DateTime get_CurrentDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_CurrentDate(valuetype System.DateTime value) {

          loc_41A1C5: nop
          loc_41A1C6: ldarg.0
          loc_41A1C7: ldarg.1
          loc_41A1C8: stfld GCUv2.cReceivedItem::_currentDate
          loc_41A1CD: ret
        }

        public void cReceivedItem(double RIId) {

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

          int32 num_1;
          int32 num_2;
          string str_1;
          int32 num_3;
          class MySqlClient.MySqlTransaction var_1;
          boolean var_2;
          boolean var_3;
          int32 num_4;
          class GCUv2.cReceivedItemItem[] var_4;
          int32 num_5;
          class GCUv2.cReceivedItemItem var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;

        }

        public static class DataTable Search(int32 intRange, valuetype System.DateTime dateFirst, valuetype System.DateTime dateLast, int32 SupplierId, int32 StorageId, int32 GroupId, int32 BranchId, double InvoiceId, int32 ItemCategoryId, int32 ItemId, int32 Status) {

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
          boolean var_13;
          boolean var_14;
          boolean var_15;
          boolean var_16;

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

        private string GenerateNewNumber() {

          string str_1;
          string str_2;
          class DataTable var_1;
          int32 num_1;
          boolean var_2;

        }

    }
}
