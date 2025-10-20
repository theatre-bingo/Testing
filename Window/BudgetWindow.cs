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
    public partial class BudgetWindow : Form
    {
        private AppDbContext _context;
        private readonly string _currentUserId; //store logged-in user id
        private List<Budget> _budgets = new List<Budget>();
        private decimal _totalBudget;
        //private const decimal TOTAL_BUDGET = 1000m; // Or get from user.TotalBudgetAmount

        public BudgetWindow(string currentUserId)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _currentUserId = currentUserId;

            this.Text = "Personal Finance Tracker - Budgets";
            this.ClientSize = new Size(770, 500);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MinimumSize = new Size(770, 500);
            this.AutoSize = false;
            this.BackColor = Color.White;

            LoadUserData();
            RefreshBudgetData();
        }


        private void LoadUserData()
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == _currentUserId);

            if (user == null)
            {
                MessageBox.Show("User not found. Please log in again or create a new user profile.",
                    "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //close this window if user is not found
                this.Close();
                return;
            }
            else
            {
                _totalBudget = user.TotalBudgetAmount;
            }
        }



        private void BudgetWindow_Load(object sender, EventArgs e)
        {
            RefreshBudgetData();
        }

        private void LoadBudgetsFromDb()
        {
            try
            {
                //load budgets for current user
                _budgets = _context.Budgets
                    .Where(b => b.UserId == _currentUserId)
                    .ToList();
            }
            catch (Exception ex) //Error handling: database error
            {
                MessageBox.Show($"Error loading budgets: {ex.Message}", "Database error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateOverallBudgetUI()
        {
            decimal totalAllocated = _budgets.Sum(b => b.AmountAllocated);
            decimal totalSpent = _budgets.Sum(b => b.AmountSpent);
            decimal remaining = _totalBudget - totalSpent;
            decimal notInUse = _totalBudget - totalAllocated;

            TotalBudgetLbl.Text = $"Total Budget: ${_totalBudget:F2}";
            TotalSpentLbl.Text = $"Spent: ${totalSpent:F2}";
            TotalRemainingLbl.Text = $"Remaining: ${remaining:F2}";
            NotInUseLbl.Text = $"Not in Use: ${notInUse:F2}";

            //checks if total budget is greater than 0 
            int percentSpent = _totalBudget > 0
                //calculate percentage spent out of total budget
                ? Math.Min((int)((double)totalSpent / (double)_totalBudget * 100), 100)
                : 0; //if total budget is 0 -> percentSpent is set to 0

            TotalProgBar.Value = percentSpent;
        }

        private void RefreshBudgetData()
        {
            LoadBudgetsFromDb();
            UpdateOverallBudgetUI();
            UpdateBudgetRows();
        }
        private void UpdateBudgetRows()
        {
            //stop layout temporarily to prevent lag
            CategoriesPanel.SuspendLayout();

            try
            {
                //clear old controls except headers
                CategoriesPanel.Controls.Clear();
                CategoriesPanel.RowStyles.Clear();
                CategoriesPanel.RowCount = 0;

                int RowHeight = 30;

                //Header row - index 0
                CategoriesPanel.RowCount = 1;
                CategoriesPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, RowHeight));

                CategoriesPanel.Controls.Add(CategoryLbl, 0, 0);
                CategoriesPanel.Controls.Add(AllocatedLbl, 1, 0);
                CategoriesPanel.Controls.Add(SpentLbl, 2, 0);
                CategoriesPanel.Controls.Add(RemainingLbl, 3, 0);
                CategoriesPanel.Controls.Add(ProgressLbl, 4, 0);

                foreach (Control header in CategoriesPanel.Controls)
                {
                    if (header is Label lbl)
                    {
                        lbl.TextAlign = ContentAlignment.MiddleCenter; //align headers
                        lbl.Dock = DockStyle.Fill;
                        lbl.AutoSize = false;
                    }
                }

                //budget rows from row index 1
                foreach (var budget in _budgets)
                {
                    int rowIndex = CategoriesPanel.RowCount++;
                    CategoriesPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, RowHeight));

                    //budget name
                    var lblName = new Label
                    {
                        Text = budget.BudgetName,
                        Font = new Font("Segoe UI", 9),
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Dock = DockStyle.Fill
                    };
                    CategoriesPanel.Controls.Add(lblName, 0, rowIndex);

                    //amount allocated
                    var lblAllocated = new Label
                    {
                        Text = $"${budget.AmountAllocated:F2}",
                        AutoSize = false,
                        Font = new Font("Segoe UI", 9),
                        TextAlign = ContentAlignment.MiddleLeft,
                        Dock = DockStyle.Fill
                    };
                    CategoriesPanel.Controls.Add(lblAllocated, 1, rowIndex);

                    //amount spent
                    var lblSpent = new Label
                    {
                        Text = $"${budget.AmountSpent:F2}",
                        AutoSize = false,
                        Font = new Font("Segoe UI", 9),
                        TextAlign = ContentAlignment.MiddleLeft,
                        Dock = DockStyle.Fill
                    };
                    CategoriesPanel.Controls.Add(lblSpent, 2, rowIndex);

                    //remaining
                    var lblRemaining = new Label
                    {
                        Text = $"${budget.AmountAllocated - budget.AmountSpent:F2}",
                        AutoSize = false,
                        Font = new Font("Segoe UI", 9),
                        TextAlign = ContentAlignment.MiddleLeft,
                        Dock = DockStyle.Fill
                    };
                    CategoriesPanel.Controls.Add(lblRemaining, 3, rowIndex);

                    //progress bar
                    int percent = budget.AmountAllocated > 0 //checks if amount allocated is greater than 0
                                                             //calculates percentage of amount spent divided by amount allocated 
                        ? (int)Math.Min((budget.AmountSpent / budget.AmountAllocated) * 100, 100)
                        : 0; //if amount allocated budget is 0 -> percent is set to 0
                    var pb = new ProgressBar
                    {
                        Value = percent,
                        Height = 16,
                        Dock = DockStyle.Fill,
                        ForeColor = Color.White,
                        BackColor = Color.LightGray,
                        Margin = new Padding(2)
                    };
                    CategoriesPanel.Controls.Add(pb, 4, rowIndex);

                    //edit button
                    var btnEdit = new Button
                    {
                        Text = "✏️",
                        Tag = budget,
                        BackColor = Color.White,
                        ForeColor = Color.Green,
                        Dock = DockStyle.Fill
                    };
                    btnEdit.Click += BtnEditBudget_Click;
                    CategoriesPanel.Controls.Add(btnEdit, 5, rowIndex);

                    //delete button
                    var btnDelete = new Button
                    {
                        Text = "🗑️",
                        Tag = budget,
                        BackColor = Color.White,
                        ForeColor = Color.DarkRed,
                        Dock = DockStyle.Fill
                    };
                    btnDelete.Click += BtnDeleteBudget_Click;
                    CategoriesPanel.Controls.Add(btnDelete, 6, rowIndex);
                }

                // Add a spacer row at the bottom
                CategoriesPanel.RowCount++;
                CategoriesPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 10));
            }
            finally
            {
                CategoriesPanel.ResumeLayout();
            }
        }

        //add budget button click handler
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            decimal totalAllocated = _budgets.Sum(b => b.AmountAllocated);
            decimal remainingBudget = _totalBudget - totalAllocated;

            if (remainingBudget <= 0) //if budget remaining is 0 
            {
                MessageBox.Show("No remaining budget available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (AddBudgetWindow addForm = new AddBudgetWindow((int)remainingBudget))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    Budget newBudget = addForm.NewBudget;
                    var user = _context.Users.FirstOrDefault(u => u.UserId == _currentUserId);

                    if (user == null)
                    {
                        MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    newBudget.UserId = user.UserId;
                    newBudget.User = user;

                    _context.Budgets.Add(newBudget);
                    _context.SaveChanges();

                    RefreshBudgetData();
                }
            }
        }
        //edit budget button click handler
        private void BtnEditBudget_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Budget budgetToEdit = btn.Tag as Budget;

            if (budgetToEdit == null) return;

            //filter to get list of budgets (except the edited budget the user chose)
            //and add the amount allocated of the filtered budgets
            decimal allocatedOther = _budgets.Where(b => b.BudgetId != budgetToEdit.BudgetId)
                                             .Sum(b => b.AmountAllocated);
            //subtract total budget from sum of allocated filtered budgets for amount not in use
            decimal notInUse = _totalBudget - allocatedOther;

            using (EditBudgetWindow editForm = new EditBudgetWindow(budgetToEdit, _budgets, _totalBudget))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    budgetToEdit.AmountAllocated = editForm.NewLimit;
                    _context.Budgets.Update(budgetToEdit);
                    _context.SaveChanges();

                    RefreshBudgetData();
                }
            }
        }

        //delete budget button click handler
        private void BtnDeleteBudget_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Budget budgetToDelete = btn.Tag as Budget;

            if (budgetToDelete == null) return;

            if (MessageBox.Show($"Delete {budgetToDelete.BudgetName}?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _context.Budgets.Remove(budgetToDelete);
                _context.SaveChanges();

                RefreshBudgetData();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            new DashboardWindow(_currentUserId).Show();
            this.Hide();
        }
    }
}
