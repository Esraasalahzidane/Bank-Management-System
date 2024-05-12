namespace Bank.Views
{
    partial class Currencies
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlCurrencyExchange = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnUpdateRate = new System.Windows.Forms.Button();
            this.numUpdateRate = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cbUpdateRateCurrencyCode = new System.Windows.Forms.ComboBox();
            this.lblCurrenyInfo = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCurrencyCalcConvert = new System.Windows.Forms.Button();
            this.numCurrencyCalcAmountToExchange = new System.Windows.Forms.NumericUpDown();
            this.lblAmountExchange = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCurrenyCalculaterCurrencyToInfo = new System.Windows.Forms.Label();
            this.lblCurrenyCalculaterCurrencyFromInfo = new System.Windows.Forms.Label();
            this.cbCurrencyCalculaterToCountryCode = new System.Windows.Forms.ComboBox();
            this.cbCurrencyCalculaterFromCountryCode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControlCurrencyExchange.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateRate)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrencyCalcAmountToExchange)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlCurrencyExchange
            // 
            this.tabControlCurrencyExchange.Controls.Add(this.tabPage1);
            this.tabControlCurrencyExchange.Controls.Add(this.tabPage2);
            this.tabControlCurrencyExchange.Controls.Add(this.tabPage3);
            this.tabControlCurrencyExchange.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControlCurrencyExchange.Location = new System.Drawing.Point(215, 0);
            this.tabControlCurrencyExchange.Name = "tabControlCurrencyExchange";
            this.tabControlCurrencyExchange.SelectedIndex = 0;
            this.tabControlCurrencyExchange.Size = new System.Drawing.Size(805, 556);
            this.tabControlCurrencyExchange.TabIndex = 0;
            this.tabControlCurrencyExchange.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvClients);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(797, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Show Currencies";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AllowUserToOrderColumns = true;
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvClients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClients.ColumnHeadersHeight = 25;
            this.dgvClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClients.Location = new System.Drawing.Point(3, 3);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.Size = new System.Drawing.Size(791, 524);
            this.dgvClients.TabIndex = 15;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnUpdateRate);
            this.tabPage2.Controls.Add(this.numUpdateRate);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cbUpdateRateCurrencyCode);
            this.tabPage2.Controls.Add(this.lblCurrenyInfo);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(797, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update Rate";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnUpdateRate
            // 
            this.btnUpdateRate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRate.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnUpdateRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUpdateRate.Location = new System.Drawing.Point(68, 347);
            this.btnUpdateRate.Name = "btnUpdateRate";
            this.btnUpdateRate.Size = new System.Drawing.Size(198, 49);
            this.btnUpdateRate.TabIndex = 38;
            this.btnUpdateRate.Text = "Update Rate";
            this.btnUpdateRate.UseVisualStyleBackColor = false;
            this.btnUpdateRate.Click += new System.EventHandler(this.btnUpdateRate_Click);
            // 
            // numUpdateRate
            // 
            this.numUpdateRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.numUpdateRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpdateRate.DecimalPlaces = 5;
            this.numUpdateRate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpdateRate.Location = new System.Drawing.Point(68, 261);
            this.numUpdateRate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numUpdateRate.Name = "numUpdateRate";
            this.numUpdateRate.Size = new System.Drawing.Size(198, 27);
            this.numUpdateRate.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label7.Location = new System.Drawing.Point(64, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 19);
            this.label7.TabIndex = 36;
            this.label7.Text = "New Rate ($)";
            // 
            // cbUpdateRateCurrencyCode
            // 
            this.cbUpdateRateCurrencyCode.AutoCompleteCustomSource.AddRange(new string[] {
            "dasd",
            "dad"});
            this.cbUpdateRateCurrencyCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbUpdateRateCurrencyCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUpdateRateCurrencyCode.BackColor = System.Drawing.Color.White;
            this.cbUpdateRateCurrencyCode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUpdateRateCurrencyCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cbUpdateRateCurrencyCode.FormattingEnabled = true;
            this.cbUpdateRateCurrencyCode.Location = new System.Drawing.Point(68, 79);
            this.cbUpdateRateCurrencyCode.Name = "cbUpdateRateCurrencyCode";
            this.cbUpdateRateCurrencyCode.Size = new System.Drawing.Size(198, 24);
            this.cbUpdateRateCurrencyCode.TabIndex = 27;
            this.cbUpdateRateCurrencyCode.SelectedIndexChanged += new System.EventHandler(this.cbUpdateRateCurrencyCode_SelectedIndexChanged);
            // 
            // lblCurrenyInfo
            // 
            this.lblCurrenyInfo.AutoSize = true;
            this.lblCurrenyInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrenyInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblCurrenyInfo.Location = new System.Drawing.Point(64, 128);
            this.lblCurrenyInfo.Name = "lblCurrenyInfo";
            this.lblCurrenyInfo.Size = new System.Drawing.Size(0, 19);
            this.lblCurrenyInfo.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label13.Location = new System.Drawing.Point(64, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 19);
            this.label13.TabIndex = 26;
            this.label13.Text = "Currency Code";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCurrencyCalcConvert);
            this.tabPage3.Controls.Add(this.numCurrencyCalcAmountToExchange);
            this.tabPage3.Controls.Add(this.lblAmountExchange);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.lblCurrenyCalculaterCurrencyToInfo);
            this.tabPage3.Controls.Add(this.lblCurrenyCalculaterCurrencyFromInfo);
            this.tabPage3.Controls.Add(this.cbCurrencyCalculaterToCountryCode);
            this.tabPage3.Controls.Add(this.cbCurrencyCalculaterFromCountryCode);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(797, 530);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Currency Calculator";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCurrencyCalcConvert
            // 
            this.btnCurrencyCalcConvert.BackColor = System.Drawing.SystemColors.Control;
            this.btnCurrencyCalcConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrencyCalcConvert.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnCurrencyCalcConvert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCurrencyCalcConvert.Location = new System.Drawing.Point(68, 339);
            this.btnCurrencyCalcConvert.Name = "btnCurrencyCalcConvert";
            this.btnCurrencyCalcConvert.Size = new System.Drawing.Size(198, 49);
            this.btnCurrencyCalcConvert.TabIndex = 40;
            this.btnCurrencyCalcConvert.Text = "Convert";
            this.btnCurrencyCalcConvert.UseVisualStyleBackColor = false;
            this.btnCurrencyCalcConvert.Click += new System.EventHandler(this.btnCurrencyCalcConvert_Click);
            // 
            // numCurrencyCalcAmountToExchange
            // 
            this.numCurrencyCalcAmountToExchange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.numCurrencyCalcAmountToExchange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numCurrencyCalcAmountToExchange.DecimalPlaces = 5;
            this.numCurrencyCalcAmountToExchange.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCurrencyCalcAmountToExchange.Location = new System.Drawing.Point(68, 260);
            this.numCurrencyCalcAmountToExchange.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numCurrencyCalcAmountToExchange.Name = "numCurrencyCalcAmountToExchange";
            this.numCurrencyCalcAmountToExchange.Size = new System.Drawing.Size(198, 27);
            this.numCurrencyCalcAmountToExchange.TabIndex = 39;
            this.numCurrencyCalcAmountToExchange.ValueChanged += new System.EventHandler(this.numCurrencyCalcAmountToExchange_ValueChanged);
            // 
            // lblAmountExchange
            // 
            this.lblAmountExchange.AutoSize = true;
            this.lblAmountExchange.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountExchange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblAmountExchange.Location = new System.Drawing.Point(64, 430);
            this.lblAmountExchange.Name = "lblAmountExchange";
            this.lblAmountExchange.Size = new System.Drawing.Size(0, 28);
            this.lblAmountExchange.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label4.Location = new System.Drawing.Point(64, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "Amount to Exchange";
            // 
            // lblCurrenyCalculaterCurrencyToInfo
            // 
            this.lblCurrenyCalculaterCurrencyToInfo.AutoSize = true;
            this.lblCurrenyCalculaterCurrencyToInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrenyCalculaterCurrencyToInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblCurrenyCalculaterCurrencyToInfo.Location = new System.Drawing.Point(370, 128);
            this.lblCurrenyCalculaterCurrencyToInfo.Name = "lblCurrenyCalculaterCurrencyToInfo";
            this.lblCurrenyCalculaterCurrencyToInfo.Size = new System.Drawing.Size(0, 19);
            this.lblCurrenyCalculaterCurrencyToInfo.TabIndex = 30;
            // 
            // lblCurrenyCalculaterCurrencyFromInfo
            // 
            this.lblCurrenyCalculaterCurrencyFromInfo.AutoSize = true;
            this.lblCurrenyCalculaterCurrencyFromInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrenyCalculaterCurrencyFromInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblCurrenyCalculaterCurrencyFromInfo.Location = new System.Drawing.Point(64, 128);
            this.lblCurrenyCalculaterCurrencyFromInfo.Name = "lblCurrenyCalculaterCurrencyFromInfo";
            this.lblCurrenyCalculaterCurrencyFromInfo.Size = new System.Drawing.Size(0, 19);
            this.lblCurrenyCalculaterCurrencyFromInfo.TabIndex = 30;
            // 
            // cbCurrencyCalculaterToCountryCode
            // 
            this.cbCurrencyCalculaterToCountryCode.AutoCompleteCustomSource.AddRange(new string[] {
            "dasd",
            "dad"});
            this.cbCurrencyCalculaterToCountryCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCurrencyCalculaterToCountryCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCurrencyCalculaterToCountryCode.BackColor = System.Drawing.Color.White;
            this.cbCurrencyCalculaterToCountryCode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCurrencyCalculaterToCountryCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cbCurrencyCalculaterToCountryCode.FormattingEnabled = true;
            this.cbCurrencyCalculaterToCountryCode.Location = new System.Drawing.Point(374, 78);
            this.cbCurrencyCalculaterToCountryCode.Name = "cbCurrencyCalculaterToCountryCode";
            this.cbCurrencyCalculaterToCountryCode.Size = new System.Drawing.Size(198, 24);
            this.cbCurrencyCalculaterToCountryCode.TabIndex = 29;
            this.cbCurrencyCalculaterToCountryCode.SelectedIndexChanged += new System.EventHandler(this.cbCurrencyCalculaterCurrencyCodeTo_SelectedIndexChanged);
            // 
            // cbCurrencyCalculaterFromCountryCode
            // 
            this.cbCurrencyCalculaterFromCountryCode.AutoCompleteCustomSource.AddRange(new string[] {
            "dasd",
            "dad"});
            this.cbCurrencyCalculaterFromCountryCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCurrencyCalculaterFromCountryCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCurrencyCalculaterFromCountryCode.BackColor = System.Drawing.Color.White;
            this.cbCurrencyCalculaterFromCountryCode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCurrencyCalculaterFromCountryCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cbCurrencyCalculaterFromCountryCode.FormattingEnabled = true;
            this.cbCurrencyCalculaterFromCountryCode.Location = new System.Drawing.Point(68, 78);
            this.cbCurrencyCalculaterFromCountryCode.Name = "cbCurrencyCalculaterFromCountryCode";
            this.cbCurrencyCalculaterFromCountryCode.Size = new System.Drawing.Size(198, 24);
            this.cbCurrencyCalculaterFromCountryCode.TabIndex = 29;
            this.cbCurrencyCalculaterFromCountryCode.SelectedIndexChanged += new System.EventHandler(this.cbCurrencyCalculaterCurrencyCodeFrom_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label5.Location = new System.Drawing.Point(370, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Convert To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.Location = new System.Drawing.Point(64, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Convert From";
            // 
            // Currencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 556);
            this.Controls.Add(this.tabControlCurrencyExchange);
            this.Name = "Currencies";
            this.Text = "Currency Exchange";
            this.tabControlCurrencyExchange.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateRate)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrencyCalcAmountToExchange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCurrencyExchange;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbUpdateRateCurrencyCode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numUpdateRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCurrenyInfo;
        private System.Windows.Forms.Button btnUpdateRate;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cbCurrencyCalculaterFromCountryCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numCurrencyCalcAmountToExchange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCurrenyCalculaterCurrencyToInfo;
        private System.Windows.Forms.Label lblCurrenyCalculaterCurrencyFromInfo;
        private System.Windows.Forms.ComboBox cbCurrencyCalculaterToCountryCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCurrencyCalcConvert;
        private System.Windows.Forms.Label lblAmountExchange;
        private System.Windows.Forms.DataGridView dgvClients;
    }
}