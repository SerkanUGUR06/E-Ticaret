using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class CompletedModel : PageModel
    {
        private Models.IStoreRepository repoasd;
        public IEnumerable<string> asd;
        public CompletedModel(Models.IStoreRepository repo)
        {
            repoasd = repo;
        }

        public void OnGet()
        {
            asd = repoasd.Products
                  .Select(x => x.MainCategory)
                  .Distinct()
                  .OrderBy(x => x);
        }
    }
}
