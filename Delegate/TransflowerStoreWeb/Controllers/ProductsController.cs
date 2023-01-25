using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TransflowerStoreWeb.Models;
using Catalog;

namespace TransflowerStoreWeb.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Product> allProducts = Catalog.ProductManager.GetAllProducts();
        this.ViewData["products"] = allProducts;
        return View();
    }

    public IActionResult Details(int id)
    {
       Product product = ProductManager.Get(id);
       this.ViewData["product"] = product ;
       return View();
    }

    [HttpGet]
    public IActionResult Insert()
    {
       Console.WriteLine("Get HTTP insert method is invoked before empty sends to client");
       return View();
    }

    [HttpPost]
    public IActionResult Insert(int Id, string Title,string Description,int Quantity, int UnitPrice, string ImageUrl)
    {
      Product product = new Product(){
         Id = Id,
         Title = Title,
         ImageUrl = ImageUrl,
         Description = Description,
         Quantity = Quantity,
         UnitPrice = UnitPrice
      };
      ProductManager.Insert(product);

       Console.WriteLine("POST HTTP update method is invoked after form submission");
       return View();
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
       Product product = ProductManager.Get(id);
       Console.WriteLine("Get HTTP insert method is invoked before empty sends to client");
       return View(product);
    }

    [HttpPost]
    public IActionResult Update(Product modifiedProduct)
    {
       ProductManager.Update(modifiedProduct);
       Console.WriteLine("Post HTTP insert method is invoked after form submission");
       return RedirectToAction("Index","products");
    }

    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
