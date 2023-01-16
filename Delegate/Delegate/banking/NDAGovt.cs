using System;

namespace CentralGovtAdministration
{
    public class NDAGovtHandler
    {
        public void PayIncomeTax()
        {
            Console.WriteLine("Income tax is deducted 10%");
        }
        public void PayServiceTax()
        {
            Console.WriteLine("Service tax is deducted 14%");
        }
        public void PayProfessionalTax()
        {
            Console.WriteLine("Professional tax is deducted 8%");
        }
    }
}