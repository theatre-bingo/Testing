using System;
using System.Linq;
using WindowFormsAssignment2.Data;
using WindowFormsAssignment2.Models;

namespace WindowFormsAssignment2.Utils
{
    public class TransactionService
    {
        // Transaction logic (use for NUnit testing)
        public bool ValidateTransaction(decimal amount, DateTime date, string category, bool isIncome, bool isExpense, out string error)
        {
            if (amount <= 0)
            {
                error = "Amount must be greater than zero.";
                return false;
            }

            if (date == DateTime.MinValue)
            {
                error = "Date must be valid.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(category))
            {
                error = "Category must be selected.";
                return false;
            }

            if (!isIncome && !isExpense)
            {
                error = "Transaction type must be selected.";
                return false;
            }

            error = string.Empty;
            return true;
        }

        public bool AddTransaction(AppDbContext context, string description, decimal amount, DateTime date, string budgetName, bool isIncome)
        {
            var user = context.Users.FirstOrDefault();
            if (user == null) throw new InvalidOperationException("No user found.");

            var budget = context.Budgets.FirstOrDefault(b => b.BudgetName == budgetName);
            if (budget == null) throw new InvalidOperationException("Budget not found.");

            var transaction = new Transaction
            {
                TransactionId = IdGenerator.GenerateId("T"),
                UserId = user.UserId,
                BudgetId = budget.BudgetId,
                TransactionDescription = description,
                TransactionAmount = amount,
                TransactionBudget = budget.BudgetName,
                TransactionDate = date,
                TransactionType = isIncome ? TransactionType.Income : TransactionType.Expense
            };

            context.Transactions.Add(transaction);
            context.SaveChanges();
            return true;
        }
    }
}

