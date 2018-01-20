using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public enum TransactionType
    {
        Credit,
        Debit
    }
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        [Required]
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Transctonamount { get; set; }
        [Required]
        public TransactionType TypeOfTransaction { get; set; }

        [ForeignKey("Account")]//creating this i am teling Account Number is associated with Account
        [Required]
        public int AcoountNumber { get; set; }
        public virtual Account Account { get; set; } //VIRTUAL - this is not phsically present in this table

    }
}
