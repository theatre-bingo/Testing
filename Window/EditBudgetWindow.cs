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
    public partial class EditBudgetWindow : Form
    {
        private AppDbContext _context;
        private Budget _budgetToEdit;
        private decimal _maxAmount;
        public decimal NewLimit { get; private set; }

        public EditBudgetWindow(Budget budgetToEdit, List<Budget> allBudgets, decimal totalBudget)
        {
            InitializeComponent();

            _context = new AppDbContext();
            _budgetToEdit = budgetToEdit;
            this.FormBorderStyle = FormBorderStyle.FixedDialog; 
            this.StartPosition = FormStartPosition.CenterParent;

            //calculate maximum amount (amount allocated + not in use)
            decimal allocatedOther =allBudgets
                .Where(b => b.BudgetId != budgetToEdit.BudgetId)
                .Sum(b => b.AmountAllocated);

            decimal notInUse = totalBudget - allocatedOther - budgetToEdit.AmountAllocated;
            _maxAmount = budgetToEdit.AmountAllocated + notInUse;

            InitialiseEditBudgetControls();
        }

        private void InitialiseEditBudgetControls()
        {
            //budget name
            BudgetNameLbl.Text = $"Budget: {_budgetToEdit.BudgetName}";

            //slider to edit budget amount
            AmountSlider.Minimum = 0;
            AmountSlider.Maximum = (int)Math.Ceiling(_maxAmount);
            AmountSlider.Value = (int)Math.Ceiling(_budgetToEdit.AmountAllocated);
            AmountSlider.TickFrequency = Math.Max(1,(int)Math.Ceiling(_maxAmount/10));
            AmountSlider.SmallChange = 1;
            AmountSlider.LargeChange = Math.Max(1,(int)Math.Ceiling(_maxAmount/5));

            //New limit label with initial amount label to max amount 
            AmountLbl.Text = $"New Limit: {AmountSlider.Value:F2} / {_maxAmount:F2}";

            //slider scroll event
            AmountSlider.Scroll += (s, e) =>
            {
                AmountLbl.Text = $"New Limit: {AmountSlider.Value:F2} / {_maxAmount:F2}";
            };

            //save button
            SaveBtn.Click += (s, e) =>
            {
                NewLimit = AmountSlider.Value;

                var budgetInDb = _context.Budgets.FirstOrDefault(b => b.BudgetId == _budgetToEdit.BudgetId);
                if (budgetInDb != null)
                {
                    budgetInDb.AmountAllocated = NewLimit;
                    _context.SaveChanges();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            };

            //cancel button
            CancelBtn.Click += (s, e) =>
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };
        }
    }
}
