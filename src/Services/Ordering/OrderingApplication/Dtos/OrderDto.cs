using OrderingDomain.Enums;

namespace OrderingApplication.Dtos
{
    public record OrderDto (
        Guid Id,
        Guid CustomerId,
        string OrderName,
        AddressDto ShippingAddress,
        AddressDto BillingAddess,
        PaymentDto Payment,
        OrderStatus Status,
        List<OrderItemDto> OrderItems
    );
}
