using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAccounting
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            LoadAllStatistics();
        }

        private void LoadAllStatistics()
        {
            // 1. Total Balance
            decimal totalBalance = DatabaseHelper.GetTotalBalanceForAllAccounts();
            lblTotalBalanceValue.Text = totalBalance.ToString("C", CultureInfo.CreateSpecificCulture("ru-RU"));

            // 2. Transaction Counts
            var counts = DatabaseHelper.GetTransactionCounts();
            lblTotalTransactionsValue.Text = counts.Item1.ToString();   // Total
            lblIncomeTransactionsValue.Text = counts.Item2.ToString();  // Income
            lblExpenseTransactionsValue.Text = counts.Item3.ToString(); // Expense

            // 3. Largest Income Transaction
            List<TransactionDisplayItem> largestIncomeList = DatabaseHelper.GetLargestTransactions(true, 1); // true for income
            if (largestIncomeList.Any())
            {
                TransactionDisplayItem largestIncome = largestIncomeList.First();
                lblLargestIncomeValue.Text = $"{largestIncome.Amount.ToString("C", CultureInfo.CreateSpecificCulture("ru-RU"))} (Акк: {largestIncome.AccountName}, Дата: {largestIncome.TransactionDate:dd.MM.yyyy})";
            }
            else
            {
                lblLargestIncomeValue.Text = "N/A";
            }

            // 4. Largest Expense Transaction
            List<TransactionDisplayItem> largestExpenseList = DatabaseHelper.GetLargestTransactions(false, 1); // false for expense
            if (largestExpenseList.Any())
            {
                TransactionDisplayItem largestExpense = largestExpenseList.First();
                lblLargestExpenseValue.Text = $"{(-largestExpense.Amount).ToString("C", CultureInfo.CreateSpecificCulture("ru-RU"))} (Акк: {largestExpense.AccountName}, Дата: {largestExpense.TransactionDate:dd.MM.yyyy})";
            }
            else
            {
                lblLargestExpenseValue.Text = "N/A";
            }


            // 5. Account Summaries (Income, Expense, Net)
            DataTable accountSummaries = DatabaseHelper.GetAccountIncomeExpenseSummary();
            DataTable displaySummaries = new DataTable();
            displaySummaries.Columns.Add("Имя Аккаунта", typeof(string));
            displaySummaries.Columns.Add("Всего Доход", typeof(decimal));
            displaySummaries.Columns.Add("Всего Расход", typeof(decimal));
            displaySummaries.Columns.Add("Общая Сумма", typeof(decimal));

            foreach (DataRow row in accountSummaries.Rows)
            {
                string accName = row["AccountName"].ToString();
                decimal income = Convert.ToDecimal(row["TotalIncome"]);
                decimal expenses = Convert.ToDecimal(row["TotalExpenses"]);
                displaySummaries.Rows.Add(accName, income, expenses, income - expenses);
            }

            dataGridViewAccountSummaries.DataSource = displaySummaries;
            CultureInfo Culture = CultureInfo.CreateSpecificCulture("ru-RU");
            dataGridViewAccountSummaries.Columns[1].DefaultCellStyle.FormatProvider = Culture;
            dataGridViewAccountSummaries.Columns[1].DefaultCellStyle.Format = "C";
            dataGridViewAccountSummaries.Columns[2].DefaultCellStyle.FormatProvider = Culture;
            dataGridViewAccountSummaries.Columns[2].DefaultCellStyle.Format = "C";
            dataGridViewAccountSummaries.Columns[3].DefaultCellStyle.FormatProvider = Culture;
            dataGridViewAccountSummaries.Columns[3].DefaultCellStyle.Format = "C";

            if (dataGridViewAccountSummaries.Rows.Count > 0)
            {
                dataGridViewAccountSummaries.ClearSelection();
            }
        }
    }

}
