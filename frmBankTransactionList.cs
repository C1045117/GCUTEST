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

          loc_431363: ldarg.0
          loc_431364: ldfld GCUv2.frmBankTransactionList::_lblTitle
          loc_431369: br.s loc_43136B
          loc_43136B: // Referenced from: loc_431369
          loc_43136B: ret
        }

        assem override strict specialname void set_lblTitle(class Label WithEventsValue) {

          loc_43136D: ldarg.0
          loc_43136E: ldarg.1
          loc_43136F: stfld GCUv2.frmBankTransactionList::_lblTitle
          loc_431374: ret
        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_431376: ldarg.0
          loc_431377: ldfld GCUv2.frmBankTransactionList::_dgvList
          loc_43137C: br.s loc_43137E
          loc_43137E: // Referenced from: loc_43137C
          loc_43137E: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class KeyEventHandler var_1;
          class System.EventHandler var_2;
          class DataGridView var_3;

        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_4313DF: ldarg.0
          loc_4313E0: ldfld GCUv2.frmBankTransactionList::_ToolStrip1
          loc_4313E5: br.s loc_4313E7
          loc_4313E7: // Referenced from: loc_4313E5
          loc_4313E7: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_4313E9: ldarg.0
          loc_4313EA: ldarg.1
          loc_4313EB: stfld GCUv2.frmBankTransactionList::_ToolStrip1
          loc_4313F0: ret
        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_4313F2: ldarg.0
          loc_4313F3: ldfld GCUv2.frmBankTransactionList::_tsbNew
          loc_4313F8: br.s loc_4313FA
          loc_4313FA: // Referenced from: loc_4313F8
          loc_4313FA: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_431440: ldarg.0
          loc_431441: ldfld GCUv2.frmBankTransactionList::_tsbRefresh
          loc_431446: br.s loc_431448
          loc_431448: // Referenced from: loc_431446
          loc_431448: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        public void frmBankTransactionList() {


        }

        private void frmBankTransactionList_KeyDown(object sender, class KeyEventArgs e) {

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

        private void dgvList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;

        }

        private void dgvList_DoubleClick(object sender, class System.EventArgs e) {

          loc_431A2B: nop
          loc_431A2C: ldarg.0
          loc_431A2D: call instance void GCUv2.frmBankTransactionList::openSelection()
          loc_431A32: nop
          loc_431A33: ret
        }

        private void openSelection() {

          boolean var_1;

        }

        private void tsbNew_Click(object sender, class System.EventArgs e) {

          loc_431B12: nop
          loc_431B13: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_431B18: callvirt instance class GCUv2.frmBankTransaction GCUv2.frmBankTransactionList/MyForms::get_frmBankTransaction()
          loc_431B1D: callvirt instance void System.Windows.Forms.Control::Show()
          loc_431B22: nop
          loc_431B23: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_431B28: callvirt instance class GCUv2.frmBankTransaction GCUv2.frmBankTransactionList/MyForms::get_frmBankTransaction()
          loc_431B2D: ldc.i4.0
          loc_431B2E: callvirt instance void GCUv2.frmBankTransaction::prepareForm(boolean)
          loc_431B33: nop
          loc_431B34: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_431B39: callvirt instance class GCUv2.frmBankTransaction GCUv2.frmBankTransactionList/MyForms::get_frmBankTransaction()
          loc_431B3E: callvirt instance void System.Windows.Forms.Form::Activate()
          loc_431B43: nop
          loc_431B44: ret
        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_431B46: nop
          loc_431B47: ldarg.0
          loc_431B48: call instance void GCUv2.frmBankTransactionList::GetRecent()
          loc_431B4D: nop
          loc_431B4E: ret
        }

    }
}
