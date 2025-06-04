namespace HomeAccounting
{
    partial class AccountDetailsForm
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
            this.lblAccountNameBalance = new System.Windows.Forms.Label();
            this.lblTransactions = new System.Windows.Forms.Label();
            this.panelDetailsFilters = new System.Windows.Forms.Panel();
            this.btnDetailsClearFilters = new System.Windows.Forms.Button();
            this.btnDetailsApplyFilters = new System.Windows.Forms.Button();
            this.cmbDetailsTransactionTypeFilter = new System.Windows.Forms.ComboBox();
            this.lblDetailsFilterType = new System.Windows.Forms.Label();
            this.dtpDetailsEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblDetailsFilterEndDate = new System.Windows.Forms.Label();
            this.dtpDetailsStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblDetailsFilterStartDate = new System.Windows.Forms.Label();
            this.listBoxTransactions = new System.Windows.Forms.ListBox();
            this.btnRemoveSelectedTransaction = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelDetailsFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAccountNameBalance
            // 
            this.lblAccountNameBalance.AutoSize = true;
            this.lblAccountNameBalance.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAccountNameBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNameBalance.Location = new System.Drawing.Point(0, 0);
            this.lblAccountNameBalance.Name = "lblAccountNameBalance";
            this.lblAccountNameBalance.Padding = new System.Windows.Forms.Padding(12, 9, 0, 5);
            this.lblAccountNameBalance.Size = new System.Drawing.Size(135, 35);
            this.lblAccountNameBalance.TabIndex = 0;
            this.lblAccountNameBalance.Text = "Account Name";
            // 
            // lblTransactions
            // 
            this.lblTransactions.AutoSize = true;
            this.lblTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTransactions.Location = new System.Drawing.Point(0, 35);
            this.lblTransactions.Name = "lblTransactions";
            this.lblTransactions.Padding = new System.Windows.Forms.Padding(13, 5, 0, 2);
            this.lblTransactions.Size = new System.Drawing.Size(84, 20);
            this.lblTransactions.TabIndex = 1;
            this.lblTransactions.Text = "Транзакции:";
            // 
            // panelDetailsFilters
            // 
            this.panelDetailsFilters.Controls.Add(this.btnDetailsClearFilters);
            this.panelDetailsFilters.Controls.Add(this.btnDetailsApplyFilters);
            this.panelDetailsFilters.Controls.Add(this.cmbDetailsTransactionTypeFilter);
            this.panelDetailsFilters.Controls.Add(this.lblDetailsFilterType);
            this.panelDetailsFilters.Controls.Add(this.dtpDetailsEndDate);
            this.panelDetailsFilters.Controls.Add(this.lblDetailsFilterEndDate);
            this.panelDetailsFilters.Controls.Add(this.dtpDetailsStartDate);
            this.panelDetailsFilters.Controls.Add(this.lblDetailsFilterStartDate);
            this.panelDetailsFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetailsFilters.Location = new System.Drawing.Point(0, 55);
            this.panelDetailsFilters.Name = "panelDetailsFilters";
            this.panelDetailsFilters.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.panelDetailsFilters.Size = new System.Drawing.Size(584, 70);
            this.panelDetailsFilters.TabIndex = 6;
            // 
            // btnDetailsClearFilters
            // 
            this.btnDetailsClearFilters.Location = new System.Drawing.Point(470, 38);
            this.btnDetailsClearFilters.Name = "btnDetailsClearFilters";
            this.btnDetailsClearFilters.Size = new System.Drawing.Size(85, 23);
            this.btnDetailsClearFilters.TabIndex = 7;
            this.btnDetailsClearFilters.Text = "Очистить";
            this.btnDetailsClearFilters.UseVisualStyleBackColor = true;
            this.btnDetailsClearFilters.Click += new System.EventHandler(this.BtnDetailsClearFilters_Click);
            // 
            // btnDetailsApplyFilters
            // 
            this.btnDetailsApplyFilters.Location = new System.Drawing.Point(380, 38);
            this.btnDetailsApplyFilters.Name = "btnDetailsApplyFilters";
            this.btnDetailsApplyFilters.Size = new System.Drawing.Size(85, 23);
            this.btnDetailsApplyFilters.TabIndex = 6;
            this.btnDetailsApplyFilters.Text = "Применить";
            this.btnDetailsApplyFilters.UseVisualStyleBackColor = true;
            this.btnDetailsApplyFilters.Click += new System.EventHandler(this.BtnDetailsApplyFilters_Click);
            // 
            // cmbDetailsTransactionTypeFilter
            // 
            this.cmbDetailsTransactionTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDetailsTransactionTypeFilter.FormattingEnabled = true;
            this.cmbDetailsTransactionTypeFilter.Location = new System.Drawing.Point(75, 39);
            this.cmbDetailsTransactionTypeFilter.Name = "cmbDetailsTransactionTypeFilter";
            this.cmbDetailsTransactionTypeFilter.Size = new System.Drawing.Size(120, 21);
            this.cmbDetailsTransactionTypeFilter.TabIndex = 5;
            // 
            // lblDetailsFilterType
            // 
            this.lblDetailsFilterType.AutoSize = true;
            this.lblDetailsFilterType.Location = new System.Drawing.Point(10, 42);
            this.lblDetailsFilterType.Name = "lblDetailsFilterType";
            this.lblDetailsFilterType.Size = new System.Drawing.Size(29, 13);
            this.lblDetailsFilterType.TabIndex = 4;
            this.lblDetailsFilterType.Text = "Тип:";
            // 
            // dtpDetailsEndDate
            // 
            this.dtpDetailsEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDetailsEndDate.Location = new System.Drawing.Point(275, 8);
            this.dtpDetailsEndDate.Name = "dtpDetailsEndDate";
            this.dtpDetailsEndDate.ShowCheckBox = true;
            this.dtpDetailsEndDate.Size = new System.Drawing.Size(120, 20);
            this.dtpDetailsEndDate.TabIndex = 3;
            // 
            // lblDetailsFilterEndDate
            // 
            this.lblDetailsFilterEndDate.AutoSize = true;
            this.lblDetailsFilterEndDate.Location = new System.Drawing.Point(215, 12);
            this.lblDetailsFilterEndDate.Name = "lblDetailsFilterEndDate";
            this.lblDetailsFilterEndDate.Size = new System.Drawing.Size(51, 13);
            this.lblDetailsFilterEndDate.TabIndex = 2;
            this.lblDetailsFilterEndDate.Text = "Дата до:";
            // 
            // dtpDetailsStartDate
            // 
            this.dtpDetailsStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDetailsStartDate.Location = new System.Drawing.Point(75, 8);
            this.dtpDetailsStartDate.Name = "dtpDetailsStartDate";
            this.dtpDetailsStartDate.ShowCheckBox = true;
            this.dtpDetailsStartDate.Size = new System.Drawing.Size(120, 20);
            this.dtpDetailsStartDate.TabIndex = 1;
            // 
            // lblDetailsFilterStartDate
            // 
            this.lblDetailsFilterStartDate.AutoSize = true;
            this.lblDetailsFilterStartDate.Location = new System.Drawing.Point(10, 12);
            this.lblDetailsFilterStartDate.Name = "lblDetailsFilterStartDate";
            this.lblDetailsFilterStartDate.Size = new System.Drawing.Size(50, 13);
            this.lblDetailsFilterStartDate.TabIndex = 0;
            this.lblDetailsFilterStartDate.Text = "Дата от:";
            // 
            // listBoxTransactions
            // 
            this.listBoxTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTransactions.FormattingEnabled = true;
            this.listBoxTransactions.IntegralHeight = false;
            this.listBoxTransactions.Location = new System.Drawing.Point(0, 125);
            this.listBoxTransactions.Name = "listBoxTransactions";
            this.listBoxTransactions.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxTransactions.Size = new System.Drawing.Size(584, 236);
            this.listBoxTransactions.TabIndex = 2;
            // 
            // btnRemoveSelectedTransaction
            // 
            this.btnRemoveSelectedTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveSelectedTransaction.Location = new System.Drawing.Point(16, 327);
            this.btnRemoveSelectedTransaction.Name = "btnRemoveSelectedTransaction";
            this.btnRemoveSelectedTransaction.Size = new System.Drawing.Size(160, 23);
            this.btnRemoveSelectedTransaction.TabIndex = 3;
            this.btnRemoveSelectedTransaction.Text = "Remove Selected Transaction(s)";
            this.btnRemoveSelectedTransaction.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedTransaction.Click += new System.EventHandler(this.BtnRemoveSelectedTransaction_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteAccount.Location = new System.Drawing.Point(366, 327);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteAccount.TabIndex = 4;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.BtnDeleteAccount_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(482, 327);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // AccountDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.listBoxTransactions);
            this.Controls.Add(this.panelDetailsFilters);
            this.Controls.Add(this.lblTransactions);
            this.Controls.Add(this.lblAccountNameBalance);
            this.Controls.Add(this.btnRemoveSelectedTransaction);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnClose);
            this.MinimizeBox = false;
            this.Name = "AccountDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Account Details";
            this.Load += new System.EventHandler(this.AccountDetailsForm_Load);
            this.panelDetailsFilters.ResumeLayout(false);
            this.panelDetailsFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountNameBalance; // Renamed
        private System.Windows.Forms.Label lblTransactions;
        private System.Windows.Forms.ListBox listBoxTransactions;
        private System.Windows.Forms.Button btnRemoveSelectedTransaction;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelDetailsFilters; // New Panel for filters
        private System.Windows.Forms.Label lblDetailsFilterStartDate;
        private System.Windows.Forms.DateTimePicker dtpDetailsStartDate;
        private System.Windows.Forms.Label lblDetailsFilterEndDate;
        private System.Windows.Forms.DateTimePicker dtpDetailsEndDate;
        private System.Windows.Forms.Label lblDetailsFilterType;
        private System.Windows.Forms.ComboBox cmbDetailsTransactionTypeFilter;
        private System.Windows.Forms.Button btnDetailsApplyFilters;
        private System.Windows.Forms.Button btnDetailsClearFilters;
    }
}