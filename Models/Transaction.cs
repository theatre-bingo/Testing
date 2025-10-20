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
    public enum TransactionType
    {
        Expense,
        Income
    }
    public class Transaction
    {
        [Key]
        public string TransactionId { get; set; }

        public string BudgetId { get; set; }
        [ForeignKey("BudgetId")]
        public Budget Budget { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        public string TransactionDescription { get; set; }
        public decimal TransactionAmount { get; set; }
        public string TransactionBudget { get; set; }
        public DateTime TransactionDate { get; set; } = DateTime.Now;
        public TransactionType TransactionType { get; set; }

        public Transaction()
        {
            TransactionId = IdGenerator.GenerateId("T");
        }
    }
}
