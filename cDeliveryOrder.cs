using mscorlib;

namespace GCUv2
{
    public class 
    {

        private double _id;
        private valuetype System.DateTime _doDate;
        private string _number;
        private string _note;
        private valuetype System.DateTime _createdDate;
        private int32 _storageId;
        private string _storageName;
        private class GCUv2.cDeliveryOrderItem[] _item;
        private double _customerId;
        private string _customerName;
        private string _customerAddress;
        private double _invoiceId;
        private string _invoiceNumber;
        private class GCUv2.cDeliveryOrderItem[] _currentItem;
        private int32 _currentStorage;
        private valuetype System.DateTime _currentDate;


        public specialname double get_Id() {

          double flt_1;

        }

        public specialname void set_Id(double value) {

          loc_40C409: nop
          loc_40C40A: ldarg.0
          loc_40C40B: ldarg.1
          loc_40C40C: stfld GCUv2.cCustomerCode::_id
          loc_40C411: ret
        }

        public specialname valuetype System.DateTime get_DODate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_DODate(valuetype System.DateTime value) {

          loc_40C42D: nop
          loc_40C42E: ldarg.0
          loc_40C42F: ldarg.1
          loc_40C430: stfld GCUv2.cDeliveryOrder::_doDate
          loc_40C435: ret
        }

        public specialname string get_Number() {

          string str_1;

        }

        public specialname void set_Number(string value) {

          loc_40C451: nop
          loc_40C452: ldarg.0
          loc_40C453: ldarg.1
          loc_40C454: stfld GCUv2.cDeliveryOrder::_number
          loc_40C459: ret
        }

        public specialname string get_Note() {

          string str_1;

        }

        public specialname void set_Note(string value) {

          loc_40C475: nop
          loc_40C476: ldarg.0
          loc_40C477: ldarg.1
          loc_40C478: call string GCUv2.Module1::cleanString(string)
          loc_40C47D: stfld GCUv2.cDeliveryOrder::_note
          loc_40C482: ret
        }

        public specialname valuetype System.DateTime get_CreatedDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_CreatedDate(valuetype System.DateTime value) {

          loc_40C49D: nop
          loc_40C49E: ldarg.0
          loc_40C49F: ldarg.1
          loc_40C4A0: stfld GCUv2.cDeliveryOrder::_createdDate
          loc_40C4A5: ret
        }

        public specialname int32 get_StorageId() {

          int32 num_1;

        }

        public specialname void set_StorageId(int32 value) {

          loc_40C4C1: nop
          loc_40C4C2: ldarg.0
          loc_40C4C3: ldarg.1
          loc_40C4C4: stfld GCUv2.cDeliveryOrder::_storageId
          loc_40C4C9: ret
        }

        public specialname string get_StorageName() {

          string str_1;

        }

        public specialname void set_StorageName(string value) {

          loc_40C4E5: nop
          loc_40C4E6: ldarg.0
          loc_40C4E7: ldarg.1
          loc_40C4E8: stfld GCUv2.cDeliveryOrder::_storageName
          loc_40C4ED: ret
        }

        public specialname class GCUv2.cDeliveryOrderItem[] get_Item() {

          class GCUv2.cDeliveryOrderItem[] var_1;

        }

        public specialname void set_Item(class GCUv2.cDeliveryOrderItem[] value) {

          loc_40C509: nop
          loc_40C50A: ldarg.0
          loc_40C50B: ldarg.1
          loc_40C50C: stfld GCUv2.cDeliveryOrder::_item
          loc_40C511: ret
        }

        public specialname double get_CustomerId() {

          double flt_1;

        }

        public specialname void set_CustomerId(double value) {

          loc_40C52D: nop
          loc_40C52E: ldarg.0
          loc_40C52F: ldarg.1
          loc_40C530: stfld GCUv2.cDeliveryOrder::_customerId
          loc_40C535: ret
        }

        public specialname string get_CustomerName() {

          string str_1;

        }

        public specialname void set_CustomerName(string value) {

          loc_40C551: nop
          loc_40C552: ldarg.0
          loc_40C553: ldarg.1
          loc_40C554: stfld GCUv2.cDeliveryOrder::_customerName
          loc_40C559: ret
        }

        public specialname string get_CustomerAddress() {

          string str_1;

        }

        public specialname void set_CustomerAddress(string value) {

          loc_40C575: nop
          loc_40C576: ldarg.0
          loc_40C577: ldarg.1
          loc_40C578: stfld GCUv2.cDeliveryOrder::_customerAddress
          loc_40C57D: ret
        }

        public specialname double get_InvoiceId() {

          double flt_1;

        }

        public specialname void set_InvoiceId(double value) {

          loc_40C599: nop
          loc_40C59A: ldarg.0
          loc_40C59B: ldarg.1
          loc_40C59C: stfld GCUv2.cDeliveryOrder::_invoiceId
          loc_40C5A1: ret
        }

        public specialname string get_InvoiceNumber() {

          string str_1;

        }

        public specialname void set_InvoiceNumber(string value) {

          loc_40C5BD: nop
          loc_40C5BE: ldarg.0
          loc_40C5BF: ldarg.1
          loc_40C5C0: stfld GCUv2.cDeliveryOrder::_invoiceNumber
          loc_40C5C5: ret
        }

        public specialname class GCUv2.cDeliveryOrderItem[] get_CurrentItem() {

          class GCUv2.cDeliveryOrderItem[] var_1;

        }

        public specialname void set_CurrentItem(class GCUv2.cDeliveryOrderItem[] value) {

          loc_40C5E1: nop
          loc_40C5E2: ldarg.0
          loc_40C5E3: ldarg.1
          loc_40C5E4: stfld GCUv2.cDeliveryOrder::_currentItem
          loc_40C5E9: ret
        }

        public specialname int32 get_CurrentStorage() {

          int32 num_1;

        }

        public specialname void set_CurrentStorage(int32 value) {

          loc_40C605: nop
          loc_40C606: ldarg.0
          loc_40C607: ldarg.1
          loc_40C608: stfld GCUv2.cDeliveryOrder::_currentStorage
          loc_40C60D: ret
        }

        public specialname valuetype System.DateTime get_CurrentDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_CurrentDate(valuetype System.DateTime value) {

          loc_40C629: nop
          loc_40C62A: ldarg.0
          loc_40C62B: ldarg.1
          loc_40C62C: stfld GCUv2.cDeliveryOrder::_currentDate
          loc_40C631: ret
        }

        public void cDeliveryOrder(double DOId) {

          boolean var_1;
          class DataTable var_2;
          string str_1;
          int32 num_1;
          boolean var_3;
          class System.Collections.IEnumerator var_4;
          class DataRow var_5;
          boolean var_6;
          boolean var_7;

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
          class GCUv2.cDeliveryOrderItem[] var_4;
          int32 num_5;
          class GCUv2.cDeliveryOrderItem var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;

        }

        public static class DataTable Search(int32 intRange, valuetype System.DateTime dateFirst, valuetype System.DateTime dateLast, double CustomerId, int32 StorageId, int32 GroupId, int32 BranchId, double InvoiceId, int32 ItemCategoryId, int32 ItemId) {

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

        }

        public static class DataTable SearchAvailableDO(double CustomerId, double InvoiceId) {

          class DataTable var_1;
          string str_1;
          boolean var_2;

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
