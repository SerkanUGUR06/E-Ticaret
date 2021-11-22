using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Components
{
    public class NavigationMenuViewComponent:ViewComponent
    {
        private IStoreRepository repository;
        public NavigationMenuViewComponent(IStoreRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Products.Where(x=>x.MainCategory==AnaCategory.category)
            .Select(x => x.Category)
            .Distinct()
            .OrderBy(x => x));
        }
    }
}
