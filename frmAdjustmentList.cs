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

          loc_42DD4F: ldarg.0
          loc_42DD50: ldfld GCUv2.frmAdjustmentList::_lblTitle
          loc_42DD55: br.s loc_42DD57
          loc_42DD57: // Referenced from: loc_42DD55
          loc_42DD57: ret
        }

        assem override strict specialname void set_lblTitle(class Label WithEventsValue) {

          loc_42DD59: ldarg.0
          loc_42DD5A: ldarg.1
          loc_42DD5B: stfld GCUv2.frmAdjustmentList::_lblTitle
          loc_42DD60: ret
        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_42DD62: ldarg.0
          loc_42DD63: ldfld GCUv2.frmAdjustmentList::_dgvList
          loc_42DD68: br.s loc_42DD6A
          loc_42DD6A: // Referenced from: loc_42DD68
          loc_42DD6A: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class KeyEventHandler var_1;
          class System.EventHandler var_2;
          class DataGridView var_3;

        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_42DDCB: ldarg.0
          loc_42DDCC: ldfld GCUv2.frmAdjustmentList::_ToolStrip1
          loc_42DDD1: br.s loc_42DDD3
          loc_42DDD3: // Referenced from: loc_42DDD1
          loc_42DDD3: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_42DDD5: ldarg.0
          loc_42DDD6: ldarg.1
          loc_42DDD7: stfld GCUv2.frmAdjustmentList::_ToolStrip1
          loc_42DDDC: ret
        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_42DDDE: ldarg.0
          loc_42DDDF: ldfld GCUv2.frmAdjustmentList::_tsbNew
          loc_42DDE4: br.s loc_42DDE6
          loc_42DDE6: // Referenced from: loc_42DDE4
          loc_42DDE6: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_42DE2C: ldarg.0
          loc_42DE2D: ldfld GCUv2.frmAdjustmentList::_tsbRefresh
          loc_42DE32: br.s loc_42DE34
          loc_42DE34: // Referenced from: loc_42DE32
          loc_42DE34: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        public void frmAdjustmentList() {

          loc_42DE7C: nop
          loc_42DE7D: ldarg.0
          loc_42DE7E: call instance void System.Windows.Forms.Form::.ctor()
          loc_42DE83: nop
          loc_42DE84: ldarg.0
          loc_42DE85: ldarg.0
          loc_42DE86: ldftn instance void GCUv2.frmAdjustmentList::frmAdjustmentList_KeyDown(object, class KeyEventArgs)
          loc_42DE8C: newobj instance void System.Windows.Forms.KeyEventHandler::.ctor(object, System.IntPtr)
          loc_42DE91: call instance void System.Windows.Forms.Control::add_KeyDown(class KeyEventHandler)
          loc_42DE96: nop
          loc_42DE97: ldarg.0
          loc_42DE98: call instance void GCUv2.frmAdjustmentList::InitializeComponent()
          loc_42DE9D: nop
          loc_42DE9E: ldarg.0
          loc_42DE9F: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_42DEA4: callvirt instance class GCUv2.frmMenu GCUv2.frmAdjustmentList/MyForms::get_frmMenu()
          loc_42DEA9: call 
          loc_42DEAE: nop
          loc_42DEAF: ldarg.0
          loc_42DEB0: call instance void GCUv2.frmAdjustmentList::GetRecent()
          loc_42DEB5: nop
          loc_42DEB6: ret
        }

        private void frmAdjustmentList_KeyDown(object sender, class KeyEventArgs e) {

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

        private void tsbNew_Click(object sender, class System.EventArgs e) {

          loc_42E32C: nop
          loc_42E32D: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_42E332: callvirt instance class GCUv2.frmAdjustment GCUv2.frmAdjustmentList/MyForms::get_frmAdjustment()
          loc_42E337: callvirt instance void System.Windows.Forms.Control::Show()
          loc_42E33C: nop
          loc_42E33D: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_42E342: callvirt instance class GCUv2.frmAdjustment GCUv2.frmAdjustmentList/MyForms::get_frmAdjustment()
          loc_42E347: ldc.i4.0
          loc_42E348: callvirt instance void GCUv2.frmAdjustment::prepareForm(boolean)
          loc_42E34D: nop
          loc_42E34E: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_42E353: callvirt instance class GCUv2.frmAdjustment GCUv2.frmAdjustmentList/MyForms::get_frmAdjustment()
          loc_42E358: callvirt instance void System.Windows.Forms.Form::Activate()
          loc_42E35D: nop
          loc_42E35E: ret
        }

        private void dgvList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;

        }

        private void dgvList_DoubleClick(object sender, class System.EventArgs e) {

          loc_42E3DF: nop
          loc_42E3E0: ldarg.0
          loc_42E3E1: call instance void GCUv2.frmAdjustmentList::openSelection()
          loc_42E3E6: nop
          loc_42E3E7: ret
        }

        private void openSelection() {

          boolean var_1;

        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_42E4C6: nop
          loc_42E4C7: ldarg.0
          loc_42E4C8: call instance void GCUv2.frmAdjustmentList::GetRecent()
          loc_42E4CD: nop
          loc_42E4CE: ret
        }

    }
}
