using CatalogService.Models;
using MySql.Data.MySqlClient;
using CatalogService.Repositories.Interfaces;
using System.Collections.Generic;
using System;
using System.Linq;
using CatalogService.Repositories.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CatalogService.Repositories
{
    public class ProductRepository : IProductRepository
    {
    private IConfiguration _configuration;
    public ProductRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<List<Product>> GetAllProducts()
        {
            using (var context = new ProductContext(_configuration))
            {
                var products = await context.Products.ToListAsync();
                return products;
            }           
        }

        public async Task<Product> GetProduct(int id)
        {
            using (var context = new ProductContext(_configuration))
            {
                var product = await context.Products.FindAsync(id);
                return product;
            }           
        }
        public async Task<bool> Insert(Product product)
        {
            bool status=false;
            using (var context = new ProductContext(_configuration))
            {
                await context.Products.AddAsync(product);
                int rowsAffected=context.SaveChanges();
                if(rowsAffected>0){
                    status=true;
                };
                return status;
            }   
        }

        public async Task<bool> Update(Product product)
        {
            bool status=false;
            using (var context = new ProductContext(_configuration))
            {
                Product theProduct = await context.Products.FindAsync(product.Id);
                theProduct.Title = product.Title;
                theProduct.Description = product.Description;
                theProduct.Quantity = product.Quantity;
                theProduct.UnitPrice = product.UnitPrice;
                int rowsAffected=context.SaveChanges();
                if(rowsAffected>0){
                    status=true;
                };
                return status;
            }
            
        }
        public async Task<bool>  DeleteProduct(int id)
        {
            bool status=false;
            using (var context = new ProductContext(_configuration))
            {
                var product= await context.Products.FindAsync(id);
                if(product==null){
                    return status;
                }    
                context.Products.Remove(product);
                int rowsAffected=context.SaveChanges();
                if(rowsAffected>0){
                    status=true;
                };
                return status;
            }
            
        }
    }
}
    