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
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);

        }

        private void signUpButton_Click(object sender, EventArgs e) 
        {
            new SignUpWindow().Show();
            this.Hide();
        }

        private string verifyUserDetails(string username, string password, AppDbContext context) //verify that details exist in the database
        {
            string userID = "";
            foreach (User user in context.Users)
            {
                if (username.Equals(user.UserEmail) && password.Equals(user.UserPassword))
                {
                    return user.UserId;
                }
            }
            return userID;
        }

        private void loginB_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                //checks database and tables exist
                context.Database.EnsureCreated();
                string username = userTB.Text;
                string password = passTB.Text;
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Do not leave fields empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!Regex.IsMatch(username, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("Please enter a valid email.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string userID = verifyUserDetails(username, password, context); //cycles through database to verify details
                if (string.IsNullOrEmpty(userID))
                {
                    MessageBox.Show("No such user exists. Please check details again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("User found! Click OK to continue.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    new DashboardWindow(userID).Show();
                    this.Hide();
                }
            }
        }
    }
}
