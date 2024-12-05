﻿using BuildingBlocks.Pagination;
namespace OrderingApplication.Orders.Queries.GetOrders
{

    public record GetOrdersQuery(PaginationRequest PaginationRequest)
        : IQuery<GetOrdersResult>;

    public record GetOrdersResult(PaginationResult<OrderDto> Orders);
}