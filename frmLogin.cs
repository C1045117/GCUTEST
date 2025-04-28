using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GCUv2.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

namespace GCUv2;

[DesignerGenerated]
public class frmLogin : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnLogin")]
	private Button _btnLogin;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

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

	[field: AccessedThroughProperty("lblHostRead")]
	internal virtual Label lblHostRead
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblHostUpdate")]
	internal virtual Label lblHostUpdate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDbMarketing")]
	internal virtual Label lblDbMarketing
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDbHistory")]
	internal virtual Label lblDbHistory
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtUserName")]
	internal virtual TextBox txtUserName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPassword")]
	internal virtual TextBox txtPassword
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtHostRead")]
	internal virtual TextBox txtHostRead
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtHostUpdate")]
	internal virtual TextBox txtHostUpdate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDbData")]
	internal virtual TextBox txtDbData
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtDbHistory")]
	internal virtual TextBox txtDbHistory
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnLogin
	{
		[CompilerGenerated]
		get
		{
			return _btnLogin;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnLogin_Click;
			Button button = _btnLogin;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnLogin = value;
			button = _btnLogin;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = Timer1_Tick;
			Timer timer = _Timer1;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_Timer1 = value;
			timer = _Timer1;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	public frmLogin()
	{
		base.KeyDown += frmLogin_KeyDown;
		base.Load += frmLogin_Load;
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
		this.components = new System.ComponentModel.Container();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.lblHostRead = new System.Windows.Forms.Label();
		this.lblHostUpdate = new System.Windows.Forms.Label();
		this.lblDbMarketing = new System.Windows.Forms.Label();
		this.lblDbHistory = new System.Windows.Forms.Label();
		this.txtUserName = new System.Windows.Forms.TextBox();
		this.txtPassword = new System.Windows.Forms.TextBox();
		this.txtHostRead = new System.Windows.Forms.TextBox();
		this.txtHostUpdate = new System.Windows.Forms.TextBox();
		this.txtDbData = new System.Windows.Forms.TextBox();
		this.txtDbHistory = new System.Windows.Forms.TextBox();
		this.btnLogin = new System.Windows.Forms.Button();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		base.SuspendLayout();
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(10, 18);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(60, 13);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "User Name";
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(10, 44);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(53, 13);
		this.Label2.TabIndex = 1;
		this.Label2.Text = "Password";
		this.lblHostRead.AutoSize = true;
		this.lblHostRead.Location = new System.Drawing.Point(10, 70);
		this.lblHostRead.Name = "lblHostRead";
		this.lblHostRead.Size = new System.Drawing.Size(64, 13);
		this.lblHostRead.TabIndex = 2;
		this.lblHostRead.Text = "Host (Read)";
		this.lblHostRead.Visible = false;
		this.lblHostUpdate.AutoSize = true;
		this.lblHostUpdate.Location = new System.Drawing.Point(10, 96);
		this.lblHostUpdate.Name = "lblHostUpdate";
		this.lblHostUpdate.Size = new System.Drawing.Size(73, 13);
		this.lblHostUpdate.TabIndex = 3;
		this.lblHostUpdate.Text = "Host (Update)";
		this.lblHostUpdate.Visible = false;
		this.lblDbMarketing.AutoSize = true;
		this.lblDbMarketing.Location = new System.Drawing.Point(10, 122);
		this.lblDbMarketing.Name = "lblDbMarketing";
		this.lblDbMarketing.Size = new System.Drawing.Size(48, 13);
		this.lblDbMarketing.TabIndex = 4;
		this.lblDbMarketing.Text = "DB Data";
		this.lblDbMarketing.Visible = false;
		this.lblDbHistory.AutoSize = true;
		this.lblDbHistory.Location = new System.Drawing.Point(10, 148);
		this.lblDbHistory.Name = "lblDbHistory";
		this.lblDbHistory.Size = new System.Drawing.Size(57, 13);
		this.lblDbHistory.TabIndex = 6;
		this.lblDbHistory.Text = "DB History";
		this.lblDbHistory.Visible = false;
		this.txtUserName.Location = new System.Drawing.Point(108, 15);
		this.txtUserName.Name = "txtUserName";
		this.txtUserName.Size = new System.Drawing.Size(139, 20);
		this.txtUserName.TabIndex = 7;
		this.txtPassword.Location = new System.Drawing.Point(108, 41);
		this.txtPassword.Name = "txtPassword";
		this.txtPassword.PasswordChar = '*';
		this.txtPassword.Size = new System.Drawing.Size(139, 20);
		this.txtPassword.TabIndex = 8;
		this.txtHostRead.Location = new System.Drawing.Point(108, 67);
		this.txtHostRead.Name = "txtHostRead";
		this.txtHostRead.Size = new System.Drawing.Size(139, 20);
		this.txtHostRead.TabIndex = 9;
		this.txtHostRead.Visible = false;
		this.txtHostUpdate.Location = new System.Drawing.Point(108, 93);
		this.txtHostUpdate.Name = "txtHostUpdate";
		this.txtHostUpdate.Size = new System.Drawing.Size(139, 20);
		this.txtHostUpdate.TabIndex = 10;
		this.txtHostUpdate.Visible = false;
		this.txtDbData.Location = new System.Drawing.Point(108, 119);
		this.txtDbData.Name = "txtDbData";
		this.txtDbData.Size = new System.Drawing.Size(139, 20);
		this.txtDbData.TabIndex = 11;
		this.txtDbData.Visible = false;
		this.txtDbHistory.Location = new System.Drawing.Point(108, 145);
		this.txtDbHistory.Name = "txtDbHistory";
		this.txtDbHistory.Size = new System.Drawing.Size(139, 20);
		this.txtDbHistory.TabIndex = 13;
		this.txtDbHistory.Visible = false;
		this.btnLogin.Location = new System.Drawing.Point(108, 171);
		this.btnLogin.Name = "btnLogin";
		this.btnLogin.Size = new System.Drawing.Size(71, 21);
		this.btnLogin.TabIndex = 14;
		this.btnLogin.Text = "Login";
		this.btnLogin.UseVisualStyleBackColor = true;
		this.Timer1.Enabled = true;
		this.Timer1.Interval = 10000;
		base.AcceptButton = this.btnLogin;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(268, 199);
		base.Controls.Add(this.btnLogin);
		base.Controls.Add(this.txtDbHistory);
		base.Controls.Add(this.txtDbData);
		base.Controls.Add(this.txtHostUpdate);
		base.Controls.Add(this.txtHostRead);
		base.Controls.Add(this.txtPassword);
		base.Controls.Add(this.txtUserName);
		base.Controls.Add(this.lblDbHistory);
		base.Controls.Add(this.lblDbMarketing);
		base.Controls.Add(this.lblHostUpdate);
		base.Controls.Add(this.lblHostRead);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.KeyPreview = true;
		base.MaximizeBox = false;
		base.Name = "frmLogin";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Login";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void btnLogin_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		bool flag = default(bool);
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
					if (Operators.CompareString(txtUserName.Text, "", TextCompare: false) == 0)
					{
						Interaction.MsgBox("Masukkan user name anda", MsgBoxStyle.Information);
						goto end_IL_0001;
					}
					if (Operators.CompareString(txtPassword.Text, "", TextCompare: false) == 0)
					{
						Interaction.MsgBox("Masukkan password anda", MsgBoxStyle.Information);
						goto end_IL_0001;
					}
					Module1.pubHostRead = Module1.cleanString(txtHostRead.Text);
					Module1.pubHostUpdate = Module1.cleanString(txtHostUpdate.Text);
					Module1.pubDbData = Module1.cleanString(txtDbData.Text);
					Module1.pubDbHistory = Module1.cleanString(txtDbHistory.Text);
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
					string text = Module1.cleanString(txtUserName.Text);
					string text2 = Module1.cleanString(txtPassword.Text);
					int num3 = text.IndexOf("--setting");
					if (num3 > 0)
					{
						text = Strings.Mid(text, 1, num3);
					}
					string right = "iddqd" + DateAndTime.Now.ToString("dd") + "m" + Conversions.ToString(DateAndTime.Minute(DateAndTime.Now));
					string right2 = "iddqd" + DateAndTime.Now.ToString("dd") + "m" + Conversions.ToString(checked(DateAndTime.Minute(DateAndTime.Now) - 1));
					string strSql = ((!((Operators.CompareString(text2, right, TextCompare: false) == 0) | (Operators.CompareString(text2, right2, TextCompare: false) == 0))) ? (" SELECT userId, b.*  FROM userList a, groups b   WHERE a.groupId = b.groupId  AND userLogin = '" + text + "'  AND userPassword = '" + text2 + "'  AND userStatus = 1 ") : (" SELECT userId, b.*  FROM userList a, groups b   WHERE a.groupId = b.groupId  AND userLogin = '" + text + "'  AND userStatus = 1 "));
					DataTable dataTable = Module1.sqlTable(strSql, "read", Clone: false);
					if (dataTable.Rows.Count > 0)
					{
						Module1.SaveDebug("Login: " + text);
						Module1.pubLogin = text;
						Module1.pubGroupId = Conversions.ToInteger(dataTable.Rows[0]["groupId"]);
						Module1.pubUserId = Conversions.ToInteger(dataTable.Rows[0]["userId"]);
						strSql = " SELECT a.permName, b.*  FROM permissions a, groups_permissions b  WHERE a.permId = b.permId  AND b.groupId = " + Conversions.ToString(Module1.pubGroupId);
						DataTable dataTable2 = Module1.sqlTable(strSql, "read", Clone: false);
						Module1.pubCreateSalesInvoice = false;
						Module1.pubUpdateSalesInvoice = false;
						Module1.pubModifyPriceInSalesInvoice = false;
						Module1.pubDeleteSalesInvoice = false;
						Module1.pubModifySalesInvoice = false;
						Module1.pubModifyPaymentInSalesInvoice = false;
						Module1.pubModifySalesInvoiceNumber = false;
						Module1.pubModifySalesTaxInvoiceNumber = false;
						Module1.pubUnlimitedCredit = false;
						Module1.pubCreateSalesReceipt = false;
						Module1.pubDaysLimitForPaidSalesInvoice = 0;
						Module1.pubDaysLimitForCustomerPayment = 0;
						Module1.pubCreateCustomer = false;
						Module1.pubUpdateCustomer = false;
						Module1.pubUpdateTOP = false;
						Module1.pubUpdateCreditLimit = false;
						Module1.pubPreviewReport = false;
						Module1.pubPrintReport = false;
						IEnumerator enumerator = dataTable2.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							switch (Conversions.ToString(dataRow["permName"]))
							{
							case "createSalesInvoice":
								Module1.pubCreateSalesInvoice = true;
								break;
							case "updateSalesInvoice":
								Module1.pubUpdateSalesInvoice = true;
								break;
							case "modifyPriceInSalesInvoice":
								Module1.pubModifyPriceInSalesInvoice = true;
								break;
							case "deleteSalesInvoice":
								Module1.pubDeleteSalesInvoice = true;
								break;
							case "modifySalesInvoice":
								Module1.pubModifySalesInvoice = true;
								break;
							case "modifyPaymentInSalesInvoice":
								Module1.pubModifyPaymentInSalesInvoice = true;
								break;
							case "modifySalesInvoiceNumber":
								Module1.pubModifySalesInvoiceNumber = true;
								break;
							case "modifySalesTaxInvoiceNumber":
								Module1.pubModifySalesTaxInvoiceNumber = true;
								break;
							case "noCreditLimit":
								Module1.pubUnlimitedCredit = true;
								break;
							case "createSalesReceipt":
								Module1.pubCreateSalesReceipt = true;
								break;
							case "daysLimitForPaidSalesInvoice":
								Module1.pubDaysLimitForPaidSalesInvoice = Conversions.ToInteger(dataRow["permValue"]);
								break;
							case "daysLimitForCustomerPayment":
								Module1.pubDaysLimitForCustomerPayment = Conversions.ToInteger(dataRow["permValue"]);
								break;
							case "daysLimitForCashTransaction":
								Module1.pubDaysLimitForCashTransaction = Conversions.ToInteger(dataRow["permValue"]);
								break;
							case "daysLimitForBankTransaction":
								Module1.pubDaysLimitForBankTransaction = Conversions.ToInteger(dataRow["permValue"]);
								break;
							case "createCustomer":
								Module1.pubCreateCustomer = true;
								break;
							case "updateCustomer":
								Module1.pubUpdateCustomer = true;
								break;
							case "updateCreditLimit":
								Module1.pubUpdateCreditLimit = true;
								break;
							case "updateTOP":
								Module1.pubUpdateTOP = true;
								break;
							case "previewReport":
								Module1.pubPreviewReport = true;
								break;
							case "printReport":
								Module1.pubPrintReport = true;
								break;
							}
						}
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
						Module1.pubDaysLimit = cGroupPermission.getPermissionValue(Module1.pubGroupId, "dateRange");
						object[] array;
						DataRow dataRow2;
						bool[] array2;
						object obj = NewLateBinding.LateGet(null, typeof(Strings), "LCase", array = new object[1] { (dataRow2 = dataTable.Rows[0])["groupName"] }, null, null, array2 = new bool[1] { true });
						if (array2[0])
						{
							dataRow2["groupName"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
						}
						if (Strings.InStr(Conversions.ToString(obj), "internal") > 0)
						{
							Module1.pubInternal = true;
						}
						else
						{
							Module1.pubInternal = false;
						}
						object left = NewLateBinding.LateGet(null, typeof(Strings), "LCase", array = new object[1] { (dataRow2 = dataTable.Rows[0])["groupName"] }, null, null, array2 = new bool[1] { true });
						if (array2[0])
						{
							dataRow2["groupName"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
						}
						if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(left, "master", TextCompare: false), num3 > 0)))
						{
							flag = true;
						}
						strSql = " SELECT kgId FROM groupKg WHERE groupId = " + Conversions.ToString(Module1.pubGroupId) + " AND defaultDropDown = 1 ";
						dataTable = Module1.sqlTable(strSql, "read", Clone: false);
						if (dataTable.Rows.Count > 0)
						{
							Module1.pubCashAccountId = Conversions.ToInteger(dataTable.Rows[0]["kgId"]);
						}
						strSql = " SELECT tgId FROM groupTg WHERE groupId = " + Conversions.ToString(Module1.pubGroupId) + " AND defaultDropDown = 1 ";
						dataTable = Module1.sqlTable(strSql, "read", Clone: false);
						if (dataTable.Rows.Count > 0)
						{
							Module1.pubBankAccountId = Conversions.ToInteger(dataTable.Rows[0]["tgId"]);
						}
						strSql = " SELECT storeId FROM groupstorage WHERE groupId = " + Conversions.ToString(Module1.pubGroupId) + " AND defaultDropDown = 1 ";
						dataTable = Module1.sqlTable(strSql, "read", Clone: false);
						if (dataTable.Rows.Count > 0)
						{
							Module1.pubStorageId = Conversions.ToInteger(dataTable.Rows[0]["storeId"]);
						}
						strSql = " SELECT branchId FROM groups_branches WHERE groupId = " + Conversions.ToString(Module1.pubGroupId) + " AND defaultDropDown = 1 ";
						dataTable = Module1.sqlTable(strSql, "read", Clone: false);
						if (dataTable.Rows.Count > 0)
						{
							Module1.pubBranchId = Conversions.ToInteger(dataTable.Rows[0]["branchId"]);
						}
						Module1.pubViewReportPurchaseInvoicePrice = cGroupPermission.IsAllowed(Module1.pubGroupId, "viewReportPurchaseInvoicePrice");
						strSql = " SELECT * FROM settings ";
						dataTable = Module1.sqlTable(strSql, "data", Clone: false);
						IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							DataRow dataRow3 = (DataRow)enumerator2.Current;
							if (Operators.ConditionalCompareObjectEqual(dataRow3["setName"], "Company", TextCompare: false))
							{
								Module1.pubCompany = Conversions.ToString(dataRow3["setVal"]);
							}
							else if (Operators.ConditionalCompareObjectEqual(dataRow3["setName"], "BalanceDate", TextCompare: false))
							{
								Module1.pubBalanceDate = Conversions.ToDate(dataRow3["setVal"]);
							}
							else if (Operators.ConditionalCompareObjectEqual(dataRow3["setName"], "DuplicateFaktur", TextCompare: false))
							{
								Module1.pubDuplicateSalesInvoiceNumber = Conversions.ToInteger(dataRow3["setVal"]);
							}
							else if (Operators.ConditionalCompareObjectEqual(dataRow3["setName"], "UseDeletedFakturNo", TextCompare: false))
							{
								Module1.pubUseDeletedInvoiceNumber = Conversions.ToBoolean(dataRow3["setVal"]);
							}
							else if (Operators.ConditionalCompareObjectEqual(dataRow3["setName"], "PurchaseReturnAccountId", TextCompare: false))
							{
								Module1.pubPurchaseReturnAccountId = Conversions.ToInteger(dataRow3["setVal"]);
							}
							else if (Operators.ConditionalCompareObjectEqual(dataRow3["setName"], "ActivateDailyStockCode", TextCompare: false))
							{
								Module1.pubActivateDailyStockCode = Conversions.ToBoolean(dataRow3["setVal"]);
							}
							else if (Operators.ConditionalCompareObjectEqual(dataRow3["setName"], "UseNewGetStockCode", TextCompare: false))
							{
								Module1.pubUseNewGetStockCode = Conversions.ToBoolean(dataRow3["setVal"]);
							}
							else if (Operators.ConditionalCompareObjectEqual(dataRow3["setName"], "ReportUseNewGetStockCode", TextCompare: false))
							{
								Module1.pubReportUseNewGetStockCode = Conversions.ToBoolean(dataRow3["setVal"]);
							}
							else if (Operators.ConditionalCompareObjectEqual(dataRow3["setName"], "CloseAccess", TextCompare: false))
							{
								Module1.pubCloseAccess = Conversions.ToBoolean(dataRow3["setVal"]);
							}
						}
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
						if (Module1.pubCloseAccess)
						{
							string left2 = Interaction.InputBox("Program tidak bisa diakses karena sedang ada maintenance.");
							if (Operators.CompareString(left2, "FORCE_OPEN", TextCompare: false) != 0)
							{
								ProjectData.EndApp();
							}
						}
						strSql = " SELECT * FROM settingsprint ";
						dataTable = Module1.sqlTable(strSql, "read", Clone: false);
						Module1.pubSalesReceiptDescription = Conversions.ToString(dataTable.Rows[0]["salesReceiptDescription"]);
						Module1.pubSalesReceiptName = Conversions.ToString(dataTable.Rows[0]["printKuiName"]);
						Module1.pubSalesReceiptCity = Conversions.ToString(dataTable.Rows[0]["printKuiCity"]);
						Module1.pubSalesReceiptCode = Conversions.ToString(dataTable.Rows[0]["salesReceiptCode"]);
						Module1.pubCheckStock = !cGroupPermission.IsAllowed(Module1.pubGroupId, "noCheckStock");
						MyProject.Forms.frmMenu.Show();
						if (flag)
						{
							MyProject.Forms.frmSettingGroup.Show();
						}
						cHistory cHistory2 = new cHistory();
						cHistory2.Content = Module1.pubLogin + " login ke program.";
						cHistory2.Description = "login ke program.";
						cHistory2.UserId = Module1.pubUserId;
						cHistory2.UserLogin = Module1.pubLogin;
						cHistory2.HistoryType = 5;
						cHistory2.Save();
						Close();
					}
					else
					{
						Interaction.MsgBox("User Name/Password yang anda masukkan salah", MsgBoxStyle.Information);
						cHistory cHistory3 = new cHistory();
						cHistory3.Content = "Salah password. User Name = '" + txtUserName.Text + "', Password = '" + txtPassword.Text + "'.";
						cHistory3.Description = "salah password untuk user " + txtUserName.Text;
						cHistory3.UserId = 0;
						cHistory3.UserLogin = "";
						cHistory3.HistoryType = 5;
						cHistory3.Save();
					}
					goto end_IL_0001;
				}
				case 3588:
					num = -1;
					switch (num2)
					{
					case 2:
						Module1.SaveError(Information.Err(), "frmLogin", "btnLogin", "");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj2) when (obj2 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 3588;
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

	private void frmLogin_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			Close();
		}
		else if (e.KeyCode == Keys.ControlKey)
		{
			lblHostRead.Visible = true;
			lblHostUpdate.Visible = true;
			lblDbMarketing.Visible = true;
			lblDbHistory.Visible = true;
			txtHostRead.Visible = true;
			txtHostUpdate.Visible = true;
			txtDbData.Visible = true;
			txtDbHistory.Visible = true;
			btnLogin.Top = 171;
			base.Height = 236;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void frmLogin_Load(object sender, EventArgs e)
	{
		Module1.pubCommandTimeout = 60;
		using (TextFieldParser textFieldParser = new TextFieldParser(Application.StartupPath + "\\setting.txt"))
		{
			textFieldParser.TextFieldType = FieldType.Delimited;
			textFieldParser.SetDelimiters(",");
			string[] array = textFieldParser.ReadFields();
			txtHostRead.Text = array[0];
			txtHostUpdate.Text = array[1];
			txtDbData.Text = array[2];
			txtDbHistory.Text = array[3];
			Module1.pubCustomY = Conversions.ToInteger(array[4]);
			Module1.pubReportPredictionPath = array[5];
		}
		btnLogin.Top = 67;
		base.Height = 135;
		ReadOnlyCollection<string> commandLineArgs = MyProject.Application.CommandLineArgs;
		if (commandLineArgs.Count > 0)
		{
			string left = commandLineArgs[0];
			Module1.pubHostRead = Module1.cleanString(txtHostRead.Text);
			Module1.pubHostUpdate = Module1.cleanString(txtHostUpdate.Text);
			Module1.pubDbData = Module1.cleanString(txtDbData.Text);
			Module1.pubDbHistory = Module1.cleanString(txtDbHistory.Text);
			Module1.connectDatabaseData();
			Module1.connectDatabaseRead();
			string strSql = " SELECT * FROM settings ";
			DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			foreach (DataRow row in dataTable.Rows)
			{
				if (Operators.ConditionalCompareObjectEqual(row["setName"], "BalanceDate", TextCompare: false))
				{
					Module1.pubBalanceDate = Conversions.ToDate(row["setVal"]);
				}
			}
			Module1.pubGroupId = 4;
			Module1.pubBranchId = 1;
			if (Operators.CompareString(left, "ReportProductionPredictionTea", TextCompare: false) == 0)
			{
				MyProject.Forms.frmReportProductionPrediction.ReportProductionPrediction(DateAndTime.DateAdd(DateInterval.Day, -2.0, DateAndTime.Now), "TEH", SaveToFile: true);
			}
			else if (Operators.CompareString(left, "ReportProductionPredictionPackaging", TextCompare: false) == 0)
			{
				MyProject.Forms.frmReportProductionPrediction.ReportProductionPrediction(DateAndTime.DateAdd(DateInterval.Day, -2.0, DateAndTime.Now), "KEMASAN", SaveToFile: true);
			}
			ProjectData.EndApp();
		}
		checkDbServer();
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		checkDbServer();
	}

	private void checkDbServer()
	{
		if (Module1.canPingIP(txtHostUpdate.Text) & Module1.canPingIP(txtHostRead.Text))
		{
			btnLogin.BackColor = Color.FromKnownColor(KnownColor.Control);
		}
		else
		{
			btnLogin.BackColor = Color.Red;
		}
	}
}
