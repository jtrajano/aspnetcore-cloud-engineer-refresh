using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Application.Queries;

namespace ProductCatalog.Api;

public static class Endpoints
{
    public static void MapProductEndpoints(this WebApplication app) {

        var product = app.MapGroup("api/products");

        app.MapGet("/", async ([FromServices] ISender sender) =>
        {
            return await sender.Send(new GetAllProductsQuery());

        });
    }
}
