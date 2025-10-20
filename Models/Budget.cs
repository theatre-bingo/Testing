using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowFormsAssignment2.Utils;

namespace WindowFormsAssignment2.Models
{
    public class Budget
    {
        [Key]
        public string BudgetId { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        public string BudgetName { get; set; }
        public decimal AmountAllocated { get; set; }
        public decimal AmountSpent { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;

        //Navigation property: transactions belonging to budget
        public ICollection<Transaction> Transactions { get; set; }

        public Budget()
        {
            BudgetId = IdGenerator.GenerateId("B");
        }
    }
}
