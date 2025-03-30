using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class CheckBox _chkAll;
        private class DataGridView _dgvList;
        private class ToolStrip _ToolStrip1;
        private class ToolStripButton _tsbNew;
        private class ToolStripButton _tsbRefresh;
        private class CheckBox _chkManual;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {

          class ComponentModel.ComponentResourceManager var_1;

        }

        assem override strict specialname class CheckBox get_chkAll() {

          loc_4EDE90: ldarg.0
          loc_4EDE91: ldfld GCUv2.frmSettingDiscountList::_chkAll
          loc_4EDE96: br.s loc_4EDE98
          loc_4EDE98: // Referenced from: loc_4EDE96
          loc_4EDE98: ret
        }

        assem override strict specialname void set_chkAll(class CheckBox WithEventsValue) {

          class System.EventHandler var_1;
          class CheckBox var_2;

        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_4EDEE0: ldarg.0
          loc_4EDEE1: ldfld GCUv2.frmSettingDiscountList::_dgvList
          loc_4EDEE6: br.s loc_4EDEE8
          loc_4EDEE8: // Referenced from: loc_4EDEE6
          loc_4EDEE8: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class System.EventHandler var_1;
          class KeyEventHandler var_2;
          class System.EventHandler var_3;
          class System.EventHandler var_4;
          class DataGridView var_5;

        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_4EDF8D: ldarg.0
          loc_4EDF8E: ldfld GCUv2.frmSettingDiscountList::_ToolStrip1
          loc_4EDF93: br.s loc_4EDF95
          loc_4EDF95: // Referenced from: loc_4EDF93
          loc_4EDF95: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_4EDF97: ldarg.0
          loc_4EDF98: ldarg.1
          loc_4EDF99: stfld GCUv2.frmSettingDiscountList::_ToolStrip1
          loc_4EDF9E: ret
        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_4EDFA0: ldarg.0
          loc_4EDFA1: ldfld GCUv2.frmSettingDiscountList::_tsbNew
          loc_4EDFA6: br.s loc_4EDFA8
          loc_4EDFA8: // Referenced from: loc_4EDFA6
          loc_4EDFA8: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_4EDFF0: ldarg.0
          loc_4EDFF1: ldfld GCUv2.frmSettingDiscountList::_tsbRefresh
          loc_4EDFF6: br.s loc_4EDFF8
          loc_4EDFF8: // Referenced from: loc_4EDFF6
          loc_4EDFF8: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class CheckBox get_chkManual() {

          loc_4EE040: ldarg.0
          loc_4EE041: ldfld GCUv2.frmSettingDiscountList::_chkManual
          loc_4EE046: br.s loc_4EE048
          loc_4EE048: // Referenced from: loc_4EE046
          loc_4EE048: ret
        }

        assem override strict specialname void set_chkManual(class CheckBox WithEventsValue) {

          loc_4EE04A: ldarg.0
          loc_4EE04B: ldarg.1
          loc_4EE04C: stfld GCUv2.frmSettingDiscountList::_chkManual
          loc_4EE051: ret
        }

        public void frmSettingDiscountList() {


        }

        private void frmSettingDiscountList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void frmSettingDiscountList_Load(object sender, class System.EventArgs e) {

          loc_4EE10F: nop
          loc_4EE110: ldarg.0
          loc_4EE111: call instance void GCUv2.frmSettingDiscountList::getList()
          loc_4EE116: nop
          loc_4EE117: ret
        }

        private void FormatGrid() {


        }

        private void chkAll_CheckedChanged(object sender, class System.EventArgs e) {

          loc_4EE10F: nop
          loc_4EE110: ldarg.0
          loc_4EE111: call instance void GCUv2.frmSettingDiscountList::getList()
          loc_4EE116: nop
          loc_4EE117: ret
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

          loc_4EE36D: nop
          loc_4EE36E: ldarg.0
          loc_4EE36F: call instance void GCUv2.frmSettingDiscountList::openSelection()
          loc_4EE374: nop
          loc_4EE375: ret
        }

        private void openSelection() {

          class GCUv2.frmSettingDiscountInput var_1;

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

          class GCUv2.frmSettingDiscountInput var_1;

        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_4EE10F: nop
          loc_4EE110: ldarg.0
          loc_4EE111: call instance void GCUv2.frmSettingDiscountList::getList()
          loc_4EE116: nop
          loc_4EE117: ret
        }

    }
}
