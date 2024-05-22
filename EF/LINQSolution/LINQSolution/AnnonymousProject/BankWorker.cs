using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AccountProject;

namespace AnnonymousProject
{
    public static class BankWorker
    {
        public static void PrintStatement(this Account o)
        {
            Console.WriteLine("Printing Bank Account statement....");
            Console.WriteLine("Balance=" + o.Balance);
        }

        public static void ShowSMS(this Account o)
        {
            Console.WriteLine("SMS send");
        }
    }
}
