using System;
using System.Collections.Generic;

namespace EStoreDBEFApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Microlearning : Transflower");

            IDBManager dbm = new DBManager();
            bool status = true;

            while(status)
            {
                Console.WriteLine("choose Option:");
                Console.WriteLine("1. Display records");
                Console.WriteLine("2. Display by Id");
                Console.WriteLine("3. Insert new record");
                Console.WriteLine("4. Update existing record");
                Console.WriteLine("5. Delete existing record");
                Console.WriteLine("6. Exit");

                switch(int.Parse(Console.ReadLine()))
                {

                    //display products
                    case 1:
                    {
                        List<Product> allProducts= dbm.GetAll();
                        foreach (var product in allProducts)
                        {
                            Console.WriteLine("Id:{0} , Title:{1} ,Description:{2}, UnitPrice:{3} , Quantity:{4}",
                                            product.Id,product.Title,product.Description,product.UnitPrice,
                                            product.Quantity);

                        }
                    }
                    break;

                    case 2:{
                        int Id = int.Parse(Console.ReadLine());
                        Product product=dbm.GetById(Id);
                        Console.WriteLine("Id:{0} , Title:{1} ,Description:{2}, UnitPrice:{3} , Quantity:{4}",
                                          product.Id,product.Title,product.Description,product.UnitPrice,
                                          product.Quantity);
                    }
                    break;
                    //Insert new product
                    case 3:
                    
                        var newProduct = new Product()
                        {
                            Id = 4,
                            Title = "Jasmine",
                            Description = "blue flower",
                            UnitPrice = 34,
                            Quantity = 4900
                        };
                        dbm.Insert(newProduct);
                    break;

                    //Update existing Product
                    case 4:
                    {
                        var updateProduct = new Product()
                        {
                            Id = 4,
                            Title = "Aster",
                            Description = "Pink flower",
                            UnitPrice = 49,
                            Quantity = 8900
                        };
                        dbm.Update(updateProduct);
                    break;
                    }

                    // Delete existing Product
                    case 5:
                        dbm.Delete(4);
                    break;

                    //Exit from loop
                    case 6:
                        status = false;
                    break;
                }
            }
        }
    }
}
