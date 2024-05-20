using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReflection
{
    public class Calculator
    {
        public double Number { get; set; }
        public static double Pi { get; set; }
        public Calculator()
        {

            Pi = 3.14;
        }
        
        public void Clear() 
        { 
            Console.WriteLine("Clear All..."); 
        }
           
        public double Add(double number) 
        { 
            return Number + number;
        }
            
         public static double GetPi()
         {
            return Pi;     
          }
        }
    }

