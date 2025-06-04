using HomeAccounting;
using System;
using System.Globalization;

// Helper class for displaying transactions with account names in a list
public class TransactionDisplayItem : Transaction // Inherit base properties
{
    public string AccountName { get; set; }

    // Override ToString for customized display in ListBox
    public override string ToString()
    {
        string type = IsExpense ? "Расход" : "Доход";
        string partyInfo = string.IsNullOrWhiteSpace(PayeeOrPayer) ? "" : $"{(IsExpense ? "" : "От: ")}{PayeeOrPayer}";
        string descriptionInfo = string.IsNullOrWhiteSpace(Description) ? "" : $"Описание: {Description}";

        return $"{TransactionDate:dd.MM.yyyy} | {AccountName} | {type} | {Amount.ToString("C", CultureInfo.CreateSpecificCulture("ru-RU"))} {(string.IsNullOrWhiteSpace(partyInfo) ? "" : $"| {partyInfo}")} {(string.IsNullOrWhiteSpace(descriptionInfo) ? "" : $"| {descriptionInfo}")}".Trim();
    }
}
