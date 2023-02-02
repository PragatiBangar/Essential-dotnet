
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CustomRoutingApp.Models;

namespace CustomRoutingApp.Controllers;

public class FarmsController : Controller
{
private readonly ILogger<FarmsController> _logger;

    public FarmsController(ILogger<FarmsController> logger)
    {
        _logger = logger;
    }

    public IActionResult GreenhouseDetails(string farmName, string unitNo)
    {
        Console.WriteLine("Farm name=" + farmName + "Greenhouse name=" +unitNo);
        return View();
    }

    public IActionResult CropDetails(string farmName, string unitNo, string cropName)
    {
        Console.WriteLine("Farm name=" + farmName + "Greenhouse name=" +unitNo+ "Crop name=" +cropName);
        return View();
    }

    public IActionResult CropDateDetails(string farmName, string unitNo,string cropName,string date)
        {
            Console.WriteLine("Farm name = "+ farmName + " Greenhouse name = "+ unitNo + "Crop name" +cropName+ "Date" +date);
            return View();
        }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
