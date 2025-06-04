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
    public partial class AddAccountForm : Form
    {
        public AddAccountForm()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAccountName.Text))
            {
                MessageBox.Show("Имя аккаунта не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxAccountName.Focus();
                return;
            }

            Account newAccount = new Account
            {
                AccountName = textBoxAccountName.Text.Trim(),
                InitialBalance = numericUpDownInitialBalance.Value,
                CurrentBalance = numericUpDownInitialBalance.Value, // Initial and Current are same at creation
                AccountType = string.IsNullOrWhiteSpace(textBoxAccountType.Text) ? null : textBoxAccountType.Text.Trim()
            };

            if (DatabaseHelper.AddAccount(newAccount))
            {
                MessageBox.Show("Аккаунт добавлен успешно!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // Error message is shown by DatabaseHelper
                // Optionally, you can add more specific handling here if needed.
            }
        }
    }
}
