using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    public class BankAccount
    {
        // prop tab tab = PROPERTIES  
        public string Number { get; } // Number is only getter. Once number has been assigned, you are unable to set it 
        public string Owner { get; set; }

        public decimal Balance // Getter becomes a behavior/function of sorts 
        {
            get
            {
                decimal balance = 0;   
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;

            }
        }

        private static int accountNumberSeed = 123456789; // Static means its shared across bank accounts. Private means its only avaliable in this class 


        private List<Transaction> allTransactions = new List<Transaction>();

        // CONSTRUCTOR - To MAKE bank account  

        public BankAccount(string name, decimal initialBalance)
        {
            Owner = name; // Setting the variable 

            MakeDepoist(initialBalance, DateTime.Now, "Initial Balance");

            Number = accountNumberSeed.ToString();
            accountNumberSeed++; // Increment so every new bank account number is different 
        }



        // Methods  
        public void MakeDepoist(decimal amount, DateTime date, string note)
        {
            
            if(amount <= 0) // If you try to deposit negative amount 
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);  
            allTransactions.Add(deposit);

        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if(Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);

        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();

            report.AppendLine("Date\t\tAmmount\t\tNote");
            foreach (var item in allTransactions) 
            {
                // ROWS 
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t\t{item.Notes}");
            }
            return report.ToString();

        }



    }
}
