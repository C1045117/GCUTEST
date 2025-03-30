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
        private class CheckBox _chkManual;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {

          class ComponentModel.ComponentResourceManager var_1;

        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_4E80F1: ldarg.0
          loc_4E80F2: ldfld GCUv2.frmSettingAreaList::_tsbRefresh
          loc_4E80F7: br.s loc_4E80F9
          loc_4E80F9: // Referenced from: loc_4E80F7
          loc_4E80F9: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_4E8140: ldarg.0
          loc_4E8141: ldfld GCUv2.frmSettingAreaList::_dgvList
          loc_4E8146: br.s loc_4E8148
          loc_4E8148: // Referenced from: loc_4E8146
          loc_4E8148: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class System.EventHandler var_1;
          class KeyEventHandler var_2;
          class System.EventHandler var_3;
          class System.EventHandler var_4;
          class DataGridView var_5;

        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_4E81ED: ldarg.0
          loc_4E81EE: ldfld GCUv2.frmSettingAreaList::_tsbNew
          loc_4E81F3: br.s loc_4E81F5
          loc_4E81F5: // Referenced from: loc_4E81F3
          loc_4E81F5: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class CheckBox get_chkAll() {

          loc_4E823C: ldarg.0
          loc_4E823D: ldfld GCUv2.frmSettingAreaList::_chkAll
          loc_4E8242: br.s loc_4E8244
          loc_4E8244: // Referenced from: loc_4E8242
          loc_4E8244: ret
        }

        assem override strict specialname void set_chkAll(class CheckBox WithEventsValue) {

          class System.EventHandler var_1;
          class CheckBox var_2;

        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_4E828C: ldarg.0
          loc_4E828D: ldfld GCUv2.frmSettingAreaList::_ToolStrip1
          loc_4E8292: br.s loc_4E8294
          loc_4E8294: // Referenced from: loc_4E8292
          loc_4E8294: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_4E8296: ldarg.0
          loc_4E8297: ldarg.1
          loc_4E8298: stfld GCUv2.frmSettingAreaList::_ToolStrip1
          loc_4E829D: ret
        }

        assem override strict specialname class CheckBox get_chkManual() {

          loc_4E829F: ldarg.0
          loc_4E82A0: ldfld GCUv2.frmSettingAreaList::_chkManual
          loc_4E82A5: br.s loc_4E82A7
          loc_4E82A7: // Referenced from: loc_4E82A5
          loc_4E82A7: ret
        }

        assem override strict specialname void set_chkManual(class CheckBox WithEventsValue) {

          loc_4E82A9: ldarg.0
          loc_4E82AA: ldarg.1
          loc_4E82AB: stfld GCUv2.frmSettingAreaList::_chkManual
          loc_4E82B0: ret
        }

        public void frmSettingAreaList() {


        }

        private void frmSettingAreaList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void frmSettingAreaList_Load(object sender, class System.EventArgs e) {

          loc_4E836F: nop
          loc_4E8370: ldarg.0
          loc_4E8371: call instance void GCUv2.frmSettingAreaList::getList()
          loc_4E8376: nop
          loc_4E8377: ret
        }

        private void FormatGrid() {


        }

        private void chkAll_CheckedChanged(object sender, class System.EventArgs e) {

          loc_4E836F: nop
          loc_4E8370: ldarg.0
          loc_4E8371: call instance void GCUv2.frmSettingAreaList::getList()
          loc_4E8376: nop
          loc_4E8377: ret
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

          loc_4E85D5: nop
          loc_4E85D6: ldarg.0
          loc_4E85D7: call instance void GCUv2.frmSettingAreaList::openSelection()
          loc_4E85DC: nop
          loc_4E85DD: ret
        }

        private void openSelection() {

          class GCUv2.frmSettingAreaInput var_1;

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

          class GCUv2.frmSettingAreaInput var_1;

        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_4E836F: nop
          loc_4E8370: ldarg.0
          loc_4E8371: call instance void GCUv2.frmSettingAreaList::getList()
          loc_4E8376: nop
          loc_4E8377: ret
        }

    }
}
