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


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {

          class ComponentModel.ComponentResourceManager var_1;

        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_4F8EF9: ldarg.0
          loc_4F8EFA: ldfld GCUv2.frmSettingSalesPriceCodeList::_tsbRefresh
          loc_4F8EFF: br.s loc_4F8F01
          loc_4F8F01: // Referenced from: loc_4F8EFF
          loc_4F8F01: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_4F8F48: ldarg.0
          loc_4F8F49: ldfld GCUv2.frmSettingSalesPriceCodeList::_dgvList
          loc_4F8F4E: br.s loc_4F8F50
          loc_4F8F50: // Referenced from: loc_4F8F4E
          loc_4F8F50: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class System.EventHandler var_1;
          class KeyEventHandler var_2;
          class System.EventHandler var_3;
          class System.EventHandler var_4;
          class DataGridView var_5;

        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_4F8FF5: ldarg.0
          loc_4F8FF6: ldfld GCUv2.frmSettingSalesPriceCodeList::_tsbNew
          loc_4F8FFB: br.s loc_4F8FFD
          loc_4F8FFD: // Referenced from: loc_4F8FFB
          loc_4F8FFD: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class CheckBox get_chkAll() {

          loc_4F9044: ldarg.0
          loc_4F9045: ldfld GCUv2.frmSettingSalesPriceCodeList::_chkAll
          loc_4F904A: br.s loc_4F904C
          loc_4F904C: // Referenced from: loc_4F904A
          loc_4F904C: ret
        }

        assem override strict specialname void set_chkAll(class CheckBox WithEventsValue) {

          class System.EventHandler var_1;
          class CheckBox var_2;

        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_4F9094: ldarg.0
          loc_4F9095: ldfld GCUv2.frmSettingSalesPriceCodeList::_ToolStrip1
          loc_4F909A: br.s loc_4F909C
          loc_4F909C: // Referenced from: loc_4F909A
          loc_4F909C: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_4F909E: ldarg.0
          loc_4F909F: ldarg.1
          loc_4F90A0: stfld GCUv2.frmSettingSalesPriceCodeList::_ToolStrip1
          loc_4F90A5: ret
        }

        public void frmSettingSalesPriceCodeList() {


        }

        private void frmSettingSalesPriceCodeList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void frmSettingSalesPriceCodeList_Load(object sender, class System.EventArgs e) {

          loc_4F9163: nop
          loc_4F9164: ldarg.0
          loc_4F9165: call instance void GCUv2.frmSettingSalesPriceCodeList::getList()
          loc_4F916A: nop
          loc_4F916B: ret
        }

        private void FormatGrid() {


        }

        private void chkAll_CheckedChanged(object sender, class System.EventArgs e) {

          loc_4F9163: nop
          loc_4F9164: ldarg.0
          loc_4F9165: call instance void GCUv2.frmSettingSalesPriceCodeList::getList()
          loc_4F916A: nop
          loc_4F916B: ret
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

          loc_4F9381: nop
          loc_4F9382: ldarg.0
          loc_4F9383: call instance void GCUv2.frmSettingSalesPriceCodeList::openSelection()
          loc_4F9388: nop
          loc_4F9389: ret
        }

        private void openSelection() {

          class GCUv2.frmSettingSalesPriceCodeInput var_1;

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

          class GCUv2.frmSettingSalesPriceCodeInput var_1;

        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_4F9163: nop
          loc_4F9164: ldarg.0
          loc_4F9165: call instance void GCUv2.frmSettingSalesPriceCodeList::getList()
          loc_4F916A: nop
          loc_4F916B: ret
        }

    }
}
