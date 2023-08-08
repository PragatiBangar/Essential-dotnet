using CatalogService.Models;
using System;
using System.Collections.Generic;

namespace CatalogService.Repositories.Interfaces
{
    public interface IProductRepository{     
    Task<List<Product>> GetAllProducts();
    Task<Product> GetProduct(int id);
    Task<bool> Insert(Product product);
    Task<bool> Update(Product product);
    Task<bool> DeleteProduct(int id);
    
    }
}