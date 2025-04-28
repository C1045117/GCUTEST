using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GCUv2.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

[DesignerGenerated]
public class frmJournalTransaction : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnHistory")]
	private Button _btnHistory;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnSaveClose")]
	private Button _btnSaveClose;

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
	[AccessedThroughProperty("btnAccount")]
	private Button _btnAccount;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvAccount")]
	private DataGridView _dgvAccount;

	private double _currentId;

	private double TotalDebit;

	private double TotalCredit;

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

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDescription")]
	internal virtual TextBox txtDescription
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

	[field: AccessedThroughProperty("dtpVoucher")]
	internal virtual DateTimePicker dtpVoucher
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

	[field: AccessedThroughProperty("TabControl1")]
	internal virtual TabControl TabControl1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage1")]
	internal virtual TabPage TabPage1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnAccount
	{
		[CompilerGenerated]
		get
		{
			return _btnAccount;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnAccount_Click;
			Button button = _btnAccount;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnAccount = value;
			button = _btnAccount;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual DataGridView dgvAccount
	{
		[CompilerGenerated]
		get
		{
			return _dgvAccount;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dgvAccount_GotFocus;
			EventHandler value3 = dgvAccount_LostFocus;
			EventHandler value4 = dgvAccount_DoubleClick;
			KeyEventHandler value5 = dgvAccount_KeyDown;
			DataGridView dataGridView = _dgvAccount;
			if (dataGridView != null)
			{
				dataGridView.GotFocus -= value2;
				dataGridView.LostFocus -= value3;
				dataGridView.DoubleClick -= value4;
				dataGridView.KeyDown -= value5;
			}
			_dgvAccount = value;
			dataGridView = _dgvAccount;
			if (dataGridView != null)
			{
				dataGridView.GotFocus += value2;
				dataGridView.LostFocus += value3;
				dataGridView.DoubleClick += value4;
				dataGridView.KeyDown += value5;
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
		this.btnHistory = new System.Windows.Forms.Button();
		this.btnSaveClose = new System.Windows.Forms.Button();
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.Label11 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.txtDescription = new System.Windows.Forms.TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.dtpVoucher = new System.Windows.Forms.DateTimePicker();
		this.lblNumber = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.btnAccount = new System.Windows.Forms.Button();
		this.dgvAccount = new System.Windows.Forms.DataGridView();
		this.TabControl1.SuspendLayout();
		this.TabPage1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvAccount).BeginInit();
		base.SuspendLayout();
		this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnHistory.Location = new System.Drawing.Point(472, 317);
		this.btnHistory.Name = "btnHistory";
		this.btnHistory.Size = new System.Drawing.Size(50, 24);
		this.btnHistory.TabIndex = 17;
		this.btnHistory.Text = "&History";
		this.btnHistory.UseVisualStyleBackColor = true;
		this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSaveClose.Location = new System.Drawing.Point(318, 317);
		this.btnSaveClose.Name = "btnSaveClose";
		this.btnSaveClose.Size = new System.Drawing.Size(93, 24);
		this.btnSaveClose.TabIndex = 15;
		this.btnSaveClose.Text = "Simpan && &Tutup";
		this.btnSaveClose.UseVisualStyleBackColor = true;
		this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnDelete.Location = new System.Drawing.Point(417, 317);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(49, 24);
		this.btnDelete.TabIndex = 16;
		this.btnDelete.Text = "Hapus";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSave.Location = new System.Drawing.Point(226, 317);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(86, 24);
		this.btnSave.TabIndex = 14;
		this.btnSave.Text = "&Simpan && Baru";
		this.btnSave.UseVisualStyleBackColor = true;
		this.Label11.BackColor = System.Drawing.Color.Silver;
		this.Label11.Location = new System.Drawing.Point(-315, 307);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(851, 59);
		this.Label11.TabIndex = 184;
		this.Label8.AutoSize = true;
		this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label8.Location = new System.Drawing.Point(10, 68);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(62, 13);
		this.Label8.TabIndex = 183;
		this.Label8.Text = "Keterangan";
		this.txtDescription.Location = new System.Drawing.Point(89, 62);
		this.txtDescription.MaxLength = 100;
		this.txtDescription.Multiline = true;
		this.txtDescription.Name = "txtDescription";
		this.txtDescription.Size = new System.Drawing.Size(165, 52);
		this.txtDescription.TabIndex = 1;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(10, 39);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(46, 13);
		this.Label1.TabIndex = 178;
		this.Label1.Text = "Tanggal";
		this.dtpVoucher.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpVoucher.Location = new System.Drawing.Point(89, 36);
		this.dtpVoucher.Name = "dtpVoucher";
		this.dtpVoucher.Size = new System.Drawing.Size(163, 20);
		this.dtpVoucher.TabIndex = 0;
		this.lblNumber.AutoSize = true;
		this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblNumber.Location = new System.Drawing.Point(88, 15);
		this.lblNumber.Name = "lblNumber";
		this.lblNumber.Size = new System.Drawing.Size(54, 13);
		this.lblNumber.TabIndex = 189;
		this.lblNumber.Text = "lblNumber";
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.Location = new System.Drawing.Point(10, 15);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(38, 13);
		this.Label3.TabIndex = 188;
		this.Label3.Text = "Nomer";
		this.TabControl1.Controls.Add(this.TabPage1);
		this.TabControl1.Location = new System.Drawing.Point(13, 120);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(509, 173);
		this.TabControl1.TabIndex = 11;
		this.TabPage1.Controls.Add(this.btnAccount);
		this.TabPage1.Controls.Add(this.dgvAccount);
		this.TabPage1.Location = new System.Drawing.Point(4, 22);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage1.Size = new System.Drawing.Size(501, 147);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "Akun";
		this.TabPage1.UseVisualStyleBackColor = true;
		this.btnAccount.BackColor = System.Drawing.SystemColors.ButtonFace;
		this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAccount.Location = new System.Drawing.Point(6, 6);
		this.btnAccount.Name = "btnAccount";
		this.btnAccount.Size = new System.Drawing.Size(61, 24);
		this.btnAccount.TabIndex = 12;
		this.btnAccount.Text = "+ Akun";
		this.btnAccount.UseVisualStyleBackColor = false;
		this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvAccount.Location = new System.Drawing.Point(6, 36);
		this.dgvAccount.Name = "dgvAccount";
		this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dgvAccount.Size = new System.Drawing.Size(489, 105);
		this.dgvAccount.TabIndex = 13;
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(534, 349);
		base.Controls.Add(this.TabControl1);
		base.Controls.Add(this.lblNumber);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.btnHistory);
		base.Controls.Add(this.btnSaveClose);
		base.Controls.Add(this.btnDelete);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.txtDescription);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.dtpVoucher);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmJournalTransaction";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Bukti Jurnal Umum";
		this.TabControl1.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvAccount).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmJournalTransaction()
	{
		base.KeyDown += frmJournalTransaction_KeyDown;
		InitializeComponent();
		DoubleBuffered = true;
		base.MdiParent = MyProject.Forms.frmMenu;
		formatGrid();
	}

	private void frmJournalTransaction_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	private void formatGrid()
	{
		dgvAccount.Columns.Add("", "accountId");
		dgvAccount.Columns.Add("", "DebitCredit");
		dgvAccount.Columns.Add("", "Akun");
		dgvAccount.Columns.Add("", "Debit");
		dgvAccount.Columns.Add("", "Kredit");
		dgvAccount.Columns.Add("", "Mata Uang");
		dgvAccount.Columns.Add("", "Kurs");
		dgvAccount.Columns[0].Visible = false;
		dgvAccount.Columns[1].Visible = false;
		dgvAccount.Columns[2].Width = 120;
		dgvAccount.Columns[3].Width = 100;
		dgvAccount.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvAccount.Columns[4].Width = 100;
		dgvAccount.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvAccount.Columns[5].Width = 50;
		dgvAccount.Columns[6].Width = 100;
		dgvAccount.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvAccount.RowHeadersVisible = false;
		dgvAccount.AllowUserToAddRows = false;
		dgvAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvAccount.ReadOnly = true;
		dgvAccount.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvAccount.AllowUserToResizeRows = false;
	}

	public void prepareForm(bool SaveNew)
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
					_currentId = 0.0;
					TotalDebit = 0.0;
					TotalCredit = 0.0;
					lblNumber.Text = "auto";
					if (!SaveNew)
					{
						dtpVoucher.Value = DateAndTime.Now;
					}
					txtDescription.Text = "";
					dgvAccount.Rows.Clear();
					dtpVoucher.Enabled = true;
					btnHistory.Enabled = false;
					btnDelete.Enabled = false;
					goto end_IL_0001;
				case 203:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmJournalTransaction", "prepareForm", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 203;
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

	public void LoadData()
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
					cVoucher cVoucher2 = new cVoucher(_currentId);
					lblNumber.Text = cVoucher2.VoucherNumber;
					dtpVoucher.Value = cVoucher2.VoucherDate;
					txtDescription.Text = cVoucher2.VoucherDescription;
					cVoucherAccount[] account = cVoucher2.Account;
					foreach (cVoucherAccount cVoucherAccount2 in account)
					{
						dgvAccount.Rows.Add(cVoucherAccount2.AccountId, cVoucherAccount2.VoucherDebitCredit, cVoucherAccount2.AccountNumber + " - " + cVoucherAccount2.AccountName, (cVoucherAccount2.VoucherDebitCredit == 1) ? Module1.formatCustomDecimal(Conversions.ToString(cVoucherAccount2.VoucherAmount), 2) : "", (cVoucherAccount2.VoucherDebitCredit == 2) ? Module1.formatCustomDecimal(Conversions.ToString(cVoucherAccount2.VoucherAmount), 2) : "", cVoucherAccount2.CurrencyName, Module1.formatCustomDecimal(Conversions.ToString(cVoucherAccount2.CurrencyRate), 2));
					}
					if (dgvAccount.RowCount > 0)
					{
						dgvAccount.CurrentRow.Selected = false;
					}
					btnHistory.Enabled = true;
					if (DateAndTime.DateDiff(DateInterval.Day, dtpVoucher.Value, DateAndTime.Now) <= Module1.pubDaysLimit)
					{
						dtpVoucher.Enabled = true;
					}
					else
					{
						dtpVoucher.Enabled = false;
					}
					if (DateAndTime.DateDiff(DateInterval.Day, dtpVoucher.Value, DateAndTime.Now) <= Module1.pubDaysLimit)
					{
						btnDelete.Enabled = true;
					}
					else
					{
						btnDelete.Enabled = false;
					}
					goto end_IL_0001;
				}
				case 535:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmJournalTransaction", "loadData", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 535;
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

	public void calculateTotal()
	{
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
						TotalDebit = 0.0;
						TotalCredit = 0.0;
						int num3 = dgvAccount.Rows.Count - 1;
						for (int i = 0; i <= num3; i++)
						{
							if (Operators.ConditionalCompareObjectEqual(dgvAccount[1, i].Value, 1, TextCompare: false))
							{
								ref double totalDebit = ref TotalDebit;
								totalDebit = Conversions.ToDouble(Operators.AddObject(totalDebit, Operators.MultiplyObject(dgvAccount[3, i].Value, dgvAccount[6, i].Value)));
							}
							else
							{
								ref double totalCredit = ref TotalCredit;
								totalCredit = Conversions.ToDouble(Operators.AddObject(totalCredit, Operators.MultiplyObject(dgvAccount[4, i].Value, dgvAccount[6, i].Value)));
							}
						}
						goto end_IL_0001;
					}
					case 289:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmTransactionJournal", "CalculateTotal", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 289;
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

	private void btnAccount_Click(object sender, EventArgs e)
	{
		frmJournalTransactionAccount frmJournalTransactionAccount2 = new frmJournalTransactionAccount(CurrentData: false);
		frmJournalTransactionAccount2.ShowDialog();
		frmJournalTransactionAccount2.Close();
		frmJournalTransactionAccount2.Dispose();
	}

	private void dgvAccount_GotFocus(object sender, EventArgs e)
	{
		if (dgvAccount.RowCount > 0)
		{
			dgvAccount.CurrentRow.Selected = true;
		}
	}

	private void dgvAccount_LostFocus(object sender, EventArgs e)
	{
		if (dgvAccount.RowCount > 0)
		{
			dgvAccount.CurrentRow.Selected = false;
		}
	}

	private void dgvAccount_DoubleClick(object sender, EventArgs e)
	{
		OpenAccount();
	}

	private void dgvAccount_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			OpenAccount();
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			btnAccount.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			btnSave.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void OpenAccount()
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
					if (dgvAccount.Rows.Count > 0)
					{
						frmJournalTransactionAccount frmJournalTransactionAccount2 = new frmJournalTransactionAccount(CurrentData: true);
						ComboBox cboSource = frmJournalTransactionAccount2.cboAccount;
						Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvAccount[0, dgvAccount.CurrentRow.Index].Value));
						frmJournalTransactionAccount2.cboAccount = cboSource;
						cboSource = frmJournalTransactionAccount2.cboDebitCredit;
						Module1.comboBoundValue(ref cboSource, Conversions.ToDouble(dgvAccount[1, dgvAccount.CurrentRow.Index].Value));
						frmJournalTransactionAccount2.cboDebitCredit = cboSource;
						if (Operators.ConditionalCompareObjectEqual(dgvAccount[1, dgvAccount.CurrentRow.Index].Value, 1, TextCompare: false))
						{
							frmJournalTransactionAccount2.txtAmount.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvAccount[3, dgvAccount.CurrentRow.Index].Value), 2);
						}
						else
						{
							frmJournalTransactionAccount2.txtAmount.Text = Module1.formatCustomDecimal(Conversions.ToString(dgvAccount[4, dgvAccount.CurrentRow.Index].Value), 2);
						}
						frmJournalTransactionAccount2.ShowDialog();
					}
					goto end_IL_0001;
				case 377:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmJournalTransaction", "OpenAccount", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 377;
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
						if (!cValidation.isDateWithinRange(dtpVoucher.Value, Module1.pubGroupId, Module1.pubDaysLimit))
						{
							Interaction.MsgBox("Tanggal diluar batas yang diperbolehkan", MsgBoxStyle.Information);
							dtpVoucher.Focus();
							goto end_IL_0001;
						}
						if (Strings.Len(txtDescription.Text) > 100)
						{
							Interaction.MsgBox("Deskripsi tidak boleh melebihi 100 karakter", MsgBoxStyle.Information);
							txtDescription.Focus();
							goto end_IL_0001;
						}
						if (dgvAccount.Rows.Count < 2)
						{
							Interaction.MsgBox("Minimum 2 akun (1 Debit dan 1 Kredit) harus dimasukkan.", MsgBoxStyle.Information);
							btnAccount.Focus();
							goto end_IL_0001;
						}
						if (TotalDebit != TotalCredit)
						{
							Interaction.MsgBox("Debit dan Kredit tidak seimbang.", MsgBoxStyle.Information);
							dgvAccount.Focus();
							goto end_IL_0001;
						}
						cVoucher cVoucher2 = new cVoucher(0.0);
						cVoucherAccount[] array = new cVoucherAccount[dgvAccount.Rows.Count - 1 + 1];
						int num3 = 0;
						cVoucher2.VoucherId = _currentId;
						cVoucher2.VoucherType = 1;
						cVoucher2.VoucherDate = dtpVoucher.Value;
						cVoucher2.VoucherDescription = txtDescription.Text;
						int num4 = dgvAccount.Rows.Count - 1;
						for (num3 = 0; num3 <= num4; num3++)
						{
							double voucherAmount = ((!Operators.ConditionalCompareObjectEqual(dgvAccount[1, num3].Value, 1, TextCompare: false)) ? Conversions.ToDouble(dgvAccount[4, num3].Value) : Conversions.ToDouble(dgvAccount[3, num3].Value));
							array[num3] = new cVoucherAccount();
							array[num3].VoucherAmount = voucherAmount;
							array[num3].AccountId = Conversions.ToInteger(dgvAccount[0, num3].Value);
							array[num3].CurrencyRate = Conversions.ToDouble(dgvAccount[6, num3].Value);
							array[num3].VoucherDebitCredit = Conversions.ToInteger(dgvAccount[1, num3].Value);
							array[num3].CounterAccountId = Conversions.ToInteger(dgvAccount[0, num3].Value);
						}
						cVoucher2.Account = array;
						cVoucher2.save();
						if (Operators.CompareString(lblNumber.Text, "auto", TextCompare: false) == 0)
						{
							lblNumber.Text = "VOU/" + Strings.Right(Conversions.ToString(DateAndTime.Year(cVoucher2.VoucherDate)), 2) + "/" + cVoucher2.VoucherNumber;
						}
						string text = "Tanggal: " + Conversions.ToString(dtpVoucher.Value) + "<br />Keterangan: " + txtDescription.Text + "<br /><br />";
						text += "<table><tr><td>Akun</ td><td>Debit</ td><td>Kredit</ td><td>Mata Uang</ td><td>Kurs</ td></tr>";
						int num5 = dgvAccount.Rows.Count - 1;
						for (num3 = 0; num3 <= num5; num3++)
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<tr><td>", dgvAccount[2, num3].Value), "</ td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(Conversion.Val(Module1.unformatNumber(Conversions.ToString(dgvAccount[3, num3].Value)))), 2)), "</ td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(Conversion.Val(Module1.unformatNumber(Conversions.ToString(dgvAccount[4, num3].Value)))), 2)), "</ td>"), "<td align='right'>"), dgvAccount[5, num3].Value), "</ td>"), "<td align='right'>"), Module1.formatCustomDecimal(Conversions.ToString(Conversion.Val(Module1.unformatNumber(Conversions.ToString(dgvAccount[6, num3].Value)))), 2)), "</ td>"), "</tr>")));
						}
						text += "</table>";
						string text2;
						if (_currentId == 0.0)
						{
							text2 = "membuat ";
							_currentId = cVoucher2.VoucherId;
						}
						else
						{
							text2 = "mengupdate ";
						}
						text2 = text2 + "Bukti Jurnal Umum: " + lblNumber.Text + ". Tanggal " + Strings.Format(dtpVoucher.Value, "dd/MM/yyyy") + ". ID= " + Conversions.ToString(_currentId) + ", v2";
						cHistory cHistory2 = new cHistory();
						cHistory2.Content = text;
						cHistory2.Description = text2;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = _currentId;
						cHistory2.HistoryType = 14;
						cHistory2.Save();
						Interaction.MsgBox("Bukti Jurnal Umum berhasil disimpan", MsgBoxStyle.Information);
						if (Module1.FormIsOpen("frmJournalTransactionList"))
						{
							MyProject.Forms.frmJournalTransactionList.GetRecent();
						}
						MyProject.Forms.frmInformation.GetActivity();
						if (CloseForm)
						{
							Close();
							goto end_IL_0001;
						}
						prepareForm(SaveNew: true);
						dtpVoucher.Focus();
						goto end_IL_0001;
					}
					case 1582:
						num = -1;
						switch (num2)
						{
						case 2:
							Module1.SaveError(Information.Err(), "frmJournalTransaction", "SaveData", "");
							goto end_IL_0001;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1582;
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
					if (MessageBox.Show("Hapus Transaksi Jurnal?", "Konfirmasi", MessageBoxButtons.YesNo) != DialogResult.No)
					{
						cVoucher cVoucher2 = new cVoucher(_currentId);
						cVoucher2.Delete();
						string description = "menghapus Transaksi Jurnal: " + lblNumber.Text + ". Tanggal  " + Strings.Format(cVoucher2.VoucherDate, "dd/MM/yyyy") + ". ID= " + Conversions.ToString(_currentId) + ", v2";
						cHistory cHistory2 = new cHistory();
						cHistory2.Description = description;
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.fKeyId = _currentId;
						cHistory2.HistoryType = 14;
						cHistory2.Save();
						Interaction.MsgBox("Transaksi Jurnal berhasil dihapus", MsgBoxStyle.Information);
						if (Module1.FormIsOpen("frmJournalTransactionList"))
						{
							MyProject.Forms.frmJournalTransactionList.GetRecent();
						}
						MyProject.Forms.frmInformation.GetActivity();
						Close();
					}
					goto end_IL_0001;
				case 332:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmJournalTransaction", "btnDelete_click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 332;
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
		MyProject.Forms.frmHistory.GetHistory(checked((int)Math.Round(_currentId)), 14);
		MyProject.Forms.frmHistory.Show();
		MyProject.Forms.frmHistory.Activate();
		MyProject.Forms.frmHistory.WindowState = FormWindowState.Normal;
	}
}
