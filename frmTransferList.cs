using System;
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
public class frmTransferList : Form
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

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BackgroundWorker1")]
	private BackgroundWorker _BackgroundWorker1;

	[field: AccessedThroughProperty("ToolStrip1")]
	internal virtual ToolStrip ToolStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

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
			EventHandler value2 = tsbAdd_Click;
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

	[field: AccessedThroughProperty("lblTitle")]
	internal virtual Label lblTitle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	internal virtual BackgroundWorker BackgroundWorker1
	{
		[CompilerGenerated]
		get
		{
			return _BackgroundWorker1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = BackgroundWorker1_DoWork;
			ProgressChangedEventHandler value3 = BackgroundWorker1_ProgressChanged;
			RunWorkerCompletedEventHandler value4 = BackgroundWorker1_RunWorkerCompleted;
			BackgroundWorker backgroundWorker = _BackgroundWorker1;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
				backgroundWorker.ProgressChanged -= value3;
				backgroundWorker.RunWorkerCompleted -= value4;
			}
			_BackgroundWorker1 = value;
			backgroundWorker = _BackgroundWorker1;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
				backgroundWorker.ProgressChanged += value3;
				backgroundWorker.RunWorkerCompleted += value4;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GCUv2.frmTransferList));
		this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
		this.tsbNew = new System.Windows.Forms.ToolStripButton();
		this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.lblTitle = new System.Windows.Forms.Label();
		this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
		this.ToolStrip1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.ToolStrip1.AutoSize = false;
		this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
		this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.tsbNew, this.tsbRefresh });
		this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
		this.ToolStrip1.Name = "ToolStrip1";
		this.ToolStrip1.Size = new System.Drawing.Size(723, 60);
		this.ToolStrip1.TabIndex = 7;
		this.ToolStrip1.Text = "ToolStrip1";
		this.tsbNew.Image = (System.Drawing.Image)resources.GetObject("tsbNew.Image");
		this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.tsbNew.Name = "tsbNew";
		this.tsbNew.Size = new System.Drawing.Size(44, 57);
		this.tsbNew.Text = "&Baru";
		this.tsbNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.tsbRefresh.Image = (System.Drawing.Image)resources.GetObject("tsbRefresh.Image");
		this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.tsbRefresh.Name = "tsbRefresh";
		this.tsbRefresh.Size = new System.Drawing.Size(50, 57);
		this.tsbRefresh.Text = "&Refresh";
		this.tsbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(12, 86);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(699, 321);
		this.dgvList.TabIndex = 6;
		this.lblTitle.AutoSize = true;
		this.lblTitle.Location = new System.Drawing.Point(12, 70);
		this.lblTitle.Name = "lblTitle";
		this.lblTitle.Size = new System.Drawing.Size(110, 13);
		this.lblTitle.TabIndex = 8;
		this.lblTitle.Text = "Transfer Stok terbaru:";
		this.BackgroundWorker1.WorkerReportsProgress = true;
		this.BackgroundWorker1.WorkerSupportsCancellation = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(723, 419);
		base.Controls.Add(this.lblTitle);
		base.Controls.Add(this.ToolStrip1);
		base.Controls.Add(this.dgvList);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmTransferList";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Daftar Transfer Stok";
		this.ToolStrip1.ResumeLayout(false);
		this.ToolStrip1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmTransferList()
	{
		base.KeyDown += frmTransferList_KeyDown;
		base.Load += frmTransferList_Load;
		InitializeComponent();
		DoubleBuffered = true;
		base.MdiParent = MyProject.Forms.frmMenu;
		FormatGrid();
		GetRecent();
	}

	private void tsbAdd_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmTransfer.Show();
		MyProject.Forms.frmTransfer.prepareForm(SaveNew: false);
		MyProject.Forms.frmTransfer.Activate();
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
					ProjectData.ClearProjectError();
					num2 = 2;
					lblTitle.Text = "Transfer terbaru sedang dicari. Harap tunggu sebentar.";
					dgvList.Rows.Clear();
					if (!BackgroundWorker1.IsBusy)
					{
						BackgroundWorker1.RunWorkerAsync();
					}
					goto end_IL_0001;
				case 107:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmTransferList", "GetRecent", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 107;
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

	private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
		DataTable dataTable = cTransfer.Search(2, 0, 0, DateAndTime.Now.AddDays(-90.0), DateAndTime.Now, 0, 0, 0, 0, Module1.pubGroupId, 0, 0);
		foreach (DataRow row in dataTable.Rows)
		{
			BackgroundWorker1.ReportProgress(1, row);
		}
	}

	private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		DataRow dataRow = default(DataRow);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000b;
				case 193:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000b;
						case 3:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 4:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_000b:
					num = 2;
					dataRow = (DataRow)e.UserState;
					break;
					end_IL_0001_2:
					break;
				}
				num = 3;
				dgvList.Rows.Add(dataRow["transferId"], dataRow["transferDate"], dataRow["transferNumber"], dataRow["storageFromName"], dataRow["storageToName"], dataRow["itemName"], Module1.formatCustomDecimal(Conversions.ToString(dataRow["transferQty"]), 3));
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 193;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		lblTitle.Text = "Transfer terbaru (" + Conversions.ToString(DateAndTime.Now) + ")";
	}

	private void FormatGrid()
	{
		dgvList.Columns.Clear();
		dgvList.Rows.Clear();
		dgvList.Columns.Add("", "invId");
		dgvList.Columns.Add("", "Tanggal");
		dgvList.Columns.Add("", "Nomer");
		dgvList.Columns.Add("", "Asal");
		dgvList.Columns.Add("", "Tujuan");
		dgvList.Columns.Add("", "Produk");
		dgvList.Columns.Add("", "Jumlah");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvList.Columns[0].Width = 0;
		dgvList.Columns[1].Width = 70;
		dgvList.Columns[2].Width = 110;
		dgvList.Columns[3].Width = 150;
		dgvList.Columns[4].Width = 150;
		dgvList.Columns[5].Width = 120;
		dgvList.Columns[6].Width = 80;
		dgvList.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.RowHeadersVisible = false;
		dgvList.AllowUserToAddRows = false;
		dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvList.ReadOnly = true;
		dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvList.AllowUserToResizeRows = false;
	}

	private void frmTransferList_KeyDown(object sender, KeyEventArgs e)
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

	private void frmTransferList_Load(object sender, EventArgs e)
	{
		GetRecent();
	}

	private void dgvList_DoubleClick(object sender, EventArgs e)
	{
		openSelection();
	}

	private void openSelection()
	{
		if (dgvList.RowCount > 0 && Operators.ConditionalCompareObjectGreater(dgvList[0, dgvList.CurrentRow.Index].Value, 0, TextCompare: false))
		{
			MyProject.Forms.frmTransfer.Show();
			MyProject.Forms.frmTransfer.prepareForm(SaveNew: false);
			MyProject.Forms.frmTransfer.CurrentId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
			MyProject.Forms.frmTransfer.loadData();
			MyProject.Forms.frmTransfer.Activate();
			MyProject.Forms.frmTransfer.WindowState = FormWindowState.Normal;
		}
	}

	private void tsbRefresh_Click(object sender, EventArgs e)
	{
		GetRecent();
	}
}
