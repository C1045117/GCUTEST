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
public class frmSupplierSearch : Form
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
	[AccessedThroughProperty("btnSearch")]
	private Button _btnSearch;

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

	[field: AccessedThroughProperty("lblTotal")]
	internal virtual Label lblTotal
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
			EventHandler value3 = dgvList_GotFocus;
			EventHandler value4 = dgvList_LostFocus;
			EventHandler value5 = dgvList_DoubleClick;
			DataGridView dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.KeyDown -= value2;
				dataGridView.GotFocus -= value3;
				dataGridView.LostFocus -= value4;
				dataGridView.DoubleClick -= value5;
			}
			_dgvList = value;
			dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.KeyDown += value2;
				dataGridView.GotFocus += value3;
				dataGridView.LostFocus += value4;
				dataGridView.DoubleClick += value5;
			}
		}
	}

	internal virtual Button btnSearch
	{
		[CompilerGenerated]
		get
		{
			return _btnSearch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnSearch_Click;
			Button button = _btnSearch;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnSearch = value;
			button = _btnSearch;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("txtName")]
	internal virtual TextBox txtName
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

	[field: AccessedThroughProperty("Label16")]
	internal virtual Label Label16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GCUv2.frmSupplierSearch));
		this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
		this.tsbNew = new System.Windows.Forms.ToolStripButton();
		this.lblTotal = new System.Windows.Forms.Label();
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.btnSearch = new System.Windows.Forms.Button();
		this.txtName = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label16 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.ToolStrip1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.ToolStrip1.AutoSize = false;
		this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
		this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.tsbNew });
		this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
		this.ToolStrip1.Name = "ToolStrip1";
		this.ToolStrip1.Size = new System.Drawing.Size(799, 60);
		this.ToolStrip1.TabIndex = 89;
		this.ToolStrip1.Text = "ToolStrip1";
		this.tsbNew.Image = (System.Drawing.Image)resources.GetObject("tsbNew.Image");
		this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.tsbNew.Name = "tsbNew";
		this.tsbNew.Size = new System.Drawing.Size(44, 57);
		this.tsbNew.Text = "&Baru";
		this.tsbNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		this.lblTotal.AutoSize = true;
		this.lblTotal.Location = new System.Drawing.Point(221, 400);
		this.lblTotal.Name = "lblTotal";
		this.lblTotal.Size = new System.Drawing.Size(91, 13);
		this.lblTotal.TabIndex = 88;
		this.lblTotal.Text = "Total Pencarian: -";
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.Location = new System.Drawing.Point(224, 68);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(560, 329);
		this.dgvList.TabIndex = 87;
		this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearch.Location = new System.Drawing.Point(56, 94);
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.Size = new System.Drawing.Size(47, 24);
		this.btnSearch.TabIndex = 86;
		this.btnSearch.Text = "&Cari";
		this.btnSearch.UseVisualStyleBackColor = true;
		this.txtName.Location = new System.Drawing.Point(56, 68);
		this.txtName.Name = "txtName";
		this.txtName.Size = new System.Drawing.Size(162, 20);
		this.txtName.TabIndex = 84;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(15, 71);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(35, 13);
		this.Label1.TabIndex = 85;
		this.Label1.Text = "Nama";
		this.Label16.AutoSize = true;
		this.Label16.Location = new System.Drawing.Point(267, 31);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(111, 13);
		this.Label16.TabIndex = 91;
		this.Label16.Text = "R = Retur Pembelian; ";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(221, 9);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(209, 13);
		this.Label3.TabIndex = 90;
		this.Label3.Text = "Shortcut: T = Terima (Penerimaan Barang);";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(430, 31);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(91, 13);
		this.Label2.TabIndex = 92;
		this.Label2.Text = "B = Pembayaran; ";
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(430, 9);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(110, 13);
		this.Label4.TabIndex = 93;
		this.Label4.Text = "F = Faktur Pembelian;";
		base.AcceptButton = this.btnSearch;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(799, 423);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label16);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.ToolStrip1);
		base.Controls.Add(this.lblTotal);
		base.Controls.Add(this.dgvList);
		base.Controls.Add(this.btnSearch);
		base.Controls.Add(this.txtName);
		base.Controls.Add(this.Label1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSupplierSearch";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Cari Supplier";
		this.ToolStrip1.ResumeLayout(false);
		this.ToolStrip1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSupplierSearch()
	{
		base.KeyDown += frmSupplierSearch_KeyDown;
		InitializeComponent();
		base.MdiParent = MyProject.Forms.frmMenu;
	}

	private void frmSupplierSearch_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
		else if (e.KeyCode == Keys.F2)
		{
			tsbNew.PerformClick();
		}
	}

	private void btnSearch_Click(object sender, EventArgs e)
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
					DataTable dataTable = cSupplier.Search(Module1.cleanString(txtName.Text), Module1.pubGroupId, 99);
					formatGrid();
					dgvList.Rows.Clear();
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						dgvList.Rows.Add(dataRow["supId"], dataRow["supName"], dataRow["supAddress"], dataRow["isParent"]);
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					if (dataTable.Rows.Count == 0)
					{
						Interaction.MsgBox("Data tidak ditemukan", MsgBoxStyle.Information);
						txtName.Focus();
					}
					else
					{
						dgvList.Focus();
					}
					goto end_IL_0001;
				}
				case 300:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSupplierSearch", "btnSearch_click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 300;
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

	private void formatGrid()
	{
		dgvList.Columns.Clear();
		dgvList.Columns.Add("", "supId");
		dgvList.Columns.Add("", "Nama");
		dgvList.Columns.Add("", "Alamat");
		dgvList.Columns.Add("", "IsParent");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[1].Width = 220;
		dgvList.Columns[2].Width = 180;
		dgvList.Columns[3].Visible = false;
		dgvList.RowHeadersVisible = false;
		dgvList.AllowUserToAddRows = false;
		dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvList.ReadOnly = true;
		dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvList.AllowUserToResizeRows = false;
	}

	private void dgvList_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			getData();
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			btnSearch.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			txtName.Focus();
			e.SuppressKeyPress = true;
		}
		else if (((e.KeyCode == Keys.T) & (dgvList.RowCount > 0)) && Operators.ConditionalCompareObjectGreater(dgvList[0, dgvList.CurrentRow.Index].Value, 0, TextCompare: false) && Operators.ConditionalCompareObjectEqual(dgvList[3, dgvList.CurrentRow.Index].Value, 0, TextCompare: false))
		{
			MyProject.Forms.frmReceivedItem.Show();
			MyProject.Forms.frmReceivedItem.prepareForm(SaveNew: false);
			frmReceivedItem obj = MyProject.Forms.frmReceivedItem;
			ComboBox cboSource = obj.cboSupplier;
			Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value));
			obj.cboSupplier = cboSource;
			MyProject.Forms.frmReceivedItem.Activate();
			MyProject.Forms.frmReceivedItem.dtpRI.Focus();
		}
		else if (((e.KeyCode == Keys.F) & (dgvList.RowCount > 0)) && Operators.ConditionalCompareObjectGreater(dgvList[0, dgvList.CurrentRow.Index].Value, 0, TextCompare: false) && Operators.ConditionalCompareObjectEqual(dgvList[3, dgvList.CurrentRow.Index].Value, 0, TextCompare: false))
		{
			MyProject.Forms.frmPurchaseInvoice.Show();
			MyProject.Forms.frmPurchaseInvoice.prepareForm(SaveNew: false, KeepSupplier: false);
			frmPurchaseInvoice obj2 = MyProject.Forms.frmPurchaseInvoice;
			ComboBox cboSource = obj2.cboSupplier;
			Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value));
			obj2.cboSupplier = cboSource;
			MyProject.Forms.frmPurchaseInvoice.Activate();
			MyProject.Forms.frmPurchaseInvoice.dtpInvoice.Focus();
		}
		else if (((e.KeyCode == Keys.R) & (dgvList.RowCount > 0)) && Operators.ConditionalCompareObjectGreater(dgvList[0, dgvList.CurrentRow.Index].Value, 0, TextCompare: false) && Operators.ConditionalCompareObjectEqual(dgvList[3, dgvList.CurrentRow.Index].Value, 0, TextCompare: false))
		{
			MyProject.Forms.frmPurchaseReturn.Show();
			MyProject.Forms.frmPurchaseReturn.prepareForm(SaveNew: false, KeepSupplier: false);
			frmPurchaseReturn obj3 = MyProject.Forms.frmPurchaseReturn;
			ComboBox cboSource = obj3.cboSupplier;
			Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value));
			obj3.cboSupplier = cboSource;
			MyProject.Forms.frmPurchaseReturn.Activate();
			MyProject.Forms.frmPurchaseReturn.dtpInvoice.Focus();
		}
		else if (((e.KeyCode == Keys.B) & (dgvList.RowCount > 0)) && Operators.ConditionalCompareObjectGreater(dgvList[0, dgvList.CurrentRow.Index].Value, 0, TextCompare: false))
		{
			if (!Module1.pubViewReportPurchaseInvoicePrice)
			{
				Interaction.MsgBox("Anda tidak bisa melihat faktur yang telah memiliki harga.", MsgBoxStyle.Information);
				return;
			}
			MyProject.Forms.frmSupplierPayment.Show();
			MyProject.Forms.frmSupplierPayment.PrepareForm(SaveNew: false);
			frmSupplierPayment obj4 = MyProject.Forms.frmSupplierPayment;
			ComboBox cboSource = obj4.cboSupplier;
			Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value));
			obj4.cboSupplier = cboSource;
			MyProject.Forms.frmSupplierPayment.Activate();
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

	private void dgvList_DoubleClick(object sender, EventArgs e)
	{
		getData();
	}

	public void getData()
	{
		if (dgvList.RowCount > 0 && Operators.ConditionalCompareObjectGreater(dgvList[0, dgvList.CurrentRow.Index].Value, 0, TextCompare: false))
		{
			MyProject.Forms.frmSupplier.Show();
			MyProject.Forms.frmSupplier.prepareForm();
			MyProject.Forms.frmSupplier.CurrentId = Conversions.ToDouble(dgvList[0, dgvList.CurrentRow.Index].Value);
			MyProject.Forms.frmSupplier.LoadData();
			MyProject.Forms.frmSupplier.Activate();
			MyProject.Forms.frmSupplier.WindowState = FormWindowState.Normal;
		}
	}

	private void tsbNew_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmSupplier.Show();
		MyProject.Forms.frmSupplier.prepareForm();
		MyProject.Forms.frmSupplier.Activate();
	}
}
