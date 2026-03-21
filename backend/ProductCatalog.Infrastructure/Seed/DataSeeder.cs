
using ProductCatalog.Domain.Entities;

namespace ProductCatalog.Infrastructure.Seed;

public static class DataSeeder
{
    public static async Task SeedAsync(AppDbContext context)
    {
        if (!context.Products.Any())
        {
            var products = new List<Product>
            {
                new Product { Id = Guid.NewGuid(), Name = "Product 1", Price = 10.99m, Quantity = 100 },
                new Product { Id = Guid.NewGuid(), Name = "Product 2", Price = 19.99m, Quantity = 50 },
                new Product { Id = Guid.NewGuid(), Name = "Product 3", Price = 5.99m, Quantity = 200 }
            };
            context.Products.AddRange(products);
            await context.SaveChangesAsync();
        }
    }
}