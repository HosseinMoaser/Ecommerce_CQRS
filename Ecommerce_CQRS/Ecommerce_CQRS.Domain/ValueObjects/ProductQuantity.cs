namespace Ecommerce_CQRS.Domain.ValueObjects;

public record ProductQuantity
{
    public int Value { get; }
	public ProductQuantity(int value)
	{
		Value = value;
	}

    public static implicit operator int(ProductQuantity quantity) => quantity.Value;
    public static implicit operator ProductQuantity(int quantity) => new(quantity);
}
