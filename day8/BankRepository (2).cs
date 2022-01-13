using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
	class InsufficientBalanceException : Exception
	{
		public InsufficientBalanceException(string message) : base(message)
		{

		}
	}
	class BankRepository : BankRepositoryInterface
	{
		List<SBAccount> sbaccount = new List<SBAccount>();
		List<SBTransaction> sbtransaction = new List<SBTransaction>();
		SBAccount sba = new SBAccount();
		SBTransaction sbt = new SBTransaction();
		public void NewAccount(SBAccount acc)
		{
			sbaccount.Add(acc);
		}
		public SBAccount GetAccountDetails(int accno)
		{
			for (int i = 0; i < sbaccount.Count; i++)
			{
				if (sbaccount.ElementAt(i).accountNumber == accno)
				{
					return sbaccount.ElementAt(i);
				}
			}
			return null;
		}
		public List<SBAccount> GetAllAccounts()
		{
			Console.WriteLine("AccoNo\tName\tAddress\tBalance");
			foreach (var acc in sbaccount)
			{
				Console.WriteLine("\t" + acc + " \t	\t");
			}
			return null;
		}
		public void DepositAmount(int accno, double amt)
		{
			for (int i = 0; i < sbaccount.Count; i++)
			{
				if (sbaccount[i].accountNumber == accno)
				{
					sbaccount[i].currentBalance = sbaccount[i].currentBalance + amt;
					sbtransaction.Add(new SBTransaction(sbt.transactionId++, sbaccount[i].accountNumber, DateTime.Now.Date.ToShortDateString(), amt, "deposit"));
				}
			}
		}
		public void WithdrawAmount(int accno, double amt)
		{
			for (int i = 0; i < sbaccount.Count; i++)
			{
				if (sbaccount[i].accountNumber == accno)
				{
					if (sbaccount[i].currentBalance > amt)
					{
						sbaccount[i].currentBalance = sbaccount[i].currentBalance - amt;
						sbtransaction.Add(new SBTransaction(sbt.transactionId++, sbaccount[i].accountNumber, DateTime.Now.Date.ToShortDateString(), amt, "withdraw"));
					}
					else
					{
						throw new InsufficientBalanceException("There is insufficent balance in your account");
					}
				}
			}
		}
		public List<SBTransaction> GetTransactions(int accno)
		{
			List<SBTransaction> transaction = new List<SBTransaction>();
			for (int i = 0; i < sbtransaction.Count; i++)
			{
				if (sbtransaction.ElementAt(i).accountNumber == accno)
				{
					transaction.Add(sbtransaction.ElementAt(i));
				}
			}
			return transaction;
		}
	}

}