using ContosoPets.Api.Models;
using System.Linq;

namespace ContosoPets.Api.Data
{
    public static class SeedData
    {
        public static void Initialize(ContosoPetsContext context)
        {
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product(0, "Squeaky Bone", 20.99m),
                    new Product(0, "Knotted Rope", 12.99m)
                );

                context.SaveChanges();
            }
        }
    }
}