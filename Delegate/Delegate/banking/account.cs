using System;
namespace banking
{
    public delegate void Operation();
    public class Account
    {
        public double Balance{get; set; }

        public Account (double amount){
            this.Balance = amount;
        }
        public event Operation underBalance;
        public event Operation overBalance;
        
        public void Moniter()
        {
            Handler theHandler = new Handler();
            if(this.Balance < 5000){
                //theHandler.BlockAccount();
                underBalance();
            }
            else if(this.Balance >= 250000){
                //theHandler.PayIncomeTax();
                overBalance();
            }
        }
        public void Deposit(double amount){
            this.Balance+=amount;
            Moniter();
        }
        public void Withdraw(double amount){
            this.Balance-=amount;
            Moniter();
        }
        public static Account Create(double initialAmount){
            Account account = new Account(initialAmount);
            return account;
        }
    }
}