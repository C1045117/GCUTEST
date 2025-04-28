using System;

namespace GCUv2;

public class cPurchaseInvoiceReturn
{
	private double _id;

	private string _number;

	private double _amount;

	private DateTime _invoiceDate;

	public double Id
	{
		get
		{
			return _id;
		}
		set
		{
			_id = value;
		}
	}

	public string Number
	{
		get
		{
			return _number;
		}
		set
		{
			_number = value;
		}
	}

	public double Amount
	{
		get
		{
			return _amount;
		}
		set
		{
			_amount = value;
		}
	}

	public DateTime InvoiceDate
	{
		get
		{
			return _invoiceDate;
		}
		set
		{
			_invoiceDate = value;
		}
	}
}
