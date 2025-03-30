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

          loc_454017: ldarg.0
          loc_454018: ldfld GCUv2.frmJournalTransactionList::_lblTitle
          loc_45401D: br.s loc_45401F
          loc_45401F: // Referenced from: loc_45401D
          loc_45401F: ret
        }

        assem override strict specialname void set_lblTitle(class Label WithEventsValue) {

          loc_454021: ldarg.0
          loc_454022: ldarg.1
          loc_454023: stfld GCUv2.frmJournalTransactionList::_lblTitle
          loc_454028: ret
        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_45402A: ldarg.0
          loc_45402B: ldfld GCUv2.frmJournalTransactionList::_tsbNew
          loc_454030: br.s loc_454032
          loc_454032: // Referenced from: loc_454030
          loc_454032: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_454078: ldarg.0
          loc_454079: ldfld GCUv2.frmJournalTransactionList::_dgvList
          loc_45407E: br.s loc_454080
          loc_454080: // Referenced from: loc_45407E
          loc_454080: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class KeyEventHandler var_1;
          class System.EventHandler var_2;
          class DataGridView var_3;

        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_4540E3: ldarg.0
          loc_4540E4: ldfld GCUv2.frmJournalTransactionList::_ToolStrip1
          loc_4540E9: br.s loc_4540EB
          loc_4540EB: // Referenced from: loc_4540E9
          loc_4540EB: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_4540ED: ldarg.0
          loc_4540EE: ldarg.1
          loc_4540EF: stfld GCUv2.frmJournalTransactionList::_ToolStrip1
          loc_4540F4: ret
        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_4540F6: ldarg.0
          loc_4540F7: ldfld GCUv2.frmJournalTransactionList::_tsbRefresh
          loc_4540FC: br.s loc_4540FE
          loc_4540FE: // Referenced from: loc_4540FC
          loc_4540FE: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        public void frmJournalTransactionList() {


        }

        private void frmJournalTransactionList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        public void GetRecent() {

          int32 num_1;
          int32 num_2;
          class DataTable var_1;
          class DataTable var_2;
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

          loc_45476F: nop
          loc_454770: ldarg.0
          loc_454771: call instance void GCUv2.frmJournalTransactionList::openSelection()
          loc_454776: nop
          loc_454777: ret
        }

        private void openSelection() {

          boolean var_1;

        }

        private void tsbNew_Click(object sender, class System.EventArgs e) {

          loc_454856: nop
          loc_454857: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_45485C: callvirt instance class GCUv2.frmJournalTransaction GCUv2.frmJournalTransactionList/MyForms::get_frmJournalTransaction()
          loc_454861: callvirt instance void System.Windows.Forms.Control::Show()
          loc_454866: nop
          loc_454867: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_45486C: callvirt instance class GCUv2.frmJournalTransaction GCUv2.frmJournalTransactionList/MyForms::get_frmJournalTransaction()
          loc_454871: ldc.i4.0
          loc_454872: callvirt instance void GCUv2.frmJournalTransaction::prepareForm(boolean)
          loc_454877: nop
          loc_454878: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_45487D: callvirt instance class GCUv2.frmJournalTransaction GCUv2.frmJournalTransactionList/MyForms::get_frmJournalTransaction()
          loc_454882: callvirt instance void System.Windows.Forms.Form::Activate()
          loc_454887: nop
          loc_454888: ret
        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_45488A: nop
          loc_45488B: ldarg.0
          loc_45488C: call instance void GCUv2.frmJournalTransactionList::GetRecent()
          loc_454891: nop
          loc_454892: ret
        }

    }
}
