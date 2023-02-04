using System.Collections.Generic;

namespace BIApp.Models
{
    public class SalesRepository
    {
        public List<Product> products = new List<Product>();
        public List<Customer> customers = new List<Customer>();

        public SalesRepository()
        {
            products = FillProducts();
            customers = FillCustomers();
        }

        private List<Product> FillProducts()
        {
            products.Add( new Product() {  Title = "Gerbera" , Description = "Wedding Flower" , Quantity = 3647 });
            products.Add( new Product() {  Title = "Lilly" , Description = "Decoration Flower" , Quantity = 5671 });
            products.Add( new Product() {  Title = "Jasmine" , Description = "Smelling Flower" , Quantity = 4532 });
            products.Add( new Product() {  Title = "Marigold" , Description = "Festival Flower" , Quantity = 4500 });
            products.Add( new Product() {  Title = "carnation" , Description = "Beautiful Flower" , Quantity = 4000 });
            return products;
        }
        private List<Customer> FillCustomers()
        {
            customers.Add(new Customer { Name = "Rajan Patil" , Age = 28 , Location = "Mumbai"});
            customers.Add(new Customer { Name = "Mangesh More" , Age = 22 , Location = "Pune"});
            customers.Add(new Customer { Name = "Shiv Kumar" , Age = 25 , Location = "Nashik"});
            customers.Add(new Customer { Name = "Rajan Bhor" , Age = 30 , Location = "Beed"});
            return customers;
        }

    }
}