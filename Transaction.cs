using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    internal class Transaction
    {
        // prop prop = properties 

        public decimal Amount { get; }

        public DateTime Date { get; }

        public string Notes { get; }

        // CONSTRUCTOR to MAKE Transactions 

        public Transaction(decimal account, DateTime date, string note)
        {
            Amount = account;
            Date = date;
            Notes = note;
        }

    }
}
