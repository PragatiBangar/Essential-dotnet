using System;
using System.Linq;
using System.Collections.Generic;

namespace AnalyticsTest
{
    class Person
    {
        public string FirstName {get; set; }
        public string LastName {get; set; }
        public int Age {get; set;}
    }

    public class Product
    {
        public int Likes {get; set; }
        public int Id {get; set; }
        public string Title {get; set; }
        public string Category {get; set; }
        public string Description {get; set; }
        public string ImageUrl {get; set; }
        public double UnitePrice {get; set;}
        public int Quantity {get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
          //FindAllNumbersMultipleOf2();
          //ShowAllNames();
          //GetReport();
          //TakeThree();
          //Skip();

        IEnumerable<string> fruits = GetFruitsOrderBy();     
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
        }

        //The preceding example loops through the entire collection of numbers and 
        //each element (named x) is checked to determine 
        //if the number is a multiple of 2 (using the Boolean expression (x % 2) == 0).
        static void FindAllNumbersMultipleOf2()
        {
            List<int> list = new List<int>() {1,2,3,4,5,6};
            List<int> evenNumbers = list.FindAll(x => (x % 2)==0);

            foreach(var num in evenNumbers)
            {   Console.WriteLine("{0}", num);   }
            Console.WriteLine();
        }

        //List that contains all the Participnats Name.
        static void ShowAllNames()
        {
            List<Person> participants = new List<Person>(){
                new Person { FirstName = "Pragati" , LastName = "Bangar", Age = 22},
                new Person { FirstName = "Neha" , LastName = "Bhor", Age = 21},
                new Person { FirstName = "Mayuresh" , LastName = "Wanjare", Age = 3},
                new Person { FirstName = "Umesh" , LastName = "Kumar", Age = 30},
                new Person { FirstName = "Swarali" , LastName = "Lakade", Age = 23},
                new Person { FirstName = "Ankur" , LastName = "Prasad", Age = 28}
            };

            var peopleResult = participants.Select( x => new{
                                                               Age = x.Age,
                                                               FirstLetter = x.FirstName,
                                                               LastNameLetter = x.LastName[0]
                                                            }
                                            );

            foreach (var person in peopleResult)
            {  Console.WriteLine(person);  }
        }
        // Get reports of all studetns names in UpperCase 
        // Where name consist of i, 
        // Order by length of characters
        static void GetReport()
        {
            string[] students = new string[] {"Neha", "Akanksha", "Mayuresh", "Shubham","Bill",
                                            "Rohit", "Siddhachakra", "Ajinkya", "Sumeet", "Hemant", "Monit",
                                            "Amol", "Rajiv", "Kimaya", "Santosh", "Nilesh", "Umesh", "Manishankar",
                                            "Amitabh","Swarali","Kamal","Steve","Priyadarshani","Jaiprakash",
                                            "Rutuja"
                                            };
            /*var filterNamebyChar = students.Where(n => n.Contains('i'));
            var NamesOrderedBy =filterNamebyChar.OrderBy( n => n.Length );
            var InUpperCase = NamesOrderedBy.Select(n => n.ToUpper());*/

            //  In short this can be written  as shown below:
            var InUpperCase = students.Where(n => n.Contains('i')).OrderBy(n => n.Length).Select(n => n.ToUpper());
                Console.WriteLine("\nStudents names containing i in Increasing order in Upper Case ");

                //Imperative Query Expressions result
                foreach(var item in InUpperCase)
                {  Console.WriteLine(item);  }
        }
        public static void TakeThree()
        {
            int[] numbers = {34,56,89,67,34,67,83,74,51};
            var first3Numbers = numbers.Take(3);
            foreach (var n in first3Numbers)
                {
                    Console.WriteLine(n);
                }
        }
        public static void Skip()
        {
            int[] numbers = {6,7,8,4,2,5,3,1,0};
            var allButFirstNumbers = numbers.Skip(4);
            Console.WriteLine("All but first 4 numbers:");
            foreach(var n in allButFirstNumbers)
            {
                Console.WriteLine(n);
            }
        }
        public static IEnumerable<string> GetFruitsOrderBy()
        {
            string[] fruits = {"apple", "Papaya", "cherry","blueberry", "banana", "mango"};
            //LINQ------HQL
            var sortedFruits = from fruit in fruits orderby fruit descending select fruit;

            return sortedFruits;
        }
    }
}

