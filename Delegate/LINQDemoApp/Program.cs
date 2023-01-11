using System;
using System.Reflection;

namespace LINQDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Program theProgram = new Program();
            Console.WriteLine(" Demo for reflection");
            Type theType1 = theProgram.GetType();
            Console.WriteLine("Type the program variable: " +theType1.Name);

            var instance = new {Id = 15, FirstName = "Pragati" , LastName = "Bangar",
                                EmailAddress = "bangarpragati11@gmail.com",
                                ContactNumber = "7498035692",
                                Location = new {
                                                  LandMark = "Akshara Milk",
                                                  City = "Pune",
                                                  State = "Maharashtra",
                                                  Country = "India"
                                }
            };

            Type theType2 = instance.GetType();
            Console.WriteLine("Type of theType2 " + theType2.Name);
            Console.WriteLine("Demo for Annonymous Data Type....");
            Console.WriteLine(instance.FirstName + " "+instance.LastName);
            Console.WriteLine(instance.Location.LandMark);
            Console.WriteLine(instance.Location.Country);
            Console.WriteLine(instance.Location.State);
        }
    }
}
