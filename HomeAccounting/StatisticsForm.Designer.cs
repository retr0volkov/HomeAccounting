namespace HomeAccounting
{
    partial class StatisticsForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tableLayoutPanelStats = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalBalanceTitle = new System.Windows.Forms.Label();
            this.lblTotalBalanceValue = new System.Windows.Forms.Label();
            this.lblTotalTransactionsTitle = new System.Windows.Forms.Label();
            this.lblTotalTransactionsValue = new System.Windows.Forms.Label();
            this.lblIncomeTransactionsTitle = new System.Windows.Forms.Label();
            this.lblIncomeTransactionsValue = new System.Windows.Forms.Label();
            this.lblExpenseTransactionsTitle = new System.Windows.Forms.Label();
            this.lblExpenseTransactionsValue = new System.Windows.Forms.Label();
            this.lblLargestIncomeTitle = new System.Windows.Forms.Label();
            this.lblLargestIncomeValue = new System.Windows.Forms.Label();
            this.lblLargestExpenseTitle = new System.Windows.Forms.Label();
            this.lblLargestExpenseValue = new System.Windows.Forms.Label();
            this.lblAccountSummariesTitle = new System.Windows.Forms.Label();
            this.dataGridViewAccountSummaries = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccountSummaries)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(235, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Финансовая Статистика";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(597, 426);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelStats
            // 
            this.tableLayoutPanelStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelStats.ColumnCount = 2;
            this.tableLayoutPanelStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelStats.Controls.Add(this.lblTotalBalanceTitle, 0, 0);
            this.tableLayoutPanelStats.Controls.Add(this.lblTotalBalanceValue, 1, 0);
            this.tableLayoutPanelStats.Controls.Add(this.lblTotalTransactionsTitle, 0, 1);
            this.tableLayoutPanelStats.Controls.Add(this.lblTotalTransactionsValue, 1, 1);
            this.tableLayoutPanelStats.Controls.Add(this.lblIncomeTransactionsTitle, 0, 2);
            this.tableLayoutPanelStats.Controls.Add(this.lblIncomeTransactionsValue, 1, 2);
            this.tableLayoutPanelStats.Controls.Add(this.lblExpenseTransactionsTitle, 0, 3);
            this.tableLayoutPanelStats.Controls.Add(this.lblExpenseTransactionsValue, 1, 3);
            this.tableLayoutPanelStats.Controls.Add(this.lblLargestIncomeTitle, 0, 4);
            this.tableLayoutPanelStats.Controls.Add(this.lblLargestIncomeValue, 1, 4);
            this.tableLayoutPanelStats.Controls.Add(this.lblLargestExpenseTitle, 0, 5);
            this.tableLayoutPanelStats.Controls.Add(this.lblLargestExpenseValue, 1, 5);
            this.tableLayoutPanelStats.Controls.Add(this.lblAccountSummariesTitle, 0, 6);
            this.tableLayoutPanelStats.Controls.Add(this.dataGridViewAccountSummaries, 0, 7);
            this.tableLayoutPanelStats.Location = new System.Drawing.Point(17, 45);
            this.tableLayoutPanelStats.Name = "tableLayoutPanelStats";
            this.tableLayoutPanelStats.RowCount = 8;
            this.tableLayoutPanelStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelStats.Size = new System.Drawing.Size(655, 375);
            this.tableLayoutPanelStats.TabIndex = 3;
            // 
            // lblTotalBalanceTitle
            // 
            this.lblTotalBalanceTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalBalanceTitle.AutoSize = true;
            this.lblTotalBalanceTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalanceTitle.Location = new System.Drawing.Point(3, 6);
            this.lblTotalBalanceTitle.Name = "lblTotalBalanceTitle";
            this.lblTotalBalanceTitle.Size = new System.Drawing.Size(175, 17);
            this.lblTotalBalanceTitle.TabIndex = 0;
            this.lblTotalBalanceTitle.Text = "Полный Баланс (Все Акк):";
            // 
            // lblTotalBalanceValue
            // 
            this.lblTotalBalanceValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalBalanceValue.AutoSize = true;
            this.lblTotalBalanceValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalanceValue.Location = new System.Drawing.Point(203, 6);
            this.lblTotalBalanceValue.Name = "lblTotalBalanceValue";
            this.lblTotalBalanceValue.Size = new System.Drawing.Size(15, 17);
            this.lblTotalBalanceValue.TabIndex = 1;
            this.lblTotalBalanceValue.Text = "0";
            // 
            // lblTotalTransactionsTitle
            // 
            this.lblTotalTransactionsTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalTransactionsTitle.AutoSize = true;
            this.lblTotalTransactionsTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTransactionsTitle.Location = new System.Drawing.Point(3, 36);
            this.lblTotalTransactionsTitle.Name = "lblTotalTransactionsTitle";
            this.lblTotalTransactionsTitle.Size = new System.Drawing.Size(124, 17);
            this.lblTotalTransactionsTitle.TabIndex = 2;
            this.lblTotalTransactionsTitle.Text = "Всего Транзакций:";
            // 
            // lblTotalTransactionsValue
            // 
            this.lblTotalTransactionsValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalTransactionsValue.AutoSize = true;
            this.lblTotalTransactionsValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTransactionsValue.Location = new System.Drawing.Point(203, 36);
            this.lblTotalTransactionsValue.Name = "lblTotalTransactionsValue";
            this.lblTotalTransactionsValue.Size = new System.Drawing.Size(15, 17);
            this.lblTotalTransactionsValue.TabIndex = 3;
            this.lblTotalTransactionsValue.Text = "0";
            // 
            // lblIncomeTransactionsTitle
            // 
            this.lblIncomeTransactionsTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIncomeTransactionsTitle.AutoSize = true;
            this.lblIncomeTransactionsTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomeTransactionsTitle.Location = new System.Drawing.Point(3, 66);
            this.lblIncomeTransactionsTitle.Name = "lblIncomeTransactionsTitle";
            this.lblIncomeTransactionsTitle.Size = new System.Drawing.Size(138, 17);
            this.lblIncomeTransactionsTitle.TabIndex = 4;
            this.lblIncomeTransactionsTitle.Text = "Транзакций Дохода:";
            // 
            // lblIncomeTransactionsValue
            // 
            this.lblIncomeTransactionsValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIncomeTransactionsValue.AutoSize = true;
            this.lblIncomeTransactionsValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomeTransactionsValue.Location = new System.Drawing.Point(203, 66);
            this.lblIncomeTransactionsValue.Name = "lblIncomeTransactionsValue";
            this.lblIncomeTransactionsValue.Size = new System.Drawing.Size(15, 17);
            this.lblIncomeTransactionsValue.TabIndex = 5;
            this.lblIncomeTransactionsValue.Text = "0";
            // 
            // lblExpenseTransactionsTitle
            // 
            this.lblExpenseTransactionsTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblExpenseTransactionsTitle.AutoSize = true;
            this.lblExpenseTransactionsTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseTransactionsTitle.Location = new System.Drawing.Point(3, 96);
            this.lblExpenseTransactionsTitle.Name = "lblExpenseTransactionsTitle";
            this.lblExpenseTransactionsTitle.Size = new System.Drawing.Size(141, 17);
            this.lblExpenseTransactionsTitle.TabIndex = 6;
            this.lblExpenseTransactionsTitle.Text = "Транзакций Расхода:";
            // 
            // lblExpenseTransactionsValue
            // 
            this.lblExpenseTransactionsValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblExpenseTransactionsValue.AutoSize = true;
            this.lblExpenseTransactionsValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseTransactionsValue.Location = new System.Drawing.Point(203, 96);
            this.lblExpenseTransactionsValue.Name = "lblExpenseTransactionsValue";
            this.lblExpenseTransactionsValue.Size = new System.Drawing.Size(15, 17);
            this.lblExpenseTransactionsValue.TabIndex = 7;
            this.lblExpenseTransactionsValue.Text = "0";
            // 
            // lblLargestIncomeTitle
            // 
            this.lblLargestIncomeTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLargestIncomeTitle.AutoSize = true;
            this.lblLargestIncomeTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLargestIncomeTitle.Location = new System.Drawing.Point(3, 126);
            this.lblLargestIncomeTitle.Name = "lblLargestIncomeTitle";
            this.lblLargestIncomeTitle.Size = new System.Drawing.Size(138, 17);
            this.lblLargestIncomeTitle.TabIndex = 8;
            this.lblLargestIncomeTitle.Text = "Крупнейший Доход:";
            // 
            // lblLargestIncomeValue
            // 
            this.lblLargestIncomeValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLargestIncomeValue.AutoSize = true;
            this.lblLargestIncomeValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLargestIncomeValue.Location = new System.Drawing.Point(203, 126);
            this.lblLargestIncomeValue.Name = "lblLargestIncomeValue";
            this.lblLargestIncomeValue.Size = new System.Drawing.Size(31, 17);
            this.lblLargestIncomeValue.TabIndex = 9;
            this.lblLargestIncomeValue.Text = "N/A";
            // 
            // lblLargestExpenseTitle
            // 
            this.lblLargestExpenseTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLargestExpenseTitle.AutoSize = true;
            this.lblLargestExpenseTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLargestExpenseTitle.Location = new System.Drawing.Point(3, 156);
            this.lblLargestExpenseTitle.Name = "lblLargestExpenseTitle";
            this.lblLargestExpenseTitle.Size = new System.Drawing.Size(141, 17);
            this.lblLargestExpenseTitle.TabIndex = 10;
            this.lblLargestExpenseTitle.Text = "Крупнейший Расход:";
            // 
            // lblLargestExpenseValue
            // 
            this.lblLargestExpenseValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLargestExpenseValue.AutoSize = true;
            this.lblLargestExpenseValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLargestExpenseValue.Location = new System.Drawing.Point(203, 156);
            this.lblLargestExpenseValue.Name = "lblLargestExpenseValue";
            this.lblLargestExpenseValue.Size = new System.Drawing.Size(31, 17);
            this.lblLargestExpenseValue.TabIndex = 11;
            this.lblLargestExpenseValue.Text = "N/A";
            // 
            // lblAccountSummariesTitle
            // 
            this.lblAccountSummariesTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAccountSummariesTitle.AutoSize = true;
            this.tableLayoutPanelStats.SetColumnSpan(this.lblAccountSummariesTitle, 2);
            this.lblAccountSummariesTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountSummariesTitle.Location = new System.Drawing.Point(3, 185);
            this.lblAccountSummariesTitle.Name = "lblAccountSummariesTitle";
            this.lblAccountSummariesTitle.Size = new System.Drawing.Size(170, 20);
            this.lblAccountSummariesTitle.TabIndex = 12;
            this.lblAccountSummariesTitle.Text = "Сводка по Аккаунтам:";
            // 
            // dataGridViewAccountSummaries
            // 
            this.dataGridViewAccountSummaries.AllowUserToAddRows = false;
            this.dataGridViewAccountSummaries.AllowUserToDeleteRows = false;
            this.dataGridViewAccountSummaries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAccountSummaries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAccountSummaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanelStats.SetColumnSpan(this.dataGridViewAccountSummaries, 2);
            this.dataGridViewAccountSummaries.Location = new System.Drawing.Point(3, 213);
            this.dataGridViewAccountSummaries.Name = "dataGridViewAccountSummaries";
            this.dataGridViewAccountSummaries.ReadOnly = true;
            this.dataGridViewAccountSummaries.RowHeadersVisible = false;
            this.dataGridViewAccountSummaries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAccountSummaries.Size = new System.Drawing.Size(649, 159);
            this.dataGridViewAccountSummaries.TabIndex = 13;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.tableLayoutPanelStats);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "StatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Финансовая Статистика";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.tableLayoutPanelStats.ResumeLayout(false);
            this.tableLayoutPanelStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccountSummaries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStats;
        private System.Windows.Forms.Label lblTotalBalanceTitle;
        private System.Windows.Forms.Label lblTotalBalanceValue;
        private System.Windows.Forms.Label lblTotalTransactionsTitle;
        private System.Windows.Forms.Label lblTotalTransactionsValue;
        private System.Windows.Forms.Label lblIncomeTransactionsTitle;
        private System.Windows.Forms.Label lblIncomeTransactionsValue;
        private System.Windows.Forms.Label lblExpenseTransactionsTitle;
        private System.Windows.Forms.Label lblExpenseTransactionsValue;
        private System.Windows.Forms.DataGridView dataGridViewAccountSummaries;
        private System.Windows.Forms.Label lblAccountSummariesTitle;
        private System.Windows.Forms.Label lblLargestIncomeTitle;
        private System.Windows.Forms.Label lblLargestIncomeValue;
        private System.Windows.Forms.Label lblLargestExpenseTitle;
        private System.Windows.Forms.Label lblLargestExpenseValue;
    }
}