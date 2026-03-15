using Microsoft.EntityFrameworkCore;
using ProductCatalog.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalog.Application.Interfaces;

public interface IAppDbContext
{
    public DbSet<Product> Products { get; }
}
