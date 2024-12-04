namespace OrderingApplication.Dtos
{
    public record OrderItemDto (
        Guid OrdeId,
        Guid ProductId,
        int Quantity,
        decimal Price
    );
}
