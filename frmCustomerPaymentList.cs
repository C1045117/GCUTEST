using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Label _lblTitle;
        private class ToolStripButton _tsbNew;
        private class DataGridView _dgvList;
        private class ToolStrip _ToolStrip1;
        private class ToolStripButton _tsbRefresh;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {

          class ComponentModel.ComponentResourceManager var_1;

        }

        assem override strict specialname class Label get_lblTitle() {

          loc_445DF7: ldarg.0
          loc_445DF8: ldfld GCUv2.frmCustomerPaymentList::_lblTitle
          loc_445DFD: br.s loc_445DFF
          loc_445DFF: // Referenced from: loc_445DFD
          loc_445DFF: ret
        }

        assem override strict specialname void set_lblTitle(class Label WithEventsValue) {

          loc_445E01: ldarg.0
          loc_445E02: ldarg.1
          loc_445E03: stfld GCUv2.frmCustomerPaymentList::_lblTitle
          loc_445E08: ret
        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_445E0A: ldarg.0
          loc_445E0B: ldfld GCUv2.frmCustomerPaymentList::_tsbNew
          loc_445E10: br.s loc_445E12
          loc_445E12: // Referenced from: loc_445E10
          loc_445E12: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_445E58: ldarg.0
          loc_445E59: ldfld GCUv2.frmCustomerPaymentList::_dgvList
          loc_445E5E: br.s loc_445E60
          loc_445E60: // Referenced from: loc_445E5E
          loc_445E60: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class KeyEventHandler var_1;
          class System.EventHandler var_2;
          class DataGridView var_3;

        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_445EC3: ldarg.0
          loc_445EC4: ldfld GCUv2.frmCustomerPaymentList::_ToolStrip1
          loc_445EC9: br.s loc_445ECB
          loc_445ECB: // Referenced from: loc_445EC9
          loc_445ECB: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_445ECD: ldarg.0
          loc_445ECE: ldarg.1
          loc_445ECF: stfld GCUv2.frmCustomerPaymentList::_ToolStrip1
          loc_445ED4: ret
        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_445ED6: ldarg.0
          loc_445ED7: ldfld GCUv2.frmCustomerPaymentList::_tsbRefresh
          loc_445EDC: br.s loc_445EDE
          loc_445EDE: // Referenced from: loc_445EDC
          loc_445EDE: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        public void frmCustomerPaymentList() {


        }

        private void frmPaymentList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        public void GetRecent() {

          int32 num_1;
          int32 num_2;
          class DataTable var_1;
          class DataTable var_2;
          valuetype System.DateTime var_3;
          class System.Collections.IEnumerator var_4;
          class DataRow var_5;
          boolean var_6;

        }

        private void FormatGrid() {


        }

        private void tsbNew_Click(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;

        }

        private void dgvList_DoubleClick(object sender, class System.EventArgs e) {

          loc_446563: nop
          loc_446564: ldarg.0
          loc_446565: call instance void GCUv2.frmCustomerPaymentList::openSelection()
          loc_44656A: nop
          loc_44656B: ret
        }

        private void openSelection() {

          boolean var_1;
          boolean var_2;

        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_446744: nop
          loc_446745: ldarg.0
          loc_446746: call instance void GCUv2.frmCustomerPaymentList::GetRecent()
          loc_44674B: nop
          loc_44674C: ret
        }

    }
}
