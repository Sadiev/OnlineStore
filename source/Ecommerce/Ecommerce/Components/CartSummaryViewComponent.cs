using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private CartViewModel cart; 
        public CartSummaryViewComponent(CartViewModel cartService) 
        { 
            cart = cartService;
        }
        public IViewComponentResult Invoke() 
        { 
            return View(cart);
        }
    }
}
