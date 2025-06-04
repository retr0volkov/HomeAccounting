namespace HomeAccounting
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerOuter = new System.Windows.Forms.SplitContainer();
            this.splitContainerLeftAndMain = new System.Windows.Forms.SplitContainer();
            this.lblAccounts = new System.Windows.Forms.Label();
            this.listBoxAccounts = new System.Windows.Forms.ListBox();
            this.listBoxAllTransactions = new System.Windows.Forms.ListBox();
            this.panelMainFilters = new System.Windows.Forms.Panel();
            this.btnMainClearFilters = new System.Windows.Forms.Button();
            this.btnMainApplyFilters = new System.Windows.Forms.Button();
            this.cmbMainTransactionTypeFilter = new System.Windows.Forms.ComboBox();
            this.lblMainFilterType = new System.Windows.Forms.Label();
            this.dtpMainEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblMainFilterEndDate = new System.Windows.Forms.Label();
            this.dtpMainStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblMainFilterStartDate = new System.Windows.Forms.Label();
            this.lblAllTransactions = new System.Windows.Forms.Label();
            this.lblChartOverview = new System.Windows.Forms.Label();
            this.chartBalanceOverview = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.руководствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOuter)).BeginInit();
            this.splitContainerOuter.Panel1.SuspendLayout();
            this.splitContainerOuter.Panel2.SuspendLayout();
            this.splitContainerOuter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeftAndMain)).BeginInit();
            this.splitContainerLeftAndMain.Panel1.SuspendLayout();
            this.splitContainerLeftAndMain.Panel2.SuspendLayout();
            this.splitContainerLeftAndMain.SuspendLayout();
            this.panelMainFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBalanceOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1119, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAccountToolStripMenuItem,
            this.addTransactionToolStripMenuItem,
            this.viewStatisticsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // addAccountToolStripMenuItem
            // 
            this.addAccountToolStripMenuItem.Name = "addAccountToolStripMenuItem";
            this.addAccountToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.addAccountToolStripMenuItem.Text = "Добавить Аккаунт...";
            this.addAccountToolStripMenuItem.Click += new System.EventHandler(this.AddAccountToolStripMenuItem_Click);
            // 
            // addTransactionToolStripMenuItem
            // 
            this.addTransactionToolStripMenuItem.Name = "addTransactionToolStripMenuItem";
            this.addTransactionToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.addTransactionToolStripMenuItem.Text = "Добавить Транзакцию...";
            this.addTransactionToolStripMenuItem.Click += new System.EventHandler(this.AddTransactionToolStripMenuItem_Click);
            // 
            // viewStatisticsToolStripMenuItem
            // 
            this.viewStatisticsToolStripMenuItem.Name = "viewStatisticsToolStripMenuItem";
            this.viewStatisticsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.viewStatisticsToolStripMenuItem.Text = "Статистика...";
            this.viewStatisticsToolStripMenuItem.Click += new System.EventHandler(this.ViewStatisticsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // splitContainerOuter
            // 
            this.splitContainerOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerOuter.Location = new System.Drawing.Point(0, 24);
            this.splitContainerOuter.Name = "splitContainerOuter";
            // 
            // splitContainerOuter.Panel1
            // 
            this.splitContainerOuter.Panel1.Controls.Add(this.splitContainerLeftAndMain);
            // 
            // splitContainerOuter.Panel2
            // 
            this.splitContainerOuter.Panel2.Controls.Add(this.lblChartOverview);
            this.splitContainerOuter.Panel2.Controls.Add(this.chartBalanceOverview);
            this.splitContainerOuter.Size = new System.Drawing.Size(1119, 537);
            this.splitContainerOuter.SplitterDistance = 670;
            this.splitContainerOuter.TabIndex = 1;
            // 
            // splitContainerLeftAndMain
            // 
            this.splitContainerLeftAndMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLeftAndMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLeftAndMain.Name = "splitContainerLeftAndMain";
            // 
            // splitContainerLeftAndMain.Panel1
            // 
            this.splitContainerLeftAndMain.Panel1.Controls.Add(this.lblAccounts);
            this.splitContainerLeftAndMain.Panel1.Controls.Add(this.listBoxAccounts);
            this.splitContainerLeftAndMain.Panel1MinSize = 200;
            // 
            // splitContainerLeftAndMain.Panel2
            // 
            this.splitContainerLeftAndMain.Panel2.Controls.Add(this.listBoxAllTransactions);
            this.splitContainerLeftAndMain.Panel2.Controls.Add(this.panelMainFilters);
            this.splitContainerLeftAndMain.Panel2.Controls.Add(this.lblAllTransactions);
            this.splitContainerLeftAndMain.Panel2MinSize = 350;
            this.splitContainerLeftAndMain.Size = new System.Drawing.Size(670, 537);
            this.splitContainerLeftAndMain.SplitterDistance = 226;
            this.splitContainerLeftAndMain.TabIndex = 0;
            // 
            // lblAccounts
            // 
            this.lblAccounts.AutoSize = true;
            this.lblAccounts.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccounts.Location = new System.Drawing.Point(12, 10);
            this.lblAccounts.Name = "lblAccounts";
            this.lblAccounts.Size = new System.Drawing.Size(63, 17);
            this.lblAccounts.TabIndex = 1;
            this.lblAccounts.Text = "Аккаунт:";
            // 
            // listBoxAccounts
            // 
            this.listBoxAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxAccounts.FormattingEnabled = true;
            this.listBoxAccounts.IntegralHeight = false;
            this.listBoxAccounts.ItemHeight = 15;
            this.listBoxAccounts.Location = new System.Drawing.Point(12, 30);
            this.listBoxAccounts.Name = "listBoxAccounts";
            this.listBoxAccounts.Size = new System.Drawing.Size(206, 495);
            this.listBoxAccounts.TabIndex = 0;
            this.listBoxAccounts.DoubleClick += new System.EventHandler(this.ListBoxAccounts_DoubleClick);
            // 
            // listBoxAllTransactions
            // 
            this.listBoxAllTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxAllTransactions.FormattingEnabled = true;
            this.listBoxAllTransactions.IntegralHeight = false;
            this.listBoxAllTransactions.ItemHeight = 15;
            this.listBoxAllTransactions.Location = new System.Drawing.Point(0, 97);
            this.listBoxAllTransactions.Name = "listBoxAllTransactions";
            this.listBoxAllTransactions.Size = new System.Drawing.Size(440, 440);
            this.listBoxAllTransactions.TabIndex = 0;
            // 
            // panelMainFilters
            // 
            this.panelMainFilters.Controls.Add(this.btnMainClearFilters);
            this.panelMainFilters.Controls.Add(this.btnMainApplyFilters);
            this.panelMainFilters.Controls.Add(this.cmbMainTransactionTypeFilter);
            this.panelMainFilters.Controls.Add(this.lblMainFilterType);
            this.panelMainFilters.Controls.Add(this.dtpMainEndDate);
            this.panelMainFilters.Controls.Add(this.lblMainFilterEndDate);
            this.panelMainFilters.Controls.Add(this.dtpMainStartDate);
            this.panelMainFilters.Controls.Add(this.lblMainFilterStartDate);
            this.panelMainFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainFilters.Location = new System.Drawing.Point(0, 27);
            this.panelMainFilters.Name = "panelMainFilters";
            this.panelMainFilters.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.panelMainFilters.Size = new System.Drawing.Size(440, 70);
            this.panelMainFilters.TabIndex = 2;
            // 
            // btnMainClearFilters
            // 
            this.btnMainClearFilters.Location = new System.Drawing.Point(330, 38);
            this.btnMainClearFilters.Name = "btnMainClearFilters";
            this.btnMainClearFilters.Size = new System.Drawing.Size(85, 23);
            this.btnMainClearFilters.TabIndex = 7;
            this.btnMainClearFilters.Text = "Очистить";
            this.btnMainClearFilters.UseVisualStyleBackColor = true;
            this.btnMainClearFilters.Click += new System.EventHandler(this.BtnMainClearFilters_Click);
            // 
            // btnMainApplyFilters
            // 
            this.btnMainApplyFilters.Location = new System.Drawing.Point(240, 38);
            this.btnMainApplyFilters.Name = "btnMainApplyFilters";
            this.btnMainApplyFilters.Size = new System.Drawing.Size(85, 23);
            this.btnMainApplyFilters.TabIndex = 6;
            this.btnMainApplyFilters.Text = "Применить";
            this.btnMainApplyFilters.UseVisualStyleBackColor = true;
            this.btnMainApplyFilters.Click += new System.EventHandler(this.BtnMainApplyFilters_Click);
            // 
            // cmbMainTransactionTypeFilter
            // 
            this.cmbMainTransactionTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMainTransactionTypeFilter.FormattingEnabled = true;
            this.cmbMainTransactionTypeFilter.Location = new System.Drawing.Point(75, 39);
            this.cmbMainTransactionTypeFilter.Name = "cmbMainTransactionTypeFilter";
            this.cmbMainTransactionTypeFilter.Size = new System.Drawing.Size(140, 23);
            this.cmbMainTransactionTypeFilter.TabIndex = 5;
            // 
            // lblMainFilterType
            // 
            this.lblMainFilterType.AutoSize = true;
            this.lblMainFilterType.Location = new System.Drawing.Point(10, 42);
            this.lblMainFilterType.Name = "lblMainFilterType";
            this.lblMainFilterType.Size = new System.Drawing.Size(31, 15);
            this.lblMainFilterType.TabIndex = 4;
            this.lblMainFilterType.Text = "Тип:";
            // 
            // dtpMainEndDate
            // 
            this.dtpMainEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMainEndDate.Location = new System.Drawing.Point(275, 8);
            this.dtpMainEndDate.Name = "dtpMainEndDate";
            this.dtpMainEndDate.ShowCheckBox = true;
            this.dtpMainEndDate.Size = new System.Drawing.Size(140, 23);
            this.dtpMainEndDate.TabIndex = 3;
            // 
            // lblMainFilterEndDate
            // 
            this.lblMainFilterEndDate.AutoSize = true;
            this.lblMainFilterEndDate.Location = new System.Drawing.Point(215, 12);
            this.lblMainFilterEndDate.Name = "lblMainFilterEndDate";
            this.lblMainFilterEndDate.Size = new System.Drawing.Size(51, 15);
            this.lblMainFilterEndDate.TabIndex = 2;
            this.lblMainFilterEndDate.Text = "Дата до:";
            // 
            // dtpMainStartDate
            // 
            this.dtpMainStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMainStartDate.Location = new System.Drawing.Point(75, 8);
            this.dtpMainStartDate.Name = "dtpMainStartDate";
            this.dtpMainStartDate.ShowCheckBox = true;
            this.dtpMainStartDate.Size = new System.Drawing.Size(140, 23);
            this.dtpMainStartDate.TabIndex = 1;
            // 
            // lblMainFilterStartDate
            // 
            this.lblMainFilterStartDate.AutoSize = true;
            this.lblMainFilterStartDate.Location = new System.Drawing.Point(10, 12);
            this.lblMainFilterStartDate.Name = "lblMainFilterStartDate";
            this.lblMainFilterStartDate.Size = new System.Drawing.Size(50, 15);
            this.lblMainFilterStartDate.TabIndex = 0;
            this.lblMainFilterStartDate.Text = "Дата от:";
            // 
            // lblAllTransactions
            // 
            this.lblAllTransactions.AutoSize = true;
            this.lblAllTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAllTransactions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllTransactions.Location = new System.Drawing.Point(0, 0);
            this.lblAllTransactions.Name = "lblAllTransactions";
            this.lblAllTransactions.Padding = new System.Windows.Forms.Padding(12, 10, 0, 0);
            this.lblAllTransactions.Size = new System.Drawing.Size(122, 27);
            this.lblAllTransactions.TabIndex = 1;
            this.lblAllTransactions.Text = "Все транзакции:";
            // 
            // lblChartOverview
            // 
            this.lblChartOverview.AutoSize = true;
            this.lblChartOverview.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChartOverview.Location = new System.Drawing.Point(13, 10);
            this.lblChartOverview.Name = "lblChartOverview";
            this.lblChartOverview.Size = new System.Drawing.Size(203, 17);
            this.lblChartOverview.TabIndex = 2;
            this.lblChartOverview.Text = "Доход и расход по аккаунтам:";
            // 
            // chartBalanceOverview
            // 
            this.chartBalanceOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.LabelAutoFitStyle = System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep90;
            chartArea2.Name = "ChartArea1";
            this.chartBalanceOverview.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartBalanceOverview.Legends.Add(legend2);
            this.chartBalanceOverview.Location = new System.Drawing.Point(16, 30);
            this.chartBalanceOverview.Name = "chartBalanceOverview";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Green;
            series3.Legend = "Legend1";
            series3.Name = "Доходы";
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "Расходы";
            this.chartBalanceOverview.Series.Add(series3);
            this.chartBalanceOverview.Series.Add(series4);
            this.chartBalanceOverview.Size = new System.Drawing.Size(415, 495);
            this.chartBalanceOverview.TabIndex = 1;
            this.chartBalanceOverview.Text = "chart1";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.руководствоToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "О Программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // руководствоToolStripMenuItem
            // 
            this.руководствоToolStripMenuItem.Name = "руководствоToolStripMenuItem";
            this.руководствоToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.руководствоToolStripMenuItem.Text = "Руководство";
            this.руководствоToolStripMenuItem.Click += new System.EventHandler(this.руководствоToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 561);
            this.Controls.Add(this.splitContainerOuter);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.Text = "Home Accounting";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.splitContainerOuter.Panel1.ResumeLayout(false);
            this.splitContainerOuter.Panel2.ResumeLayout(false);
            this.splitContainerOuter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOuter)).EndInit();
            this.splitContainerOuter.ResumeLayout(false);
            this.splitContainerLeftAndMain.Panel1.ResumeLayout(false);
            this.splitContainerLeftAndMain.Panel1.PerformLayout();
            this.splitContainerLeftAndMain.Panel2.ResumeLayout(false);
            this.splitContainerLeftAndMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeftAndMain)).EndInit();
            this.splitContainerLeftAndMain.ResumeLayout(false);
            this.panelMainFilters.ResumeLayout(false);
            this.panelMainFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBalanceOverview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxAccounts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBalanceOverview;
        private System.Windows.Forms.Label lblAccounts;
        private System.Windows.Forms.Label lblChartOverview;
        private System.Windows.Forms.SplitContainer splitContainerOuter;
        private System.Windows.Forms.SplitContainer splitContainerLeftAndMain;
        private System.Windows.Forms.ListBox listBoxAllTransactions;
        private System.Windows.Forms.Label lblAllTransactions;
        private System.Windows.Forms.Panel panelMainFilters; // New Panel for filters
        private System.Windows.Forms.Label lblMainFilterStartDate;
        private System.Windows.Forms.DateTimePicker dtpMainStartDate;
        private System.Windows.Forms.Label lblMainFilterEndDate;
        private System.Windows.Forms.DateTimePicker dtpMainEndDate;
        private System.Windows.Forms.Label lblMainFilterType;
        private System.Windows.Forms.ComboBox cmbMainTransactionTypeFilter;
        private System.Windows.Forms.Button btnMainApplyFilters;
        private System.Windows.Forms.Button btnMainClearFilters;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem руководствоToolStripMenuItem;
    }
}