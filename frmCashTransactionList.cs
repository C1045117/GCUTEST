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
        private class ComponentModel.BackgroundWorker _BackgroundWorker1;
        private class ToolStripButton _tsbRefresh;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {

          class ComponentModel.ComponentResourceManager var_1;

        }

        assem override strict specialname class Label get_lblTitle() {

          loc_434389: ldarg.0
          loc_43438A: ldfld GCUv2.frmCashTransactionList::_lblTitle
          loc_43438F: br.s loc_434391
          loc_434391: // Referenced from: loc_43438F
          loc_434391: ret
        }

        assem override strict specialname void set_lblTitle(class Label WithEventsValue) {

          loc_434393: ldarg.0
          loc_434394: ldarg.1
          loc_434395: stfld GCUv2.frmCashTransactionList::_lblTitle
          loc_43439A: ret
        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_43439C: ldarg.0
          loc_43439D: ldfld GCUv2.frmCashTransactionList::_tsbNew
          loc_4343A2: br.s loc_4343A4
          loc_4343A4: // Referenced from: loc_4343A2
          loc_4343A4: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_4343EC: ldarg.0
          loc_4343ED: ldfld GCUv2.frmCashTransactionList::_dgvList
          loc_4343F2: br.s loc_4343F4
          loc_4343F4: // Referenced from: loc_4343F2
          loc_4343F4: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class KeyEventHandler var_1;
          class System.EventHandler var_2;
          class DataGridView var_3;

        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_434457: ldarg.0
          loc_434458: ldfld GCUv2.frmCashTransactionList::_ToolStrip1
          loc_43445D: br.s loc_43445F
          loc_43445F: // Referenced from: loc_43445D
          loc_43445F: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_434461: ldarg.0
          loc_434462: ldarg.1
          loc_434463: stfld GCUv2.frmCashTransactionList::_ToolStrip1
          loc_434468: ret
        }

        assem override strict specialname class ComponentModel.BackgroundWorker get_BackgroundWorker1() {

          loc_43446A: ldarg.0
          loc_43446B: ldfld GCUv2.frmCashTransactionList::_BackgroundWorker1
          loc_434470: br.s loc_434472
          loc_434472: // Referenced from: loc_434470
          loc_434472: ret
        }

        assem override strict specialname void set_BackgroundWorker1(class ComponentModel.BackgroundWorker WithEventsValue) {

          class ComponentModel.DoWorkEventHandler var_1;
          class ComponentModel.ProgressChangedEventHandler var_2;
          class ComponentModel.RunWorkerCompletedEventHandler var_3;
          class ComponentModel.BackgroundWorker var_4;

        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_4344EE: ldarg.0
          loc_4344EF: ldfld GCUv2.frmCashTransactionList::_tsbRefresh
          loc_4344F4: br.s loc_4344F6
          loc_4344F6: // Referenced from: loc_4344F4
          loc_4344F6: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        public void frmCashTransactionList() {


        }

        private void frmCashTransactionList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void frmCashTransactionList_Load(object sender, class System.EventArgs e) {

          loc_434607: nop
          loc_434608: ldarg.0
          loc_434609: callvirt instance class DataGridView GCUv2.frmCashTransactionList::get_dgvList()
          loc_43460E: ldc.i4.1
          loc_43460F: call void GCUv2.ExtensionMethods::DoubleBuffered(class DataGridView, boolean)
          loc_434614: nop
          loc_434615: ret
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

          loc_434935: nop
          loc_434936: ldarg.0
          loc_434937: callvirt instance class Label GCUv2.frmCashTransactionList::get_lblTitle()
          loc_43493C: ldstr "Transaksi Kas terbaru ("
          loc_434941: call valuetype System.DateTime Microsoft.VisualBasic.DateAndTime::get_Now()
          loc_434946: call string Microsoft.VisualBasic.CompilerServices.Conversions::ToString(valuetype System.DateTime)
          loc_43494B: ldstr ")"
          loc_434950: call string System.String::Concat(string, string, string)
          loc_434955: callvirt instance void System.Windows.Forms.Label::set_Text(string)
          loc_43495A: nop
          loc_43495B: ret
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

          loc_434C47: nop
          loc_434C48: ldarg.0
          loc_434C49: call instance void GCUv2.frmCashTransactionList::openSelection()
          loc_434C4E: nop
          loc_434C4F: ret
        }

        private void openSelection() {

          boolean var_1;

        }

        private void tsbNew_Click(object sender, class System.EventArgs e) {

          loc_434D2E: nop
          loc_434D2F: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_434D34: callvirt instance class GCUv2.frmCashTransaction GCUv2.frmCashTransactionList/MyForms::get_frmCashTransaction()
          loc_434D39: callvirt instance void System.Windows.Forms.Control::Show()
          loc_434D3E: nop
          loc_434D3F: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_434D44: callvirt instance class GCUv2.frmCashTransaction GCUv2.frmCashTransactionList/MyForms::get_frmCashTransaction()
          loc_434D49: ldc.i4.0
          loc_434D4A: callvirt instance void GCUv2.frmCashTransaction::prepareForm(boolean)
          loc_434D4F: nop
          loc_434D50: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_434D55: callvirt instance class GCUv2.frmCashTransaction GCUv2.frmCashTransactionList/MyForms::get_frmCashTransaction()
          loc_434D5A: callvirt instance void System.Windows.Forms.Form::Activate()
          loc_434D5F: nop
          loc_434D60: ret
        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_434D62: nop
          loc_434D63: ldarg.0
          loc_434D64: call instance void GCUv2.frmCashTransactionList::GetRecent()
          loc_434D69: nop
          loc_434D6A: ret
        }

    }
}
