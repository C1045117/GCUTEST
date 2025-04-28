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
using Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6;

namespace GCUv2;

[DesignerGenerated]
public class frmSalesReceipt : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSaveClose")]
	private Button _btnSaveClose;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnHistory")]
	private Button _btnHistory;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnDelete")]
	private Button _btnDelete;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSave")]
	private Button _btnSave;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtName")]
	private TextBox _txtName;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dtpReceipt")]
	private DateTimePicker _dtpReceipt;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvList")]
	private DataGridView _dgvList;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("txtCity")]
	private TextBox _txtCity;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSearch")]
	private Button _btnSearch;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lblAddress")]
	private Label _lblAddress;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("lblName")]
	private Label _lblName;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnPrint")]
	private Button _btnPrint;

	private double _currentId;

	private double _customerId;

	private string _receiveFrom;

	private bool _edited;

	internal virtual Button btnSaveClose
	{
		[CompilerGenerated]
		get
		{
			return _btnSaveClose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnSaveClose_Click;
			Button button = _btnSaveClose;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnSaveClose = value;
			button = _btnSaveClose;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnHistory
	{
		[CompilerGenerated]
		get
		{
			return _btnHistory;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnHistory_Click;
			Button button = _btnHistory;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnHistory = value;
			button = _btnHistory;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotalInWords")]
	internal virtual Label lblTotalInWords
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnDelete
	{
		[CompilerGenerated]
		get
		{
			return _btnDelete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnDelete_Click;
			Button button = _btnDelete;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnDelete = value;
			button = _btnDelete;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnSave
	{
		[CompilerGenerated]
		get
		{
			return _btnSave;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnSave_Click;
			Button button = _btnSave;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnSave = value;
			button = _btnSave;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotal")]
	internal virtual Label lblTotal
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox txtName
	{
		[CompilerGenerated]
		get
		{
			return _txtName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = txtName_TextChanged;
			TextBox textBox = _txtName;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
			}
			_txtName = value;
			textBox = _txtName;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DateTimePicker dtpReceipt
	{
		[CompilerGenerated]
		get
		{
			return _dtpReceipt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dtpReceipt_ValueChanged;
			DateTimePicker dateTimePicker = _dtpReceipt;
			if (dateTimePicker != null)
			{
				dateTimePicker.ValueChanged -= value2;
			}
			_dtpReceipt = value;
			dateTimePicker = _dtpReceipt;
			if (dateTimePicker != null)
			{
				dateTimePicker.ValueChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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
			DataGridViewCellEventHandler value3 = dgvList_CellContentClick;
			DataGridViewCellEventHandler value4 = dgvList_CellContentDoubleClick;
			DataGridView dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.KeyDown -= value2;
				dataGridView.CellContentClick -= value3;
				dataGridView.CellContentDoubleClick -= value4;
			}
			_dgvList = value;
			dataGridView = _dgvList;
			if (dataGridView != null)
			{
				dataGridView.KeyDown += value2;
				dataGridView.CellContentClick += value3;
				dataGridView.CellContentDoubleClick += value4;
			}
		}
	}

	internal virtual TextBox txtCity
	{
		[CompilerGenerated]
		get
		{
			return _txtCity;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = txtCity_TextChanged;
			TextBox textBox = _txtCity;
			if (textBox != null)
			{
				textBox.TextChanged -= value2;
			}
			_txtCity = value;
			textBox = _txtCity;
			if (textBox != null)
			{
				textBox.TextChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNumber")]
	internal virtual Label lblNumber
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

	internal virtual Label lblAddress
	{
		[CompilerGenerated]
		get
		{
			return _lblAddress;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = lblAddress_Click;
			Label label = _lblAddress;
			if (label != null)
			{
				label.Click -= value2;
			}
			_lblAddress = value;
			label = _lblAddress;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	internal virtual Label lblName
	{
		[CompilerGenerated]
		get
		{
			return _lblName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = lblName_Click;
			Label label = _lblName;
			if (label != null)
			{
				label.Click -= value2;
			}
			_lblName = value;
			label = _lblName;
			if (label != null)
			{
				label.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnPrint
	{
		[CompilerGenerated]
		get
		{
			return _btnPrint;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnPrint_Click;
			Button button = _btnPrint;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnPrint = value;
			button = _btnPrint;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	public double CurrentId
	{
		get
		{
			return _currentId;
		}
		set
		{
			_currentId = value;
		}
	}

	public double CustomerId
	{
		get
		{
			return _customerId;
		}
		set
		{
			_customerId = value;
		}
	}

	public string ReceiveFrom
	{
		get
		{
			return _receiveFrom;
		}
		set
		{
			_receiveFrom = value;
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
		this.btnSaveClose = new System.Windows.Forms.Button();
		this.btnHistory = new System.Windows.Forms.Button();
		this.Label12 = new System.Windows.Forms.Label();
		this.lblTotalInWords = new System.Windows.Forms.Label();
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.Label11 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.lblTotal = new System.Windows.Forms.Label();
		this.txtName = new System.Windows.Forms.TextBox();
		this.Label9 = new System.Windows.Forms.Label();
		this.dtpReceipt = new System.Windows.Forms.DateTimePicker();
		this.Label2 = new System.Windows.Forms.Label();
		this.dgvList = new System.Windows.Forms.DataGridView();
		this.txtCity = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.lblNumber = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.btnSearch = new System.Windows.Forms.Button();
		this.lblAddress = new System.Windows.Forms.Label();
		this.lblName = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.btnPrint = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.dgvList).BeginInit();
		base.SuspendLayout();
		this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSaveClose.Location = new System.Drawing.Point(253, 343);
		this.btnSaveClose.Name = "btnSaveClose";
		this.btnSaveClose.Size = new System.Drawing.Size(93, 24);
		this.btnSaveClose.TabIndex = 12;
		this.btnSaveClose.Text = "Simpan && &Tutup";
		this.btnSaveClose.UseVisualStyleBackColor = true;
		this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnHistory.Location = new System.Drawing.Point(416, 343);
		this.btnHistory.Name = "btnHistory";
		this.btnHistory.Size = new System.Drawing.Size(50, 24);
		this.btnHistory.TabIndex = 14;
		this.btnHistory.Text = "&History";
		this.btnHistory.UseVisualStyleBackColor = true;
		this.Label12.AutoSize = true;
		this.Label12.Location = new System.Drawing.Point(213, 304);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(51, 13);
		this.Label12.TabIndex = 206;
		this.Label12.Text = "Terbilang";
		this.lblTotalInWords.Location = new System.Drawing.Point(270, 304);
		this.lblTotalInWords.Name = "lblTotalInWords";
		this.lblTotalInWords.Size = new System.Drawing.Size(257, 31);
		this.lblTotalInWords.TabIndex = 205;
		this.lblTotalInWords.Text = "lblTotalInWords";
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(352, 343);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(58, 24);
		this.btnDelete.TabIndex = 13;
		this.btnDelete.Text = "Hapus";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
		this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
		this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(187, 343);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(60, 24);
		this.btnSave.TabIndex = 11;
		this.btnSave.Text = "&Simpan ";
		this.btnSave.UseVisualStyleBackColor = true;
		this.Label11.BackColor = System.Drawing.Color.Silver;
		this.Label11.Location = new System.Drawing.Point(-5, 335);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(580, 51);
		this.Label11.TabIndex = 204;
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(213, 285);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(40, 13);
		this.Label6.TabIndex = 203;
		this.Label6.Text = "Jumlah";
		this.lblTotal.Location = new System.Drawing.Point(270, 285);
		this.lblTotal.Name = "lblTotal";
		this.lblTotal.Size = new System.Drawing.Size(87, 13);
		this.lblTotal.TabIndex = 202;
		this.lblTotal.Text = "lblTotal";
		this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.txtName.Location = new System.Drawing.Point(84, 127);
		this.txtName.Name = "txtName";
		this.txtName.Size = new System.Drawing.Size(116, 20);
		this.txtName.TabIndex = 2;
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.Location = new System.Drawing.Point(10, 104);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(46, 13);
		this.Label9.TabIndex = 198;
		this.Label9.Text = "Tanggal";
		this.dtpReceipt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpReceipt.Location = new System.Drawing.Point(84, 101);
		this.dtpReceipt.Name = "dtpReceipt";
		this.dtpReceipt.Size = new System.Drawing.Size(116, 20);
		this.dtpReceipt.TabIndex = 1;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(10, 130);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(59, 13);
		this.Label2.TabIndex = 196;
		this.Label2.Text = "Atas Nama";
		this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
		this.dgvList.Location = new System.Drawing.Point(217, 78);
		this.dgvList.Name = "dgvList";
		this.dgvList.Size = new System.Drawing.Size(310, 204);
		this.dgvList.TabIndex = 4;
		this.txtCity.Location = new System.Drawing.Point(84, 153);
		this.txtCity.Name = "txtCity";
		this.txtCity.Size = new System.Drawing.Size(116, 20);
		this.txtCity.TabIndex = 3;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(10, 156);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(29, 13);
		this.Label1.TabIndex = 214;
		this.Label1.Text = "Kota";
		this.lblNumber.AutoSize = true;
		this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblNumber.Location = new System.Drawing.Point(81, 78);
		this.lblNumber.Name = "lblNumber";
		this.lblNumber.Size = new System.Drawing.Size(54, 13);
		this.lblNumber.TabIndex = 220;
		this.lblNumber.Text = "lblNumber";
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(10, 78);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(38, 13);
		this.Label3.TabIndex = 219;
		this.Label3.Text = "Nomer";
		this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.btnSearch.Location = new System.Drawing.Point(444, 16);
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.Size = new System.Drawing.Size(83, 23);
		this.btnSearch.TabIndex = 0;
		this.btnSearch.Text = "Pilih Customer";
		this.btnSearch.UseVisualStyleBackColor = true;
		this.lblAddress.BackColor = System.Drawing.Color.White;
		this.lblAddress.Cursor = System.Windows.Forms.Cursors.Hand;
		this.lblAddress.Location = new System.Drawing.Point(10, 31);
		this.lblAddress.Name = "lblAddress";
		this.lblAddress.Size = new System.Drawing.Size(350, 26);
		this.lblAddress.TabIndex = 218;
		this.lblAddress.Text = "lblAddress";
		this.lblName.BackColor = System.Drawing.Color.White;
		this.lblName.Cursor = System.Windows.Forms.Cursors.Hand;
		this.lblName.Location = new System.Drawing.Point(10, 8);
		this.lblName.Name = "lblName";
		this.lblName.Size = new System.Drawing.Size(428, 23);
		this.lblName.TabIndex = 217;
		this.lblName.Text = "lblName";
		this.Label4.BackColor = System.Drawing.Color.White;
		this.Label4.Location = new System.Drawing.Point(-11, -12);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(713, 79);
		this.Label4.TabIndex = 216;
		this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnPrint.Location = new System.Drawing.Point(472, 343);
		this.btnPrint.Name = "btnPrint";
		this.btnPrint.Size = new System.Drawing.Size(55, 24);
		this.btnPrint.TabIndex = 15;
		this.btnPrint.Text = "Cetak";
		this.btnPrint.UseVisualStyleBackColor = true;
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(540, 373);
		base.Controls.Add(this.btnPrint);
		base.Controls.Add(this.lblNumber);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.btnSearch);
		base.Controls.Add(this.lblAddress);
		base.Controls.Add(this.lblName);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.txtCity);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.btnSaveClose);
		base.Controls.Add(this.btnHistory);
		base.Controls.Add(this.Label12);
		base.Controls.Add(this.lblTotalInWords);
		base.Controls.Add(this.btnDelete);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.lblTotal);
		base.Controls.Add(this.txtName);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.dtpReceipt);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.dgvList);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmSalesReceipt";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Kuitansi";
		((System.ComponentModel.ISupportInitialize)this.dgvList).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmSalesReceipt()
	{
		base.KeyDown += frmReceipt_KeyDown;
		InitializeComponent();
		base.MdiParent = MyProject.Forms.frmMenu;
		DoubleBuffered = true;
		FormatGrid();
		btnSearch.Focus();
	}

	private void frmReceipt_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void FormatGrid()
	{
		DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
		dgvList.Columns.Add("", "ID");
		dgvList.Columns.Add(dataGridViewCheckBoxColumn);
		dataGridViewCheckBoxColumn.HeaderText = "";
		dataGridViewCheckBoxColumn.Name = "chk";
		dgvList.Columns.Add("", "Tanggal");
		dgvList.Columns.Add("", "No. Faktur");
		dgvList.Columns.Add("", "Jumlah");
		dgvList.Columns[0].Visible = false;
		dgvList.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
		dgvList.Columns[2].ReadOnly = true;
		dgvList.Columns[3].ReadOnly = true;
		dgvList.Columns[4].ReadOnly = true;
		dgvList.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvList.Columns[1].Width = 40;
		dgvList.Columns[2].Width = 70;
		dgvList.Columns[3].Width = 100;
		dgvList.Columns[4].Width = 80;
		dgvList.RowHeadersVisible = false;
		dgvList.AllowUserToAddRows = false;
		dgvList.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvList.AllowUserToResizeRows = false;
		dgvList.EditMode = DataGridViewEditMode.EditOnEnter;
	}

	public void prepareForm(bool SaveNew)
	{
		_currentId = 0.0;
		_customerId = 0.0;
		btnSearch.Visible = true;
		_receiveFrom = "";
		lblName.Text = "Klik tombol 'Pilih Customer' untuk memilih customer";
		lblAddress.Text = "";
		if (!SaveNew)
		{
			dtpReceipt.Value = DateAndTime.Now;
		}
		dtpReceipt.Enabled = true;
		txtName.Text = Module1.pubSalesReceiptName;
		txtCity.Text = Module1.pubSalesReceiptCity;
		lblTotal.Text = "";
		lblTotalInWords.Text = "";
		dgvList.Rows.Clear();
		lblNumber.Text = "auto";
		btnHistory.Enabled = false;
		btnDelete.Enabled = false;
		btnPrint.Enabled = false;
		btnSearch.Focus();
		_edited = false;
	}

	public void loadData()
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
					Cursor = Cursors.WaitCursor;
					cSalesReceipt cSalesReceipt2 = new cSalesReceipt(_currentId);
					_customerId = cSalesReceipt2.CustomerId;
					btnSearch.Visible = false;
					dtpReceipt.Enabled = false;
					lblName.Text = Conversions.ToString(Operators.ConcatenateObject(cSalesReceipt2.CustomerName, Interaction.IIf(Operators.CompareString(cSalesReceipt2.CustomerPT, "", TextCompare: false) != 0, " (" + cSalesReceipt2.CustomerPT + ")", "")));
					_receiveFrom = cSalesReceipt2.ReceiveFrom;
					lblAddress.Text = cSalesReceipt2.CustomerAddress;
					lblNumber.Text = Conversions.ToString(cSalesReceipt.FormatSalesReceiptNumber(Module1.pubSalesReceiptCode, cSalesReceipt2.Number, cSalesReceipt2.ReceiptMonth, cSalesReceipt2.ReceiptYear));
					dtpReceipt.Value = cSalesReceipt2.ReceiptDate;
					txtName.Text = cSalesReceipt2.Name;
					txtCity.Text = cSalesReceipt2.City;
					dgvList.Rows.Clear();
					cSalesReceipt.SalesInvoice[] invoice = cSalesReceipt2.Invoice;
					for (int i = 0; i < invoice.Length; i = checked(i + 1))
					{
						cSalesReceipt.SalesInvoice salesInvoice = invoice[i];
						dgvList.Rows.Add(salesInvoice._id, TriState.True, salesInvoice._date, salesInvoice._number, Module1.formatCustomDecimal(Conversions.ToString(salesInvoice._amount), 2));
					}
					GetReceiptCandidate();
					btnHistory.Enabled = true;
					if (DateAndTime.DateDiff(DateInterval.Day, dtpReceipt.Value, DateAndTime.Now) <= Module1.pubDaysLimit)
					{
						btnDelete.Enabled = true;
					}
					else
					{
						btnDelete.Enabled = false;
					}
					btnPrint.Enabled = true;
					_edited = false;
					Cursor = Cursors.Default;
					goto end_IL_0001;
				}
				case 631:
					num = -1;
					switch (num2)
					{
					case 2:
						Cursor = Cursors.Default;
						Module1.SaveError(Information.Err(), "frmSalesReceipt", "loadData", "");
						if (Information.Err().Number == 513)
						{
							Close();
						}
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 631;
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

	private void lblName_Click(object sender, EventArgs e)
	{
		OpenCustomer();
	}

	private void lblAddress_Click(object sender, EventArgs e)
	{
		OpenCustomer();
	}

	private void OpenCustomer()
	{
		if (_customerId > 0.0)
		{
			MyProject.Forms.frmCustomer.Show();
			MyProject.Forms.frmCustomer.prepareForm();
			MyProject.Forms.frmCustomer.CurrentId = _customerId;
			MyProject.Forms.frmCustomer.LoadData();
			MyProject.Forms.frmCustomer.Activate();
			MyProject.Forms.frmCustomer.WindowState = FormWindowState.Normal;
		}
	}

	public void GetReceiptCandidate()
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
					DataTable receiptCandidate = cSalesReceipt.GetReceiptCandidate(checked((int)Math.Round(_customerId)), Module1.pubGroupId);
					int count = dgvList.Rows.Count;
					IEnumerator enumerator = receiptCandidate.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						dgvList.Rows.Add(dataRow["penjId"], 0, dataRow["penjDate"], dataRow["penjFaktur"], Module1.formatCustomDecimal(Conversions.ToString(dataRow["amount"]), 2));
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					if (dgvList.Rows.Count > 0)
					{
						dgvList.CurrentRow.Selected = false;
					}
					CalculateTotal();
					goto end_IL_0001;
				}
				case 304:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSalesReceipt", "GetReceiptCandidate", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 304;
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

	private void CalculateTotal()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		double num4 = default(double);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						int num3 = dgvList.Rows.Count - 1;
						for (int i = 0; i <= num3; i++)
						{
							if (Operators.ConditionalCompareObjectEqual(dgvList[1, i].EditedFormattedValue, true, TextCompare: false))
							{
								num4 += Conversions.ToDouble(dgvList[4, i].Value);
							}
						}
						lblTotal.Text = Module1.formatCustomDecimal(Conversions.ToString(num4), 2);
						Label label = lblTotalInWords;
						string Indx = Conversions.ToString(num4);
						string value = Module1.Terbilang(ref Indx);
						num4 = Conversions.ToDouble(Indx);
						label.Text = Strings.Trim(Strings.LCase(value)) + " rupiah";
						goto end_IL_0001;
					}
					case 217:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmSalesReceipt", "CalculateTotal", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 217;
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

	private void dgvList_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			txtCity.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			btnSave.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		CalculateTotal();
		_edited = true;
	}

	private void dgvList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		CalculateTotal();
		_edited = true;
	}

	private void btnSearch_Click(object sender, EventArgs e)
	{
		frmCustomerMiniSearch frmCustomerMiniSearch2 = new frmCustomerMiniSearch();
		frmCustomerMiniSearch2.CallerName = "SalesReceipt";
		frmCustomerMiniSearch2.ShowDialog();
		frmCustomerMiniSearch2.Close();
		frmCustomerMiniSearch2.Dispose();
		dtpReceipt.Focus();
		if (_customerId > 0.0)
		{
			LoadCustomer();
		}
	}

	public void LoadCustomer()
	{
		cCustomer cCustomer2 = new cCustomer(_customerId);
		string text = cCustomer2.Name;
		_receiveFrom = cCustomer2.Name;
		if (Operators.CompareString(cCustomer2.PT, "", TextCompare: false) != 0)
		{
			text = text + " (" + cCustomer2.PT + ")";
			_receiveFrom = cCustomer2.PT;
		}
		lblName.Text = text;
		lblAddress.Text = cCustomer2.Address;
		dgvList.Rows.Clear();
		GetReceiptCandidate();
		dtpReceipt.Focus();
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		SaveData(CloseForm: false);
	}

	private void btnSaveClose_Click(object sender, EventArgs e)
	{
		SaveData(CloseForm: true);
	}

	private void SaveData(bool CloseForm)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num4 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						if (_customerId == 0.0)
						{
							Interaction.MsgBox("Pilih customer", MsgBoxStyle.Information);
							btnSearch.Focus();
							goto end_IL_0001;
						}
						if (!cValidation.isDateWithinRange(dtpReceipt.Value, Module1.pubGroupId, Module1.pubDaysLimit))
						{
							Interaction.MsgBox("Tanggal diluar batas yang diperbolehkan", MsgBoxStyle.Information);
							dtpReceipt.Focus();
							goto end_IL_0001;
						}
						if (Conversion.Val(lblTotal.Text) == 0.0)
						{
							Interaction.MsgBox("Pilih minimum 1 faktur", MsgBoxStyle.Information);
							dgvList.Focus();
							goto end_IL_0001;
						}
						if (Operators.CompareString(txtName.Text, "", TextCompare: false) == 0)
						{
							Interaction.MsgBox("Masukkan Atas Nama", MsgBoxStyle.Information);
							txtName.Focus();
							goto end_IL_0001;
						}
						if (Operators.CompareString(txtCity.Text, "", TextCompare: false) == 0)
						{
							Interaction.MsgBox("Masukkan Kota", MsgBoxStyle.Information);
							txtCity.Focus();
							goto end_IL_0001;
						}
						Cursor = Cursors.WaitCursor;
						cSalesReceipt cSalesReceipt2 = new cSalesReceipt(0.0);
						cSalesReceipt2.CustomerId = _customerId;
						cSalesReceipt2.Id = _currentId;
						cSalesReceipt2.ReceiveFrom = _receiveFrom;
						cSalesReceipt2.ReceiptDate = dtpReceipt.Value;
						cSalesReceipt2.ReceiptMonth = DateAndTime.Month(dtpReceipt.Value);
						cSalesReceipt2.ReceiptYear = DateAndTime.Year(dtpReceipt.Value);
						cSalesReceipt2.Name = txtName.Text;
						cSalesReceipt2.City = txtCity.Text;
						cSalesReceipt2.Amount = Conversions.ToDouble(lblTotal.Text);
						cSalesReceipt.SalesInvoice[] array = null;
						string text = "";
						int num3 = dgvList.Rows.Count - 1;
						for (int i = 0; i <= num3; i++)
						{
							if (Operators.ConditionalCompareObjectEqual(dgvList[1, i].Value, true, TextCompare: false))
							{
								array = (cSalesReceipt.SalesInvoice[])Utils.CopyArray(array, new cSalesReceipt.SalesInvoice[num4 + 1]);
								array[num4]._id = Conversions.ToDouble(dgvList[0, i].Value);
								num4++;
								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<tr><td>", dgvList[2, i].Value), "</td>"), "<td>"), dgvList[3, i].Value), "</td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(dgvList[4, i].Value), 2)), "</td></tr>")));
							}
						}
						cSalesReceipt2.Invoice = array;
						cSalesReceipt2.Save();
						string text2 = "Nomer: " + lblNumber.Text + "<br />Tanggal: " + Conversions.ToString(dtpReceipt.Value) + "<br />Atas Nama: " + txtName.Text + "<br />Kota: " + txtCity.Text + "<br /><br />";
						text2 += "Faktur:<br />";
						text2 += "<table>";
						text2 += "<tr><td>Tanggal</td><td>No Faktur</td><td>Hutang</td></tr>";
						text2 += text;
						text2 += "</table>";
						string text3;
						if (_currentId == 0.0)
						{
							text3 = "membuat ";
							_currentId = cSalesReceipt2.Id;
						}
						else
						{
							text3 = "mengupdate ";
						}
						text3 = text3 + "kuitansi tanggal " + Strings.Format(dtpReceipt.Value, "dd/MM/yyyy") + " untuk customer " + lblName.Text + ". ID= " + Conversions.ToString(_currentId) + ", v2";
						cHistory cHistory2 = new cHistory();
						cHistory2.Content = text2;
						cHistory2.Description = text3;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = _currentId;
						cHistory2.HistoryType = 15;
						cHistory2.Save();
						Cursor = Cursors.Default;
						Interaction.MsgBox("Kuitansi berhasil disimpan", MsgBoxStyle.Information);
						if (Module1.FormIsOpen("frmSalesReceiptList"))
						{
							MyProject.Forms.frmSalesReceiptList.GetRecent();
						}
						if (Module1.FormIsOpen("frmCustomer"))
						{
							MyProject.Forms.frmCustomer.GetSalesReceipt();
						}
						MyProject.Forms.frmInformation.GetActivity();
						if (CloseForm)
						{
							Close();
							goto end_IL_0001;
						}
						btnSearch.Visible = false;
						btnDelete.Enabled = true;
						btnHistory.Enabled = true;
						btnPrint.Enabled = true;
						_edited = false;
						goto end_IL_0001;
					}
					case 1491:
						num = -1;
						switch (num2)
						{
						case 2:
							Cursor = Cursors.Default;
							Module1.SaveError(Information.Err(), "frmSalesReceipt", "SaveData", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1491;
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

	private void btnDelete_Click(object sender, EventArgs e)
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
					if (MessageBox.Show("Hapus Kuitansi?", "Konfirmasi", MessageBoxButtons.YesNo) != DialogResult.No)
					{
						cSalesReceipt cSalesReceipt2 = new cSalesReceipt(_currentId);
						cSalesReceipt2.Delete();
						string description = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("menghapus Kuitansi ", cSalesReceipt.FormatSalesReceiptNumber(Module1.pubSalesReceiptCode, cSalesReceipt2.Number, cSalesReceipt2.ReceiptMonth, cSalesReceipt2.ReceiptYear)), ". Tanggal  "), Strings.Format(cSalesReceipt2.ReceiptDate, "dd/MM/yyyy")), ". ID= "), _currentId), ", v2"));
						cHistory cHistory2 = new cHistory();
						cHistory2.Description = description;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = _currentId;
						cHistory2.HistoryType = 15;
						cHistory2.Save();
						Interaction.MsgBox("Kuitansi berhasil dihapus", MsgBoxStyle.Information);
						if (Module1.FormIsOpen("frmSalesReceiptList"))
						{
							MyProject.Forms.frmSalesReceiptList.GetRecent();
						}
						MyProject.Forms.frmInformation.GetActivity();
						Close();
					}
					goto end_IL_0001;
				case 352:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmSalesReceipt", "btnDelete_Click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 352;
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

	private void btnHistory_Click(object sender, EventArgs e)
	{
		MyProject.Forms.frmHistory.GetHistory(checked((int)Math.Round(_currentId)), 15);
		MyProject.Forms.frmHistory.Show();
		MyProject.Forms.frmHistory.Activate();
		MyProject.Forms.frmHistory.WindowState = FormWindowState.Normal;
	}

	private void btnPrint_Click(object sender, EventArgs e)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						if (_edited && btnSave.Enabled)
						{
							if (MessageBox.Show("Anda melakukan perubahan data.\r\nSimpan Kuitansi sebelum mencetak?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
							{
								SaveData(CloseForm: false);
							}
							goto end_IL_0001;
						}
						Printer val = new Printer();
						val.ScaleMode = 6;
						val.Width = 11907;
						val.Height = 7880;
						val.Font = new Font("Times New Roman", 18f, FontStyle.Bold);
						val.CurrentX = 95f;
						val.CurrentY = 30f;
						val.Print(new object[1] { "KUITANSI" });
						val.Font = new Font("Times New Roman", 12f, FontStyle.Regular);
						int num3 = 25;
						val.CurrentX = num3;
						val.CurrentY = 40f;
						val.Print(new object[1] { "No. " + lblNumber.Text });
						val.CurrentX = num3;
						val.CurrentY = 47f;
						val.Print(new object[1] { "Telah terima dari " + _receiveFrom });
						val.CurrentX = num3;
						val.CurrentY = 54f;
						val.Print(new object[1] { "Uang sejumlah" });
						val.Font = new Font("Times New Roman", 12f, FontStyle.Italic);
						string[] array = Module1.divideString(lblTotalInWords.Text, 75);
						int num4 = 54;
						int num5 = Information.LBound(array);
						int num6 = Information.UBound(array);
						for (int i = num5; i <= num6; i++)
						{
							val.CurrentX = 55f;
							val.CurrentY = num4;
							val.Print(new object[1] { array[i] });
							num4 += 5;
						}
						val.Font = new Font("Times New Roman", 12f, FontStyle.Regular);
						string text = "";
						int num7 = dgvList.Rows.Count - 1;
						for (int i = 0; i <= num7; i++)
						{
							if (Operators.ConditionalCompareObjectEqual(dgvList[1, i].Value, true, TextCompare: false))
							{
								if (Operators.CompareString(text, "", TextCompare: false) != 0)
								{
									text += ", ";
								}
								text = Conversions.ToString(Operators.ConcatenateObject(text, dgvList[3, i].Value));
							}
						}
						val.CurrentX = num3;
						num4 += 2;
						val.CurrentY = num4;
						val.Print(new object[1] { Module1.pubSalesReceiptDescription });
						string[] array2 = Module1.divideString(text, 75);
						val.CurrentX = num3;
						val.CurrentY = num4 + 7;
						val.Print(new object[1] { "No. Faktur: " + array2[0] });
						if (Information.UBound(array2) > 0)
						{
							val.CurrentX = num3;
							val.CurrentY = num4 + 12;
							val.Print(new object[1] { array2[1] });
						}
						val.CurrentX = 140f;
						val.CurrentY = 80f;
						val.Print(new object[1] { txtCity.Text + ", " + Strings.Format(dtpReceipt.Value, "d MMMM yyyy") });
						int num8 = (int)Math.Round(val.TextWidth(txtCity.Text + ", " + Strings.Format(dtpReceipt.Value, "d MMMM yyyy")));
						num4 = 115;
						val.Line(20f, (float)(num4 - 2), 80f, (float)(num4 + 7), -1, true, false);
						val.CurrentX = 25f;
						val.CurrentY = num4;
						val.Print(new object[1] { "Rp. " + lblTotal.Text });
						int num9 = (int)Math.Round(((float)num8 - val.TextWidth(txtName.Text)) / 2f);
						val.CurrentX = 140 + num9;
						val.CurrentY = num4;
						val.Print(new object[1] { txtName.Text });
						val.NewPage();
						val.EndDoc();
						goto end_IL_0001_2;
					}
					case 1217:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmSalesReceipt", "btnPrint_click", "");
							goto end_IL_0001_2;
						}
						break;
					}
					goto IL_04f7;
				}
				end_IL_0001_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1217;
				continue;
			}
			break;
			IL_04f7:
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

	private void dtpReceipt_ValueChanged(object sender, EventArgs e)
	{
		_edited = true;
	}

	private void txtName_TextChanged(object sender, EventArgs e)
	{
		_edited = true;
	}

	private void txtCity_TextChanged(object sender, EventArgs e)
	{
		_edited = true;
	}
}
