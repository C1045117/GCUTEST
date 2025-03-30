using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class ToolStripButton _tsbRefresh;
        private class DataGridView _dgvList;
        private class ToolStripButton _tsbNew;
        private class CheckBox _chkAll;
        private class ToolStrip _ToolStrip1;
        private class Label _Label1;
        private class Label _Label2;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {

          class ComponentModel.ComponentResourceManager var_1;

        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_4E9376: ldarg.0
          loc_4E9377: ldfld GCUv2.frmSettingBankList::_tsbRefresh
          loc_4E937C: br.s loc_4E937E
          loc_4E937E: // Referenced from: loc_4E937C
          loc_4E937E: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_4E93C4: ldarg.0
          loc_4E93C5: ldfld GCUv2.frmSettingBankList::_dgvList
          loc_4E93CA: br.s loc_4E93CC
          loc_4E93CC: // Referenced from: loc_4E93CA
          loc_4E93CC: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class System.EventHandler var_1;
          class KeyEventHandler var_2;
          class System.EventHandler var_3;
          class System.EventHandler var_4;
          class DataGridView var_5;

        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_4E9471: ldarg.0
          loc_4E9472: ldfld GCUv2.frmSettingBankList::_tsbNew
          loc_4E9477: br.s loc_4E9479
          loc_4E9479: // Referenced from: loc_4E9477
          loc_4E9479: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class CheckBox get_chkAll() {

          loc_4E94C0: ldarg.0
          loc_4E94C1: ldfld GCUv2.frmSettingBankList::_chkAll
          loc_4E94C6: br.s loc_4E94C8
          loc_4E94C8: // Referenced from: loc_4E94C6
          loc_4E94C8: ret
        }

        assem override strict specialname void set_chkAll(class CheckBox WithEventsValue) {

          class System.EventHandler var_1;
          class CheckBox var_2;

        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_4E9510: ldarg.0
          loc_4E9511: ldfld GCUv2.frmSettingBankList::_ToolStrip1
          loc_4E9516: br.s loc_4E9518
          loc_4E9518: // Referenced from: loc_4E9516
          loc_4E9518: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_4E951A: ldarg.0
          loc_4E951B: ldarg.1
          loc_4E951C: stfld GCUv2.frmSettingBankList::_ToolStrip1
          loc_4E9521: ret
        }

        assem override strict specialname class Label get_Label1() {

          loc_4E9523: ldarg.0
          loc_4E9524: ldfld GCUv2.frmSettingBankList::_Label1
          loc_4E9529: br.s loc_4E952B
          loc_4E952B: // Referenced from: loc_4E9529
          loc_4E952B: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_4E952D: ldarg.0
          loc_4E952E: ldarg.1
          loc_4E952F: stfld GCUv2.frmSettingBankList::_Label1
          loc_4E9534: ret
        }

        assem override strict specialname class Label get_Label2() {

          loc_4E9536: ldarg.0
          loc_4E9537: ldfld GCUv2.frmSettingBankList::_Label2
          loc_4E953C: br.s loc_4E953E
          loc_4E953E: // Referenced from: loc_4E953C
          loc_4E953E: ret
        }

        assem override strict specialname void set_Label2(class Label WithEventsValue) {

          loc_4E9540: ldarg.0
          loc_4E9541: ldarg.1
          loc_4E9542: stfld GCUv2.frmSettingBankList::_Label2
          loc_4E9547: ret
        }

        public void frmSettingBankList() {


        }

        private void frmSettingBranchList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void frmSettingBranchList_Load(object sender, class System.EventArgs e) {

          loc_4E9603: nop
          loc_4E9604: ldarg.0
          loc_4E9605: call instance void GCUv2.frmSettingBankList::getList()
          loc_4E960A: nop
          loc_4E960B: ret
        }

        private void FormatGrid() {


        }

        private void chkAll_CheckedChanged(object sender, class System.EventArgs e) {

          loc_4E9603: nop
          loc_4E9604: ldarg.0
          loc_4E9605: call instance void GCUv2.frmSettingBankList::getList()
          loc_4E960A: nop
          loc_4E960B: ret
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

          loc_4E9821: nop
          loc_4E9822: ldarg.0
          loc_4E9823: call instance void GCUv2.frmSettingBankList::openSelection()
          loc_4E9828: nop
          loc_4E9829: ret
        }

        private void openSelection() {

          class GCUv2.frmSettingBankInput var_1;

        }

        private void dgvList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;

        }

        private void dgvList_GotFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvList_LostFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void tsbNew_Click(object sender, class System.EventArgs e) {

          class GCUv2.frmSettingBankInput var_1;

        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_4E9603: nop
          loc_4E9604: ldarg.0
          loc_4E9605: call instance void GCUv2.frmSettingBankList::getList()
          loc_4E960A: nop
          loc_4E960B: ret
        }

    }
}
