using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class ToolStripButton _tsbNew;
        private class Label _lblTitle;
        private class ToolStrip _ToolStrip1;
        private class DataGridView _dgvList;
        private class ToolStripButton _tsbRefresh;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {

          class ComponentModel.ComponentResourceManager var_1;

        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_4E6B07: ldarg.0
          loc_4E6B08: ldfld GCUv2.frmSalesOrderList::_tsbNew
          loc_4E6B0D: br.s loc_4E6B0F
          loc_4E6B0F: // Referenced from: loc_4E6B0D
          loc_4E6B0F: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class Label get_lblTitle() {

          loc_4E6B54: ldarg.0
          loc_4E6B55: ldfld GCUv2.frmSalesOrderList::_lblTitle
          loc_4E6B5A: br.s loc_4E6B5C
          loc_4E6B5C: // Referenced from: loc_4E6B5A
          loc_4E6B5C: ret
        }

        assem override strict specialname void set_lblTitle(class Label WithEventsValue) {

          loc_4E6B5E: ldarg.0
          loc_4E6B5F: ldarg.1
          loc_4E6B60: stfld GCUv2.frmSalesOrderList::_lblTitle
          loc_4E6B65: ret
        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_4E6B67: ldarg.0
          loc_4E6B68: ldfld GCUv2.frmSalesOrderList::_ToolStrip1
          loc_4E6B6D: br.s loc_4E6B6F
          loc_4E6B6F: // Referenced from: loc_4E6B6D
          loc_4E6B6F: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_4E6B71: ldarg.0
          loc_4E6B72: ldarg.1
          loc_4E6B73: stfld GCUv2.frmSalesOrderList::_ToolStrip1
          loc_4E6B78: ret
        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_4E6B7A: ldarg.0
          loc_4E6B7B: ldfld GCUv2.frmSalesOrderList::_dgvList
          loc_4E6B80: br.s loc_4E6B82
          loc_4E6B82: // Referenced from: loc_4E6B80
          loc_4E6B82: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class KeyEventHandler var_1;
          class System.EventHandler var_2;
          class DataGridView var_3;

        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_4E6BE3: ldarg.0
          loc_4E6BE4: ldfld GCUv2.frmSalesOrderList::_tsbRefresh
          loc_4E6BE9: br.s loc_4E6BEB
          loc_4E6BEB: // Referenced from: loc_4E6BE9
          loc_4E6BEB: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        public void frmSalesOrderList() {


        }

        private void frmSalesOrderList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        public void GetRecent() {

          int32 num_1;
          int32 num_2;
          class DataTable var_1;
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

          loc_4E721F: nop
          loc_4E7220: ldarg.0
          loc_4E7221: call instance void GCUv2.frmSalesOrderList::openSelection()
          loc_4E7226: nop
          loc_4E7227: ret
        }

        private void openSelection() {

          boolean var_1;

        }

        private void tsbNew_Click(object sender, class System.EventArgs e) {

          loc_4E7306: nop
          loc_4E7307: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_4E730C: callvirt instance class GCUv2.frmSalesOrder GCUv2.frmSalesOrderList/MyForms::get_frmSalesOrder()
          loc_4E7311: callvirt instance void System.Windows.Forms.Control::Show()
          loc_4E7316: nop
          loc_4E7317: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_4E731C: callvirt instance class GCUv2.frmSalesOrder GCUv2.frmSalesOrderList/MyForms::get_frmSalesOrder()
          loc_4E7321: ldc.i4.0
          loc_4E7322: callvirt instance void GCUv2.frmSalesOrder::prepareForm(boolean)
          loc_4E7327: nop
          loc_4E7328: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_4E732D: callvirt instance class GCUv2.frmSalesOrder GCUv2.frmSalesOrderList/MyForms::get_frmSalesOrder()
          loc_4E7332: callvirt instance void System.Windows.Forms.Form::Activate()
          loc_4E7337: nop
          loc_4E7338: ret
        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_4E733A: nop
          loc_4E733B: ldarg.0
          loc_4E733C: call instance void GCUv2.frmSalesOrderList::GetRecent()
          loc_4E7341: nop
          loc_4E7342: ret
        }

    }
}
