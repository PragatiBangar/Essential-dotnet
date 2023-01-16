using System;
using banking;
using CentralGovtAdministration;

namespace EventTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler handler = new Handler();
            Account account1 = Account.Create(10000);
            account1.overBalance+= new Operation(handler.PayIncomeTax);
            account1.underBalance+= new Operation(handler.PayServiceTax);
        
            account1.Balance = 56000;
            
            Console.WriteLine("Before first deposit");
            account1.Deposit(200000);

            Console.WriteLine("After first deposit");
            account1.overBalance+= new Operation(handler.PayServiceTax);
            account1.Deposit(12000);

            Console.WriteLine("For another account instance...");
            Console.WriteLine("NDA");

            NDAGovtHandler handler2 = new NDAGovtHandler();
            Account account2 = Account.Create(37000);
            account2.overBalance+= new Operation(handler2.PayServiceTax);
            account2.Deposit(230000);
        }
    } 
}
