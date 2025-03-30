using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class DataGridView _dgvList;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_4A998B: ldarg.0
          loc_4A998C: ldfld GCUv2.frmReportCashBankDetail::_dgvList
          loc_4A9991: br.s loc_4A9993
          loc_4A9993: // Referenced from: loc_4A9991
          loc_4A9993: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class System.EventHandler var_1;
          class KeyEventHandler var_2;
          class DataGridView var_3;

        }

        public void frmReportCashBankDetail() {

          loc_4A99F3: nop
          loc_4A99F4: ldarg.0
          loc_4A99F5: call instance void System.Windows.Forms.Form::.ctor()
          loc_4A99FA: nop
          loc_4A99FB: ldarg.0
          loc_4A99FC: ldarg.0
          loc_4A99FD: ldftn instance void GCUv2.frmReportCashBankDetail::frmReportCashBankDetail_KeyDown(object, class KeyEventArgs)
          loc_4A9A03: newobj instance void System.Windows.Forms.KeyEventHandler::.ctor(object, System.IntPtr)
          loc_4A9A08: call instance void System.Windows.Forms.Control::add_KeyDown(class KeyEventHandler)
          loc_4A9A0D: nop
          loc_4A9A0E: ldarg.0
          loc_4A9A0F: call instance void GCUv2.frmReportCashBankDetail::InitializeComponent()
          loc_4A9A14: nop
          loc_4A9A15: ldarg.0
          loc_4A9A16: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_4A9A1B: callvirt instance class GCUv2.frmMenu GCUv2.frmReportCashBankDetail/MyForms::get_frmMenu()
          loc_4A9A20: call 
          loc_4A9A25: nop
          loc_4A9A26: ret
        }

        private void frmReportCashBankDetail_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void dgvList_DoubleClick(object sender, class System.EventArgs e) {

          loc_4A9A4E: nop
          loc_4A9A4F: ldarg.0
          loc_4A9A50: call instance void GCUv2.frmReportCashBankDetail::getData()
          loc_4A9A55: nop
          loc_4A9A56: ret
        }

        private void dgvList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void getData() {

          boolean var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;

        }

        public void LoadCustomerPayment(valuetype System.DateTime FirstDate, valuetype System.DateTime LastDate, int32 CashAccountId, int32 SalesId, int32 AreaId, int32 PaymentType) {

          class DataTable var_1;
          double flt_1;
          class System.Collections.IEnumerator var_2;
          class DataRow var_3;
          boolean var_4;

        }

        public void LoadSupplierPayment(valuetype System.DateTime FirstDate, valuetype System.DateTime LastDate, int32 CashAccountId, int32 SupplierId) {

          class DataTable var_1;
          double flt_1;
          class System.Collections.IEnumerator var_2;
          class DataRow var_3;
          boolean var_4;

        }

        private void FormatPaymentGrid(int32 CustomerSupplier) {

          boolean var_1;
          class System.Collections.IEnumerator var_2;
          object var_3;
          boolean var_4;

        }

    }
}
