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
public class frmSettingAdjustmentTypeList : Form
{
	private IContainer components;

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
	[AccessedThroughProperty("tsbDelete")]
	private ToolStripButton _tsbDelete;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("tsbRefresh")]
	private ToolStripButton _tsbRefresh;

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

	public frmSettingAdjustmentTypeList()
	{
		base.KeyDown += frmSettingAdjustmentTypeList_KeyDown;
		base.Load += frmAdjustmentTypeList_Load;
		InitializeComponent();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GCUv2.frmSettingAdjustmentTypeList));
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
		this.tsbNew = new System.Windows.Forms.ToolStripButton();
		this.tsbDelete = new System.Windows.Forms.ToolStripButton();
		this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		this.ToolStrip1.SuspendLayout();
		base.SuspendLayout();
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(12, 72);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(326, 186);
		this.dgvList.TabIndex = 4;
		this.ToolStrip1.AutoSize = false;
		this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
		this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.tsbNew, this.tsbDelete, this.tsbRefresh });
		this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
		this.ToolStrip1.Name = "ToolStrip1";
		this.ToolStrip1.Size = new System.Drawing.Size(353, 60);
		this.ToolStrip1.TabIndex = 5;
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
		this.tsbRefresh.Image = (System.Drawing.Image)resources.GetObject("tsbRefresh.Image");
		this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.tsbRefresh.Name = "tsbRefresh";
		this.tsbRefresh.Size = new System.Drawing.Size(50, 57);
		this.tsbRefresh.Text = "&Refresh";
		this.tsbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(353, 270);
		base.Controls.Add(this.ToolStrip1);
		base.Controls.Add(this.dgvList);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSettingAdjustmentTypeList";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Setting - Tipe Penyesuaian";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		this.ToolStrip1.ResumeLayout(false);
		this.ToolStrip1.PerformLayout();
		base.ResumeLayout(false);
	}

	private void frmSettingAdjustmentTypeList_KeyDown(object sender, KeyEventArgs e)
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

	private void frmAdjustmentTypeList_Load(object sender, EventArgs e)
	{
		getAdjustmentTypes();
	}

	public void getAdjustmentTypes()
	{
		string strSql = " SELECT adjtypeId, adjtypeName as 'Tipe Penyesuaian' FROM adjustment_types ORDER BY adjtypeName ";
		DataTable dataTable = new DataTable();
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		dgvList.DataSource = dataTable;
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[1].Width = 300;
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

	private void ToolStripButton1_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmSettingAdjustmentTypeInput.ShowDialog();
		MyProject.Forms.frmSettingAdjustmentTypeInput.Close();
		MyProject.Forms.frmSettingAdjustmentTypeInput.Dispose();
	}

	private void openSelection()
	{
		MyProject.Forms.frmSettingAdjustmentTypeInput.intAdjtypeId = Conversions.ToInteger(dgvList[0, dgvList.CurrentRow.Index].Value);
		string text = Conversions.ToString(dgvList[1, dgvList.CurrentRow.Index].Value);
		MyProject.Forms.frmSettingAdjustmentTypeInput.txtName.Text = text;
		MyProject.Forms.frmSettingAdjustmentTypeInput.ShowDialog();
		MyProject.Forms.frmSettingAdjustmentTypeInput.Close();
		MyProject.Forms.frmSettingAdjustmentTypeInput.Dispose();
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

	private void tsbDelete_Click(object sender, EventArgs e)
	{
		int num = Conversions.ToInteger(dgvList[0, dgvList.CurrentRow.Index].Value);
		string text = Conversions.ToString(dgvList[1, dgvList.CurrentRow.Index].Value);
		int num2 = (int)Interaction.MsgBox("Hapus tipe " + text + "?", MsgBoxStyle.YesNo, "Hapus tipe penyesuaian");
		if (num2 == 6)
		{
			string strSql = " SELECT * FROM adjustments WHERE adjCategory = " + Conversions.ToString(num);
			DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				Interaction.MsgBox("Tipe " + text + " tidak bisa dihapus karena sudah pernah dipakai", MsgBoxStyle.Information);
				return;
			}
			strSql = " DELETE FROM adjustment_types WHERE adjtypeId = " + Conversions.ToString(num);
			Module1.sqlNonQuery(strSql, "data");
			Interaction.MsgBox("Tipe " + text + " berhasil dihapus", MsgBoxStyle.Information);
			getAdjustmentTypes();
		}
	}

	private void tsbRefresh_Click(object sender, EventArgs e)
	{
		getAdjustmentTypes();
	}
}
