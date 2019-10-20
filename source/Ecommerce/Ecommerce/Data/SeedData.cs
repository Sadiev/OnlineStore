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

                context.Categories.AddRange(
                new Category
                {
                    CategoryName = "Sport"
                },
                new Category
                {
                    CategoryName = "Electronics"
                },
                new Category
                {
                    CategoryName = "Books"
                },
                new Category
                {
                    CategoryName = "Toys"
                },
                new Category
                {
                    CategoryName = "Home Garden"
                }
                );
                context.SaveChanges();
                context.Products.AddRange(
                    new Product
                    {
                        ProductName = "Item1",
                        Description = "This is an online stylish text generator.",
                        CategoryID = 1,
                        Price = 275
                    },
                    new Product
                    {
                        ProductName = "Item2",
                        Description = "This is an online stylish text generator.",
                        CategoryID = 1,
                        Price = 48.95m
                    },
                    new Product
                    {
                        ProductName = "Item3",
                        Description = "This is an online stylish text generator.",
                        CategoryID = 2,
                        Price = 19.50m
                    },
                    new Product
                    {
                        ProductName = "Item4",
                        Description = "This is an online stylish text generator.",
                        CategoryID = 2,
                        Price = 34.95m
                    },
                    new Product
                    {
                        ProductName = "Item5",
                        Description = "This is an online stylish text generator.",
                        CategoryID = 2,
                        Price = 79500
                    },
                    new Product
                    {
                        ProductName = "Item6",
                        Description = "This is an online stylish text generator.",
                        CategoryID = 3,
                        Price = 16
                    },
                    new Product
                    {
                        ProductName = "Item7",
                        Description = "This is an online stylish text generator.",
                        CategoryID = 3,
                        Price = 29.95m
                    },
                    new Product
                    {
                        ProductName = "Item8",
                        Description = "This is an online stylish text generator.",
                        CategoryID = 3,
                        Price = 75
                    },
                    new Product
                    {
                        ProductName = "Item9",
                        Description = "This is an online stylish text generator.",
                        CategoryID = 3,
                        Price = 1200
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
