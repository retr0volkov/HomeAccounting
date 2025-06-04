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
    public partial class AddTransactionForm : Form
    {
        private MainForm _mainFormInstance;
        public AddTransactionForm(MainForm mainFormInstance) // To refresh data on MainForm
        {
            InitializeComponent();
            _mainFormInstance = mainFormInstance;
        }

        private void AddTransactionForm_Load(object sender, EventArgs e)
        {
            LoadAccounts();
            dateTimePickerTransaction.Value = DateTime.Now; // Default to today
        }

        private void LoadAccounts()
        {
            List<Account> accounts = DatabaseHelper.GetAllAccounts();
            comboBoxAccount.DataSource = accounts;
            // comboBoxAccount.DisplayMember = "AccountName"; // Will use ToString() override
            comboBoxAccount.ValueMember = "AccountName";

            if (accounts.Count == 0)
            {
                MessageBox.Show("Аккаунты не найдены. Сначала создайте аккаунт.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (comboBoxAccount.SelectedItem == null)
            {
                MessageBox.Show("Выберите аккаунт.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (numericUpDownAmount.Value <= 0)
            {
                MessageBox.Show("Сумма должна быть больше нуля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Account> accounts = DatabaseHelper.GetAllAccounts();

            Transaction newTransaction = new Transaction
            {
                AccountId = accounts.Find(account => account.AccountName == (string)comboBoxAccount.SelectedValue).AccountId,
                Amount = numericUpDownAmount.Value,
                IsExpense = radioButtonExpense.Checked,
                TransactionDate = dateTimePickerTransaction.Value,
                Description = textBoxDescription.Text.Trim(),
                PayeeOrPayer = textBoxPayeePayer.Text.Trim()
            };

            if (DatabaseHelper.AddTransaction(newTransaction))
            {
                MessageBox.Show("Транзакция успешно добавлена!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _mainFormInstance?.LoadAccounts(); // Refresh accounts on main form (balances changed)
                _mainFormInstance?.LoadChartData(); // Refresh chart on main form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
