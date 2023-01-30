using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DIWebApp.Models;

namespace DIWebApp.Controllers;

public class HomeController : Controller
{
    public readonly IHelloWorldService _helloWorldService;
    public HomeController(IHelloWorldService helloWorldService)
    {
        // are used for initialization
        this._helloWorldService = helloWorldService;
    }

    public IActionResult Index()
    {
        string message = this._helloWorldService.SaysHello();
        ViewData["message"] = message;
        return View();
    }

    public IActionResult Privacy()
    {
        string message = this._helloWorldService.SaysHello();
        ViewData["message"] = message;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
