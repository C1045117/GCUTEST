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
        private class Label _Label1;
        private class ToolStripButton _tsbRefresh;
        private class CheckBox _chkManual;
        private class CheckBox _chkAll;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {

          class ComponentModel.ComponentResourceManager var_1;

        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_504009: ldarg.0
          loc_50400A: ldfld GCUv2.frmSettingAccountList::_ToolStrip1
          loc_50400F: br.s loc_504011
          loc_504011: // Referenced from: loc_50400F
          loc_504011: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_504013: ldarg.0
          loc_504014: ldarg.1
          loc_504015: stfld GCUv2.frmSettingAccountList::_ToolStrip1
          loc_50401A: ret
        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_50401C: ldarg.0
          loc_50401D: ldfld GCUv2.frmSettingAccountList::_tsbNew
          loc_504022: br.s loc_504024
          loc_504024: // Referenced from: loc_504022
          loc_504024: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_50406C: ldarg.0
          loc_50406D: ldfld GCUv2.frmSettingAccountList::_dgvList
          loc_504072: br.s loc_504074
          loc_504074: // Referenced from: loc_504072
          loc_504074: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class System.EventHandler var_1;
          class KeyEventHandler var_2;
          class System.EventHandler var_3;
          class System.EventHandler var_4;
          class DataGridView var_5;

        }

        assem override strict specialname class Label get_Label1() {

          loc_504119: ldarg.0
          loc_50411A: ldfld GCUv2.frmSettingAccountList::_Label1
          loc_50411F: br.s loc_504121
          loc_504121: // Referenced from: loc_50411F
          loc_504121: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_504123: ldarg.0
          loc_504124: ldarg.1
          loc_504125: stfld GCUv2.frmSettingAccountList::_Label1
          loc_50412A: ret
        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_50412C: ldarg.0
          loc_50412D: ldfld GCUv2.frmSettingAccountList::_tsbRefresh
          loc_504132: br.s loc_504134
          loc_504134: // Referenced from: loc_504132
          loc_504134: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class CheckBox get_chkManual() {

          loc_50417C: ldarg.0
          loc_50417D: ldfld GCUv2.frmSettingAccountList::_chkManual
          loc_504182: br.s loc_504184
          loc_504184: // Referenced from: loc_504182
          loc_504184: ret
        }

        assem override strict specialname void set_chkManual(class CheckBox WithEventsValue) {

          loc_504186: ldarg.0
          loc_504187: ldarg.1
          loc_504188: stfld GCUv2.frmSettingAccountList::_chkManual
          loc_50418D: ret
        }

        assem override strict specialname class CheckBox get_chkAll() {

          loc_50418F: ldarg.0
          loc_504190: ldfld GCUv2.frmSettingAccountList::_chkAll
          loc_504195: br.s loc_504197
          loc_504197: // Referenced from: loc_504195
          loc_504197: ret
        }

        assem override strict specialname void set_chkAll(class CheckBox WithEventsValue) {

          class System.EventHandler var_1;
          class CheckBox var_2;

        }

        public void frmSettingAccountList() {


        }

        private void frmSettingAccountList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void formatGrid() {

          class DataGridView var_1;

        }

        private void frmSettingAccountList_Load(object sender, class System.EventArgs e) {

          loc_5043E7: nop
          loc_5043E8: ldarg.0
          loc_5043E9: call instance void GCUv2.frmSettingAccountList::getAccount()
          loc_5043EE: nop
          loc_5043EF: ret
        }

        public void getAccount() {

          class DataTable var_1;
          int32 num_1;
          string str_1;
          class System.Collections.IEnumerator var_2;
          class DataRow var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;

        }

        private void dgvList_DoubleClick(object sender, class System.EventArgs e) {

          loc_504575: nop
          loc_504576: ldarg.0
          loc_504577: call instance void GCUv2.frmSettingAccountList::openSelection()
          loc_50457C: nop
          loc_50457D: ret
        }

        private void openSelection() {

          class GCUv2.frmSettingAccountInput var_1;

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

        private void tsbNew_Click(object sender, class System.EventArgs e) {

          class GCUv2.frmSettingAccountInput var_1;

        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_5043E7: nop
          loc_5043E8: ldarg.0
          loc_5043E9: call instance void GCUv2.frmSettingAccountList::getAccount()
          loc_5043EE: nop
          loc_5043EF: ret
        }

        private void chkAll_CheckedChanged(object sender, class System.EventArgs e) {

          loc_5043E7: nop
          loc_5043E8: ldarg.0
          loc_5043E9: call instance void GCUv2.frmSettingAccountList::getAccount()
          loc_5043EE: nop
          loc_5043EF: ret
        }

    }
}
