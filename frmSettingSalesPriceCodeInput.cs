using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Button _btnSaveClose;
        private class Label _Label9;
        private class ComboBox _cboActive;
        private class TextBox _txtName;
        private class Label _Label1;
        private class DataGridView _dgvList;
        private class Label _Label2;
        private boolean _dontFocus;
        private int32 _currentId;
        private boolean _blnDecimal;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Button get_btnSaveClose() {

          loc_4F7C37: ldarg.0
          loc_4F7C38: ldfld GCUv2.frmSettingSalesPriceCodeInput::_btnSaveClose
          loc_4F7C3D: br.s loc_4F7C3F
          loc_4F7C3F: // Referenced from: loc_4F7C3D
          loc_4F7C3F: ret
        }

        assem override strict specialname void set_btnSaveClose(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_Label9() {

          loc_4F7C84: ldarg.0
          loc_4F7C85: ldfld GCUv2.frmSettingSalesPriceCodeInput::_Label9
          loc_4F7C8A: br.s loc_4F7C8C
          loc_4F7C8C: // Referenced from: loc_4F7C8A
          loc_4F7C8C: ret
        }

        assem override strict specialname void set_Label9(class Label WithEventsValue) {

          loc_4F7C8E: ldarg.0
          loc_4F7C8F: ldarg.1
          loc_4F7C90: stfld GCUv2.frmSettingSalesPriceCodeInput::_Label9
          loc_4F7C95: ret
        }

        assem override strict specialname class ComboBox get_cboActive() {

          loc_4F7C97: ldarg.0
          loc_4F7C98: ldfld GCUv2.frmSettingSalesPriceCodeInput::_cboActive
          loc_4F7C9D: br.s loc_4F7C9F
          loc_4F7C9F: // Referenced from: loc_4F7C9D
          loc_4F7C9F: ret
        }

        assem override strict specialname void set_cboActive(class ComboBox WithEventsValue) {

          loc_4F7CA1: ldarg.0
          loc_4F7CA2: ldarg.1
          loc_4F7CA3: stfld GCUv2.frmSettingSalesPriceCodeInput::_cboActive
          loc_4F7CA8: ret
        }

        assem override strict specialname class TextBox get_txtName() {

          loc_4F7CAA: ldarg.0
          loc_4F7CAB: ldfld GCUv2.frmSettingSalesPriceCodeInput::_txtName
          loc_4F7CB0: br.s loc_4F7CB2
          loc_4F7CB2: // Referenced from: loc_4F7CB0
          loc_4F7CB2: ret
        }

        assem override strict specialname void set_txtName(class TextBox WithEventsValue) {

          loc_4F7CB4: ldarg.0
          loc_4F7CB5: ldarg.1
          loc_4F7CB6: stfld GCUv2.frmSettingSalesPriceCodeInput::_txtName
          loc_4F7CBB: ret
        }

        assem override strict specialname class Label get_Label1() {

          loc_4F7CBD: ldarg.0
          loc_4F7CBE: ldfld GCUv2.frmSettingSalesPriceCodeInput::_Label1
          loc_4F7CC3: br.s loc_4F7CC5
          loc_4F7CC5: // Referenced from: loc_4F7CC3
          loc_4F7CC5: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_4F7CC7: ldarg.0
          loc_4F7CC8: ldarg.1
          loc_4F7CC9: stfld GCUv2.frmSettingSalesPriceCodeInput::_Label1
          loc_4F7CCE: ret
        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_4F7CD0: ldarg.0
          loc_4F7CD1: ldfld GCUv2.frmSettingSalesPriceCodeInput::_dgvList
          loc_4F7CD6: br.s loc_4F7CD8
          loc_4F7CD8: // Referenced from: loc_4F7CD6
          loc_4F7CD8: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class DataGridViewCellEventHandler var_1;
          class DataGridViewCellEventHandler var_2;
          class DataGridViewCellValidatingEventHandler var_3;
          class DataGridViewCellEventHandler var_4;
          class System.EventHandler var_5;
          class System.EventHandler var_6;
          class KeyEventHandler var_7;
          class DataGridViewEditingControlShowingEventHandler var_8;
          class DataGridView var_9;

        }

        assem override strict specialname class Label get_Label2() {

          loc_4F7DFD: ldarg.0
          loc_4F7DFE: ldfld GCUv2.frmSettingSalesPriceCodeInput::_Label2
          loc_4F7E03: br.s loc_4F7E05
          loc_4F7E05: // Referenced from: loc_4F7E03
          loc_4F7E05: ret
        }

        assem override strict specialname void set_Label2(class Label WithEventsValue) {

          loc_4F7E07: ldarg.0
          loc_4F7E08: ldarg.1
          loc_4F7E09: stfld GCUv2.frmSettingSalesPriceCodeInput::_Label2
          loc_4F7E0E: ret
        }

        public specialname string get_CurrentId() {

          string str_1;

        }

        public specialname void set_CurrentId(string value) {

          loc_4F7E2E: nop
          loc_4F7E2F: ldarg.0
          loc_4F7E30: ldarg.1
          loc_4F7E31: call int32 Microsoft.VisualBasic.CompilerServices.Conversions::ToInteger(string)
          loc_4F7E36: stfld GCUv2.frmSettingSalesPriceCodeInput::_currentId
          loc_4F7E3B: ret
        }

        public void frmSettingSalesPriceCodeInput() {

          class ComboBox var_1;

        }

        private void frmSettingSalesPriceCodeInput_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void frmSettingSalesPriceCodeInput_Load(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void FormatGrid() {


        }

        public void loadData() {

          int32 num_1;
          int32 num_2;
          class GCUv2.cSalesPriceCode var_1;
          class ComboBox var_2;
          class GCUv2.cSalesPriceCodeItem[] var_3;
          int32 num_3;
          class GCUv2.cSalesPriceCodeItem var_4;
          boolean var_5;
          boolean var_6;

        }

        public void prepareForm() {

          loc_4F81ED: nop
          loc_4F81EE: ldarg.0
          loc_4F81EF: ldc.i4.0
          loc_4F81F0: stfld GCUv2.frmSettingSalesPriceCodeInput::_currentId
          loc_4F81F5: ret
        }

        private void btnSaveClose_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          class GCUv2.cComboItem var_1;
          class GCUv2.cSalesPriceCode var_2;
          class GCUv2.cSalesPriceCodeItem[] var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          int32 num_3;
          int32 num_4;

        }

        private void dgvList_CellEnter(object sender, class DataGridViewCellEventArgs e) {

          boolean var_1;
          string str_1;

        }

        private void dgvList_CellEndEdit(object sender, class DataGridViewCellEventArgs e) {

          boolean var_1;
          string str_1;
          boolean var_2;

        }

        private void dgvList_CellValidating(object sender, class DataGridViewCellValidatingEventArgs e) {

          int32 num_1;
          int32 num_2;
          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void dgvList_CellValidated(object sender, class DataGridViewCellEventArgs e) {

          int32 num_1;
          int32 num_2;
          double flt_1;
          boolean var_1;
          boolean var_2;

        }

        private void dgvList_GotFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvList_LostFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void dgvList_EditingControlShowing(object sender, class DataGridViewEditingControlShowingEventArgs e) {

          class Control var_1;

        }

        protected void Handle_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        protected void Handle_KeyPress(object sender, class KeyPressEventArgs e) {

          int16 num_1;
          boolean var_1;
          boolean var_2;

        }

    }
}
