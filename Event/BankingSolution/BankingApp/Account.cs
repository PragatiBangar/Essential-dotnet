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

        public event EventHandler<EventArgs> deactivate;
        public Account(double amount ) { 
            Balance = amount;
        }

        public void Withdraw( double amount )
        {
            double  predictableBalance=Balance- amount;

            if (predictableBalance <= 10000)
            {
                EventArgs eventArgs = new EventArgs();
                deactivate(this, eventArgs);
            }
            this.Balance = predictableBalance;
        }

        public void Deposit(double amount ) {
            double changedBalance = Balance + amount;
            if(changedBalance >= 100000)
            {
                EventArgs eventArgs = new EventArgs();
                deactivate(this, eventArgs);
            }
            this.Balance = changedBalance;
        }
    }
}
