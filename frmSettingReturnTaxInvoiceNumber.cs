using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks.Vs;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class GCUv2.FilteredTextBox _txtLatestNumber;
        private class Label _Label5;
        private class Button _btnSave;
        private class Label _Label1;
        private class ComboBox _cboYear;
        private class Microsoft.VisualBasic.PowerPacks.LineShape _LineShape2;
        private class Microsoft.VisualBasic.PowerPacks.ShapeContainer _ShapeContainer1;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtLatestNumber() {

          loc_4F5C22: ldarg.0
          loc_4F5C23: ldfld GCUv2.frmSettingReturnTaxInvoiceNumber::_txtLatestNumber
          loc_4F5C28: br.s loc_4F5C2A
          loc_4F5C2A: // Referenced from: loc_4F5C28
          loc_4F5C2A: ret
        }

        assem override strict specialname void set_txtLatestNumber(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_4F5C2C: ldarg.0
          loc_4F5C2D: ldarg.1
          loc_4F5C2E: stfld GCUv2.frmSettingReturnTaxInvoiceNumber::_txtLatestNumber
          loc_4F5C33: ret
        }

        assem override strict specialname class Label get_Label5() {

          loc_4F5C35: ldarg.0
          loc_4F5C36: ldfld GCUv2.frmSettingReturnTaxInvoiceNumber::_Label5
          loc_4F5C3B: br.s loc_4F5C3D
          loc_4F5C3D: // Referenced from: loc_4F5C3B
          loc_4F5C3D: ret
        }

        assem override strict specialname void set_Label5(class Label WithEventsValue) {

          loc_4F5C3F: ldarg.0
          loc_4F5C40: ldarg.1
          loc_4F5C41: stfld GCUv2.frmSettingReturnTaxInvoiceNumber::_Label5
          loc_4F5C46: ret
        }

        assem override strict specialname class Button get_btnSave() {

          loc_4F5C48: ldarg.0
          loc_4F5C49: ldfld GCUv2.frmSettingReturnTaxInvoiceNumber::_btnSave
          loc_4F5C4E: br.s loc_4F5C50
          loc_4F5C50: // Referenced from: loc_4F5C4E
          loc_4F5C50: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_Label1() {

          loc_4F5C98: ldarg.0
          loc_4F5C99: ldfld GCUv2.frmSettingReturnTaxInvoiceNumber::_Label1
          loc_4F5C9E: br.s loc_4F5CA0
          loc_4F5CA0: // Referenced from: loc_4F5C9E
          loc_4F5CA0: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_4F5CA2: ldarg.0
          loc_4F5CA3: ldarg.1
          loc_4F5CA4: stfld GCUv2.frmSettingReturnTaxInvoiceNumber::_Label1
          loc_4F5CA9: ret
        }

        assem override strict specialname class ComboBox get_cboYear() {

          loc_4F5CAB: ldarg.0
          loc_4F5CAC: ldfld GCUv2.frmSettingReturnTaxInvoiceNumber::_cboYear
          loc_4F5CB1: br.s loc_4F5CB3
          loc_4F5CB3: // Referenced from: loc_4F5CB1
          loc_4F5CB3: ret
        }

        assem override strict specialname void set_cboYear(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class Microsoft.VisualBasic.PowerPacks.LineShape get_LineShape2() {

          loc_4F5CF8: ldarg.0
          loc_4F5CF9: ldfld GCUv2.frmSettingReturnTaxInvoiceNumber::_LineShape2
          loc_4F5CFE: br.s loc_4F5D00
          loc_4F5D00: // Referenced from: loc_4F5CFE
          loc_4F5D00: ret
        }

        assem override strict specialname void set_LineShape2(class Microsoft.VisualBasic.PowerPacks.LineShape WithEventsValue) {

          loc_4F5D02: ldarg.0
          loc_4F5D03: ldarg.1
          loc_4F5D04: stfld GCUv2.frmSettingReturnTaxInvoiceNumber::_LineShape2
          loc_4F5D09: ret
        }

        assem override strict specialname class Microsoft.VisualBasic.PowerPacks.ShapeContainer get_ShapeContainer1() {

          loc_4F5D0B: ldarg.0
          loc_4F5D0C: ldfld GCUv2.frmSettingReturnTaxInvoiceNumber::_ShapeContainer1
          loc_4F5D11: br.s loc_4F5D13
          loc_4F5D13: // Referenced from: loc_4F5D11
          loc_4F5D13: ret
        }

        assem override strict specialname void set_ShapeContainer1(class Microsoft.VisualBasic.PowerPacks.ShapeContainer WithEventsValue) {

          loc_4F5D15: ldarg.0
          loc_4F5D16: ldarg.1
          loc_4F5D17: stfld GCUv2.frmSettingReturnTaxInvoiceNumber::_ShapeContainer1
          loc_4F5D1C: ret
        }

        public void frmSettingReturnTaxInvoiceNumber() {

          class ComboBox var_1;

        }

        private void frmSettingReturnTaxInvoiceNumber_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void cboYear_SelectedIndexChanged(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void getData() {

          class GCUv2.cComboItem var_1;
          class GCUv2.cReturnTaxInvoiceNumber var_2;

        }

        private void btnSave_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          class GCUv2.cComboItem var_1;
          class GCUv2.cReturnTaxInvoiceNumber var_2;
          boolean var_3;
          boolean var_4;

        }

    }
}
