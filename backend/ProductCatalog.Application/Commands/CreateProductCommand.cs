namespace ProductCatalog.Application.Commands;

public record CreateProductCommand
(
    string Name,
    decimal Price,
    int Quantity
);


