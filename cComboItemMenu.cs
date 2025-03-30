namespace GCUv2
{
    public class GCUv2.cComboItem
    {

        private string mFormName;


        public void cComboItemMenu(string pText, string pValue, string pForm) {

          loc_415C9D: nop
          loc_415C9E: ldarg.0
          loc_415C9F: ldarg.1
          loc_415CA0: ldarg.2
          loc_415CA1: call instance void GCUv2.cComboItem::.ctor(string, string)
          loc_415CA6: nop
          loc_415CA7: ldarg.0
          loc_415CA8: ldarg.3
          loc_415CA9: stfld GCUv2.cComboItem::mFormName
          loc_415CAE: ret
        }

        public specialname string get_FormName() {

          string str_1;

        }

    }
}
