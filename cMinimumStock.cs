namespace GCUv2
{
    public class 
    {

        private int32 _branchId;
        private class GCUv2.cMinimumStockItem[] _item;


        public void cMinimumStock() {

          loc_403253: ldarg.0
          loc_403254: call instance void System.Object::.ctor()
          loc_403259: ret
        }

        public specialname int32 get_BranchId() {

          int32 num_1;

        }

        public specialname void set_BranchId(int32 value) {

          loc_410B61: nop
          loc_410B62: ldarg.0
          loc_410B63: ldarg.1
          loc_410B64: stfld GCUv2.cItemStandardUsage::_branchId
          loc_410B69: ret
        }

        public specialname class GCUv2.cMinimumStockItem[] get_Item() {

          class GCUv2.cMinimumStockItem[] var_1;

        }

        public specialname void set_Item(class GCUv2.cMinimumStockItem[] value) {

          loc_410B85: nop
          loc_410B86: ldarg.0
          loc_410B87: ldarg.1
          loc_410B88: stfld GCUv2.cMinimumStock::_item
          loc_410B8D: ret
        }

        public void Save() {

          string str_1;
          class GCUv2.cMinimumStockItem[] var_1;
          int32 num_1;
          class GCUv2.cMinimumStockItem var_2;
          boolean var_3;

        }

        public static class DataTable Search(int32 BranchId) {

          class DataTable var_1;
          string str_1;

        }

    }
}
