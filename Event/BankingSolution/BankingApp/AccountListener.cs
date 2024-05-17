using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.AccountMgmt;

namespace BankingApp.Receivers
{
    public class AccountListener
    {
        public AccountListener() { }
        public void DeactivateAccount(object? sender,EventArgs e)
        {
            Console.WriteLine("Your Account has been deactivated due to insufficient funds");
        }
    }
}
