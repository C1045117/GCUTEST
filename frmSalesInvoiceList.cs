using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Label _lblNote;
        private class ToolStrip _ToolStrip1;
        private class ToolStripButton _tsbNew;
        private class DataGridView _dgvList;
        private class ToolStripButton _tsbRefresh;
        private class ComponentModel.BackgroundWorker _BackgroundWorker1;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {

          class ComponentModel.ComponentResourceManager var_1;

        }

        assem override strict specialname class Label get_lblNote() {

          loc_4DCA59: ldarg.0
          loc_4DCA5A: ldfld GCUv2.frmSalesInvoiceList::_lblNote
          loc_4DCA5F: br.s loc_4DCA61
          loc_4DCA61: // Referenced from: loc_4DCA5F
          loc_4DCA61: ret
        }

        assem override strict specialname void set_lblNote(class Label WithEventsValue) {

          loc_4DCA63: ldarg.0
          loc_4DCA64: ldarg.1
          loc_4DCA65: stfld GCUv2.frmSalesInvoiceList::_lblNote
          loc_4DCA6A: ret
        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_4DCA6C: ldarg.0
          loc_4DCA6D: ldfld GCUv2.frmSalesInvoiceList::_ToolStrip1
          loc_4DCA72: br.s loc_4DCA74
          loc_4DCA74: // Referenced from: loc_4DCA72
          loc_4DCA74: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_4DCA76: ldarg.0
          loc_4DCA77: ldarg.1
          loc_4DCA78: stfld GCUv2.frmSalesInvoiceList::_ToolStrip1
          loc_4DCA7D: ret
        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_4DCA7F: ldarg.0
          loc_4DCA80: ldfld GCUv2.frmSalesInvoiceList::_tsbNew
          loc_4DCA85: br.s loc_4DCA87
          loc_4DCA87: // Referenced from: loc_4DCA85
          loc_4DCA87: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_4DCACC: ldarg.0
          loc_4DCACD: ldfld GCUv2.frmSalesInvoiceList::_dgvList
          loc_4DCAD2: br.s loc_4DCAD4
          loc_4DCAD4: // Referenced from: loc_4DCAD2
          loc_4DCAD4: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class KeyEventHandler var_1;
          class System.EventHandler var_2;
          class DataGridView var_3;

        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_4DCB37: ldarg.0
          loc_4DCB38: ldfld GCUv2.frmSalesInvoiceList::_tsbRefresh
          loc_4DCB3D: br.s loc_4DCB3F
          loc_4DCB3F: // Referenced from: loc_4DCB3D
          loc_4DCB3F: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class ComponentModel.BackgroundWorker get_BackgroundWorker1() {

          loc_4DCB84: ldarg.0
          loc_4DCB85: ldfld GCUv2.frmSalesInvoiceList::_BackgroundWorker1
          loc_4DCB8A: br.s loc_4DCB8C
          loc_4DCB8C: // Referenced from: loc_4DCB8A
          loc_4DCB8C: ret
        }

        assem override strict specialname void set_BackgroundWorker1(class ComponentModel.BackgroundWorker WithEventsValue) {

          class ComponentModel.DoWorkEventHandler var_1;
          class ComponentModel.ProgressChangedEventHandler var_2;
          class ComponentModel.RunWorkerCompletedEventHandler var_3;
          class ComponentModel.BackgroundWorker var_4;

        }

        public void frmSalesInvoiceList() {


        }

        private void frmSalesInvoiceList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        public void GetRecent() {

          int32 num_1;
          int32 num_2;
          boolean var_1;

        }

        private void BackgroundWorker1_DoWork(object sender, class ComponentModel.DoWorkEventArgs e) {

          class DataTable var_1;
          valuetype System.DateTime var_2;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          boolean var_5;

        }

        private void BackgroundWorker1_ProgressChanged(object sender, class ComponentModel.ProgressChangedEventArgs e) {

          int32 num_1;
          int32 num_2;
          int32 num_3;
          class DataRow var_1;

        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, class ComponentModel.RunWorkerCompletedEventArgs e) {

          loc_4DCF65: nop
          loc_4DCF66: ldarg.0
          loc_4DCF67: callvirt instance class Label GCUv2.frmSalesInvoiceList::get_lblNote()
          loc_4DCF6C: ldstr "Faktur Penjualan terbaru ("
          loc_4DCF71: call valuetype System.DateTime Microsoft.VisualBasic.DateAndTime::get_Now()
          loc_4DCF76: call string Microsoft.VisualBasic.CompilerServices.Conversions::ToString(valuetype System.DateTime)
          loc_4DCF7B: ldstr ")"
          loc_4DCF80: call string System.String::Concat(string, string, string)
          loc_4DCF85: callvirt instance void System.Windows.Forms.Label::set_Text(string)
          loc_4DCF8A: nop
          loc_4DCF8B: ret
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

          loc_4DD1D7: nop
          loc_4DD1D8: ldarg.0
          loc_4DD1D9: call instance void GCUv2.frmSalesInvoiceList::openSelection()
          loc_4DD1DE: nop
          loc_4DD1DF: ret
        }

        private void openSelection() {

          boolean var_1;

        }

        private void tsbNew_Click(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_4DD31C: nop
          loc_4DD31D: ldarg.0
          loc_4DD31E: call instance void GCUv2.frmSalesInvoiceList::GetRecent()
          loc_4DD323: nop
          loc_4DD324: ret
        }

    }
}
