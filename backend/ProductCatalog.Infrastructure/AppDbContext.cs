using Microsoft.EntityFrameworkCore;
using ProductCatalog.Application.Interfaces;
using ProductCatalog.Domain;
using ProductCatalog.Domain.Entities;

namespace ProductCatalog.Infrastructure;

public class AppDbContext: DbContext, IAppDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    public DbSet<Product> Products { get; set; }

    
}
