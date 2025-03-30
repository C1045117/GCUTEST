using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class ToolStrip _ToolStrip1;
        private class ToolStripButton _tsbNew;
        private class ToolStripButton _tsbDelete;
        private class DataGridView _dgvList;
        private class ToolStripButton _tsbRefresh;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {

          class ComponentModel.ComponentResourceManager var_1;

        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_541E18: ldarg.0
          loc_541E19: ldfld GCUv2.frmSettingItemCategoryList::_ToolStrip1
          loc_541E1E: br.s loc_541E20
          loc_541E20: // Referenced from: loc_541E1E
          loc_541E20: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_541E22: ldarg.0
          loc_541E23: ldarg.1
          loc_541E24: stfld GCUv2.frmSettingItemCategoryList::_ToolStrip1
          loc_541E29: ret
        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_541E2B: ldarg.0
          loc_541E2C: ldfld GCUv2.frmSettingItemCategoryList::_tsbNew
          loc_541E31: br.s loc_541E33
          loc_541E33: // Referenced from: loc_541E31
          loc_541E33: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class ToolStripButton get_tsbDelete() {

          loc_541E78: ldarg.0
          loc_541E79: ldfld GCUv2.frmSettingItemCategoryList::_tsbDelete
          loc_541E7E: br.s loc_541E80
          loc_541E80: // Referenced from: loc_541E7E
          loc_541E80: ret
        }

        assem override strict specialname void set_tsbDelete(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_541EC8: ldarg.0
          loc_541EC9: ldfld GCUv2.frmSettingItemCategoryList::_dgvList
          loc_541ECE: br.s loc_541ED0
          loc_541ED0: // Referenced from: loc_541ECE
          loc_541ED0: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class System.EventHandler var_1;
          class KeyEventHandler var_2;
          class DataGridView var_3;

        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_541F33: ldarg.0
          loc_541F34: ldfld GCUv2.frmSettingItemCategoryList::_tsbRefresh
          loc_541F39: br.s loc_541F3B
          loc_541F3B: // Referenced from: loc_541F39
          loc_541F3B: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        public void frmSettingItemCategoryList() {


        }

        private void frmSetItemCategoryList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void frmSetItemCategoryList_Load(object sender, class System.EventArgs e) {

          loc_542033: nop
          loc_542034: ldarg.0
          loc_542035: call instance void GCUv2.frmSettingItemCategoryList::getItemCategory()
          loc_54203A: nop
          loc_54203B: ret
        }

        public void getItemCategory() {

          class DataTable var_1;

        }

        private void dgvList_DoubleClick(object sender, class System.EventArgs e) {

          loc_542104: nop
          loc_542105: ldarg.0
          loc_542106: call instance void GCUv2.frmSettingItemCategoryList::openSelection()
          loc_54210B: nop
          loc_54210C: ret
        }

        private void openSelection() {

          class GCUv2.frmSettingItemCategoryInput var_1;

        }

        private void dgvList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;

        }

        private void ToolStripButton1_Click(object sender, class System.EventArgs e) {

          class GCUv2.frmSettingItemCategoryInput var_1;

        }

        private void tsbDelete_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          string str_1;
          int32 num_2;
          boolean var_1;
          class GCUv2.cItemCategory var_2;
          boolean var_3;

        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_542033: nop
          loc_542034: ldarg.0
          loc_542035: call instance void GCUv2.frmSettingItemCategoryList::getItemCategory()
          loc_54203A: nop
          loc_54203B: ret
        }

    }
}
