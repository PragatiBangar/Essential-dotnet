using BloggersWebAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using BloggersWebAPI.Entities;

namespace BlogControllerWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = 10.99m },
                new Product { Id = 2, Name = "Product 2", Price = 19.99m },
                new Product { Id = 3, Name = "Product 3", Price = 29.99m }
            };
            return products;
        }
    }
}
