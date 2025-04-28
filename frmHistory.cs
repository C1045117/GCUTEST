using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GCUv2.My;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

[DesignerGenerated]
public class frmHistory : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WebBrowser1")]
	private WebBrowser _WebBrowser1;

	internal virtual WebBrowser WebBrowser1
	{
		[CompilerGenerated]
		get
		{
			return _WebBrowser1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PreviewKeyDownEventHandler value2 = WebBrowser1_PreviewKeyDown;
			WebBrowser webBrowser = _WebBrowser1;
			if (webBrowser != null)
			{
				webBrowser.PreviewKeyDown -= value2;
			}
			_WebBrowser1 = value;
			webBrowser = _WebBrowser1;
			if (webBrowser != null)
			{
				webBrowser.PreviewKeyDown += value2;
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
		base.SuspendLayout();
		this.WebBrowser1.Location = new System.Drawing.Point(12, 12);
		this.WebBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
		this.WebBrowser1.Name = "WebBrowser1";
		this.WebBrowser1.Size = new System.Drawing.Size(667, 308);
		this.WebBrowser1.TabIndex = 2;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(692, 359);
		base.Controls.Add(this.WebBrowser1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmHistory";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "History";
		base.ResumeLayout(false);
	}

	public frmHistory()
	{
		base.KeyDown += frmHistory_KeyDown;
		InitializeComponent();
		DoubleBuffered = true;
		base.MdiParent = MyProject.Forms.frmMenu;
		WebBrowser1.Focus();
	}

	private void frmHistory_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void WebBrowser1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	public void GetHistory(int intFkeyId, int HistoryType)
	{
		DataTable history = cHistory.GetHistory(intFkeyId, HistoryType);
		string text = "<style type='text/css'>html{font-size:12px; }table, th, td {font-size:12px; padding:2px; margin:0; border: 1px solid black;}</style>";
		foreach (DataRow row in history.Rows)
		{
			text += "===============================================================<br />";
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Disimpan oleh: ", row["userLogin"]), "; Waktu: "), row["histDate"]), "<br />")));
			text = Conversions.ToString(Operators.ConcatenateObject(text, row["histContent"]));
			text += "<br />";
		}
		WebBrowser1.DocumentText = text;
		WebBrowser1.Focus();
	}
}
