using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class ToolStrip _ToolStrip1;
        private class ToolStripButton _tsbNew;
        private class Label _lblTitle;
        private class DataGridView _dgvList;
        private class ToolStripButton _tsbRefresh;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {

          class ComponentModel.ComponentResourceManager var_1;

        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_52E7C2: ldarg.0
          loc_52E7C3: ldfld GCUv2.frmPurchaseInvoiceList::_ToolStrip1
          loc_52E7C8: br.s loc_52E7CA
          loc_52E7CA: // Referenced from: loc_52E7C8
          loc_52E7CA: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_52E7CC: ldarg.0
          loc_52E7CD: ldarg.1
          loc_52E7CE: stfld GCUv2.frmPurchaseInvoiceList::_ToolStrip1
          loc_52E7D3: ret
        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_52E7D5: ldarg.0
          loc_52E7D6: ldfld GCUv2.frmPurchaseInvoiceList::_tsbNew
          loc_52E7DB: br.s loc_52E7DD
          loc_52E7DD: // Referenced from: loc_52E7DB
          loc_52E7DD: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class Label get_lblTitle() {

          loc_52E824: ldarg.0
          loc_52E825: ldfld GCUv2.frmPurchaseInvoiceList::_lblTitle
          loc_52E82A: br.s loc_52E82C
          loc_52E82C: // Referenced from: loc_52E82A
          loc_52E82C: ret
        }

        assem override strict specialname void set_lblTitle(class Label WithEventsValue) {

          loc_52E82E: ldarg.0
          loc_52E82F: ldarg.1
          loc_52E830: stfld GCUv2.frmPurchaseInvoiceList::_lblTitle
          loc_52E835: ret
        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_52E837: ldarg.0
          loc_52E838: ldfld GCUv2.frmPurchaseInvoiceList::_dgvList
          loc_52E83D: br.s loc_52E83F
          loc_52E83F: // Referenced from: loc_52E83D
          loc_52E83F: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class KeyEventHandler var_1;
          class System.EventHandler var_2;
          class DataGridView var_3;

        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_52E89F: ldarg.0
          loc_52E8A0: ldfld GCUv2.frmPurchaseInvoiceList::_tsbRefresh
          loc_52E8A5: br.s loc_52E8A7
          loc_52E8A7: // Referenced from: loc_52E8A5
          loc_52E8A7: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        private void frmPurchaseInvoiceList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        public void frmPurchaseInvoiceList() {


        }

        private void frmPurchaseInvoiceList_Load(object sender, class System.EventArgs e) {

          loc_52E9A0: nop
          loc_52E9A1: ldarg.0
          loc_52E9A2: call instance void GCUv2.frmPurchaseInvoiceList::GetRecent()
          loc_52E9A7: nop
          loc_52E9A8: ret
        }

        public void GetRecent() {

          int32 num_1;
          int32 num_2;
          class DataTable var_1;
          class DataTable var_2;
          boolean var_3;
          class System.Collections.IEnumerator var_4;
          class DataRow var_5;
          boolean var_6;

        }

        private void FormatGrid() {


        }

        private void tsbNew_Click(object sender, class System.EventArgs e) {

          loc_52ED61: nop
          loc_52ED62: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_52ED67: callvirt instance class GCUv2.frmPurchaseInvoice GCUv2.frmPurchaseInvoiceList/MyForms::get_frmPurchaseInvoice()
          loc_52ED6C: callvirt instance void System.Windows.Forms.Control::Show()
          loc_52ED71: nop
          loc_52ED72: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_52ED77: callvirt instance class GCUv2.frmPurchaseInvoice GCUv2.frmPurchaseInvoiceList/MyForms::get_frmPurchaseInvoice()
          loc_52ED7C: ldc.i4.0
          loc_52ED7D: ldc.i4.0
          loc_52ED7E: callvirt instance void GCUv2.frmPurchaseInvoice::prepareForm(boolean, boolean)
          loc_52ED83: nop
          loc_52ED84: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_52ED89: callvirt instance class GCUv2.frmPurchaseInvoice GCUv2.frmPurchaseInvoiceList/MyForms::get_frmPurchaseInvoice()
          loc_52ED8E: callvirt instance void System.Windows.Forms.Form::Activate()
          loc_52ED93: nop
          loc_52ED94: ret
        }

        private void dgvList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;

        }

        private void dgvList_DoubleClick(object sender, class System.EventArgs e) {

          loc_52EE17: nop
          loc_52EE18: ldarg.0
          loc_52EE19: call instance void GCUv2.frmPurchaseInvoiceList::openSelection()
          loc_52EE1E: nop
          loc_52EE1F: ret
        }

        private void openSelection() {

          boolean var_1;

        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_52E9A0: nop
          loc_52E9A1: ldarg.0
          loc_52E9A2: call instance void GCUv2.frmPurchaseInvoiceList::GetRecent()
          loc_52E9A7: nop
          loc_52E9A8: ret
        }

    }
}
