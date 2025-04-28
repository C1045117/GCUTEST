using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GCUv2.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

[DesignerGenerated]
public class frmSalesReturnList : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("tsbNew")]
	private ToolStripButton _tsbNew;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvList")]
	private DataGridView _dgvList;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("tsbRefresh")]
	private ToolStripButton _tsbRefresh;

	internal virtual ToolStripButton tsbNew
	{
		[CompilerGenerated]
		get
		{
			return _tsbNew;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = tsbNew_Click;
			ToolStripButton toolStripButton = _tsbNew;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value2;
			}
			_tsbNew = value;
			toolStripButton = _tsbNew;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("lblNote")]
	internal virtual Label lblNote
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStrip1")]
	internal virtual ToolStrip ToolStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView dgvList
	{
		[CompilerGenerated]
		get
		{
			return _dgvList;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = dgvList_KeyDown;
			EventHandler value3 = dgvList_DoubleClick;
			DataGridView dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.KeyDown -= value2;
				dataGridView.DoubleClick -= value3;
			}
			_dgvList = value;
			dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.KeyDown += value2;
				dataGridView.DoubleClick += value3;
			}
		}
	}

	internal virtual ToolStripButton tsbRefresh
	{
		[CompilerGenerated]
		get
		{
			return _tsbRefresh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = tsbRefresh_Click;
			ToolStripButton toolStripButton = _tsbRefresh;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value2;
			}
			_tsbRefresh = value;
			toolStripButton = _tsbRefresh;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value2;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GCUv2.frmSalesReturnList));
		this.tsbNew = new System.Windows.Forms.ToolStripButton();
		this.lblNote = new System.Windows.Forms.Label();
		this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
		this.ToolStrip1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.tsbNew.Image = (System.Drawing.Image)resources.GetObject("tsbNew.Image");
		this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.tsbNew.Name = "tsbNew";
		this.tsbNew.Size = new System.Drawing.Size(44, 57);
		this.tsbNew.Text = "&Baru";
		this.tsbNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.lblNote.AutoSize = true;
		this.lblNote.Location = new System.Drawing.Point(12, 62);
		this.lblNote.Name = "lblNote";
		this.lblNote.Size = new System.Drawing.Size(122, 13);
		this.lblNote.TabIndex = 19;
		this.lblNote.Text = "Retur Penjualan terbaru:";
		this.ToolStrip1.AutoSize = false;
		this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
		this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.tsbNew, this.tsbRefresh });
		this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
		this.ToolStrip1.Name = "ToolStrip1";
		this.ToolStrip1.Size = new System.Drawing.Size(533, 60);
		this.ToolStrip1.TabIndex = 17;
		this.ToolStrip1.Text = "ToolStrip1";
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(12, 79);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(509, 274);
		this.dgvList.TabIndex = 18;
		this.tsbRefresh.Image = (System.Drawing.Image)resources.GetObject("tsbRefresh.Image");
		this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.tsbRefresh.Name = "tsbRefresh";
		this.tsbRefresh.Size = new System.Drawing.Size(50, 57);
		this.tsbRefresh.Text = "&Refresh";
		this.tsbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(533, 364);
		base.Controls.Add(this.lblNote);
		base.Controls.Add(this.ToolStrip1);
		base.Controls.Add(this.dgvList);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSalesReturnList";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Retur Penjualan";
		this.ToolStrip1.ResumeLayout(false);
		this.ToolStrip1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSalesReturnList()
	{
		base.KeyDown += frmSalesReturnList_KeyDown;
		InitializeComponent();
		DoubleBuffered = true;
		base.MdiParent = MyProject.Forms.frmMenu;
		GetRecent();
	}

	private void frmSalesReturnList_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
		else if (e.KeyCode == Keys.F2)
		{
			tsbNew.PerformClick();
		}
		else if (e.KeyCode == Keys.F5)
		{
			tsbRefresh.PerformClick();
		}
	}

	public void GetRecent()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					DataTable dataTable = new DataTable();
					dataTable = cSalesInvoice.Search(2, DateAndTime.Now.AddDays(-90.0), DateAndTime.Now, 0, 0, 0, 0, "", 0.0, 0.0, 99, 1, 99, 99, 0, 0, Module1.pubGroupId, "DESC");
					FormatGrid();
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						dgvList.Rows.Add(dataRow["penjId"], dataRow["penjDate"], dataRow["custName"], dataRow["penjFaktur"], Module1.formatCustomDecimal(Conversions.ToString(dataRow["penjBs"]), 2));
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					lblNote.Text = "Retur Penjualan terbaru (" + Conversions.ToString(DateAndTime.Now) + ")";
					goto end_IL_0001;
				}
				case 348:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSalesReturnList", "GetRecent", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 348;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void FormatGrid()
	{
		dgvList.Columns.Clear();
		dgvList.Rows.Clear();
		dgvList.Columns.Add("", "penjId");
		dgvList.Columns.Add("", "Tanggal");
		dgvList.Columns.Add("", "Customer");
		dgvList.Columns.Add("", "No. Faktur");
		dgvList.Columns.Add("", "Total Harga");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[1].Width = 70;
		dgvList.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvList.Columns[2].Width = 220;
		dgvList.Columns[3].Width = 100;
		dgvList.Columns[4].Width = 80;
		dgvList.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.RowHeadersVisible = false;
		dgvList.AllowUserToAddRows = false;
		dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvList.ReadOnly = true;
		dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvList.AllowUserToResizeRows = false;
		dgvList.DefaultCellStyle.Font = new Font("Segoe UI", 8f, FontStyle.Regular);
	}

	private void dgvList_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			openSelection();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Delete)
		{
			e.SuppressKeyPress = true;
		}
	}

	private void dgvList_DoubleClick(object sender, EventArgs e)
	{
		openSelection();
	}

	private void openSelection()
	{
		if (dgvList.RowCount > 0 && Operators.ConditionalCompareObjectGreater(dgvList[0, dgvList.CurrentRow.Index].Value, 0, TextCompare: false))
		{
			MyProject.Forms.frmSalesReturn.Show();
			MyProject.Forms.frmSalesReturn.prepareForm(SaveNew: false);
			MyProject.Forms.frmSalesReturn.CurrentId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
			MyProject.Forms.frmSalesReturn.LoadData();
			MyProject.Forms.frmSalesReturn.Activate();
			MyProject.Forms.frmSalesReturn.WindowState = FormWindowState.Normal;
		}
	}

	private void tsbNew_Click(object sender, EventArgs e)
	{
		if (Module1.pubCreateSalesInvoice)
		{
			MyProject.Forms.frmSalesReturn.Show();
			MyProject.Forms.frmSalesReturn.prepareForm(SaveNew: false);
			MyProject.Forms.frmSalesReturn.Activate();
		}
		else
		{
			Interaction.MsgBox("Anda tidak memiliki hak untuk membuat Retur Penjualan.", MsgBoxStyle.Information);
		}
	}

	private void tsbRefresh_Click(object sender, EventArgs e)
	{
		GetRecent();
	}
}
