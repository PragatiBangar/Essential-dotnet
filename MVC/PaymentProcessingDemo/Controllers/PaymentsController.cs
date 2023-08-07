using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Core.Models;
using Core.Services.Interfaces;

namespace PaymentProcessingDemo.Controllers;

public class PaymentsController : Controller
{
    private IPaymentService _svc ;

    public PaymentsController(IPaymentService svc)
    {
        this._svc = svc;
    }

    public IActionResult Index()
    {   
        List<Payment> allProducts = _svc.GetPayments();
        return View(allProducts);
    }

    public IActionResult Details(int id)
    {
        Payment payment = _svc.GetPaymentById(id);
        this.ViewData["payment"] = payment;
        return View();
    }

    [HttpGet]
    public IActionResult Insert()
    {
        Payment payment = new Payment();
        payment.Id  = 12;
        payment.PaymentDate = DataTime.Now;
        payment.Amount = 0 ;
        payment.OrderId= 0;
        payment.PaymentMode = "UPI";
        return View(payment);
    }

    [HttpPost]
    public IActionResult Insert(Payment payment)
    {
        _svc.Insert(payment);
        return RedirectToAction("Index","Payments");
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        Payment payment = _svc.GetPaymentById(id);
        return View(payment);
    }

    [HttpPost]
    public IActionResult Update(Payment payment)
    {
        _svc.Update(payment);
        return RedirectToAction("Index", "Payments");
    }

    public IActionResult Delete(int id)
    {
        _svc.Delete(id);
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
