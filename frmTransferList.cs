using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class ToolStrip _ToolStrip1;
        private class ToolStripButton _tsbNew;
        private class DataGridView _dgvList;
        private class Label _lblTitle;
        private class ToolStripButton _tsbRefresh;
        private class ComponentModel.BackgroundWorker _BackgroundWorker1;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {

          class ComponentModel.ComponentResourceManager var_1;

        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_54700E: ldarg.0
          loc_54700F: ldfld GCUv2.frmTransferList::_ToolStrip1
          loc_547014: br.s loc_547016
          loc_547016: // Referenced from: loc_547014
          loc_547016: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_547018: ldarg.0
          loc_547019: ldarg.1
          loc_54701A: stfld GCUv2.frmTransferList::_ToolStrip1
          loc_54701F: ret
        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_547021: ldarg.0
          loc_547022: ldfld GCUv2.frmTransferList::_tsbNew
          loc_547027: br.s loc_547029
          loc_547029: // Referenced from: loc_547027
          loc_547029: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_547070: ldarg.0
          loc_547071: ldfld GCUv2.frmTransferList::_dgvList
          loc_547076: br.s loc_547078
          loc_547078: // Referenced from: loc_547076
          loc_547078: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class KeyEventHandler var_1;
          class System.EventHandler var_2;
          class DataGridView var_3;

        }

        assem override strict specialname class Label get_lblTitle() {

          loc_5470DB: ldarg.0
          loc_5470DC: ldfld GCUv2.frmTransferList::_lblTitle
          loc_5470E1: br.s loc_5470E3
          loc_5470E3: // Referenced from: loc_5470E1
          loc_5470E3: ret
        }

        assem override strict specialname void set_lblTitle(class Label WithEventsValue) {

          loc_5470E5: ldarg.0
          loc_5470E6: ldarg.1
          loc_5470E7: stfld GCUv2.frmTransferList::_lblTitle
          loc_5470EC: ret
        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_5470EE: ldarg.0
          loc_5470EF: ldfld GCUv2.frmTransferList::_tsbRefresh
          loc_5470F4: br.s loc_5470F6
          loc_5470F6: // Referenced from: loc_5470F4
          loc_5470F6: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class ComponentModel.BackgroundWorker get_BackgroundWorker1() {

          loc_54713C: ldarg.0
          loc_54713D: ldfld GCUv2.frmTransferList::_BackgroundWorker1
          loc_547142: br.s loc_547144
          loc_547144: // Referenced from: loc_547142
          loc_547144: ret
        }

        assem override strict specialname void set_BackgroundWorker1(class ComponentModel.BackgroundWorker WithEventsValue) {

          class ComponentModel.DoWorkEventHandler var_1;
          class ComponentModel.ProgressChangedEventHandler var_2;
          class ComponentModel.RunWorkerCompletedEventHandler var_3;
          class ComponentModel.BackgroundWorker var_4;

        }

        public void frmTransferList() {


        }

        private void tsbAdd_Click(object sender, class System.EventArgs e) {

          loc_54722E: nop
          loc_54722F: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_547234: callvirt instance class GCUv2.frmTransfer GCUv2.frmTransferList/MyForms::get_frmTransfer()
          loc_547239: callvirt instance void System.Windows.Forms.Control::Show()
          loc_54723E: nop
          loc_54723F: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_547244: callvirt instance class GCUv2.frmTransfer GCUv2.frmTransferList/MyForms::get_frmTransfer()
          loc_547249: ldc.i4.0
          loc_54724A: callvirt instance void GCUv2.frmTransfer::prepareForm(boolean)
          loc_54724F: nop
          loc_547250: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_547255: callvirt instance class GCUv2.frmTransfer GCUv2.frmTransferList/MyForms::get_frmTransfer()
          loc_54725A: callvirt instance void System.Windows.Forms.Form::Activate()
          loc_54725F: nop
          loc_547260: ret
        }

        private void dgvList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;

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

          loc_547581: nop
          loc_547582: ldarg.0
          loc_547583: callvirt instance class Label GCUv2.frmTransferList::get_lblTitle()
          loc_547588: ldstr "Transfer terbaru ("
          loc_54758D: call valuetype System.DateTime Microsoft.VisualBasic.DateAndTime::get_Now()
          loc_547592: call string Microsoft.VisualBasic.CompilerServices.Conversions::ToString(valuetype System.DateTime)
          loc_547597: ldstr ")"
          loc_54759C: call string System.String::Concat(string, string, string)
          loc_5475A1: callvirt instance void System.Windows.Forms.Label::set_Text(string)
          loc_5475A6: nop
          loc_5475A7: ret
        }

        private void FormatGrid() {


        }

        private void frmTransferList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void frmTransferList_Load(object sender, class System.EventArgs e) {

          loc_547857: nop
          loc_547858: ldarg.0
          loc_547859: call instance void GCUv2.frmTransferList::GetRecent()
          loc_54785E: nop
          loc_54785F: ret
        }

        private void dgvList_DoubleClick(object sender, class System.EventArgs e) {

          loc_547861: nop
          loc_547862: ldarg.0
          loc_547863: call instance void GCUv2.frmTransferList::openSelection()
          loc_547868: nop
          loc_547869: ret
        }

        private void openSelection() {

          boolean var_1;

        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_547857: nop
          loc_547858: ldarg.0
          loc_547859: call instance void GCUv2.frmTransferList::GetRecent()
          loc_54785E: nop
          loc_54785F: ret
        }

    }
}
