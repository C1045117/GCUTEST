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

          loc_54AAAF: ldarg.0
          loc_54AAB0: ldfld GCUv2.frmUsageList::_lblTitle
          loc_54AAB5: br.s loc_54AAB7
          loc_54AAB7: // Referenced from: loc_54AAB5
          loc_54AAB7: ret
        }

        assem override strict specialname void set_lblTitle(class Label WithEventsValue) {

          loc_54AAB9: ldarg.0
          loc_54AABA: ldarg.1
          loc_54AABB: stfld GCUv2.frmUsageList::_lblTitle
          loc_54AAC0: ret
        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_54AAC2: ldarg.0
          loc_54AAC3: ldfld GCUv2.frmUsageList::_dgvList
          loc_54AAC8: br.s loc_54AACA
          loc_54AACA: // Referenced from: loc_54AAC8
          loc_54AACA: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class KeyEventHandler var_1;
          class System.EventHandler var_2;
          class DataGridView var_3;

        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_54AB2B: ldarg.0
          loc_54AB2C: ldfld GCUv2.frmUsageList::_ToolStrip1
          loc_54AB31: br.s loc_54AB33
          loc_54AB33: // Referenced from: loc_54AB31
          loc_54AB33: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_54AB35: ldarg.0
          loc_54AB36: ldarg.1
          loc_54AB37: stfld GCUv2.frmUsageList::_ToolStrip1
          loc_54AB3C: ret
        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_54AB3E: ldarg.0
          loc_54AB3F: ldfld GCUv2.frmUsageList::_tsbNew
          loc_54AB44: br.s loc_54AB46
          loc_54AB46: // Referenced from: loc_54AB44
          loc_54AB46: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_54AB8C: ldarg.0
          loc_54AB8D: ldfld GCUv2.frmUsageList::_tsbRefresh
          loc_54AB92: br.s loc_54AB94
          loc_54AB94: // Referenced from: loc_54AB92
          loc_54AB94: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        public void frmUsageList() {


        }

        private void frmUsageList_KeyDown(object sender, class KeyEventArgs e) {

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

          loc_54B115: nop
          loc_54B116: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_54B11B: callvirt instance class GCUv2.frmUsage GCUv2.frmUsageList/MyForms::get_frmUsage()
          loc_54B120: callvirt instance void System.Windows.Forms.Control::Show()
          loc_54B125: nop
          loc_54B126: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_54B12B: callvirt instance class GCUv2.frmUsage GCUv2.frmUsageList/MyForms::get_frmUsage()
          loc_54B130: ldc.i4.0
          loc_54B131: callvirt instance void GCUv2.frmUsage::PrepareForm(boolean)
          loc_54B136: nop
          loc_54B137: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_54B13C: callvirt instance class GCUv2.frmUsage GCUv2.frmUsageList/MyForms::get_frmUsage()
          loc_54B141: callvirt instance void System.Windows.Forms.Form::Activate()
          loc_54B146: nop
          loc_54B147: ret
        }

        private void dgvList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;

        }

        private void dgvList_DoubleClick(object sender, class System.EventArgs e) {

          loc_54B1C7: nop
          loc_54B1C8: ldarg.0
          loc_54B1C9: call instance void GCUv2.frmUsageList::openSelection()
          loc_54B1CE: nop
          loc_54B1CF: ret
        }

        private void openSelection() {

          boolean var_1;

        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_54B2AE: nop
          loc_54B2AF: ldarg.0
          loc_54B2B0: call instance void GCUv2.frmUsageList::GetRecent()
          loc_54B2B5: nop
          loc_54B2B6: ret
        }

    }
}
