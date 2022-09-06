using System;
using System.Collections.Generic;
using System.Text;

namespace BankApplicationAhmed.Models
{
    public class TransactionHistory
    {
        public decimal Amount { get; set; }
        public int UserId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TypeOfTransaction { get; set; }


    }
}
