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
public class frmSettingItemCategoryList : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("tsbNew")]
	private ToolStripButton _tsbNew;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("tsbDelete")]
	private ToolStripButton _tsbDelete;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvList")]
	private DataGridView _dgvList;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("tsbRefresh")]
	private ToolStripButton _tsbRefresh;

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
			DataGridView dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick -= value2;
				dataGridView.KeyDown -= value3;
			}
			_dgvList = value;
			dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.DoubleClick += value2;
				dataGridView.KeyDown += value3;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GCUv2.frmSettingItemCategoryList));
		this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
		this.tsbNew = new System.Windows.Forms.ToolStripButton();
		this.tsbDelete = new System.Windows.Forms.ToolStripButton();
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
		this.ToolStrip1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.ToolStrip1.AutoSize = false;
		this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
		this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.tsbNew, this.tsbDelete, this.tsbRefresh });
		this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
		this.ToolStrip1.Name = "ToolStrip1";
		this.ToolStrip1.Size = new System.Drawing.Size(359, 60);
		this.ToolStrip1.TabIndex = 7;
		this.ToolStrip1.Text = "ToolStrip1";
		this.tsbNew.Image = (System.Drawing.Image)resources.GetObject("tsbNew.Image");
		this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.tsbNew.Name = "tsbNew";
		this.tsbNew.Size = new System.Drawing.Size(55, 57);
		this.tsbNew.Text = "&Tambah";
		this.tsbNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.tsbDelete.Image = (System.Drawing.Image)resources.GetObject("tsbDelete.Image");
		this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.tsbDelete.Name = "tsbDelete";
		this.tsbDelete.Size = new System.Drawing.Size(45, 57);
		this.tsbDelete.Text = "&Hapus";
		this.tsbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.tsbDelete.ToolTipText = "Hapus";
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(12, 74);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(335, 211);
		this.dgvList.TabIndex = 6;
		this.tsbRefresh.Image = (System.Drawing.Image)resources.GetObject("tsbRefresh.Image");
		this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.tsbRefresh.Name = "tsbRefresh";
		this.tsbRefresh.Size = new System.Drawing.Size(50, 57);
		this.tsbRefresh.Text = "&Refresh";
		this.tsbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(359, 297);
		base.Controls.Add(this.ToolStrip1);
		base.Controls.Add(this.dgvList);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSettingItemCategoryList";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Setting - Kategori Barang";
		this.ToolStrip1.ResumeLayout(false);
		this.ToolStrip1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
	}

	public frmSettingItemCategoryList()
	{
		base.KeyDown += frmSetItemCategoryList_KeyDown;
		base.Load += frmSetItemCategoryList_Load;
		InitializeComponent();
		base.MdiParent = MyProject.Forms.frmMenu;
	}

	private void frmSetItemCategoryList_KeyDown(object sender, KeyEventArgs e)
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

	private void frmSetItemCategoryList_Load(object sender, EventArgs e)
	{
		getItemCategory();
	}

	public void getItemCategory()
	{
		DataTable dataTable = new DataTable();
		dataTable = cItemCategory.getItemCategory(0, Active: false);
		dgvList.DataSource = dataTable;
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[1].Width = 200;
		dgvList.Columns[1].HeaderText = "Nama Kategori";
		dgvList.RowHeadersVisible = false;
		dgvList.AllowUserToAddRows = false;
		dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvList.MultiSelect = false;
		dgvList.ReadOnly = true;
		dgvList.AllowUserToResizeRows = false;
	}

	private void dgvList_DoubleClick(object sender, EventArgs e)
	{
		openSelection();
	}

	private void openSelection()
	{
		frmSettingItemCategoryInput frmSettingItemCategoryInput2 = new frmSettingItemCategoryInput();
		frmSettingItemCategoryInput2.CurrentId = Conversions.ToString(dgvList[0, dgvList.CurrentRow.Index].Value);
		frmSettingItemCategoryInput2.loadData();
		frmSettingItemCategoryInput2.ShowDialog();
		frmSettingItemCategoryInput2.Close();
		frmSettingItemCategoryInput2.Dispose();
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
		else if (e.KeyCode == Keys.Tab)
		{
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			e.SuppressKeyPress = true;
		}
	}

	private void ToolStripButton1_Click(object sender, EventArgs e)
	{
		frmSettingItemCategoryInput frmSettingItemCategoryInput2 = new frmSettingItemCategoryInput();
		frmSettingItemCategoryInput2.prepareForm();
		frmSettingItemCategoryInput2.ShowDialog();
		frmSettingItemCategoryInput2.Close();
		frmSettingItemCategoryInput2.Dispose();
	}

	private void tsbDelete_Click(object sender, EventArgs e)
	{
		int catId = Conversions.ToInteger(dgvList[0, dgvList.CurrentRow.Index].Value);
		string text = Conversions.ToString(dgvList[1, dgvList.CurrentRow.Index].Value);
		int num = (int)Interaction.MsgBox("Hapus kategori " + text + "?", MsgBoxStyle.YesNo, "Hapus kategori barang");
		if (num == 6)
		{
			cItemCategory cItemCategory2 = new cItemCategory(catId);
			if (cItemCategory2.Used)
			{
				Interaction.MsgBox("Kategori " + text + " tidak bisa dihapus karena sudah pernah dipakai", MsgBoxStyle.Information);
				return;
			}
			cItemCategory2.Delete();
			Interaction.MsgBox("Kategori " + text + " berhasil dihapus", MsgBoxStyle.Information);
			getItemCategory();
		}
	}

	private void tsbRefresh_Click(object sender, EventArgs e)
	{
		getItemCategory();
	}
}
