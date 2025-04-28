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
public class frmInformation : Form
{
	private struct StockBelowMinimum
	{
		public string ItemName;

		public string BranchName;

		public double MinimumStock;

		public double CurrentStock;
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnUserManual")]
	private Button _btnUserManual;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvActivity")]
	private DataGridView _dgvActivity;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvMinimumStock")]
	private DataGridView _dgvMinimumStock;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BackgroundWorker1")]
	private BackgroundWorker _BackgroundWorker1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("tmrInformation")]
	private Timer _tmrInformation;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BackgroundWorkerActivity")]
	private BackgroundWorker _BackgroundWorkerActivity;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnConnect")]
	private Button _btnConnect;

	private int intTimer;

	internal virtual TabControl TabControl1
	{
		[CompilerGenerated]
		get
		{
			return _TabControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = TabControl1_SelectedIndexChanged;
			TabControl tabControl = _TabControl1;
			if (tabControl != null)
			{
				tabControl.SelectedIndexChanged -= value2;
			}
			_TabControl1 = value;
			tabControl = _TabControl1;
			if (tabControl != null)
			{
				tabControl.SelectedIndexChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TabPage1")]
	internal virtual TabPage TabPage1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnUserManual
	{
		[CompilerGenerated]
		get
		{
			return _btnUserManual;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnUserManual_Click;
			Button button = _btnUserManual;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnUserManual = value;
			button = _btnUserManual;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("lblCompany")]
	internal virtual Label lblCompany
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblLogin")]
	internal virtual Label lblLogin
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblActivity")]
	internal virtual Label lblActivity
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("WebBrowser1")]
	internal virtual WebBrowser WebBrowser1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblVersion")]
	internal virtual Label lblVersion
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView dgvActivity
	{
		[CompilerGenerated]
		get
		{
			return _dgvActivity;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = dgvActivity_KeyDown;
			EventHandler value3 = dgvActivity_GotFocus;
			EventHandler value4 = dgvActivity_LostFocus;
			DataGridView dataGridView = _dgvActivity;
			if (dataGridView != null)
			{
				dataGridView.KeyDown -= value2;
				dataGridView.GotFocus -= value3;
				dataGridView.LostFocus -= value4;
			}
			_dgvActivity = value;
			dataGridView = _dgvActivity;
			if (dataGridView != null)
			{
				dataGridView.KeyDown += value2;
				dataGridView.GotFocus += value3;
				dataGridView.LostFocus += value4;
			}
		}
	}

	[field: AccessedThroughProperty("TabPage2")]
	internal virtual TabPage TabPage2
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

	internal virtual DataGridView dgvMinimumStock
	{
		[CompilerGenerated]
		get
		{
			return _dgvMinimumStock;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			KeyEventHandler value2 = dgvMinimumStock_KeyDown;
			EventHandler value3 = dgvMinimumStock_GotFocus;
			EventHandler value4 = dgvMinimumStock_LostFocus;
			DataGridView dataGridView = _dgvMinimumStock;
			if (dataGridView != null)
			{
				dataGridView.KeyDown -= value2;
				dataGridView.GotFocus -= value3;
				dataGridView.LostFocus -= value4;
			}
			_dgvMinimumStock = value;
			dataGridView = _dgvMinimumStock;
			if (dataGridView != null)
			{
				dataGridView.KeyDown += value2;
				dataGridView.GotFocus += value3;
				dataGridView.LostFocus += value4;
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

	internal virtual Timer tmrInformation
	{
		[CompilerGenerated]
		get
		{
			return _tmrInformation;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = tmrInformation_Tick;
			Timer timer = _tmrInformation;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_tmrInformation = value;
			timer = _tmrInformation;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("lblLatestStockUpdate")]
	internal virtual Label lblLatestStockUpdate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual BackgroundWorker BackgroundWorkerActivity
	{
		[CompilerGenerated]
		get
		{
			return _BackgroundWorkerActivity;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			DoWorkEventHandler value2 = BackgroundWorkerActivity_DoWork;
			ProgressChangedEventHandler value3 = BackgroundWorkerActivity_ProgressChanged;
			RunWorkerCompletedEventHandler value4 = BackgroundWorkerActivity_RunWorkerCompleted;
			BackgroundWorker backgroundWorker = _BackgroundWorkerActivity;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
				backgroundWorker.ProgressChanged -= value3;
				backgroundWorker.RunWorkerCompleted -= value4;
			}
			_BackgroundWorkerActivity = value;
			backgroundWorker = _BackgroundWorkerActivity;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
				backgroundWorker.ProgressChanged += value3;
				backgroundWorker.RunWorkerCompleted += value4;
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnConnect
	{
		[CompilerGenerated]
		get
		{
			return _btnConnect;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnConnect_Click;
			Button button = _btnConnect;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnConnect = value;
			button = _btnConnect;
			if (button != null)
			{
				button.Click += value2;
			}
		}
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
		this.components = new System.ComponentModel.Container();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		this.TabControl1 = new System.Windows.Forms.TabControl();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.btnConnect = new System.Windows.Forms.Button();
		this.btnUserManual = new System.Windows.Forms.Button();
		this.lblCompany = new System.Windows.Forms.Label();
		this.lblLogin = new System.Windows.Forms.Label();
		this.lblActivity = new System.Windows.Forms.Label();
		this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
		this.lblVersion = new System.Windows.Forms.Label();
		this.dgvActivity = new System.Windows.Forms.DataGridView();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.lblLatestStockUpdate = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.dgvMinimumStock = new System.Windows.Forms.DataGridView();
		this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
		this.tmrInformation = new System.Windows.Forms.Timer(this.components);
		this.BackgroundWorkerActivity = new System.ComponentModel.BackgroundWorker();
		this.TabControl1.SuspendLayout();
		this.TabPage1.SuspendLayout();
		this.GroupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvActivity).BeginInit();
		this.TabPage2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvMinimumStock).BeginInit();
		base.SuspendLayout();
		this.TabControl1.Controls.Add(this.TabPage1);
		this.TabControl1.Controls.Add(this.TabPage2);
		this.TabControl1.Location = new System.Drawing.Point(12, 12);
		this.TabControl1.Name = "TabControl1";
		this.TabControl1.SelectedIndex = 0;
		this.TabControl1.Size = new System.Drawing.Size(856, 590);
		this.TabControl1.TabIndex = 100;
		this.TabPage1.BackColor = System.Drawing.SystemColors.Control;
		this.TabPage1.Controls.Add(this.GroupBox1);
		this.TabPage1.Controls.Add(this.btnUserManual);
		this.TabPage1.Controls.Add(this.lblCompany);
		this.TabPage1.Controls.Add(this.lblLogin);
		this.TabPage1.Controls.Add(this.lblActivity);
		this.TabPage1.Controls.Add(this.WebBrowser1);
		this.TabPage1.Controls.Add(this.lblVersion);
		this.TabPage1.Controls.Add(this.dgvActivity);
		this.TabPage1.Location = new System.Drawing.Point(4, 22);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage1.Size = new System.Drawing.Size(848, 564);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "Umum";
		this.GroupBox1.Controls.Add(this.Label2);
		this.GroupBox1.Controls.Add(this.btnConnect);
		this.GroupBox1.Location = new System.Drawing.Point(520, 451);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(312, 66);
		this.GroupBox1.TabIndex = 30;
		this.GroupBox1.TabStop = false;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(6, 46);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(291, 13);
		this.Label2.TabIndex = 31;
		this.Label2.Text = "Gunakan tombol Reset untuk koneksi ulang dengan Server.";
		this.btnConnect.BackColor = System.Drawing.Color.LimeGreen;
		this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnConnect.ForeColor = System.Drawing.Color.Black;
		this.btnConnect.Location = new System.Drawing.Point(6, 13);
		this.btnConnect.Name = "btnConnect";
		this.btnConnect.Size = new System.Drawing.Size(135, 30);
		this.btnConnect.TabIndex = 30;
		this.btnConnect.Text = "Reset koneksi";
		this.btnConnect.UseVisualStyleBackColor = false;
		this.btnUserManual.BackColor = System.Drawing.Color.Yellow;
		this.btnUserManual.ForeColor = System.Drawing.Color.Black;
		this.btnUserManual.Location = new System.Drawing.Point(697, 381);
		this.btnUserManual.Name = "btnUserManual";
		this.btnUserManual.Size = new System.Drawing.Size(135, 30);
		this.btnUserManual.TabIndex = 2;
		this.btnUserManual.Text = "Manual Program GCUv2";
		this.btnUserManual.UseVisualStyleBackColor = false;
		this.btnUserManual.Visible = false;
		this.lblCompany.AutoSize = true;
		this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblCompany.Location = new System.Drawing.Point(517, 428);
		this.lblCompany.Name = "lblCompany";
		this.lblCompany.Size = new System.Drawing.Size(110, 24);
		this.lblCompany.TabIndex = 26;
		this.lblCompany.Text = "lblCompany";
		this.lblLogin.AutoSize = true;
		this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblLogin.Location = new System.Drawing.Point(517, 405);
		this.lblLogin.Name = "lblLogin";
		this.lblLogin.Size = new System.Drawing.Size(55, 16);
		this.lblLogin.TabIndex = 25;
		this.lblLogin.Text = "lblLogin";
		this.lblActivity.AutoSize = true;
		this.lblActivity.Location = new System.Drawing.Point(6, 9);
		this.lblActivity.Name = "lblActivity";
		this.lblActivity.Size = new System.Drawing.Size(51, 13);
		this.lblActivity.TabIndex = 24;
		this.lblActivity.Text = "lblActivity";
		this.WebBrowser1.Location = new System.Drawing.Point(6, 381);
		this.WebBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
		this.WebBrowser1.Name = "WebBrowser1";
		this.WebBrowser1.Size = new System.Drawing.Size(505, 175);
		this.WebBrowser1.TabIndex = 1;
		this.lblVersion.AutoSize = true;
		this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblVersion.Location = new System.Drawing.Point(517, 381);
		this.lblVersion.Name = "lblVersion";
		this.lblVersion.Size = new System.Drawing.Size(54, 16);
		this.lblVersion.TabIndex = 22;
		this.lblVersion.Text = "GCUv2 ";
		this.dgvActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.dgvActivity.DefaultCellStyle = dataGridViewCellStyle;
		this.dgvActivity.Location = new System.Drawing.Point(6, 25);
		this.dgvActivity.Name = "dgvActivity";
		this.dgvActivity.Size = new System.Drawing.Size(826, 350);
		this.dgvActivity.TabIndex = 0;
		this.TabPage2.BackColor = System.Drawing.SystemColors.Control;
		this.TabPage2.Controls.Add(this.lblLatestStockUpdate);
		this.TabPage2.Controls.Add(this.Label1);
		this.TabPage2.Controls.Add(this.dgvMinimumStock);
		this.TabPage2.Location = new System.Drawing.Point(4, 22);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage2.Size = new System.Drawing.Size(848, 564);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = "Stok";
		this.lblLatestStockUpdate.AutoSize = true;
		this.lblLatestStockUpdate.Location = new System.Drawing.Point(14, 34);
		this.lblLatestStockUpdate.Name = "lblLatestStockUpdate";
		this.lblLatestStockUpdate.Size = new System.Drawing.Size(272, 13);
		this.lblLatestStockUpdate.TabIndex = 32;
		this.lblLatestStockUpdate.Text = "Update terakhir: Harap tunggu, daftar sedang di-update.";
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(14, 16);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(239, 13);
		this.Label1.TabIndex = 31;
		this.Label1.Text = "Daftar Stok Barang yang dibawah Minimum Stok.";
		this.dgvMinimumStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvMinimumStock.Location = new System.Drawing.Point(17, 56);
		this.dgvMinimumStock.Name = "dgvMinimumStock";
		this.dgvMinimumStock.Size = new System.Drawing.Size(531, 490);
		this.dgvMinimumStock.TabIndex = 30;
		this.BackgroundWorker1.WorkerReportsProgress = true;
		this.BackgroundWorker1.WorkerSupportsCancellation = true;
		this.tmrInformation.Interval = 1000;
		this.BackgroundWorkerActivity.WorkerReportsProgress = true;
		this.BackgroundWorkerActivity.WorkerSupportsCancellation = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.LightGray;
		base.ClientSize = new System.Drawing.Size(880, 612);
		base.ControlBox = false;
		base.Controls.Add(this.TabControl1);
		base.Name = "frmInformation";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		this.Text = "Informasi";
		this.TabControl1.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		this.TabPage1.PerformLayout();
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvActivity).EndInit();
		this.TabPage2.ResumeLayout(false);
		this.TabPage2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvMinimumStock).EndInit();
		base.ResumeLayout(false);
	}

	public frmInformation()
	{
		base.Load += frmInformation_Load;
		InitializeComponent();
		base.MdiParent = MyProject.Forms.frmMenu;
		dgvActivity.Columns.Add("", "Tanggal");
		dgvActivity.Columns.Add("", "Aktivitas");
		dgvActivity.Columns[0].Width = 100;
		dgvActivity.Columns[1].Width = 1000;
		dgvActivity.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
		dgvActivity.RowHeadersVisible = false;
		dgvActivity.AllowUserToAddRows = false;
		dgvActivity.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvActivity.ReadOnly = true;
		dgvActivity.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvActivity.AllowUserToResizeRows = false;
		dgvMinimumStock.Columns.Add("", "Cabang");
		dgvMinimumStock.Columns.Add("", "Barang");
		dgvMinimumStock.Columns.Add("", "Minimum Stok");
		dgvMinimumStock.Columns.Add("", "Stok saat ini");
		dgvMinimumStock.Columns[1].Width = 200;
		dgvMinimumStock.RowHeadersVisible = false;
		dgvMinimumStock.AllowUserToAddRows = false;
		dgvMinimumStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgvMinimumStock.ReadOnly = true;
		dgvMinimumStock.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
		dgvMinimumStock.AllowUserToResizeRows = false;
		dgvMinimumStock.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		dgvMinimumStock.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
	}

	private void frmInformation_Load(object sender, EventArgs e)
	{
		DoubleBuffered = true;
		tmrInformation.Enabled = true;
		Module1.pubVersion = "2022.2";
		string text = "13 May 2022";
		lblVersion.Text = "GCUv2 - " + Module1.pubVersion + ", " + text;
		lblLogin.Text = "User Name: " + Module1.pubLogin;
		MyProject.Forms.frmMenu.Text = "Menu Utama - " + Module1.pubCompany;
		lblCompany.Text = Module1.pubCompany;
		GetAnnouncement();
		BackgroundWorkerActivity.RunWorkerAsync();
		BackgroundWorker1.RunWorkerAsync();
	}

	public void GetActivity()
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
					lblActivity.Text = "Daftar aktivitas terbaru sedang dicari. Harap tunggu sebentar.";
					dgvActivity.Rows.Clear();
					if (!BackgroundWorkerActivity.IsBusy)
					{
						BackgroundWorkerActivity.RunWorkerAsync();
					}
					goto end_IL_0001;
				case 107:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmInformation", "GetActivity", "");
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

	private void BackgroundWorkerActivity_DoWork(object sender, DoWorkEventArgs e)
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
					string text = " SELECT histDate, CONCAT(b.userLogin, ' ', histDescription) as activity  FROM " + Module1.pubDbHistory + ".historyV2 a, userList b, groups c  WHERE a.userId = b.userId  AND b.groupId = c.groupId  AND histType <> 5  AND histDescription <> ''  AND histDate >= '" + Strings.Format(DateAndTime.Now.AddDays(-90.0), "yyyy-MM-dd") + "'";
					if (!Module1.pubInternal)
					{
						text += " AND c.groupName NOT LIKE '%internal%' ";
					}
					text += " ORDER BY histId DESC LIMIT 100 ";
					DataTable dataTable = Module1.sqlTable(text, "data", Clone: true);
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow userState = (DataRow)enumerator.Current;
						BackgroundWorkerActivity.ReportProgress(1, userState);
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					goto end_IL_0001;
				}
				case 259:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmInformation", "BackgroundWorkerActivity_DoWork", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 259;
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

	private void BackgroundWorkerActivity_ProgressChanged(object sender, ProgressChangedEventArgs e)
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
				case 212:
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
							goto IL_0019;
						case 4:
							goto IL_004e;
						case 5:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 6:
						case 7:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_000b:
					num = 2;
					dataRow = (DataRow)e.UserState;
					goto IL_0019;
					IL_0019:
					num = 3;
					dgvActivity.Rows.Add(dataRow["histDate"], dataRow["activity"]);
					goto IL_004e;
					IL_004e:
					num = 4;
					if (Strings.InStr(1, Conversions.ToString(dataRow["activity"]), "menghapus") <= 0)
					{
						goto end_IL_0001_3;
					}
					break;
					end_IL_0001_2:
					break;
				}
				num = 5;
				dgvActivity.Rows[checked(dgvActivity.RowCount - 1)].DefaultCellStyle.BackColor = Color.Red;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 212;
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

	private void BackgroundWorkerActivity_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		lblActivity.Text = "Daftar aktivitas terbaru (" + Conversions.ToString(DateAndTime.Now) + ")";
		if (dgvActivity.RowCount > 0)
		{
			dgvActivity.CurrentRow.Selected = false;
		}
	}

	private void GetAnnouncement()
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
					string strSql = " SELECT * FROM announcement ORDER BY announcementId DESC LIMIT 10 ";
					DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
					string text = "<style type='text/css'>html{font-size:12px;}</style>";
					text += "PENGUMUMAN:<br />";
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						text = text + Strings.Format(RuntimeHelpers.GetObjectValue(dataRow["announcementDate"]), "dd/MM/yyyy hh:mm") + "<br />";
						text = ((!Operators.ConditionalCompareObjectEqual(dataRow["announcementPriority"], 1, TextCompare: false)) ? (text + "<font color='black'>") : (text + "<font color='red'>"));
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(dataRow["announcementContent"], "<br /></font>")));
						text += "-----------------------------------------------------------------------<br />";
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					text = text + "<br />Host (Read): " + Module1.pubHostRead;
					WebBrowser1.DocumentText = text;
					goto end_IL_0001;
				}
				case 339:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmInformation", "getAnnouncement", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 339;
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

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void TestError()
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
					Information.Err().Raise(513, null, "Testing");
					goto end_IL_0001;
				case 65:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmInformation", "TestError", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 65;
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

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void tmrInformation_Tick(object sender, EventArgs e)
	{
		checked
		{
			intTimer++;
		}
		if (intTimer % 60 == 0 && !cDatabase.CheckSlaveStatus())
		{
			Module1.SaveDebug("Database out of sync");
			Interaction.MsgBox("Database tidak sinkron. Harap login ulang.", MsgBoxStyle.Information);
			ProjectData.EndApp();
		}
		if (intTimer % 10 == 0)
		{
			if (!Module1.canPingIP(Module1.pubHostUpdate))
			{
				btnConnect.BackColor = Color.Red;
				btnConnect.Enabled = false;
			}
			else
			{
				btnConnect.BackColor = Color.LimeGreen;
				btnConnect.Enabled = true;
			}
		}
		if ((intTimer % 600 == 0) & Module1.pubDatabaseIsConnected)
		{
			GetActivity();
			dgvMinimumStock.Rows.Clear();
			lblLatestStockUpdate.Text = "Update terakhir: Harap tunggu, daftar sedang di-update.";
			if (!BackgroundWorker1.IsBusy)
			{
				BackgroundWorker1.RunWorkerAsync();
			}
		}
		if ((intTimer % 1200 == 0) & Module1.pubDatabaseIsConnected)
		{
			GetAnnouncement();
		}
		if (intTimer % 3600 == 0)
		{
			intTimer = 0;
		}
	}

	private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (TabControl1.SelectedIndex == 0)
		{
			if (dgvActivity.Rows.Count > 0)
			{
				dgvActivity.CurrentRow.Selected = false;
			}
		}
		else if (TabControl1.SelectedIndex == 1 && dgvMinimumStock.Rows.Count > 0)
		{
			dgvMinimumStock.CurrentRow.Selected = false;
		}
	}

	private void dgvActivity_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			e.SuppressKeyPress = true;
		}
		else if (e.KeyCode == Keys.Tab)
		{
			btnUserManual.Focus();
			e.SuppressKeyPress = true;
		}
		else if (e.Shift & (e.KeyCode == Keys.Tab))
		{
			TabControl1.Focus();
			e.SuppressKeyPress = true;
		}
	}

	private void dgvMinimumStock_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
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

	private void dgvActivity_GotFocus(object sender, EventArgs e)
	{
		if (dgvActivity.RowCount > 0)
		{
			dgvActivity.CurrentRow.Selected = true;
		}
	}

	private void dgvActivity_LostFocus(object sender, EventArgs e)
	{
		if (dgvActivity.RowCount > 0)
		{
			dgvActivity.CurrentRow.Selected = false;
		}
	}

	private void dgvMinimumStock_GotFocus(object sender, EventArgs e)
	{
		if (dgvMinimumStock.RowCount > 0)
		{
			dgvMinimumStock.CurrentRow.Selected = true;
		}
	}

	private void dgvMinimumStock_LostFocus(object sender, EventArgs e)
	{
		if (dgvMinimumStock.RowCount > 0)
		{
			dgvMinimumStock.CurrentRow.Selected = false;
		}
	}

	private void btnUserManual_Click(object sender, EventArgs e)
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
					Process.Start("GCUv2 User Manual.pdf");
					goto end_IL_0001;
				case 52:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmInformation", "btnUserManual_click", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 52;
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
		int try0001_dispatch = -1;
		int num2 = default(int);
		StockBelowMinimum stockBelowMinimum = default(StockBelowMinimum);
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
					string strSql = " SELECT a.*, prodName, c.branchName  FROM prodBranches a, produk b, branches c  WHERE a.prodId = b.prodId  AND a.branchId = c.branchId  AND a.prodMin > 0  ORDER BY branchName, prodName ";
					DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: true);
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (true)
					{
						if (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							double stock = cStock.getStock(Conversions.ToInteger(dataRow["prodId"]), Module1.pubBalanceDate, DateAndTime.Now.AddDays(1.0), "Good", 0, Module1.pubGroupId, Conversions.ToInteger(dataRow["branchId"]), Module1.pubUseNewGetStockCode);
							if (Operators.ConditionalCompareObjectGreater(dataRow["prodMin"], stock, TextCompare: false))
							{
								stockBelowMinimum.ItemName = Conversions.ToString(dataRow["prodName"]);
								stockBelowMinimum.BranchName = Conversions.ToString(dataRow["branchName"]);
								stockBelowMinimum.MinimumStock = Conversions.ToDouble(dataRow["prodMin"]);
								stockBelowMinimum.CurrentStock = stock;
								if (BackgroundWorker1.CancellationPending)
								{
									break;
								}
								BackgroundWorker1.ReportProgress(1, stockBelowMinimum);
							}
							continue;
						}
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
						break;
					}
					goto end_IL_0001;
				}
				case 369:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmInformation", "BackgroundWorker1_DoWork", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 369;
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

	private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
	{
		object userState = e.UserState;
		StockBelowMinimum stockBelowMinimum = ((userState != null) ? ((StockBelowMinimum)userState) : default(StockBelowMinimum));
		dgvMinimumStock.Rows.Add(stockBelowMinimum.BranchName, stockBelowMinimum.ItemName, Module1.formatCustomDecimal(Conversions.ToString(stockBelowMinimum.MinimumStock), 3), Module1.formatCustomDecimal(Conversions.ToString(stockBelowMinimum.CurrentStock), 3));
		if (TabControl1.SelectedIndex == 1)
		{
			dgvMinimumStock.CurrentRow.Selected = false;
		}
	}

	private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		lblLatestStockUpdate.Text = "Update terakhir: " + Conversions.ToString(DateAndTime.Now);
		if (dgvMinimumStock.Rows.Count > 0)
		{
			TabControl1.TabPages[1].Text = "Stok (" + Conversions.ToString(dgvMinimumStock.Rows.Count) + ")";
		}
		else
		{
			TabControl1.TabPages[1].Text = "Stok";
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void btnConnect_Click(object sender, EventArgs e)
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
					Cursor = Cursors.WaitCursor;
					if (!Module1.canPingIP(Module1.pubHostUpdate))
					{
						Information.Err().Raise(513, null, "Database tidak bisa terkoneksi.");
					}
					else if (!Module1.canPingIP(Module1.pubHostRead))
					{
						Information.Err().Raise(513, null, "Database lokal tidak bisa terkoneksi.");
					}
					Module1.connectDatabaseData();
					Module1.connectDatabaseRead();
					if (!cDatabase.CheckSlaveStatus())
					{
						Module1.pubHostRead = Module1.pubHostUpdate;
						Module1.connectDatabaseRead();
					}
					Interaction.MsgBox("Koneksi berhasil dilakukan", MsgBoxStyle.Information);
					Cursor = Cursors.Default;
					goto end_IL_0001;
				case 221:
					num = -1;
					switch (num2)
					{
					case 2:
						Cursor = Cursors.Default;
						Module1.SaveError(Information.Err(), "frmInformation", "btnConnect", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 221;
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
}
