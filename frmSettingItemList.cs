using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class DataGridView _dgvList;
        private class ToolStrip _ToolStrip1;
        private class ToolStripButton _tsbNew;
        private class ToolStripButton _tsbRefresh;
        private class CheckBox _chkManual;
        private class CheckBox _chkAll;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {

          class ComponentModel.ComponentResourceManager var_1;

        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_510BAD: ldarg.0
          loc_510BAE: ldfld GCUv2.frmSettingItemList::_dgvList
          loc_510BB3: br.s loc_510BB5
          loc_510BB5: // Referenced from: loc_510BB3
          loc_510BB5: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class System.EventHandler var_1;
          class KeyEventHandler var_2;
          class System.EventHandler var_3;
          class System.EventHandler var_4;
          class DataGridView var_5;

        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_510C59: ldarg.0
          loc_510C5A: ldfld GCUv2.frmSettingItemList::_ToolStrip1
          loc_510C5F: br.s loc_510C61
          loc_510C61: // Referenced from: loc_510C5F
          loc_510C61: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_510C63: ldarg.0
          loc_510C64: ldarg.1
          loc_510C65: stfld GCUv2.frmSettingItemList::_ToolStrip1
          loc_510C6A: ret
        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_510C6C: ldarg.0
          loc_510C6D: ldfld GCUv2.frmSettingItemList::_tsbNew
          loc_510C72: br.s loc_510C74
          loc_510C74: // Referenced from: loc_510C72
          loc_510C74: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_510CBC: ldarg.0
          loc_510CBD: ldfld GCUv2.frmSettingItemList::_tsbRefresh
          loc_510CC2: br.s loc_510CC4
          loc_510CC4: // Referenced from: loc_510CC2
          loc_510CC4: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class CheckBox get_chkManual() {

          loc_510D0C: ldarg.0
          loc_510D0D: ldfld GCUv2.frmSettingItemList::_chkManual
          loc_510D12: br.s loc_510D14
          loc_510D14: // Referenced from: loc_510D12
          loc_510D14: ret
        }

        assem override strict specialname void set_chkManual(class CheckBox WithEventsValue) {

          loc_510D16: ldarg.0
          loc_510D17: ldarg.1
          loc_510D18: stfld GCUv2.frmSettingItemList::_chkManual
          loc_510D1D: ret
        }

        assem override strict specialname class CheckBox get_chkAll() {

          loc_510D1F: ldarg.0
          loc_510D20: ldfld GCUv2.frmSettingItemList::_chkAll
          loc_510D25: br.s loc_510D27
          loc_510D27: // Referenced from: loc_510D25
          loc_510D27: ret
        }

        assem override strict specialname void set_chkAll(class CheckBox WithEventsValue) {

          class System.EventHandler var_1;
          class CheckBox var_2;

        }

        public void frmSettingItemList() {


        }

        private void frmSettingItemList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void FormatGrid() {


        }

        private void frmSettingItemList_Load(object sender, class System.EventArgs e) {

          loc_510F05: nop
          loc_510F06: ldarg.0
          loc_510F07: call instance void GCUv2.frmSettingItemList::getItem()
          loc_510F0C: nop
          loc_510F0D: ret
        }

        public void getItem() {

          class DataTable var_1;
          class System.Collections.IEnumerator var_2;
          class DataRow var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;

        }

        private void dgvList_DoubleClick(object sender, class System.EventArgs e) {

          loc_511049: nop
          loc_51104A: ldarg.0
          loc_51104B: call instance void GCUv2.frmSettingItemList::openSelection()
          loc_511050: nop
          loc_511051: ret
        }

        private void openSelection() {


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

        private void ToolStripButton1_Click(object sender, class System.EventArgs e) {


        }

        private void tsbDelete_Click(object sender, class System.EventArgs e) {

          loc_511240: nop
          loc_511241: ldstr "Fitur ini belum selesai dibuat"
          loc_511246: ldc.i4.s 64
          loc_511248: ldnull
          loc_511249: call valuetype MsgBoxResult Microsoft.VisualBasic.Interaction::MsgBox(object, valuetype MsgBoxStyle, object)
          loc_51124E: pop
          loc_51124F: ret
        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_510F05: nop
          loc_510F06: ldarg.0
          loc_510F07: call instance void GCUv2.frmSettingItemList::getItem()
          loc_510F0C: nop
          loc_510F0D: ret
        }

        private void chkAll_CheckedChanged(object sender, class System.EventArgs e) {

          loc_510F05: nop
          loc_510F06: ldarg.0
          loc_510F07: call instance void GCUv2.frmSettingItemList::getItem()
          loc_510F0C: nop
          loc_510F0D: ret
        }

    }
}
