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
public class frmChequeIn : Form
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
	[AccessedThroughProperty("chkNoDeposit")]
	private CheckBox _chkNoDeposit;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("chkDeposit")]
	private CheckBox _chkDeposit;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("chkClearing")]
	private CheckBox _chkClearing;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("chkNoClearing")]
	private CheckBox _chkNoClearing;

	private double _currentId;

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

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
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

	[field: AccessedThroughProperty("dtpDeposit")]
	internal virtual DateTimePicker dtpDeposit
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual CheckBox chkNoDeposit
	{
		[CompilerGenerated]
		get
		{
			return _chkNoDeposit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = chkNoDeposit_CheckedChanged;
			CheckBox checkBox = _chkNoDeposit;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value2;
			}
			_chkNoDeposit = value;
			checkBox = _chkNoDeposit;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value2;
			}
		}
	}

	internal virtual CheckBox chkDeposit
	{
		[CompilerGenerated]
		get
		{
			return _chkDeposit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = chkDeposit_CheckedChanged;
			CheckBox checkBox = _chkDeposit;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value2;
			}
			_chkDeposit = value;
			checkBox = _chkDeposit;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value2;
			}
		}
	}

	internal virtual CheckBox chkClearing
	{
		[CompilerGenerated]
		get
		{
			return _chkClearing;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = chkClearing_CheckedChanged;
			CheckBox checkBox = _chkClearing;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value2;
			}
			_chkClearing = value;
			checkBox = _chkClearing;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value2;
			}
		}
	}

	internal virtual CheckBox chkNoClearing
	{
		[CompilerGenerated]
		get
		{
			return _chkNoClearing;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = chkNoClearing_CheckedChanged;
			CheckBox checkBox = _chkNoClearing;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value2;
			}
			_chkNoClearing = value;
			checkBox = _chkNoClearing;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dtpClearing")]
	internal virtual DateTimePicker dtpClearing
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
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

	[field: AccessedThroughProperty("lblChequeDate")]
	internal virtual Label lblChequeDate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblChequeNo")]
	internal virtual Label lblChequeNo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAmount")]
	internal virtual Label lblAmount
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAccountName")]
	internal virtual Label lblAccountName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
		this.Label11 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.dtpDeposit = new System.Windows.Forms.DateTimePicker();
		this.chkNoDeposit = new System.Windows.Forms.CheckBox();
		this.chkDeposit = new System.Windows.Forms.CheckBox();
		this.chkClearing = new System.Windows.Forms.CheckBox();
		this.chkNoClearing = new System.Windows.Forms.CheckBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.dtpClearing = new System.Windows.Forms.DateTimePicker();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Label8 = new System.Windows.Forms.Label();
		this.lblChequeDate = new System.Windows.Forms.Label();
		this.lblChequeNo = new System.Windows.Forms.Label();
		this.lblAmount = new System.Windows.Forms.Label();
		this.lblAccountName = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnHistory.Location = new System.Drawing.Point(189, 216);
		this.btnHistory.Name = "btnHistory";
		this.btnHistory.Size = new System.Drawing.Size(50, 24);
		this.btnHistory.TabIndex = 22;
		this.btnHistory.Text = "&History";
		this.btnHistory.UseVisualStyleBackColor = true;
		this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnSaveClose.Location = new System.Drawing.Point(90, 216);
		this.btnSaveClose.Name = "btnSaveClose";
		this.btnSaveClose.Size = new System.Drawing.Size(93, 24);
		this.btnSaveClose.TabIndex = 21;
		this.btnSaveClose.Text = "Simpan && &Tutup";
		this.btnSaveClose.UseVisualStyleBackColor = true;
		this.Label11.BackColor = System.Drawing.Color.Silver;
		this.Label11.Location = new System.Drawing.Point(-245, 208);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(713, 43);
		this.Label11.TabIndex = 148;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.Location = new System.Drawing.Point(12, 101);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(32, 13);
		this.Label1.TabIndex = 141;
		this.Label1.Text = "Setor";
		this.dtpDeposit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpDeposit.Location = new System.Drawing.Point(190, 123);
		this.dtpDeposit.Name = "dtpDeposit";
		this.dtpDeposit.Size = new System.Drawing.Size(138, 20);
		this.dtpDeposit.TabIndex = 130;
		this.chkNoDeposit.AutoSize = true;
		this.chkNoDeposit.Location = new System.Drawing.Point(92, 101);
		this.chkNoDeposit.Name = "chkNoDeposit";
		this.chkNoDeposit.Size = new System.Drawing.Size(89, 17);
		this.chkNoDeposit.TabIndex = 0;
		this.chkNoDeposit.Text = "Belum disetor";
		this.chkNoDeposit.UseVisualStyleBackColor = true;
		this.chkDeposit.AutoSize = true;
		this.chkDeposit.Location = new System.Drawing.Point(92, 125);
		this.chkDeposit.Name = "chkDeposit";
		this.chkDeposit.Size = new System.Drawing.Size(91, 17);
		this.chkDeposit.TabIndex = 1;
		this.chkDeposit.Text = "Tanggal setor";
		this.chkDeposit.UseVisualStyleBackColor = true;
		this.chkClearing.AutoSize = true;
		this.chkClearing.Location = new System.Drawing.Point(92, 175);
		this.chkClearing.Name = "chkClearing";
		this.chkClearing.Size = new System.Drawing.Size(99, 17);
		this.chkClearing.TabIndex = 3;
		this.chkClearing.Text = "Tanggal masuk";
		this.chkClearing.UseVisualStyleBackColor = true;
		this.chkNoClearing.AutoSize = true;
		this.chkNoClearing.Location = new System.Drawing.Point(92, 151);
		this.chkNoClearing.Name = "chkNoClearing";
		this.chkNoClearing.Size = new System.Drawing.Size(89, 17);
		this.chkNoClearing.TabIndex = 2;
		this.chkNoClearing.Text = "Belum masuk";
		this.chkNoClearing.UseVisualStyleBackColor = true;
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.Location = new System.Drawing.Point(12, 151);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(39, 13);
		this.Label2.TabIndex = 152;
		this.Label2.Text = "Masuk";
		this.dtpClearing.Format = System.Windows.Forms.DateTimePickerFormat.Short;
		this.dtpClearing.Location = new System.Drawing.Point(190, 173);
		this.dtpClearing.Name = "dtpClearing";
		this.dtpClearing.Size = new System.Drawing.Size(138, 20);
		this.dtpClearing.TabIndex = 151;
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.Location = new System.Drawing.Point(12, 9);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(71, 13);
		this.Label5.TabIndex = 157;
		this.Label5.Text = "Tgl. Cek/Giro";
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.Location = new System.Drawing.Point(12, 32);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(70, 13);
		this.Label6.TabIndex = 158;
		this.Label6.Text = "No. Cek/Giro";
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.Location = new System.Drawing.Point(12, 55);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(40, 13);
		this.Label7.TabIndex = 159;
		this.Label7.Text = "Jumlah";
		this.Label8.AutoSize = true;
		this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label8.Location = new System.Drawing.Point(12, 77);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(53, 13);
		this.Label8.TabIndex = 160;
		this.Label8.Text = "Rekening";
		this.lblChequeDate.AutoSize = true;
		this.lblChequeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblChequeDate.Location = new System.Drawing.Point(89, 9);
		this.lblChequeDate.Name = "lblChequeDate";
		this.lblChequeDate.Size = new System.Drawing.Size(77, 13);
		this.lblChequeDate.TabIndex = 161;
		this.lblChequeDate.Text = "lblChequeDate";
		this.lblChequeNo.AutoSize = true;
		this.lblChequeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblChequeNo.Location = new System.Drawing.Point(89, 32);
		this.lblChequeNo.Name = "lblChequeNo";
		this.lblChequeNo.Size = new System.Drawing.Size(68, 13);
		this.lblChequeNo.TabIndex = 162;
		this.lblChequeNo.Text = "lblChequeNo";
		this.lblAmount.AutoSize = true;
		this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblAmount.Location = new System.Drawing.Point(89, 55);
		this.lblAmount.Name = "lblAmount";
		this.lblAmount.Size = new System.Drawing.Size(53, 13);
		this.lblAmount.TabIndex = 163;
		this.lblAmount.Text = "lblAmount";
		this.lblAccountName.AutoSize = true;
		this.lblAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblAccountName.Location = new System.Drawing.Point(89, 77);
		this.lblAccountName.Name = "lblAccountName";
		this.lblAccountName.Size = new System.Drawing.Size(85, 13);
		this.lblAccountName.TabIndex = 164;
		this.lblAccountName.Text = "lblAccountName";
		base.AcceptButton = this.btnSaveClose;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(346, 249);
		base.Controls.Add(this.lblAccountName);
		base.Controls.Add(this.lblAmount);
		base.Controls.Add(this.lblChequeNo);
		base.Controls.Add(this.lblChequeDate);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.chkClearing);
		base.Controls.Add(this.chkNoClearing);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.dtpClearing);
		base.Controls.Add(this.chkDeposit);
		base.Controls.Add(this.chkNoDeposit);
		base.Controls.Add(this.btnHistory);
		base.Controls.Add(this.btnSaveClose);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.dtpDeposit);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmChequeIn";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Setor Cek/Giro";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public frmChequeIn()
	{
		base.KeyDown += frmChequeIn_KeyDown;
		InitializeComponent();
		DoubleBuffered = true;
		base.MdiParent = MyProject.Forms.frmMenu;
	}

	private void frmChequeIn_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
	}

	public void prepareForm()
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
					btnHistory.Enabled = false;
					goto end_IL_0001;
				case 69:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmChequeIn", "prepareForm", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 69;
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
					cChequeIn cChequeIn2 = new cChequeIn(_currentId, 0.0, 0.0);
					lblChequeDate.Text = Conversions.ToString(cChequeIn2.ChequeDate);
					lblChequeNo.Text = cChequeIn2.Number;
					lblAmount.Text = Module1.formatCustomDecimal(Conversions.ToString(cChequeIn2.Amount), 2);
					lblAccountName.Text = cChequeIn2.AccountName;
					if (DateTime.Compare(cChequeIn2.DepositDate, DateTime.MinValue) == 0)
					{
						chkNoDeposit.Checked = true;
						chkDeposit.Checked = false;
						dtpDeposit.Enabled = false;
					}
					else
					{
						chkDeposit.Checked = true;
						dtpDeposit.Enabled = true;
						dtpDeposit.Value = cChequeIn2.DepositDate;
						chkNoDeposit.Checked = false;
					}
					if (DateTime.Compare(cChequeIn2.ClearingDate, DateTime.MinValue) == 0)
					{
						chkNoClearing.Checked = true;
						chkClearing.Checked = false;
						dtpClearing.Enabled = false;
					}
					else
					{
						chkClearing.Checked = true;
						dtpClearing.Enabled = true;
						dtpClearing.Value = cChequeIn2.ClearingDate;
						chkNoClearing.Checked = false;
					}
					btnHistory.Enabled = true;
					goto end_IL_0001;
				}
				case 454:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmChequeIn", "loadData", "");
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
				try0001_dispatch = 454;
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

	private void chkNoDeposit_CheckedChanged(object sender, EventArgs e)
	{
		if (chkNoDeposit.Checked)
		{
			chkDeposit.Checked = false;
			dtpDeposit.Enabled = false;
			chkNoClearing.Enabled = false;
			chkNoClearing.Checked = true;
			chkClearing.Enabled = false;
			dtpClearing.Enabled = false;
		}
		else
		{
			chkDeposit.Checked = true;
			dtpDeposit.Enabled = true;
			chkNoClearing.Enabled = true;
			chkClearing.Enabled = true;
		}
	}

	private void chkDeposit_CheckedChanged(object sender, EventArgs e)
	{
		if (chkDeposit.Checked)
		{
			chkNoDeposit.Checked = false;
			dtpDeposit.Enabled = true;
		}
		else
		{
			chkNoDeposit.Checked = true;
			dtpDeposit.Enabled = false;
		}
	}

	private void chkNoClearing_CheckedChanged(object sender, EventArgs e)
	{
		if (chkNoClearing.Checked)
		{
			chkClearing.Checked = false;
			dtpClearing.Enabled = false;
		}
		else
		{
			chkClearing.Checked = true;
			dtpClearing.Enabled = true;
		}
	}

	private void chkClearing_CheckedChanged(object sender, EventArgs e)
	{
		if (chkClearing.Checked)
		{
			chkNoClearing.Checked = false;
			dtpClearing.Enabled = true;
		}
		else
		{
			chkNoClearing.Checked = true;
			dtpClearing.Enabled = false;
		}
	}

	private void btnSaveClose_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool clearing = default(bool);
		bool deposit = default(bool);
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
					if (chkClearing.Checked)
					{
						clearing = true;
					}
					if (chkDeposit.Checked)
					{
						deposit = true;
					}
					cChequeIn.SaveDepositClearingDate(_currentId, deposit, dtpDeposit.Value, clearing, dtpClearing.Value);
					string content = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Tanggal setor: ", Interaction.IIf(chkDeposit.Checked, Strings.Format(dtpDeposit.Value, "dd/MM/yyyy"), "-")), "<br />"), "Tanggal masuk: "), Interaction.IIf(chkClearing.Checked, Strings.Format(dtpClearing.Value, "dd/MM/yyyy"), "-")), "<br /><br />"));
					string text = "mengupdate ";
					text = text + "tanggal setor/masuk untuk cek/giro: " + lblChequeNo.Text + ". ID= " + Conversions.ToString(_currentId) + ", v2";
					cHistory cHistory2 = new cHistory();
					cHistory2.Content = content;
					cHistory2.Description = text;
					cHistory2.UserId = Module1.pubUserId;
					cHistory2.UserLogin = Module1.pubLogin;
					cHistory2.fKeyId = _currentId;
					cHistory2.HistoryType = 16;
					cHistory2.Save();
					Interaction.MsgBox("Tanggal setor/masuk berhasil disimpan.", MsgBoxStyle.Information);
					if (Module1.FormIsOpen("frmChequeInList"))
					{
						MyProject.Forms.frmChequeInList.GetRecent();
					}
					MyProject.Forms.frmInformation.GetActivity();
					Close();
					goto end_IL_0001;
				}
				case 498:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmChequeIn", "btnSaveClose_click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 498;
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
		MyProject.Forms.frmHistory.GetHistory(checked((int)Math.Round(_currentId)), 16);
		MyProject.Forms.frmHistory.Show();
		MyProject.Forms.frmHistory.Activate();
		MyProject.Forms.frmHistory.WindowState = FormWindowState.Normal;
	}
}
