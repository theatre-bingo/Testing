using WindowFormsAssignment2.Data;
using WindowFormsAssignment2.Models;
using WindowFormsAssignment2.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowFormsAssignment2.Window
{
    public partial class DashboardWindow : Form
    {
        private string currentUserId;
        private DataTable dt;
        public DashboardWindow()
        {
            InitializeComponent();
        }

        public DashboardWindow(string currentUserId)
        {
            InitializeComponent();
            this.currentUserId = currentUserId;
        }

        private void setFilter(List<Budget> budgets) //cycles through the user's budgets and adds them to the filter
        {
            foreach (Budget budget in budgets)
            {
                budgFilterCB.Items.Add(budget.BudgetName);
            }
            budgFilterCB.Items.Add("All budgets");
        }

        private DataTable GetBudgetDataTable() //add columns for budget info i.e. name, amount spent and allocated 
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Spent");
            dt.Columns.Add("Allocated");
            return dt;
        }
        private DataTable GetTransactionDataTable() //add columns for transaction info i.e. budget, amount, desc, date
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Budget");
            dt.Columns.Add("Amount");
            dt.Columns.Add("Description");
            dt.Columns.Add("Date");
            return dt;
        }

        private void SetBudgetDataTable(List<Budget> budgets, DataTable budgetDT)
        {
            foreach (Budget budget in budgets)
            {
                budgetDT.Rows.Add(budget.BudgetName, budget.AmountSpent, budget.AmountAllocated);
            }
        }

        private void SetTransactionDataTable(List<Transaction> transactions, DataTable transactionDT)
        {
            foreach (Transaction transaction in transactions)
            {
                transactionDT.Rows.Add(transaction.TransactionBudget, transaction.TransactionAmount, transaction.TransactionDescription, transaction.TransactionDate);
            }
        }

        private void SetDataGridView(DataTable dt, DataGridView dgv)
        {
            dgv.DataSource = dt;
            for (int i = 0; i < budgetDGV.Columns.Count; i++)
            {
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic; //static tables - users can sort via amounts, dates, etc. in the Transactions window
            }
        }
        private void DashboardWindow_Load(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                DataTable budgetDT = GetBudgetDataTable();
                DataTable transactionDT = GetTransactionDataTable();
                this.dt = transactionDT; //global variable for dynamically changing after user input

                //checks database and tables exist
                context.Database.EnsureCreated();
                var user = context.Users.SingleOrDefault(u => u.UserId.Equals(currentUserId)); //lambda expression with LINQ
                var budgets = context.Budgets.Where(b => b.UserId.Equals(currentUserId)).ToList();
                var transactions = context.Transactions.Where(t => t.UserId.Equals(currentUserId)).ToList();
                setFilter(budgets);
                SetBudgetDataTable(budgets, budgetDT);
                SetTransactionDataTable(transactions, transactionDT);
                userHeading.Text = user.UserFirstName + " " + user.UserLastName;
                accBalLbl.Text = "$" + CalculateSpendings(budgets, user);
                SetWarning(budgets);
                dayLbl.Text = user.BudgetPeriod.ToString();
                SetDataGridView(budgetDT, budgetDGV);
                SetDataGridView(transactionDT, transactionsDGV);
            }
        }

        private decimal CalculateSpendings(List<Budget> budgets, User user) //cycles through budgets and calculates the total amount spent
        {
            decimal amount = 0;
            foreach (var budget in budgets)
            {
                amount += budget.AmountSpent;
            }
            return user.TotalBudgetAmount - amount;
        }

        private void SetWarning(List<Budget> budgets) //sets a warning for the user if they spend over 75% within their allocated budget amount
        {
            string budgetName = "";
            decimal min = int.MaxValue;
            
            foreach(Budget budget in budgets)
            {
                decimal difference = budget.AmountAllocated - budget.AmountSpent;
                if (difference <= 0 && difference < min)
                {
                    min = difference;
                    warningLbl.Text = budget.BudgetName + " has exceeded its limit.";
                }
                if (difference <= Convert.ToDecimal(0.25)*(budget.AmountAllocated) && difference < min)
                {
                    min = difference;
                    warningLbl.Text = budget.BudgetName + " is nearing its limit.";
                }
            }
        }
        private void budgFilterCB_SelectedIndexChanged(object sender, EventArgs e) //sets the filter for the transaction data grid (users can filter between transactions via a specific budget)
        {
            DataView dataView = new DataView(dt);
            if (budgFilterCB.Text.Equals("All budgets"))
            {
                dataView.RowFilter = "";
            }
            else
            {
                dataView.RowFilter = "Budget = '" + budgFilterCB.Text + "'";
            }
            transactionsDGV.DataSource = dataView;
        }
        private void logB_Click(object sender, EventArgs e)
        {
            new LoginWindow().Show();
            this.Hide();
        }
        private void transactB_Click(object sender, EventArgs e)
        {
            new TransactionWindow(this.currentUserId).Show();
            this.Hide();
        }
        private void budgB_Click(object sender, EventArgs e)
        {
            new BudgetWindow(this.currentUserId).Show();
            this.Hide();
        }
        private void transactionsDGV_SelectionChanged(Object sender, EventArgs e)
        {
            transactionsDGV.ClearSelection(); //users cannot select rows or columns in the transaction/budget tables
        }
        private void budgetDGV_SelectionChanged(Object sender, EventArgs e)
        {
            budgetDGV.ClearSelection();
        }
    }
}