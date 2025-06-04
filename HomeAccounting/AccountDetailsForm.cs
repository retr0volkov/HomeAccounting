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
    public partial class AccountDetailsForm : Form
    {
        private readonly Dictionary<string, string> _transactionTypeFilterMap = new Dictionary<string, string>
        {
            { "Все", "All" },
            { "Доходы", "Income" },
            { "Расходы", "Expense" }
        };

        private int _accountId;
        private Account _currentAccount;
        private MainForm _mainFormInstance;

        public AccountDetailsForm(int accountId, MainForm mainFormInstance)
        {
            InitializeComponent();
            _accountId = accountId;
            _mainFormInstance = mainFormInstance;
            InitializeDetailsFilters();
        }

        private void InitializeDetailsFilters()
        {
            cmbDetailsTransactionTypeFilter.Items.Add("Все");
            cmbDetailsTransactionTypeFilter.Items.Add("Доходы");
            cmbDetailsTransactionTypeFilter.Items.Add("Расходы");
            cmbDetailsTransactionTypeFilter.SelectedItem = "Все";

            dtpDetailsStartDate.Checked = false;
            dtpDetailsEndDate.Checked = false;
        }

        private void AccountDetailsForm_Load(object sender, EventArgs e)
        {
            LoadAccountDetails(); // This also calls ApplyDetailsFiltersAndLoadTransactions
        }

        private void LoadAccountDetails()
        {
            _currentAccount = DatabaseHelper.GetAccountById(_accountId);
            if (_currentAccount != null)
            {
                lblAccountNameBalance.Text = $"{_currentAccount.AccountName} (Баланс: {_currentAccount.CurrentBalance.ToString("C", new CultureInfo("ru-RU"))})";
                this.Text = $"Подробности {_currentAccount.AccountName}";
                ApplyDetailsFiltersAndLoadTransactions(); // Load transactions with current (default) filters
            }
            else
            {
                MessageBox.Show("Не удалось загрузить подробности аккаунта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        // Renamed and modified to use filter controls
        private void ApplyDetailsFiltersAndLoadTransactions()
        {
            if (_currentAccount == null) return; // Should not happen if LoadAccountDetails succeeded

            DateTime? startDate = dtpDetailsStartDate.Checked ? dtpDetailsStartDate.Value.Date : (DateTime?)null;
            DateTime? endDate = dtpDetailsEndDate.Checked ? dtpDetailsEndDate.Value.Date : (DateTime?)null;
            string transactionType = _transactionTypeFilterMap[cmbDetailsTransactionTypeFilter.SelectedItem?.ToString()] ?? "All";

            List<Transaction> transactions = DatabaseHelper.GetTransactionsForAccount(_accountId, startDate, endDate, transactionType);
            listBoxTransactions.DataSource = null;
            listBoxTransactions.DataSource = transactions;
        }

        private void BtnRemoveSelectedTransaction_Click(object sender, EventArgs e)
        {
            if (listBoxTransactions.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите транзакцию для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Вы уверены что хотите удалить {listBoxTransactions.SelectedItems.Count} транзакций? Это изменит баланс аккаунта.", "Подтвердить удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int successCount = 0;
                List<Transaction> itemsToRemove = new List<Transaction>();
                foreach (var item in listBoxTransactions.SelectedItems)
                {
                    itemsToRemove.Add((Transaction)item);
                }

                foreach (Transaction selectedTransaction in itemsToRemove)
                {
                    if (DatabaseHelper.DeleteTransaction(selectedTransaction.TransactionId))
                    {
                        successCount++;
                    }
                }
                MessageBox.Show($"{successCount} транзакций удалены.", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh everything: account balance display, transaction list, and main form data
                LoadAccountDetails(); // This reloads account info and re-applies filters to transaction list
                _mainFormInstance?.RefreshAllData();
            }
        }

        private void BtnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (_currentAccount == null) return;

            if (MessageBox.Show($"Вы уверены что хотите удалить аккаунт '{_currentAccount.AccountName}'?\nВсе связанные транзакции будут удалены.", "Подтвердить удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (DatabaseHelper.DeleteAccount(_accountId))
                {
                    MessageBox.Show("Account deleted successfully.", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _mainFormInstance?.RefreshAllData();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void BtnDetailsApplyFilters_Click(object sender, EventArgs e)
        {
            ApplyDetailsFiltersAndLoadTransactions();
        }

        private void BtnDetailsClearFilters_Click(object sender, EventArgs e)
        {
            dtpDetailsStartDate.Checked = false;
            dtpDetailsEndDate.Checked = false;
            cmbDetailsTransactionTypeFilter.SelectedItem = "Все";
            ApplyDetailsFiltersAndLoadTransactions();
        }
    }
}
