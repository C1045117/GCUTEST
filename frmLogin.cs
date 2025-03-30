using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Label _Label1;
        private class Label _Label2;
        private class Label _lblHostRead;
        private class Label _lblHostUpdate;
        private class Label _lblDbMarketing;
        private class Label _lblDbHistory;
        private class TextBox _txtUserName;
        private class TextBox _txtPassword;
        private class TextBox _txtHostRead;
        private class TextBox _txtHostUpdate;
        private class TextBox _txtDbData;
        private class TextBox _txtDbHistory;
        private class Button _btnLogin;
        private class Timer _Timer1;


        public void frmLogin() {

          loc_454894: ldarg.0
          loc_454895: call instance void System.Windows.Forms.Form::.ctor()
          loc_45489A: ldarg.0
          loc_45489B: ldarg.0
          loc_45489C: ldftn instance void GCUv2.frmLogin::frmLogin_KeyDown(object, class KeyEventArgs)
          loc_4548A2: newobj instance void System.Windows.Forms.KeyEventHandler::.ctor(object, System.IntPtr)
          loc_4548A7: call instance void System.Windows.Forms.Control::add_KeyDown(class KeyEventHandler)
          loc_4548AC: ldarg.0
          loc_4548AD: ldarg.0
          loc_4548AE: ldftn instance void GCUv2.frmLogin::frmLogin_Load(object, class System.EventArgs)
          loc_4548B4: newobj instance void System.EventHandler::.ctor(object, System.IntPtr)
          loc_4548B9: call instance void System.Windows.Forms.Form::add_Load(class System.EventHandler)
          loc_4548BE: ldarg.0
          loc_4548BF: call instance void GCUv2.frmLogin::InitializeComponent()
          loc_4548C4: ret
        }

        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Label get_Label1() {

          loc_45507F: ldarg.0
          loc_455080: ldfld GCUv2.frmLogin::_Label1
          loc_455085: br.s loc_455087
          loc_455087: // Referenced from: loc_455085
          loc_455087: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_455089: ldarg.0
          loc_45508A: ldarg.1
          loc_45508B: stfld GCUv2.frmLogin::_Label1
          loc_455090: ret
        }

        assem override strict specialname class Label get_Label2() {

          loc_455092: ldarg.0
          loc_455093: ldfld GCUv2.frmLogin::_Label2
          loc_455098: br.s loc_45509A
          loc_45509A: // Referenced from: loc_455098
          loc_45509A: ret
        }

        assem override strict specialname void set_Label2(class Label WithEventsValue) {

          loc_45509C: ldarg.0
          loc_45509D: ldarg.1
          loc_45509E: stfld GCUv2.frmLogin::_Label2
          loc_4550A3: ret
        }

        assem override strict specialname class Label get_lblHostRead() {

          loc_4550A5: ldarg.0
          loc_4550A6: ldfld GCUv2.frmLogin::_lblHostRead
          loc_4550AB: br.s loc_4550AD
          loc_4550AD: // Referenced from: loc_4550AB
          loc_4550AD: ret
        }

        assem override strict specialname void set_lblHostRead(class Label WithEventsValue) {

          loc_4550AF: ldarg.0
          loc_4550B0: ldarg.1
          loc_4550B1: stfld GCUv2.frmLogin::_lblHostRead
          loc_4550B6: ret
        }

        assem override strict specialname class Label get_lblHostUpdate() {

          loc_4550B8: ldarg.0
          loc_4550B9: ldfld GCUv2.frmLogin::_lblHostUpdate
          loc_4550BE: br.s loc_4550C0
          loc_4550C0: // Referenced from: loc_4550BE
          loc_4550C0: ret
        }

        assem override strict specialname void set_lblHostUpdate(class Label WithEventsValue) {

          loc_4550C2: ldarg.0
          loc_4550C3: ldarg.1
          loc_4550C4: stfld GCUv2.frmLogin::_lblHostUpdate
          loc_4550C9: ret
        }

        assem override strict specialname class Label get_lblDbMarketing() {

          loc_4550CB: ldarg.0
          loc_4550CC: ldfld GCUv2.frmLogin::_lblDbMarketing
          loc_4550D1: br.s loc_4550D3
          loc_4550D3: // Referenced from: loc_4550D1
          loc_4550D3: ret
        }

        assem override strict specialname void set_lblDbMarketing(class Label WithEventsValue) {

          loc_4550D5: ldarg.0
          loc_4550D6: ldarg.1
          loc_4550D7: stfld GCUv2.frmLogin::_lblDbMarketing
          loc_4550DC: ret
        }

        assem override strict specialname class Label get_lblDbHistory() {

          loc_4550DE: ldarg.0
          loc_4550DF: ldfld GCUv2.frmLogin::_lblDbHistory
          loc_4550E4: br.s loc_4550E6
          loc_4550E6: // Referenced from: loc_4550E4
          loc_4550E6: ret
        }

        assem override strict specialname void set_lblDbHistory(class Label WithEventsValue) {

          loc_4550E8: ldarg.0
          loc_4550E9: ldarg.1
          loc_4550EA: stfld GCUv2.frmLogin::_lblDbHistory
          loc_4550EF: ret
        }

        assem override strict specialname class TextBox get_txtUserName() {

          loc_4550F1: ldarg.0
          loc_4550F2: ldfld GCUv2.frmLogin::_txtUserName
          loc_4550F7: br.s loc_4550F9
          loc_4550F9: // Referenced from: loc_4550F7
          loc_4550F9: ret
        }

        assem override strict specialname void set_txtUserName(class TextBox WithEventsValue) {

          loc_4550FB: ldarg.0
          loc_4550FC: ldarg.1
          loc_4550FD: stfld GCUv2.frmLogin::_txtUserName
          loc_455102: ret
        }

        assem override strict specialname class TextBox get_txtPassword() {

          loc_455104: ldarg.0
          loc_455105: ldfld GCUv2.frmLogin::_txtPassword
          loc_45510A: br.s loc_45510C
          loc_45510C: // Referenced from: loc_45510A
          loc_45510C: ret
        }

        assem override strict specialname void set_txtPassword(class TextBox WithEventsValue) {

          loc_45510E: ldarg.0
          loc_45510F: ldarg.1
          loc_455110: stfld GCUv2.frmLogin::_txtPassword
          loc_455115: ret
        }

        assem override strict specialname class TextBox get_txtHostRead() {

          loc_455117: ldarg.0
          loc_455118: ldfld GCUv2.frmLogin::_txtHostRead
          loc_45511D: br.s loc_45511F
          loc_45511F: // Referenced from: loc_45511D
          loc_45511F: ret
        }

        assem override strict specialname void set_txtHostRead(class TextBox WithEventsValue) {

          loc_455121: ldarg.0
          loc_455122: ldarg.1
          loc_455123: stfld GCUv2.frmLogin::_txtHostRead
          loc_455128: ret
        }

        assem override strict specialname class TextBox get_txtHostUpdate() {

          loc_45512A: ldarg.0
          loc_45512B: ldfld GCUv2.frmLogin::_txtHostUpdate
          loc_455130: br.s loc_455132
          loc_455132: // Referenced from: loc_455130
          loc_455132: ret
        }

        assem override strict specialname void set_txtHostUpdate(class TextBox WithEventsValue) {

          loc_455134: ldarg.0
          loc_455135: ldarg.1
          loc_455136: stfld GCUv2.frmLogin::_txtHostUpdate
          loc_45513B: ret
        }

        assem override strict specialname class TextBox get_txtDbData() {

          loc_45513D: ldarg.0
          loc_45513E: ldfld GCUv2.frmLogin::_txtDbData
          loc_455143: br.s loc_455145
          loc_455145: // Referenced from: loc_455143
          loc_455145: ret
        }

        assem override strict specialname void set_txtDbData(class TextBox WithEventsValue) {

          loc_455147: ldarg.0
          loc_455148: ldarg.1
          loc_455149: stfld GCUv2.frmLogin::_txtDbData
          loc_45514E: ret
        }

        assem override strict specialname class TextBox get_txtDbHistory() {

          loc_455150: ldarg.0
          loc_455151: ldfld GCUv2.frmLogin::_txtDbHistory
          loc_455156: br.s loc_455158
          loc_455158: // Referenced from: loc_455156
          loc_455158: ret
        }

        assem override strict specialname void set_txtDbHistory(class TextBox WithEventsValue) {

          loc_45515A: ldarg.0
          loc_45515B: ldarg.1
          loc_45515C: stfld GCUv2.frmLogin::_txtDbHistory
          loc_455161: ret
        }

        assem override strict specialname class Button get_btnLogin() {

          loc_455163: ldarg.0
          loc_455164: ldfld GCUv2.frmLogin::_btnLogin
          loc_455169: br.s loc_45516B
          loc_45516B: // Referenced from: loc_455169
          loc_45516B: ret
        }

        assem override strict specialname void set_btnLogin(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Timer get_Timer1() {

          loc_4551B0: ldarg.0
          loc_4551B1: ldfld GCUv2.frmLogin::_Timer1
          loc_4551B6: br.s loc_4551B8
          loc_4551B8: // Referenced from: loc_4551B6
          loc_4551B8: ret
        }

        assem override strict specialname void set_Timer1(class Timer WithEventsValue) {

          class System.EventHandler var_1;
          class Timer var_2;

        }

        private void btnLogin_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          class DataTable var_1;
          class DataTable var_2;
          string str_1;
          string str_2;
          string str_3;
          boolean var_3;
          int32 num_3;
          string str_4;
          string str_5;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;
          boolean var_9;
          valuetype System.DateTime var_10;
          boolean var_11;
          boolean var_12;
          string str_6;
          class GCUv2.cHistory var_13;
          class System.Collections.IEnumerator var_14;
          class DataRow var_15;
          boolean var_16;
          boolean var_17;
          boolean var_18;
          boolean var_19;
          boolean var_20;
          boolean var_21;
          boolean var_22;
          boolean var_23;
          boolean var_24;
          boolean var_25;
          boolean var_26;
          boolean var_27;
          boolean var_28;
          boolean var_29;
          boolean var_30;
          boolean var_31;
          boolean var_32;
          boolean var_33;
          boolean var_34;
          boolean var_35;
          boolean var_36;
          boolean var_37;
          class DataRow var_38;
          object[] var_39;
          boolean[] var_40;
          boolean var_41;
          boolean var_42;
          boolean var_43;
          boolean var_44;
          boolean var_45;
          class System.Collections.IEnumerator var_46;
          class DataRow var_47;
          boolean var_48;
          boolean var_49;
          boolean var_50;
          boolean var_51;
          boolean var_52;
          boolean var_53;
          boolean var_54;
          boolean var_55;
          boolean var_56;
          boolean var_57;
          boolean var_58;
          string str_7;
          boolean var_59;
          boolean var_60;
          class GCUv2.cHistory var_61;

        }

        private void frmLogin_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;

        }

        private void frmLogin_Load(object sender, class System.EventArgs e) {

          class System.Collections.ObjectModel.ReadOnlyCollection<string> var_1;
          class FileIO.TextFieldParser var_2;
          string[] var_3;
          boolean var_4;
          string str_1;
          string str_2;
          class DataTable var_5;
          class System.Collections.IEnumerator var_6;
          class DataRow var_7;
          boolean var_8;
          boolean var_9;
          boolean var_10;
          boolean var_11;

        }

        private void Timer1_Tick(object sender, class System.EventArgs e) {

          loc_4563D1: nop
          loc_4563D2: ldarg.0
          loc_4563D3: call instance void GCUv2.frmLogin::checkDbServer()
          loc_4563D8: nop
          loc_4563D9: ret
        }

        private void checkDbServer() {

          boolean var_1;

        }

    }
}
