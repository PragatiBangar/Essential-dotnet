using Microsoft.AspNetCore.Mvc;
using DemoApp.Models;
using DemoApp.Helpers;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Core.Services.Interfaces;
using core.Services.Interfaces;

namespace DempApp.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IFlowerService _flowerService;

        public ShoppingCartController(IFlowerService flowerService)
        {
            _flowerService = flowerService;
        }
        public IActionResult Index()
        {
            Cart theCart = SessionHelper.GetObjectFromJson<Cart>(HttpContext.Session,"cart");
            return View(theCart);
        }
        
        [HttpGet]
        public IActionResult Add(int id)
        {
            Flower theFlower = _flowerService.GetById(id);
            Item theItem = new Item();
            theItem.theFlower = theFlower;
            theItem.Quantity= 0;
            return View(theItem);
        }

        [HttpPost]
        public IActionResult Add(Item newItem)
        {
            Cart theCart = SessionHelper.GetObjectFromJson<Cart>(HttpContext.Session, "cart");
            theCart.Items.Add(newItem);
            SessionHelper.SetObjectAsJson(HttpContext.Session,"cart", theCart);
            return RedirectToAction("Index","shoppingcart");

        }
         
        public IActionResult Remove(int id)
        {
            Cart theCart = SessionHelper.GetObjectFromJson<Cart>(HttpContext.Session, "cart");
            var found = theCart.Items.Find(x => x.theFlower.ID == id);
            if(found != null) theCart.Items.Remove(found);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", theCart);
            return RedirectToAction("Index", "ShoppingCart");
        } 
    }
}
