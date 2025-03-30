using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Label _lblTitle;
        private class ToolStrip _ToolStrip1;
        private class ToolStripButton _tsbNew;
        private class DataGridView _dgvList;
        private class ToolStripButton _tsbRefresh;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {

          class ComponentModel.ComponentResourceManager var_1;

        }

        assem override strict specialname class Label get_lblTitle() {

          loc_523F0F: ldarg.0
          loc_523F10: ldfld GCUv2.frmProcessList::_lblTitle
          loc_523F15: br.s loc_523F17
          loc_523F17: // Referenced from: loc_523F15
          loc_523F17: ret
        }

        assem override strict specialname void set_lblTitle(class Label WithEventsValue) {

          loc_523F19: ldarg.0
          loc_523F1A: ldarg.1
          loc_523F1B: stfld GCUv2.frmProcessList::_lblTitle
          loc_523F20: ret
        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_523F22: ldarg.0
          loc_523F23: ldfld GCUv2.frmProcessList::_ToolStrip1
          loc_523F28: br.s loc_523F2A
          loc_523F2A: // Referenced from: loc_523F28
          loc_523F2A: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_523F2C: ldarg.0
          loc_523F2D: ldarg.1
          loc_523F2E: stfld GCUv2.frmProcessList::_ToolStrip1
          loc_523F33: ret
        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_523F35: ldarg.0
          loc_523F36: ldfld GCUv2.frmProcessList::_tsbNew
          loc_523F3B: br.s loc_523F3D
          loc_523F3D: // Referenced from: loc_523F3B
          loc_523F3D: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_523F84: ldarg.0
          loc_523F85: ldfld GCUv2.frmProcessList::_dgvList
          loc_523F8A: br.s loc_523F8C
          loc_523F8C: // Referenced from: loc_523F8A
          loc_523F8C: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class KeyEventHandler var_1;
          class System.EventHandler var_2;
          class DataGridView var_3;

        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_523FEF: ldarg.0
          loc_523FF0: ldfld GCUv2.frmProcessList::_tsbRefresh
          loc_523FF5: br.s loc_523FF7
          loc_523FF7: // Referenced from: loc_523FF5
          loc_523FF7: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        public void frmProcessList() {


        }

        private void frmProcessList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void frmProcessList_Load(object sender, class System.EventArgs e) {

          loc_5240EF: nop
          loc_5240F0: ldarg.0
          loc_5240F1: call instance void GCUv2.frmProcessList::GetRecent()
          loc_5240F6: nop
          loc_5240F7: ret
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

        private void tsbNew_Click(object sender, class System.EventArgs e) {

          loc_524468: nop
          loc_524469: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_52446E: callvirt instance class GCUv2.frmProcess GCUv2.frmProcessList/MyForms::get_frmProcess()
          loc_524473: callvirt instance void System.Windows.Forms.Control::Show()
          loc_524478: nop
          loc_524479: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_52447E: callvirt instance class GCUv2.frmProcess GCUv2.frmProcessList/MyForms::get_frmProcess()
          loc_524483: ldc.i4.0
          loc_524484: ldc.i4.0
          loc_524485: callvirt instance void GCUv2.frmProcess::prepareForm(boolean, boolean)
          loc_52448A: nop
          loc_52448B: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_524490: callvirt instance class GCUv2.frmProcess GCUv2.frmProcessList/MyForms::get_frmProcess()
          loc_524495: callvirt instance void System.Windows.Forms.Form::Activate()
          loc_52449A: nop
          loc_52449B: ret
        }

        private void dgvList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;

        }

        private void dgvList_DoubleClick(object sender, class System.EventArgs e) {

          loc_52451B: nop
          loc_52451C: ldarg.0
          loc_52451D: call instance void GCUv2.frmProcessList::openSelection()
          loc_524522: nop
          loc_524523: ret
        }

        private void openSelection() {

          boolean var_1;

        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_5240EF: nop
          loc_5240F0: ldarg.0
          loc_5240F1: call instance void GCUv2.frmProcessList::GetRecent()
          loc_5240F6: nop
          loc_5240F7: ret
        }

    }
}
