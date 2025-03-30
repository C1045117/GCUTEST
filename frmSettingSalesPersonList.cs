using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class CheckBox _chkAll;
        private class ToolStripButton _tsbRefresh;
        private class ToolStripButton _tsbNew;
        private class DataGridView _dgvList;
        private class ToolStrip _ToolStrip1;
        private class CheckBox _chkManual;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {

          class ComponentModel.ComponentResourceManager var_1;

        }

        assem override strict specialname class CheckBox get_chkAll() {

          loc_4F70D5: ldarg.0
          loc_4F70D6: ldfld GCUv2.frmSettingSalesPersonList::_chkAll
          loc_4F70DB: br.s loc_4F70DD
          loc_4F70DD: // Referenced from: loc_4F70DB
          loc_4F70DD: ret
        }

        assem override strict specialname void set_chkAll(class CheckBox WithEventsValue) {

          class System.EventHandler var_1;
          class CheckBox var_2;

        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_4F7124: ldarg.0
          loc_4F7125: ldfld GCUv2.frmSettingSalesPersonList::_tsbRefresh
          loc_4F712A: br.s loc_4F712C
          loc_4F712C: // Referenced from: loc_4F712A
          loc_4F712C: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_4F7174: ldarg.0
          loc_4F7175: ldfld GCUv2.frmSettingSalesPersonList::_tsbNew
          loc_4F717A: br.s loc_4F717C
          loc_4F717C: // Referenced from: loc_4F717A
          loc_4F717C: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_4F71C4: ldarg.0
          loc_4F71C5: ldfld GCUv2.frmSettingSalesPersonList::_dgvList
          loc_4F71CA: br.s loc_4F71CC
          loc_4F71CC: // Referenced from: loc_4F71CA
          loc_4F71CC: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class System.EventHandler var_1;
          class KeyEventHandler var_2;
          class System.EventHandler var_3;
          class System.EventHandler var_4;
          class DataGridView var_5;

        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_4F7271: ldarg.0
          loc_4F7272: ldfld GCUv2.frmSettingSalesPersonList::_ToolStrip1
          loc_4F7277: br.s loc_4F7279
          loc_4F7279: // Referenced from: loc_4F7277
          loc_4F7279: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_4F727B: ldarg.0
          loc_4F727C: ldarg.1
          loc_4F727D: stfld GCUv2.frmSettingSalesPersonList::_ToolStrip1
          loc_4F7282: ret
        }

        assem override strict specialname class CheckBox get_chkManual() {

          loc_4F7284: ldarg.0
          loc_4F7285: ldfld GCUv2.frmSettingSalesPersonList::_chkManual
          loc_4F728A: br.s loc_4F728C
          loc_4F728C: // Referenced from: loc_4F728A
          loc_4F728C: ret
        }

        assem override strict specialname void set_chkManual(class CheckBox WithEventsValue) {

          loc_4F728E: ldarg.0
          loc_4F728F: ldarg.1
          loc_4F7290: stfld GCUv2.frmSettingSalesPersonList::_chkManual
          loc_4F7295: ret
        }

        public void frmSettingSalesPersonList() {


        }

        private void frmSettingSalesPersonList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void frmSettingSalesPersonList_Load(object sender, class System.EventArgs e) {

          loc_4F7353: nop
          loc_4F7354: ldarg.0
          loc_4F7355: call instance void GCUv2.frmSettingSalesPersonList::getList()
          loc_4F735A: nop
          loc_4F735B: ret
        }

        private void FormatGrid() {


        }

        private void chkAll_CheckedChanged(object sender, class System.EventArgs e) {

          loc_4F7353: nop
          loc_4F7354: ldarg.0
          loc_4F7355: call instance void GCUv2.frmSettingSalesPersonList::getList()
          loc_4F735A: nop
          loc_4F735B: ret
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

          loc_4F75C1: nop
          loc_4F75C2: ldarg.0
          loc_4F75C3: call instance void GCUv2.frmSettingSalesPersonList::openSelection()
          loc_4F75C8: nop
          loc_4F75C9: ret
        }

        private void openSelection() {

          class GCUv2.frmSettingSalesPersonInput var_1;

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

          class GCUv2.frmSettingSalesPersonInput var_1;

        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_4F7353: nop
          loc_4F7354: ldarg.0
          loc_4F7355: call instance void GCUv2.frmSettingSalesPersonList::getList()
          loc_4F735A: nop
          loc_4F735B: ret
        }

    }
}
