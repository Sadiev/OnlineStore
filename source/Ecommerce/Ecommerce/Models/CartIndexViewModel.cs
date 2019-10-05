using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class CartIndexViewModel
    {
        public CartViewModel Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}
