using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Button _btnSearch;
        private class DataGridView _dgvList;
        private class TextBox _txtName;
        private class Label _Label2;
        private string _callerName;
        private int32 _branchId;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Button get_btnSearch() {

          loc_4407B9: ldarg.0
          loc_4407BA: ldfld GCUv2.frmCustomerMiniSearch::_btnSearch
          loc_4407BF: br.s loc_4407C1
          loc_4407C1: // Referenced from: loc_4407BF
          loc_4407C1: ret
        }

        assem override strict specialname void set_btnSearch(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_440808: ldarg.0
          loc_440809: ldfld GCUv2.frmCustomerMiniSearch::_dgvList
          loc_44080E: br.s loc_440810
          loc_440810: // Referenced from: loc_44080E
          loc_440810: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class KeyEventHandler var_1;
          class System.EventHandler var_2;
          class System.EventHandler var_3;
          class System.EventHandler var_4;
          class DataGridView var_5;

        }

        assem override strict specialname class TextBox get_txtName() {

          loc_4408B5: ldarg.0
          loc_4408B6: ldfld GCUv2.frmCustomerMiniSearch::_txtName
          loc_4408BB: br.s loc_4408BD
          loc_4408BD: // Referenced from: loc_4408BB
          loc_4408BD: ret
        }

        assem override strict specialname void set_txtName(class TextBox WithEventsValue) {

          loc_4408BF: ldarg.0
          loc_4408C0: ldarg.1
          loc_4408C1: stfld GCUv2.frmCustomerMiniSearch::_txtName
          loc_4408C6: ret
        }

        assem override strict specialname class Label get_Label2() {

          loc_4408C8: ldarg.0
          loc_4408C9: ldfld GCUv2.frmCustomerMiniSearch::_Label2
          loc_4408CE: br.s loc_4408D0
          loc_4408D0: // Referenced from: loc_4408CE
          loc_4408D0: ret
        }

        assem override strict specialname void set_Label2(class Label WithEventsValue) {

          loc_4408D2: ldarg.0
          loc_4408D3: ldarg.1
          loc_4408D4: stfld GCUv2.frmCustomerMiniSearch::_Label2
          loc_4408D9: ret
        }

        public specialname string get_CallerName() {

          string str_1;

        }

        public specialname void set_CallerName(string value) {

          loc_4408F5: nop
          loc_4408F6: ldarg.0
          loc_4408F7: ldarg.1
          loc_4408F8: stfld GCUv2.frmCustomerMiniSearch::_callerName
          loc_4408FD: ret
        }

        public specialname int32 get_BranchId() {

          int32 num_1;

        }

        public specialname void set_BranchId(int32 value) {

          loc_440919: nop
          loc_44091A: ldarg.0
          loc_44091B: ldarg.1
          loc_44091C: stfld GCUv2.frmCustomerMiniSearch::_branchId
          loc_440921: ret
        }

        public void frmCustomerMiniSearch() {

          loc_440923: nop
          loc_440924: ldarg.0
          loc_440925: call instance void System.Windows.Forms.Form::.ctor()
          loc_44092A: nop
          loc_44092B: ldarg.0
          loc_44092C: ldarg.0
          loc_44092D: ldftn instance void GCUv2.frmCustomerMiniSearch::frmCustomerMiniSearch_KeyDown(object, class KeyEventArgs)
          loc_440933: newobj instance void System.Windows.Forms.KeyEventHandler::.ctor(object, System.IntPtr)
          loc_440938: call instance void System.Windows.Forms.Control::add_KeyDown(class KeyEventHandler)
          loc_44093D: nop
          loc_44093E: ldarg.0
          loc_44093F: call instance void GCUv2.frmCustomerMiniSearch::InitializeComponent()
          loc_440944: nop
          loc_440945: ldarg.0
          loc_440946: ldc.i4.1
          loc_440947: callvirt instance void System.Windows.Forms.Control::set_DoubleBuffered(boolean)
          loc_44094C: nop
          loc_44094D: ret
        }

        private void frmCustomerMiniSearch_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void formatGrid() {


        }

        private void btnSearch_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          class DataTable var_1;
          int32 num_3;
          boolean var_2;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          boolean var_5;
          boolean var_6;

        }

        private void dgvList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void dgvList_GotFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvList_LostFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvList_DoubleClick(object sender, class System.EventArgs e) {

          loc_440F2D: nop
          loc_440F2E: ldarg.0
          loc_440F2F: call instance void GCUv2.frmCustomerMiniSearch::sendCustomer()
          loc_440F34: nop
          loc_440F35: ret
        }

        public void sendCustomer() {

          boolean var_1;
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

    }
}
