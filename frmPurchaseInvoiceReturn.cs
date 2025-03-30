using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Label _Label4;
        private class ComboBox _cboRetur;
        private class GCUv2.FilteredTextBox _txtAmount;
        private class Label _Label5;
        private class Button _btnDelete;
        private class Button _btnSave;
        private int32 _supplierId;


        public void frmPurchaseInvoiceReturn() {

          loc_5307F7: ldarg.0
          loc_5307F8: call instance void System.Windows.Forms.Form::.ctor()
          loc_5307FD: ldarg.0
          loc_5307FE: ldarg.0
          loc_5307FF: ldftn instance void GCUv2.frmPurchaseInvoiceReturn::frmPurchaseInvoiceRetur_KeyDown(object, class KeyEventArgs)
          loc_530805: newobj instance void System.Windows.Forms.KeyEventHandler::.ctor(object, System.IntPtr)
          loc_53080A: call instance void System.Windows.Forms.Control::add_KeyDown(class KeyEventHandler)
          loc_53080F: ldarg.0
          loc_530810: call instance void GCUv2.frmPurchaseInvoiceReturn::InitializeComponent()
          loc_530815: ret
        }

        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Label get_Label4() {

          loc_530CB4: ldarg.0
          loc_530CB5: ldfld GCUv2.frmPurchaseInvoiceReturn::_Label4
          loc_530CBA: br.s loc_530CBC
          loc_530CBC: // Referenced from: loc_530CBA
          loc_530CBC: ret
        }

        assem override strict specialname void set_Label4(class Label WithEventsValue) {

          loc_530CBE: ldarg.0
          loc_530CBF: ldarg.1
          loc_530CC0: stfld GCUv2.frmPurchaseInvoiceReturn::_Label4
          loc_530CC5: ret
        }

        assem override strict specialname class ComboBox get_cboRetur() {

          loc_530CC7: ldarg.0
          loc_530CC8: ldfld GCUv2.frmPurchaseInvoiceReturn::_cboRetur
          loc_530CCD: br.s loc_530CCF
          loc_530CCF: // Referenced from: loc_530CCD
          loc_530CCF: ret
        }

        assem override strict specialname void set_cboRetur(class ComboBox WithEventsValue) {

          loc_530CD1: ldarg.0
          loc_530CD2: ldarg.1
          loc_530CD3: stfld GCUv2.frmPurchaseInvoiceReturn::_cboRetur
          loc_530CD8: ret
        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtAmount() {

          loc_530CDA: ldarg.0
          loc_530CDB: ldfld GCUv2.frmPurchaseInvoiceReturn::_txtAmount
          loc_530CE0: br.s loc_530CE2
          loc_530CE2: // Referenced from: loc_530CE0
          loc_530CE2: ret
        }

        assem override strict specialname void set_txtAmount(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_530CE4: ldarg.0
          loc_530CE5: ldarg.1
          loc_530CE6: stfld GCUv2.frmPurchaseInvoiceReturn::_txtAmount
          loc_530CEB: ret
        }

        assem override strict specialname class Label get_Label5() {

          loc_530CED: ldarg.0
          loc_530CEE: ldfld GCUv2.frmPurchaseInvoiceReturn::_Label5
          loc_530CF3: br.s loc_530CF5
          loc_530CF5: // Referenced from: loc_530CF3
          loc_530CF5: ret
        }

        assem override strict specialname void set_Label5(class Label WithEventsValue) {

          loc_530CF7: ldarg.0
          loc_530CF8: ldarg.1
          loc_530CF9: stfld GCUv2.frmPurchaseInvoiceReturn::_Label5
          loc_530CFE: ret
        }

        assem override strict specialname class Button get_btnDelete() {

          loc_530D00: ldarg.0
          loc_530D01: ldfld GCUv2.frmPurchaseInvoiceReturn::_btnDelete
          loc_530D06: br.s loc_530D08
          loc_530D08: // Referenced from: loc_530D06
          loc_530D08: ret
        }

        assem override strict specialname void set_btnDelete(class Button WithEventsValue) {

          loc_530D0A: ldarg.0
          loc_530D0B: ldarg.1
          loc_530D0C: stfld GCUv2.frmPurchaseInvoiceReturn::_btnDelete
          loc_530D11: ret
        }

        assem override strict specialname class Button get_btnSave() {

          loc_530D13: ldarg.0
          loc_530D14: ldfld GCUv2.frmPurchaseInvoiceReturn::_btnSave
          loc_530D19: br.s loc_530D1B
          loc_530D1B: // Referenced from: loc_530D19
          loc_530D1B: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          loc_530D1D: ldarg.0
          loc_530D1E: ldarg.1
          loc_530D1F: stfld GCUv2.frmPurchaseInvoiceReturn::_btnSave
          loc_530D24: ret
        }

        public specialname int32 get_SupplierId() {

          int32 num_1;

        }

        public specialname void set_SupplierId(int32 value) {

          loc_530D41: nop
          loc_530D42: ldarg.0
          loc_530D43: ldarg.1
          loc_530D44: stfld GCUv2.frmPurchaseInvoiceReturn::_supplierId
          loc_530D49: ret
        }

        private void frmPurchaseInvoiceRetur_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void btnSave_Click(object sender, class System.EventArgs e) {

          loc_4404BF: nop
          loc_4404C0: ret
        }

    }
}
