using ProductCatalog.Domain.Entities;

namespace ProductCatalog.Domain.Services;

public class ProductService
{
    public bool IsStockAvailable(Product product, int requestedQuantity) => product.Quantity >= requestedQuantity;
}
