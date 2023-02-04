using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BIApp.Models;
using System.Collections.Generic;

namespace BIApp.Controllers;

public class HomeController : Controller
{
    public HomeController()
    {
        
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult AboutUs()
    {
        //using viewdata
        string name = "Transflower learning Pvt.Ltd.";
        ViewData["company"] = name;
        return View();
    }

    public IActionResult ContactUs()
    {
        //using viewBag
        string url = "www.transflower.in";
        var product = new Product{Id = 23, Title = "Rose"};
        ViewBag.product = product;
        ViewBag.website = url;
        ViewBag.school = "Transflower school";
        ViewBag.age = 76;
        return View();
    }
    
    public IActionResult Services()
    {
        //using TempData
        string service = "Transforming Digital India";
        TempData["vision"] = service;
        return View();
    }

    public IActionResult SalesView()
    {
        SalesRepository list = new SalesRepository();
        ViewBag.Message = "Transflower Sales!";
        return View(list);
    }

    public IActionResult Students()
    {
        List<string> data = new List<string>();
        data.Add("Ajinkya");
        data.Add("Rohit");
        data.Add("Swarali");
        data.Add("Neha");
        data.Add("Rutuja");
        var result = data.ToArray();
        return new JsonResult(result);
    }

    public IActionResult List()
    {
        SalesRepository repository = new SalesRepository();
        return new JsonResult(repository.products);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
