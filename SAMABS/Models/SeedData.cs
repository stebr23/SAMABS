using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAMABS.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SAMABSContext(
                serviceProvider.GetRequiredService<DbContextOptions<SAMABSContext>>()))
            {
                if (context.Product.Any())
                {
                    return;
                }

                context.Product.AddRange(
                    new Product
                    {
                        Name = "Test",
                        BrandName = "TestBrand",
                        Category = "TestCat",
                        Description = "This is a test description for the TestBrand Test",
                        Quantity = 10,
                        Price = 14.99m,
                        ImageName = "item.jpg"
                    }
                    );
            }
        }
    }
}
