using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Components
{
    public class CartSummaryViewComponent:ViewComponent
    {
        private Cart cart;
        public CartSummaryViewComponent(Cart cartService)
        {
            cart = CartBilgileri.Cart;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
