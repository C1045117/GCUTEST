using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class ToolStripButton _tsbNew;
        private class Label _lblNote;
        private class ToolStrip _ToolStrip1;
        private class DataGridView _dgvList;
        private class ToolStripButton _tsbRefresh;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {

          class ComponentModel.ComponentResourceManager var_1;

        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_500353: ldarg.0
          loc_500354: ldfld GCUv2.frmSalesReturnList::_tsbNew
          loc_500359: br.s loc_50035B
          loc_50035B: // Referenced from: loc_500359
          loc_50035B: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class Label get_lblNote() {

          loc_5003A0: ldarg.0
          loc_5003A1: ldfld GCUv2.frmSalesReturnList::_lblNote
          loc_5003A6: br.s loc_5003A8
          loc_5003A8: // Referenced from: loc_5003A6
          loc_5003A8: ret
        }

        assem override strict specialname void set_lblNote(class Label WithEventsValue) {

          loc_5003AA: ldarg.0
          loc_5003AB: ldarg.1
          loc_5003AC: stfld GCUv2.frmSalesReturnList::_lblNote
          loc_5003B1: ret
        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_5003B3: ldarg.0
          loc_5003B4: ldfld GCUv2.frmSalesReturnList::_ToolStrip1
          loc_5003B9: br.s loc_5003BB
          loc_5003BB: // Referenced from: loc_5003B9
          loc_5003BB: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_5003BD: ldarg.0
          loc_5003BE: ldarg.1
          loc_5003BF: stfld GCUv2.frmSalesReturnList::_ToolStrip1
          loc_5003C4: ret
        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_5003C6: ldarg.0
          loc_5003C7: ldfld GCUv2.frmSalesReturnList::_dgvList
          loc_5003CC: br.s loc_5003CE
          loc_5003CE: // Referenced from: loc_5003CC
          loc_5003CE: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class KeyEventHandler var_1;
          class System.EventHandler var_2;
          class DataGridView var_3;

        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_50042F: ldarg.0
          loc_500430: ldfld GCUv2.frmSalesReturnList::_tsbRefresh
          loc_500435: br.s loc_500437
          loc_500437: // Referenced from: loc_500435
          loc_500437: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        public void frmSalesReturnList() {


        }

        private void frmSalesReturnList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        public void GetRecent() {

          int32 num_1;
          int32 num_2;
          class DataTable var_1;
          valuetype System.DateTime var_2;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          boolean var_5;

        }

        private void FormatGrid() {


        }

        private void dgvList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;

        }

        private void dgvList_DoubleClick(object sender, class System.EventArgs e) {

          loc_50096B: nop
          loc_50096C: ldarg.0
          loc_50096D: call instance void GCUv2.frmSalesReturnList::openSelection()
          loc_500972: nop
          loc_500973: ret
        }

        private void openSelection() {

          boolean var_1;

        }

        private void tsbNew_Click(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_500AB0: nop
          loc_500AB1: ldarg.0
          loc_500AB2: call instance void GCUv2.frmSalesReturnList::GetRecent()
          loc_500AB7: nop
          loc_500AB8: ret
        }

    }
}
