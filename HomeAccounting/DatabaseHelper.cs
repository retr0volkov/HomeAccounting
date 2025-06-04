using HomeAccounting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;

public static class DatabaseHelper
{
    // Connection string fields
    private static readonly string DbName = "HomeAccountingDB";
    private static readonly string BaseConnectionString = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;";
    private static readonly string MasterConnectionString = BaseConnectionString + "Database=master;";
    private static string _appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "HomeAccountingApp");
    private static string _dbFilePath = Path.Combine(_appDataPath, DbName + ".mdf");
    private static string _connectionString = BaseConnectionString + $"AttachDbFilename={_dbFilePath};Database={DbName};";

    public static string GetConnectionString() => _connectionString;

    // EnsureDatabaseAndTablesExist, CheckDatabaseExists, CreateDatabase (same as before)
    public static void EnsureDatabaseAndTablesExist()
    {
        try
        {
            if (!Directory.Exists(_appDataPath))
            {
                Directory.CreateDirectory(_appDataPath);
            }

            bool dbExists = CheckDatabaseExists();

            if (!dbExists)
            {
                CreateDatabase();
            }

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                // Check and create Accounts table
                string checkAccountsTableQuery = "IF OBJECT_ID(N'dbo.Accounts', N'U') IS NULL SELECT 0 ELSE SELECT 1";
                using (SqlCommand cmdCheck = new SqlCommand(checkAccountsTableQuery, conn))
                {
                    if (Convert.ToInt32(cmdCheck.ExecuteScalar()) == 0)
                    {
                        string createAccountsTableQuery = @"
                        CREATE TABLE Accounts (
                            AccountId INT PRIMARY KEY IDENTITY(1,1),
                            AccountName NVARCHAR(100) NOT NULL UNIQUE,
                            InitialBalance DECIMAL(18, 2) NOT NULL DEFAULT 0,
                            CurrentBalance DECIMAL(18, 2) NOT NULL DEFAULT 0,
                            AccountType NVARCHAR(50)
                        );";
                        using (SqlCommand cmdCreate = new SqlCommand(createAccountsTableQuery, conn))
                        {
                            cmdCreate.ExecuteNonQuery();
                        }
                    }
                }

                // Check and create Transactions table
                string checkTransactionsTableQuery = "IF OBJECT_ID(N'dbo.Transactions', N'U') IS NULL SELECT 0 ELSE SELECT 1";
                using (SqlCommand cmdCheck = new SqlCommand(checkTransactionsTableQuery, conn))
                {
                    if (Convert.ToInt32(cmdCheck.ExecuteScalar()) == 0)
                    {
                        string createTransactionsTableQuery = @"
                        CREATE TABLE Transactions (
                            TransactionId INT PRIMARY KEY IDENTITY(1,1),
                            AccountId INT NOT NULL,
                            Amount DECIMAL(18, 2) NOT NULL,
                            IsExpense BIT NOT NULL, -- 1 for Expense, 0 for Income
                            TransactionDate DATETIME NOT NULL,
                            Description NVARCHAR(255),
                            PayeeOrPayer NVARCHAR(100),
                            FOREIGN KEY (AccountId) REFERENCES Accounts(AccountId) ON DELETE CASCADE
                        );";
                        using (SqlCommand cmdCreate = new SqlCommand(createTransactionsTableQuery, conn))
                        {
                            cmdCreate.ExecuteNonQuery();
                        }
                    }
                }
                conn.Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка установки базы данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(1);
        }
    }

    private static bool CheckDatabaseExists()
    {
        if (File.Exists(_dbFilePath))
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    conn.Close();
                }
                return true;
            }
            catch
            {
                File.Delete(_dbFilePath);
                string logFilePath = Path.Combine(_appDataPath, DbName + "_log.ldf");
                if (File.Exists(logFilePath)) File.Delete(logFilePath);
                return false;
            }
        }
        return false;
    }

    private static void CreateDatabase()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(MasterConnectionString))
            {
                conn.Open();
                string query = $"CREATE DATABASE [{DbName}] ON PRIMARY (NAME={DbName}_Data, FILENAME='{_dbFilePath}')";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            System.Threading.Thread.Sleep(500);
        }
        catch (SqlException ex)
        {
            if (ex.Number == 1801)
            {
                return;
            }
            MessageBox.Show($"Не удалось создать базу данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw;
        }
    }
    // Account Methods (AddAccount, GetAllAccounts, GetAccountById, DeleteAccount - same as before)
    public static bool AddAccount(Account account)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Accounts (AccountName, InitialBalance, CurrentBalance, AccountType) VALUES (@Name, @Initial, @Current, @Type)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", account.AccountName);
                    cmd.Parameters.AddWithValue("@Initial", account.InitialBalance);
                    cmd.Parameters.AddWithValue("@Current", account.InitialBalance);
                    cmd.Parameters.AddWithValue("@Type", account.AccountType ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка добавления аккаунта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    public static List<Account> GetAllAccounts()
    {
        List<Account> accounts = new List<Account>();
        try
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT AccountId, AccountName, CurrentBalance, InitialBalance, AccountType FROM Accounts ORDER BY AccountName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        accounts.Add(new Account
                        {
                            AccountId = reader.GetInt32(0),
                            AccountName = reader.GetString(1),
                            CurrentBalance = reader.GetDecimal(2),
                            InitialBalance = reader.GetDecimal(3),
                            AccountType = reader.IsDBNull(4) ? null : reader.GetString(4)
                        });
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка получения аккаунтов: {ex.Message}", "Ошбика", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return accounts;
    }

    public static Account GetAccountById(int accountId)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT AccountId, AccountName, CurrentBalance, InitialBalance, AccountType FROM Accounts WHERE AccountId = @AccountId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AccountId", accountId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Account
                            {
                                AccountId = reader.GetInt32(0),
                                AccountName = reader.GetString(1),
                                CurrentBalance = reader.GetDecimal(2),
                                InitialBalance = reader.GetDecimal(3),
                                AccountType = reader.IsDBNull(4) ? null : reader.GetString(4)
                            };
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка получения аккаунта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return null;
    }

    public static bool DeleteAccount(int accountId)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Accounts WHERE AccountId = @AccountId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AccountId", accountId);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка удаления аккаунта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    // Transaction Methods (AddTransaction, DeleteTransaction)
    public static bool AddTransaction(Transaction transaction)
    {
        SqlTransaction sqlTx = null;
        try
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                sqlTx = conn.BeginTransaction();

                string query = @"
                    INSERT INTO Transactions (AccountId, Amount, IsExpense, TransactionDate, Description, PayeeOrPayer)
                    VALUES (@AccountId, @Amount, @IsExpense, @TransactionDate, @Description, @PayeeOrPayer);";
                using (SqlCommand cmd = new SqlCommand(query, conn, sqlTx))
                {
                    cmd.Parameters.AddWithValue("@AccountId", transaction.AccountId);
                    cmd.Parameters.AddWithValue("@Amount", transaction.IsExpense ? -transaction.Amount : transaction.Amount);
                    cmd.Parameters.AddWithValue("@IsExpense", transaction.IsExpense);
                    cmd.Parameters.AddWithValue("@TransactionDate", transaction.TransactionDate);
                    cmd.Parameters.AddWithValue("@Description", transaction.Description ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PayeeOrPayer", transaction.PayeeOrPayer ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }

                decimal amountChange = transaction.IsExpense ? -transaction.Amount : transaction.Amount;
                string updateBalanceQuery = "UPDATE Accounts SET CurrentBalance = CurrentBalance + @AmountChange WHERE AccountId = @AccountId";
                using (SqlCommand cmdUpdate = new SqlCommand(updateBalanceQuery, conn, sqlTx))
                {
                    cmdUpdate.Parameters.AddWithValue("@AmountChange", amountChange);
                    cmdUpdate.Parameters.AddWithValue("@AccountId", transaction.AccountId);
                    cmdUpdate.ExecuteNonQuery();
                }

                sqlTx.Commit();
                return true;
            }
        }
        catch (Exception ex)
        {
            sqlTx?.Rollback();
            MessageBox.Show($"Ошибка добавления транзакции: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
    public static bool DeleteTransaction(int transactionId)
    {
        SqlTransaction sqlTx = null;
        try
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                sqlTx = conn.BeginTransaction();

                Transaction transactionToDelete = null;
                string selectQuery = "SELECT AccountId, Amount, IsExpense FROM Transactions WHERE TransactionId = @TransactionId";
                using (SqlCommand cmdSelect = new SqlCommand(selectQuery, conn, sqlTx))
                {
                    cmdSelect.Parameters.AddWithValue("@TransactionId", transactionId);
                    using (SqlDataReader reader = cmdSelect.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            transactionToDelete = new Transaction
                            {
                                AccountId = reader.GetInt32(0),
                                Amount = reader.GetDecimal(1),
                                IsExpense = reader.GetBoolean(2)
                            };
                        }
                        reader.Close();
                    }
                }

                if (transactionToDelete == null)
                {
                    sqlTx.Rollback();
                    MessageBox.Show("Транзакция не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                string deleteQuery = "DELETE FROM Transactions WHERE TransactionId = @TransactionId";
                using (SqlCommand cmdDelete = new SqlCommand(deleteQuery, conn, sqlTx))
                {
                    cmdDelete.Parameters.AddWithValue("@TransactionId", transactionId);
                    cmdDelete.ExecuteNonQuery();
                }

                decimal amountChange = transactionToDelete.IsExpense ? transactionToDelete.Amount : -transactionToDelete.Amount;
                string updateBalanceQuery = "UPDATE Accounts SET CurrentBalance = CurrentBalance + @AmountChange WHERE AccountId = @AccountId";
                using (SqlCommand cmdUpdate = new SqlCommand(updateBalanceQuery, conn, sqlTx))
                {
                    cmdUpdate.Parameters.AddWithValue("@AmountChange", amountChange);
                    cmdUpdate.Parameters.AddWithValue("@AccountId", transactionToDelete.AccountId);
                    cmdUpdate.ExecuteNonQuery();
                }

                sqlTx.Commit();
                return true;
            }
        }
        catch (Exception ex)
        {
            sqlTx?.Rollback();
            MessageBox.Show($"Ошибка удаления аккаунта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }


    // MODIFIED: Get transactions for a specific account WITH filters
    public static List<Transaction> GetTransactionsForAccount(int accountId, DateTime? startDate, DateTime? endDate, string transactionTypeFilter)
    {
        List<Transaction> transactions = new List<Transaction>();
        try
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                StringBuilder queryBuilder = new StringBuilder(@"
                    SELECT TransactionId, AccountId, Amount, IsExpense, TransactionDate, Description, PayeeOrPayer
                    FROM Transactions t WHERE t.AccountId = @AccountId");

                if (startDate.HasValue)
                {
                    queryBuilder.Append(" AND t.TransactionDate >= @StartDate");
                }
                if (endDate.HasValue)
                {
                    // To include the entire end day, we go up to the start of the next day.
                    queryBuilder.Append(" AND t.TransactionDate < @EndDate");
                }
                if (!string.IsNullOrEmpty(transactionTypeFilter) && transactionTypeFilter != "All")
                {
                    queryBuilder.Append(" AND t.IsExpense = @IsExpenseFilter");
                }
                queryBuilder.Append(" ORDER BY t.TransactionDate DESC");

                using (SqlCommand cmd = new SqlCommand(queryBuilder.ToString(), conn))
                {
                    cmd.Parameters.AddWithValue("@AccountId", accountId);
                    if (startDate.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@StartDate", startDate.Value.Date); // Use .Date to ensure time part is 00:00:00
                    }
                    if (endDate.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@EndDate", endDate.Value.Date.AddDays(1)); // Use .Date and add a day for < comparison
                    }
                    if (!string.IsNullOrEmpty(transactionTypeFilter) && transactionTypeFilter != "All")
                    {
                        cmd.Parameters.AddWithValue("@IsExpenseFilter", transactionTypeFilter == "Expense");
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            transactions.Add(new Transaction
                            {
                                TransactionId = reader.GetInt32(0),
                                AccountId = reader.GetInt32(1),
                                Amount = reader.GetDecimal(2),
                                IsExpense = reader.GetBoolean(3),
                                TransactionDate = reader.GetDateTime(4),
                                Description = reader.IsDBNull(5) ? null : reader.GetString(5),
                                PayeeOrPayer = reader.IsDBNull(6) ? null : reader.GetString(6)
                            });
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка получения транзакций аккаунта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return transactions;
    }

    // MODIFIED: Get all transactions with account name WITH filters
    public static List<TransactionDisplayItem> GetAllTransactionsWithAccountName(DateTime? startDate, DateTime? endDate, string transactionTypeFilter)
    {
        List<TransactionDisplayItem> transactions = new List<TransactionDisplayItem>();
        try
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                StringBuilder queryBuilder = new StringBuilder(@"
                    SELECT t.TransactionId, t.AccountId, a.AccountName, t.Amount, t.IsExpense, t.TransactionDate, t.Description, t.PayeeOrPayer
                    FROM Transactions t
                    JOIN Accounts a ON t.AccountId = a.AccountId
                    WHERE 1=1"); // Start with a true condition to make appending AND easier

                if (startDate.HasValue)
                {
                    queryBuilder.Append(" AND t.TransactionDate >= @StartDate");
                }
                if (endDate.HasValue)
                {
                    queryBuilder.Append(" AND t.TransactionDate < @EndDate");
                }
                if (!string.IsNullOrEmpty(transactionTypeFilter) && transactionTypeFilter != "All")
                {
                    queryBuilder.Append(" AND t.IsExpense = @IsExpenseFilter");
                }
                queryBuilder.Append(" ORDER BY t.TransactionDate DESC, a.AccountName");

                using (SqlCommand cmd = new SqlCommand(queryBuilder.ToString(), conn))
                {
                    if (startDate.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@StartDate", startDate.Value.Date);
                    }
                    if (endDate.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@EndDate", endDate.Value.Date.AddDays(1));
                    }
                    if (!string.IsNullOrEmpty(transactionTypeFilter) && transactionTypeFilter != "All")
                    {
                        cmd.Parameters.AddWithValue("@IsExpenseFilter", transactionTypeFilter == "Expense");
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            transactions.Add(new TransactionDisplayItem
                            {
                                TransactionId = reader.GetInt32(0),
                                AccountId = reader.GetInt32(1),
                                AccountName = reader.GetString(2),
                                Amount = reader.GetDecimal(3),
                                IsExpense = reader.GetBoolean(4),
                                TransactionDate = reader.GetDateTime(5),
                                Description = reader.IsDBNull(6) ? null : reader.GetString(6),
                                PayeeOrPayer = reader.IsDBNull(7) ? null : reader.GetString(7)
                            });
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка получения всех транзакций: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return transactions;
    }

    // Statistics Methods (GetOverallStats, GetAccountIncomeExpenseSummary, GetTotalBalanceForAllAccounts, GetTransactionCounts, GetLargestTransactions)
    public static DataTable GetOverallStats()
    {
        DataTable dt = new DataTable();
        try
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT
                        SUM(CASE WHEN IsExpense = 0 THEN Amount ELSE 0 END) AS TotalIncome,
                        SUM(CASE WHEN IsExpense = 1 THEN Amount ELSE 0 END) AS TotalExpenses
                    FROM Transactions";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка получения статистики: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return dt;
    }
    public static DataTable GetAccountIncomeExpenseSummary()
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("AccountName", typeof(string));
        dt.Columns.Add("TotalIncome", typeof(decimal));
        dt.Columns.Add("TotalExpenses", typeof(decimal));

        try
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT
                        a.AccountName,
                        SUM(CASE WHEN t.IsExpense = 0 THEN t.Amount ELSE 0 END) AS TotalIncome,
                        SUM(CASE WHEN t.IsExpense = 1 THEN t.Amount ELSE 0 END) AS TotalExpenses
                    FROM Accounts a
                    LEFT JOIN Transactions t ON a.AccountId = t.AccountId
                    GROUP BY a.AccountName
                    ORDER BY a.AccountName;";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dt.Rows.Add(
                            reader.GetString(0),  // AccountName
                            reader.GetDecimal(1), // TotalIncome
                            reader.GetDecimal(2)  // TotalExpenses
                        );
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка получения сводки аккаунта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return dt;
    }
    public static decimal GetTotalBalanceForAllAccounts()
    {
        decimal totalBalance = 0;
        try
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT SUM(CurrentBalance) FROM Accounts";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        totalBalance = Convert.ToDecimal(result);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка получения баланса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return totalBalance;
    }
    public static Tuple<int, int, int> GetTransactionCounts() // Total, Income, Expense
    {
        int total = 0, income = 0, expense = 0;
        try
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT 
                        COUNT(*) AS TotalTransactions,
                        SUM(CASE WHEN IsExpense = 0 THEN 1 ELSE 0 END) AS IncomeTransactions,
                        SUM(CASE WHEN IsExpense = 1 THEN 1 ELSE 0 END) AS ExpenseTransactions
                    FROM Transactions";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        total = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                        income = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                        expense = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка получения транзакций: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return Tuple.Create(total, income, expense);
    }
    public static List<TransactionDisplayItem> GetLargestTransactions(bool forIncome, int topN = 1)
    {
        List<TransactionDisplayItem> transactions = new List<TransactionDisplayItem>();
        try
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = $@"
                    SELECT TOP {topN}
                        t.TransactionId, t.AccountId, a.AccountName, t.Amount, t.IsExpense, t.TransactionDate, t.Description, t.PayeeOrPayer
                    FROM Transactions t
                    JOIN Accounts a ON t.AccountId = a.AccountId
                    WHERE t.IsExpense = @IsExpenseParam
                    ORDER BY t.Amount DESC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IsExpenseParam", forIncome ? 0 : 1);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            transactions.Add(new TransactionDisplayItem
                            {
                                TransactionId = reader.GetInt32(0),
                                AccountId = reader.GetInt32(1),
                                AccountName = reader.GetString(2),
                                Amount = reader.GetDecimal(3),
                                IsExpense = reader.GetBoolean(4),
                                TransactionDate = reader.GetDateTime(5),
                                Description = reader.IsDBNull(6) ? null : reader.GetString(6),
                                PayeeOrPayer = reader.IsDBNull(7) ? null : reader.GetString(7)
                            });
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка получения транзакций: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return transactions;
    }
}
