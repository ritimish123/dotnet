using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
	public class BankException : Exception
	{
		public BankException(String message) : base(message)
		{
		}
	}
	public class ScreenDescription
	{
		BankRepository br = new BankRepository();
		public void showBankScreen()
		{
			Console.WriteLine("You are in main screen");
			Console.WriteLine("---Welcome to Account Dashboard---");
			Console.WriteLine("\nEnter your choice:\n1.Add new Account\n2.Get Account Details\n3.Show all Account Details\n4.Deposit Amount\n5.Withdraw Amount\nGet all the transactions\n");
			int ch = Convert.ToInt32(Console.ReadLine());
			switch (ch)
			{
				case 1:
					showAddAccount();
					break;
				case 2:
					showAccount();
					break;
				case 3:
					showAllAcounts();
					break;
				case 4:
					getDepositAmount();
					break;
				case 5:
					try
					{
						getWithdrawAmount();
					}
					catch (InsufficientBalanceException e)
					{
						Console.WriteLine(e);
					}
					break;
				case 6:
					List<SBTransaction> t = new List<SBTransaction>();
					Console.WriteLine("Enter the account number :");
					int accountNumber = Convert.ToInt32(Console.ReadLine());
					t = br.GetTransactions(accountNumber);
					foreach (var v in t)
					{
						Console.WriteLine(v);
					}

					break;
				default:
					Console.WriteLine("Please enter correct choice");
					break;
			}
		}
		public void showAddAccount()
		{
			Console.WriteLine("Enter the account number :");
			int accountNumber = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the customer name :");
			string customerName = Console.ReadLine();
			Console.WriteLine("Enter the customer address :");
			string customerAddress = Console.ReadLine();
			Console.WriteLine("Enter the current balance :");
			double currentBalance = Convert.ToDouble(Console.ReadLine());
			br.NewAccount(new SBAccount(accountNumber, customerName, customerAddress, currentBalance));
		}
		public void showAccount()
		{
			SBAccount sba = new SBAccount();
			Console.WriteLine("Enter the account number :");
			int accountNumber = Convert.ToInt32(Console.ReadLine());
			sba = br.GetAccountDetails(accountNumber);
			try
			{
				if (sba == null)
					throw new BankException("The account number you entered is not present");
				else
				{
					Console.WriteLine(sba.customerName + "\t" + sba.customerAddress + "\t" + sba.currentBalance);
				}
			}
			catch (BankException e)
			{
				Console.WriteLine(e);
			}
		}
		public void showAllAcounts()
		{
			br.GetAllAccounts();
		}
		public void getDepositAmount()
		{
			Console.WriteLine("Enter the account number :");
			int accountNumber = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the  amount to be deposited :");
			double amount = Convert.ToDouble(Console.ReadLine());
			br.DepositAmount(accountNumber, amount);
		}
		public void getWithdrawAmount()
		{
			Console.WriteLine("Enter the account number :");
			int accountNumber = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the  amount to be Withdraw :");
			double amount = Convert.ToDouble(Console.ReadLine());
			br.WithdrawAmount(accountNumber, amount);
		}

	}
}
