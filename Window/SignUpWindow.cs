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
    public partial class SignUpWindow : Form
    {
        public SignUpWindow()
        {
            InitializeComponent();
        }

        private void SignUpWindow_Load(object sender, EventArgs e)
        {

        }

        private void createAccB_Click(object sender, EventArgs e) //constructing time periods -> timespan object, add the time period saved in the user, storing dates in user object
        {
            using (var context = new AppDbContext())
            {

                //checks database and tables exist
                context.Database.EnsureCreated();
                string firstName = fNameTB.Text;
                string lastName = lNameTB.Text;
                string password = passTB.Text;
                string email = emailTB.Text;
                decimal timePeriod = timePeriodNUD.Value;
                string timePeriodType = timePeriodTypeLB.Text;
                decimal budget;

                if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(timePeriodType) ||
                string.IsNullOrWhiteSpace(budgTB.Text) ||
                string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Do not leave fields empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (!Decimal.TryParse(budgTB.Text, out budget))
                {
                    MessageBox.Show("Please only enter a number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!isGoodInput(budget))
                {
                    MessageBox.Show("Please enter a number larger than 0.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!isGoodInput(firstName))
                {
                    MessageBox.Show("Numbers and special symbols not allowed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!isGoodInput(lastName))
                {
                    MessageBox.Show("Numbers and special symbols not allowed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) //cycle through users to make sure that email is unique
                {
                    MessageBox.Show("Please enter a valid email.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!isEmailUnqiue(email, context)) //cycle through users to make sure that email is unique
                {
                    MessageBox.Show("Please enter a unique email.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    var user = new User
                    {
                        UserId = IdGenerator.GenerateId("U"),
                        UserFirstName = firstName,
                        UserLastName = lastName,
                        UserEmail = email,
                        UserPassword = password,
                        TotalBudgetAmount = budget,
                        BudgetPeriod = CalculateBudgetPeriod(timePeriod, timePeriodType)
                    };
                    context.Users.Add(user);
                    context.SaveChanges();
                    MessageBox.Show("User successfully created. Thank you for joining us!", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ExitWindow();
                    return;
                }
            }
        }

        private static int CalculateBudgetPeriod(decimal timePeriod, string timePeriodType)
        {
            int budgetPeriod = Convert.ToInt32(timePeriodType.Equals("Days") ? timePeriod : timePeriod * 7); // calculates budget period; multiplies by 7 if user chooses weeks
            return budgetPeriod;
        }
        private static bool isEmailUnqiue(string email, AppDbContext context)
        {
            foreach (User user in context.Users)
            {
                if (user.UserEmail.Equals(email))
                {
                    return false;
                }
            }
            return true;
        }
        private void exitB_Click(object sender, EventArgs e)
        {
            ExitWindow();
        }

        private bool isGoodInput(string attempt) // example of polymorphism in the form of an overloaded method
        {
            return Regex.IsMatch(attempt, @"^[a-zA-Z]+$");
        }
        private bool isGoodInput(decimal attempt)
        {
            return attempt > 0;
        }

        private void ExitWindow()
        {
            new LoginWindow().Show();
            this.Hide();
        } 
    }
}
