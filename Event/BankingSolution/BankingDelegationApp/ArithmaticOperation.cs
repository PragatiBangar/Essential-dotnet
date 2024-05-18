using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDelegationApp
{
    public class ArithmaticOperation
    {
        public int Addition(int num1,int num2) 
        {
            int result = num1 + num2;
            Console.WriteLine("Addition="+result);  
            return result;       
        }

        public int Substraction(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine("Substraction="+result);
            return result;
        }

        public int Multiplication(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine("Multiplication="+result);
            return result;
        }

        public int Division(int num1, int num2)
        {
            int result = num1 / num2;
            Console.WriteLine("Division="+result);
            return result;
        }
    }
}
