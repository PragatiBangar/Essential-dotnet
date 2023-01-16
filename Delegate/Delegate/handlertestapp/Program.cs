using System;
using banking;

namespace handlertest
{
    public delegate void AccountOperation();
    class Program
    {
        static void Main(string[] args)
        {
            Handler theHandler = new Handler();
            AccountOperation operation1 = new AccountOperation(theHandler.BlockAccount);
            AccountOperation operation2 = new AccountOperation(theHandler.PayIncomeTax);     
            AccountOperation operation3 = new AccountOperation(theHandler.SendEmailNotification);
            AccountOperation operation = operation1;
            operation+=operation2;
            operation+=operation3;
            operation();
        }
    }
}
