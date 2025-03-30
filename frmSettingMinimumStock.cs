using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Label _Label2;
        private class ComboBox _cboBranch;
        private class Button _btnSaveClose;
        private class DataGridView _dgvList;
        private boolean _dontFocus;
        private boolean _blnDecimal;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Label get_Label2() {

          loc_4F1CD9: ldarg.0
          loc_4F1CDA: ldfld GCUv2.frmSettingMinimumStock::_Label2
          loc_4F1CDF: br.s loc_4F1CE1
          loc_4F1CE1: // Referenced from: loc_4F1CDF
          loc_4F1CE1: ret
        }

        assem override strict specialname void set_Label2(class Label WithEventsValue) {

          loc_4F1CE3: ldarg.0
          loc_4F1CE4: ldarg.1
          loc_4F1CE5: stfld GCUv2.frmSettingMinimumStock::_Label2
          loc_4F1CEA: ret
        }

        assem override strict specialname class ComboBox get_cboBranch() {

          loc_4F1CEC: ldarg.0
          loc_4F1CED: ldfld GCUv2.frmSettingMinimumStock::_cboBranch
          loc_4F1CF2: br.s loc_4F1CF4
          loc_4F1CF4: // Referenced from: loc_4F1CF2
          loc_4F1CF4: ret
        }

        assem override strict specialname void set_cboBranch(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class Button get_btnSaveClose() {

          loc_4F1D3C: ldarg.0
          loc_4F1D3D: ldfld GCUv2.frmSettingMinimumStock::_btnSaveClose
          loc_4F1D42: br.s loc_4F1D44
          loc_4F1D44: // Referenced from: loc_4F1D42
          loc_4F1D44: ret
        }

        assem override strict specialname void set_btnSaveClose(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_4F1D8C: ldarg.0
          loc_4F1D8D: ldfld GCUv2.frmSettingMinimumStock::_dgvList
          loc_4F1D92: br.s loc_4F1D94
          loc_4F1D94: // Referenced from: loc_4F1D92
          loc_4F1D94: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class DataGridViewCellEventHandler var_1;
          class DataGridViewCellEventHandler var_2;
          class DataGridViewCellValidatingEventHandler var_3;
          class System.EventHandler var_4;
          class System.EventHandler var_5;
          class KeyEventHandler var_6;
          class DataGridViewEditingControlShowingEventHandler var_7;
          class DataGridView var_8;

        }

        public void frmSettingMinimumStock() {

          class ComboBox var_1;

        }

        private void frmSettingMinimumItem_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void FormatGrid() {


        }

        private void cboBranch_SelectedIndexChanged(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          class DataTable var_2;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          boolean var_5;
          boolean var_6;

        }

        private void dgvList_CellEnter(object sender, class DataGridViewCellEventArgs e) {

          boolean var_1;
          string str_1;

        }

        private void dgvList_CellEndEdit(object sender, class DataGridViewCellEventArgs e) {

          boolean var_1;
          string str_1;
          boolean var_2;

        }

        private void dgvList_CellValidating(object sender, class DataGridViewCellValidatingEventArgs e) {

          int32 num_1;
          int32 num_2;
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

        private void dgvList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void dgvList_EditingControlShowing(object sender, class DataGridViewEditingControlShowingEventArgs e) {

          class Control var_1;

        }

        protected void Handle_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        protected void Handle_KeyPress(object sender, class KeyPressEventArgs e) {

          int16 num_1;
          boolean var_1;
          boolean var_2;

        }

        private void btnSaveClose_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          class GCUv2.cComboItem var_1;
          class GCUv2.cMinimumStock var_2;
          class GCUv2.cMinimumStockItem[] var_3;
          int32 num_3;
          int32 num_4;

        }

    }
}
