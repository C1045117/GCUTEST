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

          loc_49EB2B: ldarg.0
          loc_49EB2C: ldfld GCUv2.frmSalesReceiptList::_ToolStrip1
          loc_49EB31: br.s loc_49EB33
          loc_49EB33: // Referenced from: loc_49EB31
          loc_49EB33: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_49EB35: ldarg.0
          loc_49EB36: ldarg.1
          loc_49EB37: stfld GCUv2.frmSalesReceiptList::_ToolStrip1
          loc_49EB3C: ret
        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_49EB3E: ldarg.0
          loc_49EB3F: ldfld GCUv2.frmSalesReceiptList::_tsbNew
          loc_49EB44: br.s loc_49EB46
          loc_49EB46: // Referenced from: loc_49EB44
          loc_49EB46: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class Label get_lblTitle() {

          loc_49EB8C: ldarg.0
          loc_49EB8D: ldfld GCUv2.frmSalesReceiptList::_lblTitle
          loc_49EB92: br.s loc_49EB94
          loc_49EB94: // Referenced from: loc_49EB92
          loc_49EB94: ret
        }

        assem override strict specialname void set_lblTitle(class Label WithEventsValue) {

          loc_49EB96: ldarg.0
          loc_49EB97: ldarg.1
          loc_49EB98: stfld GCUv2.frmSalesReceiptList::_lblTitle
          loc_49EB9D: ret
        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_49EB9F: ldarg.0
          loc_49EBA0: ldfld GCUv2.frmSalesReceiptList::_dgvList
          loc_49EBA5: br.s loc_49EBA7
          loc_49EBA7: // Referenced from: loc_49EBA5
          loc_49EBA7: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class KeyEventHandler var_1;
          class System.EventHandler var_2;
          class DataGridView var_3;

        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_49EC07: ldarg.0
          loc_49EC08: ldfld GCUv2.frmSalesReceiptList::_tsbRefresh
          loc_49EC0D: br.s loc_49EC0F
          loc_49EC0F: // Referenced from: loc_49EC0D
          loc_49EC0F: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        public void frmSalesReceiptList() {


        }

        private void frmSalesReciptList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        public void GetRecent() {

          int32 num_1;
          int32 num_2;
          class DataTable var_1;
          string str_1;
          class System.Collections.IEnumerator var_2;
          class DataRow var_3;
          boolean var_4;

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

          loc_49F253: nop
          loc_49F254: ldarg.0
          loc_49F255: call instance void GCUv2.frmSalesReceiptList::openSelection()
          loc_49F25A: nop
          loc_49F25B: ret
        }

        private void openSelection() {

          boolean var_1;

        }

        private void tsbNew_Click(object sender, class System.EventArgs e) {

          loc_49F33A: nop
          loc_49F33B: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_49F340: callvirt instance class GCUv2.frmSalesReceipt GCUv2.frmSalesReceiptList/MyForms::get_frmSalesReceipt()
          loc_49F345: callvirt instance void System.Windows.Forms.Control::Show()
          loc_49F34A: nop
          loc_49F34B: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_49F350: callvirt instance class GCUv2.frmSalesReceipt GCUv2.frmSalesReceiptList/MyForms::get_frmSalesReceipt()
          loc_49F355: ldc.i4.0
          loc_49F356: callvirt instance void GCUv2.frmSalesReceipt::prepareForm(boolean)
          loc_49F35B: nop
          loc_49F35C: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_49F361: callvirt instance class GCUv2.frmSalesReceipt GCUv2.frmSalesReceiptList/MyForms::get_frmSalesReceipt()
          loc_49F366: callvirt instance void System.Windows.Forms.Form::Activate()
          loc_49F36B: nop
          loc_49F36C: ret
        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_49F36E: nop
          loc_49F36F: ldarg.0
          loc_49F370: call instance void GCUv2.frmSalesReceiptList::GetRecent()
          loc_49F375: nop
          loc_49F376: ret
        }

    }
}
