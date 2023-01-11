using System;

namespace CentralGovtAdministration
{
    public class UPAGovtHandler
    {
        public void PayIncomeTax()
        {
            Console.WriteLine("Income tax is deducted 5%");
        }
        public void PayServiceTax()
        {
            Console.WriteLine("Service tax is deducted 10%");
        }
        public void PayProfessionalTax()
        {
            Console.WriteLine("Professional tax is deducted by 35%");
        }
    }
}