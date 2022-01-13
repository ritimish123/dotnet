using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    interface BankRepositoryInterface
    {
        void NewAccount(SBAccount acc);
        SBAccount GetAccountDetails(int accno);
        List<SBAccount> GetAllAccounts();
        void DepositAmount(int accno, double amt);
        void WithdrawAmount(int accno, double amt);
    }
}
