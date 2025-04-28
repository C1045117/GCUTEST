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
public class frmSettingUserList : Form
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
	[AccessedThroughProperty("chkAll")]
	private CheckBox _chkAll;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("tsbRefresh")]
	private ToolStripButton _tsbRefresh;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("tsbDelete")]
	private ToolStripButton _tsbDelete;

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
			EventHandler value2 = ToolStripButton1_Click;
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

	internal virtual ToolStripButton tsbDelete
	{
		[CompilerGenerated]
		get
		{
			return _tsbDelete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = tsbDelete_Click;
			ToolStripButton toolStripButton = _tsbDelete;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value2;
			}
			_tsbDelete = value;
			toolStripButton = _tsbDelete;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GCUv2.frmSettingUserList));
		this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
		this.tsbNew = new System.Windows.Forms.ToolStripButton();
		this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.chkAll = new System.Windows.Forms.CheckBox();
		this.chkManual = new System.Windows.Forms.CheckBox();
		this.tsbDelete = new System.Windows.Forms.ToolStripButton();
		this.ToolStrip1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.ToolStrip1.AutoSize = false;
		this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
		this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.tsbNew, this.tsbDelete, this.tsbRefresh });
		this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
		this.ToolStrip1.Name = "ToolStrip1";
		this.ToolStrip1.Size = new System.Drawing.Size(299, 60);
		this.ToolStrip1.TabIndex = 0;
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
		this.dgvList.Location = new System.Drawing.Point(12, 108);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(273, 369);
		this.dgvList.TabIndex = 0;
		this.chkAll.AutoSize = true;
		this.chkAll.Location = new System.Drawing.Point(12, 63);
		this.chkAll.Name = "chkAll";
		this.chkAll.Size = new System.Drawing.Size(242, 17);
		this.chkAll.TabIndex = 1;
		this.chkAll.Text = "Tampilkan semua ( termasuk yang tidak aktif )";
		this.chkAll.UseVisualStyleBackColor = true;
		this.chkManual.AutoSize = true;
		this.chkManual.Location = new System.Drawing.Point(12, 85);
		this.chkManual.Name = "chkManual";
		this.chkManual.Size = new System.Drawing.Size(135, 17);
		this.chkManual.TabIndex = 2;
		this.chkManual.Text = "Refresh secara manual";
		this.chkManual.UseVisualStyleBackColor = true;
		this.tsbDelete.Image = (System.Drawing.Image)resources.GetObject("tsbDelete.Image");
		this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.tsbDelete.Name = "tsbDelete";
		this.tsbDelete.Size = new System.Drawing.Size(45, 57);
		this.tsbDelete.Text = "&Hapus";
		this.tsbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.tsbDelete.ToolTipText = "Hapus";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(299, 489);
		base.Controls.Add(this.chkManual);
		base.Controls.Add(this.chkAll);
		base.Controls.Add(this.dgvList);
		base.Controls.Add(this.ToolStrip1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSettingUserList";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Setting User";
		this.ToolStrip1.ResumeLayout(false);
		this.ToolStrip1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSettingUserList()
	{
		base.KeyDown += frmSettingUserList_KeyDown;
		base.Load += frmSettingUserList_Load;
		InitializeComponent();
		base.MdiParent = MyProject.Forms.frmMenu;
		FormatGrid();
	}

	private void frmSettingUserList_KeyDown(object sender, KeyEventArgs e)
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

	private void frmSettingUserList_Load(object sender, EventArgs e)
	{
		getList();
	}

	private void FormatGrid()
	{
		dgvList.Columns.Add("", "userId");
		dgvList.Columns.Add("", "User Name");
		dgvList.Columns.Add("", "Grup");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[1].Width = 100;
		dgvList.Columns[2].Width = 150;
		dgvList.RowHeadersVisible = false;
		dgvList.AllowUserToAddRows = false;
		dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvList.AllowUserToResizeRows = false;
		dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvList.MultiSelect = false;
		dgvList.ReadOnly = true;
		dgvList.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f);
	}

	private void chkAll_CheckedChanged(object sender, EventArgs e)
	{
		getList();
	}

	public void getList()
	{
		DataTable dataTable = new DataTable();
		dataTable = cUser.Search((!chkAll.Checked) ? 1 : 99);
		dgvList.Rows.Clear();
		foreach (DataRow row in dataTable.Rows)
		{
			dgvList.Rows.Add(row["userId"], row["userLogin"], row["groupName"]);
			if (Operators.ConditionalCompareObjectEqual(row["userStatus"], 0, TextCompare: false))
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
		frmSettingUserInput frmSettingUserInput2 = new frmSettingUserInput();
		frmSettingUserInput2.CurrentId = Conversions.ToString(dgvList[0, dgvList.CurrentRow.Index].Value);
		frmSettingUserInput2.loadData();
		frmSettingUserInput2.ShowDialog();
		frmSettingUserInput2.Close();
		frmSettingUserInput2.Dispose();
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
		else if (e.KeyCode == Keys.Subtract)
		{
			tsbDelete.PerformClick();
		}
		else if (e.KeyCode == Keys.Delete)
		{
			tsbDelete.PerformClick();
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
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

	private void ToolStripButton1_Click(object sender, EventArgs e)
	{
		frmSettingUserInput frmSettingUserInput2 = new frmSettingUserInput();
		frmSettingUserInput2.prepareForm();
		frmSettingUserInput2.ShowDialog();
		frmSettingUserInput2.Close();
		frmSettingUserInput2.Dispose();
	}

	private void tsbRefresh_Click(object sender, EventArgs e)
	{
		getList();
	}

	private void tsbDelete_Click(object sender, EventArgs e)
	{
		int userId = Conversions.ToInteger(dgvList[0, dgvList.CurrentRow.Index].Value);
		string text = Conversions.ToString(dgvList[1, dgvList.CurrentRow.Index].Value);
		if (Operators.CompareString(text, "adi", TextCompare: false) == 0)
		{
			Interaction.MsgBox("User adi tidak dapat dihapus.", MsgBoxStyle.Information);
		}
		else if (MessageBox.Show("Hapus User " + text + "?", "Konfirmasi", MessageBoxButtons.YesNo) != DialogResult.No)
		{
			cUser.Delete(userId);
			Interaction.MsgBox("User " + text + " berhasil dihapus", MsgBoxStyle.Information);
			if (!chkManual.Checked)
			{
				getList();
			}
		}
	}
}
