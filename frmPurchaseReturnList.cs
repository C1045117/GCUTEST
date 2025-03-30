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

          loc_45EE9F: ldarg.0
          loc_45EEA0: ldfld GCUv2.frmPurchaseReturnList::_lblTitle
          loc_45EEA5: br.s loc_45EEA7
          loc_45EEA7: // Referenced from: loc_45EEA5
          loc_45EEA7: ret
        }

        assem override strict specialname void set_lblTitle(class Label WithEventsValue) {

          loc_45EEA9: ldarg.0
          loc_45EEAA: ldarg.1
          loc_45EEAB: stfld GCUv2.frmPurchaseReturnList::_lblTitle
          loc_45EEB0: ret
        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_45EEB2: ldarg.0
          loc_45EEB3: ldfld GCUv2.frmPurchaseReturnList::_ToolStrip1
          loc_45EEB8: br.s loc_45EEBA
          loc_45EEBA: // Referenced from: loc_45EEB8
          loc_45EEBA: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_45EEBC: ldarg.0
          loc_45EEBD: ldarg.1
          loc_45EEBE: stfld GCUv2.frmPurchaseReturnList::_ToolStrip1
          loc_45EEC3: ret
        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_45EEC5: ldarg.0
          loc_45EEC6: ldfld GCUv2.frmPurchaseReturnList::_tsbNew
          loc_45EECB: br.s loc_45EECD
          loc_45EECD: // Referenced from: loc_45EECB
          loc_45EECD: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_45EF14: ldarg.0
          loc_45EF15: ldfld GCUv2.frmPurchaseReturnList::_dgvList
          loc_45EF1A: br.s loc_45EF1C
          loc_45EF1C: // Referenced from: loc_45EF1A
          loc_45EF1C: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class KeyEventHandler var_1;
          class System.EventHandler var_2;
          class DataGridView var_3;

        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_45EF7F: ldarg.0
          loc_45EF80: ldfld GCUv2.frmPurchaseReturnList::_tsbRefresh
          loc_45EF85: br.s loc_45EF87
          loc_45EF87: // Referenced from: loc_45EF85
          loc_45EF87: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        private void frmPurchaseReturnList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        public void frmPurchaseReturnList() {


        }

        private void frmPurchaseReturnList_Load(object sender, class System.EventArgs e) {

          loc_45F080: nop
          loc_45F081: ldarg.0
          loc_45F082: call instance void GCUv2.frmPurchaseReturnList::GetRecent()
          loc_45F087: nop
          loc_45F088: ret
        }

        public void GetRecent() {

          int32 num_1;
          int32 num_2;
          class DataTable var_1;
          class DataTable var_2;
          boolean var_3;
          class System.Collections.IEnumerator var_4;
          class DataRow var_5;
          boolean var_6;

        }

        private void FormatGrid() {


        }

        private void tsbNew_Click(object sender, class System.EventArgs e) {

          loc_45F441: nop
          loc_45F442: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_45F447: callvirt instance class GCUv2.frmPurchaseReturn GCUv2.frmPurchaseReturnList/MyForms::get_frmPurchaseReturn()
          loc_45F44C: callvirt instance void System.Windows.Forms.Control::Show()
          loc_45F451: nop
          loc_45F452: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_45F457: callvirt instance class GCUv2.frmPurchaseReturn GCUv2.frmPurchaseReturnList/MyForms::get_frmPurchaseReturn()
          loc_45F45C: ldc.i4.0
          loc_45F45D: ldc.i4.0
          loc_45F45E: callvirt instance void GCUv2.frmPurchaseReturn::prepareForm(boolean, boolean)
          loc_45F463: nop
          loc_45F464: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_45F469: callvirt instance class GCUv2.frmPurchaseReturn GCUv2.frmPurchaseReturnList/MyForms::get_frmPurchaseReturn()
          loc_45F46E: callvirt instance void System.Windows.Forms.Form::Activate()
          loc_45F473: nop
          loc_45F474: ret
        }

        private void dgvList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;

        }

        private void dgvList_DoubleClick(object sender, class System.EventArgs e) {

          loc_45F4F7: nop
          loc_45F4F8: ldarg.0
          loc_45F4F9: call instance void GCUv2.frmPurchaseReturnList::openSelection()
          loc_45F4FE: nop
          loc_45F4FF: ret
        }

        private void openSelection() {

          boolean var_1;

        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_45F080: nop
          loc_45F081: ldarg.0
          loc_45F082: call instance void GCUv2.frmPurchaseReturnList::GetRecent()
          loc_45F087: nop
          loc_45F088: ret
        }

    }
}
