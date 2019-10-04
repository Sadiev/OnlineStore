using Ecommerce.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private ApplicationDbContext repository;
        public NavigationMenuViewComponent(ApplicationDbContext repo)
        {
            repository = repo;
        }
        
        public IViewComponentResult Invoke()
        {
           // string controller = RouteData.Values["category"].ToString();
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Categories
                //.Select(x => x.CategoryName)
                .Distinct()
                .OrderBy(x => x));
        }
        //public string Invoke()
        //{
        //    return "Hello from the Nav View Component";
        //}
    }
}
