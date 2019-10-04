using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Data;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public class ProductsController : Controller
    {
        ApplicationDbContext db;
        public int PageSize = 6;
        public ProductsController(ApplicationDbContext db)
        {
            this.db = db;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //Adding Pagination
        public ViewResult Index(int category, int productPage = 1)
            => View(new ProductsListViewModel {
                Products = db.Products
                .Where(p => category == 0 || p.CategoryID == category)
                .OrderBy(p => p.ProductID)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfoViewModel {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = category == 0 ?
                    db.Products.Count() :
                    db.Products.Where(e =>
                    e.CategoryID == category).Count()
                    //TotalItems = db.Products.Count()
                },
                CurrentCategory = category
            });

        public IActionResult Details(int id)
        {

            return View(db.Products.Where(x => x.ProductID == id).FirstOrDefault());
        }
    }
}