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

        /*IEnumerable<string> fruits = GetFruitsOrderBy();     
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            */

        //SimpleUnion();
        //SimpleIntersect();
        //SimpleExcept();
        //ToSimpleList();
        //ToDictionary();
        
        /*Console.WriteLine("sorted products:")
        IEnumerable<Product> sortedProducts =GetProductsOrderBy();
        foreach(var product in sortedProducts)
        {
             Console.WriteLine(product.Quantity+" "+product.Title);
        }
         */
         /*
        Console.WriteLine("sold out products:");
        IEnumerable<Product> soldOutProducts =GetSoldOutProducts();
        // UI logic layer : console UI
        foreach(var prod in soldOutProducts)
        {
             Console.WriteLine(prod.Title+" "+prod.UnitePrice+" "+prod.Quantity);
        }
         */
         /*
        Console.WriteLine("expensive in stock products:");
        IEnumerable<Product> expensiveInStockProducts =GetProductsInStockLessThan();
        // UI logic layer : console UI
        foreach(var prod in expensiveInStockProducts)
        {
            Console.WriteLine(prod.Title+" "+prod.UnitePrice+" "+prod.Quantity);
        }
        */
        Console.WriteLine(" product details:");
        IEnumerable<Product> productInfo = GetProductDetails();
        foreach(var prod in productInfo)
        {
            Console.WriteLine(prod.Title+" "+prod.Category+" "+prod.UnitePrice+" "+prod.Likes);
        }
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
        public static void SimpleUnion()
        {
            int[] numbersA = {0, 2, 4, 6, 8, 9 };
            int[] numbersB = {1, 3, 5, 7, 8};

            var uniqueNumbers = numbersA.Union(numbersB);
            Console.WriteLine("Unique numbers from both arrays");
            foreach(var numbers in uniqueNumbers)
            {
                Console.WriteLine(numbers);
            }
        }

        public static void SimpleIntersect()
        {
            int[] numbersX = {1, 3, 4, 7, 9, 0};
            int[] numbersY = {1, 2, 3, 9, 6, 5};

            var commonNumbers = numbersX.Intersect(numbersY);
            Console.WriteLine("common numbers shared by both arrays:");
            foreach(var n in commonNumbers)
            {
                Console.WriteLine(n);
            }
        }

        public static void SimpleExcept()
        {
            int[] numbersP = {0, 1, 2, 3, 4, 5};
            int[] numbersQ = {6, 7, 8, 9, 0};
            IEnumerable<int> firstArray = numbersP.Except(numbersQ);
            Console.WriteLine("Numbers in first array but not second array:");
            foreach(var num in firstArray)
            {
                Console.WriteLine(num);
            }
        }

        public static void ToSimpleList()
        {
            string[] words = {"cherry", "apple", "banana"};
            var sortedWords = 
                              from word in words
                              orderby word
                              select word;
            var wordList =  sortedWords.ToList();

            Console.WriteLine("The sorted word list:");
            foreach(var word in words)
            {
                Console.WriteLine(word);
            }
        }

        public static void ToDictionary()
        {
                var scoreRecords = new[] {   new {   Name = "Ankur", score = 89 },
                                             new {   Name = "Pralhad", score = 67 },
                                             new {   Name = "Vishwajeet", score = 78 },
                                             new {   Name = "Saurav", score = 58 },
                                             new {   Name = "Kanchan", score = 45 },
                                             new {   Name = "Rutuja", score = 45 },
                                             new {   Name = "Swarali", score = 45 }
            
                };
                   var scoreRecordsDict = scoreRecords.ToDictionary(sr => sr.Name);
        }

        //Getting data from repositories

        //Data Access logic layer
        public static IEnumerable<Product> GetAllProducts()
        {
            List<Product> allProducts = new List<Product>();
            allProducts.Add(new Product { Id = 1, Title = "Gerbera", UnitePrice = 6, Category = "Flower",  Quantity = 5000, Likes = 4000});
            allProducts.Add(new Product { Id = 2,Title = "Rose",UnitePrice =15 , Category = "Flower", Quantity = 7000 , Likes = 6000});
            allProducts.Add(new Product { Id = 3,Title = "Lotus",UnitePrice = 45, Category = "Flower", Quantity =5999 , Likes = 3000 });
            allProducts.Add(new Product { Id = 4,Title = "Carnation" ,UnitePrice = 45, Category = "Flower", Quantity = 0 , Likes =1500 });
            allProducts.Add(new Product { Id = 5,Title = "Lily" ,UnitePrice = 67, Category ="Flower" , Quantity = 2300, Likes =5500 });
            allProducts.Add(new Product { Id = 6,Title = "Jasmine" ,UnitePrice =34 , Category ="Flower" , Quantity =23000 , Likes = 800 });
            allProducts.Add(new Product { Id = 7,Title = "Daisy",UnitePrice = 90, Category = "Flower", Quantity =50000 , Likes =60000 });
            allProducts.Add(new Product { Id = 8,Title = "Aster",UnitePrice = 78, Category ="Flower" , Quantity = 4500, Likes =5600 });
            allProducts.Add(new Product { Id = 9,Title = "Daffodil",UnitePrice = 42, Category = "Flower", Quantity = 0, Likes =6700 });
            allProducts.Add(new Product { Id = 10,Title = "Dahlia",UnitePrice = 76, Category = "Flower", Quantity = 1000, Likes =560 });
            allProducts.Add(new Product { Id = 11,Title = "Tulip",UnitePrice = 400, Category ="Flower" , Quantity =567 , Likes = 789});
            return allProducts;

        }
        public static IEnumerable<Product> GetAllProductsFromDatabase()
        {
            List<Product> allProducts = new List<Product>();
            // Data Access Logic from Database ( DAL)
            // querying   against mySQL Database
            // database connectivity code
            // fill all products list
            // return back to caller
            return allProducts;
        }
        public static IEnumerable<Product> GetAllProductsFromJSONFile(){

        List<Product> allProducts = new List<Product>();
        // Data Access Logic from getting data from JSON file
        // Using JSON Serialization
        // fill all products list
        // return back to caller
        return allProducts;
        }

        public static IEnumerable<Product> GetAllProductsFromBinaryFile(){

            List<Product> allProducts = new List<Product>();
            // Data Access Logic from getting data from binary file
            // Using Binary Serialization
            // fill all products list
            // return back to caller
            return allProducts;
        }

        public static IEnumerable<Product> GetAllProductsFromMongoDB(){

            List<Product> allProducts = new List<Product>();
            // Data Access Logic from getting data from Mongo DB database
            // Using using some Mongo DB connector
            // fill all products list
            // return back to caller

            // What are the apis provided by .NET Core Connector 
            // for performing CRUD Operations
            // Create, Read, Update and Delete
            
            return allProducts;
        }
        
        public static IEnumerable<Product> GetProductsOrderBy()
        {
            IEnumerable<Product> products = GetAllProducts();
            //IEnumerable<Product> products = GetAllProductsFromMongoDB();
            //IEnumerable<Product> products = GetAllProductsFromJSONFile();
            //IEnumerable<Product> products = GetAllProductsFromDatabase();
            var sortedProducts = from product in products       
                                 orderby product.Quantity
                                 select product;
            return sortedProducts;
        }
        //Business logic layer
        public static IEnumerable<Product> GetSoldOutProducts()
        {
            IEnumerable<Product> products = GetAllProducts();
            var SoldOutProducts = from prod in products
                                  where prod.Quantity == 0
                                  select prod;
            return SoldOutProducts;
        }
        public static IEnumerable<Product> GetProductsInStockLessThan()
        {
            IEnumerable<Product> products = GetAllProducts();
            var expensiveInStockProducts =
                    from prod in products
                    where prod.Quantity > 0 && prod.UnitePrice > 76
                    select prod;
            return expensiveInStockProducts;
        }
        public static dynamic GetProductDetails()
        {
            IEnumerable<Product> products = GetAllProducts();
            var productInfos  =
                                          from prod in products
                                          select new { prod.Title,prod.Category, Price = prod.UnitePrice };
            return productInfos;
        }
        public static IEnumerable<string> GetProductsDistinct()
        {
            IEnumerable<Product> products = GetAllProducts();

            var categoryNames = ( from prod in products
                                select prod.Category
                                ).Distinct();
            
            return categoryNames;
        } 
        public static dynamic  GetProductCount()
        {
            IEnumerable<Product> products = GetAllProducts();
            var categoryCounts =
                                from prod in products
                                group prod by prod.Category into prodGroup
                                select new { Category = prodGroup.Key, ProductCount = prodGroup.Count() };
            return categoryCounts;
        }
    }
}

