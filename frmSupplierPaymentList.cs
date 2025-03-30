using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Label _lblTitle;
        private class DataGridView _dgvList;
        private class ToolStrip _ToolStrip1;
        private class ToolStripButton _tsbNew;
        private class ToolStripButton _tsbRefresh;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {

          class ComponentModel.ComponentResourceManager var_1;

        }

        assem override strict specialname class Label get_lblTitle() {

          loc_51F61B: ldarg.0
          loc_51F61C: ldfld GCUv2.frmSupplierPaymentList::_lblTitle
          loc_51F621: br.s loc_51F623
          loc_51F623: // Referenced from: loc_51F621
          loc_51F623: ret
        }

        assem override strict specialname void set_lblTitle(class Label WithEventsValue) {

          loc_51F625: ldarg.0
          loc_51F626: ldarg.1
          loc_51F627: stfld GCUv2.frmSupplierPaymentList::_lblTitle
          loc_51F62C: ret
        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_51F62E: ldarg.0
          loc_51F62F: ldfld GCUv2.frmSupplierPaymentList::_dgvList
          loc_51F634: br.s loc_51F636
          loc_51F636: // Referenced from: loc_51F634
          loc_51F636: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class KeyEventHandler var_1;
          class System.EventHandler var_2;
          class DataGridView var_3;

        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_51F697: ldarg.0
          loc_51F698: ldfld GCUv2.frmSupplierPaymentList::_ToolStrip1
          loc_51F69D: br.s loc_51F69F
          loc_51F69F: // Referenced from: loc_51F69D
          loc_51F69F: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_51F6A1: ldarg.0
          loc_51F6A2: ldarg.1
          loc_51F6A3: stfld GCUv2.frmSupplierPaymentList::_ToolStrip1
          loc_51F6A8: ret
        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_51F6AA: ldarg.0
          loc_51F6AB: ldfld GCUv2.frmSupplierPaymentList::_tsbNew
          loc_51F6B0: br.s loc_51F6B2
          loc_51F6B2: // Referenced from: loc_51F6B0
          loc_51F6B2: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_51F6F8: ldarg.0
          loc_51F6F9: ldfld GCUv2.frmSupplierPaymentList::_tsbRefresh
          loc_51F6FE: br.s loc_51F700
          loc_51F700: // Referenced from: loc_51F6FE
          loc_51F700: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        public void frmSupplierPaymentList() {


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
          boolean var_3;
          valuetype System.DateTime var_4;
          class System.Collections.IEnumerator var_5;
          class DataRow var_6;
          boolean var_7;

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

          loc_51FD23: nop
          loc_51FD24: ldarg.0
          loc_51FD25: call instance void GCUv2.frmSupplierPaymentList::openSelection()
          loc_51FD2A: nop
          loc_51FD2B: ret
        }

        private void openSelection() {

          boolean var_1;
          boolean var_2;

        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_51FF05: nop
          loc_51FF06: ldarg.0
          loc_51FF07: call instance void GCUv2.frmSupplierPaymentList::GetRecent()
          loc_51FF0C: nop
          loc_51FF0D: ret
        }

    }
}
