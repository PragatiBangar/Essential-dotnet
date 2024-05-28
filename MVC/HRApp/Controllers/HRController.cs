using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HRApp.Models;
using HRConsoleApp.Repositories.Interfaces;
using HRApp.Entities;

namespace HRApp.Controllers;

public class HRController : Controller
{
    private readonly ILogger<HRController> _logger;

    private readonly IHRRepository _repo;

    public HRController(ILogger<HRController> logger, IHRRepository repo)
    {
        _repo = repo;
        _logger = logger;
    }

    public IActionResult GetAll()
    {
        List<Employee> employees = _repo.GetAll();
        return View(employees);
    }


    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
