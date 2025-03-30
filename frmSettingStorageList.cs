using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class CheckBox _chkAll;
        private class ToolStripButton _tsbRefresh;
        private class ToolStripButton _tsbNew;
        private class DataGridView _dgvList;
        private class ToolStrip _ToolStrip1;
        private class CheckBox _chkManual;
        private class ToolStripButton _tsbDelete;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {

          class ComponentModel.ComponentResourceManager var_1;

        }

        assem override strict specialname class CheckBox get_chkAll() {

          loc_512FE0: ldarg.0
          loc_512FE1: ldfld GCUv2.frmSettingStorageList::_chkAll
          loc_512FE6: br.s loc_512FE8
          loc_512FE8: // Referenced from: loc_512FE6
          loc_512FE8: ret
        }

        assem override strict specialname void set_chkAll(class CheckBox WithEventsValue) {

          class System.EventHandler var_1;
          class CheckBox var_2;

        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_513030: ldarg.0
          loc_513031: ldfld GCUv2.frmSettingStorageList::_tsbRefresh
          loc_513036: br.s loc_513038
          loc_513038: // Referenced from: loc_513036
          loc_513038: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_513080: ldarg.0
          loc_513081: ldfld GCUv2.frmSettingStorageList::_tsbNew
          loc_513086: br.s loc_513088
          loc_513088: // Referenced from: loc_513086
          loc_513088: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_5130D0: ldarg.0
          loc_5130D1: ldfld GCUv2.frmSettingStorageList::_dgvList
          loc_5130D6: br.s loc_5130D8
          loc_5130D8: // Referenced from: loc_5130D6
          loc_5130D8: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class System.EventHandler var_1;
          class KeyEventHandler var_2;
          class System.EventHandler var_3;
          class System.EventHandler var_4;
          class DataGridView var_5;

        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_51317D: ldarg.0
          loc_51317E: ldfld GCUv2.frmSettingStorageList::_ToolStrip1
          loc_513183: br.s loc_513185
          loc_513185: // Referenced from: loc_513183
          loc_513185: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_513187: ldarg.0
          loc_513188: ldarg.1
          loc_513189: stfld GCUv2.frmSettingStorageList::_ToolStrip1
          loc_51318E: ret
        }

        assem override strict specialname class CheckBox get_chkManual() {

          loc_513190: ldarg.0
          loc_513191: ldfld GCUv2.frmSettingStorageList::_chkManual
          loc_513196: br.s loc_513198
          loc_513198: // Referenced from: loc_513196
          loc_513198: ret
        }

        assem override strict specialname void set_chkManual(class CheckBox WithEventsValue) {

          loc_51319A: ldarg.0
          loc_51319B: ldarg.1
          loc_51319C: stfld GCUv2.frmSettingStorageList::_chkManual
          loc_5131A1: ret
        }

        assem override strict specialname class ToolStripButton get_tsbDelete() {

          loc_5131A3: ldarg.0
          loc_5131A4: ldfld GCUv2.frmSettingStorageList::_tsbDelete
          loc_5131A9: br.s loc_5131AB
          loc_5131AB: // Referenced from: loc_5131A9
          loc_5131AB: ret
        }

        assem override strict specialname void set_tsbDelete(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        public void frmSettingStorageList() {


        }

        private void frmSettingStorageList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void frmSettingStorageList_Load(object sender, class System.EventArgs e) {

          loc_5132AB: nop
          loc_5132AC: ldarg.0
          loc_5132AD: call instance void GCUv2.frmSettingStorageList::getList()
          loc_5132B2: nop
          loc_5132B3: ret
        }

        private void FormatGrid() {


        }

        private void chkAll_CheckedChanged(object sender, class System.EventArgs e) {

          loc_5132AB: nop
          loc_5132AC: ldarg.0
          loc_5132AD: call instance void GCUv2.frmSettingStorageList::getList()
          loc_5132B2: nop
          loc_5132B3: ret
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

          loc_513511: nop
          loc_513512: ldarg.0
          loc_513513: call instance void GCUv2.frmSettingStorageList::openSelection()
          loc_513518: nop
          loc_513519: ret
        }

        private void openSelection() {

          class GCUv2.frmSettingStorageInput var_1;

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

          class GCUv2.frmSettingStorageInput var_1;

        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_5132AB: nop
          loc_5132AC: ldarg.0
          loc_5132AD: call instance void GCUv2.frmSettingStorageList::getList()
          loc_5132B2: nop
          loc_5132B3: ret
        }

        private void tsbDelete_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          string str_1;
          int32 num_2;
          boolean var_1;
          class GCUv2.cStorage var_2;
          boolean var_3;
          boolean var_4;

        }

    }
}
