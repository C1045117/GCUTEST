using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class ToolStrip _ToolStrip1;
        private class ToolStripButton _tsbNew;
        private class DataGridView _dgvList;
        private class CheckBox _chkAll;
        private class ToolStripButton _tsbRefresh;
        private class CheckBox _chkManual;
        private class ToolStripButton _tsbDelete;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {

          class ComponentModel.ComponentResourceManager var_1;

        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_515A2B: ldarg.0
          loc_515A2C: ldfld GCUv2.frmSettingUserList::_ToolStrip1
          loc_515A31: br.s loc_515A33
          loc_515A33: // Referenced from: loc_515A31
          loc_515A33: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_515A35: ldarg.0
          loc_515A36: ldarg.1
          loc_515A37: stfld GCUv2.frmSettingUserList::_ToolStrip1
          loc_515A3C: ret
        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_515A3E: ldarg.0
          loc_515A3F: ldfld GCUv2.frmSettingUserList::_tsbNew
          loc_515A44: br.s loc_515A46
          loc_515A46: // Referenced from: loc_515A44
          loc_515A46: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_515A8C: ldarg.0
          loc_515A8D: ldfld GCUv2.frmSettingUserList::_dgvList
          loc_515A92: br.s loc_515A94
          loc_515A94: // Referenced from: loc_515A92
          loc_515A94: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class System.EventHandler var_1;
          class KeyEventHandler var_2;
          class System.EventHandler var_3;
          class System.EventHandler var_4;
          class DataGridView var_5;

        }

        assem override strict specialname class CheckBox get_chkAll() {

          loc_515B39: ldarg.0
          loc_515B3A: ldfld GCUv2.frmSettingUserList::_chkAll
          loc_515B3F: br.s loc_515B41
          loc_515B41: // Referenced from: loc_515B3F
          loc_515B41: ret
        }

        assem override strict specialname void set_chkAll(class CheckBox WithEventsValue) {

          class System.EventHandler var_1;
          class CheckBox var_2;

        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_515B88: ldarg.0
          loc_515B89: ldfld GCUv2.frmSettingUserList::_tsbRefresh
          loc_515B8E: br.s loc_515B90
          loc_515B90: // Referenced from: loc_515B8E
          loc_515B90: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class CheckBox get_chkManual() {

          loc_515BD8: ldarg.0
          loc_515BD9: ldfld GCUv2.frmSettingUserList::_chkManual
          loc_515BDE: br.s loc_515BE0
          loc_515BE0: // Referenced from: loc_515BDE
          loc_515BE0: ret
        }

        assem override strict specialname void set_chkManual(class CheckBox WithEventsValue) {

          loc_515BE2: ldarg.0
          loc_515BE3: ldarg.1
          loc_515BE4: stfld GCUv2.frmSettingUserList::_chkManual
          loc_515BE9: ret
        }

        assem override strict specialname class ToolStripButton get_tsbDelete() {

          loc_515BEB: ldarg.0
          loc_515BEC: ldfld GCUv2.frmSettingUserList::_tsbDelete
          loc_515BF1: br.s loc_515BF3
          loc_515BF3: // Referenced from: loc_515BF1
          loc_515BF3: ret
        }

        assem override strict specialname void set_tsbDelete(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        public void frmSettingUserList() {


        }

        private void frmSettingUserList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void frmSettingUserList_Load(object sender, class System.EventArgs e) {

          loc_515CF3: nop
          loc_515CF4: ldarg.0
          loc_515CF5: call instance void GCUv2.frmSettingUserList::getList()
          loc_515CFA: nop
          loc_515CFB: ret
        }

        private void FormatGrid() {


        }

        private void chkAll_CheckedChanged(object sender, class System.EventArgs e) {

          loc_515CF3: nop
          loc_515CF4: ldarg.0
          loc_515CF5: call instance void GCUv2.frmSettingUserList::getList()
          loc_515CFA: nop
          loc_515CFB: ret
        }

        public void getList() {

          class DataTable var_1;
          class System.Collections.IEnumerator var_2;
          class DataRow var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;

        }

        private void dgvList_DoubleClick(object sender, class System.EventArgs e) {

          loc_515F71: nop
          loc_515F72: ldarg.0
          loc_515F73: call instance void GCUv2.frmSettingUserList::openSelection()
          loc_515F78: nop
          loc_515F79: ret
        }

        private void openSelection() {

          class GCUv2.frmSettingUserInput var_1;

        }

        private void dgvList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;

        }

        private void dgvList_GotFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvList_LostFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void ToolStripButton1_Click(object sender, class System.EventArgs e) {

          class GCUv2.frmSettingUserInput var_1;

        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_515CF3: nop
          loc_515CF4: ldarg.0
          loc_515CF5: call instance void GCUv2.frmSettingUserList::getList()
          loc_515CFA: nop
          loc_515CFB: ret
        }

        private void tsbDelete_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          string str_1;
          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

    }
}
