using CatalogService.Models;
using Microsoft.AspNetCore.Mvc;
using CatalogService.Service.Interfaces;
using System.Net.Http.Headers;

namespace CatalogService.Controllers;

[ApiController]
[Route("/api/products")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _service;

    public ProductsController(IProductService service)
    {
        _service = service;
    }
     

    // http://localhost:5137/api/products
    // this method gives list of all products.
    [HttpGet]
    public async Task<List<Product>> GetAll()
    {
        List<Product> products = await _service.GetAllProducts();
        return products;
    }

    //http://localhost:5137/api/products/product/{id}
    //this method gives product by id.
    [HttpGet("product/{id}")]
    public async Task<Product> GetById(int id)
    {
        Product product = await _service.GetProduct(id);
        return product;
    }

    //this method is used for insert product
    //http://localhost:5137/api/products
    
    [HttpPost]
    public async Task<bool> Insert([FromBody] Product product)
    {
        bool result = await _service.Insert(product);
        return result;
    }
    

    [HttpPut]
    //this method is used for Update product
    //http://localhost:5137/api/products
    public async Task<bool> Update([FromBody] Product product)
    {
        bool result =await  _service.Update(product);
        return result;
    }

    //this method is used for delete product.
    //http://localhost:5137/api/products/{id}
    [HttpDelete("{id}")]
    public async Task<bool> DeleteProduct(int id)
    {
        bool result = await _service.DeleteProduct(id);
        return result;
    }
}
 