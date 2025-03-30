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

          loc_4996A3: ldarg.0
          loc_4996A4: ldfld GCUv2.frmSalesInvoiceDO::_btnSave
          loc_4996A9: br.s loc_4996AB
          loc_4996AB: // Referenced from: loc_4996A9
          loc_4996AB: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_4996F0: ldarg.0
          loc_4996F1: ldfld GCUv2.frmSalesInvoiceDO::_dgvList
          loc_4996F6: br.s loc_4996F8
          loc_4996F8: // Referenced from: loc_4996F6
          loc_4996F8: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class KeyEventHandler var_1;
          class DataGridView var_2;

        }

        public specialname int32 get_CustomerId() {

          int32 num_1;

        }

        public specialname void set_CustomerId(int32 value) {

          loc_499759: nop
          loc_49975A: ldarg.0
          loc_49975B: ldarg.1
          loc_49975C: stfld GCUv2.frmSalesInvoiceDO::_customerId
          loc_499761: ret
        }

        public specialname double get_InvoiceId() {

          double flt_1;

        }

        public specialname void set_InvoiceId(double value) {

          loc_49977D: nop
          loc_49977E: ldarg.0
          loc_49977F: ldarg.1
          loc_499780: stfld GCUv2.frmSalesInvoiceDO::_invoiceId
          loc_499785: ret
        }

        public void frmSalesInvoiceDO(int32 customerId, double InvoiceId) {

          loc_499787: nop
          loc_499788: ldarg.0
          loc_499789: call instance void System.Windows.Forms.Form::.ctor()
          loc_49978E: nop
          loc_49978F: ldarg.0
          loc_499790: ldarg.0
          loc_499791: ldftn instance void GCUv2.frmSalesInvoiceDO::frmSalesInvoiceDO_KeyDown(object, class KeyEventArgs)
          loc_499797: newobj instance void System.Windows.Forms.KeyEventHandler::.ctor(object, System.IntPtr)
          loc_49979C: call instance void System.Windows.Forms.Control::add_KeyDown(class KeyEventHandler)
          loc_4997A1: nop
          loc_4997A2: ldarg.0
          loc_4997A3: call instance void GCUv2.frmSalesInvoiceDO::InitializeComponent()
          loc_4997A8: nop
          loc_4997A9: ldarg.0
          loc_4997AA: ldarg.1
          loc_4997AB: stfld GCUv2.frmSalesInvoiceDO::_customerId
          loc_4997B0: ldarg.0
          loc_4997B1: ldarg.2
          loc_4997B2: stfld GCUv2.frmSalesInvoiceDO::_invoiceId
          loc_4997B7: ldarg.0
          loc_4997B8: call instance void GCUv2.frmSalesInvoiceDO::LoadData()
          loc_4997BD: nop
          loc_4997BE: ret
        }

        private void frmSalesInvoiceDO_KeyDown(object sender, class KeyEventArgs e) {

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
          int32 num_4;
          boolean var_2;
          int32 num_5;
          boolean var_3;
          boolean var_4;
          class GCUv2.cDeliveryOrder var_5;
          class GCUv2.frmSalesInvoice var_6;
          class ComboBox var_7;
          class GCUv2.cDeliveryOrderItem[] var_8;
          int32 num_6;
          class GCUv2.cDeliveryOrderItem var_9;
          class GCUv2.cItemPrintDetail var_10;
          double flt_1;
          boolean var_11;
          int32 num_7;
          boolean var_12;

        }

    }
}
