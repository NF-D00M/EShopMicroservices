﻿
using BasketApi.Basket.GetBasket;

namespace BasketApi.Basket.DeleteBasket
{
    //public record DeleteBasketRequest(string UserName);
    public record DeleteBasketResponse(bool IsSuccess);
    public class DeleteBasketEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapDelete("/basket/{UserName}", async (string UserName, ISender sender) =>
            {
                var result = await sender.Send(new DeleteBasketCommand(UserName));

                var response = result.Adapt<DeleteBasketResponse>();

                return Results.Ok(response);
            })
            .WithName("DeleteProduct")
            .Produces<GetBasketResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .ProducesProblem(StatusCodes.Status404NotFound)
            .WithSummary("DeleteProduct")
            .WithDescription("DeleteProduct"); ;
        }
    }
}
