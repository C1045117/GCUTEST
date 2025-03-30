using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class TabControl _TabControl1;
        private class TabPage _TabPage1;
        private class Button _btnUserManual;
        private class Label _lblCompany;
        private class Label _lblLogin;
        private class Label _lblActivity;
        private class WebBrowser _WebBrowser1;
        private class Label _lblVersion;
        private class DataGridView _dgvActivity;
        private class TabPage _TabPage2;
        private class Label _Label1;
        private class DataGridView _dgvMinimumStock;
        private class ComponentModel.BackgroundWorker _BackgroundWorker1;
        private class Timer _tmrInformation;
        private class Label _lblLatestStockUpdate;
        private class ComponentModel.BackgroundWorker _BackgroundWorkerActivity;
        private class GroupBox _GroupBox1;
        private class Button _btnConnect;
        private class Label _Label2;
        private int32 intTimer;

        private struct StockBelowMinimum
        {
            public string ItemName;
            public string BranchName;
            public double MinimumStock;
            public double CurrentStock;
        }


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {

          class DataGridViewCellStyle var_1;

        }

        assem override strict specialname class TabControl get_TabControl1() {

          loc_44F590: ldarg.0
          loc_44F591: ldfld GCUv2.frmInformation::_TabControl1
          loc_44F596: br.s loc_44F598
          loc_44F598: // Referenced from: loc_44F596
          loc_44F598: ret
        }

        assem override strict specialname void set_TabControl1(class TabControl WithEventsValue) {

          class System.EventHandler var_1;
          class TabControl var_2;

        }

        assem override strict specialname class TabPage get_TabPage1() {

          loc_44F5E0: ldarg.0
          loc_44F5E1: ldfld GCUv2.frmInformation::_TabPage1
          loc_44F5E6: br.s loc_44F5E8
          loc_44F5E8: // Referenced from: loc_44F5E6
          loc_44F5E8: ret
        }

        assem override strict specialname void set_TabPage1(class TabPage WithEventsValue) {

          loc_44F5EA: ldarg.0
          loc_44F5EB: ldarg.1
          loc_44F5EC: stfld GCUv2.frmInformation::_TabPage1
          loc_44F5F1: ret
        }

        assem override strict specialname class Button get_btnUserManual() {

          loc_44F5F3: ldarg.0
          loc_44F5F4: ldfld GCUv2.frmInformation::_btnUserManual
          loc_44F5F9: br.s loc_44F5FB
          loc_44F5FB: // Referenced from: loc_44F5F9
          loc_44F5FB: ret
        }

        assem override strict specialname void set_btnUserManual(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_lblCompany() {

          loc_44F640: ldarg.0
          loc_44F641: ldfld GCUv2.frmInformation::_lblCompany
          loc_44F646: br.s loc_44F648
          loc_44F648: // Referenced from: loc_44F646
          loc_44F648: ret
        }

        assem override strict specialname void set_lblCompany(class Label WithEventsValue) {

          loc_44F64A: ldarg.0
          loc_44F64B: ldarg.1
          loc_44F64C: stfld GCUv2.frmInformation::_lblCompany
          loc_44F651: ret
        }

        assem override strict specialname class Label get_lblLogin() {

          loc_44F653: ldarg.0
          loc_44F654: ldfld GCUv2.frmInformation::_lblLogin
          loc_44F659: br.s loc_44F65B
          loc_44F65B: // Referenced from: loc_44F659
          loc_44F65B: ret
        }

        assem override strict specialname void set_lblLogin(class Label WithEventsValue) {

          loc_44F65D: ldarg.0
          loc_44F65E: ldarg.1
          loc_44F65F: stfld GCUv2.frmInformation::_lblLogin
          loc_44F664: ret
        }

        assem override strict specialname class Label get_lblActivity() {

          loc_44F666: ldarg.0
          loc_44F667: ldfld GCUv2.frmInformation::_lblActivity
          loc_44F66C: br.s loc_44F66E
          loc_44F66E: // Referenced from: loc_44F66C
          loc_44F66E: ret
        }

        assem override strict specialname void set_lblActivity(class Label WithEventsValue) {

          loc_44F670: ldarg.0
          loc_44F671: ldarg.1
          loc_44F672: stfld GCUv2.frmInformation::_lblActivity
          loc_44F677: ret
        }

        assem override strict specialname class WebBrowser get_WebBrowser1() {

          loc_44F679: ldarg.0
          loc_44F67A: ldfld GCUv2.frmInformation::_WebBrowser1
          loc_44F67F: br.s loc_44F681
          loc_44F681: // Referenced from: loc_44F67F
          loc_44F681: ret
        }

        assem override strict specialname void set_WebBrowser1(class WebBrowser WithEventsValue) {

          loc_44F683: ldarg.0
          loc_44F684: ldarg.1
          loc_44F685: stfld GCUv2.frmInformation::_WebBrowser1
          loc_44F68A: ret
        }

        assem override strict specialname class Label get_lblVersion() {

          loc_44F68C: ldarg.0
          loc_44F68D: ldfld GCUv2.frmInformation::_lblVersion
          loc_44F692: br.s loc_44F694
          loc_44F694: // Referenced from: loc_44F692
          loc_44F694: ret
        }

        assem override strict specialname void set_lblVersion(class Label WithEventsValue) {

          loc_44F696: ldarg.0
          loc_44F697: ldarg.1
          loc_44F698: stfld GCUv2.frmInformation::_lblVersion
          loc_44F69D: ret
        }

        assem override strict specialname class DataGridView get_dgvActivity() {

          loc_44F69F: ldarg.0
          loc_44F6A0: ldfld GCUv2.frmInformation::_dgvActivity
          loc_44F6A5: br.s loc_44F6A7
          loc_44F6A7: // Referenced from: loc_44F6A5
          loc_44F6A7: ret
        }

        assem override strict specialname void set_dgvActivity(class DataGridView WithEventsValue) {

          class KeyEventHandler var_1;
          class System.EventHandler var_2;
          class System.EventHandler var_3;
          class DataGridView var_4;

        }

        assem override strict specialname class TabPage get_TabPage2() {

          loc_44F722: ldarg.0
          loc_44F723: ldfld GCUv2.frmInformation::_TabPage2
          loc_44F728: br.s loc_44F72A
          loc_44F72A: // Referenced from: loc_44F728
          loc_44F72A: ret
        }

        assem override strict specialname void set_TabPage2(class TabPage WithEventsValue) {

          loc_44F72C: ldarg.0
          loc_44F72D: ldarg.1
          loc_44F72E: stfld GCUv2.frmInformation::_TabPage2
          loc_44F733: ret
        }

        assem override strict specialname class Label get_Label1() {

          loc_44F735: ldarg.0
          loc_44F736: ldfld GCUv2.frmInformation::_Label1
          loc_44F73B: br.s loc_44F73D
          loc_44F73D: // Referenced from: loc_44F73B
          loc_44F73D: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_44F73F: ldarg.0
          loc_44F740: ldarg.1
          loc_44F741: stfld GCUv2.frmInformation::_Label1
          loc_44F746: ret
        }

        assem override strict specialname class DataGridView get_dgvMinimumStock() {

          loc_44F748: ldarg.0
          loc_44F749: ldfld GCUv2.frmInformation::_dgvMinimumStock
          loc_44F74E: br.s loc_44F750
          loc_44F750: // Referenced from: loc_44F74E
          loc_44F750: ret
        }

        assem override strict specialname void set_dgvMinimumStock(class DataGridView WithEventsValue) {

          class KeyEventHandler var_1;
          class System.EventHandler var_2;
          class System.EventHandler var_3;
          class DataGridView var_4;

        }

        assem override strict specialname class ComponentModel.BackgroundWorker get_BackgroundWorker1() {

          loc_44F7CE: ldarg.0
          loc_44F7CF: ldfld GCUv2.frmInformation::_BackgroundWorker1
          loc_44F7D4: br.s loc_44F7D6
          loc_44F7D6: // Referenced from: loc_44F7D4
          loc_44F7D6: ret
        }

        assem override strict specialname void set_BackgroundWorker1(class ComponentModel.BackgroundWorker WithEventsValue) {

          class ComponentModel.DoWorkEventHandler var_1;
          class ComponentModel.ProgressChangedEventHandler var_2;
          class ComponentModel.RunWorkerCompletedEventHandler var_3;
          class ComponentModel.BackgroundWorker var_4;

        }

        assem override strict specialname class Timer get_tmrInformation() {

          loc_44F852: ldarg.0
          loc_44F853: ldfld GCUv2.frmInformation::_tmrInformation
          loc_44F858: br.s loc_44F85A
          loc_44F85A: // Referenced from: loc_44F858
          loc_44F85A: ret
        }

        assem override strict specialname void set_tmrInformation(class Timer WithEventsValue) {

          class System.EventHandler var_1;
          class Timer var_2;

        }

        assem override strict specialname class Label get_lblLatestStockUpdate() {

          loc_44F8A0: ldarg.0
          loc_44F8A1: ldfld GCUv2.frmInformation::_lblLatestStockUpdate
          loc_44F8A6: br.s loc_44F8A8
          loc_44F8A8: // Referenced from: loc_44F8A6
          loc_44F8A8: ret
        }

        assem override strict specialname void set_lblLatestStockUpdate(class Label WithEventsValue) {

          loc_44F8AA: ldarg.0
          loc_44F8AB: ldarg.1
          loc_44F8AC: stfld GCUv2.frmInformation::_lblLatestStockUpdate
          loc_44F8B1: ret
        }

        assem override strict specialname class ComponentModel.BackgroundWorker get_BackgroundWorkerActivity() {

          loc_44F8B3: ldarg.0
          loc_44F8B4: ldfld GCUv2.frmInformation::_BackgroundWorkerActivity
          loc_44F8B9: br.s loc_44F8BB
          loc_44F8BB: // Referenced from: loc_44F8B9
          loc_44F8BB: ret
        }

        assem override strict specialname void set_BackgroundWorkerActivity(class ComponentModel.BackgroundWorker WithEventsValue) {

          class ComponentModel.DoWorkEventHandler var_1;
          class ComponentModel.ProgressChangedEventHandler var_2;
          class ComponentModel.RunWorkerCompletedEventHandler var_3;
          class ComponentModel.BackgroundWorker var_4;

        }

        assem override strict specialname class GroupBox get_GroupBox1() {

          loc_44F936: ldarg.0
          loc_44F937: ldfld GCUv2.frmInformation::_GroupBox1
          loc_44F93C: br.s loc_44F93E
          loc_44F93E: // Referenced from: loc_44F93C
          loc_44F93E: ret
        }

        assem override strict specialname void set_GroupBox1(class GroupBox WithEventsValue) {

          loc_44F940: ldarg.0
          loc_44F941: ldarg.1
          loc_44F942: stfld GCUv2.frmInformation::_GroupBox1
          loc_44F947: ret
        }

        assem override strict specialname class Button get_btnConnect() {

          loc_44F949: ldarg.0
          loc_44F94A: ldfld GCUv2.frmInformation::_btnConnect
          loc_44F94F: br.s loc_44F951
          loc_44F951: // Referenced from: loc_44F94F
          loc_44F951: ret
        }

        assem override strict specialname void set_btnConnect(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_Label2() {

          loc_44F998: ldarg.0
          loc_44F999: ldfld GCUv2.frmInformation::_Label2
          loc_44F99E: br.s loc_44F9A0
          loc_44F9A0: // Referenced from: loc_44F99E
          loc_44F9A0: ret
        }

        assem override strict specialname void set_Label2(class Label WithEventsValue) {

          loc_44F9A2: ldarg.0
          loc_44F9A3: ldarg.1
          loc_44F9A4: stfld GCUv2.frmInformation::_Label2
          loc_44F9A9: ret
        }

        public void frmInformation() {


        }

        private void frmInformation_Load(object sender, class System.EventArgs e) {

          string str_1;

        }

        public void GetActivity() {

          int32 num_1;
          int32 num_2;
          boolean var_1;

        }

        private void BackgroundWorkerActivity_DoWork(object sender, class ComponentModel.DoWorkEventArgs e) {

          int32 num_1;
          int32 num_2;
          class DataTable var_1;
          string str_1;
          valuetype System.DateTime var_2;
          boolean var_3;
          class System.Collections.IEnumerator var_4;
          class DataRow var_5;
          boolean var_6;

        }

        private void BackgroundWorkerActivity_ProgressChanged(object sender, class ComponentModel.ProgressChangedEventArgs e) {

          int32 num_1;
          int32 num_2;
          int32 num_3;
          class DataRow var_1;
          boolean var_2;

        }

        private void BackgroundWorkerActivity_RunWorkerCompleted(object sender, class ComponentModel.RunWorkerCompletedEventArgs e) {

          boolean var_1;

        }

        private void GetAnnouncement() {

          int32 num_1;
          int32 num_2;
          string str_1;
          class DataTable var_1;
          string str_2;
          class System.Collections.IEnumerator var_2;
          class DataRow var_3;
          boolean var_4;
          boolean var_5;

        }

        private void TestError() {

          int32 num_1;
          int32 num_2;

        }

        private void tmrInformation_Tick(object sender, class System.EventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;

        }

        private void TabControl1_SelectedIndexChanged(object sender, class System.EventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;

        }

        private void dgvActivity_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void dgvMinimumStock_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void dgvActivity_GotFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvActivity_LostFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvMinimumStock_GotFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvMinimumStock_LostFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void btnUserManual_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;

        }

        private void BackgroundWorker1_DoWork(object sender, class ComponentModel.DoWorkEventArgs e) {

          int32 num_1;
          int32 num_2;
          double flt_1;
          class DataTable var_1;
          string str_1;
          valuetype StockBelowMinimum var_2;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          valuetype System.DateTime var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;

        }

        private void BackgroundWorker1_ProgressChanged(object sender, class ComponentModel.ProgressChangedEventArgs e) {

          valuetype StockBelowMinimum var_1;
          valuetype StockBelowMinimum var_2;
          boolean var_3;

        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, class ComponentModel.RunWorkerCompletedEventArgs e) {

          boolean var_1;

        }

        private void btnConnect_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

    }
}
