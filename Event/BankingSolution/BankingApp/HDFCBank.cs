using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.AccountMgmt;
using BankingApp.Receivers;

namespace BankingApp
{
    public class HDFCBank
    {
        public HDFCBank() { }
        public void PerformBankingOperation(Account acct, AccountListener listener)
        {
            acct.deactivate += listener.DeactivateAccount;
            Console.WriteLine(acct.Balance);
            acct.Deposit(55000);
            Console.WriteLine(acct.Balance);
        }
    }
}
