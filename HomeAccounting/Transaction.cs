using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccounting
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int AccountId { get; set; }
        public decimal Amount { get; set; }
        public bool IsExpense { get; set; } // true for expense, false for income
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }
        public string PayeeOrPayer { get; set; } // Payee if expense, Payer if income

        public override string ToString()
        {
            string type = IsExpense ? "Трата" : "Доход";
            string party = IsExpense ? "" : "От: ";
            party += PayeeOrPayer ?? "N/A";
            return $"{TransactionDate:dd.MM.yyyy} | {type} | {party} | {Amount.ToString("C2", CultureInfo.CreateSpecificCulture("ru-RU"))} | Описание: {Description ?? ""}";
        }
    }
}
