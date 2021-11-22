using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Infrastructure;
using Microsoft.AspNetCore.Http;
using WebApplication2.Models;
using System.Text.Json;

namespace WebApplication2.Pages
{
    public class CartModel : PageModel
    {
        private IStoreRepository repository;
        public CartModel(IStoreRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = CartBilgileri.Cart;
        }
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
        public IEnumerable<string> asd;
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            asd = repository.Products
                  .Select(x => x.MainCategory)
                  .Distinct()
                  .OrderBy(x => x);
        }
        //public IActionResult OnPost(long productId, string returnUrl)
        //{
        //    Product product = repository.Products
        //    .FirstOrDefault(p => p.ProductID == productId);
        //    Cart.AddItem(product, 1);
        //    return RedirectToPage(new { returnUrl = returnUrl });
        //}
        //public IActionResult OnPostRemove(long productId, string returnUrl)
        //{
        //    CartBilgileri.Cart.RemoveLine(CartBilgileri.Cart.Lines.First(cl =>
        //    cl.Product.ProductID == productId).Product);
        //    return RedirectToPage(new { returnUrl = returnUrl });
        //}
    }
}
