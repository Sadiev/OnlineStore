using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Data;
using Ecommerce.Infrastructure;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public class CartController : Controller
    {
        ApplicationDbContext repository;
        private CartViewModel cart;
        public CartController(ApplicationDbContext repo, CartViewModel cartService)
        {
            repository = repo;
            cart = cartService;
        }
        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel {
                Cart = GetCart(),
                ReturnUrl = returnUrl
            });
        }
        public ViewResult Checkout() => View(new OrderViewModel {Cart=GetCart()});

        [HttpPost] 
        public IActionResult Checkout(OrderViewModel order) 
        { 
            if (cart.Lines.Count() == 0) 
            { 
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            } 
            if (ModelState.IsValid) 
            {
                //order.Cart.Lines = cart.Lines.ToArray(); 
                //repository.SaveOrder(order);
                foreach (var item in cart.Lines)
                {
                    repository.Orders.Add(new Order
                    {
                        OrderDate = DateTime.Now,
                        ShipAddress = order.Line1,
                        ProductID = item.Product.ProductID
                    });
                }
                repository.SaveChanges();
                cart.Clear();
                return RedirectToAction("Index", "Home");
            } 
            else 
            { 
                return View(new OrderViewModel { Cart = GetCart()}); 
            } 
        }
        //public ViewResult Completed() 
        //{ 
        //    cart.Clear(); 
        //    return View();
        //}

        public RedirectToActionResult AddToCart(int id, string returnUrl)
        {
            Product product = repository.Products
                .FirstOrDefault(p => p.ProductID == id);

            if (product != null)
            {
                CartViewModel cart = GetCart();
                cart.AddItem(product, 1);
                SaveCart(cart);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToActionResult RemoveFromCart(int productId, string returnUrl)
        {
            Product product = repository.Products
                .FirstOrDefault(p => p.ProductID == productId);

            if (product != null)
            {
                CartViewModel cart = GetCart();
                cart.RemoveLine(product);
                SaveCart(cart);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        private CartViewModel GetCart()
        {
            CartViewModel cart = HttpContext.Session.GetJson<CartViewModel>("Cart") ?? new CartViewModel();
            return cart;
        }

        private void SaveCart(CartViewModel cart)
        {
            HttpContext.Session.SetJson("Cart", cart);
        }

    }
}