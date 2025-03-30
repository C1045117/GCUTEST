using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class ToolStripButton _tsbRefresh;
        private class CheckBox _chkAll;
        private class ToolStrip _ToolStrip1;
        private class ToolStripButton _tsbNew;
        private class DataGridView _dgvList;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {

          class ComponentModel.ComponentResourceManager var_1;

        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_4EBD6B: ldarg.0
          loc_4EBD6C: ldfld GCUv2.frmSettingCurrencyList::_tsbRefresh
          loc_4EBD71: br.s loc_4EBD73
          loc_4EBD73: // Referenced from: loc_4EBD71
          loc_4EBD73: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class CheckBox get_chkAll() {

          loc_4EBDB8: ldarg.0
          loc_4EBDB9: ldfld GCUv2.frmSettingCurrencyList::_chkAll
          loc_4EBDBE: br.s loc_4EBDC0
          loc_4EBDC0: // Referenced from: loc_4EBDBE
          loc_4EBDC0: ret
        }

        assem override strict specialname void set_chkAll(class CheckBox WithEventsValue) {

          class System.EventHandler var_1;
          class CheckBox var_2;

        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_4EBE08: ldarg.0
          loc_4EBE09: ldfld GCUv2.frmSettingCurrencyList::_ToolStrip1
          loc_4EBE0E: br.s loc_4EBE10
          loc_4EBE10: // Referenced from: loc_4EBE0E
          loc_4EBE10: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_4EBE12: ldarg.0
          loc_4EBE13: ldarg.1
          loc_4EBE14: stfld GCUv2.frmSettingCurrencyList::_ToolStrip1
          loc_4EBE19: ret
        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_4EBE1B: ldarg.0
          loc_4EBE1C: ldfld GCUv2.frmSettingCurrencyList::_tsbNew
          loc_4EBE21: br.s loc_4EBE23
          loc_4EBE23: // Referenced from: loc_4EBE21
          loc_4EBE23: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_4EBE68: ldarg.0
          loc_4EBE69: ldfld GCUv2.frmSettingCurrencyList::_dgvList
          loc_4EBE6E: br.s loc_4EBE70
          loc_4EBE70: // Referenced from: loc_4EBE6E
          loc_4EBE70: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class System.EventHandler var_1;
          class KeyEventHandler var_2;
          class System.EventHandler var_3;
          class System.EventHandler var_4;
          class DataGridView var_5;

        }

        public void frmSettingCurrencyList() {


        }

        private void frmSettingAreaList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void frmSettingAreaList_Load(object sender, class System.EventArgs e) {

          loc_4EBFCF: nop
          loc_4EBFD0: ldarg.0
          loc_4EBFD1: call instance void GCUv2.frmSettingCurrencyList::getList()
          loc_4EBFD6: nop
          loc_4EBFD7: ret
        }

        private void FormatGrid() {


        }

        private void chkAll_CheckedChanged(object sender, class System.EventArgs e) {

          loc_4EBFCF: nop
          loc_4EBFD0: ldarg.0
          loc_4EBFD1: call instance void GCUv2.frmSettingCurrencyList::getList()
          loc_4EBFD6: nop
          loc_4EBFD7: ret
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

          loc_4EC295: nop
          loc_4EC296: ldarg.0
          loc_4EC297: call instance void GCUv2.frmSettingCurrencyList::openSelection()
          loc_4EC29C: nop
          loc_4EC29D: ret
        }

        private void openSelection() {

          class GCUv2.frmSettingCurrencyInput var_1;

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

          class GCUv2.frmSettingCurrencyInput var_1;

        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_4EBFCF: nop
          loc_4EBFD0: ldarg.0
          loc_4EBFD1: call instance void GCUv2.frmSettingCurrencyList::getList()
          loc_4EBFD6: nop
          loc_4EBFD7: ret
        }

    }
}
