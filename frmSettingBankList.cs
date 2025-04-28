using System;
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
public class frmSettingBankList : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("tsbRefresh")]
	private ToolStripButton _tsbRefresh;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvList")]
	private DataGridView _dgvList;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("tsbNew")]
	private ToolStripButton _tsbNew;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("chkAll")]
	private CheckBox _chkAll;

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
			EventHandler value2 = dgvList_DoubleClick;
			KeyEventHandler value3 = dgvList_KeyDown;
			EventHandler value4 = dgvList_GotFocus;
			EventHandler value5 = dgvList_LostFocus;
			DataGridView dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick -= value2;
				dataGridView.KeyDown -= value3;
				dataGridView.GotFocus -= value4;
				dataGridView.LostFocus -= value5;
			}
			_dgvList = value;
			dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick += value2;
				dataGridView.KeyDown += value3;
				dataGridView.GotFocus += value4;
				dataGridView.LostFocus += value5;
			}
		}
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

	internal virtual CheckBox chkAll
	{
		[CompilerGenerated]
		get
		{
			return _chkAll;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = chkAll_CheckedChanged;
			CheckBox checkBox = _chkAll;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value2;
			}
			_chkAll = value;
			checkBox = _chkAll;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStrip1")]
	internal virtual ToolStrip ToolStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GCUv2.frmSettingBankList));
		this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.tsbNew = new System.Windows.Forms.ToolStripButton();
		this.chkAll = new System.Windows.Forms.CheckBox();
		this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		this.ToolStrip1.SuspendLayout();
		base.SuspendLayout();
		this.tsbRefresh.Image = (System.Drawing.Image)resources.GetObject("tsbRefresh.Image");
		this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.tsbRefresh.Name = "tsbRefresh";
		this.tsbRefresh.Size = new System.Drawing.Size(50, 57);
		this.tsbRefresh.Text = "&Refresh";
		this.tsbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(12, 131);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(260, 309);
		this.dgvList.TabIndex = 16;
		this.tsbNew.Image = (System.Drawing.Image)resources.GetObject("tsbNew.Image");
		this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.tsbNew.Name = "tsbNew";
		this.tsbNew.Size = new System.Drawing.Size(55, 57);
		this.tsbNew.Text = "&Tambah";
		this.tsbNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.chkAll.AutoSize = true;
		this.chkAll.Location = new System.Drawing.Point(12, 108);
		this.chkAll.Name = "chkAll";
		this.chkAll.Size = new System.Drawing.Size(242, 17);
		this.chkAll.TabIndex = 17;
		this.chkAll.Text = "Tampilkan semua ( termasuk yang tidak aktif )";
		this.chkAll.UseVisualStyleBackColor = true;
		this.ToolStrip1.AutoSize = false;
		this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
		this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.tsbNew, this.tsbRefresh });
		this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
		this.ToolStrip1.Name = "ToolStrip1";
		this.ToolStrip1.Size = new System.Drawing.Size(441, 60);
		this.ToolStrip1.TabIndex = 15;
		this.ToolStrip1.Text = "ToolStrip1";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(12, 64);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(400, 13);
		this.Label1.TabIndex = 18;
		this.Label1.Text = "Catatan: Bank disini tidak ada hubungan dengan Rekening Bank milik perusahaan.";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(12, 85);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(420, 13);
		this.Label2.TabIndex = 19;
		this.Label2.Text = "Bank disini adalah Bank yang digunakan oleh Customer untuk melakukan Pembayaran.";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(441, 451);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.dgvList);
		base.Controls.Add(this.chkAll);
		base.Controls.Add(this.ToolStrip1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSettingBankList";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Setting - Bank";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		this.ToolStrip1.ResumeLayout(false);
		this.ToolStrip1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSettingBankList()
	{
		base.KeyDown += frmSettingBranchList_KeyDown;
		base.Load += frmSettingBranchList_Load;
		InitializeComponent();
		base.MdiParent = MyProject.Forms.frmMenu;
		FormatGrid();
	}

	private void frmSettingBranchList_KeyDown(object sender, KeyEventArgs e)
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

	private void frmSettingBranchList_Load(object sender, EventArgs e)
	{
		getList();
	}

	private void FormatGrid()
	{
		dgvList.Columns.Add("", "Id");
		dgvList.Columns.Add("", "Nama Bank");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[1].Width = 200;
		dgvList.RowHeadersVisible = false;
		dgvList.AllowUserToAddRows = false;
		dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvList.AllowUserToResizeRows = false;
		dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvList.MultiSelect = false;
		dgvList.ReadOnly = true;
	}

	private void chkAll_CheckedChanged(object sender, EventArgs e)
	{
		getList();
	}

	public void getList()
	{
		DataTable dataTable = new DataTable();
		dataTable = cBank.Search((!chkAll.Checked) ? 1 : 99);
		dgvList.Rows.Clear();
		foreach (DataRow row in dataTable.Rows)
		{
			dgvList.Rows.Add(row["bankId"], row["bankName"]);
			if (Operators.ConditionalCompareObjectEqual(row["bankStatus"], 0, TextCompare: false))
			{
				dgvList.Rows[checked(dgvList.RowCount - 1)].DefaultCellStyle.BackColor = Color.Red;
			}
		}
		if (dgvList.Rows.Count > 0)
		{
			dgvList.Focus();
		}
	}

	private void dgvList_DoubleClick(object sender, EventArgs e)
	{
		openSelection();
	}

	private void openSelection()
	{
		frmSettingBankInput frmSettingBankInput2 = new frmSettingBankInput();
		frmSettingBankInput2.CurrentId = Conversions.ToString(dgvList[0, dgvList.CurrentRow.Index].Value);
		frmSettingBankInput2.loadData();
		frmSettingBankInput2.ShowDialog();
		frmSettingBankInput2.Close();
		frmSettingBankInput2.Dispose();
	}

	private void dgvList_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			openSelection();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Add)
		{
			tsbNew.PerformClick();
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			chkAll.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			chkAll.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void dgvList_GotFocus(object sender, EventArgs e)
	{
		if (dgvList.RowCount > 0)
		{
			dgvList.CurrentRow.Selected = true;
		}
	}

	private void dgvList_LostFocus(object sender, EventArgs e)
	{
		if (dgvList.RowCount > 0)
		{
			dgvList.CurrentRow.Selected = false;
		}
	}

	private void tsbNew_Click(object sender, EventArgs e)
	{
		frmSettingBankInput frmSettingBankInput2 = new frmSettingBankInput();
		frmSettingBankInput2.prepareForm();
		frmSettingBankInput2.ShowDialog();
		frmSettingBankInput2.Close();
		frmSettingBankInput2.Dispose();
	}

	private void tsbRefresh_Click(object sender, EventArgs e)
	{
		getList();
	}
}
