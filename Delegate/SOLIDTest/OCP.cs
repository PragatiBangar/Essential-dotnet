using System;

//Open Closed Principle (OCP)

namespace OCP
{
    public class Account
    {
        public decimal Interest {get; set; }
        public decimal Balance {get; set; }

        //members and function declaration
        public decimal CalcInterest(string accType)
        {
            if (accType == "Regular")  //saving
            {
                Interest = (Balance * 4) / 100;
                if (Balance < 1000) Interest -= (Balance * 2) / 100;
                if (Balance < 5000) Interest += (Balance * 4) / 100;
            }
            else if (accType == "Salary") //salary savings
            {
                Interest = (Balance * 5) / 100;
            }
            else if (accType == "Corporate")  //Corporate
            {
                Interest = (Balance * 3) / 100;
            }
            return Interest;
        }
    }

    interface IAccount
    {
        //member and function declaration , Properties
        decimal Balance {get; set;}
        decimal CalcInterest();
    }
    //Regular savings account
    public class RegularSavingAccount : IAccount
    {
        public decimal Balance{get; set; } = 0;
        public decimal CalcInterest()
        {
            decimal Interest = (Balance * 4) / 100;
            if (Balance < 1000) Interest -= (Balance * 2) / 100;
            if (Balance < 5000) Interest += (Balance * 4) / 100;
            return Interest;
        }
    }
    // salary savings account
    public class SalarySavingAccount : IAccount
    {
        public decimal Balance{get; set; } = 0;
        public decimal CalcInterest()   
        {
            decimal Interest = (Balance * 5) / 100;
            return Interest;
        }
    }
    //corporate account
    public class CorporateAccount : IAccount
    {
        public decimal Balance{get; set; } = 0;
        public decimal CalcInterest() 
        {
            decimal Interest = (Balance * 5) / 100;
            return Interest;  
        }  
    }
/* 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Open closed principle (OCP)");
        }
    }*/
}