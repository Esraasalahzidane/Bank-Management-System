namespace Bank.Views
{
    partial class Users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlesManageUsers = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.usersContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.circularProgressBarAddNewUser = new CircularProgressBar.CircularProgressBar();
            this.grpAddNewUserPermissions = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbAddUserPermissionsNo = new System.Windows.Forms.RadioButton();
            this.rbAddUserPermissionsYes = new System.Windows.Forms.RadioButton();
            this.chkCurrencyExchange = new System.Windows.Forms.CheckBox();
            this.chkManageUsers = new System.Windows.Forms.CheckBox();
            this.chkClientsTransactions = new System.Windows.Forms.CheckBox();
            this.chkManageClients = new System.Windows.Forms.CheckBox();
            this.txtAddNewUserEmail = new System.Windows.Forms.TextBox();
            this.txtAddNewUserLastName = new System.Windows.Forms.TextBox();
            this.txtAddNewUserPassword = new System.Windows.Forms.TextBox();
            this.txtAddNewUserPhone = new System.Windows.Forms.TextBox();
            this.txtAddNewUserFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAddNewUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAccountNumber = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grpUpdateUserPermissions = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.rbUpdateUserPermissionsNo = new System.Windows.Forms.RadioButton();
            this.rbUpdateUserPermissionsYes = new System.Windows.Forms.RadioButton();
            this.chkUpdateCurrencyExchange = new System.Windows.Forms.CheckBox();
            this.chkUpdateManageUsers = new System.Windows.Forms.CheckBox();
            this.chkUpdateClientsTransactions = new System.Windows.Forms.CheckBox();
            this.chkUpdateManageClients = new System.Windows.Forms.CheckBox();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.cbUpdateUserName = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUpdateUserPhone = new System.Windows.Forms.TextBox();
            this.txtUpdateUserFirstName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtUpdateUserLastName = new System.Windows.Forms.TextBox();
            this.txtUpdateUserPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtUpdateUserEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvUsersLoginLog = new System.Windows.Forms.DataGridView();
            this.lblLoginRegister = new System.Windows.Forms.Label();
            this.UserInfoErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControlesManageUsers.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.usersContextMenuStrip.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpAddNewUserPermissions.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.grpUpdateUserPermissions.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersLoginLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlesManageUsers
            // 
            this.tabControlesManageUsers.Controls.Add(this.tabPage1);
            this.tabControlesManageUsers.Controls.Add(this.tabPage2);
            this.tabControlesManageUsers.Controls.Add(this.tabPage3);
            this.tabControlesManageUsers.Controls.Add(this.tabPage4);
            this.tabControlesManageUsers.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControlesManageUsers.Location = new System.Drawing.Point(211, 0);
            this.tabControlesManageUsers.Name = "tabControlesManageUsers";
            this.tabControlesManageUsers.SelectedIndex = 0;
            this.tabControlesManageUsers.Size = new System.Drawing.Size(1083, 582);
            this.tabControlesManageUsers.TabIndex = 0;
            this.tabControlesManageUsers.SelectedIndexChanged += new System.EventHandler(this.tabControlesManageUsers_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvUsers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1075, 556);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Show Users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToOrderColumns = true;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.ColumnHeadersHeight = 25;
            this.dgvUsers.ContextMenuStrip = this.usersContextMenuStrip;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUsers.Location = new System.Drawing.Point(3, 205);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.Size = new System.Drawing.Size(1069, 348);
            this.dgvUsers.TabIndex = 15;
            // 
            // usersContextMenuStrip
            // 
            this.usersContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.usersContextMenuStrip.Name = "usersContextMenuStrip";
            this.usersContextMenuStrip.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAddNewUser);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.circularProgressBarAddNewUser);
            this.tabPage2.Controls.Add(this.grpAddNewUserPermissions);
            this.tabPage2.Controls.Add(this.txtAddNewUserEmail);
            this.tabPage2.Controls.Add(this.txtAddNewUserLastName);
            this.tabPage2.Controls.Add(this.txtAddNewUserPassword);
            this.tabPage2.Controls.Add(this.txtAddNewUserPhone);
            this.tabPage2.Controls.Add(this.txtAddNewUserFirstName);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.txtAddNewUserName);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.pnlAccountNumber);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1075, 556);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add New User";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUser.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnAddNewUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAddNewUser.Location = new System.Drawing.Point(26, 487);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(198, 49);
            this.btnAddNewUser.TabIndex = 16;
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label15.Location = new System.Drawing.Point(687, 250);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 25);
            this.label15.TabIndex = 17;
            this.label15.Text = "Profile";
            // 
            // circularProgressBarAddNewUser
            // 
            this.circularProgressBarAddNewUser.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarAddNewUser.AnimationSpeed = 500;
            this.circularProgressBarAddNewUser.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarAddNewUser.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBarAddNewUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarAddNewUser.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBarAddNewUser.InnerMargin = 2;
            this.circularProgressBarAddNewUser.InnerWidth = -1;
            this.circularProgressBarAddNewUser.Location = new System.Drawing.Point(618, 41);
            this.circularProgressBarAddNewUser.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarAddNewUser.Maximum = 6;
            this.circularProgressBarAddNewUser.Name = "circularProgressBarAddNewUser";
            this.circularProgressBarAddNewUser.OuterColor = System.Drawing.Color.White;
            this.circularProgressBarAddNewUser.OuterMargin = 0;
            this.circularProgressBarAddNewUser.OuterWidth = 0;
            this.circularProgressBarAddNewUser.ProgressColor = System.Drawing.Color.White;
            this.circularProgressBarAddNewUser.ProgressWidth = 10;
            this.circularProgressBarAddNewUser.SecondaryFont = new System.Drawing.Font("Tahoma", 36F);
            this.circularProgressBarAddNewUser.Size = new System.Drawing.Size(192, 191);
            this.circularProgressBarAddNewUser.StartAngle = 270;
            this.circularProgressBarAddNewUser.Step = 1;
            this.circularProgressBarAddNewUser.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.circularProgressBarAddNewUser.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBarAddNewUser.SubscriptText = "";
            this.circularProgressBarAddNewUser.SuperscriptColor = System.Drawing.Color.White;
            this.circularProgressBarAddNewUser.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarAddNewUser.SuperscriptText = "";
            this.circularProgressBarAddNewUser.TabIndex = 16;
            this.circularProgressBarAddNewUser.Text = "0 %";
            this.circularProgressBarAddNewUser.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.circularProgressBarAddNewUser.Value = 6;
            // 
            // grpAddNewUserPermissions
            // 
            this.grpAddNewUserPermissions.Controls.Add(this.label7);
            this.grpAddNewUserPermissions.Controls.Add(this.rbAddUserPermissionsNo);
            this.grpAddNewUserPermissions.Controls.Add(this.rbAddUserPermissionsYes);
            this.grpAddNewUserPermissions.Controls.Add(this.chkCurrencyExchange);
            this.grpAddNewUserPermissions.Controls.Add(this.chkManageUsers);
            this.grpAddNewUserPermissions.Controls.Add(this.chkClientsTransactions);
            this.grpAddNewUserPermissions.Controls.Add(this.chkManageClients);
            this.grpAddNewUserPermissions.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddNewUserPermissions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.grpAddNewUserPermissions.Location = new System.Drawing.Point(26, 313);
            this.grpAddNewUserPermissions.Name = "grpAddNewUserPermissions";
            this.grpAddNewUserPermissions.Size = new System.Drawing.Size(454, 147);
            this.grpAddNewUserPermissions.TabIndex = 8;
            this.grpAddNewUserPermissions.TabStop = false;
            this.grpAddNewUserPermissions.Text = "Permissions";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Give full Access?";
            // 
            // rbAddUserPermissionsNo
            // 
            this.rbAddUserPermissionsNo.AutoSize = true;
            this.rbAddUserPermissionsNo.Location = new System.Drawing.Point(198, 38);
            this.rbAddUserPermissionsNo.Name = "rbAddUserPermissionsNo";
            this.rbAddUserPermissionsNo.Size = new System.Drawing.Size(47, 22);
            this.rbAddUserPermissionsNo.TabIndex = 7;
            this.rbAddUserPermissionsNo.TabStop = true;
            this.rbAddUserPermissionsNo.Text = "No";
            this.rbAddUserPermissionsNo.UseVisualStyleBackColor = true;
            this.rbAddUserPermissionsNo.CheckedChanged += new System.EventHandler(this.rbPermissionsNo_CheckedChanged);
            // 
            // rbAddUserPermissionsYes
            // 
            this.rbAddUserPermissionsYes.AutoSize = true;
            this.rbAddUserPermissionsYes.Location = new System.Drawing.Point(126, 38);
            this.rbAddUserPermissionsYes.Name = "rbAddUserPermissionsYes";
            this.rbAddUserPermissionsYes.Size = new System.Drawing.Size(51, 22);
            this.rbAddUserPermissionsYes.TabIndex = 6;
            this.rbAddUserPermissionsYes.TabStop = true;
            this.rbAddUserPermissionsYes.Text = "Yes";
            this.rbAddUserPermissionsYes.UseVisualStyleBackColor = true;
            this.rbAddUserPermissionsYes.CheckedChanged += new System.EventHandler(this.rbPermissionsYes_CheckedChanged);
            // 
            // chkCurrencyExchange
            // 
            this.chkCurrencyExchange.AutoSize = true;
            this.chkCurrencyExchange.Location = new System.Drawing.Point(256, 100);
            this.chkCurrencyExchange.Name = "chkCurrencyExchange";
            this.chkCurrencyExchange.Size = new System.Drawing.Size(174, 22);
            this.chkCurrencyExchange.TabIndex = 14;
            this.chkCurrencyExchange.Text = "Currency Exchange";
            this.chkCurrencyExchange.UseVisualStyleBackColor = true;
            // 
            // chkManageUsers
            // 
            this.chkManageUsers.AutoSize = true;
            this.chkManageUsers.Location = new System.Drawing.Point(6, 100);
            this.chkManageUsers.Name = "chkManageUsers";
            this.chkManageUsers.Size = new System.Drawing.Size(131, 22);
            this.chkManageUsers.TabIndex = 13;
            this.chkManageUsers.Text = "Manage Users";
            this.chkManageUsers.UseVisualStyleBackColor = true;
            // 
            // chkClientsTransactions
            // 
            this.chkClientsTransactions.AutoSize = true;
            this.chkClientsTransactions.Location = new System.Drawing.Point(255, 72);
            this.chkClientsTransactions.Name = "chkClientsTransactions";
            this.chkClientsTransactions.Size = new System.Drawing.Size(169, 22);
            this.chkClientsTransactions.TabIndex = 12;
            this.chkClientsTransactions.Text = "Clients Transactions";
            this.chkClientsTransactions.UseVisualStyleBackColor = true;
            // 
            // chkManageClients
            // 
            this.chkManageClients.AutoSize = true;
            this.chkManageClients.Location = new System.Drawing.Point(6, 72);
            this.chkManageClients.Name = "chkManageClients";
            this.chkManageClients.Size = new System.Drawing.Size(143, 22);
            this.chkManageClients.TabIndex = 8;
            this.chkManageClients.Text = "Manage Clients";
            this.chkManageClients.UseVisualStyleBackColor = true;
            // 
            // txtAddNewUserEmail
            // 
            this.txtAddNewUserEmail.BackColor = System.Drawing.Color.White;
            this.txtAddNewUserEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddNewUserEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddNewUserEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtAddNewUserEmail.Location = new System.Drawing.Point(282, 58);
            this.txtAddNewUserEmail.Name = "txtAddNewUserEmail";
            this.txtAddNewUserEmail.Size = new System.Drawing.Size(198, 20);
            this.txtAddNewUserEmail.TabIndex = 1;
            this.txtAddNewUserEmail.Validating += new System.ComponentModel.CancelEventHandler(this.validateUserForm);
            // 
            // txtAddNewUserLastName
            // 
            this.txtAddNewUserLastName.BackColor = System.Drawing.Color.White;
            this.txtAddNewUserLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddNewUserLastName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddNewUserLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtAddNewUserLastName.Location = new System.Drawing.Point(282, 149);
            this.txtAddNewUserLastName.Name = "txtAddNewUserLastName";
            this.txtAddNewUserLastName.Size = new System.Drawing.Size(198, 20);
            this.txtAddNewUserLastName.TabIndex = 3;
            this.txtAddNewUserLastName.Validating += new System.ComponentModel.CancelEventHandler(this.validateUserForm);
            // 
            // txtAddNewUserPassword
            // 
            this.txtAddNewUserPassword.BackColor = System.Drawing.Color.White;
            this.txtAddNewUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddNewUserPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddNewUserPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtAddNewUserPassword.Location = new System.Drawing.Point(281, 248);
            this.txtAddNewUserPassword.Name = "txtAddNewUserPassword";
            this.txtAddNewUserPassword.PasswordChar = '*';
            this.txtAddNewUserPassword.Size = new System.Drawing.Size(198, 20);
            this.txtAddNewUserPassword.TabIndex = 5;
            this.txtAddNewUserPassword.Validating += new System.ComponentModel.CancelEventHandler(this.validateUserForm);
            // 
            // txtAddNewUserPhone
            // 
            this.txtAddNewUserPhone.BackColor = System.Drawing.Color.White;
            this.txtAddNewUserPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddNewUserPhone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddNewUserPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtAddNewUserPhone.Location = new System.Drawing.Point(26, 248);
            this.txtAddNewUserPhone.Name = "txtAddNewUserPhone";
            this.txtAddNewUserPhone.Size = new System.Drawing.Size(198, 20);
            this.txtAddNewUserPhone.TabIndex = 4;
            this.txtAddNewUserPhone.Validating += new System.ComponentModel.CancelEventHandler(this.validateUserForm);
            // 
            // txtAddNewUserFirstName
            // 
            this.txtAddNewUserFirstName.BackColor = System.Drawing.Color.White;
            this.txtAddNewUserFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddNewUserFirstName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddNewUserFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtAddNewUserFirstName.Location = new System.Drawing.Point(26, 149);
            this.txtAddNewUserFirstName.Name = "txtAddNewUserFirstName";
            this.txtAddNewUserFirstName.Size = new System.Drawing.Size(198, 20);
            this.txtAddNewUserFirstName.TabIndex = 2;
            this.txtAddNewUserFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.validateUserForm);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label4.Location = new System.Drawing.Point(278, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.Location = new System.Drawing.Point(278, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label6.Location = new System.Drawing.Point(277, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label5.Location = new System.Drawing.Point(22, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(22, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(282, 84);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel3.Size = new System.Drawing.Size(198, 1);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(282, 175);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel2.Size = new System.Drawing.Size(198, 1);
            this.panel2.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(281, 274);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel5.Size = new System.Drawing.Size(198, 1);
            this.panel5.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(26, 274);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel4.Size = new System.Drawing.Size(198, 1);
            this.panel4.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(26, 175);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel1.Size = new System.Drawing.Size(198, 1);
            this.panel1.TabIndex = 6;
            // 
            // txtAddNewUserName
            // 
            this.txtAddNewUserName.BackColor = System.Drawing.Color.White;
            this.txtAddNewUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddNewUserName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddNewUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtAddNewUserName.Location = new System.Drawing.Point(26, 58);
            this.txtAddNewUserName.Name = "txtAddNewUserName";
            this.txtAddNewUserName.Size = new System.Drawing.Size(198, 20);
            this.txtAddNewUserName.TabIndex = 0;
            this.txtAddNewUserName.Validating += new System.ComponentModel.CancelEventHandler(this.validateUserForm);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name";
            // 
            // pnlAccountNumber
            // 
            this.pnlAccountNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlAccountNumber.ForeColor = System.Drawing.Color.White;
            this.pnlAccountNumber.Location = new System.Drawing.Point(26, 84);
            this.pnlAccountNumber.Name = "pnlAccountNumber";
            this.pnlAccountNumber.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pnlAccountNumber.Size = new System.Drawing.Size(198, 1);
            this.pnlAccountNumber.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.grpUpdateUserPermissions);
            this.tabPage3.Controls.Add(this.btnUpdateUser);
            this.tabPage3.Controls.Add(this.cbUpdateUserName);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.txtUpdateUserPhone);
            this.tabPage3.Controls.Add(this.txtUpdateUserFirstName);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.panel9);
            this.tabPage3.Controls.Add(this.panel10);
            this.tabPage3.Controls.Add(this.txtUpdateUserLastName);
            this.tabPage3.Controls.Add(this.txtUpdateUserPassword);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.panel7);
            this.tabPage3.Controls.Add(this.panel8);
            this.tabPage3.Controls.Add(this.txtUpdateUserEmail);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.panel6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1075, 556);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update User";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grpUpdateUserPermissions
            // 
            this.grpUpdateUserPermissions.Controls.Add(this.label16);
            this.grpUpdateUserPermissions.Controls.Add(this.rbUpdateUserPermissionsNo);
            this.grpUpdateUserPermissions.Controls.Add(this.rbUpdateUserPermissionsYes);
            this.grpUpdateUserPermissions.Controls.Add(this.chkUpdateCurrencyExchange);
            this.grpUpdateUserPermissions.Controls.Add(this.chkUpdateManageUsers);
            this.grpUpdateUserPermissions.Controls.Add(this.chkUpdateClientsTransactions);
            this.grpUpdateUserPermissions.Controls.Add(this.chkUpdateManageClients);
            this.grpUpdateUserPermissions.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUpdateUserPermissions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.grpUpdateUserPermissions.Location = new System.Drawing.Point(21, 294);
            this.grpUpdateUserPermissions.Name = "grpUpdateUserPermissions";
            this.grpUpdateUserPermissions.Size = new System.Drawing.Size(454, 147);
            this.grpUpdateUserPermissions.TabIndex = 30;
            this.grpUpdateUserPermissions.TabStop = false;
            this.grpUpdateUserPermissions.Text = "Permissions";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(123, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(133, 18);
            this.label16.TabIndex = 11;
            this.label16.Text = "Give full Access?";
            // 
            // rbUpdateUserPermissionsNo
            // 
            this.rbUpdateUserPermissionsNo.AutoSize = true;
            this.rbUpdateUserPermissionsNo.Location = new System.Drawing.Point(198, 38);
            this.rbUpdateUserPermissionsNo.Name = "rbUpdateUserPermissionsNo";
            this.rbUpdateUserPermissionsNo.Size = new System.Drawing.Size(47, 22);
            this.rbUpdateUserPermissionsNo.TabIndex = 7;
            this.rbUpdateUserPermissionsNo.TabStop = true;
            this.rbUpdateUserPermissionsNo.Text = "No";
            this.rbUpdateUserPermissionsNo.UseVisualStyleBackColor = true;
            this.rbUpdateUserPermissionsNo.CheckedChanged += new System.EventHandler(this.rbUpdateUserPermissionsNo_CheckedChanged);
            this.rbUpdateUserPermissionsNo.Click += new System.EventHandler(this.rbUpdateUserPermissionsNo_CheckedChanged);
            // 
            // rbUpdateUserPermissionsYes
            // 
            this.rbUpdateUserPermissionsYes.AutoSize = true;
            this.rbUpdateUserPermissionsYes.Location = new System.Drawing.Point(126, 38);
            this.rbUpdateUserPermissionsYes.Name = "rbUpdateUserPermissionsYes";
            this.rbUpdateUserPermissionsYes.Size = new System.Drawing.Size(51, 22);
            this.rbUpdateUserPermissionsYes.TabIndex = 6;
            this.rbUpdateUserPermissionsYes.TabStop = true;
            this.rbUpdateUserPermissionsYes.Text = "Yes";
            this.rbUpdateUserPermissionsYes.UseVisualStyleBackColor = true;
            this.rbUpdateUserPermissionsYes.CheckedChanged += new System.EventHandler(this.rbUpdateUserPermissionsYes_CheckedChanged);
            // 
            // chkUpdateCurrencyExchange
            // 
            this.chkUpdateCurrencyExchange.AutoSize = true;
            this.chkUpdateCurrencyExchange.Location = new System.Drawing.Point(256, 100);
            this.chkUpdateCurrencyExchange.Name = "chkUpdateCurrencyExchange";
            this.chkUpdateCurrencyExchange.Size = new System.Drawing.Size(174, 22);
            this.chkUpdateCurrencyExchange.TabIndex = 14;
            this.chkUpdateCurrencyExchange.Text = "Currency Exchange";
            this.chkUpdateCurrencyExchange.UseVisualStyleBackColor = true;
            // 
            // chkUpdateManageUsers
            // 
            this.chkUpdateManageUsers.AutoSize = true;
            this.chkUpdateManageUsers.Location = new System.Drawing.Point(6, 100);
            this.chkUpdateManageUsers.Name = "chkUpdateManageUsers";
            this.chkUpdateManageUsers.Size = new System.Drawing.Size(131, 22);
            this.chkUpdateManageUsers.TabIndex = 13;
            this.chkUpdateManageUsers.Text = "Manage Users";
            this.chkUpdateManageUsers.UseVisualStyleBackColor = true;
            // 
            // chkUpdateClientsTransactions
            // 
            this.chkUpdateClientsTransactions.AutoSize = true;
            this.chkUpdateClientsTransactions.Location = new System.Drawing.Point(255, 72);
            this.chkUpdateClientsTransactions.Name = "chkUpdateClientsTransactions";
            this.chkUpdateClientsTransactions.Size = new System.Drawing.Size(169, 22);
            this.chkUpdateClientsTransactions.TabIndex = 12;
            this.chkUpdateClientsTransactions.Text = "Clients Transactions";
            this.chkUpdateClientsTransactions.UseVisualStyleBackColor = true;
            // 
            // chkUpdateManageClients
            // 
            this.chkUpdateManageClients.AutoSize = true;
            this.chkUpdateManageClients.Location = new System.Drawing.Point(6, 72);
            this.chkUpdateManageClients.Name = "chkUpdateManageClients";
            this.chkUpdateManageClients.Size = new System.Drawing.Size(143, 22);
            this.chkUpdateManageClients.TabIndex = 8;
            this.chkUpdateManageClients.Text = "Manage Clients";
            this.chkUpdateManageClients.UseVisualStyleBackColor = true;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnUpdateUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUpdateUser.Location = new System.Drawing.Point(21, 488);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(198, 49);
            this.btnUpdateUser.TabIndex = 29;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // cbUpdateUserName
            // 
            this.cbUpdateUserName.BackColor = System.Drawing.Color.White;
            this.cbUpdateUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUpdateUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUpdateUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cbUpdateUserName.FormattingEnabled = true;
            this.cbUpdateUserName.Location = new System.Drawing.Point(21, 62);
            this.cbUpdateUserName.Name = "cbUpdateUserName";
            this.cbUpdateUserName.Size = new System.Drawing.Size(198, 24);
            this.cbUpdateUserName.TabIndex = 1;
            this.cbUpdateUserName.SelectedIndexChanged += new System.EventHandler(this.cbUpdateUserName_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label13.Location = new System.Drawing.Point(17, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 19);
            this.label13.TabIndex = 26;
            this.label13.Text = "User Name";
            // 
            // txtUpdateUserPhone
            // 
            this.txtUpdateUserPhone.BackColor = System.Drawing.Color.White;
            this.txtUpdateUserPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUpdateUserPhone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateUserPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtUpdateUserPhone.Location = new System.Drawing.Point(21, 206);
            this.txtUpdateUserPhone.Name = "txtUpdateUserPhone";
            this.txtUpdateUserPhone.Size = new System.Drawing.Size(198, 20);
            this.txtUpdateUserPhone.TabIndex = 5;
            this.txtUpdateUserPhone.Validating += new System.ComponentModel.CancelEventHandler(this.validateUserForm);
            // 
            // txtUpdateUserFirstName
            // 
            this.txtUpdateUserFirstName.BackColor = System.Drawing.Color.White;
            this.txtUpdateUserFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUpdateUserFirstName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateUserFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtUpdateUserFirstName.Location = new System.Drawing.Point(21, 130);
            this.txtUpdateUserFirstName.Name = "txtUpdateUserFirstName";
            this.txtUpdateUserFirstName.Size = new System.Drawing.Size(198, 20);
            this.txtUpdateUserFirstName.TabIndex = 3;
            this.txtUpdateUserFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.validateUserForm);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label11.Location = new System.Drawing.Point(17, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 19);
            this.label11.TabIndex = 21;
            this.label11.Text = "Phone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label12.Location = new System.Drawing.Point(17, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 19);
            this.label12.TabIndex = 22;
            this.label12.Text = "First Name";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel9.ForeColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(21, 232);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel9.Size = new System.Drawing.Size(198, 1);
            this.panel9.TabIndex = 19;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel10.ForeColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(21, 156);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel10.Size = new System.Drawing.Size(198, 1);
            this.panel10.TabIndex = 20;
            // 
            // txtUpdateUserLastName
            // 
            this.txtUpdateUserLastName.BackColor = System.Drawing.Color.White;
            this.txtUpdateUserLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUpdateUserLastName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateUserLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtUpdateUserLastName.Location = new System.Drawing.Point(282, 130);
            this.txtUpdateUserLastName.Name = "txtUpdateUserLastName";
            this.txtUpdateUserLastName.Size = new System.Drawing.Size(198, 20);
            this.txtUpdateUserLastName.TabIndex = 4;
            this.txtUpdateUserLastName.Validating += new System.ComponentModel.CancelEventHandler(this.validateUserForm);
            // 
            // txtUpdateUserPassword
            // 
            this.txtUpdateUserPassword.BackColor = System.Drawing.Color.White;
            this.txtUpdateUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUpdateUserPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateUserPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtUpdateUserPassword.Location = new System.Drawing.Point(282, 206);
            this.txtUpdateUserPassword.Name = "txtUpdateUserPassword";
            this.txtUpdateUserPassword.PasswordChar = '*';
            this.txtUpdateUserPassword.Size = new System.Drawing.Size(198, 20);
            this.txtUpdateUserPassword.TabIndex = 6;
            this.txtUpdateUserPassword.Validating += new System.ComponentModel.CancelEventHandler(this.validateUserForm);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label9.Location = new System.Drawing.Point(278, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Last Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label10.Location = new System.Drawing.Point(278, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "Password";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel7.ForeColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(282, 156);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel7.Size = new System.Drawing.Size(198, 1);
            this.panel7.TabIndex = 13;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel8.ForeColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(282, 232);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel8.Size = new System.Drawing.Size(198, 1);
            this.panel8.TabIndex = 14;
            // 
            // txtUpdateUserEmail
            // 
            this.txtUpdateUserEmail.BackColor = System.Drawing.Color.White;
            this.txtUpdateUserEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUpdateUserEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateUserEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtUpdateUserEmail.Location = new System.Drawing.Point(282, 59);
            this.txtUpdateUserEmail.Name = "txtUpdateUserEmail";
            this.txtUpdateUserEmail.Size = new System.Drawing.Size(198, 20);
            this.txtUpdateUserEmail.TabIndex = 2;
            this.txtUpdateUserEmail.Validating += new System.ComponentModel.CancelEventHandler(this.validateUserForm);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label8.Location = new System.Drawing.Point(278, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Email";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel6.ForeColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(282, 85);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel6.Size = new System.Drawing.Size(198, 1);
            this.panel6.TabIndex = 9;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvUsersLoginLog);
            this.tabPage4.Controls.Add(this.lblLoginRegister);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1075, 556);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Login Register";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvUsersLoginLog
            // 
            this.dgvUsersLoginLog.AllowUserToAddRows = false;
            this.dgvUsersLoginLog.AllowUserToDeleteRows = false;
            this.dgvUsersLoginLog.AllowUserToOrderColumns = true;
            this.dgvUsersLoginLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsersLoginLog.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvUsersLoginLog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsersLoginLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsersLoginLog.ColumnHeadersHeight = 25;
            this.dgvUsersLoginLog.ContextMenuStrip = this.usersContextMenuStrip;
            this.dgvUsersLoginLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUsersLoginLog.Location = new System.Drawing.Point(0, 208);
            this.dgvUsersLoginLog.Name = "dgvUsersLoginLog";
            this.dgvUsersLoginLog.ReadOnly = true;
            this.dgvUsersLoginLog.Size = new System.Drawing.Size(1075, 348);
            this.dgvUsersLoginLog.TabIndex = 20;
            // 
            // lblLoginRegister
            // 
            this.lblLoginRegister.AutoSize = true;
            this.lblLoginRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblLoginRegister.Location = new System.Drawing.Point(24, 154);
            this.lblLoginRegister.Name = "lblLoginRegister";
            this.lblLoginRegister.Size = new System.Drawing.Size(0, 19);
            this.lblLoginRegister.TabIndex = 18;
            // 
            // UserInfoErrorProvider
            // 
            this.UserInfoErrorProvider.ContainerControl = this;
            // 
            // FrmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 582);
            this.Controls.Add(this.tabControlesManageUsers);
            this.Name = "FrmManageUsers";
            this.Text = "Manage Users";
            this.tabControlesManageUsers.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.usersContextMenuStrip.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grpAddNewUserPermissions.ResumeLayout(false);
            this.grpAddNewUserPermissions.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.grpUpdateUserPermissions.ResumeLayout(false);
            this.grpUpdateUserPermissions.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersLoginLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlesManageUsers;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ContextMenuStrip usersContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TextBox txtAddNewUserEmail;
        private System.Windows.Forms.TextBox txtAddNewUserLastName;
        private System.Windows.Forms.TextBox txtAddNewUserPassword;
        private System.Windows.Forms.TextBox txtAddNewUserPhone;
        private System.Windows.Forms.TextBox txtAddNewUserFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAddNewUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAccountNumber;
        private System.Windows.Forms.GroupBox grpAddNewUserPermissions;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbAddUserPermissionsNo;
        private System.Windows.Forms.RadioButton rbAddUserPermissionsYes;
        private System.Windows.Forms.CheckBox chkCurrencyExchange;
        private System.Windows.Forms.CheckBox chkManageUsers;
        private System.Windows.Forms.CheckBox chkClientsTransactions;
        private System.Windows.Forms.CheckBox chkManageClients;
        private System.Windows.Forms.Label label15;
        private CircularProgressBar.CircularProgressBar circularProgressBarAddNewUser;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.ErrorProvider UserInfoErrorProvider;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cbUpdateUserName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtUpdateUserPhone;
        private System.Windows.Forms.TextBox txtUpdateUserFirstName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtUpdateUserLastName;
        private System.Windows.Forms.TextBox txtUpdateUserPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtUpdateUserEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblLoginRegister;
        private System.Windows.Forms.GroupBox grpUpdateUserPermissions;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rbUpdateUserPermissionsNo;
        private System.Windows.Forms.RadioButton rbUpdateUserPermissionsYes;
        private System.Windows.Forms.CheckBox chkUpdateCurrencyExchange;
        private System.Windows.Forms.CheckBox chkUpdateManageUsers;
        private System.Windows.Forms.CheckBox chkUpdateClientsTransactions;
        private System.Windows.Forms.CheckBox chkUpdateManageClients;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridView dgvUsersLoginLog;
    }
}