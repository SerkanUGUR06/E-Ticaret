using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository repository;
        private Cart cart;
        private IStoreRepository repoasd;
        public OrderController(IOrderRepository repoService, Cart cartService, IStoreRepository repo)
        {
            repository = repoService;
            cart = cartService;
            repoasd = repo;
        }
        public ViewResult Checkout() {

            ViewBag.asd = repoasd.Products
             .Select(x => x.MainCategory)
             .Distinct()
             .OrderBy(x => x);

            return View(new Order()); 
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            ViewBag.asd = repoasd.Products
            .Select(x => x.MainCategory)
            .Distinct()
            .OrderBy(x => x);

            if (CartBilgileri.Cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }
            if (ModelState.IsValid)
            {
                order.Lines = CartBilgileri.Cart.Lines.ToArray();
                repository.SaveOrder(order);
                CartBilgileri.Cart.Clear();
                return RedirectToPage("/Completed", new { orderId = order.OrderID });
            }
            else
            {
                return View();
            }
        }
    }
}
