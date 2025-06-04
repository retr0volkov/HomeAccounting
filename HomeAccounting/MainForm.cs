using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAccounting
{
    public partial class MainForm : Form
    {
        private readonly Dictionary<string, string> _transactionTypeFilterMap = new Dictionary<string, string>
        {
            { "Все", "All" },
            { "Доходы", "Income" },
            { "Расходы", "Expense" }
        };

        public MainForm()
        {
            InitializeComponent();
            InitializeFilters();
            // Set initial splitter distances for better default layout
            splitContainerOuter.SplitterDistance = (int)(this.Width * 0.60); // Outer: 60% for lists, 40% for chart
            splitContainerLeftAndMain.SplitterDistance = (int)(splitContainerOuter.Panel1.Width * 0.40); // Inner: 40% for accounts, 60% for all transactions
        }

        private void InitializeFilters()
        {
            // Initialize ComboBox for transaction type filter
            cmbMainTransactionTypeFilter.Items.Add("Все");
            cmbMainTransactionTypeFilter.Items.Add("Доходы");
            cmbMainTransactionTypeFilter.Items.Add("Расходы");
            cmbMainTransactionTypeFilter.SelectedItem = "Все";

            // Set DateTimePickers to not have a date selected by default (unchecked)
            dtpMainStartDate.Checked = false;
            dtpMainEndDate.Checked = false;

            // Set default values (optional, e.g., start of month for start date)
            // dtpMainStartDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            // dtpMainEndDate.Value = DateTime.Now;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshAllData();
        }

        public void RefreshAllData()
        {
            LoadAccounts();
            ApplyMainFiltersAndLoadTransactions(); // This will load transactions based on current filter settings
            LoadChartData();
        }

        public void LoadAccounts()
        {
            List<Account> accounts = DatabaseHelper.GetAllAccounts();
            listBoxAccounts.DataSource = null;
            listBoxAccounts.DataSource = accounts;
        }

        public void ApplyMainFiltersAndLoadTransactions()
        {
            DateTime? startDate = dtpMainStartDate.Checked ? dtpMainStartDate.Value.Date : (DateTime?)null;
            DateTime? endDate = dtpMainEndDate.Checked ? dtpMainEndDate.Value.Date : (DateTime?)null;
            string transactionType = _transactionTypeFilterMap[cmbMainTransactionTypeFilter.SelectedItem?.ToString()] ?? "All";

            List<TransactionDisplayItem> transactions = DatabaseHelper.GetAllTransactionsWithAccountName(startDate, endDate, transactionType);
            listBoxAllTransactions.DataSource = null;
            listBoxAllTransactions.DataSource = transactions;
        }

        public void LoadChartData()
        {
            chartBalanceOverview.Series[0].Points.Clear();
            chartBalanceOverview.Series[1].Points.Clear();
            chartBalanceOverview.ChartAreas[0].AxisX.CustomLabels.Clear();

            DataTable accountSummaries = DatabaseHelper.GetAccountIncomeExpenseSummary();

            if (accountSummaries.Rows.Count > 0)
            {
                List<string> accountNames = new List<string>();
                for (int i = 0; i < accountSummaries.Rows.Count; i++)
                {
                    DataRow row = accountSummaries.Rows[i];
                    string accountName = row["AccountName"].ToString();
                    accountNames.Add(accountName);
                    decimal totalIncome = Convert.ToDecimal(row["TotalIncome"]);
                    decimal totalExpenses = Convert.ToDecimal(row["TotalExpenses"]);

                    chartBalanceOverview.Series[0].Points.AddXY(i + 1, totalIncome); // Use X value for positioning
                    chartBalanceOverview.Series[1].Points.AddXY(i + 1, totalExpenses);

                    // Add custom label for the X-axis
                    chartBalanceOverview.ChartAreas[0].AxisX.CustomLabels.Add(i + 0.5, i + 1.5, accountName);
                }
                chartBalanceOverview.ChartAreas[0].AxisX.LabelStyle.IsEndLabelVisible = true;
            }
            else
            {
                chartBalanceOverview.ChartAreas[0].AxisX.Title = "Нет данных об аккаунтах";
            }
            chartBalanceOverview.Invalidate();
        }

        private void AddAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddAccountForm addAccountForm = new AddAccountForm())
            {
                if (addAccountForm.ShowDialog() == DialogResult.OK)
                {
                    LoadAccounts(); // Refresh list
                }
            }
        }

        private void AddTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddTransactionForm addTransactionForm = new AddTransactionForm(this))
            {
                if (addTransactionForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshAllData(); // This will re-apply filters
                }
            }
        }

        private void ViewStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StatisticsForm statsForm = new StatisticsForm())
            {
                statsForm.ShowDialog();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ListBoxAccounts_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxAccounts.SelectedItem is Account selectedAccount)
            {
                using (AccountDetailsForm detailsForm = new AccountDetailsForm(selectedAccount.AccountId, this))
                {
                    detailsForm.ShowDialog();
                    RefreshAllData();
                }
            }
        }

        private void руководствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(".\\Руководство.html");
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Домашняя бухгалтерия.\nСоздал: Кознов М.Д. 22-КБ-ИВ1\nv.0.1");
        }

        private void BtnMainApplyFilters_Click(object sender, EventArgs e)
        {
            ApplyMainFiltersAndLoadTransactions();
        }

        private void BtnMainClearFilters_Click(object sender, EventArgs e)
        {
            dtpMainStartDate.Checked = false;
            dtpMainEndDate.Checked = false;
            // Optionally reset dates to some default if desired, e.g.:
            // dtpMainStartDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
            // dtpMainEndDate.Value = DateTime.Now;
            cmbMainTransactionTypeFilter.SelectedItem = "Все";
            ApplyMainFiltersAndLoadTransactions(); // Reload with cleared filters
        }
    }
}
