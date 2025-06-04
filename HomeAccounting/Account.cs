using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccounting
{
    public class Account
    {
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public decimal InitialBalance { get; set; }
        public decimal CurrentBalance { get; set; }
        public string AccountType { get; set; } // e.g., "Checking", "Savings", "Credit Card"

        public override string ToString()
        {
            return $"{AccountName} - Баланс: {CurrentBalance.ToString("C2", CultureInfo.CreateSpecificCulture("ru-RU"))}";
        }
    }
}
