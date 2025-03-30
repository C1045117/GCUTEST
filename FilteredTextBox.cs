namespace GCUv2
{
    public class TextBox
    {

        private valuetype InputType _allowedcharacters;
        private boolean _isDecimal;
        private int32 _maximumDigit;
        private boolean _dontFormat;

        public enum InputType
        {
            public const valuetype InputType All = 0,
            public const valuetype InputType NumeralsOnly = 1,
            public const valuetype InputType LettersOnly = 2,
            public const valuetype InputType NumeralsAndCurrency = 3,
            public const valuetype InputType NoSymbols = 4,
            public const valuetype InputType NumeralsAndDotAndPlus = 5
        }


        public void FilteredTextBox() {

          loc_428F77: ldarg.0
          loc_428F78: call instance void System.Windows.Forms.TextBox::.ctor()
          loc_428F7D: nop
          loc_428F7E: ldarg.0
          loc_428F7F: ldc.i4.0
          loc_428F80: stfld GCUv2.FilteredTextBox::_isDecimal
          loc_428F85: ldarg.0
          loc_428F86: ldc.i4.3
          loc_428F87: stfld GCUv2.FilteredTextBox::_maximumDigit
          loc_428F8C: ldarg.0
          loc_428F8D: ldc.i4.0
          loc_428F8E: stfld GCUv2.FilteredTextBox::_dontFormat
          loc_428F93: ret
        }

        public specialname int32 get_MaximumDigit() {

          int32 num_1;

        }

        public specialname void set_MaximumDigit(int32 value) {

          loc_428FAD: nop
          loc_428FAE: ldarg.0
          loc_428FAF: ldarg.1
          loc_428FB0: stfld GCUv2.FilteredTextBox::_maximumDigit
          loc_428FB5: ret
        }

        public specialname boolean get_DontFormat() {

          boolean var_1;

        }

        public specialname void set_DontFormat(boolean value) {

          loc_428FD1: nop
          loc_428FD2: ldarg.0
          loc_428FD3: ldarg.1
          loc_428FD4: stfld GCUv2.FilteredTextBox::_dontFormat
          loc_428FD9: ret
        }

        public specialname valuetype InputType get_AllowedCharacters() {

          valuetype InputType var_1;

        }

        public specialname void set_AllowedCharacters(valuetype InputType Value) {

          valuetype InputType var_1;
          boolean var_2;

        }

        protected override strict void OnKeyDown(class KeyEventArgs e) {

          boolean var_1;

        }

        protected override strict void OnKeyPress(class KeyPressEventArgs e) {

          int16 num_1;
          valuetype InputType var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;

        }

        protected override strict void OnGotFocus(class System.EventArgs e) {

          boolean var_1;
          boolean var_2;

        }

        protected override strict void OnLostFocus(class System.EventArgs e) {

          boolean var_1;

        }

    }
}
