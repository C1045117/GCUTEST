using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class DataGridView _dgvList;
        private class ToolStrip _ToolStrip1;
        private class ToolStripButton _tsbNew;
        private class ToolStripButton _tsbDelete;
        private class ToolStripButton _tsbRefresh;


        public void frmSettingAdjustmentTypeList() {

          loc_5388A1: ldarg.0
          loc_5388A2: call instance void System.Windows.Forms.Form::.ctor()
          loc_5388A7: ldarg.0
          loc_5388A8: ldarg.0
          loc_5388A9: ldftn instance void GCUv2.frmSettingAdjustmentTypeList::frmSettingAdjustmentTypeList_KeyDown(object, class KeyEventArgs)
          loc_5388AF: newobj instance void System.Windows.Forms.KeyEventHandler::.ctor(object, System.IntPtr)
          loc_5388B4: call instance void System.Windows.Forms.Control::add_KeyDown(class KeyEventHandler)
          loc_5388B9: ldarg.0
          loc_5388BA: ldarg.0
          loc_5388BB: ldftn instance void GCUv2.frmSettingAdjustmentTypeList::frmAdjustmentTypeList_Load(object, class System.EventArgs)
          loc_5388C1: newobj instance void System.EventHandler::.ctor(object, System.IntPtr)
          loc_5388C6: call instance void System.Windows.Forms.Form::add_Load(class System.EventHandler)
          loc_5388CB: ldarg.0
          loc_5388CC: call instance void GCUv2.frmSettingAdjustmentTypeList::InitializeComponent()
          loc_5388D1: ret
        }

        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {

          class ComponentModel.ComponentResourceManager var_1;

        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_538CC0: ldarg.0
          loc_538CC1: ldfld GCUv2.frmSettingAdjustmentTypeList::_dgvList
          loc_538CC6: br.s loc_538CC8
          loc_538CC8: // Referenced from: loc_538CC6
          loc_538CC8: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class System.EventHandler var_1;
          class KeyEventHandler var_2;
          class DataGridView var_3;

        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_538D2B: ldarg.0
          loc_538D2C: ldfld GCUv2.frmSettingAdjustmentTypeList::_ToolStrip1
          loc_538D31: br.s loc_538D33
          loc_538D33: // Referenced from: loc_538D31
          loc_538D33: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_538D35: ldarg.0
          loc_538D36: ldarg.1
          loc_538D37: stfld GCUv2.frmSettingAdjustmentTypeList::_ToolStrip1
          loc_538D3C: ret
        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_538D3E: ldarg.0
          loc_538D3F: ldfld GCUv2.frmSettingAdjustmentTypeList::_tsbNew
          loc_538D44: br.s loc_538D46
          loc_538D46: // Referenced from: loc_538D44
          loc_538D46: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class ToolStripButton get_tsbDelete() {

          loc_538D8C: ldarg.0
          loc_538D8D: ldfld GCUv2.frmSettingAdjustmentTypeList::_tsbDelete
          loc_538D92: br.s loc_538D94
          loc_538D94: // Referenced from: loc_538D92
          loc_538D94: ret
        }

        assem override strict specialname void set_tsbDelete(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_538DDC: ldarg.0
          loc_538DDD: ldfld GCUv2.frmSettingAdjustmentTypeList::_tsbRefresh
          loc_538DE2: br.s loc_538DE4
          loc_538DE4: // Referenced from: loc_538DE2
          loc_538DE4: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        private void frmSettingAdjustmentTypeList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void frmAdjustmentTypeList_Load(object sender, class System.EventArgs e) {

          loc_538E8B: nop
          loc_538E8C: ldarg.0
          loc_538E8D: call instance void GCUv2.frmSettingAdjustmentTypeList::getAdjustmentTypes()
          loc_538E92: nop
          loc_538E93: ret
        }

        public void getAdjustmentTypes() {

          string str_1;
          class DataTable var_1;

        }

        private void dgvList_DoubleClick(object sender, class System.EventArgs e) {

          loc_538F4B: nop
          loc_538F4C: ldarg.0
          loc_538F4D: call instance void GCUv2.frmSettingAdjustmentTypeList::openSelection()
          loc_538F52: nop
          loc_538F53: ret
        }

        private void ToolStripButton1_Click(object sender, class System.EventArgs e) {

          loc_538F55: nop
          loc_538F56: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_538F5B: callvirt instance class GCUv2.frmSettingAdjustmentTypeInput GCUv2.frmSettingAdjustmentTypeList/MyForms::get_frmSettingAdjustmentTypeInput()
          loc_538F60: callvirt instance valuetype DialogResult System.Windows.Forms.Form::ShowDialog()
          loc_538F65: pop
          loc_538F66: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_538F6B: callvirt instance class GCUv2.frmSettingAdjustmentTypeInput GCUv2.frmSettingAdjustmentTypeList/MyForms::get_frmSettingAdjustmentTypeInput()
          loc_538F70: callvirt instance void System.Windows.Forms.Form::Close()
          loc_538F75: nop
          loc_538F76: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_538F7B: callvirt instance class GCUv2.frmSettingAdjustmentTypeInput GCUv2.frmSettingAdjustmentTypeList/MyForms::get_frmSettingAdjustmentTypeInput()
          loc_538F80: callvirt instance void System.ComponentModel.Component::Dispose()
          loc_538F85: nop
          loc_538F86: ret
        }

        private void openSelection() {

          string str_1;

        }

        private void dgvList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;

        }

        private void tsbDelete_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          string str_1;
          string str_2;
          int32 num_2;
          boolean var_1;
          class DataTable var_2;
          boolean var_3;

        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_538E8B: nop
          loc_538E8C: ldarg.0
          loc_538E8D: call instance void GCUv2.frmSettingAdjustmentTypeList::getAdjustmentTypes()
          loc_538E92: nop
          loc_538E93: ret
        }

    }
}
