using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.AccountMgmt
{
    public class Account
    {
        public double Balance { get; set; }

        public Account(double amount)
        {
            Balance = amount;
        }

        public void Withdraw(double amount)
        {
            double predictableBalance = Balance - amount;
            this.Balance = predictableBalance;
        }

        public void Deposit(double amount)
        {
            double changedBalance = Balance + amount;
            this.Balance = changedBalance;
        }
    }
}
