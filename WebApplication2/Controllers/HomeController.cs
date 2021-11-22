using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication2.Models;
using WebApplication2.Models.ViewModels;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public Cart Cart { get; set; }
        private IStoreRepository repository;
        public int PageSize = 8;
        static int Sayac = 0;
        public static Cart Cart2 = new Cart();

        public HomeController(IStoreRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;

        }
        public ViewResult Index(string category, int productPage = 1)
        {
            ViewBag.asd = repository.Products
               .Select(x => x.MainCategory)
               .Distinct()
               .OrderBy(x => x);

            if (Sayac == 0 || productPage == -7 || (AnaCategory.category == "" && category == null))
            {
                Sayac++;
                return View("Anasayfa", repository.Products
               .Select(x => x.MainCategory)
               .Distinct()
               .OrderBy(x => x));
            }
            else
            {
                if (productPage == -5)
                {
                    AnaCategory.category = category;

                    productPage = 1;


                    return View(new ProductsListViewModel
                    {
                        Products = repository.Products
                         .Where(p => p.MainCategory == AnaCategory.category)
                         .OrderBy(p => p.ProductID)
                         .Skip((0) * PageSize)
                         .Take(PageSize),
                        PagingInfo = new PagingInfo
                        {
                            CurrentPage = 1,
                            ItemsPerPage = PageSize,
                            TotalItems = category == null ?
                            repository.Products.Count() :
                            repository.Products.Where(e =>
                            e.MainCategory == AnaCategory.category).Count()
                        }
                    });
                }
                else if (productPage == -6 && category == "Hepsi")
                {
                    return View(new ProductsListViewModel
                    {
                        Products = repository.Products
                        .Where(p => p.MainCategory == AnaCategory.category)
                        .OrderBy(p => p.ProductID)
                        .Skip((0) * PageSize)
                        .Take(PageSize),
                        PagingInfo = new PagingInfo
                        {
                            CurrentPage = 1,
                            ItemsPerPage = PageSize,
                            TotalItems = category == null ?
                            repository.Products.Count() :
                            repository.Products.Where(e =>
                            e.MainCategory == AnaCategory.category).Count()
                        }
                    });
                }


                return View(new ProductsListViewModel
                {
                    Products = repository.Products
                 .Where(p => (category == null || p.Category == category) && p.MainCategory == AnaCategory.category)
                 .OrderBy(p => p.ProductID)
                 .Skip((productPage - 1) * PageSize)
                 .Take(PageSize),
                    PagingInfo = new PagingInfo
                    {
                        CurrentPage = productPage,
                        ItemsPerPage = PageSize,
                        TotalItems = category == null ?
                        repository.Products.Count() :
                        repository.Products.Where(e =>
                        e.Category == category).Count()
                    }
                });


            }

        }

        public ActionResult OnPost(long productId, string returnUrl)
        {
            Product product = repository.Products
            .FirstOrDefault(p => p.ProductID == productId);
            CartBilgileri.Cart.AddItem(product, 1);
            return RedirectToAction("Index", new ProductsListViewModel
            {
                Products = repository.Products
                         .Where(p => p.MainCategory == AnaCategory.category)
                         .OrderBy(p => p.ProductID)
                         .Skip((0) * PageSize)
                         .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = 0,
                    ItemsPerPage = PageSize,
                    TotalItems = product.Category == null ?
                                 repository.Products.Count() :
                                 repository.Products.Where(e =>
                                 e.Category == product.Category).Count()
                }
            });
        }

        public IActionResult Remove(long productId, string returnUrl)
        {
            CartBilgileri.Cart.RemoveLine(CartBilgileri.Cart.Lines.First(cl =>
            cl.Product.ProductID == productId).Product);
            return RedirectToPage("/Cart");
        }
    }
}
