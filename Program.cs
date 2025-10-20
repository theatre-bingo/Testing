using System;
using System.Linq;
using System.Windows.Forms;
using WindowFormsAssignment2.Data;
using WindowFormsAssignment2.Models;
using WindowFormsAssignment2.Utils;
using WindowFormsAssignment2.Window;
namespace WindowFormsAssignment2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //initialize database(SQLite file in project folder)
            using (var context = new AppDbContext())
            {
                //checks database and tables exist
                context.Database.EnsureCreated();
            }

            //start application
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginWindow());
        }
    }
}