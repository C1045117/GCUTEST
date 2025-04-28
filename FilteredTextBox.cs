using System;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class FilteredTextBox : TextBox
{
	public enum InputType
	{
		All,
		NumeralsOnly,
		LettersOnly,
		NumeralsAndCurrency,
		NoSymbols,
		NumeralsAndDotAndPlus
	}

	private InputType _allowedcharacters;

	private bool _isDecimal;

	private int _maximumDigit;

	private bool _dontFormat;

	public int MaximumDigit
	{
		get
		{
			return _maximumDigit;
		}
		set
		{
			_maximumDigit = value;
		}
	}

	public bool DontFormat
	{
		get
		{
			return _dontFormat;
		}
		set
		{
			_dontFormat = value;
		}
	}

	public InputType AllowedCharacters
	{
		get
		{
			return _allowedcharacters;
		}
		set
		{
			if (value >= InputType.NumeralsOnly && value <= InputType.NumeralsAndDotAndPlus)
			{
				_allowedcharacters = value;
			}
			else
			{
				_allowedcharacters = InputType.All;
			}
		}
	}

	public FilteredTextBox()
	{
		_isDecimal = false;
		_maximumDigit = 3;
		_dontFormat = false;
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		if (e.KeyValue == 110)
		{
			_isDecimal = true;
		}
		else
		{
			_isDecimal = false;
		}
	}

	protected override void OnKeyPress(KeyPressEventArgs e)
	{
		base.OnKeyPress(e);
		short num = checked((short)Strings.Asc(e.KeyChar));
		switch (_allowedcharacters)
		{
		case InputType.NumeralsOnly:
			if (!((num >= 48 && num <= 57) | (e.KeyChar == Convert.ToChar(8))))
			{
				e.Handled = true;
				Interaction.Beep();
			}
			break;
		case InputType.NumeralsAndCurrency:
			if (_isDecimal)
			{
				e.KeyChar = Conversions.ToChar(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
			}
			if (!(((num >= 48 && num <= 57) || num == 45) | (e.KeyChar == Convert.ToChar(8)) | (Operators.CompareString(Conversions.ToString(e.KeyChar), CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator, TextCompare: false) == 0)))
			{
				e.Handled = true;
			}
			break;
		case InputType.NumeralsAndDotAndPlus:
			if (!((num == 46 || num == 43 || (num >= 48 && num <= 57)) | (e.KeyChar == Convert.ToChar(8))))
			{
				e.Handled = true;
			}
			break;
		default:
			if (_isDecimal)
			{
				e.KeyChar = Conversions.ToChar(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
			}
			break;
		}
	}

	protected override void OnGotFocus(EventArgs e)
	{
		base.OnGotFocus(e);
		if ((Operators.CompareString(base.Text, "", TextCompare: false) != 0) & !_dontFormat)
		{
			base.Text = Conversions.ToString(decimal.Parse(base.Text, NumberStyles.Currency));
			if (!string.IsNullOrEmpty(base.Text))
			{
				base.SelectionStart = 0;
				base.SelectionLength = base.Text.Length;
			}
		}
	}

	protected override void OnLostFocus(EventArgs e)
	{
		base.OnLostFocus(e);
		if ((Operators.CompareString(base.Text, "", TextCompare: false) != 0) & !_dontFormat)
		{
			base.Text = Module1.formatCustomDecimal(base.Text, _maximumDigit);
		}
	}
}
