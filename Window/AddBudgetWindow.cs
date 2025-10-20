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
    public partial class AddBudgetWindow : Form
    {
        public Budget NewBudget { get; private set; }
        private decimal maxAmount;

        public AddBudgetWindow(decimal remainingBudget)
        {
            InitializeComponent();
            this.Text = "Add New Budget";
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            maxAmount = remainingBudget;
            CenterControls();

            //slider
            AmountSlider.Minimum = 0;
            AmountSlider.Maximum = (int)Math.Ceiling(maxAmount);
            AmountSlider.TickFrequency = Math.Max(1, (int)Math.Ceiling(maxAmount/10));
            AmountSlider.SmallChange = 1;
            AmountSlider.LargeChange = Math.Max(1, (int)Math.Ceiling(maxAmount/5));
            AmountSlider.Value = 0;

            AmountLbl.Text = $"Amount: 0 / {maxAmount:F2}";

            //set ComboBox with predefined categories
            string[] predefinedCategories = { "Food", "Shopping", "Grocery", "Health", "Transport", "Entertainment", "Utilities" };
            CatComboBox.Items.Clear();
            CatComboBox.Items.AddRange(predefinedCategories);
            CatComboBox.DropDownStyle = ComboBoxStyle.DropDown;

            AddBtn.Click += AddBtn_Click;
            CancelBtn.Click += CancelBtn_Click;
            AmountSlider.Scroll += AmountSlider_Scroll;

            this.Load += (s, e) => CenterControls(); 
        }

        private void CenterControls()
        {
            CatComboBox.Left = (this.ClientSize.Width - CatComboBox.Width)/2;
            AmountSlider.Left = (this.ClientSize.Width - AmountSlider.Width)/2;
            AmountLbl.Left = (this.ClientSize.Width - AmountLbl.Width)/2;

            //AddBtn and CancelBtn spacing
            int spacing = 10; 
            int totalButtonsWidth = AddBtn.Width + spacing + CancelBtn.Width;
            int startX = (this.ClientSize.Width - totalButtonsWidth)/2;
            AddBtn.Left = startX;
            CancelBtn.Left = startX + AddBtn.Width + spacing;
        }

        private void AmountSlider_Scroll(object sender, EventArgs e)
        {
            AmountLbl.Text = $"Amount: {AmountSlider.Value:F2} / {maxAmount:F2}";
            AmountLbl.Left = (this.ClientSize.Width/2) - (AmountLbl.Width/2);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string category = CatComboBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(category)) //user leaves category empty
            {
                MessageBox.Show("Please select or enter a budget category.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AmountSlider.Value <= 0) //user does not select budget amount
            {
                MessageBox.Show("Please select a budget amount.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NewBudget = new Budget
            {
                BudgetName = category,
                AmountAllocated = AmountSlider.Value,
                AmountSpent = 0,
                DateCreated = DateTime.Now
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}