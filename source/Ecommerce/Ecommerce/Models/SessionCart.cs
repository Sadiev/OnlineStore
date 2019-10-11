using Ecommerce.Data;
using Ecommerce.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class SessionCart: CartViewModel
    {
        public static CartViewModel GetCart(IServiceProvider services) 
        { 
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            SessionCart cart = session?.GetJson<SessionCart>("Cart") ?? new SessionCart(); 
            cart.Session = session; return cart; 
        }

        [JsonIgnore] 
        public ISession Session { get; set; } 
        public override void AddItem(Product product, int quantity) 
        { 
            base.AddItem(product, quantity); Session.SetJson("Cart", this); 
        }
        public override void RemoveLine(Product product) 
        { 
            base.RemoveLine(product); Session.SetJson("Cart", this);
        } 
        public override void Clear() 
        { 
            base.Clear(); Session.Remove("Cart");
        }
    }
}
