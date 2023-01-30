using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DIWebApp.Models;
using DIWebApp.Services;

namespace DIWebApp.Controllers;

public class HomeController : Controller
{
    public readonly IHelloWorldService _HelloWorldService;
    public HomeController(IHelloWorldService HelloWorldService)
    {
        // are used for initialization
        this._HelloWorldService = HelloWorldService;
    }

    public IActionResult Index()
    {
        string message = this._HelloWorldService.SaysHello();
        ViewData["message"] = message;
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
