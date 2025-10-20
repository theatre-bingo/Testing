using WindowFormsAssignment2.Data;
using WindowFormsAssignment2.Models;
using WindowFormsAssignment2.Utils;
using System;
using System.Data.SqlTypes;
using System.Linq;
using System.Windows.Forms;

namespace WindowFormsAssignment2.Window
{
    public partial class TransactionWindow : Form
    {
        private string currentUserId;
        public TransactionWindow(string UserId)
        {
            this.currentUserId = UserId;
            InitializeComponent();
            Load += TransactionWindow_Load;
        }

        private void TransactionWindow_Load(object? sender, EventArgs e)
        {
            TransactionDate.MaxDate = DateTime.Now;
            PopulateCategories();
            LoadTransactions();
        }
        // Load Budget (Category) from DB
        private void PopulateCategories()
        {
            TransactionCategory.Items.Clear();
            try
            {
                using var context = new AppDbContext();
                var budgets = context.Budgets.Where(b => b.UserId.Equals(currentUserId)).ToList();
                foreach (var b in budgets)
                    TransactionCategory.Items.Add(b.BudgetName);
            }
            catch (Exception)
            {
                // Ignore for UI populate
            }
            TransactionCategory.SelectedIndex = -1;
        }
        // Transaction History 
        private void LoadTransactions()
        {
            TransactionHistory.Rows.Clear();
            try
            {
                using var context = new AppDbContext();
                var transactions = context.Transactions
                    .OrderByDescending(t => t.TransactionDate)
                    .ToList();

                foreach (var t in transactions)
                {
                    string budgetName = t.TransactionBudget;
                    if (string.IsNullOrWhiteSpace(budgetName) && !string.IsNullOrWhiteSpace(t.BudgetId))
                    {
                        var b = context.Budgets.FirstOrDefault(x => x.BudgetId == t.BudgetId);
                        budgetName = b?.BudgetName ?? "";
                    }

                    var date = t.TransactionDate == DateTime.MinValue ? "" : t.TransactionDate.ToShortDateString();
                    // Include TransactionType so the grid has values for all five columns (Date, Amount, Description, Budget, Type)
                    TransactionHistory.Rows.Add(date, t.TransactionAmount, t.TransactionDescription ?? "", budgetName ?? "", t.TransactionType.ToString());
                }
            }
            catch (Exception)
            {
               // If DB read fails, leave grid empty.
            }
        }
        // Add Transaction
        private void Add_Click(object sender, EventArgs e)
        {
            decimal amount = TransactionAmount.Value;
            DateTime date = TransactionDate.Value;
            string description = string.IsNullOrWhiteSpace(TransactionDescription.Text) ? "" : TransactionDescription.Text;
            string category = TransactionCategory.SelectedItem?.ToString() ?? "";
            string budgetText = category; // use selected category as budget text

            // Validate inputs (ensure certain fields are filled in)
            if (amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount greater than 0", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (date > DateTime.MaxValue)
            {
                MessageBox.Show("Please select a valid date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(budgetText))
            {
                MessageBox.Show("Please select a budget from the dropdown.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!radioIncome.Checked && !radioExpense.Checked)
            {
                MessageBox.Show("Please select Income or Expense.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var context = new AppDbContext();

                var budgetEntity = context.Budgets.FirstOrDefault(b => b.BudgetName == budgetText);
                if (budgetEntity == null)
                {
                    MessageBox.Show("Selected budget was not found in database.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var transaction = new Transaction
                {
                    TransactionId = IdGenerator.GenerateId("T"),
                    UserId = this.currentUserId,
                    BudgetId = budgetEntity.BudgetId,
                    TransactionDescription = description,
                    TransactionAmount = amount,
                    TransactionBudget = budgetEntity.BudgetName,
                    TransactionDate = date,
                    // Read the selected radio button and set the enum accordingly
                    TransactionType = radioIncome.Checked ? TransactionType.Income : TransactionType.Expense
                };

                context.Transactions.Add(transaction);
                if (transaction.TransactionType == TransactionType.Expense) // AmountSpent begins at 0, so the transaction amount is added to show that spending has increased 
                {
                    budgetEntity.AmountSpent += amount;
                }
                else
                {
                    budgetEntity.AmountSpent -= amount; // AmountSpent decreases if money is added to the budget
                }
                    context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save transaction: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Refresh grid from DB to reflect any computed fields or relationships
            LoadTransactions();

            TransactionAmount.Value = 0;
            TransactionDescription.Clear();
            TransactionCategory.SelectedIndex = -1;
            TransactionDate.Value = DateTime.Today;
            radioIncome.Checked = false;
            radioExpense.Checked = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) { }

        private void TransactionHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new DashboardWindow(this.currentUserId).Show();
            this.Hide();
        }
    }
}
