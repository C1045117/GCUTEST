namespace GCUv2
{
    public class 
    {

        private int32 _storageId;
        private string _storageName;
        private string _branchName;
        private boolean _isMember;
        private double _qty;
        private double _price;


        public void cItemStorage() {

          loc_403253: ldarg.0
          loc_403254: call instance void System.Object::.ctor()
          loc_403259: ret
        }

        public specialname int32 get_StorageId() {

          int32 num_1;

        }

        public specialname void set_StorageId(int32 value) {

          loc_4109D5: nop
          loc_4109D6: ldarg.0
          loc_4109D7: ldarg.1
          loc_4109D8: stfld GCUv2.cItemGroup::_storageId
          loc_4109DD: ret
        }

        public specialname string get_StorageName() {

          string str_1;

        }

        public specialname void set_StorageName(string value) {

          loc_4109F9: nop
          loc_4109FA: ldarg.0
          loc_4109FB: ldarg.1
          loc_4109FC: stfld GCUv2.cItemStorage::_storageName
          loc_410A01: ret
        }

        public specialname string get_BranchName() {

          string str_1;

        }

        public specialname void set_BranchName(string value) {

          loc_410A1D: nop
          loc_410A1E: ldarg.0
          loc_410A1F: ldarg.1
          loc_410A20: stfld GCUv2.cItemStorage::_branchName
          loc_410A25: ret
        }

        public specialname boolean get_IsMember() {

          boolean var_1;

        }

        public specialname void set_IsMember(boolean value) {

          loc_410A41: nop
          loc_410A42: ldarg.0
          loc_410A43: ldarg.1
          loc_410A44: stfld GCUv2.cItemStorage::_isMember
          loc_410A49: ret
        }

        public specialname double get_Qty() {

          double flt_1;

        }

        public specialname void set_Qty(double value) {

          loc_410A65: nop
          loc_410A66: ldarg.0
          loc_410A67: ldarg.1
          loc_410A68: stfld GCUv2.cItemStorage::_qty
          loc_410A6D: ret
        }

        public specialname double get_Price() {

          double flt_1;

        }

        public specialname void set_Price(double value) {

          loc_410A89: nop
          loc_410A8A: ldarg.0
          loc_410A8B: ldarg.1
          loc_410A8C: stfld GCUv2.cItemStorage::_price
          loc_410A91: ret
        }

    }
}
