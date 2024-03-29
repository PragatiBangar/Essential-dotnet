using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TransflowerWebApp.Models;

namespace TransflowerWebApp.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {   
        List<string> products = new List<string>();
        products.Add("Lily");
        products.Add("Jasmine");
        products.Add("Marigold");
        products.Add("Auster");

        ViewData["allProducts"] = products;

        return View();
    }

    public IActionResult Insert()
    {
        return View();
    }

    public IActionResult Details()
    {
        return View();
    }

    public IActionResult Update()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
