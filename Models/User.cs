using WindowFormsAssignment2.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowFormsAssignment2.Models
{
    public class User
    {
        [Key]
        public string UserId { get; set; }

        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }

        public decimal TotalBudgetAmount { get; set; } 
        public int BudgetPeriod { get; set; } //number of days/weeks/months
        public DateTime DateCreated { get; set; } = DateTime.Now;

        //Navigation property: budgets & transactions belonging to user
        public ICollection<Budget> Budgets { get; set; } //EXAMPLE: Generic-based collection & 2 Interfaces
        public ICollection<Transaction> Transactions { get; set; }

        public User() 
        {
            UserId = IdGenerator.GenerateId("U"); 
        }
    }


}
