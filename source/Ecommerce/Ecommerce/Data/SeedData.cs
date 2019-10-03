using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))

         
            {
                //Look for any movies.
                if (context.Products.Any())
                    {
                        return;   // DB has been seeded
                    }
                context.Products.AddRange(
                    new Product
                    {
                        ProductName = "Kayak",
                        Description = "A boat for one person",
                        CategoryID = 1,
                        Price = 275
                    },
                    new Product
                    {
                        ProductName = "Lifejacket",
                        Description = "Protective and fashionable",
                        CategoryID = 1,
                        Price = 48.95m
                    },
                    new Product
                    {
                        ProductName = "Soccer Ball",
                        Description = "FIFA-approved size and weight",
                        CategoryID = 2,
                        Price = 19.50m
                    },
                    new Product
                    {
                        ProductName = "Corner Flags",
                        Description = "Give your playing field a professional touch",
                        CategoryID = 2,
                        Price = 34.95m
                    },
                    new Product
                    {
                        ProductName = "Stadium",
                        Description = "Flat-packed 35,000-seat stadium",
                        CategoryID = 2,
                        Price = 79500
                    },
                    new Product
                    {
                        ProductName = "Thinking Cap",
                        Description = "Improve brain efficiency by 75%",
                        CategoryID = 3,
                        Price = 16
                    },
                    new Product
                    {
                        ProductName = "Unsteady Chair",
                        Description = "Secretly give your opponent a disadvantage",
                        CategoryID = 3,
                        Price = 29.95m
                    },
                    new Product
                    {
                        ProductName = "Human Chess Board",
                        Description = "A fun game for the family",
                        CategoryID = 3,
                        Price = 75
                    },
                    new Product
                    {
                        ProductName = "Bling-Bling King",
                        Description = "Gold-plated, diamond-studded King",
                        CategoryID = 3,
                        Price = 1200
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
