using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class OrderViewModel
    {
        [BindNever]
        public CartViewModel Cart { get; set; }
        [BindNever]
        public int OrderID { get; set; }
        //[BindNever]
        //public ICollection<CartLine> Lines { get; set; }
        
        [Required(ErrorMessage = "Please enter a first name")] 
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter a last name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter the first address line")] 
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        [Required(ErrorMessage = "Please enter a city name")] 
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter a state name")] 
        public string State { get; set; }
        public string Zip { get; set; }
        [Required(ErrorMessage = "Please enter a country name")] 
        public string Country { get; set; }
        public bool GiftWrap { get; set; }
    }
}
