using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class DataGridView _dgvList;
        private class Button _btnSave;
        private int32 _supplierId;
        private double _invoiceId;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_456641: ldarg.0
          loc_456642: ldfld GCUv2.frmPurchaseInvoiceRI::_dgvList
          loc_456647: br.s loc_456649
          loc_456649: // Referenced from: loc_456647
          loc_456649: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class KeyEventHandler var_1;
          class DataGridView var_2;

        }

        assem override strict specialname class Button get_btnSave() {

          loc_456690: ldarg.0
          loc_456691: ldfld GCUv2.frmPurchaseInvoiceRI::_btnSave
          loc_456696: br.s loc_456698
          loc_456698: // Referenced from: loc_456696
          loc_456698: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        public specialname int32 get_SupplierId() {

          int32 num_1;

        }

        public specialname void set_SupplierId(int32 value) {

          loc_4566F9: nop
          loc_4566FA: ldarg.0
          loc_4566FB: ldarg.1
          loc_4566FC: stfld GCUv2.frmPurchaseInvoiceRI::_supplierId
          loc_456701: ret
        }

        public specialname double get_InvoiceId() {

          double flt_1;

        }

        public specialname void set_InvoiceId(double value) {

          loc_45671D: nop
          loc_45671E: ldarg.0
          loc_45671F: ldarg.1
          loc_456720: stfld GCUv2.frmPurchaseInvoiceRI::_invoiceId
          loc_456725: ret
        }

        public void frmPurchaseInvoiceRI(int32 SupplierId, double InvoiceId) {

          loc_456727: nop
          loc_456728: ldarg.0
          loc_456729: call instance void System.Windows.Forms.Form::.ctor()
          loc_45672E: nop
          loc_45672F: ldarg.0
          loc_456730: ldarg.0
          loc_456731: ldftn instance void GCUv2.frmPurchaseInvoiceRI::frmPurchaseInvoiceRI_KeyDown(object, class KeyEventArgs)
          loc_456737: newobj instance void System.Windows.Forms.KeyEventHandler::.ctor(object, System.IntPtr)
          loc_45673C: call instance void System.Windows.Forms.Control::add_KeyDown(class KeyEventHandler)
          loc_456741: nop
          loc_456742: ldarg.0
          loc_456743: call instance void GCUv2.frmPurchaseInvoiceRI::InitializeComponent()
          loc_456748: nop
          loc_456749: ldarg.0
          loc_45674A: ldarg.1
          loc_45674B: stfld GCUv2.frmPurchaseInvoiceRI::_supplierId
          loc_456750: ldarg.0
          loc_456751: ldarg.2
          loc_456752: stfld GCUv2.frmPurchaseInvoiceRI::_invoiceId
          loc_456757: ldarg.0
          loc_456758: call instance void GCUv2.frmPurchaseInvoiceRI::LoadRI()
          loc_45675D: nop
          loc_45675E: ret
        }

        private void frmPurchaseInvoiceRI_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void LoadRI() {

          class DataTable var_1;
          int32 num_1;
          boolean var_2;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          int32 num_2;
          boolean var_5;
          boolean var_6;

        }

        private void FormatGrid() {

          class DataGridViewCheckBoxColumn var_1;

        }

        private void dgvList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;

        }

        private void btnSave_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          int32 num_3;
          boolean var_1;
          int32 num_4;
          boolean var_2;
          int32 num_5;
          boolean var_3;
          boolean var_4;
          class GCUv2.cReceivedItem var_5;
          boolean var_6;
          class GCUv2.frmPurchaseInvoice var_7;
          class ComboBox var_8;
          class GCUv2.cReceivedItemItem[] var_9;
          int32 num_6;
          class GCUv2.cReceivedItemItem var_10;
          class GCUv2.cItemPurchasePrice var_11;
          boolean var_12;
          int32 num_7;
          boolean var_13;

        }

    }
}
