using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankkonto
{
    public class Transaction
    {
        public double Amount { get; set; }
        public DateTime Date { get; }
        public string Notes { get; }
        
        public Transaction(double amount, DateTime dateTime, string note )
        { 
            Amount = amount;
            Date = dateTime;
            Notes = note;
        }

        
    }
}
