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
public class frmSettingAccountList : Form
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
	[AccessedThroughProperty("chkAll")]
	private CheckBox _chkAll;

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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	[field: AccessedThroughProperty("chkManual")]
	internal virtual CheckBox chkManual
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GCUv2.frmSettingAccountList));
		this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
		this.tsbNew = new System.Windows.Forms.ToolStripButton();
		this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.Label1 = new System.Windows.Forms.Label();
		this.chkManual = new System.Windows.Forms.CheckBox();
		this.chkAll = new System.Windows.Forms.CheckBox();
		this.ToolStrip1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.ToolStrip1.AutoSize = false;
		this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
		this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.tsbNew, this.tsbRefresh });
		this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
		this.ToolStrip1.Name = "ToolStrip1";
		this.ToolStrip1.Size = new System.Drawing.Size(550, 60);
		this.ToolStrip1.TabIndex = 10;
		this.ToolStrip1.Text = "ToolStrip1";
		this.tsbNew.Image = (System.Drawing.Image)resources.GetObject("tsbNew.Image");
		this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.tsbNew.Name = "tsbNew";
		this.tsbNew.Size = new System.Drawing.Size(55, 57);
		this.tsbNew.Text = "&Tambah";
		this.tsbNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.tsbRefresh.Image = (System.Drawing.Image)resources.GetObject("tsbRefresh.Image");
		this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.tsbRefresh.Name = "tsbRefresh";
		this.tsbRefresh.Size = new System.Drawing.Size(50, 57);
		this.tsbRefresh.Text = "&Refresh";
		this.tsbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(12, 129);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(526, 473);
		this.dgvList.TabIndex = 0;
		this.Label1.AutoSize = true;
		this.Label1.ForeColor = System.Drawing.Color.Red;
		this.Label1.Location = new System.Drawing.Point(12, 67);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(391, 13);
		this.Label1.TabIndex = 12;
		this.Label1.Text = "PERHATIAN: SAAT INI NOMER AKUN DAN TIPE MASIH DIISI ASAL-ASALAN.";
		this.chkManual.AutoSize = true;
		this.chkManual.Location = new System.Drawing.Point(15, 106);
		this.chkManual.Name = "chkManual";
		this.chkManual.Size = new System.Drawing.Size(135, 17);
		this.chkManual.TabIndex = 2;
		this.chkManual.Text = "Refresh secara manual";
		this.chkManual.UseVisualStyleBackColor = true;
		this.chkAll.AutoSize = true;
		this.chkAll.Location = new System.Drawing.Point(15, 83);
		this.chkAll.Name = "chkAll";
		this.chkAll.Size = new System.Drawing.Size(242, 17);
		this.chkAll.TabIndex = 1;
		this.chkAll.Text = "Tampilkan semua ( termasuk yang tidak aktif )";
		this.chkAll.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(550, 614);
		base.Controls.Add(this.chkManual);
		base.Controls.Add(this.chkAll);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.dgvList);
		base.Controls.Add(this.ToolStrip1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSettingAccountList";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Setting - Akun";
		this.ToolStrip1.ResumeLayout(false);
		this.ToolStrip1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSettingAccountList()
	{
		base.KeyDown += frmSettingAccountList_KeyDown;
		base.Load += frmSettingAccountList_Load;
		InitializeComponent();
		base.MdiParent = MyProject.Forms.frmMenu;
		formatGrid();
	}

	private void frmSettingAccountList_KeyDown(object sender, KeyEventArgs e)
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

	private void formatGrid()
	{
		dgvList.Columns.Add("", "accountId");
		dgvList.Columns.Add("", "Nomer Akun");
		dgvList.Columns.Add("", "Nama Akun");
		dgvList.Columns.Add("", "Tipe");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[1].Width = 100;
		dgvList.Columns[2].Width = 250;
		dgvList.Columns[3].Width = 120;
		dgvList.RowHeadersVisible = false;
		dgvList.AllowUserToAddRows = false;
		dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvList.ReadOnly = true;
		dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvList.AllowUserToResizeRows = false;
		DataGridView grid = dgvList;
		Module1.DisableGridSorting(ref grid);
		dgvList = grid;
	}

	private void frmSettingAccountList_Load(object sender, EventArgs e)
	{
		getAccount();
	}

	public void getAccount()
	{
		DataTable dataTable = new DataTable();
		dataTable = cAccount.Search(0, 99, 0, 99, 0, 0, 0, (!chkAll.Checked) ? 1 : 99);
		dgvList.Rows.Clear();
		checked
		{
			foreach (DataRow row in dataTable.Rows)
			{
				int num = Conversions.ToInteger(row["accountLevel"]);
				string text = "";
				while (num != 0)
				{
					text += "- ";
					num--;
				}
				dgvList.Rows.Add(row["accountId"], row["accountNumber"], Operators.ConcatenateObject(text, row["accountName"]), row["accountTypeName"]);
				if (Operators.ConditionalCompareObjectEqual(row["accountActive"], 0, TextCompare: false))
				{
					dgvList.Rows[dgvList.RowCount - 1].DefaultCellStyle.BackColor = Color.Red;
				}
			}
		}
	}

	private void dgvList_DoubleClick(object sender, EventArgs e)
	{
		openSelection();
	}

	private void openSelection()
	{
		frmSettingAccountInput frmSettingAccountInput2 = new frmSettingAccountInput(Conversions.ToInteger(dgvList[0, dgvList.CurrentRow.Index].Value));
		frmSettingAccountInput2.loadData();
		frmSettingAccountInput2.ShowDialog();
		frmSettingAccountInput2.Close();
		frmSettingAccountInput2.Dispose();
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
		else if (e.KeyCode != Keys.Subtract && e.KeyCode != Keys.Delete)
		{
			if (e.Shift & (e.KeyCode == Keys.Tab))
			{
				chkManual.Focus();
				e.SuppressKeyPress = true;
			}
			else if (e.KeyCode == Keys.Tab)
			{
				chkAll.Focus();
				e.SuppressKeyPress = true;
			}
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
		frmSettingAccountInput frmSettingAccountInput2 = new frmSettingAccountInput(0);
		frmSettingAccountInput2.ShowDialog();
		frmSettingAccountInput2.Close();
		frmSettingAccountInput2.Dispose();
	}

	private void tsbRefresh_Click(object sender, EventArgs e)
	{
		getAccount();
	}

	private void chkAll_CheckedChanged(object sender, EventArgs e)
	{
		getAccount();
	}
}
