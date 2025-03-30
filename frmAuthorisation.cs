using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class GroupBox _GroupBox1;
        private class Button _btnAuthorise;
        private class TextBox _txtPassword;
        private class TextBox _txtUserName;
        private class Label _Label2;
        private class Label _Label1;
        private class Label _Label3;
        private class Label _Label4;
        private string _customerName;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class GroupBox get_GroupBox1() {

          loc_42EA22: ldarg.0
          loc_42EA23: ldfld GCUv2.frmAuthorisation::_GroupBox1
          loc_42EA28: br.s loc_42EA2A
          loc_42EA2A: // Referenced from: loc_42EA28
          loc_42EA2A: ret
        }

        assem override strict specialname void set_GroupBox1(class GroupBox WithEventsValue) {

          loc_42EA2C: ldarg.0
          loc_42EA2D: ldarg.1
          loc_42EA2E: stfld GCUv2.frmAuthorisation::_GroupBox1
          loc_42EA33: ret
        }

        assem override strict specialname class Button get_btnAuthorise() {

          loc_42EA35: ldarg.0
          loc_42EA36: ldfld GCUv2.frmAuthorisation::_btnAuthorise
          loc_42EA3B: br.s loc_42EA3D
          loc_42EA3D: // Referenced from: loc_42EA3B
          loc_42EA3D: ret
        }

        assem override strict specialname void set_btnAuthorise(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class TextBox get_txtPassword() {

          loc_42EA84: ldarg.0
          loc_42EA85: ldfld GCUv2.frmAuthorisation::_txtPassword
          loc_42EA8A: br.s loc_42EA8C
          loc_42EA8C: // Referenced from: loc_42EA8A
          loc_42EA8C: ret
        }

        assem override strict specialname void set_txtPassword(class TextBox WithEventsValue) {

          loc_42EA8E: ldarg.0
          loc_42EA8F: ldarg.1
          loc_42EA90: stfld GCUv2.frmAuthorisation::_txtPassword
          loc_42EA95: ret
        }

        assem override strict specialname class TextBox get_txtUserName() {

          loc_42EA97: ldarg.0
          loc_42EA98: ldfld GCUv2.frmAuthorisation::_txtUserName
          loc_42EA9D: br.s loc_42EA9F
          loc_42EA9F: // Referenced from: loc_42EA9D
          loc_42EA9F: ret
        }

        assem override strict specialname void set_txtUserName(class TextBox WithEventsValue) {

          loc_42EAA1: ldarg.0
          loc_42EAA2: ldarg.1
          loc_42EAA3: stfld GCUv2.frmAuthorisation::_txtUserName
          loc_42EAA8: ret
        }

        assem override strict specialname class Label get_Label2() {

          loc_42EAAA: ldarg.0
          loc_42EAAB: ldfld GCUv2.frmAuthorisation::_Label2
          loc_42EAB0: br.s loc_42EAB2
          loc_42EAB2: // Referenced from: loc_42EAB0
          loc_42EAB2: ret
        }

        assem override strict specialname void set_Label2(class Label WithEventsValue) {

          loc_42EAB4: ldarg.0
          loc_42EAB5: ldarg.1
          loc_42EAB6: stfld GCUv2.frmAuthorisation::_Label2
          loc_42EABB: ret
        }

        assem override strict specialname class Label get_Label1() {

          loc_42EABD: ldarg.0
          loc_42EABE: ldfld GCUv2.frmAuthorisation::_Label1
          loc_42EAC3: br.s loc_42EAC5
          loc_42EAC5: // Referenced from: loc_42EAC3
          loc_42EAC5: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_42EAC7: ldarg.0
          loc_42EAC8: ldarg.1
          loc_42EAC9: stfld GCUv2.frmAuthorisation::_Label1
          loc_42EACE: ret
        }

        assem override strict specialname class Label get_Label3() {

          loc_42EAD0: ldarg.0
          loc_42EAD1: ldfld GCUv2.frmAuthorisation::_Label3
          loc_42EAD6: br.s loc_42EAD8
          loc_42EAD8: // Referenced from: loc_42EAD6
          loc_42EAD8: ret
        }

        assem override strict specialname void set_Label3(class Label WithEventsValue) {

          loc_42EADA: ldarg.0
          loc_42EADB: ldarg.1
          loc_42EADC: stfld GCUv2.frmAuthorisation::_Label3
          loc_42EAE1: ret
        }

        assem override strict specialname class Label get_Label4() {

          loc_42EAE3: ldarg.0
          loc_42EAE4: ldfld GCUv2.frmAuthorisation::_Label4
          loc_42EAE9: br.s loc_42EAEB
          loc_42EAEB: // Referenced from: loc_42EAE9
          loc_42EAEB: ret
        }

        assem override strict specialname void set_Label4(class Label WithEventsValue) {

          loc_42EAED: ldarg.0
          loc_42EAEE: ldarg.1
          loc_42EAEF: stfld GCUv2.frmAuthorisation::_Label4
          loc_42EAF4: ret
        }

        public void frmAuthorisation(string CustomerName) {


        }

        private void frmAuthorisation_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void btnAuthorise_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          class DataTable var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          class GCUv2.cHistory var_6;

        }

    }
}
