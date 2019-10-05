﻿using System;
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
        public CartController(ApplicationDbContext repo)
        {
            repository = repo;
        }
        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel {
                Cart = GetCart(),
                ReturnUrl = returnUrl
            });
        }
        public IActionResult Checkout()
        {
            return View();
        }

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