

using ProductCatalog.Application.Interfaces;

using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ProductCatalog.Application.Queries;

public record ProductListDto (
  Guid Id,
  string Name,
  decimal Price, 
  int Quantity 
);

public record GetAllProductsQuery : IRequest<List<ProductListDto>>;

public class GetAllProductsQueryHandler(IAppDbContext appDbContext) 
    : IRequestHandler<GetAllProductsQuery, List<ProductListDto>>
{
    public async Task<List<ProductListDto>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        //var query =  appDbContext.Products.Select(p => new ProductListDto
        //(
        //    p.Id,
        //    p.Name,
        //    p.Price,
        //    p.Quantity
        //));

        //return await query.ToListAsync();

        return new List<ProductListDto> {
            new ProductListDto (Guid.NewGuid() , "Car", 1000, 1)
              
        };
    }
}
