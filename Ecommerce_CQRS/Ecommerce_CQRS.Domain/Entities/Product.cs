namespace Ecommerce_CQRS.Domain.Entities;

public class Product
{
    public Guid Id { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public float DiscountValue { get; set; }
    public int Quantity { get; set; }
    public float Price { get; set; }
    public string Description { get; set; } = string.Empty;
}
