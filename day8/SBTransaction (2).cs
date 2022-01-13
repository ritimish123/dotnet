using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class SBTransaction
    {
        public int transactionId { get; set; }
        public int accountNumber { get; set; }
        private string transactionDate { get; set; }
        private double amount { get; set; }
        private string transactionType { get; set; }
        //public int TransactionId { get { return transactionId; } set { transactionId = value; } }
       // public int AccountNumber { get { return accountNumber; } set { accountNumber = value; } }
       // public string TransactionDate { get { return transactionDate; } set { transactionDate = value; } }
       // public double Amount { get { return amount; } set { amount = value; } }
       // public string TransactionType { get { return transactionType; } set { transactionType = value; } }
        public SBTransaction() { transactionId = 0; }
        public SBTransaction(int transactionId, int accountNumber, string transactionDate, double amount, string transactionType)
        {
            this.transactionId = transactionId;
            this.accountNumber = accountNumber;
            this.transactionDate = transactionDate;
            this.amount = amount;
            this.transactionType = transactionType;
        }
        public override string ToString()
        {
            return transactionId + "\t" + accountNumber + "\t" + transactionDate + "\t" + amount + "\t" + transactionType;
        }
    }
}
