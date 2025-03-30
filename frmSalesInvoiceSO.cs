using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Button _btnSave;
        private class DataGridView _dgvList;
        private int32 _customerId;
        private double _invoiceId;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Button get_btnSave() {

          loc_49A103: ldarg.0
          loc_49A104: ldfld GCUv2.frmSalesInvoiceSO::_btnSave
          loc_49A109: br.s loc_49A10B
          loc_49A10B: // Referenced from: loc_49A109
          loc_49A10B: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_49A150: ldarg.0
          loc_49A151: ldfld GCUv2.frmSalesInvoiceSO::_dgvList
          loc_49A156: br.s loc_49A158
          loc_49A158: // Referenced from: loc_49A156
          loc_49A158: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class KeyEventHandler var_1;
          class DataGridViewCellEventHandler var_2;
          class DataGridView var_3;

        }

        public specialname int32 get_CustomerId() {

          int32 num_1;

        }

        public specialname void set_CustomerId(int32 value) {

          loc_49A1D5: nop
          loc_49A1D6: ldarg.0
          loc_49A1D7: ldarg.1
          loc_49A1D8: stfld GCUv2.frmSalesInvoiceSO::_customerId
          loc_49A1DD: ret
        }

        public specialname double get_InvoiceId() {

          double flt_1;

        }

        public specialname void set_InvoiceId(double value) {

          loc_49A1F9: nop
          loc_49A1FA: ldarg.0
          loc_49A1FB: ldarg.1
          loc_49A1FC: stfld GCUv2.frmSalesInvoiceSO::_invoiceId
          loc_49A201: ret
        }

        public void frmSalesInvoiceSO(int32 customerId, double InvoiceId) {

          loc_49A203: nop
          loc_49A204: ldarg.0
          loc_49A205: call instance void System.Windows.Forms.Form::.ctor()
          loc_49A20A: nop
          loc_49A20B: ldarg.0
          loc_49A20C: ldarg.0
          loc_49A20D: ldftn instance void GCUv2.frmSalesInvoiceSO::frmSalesInvoiceSO_KeyDown(object, class KeyEventArgs)
          loc_49A213: newobj instance void System.Windows.Forms.KeyEventHandler::.ctor(object, System.IntPtr)
          loc_49A218: call instance void System.Windows.Forms.Control::add_KeyDown(class KeyEventHandler)
          loc_49A21D: nop
          loc_49A21E: ldarg.0
          loc_49A21F: call instance void GCUv2.frmSalesInvoiceSO::InitializeComponent()
          loc_49A224: nop
          loc_49A225: ldarg.0
          loc_49A226: ldarg.1
          loc_49A227: stfld GCUv2.frmSalesInvoiceSO::_customerId
          loc_49A22C: ldarg.0
          loc_49A22D: ldarg.2
          loc_49A22E: stfld GCUv2.frmSalesInvoiceSO::_invoiceId
          loc_49A233: ldarg.0
          loc_49A234: call instance void GCUv2.frmSalesInvoiceSO::LoadData()
          loc_49A239: nop
          loc_49A23A: ret
        }

        private void frmSalesInvoiceSO_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void LoadData() {

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
          boolean var_2;
          int32 num_4;
          boolean var_3;
          int32 num_5;
          boolean var_4;
          boolean var_5;
          class GCUv2.cSalesOrder var_6;
          boolean var_7;
          class GCUv2.cComboItem var_8;
          class GCUv2.cSalesOrderItem[] var_9;
          int32 num_6;
          class GCUv2.cSalesOrderItem var_10;
          boolean var_11;
          boolean var_12;
          class GCUv2.cSalesOrderItem[] var_13;
          int32 num_7;
          class GCUv2.cSalesOrderItem var_14;
          class GCUv2.cItemPrintDetail var_15;
          boolean var_16;
          class GCUv2.frmSalesInvoice var_17;
          int32 num_8;
          boolean var_18;
          boolean var_19;

        }

        private void dgvList_CellContentClick(object sender, class DataGridViewCellEventArgs e) {

          boolean var_1;
          boolean var_2;
          int32 num_1;
          int32 num_2;
          boolean var_3;

        }

    }
}
