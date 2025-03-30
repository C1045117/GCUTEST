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
        private class CheckBox _chkAll;
        private class ToolStripButton _tsbRefresh;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {

          class ComponentModel.ComponentResourceManager var_1;

        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_505217: ldarg.0
          loc_505218: ldfld GCUv2.frmSettingBranchList::_dgvList
          loc_50521D: br.s loc_50521F
          loc_50521F: // Referenced from: loc_50521D
          loc_50521F: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class System.EventHandler var_1;
          class KeyEventHandler var_2;
          class System.EventHandler var_3;
          class System.EventHandler var_4;
          class DataGridView var_5;

        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_5052C1: ldarg.0
          loc_5052C2: ldfld GCUv2.frmSettingBranchList::_ToolStrip1
          loc_5052C7: br.s loc_5052C9
          loc_5052C9: // Referenced from: loc_5052C7
          loc_5052C9: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_5052CB: ldarg.0
          loc_5052CC: ldarg.1
          loc_5052CD: stfld GCUv2.frmSettingBranchList::_ToolStrip1
          loc_5052D2: ret
        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_5052D4: ldarg.0
          loc_5052D5: ldfld GCUv2.frmSettingBranchList::_tsbNew
          loc_5052DA: br.s loc_5052DC
          loc_5052DC: // Referenced from: loc_5052DA
          loc_5052DC: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class CheckBox get_chkAll() {

          loc_505324: ldarg.0
          loc_505325: ldfld GCUv2.frmSettingBranchList::_chkAll
          loc_50532A: br.s loc_50532C
          loc_50532C: // Referenced from: loc_50532A
          loc_50532C: ret
        }

        assem override strict specialname void set_chkAll(class CheckBox WithEventsValue) {

          class System.EventHandler var_1;
          class CheckBox var_2;

        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_505374: ldarg.0
          loc_505375: ldfld GCUv2.frmSettingBranchList::_tsbRefresh
          loc_50537A: br.s loc_50537C
          loc_50537C: // Referenced from: loc_50537A
          loc_50537C: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        public void frmSettingBranchList() {


        }

        private void frmSettingBranchList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void frmSettingBranchList_Load(object sender, class System.EventArgs e) {

          loc_50547F: nop
          loc_505480: ldarg.0
          loc_505481: call instance void GCUv2.frmSettingBranchList::getList()
          loc_505486: nop
          loc_505487: ret
        }

        private void FormatGrid() {


        }

        private void chkAll_CheckedChanged(object sender, class System.EventArgs e) {

          loc_50547F: nop
          loc_505480: ldarg.0
          loc_505481: call instance void GCUv2.frmSettingBranchList::getList()
          loc_505486: nop
          loc_505487: ret
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

          loc_50569D: nop
          loc_50569E: ldarg.0
          loc_50569F: call instance void GCUv2.frmSettingBranchList::openSelection()
          loc_5056A4: nop
          loc_5056A5: ret
        }

        private void openSelection() {

          class GCUv2.frmSettingBranchInput var_1;

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

          class GCUv2.frmSettingBranchInput var_1;

        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_50547F: nop
          loc_505480: ldarg.0
          loc_505481: call instance void GCUv2.frmSettingBranchList::getList()
          loc_505486: nop
          loc_505487: ret
        }

    }
}
