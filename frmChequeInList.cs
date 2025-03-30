using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Label _Label1;
        private class DataGridView _dgvList;
        private class ComboBox _cboBaseFilter;
        private class ToolStrip _ToolStrip1;
        private class ToolStripButton _tsbRefresh;
        private class Label _lblTitle;
        private class Label _lblTotal;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {

          class ComponentModel.ComponentResourceManager var_1;

        }

        assem override strict specialname class Label get_Label1() {

          loc_436983: ldarg.0
          loc_436984: ldfld GCUv2.frmChequeInList::_Label1
          loc_436989: br.s loc_43698B
          loc_43698B: // Referenced from: loc_436989
          loc_43698B: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_43698D: ldarg.0
          loc_43698E: ldarg.1
          loc_43698F: stfld GCUv2.frmChequeInList::_Label1
          loc_436994: ret
        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_436996: ldarg.0
          loc_436997: ldfld GCUv2.frmChequeInList::_dgvList
          loc_43699C: br.s loc_43699E
          loc_43699E: // Referenced from: loc_43699C
          loc_43699E: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class KeyEventHandler var_1;
          class System.EventHandler var_2;
          class System.EventHandler var_3;
          class System.EventHandler var_4;
          class DataGridView var_5;

        }

        assem override strict specialname class ComboBox get_cboBaseFilter() {

          loc_436A41: ldarg.0
          loc_436A42: ldfld GCUv2.frmChequeInList::_cboBaseFilter
          loc_436A47: br.s loc_436A49
          loc_436A49: // Referenced from: loc_436A47
          loc_436A49: ret
        }

        assem override strict specialname void set_cboBaseFilter(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_436A90: ldarg.0
          loc_436A91: ldfld GCUv2.frmChequeInList::_ToolStrip1
          loc_436A96: br.s loc_436A98
          loc_436A98: // Referenced from: loc_436A96
          loc_436A98: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_436A9A: ldarg.0
          loc_436A9B: ldarg.1
          loc_436A9C: stfld GCUv2.frmChequeInList::_ToolStrip1
          loc_436AA1: ret
        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_436AA3: ldarg.0
          loc_436AA4: ldfld GCUv2.frmChequeInList::_tsbRefresh
          loc_436AA9: br.s loc_436AAB
          loc_436AAB: // Referenced from: loc_436AA9
          loc_436AAB: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class Label get_lblTitle() {

          loc_436AF0: ldarg.0
          loc_436AF1: ldfld GCUv2.frmChequeInList::_lblTitle
          loc_436AF6: br.s loc_436AF8
          loc_436AF8: // Referenced from: loc_436AF6
          loc_436AF8: ret
        }

        assem override strict specialname void set_lblTitle(class Label WithEventsValue) {

          loc_436AFA: ldarg.0
          loc_436AFB: ldarg.1
          loc_436AFC: stfld GCUv2.frmChequeInList::_lblTitle
          loc_436B01: ret
        }

        assem override strict specialname class Label get_lblTotal() {

          loc_436B03: ldarg.0
          loc_436B04: ldfld GCUv2.frmChequeInList::_lblTotal
          loc_436B09: br.s loc_436B0B
          loc_436B0B: // Referenced from: loc_436B09
          loc_436B0B: ret
        }

        assem override strict specialname void set_lblTotal(class Label WithEventsValue) {

          loc_436B0D: ldarg.0
          loc_436B0E: ldarg.1
          loc_436B0F: stfld GCUv2.frmChequeInList::_lblTotal
          loc_436B14: ret
        }

        public void frmChequeInList() {

          class ComboBox var_1;

        }

        private void frmChequeInList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;

        }

        public void GetRecent() {

          int32 num_1;
          int32 num_2;
          class GCUv2.cComboItem var_1;
          class DataTable var_2;
          double flt_1;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          boolean var_5;
          boolean var_6;

        }

        private void formatGrid() {

          class DataGridView var_1;

        }

        private void dgvList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void dgvList_DoubleClick(object sender, class System.EventArgs e) {

          loc_4372EE: nop
          loc_4372EF: ldarg.0
          loc_4372F0: call instance void GCUv2.frmChequeInList::openSelection()
          loc_4372F5: nop
          loc_4372F6: ret
        }

        private void dgvList_GotFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvList_LostFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void openSelection() {

          boolean var_1;

        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_43743D: nop
          loc_43743E: ldarg.0
          loc_43743F: call instance void GCUv2.frmChequeInList::GetRecent()
          loc_437444: nop
          loc_437445: ret
        }

        private void cboBaseFilter_SelectedIndexChanged(object sender, class System.EventArgs e) {

          loc_43743D: nop
          loc_43743E: ldarg.0
          loc_43743F: call instance void GCUv2.frmChequeInList::GetRecent()
          loc_437444: nop
          loc_437445: ret
        }

    }
}
