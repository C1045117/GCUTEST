using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class ToolStripButton _tsbRefresh;
        private class DataGridView _dgvList;
        private class ToolStripButton _tsbNew;
        private class CheckBox _chkAll;
        private class ToolStrip _ToolStrip1;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {

          class ComponentModel.ComponentResourceManager var_1;

        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_4F3343: ldarg.0
          loc_4F3344: ldfld GCUv2.frmSettingCustomerCodeList::_tsbRefresh
          loc_4F3349: br.s loc_4F334B
          loc_4F334B: // Referenced from: loc_4F3349
          loc_4F334B: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_4F3390: ldarg.0
          loc_4F3391: ldfld GCUv2.frmSettingCustomerCodeList::_dgvList
          loc_4F3396: br.s loc_4F3398
          loc_4F3398: // Referenced from: loc_4F3396
          loc_4F3398: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class System.EventHandler var_1;
          class KeyEventHandler var_2;
          class System.EventHandler var_3;
          class System.EventHandler var_4;
          class DataGridView var_5;

        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_4F343D: ldarg.0
          loc_4F343E: ldfld GCUv2.frmSettingCustomerCodeList::_tsbNew
          loc_4F3443: br.s loc_4F3445
          loc_4F3445: // Referenced from: loc_4F3443
          loc_4F3445: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class CheckBox get_chkAll() {

          loc_4F348C: ldarg.0
          loc_4F348D: ldfld GCUv2.frmSettingCustomerCodeList::_chkAll
          loc_4F3492: br.s loc_4F3494
          loc_4F3494: // Referenced from: loc_4F3492
          loc_4F3494: ret
        }

        assem override strict specialname void set_chkAll(class CheckBox WithEventsValue) {

          class System.EventHandler var_1;
          class CheckBox var_2;

        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_4F34DC: ldarg.0
          loc_4F34DD: ldfld GCUv2.frmSettingCustomerCodeList::_ToolStrip1
          loc_4F34E2: br.s loc_4F34E4
          loc_4F34E4: // Referenced from: loc_4F34E2
          loc_4F34E4: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_4F34E6: ldarg.0
          loc_4F34E7: ldarg.1
          loc_4F34E8: stfld GCUv2.frmSettingCustomerCodeList::_ToolStrip1
          loc_4F34ED: ret
        }

        public void frmSettingCustomerCodeList() {


        }

        private void frmSettingCustomerCodeList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void frmSettingCustomerCodeList_Load(object sender, class System.EventArgs e) {

          loc_4F35AB: nop
          loc_4F35AC: ldarg.0
          loc_4F35AD: call instance void GCUv2.frmSettingCustomerCodeList::getList()
          loc_4F35B2: nop
          loc_4F35B3: ret
        }

        private void FormatGrid() {


        }

        private void chkAll_CheckedChanged(object sender, class System.EventArgs e) {

          loc_4F35AB: nop
          loc_4F35AC: ldarg.0
          loc_4F35AD: call instance void GCUv2.frmSettingCustomerCodeList::getList()
          loc_4F35B2: nop
          loc_4F35B3: ret
        }

        public void getList() {

          class DataTable var_1;
          class System.Collections.IEnumerator var_2;
          class DataRow var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;

        }

        private void dgvList_DoubleClick(object sender, class System.EventArgs e) {

          loc_4F37C9: nop
          loc_4F37CA: ldarg.0
          loc_4F37CB: call instance void GCUv2.frmSettingCustomerCodeList::openSelection()
          loc_4F37D0: nop
          loc_4F37D1: ret
        }

        private void openSelection() {

          class GCUv2.frmSettingCustomerCodeInput var_1;

        }

        private void dgvList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;

        }

        private void dgvList_GotFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvList_LostFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void tsbNew_Click(object sender, class System.EventArgs e) {

          class GCUv2.frmSettingCustomerCodeInput var_1;

        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_4F35AB: nop
          loc_4F35AC: ldarg.0
          loc_4F35AD: call instance void GCUv2.frmSettingCustomerCodeList::getList()
          loc_4F35B2: nop
          loc_4F35B3: ret
        }

    }
}
