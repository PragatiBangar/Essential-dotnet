using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DIWebApp.Models;
using DIWebApp.Services;

namespace DIWebApp.Controllers;

public class HomeController : Controller
{
    public readonly IHelloWorldService _HelloWorldService;
    public readonly IProductCatalogService _ProductCatalogService;

    public HomeController(IHelloWorldService HelloWorldService, IProductCatalogService ProductCatalogService)
    {
        // are used for initialization
        this._HelloWorldService = HelloWorldService;
        this._ProductCatalogService = ProductCatalogService;
    }

    public IActionResult Index()
    {
        string message = this._HelloWorldService.SaysHello();
        ViewData["message"] = message;
        bool status = this._ProductCatalogService.Insert();
        return View();
    }

    public IActionResult Privacy()
    {
        string message = this._HelloWorldService.SaysHello();
        ViewData["message"] = message;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
