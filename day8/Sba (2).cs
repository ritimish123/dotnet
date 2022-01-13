using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class SBAccount
    {
         public int accountNumber { get; set; }
         public string customerName { get; set; }
         public string customerAddress { get; set; }
        public double currentBalance { get; set; }
        //public int AccountNumber { get { return accountNumber; } set { accountNumber = value; } }
        //public string CustomerName { get { return customerName; } set { customerName = value; } }
       // public string CustomerAddress { get { return customerAddress; } set { customerAddress = value; } }
        //public double CurrentBalance { get { return currentBalance; } set { currentBalance = value; } }
        public SBAccount() { }
        public SBAccount(int accountNumber, string customerName, string customerAddress, double currentBalance)
        {
            this.accountNumber = accountNumber;
            this.customerName = customerName;
            this.customerAddress = customerAddress;
            this.currentBalance = currentBalance;
        }
        public override string ToString()
        {
            return accountNumber + "\t" + customerName + "\t" + customerAddress + "\t" + currentBalance;
        }
    }
}
